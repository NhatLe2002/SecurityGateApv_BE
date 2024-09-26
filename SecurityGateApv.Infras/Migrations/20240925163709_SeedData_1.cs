using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SecurityGateApv.Infras.Migrations
{
    /// <inheritdoc />
    public partial class SeedData_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_VisitTypes_Visittype",
                table: "Projects");

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 30);

            migrationBuilder.RenameColumn(
                name: "Visittype",
                table: "Projects",
                newName: "VisitTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_Visittype",
                table: "Projects",
                newName: "IX_Projects_VisitTypeId");

            migrationBuilder.UpdateData(
                table: "CredentialCardTypes",
                keyColumn: "CredentialCardTypeId",
                keyValue: 1,
                column: "CredentialCardTypeName",
                value: "Giấy phép lái xe");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2024, 9, 10, 21, 10, 25, 19, DateTimeKind.Utc).AddTicks(2219), "Phòng R&D", "Placeat repellendus odio quam omnis tenetur cupiditate cum exercitationem.", new DateTime(2024, 9, 10, 21, 10, 25, 19, DateTimeKind.Utc).AddTicks(2219) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2024, 9, 20, 14, 49, 11, 296, DateTimeKind.Utc).AddTicks(2904), "Phòng IT", "Sit exercitationem eum.", new DateTime(2024, 9, 20, 14, 49, 11, 296, DateTimeKind.Utc).AddTicks(2904) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 4, new DateTime(2024, 9, 15, 2, 13, 8, 15, DateTimeKind.Utc).AddTicks(3930), "Phòng IT", "Ducimus est ipsa sequi omnis.", new DateTime(2024, 9, 15, 2, 13, 8, 15, DateTimeKind.Utc).AddTicks(3930) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 9, 12, 13, 59, 476, DateTimeKind.Utc).AddTicks(5430), "Phòng Sản xuất", "Ratione quia dignissimos alias ut quos a similique.", new DateTime(2024, 9, 9, 12, 13, 59, 476, DateTimeKind.Utc).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5,
                columns: new[] { "AcceptLevel", "CreateDate", "Description", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 25, 1, 41, 46, 144, DateTimeKind.Utc).AddTicks(2667), "Et enim mollitia accusamus vel ut velit ut alias esse.", new DateTime(2024, 9, 25, 1, 41, 46, 144, DateTimeKind.Utc).AddTicks(2667) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 6,
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 23, 13, 55, 28, 871, DateTimeKind.Utc).AddTicks(1981), "Phòng Chăm sóc khách hàng", "Et maxime illum sed sequi eaque maiores.", new DateTime(2024, 9, 23, 13, 55, 28, 871, DateTimeKind.Utc).AddTicks(1981) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 7,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 4, new DateTime(2024, 9, 20, 10, 39, 59, 457, DateTimeKind.Utc).AddTicks(8617), "Phòng Pháp chế", "Nulla voluptatum consequatur quo nostrum maiores.", new DateTime(2024, 9, 20, 10, 39, 59, 457, DateTimeKind.Utc).AddTicks(8617) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 8,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 11, 14, 39, 54, 527, DateTimeKind.Utc).AddTicks(2139), "Phòng Marketing", "Dolores nemo officia placeat ut ipsa.", new DateTime(2024, 9, 11, 14, 39, 54, 527, DateTimeKind.Utc).AddTicks(2139) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 9,
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 24, 8, 55, 7, 86, DateTimeKind.Utc).AddTicks(1707), "Phòng Marketing", "Aspernatur et quas voluptatibus ut praesentium voluptatibus eos enim modi.", new DateTime(2024, 9, 24, 8, 55, 7, 86, DateTimeKind.Utc).AddTicks(1707) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 10,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 4, new DateTime(2024, 9, 20, 20, 33, 26, 595, DateTimeKind.Utc).AddTicks(7604), "Phòng Nhân sự", "Debitis aut et.", new DateTime(2024, 9, 20, 20, 33, 26, 595, DateTimeKind.Utc).AddTicks(7604) });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 1,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 1, 3 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 2,
                column: "DepartmentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 3,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 4,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 24 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 5,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 5, 17 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 6,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 6, 13 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 7,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 6 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 8,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 5, 16 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 9,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 22 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 10,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 8 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 11,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 2, 14 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 12,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 10, 12 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 13,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 10, 10 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 14,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 23 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 15,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 10, 13 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 16,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 9 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 17,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 3, 20 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 18,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 23 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 19,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 25 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 20,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 16 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 21,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 1, 24 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 22,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 21 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 23,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 3, 10 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 25, 16, 37, 8, 620, DateTimeKind.Utc).AddTicks(5898), new DateTime(2024, 9, 25, 16, 37, 8, 620, DateTimeKind.Utc).AddTicks(5907) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 25, 16, 37, 8, 620, DateTimeKind.Utc).AddTicks(5910), new DateTime(2024, 9, 25, 16, 37, 8, 620, DateTimeKind.Utc).AddTicks(5911) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 16, 37, 8, 620, DateTimeKind.Utc).AddTicks(5912), new DateTime(2024, 9, 25, 16, 37, 8, 620, DateTimeKind.Utc).AddTicks(5913) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 25, 16, 37, 8, 620, DateTimeKind.Utc).AddTicks(5914), new DateTime(2024, 9, 25, 16, 37, 8, 620, DateTimeKind.Utc).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 25, 16, 37, 8, 620, DateTimeKind.Utc).AddTicks(5916), new DateTime(2024, 9, 25, 16, 37, 8, 620, DateTimeKind.Utc).AddTicks(5917) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 5, 2, 13, 20, 77, DateTimeKind.Unspecified).AddTicks(87), "gmail.com_Brown39@hotmail.com", "Alfredo Sipes", "wd39ew", "0969958184", 3, new DateTime(2024, 9, 5, 2, 13, 20, 77, DateTimeKind.Unspecified).AddTicks(87), "Rylan4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 22, 10, 56, 22, 896, DateTimeKind.Unspecified).AddTicks(7003), "gmail.com_Hagenes72@hotmail.com", "Halle Donnelly", "qiltro", "0806279462", 4, new DateTime(2024, 9, 22, 10, 56, 22, 896, DateTimeKind.Unspecified).AddTicks(7003), "Lolita.Bergnaum" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 12, 6, 45, 7, 54, DateTimeKind.Unspecified).AddTicks(1257), "gmail.com_Howell@yahoo.com", "Percival O'Kon", "kt666z", "0673439234", 3, new DateTime(2024, 9, 12, 6, 45, 7, 54, DateTimeKind.Unspecified).AddTicks(1257), "Rupert_Jakubowski6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 19, 3, 19, 43, 194, DateTimeKind.Unspecified).AddTicks(8507), "gmail.com39@gmail.com", "Jabari Ferry", "880sxv", "0901182356", 2, new DateTime(2024, 9, 19, 3, 19, 43, 194, DateTimeKind.Unspecified).AddTicks(8507), "Caroline31" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 1, 7, 35, 2, 933, DateTimeKind.Unspecified).AddTicks(3032), "gmail.com92@gmail.com", "Delilah Waelchi", "44up9w", "0214577535", 5, new DateTime(2024, 9, 1, 7, 35, 2, 933, DateTimeKind.Unspecified).AddTicks(3032), "Quinn1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 13, 14, 34, 59, 254, DateTimeKind.Unspecified).AddTicks(6747), "gmail.com.Hartmann@hotmail.com", "Marcos Schoen", "hmvh67", "0763492957", new DateTime(2024, 9, 13, 14, 34, 59, 254, DateTimeKind.Unspecified).AddTicks(6747), "Elza58" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 25, 5, 1, 12, 779, DateTimeKind.Unspecified).AddTicks(864), "gmail.com_Cartwright@yahoo.com", "Misty Graham", "jt6405", "0846014889", new DateTime(2024, 9, 25, 5, 1, 12, 779, DateTimeKind.Unspecified).AddTicks(864), "Letitia26" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 1, 4, 57, 34, 884, DateTimeKind.Unspecified).AddTicks(2528), "gmail.com_Lockman@gmail.com", "Ransom Champlin", "e88z0v", "0751374192", 5, new DateTime(2024, 9, 1, 4, 57, 34, 884, DateTimeKind.Unspecified).AddTicks(2528), "Samantha.Schuster67" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 57, 51, 223, DateTimeKind.Unspecified).AddTicks(1512), "gmail.com.Keeling@yahoo.com", "Keshawn Pfeffer", "8c02bw", "0786592061", 5, new DateTime(2024, 9, 24, 12, 57, 51, 223, DateTimeKind.Unspecified).AddTicks(1512), "Antonio54" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 13, 2, 18, 14, 149, DateTimeKind.Unspecified).AddTicks(6270), "gmail.com.Reichert21@yahoo.com", "Kiara Zboncak", "zv2t44", "0760142298", 1, new DateTime(2024, 9, 13, 2, 18, 14, 149, DateTimeKind.Unspecified).AddTicks(6270), "Evalyn_McLaughlin11" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 8, 12, 51, 17, 661, DateTimeKind.Unspecified).AddTicks(4496), "gmail.com_Littel@yahoo.com", "Hollie Murray", "sb4o1x", "0114739383", 4, new DateTime(2024, 9, 8, 12, 51, 17, 661, DateTimeKind.Unspecified).AddTicks(4496), "Joany28" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 17, 10, 44, 40, 887, DateTimeKind.Unspecified).AddTicks(2442), "gmail.com87@yahoo.com", "Forrest VonRueden", "qc9ftf", "0751140931", 1, new DateTime(2024, 9, 17, 10, 44, 40, 887, DateTimeKind.Unspecified).AddTicks(2442), "Johnathan34" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 21, 17, 43, 21, 512, DateTimeKind.Unspecified).AddTicks(455), "gmail.com.Nicolas61@gmail.com", "Lowell Kulas", "pssbut", "0289278894", 2, new DateTime(2024, 9, 21, 17, 43, 21, 512, DateTimeKind.Unspecified).AddTicks(455), "Mckayla62" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 23, 5, 46, 14, 16, DateTimeKind.Unspecified).AddTicks(5797), "gmail.com.Beahan@hotmail.com", "Bret Lueilwitz", "fkj61v", "0402171798", 4, new DateTime(2024, 9, 23, 5, 46, 14, 16, DateTimeKind.Unspecified).AddTicks(5797), "Franco.Glover18" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 25, 14, 4, 10, 336, DateTimeKind.Unspecified).AddTicks(1381), "gmail.com.Durgan70@gmail.com", "Watson Hyatt", "af2ilv", "0845854562", 3, new DateTime(2024, 9, 25, 14, 4, 10, 336, DateTimeKind.Unspecified).AddTicks(1381), "Lilyan.Russel81" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 59, 39, 647, DateTimeKind.Unspecified).AddTicks(2880), "gmail.com10@gmail.com", "Chester O'Connell", "bkd33c", "0353214610", 5, new DateTime(2024, 9, 10, 14, 59, 39, 647, DateTimeKind.Unspecified).AddTicks(2880), "Emie.Goldner" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 23, 6, 26, 36, 722, DateTimeKind.Unspecified).AddTicks(1458), "gmail.com.Bogisich@hotmail.com", "Abigail Hahn", "c0m44y", "0290092921", new DateTime(2024, 9, 23, 6, 26, 36, 722, DateTimeKind.Unspecified).AddTicks(1458), "Marisa.Okuneva" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 6, 16, 59, 9, 596, DateTimeKind.Unspecified).AddTicks(7885), "gmail.com59@hotmail.com", "Eugenia O'Hara", "bvydnw", "0751532454", 2, new DateTime(2024, 9, 6, 16, 59, 9, 596, DateTimeKind.Unspecified).AddTicks(7885), "Judy_Miller" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 22, 1, 18, 54, 584, DateTimeKind.Unspecified).AddTicks(8604), "gmail.com39@gmail.com", "Abigale Wilderman", "flrqcl", "0662379806", 2, new DateTime(2024, 9, 22, 1, 18, 54, 584, DateTimeKind.Unspecified).AddTicks(8604), "Karl11" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 16, 13, 25, 19, 69, DateTimeKind.Unspecified).AddTicks(4193), "gmail.com.Walsh@hotmail.com", "Miracle Morar", "hixlox", "0616986661", new DateTime(2024, 9, 16, 13, 25, 19, 69, DateTimeKind.Unspecified).AddTicks(4193), "Kaleb.Veum62" });

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

            migrationBuilder.InsertData(
                table: "Visitors",
                columns: new[] { "VisitorId", "CompanyName", "CreateById", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "UserId", "VisitorName" },
                values: new object[,]
                {
                    { 1, "Kuhic, O'Kon and Schultz", 1, new DateTime(2024, 9, 20, 1, 36, 43, 416, DateTimeKind.Unspecified).AddTicks(145), 2, "wrftyq1e7v", "0734464693", false, new DateTime(2024, 9, 20, 1, 36, 43, 416, DateTimeKind.Unspecified).AddTicks(145), null, "Candice Bogisich" },
                    { 2, "Mills, Watsica and Stark", 1, new DateTime(2024, 9, 2, 22, 16, 28, 397, DateTimeKind.Unspecified).AddTicks(4860), 2, "2vdvsi4a22", "0636809047", true, new DateTime(2024, 9, 2, 22, 16, 28, 397, DateTimeKind.Unspecified).AddTicks(4860), null, "Mabel Kihn" },
                    { 3, "Marks, Gleichner and Renner", 1, new DateTime(2024, 9, 20, 12, 33, 29, 576, DateTimeKind.Unspecified).AddTicks(6083), 1, "v8o9wfbue4", "0157460540", false, new DateTime(2024, 9, 20, 12, 33, 29, 576, DateTimeKind.Unspecified).AddTicks(6083), null, "Stefan Balistreri" },
                    { 4, "Fisher - Stamm", 1, new DateTime(2024, 9, 16, 2, 24, 6, 927, DateTimeKind.Unspecified).AddTicks(939), 2, "fegww4fpf1", "0753370001", true, new DateTime(2024, 9, 16, 2, 24, 6, 927, DateTimeKind.Unspecified).AddTicks(939), null, "Milo Schulist" },
                    { 5, "Casper, Boyer and Lesch", 1, new DateTime(2024, 9, 9, 4, 5, 58, 907, DateTimeKind.Unspecified).AddTicks(2287), 1, "00lqs54raa", "0329159872", false, new DateTime(2024, 9, 9, 4, 5, 58, 907, DateTimeKind.Unspecified).AddTicks(2287), null, "Robyn Parisian" },
                    { 6, "O'Reilly, Heller and Graham", 1, new DateTime(2024, 9, 16, 1, 18, 43, 564, DateTimeKind.Unspecified).AddTicks(698), 1, "72c986ayy0", "0795334114", true, new DateTime(2024, 9, 16, 1, 18, 43, 564, DateTimeKind.Unspecified).AddTicks(698), null, "Jacky Towne" },
                    { 7, "Blanda, Bode and Murphy", 1, new DateTime(2024, 9, 4, 0, 59, 16, 176, DateTimeKind.Unspecified).AddTicks(9833), 1, "tu7jupqtad", "0755667049", true, new DateTime(2024, 9, 4, 0, 59, 16, 176, DateTimeKind.Unspecified).AddTicks(9833), null, "Buster Abshire" },
                    { 8, "Labadie LLC", 1, new DateTime(2024, 9, 4, 7, 38, 2, 627, DateTimeKind.Unspecified).AddTicks(1474), 1, "gew0niqkg5", "0307507461", true, new DateTime(2024, 9, 4, 7, 38, 2, 627, DateTimeKind.Unspecified).AddTicks(1474), null, "Jakayla Lind" },
                    { 9, "Hartmann, Ondricka and Kohler", 1, new DateTime(2024, 9, 5, 18, 40, 42, 545, DateTimeKind.Unspecified).AddTicks(3586), 1, "yb7dx5vobn", "0832041776", false, new DateTime(2024, 9, 5, 18, 40, 42, 545, DateTimeKind.Unspecified).AddTicks(3586), null, "Rylan Rippin" },
                    { 10, "Hodkiewicz Group", 1, new DateTime(2024, 9, 4, 12, 29, 22, 958, DateTimeKind.Unspecified).AddTicks(2517), 1, "meboukxxgv", "0493509614", false, new DateTime(2024, 9, 4, 12, 29, 22, 958, DateTimeKind.Unspecified).AddTicks(2517), null, "Sally Mohr" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProcessId", "CreateBy", "CreateTime", "Description", "ProcessName", "Status", "VisitTypeId" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2024, 9, 25, 16, 37, 8, 630, DateTimeKind.Utc).AddTicks(2253), "", "Awesome Cotton Gloves", false, 1 },
                    { 2, 3, new DateTime(2024, 9, 25, 16, 37, 8, 630, DateTimeKind.Utc).AddTicks(3869), "", "Handcrafted Concrete Hat", false, 1 },
                    { 3, 3, new DateTime(2024, 9, 25, 16, 37, 8, 630, DateTimeKind.Utc).AddTicks(3906), "", "Intelligent Cotton Computer", false, 1 },
                    { 4, 3, new DateTime(2024, 9, 25, 16, 37, 8, 630, DateTimeKind.Utc).AddTicks(3926), "", "Ergonomic Soft Pants", false, 1 },
                    { 5, 3, new DateTime(2024, 9, 25, 16, 37, 8, 630, DateTimeKind.Utc).AddTicks(3945), "", "Gorgeous Cotton Fish", true, 1 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_VisitTypes_VisitTypeId",
                table: "Projects",
                column: "VisitTypeId",
                principalTable: "VisitTypes",
                principalColumn: "VisitTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_VisitTypes_VisitTypeId",
                table: "Projects");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProcessId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProcessId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProcessId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProcessId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProcessId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VisitTypes",
                keyColumn: "VisitTypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VisitTypes",
                keyColumn: "VisitTypeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VisitTypes",
                keyColumn: "VisitTypeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VisitTypes",
                keyColumn: "VisitTypeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "VisitTypes",
                keyColumn: "VisitTypeId",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "VisitTypeId",
                table: "Projects",
                newName: "Visittype");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_VisitTypeId",
                table: "Projects",
                newName: "IX_Projects_Visittype");

            migrationBuilder.UpdateData(
                table: "CredentialCardTypes",
                keyColumn: "CredentialCardTypeId",
                keyValue: 1,
                column: "CredentialCardTypeName",
                value: "Căn cước công dân");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 5, 22, 4, 55, 667, DateTimeKind.Utc).AddTicks(3278), "Phòng Hành chính", "Amet consequuntur magnam iusto voluptates et repudiandae odio.", new DateTime(2024, 9, 5, 22, 4, 55, 667, DateTimeKind.Utc).AddTicks(3278) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 4, 18, 26, 28, 975, DateTimeKind.Utc).AddTicks(8559), "Phòng Hành chính", "Tempora ipsum mollitia sunt laborum itaque ipsam.", new DateTime(2024, 9, 4, 18, 26, 28, 975, DateTimeKind.Utc).AddTicks(8559) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 5, 1, 18, 51, 451, DateTimeKind.Utc).AddTicks(6536), "Phòng Kế toán", "Occaecati consequatur explicabo dolor est aut quas.", new DateTime(2024, 9, 5, 1, 18, 51, 451, DateTimeKind.Utc).AddTicks(6536) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 9, 12, 5, 48, 12, 464, DateTimeKind.Utc).AddTicks(4551), "Phòng Chăm sóc khách hàng", "Et laudantium quia.", new DateTime(2024, 9, 12, 5, 48, 12, 464, DateTimeKind.Utc).AddTicks(4551) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5,
                columns: new[] { "AcceptLevel", "CreateDate", "Description", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 9, 15, 5, 13, 11, 383, DateTimeKind.Utc).AddTicks(7617), "Illum est illum.", new DateTime(2024, 9, 15, 5, 13, 11, 383, DateTimeKind.Utc).AddTicks(7617) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 6,
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 13, 21, 41, 38, 66, DateTimeKind.Utc).AddTicks(5081), "Phòng R&D", "Temporibus aspernatur earum eveniet tempore ea in iusto.", new DateTime(2024, 9, 13, 21, 41, 38, 66, DateTimeKind.Utc).AddTicks(5081) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 7,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 19, 3, 20, 11, 979, DateTimeKind.Utc).AddTicks(2228), "Phòng IT", "Voluptatem et debitis rem.", new DateTime(2024, 9, 19, 3, 20, 11, 979, DateTimeKind.Utc).AddTicks(2228) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 8,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2024, 9, 6, 15, 49, 58, 819, DateTimeKind.Utc).AddTicks(7458), "Phòng Pháp chế", "Quam voluptates maxime.", new DateTime(2024, 9, 6, 15, 49, 58, 819, DateTimeKind.Utc).AddTicks(7458) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 9,
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 40, 11, 536, DateTimeKind.Utc).AddTicks(8504), "Phòng Kinh doanh", "Rerum laudantium explicabo.", new DateTime(2024, 9, 14, 15, 40, 11, 536, DateTimeKind.Utc).AddTicks(8504) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 10,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 15, 1, 9, 53, 187, DateTimeKind.Utc).AddTicks(8690), "Phòng Kinh doanh", "Veniam eius et qui est perferendis asperiores eius dolore dolor.", new DateTime(2024, 9, 15, 1, 9, 53, 187, DateTimeKind.Utc).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 1,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 3, 12 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 2,
                column: "DepartmentId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 3,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 10, 9 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 4,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 6, 8 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 5,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 10 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 6,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 4, 23 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 7,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 10, 8 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 8,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 1, 15 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 9,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 3, 9 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 10,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 10 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 11,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 21 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 12,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 13 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 13,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 3, 6 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 14,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 3, 22 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 15,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 2, 9 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 16,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 18 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 17,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 4, 23 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 18,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 3, 22 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 19,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 5, 13 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 20,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 6, 18 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 21,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 25 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 22,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 19 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 23,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 16 });

            migrationBuilder.InsertData(
                table: "UserDepartments",
                columns: new[] { "UserDepartmentId", "DepartmentId", "UserId" },
                values: new object[,]
                {
                    { 24, 5, 6 },
                    { 25, 2, 6 },
                    { 26, 8, 17 },
                    { 27, 2, 24 },
                    { 28, 10, 10 },
                    { 29, 10, 3 },
                    { 30, 6, 14 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 25, 16, 12, 25, 850, DateTimeKind.Utc).AddTicks(6785), new DateTime(2024, 9, 25, 16, 12, 25, 850, DateTimeKind.Utc).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 25, 16, 12, 25, 850, DateTimeKind.Utc).AddTicks(6794), new DateTime(2024, 9, 25, 16, 12, 25, 850, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 16, 12, 25, 850, DateTimeKind.Utc).AddTicks(6797), new DateTime(2024, 9, 25, 16, 12, 25, 850, DateTimeKind.Utc).AddTicks(6797) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 25, 16, 12, 25, 850, DateTimeKind.Utc).AddTicks(6799), new DateTime(2024, 9, 25, 16, 12, 25, 850, DateTimeKind.Utc).AddTicks(6800) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 25, 16, 12, 25, 850, DateTimeKind.Utc).AddTicks(6801), new DateTime(2024, 9, 25, 16, 12, 25, 850, DateTimeKind.Utc).AddTicks(6802) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 17, 2, 29, 39, 760, DateTimeKind.Unspecified).AddTicks(1408), "gmail.com.Mertz@gmail.com", "Wilburn Nikolaus", "2gxkhw", "0358184031", 4, new DateTime(2024, 9, 17, 2, 29, 39, 760, DateTimeKind.Unspecified).AddTicks(1408), "Sage_Schmeler" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 6, 9, 50, 51, 668, DateTimeKind.Unspecified).AddTicks(3048), "gmail.com_Bailey38@gmail.com", "Eric Spinka", "0p4yq9", "0656597384", 2, new DateTime(2024, 9, 6, 9, 50, 51, 668, DateTimeKind.Unspecified).AddTicks(3048), "Clarissa_Zemlak" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 20, 0, 0, 25, 15, DateTimeKind.Unspecified).AddTicks(9588), "gmail.com.Rogahn32@yahoo.com", "Alayna Renner", "yrlhco", "0276634956", 5, new DateTime(2024, 9, 20, 0, 0, 25, 15, DateTimeKind.Unspecified).AddTicks(9588), "Matt36" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 6, 1, 38, 18, 663, DateTimeKind.Unspecified).AddTicks(7033), "gmail.com_Nikolaus62@gmail.com", "Jefferey Heaney", "084pd1", "0411848682", 3, new DateTime(2024, 9, 6, 1, 38, 18, 663, DateTimeKind.Unspecified).AddTicks(7033), "Leon_Schneider14" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 10, 11, 52, 38, 572, DateTimeKind.Unspecified).AddTicks(4356), "gmail.com.Bogisich@hotmail.com", "Elena Terry", "27c43e", "0762949919", 2, new DateTime(2024, 9, 10, 11, 52, 38, 572, DateTimeKind.Unspecified).AddTicks(4356), "Adolf64" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 24, 14, 29, 47, 159, DateTimeKind.Unspecified).AddTicks(4548), "gmail.com_Oberbrunner@gmail.com", "Gay Toy", "pjtc4q", "0372122902", new DateTime(2024, 9, 24, 14, 29, 47, 159, DateTimeKind.Unspecified).AddTicks(4548), "Anastacio.Blick" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 21, 2, 4, 49, 516, DateTimeKind.Unspecified).AddTicks(8541), "gmail.com9@hotmail.com", "Pietro Morissette", "nz5deb", "0191711831", new DateTime(2024, 9, 21, 2, 4, 49, 516, DateTimeKind.Unspecified).AddTicks(8541), "Fabiola28" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 11, 10, 40, 5, 338, DateTimeKind.Unspecified).AddTicks(3282), "gmail.com_Kihn@yahoo.com", "Janessa Ernser", "34v1rs", "0379914908", 4, new DateTime(2024, 9, 11, 10, 40, 5, 338, DateTimeKind.Unspecified).AddTicks(3282), "Sarah91" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 9, 21, 37, 4, 722, DateTimeKind.Unspecified).AddTicks(6194), "gmail.com.Cronin79@hotmail.com", "Freda Hand", "7hbmc7", "0546219994", 4, new DateTime(2024, 9, 9, 21, 37, 4, 722, DateTimeKind.Unspecified).AddTicks(6194), "Jayden.Boyer" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 13, 9, 37, 48, 670, DateTimeKind.Unspecified).AddTicks(14), "gmail.com.Wisozk@hotmail.com", "Myrl Abshire", "a2e1fb", "0195639728", 3, new DateTime(2024, 9, 13, 9, 37, 48, 670, DateTimeKind.Unspecified).AddTicks(14), "Betsy41" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 10, 22, 32, 6, 133, DateTimeKind.Unspecified).AddTicks(1891), "gmail.com70@yahoo.com", "Nicolette Stehr", "kpradd", "0710529703", 1, new DateTime(2024, 9, 10, 22, 32, 6, 133, DateTimeKind.Unspecified).AddTicks(1891), "Ryley.Dare36" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 1, 3, 0, 17, 358, DateTimeKind.Unspecified).AddTicks(3392), "gmail.com_Jacobi32@yahoo.com", "Raquel Fahey", "v5iniw", "0241223773", 4, new DateTime(2024, 9, 1, 3, 0, 17, 358, DateTimeKind.Unspecified).AddTicks(3392), "Joany.Baumbach63" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 22, 21, 7, 10, 473, DateTimeKind.Unspecified).AddTicks(7790), "gmail.com_Kozey37@yahoo.com", "Joey Bednar", "a9hsxa", "0345509790", 4, new DateTime(2024, 9, 22, 21, 7, 10, 473, DateTimeKind.Unspecified).AddTicks(7790), "Leopold.Turcotte72" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 23, 4, 56, 53, 604, DateTimeKind.Unspecified).AddTicks(640), "gmail.com_Harris69@yahoo.com", "Misael Kemmer", "j9mp58", "0142800786", 5, new DateTime(2024, 9, 23, 4, 56, 53, 604, DateTimeKind.Unspecified).AddTicks(640), "Dan_Batz22" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 16, 10, 0, 14, 792, DateTimeKind.Unspecified).AddTicks(9553), "gmail.com61@gmail.com", "Emile Okuneva", "f897se", "0701111702", 1, new DateTime(2024, 9, 16, 10, 0, 14, 792, DateTimeKind.Unspecified).AddTicks(9553), "Tanya_Bartoletti37" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 10, 3, 10, 3, 498, DateTimeKind.Unspecified).AddTicks(6734), "gmail.com.Stoltenberg@hotmail.com", "Charity Kertzmann", "bpzbxq", "0135663761", 1, new DateTime(2024, 9, 10, 3, 10, 3, 498, DateTimeKind.Unspecified).AddTicks(6734), "Javonte33" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 22, 20, 23, 5, 911, DateTimeKind.Unspecified).AddTicks(1619), "gmail.com.Jacobson@yahoo.com", "Toney Bailey", "1elc7y", "0956080700", new DateTime(2024, 9, 22, 20, 23, 5, 911, DateTimeKind.Unspecified).AddTicks(1619), "Bradford4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 4, 2, 42, 26, 710, DateTimeKind.Unspecified).AddTicks(1098), "gmail.com85@yahoo.com", "Larissa Goyette", "9pomlw", "0629654378", 1, new DateTime(2024, 9, 4, 2, 42, 26, 710, DateTimeKind.Unspecified).AddTicks(1098), "Orville.Prohaska" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 16, 21, 9, 14, 128, DateTimeKind.Unspecified).AddTicks(1766), "gmail.com.Cole18@yahoo.com", "Torrey Rogahn", "ronx1o", "0434673269", 5, new DateTime(2024, 9, 16, 21, 9, 14, 128, DateTimeKind.Unspecified).AddTicks(1766), "Kaitlin56" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 10, 3, 35, 7, 814, DateTimeKind.Unspecified).AddTicks(9169), "gmail.com.Zboncak98@gmail.com", "Floyd Morissette", "1acx6x", "0260729199", new DateTime(2024, 9, 10, 3, 35, 7, 814, DateTimeKind.Unspecified).AddTicks(9169), "Irma.Ankunding13" });

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_VisitTypes_Visittype",
                table: "Projects",
                column: "Visittype",
                principalTable: "VisitTypes",
                principalColumn: "VisitTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
