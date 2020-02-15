using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SouthStudioBlog.Migrations
{
    public partial class ModifyingDatesNullables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Users_UserIdUser",
                table: "Jobs");

            migrationBuilder.DropForeignKey(
                name: "FK_Studies_Users_UserIdUser",
                table: "Studies");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Studies");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Jobs");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LeavingDate",
                table: "Users",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModificationDate",
                table: "Users",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<int>(
                name: "UserIdUser",
                table: "Studies",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LeavingDate",
                table: "Studies",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModificationDate",
                table: "Studies",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LeavingDate",
                table: "Posts",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModificationDate",
                table: "Posts",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<int>(
                name: "UserIdUser",
                table: "Jobs",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LeavingDate",
                table: "Jobs",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModificationDate",
                table: "Jobs",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "IdJob",
                keyValue: 1,
                columns: new[] { "LastModificationDate", "LeavingDate", "UserIdUser" },
                values: new object[] { null, null, 1 });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "IdJob",
                keyValue: 2,
                columns: new[] { "LastModificationDate", "LeavingDate", "UserIdUser" },
                values: new object[] { null, null, 1 });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "IdJob",
                keyValue: 3,
                columns: new[] { "LastModificationDate", "LeavingDate", "UserIdUser" },
                values: new object[] { null, null, 1 });

            migrationBuilder.UpdateData(
                table: "Studies",
                keyColumn: "IdStudy",
                keyValue: 1,
                columns: new[] { "LastModificationDate", "LeavingDate", "UserIdUser" },
                values: new object[] { null, null, 1 });

            migrationBuilder.UpdateData(
                table: "Studies",
                keyColumn: "IdStudy",
                keyValue: 2,
                columns: new[] { "LastModificationDate", "LeavingDate", "UserIdUser" },
                values: new object[] { null, null, 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "IdUser",
                keyValue: 1,
                columns: new[] { "LastModificationDate", "LeavingDate" },
                values: new object[] { null, null });

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Users_UserIdUser",
                table: "Jobs",
                column: "UserIdUser",
                principalTable: "Users",
                principalColumn: "IdUser",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Studies_Users_UserIdUser",
                table: "Studies",
                column: "UserIdUser",
                principalTable: "Users",
                principalColumn: "IdUser",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Users_UserIdUser",
                table: "Jobs");

            migrationBuilder.DropForeignKey(
                name: "FK_Studies_Users_UserIdUser",
                table: "Studies");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LeavingDate",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModificationDate",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserIdUser",
                table: "Studies",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LeavingDate",
                table: "Studies",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModificationDate",
                table: "Studies",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdUser",
                table: "Studies",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LeavingDate",
                table: "Posts",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModificationDate",
                table: "Posts",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserIdUser",
                table: "Jobs",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LeavingDate",
                table: "Jobs",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModificationDate",
                table: "Jobs",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdUser",
                table: "Jobs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "IdJob",
                keyValue: 1,
                columns: new[] { "IdUser", "LastModificationDate", "LeavingDate", "UserIdUser" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "IdJob",
                keyValue: 2,
                columns: new[] { "IdUser", "LastModificationDate", "LeavingDate", "UserIdUser" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "IdJob",
                keyValue: 3,
                columns: new[] { "IdUser", "LastModificationDate", "LeavingDate", "UserIdUser" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Studies",
                keyColumn: "IdStudy",
                keyValue: 1,
                columns: new[] { "IdUser", "LastModificationDate", "LeavingDate", "UserIdUser" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Studies",
                keyColumn: "IdStudy",
                keyValue: 2,
                columns: new[] { "IdUser", "LastModificationDate", "LeavingDate", "UserIdUser" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "IdUser",
                keyValue: 1,
                columns: new[] { "LastModificationDate", "LeavingDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Users_UserIdUser",
                table: "Jobs",
                column: "UserIdUser",
                principalTable: "Users",
                principalColumn: "IdUser",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Studies_Users_UserIdUser",
                table: "Studies",
                column: "UserIdUser",
                principalTable: "Users",
                principalColumn: "IdUser",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
