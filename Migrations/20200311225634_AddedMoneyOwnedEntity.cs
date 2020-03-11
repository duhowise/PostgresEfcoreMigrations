using Microsoft.EntityFrameworkCore.Migrations;

namespace PostgresApi.Migrations
{
    public partial class AddedMoneyOwnedEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Balance_Amount",
                table: "Accounts",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Balance_CurrencyCode",
                table: "Accounts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Balance_Amount",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "Balance_CurrencyCode",
                table: "Accounts");
        }
    }
}
