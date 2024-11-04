using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecurityGateApv.Infras.Migrations
{
    /// <inheritdoc />
    public partial class Update_Delete_Duration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Schedules");

            migrationBuilder.UpdateData(
                table: "CardTypes",
                keyColumn: "CardTypeId",
                keyValue: 1,
                columns: new[] { "CardTypeName", "TypeDescription" },
                values: new object[] { "ShotTermCard", "Thẻ cho ra vào hằng ngày" });

            migrationBuilder.UpdateData(
                table: "CardTypes",
                keyColumn: "CardTypeId",
                keyValue: 2,
                columns: new[] { "CardTypeName", "TypeDescription" },
                values: new object[] { "LongTermCard", "Thẻ cho ra vào theo lịch trình" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Duration",
                table: "Schedules",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "CardTypes",
                keyColumn: "CardTypeId",
                keyValue: 1,
                columns: new[] { "CardTypeName", "TypeDescription" },
                values: new object[] { "Vehicle", "Vehicle QR Card" });

            migrationBuilder.UpdateData(
                table: "CardTypes",
                keyColumn: "CardTypeId",
                keyValue: 2,
                columns: new[] { "CardTypeName", "TypeDescription" },
                values: new object[] { "Visitor", "Visitor QR Card" });
        }
    }
}
