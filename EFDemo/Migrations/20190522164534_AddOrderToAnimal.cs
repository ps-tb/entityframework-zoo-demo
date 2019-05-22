using Microsoft.EntityFrameworkCore.Migrations;

namespace EFDemo.Migrations
{
    public partial class AddOrderToAnimal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Order",
                table: "Animals",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Order",
                table: "Animals");
        }
    }
}
