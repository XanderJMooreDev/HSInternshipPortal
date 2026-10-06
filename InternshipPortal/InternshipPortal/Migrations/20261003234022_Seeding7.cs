using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InternshipPortal.Migrations
{
    /// <inheritdoc />
    public partial class Seeding7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Registered",
                table: "UserAccounts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "UserAccounts",
                keyColumn: "UserAccountId",
                keyValue: 1,
                column: "Registered",
                value: false);

            migrationBuilder.UpdateData(
                table: "UserAccounts",
                keyColumn: "UserAccountId",
                keyValue: 2,
                column: "Registered",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Registered",
                table: "UserAccounts");
        }
    }
}
