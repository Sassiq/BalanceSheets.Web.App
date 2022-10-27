using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BalanceSheets.Infrastructure.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FinancialClassId",
                table: "Accounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_FinancialClassId",
                table: "Accounts",
                column: "FinancialClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_FinancialClasses_FinancialClassId",
                table: "Accounts",
                column: "FinancialClassId",
                principalTable: "FinancialClasses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_FinancialClasses_FinancialClassId",
                table: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_FinancialClassId",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "FinancialClassId",
                table: "Accounts");
        }
    }
}
