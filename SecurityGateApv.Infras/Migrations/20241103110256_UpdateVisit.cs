using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecurityGateApv.Infras.Migrations
{
    /// <inheritdoc />
    public partial class UpdateVisit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visits_ScheduleUsers_ScheduleUserId",
                table: "Visits");

            migrationBuilder.AlterColumn<int>(
                name: "ScheduleUserId",
                table: "Visits",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Visits_ScheduleUsers_ScheduleUserId",
                table: "Visits",
                column: "ScheduleUserId",
                principalTable: "ScheduleUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visits_ScheduleUsers_ScheduleUserId",
                table: "Visits");

            migrationBuilder.AlterColumn<int>(
                name: "ScheduleUserId",
                table: "Visits",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Visits_ScheduleUsers_ScheduleUserId",
                table: "Visits",
                column: "ScheduleUserId",
                principalTable: "ScheduleUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
