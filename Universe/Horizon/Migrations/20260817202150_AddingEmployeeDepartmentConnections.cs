using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Horizon.Migrations
{
    /// <inheritdoc />
    public partial class AddingEmployeeDepartmentConnections : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Employees");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Country", "FullName", "NationalId", "Position", "Salary" },
                values: new object[,]
                {
                    { 1, "Egypt", "Osama Ahmed Hassan", "11122233344455", "Developer", 17500m },
                    { 2, "Kuwait", "Wael Ali Omar", "10002000300044", "Tester", 12500m },
                    { 3, "Egypt", "Bahaa Hussain Othman", "10120230340455", "Senior Developer", 23500m },
                    { 4, "Oman", "Ayman Saad Mostafa", "10020030040066", "Senior Tester", 19300m },
                    { 5, "Egypt", "Hossam Ali Mamdouh", "50060070080099", "Junior Developer", 15250m }
                });
        }
    }
}
