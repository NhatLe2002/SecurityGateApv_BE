using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecurityGateApv.Infras.Migrations
{
    /// <inheritdoc />
    public partial class NewTableScheduleUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ScheduleUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssignTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeadlineTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScheduleId = table.Column<int>(type: "int", nullable: false),
                    AssignToId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScheduleUsers_Schedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedules",
                        principalColumn: "ScheduleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScheduleUsers_Users_AssignToId",
                        column: x => x.AssignToId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "CredentialCardTypes",
                keyColumn: "CredentialCardTypeId",
                keyValue: 1,
                columns: new[] { "CredentialCardTypeName", "Description" },
                values: new object[] { "Căn cước công dân", "Ratione nemo modi animi veritatis et eius et voluptas." });

            migrationBuilder.UpdateData(
                table: "CredentialCardTypes",
                keyColumn: "CredentialCardTypeId",
                keyValue: 2,
                column: "Description",
                value: "Ipsa voluptatibus exercitationem aut ut libero amet.");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Marketing", "Doloribus omnis dolorum velit officia." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Sản xuất", "Quia nostrum cumque enim deleniti nesciunt vel." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Chăm sóc khách hàng", "Cupiditate aut rerum." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Kinh doanh", "Est delectus consequatur laudantium sunt incidunt laboriosam." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Chăm sóc khách hàng", "Ut quis quia aliquid praesentium." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 6,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng IT", "Id et fugit hic nihil." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 7,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Kinh doanh", "Quidem ut accusamus consequuntur suscipit sit repellat sit." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 8,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Pháp chế", "Molestiae distinctio velit et earum." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 9,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Kế toán", "Enim molestiae sit voluptas nisi labore expedita accusantium vitae numquam." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 10,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Sản xuất", "Corporis velit error consequatur tempora." });

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleUsers_AssignToId",
                table: "ScheduleUsers",
                column: "AssignToId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleUsers_ScheduleId",
                table: "ScheduleUsers",
                column: "ScheduleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScheduleUsers");

            migrationBuilder.UpdateData(
                table: "CredentialCardTypes",
                keyColumn: "CredentialCardTypeId",
                keyValue: 1,
                columns: new[] { "CredentialCardTypeName", "Description" },
                values: new object[] { "Giấy phép lái xe", "Occaecati quasi sunt et reiciendis voluptas dolore." });

            migrationBuilder.UpdateData(
                table: "CredentialCardTypes",
                keyColumn: "CredentialCardTypeId",
                keyValue: 2,
                column: "Description",
                value: "Fugit iure eum facere sequi quod a modi enim.");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Pháp chế", "Voluptatem officiis doloribus modi recusandae vel." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Hành chính", "Fuga assumenda reiciendis molestiae et voluptatem ut." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Marketing", "Aperiam veritatis sunt sit autem voluptatum dolores." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng R&D", "Quia ut dolore placeat non quibusdam non voluptates autem consequuntur." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Nhân sự", "Voluptas aut praesentium." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 6,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Nhân sự", "Nostrum consectetur et ullam omnis officiis illum praesentium consequuntur exercitationem." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 7,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng R&D", "Quo sit harum laboriosam accusantium aut ipsa numquam aut." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 8,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Sản xuất", "Quia pariatur numquam illo autem qui quia molestiae porro laboriosam." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 9,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Sản xuất", "At cupiditate nulla et officia vero molestiae cum consectetur." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 10,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng R&D", "Consequatur aut ex similique aut aliquid id aut rerum." });
        }
    }
}
