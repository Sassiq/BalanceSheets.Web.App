using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BalanceSheets.Infrastructure.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Balances_Accounts_AccountId",
                table: "Balances");

            migrationBuilder.DropForeignKey(
                name: "FK_MoneyTurnovers_Accounts_AccountId",
                table: "MoneyTurnovers");

            migrationBuilder.DropIndex(
                name: "IX_MoneyTurnovers_AccountId",
                table: "MoneyTurnovers");

            migrationBuilder.DropIndex(
                name: "IX_Balances_AccountId",
                table: "Balances");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Balances");

            migrationBuilder.AddColumn<int>(
                name: "OpeningBalanceId",
                table: "Accounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TurnoverId",
                table: "Accounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_OpeningBalanceId",
                table: "Accounts",
                column: "OpeningBalanceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_TurnoverId",
                table: "Accounts",
                column: "TurnoverId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Balances_OpeningBalanceId",
                table: "Accounts",
                column: "OpeningBalanceId",
                principalTable: "Balances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_MoneyTurnovers_TurnoverId",
                table: "Accounts",
                column: "TurnoverId",
                principalTable: "MoneyTurnovers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Balances_OpeningBalanceId",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_MoneyTurnovers_TurnoverId",
                table: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_OpeningBalanceId",
                table: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_TurnoverId",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "OpeningBalanceId",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "TurnoverId",
                table: "Accounts");

            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "Balances",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MoneyTurnovers_AccountId",
                table: "MoneyTurnovers",
                column: "AccountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Balances_AccountId",
                table: "Balances",
                column: "AccountId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Balances_Accounts_AccountId",
                table: "Balances",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MoneyTurnovers_Accounts_AccountId",
                table: "MoneyTurnovers",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
