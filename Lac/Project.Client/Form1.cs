using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;    // Tham chiếu Project.Data
using Models;  // Tham chiếu Project.Models

namespace Project.Client
{
    public partial class Form1 : Form
    {
        private readonly BankingService _service;

        public Form1()
        {
            InitializeComponent();
            // Khởi tạo context và service
            var context = new BankingAppData();
            _service = new BankingService(context);
        }

        private async void loginbtn_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ textbox
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Chuyển đổi Username từ string sang long
            if (long.TryParse(username, out long accountId))
            {
                // Gọi service kiểm tra đăng nhập
                var account = await _service.LoginAsync(accountId, password);

                if (account != null)
                {
                    MessageBox.Show("Login successful!");

                    // Kiểm tra loại tài khoản
                    if (account.Account_Type.Equals("Checking", StringComparison.OrdinalIgnoreCase))
                    {
                        // TODO: Mở form chính cho Checking
                        MessageBox.Show("This is a Checking account.");
                        // Example: new MainForm(account).Show(); this.Hide();
                    }
                    else if (account.Account_Type.Equals("Savings", StringComparison.OrdinalIgnoreCase) ||
                             account.Account_Type.Equals("Saving", StringComparison.OrdinalIgnoreCase))
                    {
                        // TODO: Mở form thông tin cho Savings
                        MessageBox.Show(
                            $"Account: {account.Account_ID}\n" +
                            $"Name: {account.Owner_Name}\n" +
                            $"Address: {account.Owner_Address}\n" +
                            $"Phone: {account.Owner_Phone}",
                            "Savings Account Info"
                        );
                        // Example: new SavingsForm(account).Show(); this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Unknown account type.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid account ID or password.");
                }
            }
            else
            {
                MessageBox.Show("Invalid account ID format. Please enter a numeric value.");
            }
        }
    }
}
