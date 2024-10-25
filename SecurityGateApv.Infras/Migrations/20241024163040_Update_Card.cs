using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecurityGateApv.Infras.Migrations
{
    /// <inheritdoc />
    public partial class Update_Card : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_QRCardTypes_QRCardTypeId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleSessions_VisitDetails_VisitDetailId",
                table: "VehicleSessions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QRCardTypes",
                table: "QRCardTypes");

            migrationBuilder.DropColumn(
                name: "IssuedDate",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "ReturnDate",
                table: "Cards");

            migrationBuilder.RenameTable(
                name: "QRCardTypes",
                newName: "CardTypes");

            migrationBuilder.RenameColumn(
                name: "QRCardTypeId",
                table: "Cards",
                newName: "CardTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Cards_QRCardTypeId",
                table: "Cards",
                newName: "IX_Cards_CardTypeId");

            migrationBuilder.RenameColumn(
                name: "QRCardTypeId",
                table: "CardTypes",
                newName: "CardTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardTypes",
                table: "CardTypes",
                column: "CardTypeId");

            migrationBuilder.CreateTable(
                name: "VisitCards",
                columns: table => new
                {
                    VisitCardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VisitCardStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VisitDetailId = table.Column<int>(type: "int", nullable: false),
                    CardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitCards", x => x.VisitCardId);
                    table.ForeignKey(
                        name: "FK_VisitCards_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "CardId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VisitCards_VisitDetails_VisitDetailId",
                        column: x => x.VisitDetailId,
                        principalTable: "VisitDetails",
                        principalColumn: "VisitDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                column: "RoleName",
                value: "DepartmentManager");

            migrationBuilder.CreateIndex(
                name: "IX_VisitCards_CardId",
                table: "VisitCards",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitCards_VisitDetailId",
                table: "VisitCards",
                column: "VisitDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_CardTypes_CardTypeId",
                table: "Cards",
                column: "CardTypeId",
                principalTable: "CardTypes",
                principalColumn: "CardTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleSessions_VisitDetails_VisitDetailId",
                table: "VehicleSessions",
                column: "VisitDetailId",
                principalTable: "VisitDetails",
                principalColumn: "VisitDetailId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_CardTypes_CardTypeId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleSessions_VisitDetails_VisitDetailId",
                table: "VehicleSessions");

            migrationBuilder.DropTable(
                name: "VisitCards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CardTypes",
                table: "CardTypes");

            migrationBuilder.RenameTable(
                name: "CardTypes",
                newName: "QRCardTypes");

            migrationBuilder.RenameColumn(
                name: "CardTypeId",
                table: "Cards",
                newName: "QRCardTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Cards_CardTypeId",
                table: "Cards",
                newName: "IX_Cards_QRCardTypeId");

            migrationBuilder.RenameColumn(
                name: "CardTypeId",
                table: "QRCardTypes",
                newName: "QRCardTypeId");

            migrationBuilder.AddColumn<DateTime>(
                name: "IssuedDate",
                table: "Cards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ReturnDate",
                table: "Cards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_QRCardTypes",
                table: "QRCardTypes",
                column: "QRCardTypeId");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                column: "RoleName",
                value: "DepartmentManaager");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_QRCardTypes_QRCardTypeId",
                table: "Cards",
                column: "QRCardTypeId",
                principalTable: "QRCardTypes",
                principalColumn: "QRCardTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleSessions_VisitDetails_VisitDetailId",
                table: "VehicleSessions",
                column: "VisitDetailId",
                principalTable: "VisitDetails",
                principalColumn: "VisitDetailId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
