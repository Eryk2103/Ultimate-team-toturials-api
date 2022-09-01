using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UltimateTeamApi.Data.Migrations
{
    public partial class PlaystationControls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "XboxControlsImgUrl",
                table: "Skills",
                newName: "XboxControls");

            migrationBuilder.RenameColumn(
                name: "VideoUrl",
                table: "Skills",
                newName: "PlaystationControls");

            migrationBuilder.RenameColumn(
                name: "PlaystationControlsImgUrl",
                table: "Skills",
                newName: "Gif");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "XboxControls",
                table: "Skills",
                newName: "XboxControlsImgUrl");

            migrationBuilder.RenameColumn(
                name: "PlaystationControls",
                table: "Skills",
                newName: "VideoUrl");

            migrationBuilder.RenameColumn(
                name: "Gif",
                table: "Skills",
                newName: "PlaystationControlsImgUrl");
        }
    }
}
