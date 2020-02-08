using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SouthStudioBlog.Migrations
{
    public partial class InitialModelCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    IdUser = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserName = table.Column<string>(nullable: true),
                    UserSurname = table.Column<string>(nullable: true),
                    UserAka = table.Column<string>(nullable: true),
                    UserBirthday = table.Column<DateTime>(nullable: false),
                    UserDescription = table.Column<string>(nullable: true),
                    LastModificationDate = table.Column<DateTime>(nullable: false),
                    LeavingDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.IdUser);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    IdJob = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    JobPosition = table.Column<string>(nullable: true),
                    JobCompany = table.Column<string>(nullable: true),
                    JobDescription = table.Column<string>(nullable: true),
                    JobStartDate = table.Column<DateTime>(nullable: false),
                    JobEndDate = table.Column<DateTime>(nullable: false),
                    LastModificationDate = table.Column<DateTime>(nullable: false),
                    LeavingDate = table.Column<DateTime>(nullable: false),
                    UserIdUser = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.IdJob);
                    table.ForeignKey(
                        name: "FK_Jobs_Users_UserIdUser",
                        column: x => x.UserIdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    IdPost = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PostTiltle = table.Column<string>(nullable: true),
                    PostContent = table.Column<string>(nullable: true),
                    PostImages = table.Column<List<string>>(nullable: true),
                    PostAuthorIdUser = table.Column<int>(nullable: true),
                    PostCreationDate = table.Column<DateTime>(nullable: false),
                    LastModificationDate = table.Column<DateTime>(nullable: false),
                    LeavingDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.IdPost);
                    table.ForeignKey(
                        name: "FK_Posts_Users_PostAuthorIdUser",
                        column: x => x.PostAuthorIdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Studies",
                columns: table => new
                {
                    IdStudy = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StudyTitle = table.Column<string>(nullable: true),
                    StudyStartDate = table.Column<DateTime>(nullable: false),
                    StudyEndDate = table.Column<DateTime>(nullable: false),
                    StudyDescription = table.Column<string>(nullable: true),
                    StudyCenter = table.Column<string>(nullable: true),
                    LastModificationDate = table.Column<DateTime>(nullable: false),
                    LeavingDate = table.Column<DateTime>(nullable: false),
                    UserIdUser = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studies", x => x.IdStudy);
                    table.ForeignKey(
                        name: "FK_Studies_Users_UserIdUser",
                        column: x => x.UserIdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_UserIdUser",
                table: "Jobs",
                column: "UserIdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PostAuthorIdUser",
                table: "Posts",
                column: "PostAuthorIdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Studies_UserIdUser",
                table: "Studies",
                column: "UserIdUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Studies");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
