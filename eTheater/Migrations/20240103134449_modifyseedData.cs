using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTheater.Migrations
{
    /// <inheritdoc />
    public partial class modifyseedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9651));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9654));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9656));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f77d71a3-1777-48e8-8872-6f19abd5d40f", new DateTime(2024, 1, 3, 14, 44, 48, 531, DateTimeKind.Local).AddTicks(5356), "AQAAAAEAACcQAAAAEDqFeNNxvIrZVd2pv4FkTCK9TTs/ixw3r8S4yHteIRMvEA3WLZ3v5WhwqOneqdak8A==", "e2f966ef-2cc2-40e0-a65c-82fd6c3b7532" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6be49a16-c1a9-4362-a169-00a3e8b0455f", new DateTime(2024, 1, 3, 14, 44, 48, 537, DateTimeKind.Local).AddTicks(6917), "AQAAAAEAACcQAAAAEFMsJTMuTn76efs1VyOjIHrmiDzqzASmtkjso5zjaKQHwiP4zFMqMJvXL9uPFIsNHQ==", "7f5ec6f6-31e6-4583-9f52-9e71fc3fd75d" });

            migrationBuilder.UpdateData(
                table: "Hall",
                keyColumn: "HallId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Hall",
                keyColumn: "HallId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "PurchaseId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1255));

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "PurchaseId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "PurchaseId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "PurchaseId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1265));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9671));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9683));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9686));

            migrationBuilder.UpdateData(
                table: "ShowActors",
                keyColumn: "ShowActorId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "ShowActors",
                keyColumn: "ShowActorId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "ShowActors",
                keyColumn: "ShowActorId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "ShowActors",
                keyColumn: "ShowActorId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9708));

            migrationBuilder.UpdateData(
                table: "ShowActors",
                keyColumn: "ShowActorId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "ShowActors",
                keyColumn: "ShowActorId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "ShowActors",
                keyColumn: "ShowActorId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ShowDate", "ShowTime" },
                values: new object[] { new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9729), new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Local), "20:00-22:00" });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ShowDate", "ShowTime" },
                values: new object[] { new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9733), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), "20:00-22:00" });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ShowDate", "ShowTime" },
                values: new object[] { new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9738), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), "20:00-22:00" });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ShowDate", "ShowTime" },
                values: new object[] { new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9741), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), "18:00-20:00" });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ShowDate", "ShowTime" },
                values: new object[] { new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9745), new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Local), "18:00-20:00" });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ShowDate", "ShowTime" },
                values: new object[] { new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9748), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), "18:00-20:00" });

            migrationBuilder.UpdateData(
                table: "TheaterInfo",
                keyColumn: "TheaterInfoId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9764));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9795));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9797));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9798));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9806));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9808));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9809));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9811));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9813));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9815));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9819));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9821));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9823));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9825));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9829));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9832));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9837));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9838));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9846));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9849));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9859));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9861));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9863));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9865));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9866));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9868));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9872));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9874));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9876));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9877));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9879));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9881));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9883));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9885));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9887));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9889));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9893));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9895));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9901));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9912));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9914));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9915));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9929));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9931));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9933));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9935));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9941));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9945));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9946));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9959));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9962));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9964));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9966));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9972));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9975));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9978));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9982));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9983));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9985));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9988));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9996));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 543, DateTimeKind.Local).AddTicks(9999));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(3));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(8));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(11));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(13));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(15));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(17));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(19));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(22));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(24));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(26));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(28));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(33));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(35));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(37));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(42));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(44));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(45));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(49));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(53));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(55));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(56));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(58));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(62));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(65));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(66));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(68));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(70));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(72));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(74));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(76));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(77));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(79));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(81));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(83));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(85));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(87));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(89));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(90));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(95));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(103));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(107));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(108));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(112));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(114));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(117));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(119));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(121));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(123));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(131));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(135));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(142));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(144));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(146));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(148));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(152));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(153));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(155));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(157));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(161));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(166));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(172));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(174));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(176));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(177));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(179));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(181));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(188));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 199,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(191));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(193));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 201,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(195));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 202,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(197));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 203,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 204,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(202));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 205,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(204));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 206,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(206));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 207,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(210));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 208,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 209,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(214));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 210,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 211,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(217));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 212,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 213,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(222));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 214,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(224));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 215,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(226));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 216,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 217,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 218,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 219,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(233));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 220,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(235));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 221,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(237));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 222,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(238));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 223,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 224,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 225,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(244));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 226,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 227,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 228,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 229,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(252));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 230,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(254));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 231,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(256));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 232,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(258));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 233,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(260));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 234,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(262));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 235,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(264));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 236,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 237,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 238,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(269));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 239,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(271));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 240,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(273));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 241,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(276));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 242,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(278));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 243,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 244,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(281));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 245,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(283));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 246,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(285));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 247,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(287));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 248,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 249,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 250,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(298));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 251,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(299));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 252,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(301));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 253,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(303));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 254,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(305));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 255,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(307));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 256,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 257,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 258,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(313));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 259,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(315));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 260,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 261,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 262,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(321));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 263,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(322));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 264,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(324));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 265,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(326));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 266,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(328));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 267,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(330));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 268,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(332));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 269,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(334));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 270,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 271,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(337));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 272,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(339));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 273,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(342));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 274,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(344));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 275,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 276,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 277,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(349));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 278,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(351));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 279,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(353));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 280,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 281,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(357));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 282,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(359));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 283,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 284,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(363));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 285,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(365));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 286,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(367));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 287,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(369));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 288,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(372));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 289,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(373));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 290,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 291,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 292,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(379));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 293,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 294,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 295,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(384));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 296,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 297,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(388));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 298,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 299,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(392));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(395));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 301,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 302,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 303,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 304,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 305,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(405));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 306,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(407));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 307,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 308,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 309,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(414));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 310,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 311,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 312,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 313,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 314,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 315,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 316,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 317,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(432));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 318,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 319,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 320,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 321,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 322,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 323,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 324,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(454));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 325,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(456));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 326,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 327,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 328,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(462));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 329,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(465));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 330,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 331,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 332,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 333,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(472));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 334,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 335,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(476));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 336,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(478));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 337,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 338,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 339,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 340,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 341,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 342,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 343,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 344,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(494));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 345,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 346,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 347,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 348,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 349,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 350,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 351,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 352,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 353,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(511));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 354,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 355,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(515));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 356,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(517));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 357,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(519));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 358,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 359,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 360,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(525));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 361,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 362,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 363,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(532));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 364,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 365,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 366,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 367,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 368,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 369,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 370,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(545));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 371,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 372,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(548));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 373,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 374,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 375,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 376,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 377,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 378,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 379,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(564));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 380,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(566));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 381,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 382,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(571));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 383,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 384,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 385,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 386,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 387,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(581));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 388,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 389,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 390,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(587));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 391,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 392,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(592));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 393,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 394,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 395,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 396,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(605));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 397,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(607));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 398,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 399,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(611));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(613));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 401,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 402,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(617));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 403,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 404,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 405,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(622));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 406,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 407,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(627));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 408,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(629));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 409,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(631));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 410,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(633));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 411,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(634));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 412,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 413,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(638));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 414,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 415,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(642));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 416,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(644));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 417,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(646));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 418,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(647));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 419,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 420,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 421,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 422,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(656));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 423,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(658));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 424,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 425,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 426,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 427,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 428,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 429,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 430,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 431,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 432,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 433,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 434,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 435,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 436,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 437,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 438,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 439,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(689));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 440,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 441,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 442,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(694));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 443,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 444,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(698));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 445,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(701));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 446,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 447,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 448,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 449,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(709));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 450,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 451,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 452,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 453,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 454,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 455,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 456,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 457,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 458,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(733));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 459,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 460,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 461,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 462,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(741));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 463,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 464,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 465,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 466,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(754));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 467,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 468,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 469,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 470,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 471,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 472,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(766));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 473,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 474,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 475,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 476,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 477,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(775));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 478,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 479,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(779));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 480,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 481,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 482,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 483,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 484,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(789));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 485,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 486,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 487,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(795));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 488,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 489,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 490,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 491,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 492,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 493,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 494,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 495,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 496,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(812));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 497,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 498,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 499,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(817));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(819));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 501,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 502,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 503,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 504,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(827));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 505,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 506,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 507,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 508,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(835));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 509,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 510,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 511,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(841));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 512,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 513,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 514,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 515,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(848));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 516,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 517,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 518,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 519,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 520,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 521,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 522,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 523,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 524,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 525,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(867));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 526,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 527,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 528,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 529,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 530,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 531,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 532,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(881));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 533,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 534,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(884));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 535,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 536,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(888));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 537,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 538,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(892));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 539,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(898));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 540,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 541,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(906));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 542,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 543,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 544,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 545,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 546,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 547,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 548,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 549,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 550,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(922));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 551,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 552,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 553,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 554,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 555,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 556,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(935));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 557,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(936));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 558,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(938));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 559,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 560,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 561,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(944));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 562,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(946));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 563,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 564,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 565,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(951));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 566,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(953));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 567,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(955));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 568,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(957));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 569,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(959));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 570,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(961));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 571,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(963));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 572,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 573,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(967));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 574,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 575,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(971));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 576,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 577,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(975));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 578,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(977));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 579,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 580,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(981));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 581,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 582,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(985));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 583,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(987));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 584,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 585,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 586,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(993));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 587,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 588,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 589,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 590,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 591,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1003));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 592,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1005));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 593,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 594,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1008));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 595,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 596,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 597,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 598,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 599,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 601,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 602,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 603,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 604,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1027));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 605,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1029));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 606,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1031));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 607,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1033));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 608,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1035));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 609,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 610,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1039));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 611,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 612,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1047));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 613,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 614,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1051));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 615,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 616,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 617,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 618,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 619,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1061));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 620,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 621,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 622,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 623,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 624,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 625,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1072));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 626,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1074));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 627,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1076));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 628,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1078));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 629,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 630,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1082));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 631,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1084));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 632,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1086));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 633,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1087));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 634,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 635,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 636,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1093));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 637,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 638,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1097));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 639,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 640,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 641,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1102));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 642,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1104));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 643,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1106));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 644,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1108));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 645,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 646,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 647,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 648,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1115));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 649,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 650,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 14, 44, 48, 544, DateTimeKind.Local).AddTicks(1119));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5492));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3507ffe-31a2-4e05-8da6-beafdb17baab", new DateTime(2024, 1, 2, 18, 12, 46, 768, DateTimeKind.Local).AddTicks(7219), "AQAAAAEAACcQAAAAEBaCtDtlapMdDfOHalMIrRb2HD5fNAVYUrZckBI2PrGa3Mk1e09Pwh6Lh5jkYJKmWA==", "eca55f25-302c-4d34-913a-a66d4ac05eb7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8fdf3240-fdfb-45bf-bbbe-a8fdc8b8faf8", new DateTime(2024, 1, 2, 18, 12, 46, 775, DateTimeKind.Local).AddTicks(4508), "AQAAAAEAACcQAAAAEG35QkCoJ9/HGwR247JNs2N5uA/tIcKeXEN3gg/vF4sliR1UiADlJqnP2W8dp5UvAA==", "45d60b09-77a4-45a7-abbe-9c1fd774a87d" });

            migrationBuilder.UpdateData(
                table: "Hall",
                keyColumn: "HallId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Hall",
                keyColumn: "HallId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "PurchaseId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "PurchaseId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "PurchaseId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "PurchaseId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5514));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5518));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "ShowActors",
                keyColumn: "ShowActorId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "ShowActors",
                keyColumn: "ShowActorId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "ShowActors",
                keyColumn: "ShowActorId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5554));

            migrationBuilder.UpdateData(
                table: "ShowActors",
                keyColumn: "ShowActorId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5556));

            migrationBuilder.UpdateData(
                table: "ShowActors",
                keyColumn: "ShowActorId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "ShowActors",
                keyColumn: "ShowActorId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "ShowActors",
                keyColumn: "ShowActorId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ShowDate", "ShowTime" },
                values: new object[] { new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5586), new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), "20:00" });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ShowDate", "ShowTime" },
                values: new object[] { new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5591), new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), "20:00" });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ShowDate", "ShowTime" },
                values: new object[] { new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5595), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), "20:00" });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ShowDate", "ShowTime" },
                values: new object[] { new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5600), new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), "18:00" });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ShowDate", "ShowTime" },
                values: new object[] { new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5603), new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), "18:00" });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ShowDate", "ShowTime" },
                values: new object[] { new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5607), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), "18:00" });

            migrationBuilder.UpdateData(
                table: "TheaterInfo",
                keyColumn: "TheaterInfoId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5629));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5661));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5666));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5674));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5679));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5688));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5697));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5699));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5702));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5704));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5706));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5708));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5712));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5716));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5717));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5721));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5733));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5739));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5744));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5748));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5755));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5756));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5762));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5766));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5778));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5781));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5783));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5785));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5792));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5796));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5797));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5802));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5806));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5813));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5815));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5819));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5826));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5832));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5834));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5836));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5838));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5839));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5841));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5854));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5856));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5859));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5861));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5863));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5865));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5867));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5877));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5881));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5883));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5885));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5886));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5888));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5892));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5896));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5902));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5904));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5908));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5915));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5916));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5918));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5926));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5927));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5929));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5931));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5933));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5935));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5937));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5939));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5942));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5944));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5945));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5947));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5949));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5954));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5957));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5959));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5967));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5969));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5972));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5973));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5976));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5978));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5989));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5993));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5995));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6005));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6009));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6013));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6017));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6022));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6024));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6026));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6028));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6030));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6034));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6038));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6047));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6049));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6059));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 199,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 201,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6064));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 202,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6066));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 203,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 204,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 205,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6075));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 206,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6077));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 207,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 208,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 209,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 210,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 211,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 212,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 213,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 214,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6093));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 215,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 216,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 217,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 218,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 219,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 220,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 221,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6181));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 222,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 223,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 224,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 225,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6189));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 226,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 227,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 228,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 229,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6198));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 230,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 231,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 232,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 233,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 234,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6207));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 235,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 236,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 237,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 238,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6216));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 239,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 240,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 241,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 242,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6225));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 243,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6227));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 244,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6228));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 245,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 246,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 247,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6235));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 248,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 249,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 250,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 251,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 252,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 253,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 254,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 255,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 256,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 257,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 258,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 259,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 260,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 261,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 262,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 263,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 264,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 265,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 266,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 267,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 268,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6276));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 269,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6277));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 270,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 271,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 272,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 273,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 274,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6288));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 275,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 276,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6297));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 277,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 278,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 279,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6302));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 280,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 281,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 282,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 283,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 284,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 285,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 286,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 287,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 288,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 289,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6324));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 290,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6326));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 291,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6327));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 292,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6329));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 293,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6332));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 294,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6334));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 295,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6336));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 296,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6338));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 297,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6340));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 298,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6341));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 299,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6345));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 301,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 302,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6349));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 303,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 304,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 305,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6356));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 306,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6358));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 307,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 308,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6363));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 309,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 310,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 311,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 312,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 313,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 314,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 315,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 316,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 317,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 318,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 319,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 320,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6388));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 321,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 322,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 323,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 324,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 325,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 326,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 327,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 328,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 329,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 330,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 331,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 332,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 333,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6415));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 334,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 335,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6419));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 336,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 337,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 338,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 339,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 340,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6429));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 341,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 342,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 343,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6434));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 344,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 345,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 346,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 347,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 348,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 349,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 350,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 351,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 352,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 353,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 354,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6463));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 355,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 356,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 357,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 358,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6471));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 359,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 360,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 361,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6477));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 362,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6479));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 363,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6481));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 364,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6483));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 365,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 366,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 367,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 368,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6491));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 369,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 370,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 371,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 372,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 373,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6501));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 374,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6503));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 375,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6505));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 376,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 377,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 378,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 379,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 380,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6515));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 381,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 382,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 383,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 384,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 385,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 386,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 387,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 388,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 389,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 390,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6535));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 391,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6537));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 392,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 393,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6543));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 394,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 395,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 396,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 397,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6551));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 398,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 399,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 401,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 402,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6562));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 403,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 404,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6565));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 405,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 406,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 407,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6572));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 408,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 409,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 410,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 411,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 412,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 413,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 414,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 415,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 416,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 417,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 418,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 419,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 420,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 421,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 422,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6605));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 423,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 424,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 425,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 426,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 427,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 428,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 429,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6619));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 430,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 431,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6622));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 432,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 433,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6626));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 434,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6628));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 435,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 436,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 437,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6636));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 438,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 439,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 440,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6642));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 441,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6644));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 442,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 443,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6648));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 444,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 445,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6651));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 446,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 447,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 448,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6658));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 449,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 450,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 451,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 452,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 453,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 454,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 455,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 456,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 457,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 458,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 459,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 460,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 461,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 462,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 463,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6689));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 464,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 465,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 466,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 467,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 468,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 469,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 470,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 471,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 472,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 473,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 474,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 475,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 476,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 477,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 478,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 479,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 480,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 481,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 482,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 483,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 484,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 485,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 486,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 487,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 488,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 489,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 490,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 491,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 492,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 493,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 494,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 495,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 496,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 497,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 498,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6762));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 499,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6764));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 501,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 502,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 503,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 504,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 505,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 506,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6778));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 507,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 508,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6782));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 509,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 510,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 511,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6789));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 512,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6791));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 513,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6794));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 514,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6795));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 515,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 516,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 517,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 518,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 519,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 520,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 521,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 522,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6811));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 523,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 524,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6814));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 525,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 526,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6819));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 527,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 528,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 529,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6825));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 530,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 531,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 532,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 533,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6832));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 534,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 535,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 536,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 537,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 538,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 539,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 540,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 541,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 542,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 543,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 544,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 545,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 546,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 547,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 548,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 549,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 550,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 551,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 552,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 553,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6873));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 554,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6875));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 555,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 556,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 557,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 558,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 559,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 560,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 561,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 562,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 563,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 564,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 565,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 566,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 567,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 568,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 569,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 570,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 571,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 572,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 573,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 574,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 575,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 576,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 577,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6924));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 578,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 579,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 580,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 581,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 582,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 583,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 584,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6937));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 585,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 586,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6942));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 587,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 588,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 589,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 590,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 591,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 592,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 593,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 594,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 595,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 596,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 597,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 598,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6965));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 599,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6968));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 601,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 602,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 603,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6975));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 604,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 605,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6979));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 606,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 607,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6983));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 608,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 609,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 610,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 611,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 612,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 613,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6994));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 614,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 615,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 616,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 617,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 618,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 619,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 620,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 621,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 622,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 623,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 624,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 625,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 626,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 627,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 628,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 629,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 630,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 631,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 632,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 633,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 634,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 635,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 636,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 637,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 638,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 639,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 640,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 641,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 642,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 643,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 644,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 645,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 646,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 647,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 648,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 649,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 650,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 2, 18, 12, 46, 782, DateTimeKind.Local).AddTicks(7071));
        }
    }
}
