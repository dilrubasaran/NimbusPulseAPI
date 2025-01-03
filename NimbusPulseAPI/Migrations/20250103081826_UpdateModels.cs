using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NimbusPulseAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeviceDTO");

            migrationBuilder.DropColumn(
                name: "ApplicationsUsage",
                table: "ResourceUsages");

            migrationBuilder.DropColumn(
                name: "BackupsUsage",
                table: "ResourceUsages");

            migrationBuilder.DropColumn(
                name: "CpuUsagePercentage",
                table: "ResourceUsages");

            migrationBuilder.DropColumn(
                name: "DiskUsagePercentage",
                table: "ResourceUsages");

            migrationBuilder.DropColumn(
                name: "RamUsagePercentage",
                table: "ResourceUsages");

            migrationBuilder.RenameColumn(
                name: "UserFilesUsage",
                table: "ResourceUsages",
                newName: "RamUsage");

            migrationBuilder.RenameColumn(
                name: "TemporaryFilesUsage",
                table: "ResourceUsages",
                newName: "DiskUsage");

            migrationBuilder.RenameColumn(
                name: "SystemFilesUsage",
                table: "ResourceUsages",
                newName: "CpuUsage");

            migrationBuilder.RenameColumn(
                name: "RamUsagePercentage",
                table: "Applications",
                newName: "RamUsage");

            migrationBuilder.RenameColumn(
                name: "Duration",
                table: "Applications",
                newName: "RunningTime");

            migrationBuilder.RenameColumn(
                name: "CpuUsagePercentage",
                table: "Applications",
                newName: "CpuUsage");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RamUsage",
                table: "ResourceUsages",
                newName: "UserFilesUsage");

            migrationBuilder.RenameColumn(
                name: "DiskUsage",
                table: "ResourceUsages",
                newName: "TemporaryFilesUsage");

            migrationBuilder.RenameColumn(
                name: "CpuUsage",
                table: "ResourceUsages",
                newName: "SystemFilesUsage");

            migrationBuilder.RenameColumn(
                name: "RunningTime",
                table: "Applications",
                newName: "Duration");

            migrationBuilder.RenameColumn(
                name: "RamUsage",
                table: "Applications",
                newName: "RamUsagePercentage");

            migrationBuilder.RenameColumn(
                name: "CpuUsage",
                table: "Applications",
                newName: "CpuUsagePercentage");

            migrationBuilder.AddColumn<double>(
                name: "ApplicationsUsage",
                table: "ResourceUsages",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "BackupsUsage",
                table: "ResourceUsages",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "CpuUsagePercentage",
                table: "ResourceUsages",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "DiskUsagePercentage",
                table: "ResourceUsages",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "RamUsagePercentage",
                table: "ResourceUsages",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "DeviceDTO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HealthStatus = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceDTO", x => x.Id);
                });
        }
    }
}
