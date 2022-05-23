using Microsoft.EntityFrameworkCore.Migrations;

namespace practice.Migrations
{
    public partial class uptadetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "sliders");

            migrationBuilder.AddColumn<string>(
                name: "RedirectUrl",
                table: "sliders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RedirectUrlText",
                table: "sliders",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RedirectUrl",
                table: "sliders");

            migrationBuilder.DropColumn(
                name: "RedirectUrlText",
                table: "sliders");

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "sliders",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
