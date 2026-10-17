using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BrightStars.Migrations
{
    /// <inheritdoc />
    public partial class LAST : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Products");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "Rating",
                table: "Products",
                type: "tinyint",
                nullable: true);
        }
    }
}
