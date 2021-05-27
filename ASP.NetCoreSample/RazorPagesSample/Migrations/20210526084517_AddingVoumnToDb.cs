using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPagesSample.Migrations
{
    public partial class AddingVoumnToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Volum",
                table: "Book",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Volum",
                table: "Book");
        }
    }
}
