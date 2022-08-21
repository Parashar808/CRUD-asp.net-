using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hello.Migrations
{
    public partial class Firstone2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Citizenship_number",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Phone_number",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Citizenship_number",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Phone_number",
                table: "Categories");
        }
    }
}
