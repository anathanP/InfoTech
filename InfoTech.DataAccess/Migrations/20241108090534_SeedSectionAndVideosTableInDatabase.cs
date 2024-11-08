using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfoTech.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedSectionAndVideosTableInDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Description", "EmptyButtonAction", "EmptyButtonCaption", "FillButtonAction", "FillButtonCaption", "IndexSections", "Tag", "Title" },
                values: new object[] { 5, null, null, null, null, null, 6, "پروژه ها", "پروژه های انجام شده در این شرکت" });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "Id", "Link", "Title" },
                values: new object[] { 2, "https://www.youtube.com/watch?v=Cn4G2lZ_g2I", "َProject Video" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
