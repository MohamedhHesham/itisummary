using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BrightStars.Migrations
{
    /// <inheritdoc />
    public partial class addmigrationDToNotes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Products",
                newName: "Notes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Notes",
                table: "Products",
                newName: "Description");
        }
    }
}
