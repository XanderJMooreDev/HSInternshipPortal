using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InternshipPortal.Migrations
{
    /// <inheritdoc />
    public partial class Seeding3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "InternshipListings",
                keyColumn: "InternshipListingId",
                keyValue: 1,
                column: "ExtendedDescription",
                value: "This is an extended description of the software engineering internship.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "InternshipListings",
                keyColumn: "InternshipListingId",
                keyValue: 1,
                column: "ExtendedDescription",
                value: null);
        }
    }
}
