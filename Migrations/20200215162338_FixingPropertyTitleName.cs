using Microsoft.EntityFrameworkCore.Migrations;

namespace SouthStudioBlog.Migrations
{
    public partial class FixingPropertyTitleName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostTiltle",
                table: "Posts");

            migrationBuilder.AddColumn<string>(
                name: "PostTitle",
                table: "Posts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostTitle",
                table: "Posts");

            migrationBuilder.AddColumn<string>(
                name: "PostTiltle",
                table: "Posts",
                type: "text",
                nullable: true);
        }
    }
}
