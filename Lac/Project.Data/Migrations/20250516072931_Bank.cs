using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class Bank : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BankAccounts",
                columns: table => new
                {
                    Account_ID = table.Column<long>(type: "INTEGER", maxLength: 20, nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Owner_Name = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    Owner_Address = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    Owner_Phone = table.Column<string>(type: "TEXT", maxLength: 13, nullable: false),
                    Balance = table.Column<double>(type: "REAL", nullable: false),
                    Account_Type = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankAccounts", x => x.Account_ID);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Trans_ID = table.Column<Guid>(type: "TEXT", nullable: false),
                    Account_ID = table.Column<long>(type: "INTEGER", maxLength: 20, nullable: false),
                    Happened_Time = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Action_Desc = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Trans_ID);
                    table.ForeignKey(
                        name: "FK_Transactions_BankAccounts_Account_ID",
                        column: x => x.Account_ID,
                        principalTable: "BankAccounts",
                        principalColumn: "Account_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Account_ID", "Account_Type", "Balance", "Owner_Address", "Owner_Name", "Owner_Phone", "Password" },
                values: new object[,]
                {
                    { 100001L, "Checking", 1000.0, "123 Main St, Anytown, USA", "Lac", "555-1234", "password123" },
                    { 100002L, "Savings", 2000.0, "456 Elm St, Othertown, USA", "Gia", "555-5678", "password456" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_Account_ID",
                table: "Transactions",
                column: "Account_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "BankAccounts");
        }
    }
}
