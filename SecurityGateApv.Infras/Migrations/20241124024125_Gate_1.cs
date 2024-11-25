using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SecurityGateApv.Infras.Migrations
{
    /// <inheritdoc />
    public partial class Gate_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GateCoordinate",
                table: "Gates",
                newName: "Description");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Gates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Gates",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "CameraType",
                columns: table => new
                {
                    CameraTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CameraTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CameraType", x => x.CameraTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Camera",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaptureURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreamURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GateId = table.Column<int>(type: "int", nullable: false),
                    CameraTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Camera", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Camera_CameraType_CameraTypeId",
                        column: x => x.CameraTypeId,
                        principalTable: "CameraType",
                        principalColumn: "CameraTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Camera_Gates_GateId",
                        column: x => x.GateId,
                        principalTable: "Gates",
                        principalColumn: "GateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CameraType",
                columns: new[] { "CameraTypeId", "CameraTypeName", "Description" },
                values: new object[,]
                {
                    { 1, "Visitor_Body", "Camera chụp toàn thân." },
                    { 2, "Visitor_Shoe", "Camera chụp giày." }
                });

            migrationBuilder.UpdateData(
                table: "Gates",
                keyColumn: "GateId",
                keyValue: 1,
                columns: new[] { "CreateDate", "Description", "GateName", "Status" },
                values: new object[] { new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cổng A", "Cổng A", true });

            migrationBuilder.UpdateData(
                table: "Gates",
                keyColumn: "GateId",
                keyValue: 2,
                columns: new[] { "CreateDate", "Description", "GateName", "Status" },
                values: new object[] { new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cổng B", "Cổng B", true });

            migrationBuilder.InsertData(
                table: "Camera",
                columns: new[] { "Id", "CameraTypeId", "CaptureURL", "Description", "GateId", "Status", "StreamURL" },
                values: new object[] { 1, 1, "https://security-gateway-camera-1.tools.kozow.com/capture-image", "Camera setup cho chụp toàn thân.", 1, "Active", "https://security-gateway-camera-1.tools.kozow.com/libs/index.m3u8" });

            migrationBuilder.CreateIndex(
                name: "IX_Camera_CameraTypeId",
                table: "Camera",
                column: "CameraTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Camera_GateId",
                table: "Camera",
                column: "GateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Camera");

            migrationBuilder.DropTable(
                name: "CameraType");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Gates");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Gates");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Gates",
                newName: "GateCoordinate");

            migrationBuilder.UpdateData(
                table: "Gates",
                keyColumn: "GateId",
                keyValue: 1,
                columns: new[] { "GateCoordinate", "GateName" },
                values: new object[] { "Ra vào trong ngày", "Cổng 1" });

            migrationBuilder.UpdateData(
                table: "Gates",
                keyColumn: "GateId",
                keyValue: 2,
                columns: new[] { "GateCoordinate", "GateName" },
                values: new object[] { "Ra vào trong ngày", "Cổng 2" });
        }
    }
}
