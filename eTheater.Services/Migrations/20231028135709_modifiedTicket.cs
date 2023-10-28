using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTheater.Services.Migrations
{
    /// <inheritdoc />
    public partial class modifiedTicket : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "isActive",
                table: "Ticket",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsPaid",
                table: "Purchase",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Hall",
                keyColumn: "HallId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Hall",
                keyColumn: "HallId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 28, 15, 57, 8, 793, DateTimeKind.Local).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 28, 15, 57, 8, 793, DateTimeKind.Local).AddTicks(5239));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 28, 15, 57, 8, 793, DateTimeKind.Local).AddTicks(5241));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 28, 15, 57, 8, 793, DateTimeKind.Local).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 28, 15, 57, 8, 793, DateTimeKind.Local).AddTicks(5246));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 28, 15, 57, 8, 793, DateTimeKind.Local).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 10, 28, 15, 57, 8, 793, DateTimeKind.Local).AddTicks(5266), new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 10, 28, 15, 57, 8, 793, DateTimeKind.Local).AddTicks(5271), new DateTime(2023, 10, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 10, 28, 15, 57, 8, 793, DateTimeKind.Local).AddTicks(5276), new DateTime(2023, 10, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 10, 28, 15, 57, 8, 793, DateTimeKind.Local).AddTicks(5280), new DateTime(2023, 10, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 10, 28, 15, 57, 8, 793, DateTimeKind.Local).AddTicks(5283), new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 10, 28, 15, 57, 8, 793, DateTimeKind.Local).AddTicks(5287), new DateTime(2023, 10, 31, 0, 0, 0, 0, DateTimeKind.Local) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPaid",
                table: "Purchase");

            migrationBuilder.AlterColumn<bool>(
                name: "isActive",
                table: "Ticket",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "Hall",
                keyColumn: "HallId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Hall",
                keyColumn: "HallId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Local));

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

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 10, 25, 14, 28, 2, 44, DateTimeKind.Local).AddTicks(4826), new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 10, 25, 14, 28, 2, 44, DateTimeKind.Local).AddTicks(4832), new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 10, 25, 14, 28, 2, 44, DateTimeKind.Local).AddTicks(4837), new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 10, 25, 14, 28, 2, 44, DateTimeKind.Local).AddTicks(4841), new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 10, 25, 14, 28, 2, 44, DateTimeKind.Local).AddTicks(4845), new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 10, 25, 14, 28, 2, 44, DateTimeKind.Local).AddTicks(4849), new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
