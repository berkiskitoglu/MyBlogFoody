using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlogNight.DataAccessLayer.Migrations
{
    public partial class migg1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_TagClouds_TagCloudID",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_TagCloudID",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "TagCloudID",
                table: "Articles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TagCloudID",
                table: "Articles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Articles_TagCloudID",
                table: "Articles",
                column: "TagCloudID");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_TagClouds_TagCloudID",
                table: "Articles",
                column: "TagCloudID",
                principalTable: "TagClouds",
                principalColumn: "TagCloudID");
        }
    }
}
