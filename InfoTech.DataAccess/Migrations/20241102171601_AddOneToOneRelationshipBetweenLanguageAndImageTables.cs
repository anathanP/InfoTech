using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfoTech.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddOneToOneRelationshipBetweenLanguageAndImageTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "Languages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Languages_ImageId",
                table: "Languages",
                column: "ImageId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Languages_Images_ImageId",
                table: "Languages",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Languages_Images_ImageId",
                table: "Languages");

            migrationBuilder.DropIndex(
                name: "IX_Languages_ImageId",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Languages");
        }
    }
}
