using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eTheater.Migrations
{
    /// <inheritdoc />
    public partial class addedShowActorsToSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(7862));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(7865));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(7867));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f62d9bc6-1c21-4d58-981d-fca63c973b05", new DateTime(2023, 11, 15, 15, 30, 20, 308, DateTimeKind.Local).AddTicks(1041), "AQAAAAEAACcQAAAAEJP1tmpXYbyis4OS1jiInYfrUSUxmqOrPMsCtZ7M6pUD6+6A6pbtKBqtXjN8oDXbFA==", "6994eada-768c-4c25-a64f-3b3097a96fdd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af028640-99c2-4d67-a37a-9a1f1279ef1b", new DateTime(2023, 11, 15, 15, 30, 20, 315, DateTimeKind.Local).AddTicks(2607), "AQAAAAEAACcQAAAAEHh4pBQrN0wVHbDR/vKNaI7RUOHx/sGS25uKZgd35RqGamAQALH1SP2Rmh1U59pKRA==", "f2eb623f-135b-4a8e-996d-70adc65cc19f" });

            migrationBuilder.UpdateData(
                table: "Hall",
                keyColumn: "HallId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Hall",
                keyColumn: "HallId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(7804));

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(7807));

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "PurchaseId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "PurchaseId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "PurchaseId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9643));

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "PurchaseId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9647));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(7884));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(7899));

            migrationBuilder.InsertData(
                table: "ShowActors",
                columns: new[] { "ShowActorId", "ActorId", "CreatedAt", "IsDeleted", "ModifiedAt", "ShowId" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(7934), false, null, 1 },
                    { 2, 2, new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(7937), false, null, 2 },
                    { 3, 2, new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(7939), false, null, 3 },
                    { 4, 1, new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(7941), false, null, 4 },
                    { 5, 1, new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(7944), false, null, 5 },
                    { 6, 1, new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(7945), false, null, 6 },
                    { 7, 2, new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(7947), false, null, 6 }
                });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(7964), new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(7970), new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(7975), new DateTime(2023, 11, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(7979), new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(7983), new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(7986), new DateTime(2023, 11, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TheaterInfo",
                keyColumn: "TheaterInfoId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8034));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8055));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8061));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8079));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8087));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8113));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8117));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8122));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8133));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8146));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8162));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8164));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8231));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8237));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8256));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8293));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8302));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8322));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8388));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8396));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8398));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8434));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 199,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8444));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 201,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 202,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 203,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 204,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 205,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 206,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 207,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 208,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 209,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 210,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 211,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8469));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 212,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 213,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 214,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 215,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 216,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 217,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 218,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 219,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8486));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 220,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8488));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 221,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8494));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 222,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8497));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 223,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 224,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8501));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 225,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 226,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 227,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 228,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 229,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8513));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 230,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 231,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 232,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 233,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 234,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 235,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8528));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 236,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 237,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8531));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 238,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 239,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 240,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 241,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 242,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 243,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 244,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 245,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 246,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 247,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 248,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8553));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 249,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 250,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 251,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8559));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 252,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 253,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 254,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 255,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 256,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 257,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 258,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 259,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 260,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 261,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 262,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 263,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 264,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 265,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 266,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 267,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 268,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 269,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 270,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 271,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 272,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 273,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 274,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 275,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 276,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 277,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8616));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 278,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 279,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 280,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 281,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 282,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8627));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 283,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 284,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 285,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8633));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 286,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 287,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 288,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 289,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 290,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 291,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 292,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 293,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 294,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 295,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 296,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 297,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8664));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 298,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8666));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 299,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8668));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 301,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8672));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 302,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 303,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 304,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 305,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8681));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 306,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 307,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 308,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 309,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 310,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 311,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 312,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 313,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 314,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 315,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 316,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 317,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 318,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 319,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 320,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 321,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 322,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 323,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 324,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 325,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 326,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 327,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 328,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 329,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 330,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 331,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 332,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 333,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 334,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 335,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 336,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 337,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 338,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 339,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 340,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 341,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 342,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 343,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8759));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 344,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 345,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 346,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 347,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 348,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 349,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 350,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 351,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 352,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 353,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 354,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 355,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 356,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 357,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 358,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 359,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 360,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 361,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 362,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 363,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 364,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 365,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 366,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 367,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 368,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 369,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 370,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 371,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 372,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 373,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 374,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 375,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 376,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 377,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 378,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 379,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 380,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 381,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8843));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 382,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 383,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 384,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8848));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 385,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 386,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 387,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 388,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 389,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 390,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 391,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 392,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 393,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 394,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 395,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 396,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 397,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 398,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 399,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8881));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 401,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 402,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8885));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 403,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8887));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 404,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 405,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8891));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 406,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 407,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 408,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 409,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 410,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8903));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 411,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 412,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 413,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8908));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 414,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 415,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 416,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 417,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 418,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8918));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 419,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 420,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8922));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 421,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 422,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8926));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 423,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 424,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 425,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 426,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 427,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 428,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 429,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 430,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 431,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 432,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 433,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 434,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 435,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 436,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 437,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 438,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 439,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 440,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8969));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 441,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 442,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 443,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 444,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 445,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 446,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 447,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8984));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 448,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 449,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 450,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 451,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 452,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 453,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 454,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 455,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 456,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 457,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 458,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 459,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 460,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 461,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9012));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 462,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 463,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 464,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 465,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 466,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9022));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 467,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 468,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 469,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 470,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 471,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 472,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 473,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 474,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 475,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 476,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 477,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 478,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 479,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 480,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 481,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9052));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 482,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 483,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 484,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 485,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 486,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9061));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 487,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 488,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9065));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 489,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 490,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 491,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 492,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 493,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 494,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 495,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 496,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9082));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 497,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 498,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9086));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 499,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 501,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 502,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 503,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 504,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 505,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 506,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9101));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 507,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9103));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 508,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 509,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 510,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9108));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 511,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9111));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 512,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9117));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 513,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 514,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 515,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 516,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9125));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 517,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 518,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 519,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 520,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 521,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 522,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9137));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 523,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 524,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 525,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9143));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 526,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 527,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 528,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 529,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 530,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 531,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 532,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9158));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 533,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 534,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9162));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 535,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 536,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 537,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9168));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 538,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 539,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9171));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 540,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 541,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9176));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 542,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 543,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 544,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9182));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 545,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9184));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 546,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 547,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9187));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 548,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9189));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 549,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9191));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 550,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9193));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 551,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9196));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 552,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9198));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 553,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 554,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9202));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 555,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 556,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9207));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 557,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9209));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 558,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 559,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 560,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 561,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9216));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 562,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9218));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 563,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 564,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 565,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 566,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9225));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 567,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 568,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 569,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 570,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 571,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 572,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 573,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 574,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9242));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 575,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9244));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 576,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 577,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 578,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 579,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 580,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 581,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 582,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9257));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 583,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 584,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9261));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 585,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 586,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9271));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 587,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9273));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 588,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9275));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 589,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 590,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9279));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 591,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 592,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9282));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 593,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 594,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9286));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 595,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 596,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 597,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 598,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 599,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 601,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9301));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 602,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9303));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 603,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9305));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 604,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 605,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 606,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9311));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 607,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 608,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9315));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 609,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 610,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 611,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 612,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 613,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 614,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 615,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9329));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 616,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 617,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9333));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 618,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 619,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9336));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 620,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9338));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 621,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9340));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 622,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9342));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 623,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 624,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9346));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 625,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9348));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 626,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 627,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 628,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 629,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 630,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 631,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 632,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 633,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 634,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 635,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 636,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 637,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 638,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 639,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9376));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 640,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 641,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 642,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 643,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9384));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 644,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 645,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 646,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9389));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 647,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 648,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 649,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 650,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 15, 15, 30, 20, 321, DateTimeKind.Local).AddTicks(9397));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ShowActors",
                keyColumn: "ShowActorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ShowActors",
                keyColumn: "ShowActorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ShowActors",
                keyColumn: "ShowActorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ShowActors",
                keyColumn: "ShowActorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ShowActors",
                keyColumn: "ShowActorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ShowActors",
                keyColumn: "ShowActorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ShowActors",
                keyColumn: "ShowActorId",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(711));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(716));

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61952b35-c47c-4636-8b44-9a8800d34b2d", new DateTime(2023, 11, 14, 16, 26, 15, 690, DateTimeKind.Local).AddTicks(8255), "AQAAAAEAACcQAAAAEKRSle9LYaq1MCmMxe2ZixPem4rTSUi3CHF1tXPmzIeXLHokx07Xa5WIADzyAMUzRA==", "76e8dbb6-6852-4635-bac2-29890aeaea4f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0690caee-d61a-410a-9020-6c77c8878c2e", new DateTime(2023, 11, 14, 16, 26, 15, 697, DateTimeKind.Local).AddTicks(3289), "AQAAAAEAACcQAAAAEOUFpsNr/JhC9TJEvIOQFMjG90g5WBN6tbNbe/BujuqN0m0V1ubegs2K7TOgD/i9yQ==", "076c9f78-78d8-4d72-8710-9e22034b0eb6" });

            migrationBuilder.UpdateData(
                table: "Hall",
                keyColumn: "HallId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Hall",
                keyColumn: "HallId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(634));

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(655));

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(658));

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "PurchaseId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "PurchaseId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "PurchaseId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "PurchaseId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2692));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(737));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(762), new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(768), new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(773), new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(777), new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(781), new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(785), new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TheaterInfo",
                keyColumn: "TheaterInfoId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(848));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(867));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(869));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(882));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(884));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(888));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(891));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(893));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(895));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(899));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(901));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(905));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(922));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(963));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(964));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(974));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(982));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(986));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(991));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(993));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(994));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1008));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1028));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1032));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1034));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1038));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1042));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1052));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1069));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1071));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1075));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1082));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1084));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1086));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1093));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1097));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1103));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1104));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1137));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1139));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1141));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1145));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1147));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1148));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1152));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1154));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1156));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1158));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1162));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1163));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1168));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1172));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1174));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1176));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1178));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1187));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1189));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1191));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1193));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1196));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1202));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1204));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1208));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1212));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1216));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1221));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1224));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1234));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1235));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1237));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1239));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1243));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1245));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1247));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1249));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1251));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1254));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1261));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1265));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1267));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1273));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1276));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1312));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1315));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1317));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1321));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1327));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 199,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1329));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1331));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 201,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1333));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 202,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 203,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1337));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 204,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1338));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 205,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1342));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 206,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 207,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1346));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 208,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1348));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 209,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 210,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1352));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 211,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1354));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 212,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1356));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 213,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1358));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 214,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 215,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1362));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 216,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1364));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 217,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1366));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 218,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1368));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 219,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 220,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1373));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 221,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1374));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 222,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 223,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1378));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 224,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 225,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1382));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 226,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 227,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 228,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1388));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 229,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 230,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1391));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 231,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1393));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 232,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1395));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 233,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1397));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 234,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 235,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1402));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 236,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1403));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 237,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 238,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1407));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 239,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1409));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 240,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1411));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 241,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 242,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1415));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 243,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1417));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 244,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1419));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 245,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 246,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1423));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 247,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1425));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 248,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1426));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 249,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1428));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 250,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1431));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 251,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 252,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1435));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 253,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1437));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 254,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 255,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 256,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 257,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 258,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1446));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 259,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1448));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 260,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 261,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1483));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 262,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 263,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 264,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 265,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 266,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1495));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 267,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1496));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 268,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1498));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 269,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 270,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 271,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 272,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 273,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 274,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 275,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 276,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1514));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 277,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 278,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 279,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 280,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 281,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 282,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1526));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 283,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 284,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 285,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 286,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 287,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1536));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 288,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 289,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 290,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 291,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1543));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 292,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 293,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 294,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 295,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1552));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 296,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 297,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 298,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1558));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 299,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1562));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 301,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1564));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 302,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1566));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 303,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 304,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1569));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 305,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 306,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1573));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 307,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 308,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1577));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 309,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1582));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 310,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1584));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 311,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1586));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 312,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1588));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 313,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 314,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1591));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 315,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1593));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 316,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1595));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 317,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1597));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 318,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1599));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 319,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1601));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 320,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1603));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 321,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1605));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 322,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1607));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 323,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 324,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1611));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 325,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1613));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 326,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1615));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 327,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1617));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 328,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 329,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1621));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 330,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 331,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1625));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 332,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1626));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 333,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1628));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 334,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 335,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1661));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 336,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1663));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 337,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1665));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 338,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1667));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 339,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 340,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 341,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 342,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 343,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 344,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1681));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 345,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1683));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 346,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1685));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 347,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 348,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1688));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 349,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 350,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 351,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1694));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 352,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1696));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 353,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1698));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 354,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1701));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 355,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1703));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 356,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 357,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1707));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 358,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1709));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 359,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1711));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 360,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 361,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1715));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 362,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 363,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 364,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 365,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1723));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 366,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 367,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 368,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 369,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1734));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 370,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1736));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 371,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1738));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 372,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 373,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1742));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 374,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1744));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 375,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 376,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1748));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 377,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 378,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1752));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 379,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1754));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 380,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 381,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1758));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 382,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 383,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1762));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 384,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 385,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1767));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 386,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1769));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 387,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1771));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 388,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1773));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 389,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1775));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 390,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1777));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 391,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 392,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1781));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 393,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1783));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 394,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1785));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 395,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1787));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 396,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1789));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 397,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1791));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 398,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1794));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 399,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1796));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1798));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 401,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 402,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1802));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 403,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1804));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 404,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1805));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 405,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1807));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 406,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1809));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 407,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1839));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 408,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1842));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 409,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1844));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 410,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1846));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 411,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1848));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 412,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 413,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1853));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 414,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1855));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 415,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1857));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 416,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1859));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 417,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1861));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 418,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 419,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1865));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 420,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1866));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 421,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1868));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 422,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 423,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1872));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 424,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1874));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 425,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1876));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 426,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1878));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 427,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 428,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1886));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 429,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 430,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 431,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 432,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1893));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 433,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1895));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 434,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 435,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 436,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 437,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1903));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 438,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1905));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 439,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1907));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 440,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 441,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1911));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 442,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 443,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 444,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 445,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1919));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 446,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 447,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1923));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 448,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 449,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1927));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 450,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1928));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 451,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 452,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1932));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 453,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1934));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 454,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1936));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 455,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1938));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 456,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1940));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 457,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1942));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 458,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1945));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 459,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1947));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 460,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1949));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 461,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 462,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 463,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1955));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 464,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 465,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1959));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 466,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 467,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 468,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 469,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 470,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 471,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1972));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 472,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 473,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 474,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1979));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 475,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1981));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 476,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1982));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 477,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 478,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 479,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(1988));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 480,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2032));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 481,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2039));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 482,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 483,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2043));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 484,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 485,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2047));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 486,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 487,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 488,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2054));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 489,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 490,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2058));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 491,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 492,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 493,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2064));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 494,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2066));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 495,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2068));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 496,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 497,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 498,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2073));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 499,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2075));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2077));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 501,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2079));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 502,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2081));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 503,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 504,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 505,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 506,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2090));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 507,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2092));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 508,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 509,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 510,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 511,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 512,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2103));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 513,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2104));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 514,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2106));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 515,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 516,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 517,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 518,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 519,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 520,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 521,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 522,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2124));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 523,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 524,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 525,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 526,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 527,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 528,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2135));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 529,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2137));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 530,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2139));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 531,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2141));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 532,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 533,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 534,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2147));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 535,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2149));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 536,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2151));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 537,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2153));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 538,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2155));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 539,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2157));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 540,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2159));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 541,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 542,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2163));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 543,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2165));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 544,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 545,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2168));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 546,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 547,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2173));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 548,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2175));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 549,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2177));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 550,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2179));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 551,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 552,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 553,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2213));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 554,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2216));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 555,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 556,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2219));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 557,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2221));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 558,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2223));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 559,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2225));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 560,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2227));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 561,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 562,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2232));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 563,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2234));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 564,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 565,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2238));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 566,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 567,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2242));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 568,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2244));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 569,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2245));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 570,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 571,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2249));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 572,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 573,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2253));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 574,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2255));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 575,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2257));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 576,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2259));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 577,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2262));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 578,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2263));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 579,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2265));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 580,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2268));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 581,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 582,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 583,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2273));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 584,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 585,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 586,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2279));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 587,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2281));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 588,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 589,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 590,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2287));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 591,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2290));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 592,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 593,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 594,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2295));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 595,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2297));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 596,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 597,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 598,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 599,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2307));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 601,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 602,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2310));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 603,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 604,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 605,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 606,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2319));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 607,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2321));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 608,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 609,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 610,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 611,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 612,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 613,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 614,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2334));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 615,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2336));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 616,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 617,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2342));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 618,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 619,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 620,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 621,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2351));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 622,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 623,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 624,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2356));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 625,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2358));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 626,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2387));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 627,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 628,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 629,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2394));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 630,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 631,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2397));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 632,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 633,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 634,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2403));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 635,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2405));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 636,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2408));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 637,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2410));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 638,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 639,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2414));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 640,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2415));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 641,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2417));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 642,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 643,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2422));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 644,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 645,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2426));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 646,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 647,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 648,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 649,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 650,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(2435));
        }
    }
}
