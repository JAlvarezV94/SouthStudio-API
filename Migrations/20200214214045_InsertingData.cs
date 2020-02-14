using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SouthStudioBlog.Migrations
{
    public partial class InsertingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdUser",
                table: "Studies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdUser",
                table: "Jobs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "IdJob", "IdUser", "JobCompany", "JobDescription", "JobEndDate", "JobPosition", "JobStartDate", "LastModificationDate", "LeavingDate", "UserIdUser" },
                values: new object[,]
                {
                    { 1, 1, "Prodigia Consultores", "Desarrollador de aplicaciones móviles en Android nativo.", new DateTime(2017, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Desarrollador Android", new DateTime(2017, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, 1, "iUrban.es", "Desarrollador de aplicaciones móviles en Android nativo.", new DateTime(2019, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Desarrollador Android", new DateTime(2017, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, 1, "TYM Soluciones", "Desarrollador de aplicaciones web en .Net Framework.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Desarrollador .Net", new DateTime(2019, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Studies",
                columns: new[] { "IdStudy", "IdUser", "LastModificationDate", "LeavingDate", "StudyCenter", "StudyDescription", "StudyEndDate", "StudyStartDate", "StudyTitle", "UserIdUser" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "I.E.S. Belén", "Ciclo formativo de grado medio en administración de sistemas microinformaáticos y redes.", new DateTime(2014, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Técnico en Administración de Sistemas Microinformáticos y Redes", null },
                    { 2, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cenec Málaga", "Ciclo formativo de grado superior en desarrollo de aplicaciones multiplataforma.", new DateTime(2017, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Técnico en Desarrollo de Aplicaciones Multiplataforma", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "IdUser", "LastModificationDate", "LeavingDate", "UserAka", "UserBirthday", "UserDescription", "UserName", "UserSurname" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "JNoma", new DateTime(1994, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pruebecita que te crió!", "Jose", "Álvarez Vivar" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "IdJob",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "IdJob",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "IdJob",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Studies",
                keyColumn: "IdStudy",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Studies",
                keyColumn: "IdStudy",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IdUser",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Studies");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Jobs");
        }
    }
}
