using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SecurityGateApv.Infras.Migrations
{
    /// <inheritdoc />
    public partial class Update_Department : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 10);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                columns: new[] { "AcceptLevel", "DepartmentName", "Description", "Status", "UpdatedDate" },
                values: new object[] { 1, "AdminDepartment", "Phòng ban riêng cho admin", "Active", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "AcceptLevel", "DepartmentName", "Description", "Status", "UpdatedDate" },
                values: new object[] { 1, "ManagerDepartment", "Phòng ban riêng cho quản lý", "Active", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "AcceptLevel", "DepartmentName", "Description", "Status", "UpdatedDate" },
                values: new object[] { 1, "SecurityDepartment", "Phòng ban riêng cho quản security", "Active", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4,
                columns: new[] { "AcceptLevel", "DepartmentName", "Description", "Status", "UpdatedDate" },
                values: new object[] { 1, "Phòng Nhân sự", "Phòng nhân sự", "Active", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5,
                columns: new[] { "AcceptLevel", "DepartmentName", "Description", "Status", "UpdatedDate" },
                values: new object[] { 1, "Phòng Sản xuất", "Phòng Sản xuất", "Active", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DepartmentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DepartmentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "DepartmentId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "DepartmentId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "DepartmentId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "DepartmentId",
                value: 3);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Departments");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                columns: new[] { "AcceptLevel", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 2, "Phòng Kinh doanh", "Facere rem eius dolore aut ad.", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "AcceptLevel", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 2, "Phòng Kinh doanh", "Odit accusantium et explicabo sunt magnam.", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "AcceptLevel", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 2, "Phòng R&D", "Temporibus officia magni voluptas porro vitae corrupti doloribus doloremque.", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4,
                columns: new[] { "AcceptLevel", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 2, "Phòng R&D", "Est perspiciatis ullam quia hic minima.", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5,
                columns: new[] { "AcceptLevel", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 2, "Phòng Kinh doanh", "Itaque consequatur inventore voluptate quia incidunt doloribus corporis.", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[,]
                {
                    { 6, 2, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phòng Marketing", "Voluptas optio quibusdam alias et maiores.", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 2, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phòng Hành chính", "Minima aut voluptas.", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 2, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phòng R&D", "Debitis architecto dolores neque et consequatur laboriosam eius vel.", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 2, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phòng Kế toán", "Perferendis tenetur corrupti expedita est consequuntur doloremque consequatur quia.", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 2, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phòng Chăm sóc khách hàng", "Dolorem laborum et nihil aut tenetur sed non sit.", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DepartmentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DepartmentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "DepartmentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "DepartmentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "DepartmentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "DepartmentId",
                value: null);
        }
    }
}
