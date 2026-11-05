using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InternshipPortal.Migrations
{
    /// <inheritdoc />
    public partial class AddTag2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    TagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InternshipListingId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.TagId);
                    table.ForeignKey(
                        name: "FK_Tags_InternshipListings_InternshipListingId",
                        column: x => x.InternshipListingId,
                        principalTable: "InternshipListings",
                        principalColumn: "InternshipListingId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tags_InternshipListingId",
                table: "Tags",
                column: "InternshipListingId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tags");
        }
    }
}
