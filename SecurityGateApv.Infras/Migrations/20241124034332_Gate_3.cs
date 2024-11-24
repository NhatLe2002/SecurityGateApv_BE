using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecurityGateApv.Infras.Migrations
{
    /// <inheritdoc />
    public partial class Gate_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Camera_CameraType_CameraTypeId",
                table: "Camera");

            migrationBuilder.DropForeignKey(
                name: "FK_Camera_Gates_GateId",
                table: "Camera");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CameraType",
                table: "CameraType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Camera",
                table: "Camera");

            migrationBuilder.RenameTable(
                name: "CameraType",
                newName: "CameraTypes");

            migrationBuilder.RenameTable(
                name: "Camera",
                newName: "Cameras");

            migrationBuilder.RenameIndex(
                name: "IX_Camera_GateId",
                table: "Cameras",
                newName: "IX_Cameras_GateId");

            migrationBuilder.RenameIndex(
                name: "IX_Camera_CameraTypeId",
                table: "Cameras",
                newName: "IX_Cameras_CameraTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CameraTypes",
                table: "CameraTypes",
                column: "CameraTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cameras",
                table: "Cameras",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cameras_CameraTypes_CameraTypeId",
                table: "Cameras",
                column: "CameraTypeId",
                principalTable: "CameraTypes",
                principalColumn: "CameraTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cameras_Gates_GateId",
                table: "Cameras",
                column: "GateId",
                principalTable: "Gates",
                principalColumn: "GateId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cameras_CameraTypes_CameraTypeId",
                table: "Cameras");

            migrationBuilder.DropForeignKey(
                name: "FK_Cameras_Gates_GateId",
                table: "Cameras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CameraTypes",
                table: "CameraTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cameras",
                table: "Cameras");

            migrationBuilder.RenameTable(
                name: "CameraTypes",
                newName: "CameraType");

            migrationBuilder.RenameTable(
                name: "Cameras",
                newName: "Camera");

            migrationBuilder.RenameIndex(
                name: "IX_Cameras_GateId",
                table: "Camera",
                newName: "IX_Camera_GateId");

            migrationBuilder.RenameIndex(
                name: "IX_Cameras_CameraTypeId",
                table: "Camera",
                newName: "IX_Camera_CameraTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CameraType",
                table: "CameraType",
                column: "CameraTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Camera",
                table: "Camera",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Camera_CameraType_CameraTypeId",
                table: "Camera",
                column: "CameraTypeId",
                principalTable: "CameraType",
                principalColumn: "CameraTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Camera_Gates_GateId",
                table: "Camera",
                column: "GateId",
                principalTable: "Gates",
                principalColumn: "GateId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
