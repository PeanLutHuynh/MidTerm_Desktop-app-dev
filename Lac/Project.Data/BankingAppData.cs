using Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;

namespace Data
{
    public class BankingAppData : DbContext
    {
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=BankingAppDB.db");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BankAccount>()
                .HasMany(b => b.Transactions)
                .WithOne(t => t.BankAccount)
                .HasForeignKey(t => t.Account_ID);

            modelBuilder.Entity<BankAccount>().HasData(
                new BankAccount
                {
                    Account_ID = 100001,
                    Owner_Name = "Lac",
                    Owner_Address = "123 Main St, Anytown, USA",
                    Owner_Phone = "555-1234",
                    Balance = 1000.00,
                    Account_Type = "Checking",
                    Password = "password123"
                },
                new BankAccount
                {
                    Account_ID = 100002,
                    Owner_Name = "Gia",
                    Owner_Address = "456 Elm St, Othertown, USA",
                    Owner_Phone = "555-5678",
                    Balance = 2000.00,
                    Account_Type = "Savings",
                    Password = "password456"
                }
            );
        }
    }
    public class BankingService
    {
        private readonly BankingAppData _context;

        public BankingService(BankingAppData context)
        {
            _context = context;
        }

        public async Task<BankAccount> LoginAsync(long accountId, string password)
        {
            var account = await _context.BankAccounts.FirstOrDefaultAsync(a => a.Account_ID == accountId);
            bool success = account != null && account.Password == password;

            await _context.Transactions.AddAsync(new Transaction
            {
                Trans_ID = Guid.NewGuid(),
                Account_ID = accountId,
                Happened_Time = DateTime.Now,
                Action_Desc = "Login",
                Note = success ? "Success" : "Failed"
            });
            await _context.SaveChangesAsync();

            return success ? account : null;
        }

        public async Task<List<Transaction>> GetTransactionsAsync(long accountId)
        {
            await _context.Transactions.AddAsync(new Transaction
            {
                Trans_ID = Guid.NewGuid(),
                Account_ID = accountId,
                Happened_Time = DateTime.Now,
                Action_Desc = "Display Transaction",
                Note = ""
            });
            await _context.SaveChangesAsync();

            return await _context.Transactions
                .Where(t => t.Account_ID == accountId)
                .OrderByDescending(t => t.Happened_Time)
                .ToListAsync();
        }

        public async Task<BankAccount> GetAccountInfoAsync(long accountId)
        {
            await _context.Transactions.AddAsync(new Transaction
            {
                Trans_ID = Guid.NewGuid(),
                Account_ID = accountId,
                Happened_Time = DateTime.Now,
                Action_Desc = "Display Account Info",
                Note = ""
            });
            await _context.SaveChangesAsync();

            return await _context.BankAccounts.FirstOrDefaultAsync(a => a.Account_ID == accountId);
        }

        public async Task<bool> DepositAsync(long accountId, double amount)
        {
            if (amount <= 0) return false;

            var account = await _context.BankAccounts.FirstOrDefaultAsync(a => a.Account_ID == accountId);
            if (account == null) return false;

            account.Balance += amount;

            await _context.Transactions.AddAsync(new Transaction
            {
                Trans_ID = Guid.NewGuid(),
                Account_ID = accountId,
                Happened_Time = DateTime.Now,
                Action_Desc = "Deposit",
                Note = $"Deposit {amount} to account"
            });

            await _context.SaveChangesAsync();
            return true;
        }
    }
}
