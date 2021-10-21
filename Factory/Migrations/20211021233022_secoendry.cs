using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class secoendry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "joinDate",
                table: "Engineers",
                newName: "JoinDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "JoinDate",
                table: "Engineers",
                newName: "joinDate");
        }
    }
}
