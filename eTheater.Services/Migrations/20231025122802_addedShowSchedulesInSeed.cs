using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eTheater.Services.Migrations
{
    /// <inheritdoc />
    public partial class addedShowSchedulesInSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShowDateTime",
                table: "ShowSchedule");

            migrationBuilder.AddColumn<DateTime>(
                name: "ShowDate",
                table: "ShowSchedule",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ShowTime",
                table: "ShowSchedule",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Duration",
                table: "Show",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 14, 28, 2, 44, DateTimeKind.Local).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 14, 28, 2, 44, DateTimeKind.Local).AddTicks(4759));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 14, 28, 2, 44, DateTimeKind.Local).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 14, 28, 2, 44, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 14, 28, 2, 44, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 14, 28, 2, 44, DateTimeKind.Local).AddTicks(4769));

            migrationBuilder.InsertData(
                table: "ShowSchedule",
                columns: new[] { "ShowScheduleId", "CreatedAt", "HallId", "IsDeleted", "ModifiedAt", "ShowDate", "ShowId", "ShowTime", "TicketPrice" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 25, 14, 28, 2, 44, DateTimeKind.Local).AddTicks(4826), 1, false, null, new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Local), 1, "20:00", 20 },
                    { 2, new DateTime(2023, 10, 25, 14, 28, 2, 44, DateTimeKind.Local).AddTicks(4832), 2, false, null, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Local), 2, "20:00", 10 },
                    { 3, new DateTime(2023, 10, 25, 14, 28, 2, 44, DateTimeKind.Local).AddTicks(4837), 2, false, null, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Local), 3, "20:00", 20 },
                    { 4, new DateTime(2023, 10, 25, 14, 28, 2, 44, DateTimeKind.Local).AddTicks(4841), 2, false, null, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Local), 4, "18:00", 20 },
                    { 5, new DateTime(2023, 10, 25, 14, 28, 2, 44, DateTimeKind.Local).AddTicks(4845), 2, false, null, new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Local), 5, "18:00", 10 },
                    { 6, new DateTime(2023, 10, 25, 14, 28, 2, 44, DateTimeKind.Local).AddTicks(4849), 2, false, null, new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Local), 6, "18:00", 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "ShowDate",
                table: "ShowSchedule");

            migrationBuilder.DropColumn(
                name: "ShowTime",
                table: "ShowSchedule");

            migrationBuilder.AddColumn<DateTime>(
                name: "ShowDateTime",
                table: "ShowSchedule",
                type: "datetime",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Duration",
                table: "Show",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 11, 54, 46, 989, DateTimeKind.Local).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 11, 54, 46, 989, DateTimeKind.Local).AddTicks(6877));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 11, 54, 46, 989, DateTimeKind.Local).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 11, 54, 46, 989, DateTimeKind.Local).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 11, 54, 46, 989, DateTimeKind.Local).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 11, 54, 46, 989, DateTimeKind.Local).AddTicks(6892));
        }
    }
}
