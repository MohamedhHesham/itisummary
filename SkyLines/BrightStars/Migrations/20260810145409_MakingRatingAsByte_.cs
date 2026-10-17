using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BrightStars.Migrations
{
    /// <inheritdoc />
    public partial class MakingRatingAsByte_ : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "Rating",
                table: "Products",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);
        }
    }
}
