using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InfoTech.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class CreateAndSeedBothTablesHeroBannersAndSectionsInDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HeroBanners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageId = table.Column<int>(type: "int", nullable: false),
                    Tag = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    FillButtonCaption = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    EmptyButtonCaption = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    FillButtonAction = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EmptyButtonAction = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroBanners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HeroBanners_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IndexSections = table.Column<int>(type: "int", nullable: false),
                    Tag = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FillButtonCaption = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    EmptyButtonCaption = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    FillButtonAction = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EmptyButtonAction = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Address", "Alt", "Title" },
                values: new object[,]
                {
                    { 4, "hero/hero-2.jpg", "عکس بنر", "عکس بنر" },
                    { 5, "hero/hero-1.jpg", "عکس بنر", "عکس بنر" },
                    { 6, "hero/hero-3.jpg", "عکس بنر", "عکس بنر" }
                });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Description", "EmptyButtonAction", "EmptyButtonCaption", "FillButtonAction", "FillButtonCaption", "IndexSections", "Tag", "Title" },
                values: new object[] { 1, "ما در این موسسه افتخار این را داریم که بگوییم بهترین هستیم و همیشه حق با مشتری است", null, null, "/Customer/Home/About", "درباره ما", 0, "درباره اینفوتک", "بزرگترین شرکت تکنولوژی ایران" });

            migrationBuilder.InsertData(
                table: "HeroBanners",
                columns: new[] { "Id", "Description", "EmptyButtonAction", "EmptyButtonCaption", "FillButtonAction", "FillButtonCaption", "ImageId", "Tag", "Title" },
                values: new object[,]
                {
                    { 1, "آموزش شکلات برنزی و ارتقای عمر محصول را به دنبال خواهد داشت. همه می خواهند تکالیف خود را در دوره انجام دهند، اما اعضای مدرسه به آن نیاز دارند", "/Customer/Home/About", "بیشتر کاوش کنید", "/Customer/Home/Contact", "با ما تماس بگیرید", 4, "بهترین شرکت", "کسب و کار ما را دریافت کنید بهترین راه حل" },
                    { 2, "آموزش شکلات برنزی و ارتقای عمر محصول را به دنبال خواهد داشت. همه می خواهند تکالیف خود را در دوره انجام دهند، اما اعضای مدرسه به آن نیاز دارند", "/Customer/Home/About", "بیشتر کاوش کنید", "/Customer/Home/Contact", "با ما تماس بگیرید", 5, "بهترین شرکت", "کسب و کار ما را دریافت کنید بهترین راه حل" },
                    { 3, "آموزش شکلات برنزی و ارتقای عمر محصول را به دنبال خواهد داشت. همه می خواهند تکالیف خود را در دوره انجام دهند، اما اعضای مدرسه به آن نیاز دارند", "/Customer/Home/About", "بیشتر کاوش کنید", "/Customer/Home/Contact", "با ما تماس بگیرید", 6, "بهترین شرکت", "کسب و کار ما را دریافت کنید بهترین راه حل" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_HeroBanners_ImageId",
                table: "HeroBanners",
                column: "ImageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeroBanners");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
