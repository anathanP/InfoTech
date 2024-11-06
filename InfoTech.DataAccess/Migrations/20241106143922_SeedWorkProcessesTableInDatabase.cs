using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InfoTech.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedWorkProcessesTableInDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "WorkProcesses",
                columns: new[] { "Id", "Description", "DisplayOrder", "ImageId", "Step" },
                values: new object[,]
                {
                    { 1, "در یک ساعت آزاد، زمانی که قدرت انتخاب ما بی بند و بار است و", (byte)1, 18, "یک سرویس را انتخاب کنید" },
                    { 2, "در یک ساعت آزاد، زمانی که قدرت انتخاب ما بی بند و بار است و", (byte)2, 19, "الزامات را تعریف کنید" },
                    { 3, "در یک ساعت آزاد، زمانی که قدرت انتخاب ما بی بند و بار است و", (byte)3, 20, "درخواست یک جلسه" },
                    { 4, "در یک ساعت آزاد، زمانی که قدرت انتخاب ما بی بند و بار است و", (byte)4, 21, "راه حل نهایی 3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WorkProcesses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WorkProcesses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WorkProcesses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WorkProcesses",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
