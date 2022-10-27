using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BalanceSheets.Infrastructure.Migrations
{
    public partial class completedv1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "MoneyTurnovers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "MoneyTurnovers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
