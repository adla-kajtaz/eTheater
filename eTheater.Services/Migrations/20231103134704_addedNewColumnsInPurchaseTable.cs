using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eTheater.Services.Migrations
{
    /// <inheritdoc />
    public partial class addedNewColumnsInPurchaseTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PaymentIntentId",
                table: "Purchase",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShowScheduleId",
                table: "Purchase",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0fe36601-caed-4988-8fd6-fabe3e80d457", new DateTime(2023, 11, 3, 14, 47, 3, 49, DateTimeKind.Local).AddTicks(9399), "AQAAAAEAACcQAAAAENYzFalX4T44LLYd+C9NeUTc+69N/+jAnx6PAUrp951D2RH3h0NNvwGDGavXqKYOmQ==", "1a84b21d-6ebb-47c8-8448-f3abceaf0dda" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d32306e-e268-4d79-a9a6-585adc548a63", new DateTime(2023, 11, 3, 14, 47, 3, 56, DateTimeKind.Local).AddTicks(9402), "AQAAAAEAACcQAAAAEDiAS7HsyJd4yDjNEn6+XxUszLVM1xeapYjr4p3tnovRbSffINAmKAGp5pGv+Uzm+g==", "6f46e2de-ab71-4e9c-ad77-19beca2b7f2f" });

            migrationBuilder.UpdateData(
                table: "Hall",
                keyColumn: "HallId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Hall",
                keyColumn: "HallId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7721));

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7734));

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7737));

            migrationBuilder.InsertData(
                table: "Purchase",
                columns: new[] { "PurchaseId", "CreatedAt", "IsDeleted", "IsPaid", "ModifiedAt", "NumberOfTickets", "PaymentIntentId", "ShowScheduleId", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9613), false, true, null, 2, "pi_3NwMiYEDYm8POibP1HZgAANw_secret_L1f7hpTvlCWjJJXmeJaTwZO06", 1, 40, 2 },
                    { 2, new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9619), false, true, null, 3, "pi_3NwMiYEDYm8POibP1HZgAANw_secret_L1f7hpTvlCWjJJXmeJaTwZO06", 6, 30, 2 },
                    { 3, new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9622), false, true, null, 1, "pi_3NwMiYEDYm8POibP1HZgAANw_secret_L1f7hpTvlCWjJJXmeJaTwZO06", 5, 10, 2 },
                    { 4, new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9624), false, true, null, 2, "pi_3NwMiYEDYm8POibP1HZgAANw_secret_L1f7hpTvlCWjJJXmeJaTwZO06", 2, 20, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7791));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7794));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7796));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7799));

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7821), new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7827), new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7832), new DateTime(2023, 11, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7836), new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7841), new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7845), new DateTime(2023, 11, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TheaterInfo",
                keyColumn: "TheaterInfoId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PurchaseId" },
                values: new object[] { new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7885), 1 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PurchaseId" },
                values: new object[] { new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7890), 1 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7893));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7899));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7903));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7905));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7907));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7915));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7919));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7921));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7923));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7925));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7931));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7933));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7939));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7941));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7946));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7953));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7972));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7976));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7979));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7981));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7985));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7991));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(7993));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8032));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8044));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8055));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8061));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8068));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8076));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8078));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8087));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8102));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8106));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8113));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8117));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8122));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8126));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8133));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8146));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8162));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8164));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8259));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 151,
                columns: new[] { "CreatedAt", "PurchaseId" },
                values: new object[] { new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8261), 4 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 152,
                columns: new[] { "CreatedAt", "PurchaseId" },
                values: new object[] { new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8263), 4 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8293));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8322));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8337));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8343));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 199,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 201,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 202,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 203,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 204,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 205,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 206,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 207,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 208,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 209,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 210,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 211,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 212,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 213,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8401));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 214,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 215,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 216,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 217,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 218,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 219,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 220,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 221,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 222,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 223,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 224,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 225,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8428));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 226,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 227,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 228,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8434));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 229,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 230,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8439));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 231,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 232,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8444));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 233,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 234,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 235,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 236,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 237,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 238,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 239,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 240,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 241,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 242,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 243,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8469));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 244,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 245,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 246,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 247,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 248,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 249,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 250,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 251,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 252,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 253,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 254,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8492));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 255,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8494));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 256,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8497));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 257,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 258,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8501));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 259,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 260,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 261,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 262,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 263,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8511));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 264,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8513));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 265,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8515));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 266,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 267,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 268,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 269,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8528));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 270,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8531));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 271,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 272,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8535));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 273,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 274,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 275,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 276,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 277,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 278,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 279,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 280,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 281,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 282,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 283,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 284,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 285,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 286,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 287,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 288,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 289,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 290,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 291,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 292,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 293,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 294,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 295,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8585));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 296,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 297,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 298,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 299,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 301,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 302,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 303,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 304,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 305,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 306,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 307,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 308,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 309,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 310,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 311,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 312,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 313,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 314,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8628));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 315,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 316,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8632));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 317,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 318,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 319,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 320,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 321,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 322,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8645));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 323,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8647));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 324,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 325,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 326,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 327,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 328,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 329,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 330,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 331,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8664));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 332,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8666));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 333,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8668));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 334,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 335,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8672));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 336,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 337,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 338,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 339,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8681));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 340,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 341,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 342,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 343,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 344,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 345,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 346,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 347,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 348,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 349,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 350,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 351,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8712));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 352,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 353,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 354,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 355,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 356,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 357,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 358,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 359,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 360,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 361,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 362,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 363,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 364,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 365,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 366,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 367,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 368,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 369,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 370,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 371,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 372,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 373,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 374,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 375,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 376,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8766));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 377,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 378,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 379,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 380,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 381,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 382,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 383,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 384,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 385,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 386,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 387,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 388,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 389,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 390,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 391,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 392,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 393,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 394,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 395,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 396,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 397,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 398,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 399,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 401,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 402,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 403,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 404,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 405,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 406,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 407,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 408,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 409,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 410,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8843));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 411,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 412,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 413,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 414,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 415,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 416,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 417,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 418,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 419,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 420,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 421,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 422,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 423,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 424,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 425,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 426,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8887));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 427,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 428,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 429,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8894));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 430,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 431,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 432,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 433,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8904));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 434,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 435,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8908));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 436,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 437,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 438,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 439,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 440,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 441,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 442,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8923));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 443,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 444,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 445,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 446,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 447,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 448,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 449,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 450,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 451,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 452,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 453,
                columns: new[] { "CreatedAt", "PurchaseId" },
                values: new object[] { new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8949), 3 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 454,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 455,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 456,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 457,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 458,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 459,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8961));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 460,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8964));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 461,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 462,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 463,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 464,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8972));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 465,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 466,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8977));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 467,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 468,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8981));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 469,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8983));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 470,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 471,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 472,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 473,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 474,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8993));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 475,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 476,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 477,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 478,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 479,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 480,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 481,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 482,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9011));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 483,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 484,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 485,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 486,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 487,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9022));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 488,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 489,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 490,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 491,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9037));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 492,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 493,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 494,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 495,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 496,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 497,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 498,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9051));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 499,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 501,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 502,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 503,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9062));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 504,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 505,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 506,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 507,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 508,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 509,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 510,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 511,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 512,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 513,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 514,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9085));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 515,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 516,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 517,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 518,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 519,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 520,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9098));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 521,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9101));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 522,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 523,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 524,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9108));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 525,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 526,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 527,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9114));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 528,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 529,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 530,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 531,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 532,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 533,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9126));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 534,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 535,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 536,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 537,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 538,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 539,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 540,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 541,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 542,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 543,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 544,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 545,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 546,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9155));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 547,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9157));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 548,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 549,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 550,
                columns: new[] { "CreatedAt", "PurchaseId" },
                values: new object[] { new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9163), 2 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 551,
                columns: new[] { "CreatedAt", "PurchaseId" },
                values: new object[] { new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9169), 2 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 552,
                columns: new[] { "CreatedAt", "PurchaseId" },
                values: new object[] { new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9171), 2 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 553,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 554,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 555,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 556,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 557,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 558,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 559,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9262));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 560,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9264));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 561,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9271));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 562,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 563,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 564,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9279));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 565,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9282));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 566,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 567,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9286));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 568,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 569,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 570,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 571,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 572,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 573,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 574,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 575,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9305));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 576,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 577,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 578,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9311));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 579,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 580,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 581,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9318));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 582,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 583,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 584,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9324));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 585,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9326));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 586,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9328));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 587,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 588,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 589,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 590,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 591,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9339));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 592,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 593,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 594,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 595,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9349));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 596,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9351));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 597,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 598,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 599,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9357));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 601,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 602,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 603,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 604,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 605,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 606,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 607,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9373));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 608,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 609,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 610,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 611,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 612,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9384));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 613,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 614,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 615,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 616,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9392));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 617,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9394));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 618,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9396));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 619,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 620,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 621,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 622,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 623,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 624,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 625,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 626,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9415));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 627,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 628,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 629,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9421));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 630,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 631,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9425));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 632,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 633,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9429));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 634,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9436));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 635,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9439));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 636,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 637,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9443));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 638,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9445));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 639,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9447));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 640,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 641,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 642,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9455));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 643,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9457));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 644,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 645,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9461));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 646,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 647,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 648,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 649,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 650,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 3, 14, 47, 3, 63, DateTimeKind.Local).AddTicks(9471));

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_ShowScheduleId",
                table: "Purchase",
                column: "ShowScheduleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_ShowSchedule_ShowScheduleId",
                table: "Purchase",
                column: "ShowScheduleId",
                principalTable: "ShowSchedule",
                principalColumn: "ShowScheduleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_ShowSchedule_ShowScheduleId",
                table: "Purchase");

            migrationBuilder.DropIndex(
                name: "IX_Purchase_ShowScheduleId",
                table: "Purchase");

            migrationBuilder.DeleteData(
                table: "Purchase",
                keyColumn: "PurchaseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Purchase",
                keyColumn: "PurchaseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Purchase",
                keyColumn: "PurchaseId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Purchase",
                keyColumn: "PurchaseId",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "PaymentIntentId",
                table: "Purchase");

            migrationBuilder.DropColumn(
                name: "ShowScheduleId",
                table: "Purchase");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6c6efca-1fe8-4527-b14c-13a38738c035", new DateTime(2023, 11, 2, 16, 44, 0, 499, DateTimeKind.Local).AddTicks(6450), "AQAAAAEAACcQAAAAEAtn1vU3OKIV3/hZpFahH3ndtbW8O/Tq337ygBDWyR09guEyAxxdMufwVfycHSB5lg==", "d2093c5d-5247-4583-bea3-ba8155ac5740" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a255617-a2b2-46e5-b5a4-15ac1a77f51e", new DateTime(2023, 11, 2, 16, 44, 0, 506, DateTimeKind.Local).AddTicks(354), "AQAAAAEAACcQAAAAEEt6ekNOld7gxe3jfE2Agmfoskf0w7MRxdkAqmLx4m5GpNvsxGGhERHQjOX77jDxUw==", "a0a3a182-68ad-4790-b600-5bb56acf067b" });

            migrationBuilder.UpdateData(
                table: "Hall",
                keyColumn: "HallId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Hall",
                keyColumn: "HallId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2688));

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2695));

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2698));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2771));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2775));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2781));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2783));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2785));

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2804), new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2808), new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2813), new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2816), new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2821), new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2824), new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TheaterInfo",
                keyColumn: "TheaterInfoId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PurchaseId" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2880), null });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PurchaseId" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2884), null });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2892));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2893));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2895));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2897));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2904));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2908));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2911));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2913));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2915));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2917));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2919));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2921));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2923));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2924));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2926));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2928));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2932));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2935));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2940));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2942));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2944));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2946));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2948));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2951));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2955));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2957));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2959));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2962));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2965));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2967));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2971));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2976));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2978));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2984));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2986));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2989));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2998));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(2999));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3003));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3005));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3007));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3009));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3038));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3039));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3041));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3043));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3045));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3047));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3051));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3054));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3064));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3074));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3083));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3085));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3086));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3092));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3094));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3098));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3101));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3103));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3105));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3107));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3109));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3112));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3114));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3115));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3117));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3119));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3123));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3124));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3126));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3128));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3132));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3134));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3135));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3137));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3142));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3144));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3146));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3152));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3153));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3155));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3159));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3161));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3163));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3164));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3169));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3171));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3173));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3175));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3198));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3202));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3204));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3206));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3208));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3211));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3217));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3223));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 151,
                columns: new[] { "CreatedAt", "PurchaseId" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3225), null });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 152,
                columns: new[] { "CreatedAt", "PurchaseId" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3227), null });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3232));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3234));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3237));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3245));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3249));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3255));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3259));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3262));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3266));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 199,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3317));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3319));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 201,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 202,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 203,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3324));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 204,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3326));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 205,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3328));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 206,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 207,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3332));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 208,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 209,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 210,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 211,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 212,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 213,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3369));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 214,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3376));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 215,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 216,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 217,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3382));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 218,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 219,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 220,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 221,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 222,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 223,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 224,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3394));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 225,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 226,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 227,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 228,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3403));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 229,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 230,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 231,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3408));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 232,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 233,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3412));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 234,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 235,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 236,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 237,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3419));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 238,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 239,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 240,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 241,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 242,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 243,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 244,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 245,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 246,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 247,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3439));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 248,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3441));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 249,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3442));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 250,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3444));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 251,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3446));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 252,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3448));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 253,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 254,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3454));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 255,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3456));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 256,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 257,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 258,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3462));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 259,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 260,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3465));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 261,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3467));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 262,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3469));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 263,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3471));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 264,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3473));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 265,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3475));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 266,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3476));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 267,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3478));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 268,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 269,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3483));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 270,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 271,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3487));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 272,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3488));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 273,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 274,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 275,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 276,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 277,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 278,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3499));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 279,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 280,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 281,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3505));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 282,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3507));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 283,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3509));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 284,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 285,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 286,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 287,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3542));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 288,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 289,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 290,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 291,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 292,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 293,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3553));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 294,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 295,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 296,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 297,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 298,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 299,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 301,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 302,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 303,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3572));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 304,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 305,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3576));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 306,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 307,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 308,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3582));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 309,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3583));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 310,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 311,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3587));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 312,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3589));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 313,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 314,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 315,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 316,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3597));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 317,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 318,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3601));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 319,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 320,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3606));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 321,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3608));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 322,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 323,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 324,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3613));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 325,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3615));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 326,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3617));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 327,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 328,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 329,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 330,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3625));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 331,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 332,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 333,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 334,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 335,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 336,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 337,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3638));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 338,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 339,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 340,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3644));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 341,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 342,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3647));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 343,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 344,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3652));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 345,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3654));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 346,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 347,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 348,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 349,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 350,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 351,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 352,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 353,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3669));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 354,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 355,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3672));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 356,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 357,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 358,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 359,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 360,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 361,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 362,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 363,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 364,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 365,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3746));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 366,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 367,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3749));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 368,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3751));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 369,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 370,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 371,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 372,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 373,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 374,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3763));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 375,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 376,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 377,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 378,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 379,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 380,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 381,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3776));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 382,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 383,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 384,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 385,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 386,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3789));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 387,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3791));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 388,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 389,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3794));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 390,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 391,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 392,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 393,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 394,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 395,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 396,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 397,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 398,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3812));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 399,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3814));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 401,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 402,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 403,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 404,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3824));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 405,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 406,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 407,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 408,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 409,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 410,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 411,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3838));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 412,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 413,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 414,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 415,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 416,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3848));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 417,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 418,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 419,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 420,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3856));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 421,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 422,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 423,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 424,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3863));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 425,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 426,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3867));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 427,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 428,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 429,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 430,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 431,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 432,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 433,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 434,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 435,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 436,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 437,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 438,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 439,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 440,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 441,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 442,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 443,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 444,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3928));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 445,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 446,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3932));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 447,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 448,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 449,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 450,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 451,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 452,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 453,
                columns: new[] { "CreatedAt", "PurchaseId" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3947), null });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 454,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 455,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 456,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3953));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 457,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 458,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 459,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 460,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 461,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3963));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 462,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 463,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 464,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 465,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 466,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 467,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 468,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 469,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 470,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 471,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 472,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 473,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 474,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3994));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 475,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 476,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 477,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 478,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4002));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 479,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 480,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 481,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 482,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 483,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 484,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 485,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4018));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 486,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 487,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 488,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4024));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 489,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 490,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 491,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 492,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 493,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 494,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 495,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4038));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 496,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 497,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 498,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 499,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4047));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 501,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 502,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 503,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 504,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 505,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 506,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 507,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4085));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 508,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4088));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 509,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 510,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 511,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 512,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 513,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 514,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 515,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4102));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 516,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 517,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 518,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 519,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 520,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 521,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 522,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 523,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 524,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 525,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 526,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 527,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 528,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 529,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 530,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 531,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 532,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 533,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 534,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 535,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 536,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 537,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 538,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 539,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 540,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 541,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4154));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 542,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 543,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 544,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 545,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 546,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 547,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 548,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 549,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 550,
                columns: new[] { "CreatedAt", "PurchaseId" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4171), null });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 551,
                columns: new[] { "CreatedAt", "PurchaseId" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4172), null });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 552,
                columns: new[] { "CreatedAt", "PurchaseId" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4175), null });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 553,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 554,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 555,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 556,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 557,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 558,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 559,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 560,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 561,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 562,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4194));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 563,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 564,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 565,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 566,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 567,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4204));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 568,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4206));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 569,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 570,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 571,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 572,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 573,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 574,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 575,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 576,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 577,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 578,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4323));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 579,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 580,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 581,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 582,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 583,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 584,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 585,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4337));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 586,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4339));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 587,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 588,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 589,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 590,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 591,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 592,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 593,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 594,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 595,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 596,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 597,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 598,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 599,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4367));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 601,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 602,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 603,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 604,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 605,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 606,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 607,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 608,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 609,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 610,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 611,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 612,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 613,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4394));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 614,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4395));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 615,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 616,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4399));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 617,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4401));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 618,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 619,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 620,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 621,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 622,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 623,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 624,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4414));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 625,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4415));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 626,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 627,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 628,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 629,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4424));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 630,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4426));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 631,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4427));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 632,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 633,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 634,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4433));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 635,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 636,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 637,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 638,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 639,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4443));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 640,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 641,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 642,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 643,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 644,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 645,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4454));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 646,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 647,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 648,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 649,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 650,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 2, 16, 44, 0, 512, DateTimeKind.Local).AddTicks(4485));
        }
    }
}
