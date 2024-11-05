using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfoTech.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddingANewItemToSectionsTableInDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Description", "EmptyButtonAction", "EmptyButtonCaption", "FillButtonAction", "FillButtonCaption", "IndexSections", "Tag", "Title" },
                values: new object[] { 2, null, null, null, null, null, 2, null, "برند های که به ما اعتماد کرده اند" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
