using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eTheater.Migrations
{
    /// <inheritdoc />
    public partial class addedShowActorTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShowActors",
                columns: table => new
                {
                    ShowActorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActorId = table.Column<int>(type: "int", nullable: true),
                    ShowId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShowActors", x => x.ShowActorId);
                    table.ForeignKey(
                        name: "FK_ShowActors_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "ActorId");
                    table.ForeignKey(
                        name: "FK_ShowActors_Show_ShowId",
                        column: x => x.ShowId,
                        principalTable: "Show",
                        principalColumn: "ShowId");
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ActorId", "CreatedAt", "FirstName", "IsDeleted", "LastName", "ModifiedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(711), "Ajla", false, "Hamzić", null },
                    { 2, new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(714), "Emir", false, "Spahić", null },
                    { 3, new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(716), "Asija", false, "Kajtaz", null },
                    { 4, new DateTime(2023, 11, 14, 16, 26, 15, 704, DateTimeKind.Local).AddTicks(718), "Adi", false, "Pezo", null }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ShowActors_ActorId",
                table: "ShowActors",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_ShowActors_ShowId",
                table: "ShowActors",
                column: "ShowId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShowActors");

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22ab6bc4-4abb-4ce9-b5fb-bcdb3e496892", new DateTime(2023, 11, 13, 16, 38, 28, 516, DateTimeKind.Local).AddTicks(1585), "AQAAAAEAACcQAAAAEMF0pRt3O2SWhpA15NauU3LjkG0kpS/CZ+XiNcOI4XRdwUZ1/3uM2MmbgpwVjZqNYw==", "e2ec76fc-4242-4cd4-8048-334ef74edfee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f46ed2cb-51fb-46ac-9a8c-9a85b626b8f9", new DateTime(2023, 11, 13, 16, 38, 28, 523, DateTimeKind.Local).AddTicks(5597), "AQAAAAEAACcQAAAAEJAwUNUH4HNFG27TJBHRtgCiqTy8HPetjiUQS767zJL046KeucbiJLriMYmTDQv7+A==", "257364d4-a39e-478a-a106-87c2a1b694c9" });

            migrationBuilder.UpdateData(
                table: "Hall",
                keyColumn: "HallId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Hall",
                keyColumn: "HallId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "PurchaseId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "PurchaseId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "PurchaseId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "Purchase",
                keyColumn: "PurchaseId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4442));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4454));

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4492), new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4496), new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4504), new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4510), new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4514), new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4518), new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TheaterInfo",
                keyColumn: "TheaterInfoId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4724));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4738));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4759));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4769));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4775));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4779));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4784));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4785));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5077));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5092));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5094));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5095));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5101));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5109));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5111));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5113));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5117));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5119));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5126));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5161));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5165));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5176));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5178));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5186));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5188));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5211));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5215));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5336));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5343));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5351));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5357));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5372));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5379));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5383));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5427));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5431));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5433));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5437));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5439));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5441));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5444));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5446));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5448));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5449));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5457));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5477));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 199,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5535));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 201,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 202,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 203,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 204,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 205,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 206,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5549));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 207,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 208,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5554));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 209,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 210,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5557));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 211,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 212,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 213,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 214,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 215,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 216,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5569));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 217,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5571));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 218,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 219,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5575));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 220,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 221,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5578));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 222,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 223,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 224,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5585));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 225,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5587));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 226,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5589));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 227,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 228,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5593));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 229,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5594));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 230,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 231,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5598));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 232,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 233,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5603));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 234,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5605));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 235,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 236,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5608));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 237,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 238,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5613));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 239,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5615));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 240,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5617));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 241,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 242,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5621));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 243,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 244,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5625));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 245,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 246,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5629));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 247,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5631));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 248,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 249,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5634));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 250,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 251,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 252,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 253,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5643));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 254,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 255,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 256,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 257,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 258,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 259,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5654));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 260,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5656));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 261,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5658));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 262,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 263,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 264,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 265,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5666));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 266,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 267,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 268,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 269,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5674));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 270,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5708));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 271,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 272,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5713));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 273,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 274,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5717));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 275,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 276,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5721));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 277,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 278,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 279,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 280,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 281,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 282,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 283,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 284,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 285,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5739));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 286,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 287,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 288,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5745));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 289,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 290,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 291,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5751));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 292,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5753));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 293,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5755));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 294,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5756));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 295,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 296,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 297,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 298,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5766));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 299,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 301,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 302,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5774));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 303,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 304,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 305,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 306,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5781));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 307,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5783));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 308,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5785));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 309,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 310,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 311,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5791));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 312,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5793));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 313,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5795));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 314,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5797));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 315,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 316,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5801));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 317,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 318,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 319,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 320,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 321,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 322,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5813));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 323,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5814));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 324,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 325,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5818));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 326,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 327,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 328,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 329,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5827));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 330,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 331,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 332,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5926));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 333,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5928));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 334,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5930));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 335,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5932));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 336,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 337,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5936));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 338,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5938));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 339,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 340,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5942));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 341,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5944));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 342,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5947));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 343,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5992));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 344,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5995));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 345,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 346,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 347,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6001));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 348,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6003));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 349,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6006));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 350,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6008));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 351,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 352,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6012));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 353,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6014));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 354,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6016));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 355,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 356,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 357,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6023));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 358,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6025));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 359,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6027));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 360,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6029));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 361,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6031));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 362,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 363,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 364,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6037));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 365,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6039));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 366,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 367,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6043));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 368,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 369,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6047));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 370,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6049));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 371,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 372,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 373,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 374,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6057));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 375,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6059));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 376,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 377,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6063));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 378,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 379,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 380,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 381,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 382,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 383,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6075));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 384,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6077));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 385,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 386,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 387,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 388,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 389,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6092));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 390,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 391,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6096));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 392,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 393,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 394,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 395,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 396,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6106));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 397,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6108));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 398,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 399,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 401,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 402,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 403,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 404,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 405,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 406,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 407,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6128));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 408,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 409,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 410,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 411,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 412,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6138));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 413,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 414,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 415,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 416,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6176));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 417,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 418,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6181));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 419,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 420,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 421,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 422,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6189));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 423,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 424,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 425,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6195));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 426,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6198));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 427,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 428,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 429,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 430,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 431,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6209));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 432,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 433,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 434,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 435,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 436,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 437,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6221));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 438,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 439,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6225));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 440,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6227));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 441,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6229));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 442,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 443,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 444,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6235));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 445,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 446,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 447,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 448,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 449,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 450,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 451,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 452,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 453,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 454,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 455,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 456,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 457,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 458,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6267));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 459,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 460,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 461,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 462,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6277));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 463,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 464,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 465,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 466,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 467,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 468,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6293));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 469,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 470,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 471,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 472,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6302));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 473,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 474,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 475,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 476,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 477,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 478,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 479,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 480,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 481,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6328));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 482,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6330));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 483,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6332));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 484,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6334));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 485,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 486,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6339));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 487,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6341));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 488,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 489,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 490,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 491,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 492,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 493,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 494,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 495,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 496,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 497,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 498,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 499,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 501,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 502,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 503,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6415));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 504,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 505,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6419));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 506,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 507,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6424));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 508,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 509,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6428));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 510,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 511,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 512,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6434));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 513,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 514,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 515,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 516,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6442));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 517,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 518,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 519,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 520,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 521,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 522,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 523,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 524,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 525,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 526,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 527,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 528,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 529,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 530,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6474));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 531,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6476));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 532,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6478));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 533,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 534,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 535,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 536,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 537,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 538,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 539,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6492));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 540,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6494));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 541,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6496));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 542,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 543,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 544,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 545,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 546,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 547,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 548,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 549,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 550,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6515));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 551,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 552,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 553,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 554,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6523));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 555,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 556,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 557,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 558,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 559,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 560,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6535));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 561,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 562,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 563,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 564,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 565,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 566,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 567,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 568,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 569,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 570,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 571,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6606));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 572,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6608));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 573,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 574,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 575,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6616));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 576,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 577,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 578,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6622));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 579,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 580,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6628));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 581,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6631));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 582,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6634));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 583,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6636));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 584,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6639));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 585,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 586,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 587,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6648));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 588,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6651));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 589,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 590,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 591,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6658));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 592,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 593,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 594,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 595,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 596,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 597,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 598,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 599,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 601,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 602,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6689));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 603,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 604,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6694));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 605,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 606,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 607,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 608,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 609,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 610,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 611,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 612,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 613,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 614,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 615,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 616,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 617,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 618,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 619,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 620,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 621,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 622,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 623,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 624,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 625,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 626,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 627,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 628,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 629,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 630,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 631,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6761));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 632,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 633,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 634,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 635,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 636,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 637,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 638,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 639,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6811));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 640,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6813));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 641,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 642,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 643,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 644,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 645,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6825));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 646,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 647,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6832));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 648,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6837));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 649,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 650,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 13, 16, 38, 28, 530, DateTimeKind.Local).AddTicks(6840));
        }
    }
}
