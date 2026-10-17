using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Horizon.Migrations
{
    /// <inheritdoc />
    public partial class updatingDepartment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Departments",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 30);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Description",
                table: "Departments",
                type: "decimal(18,2)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);
        }
    }
}
