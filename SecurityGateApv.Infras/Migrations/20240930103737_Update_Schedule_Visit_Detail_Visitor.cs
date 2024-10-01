using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SecurityGateApv.Infras.Migrations
{
    /// <inheritdoc />
    public partial class Update_Schedule_Visit_Detail_Visitor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VisitorSessions_Gates_GateInId",
                table: "VisitorSessions");

            migrationBuilder.DropForeignKey(
                name: "FK_VisitorSessions_Users_SecurityInId",
                table: "VisitorSessions");

            migrationBuilder.DropForeignKey(
                name: "FK_Visits_Departments_DepartmentId",
                table: "Visits");

            migrationBuilder.DropForeignKey(
                name: "FK_Visits_Users_CreateById",
                table: "Visits");

            migrationBuilder.DropTable(
                name: "VisitorDepartment");

            migrationBuilder.DropTable(
                name: "VisitProcesses");

            migrationBuilder.DropTable(
                name: "Processes");

            migrationBuilder.DropTable(
                name: "VisitTypes");

            migrationBuilder.DropIndex(
                name: "IX_Visits_DepartmentId",
                table: "Visits");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Visits");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "VisitDetails");

            migrationBuilder.DropColumn(
                name: "ExpectedEndDate",
                table: "VisitDetails");

            migrationBuilder.DropColumn(
                name: "ExpectedStartDate",
                table: "VisitDetails");

            migrationBuilder.RenameColumn(
                name: "VisitType",
                table: "Visits",
                newName: "VisitStatus");

            migrationBuilder.RenameColumn(
                name: "DateRegister",
                table: "Visits",
                newName: "UpdateTime");

            migrationBuilder.RenameColumn(
                name: "AcceptLevel",
                table: "Visits",
                newName: "ScheduleId");

            migrationBuilder.RenameColumn(
                name: "ExpectedStartTime",
                table: "VisitDetails",
                newName: "ExpectedStartHour");

            migrationBuilder.RenameColumn(
                name: "ExpectedEndTime",
                table: "VisitDetails",
                newName: "ExpectedEndHour");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "Visits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpectedEndTime",
                table: "Visits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpectedStartTime",
                table: "Visits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "Visitors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Visitors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Visitors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Visitors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "VisitorCredentialImage",
                table: "Visitors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CredentialCardTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "CredentialCardTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "ScheduleTypes",
                columns: table => new
                {
                    ScheduleTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScheduleTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleTypes", x => x.ScheduleTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    ScheduleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScheduleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DaysOfProcess = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    ScheduleTypeId = table.Column<int>(type: "int", nullable: false),
                    CreateById = table.Column<int>(type: "int", nullable: false),
                    AssignToId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.ScheduleId);
                    table.ForeignKey(
                        name: "FK_Schedules_ScheduleTypes_ScheduleTypeId",
                        column: x => x.ScheduleTypeId,
                        principalTable: "ScheduleTypes",
                        principalColumn: "ScheduleTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Schedules_Users_AssignToId",
                        column: x => x.AssignToId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Schedules_Users_CreateById",
                        column: x => x.CreateById,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "CredentialCardTypes",
                keyColumn: "CredentialCardTypeId",
                keyValue: 1,
                columns: new[] { "Description", "Status" },
                values: new object[] { "Et error cumque.", true });

            migrationBuilder.UpdateData(
                table: "CredentialCardTypes",
                keyColumn: "CredentialCardTypeId",
                keyValue: 2,
                columns: new[] { "CredentialCardTypeName", "Description", "Status" },
                values: new object[] { "Giấy phép lái xe", "Modi voluptatem quis vitae ratione quia nam.", true });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Sản xuất", "Natus eum magni at." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Nhân sự", "Possimus ipsam quia rem molestiae cumque occaecati molestiae explicabo itaque." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Kinh doanh", "Delectus ut unde est ratione aspernatur aliquid praesentium odio tenetur." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Kinh doanh", "Molestiae cupiditate omnis rerum delectus est voluptatem nemo accusantium rerum." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Kế toán", "Sed officia dolores aut." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 6,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng R&D", "Aspernatur eum veniam sapiente." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 7,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Chăm sóc khách hàng", "Quibusdam et dolorem cupiditate suscipit rerum et." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 8,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Kế toán", "Vel ex voluptas quis." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 9,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Pháp chế", "Eveniet alias distinctio quam." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 10,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Marketing", "Totam est omnis laudantium corrupti quia temporibus quasi error iusto." });

            migrationBuilder.CreateIndex(
                name: "IX_Visits_ScheduleId",
                table: "Visits",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_AssignToId",
                table: "Schedules",
                column: "AssignToId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_CreateById",
                table: "Schedules",
                column: "CreateById");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_ScheduleTypeId",
                table: "Schedules",
                column: "ScheduleTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_VisitorSessions_Gates_GateInId",
                table: "VisitorSessions",
                column: "GateInId",
                principalTable: "Gates",
                principalColumn: "GateId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VisitorSessions_Users_SecurityInId",
                table: "VisitorSessions",
                column: "SecurityInId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Visits_Schedules_ScheduleId",
                table: "Visits",
                column: "ScheduleId",
                principalTable: "Schedules",
                principalColumn: "ScheduleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Visits_Users_CreateById",
                table: "Visits",
                column: "CreateById",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VisitorSessions_Gates_GateInId",
                table: "VisitorSessions");

            migrationBuilder.DropForeignKey(
                name: "FK_VisitorSessions_Users_SecurityInId",
                table: "VisitorSessions");

            migrationBuilder.DropForeignKey(
                name: "FK_Visits_Schedules_ScheduleId",
                table: "Visits");

            migrationBuilder.DropForeignKey(
                name: "FK_Visits_Users_CreateById",
                table: "Visits");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "ScheduleTypes");

            migrationBuilder.DropIndex(
                name: "IX_Visits_ScheduleId",
                table: "Visits");

            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "Visits");

            migrationBuilder.DropColumn(
                name: "ExpectedEndTime",
                table: "Visits");

            migrationBuilder.DropColumn(
                name: "ExpectedStartTime",
                table: "Visits");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "Visitors");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Visitors");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Visitors");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Visitors");

            migrationBuilder.DropColumn(
                name: "VisitorCredentialImage",
                table: "Visitors");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "CredentialCardTypes");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "CredentialCardTypes");

            migrationBuilder.RenameColumn(
                name: "VisitStatus",
                table: "Visits",
                newName: "VisitType");

            migrationBuilder.RenameColumn(
                name: "UpdateTime",
                table: "Visits",
                newName: "DateRegister");

            migrationBuilder.RenameColumn(
                name: "ScheduleId",
                table: "Visits",
                newName: "AcceptLevel");

            migrationBuilder.RenameColumn(
                name: "ExpectedStartHour",
                table: "VisitDetails",
                newName: "ExpectedStartTime");

            migrationBuilder.RenameColumn(
                name: "ExpectedEndHour",
                table: "VisitDetails",
                newName: "ExpectedEndTime");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Visits",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "VisitDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpectedEndDate",
                table: "VisitDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpectedStartDate",
                table: "VisitDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "VisitorDepartment",
                columns: table => new
                {
                    VisitorDepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    VisitorId = table.Column<int>(type: "int", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitorDepartment", x => x.VisitorDepartmentId);
                    table.ForeignKey(
                        name: "FK_VisitorDepartment_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VisitorDepartment_Visitors_VisitorId",
                        column: x => x.VisitorId,
                        principalTable: "Visitors",
                        principalColumn: "VisitorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VisitTypes",
                columns: table => new
                {
                    VisitTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VisitTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitTypes", x => x.VisitTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Processes",
                columns: table => new
                {
                    ProcessId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    VisitTypeId = table.Column<int>(type: "int", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProcessName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processes", x => x.ProcessId);
                    table.ForeignKey(
                        name: "FK_Processes_Users_CreateBy",
                        column: x => x.CreateBy,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Processes_VisitTypes_VisitTypeId",
                        column: x => x.VisitTypeId,
                        principalTable: "VisitTypes",
                        principalColumn: "VisitTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VisitProcesses",
                columns: table => new
                {
                    VisitProcessId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProcessId = table.Column<int>(type: "int", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: true),
                    DaysOfProcess = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpectedEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpectedEndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    ExpectedStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpectedStartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VisitQuantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitProcesses", x => x.VisitProcessId);
                    table.ForeignKey(
                        name: "FK_VisitProcesses_Processes_ProcessId",
                        column: x => x.ProcessId,
                        principalTable: "Processes",
                        principalColumn: "ProcessId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VisitProcesses_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "Visits",
                        principalColumn: "VisitId");
                });

            migrationBuilder.UpdateData(
                table: "CredentialCardTypes",
                keyColumn: "CredentialCardTypeId",
                keyValue: 2,
                column: "CredentialCardTypeName",
                value: "Căn cước công dân");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Chăm sóc khách hàng", "Omnis molestiae voluptatum est sit sequi magnam ullam." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng R&D", "Nobis voluptatem enim rerum voluptatem perferendis et." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Nhân sự", "Nihil voluptas sed expedita." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Pháp chế", "Animi necessitatibus quis veniam nemo enim non voluptatem impedit consequatur." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Pháp chế", "Ut quidem inventore necessitatibus porro atque velit et dolor minima." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 6,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Pháp chế", "Sapiente rem recusandae officia pariatur." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 7,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Pháp chế", "Dolorem necessitatibus cupiditate praesentium molestiae ullam." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 8,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Sản xuất", "Incidunt quod ad dicta vero aliquid sit dolores optio odit." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 9,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Chăm sóc khách hàng", "Hic minima voluptas consequuntur eos soluta suscipit." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 10,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Kế toán", "Eum magnam alias repellendus fugit fuga." });

            migrationBuilder.InsertData(
                table: "VisitTypes",
                columns: new[] { "VisitTypeId", "Description", "VisitTypeName" },
                values: new object[,]
                {
                    { 1, "Process trong tuần", "ProcessWeek" },
                    { 2, "Process trong tháng", "ProcessMonth" },
                    { 3, "Project", "Project" },
                    { 4, "Visit được tạo bởi staff", "VisitStaff" },
                    { 5, "Visit được tạo bởi security", "VisitSecurity" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Visits_DepartmentId",
                table: "Visits",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Processes_CreateBy",
                table: "Processes",
                column: "CreateBy");

            migrationBuilder.CreateIndex(
                name: "IX_Processes_VisitTypeId",
                table: "Processes",
                column: "VisitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitorDepartment_DepartmentId",
                table: "VisitorDepartment",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitorDepartment_VisitorId",
                table: "VisitorDepartment",
                column: "VisitorId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitProcesses_ProcessId",
                table: "VisitProcesses",
                column: "ProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitProcesses_VisitId",
                table: "VisitProcesses",
                column: "VisitId");

            migrationBuilder.AddForeignKey(
                name: "FK_VisitorSessions_Gates_GateInId",
                table: "VisitorSessions",
                column: "GateInId",
                principalTable: "Gates",
                principalColumn: "GateId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VisitorSessions_Users_SecurityInId",
                table: "VisitorSessions",
                column: "SecurityInId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Visits_Departments_DepartmentId",
                table: "Visits",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Visits_Users_CreateById",
                table: "Visits",
                column: "CreateById",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
