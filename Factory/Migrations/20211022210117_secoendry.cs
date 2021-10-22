using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class secoendry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Operational",
                table: "Machines",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Operational",
                table: "Machines");
        }
    }
}
