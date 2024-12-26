using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlogNight.DataAccessLayer.Migrations
{
    public partial class mig_tagcloud_article : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TagCloudID",
                table: "Articles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_TagClouds_TagCloudID",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_TagCloudID",
                table: "Articles");

            migrationBuilder.AlterColumn<int>(
                name: "TagCloudID",
                table: "Articles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
