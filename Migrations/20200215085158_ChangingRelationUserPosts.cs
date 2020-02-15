using Microsoft.EntityFrameworkCore.Migrations;

namespace SouthStudioBlog.Migrations
{
    public partial class ChangingRelationUserPosts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Users_PostAuthorIdUser",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_PostAuthorIdUser",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "PostAuthorIdUser",
                table: "Posts");

            migrationBuilder.AddColumn<int>(
                name: "UserIdUser",
                table: "Posts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserIdUser",
                table: "Posts",
                column: "UserIdUser");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Users_UserIdUser",
                table: "Posts",
                column: "UserIdUser",
                principalTable: "Users",
                principalColumn: "IdUser",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Users_UserIdUser",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_UserIdUser",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "UserIdUser",
                table: "Posts");

            migrationBuilder.AddColumn<int>(
                name: "PostAuthorIdUser",
                table: "Posts",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PostAuthorIdUser",
                table: "Posts",
                column: "PostAuthorIdUser");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Users_PostAuthorIdUser",
                table: "Posts",
                column: "PostAuthorIdUser",
                principalTable: "Users",
                principalColumn: "IdUser",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
