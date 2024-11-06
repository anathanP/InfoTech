using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InfoTech.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class CreateAndSeedServicesTableInDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageId = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Services_Images_ImageId",
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
                    { 12, "service/01.jpg", "عکس سرویس", "عکس سرویس" },
                    { 13, "service/02.jpg", "عکس سرویس", "عکس سرویس" },
                    { 14, "service/03.jpg", "عکس سرویس", "عکس سرویس" },
                    { 15, "service/04.jpg", "عکس سرویس", "عکس سرویس" },
                    { 16, "service/05.jpg", "عکس سرویس", "عکس سرویس" }
                });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Description", "EmptyButtonAction", "EmptyButtonCaption", "FillButtonAction", "FillButtonCaption", "IndexSections", "Tag", "Title" },
                values: new object[] { 3, null, null, null, "/Customer/Home/Service", "سرویس ما", 7, "سرویس ها", "فعالیت های ما در این شرکت" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Content", "Description", "ImageId", "Name" },
                values: new object[,]
                {
                    { 1, "", "سرویسی که این شرکت ارایه میدهد", 12, "امنیت سایبری" },
                    { 2, "", "سرویسی که این شرکت ارایه میدهد", 13, "فناوری اطلاعات" },
                    { 3, "", "سرویسی که این شرکت ارایه میدهد", 14, "توسعه برنامه" },
                    { 4, "", "سرویسی که این شرکت ارایه میدهد", 15, "بازاریابی دیجیتال" },
                    { 5, "", "سرویسی که این شرکت ارایه میدهد", 16, "تحلیل داده" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Services_ImageId",
                table: "Services",
                column: "ImageId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
