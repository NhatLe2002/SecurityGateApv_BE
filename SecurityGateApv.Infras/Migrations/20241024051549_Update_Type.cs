using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SecurityGateApv.Infras.Migrations
{
    /// <inheritdoc />
    public partial class Update_Type : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CredentialCardTypes",
                keyColumn: "CredentialCardTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CredentialCardTypes",
                keyColumn: "CredentialCardTypeId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Kế toán", "Occaecati accusamus temporibus modi voluptate quis." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng IT", "Ea eum qui ipsam aut maiores." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng R&D", "Fuga pariatur temporibus velit possimus." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng R&D", "Fuga et sunt alias eveniet nam odit ea ullam aut." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Chăm sóc khách hàng", "Accusamus similique distinctio sequi aut architecto enim itaque autem." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 6,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Marketing", "Totam corporis quidem perferendis." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 7,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng IT", "Et rem aut incidunt consequatur dolorem corporis fugit ut deleniti." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 8,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng IT", "Dicta quia nemo et repudiandae aliquam asperiores ut et aliquam." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 9,
                column: "Description",
                value: "Dolorem nihil assumenda.");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 10,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Marketing", "Eligendi veniam voluptas." });

            migrationBuilder.InsertData(
                table: "ScheduleTypes",
                columns: new[] { "ScheduleTypeId", "Description", "ScheduleTypeName", "Status" },
                values: new object[,]
                {
                    { 1, "Lịch trình đăng ký ra vào hàng ngày cho staff và bảo vệ", "VisitDaily", true },
                    { 2, "Lịch trình đăng ký ra vào theo tiến trình hàng tuần cho Department Manager", "ProcessWeek", true },
                    { 3, "Lịch trình đăng ký ra vào theo tiến trình hàng tháng cho Department Manager", "ProcessMonth", true },
                    { 4, "Lịch trình đăng ký ra vào theo dự án cho Department Manager", "Project", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ScheduleTypes",
                keyColumn: "ScheduleTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ScheduleTypes",
                keyColumn: "ScheduleTypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ScheduleTypes",
                keyColumn: "ScheduleTypeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ScheduleTypes",
                keyColumn: "ScheduleTypeId",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "CredentialCardTypes",
                columns: new[] { "CredentialCardTypeId", "CredentialCardTypeName", "Description", "Status" },
                values: new object[,]
                {
                    { 1, "Giấy phép lái xe", "A magni repellendus saepe voluptates qui non.", true },
                    { 2, "Căn cước công dân", "Delectus dolor totam qui consequatur.", true }
                });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng R&D", "Quia qui quis iure ut labore." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Sản xuất", "Fugit atque placeat numquam aliquid ipsa asperiores omnis velit magnam." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Marketing", "Ad corrupti quidem veritatis quam." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Pháp chế", "Et est corporis velit itaque in iure." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Sản xuất", "Blanditiis vitae qui quaerat eaque debitis accusamus saepe aut." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 6,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Kế toán", "Voluptatum numquam nemo fugit sequi expedita." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 7,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Sản xuất", "Ut praesentium aut porro voluptas fugiat magni natus voluptatem." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 8,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng R&D", "Non quos aliquam tenetur delectus distinctio." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 9,
                column: "Description",
                value: "Unde ea totam harum.");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 10,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng R&D", "Voluptatibus blanditiis beatae sequi ducimus ut similique minima." });
        }
    }
}
