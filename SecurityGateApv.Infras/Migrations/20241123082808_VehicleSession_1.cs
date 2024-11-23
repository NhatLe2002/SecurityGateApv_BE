using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecurityGateApv.Infras.Migrations
{
    /// <inheritdoc />
    public partial class VehicleSession_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehicleSessions_Gates_GateId",
                table: "VehicleSessions");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleSessions_Users_SecurityID",
                table: "VehicleSessions");

            migrationBuilder.RenameColumn(
                name: "SecurityID",
                table: "VehicleSessions",
                newName: "SecurityInId");

            migrationBuilder.RenameColumn(
                name: "GateId",
                table: "VehicleSessions",
                newName: "GateInId");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleSessions_SecurityID",
                table: "VehicleSessions",
                newName: "IX_VehicleSessions_SecurityInId");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleSessions_GateId",
                table: "VehicleSessions",
                newName: "IX_VehicleSessions_GateInId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckoutTime",
                table: "VehicleSessions",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "GateOutId",
                table: "VehicleSessions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SecurityOutId",
                table: "VehicleSessions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "VehicleSessions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "VehicleSessions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VehicleSessions_GateOutId",
                table: "VehicleSessions",
                column: "GateOutId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleSessions_SecurityOutId",
                table: "VehicleSessions",
                column: "SecurityOutId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleSessions_UserId",
                table: "VehicleSessions",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleSessions_Gates_GateInId",
                table: "VehicleSessions",
                column: "GateInId",
                principalTable: "Gates",
                principalColumn: "GateId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleSessions_Gates_GateOutId",
                table: "VehicleSessions",
                column: "GateOutId",
                principalTable: "Gates",
                principalColumn: "GateId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleSessions_Users_SecurityInId",
                table: "VehicleSessions",
                column: "SecurityInId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleSessions_Users_SecurityOutId",
                table: "VehicleSessions",
                column: "SecurityOutId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleSessions_Users_UserId",
                table: "VehicleSessions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehicleSessions_Gates_GateInId",
                table: "VehicleSessions");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleSessions_Gates_GateOutId",
                table: "VehicleSessions");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleSessions_Users_SecurityInId",
                table: "VehicleSessions");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleSessions_Users_SecurityOutId",
                table: "VehicleSessions");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleSessions_Users_UserId",
                table: "VehicleSessions");

            migrationBuilder.DropIndex(
                name: "IX_VehicleSessions_GateOutId",
                table: "VehicleSessions");

            migrationBuilder.DropIndex(
                name: "IX_VehicleSessions_SecurityOutId",
                table: "VehicleSessions");

            migrationBuilder.DropIndex(
                name: "IX_VehicleSessions_UserId",
                table: "VehicleSessions");

            migrationBuilder.DropColumn(
                name: "GateOutId",
                table: "VehicleSessions");

            migrationBuilder.DropColumn(
                name: "SecurityOutId",
                table: "VehicleSessions");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "VehicleSessions");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "VehicleSessions");

            migrationBuilder.RenameColumn(
                name: "SecurityInId",
                table: "VehicleSessions",
                newName: "SecurityID");

            migrationBuilder.RenameColumn(
                name: "GateInId",
                table: "VehicleSessions",
                newName: "GateId");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleSessions_SecurityInId",
                table: "VehicleSessions",
                newName: "IX_VehicleSessions_SecurityID");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleSessions_GateInId",
                table: "VehicleSessions",
                newName: "IX_VehicleSessions_GateId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckoutTime",
                table: "VehicleSessions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleSessions_Gates_GateId",
                table: "VehicleSessions",
                column: "GateId",
                principalTable: "Gates",
                principalColumn: "GateId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleSessions_Users_SecurityID",
                table: "VehicleSessions",
                column: "SecurityID",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
