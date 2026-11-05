using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InternshipPortal.Migrations
{
    /// <inheritdoc />
    public partial class AddTaggedWith : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tags_InternshipListings_InternshipListingId",
                table: "Tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tags",
                table: "Tags");

            migrationBuilder.RenameTable(
                name: "Tags",
                newName: "Tag");

            migrationBuilder.RenameIndex(
                name: "IX_Tags_InternshipListingId",
                table: "Tag",
                newName: "IX_Tag_InternshipListingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tag",
                table: "Tag",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tag_InternshipListings_InternshipListingId",
                table: "Tag",
                column: "InternshipListingId",
                principalTable: "InternshipListings",
                principalColumn: "InternshipListingId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tag_InternshipListings_InternshipListingId",
                table: "Tag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tag",
                table: "Tag");

            migrationBuilder.RenameTable(
                name: "Tag",
                newName: "Tags");

            migrationBuilder.RenameIndex(
                name: "IX_Tag_InternshipListingId",
                table: "Tags",
                newName: "IX_Tags_InternshipListingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tags",
                table: "Tags",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_InternshipListings_InternshipListingId",
                table: "Tags",
                column: "InternshipListingId",
                principalTable: "InternshipListings",
                principalColumn: "InternshipListingId");
        }
    }
}
