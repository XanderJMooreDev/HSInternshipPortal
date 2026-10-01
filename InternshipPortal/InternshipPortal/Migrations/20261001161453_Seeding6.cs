using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InternshipPortal.Migrations
{
    /// <inheritdoc />
    public partial class Seeding6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "UserAccounts",
                keyColumn: "UserAccountId",
                keyValue: 1,
                columns: new[] { "Password", "Username" },
                values: new object[] { "12341234", "student" });

            migrationBuilder.InsertData(
                table: "UserAccounts",
                columns: new[] { "UserAccountId", "Password", "Role", "RoleSpecificId", "Username" },
                values: new object[] { 2, "12341234", "Coordinator", 0, "coord" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserAccounts",
                keyColumn: "UserAccountId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "UserAccounts",
                keyColumn: "UserAccountId",
                keyValue: 1,
                columns: new[] { "Password", "Username" },
                values: new object[] { "password123", "johndoe" });
        }
    }
}
