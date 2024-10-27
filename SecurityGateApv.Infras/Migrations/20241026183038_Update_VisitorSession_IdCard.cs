using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecurityGateApv.Infras.Migrations
{
    /// <inheritdoc />
    public partial class Update_VisitorSession_IdCard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VisitorSessions_Cards_CardId",
                table: "VisitorSessions");

            migrationBuilder.DropIndex(
                name: "IX_VisitorSessions_CardId",
                table: "VisitorSessions");

            migrationBuilder.DropColumn(
                name: "CardId",
                table: "VisitorSessions");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CardId",
                table: "VisitorSessions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_VisitorSessions_CardId",
                table: "VisitorSessions",
                column: "CardId");

            migrationBuilder.AddForeignKey(
                name: "FK_VisitorSessions_Cards_CardId",
                table: "VisitorSessions",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "CardId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
