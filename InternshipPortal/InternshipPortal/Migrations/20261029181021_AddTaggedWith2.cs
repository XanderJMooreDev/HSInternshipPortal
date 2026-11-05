using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InternshipPortal.Migrations
{
    /// <inheritdoc />
    public partial class AddTaggedWith2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tag_InternshipListings_InternshipListingId",
                table: "Tag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tag",
                table: "Tag");

            migrationBuilder.DropIndex(
                name: "IX_Tag_InternshipListingId",
                table: "Tag");

            migrationBuilder.DropColumn(
                name: "InternshipListingId",
                table: "Tag");

            migrationBuilder.RenameTable(
                name: "Tag",
                newName: "Tags");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tags",
                table: "Tags",
                column: "TagId");

            migrationBuilder.CreateTable(
                name: "TaggedWiths",
                columns: table => new
                {
                    TaggedWithId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InternshipListingId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaggedWiths", x => x.TaggedWithId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaggedWiths");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tags",
                table: "Tags");

            migrationBuilder.RenameTable(
                name: "Tags",
                newName: "Tag");

            migrationBuilder.AddColumn<int>(
                name: "InternshipListingId",
                table: "Tag",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tag",
                table: "Tag",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Tag_InternshipListingId",
                table: "Tag",
                column: "InternshipListingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tag_InternshipListings_InternshipListingId",
                table: "Tag",
                column: "InternshipListingId",
                principalTable: "InternshipListings",
                principalColumn: "InternshipListingId");
        }
    }
}
