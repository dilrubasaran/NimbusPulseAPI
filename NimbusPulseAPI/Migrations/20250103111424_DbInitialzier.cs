using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NimbusPulseAPI.Migrations
{
    /// <inheritdoc />
    public partial class DbInitialzier : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResourceUsages_Devices_Id",
                table: "ResourceUsages");

            migrationBuilder.DropIndex(
                name: "IX_ResourceUsages_DeviceId",
                table: "ResourceUsages");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ResourceUsages",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "HealthStatus", "IpAddress", "LastReportDate", "Name", "OperatingSystem", "Status", "Type", "Uptime" },
                values: new object[,]
                {
                    { 1, "Good", "192.168.0.1", new DateTime(2025, 1, 3, 10, 14, 23, 677, DateTimeKind.Utc).AddTicks(2688), "Device01", "Windows Server", "Active", "Physical Machine", new TimeSpan(0, 0, 0, 0, 0) },
                    { 2, "Good", "192.168.0.2", new DateTime(2025, 1, 3, 9, 14, 23, 677, DateTimeKind.Utc).AddTicks(2893), "Device02", "Windows Server", "Active", "Virtual Machine", new TimeSpan(0, 0, 0, 0, 0) },
                    { 3, "Requires Check", "192.168.0.3", new DateTime(2025, 1, 3, 8, 14, 23, 677, DateTimeKind.Utc).AddTicks(2897), "Device03", "Linux", "Active", "Physical Machine", new TimeSpan(0, 0, 0, 0, 0) },
                    { 4, "Critical", "192.168.0.4", new DateTime(2025, 1, 3, 7, 14, 23, 677, DateTimeKind.Utc).AddTicks(2900), "Device04", "Windows Server", "Active", "Virtual Machine", new TimeSpan(0, 0, 0, 0, 0) },
                    { 5, "Good", "192.168.0.5", new DateTime(2025, 1, 3, 6, 14, 23, 677, DateTimeKind.Utc).AddTicks(2903), "Device05", "Windows Server", "Inactive", "Physical Machine", new TimeSpan(0, 0, 0, 0, 0) },
                    { 6, "Requires Check", "192.168.0.6", new DateTime(2025, 1, 3, 5, 14, 23, 677, DateTimeKind.Utc).AddTicks(2906), "Device06", "Linux", "Active", "Virtual Machine", new TimeSpan(0, 0, 0, 0, 0) },
                    { 7, "Good", "192.168.0.7", new DateTime(2025, 1, 3, 4, 14, 23, 677, DateTimeKind.Utc).AddTicks(2908), "Device07", "Windows Server", "Active", "Physical Machine", new TimeSpan(0, 0, 0, 0, 0) },
                    { 8, "Critical", "192.168.0.8", new DateTime(2025, 1, 3, 3, 14, 23, 677, DateTimeKind.Utc).AddTicks(2911), "Device08", "Windows Server", "Active", "Virtual Machine", new TimeSpan(0, 0, 0, 0, 0) },
                    { 9, "Requires Check", "192.168.0.9", new DateTime(2025, 1, 3, 2, 14, 23, 677, DateTimeKind.Utc).AddTicks(2913), "Device09", "Linux", "Active", "Physical Machine", new TimeSpan(0, 0, 0, 0, 0) },
                    { 10, "Good", "192.168.1.10", new DateTime(2025, 1, 3, 1, 14, 23, 677, DateTimeKind.Utc).AddTicks(2917), "Device10", "Windows Server", "Inactive", "Virtual Machine", new TimeSpan(0, 0, 0, 0, 0) },
                    { 11, "Good", "192.168.1.11", new DateTime(2025, 1, 3, 0, 14, 23, 677, DateTimeKind.Utc).AddTicks(2920), "Device11", "Windows Server", "Active", "Physical Machine", new TimeSpan(0, 0, 0, 0, 0) },
                    { 12, "Critical", "192.168.1.12", new DateTime(2025, 1, 2, 23, 14, 23, 677, DateTimeKind.Utc).AddTicks(2921), "Device12", "Linux", "Active", "Virtual Machine", new TimeSpan(0, 0, 0, 0, 0) },
                    { 13, "Good", "192.168.1.13", new DateTime(2025, 1, 2, 22, 14, 23, 677, DateTimeKind.Utc).AddTicks(2923), "Device13", "Windows Server", "Active", "Physical Machine", new TimeSpan(0, 0, 0, 0, 0) },
                    { 14, "Good", "192.168.1.14", new DateTime(2025, 1, 2, 21, 14, 23, 677, DateTimeKind.Utc).AddTicks(2925), "Device14", "Windows Server", "Active", "Virtual Machine", new TimeSpan(0, 0, 0, 0, 0) },
                    { 15, "Requires Check", "192.168.1.15", new DateTime(2025, 1, 2, 20, 14, 23, 677, DateTimeKind.Utc).AddTicks(2927), "Device15", "Linux", "Inactive", "Physical Machine", new TimeSpan(0, 0, 0, 0, 0) },
                    { 16, "Critical", "192.168.1.16", new DateTime(2025, 1, 2, 19, 14, 23, 677, DateTimeKind.Utc).AddTicks(2929), "Device16", "Windows Server", "Active", "Virtual Machine", new TimeSpan(0, 0, 0, 0, 0) },
                    { 17, "Good", "192.168.1.17", new DateTime(2025, 1, 2, 18, 14, 23, 677, DateTimeKind.Utc).AddTicks(2930), "Device17", "Windows Server", "Active", "Physical Machine", new TimeSpan(0, 0, 0, 0, 0) },
                    { 18, "Requires Check", "192.168.1.18", new DateTime(2025, 1, 2, 17, 14, 23, 677, DateTimeKind.Utc).AddTicks(2932), "Device18", "Linux", "Active", "Virtual Machine", new TimeSpan(0, 0, 0, 0, 0) },
                    { 19, "Good", "192.168.1.19", new DateTime(2025, 1, 2, 16, 14, 23, 677, DateTimeKind.Utc).AddTicks(2933), "Device19", "Windows Server", "Active", "Physical Machine", new TimeSpan(0, 0, 0, 0, 0) },
                    { 20, "Critical", "192.168.2.20", new DateTime(2025, 1, 2, 15, 14, 23, 677, DateTimeKind.Utc).AddTicks(2935), "Device20", "Windows Server", "Inactive", "Virtual Machine", new TimeSpan(0, 0, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "Logs",
                columns: new[] { "Id", "DeviceId", "LogLevel", "Message", "Source", "Timestamp" },
                values: new object[,]
                {
                    { 1, 1, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 11, 9, 23, 678, DateTimeKind.Utc).AddTicks(98) },
                    { 2, 1, "Info", "Device operating normally.", "Server Monitoring", new DateTime(2025, 1, 3, 11, 4, 23, 678, DateTimeKind.Utc).AddTicks(284) },
                    { 3, 1, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 10, 59, 23, 678, DateTimeKind.Utc).AddTicks(286) },
                    { 4, 1, "Critical", "Device requires urgent attention.", "Server Monitoring", new DateTime(2025, 1, 3, 10, 54, 23, 678, DateTimeKind.Utc).AddTicks(287) },
                    { 5, 1, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 10, 49, 23, 678, DateTimeKind.Utc).AddTicks(288) },
                    { 6, 2, "Info", "Device operating normally.", "Server Monitoring", new DateTime(2025, 1, 3, 10, 44, 23, 678, DateTimeKind.Utc).AddTicks(288) },
                    { 7, 2, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 10, 39, 23, 678, DateTimeKind.Utc).AddTicks(289) },
                    { 8, 2, "Critical", "Device requires urgent attention.", "Server Monitoring", new DateTime(2025, 1, 3, 10, 34, 23, 678, DateTimeKind.Utc).AddTicks(289) },
                    { 9, 2, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 10, 29, 23, 678, DateTimeKind.Utc).AddTicks(290) },
                    { 10, 2, "Info", "Device operating normally.", "Server Monitoring", new DateTime(2025, 1, 3, 10, 24, 23, 678, DateTimeKind.Utc).AddTicks(290) },
                    { 11, 3, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 10, 19, 23, 678, DateTimeKind.Utc).AddTicks(291) },
                    { 12, 3, "Critical", "Device requires urgent attention.", "Server Monitoring", new DateTime(2025, 1, 3, 10, 14, 23, 678, DateTimeKind.Utc).AddTicks(291) },
                    { 13, 3, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 10, 9, 23, 678, DateTimeKind.Utc).AddTicks(292) },
                    { 14, 3, "Info", "Device operating normally.", "Server Monitoring", new DateTime(2025, 1, 3, 10, 4, 23, 678, DateTimeKind.Utc).AddTicks(292) },
                    { 15, 3, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 9, 59, 23, 678, DateTimeKind.Utc).AddTicks(293) },
                    { 16, 4, "Critical", "Device requires urgent attention.", "Server Monitoring", new DateTime(2025, 1, 3, 9, 54, 23, 678, DateTimeKind.Utc).AddTicks(293) },
                    { 17, 4, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 9, 49, 23, 678, DateTimeKind.Utc).AddTicks(293) },
                    { 18, 4, "Info", "Device operating normally.", "Server Monitoring", new DateTime(2025, 1, 3, 9, 44, 23, 678, DateTimeKind.Utc).AddTicks(294) },
                    { 19, 4, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 9, 39, 23, 678, DateTimeKind.Utc).AddTicks(294) },
                    { 20, 4, "Critical", "Device requires urgent attention.", "Server Monitoring", new DateTime(2025, 1, 3, 9, 34, 23, 678, DateTimeKind.Utc).AddTicks(295) },
                    { 21, 5, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 9, 29, 23, 678, DateTimeKind.Utc).AddTicks(295) },
                    { 22, 5, "Info", "Device operating normally.", "Server Monitoring", new DateTime(2025, 1, 3, 9, 24, 23, 678, DateTimeKind.Utc).AddTicks(295) },
                    { 23, 5, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 9, 19, 23, 678, DateTimeKind.Utc).AddTicks(296) },
                    { 24, 5, "Critical", "Device requires urgent attention.", "Server Monitoring", new DateTime(2025, 1, 3, 9, 14, 23, 678, DateTimeKind.Utc).AddTicks(296) },
                    { 25, 5, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 9, 9, 23, 678, DateTimeKind.Utc).AddTicks(296) },
                    { 26, 6, "Info", "Device operating normally.", "Server Monitoring", new DateTime(2025, 1, 3, 9, 4, 23, 678, DateTimeKind.Utc).AddTicks(297) },
                    { 27, 6, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 8, 59, 23, 678, DateTimeKind.Utc).AddTicks(297) },
                    { 28, 6, "Critical", "Device requires urgent attention.", "Server Monitoring", new DateTime(2025, 1, 3, 8, 54, 23, 678, DateTimeKind.Utc).AddTicks(298) },
                    { 29, 6, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 8, 49, 23, 678, DateTimeKind.Utc).AddTicks(298) },
                    { 30, 6, "Info", "Device operating normally.", "Server Monitoring", new DateTime(2025, 1, 3, 8, 44, 23, 678, DateTimeKind.Utc).AddTicks(299) },
                    { 31, 7, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 8, 39, 23, 678, DateTimeKind.Utc).AddTicks(299) },
                    { 32, 7, "Critical", "Device requires urgent attention.", "Server Monitoring", new DateTime(2025, 1, 3, 8, 34, 23, 678, DateTimeKind.Utc).AddTicks(299) },
                    { 33, 7, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 8, 29, 23, 678, DateTimeKind.Utc).AddTicks(300) },
                    { 34, 7, "Info", "Device operating normally.", "Server Monitoring", new DateTime(2025, 1, 3, 8, 24, 23, 678, DateTimeKind.Utc).AddTicks(300) },
                    { 35, 7, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 8, 19, 23, 678, DateTimeKind.Utc).AddTicks(301) },
                    { 36, 8, "Critical", "Device requires urgent attention.", "Server Monitoring", new DateTime(2025, 1, 3, 8, 14, 23, 678, DateTimeKind.Utc).AddTicks(301) },
                    { 37, 8, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 8, 9, 23, 678, DateTimeKind.Utc).AddTicks(301) },
                    { 38, 8, "Info", "Device operating normally.", "Server Monitoring", new DateTime(2025, 1, 3, 8, 4, 23, 678, DateTimeKind.Utc).AddTicks(302) },
                    { 39, 8, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 7, 59, 23, 678, DateTimeKind.Utc).AddTicks(302) },
                    { 40, 8, "Critical", "Device requires urgent attention.", "Server Monitoring", new DateTime(2025, 1, 3, 7, 54, 23, 678, DateTimeKind.Utc).AddTicks(303) },
                    { 41, 9, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 7, 49, 23, 678, DateTimeKind.Utc).AddTicks(303) },
                    { 42, 9, "Info", "Device operating normally.", "Server Monitoring", new DateTime(2025, 1, 3, 7, 44, 23, 678, DateTimeKind.Utc).AddTicks(303) },
                    { 43, 9, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 7, 39, 23, 678, DateTimeKind.Utc).AddTicks(304) },
                    { 44, 9, "Critical", "Device requires urgent attention.", "Server Monitoring", new DateTime(2025, 1, 3, 7, 34, 23, 678, DateTimeKind.Utc).AddTicks(304) },
                    { 45, 9, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 7, 29, 23, 678, DateTimeKind.Utc).AddTicks(304) },
                    { 46, 10, "Info", "Device operating normally.", "Server Monitoring", new DateTime(2025, 1, 3, 7, 24, 23, 678, DateTimeKind.Utc).AddTicks(305) },
                    { 47, 10, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 7, 19, 23, 678, DateTimeKind.Utc).AddTicks(305) },
                    { 48, 10, "Critical", "Device requires urgent attention.", "Server Monitoring", new DateTime(2025, 1, 3, 7, 14, 23, 678, DateTimeKind.Utc).AddTicks(306) },
                    { 49, 10, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 7, 9, 23, 678, DateTimeKind.Utc).AddTicks(306) },
                    { 50, 10, "Info", "Device operating normally.", "Server Monitoring", new DateTime(2025, 1, 3, 7, 4, 23, 678, DateTimeKind.Utc).AddTicks(306) },
                    { 51, 11, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 6, 59, 23, 678, DateTimeKind.Utc).AddTicks(307) },
                    { 52, 11, "Critical", "Device requires urgent attention.", "Server Monitoring", new DateTime(2025, 1, 3, 6, 54, 23, 678, DateTimeKind.Utc).AddTicks(307) },
                    { 53, 11, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 6, 49, 23, 678, DateTimeKind.Utc).AddTicks(308) },
                    { 54, 11, "Info", "Device operating normally.", "Server Monitoring", new DateTime(2025, 1, 3, 6, 44, 23, 678, DateTimeKind.Utc).AddTicks(308) },
                    { 55, 11, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 6, 39, 23, 678, DateTimeKind.Utc).AddTicks(308) },
                    { 56, 12, "Critical", "Device requires urgent attention.", "Server Monitoring", new DateTime(2025, 1, 3, 6, 34, 23, 678, DateTimeKind.Utc).AddTicks(309) },
                    { 57, 12, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 6, 29, 23, 678, DateTimeKind.Utc).AddTicks(309) },
                    { 58, 12, "Info", "Device operating normally.", "Server Monitoring", new DateTime(2025, 1, 3, 6, 24, 23, 678, DateTimeKind.Utc).AddTicks(309) },
                    { 59, 12, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 6, 19, 23, 678, DateTimeKind.Utc).AddTicks(310) },
                    { 60, 12, "Critical", "Device requires urgent attention.", "Server Monitoring", new DateTime(2025, 1, 3, 6, 14, 23, 678, DateTimeKind.Utc).AddTicks(310) },
                    { 61, 13, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 6, 9, 23, 678, DateTimeKind.Utc).AddTicks(311) },
                    { 62, 13, "Info", "Device operating normally.", "Server Monitoring", new DateTime(2025, 1, 3, 6, 4, 23, 678, DateTimeKind.Utc).AddTicks(311) },
                    { 63, 13, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 5, 59, 23, 678, DateTimeKind.Utc).AddTicks(344) },
                    { 64, 13, "Critical", "Device requires urgent attention.", "Server Monitoring", new DateTime(2025, 1, 3, 5, 54, 23, 678, DateTimeKind.Utc).AddTicks(345) },
                    { 65, 13, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 5, 49, 23, 678, DateTimeKind.Utc).AddTicks(346) },
                    { 66, 14, "Info", "Device operating normally.", "Server Monitoring", new DateTime(2025, 1, 3, 5, 44, 23, 678, DateTimeKind.Utc).AddTicks(346) },
                    { 67, 14, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 5, 39, 23, 678, DateTimeKind.Utc).AddTicks(347) },
                    { 68, 14, "Critical", "Device requires urgent attention.", "Server Monitoring", new DateTime(2025, 1, 3, 5, 34, 23, 678, DateTimeKind.Utc).AddTicks(347) },
                    { 69, 14, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 5, 29, 23, 678, DateTimeKind.Utc).AddTicks(348) },
                    { 70, 14, "Info", "Device operating normally.", "Server Monitoring", new DateTime(2025, 1, 3, 5, 24, 23, 678, DateTimeKind.Utc).AddTicks(348) },
                    { 71, 15, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 5, 19, 23, 678, DateTimeKind.Utc).AddTicks(348) },
                    { 72, 15, "Critical", "Device requires urgent attention.", "Server Monitoring", new DateTime(2025, 1, 3, 5, 14, 23, 678, DateTimeKind.Utc).AddTicks(349) },
                    { 73, 15, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 5, 9, 23, 678, DateTimeKind.Utc).AddTicks(349) },
                    { 74, 15, "Info", "Device operating normally.", "Server Monitoring", new DateTime(2025, 1, 3, 5, 4, 23, 678, DateTimeKind.Utc).AddTicks(350) },
                    { 75, 15, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 4, 59, 23, 678, DateTimeKind.Utc).AddTicks(350) },
                    { 76, 16, "Critical", "Device requires urgent attention.", "Server Monitoring", new DateTime(2025, 1, 3, 4, 54, 23, 678, DateTimeKind.Utc).AddTicks(350) },
                    { 77, 16, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 4, 49, 23, 678, DateTimeKind.Utc).AddTicks(351) },
                    { 78, 16, "Info", "Device operating normally.", "Server Monitoring", new DateTime(2025, 1, 3, 4, 44, 23, 678, DateTimeKind.Utc).AddTicks(351) },
                    { 79, 16, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 4, 39, 23, 678, DateTimeKind.Utc).AddTicks(352) },
                    { 80, 16, "Critical", "Device requires urgent attention.", "Server Monitoring", new DateTime(2025, 1, 3, 4, 34, 23, 678, DateTimeKind.Utc).AddTicks(352) },
                    { 81, 17, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 4, 29, 23, 678, DateTimeKind.Utc).AddTicks(352) },
                    { 82, 17, "Info", "Device operating normally.", "Server Monitoring", new DateTime(2025, 1, 3, 4, 24, 23, 678, DateTimeKind.Utc).AddTicks(353) },
                    { 83, 17, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 4, 19, 23, 678, DateTimeKind.Utc).AddTicks(353) },
                    { 84, 17, "Critical", "Device requires urgent attention.", "Server Monitoring", new DateTime(2025, 1, 3, 4, 14, 23, 678, DateTimeKind.Utc).AddTicks(353) },
                    { 85, 17, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 4, 9, 23, 678, DateTimeKind.Utc).AddTicks(354) },
                    { 86, 18, "Info", "Device operating normally.", "Server Monitoring", new DateTime(2025, 1, 3, 4, 4, 23, 678, DateTimeKind.Utc).AddTicks(354) },
                    { 87, 18, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 3, 59, 23, 678, DateTimeKind.Utc).AddTicks(355) },
                    { 88, 18, "Critical", "Device requires urgent attention.", "Server Monitoring", new DateTime(2025, 1, 3, 3, 54, 23, 678, DateTimeKind.Utc).AddTicks(355) },
                    { 89, 18, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 3, 49, 23, 678, DateTimeKind.Utc).AddTicks(355) },
                    { 90, 18, "Info", "Device operating normally.", "Server Monitoring", new DateTime(2025, 1, 3, 3, 44, 23, 678, DateTimeKind.Utc).AddTicks(356) },
                    { 91, 19, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 3, 39, 23, 678, DateTimeKind.Utc).AddTicks(356) },
                    { 92, 19, "Critical", "Device requires urgent attention.", "Server Monitoring", new DateTime(2025, 1, 3, 3, 34, 23, 678, DateTimeKind.Utc).AddTicks(357) },
                    { 93, 19, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 3, 29, 23, 678, DateTimeKind.Utc).AddTicks(357) },
                    { 94, 19, "Info", "Device operating normally.", "Server Monitoring", new DateTime(2025, 1, 3, 3, 24, 23, 678, DateTimeKind.Utc).AddTicks(357) },
                    { 95, 19, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 3, 19, 23, 678, DateTimeKind.Utc).AddTicks(358) },
                    { 96, 20, "Critical", "Device requires urgent attention.", "Server Monitoring", new DateTime(2025, 1, 3, 3, 14, 23, 678, DateTimeKind.Utc).AddTicks(358) },
                    { 97, 20, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 3, 9, 23, 678, DateTimeKind.Utc).AddTicks(358) },
                    { 98, 20, "Info", "Device operating normally.", "Server Monitoring", new DateTime(2025, 1, 3, 3, 4, 23, 678, DateTimeKind.Utc).AddTicks(359) },
                    { 99, 20, "Info", "Device operating normally.", "Authentication", new DateTime(2025, 1, 3, 2, 59, 23, 678, DateTimeKind.Utc).AddTicks(359) },
                    { 100, 20, "Critical", "Device requires urgent attention.", "Server Monitoring", new DateTime(2025, 1, 3, 2, 54, 23, 678, DateTimeKind.Utc).AddTicks(360) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CompanyName", "CreatedAt", "Email", "Name", "Password", "PhoneNumber", "ProfilePictureUrl", "SettingsId", "SurName" },
                values: new object[,]
                {
                    { 1, "TechCorp", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.doe@example.com", "John", "Pass@123", "+123456789", null, null, "Doe" },
                    { 2, "InnovateLtd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jane.smith@example.com", "Jane", "Jane@2024", "+987654321", null, null, "Smith" },
                    { 3, "FutureWorks", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "alice.brown@example.com", "Alice", "Alice@123", "+456789123", null, null, "Brown" },
                    { 4, "EnterpriseSolutions", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bob.johnson@example.com", "Bob", "Bob@Secure", "+321654987", null, null, "Johnson" },
                    { 5, "NextGenTech", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "charlie.davis@example.com", "Charlie", "Charlie@Secure", "+789123456", null, null, "Davis" }
                });

            migrationBuilder.InsertData(
                table: "Applications",
                columns: new[] { "Id", "CpuUsage", "DeviceId", "Name", "RamUsage", "RunningTime", "Status" },
                values: new object[,]
                {
                    { 1, 6.0, 1, "BackgroundApp1", 11.0, new TimeSpan(0, 1, 0, 0, 0), "Inactive" },
                    { 2, 7.0, 1, "BackgroundApp2", 12.0, new TimeSpan(0, 2, 0, 0, 0), "Inactive" },
                    { 3, 8.0, 1, "BackgroundApp3", 13.0, new TimeSpan(0, 3, 0, 0, 0), "Inactive" },
                    { 4, 9.0, 1, "BackgroundApp4", 14.0, new TimeSpan(0, 4, 0, 0, 0), "Inactive" },
                    { 5, 10.0, 1, "BackgroundApp5", 15.0, new TimeSpan(0, 5, 0, 0, 0), "Inactive" },
                    { 6, 11.0, 1, "BackgroundApp6", 16.0, new TimeSpan(0, 6, 0, 0, 0), "Inactive" },
                    { 7, 12.0, 1, "BackgroundApp7", 17.0, new TimeSpan(0, 7, 0, 0, 0), "Inactive" },
                    { 8, 13.0, 1, "BackgroundApp8", 18.0, new TimeSpan(0, 8, 0, 0, 0), "Inactive" },
                    { 9, 14.0, 1, "BackgroundApp9", 19.0, new TimeSpan(0, 9, 0, 0, 0), "Inactive" },
                    { 10, 5.0, 1, "BackgroundApp10", 20.0, new TimeSpan(0, 10, 0, 0, 0), "Inactive" },
                    { 11, 6.0, 1, "BackgroundApp11", 21.0, new TimeSpan(0, 11, 0, 0, 0), "Inactive" },
                    { 12, 7.0, 1, "BackgroundApp12", 22.0, new TimeSpan(0, 12, 0, 0, 0), "Inactive" },
                    { 13, 8.0, 1, "BackgroundApp13", 23.0, new TimeSpan(0, 13, 0, 0, 0), "Inactive" },
                    { 14, 9.0, 1, "BackgroundApp14", 24.0, new TimeSpan(0, 14, 0, 0, 0), "Inactive" },
                    { 15, 10.0, 1, "BackgroundApp15", 10.0, new TimeSpan(0, 15, 0, 0, 0), "Inactive" },
                    { 16, 11.0, 1, "BackgroundApp16", 11.0, new TimeSpan(0, 16, 0, 0, 0), "Inactive" },
                    { 17, 12.0, 1, "BackgroundApp17", 12.0, new TimeSpan(0, 17, 0, 0, 0), "Inactive" },
                    { 18, 13.0, 1, "BackgroundApp18", 13.0, new TimeSpan(0, 18, 0, 0, 0), "Inactive" },
                    { 19, 14.0, 1, "BackgroundApp19", 14.0, new TimeSpan(0, 19, 0, 0, 0), "Inactive" },
                    { 20, 5.0, 1, "BackgroundApp20", 15.0, new TimeSpan(0, 20, 0, 0, 0), "Inactive" },
                    { 21, 6.0, 1, "BackgroundApp21", 16.0, new TimeSpan(0, 21, 0, 0, 0), "Inactive" },
                    { 22, 7.0, 1, "BackgroundApp22", 17.0, new TimeSpan(0, 22, 0, 0, 0), "Inactive" },
                    { 23, 8.0, 1, "BackgroundApp23", 18.0, new TimeSpan(0, 23, 0, 0, 0), "Inactive" },
                    { 24, 9.0, 1, "BackgroundApp24", 19.0, new TimeSpan(0, 0, 0, 0, 0), "Inactive" },
                    { 25, 10.0, 1, "BackgroundApp25", 20.0, new TimeSpan(0, 1, 0, 0, 0), "Inactive" },
                    { 26, 11.0, 1, "BackgroundApp26", 21.0, new TimeSpan(0, 2, 0, 0, 0), "Inactive" },
                    { 27, 12.0, 1, "BackgroundApp27", 22.0, new TimeSpan(0, 3, 0, 0, 0), "Inactive" },
                    { 28, 13.0, 1, "BackgroundApp28", 23.0, new TimeSpan(0, 4, 0, 0, 0), "Inactive" },
                    { 29, 14.0, 1, "BackgroundApp29", 24.0, new TimeSpan(0, 5, 0, 0, 0), "Inactive" },
                    { 30, 5.0, 1, "BackgroundApp30", 10.0, new TimeSpan(0, 6, 0, 0, 0), "Inactive" },
                    { 31, 6.0, 1, "BackgroundApp31", 11.0, new TimeSpan(0, 7, 0, 0, 0), "Inactive" },
                    { 32, 7.0, 1, "BackgroundApp32", 12.0, new TimeSpan(0, 8, 0, 0, 0), "Inactive" },
                    { 33, 8.0, 1, "BackgroundApp33", 13.0, new TimeSpan(0, 9, 0, 0, 0), "Inactive" },
                    { 34, 9.0, 1, "BackgroundApp34", 14.0, new TimeSpan(0, 10, 0, 0, 0), "Inactive" },
                    { 35, 10.0, 1, "BackgroundApp35", 15.0, new TimeSpan(0, 11, 0, 0, 0), "Inactive" },
                    { 36, 11.0, 1, "BackgroundApp36", 16.0, new TimeSpan(0, 12, 0, 0, 0), "Inactive" },
                    { 37, 12.0, 1, "BackgroundApp37", 17.0, new TimeSpan(0, 13, 0, 0, 0), "Inactive" },
                    { 38, 13.0, 1, "BackgroundApp38", 18.0, new TimeSpan(0, 14, 0, 0, 0), "Inactive" },
                    { 39, 14.0, 1, "BackgroundApp39", 19.0, new TimeSpan(0, 15, 0, 0, 0), "Inactive" },
                    { 40, 5.0, 1, "BackgroundApp40", 20.0, new TimeSpan(0, 16, 0, 0, 0), "Inactive" },
                    { 41, 6.0, 1, "BackgroundApp41", 21.0, new TimeSpan(0, 17, 0, 0, 0), "Inactive" },
                    { 42, 7.0, 1, "BackgroundApp42", 22.0, new TimeSpan(0, 18, 0, 0, 0), "Inactive" },
                    { 43, 8.0, 1, "BackgroundApp43", 23.0, new TimeSpan(0, 19, 0, 0, 0), "Inactive" },
                    { 44, 9.0, 1, "BackgroundApp44", 24.0, new TimeSpan(0, 20, 0, 0, 0), "Inactive" },
                    { 45, 10.0, 1, "BackgroundApp45", 10.0, new TimeSpan(0, 21, 0, 0, 0), "Inactive" },
                    { 46, 11.0, 1, "BackgroundApp46", 11.0, new TimeSpan(0, 22, 0, 0, 0), "Inactive" },
                    { 47, 12.0, 1, "BackgroundApp47", 12.0, new TimeSpan(0, 23, 0, 0, 0), "Inactive" },
                    { 48, 13.0, 1, "BackgroundApp48", 13.0, new TimeSpan(0, 0, 0, 0, 0), "Inactive" },
                    { 49, 14.0, 1, "BackgroundApp49", 14.0, new TimeSpan(0, 1, 0, 0, 0), "Inactive" },
                    { 50, 5.0, 1, "BackgroundApp50", 15.0, new TimeSpan(0, 2, 0, 0, 0), "Inactive" },
                    { 51, 6.0, 1, "BackgroundApp51", 16.0, new TimeSpan(0, 3, 0, 0, 0), "Inactive" },
                    { 52, 7.0, 1, "BackgroundApp52", 17.0, new TimeSpan(0, 4, 0, 0, 0), "Inactive" },
                    { 53, 8.0, 1, "BackgroundApp53", 18.0, new TimeSpan(0, 5, 0, 0, 0), "Inactive" },
                    { 54, 9.0, 1, "BackgroundApp54", 19.0, new TimeSpan(0, 6, 0, 0, 0), "Inactive" },
                    { 55, 10.0, 1, "BackgroundApp55", 20.0, new TimeSpan(0, 7, 0, 0, 0), "Inactive" },
                    { 56, 11.0, 1, "BackgroundApp56", 21.0, new TimeSpan(0, 8, 0, 0, 0), "Inactive" },
                    { 57, 12.0, 1, "BackgroundApp57", 22.0, new TimeSpan(0, 9, 0, 0, 0), "Inactive" },
                    { 58, 13.0, 1, "BackgroundApp58", 23.0, new TimeSpan(0, 10, 0, 0, 0), "Inactive" },
                    { 59, 14.0, 1, "BackgroundApp59", 24.0, new TimeSpan(0, 11, 0, 0, 0), "Inactive" },
                    { 60, 5.0, 1, "BackgroundApp60", 10.0, new TimeSpan(0, 12, 0, 0, 0), "Inactive" },
                    { 61, 6.0, 1, "BackgroundApp61", 11.0, new TimeSpan(0, 13, 0, 0, 0), "Inactive" },
                    { 62, 7.0, 1, "BackgroundApp62", 12.0, new TimeSpan(0, 14, 0, 0, 0), "Inactive" },
                    { 63, 8.0, 1, "BackgroundApp63", 13.0, new TimeSpan(0, 15, 0, 0, 0), "Inactive" },
                    { 64, 9.0, 1, "BackgroundApp64", 14.0, new TimeSpan(0, 16, 0, 0, 0), "Inactive" },
                    { 65, 10.0, 1, "BackgroundApp65", 15.0, new TimeSpan(0, 17, 0, 0, 0), "Inactive" },
                    { 66, 11.0, 1, "BackgroundApp66", 16.0, new TimeSpan(0, 18, 0, 0, 0), "Inactive" },
                    { 67, 12.0, 1, "BackgroundApp67", 17.0, new TimeSpan(0, 19, 0, 0, 0), "Inactive" },
                    { 68, 13.0, 1, "BackgroundApp68", 18.0, new TimeSpan(0, 20, 0, 0, 0), "Inactive" },
                    { 69, 14.0, 1, "BackgroundApp69", 19.0, new TimeSpan(0, 21, 0, 0, 0), "Inactive" },
                    { 70, 5.0, 1, "BackgroundApp70", 20.0, new TimeSpan(0, 22, 0, 0, 0), "Inactive" },
                    { 71, 6.0, 1, "BackgroundApp71", 21.0, new TimeSpan(0, 23, 0, 0, 0), "Inactive" },
                    { 72, 7.0, 1, "BackgroundApp72", 22.0, new TimeSpan(0, 0, 0, 0, 0), "Inactive" },
                    { 73, 8.0, 1, "BackgroundApp73", 23.0, new TimeSpan(0, 1, 0, 0, 0), "Inactive" },
                    { 74, 9.0, 1, "BackgroundApp74", 24.0, new TimeSpan(0, 2, 0, 0, 0), "Inactive" },
                    { 75, 10.0, 1, "BackgroundApp75", 10.0, new TimeSpan(0, 3, 0, 0, 0), "Inactive" },
                    { 76, 11.0, 1, "BackgroundApp76", 11.0, new TimeSpan(0, 4, 0, 0, 0), "Inactive" },
                    { 77, 12.0, 1, "BackgroundApp77", 12.0, new TimeSpan(0, 5, 0, 0, 0), "Inactive" },
                    { 78, 13.0, 1, "BackgroundApp78", 13.0, new TimeSpan(0, 6, 0, 0, 0), "Inactive" },
                    { 79, 14.0, 1, "BackgroundApp79", 14.0, new TimeSpan(0, 7, 0, 0, 0), "Inactive" },
                    { 80, 5.0, 1, "BackgroundApp80", 15.0, new TimeSpan(0, 8, 0, 0, 0), "Inactive" },
                    { 81, 6.0, 1, "BackgroundApp81", 16.0, new TimeSpan(0, 9, 0, 0, 0), "Inactive" },
                    { 82, 7.0, 1, "BackgroundApp82", 17.0, new TimeSpan(0, 10, 0, 0, 0), "Inactive" },
                    { 83, 8.0, 1, "BackgroundApp83", 18.0, new TimeSpan(0, 11, 0, 0, 0), "Inactive" },
                    { 84, 9.0, 1, "BackgroundApp84", 19.0, new TimeSpan(0, 12, 0, 0, 0), "Inactive" },
                    { 85, 10.0, 1, "BackgroundApp85", 20.0, new TimeSpan(0, 13, 0, 0, 0), "Inactive" },
                    { 86, 11.0, 1, "BackgroundApp86", 21.0, new TimeSpan(0, 14, 0, 0, 0), "Inactive" },
                    { 87, 12.0, 1, "BackgroundApp87", 22.0, new TimeSpan(0, 15, 0, 0, 0), "Inactive" },
                    { 88, 13.0, 1, "BackgroundApp88", 23.0, new TimeSpan(0, 16, 0, 0, 0), "Inactive" },
                    { 89, 14.0, 1, "BackgroundApp89", 24.0, new TimeSpan(0, 17, 0, 0, 0), "Inactive" },
                    { 90, 5.0, 1, "BackgroundApp90", 10.0, new TimeSpan(0, 18, 0, 0, 0), "Inactive" },
                    { 91, 6.0, 1, "BackgroundApp91", 11.0, new TimeSpan(0, 19, 0, 0, 0), "Inactive" },
                    { 92, 7.0, 1, "BackgroundApp92", 12.0, new TimeSpan(0, 20, 0, 0, 0), "Inactive" },
                    { 93, 8.0, 1, "BackgroundApp93", 13.0, new TimeSpan(0, 21, 0, 0, 0), "Inactive" },
                    { 94, 9.0, 1, "BackgroundApp94", 14.0, new TimeSpan(0, 22, 0, 0, 0), "Inactive" },
                    { 95, 10.0, 1, "BackgroundApp95", 15.0, new TimeSpan(0, 23, 0, 0, 0), "Inactive" },
                    { 96, 11.0, 1, "BackgroundApp96", 16.0, new TimeSpan(0, 0, 0, 0, 0), "Inactive" },
                    { 97, 12.0, 1, "BackgroundApp97", 17.0, new TimeSpan(0, 1, 0, 0, 0), "Inactive" },
                    { 98, 13.0, 1, "BackgroundApp98", 18.0, new TimeSpan(0, 2, 0, 0, 0), "Inactive" },
                    { 99, 14.0, 1, "BackgroundApp99", 19.0, new TimeSpan(0, 3, 0, 0, 0), "Inactive" },
                    { 100, 5.0, 1, "BackgroundApp100", 20.0, new TimeSpan(0, 4, 0, 0, 0), "Inactive" },
                    { 101, 31.0, 1, "ActiveApp1", 51.0, new TimeSpan(0, 5, 0, 0, 0), "Active" },
                    { 102, 32.0, 1, "ActiveApp2", 52.0, new TimeSpan(0, 6, 0, 0, 0), "Active" },
                    { 103, 33.0, 1, "ActiveApp3", 53.0, new TimeSpan(0, 7, 0, 0, 0), "Active" },
                    { 104, 34.0, 1, "ActiveApp4", 54.0, new TimeSpan(0, 8, 0, 0, 0), "Active" },
                    { 105, 35.0, 1, "ActiveApp5", 55.0, new TimeSpan(0, 9, 0, 0, 0), "Active" },
                    { 106, 36.0, 1, "ActiveApp6", 56.0, new TimeSpan(0, 10, 0, 0, 0), "Active" },
                    { 107, 37.0, 1, "ActiveApp7", 57.0, new TimeSpan(0, 11, 0, 0, 0), "Active" },
                    { 108, 38.0, 1, "ActiveApp8", 58.0, new TimeSpan(0, 12, 0, 0, 0), "Active" }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "IsRead", "Message", "SentAt", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, false, "This is a test notification for user 1.", new DateTime(2025, 1, 3, 11, 9, 23, 678, DateTimeKind.Utc).AddTicks(2391), "Notification 1", 1 },
                    { 2, true, "This is a test notification for user 1.", new DateTime(2025, 1, 3, 11, 4, 23, 678, DateTimeKind.Utc).AddTicks(2487), "Notification 2", 1 },
                    { 3, false, "This is a test notification for user 1.", new DateTime(2025, 1, 3, 10, 59, 23, 678, DateTimeKind.Utc).AddTicks(2489), "Notification 3", 1 },
                    { 4, true, "This is a test notification for user 2.", new DateTime(2025, 1, 3, 10, 54, 23, 678, DateTimeKind.Utc).AddTicks(2491), "Notification 4", 2 },
                    { 5, false, "This is a test notification for user 2.", new DateTime(2025, 1, 3, 10, 49, 23, 678, DateTimeKind.Utc).AddTicks(2492), "Notification 5", 2 },
                    { 6, true, "This is a test notification for user 2.", new DateTime(2025, 1, 3, 10, 44, 23, 678, DateTimeKind.Utc).AddTicks(2494), "Notification 6", 2 },
                    { 7, false, "This is a test notification for user 3.", new DateTime(2025, 1, 3, 10, 39, 23, 678, DateTimeKind.Utc).AddTicks(2495), "Notification 7", 3 },
                    { 8, true, "This is a test notification for user 3.", new DateTime(2025, 1, 3, 10, 34, 23, 678, DateTimeKind.Utc).AddTicks(2496), "Notification 8", 3 },
                    { 9, false, "This is a test notification for user 3.", new DateTime(2025, 1, 3, 10, 29, 23, 678, DateTimeKind.Utc).AddTicks(2498), "Notification 9", 3 },
                    { 10, true, "This is a test notification for user 4.", new DateTime(2025, 1, 3, 10, 24, 23, 678, DateTimeKind.Utc).AddTicks(2500), "Notification 10", 4 },
                    { 11, false, "This is a test notification for user 4.", new DateTime(2025, 1, 3, 10, 19, 23, 678, DateTimeKind.Utc).AddTicks(2501), "Notification 11", 4 },
                    { 12, true, "This is a test notification for user 4.", new DateTime(2025, 1, 3, 10, 14, 23, 678, DateTimeKind.Utc).AddTicks(2502), "Notification 12", 4 },
                    { 13, false, "This is a test notification for user 5.", new DateTime(2025, 1, 3, 10, 9, 23, 678, DateTimeKind.Utc).AddTicks(2503), "Notification 13", 5 },
                    { 14, true, "This is a test notification for user 5.", new DateTime(2025, 1, 3, 10, 4, 23, 678, DateTimeKind.Utc).AddTicks(2504), "Notification 14", 5 },
                    { 15, false, "This is a test notification for user 5.", new DateTime(2025, 1, 3, 9, 59, 23, 678, DateTimeKind.Utc).AddTicks(2506), "Notification 15", 5 }
                });

            migrationBuilder.InsertData(
                table: "ResourceUsages",
                columns: new[] { "Id", "CpuUsage", "DeviceId", "DiskUsage", "RamUsage" },
                values: new object[] { 1, 45.5, 1, 78.099999999999994, 62.299999999999997 });

            migrationBuilder.CreateIndex(
                name: "IX_ResourceUsages_DeviceId",
                table: "ResourceUsages",
                column: "DeviceId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ResourceUsages_DeviceId",
                table: "ResourceUsages");

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ResourceUsages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1);

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
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ResourceUsages",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.CreateIndex(
                name: "IX_ResourceUsages_DeviceId",
                table: "ResourceUsages",
                column: "DeviceId");

            migrationBuilder.AddForeignKey(
                name: "FK_ResourceUsages_Devices_Id",
                table: "ResourceUsages",
                column: "Id",
                principalTable: "Devices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
