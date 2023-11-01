using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTheater.Services.Migrations
{
    /// <inheritdoc />
    public partial class changeAdminPassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3758ce2e-f243-40b7-98c4-9a71b1c576ed", new DateTime(2023, 11, 1, 17, 35, 31, 526, DateTimeKind.Local).AddTicks(4901), "AQAAAAEAACcQAAAAEOrqpQmyZvpi0xLtZQbkVjY5NxK8Xf5bwWNbMqXlFnaZw6YY9z/PfgPgKAlrIci3YQ==", "8385eea7-3f1c-49da-94e6-ff7ac4a00b2e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9fca9254-41fa-4118-b80f-dbdb887b67bf", new DateTime(2023, 11, 1, 17, 35, 31, 534, DateTimeKind.Local).AddTicks(6753), "AQAAAAEAACcQAAAAEF4SgRrbZ9Flw18cswT0KMJQJn8koD2KlTyGihsEGFgjtatgIXFVVFesJdtMeBG+yw==", "411907db-7f4b-4d86-81c3-fd3f54ec0178" });

            migrationBuilder.UpdateData(
                table: "Hall",
                keyColumn: "HallId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Hall",
                keyColumn: "HallId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8328), new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8335), new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8341), new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8345), new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8351), new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8357), new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TheaterInfo",
                keyColumn: "TheaterInfoId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8428));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8469));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8486));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8496));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8501));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8511));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8528));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8535));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8559));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8616));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8654));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8666));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8672));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8712));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8766));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8843));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8848));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8881));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8885));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8888));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8903));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8911));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8918));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8923));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 199,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 201,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 202,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 203,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 204,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 205,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 206,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 207,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8967));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 208,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 209,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8972));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 210,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 211,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 212,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 213,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 214,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 215,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 216,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8994));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 217,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 218,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 219,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9001));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 220,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 221,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 222,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 223,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9012));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 224,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 225,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 226,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 227,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9022));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 228,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9025));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 229,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 230,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 231,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 232,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 233,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 234,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 235,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 236,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 237,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 238,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9051));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 239,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 240,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9056));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 241,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9058));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 242,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9061));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 243,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 244,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 245,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 246,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 247,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9074));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 248,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 249,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 250,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9082));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 251,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 252,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9086));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 253,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 254,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 255,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 256,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 257,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9098));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 258,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 259,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 260,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 261,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9115));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 262,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9117));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 263,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 264,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 265,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 266,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 267,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 268,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 269,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 270,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 271,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 272,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9143));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 273,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 274,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 275,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 276,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 277,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9155));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 278,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9157));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 279,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 280,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9162));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 281,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 282,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 283,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 284,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9171));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 285,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 286,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 287,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9181));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 288,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 289,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9187));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 290,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9189));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 291,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9193));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 292,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9196));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 293,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9199));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 294,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 295,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9206));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 296,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9209));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 297,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9211));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 298,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 299,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9218));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9221));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 301,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 302,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9225));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 303,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 304,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 305,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 306,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 307,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 308,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9241));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 309,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9244));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 310,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 311,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 312,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 313,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 314,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 315,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 316,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9262));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 317,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 318,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 319,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 320,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9273));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 321,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9275));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 322,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 323,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9282));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 324,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 325,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9287));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 326,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 327,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 328,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 329,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 330,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 331,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9303));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 332,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9311));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 333,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9315));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 334,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9318));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 335,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 336,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 337,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9326));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 338,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9329));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 339,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 340,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9334));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 341,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9336));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 342,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9339));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 343,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 344,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 345,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9346));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 346,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9349));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 347,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9351));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 348,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 349,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 350,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 351,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 352,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 353,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 354,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9373));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 355,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 356,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 357,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 358,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 359,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 360,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 361,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 362,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9392));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 363,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 364,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 365,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 366,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 367,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 368,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 369,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 370,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 371,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9415));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 372,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 373,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 374,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9422));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 375,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9424));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 376,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 377,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9433));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 378,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9436));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 379,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9438));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 380,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 381,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9443));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 382,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9445));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 383,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 384,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 385,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 386,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9455));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 387,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9457));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 388,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 389,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 390,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 391,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 392,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9471));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 393,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 394,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9476));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 395,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9479));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 396,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9482));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 397,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9484));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 398,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9487));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 399,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9489));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 401,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 402,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9497));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 403,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 404,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9502));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 405,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 406,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9514));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 407,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 408,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 409,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 410,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 411,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9527));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 412,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 413,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 414,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9536));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 415,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 416,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 417,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9543));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 418,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 419,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9547));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 420,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 421,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 422,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 423,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 424,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9561));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 425,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 426,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 427,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 428,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 429,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9573));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 430,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 431,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 432,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 433,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 434,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9585));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 435,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 436,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 437,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 438,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 439,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 440,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9601));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 441,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 442,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 443,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9608));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 444,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9611));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 445,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 446,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 447,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9618));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 448,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9621));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 449,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 450,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 451,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 452,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 453,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9635));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 454,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 455,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 456,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9642));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 457,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 458,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9647));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 459,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9649));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 460,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9651));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 461,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9654));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 462,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9656));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 463,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 464,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9661));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 465,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9663));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 466,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9666));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 467,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9669));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 468,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9671));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 469,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9674));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 470,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 471,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 472,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 473,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9683));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 474,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9686));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 475,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 476,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 477,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9693));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 478,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 479,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 480,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 481,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9708));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 482,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 483,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 484,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9717));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 485,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9719));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 486,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9721));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 487,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9724));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 488,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9726));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 489,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9729));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 490,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9731));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 491,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9733));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 492,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9736));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 493,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9738));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 494,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9741));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 495,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9743));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 496,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9745));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 497,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9749));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 498,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 499,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9754));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9756));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 501,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9758));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 502,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 503,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9859));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 504,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9861));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 505,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9864));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 506,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9866));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 507,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9868));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 508,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9871));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 509,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9873));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 510,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9876));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 511,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 512,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9882));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 513,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 514,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9887));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 515,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9889));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 516,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 517,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9894));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 518,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9896));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 519,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 520,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9901));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 521,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 522,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 523,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9908));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 524,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9911));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 525,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9913));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 526,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9916));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 527,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9919));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 528,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9921));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 529,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 530,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 531,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 532,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9931));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 533,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9933));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 534,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 535,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9938));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 536,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 537,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 538,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9945));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 539,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 540,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 541,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 542,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9956));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 543,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9958));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 544,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9961));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 545,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 546,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9965));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 547,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 548,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 549,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 550,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9975));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 551,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9984));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 552,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9988));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 553,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 554,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9993));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 555,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9995));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 556,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 542, DateTimeKind.Local).AddTicks(9999));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 557,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 558,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 559,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(6));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 560,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(8));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 561,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(11));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 562,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(13));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 563,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(16));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 564,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(18));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 565,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(21));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 566,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(23));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 567,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(25));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 568,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(28));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 569,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 570,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(33));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 571,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(36));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 572,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 573,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(41));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 574,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 575,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(46));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 576,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(48));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 577,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 578,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(53));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 579,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(55));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 580,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(58));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 581,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 582,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(63));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 583,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(65));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 584,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(67));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 585,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(70));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 586,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(73));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 587,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(76));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 588,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(78));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 589,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(80));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 590,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(83));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 591,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(85));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 592,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(88));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 593,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(90));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 594,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 595,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(95));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 596,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 597,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 598,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 599,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(104));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(107));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 601,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 602,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(113));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 603,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(115));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 604,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(117));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 605,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 606,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(123));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 607,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(125));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 608,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 609,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(130));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 610,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(132));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 611,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(134));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 612,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(137));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 613,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(139));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 614,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(142));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 615,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(144));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 616,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(148));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 617,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 618,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(153));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 619,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(155));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 620,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(157));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 621,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 622,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 623,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(165));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 624,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 625,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(175));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 626,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(177));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 627,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 628,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(182));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 629,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(184));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 630,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(187));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 631,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(194));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 632,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(196));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 633,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(198));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 634,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(201));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 635,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 636,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(206));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 637,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 638,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(211));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 639,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(213));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 640,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 641,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(218));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 642,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 643,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(223));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 644,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(225));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 645,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 646,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 647,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(232));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 648,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(235));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 649,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(237));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 650,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 1, 17, 35, 31, 543, DateTimeKind.Local).AddTicks(240));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b63567c3-e679-461e-9edc-9d68928cf853", new DateTime(2023, 10, 31, 16, 41, 21, 673, DateTimeKind.Local).AddTicks(3773), "AQAAAAEAACcQAAAAELM31qUwNRL7kiJWJLIreZi4PreEpvVDXR9/46oBX7EBNfADDp6rM0QB1DTVdoXEBg==", "b1795b15-28a3-4733-86f2-cb1730fd9de1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb74f987-c6b4-4615-ad8e-ce7a5a548ee9", new DateTime(2023, 10, 31, 16, 41, 21, 679, DateTimeKind.Local).AddTicks(8207), "AQAAAAEAACcQAAAAEMXOVNnwCsxU+RVNtrDB+p30eB3D7zeV6ViTpkH8M5W3BqGIGQcduGFPZMwOT9WnvQ==", "7a32c264-496d-4b6b-ba06-0ae8609d6e14" });

            migrationBuilder.UpdateData(
                table: "Hall",
                keyColumn: "HallId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Hall",
                keyColumn: "HallId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6138));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6145));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6148));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6153));

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6190), new DateTime(2023, 10, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6195), new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6200), new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6204), new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6207), new DateTime(2023, 10, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6211), new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TheaterInfo",
                keyColumn: "TheaterInfoId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6262));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6276));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6288));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6293));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6297));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6307));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6323));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6326));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6328));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6329));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6331));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6333));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6335));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6339));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6341));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6345));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6349));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6357));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6359));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6363));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6377));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6416));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6424));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6428));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6434));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6471));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6474));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6477));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6479));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6481));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6491));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6492));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6494));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6496));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6505));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6518));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6536));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6547));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6551));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6565));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6606));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6608));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6612));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6619));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6621));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6623));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6626));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6628));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6639));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6641));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6647));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6651));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 199,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6657));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 201,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 202,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 203,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 204,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 205,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 206,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 207,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 208,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 209,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 210,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 211,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 212,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 213,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 214,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 215,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 216,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6689));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 217,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 218,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 219,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 220,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 221,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 222,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 223,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 224,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 225,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 226,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 227,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 228,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 229,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 230,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 231,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 232,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 233,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 234,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 235,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 236,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 237,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 238,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 239,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 240,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 241,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 242,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 243,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 244,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 245,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 246,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 247,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 248,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 249,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 250,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6761));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 251,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 252,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 253,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 254,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6769));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 255,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6771));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 256,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 257,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 258,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 259,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 260,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6782));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 261,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 262,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 263,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 264,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6789));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 265,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6791));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 266,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 267,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6795));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 268,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 269,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 270,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 271,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 272,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 273,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 274,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 275,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6811));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 276,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6813));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 277,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 278,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6817));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 279,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6819));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 280,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 281,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 282,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 283,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 284,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6829));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 285,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 286,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6832));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 287,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 288,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6837));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 289,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 290,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 291,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 292,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 293,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 294,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 295,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 296,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 297,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 298,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 299,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 301,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 302,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 303,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 304,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 305,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 306,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6877));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 307,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 308,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 309,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 310,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 311,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 312,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 313,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 314,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 315,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 316,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 317,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 318,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 319,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 320,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 321,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 322,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 323,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 324,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 325,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 326,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 327,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 328,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 329,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 330,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6924));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 331,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 332,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 333,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 334,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6932));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 335,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 336,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 337,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 338,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 339,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6942));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 340,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 341,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 342,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6947));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 343,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 344,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 345,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 346,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 347,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 348,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 349,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 350,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 351,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6965));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 352,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 353,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 354,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 355,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 356,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6975));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 357,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 358,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6979));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 359,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 360,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6983));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 361,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 362,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6986));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 363,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6989));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 364,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 365,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 366,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 367,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 368,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 369,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 370,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 371,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 372,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 373,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 374,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 375,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 376,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 377,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 378,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 379,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 380,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7027));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 381,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 382,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 383,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 384,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 385,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 386,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 387,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 388,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 389,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 390,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 391,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 392,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 393,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 394,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 395,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 396,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 397,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 398,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 399,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 401,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 402,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 403,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7071));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 404,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 405,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 406,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 407,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 408,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 409,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 410,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7085));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 411,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 412,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 413,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 414,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 415,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 416,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 417,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 418,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 419,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 420,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 421,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7105));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 422,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 423,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 424,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 425,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 426,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 427,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 428,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 429,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 430,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 431,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 432,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 433,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 434,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 435,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7133));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 436,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 437,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 438,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 439,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 440,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 441,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 442,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 443,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 444,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 445,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 446,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 447,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 448,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 449,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7164));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 450,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 451,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 452,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7171));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 453,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 454,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 455,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 456,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7179));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 457,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 458,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 459,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 460,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 461,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7188));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 462,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 463,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 464,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7194));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 465,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 466,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 467,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 468,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 469,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 470,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 471,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 472,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7212));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 473,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 474,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 475,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 476,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 477,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 478,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 479,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 480,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 481,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 482,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 483,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 484,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 485,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7237));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 486,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7239));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 487,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 488,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 489,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7245));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 490,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7247));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 491,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 492,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 493,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7252));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 494,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 495,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 496,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 497,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 498,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 499,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 501,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 502,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7272));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 503,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7274));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 504,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 505,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 506,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 507,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 508,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 509,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 510,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7287));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 511,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7289));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 512,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 513,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 514,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 515,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 516,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 517,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7302));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 518,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7304));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 519,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 520,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 521,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7314));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 522,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 523,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7318));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 524,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 525,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7322));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 526,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 527,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 528,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 529,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 530,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7332));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 531,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 532,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 533,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 534,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 535,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 536,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 537,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 538,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 539,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 540,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 541,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 542,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 543,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 544,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 545,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 546,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 547,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 548,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 549,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 550,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 551,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 552,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7375));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 553,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7377));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 554,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7379));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 555,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 556,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 557,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 558,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 559,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 560,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7392));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 561,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 562,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7396));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 563,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 564,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 565,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7401));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 566,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 567,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 568,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7407));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 569,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7409));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 570,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7411));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 571,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 572,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7416));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 573,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7418));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 574,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 575,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7421));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 576,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 577,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7425));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 578,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 579,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 580,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 581,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 582,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7435));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 583,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7437));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 584,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7439));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 585,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 586,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7444));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 587,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7446));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 588,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 589,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 590,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 591,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7454));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 592,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 593,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 594,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 595,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 596,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 597,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 598,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 599,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7475));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 601,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7479));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 602,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 603,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 604,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7485));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 605,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7487));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 606,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7489));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 607,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 608,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 609,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7495));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 610,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 611,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7499));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 612,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 613,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7503));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 614,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7505));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 615,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 616,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7509));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 617,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 618,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 619,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7515));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 620,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 621,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7518));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 622,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 623,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 624,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7524));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 625,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7526));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 626,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 627,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 628,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7532));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 629,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 630,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 631,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 632,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 633,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 634,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 635,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 636,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 637,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 638,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 639,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 640,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 641,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7557));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 642,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 643,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 644,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 645,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 646,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 647,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 648,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 649,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7572));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 650,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7574));
        }
    }
}
