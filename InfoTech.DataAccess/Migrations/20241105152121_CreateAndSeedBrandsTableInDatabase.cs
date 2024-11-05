using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InfoTech.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class CreateAndSeedBrandsTableInDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_HeroBanners_ImageId",
                table: "HeroBanners");

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ImageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Brands_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Address", "Alt", "Title" },
                values: new object[,]
                {
                    { 8, "brand.png", "عکس برند", "عکس برند" },
                    { 9, "brand.png", "عکس برند", "عکس برند" },
                    { 10, "brand.png", "عکس برند", "عکس برند" },
                    { 11, "brand.png", "عکس برند", "عکس برند" }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "ImageId", "Name" },
                values: new object[,]
                {
                    { 1, 8, "برند نو" },
                    { 2, 9, "برند نو" },
                    { 3, 10, "برند نو" },
                    { 4, 11, "برند نو" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_HeroBanners_ImageId",
                table: "HeroBanners",
                column: "ImageId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Brands_ImageId",
                table: "Brands",
                column: "ImageId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropIndex(
                name: "IX_HeroBanners_ImageId",
                table: "HeroBanners");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.CreateIndex(
                name: "IX_HeroBanners_ImageId",
                table: "HeroBanners",
                column: "ImageId");
        }
    }
}
