using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InfoTech.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedImageIconsOfWorkProcessToImagesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "WorkProcesses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Address", "Alt", "Title" },
                values: new object[,]
                {
                    { 18, "process/01.svg", "عکس پروسه", "عکس پروسه" },
                    { 19, "process/02.svg", "عکس پروسه", "عکس پروسه" },
                    { 20, "process/03.svg", "عکس پروسه", "عکس پروسه" },
                    { 21, "process/04.svg", "عکس پروسه", "عکس پروسه" }
                });
            migrationBuilder.CreateIndex(
                name: "IX_WorkProcesses_ImageId",
                table: "WorkProcesses",
                column: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkProcesses_Images_ImageId",
                table: "WorkProcesses",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkProcesses_Images_ImageId",
                table: "WorkProcesses");

            migrationBuilder.DropIndex(
                name: "IX_WorkProcesses_ImageId",
                table: "WorkProcesses");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "WorkProcesses");
        }
    }
}
