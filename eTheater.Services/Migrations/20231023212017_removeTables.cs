using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTheater.Services.Migrations
{
    /// <inheritdoc />
    public partial class removeTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Notificat__Notif__267ABA7A",
                table: "Notification");

            migrationBuilder.DropForeignKey(
                name: "FK__Show__ShowGenreI__2D27B809",
                table: "Show");

            migrationBuilder.DropTable(
                name: "NotificationCategory");

            migrationBuilder.DropTable(
                name: "ShowGenre");

            migrationBuilder.DropIndex(
                name: "IX_Show_ShowGenreId",
                table: "Show");

            migrationBuilder.DropIndex(
                name: "IX_Notification_NotificationCategoryId",
                table: "Notification");

            migrationBuilder.DropColumn(
                name: "ShowGenreId",
                table: "Show");

            migrationBuilder.DropColumn(
                name: "NotificationCategoryId",
                table: "Notification");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ShowGenreId",
                table: "Show",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NotificationCategoryId",
                table: "Notification",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "NotificationCategory",
                columns: table => new
                {
                    NotificationCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Notifica__C7B551ABC13F63DA", x => x.NotificationCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "ShowGenre",
                columns: table => new
                {
                    ShowGenreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ShowGenr__5D1898B1648F4AFA", x => x.ShowGenreId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Show_ShowGenreId",
                table: "Show",
                column: "ShowGenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_NotificationCategoryId",
                table: "Notification",
                column: "NotificationCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK__Notificat__Notif__267ABA7A",
                table: "Notification",
                column: "NotificationCategoryId",
                principalTable: "NotificationCategory",
                principalColumn: "NotificationCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK__Show__ShowGenreI__2D27B809",
                table: "Show",
                column: "ShowGenreId",
                principalTable: "ShowGenre",
                principalColumn: "ShowGenreId");
        }
    }
}
