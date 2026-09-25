using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InternshipPortal.Migrations
{
    /// <inheritdoc />
    public partial class Seeding2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "InternshipListings",
                columns: new[] { "InternshipListingId", "Applicants", "Company", "Description", "ExtendedDescription", "Location", "Site", "Title" },
                values: new object[] { 1, 0, "Example Company", "This is a software engineering internship.", null, "New York, NY", "https://www.example.com/internship", "Software Engineering Intern" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InternshipListings",
                keyColumn: "InternshipListingId",
                keyValue: 1);
        }
    }
}
