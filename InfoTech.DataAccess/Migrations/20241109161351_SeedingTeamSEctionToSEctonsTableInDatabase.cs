using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfoTech.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedingTeamSEctionToSEctonsTableInDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Description", "EmptyButtonAction", "EmptyButtonCaption", "FillButtonAction", "FillButtonCaption", "IndexSections", "Tag", "Title" },
                values: new object[] { 6, null, null, null, null, null, 8, "اعضا", "اعضای تیم ما" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
