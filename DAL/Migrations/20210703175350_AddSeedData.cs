using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[,]
                {
                    { 1, 3, "03.07.2021 20:53:49", "03.07.2021 0:00:00", "bestProj", "SergoGagoProj", 1 },
                    { 2, 1, "02.06.2010 0:00:00", "03.07.2021 0:00:00", "bestGavrulo", "GavruloProj", 2 }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SergoAndGago" },
                    { 2, new DateTime(1999, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "GavruloTeam" }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "do", new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "SergoTask", 1, 1, 1 },
                    { 2, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "do", new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "GagoTask", 2, 2, 1 },
                    { 3, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "do", new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "GagoTask", 2, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[,]
                {
                    { 1, new DateTime(2002, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "serhiy2002shev@gmail.com", "Sergo", "Shevchuk", new DateTime(2021, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, new DateTime(1980, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "GagoGagoich@gmail.com", "Gago", "Gagoich", new DateTime(2001, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, new DateTime(2012, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vista@gmail.com", "Gavrulo", "Vista", new DateTime(2019, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
