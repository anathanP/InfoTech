using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InfoTech.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedingPagesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubPage_Pages_PageId",
                table: "SubPage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubPage",
                table: "SubPage");

            migrationBuilder.RenameTable(
                name: "SubPage",
                newName: "SubPages");

            migrationBuilder.RenameIndex(
                name: "IX_SubPage_PageId",
                table: "SubPages",
                newName: "IX_SubPages_PageId");

            migrationBuilder.AlterColumn<string>(
                name: "Action",
                table: "Pages",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubPages",
                table: "SubPages",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Pages",
                columns: new[] { "Id", "Action", "Author", "Description", "Keywords", "Name", "Title" },
                values: new object[,]
                {
                    { 1, "Customer/Home/Index", "Anathan", "صفحه نخست سایت اینفو تک", "Home, info tech, C#", "صفحه اصلی", "Home" },
                    { 2, "Customer/Home/About", "Anathan", "صفحه نخست سایت اینفو تک", "Home, info tech, C#", "درباره", "About Us" },
                    { 3, "Customer/Home/Services", "Anathan", "صفحه نخست سایت اینفو تک", "Home, info tech, C#", "خدمات", "Services" },
                    { 4, "Customer/Home/Pages", "Anathan", "صفحه نخست سایت اینفو تک", "Home, info tech, C#", "صفحات", "Pages" },
                    { 5, "Customer/Home/Blogs", "Anathan", "صفحه نخست سایت اینفو تک", "Home, info tech, C#", "وبلاگ", "Blogs" },
                    { 6, "Customer/Home/Contact", "Anathan", "صفحه نخست سایت اینفو تک", "Home, info tech, C#", "تماس", "Contact" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_SubPages_Pages_PageId",
                table: "SubPages",
                column: "PageId",
                principalTable: "Pages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubPages_Pages_PageId",
                table: "SubPages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubPages",
                table: "SubPages");

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.RenameTable(
                name: "SubPages",
                newName: "SubPage");

            migrationBuilder.RenameIndex(
                name: "IX_SubPages_PageId",
                table: "SubPage",
                newName: "IX_SubPage_PageId");

            migrationBuilder.AlterColumn<string>(
                name: "Action",
                table: "Pages",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubPage",
                table: "SubPage",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubPage_Pages_PageId",
                table: "SubPage",
                column: "PageId",
                principalTable: "Pages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
