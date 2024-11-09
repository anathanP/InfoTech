using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfoTech.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class CreateTeamMembersTableInDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "CompanyMedia",
                table: "SocialMedias",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.Sql("UPDATE SocialMedias SET CompanyMedia = 1 WHERE Id = 1");
            migrationBuilder.Sql("UPDATE SocialMedias SET CompanyMedia = 1 WHERE Id = 2");
            migrationBuilder.Sql("UPDATE SocialMedias SET CompanyMedia = 1 WHERE Id = 3");
            migrationBuilder.Sql("UPDATE SocialMedias SET CompanyMedia = 1 WHERE Id = 4");

            migrationBuilder.AddColumn<int>(
                name: "TeamMemberId",
                table: "SocialMedias",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TeamMembers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Family = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamMembers_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CompanyMedia", "TeamMemberId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CompanyMedia", "TeamMemberId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CompanyMedia", "TeamMemberId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CompanyMedia", "TeamMemberId" },
                values: new object[] { false, null });

            migrationBuilder.CreateIndex(
                name: "IX_SocialMedias_TeamMemberId",
                table: "SocialMedias",
                column: "TeamMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamMembers_ImageId",
                table: "TeamMembers",
                column: "ImageId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SocialMedias_TeamMembers_TeamMemberId",
                table: "SocialMedias",
                column: "TeamMemberId",
                principalTable: "TeamMembers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SocialMedias_TeamMembers_TeamMemberId",
                table: "SocialMedias");

            migrationBuilder.DropTable(
                name: "TeamMembers");

            migrationBuilder.DropIndex(
                name: "IX_SocialMedias_TeamMemberId",
                table: "SocialMedias");

            migrationBuilder.DropColumn(
                name: "CompanyMedia",
                table: "SocialMedias");

            migrationBuilder.DropColumn(
                name: "TeamMemberId",
                table: "SocialMedias");
        }
    }
}
