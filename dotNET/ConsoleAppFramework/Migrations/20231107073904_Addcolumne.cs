using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleAppFramework.Migrations
{
    /// <inheritdoc />
    public partial class Addcolumne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Student",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Student");
        }
    }
}
