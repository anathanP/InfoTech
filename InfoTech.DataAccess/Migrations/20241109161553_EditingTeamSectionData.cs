using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfoTech.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class EditingTeamSectionData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Sections SET FillButtonCaption = 'همه اعضای ما' WHERE Id = 6");
            migrationBuilder.Sql("UPDATE Sections SET FillButtonAction = '/Customer/Home/Teams' WHERE Id = 6");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
