using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SecurityGateApv.Infras.Migrations
{
    /// <inheritdoc />
    public partial class SeedData_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { 3, new DateTime(2024, 9, 17, 15, 14, 47, 762, DateTimeKind.Utc).AddTicks(4917), "Phòng Hành chính", "Inventore voluptas placeat sed assumenda.", new DateTime(2024, 9, 17, 15, 14, 47, 762, DateTimeKind.Utc).AddTicks(4917) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 9, 11, 7, 51, 27, 677, DateTimeKind.Utc).AddTicks(3287), "Phòng Kế toán", "Ut sint sed cum nulla similique voluptate.", new DateTime(2024, 9, 11, 7, 51, 27, 677, DateTimeKind.Utc).AddTicks(3287) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 13, 7, 7, 44, 7, DateTimeKind.Utc).AddTicks(8363), "Phòng IT", "Ipsa facilis corrupti expedita tempora et deleniti.", new DateTime(2024, 9, 13, 7, 7, 44, 7, DateTimeKind.Utc).AddTicks(8363) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2024, 9, 19, 20, 7, 1, 283, DateTimeKind.Utc).AddTicks(3254), "Phòng Kinh doanh", "Voluptas quaerat atque odit et.", new DateTime(2024, 9, 19, 20, 7, 1, 283, DateTimeKind.Utc).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 17, 9, 59, 28, 737, DateTimeKind.Utc).AddTicks(4285), "Phòng Sản xuất", "Et laudantium et facilis voluptatem delectus natus fugiat.", new DateTime(2024, 9, 17, 9, 59, 28, 737, DateTimeKind.Utc).AddTicks(4285) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 6,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 2, 0, 25, 50, 621, DateTimeKind.Utc).AddTicks(8077), "Phòng Chăm sóc khách hàng", "Quis quia odit iste rerum debitis nam non.", new DateTime(2024, 9, 2, 0, 25, 50, 621, DateTimeKind.Utc).AddTicks(8077) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 7,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 25, 22, 54, 48, 921, DateTimeKind.Utc).AddTicks(1727), "Phòng Kế toán", "Excepturi dolore est est et vel.", new DateTime(2024, 9, 25, 22, 54, 48, 921, DateTimeKind.Utc).AddTicks(1727) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 8,
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 16, 18, 28, 59, 256, DateTimeKind.Utc).AddTicks(3232), "Phòng Nhân sự", "Ex maxime et quae odio temporibus ratione illo.", new DateTime(2024, 9, 16, 18, 28, 59, 256, DateTimeKind.Utc).AddTicks(3232) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 9,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 4, new DateTime(2024, 9, 11, 12, 57, 23, 800, DateTimeKind.Utc).AddTicks(143), "Phòng IT", "Debitis fugiat qui.", new DateTime(2024, 9, 11, 12, 57, 23, 800, DateTimeKind.Utc).AddTicks(143) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 10,
                columns: new[] { "AcceptLevel", "CreateDate", "Description", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 9, 9, 3, 15, 33, 667, DateTimeKind.Utc).AddTicks(2213), "Quis accusantium sapiente suscipit explicabo eaque omnis error.", new DateTime(2024, 9, 9, 3, 15, 33, 667, DateTimeKind.Utc).AddTicks(2213) });

            migrationBuilder.InsertData(
                table: "Gates",
                columns: new[] { "GateId", "GateCoordinate", "GateName" },
                values: new object[,]
                {
                    { 1, "Ra vào trong ngày", "Cổng 1" },
                    { 2, "Ra vào trong ngày", "Cổng 2" }
                });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProcessId",
                keyValue: 1,
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 24, 3, 33, 39, 746, DateTimeKind.Utc).AddTicks(9115), "Rustic Concrete Hat", false });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProcessId",
                keyValue: 2,
                columns: new[] { "CreateTime", "ProcessName" },
                values: new object[] { new DateTime(2024, 9, 24, 3, 33, 39, 747, DateTimeKind.Utc).AddTicks(799), "Ergonomic Soft Bike" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProcessId",
                keyValue: 3,
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 24, 3, 33, 39, 747, DateTimeKind.Utc).AddTicks(829), "Ergonomic Wooden Chicken", false });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProcessId",
                keyValue: 4,
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 24, 3, 33, 39, 747, DateTimeKind.Utc).AddTicks(848), "Refined Granite Mouse", false });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProcessId",
                keyValue: 5,
                columns: new[] { "CreateTime", "ProcessName" },
                values: new object[] { new DateTime(2024, 9, 24, 3, 33, 39, 747, DateTimeKind.Utc).AddTicks(864), "Gorgeous Wooden Gloves" });

            migrationBuilder.InsertData(
                table: "QRCardStatus",
                columns: new[] { "QRCardStatusId", "StatusName", "StatusNumber" },
                values: new object[,]
                {
                    { 1, "Active", 1 },
                    { 2, "Inactive", 0 }
                });

            migrationBuilder.InsertData(
                table: "QRCardType",
                columns: new[] { "QRCardTypeId", "CardTypeName", "TypeDescription" },
                values: new object[,]
                {
                    { 1, "Employee", "Employee QR Card" },
                    { 2, "Visitor", "Visitor QR Card" }
                });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 4,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 5, 24 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 5,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 1, 25 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 6,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 21 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 7,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 8 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 8,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 5, 9 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 9,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 1, 17 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 10,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 15 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 11,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 4, 23 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 12,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 1, 22 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 13,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 18 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 14,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 6, 8 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 15,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 4, 16 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 16,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 6, 13 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 17,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 15 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 18,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 4, 14 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 19,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 2, 10 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 20,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 20 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 21,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 4, 10 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 22,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 5, 21 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 23,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 3, 25 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 3, 33, 39, 736, DateTimeKind.Utc).AddTicks(9874), new DateTime(2024, 9, 26, 3, 33, 39, 736, DateTimeKind.Utc).AddTicks(9883) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 26, 3, 33, 39, 736, DateTimeKind.Utc).AddTicks(9886), new DateTime(2024, 9, 26, 3, 33, 39, 736, DateTimeKind.Utc).AddTicks(9887) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 26, 3, 33, 39, 736, DateTimeKind.Utc).AddTicks(9888), new DateTime(2024, 9, 26, 3, 33, 39, 736, DateTimeKind.Utc).AddTicks(9889) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 3, 33, 39, 736, DateTimeKind.Utc).AddTicks(9890), new DateTime(2024, 9, 26, 3, 33, 39, 736, DateTimeKind.Utc).AddTicks(9891) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 26, 3, 33, 39, 736, DateTimeKind.Utc).AddTicks(9892), new DateTime(2024, 9, 26, 3, 33, 39, 736, DateTimeKind.Utc).AddTicks(9893) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 19, 7, 0, 36, 308, DateTimeKind.Unspecified).AddTicks(8859), "gmail.com_Witting87@hotmail.com", "Jake Mohr", "3kj8ln", "0816565743", 3, new DateTime(2024, 9, 19, 7, 0, 36, 308, DateTimeKind.Unspecified).AddTicks(8859), "Rossie_Marvin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 14, 7, 24, 45, 213, DateTimeKind.Unspecified).AddTicks(689), "gmail.com.Braun@hotmail.com", "Damian Lehner", "yh37m1", "0457631742", 4, new DateTime(2024, 9, 14, 7, 24, 45, 213, DateTimeKind.Unspecified).AddTicks(689), "Macie_Pfannerstill43" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 7, 1, 53, 12, 662, DateTimeKind.Unspecified).AddTicks(6751), "gmail.com.Graham@yahoo.com", "Krystina Leffler", "mv3di2", "0715379980", new DateTime(2024, 9, 7, 1, 53, 12, 662, DateTimeKind.Unspecified).AddTicks(6751), "Ava.Gibson28" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 25, 22, 6, 14, 513, DateTimeKind.Unspecified).AddTicks(2081), "gmail.com_Jacobs@gmail.com", "Camden Conn", "4ce9w0", "0617720404", 3, new DateTime(2024, 9, 25, 22, 6, 14, 513, DateTimeKind.Unspecified).AddTicks(2081), "Mabelle_Carroll" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 21, 16, 1, 45, 433, DateTimeKind.Unspecified).AddTicks(4475), "gmail.com_Ebert26@gmail.com", "Hadley Parisian", "s2xzb8", "0751827197", 4, new DateTime(2024, 9, 21, 16, 1, 45, 433, DateTimeKind.Unspecified).AddTicks(4475), "Barrett20" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 2, 3, 7, 45, 401, DateTimeKind.Unspecified).AddTicks(5097), "gmail.com_Ullrich@gmail.com", "Holden Williamson", "69ylw2", "0699063021", 2, new DateTime(2024, 9, 2, 3, 7, 45, 401, DateTimeKind.Unspecified).AddTicks(5097), "Micheal.Toy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 9, 4, 45, 16, 537, DateTimeKind.Unspecified).AddTicks(2496), "gmail.com_Heidenreich86@yahoo.com", "Elenora Gusikowski", "x2pa7h", "0740903208", new DateTime(2024, 9, 9, 4, 45, 16, 537, DateTimeKind.Unspecified).AddTicks(2496), "Marianne.Batz40" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 8, 19, 14, 6, 946, DateTimeKind.Unspecified).AddTicks(1537), "gmail.com_Roob@hotmail.com", "Blake Jacobson", "srjobn", "0831496216", 4, new DateTime(2024, 9, 8, 19, 14, 6, 946, DateTimeKind.Unspecified).AddTicks(1537), "Jermey9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 20, 21, 49, 29, 442, DateTimeKind.Unspecified).AddTicks(6733), "gmail.com.Borer@yahoo.com", "Edwin Kulas", "o2doqx", "0449828222", 2, new DateTime(2024, 9, 20, 21, 49, 29, 442, DateTimeKind.Unspecified).AddTicks(6733), "Sabrina.Rice76" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 12, 23, 19, 28, 69, DateTimeKind.Unspecified).AddTicks(2263), "gmail.com82@yahoo.com", "Jeremy Hills", "y69063", "0722110419", 2, new DateTime(2024, 9, 12, 23, 19, 28, 69, DateTimeKind.Unspecified).AddTicks(2263), "Gwen_Sauer" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 7, 22, 45, 50, 593, DateTimeKind.Unspecified).AddTicks(7056), "gmail.com.Crooks@hotmail.com", "Okey Larkin", "6bdq99", "0607236253", 3, new DateTime(2024, 9, 7, 22, 45, 50, 593, DateTimeKind.Unspecified).AddTicks(7056), "Jo.Tremblay97" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 15, 12, 29, 53, 22, DateTimeKind.Unspecified).AddTicks(2230), "gmail.com.Reinger@gmail.com", "Marilyne Langosh", "46fp48", "0120430110", 1, new DateTime(2024, 9, 15, 12, 29, 53, 22, DateTimeKind.Unspecified).AddTicks(2230), "Barrett_DAmore" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 1, 48, 651, DateTimeKind.Unspecified).AddTicks(3715), "gmail.com.Dach@gmail.com", "Kiley Leffler", "58zo8x", "0479382672", 2, new DateTime(2024, 9, 1, 14, 1, 48, 651, DateTimeKind.Unspecified).AddTicks(3715), "Owen_Lockman46" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 4, 10, 59, 11, 522, DateTimeKind.Unspecified).AddTicks(7344), "gmail.com.Hirthe@hotmail.com", "Addie O'Kon", "5mgfji", "0587664167", 1, new DateTime(2024, 9, 4, 10, 59, 11, 522, DateTimeKind.Unspecified).AddTicks(7344), "Eudora.Hauck" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 4, 8, 53, 11, 347, DateTimeKind.Unspecified).AddTicks(9523), "gmail.com7@hotmail.com", "Brianne Barton", "p2qq8l", "0701253582", new DateTime(2024, 9, 4, 8, 53, 11, 347, DateTimeKind.Unspecified).AddTicks(9523), "Bryana36" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 18, 6, 33, 18, 245, DateTimeKind.Unspecified).AddTicks(5037), "gmail.com.Bashirian60@gmail.com", "Deshaun Walker", "ra76yv", "0377019089", 4, new DateTime(2024, 9, 18, 6, 33, 18, 245, DateTimeKind.Unspecified).AddTicks(5037), "Brian.Casper" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 25, 8, 52, 3, 822, DateTimeKind.Unspecified).AddTicks(8271), "gmail.com.Schiller@hotmail.com", "Jannie Kshlerin", "rkvg0w", "0917218440", 5, new DateTime(2024, 9, 25, 8, 52, 3, 822, DateTimeKind.Unspecified).AddTicks(8271), "Jaydon.Schiller" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 5, 9, 9, 44, 342, DateTimeKind.Unspecified).AddTicks(8392), "gmail.com22@yahoo.com", "Jerald Terry", "x7wdm6", "0495002427", new DateTime(2024, 9, 5, 9, 9, 44, 342, DateTimeKind.Unspecified).AddTicks(8392), "Lula.DAmore95" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 24, 1, 35, 23, 117, DateTimeKind.Unspecified).AddTicks(7025), "gmail.com.Cruickshank9@gmail.com", "Maurice Grady", "h0h3f2", "0316855727", new DateTime(2024, 9, 24, 1, 35, 23, 117, DateTimeKind.Unspecified).AddTicks(7025), "Luz.OConnell" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 29, 5, 122, DateTimeKind.Unspecified).AddTicks(163), "gmail.com91@gmail.com", "Mavis Veum", "dgbapa", "0725773473", 2, new DateTime(2024, 9, 5, 15, 29, 5, 122, DateTimeKind.Unspecified).AddTicks(163), "Addison.Bergnaum71" });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 1,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Sed praesentium autem rem sit ipsa explicabo. Consequuntur eum quo. Ipsa non molestias nisi ipsam.", new DateTime(2024, 10, 25, 10, 33, 39, 759, DateTimeKind.Local).AddTicks(7883), new DateTime(2024, 9, 25, 10, 33, 39, 759, DateTimeKind.Local).AddTicks(7822) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 2,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Molestiae asperiores suscipit eaque doloremque aliquam sit hic est. Molestiae aut facilis doloribus. Ut quas ducimus atque et iure deserunt consequatur.", new DateTime(2024, 10, 25, 10, 33, 39, 759, DateTimeKind.Local).AddTicks(8277), new DateTime(2024, 9, 25, 10, 33, 39, 759, DateTimeKind.Local).AddTicks(8275) });

            migrationBuilder.UpdateData(
                table: "VisitProjects",
                keyColumn: "VisitProcessId",
                keyValue: 1,
                columns: new[] { "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { new DateTime(2024, 10, 25, 10, 33, 39, 749, DateTimeKind.Local).AddTicks(3522), new DateTime(2024, 9, 25, 10, 33, 39, 749, DateTimeKind.Local).AddTicks(3488) });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 1,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Veum - Macejkovic", new DateTime(2024, 9, 16, 5, 2, 48, 837, DateTimeKind.Unspecified).AddTicks(1954), "fla2me9dro", "0366515124", true, new DateTime(2024, 9, 16, 5, 2, 48, 837, DateTimeKind.Unspecified).AddTicks(1954), "Elbert Rippin" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 2,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Thompson - Brown", new DateTime(2024, 9, 6, 18, 0, 59, 557, DateTimeKind.Unspecified).AddTicks(3059), "jc8hwp17jr", "0424629675", true, new DateTime(2024, 9, 6, 18, 0, 59, 557, DateTimeKind.Unspecified).AddTicks(3059), "Ashly Kessler" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 3,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Kirlin - Veum", new DateTime(2024, 9, 25, 0, 18, 15, 246, DateTimeKind.Unspecified).AddTicks(5086), "04hiqp4rte", "0150176053", new DateTime(2024, 9, 25, 0, 18, 15, 246, DateTimeKind.Unspecified).AddTicks(5086), "Alexander Robel" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 4,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Friesen Group", new DateTime(2024, 9, 13, 17, 13, 22, 423, DateTimeKind.Unspecified).AddTicks(3486), "z878cushvu", "0913845818", false, new DateTime(2024, 9, 13, 17, 13, 22, 423, DateTimeKind.Unspecified).AddTicks(3486), "Hanna Monahan" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 5,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Lubowitz, Hoppe and Kilback", new DateTime(2024, 9, 18, 0, 51, 0, 481, DateTimeKind.Unspecified).AddTicks(5150), 1, "fy48mcdqne", "0270704305", false, new DateTime(2024, 9, 18, 0, 51, 0, 481, DateTimeKind.Unspecified).AddTicks(5150), "Addison Zulauf" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 6,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "O'Kon - Kilback", new DateTime(2024, 9, 5, 19, 7, 29, 233, DateTimeKind.Unspecified).AddTicks(1471), "xpyivd0v6t", "0702122086", new DateTime(2024, 9, 5, 19, 7, 29, 233, DateTimeKind.Unspecified).AddTicks(1471), "Alicia Smith" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 7,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Ledner - Wolf", new DateTime(2024, 9, 12, 22, 27, 29, 304, DateTimeKind.Unspecified).AddTicks(6576), "0q98jaomat", "0216217526", true, new DateTime(2024, 9, 12, 22, 27, 29, 304, DateTimeKind.Unspecified).AddTicks(6576), "Karen Roberts" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 8,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Gleichner - Wilkinson", new DateTime(2024, 9, 2, 20, 31, 47, 691, DateTimeKind.Unspecified).AddTicks(2915), 1, "3ad836w0e0", "0329699322", new DateTime(2024, 9, 2, 20, 31, 47, 691, DateTimeKind.Unspecified).AddTicks(2915), "Destin Quigley" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 9,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Balistreri - Rau", new DateTime(2024, 9, 7, 15, 52, 35, 822, DateTimeKind.Unspecified).AddTicks(9562), 1, "im1cxlc8lo", "0108138373", new DateTime(2024, 9, 7, 15, 52, 35, 822, DateTimeKind.Unspecified).AddTicks(9562), "Keanu Zemlak" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 10,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Kling, VonRueden and Donnelly", new DateTime(2024, 9, 4, 2, 48, 47, 925, DateTimeKind.Unspecified).AddTicks(995), 2, "fdv8ktqskj", "0707725852", false, new DateTime(2024, 9, 4, 2, 48, 47, 925, DateTimeKind.Unspecified).AddTicks(995), "Baron Kulas" });

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 1,
                column: "DateRegister",
                value: new DateTime(2024, 9, 24, 10, 33, 39, 748, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.InsertData(
                table: "Visits",
                columns: new[] { "VisitId", "AcceptLevel", "CreateById", "DateRegister", "Description", "UpdateById", "VisitName", "VisitQuantity", "VisitType" },
                values: new object[,]
                {
                    { 2, 2, 4, new DateTime(2024, 9, 26, 3, 33, 39, 761, DateTimeKind.Utc).AddTicks(149), null, 4, "Dọn vệ sinh", 2, "ProcessWeek" },
                    { 3, 2, 4, new DateTime(2024, 9, 26, 3, 33, 39, 761, DateTimeKind.Utc).AddTicks(303), null, 4, "Dọn vệ sinh", 2, "ProcessWeek" },
                    { 4, 2, 4, new DateTime(2024, 9, 26, 3, 33, 39, 761, DateTimeKind.Utc).AddTicks(316), null, 4, "Dọn vệ sinh", 2, "ProcessWeek" },
                    { 5, 2, 4, new DateTime(2024, 9, 26, 3, 33, 39, 761, DateTimeKind.Utc).AddTicks(324), null, 4, "Dọn vệ sinh", 2, "ProcessWeek" },
                    { 6, 2, 4, new DateTime(2024, 9, 26, 3, 33, 39, 761, DateTimeKind.Utc).AddTicks(333), null, 4, "Dọn vệ sinh", 2, "ProcessWeek" }
                });

            migrationBuilder.InsertData(
                table: "QRCards",
                columns: new[] { "QRCardId", "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId", "QRCardTypeId" },
                values: new object[,]
                {
                    { 1, new Guid("c7d91ce2-5454-474f-99b6-4fefc9306987"), new DateTime(2024, 9, 26, 10, 33, 39, 782, DateTimeKind.Local).AddTicks(9765), new DateTime(2024, 10, 26, 10, 33, 39, 782, DateTimeKind.Local).AddTicks(9765), 1, 1 },
                    { 2, new Guid("d7d70999-9e5f-4e97-8582-d308845325eb"), new DateTime(2024, 9, 26, 10, 33, 39, 782, DateTimeKind.Local).AddTicks(9965), new DateTime(2024, 10, 26, 10, 33, 39, 782, DateTimeKind.Local).AddTicks(9965), 1, 1 },
                    { 3, new Guid("c1361f13-99f3-4ef0-98f0-2c660db49469"), new DateTime(2024, 9, 26, 10, 33, 39, 782, DateTimeKind.Local).AddTicks(9976), new DateTime(2024, 10, 26, 10, 33, 39, 782, DateTimeKind.Local).AddTicks(9976), 1, 1 },
                    { 4, new Guid("f7e74be1-410b-4619-bbbf-f94b512a34cf"), new DateTime(2024, 9, 26, 10, 33, 39, 782, DateTimeKind.Local).AddTicks(9983), new DateTime(2024, 10, 26, 10, 33, 39, 782, DateTimeKind.Local).AddTicks(9983), 2, 2 },
                    { 5, new Guid("00598625-25c4-44be-be93-ce74279a8330"), new DateTime(2024, 9, 26, 10, 33, 39, 782, DateTimeKind.Local).AddTicks(9990), new DateTime(2024, 10, 26, 10, 33, 39, 782, DateTimeKind.Local).AddTicks(9990), 2, 2 },
                    { 6, new Guid("8411d285-9b76-4287-9abf-9e27dd8c843d"), new DateTime(2024, 9, 26, 10, 33, 39, 782, DateTimeKind.Local).AddTicks(9996), new DateTime(2024, 10, 26, 10, 33, 39, 782, DateTimeKind.Local).AddTicks(9996), 1, 2 },
                    { 7, new Guid("02f6b50a-6b12-4c3e-89ec-74319c121ecc"), new DateTime(2024, 9, 26, 10, 33, 39, 783, DateTimeKind.Local).AddTicks(2), new DateTime(2024, 10, 26, 10, 33, 39, 783, DateTimeKind.Local).AddTicks(2), 1, 2 },
                    { 8, new Guid("820657b7-471d-4446-b1f5-61c5509aa92e"), new DateTime(2024, 9, 26, 10, 33, 39, 783, DateTimeKind.Local).AddTicks(21), new DateTime(2024, 10, 26, 10, 33, 39, 783, DateTimeKind.Local).AddTicks(21), 1, 2 },
                    { 9, new Guid("3ba9dca5-f5c6-4fff-84e8-ae1d76e431e4"), new DateTime(2024, 9, 26, 10, 33, 39, 783, DateTimeKind.Local).AddTicks(36), new DateTime(2024, 10, 26, 10, 33, 39, 783, DateTimeKind.Local).AddTicks(36), 1, 2 },
                    { 10, new Guid("f9eb3fb1-e0e5-46af-96a0-a02e3cdfc97f"), new DateTime(2024, 9, 26, 10, 33, 39, 783, DateTimeKind.Local).AddTicks(43), new DateTime(2024, 10, 26, 10, 33, 39, 783, DateTimeKind.Local).AddTicks(43), 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "VisitDetails",
                columns: new[] { "VisitDetailId", "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "Status", "VisitId", "VisitorId" },
                values: new object[,]
                {
                    { 3, "Qui magnam quidem atque aliquam mollitia velit non est adipisci. Velit autem accusamus voluptas. Sed tenetur inventore optio necessitatibus modi enim.", new DateTime(2024, 9, 26, 10, 33, 39, 762, DateTimeKind.Local).AddTicks(2095), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 762, DateTimeKind.Local).AddTicks(2126), new TimeSpan(0, 0, 0, 0, 0), true, 2, 3 },
                    { 4, "Quia nam impedit recusandae natus explicabo. Voluptas dolore laudantium ut et vel sed. Id odit et voluptatem similique tempore id explicabo placeat. Ipsa sit reiciendis et quos cum omnis corrupti dolores officia. Odit cumque minus rem nesciunt quisquam quas.", new DateTime(2024, 9, 26, 10, 33, 39, 762, DateTimeKind.Local).AddTicks(2382), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 762, DateTimeKind.Local).AddTicks(2385), new TimeSpan(0, 0, 0, 0, 0), true, 2, 8 },
                    { 5, "Deserunt quis dolorem est dolor voluptas quaerat. Aut ut quaerat non. Quam ducimus dolores nisi tempora aliquid.", new DateTime(2024, 9, 26, 10, 33, 39, 763, DateTimeKind.Local).AddTicks(5718), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 763, DateTimeKind.Local).AddTicks(5749), new TimeSpan(0, 0, 0, 0, 0), false, 2, 9 },
                    { 6, "Et nam omnis ea laboriosam omnis perspiciatis soluta ut similique. Ut omnis culpa et necessitatibus. Amet delectus fugiat ipsam neque corrupti cumque in molestiae alias.", new DateTime(2024, 9, 26, 10, 33, 39, 763, DateTimeKind.Local).AddTicks(5952), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 763, DateTimeKind.Local).AddTicks(5954), new TimeSpan(0, 0, 0, 0, 0), false, 2, 7 },
                    { 7, "Et molestiae labore a qui. Deserunt veniam voluptas et magni dolore eligendi voluptatibus aut rem. Sit voluptatem eligendi ut. Placeat debitis possimus ut debitis earum accusantium ad blanditiis omnis.", new DateTime(2024, 9, 26, 10, 33, 39, 764, DateTimeKind.Local).AddTicks(7938), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 764, DateTimeKind.Local).AddTicks(7965), new TimeSpan(0, 0, 0, 0, 0), true, 2, 6 },
                    { 8, "Natus ut et a dolore voluptatem ipsum. Laborum rerum tempora error ut dolore dolore iste nihil. Hic molestias quia quia. Doloremque aspernatur soluta.", new DateTime(2024, 9, 26, 10, 33, 39, 764, DateTimeKind.Local).AddTicks(8304), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 764, DateTimeKind.Local).AddTicks(8307), new TimeSpan(0, 0, 0, 0, 0), false, 2, 4 },
                    { 9, "Commodi perspiciatis officiis. Aliquam ut impedit quaerat perspiciatis nobis dolorem quis distinctio similique. Officia hic officiis repudiandae incidunt nulla aut facere.", new DateTime(2024, 9, 26, 10, 33, 39, 765, DateTimeKind.Local).AddTicks(9307), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 765, DateTimeKind.Local).AddTicks(9336), new TimeSpan(0, 0, 0, 0, 0), true, 3, 3 },
                    { 10, "Nihil quo minus aperiam eligendi ea nemo voluptatem cumque. Doloremque cumque illo molestiae odit corporis et optio deserunt. Aut libero omnis. Nam quisquam beatae blanditiis maxime.", new DateTime(2024, 9, 26, 10, 33, 39, 765, DateTimeKind.Local).AddTicks(9529), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 765, DateTimeKind.Local).AddTicks(9532), new TimeSpan(0, 0, 0, 0, 0), true, 3, 6 },
                    { 11, "Quia excepturi tempore eius et et distinctio odio. Quis ut animi voluptas architecto quia. Voluptatem sit voluptatem enim rerum asperiores perferendis consequatur maiores molestiae.", new DateTime(2024, 9, 26, 10, 33, 39, 767, DateTimeKind.Local).AddTicks(436), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 767, DateTimeKind.Local).AddTicks(462), new TimeSpan(0, 0, 0, 0, 0), true, 3, 4 },
                    { 12, "Est consequatur qui suscipit quas dicta minima nisi alias cum. Ea rerum deserunt sit placeat possimus commodi quia. Temporibus dignissimos quibusdam et dolore deleniti velit. Voluptatum aut excepturi neque magni.", new DateTime(2024, 9, 26, 10, 33, 39, 767, DateTimeKind.Local).AddTicks(660), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 767, DateTimeKind.Local).AddTicks(662), new TimeSpan(0, 0, 0, 0, 0), false, 3, 5 },
                    { 13, "Quos eius alias. Et facere qui quia debitis distinctio laudantium ipsam. Et et animi expedita culpa mollitia. Tenetur tempore dolorum deleniti ea. Soluta quam officia sed omnis qui qui sed. Ut sed ea qui et consequatur modi molestias velit.", new DateTime(2024, 9, 26, 10, 33, 39, 770, DateTimeKind.Local).AddTicks(319), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 770, DateTimeKind.Local).AddTicks(364), new TimeSpan(0, 0, 0, 0, 0), false, 3, 3 },
                    { 14, "Cupiditate culpa inventore laborum sint aspernatur voluptatibus dolorem ut tenetur. Dolor voluptatem qui numquam aut corrupti excepturi rerum nulla. Itaque et nam est quasi omnis. Ea repellendus illum. Voluptatem neque architecto incidunt ut amet.", new DateTime(2024, 9, 26, 10, 33, 39, 770, DateTimeKind.Local).AddTicks(617), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 770, DateTimeKind.Local).AddTicks(619), new TimeSpan(0, 0, 0, 0, 0), true, 3, 5 },
                    { 15, "Doloribus eligendi incidunt qui aut velit assumenda nam. Rerum ducimus enim quae. Odit velit nisi pariatur occaecati perferendis dolores accusamus consectetur est.", new DateTime(2024, 9, 26, 10, 33, 39, 771, DateTimeKind.Local).AddTicks(4610), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 771, DateTimeKind.Local).AddTicks(4712), new TimeSpan(0, 0, 0, 0, 0), true, 4, 4 },
                    { 16, "Rerum ullam iusto dignissimos facere hic non. Labore asperiores explicabo tenetur aliquam veniam magnam repudiandae quo quibusdam. Pariatur accusantium deleniti similique corrupti deserunt qui. Maiores et id neque est nobis eum.", new DateTime(2024, 9, 26, 10, 33, 39, 771, DateTimeKind.Local).AddTicks(5157), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 771, DateTimeKind.Local).AddTicks(5160), new TimeSpan(0, 0, 0, 0, 0), true, 4, 7 },
                    { 17, "Fugiat qui occaecati. Deleniti aperiam cumque rerum et sit exercitationem optio recusandae. In eveniet animi id architecto magnam qui in ipsum repellat.", new DateTime(2024, 9, 26, 10, 33, 39, 772, DateTimeKind.Local).AddTicks(8703), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 772, DateTimeKind.Local).AddTicks(8734), new TimeSpan(0, 0, 0, 0, 0), true, 4, 6 },
                    { 18, "Cum iste quia recusandae error accusamus. Corrupti quis et et id autem qui omnis. Laboriosam libero quo harum neque voluptas nemo occaecati atque. In beatae non eveniet rerum ducimus aut.", new DateTime(2024, 9, 26, 10, 33, 39, 772, DateTimeKind.Local).AddTicks(8937), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 772, DateTimeKind.Local).AddTicks(8940), new TimeSpan(0, 0, 0, 0, 0), false, 4, 6 },
                    { 19, "Explicabo veritatis ipsa rem iste eaque perspiciatis rem. Totam consequatur consectetur ut inventore ut id eligendi. Molestias at minima dolores. Adipisci et corporis numquam sed eum. Provident quo deleniti porro consequatur ipsum neque molestiae.", new DateTime(2024, 9, 26, 10, 33, 39, 773, DateTimeKind.Local).AddTicks(9997), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 774, DateTimeKind.Local).AddTicks(23), new TimeSpan(0, 0, 0, 0, 0), true, 4, 6 },
                    { 20, "Voluptatibus libero totam doloremque enim amet. Corporis doloribus vitae aut suscipit non accusantium. Sed dicta dolorem ut quae aliquam natus porro. Vel dolorem id soluta eos. Nesciunt ut dolor. Tempora nisi quas recusandae magni dicta dicta.", new DateTime(2024, 9, 26, 10, 33, 39, 774, DateTimeKind.Local).AddTicks(234), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 774, DateTimeKind.Local).AddTicks(236), new TimeSpan(0, 0, 0, 0, 0), true, 4, 10 },
                    { 21, "Et omnis omnis laborum aliquam sit. Facere architecto dolores est repellendus molestiae magni. Enim non repellendus iste nam id. Quidem blanditiis aspernatur. Nostrum rerum dolores ullam molestiae odit quo fugit consequatur. Reiciendis et voluptas ut cupiditate amet quo laudantium.", new DateTime(2024, 9, 26, 10, 33, 39, 775, DateTimeKind.Local).AddTicks(1254), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 775, DateTimeKind.Local).AddTicks(1283), new TimeSpan(0, 0, 0, 0, 0), false, 5, 9 },
                    { 22, "Facere in nesciunt necessitatibus. Quos quia est velit. Sed fuga temporibus impedit sint et inventore. Soluta quis qui qui explicabo magni rem. Iste dolore consequatur commodi est inventore in voluptas illum.", new DateTime(2024, 9, 26, 10, 33, 39, 775, DateTimeKind.Local).AddTicks(1491), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 775, DateTimeKind.Local).AddTicks(1493), new TimeSpan(0, 0, 0, 0, 0), true, 5, 9 },
                    { 23, "Voluptates illo voluptas modi perspiciatis ducimus quidem fuga sed. Et maiores veritatis officiis soluta. Aspernatur asperiores reprehenderit dolorem voluptatem adipisci. Sunt quia maiores magnam sequi voluptatem est repudiandae. Excepturi explicabo nihil minima sit praesentium aliquid. Doloremque nobis dolorum libero sed voluptas exercitationem.", new DateTime(2024, 9, 26, 10, 33, 39, 776, DateTimeKind.Local).AddTicks(2168), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 776, DateTimeKind.Local).AddTicks(2212), new TimeSpan(0, 0, 0, 0, 0), true, 5, 1 },
                    { 24, "Cupiditate ipsum autem ut voluptas at rerum occaecati. Molestiae exercitationem dolore est molestiae repudiandae deleniti rerum est. Et id ut. Itaque delectus qui excepturi vero provident.", new DateTime(2024, 9, 26, 10, 33, 39, 776, DateTimeKind.Local).AddTicks(2395), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 776, DateTimeKind.Local).AddTicks(2397), new TimeSpan(0, 0, 0, 0, 0), true, 5, 5 },
                    { 25, "Illo et aut. Repellendus tempora corporis architecto culpa maiores inventore aut hic sit. Incidunt expedita doloribus quisquam sit.", new DateTime(2024, 9, 26, 10, 33, 39, 777, DateTimeKind.Local).AddTicks(3002), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 777, DateTimeKind.Local).AddTicks(3030), new TimeSpan(0, 0, 0, 0, 0), false, 5, 1 },
                    { 26, "Quae deleniti magni id iure nemo. Autem corporis veniam. Ut iure esse quidem assumenda est fugit pariatur assumenda consequuntur. Voluptatem in consequatur quia dignissimos qui dolores tempora beatae totam. Est in corrupti excepturi quia hic veritatis laudantium rerum.", new DateTime(2024, 9, 26, 10, 33, 39, 777, DateTimeKind.Local).AddTicks(3328), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 777, DateTimeKind.Local).AddTicks(3330), new TimeSpan(0, 0, 0, 0, 0), false, 5, 1 },
                    { 27, "Debitis veritatis fuga aut deserunt. Atque vel sunt sed consequatur dolorem velit. Soluta dolorem dolores omnis nemo architecto sit. Beatae sed quia expedita dolor consequuntur quia. Laborum cumque aspernatur saepe dolores cumque fuga aut.", new DateTime(2024, 9, 26, 10, 33, 39, 778, DateTimeKind.Local).AddTicks(3789), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 778, DateTimeKind.Local).AddTicks(3817), new TimeSpan(0, 0, 0, 0, 0), false, 6, 10 },
                    { 28, "Rerum doloribus nam magni pariatur beatae recusandae dolores quibusdam. Aperiam facilis quam adipisci ea laudantium recusandae aut. Maxime ut totam sapiente nostrum blanditiis eveniet. Veniam debitis sunt dolorem non. Aut eaque minus expedita doloribus est qui.", new DateTime(2024, 9, 26, 10, 33, 39, 778, DateTimeKind.Local).AddTicks(4030), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 778, DateTimeKind.Local).AddTicks(4032), new TimeSpan(0, 0, 0, 0, 0), false, 6, 4 },
                    { 29, "Debitis ratione eaque exercitationem reprehenderit et vero sunt exercitationem corporis. Corrupti aliquid eos quasi fugiat eum. Vel velit incidunt quis quibusdam omnis hic facere. Quia hic ipsam sed facere facere cumque qui dolorem. Itaque est ea id culpa ducimus aut. Necessitatibus enim quae eum culpa velit quidem et.", new DateTime(2024, 9, 26, 10, 33, 39, 780, DateTimeKind.Local).AddTicks(3824), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 780, DateTimeKind.Local).AddTicks(3856), new TimeSpan(0, 0, 0, 0, 0), true, 6, 4 },
                    { 30, "Quae quaerat molestias nesciunt. Delectus animi ea inventore quo. Aliquid provident voluptatem vitae voluptate nihil est culpa.", new DateTime(2024, 9, 26, 10, 33, 39, 780, DateTimeKind.Local).AddTicks(4031), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 780, DateTimeKind.Local).AddTicks(4033), new TimeSpan(0, 0, 0, 0, 0), false, 6, 8 },
                    { 31, "Quas nisi molestiae et ullam sint. Voluptatem blanditiis minus veniam. Id natus consectetur ut tempora illum sint quia. Beatae sint sapiente quia sunt quam. Quia modi in doloremque.", new DateTime(2024, 9, 26, 10, 33, 39, 781, DateTimeKind.Local).AddTicks(5498), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 781, DateTimeKind.Local).AddTicks(5527), new TimeSpan(0, 0, 0, 0, 0), true, 6, 7 },
                    { 32, "Voluptatem sapiente voluptas consequatur sunt rem et nihil neque est. Iste possimus veniam voluptatem alias. Fugiat aut voluptas labore qui laborum aut.", new DateTime(2024, 9, 26, 10, 33, 39, 781, DateTimeKind.Local).AddTicks(5783), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 781, DateTimeKind.Local).AddTicks(5785), new TimeSpan(0, 0, 0, 0, 0), false, 6, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Gates",
                keyColumn: "GateId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Gates",
                keyColumn: "GateId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "QRCardStatus",
                keyColumn: "QRCardStatusId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "QRCardStatus",
                keyColumn: "QRCardStatusId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "QRCardType",
                keyColumn: "QRCardTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "QRCardType",
                keyColumn: "QRCardTypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 6);

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
                values: new object[] { 2, new DateTime(2024, 9, 9, 1, 37, 3, 694, DateTimeKind.Utc).AddTicks(7483), "Phòng Kinh doanh", "Sit itaque laboriosam odio et.", new DateTime(2024, 9, 9, 1, 37, 3, 694, DateTimeKind.Utc).AddTicks(7483) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 22, 19, 52, 21, 411, DateTimeKind.Utc).AddTicks(6258), "Phòng Chăm sóc khách hàng", "Expedita hic sed vel qui ratione sit quis.", new DateTime(2024, 9, 22, 19, 52, 21, 411, DateTimeKind.Utc).AddTicks(6258) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 4, new DateTime(2024, 9, 15, 20, 45, 49, 236, DateTimeKind.Utc).AddTicks(3413), "Phòng Pháp chế", "Nihil nam sit suscipit.", new DateTime(2024, 9, 15, 20, 45, 49, 236, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 4, new DateTime(2024, 9, 4, 13, 44, 16, 969, DateTimeKind.Utc).AddTicks(976), "Phòng Chăm sóc khách hàng", "Modi eum veritatis sit doloremque odit earum facilis sint praesentium.", new DateTime(2024, 9, 4, 13, 44, 16, 969, DateTimeKind.Utc).AddTicks(976) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 5, 19, 27, 7, 453, DateTimeKind.Utc).AddTicks(8225), "Phòng Pháp chế", "Voluptas architecto ut eum consequatur veritatis omnis natus consequatur voluptatem.", new DateTime(2024, 9, 5, 19, 27, 7, 453, DateTimeKind.Utc).AddTicks(8225) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 6,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 9, 12, 20, 16, 46, 431, DateTimeKind.Utc).AddTicks(3011), "Phòng Pháp chế", "Aperiam voluptas voluptas sed deserunt natus fuga nihil dolores.", new DateTime(2024, 9, 12, 20, 16, 46, 431, DateTimeKind.Utc).AddTicks(3011) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 7,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 4, new DateTime(2024, 9, 11, 21, 14, 1, 460, DateTimeKind.Utc).AddTicks(8567), "Phòng Nhân sự", "Quis facere ex et est veritatis accusamus.", new DateTime(2024, 9, 11, 21, 14, 1, 460, DateTimeKind.Utc).AddTicks(8567) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 8,
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 15, 14, 56, 694, DateTimeKind.Utc).AddTicks(8462), "Phòng Hành chính", "Nobis ut quisquam nesciunt in qui voluptatem quasi.", new DateTime(2024, 9, 11, 15, 14, 56, 694, DateTimeKind.Utc).AddTicks(8462) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 9,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 9, 14, 19, 27, 28, 659, DateTimeKind.Utc).AddTicks(4207), "Phòng Kế toán", "Harum aut saepe quaerat expedita natus illum impedit sit fugiat.", new DateTime(2024, 9, 14, 19, 27, 28, 659, DateTimeKind.Utc).AddTicks(4207) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 10,
                columns: new[] { "AcceptLevel", "CreateDate", "Description", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2024, 9, 20, 1, 7, 44, 959, DateTimeKind.Utc).AddTicks(4003), "Pariatur quasi in tempore aut velit animi necessitatibus.", new DateTime(2024, 9, 20, 1, 7, 44, 959, DateTimeKind.Utc).AddTicks(4003) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProcessId",
                keyValue: 1,
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 24, 3, 17, 14, 145, DateTimeKind.Utc).AddTicks(4163), "Handcrafted Cotton Cheese", true });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProcessId",
                keyValue: 2,
                columns: new[] { "CreateTime", "ProcessName" },
                values: new object[] { new DateTime(2024, 9, 24, 3, 17, 14, 145, DateTimeKind.Utc).AddTicks(6771), "Incredible Fresh Bacon" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProcessId",
                keyValue: 3,
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 24, 3, 17, 14, 145, DateTimeKind.Utc).AddTicks(6799), "Awesome Cotton Shirt", true });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProcessId",
                keyValue: 4,
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 24, 3, 17, 14, 145, DateTimeKind.Utc).AddTicks(6817), "Practical Soft Shirt", true });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProcessId",
                keyValue: 5,
                columns: new[] { "CreateTime", "ProcessName" },
                values: new object[] { new DateTime(2024, 9, 24, 3, 17, 14, 145, DateTimeKind.Utc).AddTicks(6835), "Practical Rubber Table" });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 4,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 2, 21 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 5,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 4, 13 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 6,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 5, 16 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 7,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 4, 10 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 8,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 22 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 9,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 3, 21 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 10,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 3, 10 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 11,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 11 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 12,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 4, 25 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 13,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 1, 16 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 14,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 4, 9 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 15,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 12 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 16,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 6 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 17,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 6, 23 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 18,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 3, 11 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 19,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 6, 22 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 20,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 3, 23 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 21,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 21 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 22,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 4, 23 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 23,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 2, 10 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 3, 17, 14, 132, DateTimeKind.Utc).AddTicks(3171), new DateTime(2024, 9, 26, 3, 17, 14, 132, DateTimeKind.Utc).AddTicks(3180) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 26, 3, 17, 14, 132, DateTimeKind.Utc).AddTicks(3183), new DateTime(2024, 9, 26, 3, 17, 14, 132, DateTimeKind.Utc).AddTicks(3184) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 26, 3, 17, 14, 132, DateTimeKind.Utc).AddTicks(3185), new DateTime(2024, 9, 26, 3, 17, 14, 132, DateTimeKind.Utc).AddTicks(3186) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 3, 17, 14, 132, DateTimeKind.Utc).AddTicks(3188), new DateTime(2024, 9, 26, 3, 17, 14, 132, DateTimeKind.Utc).AddTicks(3188) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 26, 3, 17, 14, 132, DateTimeKind.Utc).AddTicks(3190), new DateTime(2024, 9, 26, 3, 17, 14, 132, DateTimeKind.Utc).AddTicks(3190) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 19, 2, 59, 45, 245, DateTimeKind.Unspecified).AddTicks(9850), "gmail.com.Bahringer@hotmail.com", "Rubye Kuphal", "f2noko", "0959250823", 4, new DateTime(2024, 9, 19, 2, 59, 45, 245, DateTimeKind.Unspecified).AddTicks(9850), "Ruthe.Gorczany18" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 15, 3, 4, 55, 526, DateTimeKind.Unspecified).AddTicks(2367), "gmail.com.Tremblay72@yahoo.com", "Anabel Baumbach", "6i0h9q", "0648248532", 2, new DateTime(2024, 9, 15, 3, 4, 55, 526, DateTimeKind.Unspecified).AddTicks(2367), "Skylar.Zulauf" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 19, 10, 7, 6, 103, DateTimeKind.Unspecified).AddTicks(7610), "gmail.com.Robel@yahoo.com", "Leon Jones", "kk6vsa", "0884744236", new DateTime(2024, 9, 19, 10, 7, 6, 103, DateTimeKind.Unspecified).AddTicks(7610), "Patience.Kassulke" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 1, 11, 29, 29, 663, DateTimeKind.Unspecified).AddTicks(2909), "gmail.com61@yahoo.com", "Carley Stark", "vojr8c", "0669391328", 2, new DateTime(2024, 9, 1, 11, 29, 29, 663, DateTimeKind.Unspecified).AddTicks(2909), "Lucinda63" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 5, 10, 30, 59, 303, DateTimeKind.Unspecified).AddTicks(120), "gmail.com10@gmail.com", "Destany Durgan", "kprbti", "0789172719", 1, new DateTime(2024, 9, 5, 10, 30, 59, 303, DateTimeKind.Unspecified).AddTicks(120), "Wiley74" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 2, 6, 53, 24, 777, DateTimeKind.Unspecified).AddTicks(9395), "gmail.com.Baumbach@hotmail.com", "Katherine Gaylord", "rrad97", "0957436780", 5, new DateTime(2024, 9, 2, 6, 53, 24, 777, DateTimeKind.Unspecified).AddTicks(9395), "Norwood_Aufderhar" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 16, 12, 20, 32, 487, DateTimeKind.Unspecified).AddTicks(9702), "gmail.com_Lesch@yahoo.com", "Amelie Stoltenberg", "pdplxd", "0975028154", new DateTime(2024, 9, 16, 12, 20, 32, 487, DateTimeKind.Unspecified).AddTicks(9702), "Stella_Metz" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 3, 9, 55, 45, 277, DateTimeKind.Unspecified).AddTicks(8444), "gmail.com39@gmail.com", "Karelle Haag", "v96f1n", "0345169252", 2, new DateTime(2024, 9, 3, 9, 55, 45, 277, DateTimeKind.Unspecified).AddTicks(8444), "Alize.Kreiger71" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 1, 23, 1, 1, 725, DateTimeKind.Unspecified).AddTicks(629), "gmail.com_Herman66@gmail.com", "Mylene Marquardt", "4m9pb2", "0978822463", 3, new DateTime(2024, 9, 1, 23, 1, 1, 725, DateTimeKind.Unspecified).AddTicks(629), "Carey96" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 20, 1, 46, 33, 277, DateTimeKind.Unspecified).AddTicks(1621), "gmail.com86@hotmail.com", "Parker Nader", "raaqq6", "0148521413", 3, new DateTime(2024, 9, 20, 1, 46, 33, 277, DateTimeKind.Unspecified).AddTicks(1621), "Dayna_Gerlach" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 9, 20, 44, 36, 827, DateTimeKind.Unspecified).AddTicks(354), "gmail.com.Shields51@yahoo.com", "Rodger Moen", "6p4386", "0955635866", 4, new DateTime(2024, 9, 9, 20, 44, 36, 827, DateTimeKind.Unspecified).AddTicks(354), "Franco_Braun" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 6, 3, 1, 14, 342, DateTimeKind.Unspecified).AddTicks(726), "gmail.com_Franecki12@gmail.com", "Orville Ward", "s6hupg", "0784462431", 5, new DateTime(2024, 9, 6, 3, 1, 14, 342, DateTimeKind.Unspecified).AddTicks(726), "Amely72" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 15, 11, 40, 15, 296, DateTimeKind.Unspecified).AddTicks(3121), "gmail.com22@hotmail.com", "King Beatty", "4pgocs", "0597412004", 3, new DateTime(2024, 9, 15, 11, 40, 15, 296, DateTimeKind.Unspecified).AddTicks(3121), "Letitia.Deckow" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 21, 13, 39, 23, 323, DateTimeKind.Unspecified).AddTicks(3231), "gmail.com_Muller@hotmail.com", "Helene McCullough", "qni83t", "0470116832", 2, new DateTime(2024, 9, 21, 13, 39, 23, 323, DateTimeKind.Unspecified).AddTicks(3231), "Elena.Schultz69" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 19, 46, 723, DateTimeKind.Unspecified).AddTicks(6547), "gmail.com40@hotmail.com", "Lucile Abernathy", "puq8s1", "0906409321", new DateTime(2024, 9, 11, 23, 19, 46, 723, DateTimeKind.Unspecified).AddTicks(6547), "Mable.Mann" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 7, 5, 7, 54, 798, DateTimeKind.Unspecified).AddTicks(4806), "gmail.com.Bernier63@hotmail.com", "Zena Labadie", "8lh61f", "0925024023", 2, new DateTime(2024, 9, 7, 5, 7, 54, 798, DateTimeKind.Unspecified).AddTicks(4806), "Avis.Konopelski86" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 1, 16, 46, 7, 847, DateTimeKind.Unspecified).AddTicks(8959), "gmail.com.Mraz@yahoo.com", "Einar Kuhlman", "5mv6dk", "0669702739", 4, new DateTime(2024, 9, 1, 16, 46, 7, 847, DateTimeKind.Unspecified).AddTicks(8959), "Tabitha_Flatley" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 21, 23, 48, 48, 713, DateTimeKind.Unspecified).AddTicks(5109), "gmail.com2@gmail.com", "Laura Veum", "alek7n", "0337355594", new DateTime(2024, 9, 21, 23, 48, 48, 713, DateTimeKind.Unspecified).AddTicks(5109), "Nyah78" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 13, 13, 30, 53, 238, DateTimeKind.Unspecified).AddTicks(6523), "gmail.com41@hotmail.com", "Sandrine Watsica", "563bx3", "0724931273", new DateTime(2024, 9, 13, 13, 30, 53, 238, DateTimeKind.Unspecified).AddTicks(6523), "Ashly79" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 12, 11, 58, 54, 134, DateTimeKind.Unspecified).AddTicks(679), "gmail.com.Hansen@yahoo.com", "Federico Beahan", "5eiulz", "0907208467", 3, new DateTime(2024, 9, 12, 11, 58, 54, 134, DateTimeKind.Unspecified).AddTicks(679), "Ariel.Beer57" });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 1,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Odio autem molestias et magni neque. Reiciendis expedita eaque accusantium beatae omnis recusandae consequuntur quas. Nobis fuga in. Tempore maiores ab aut voluptatem doloribus aut debitis. Vel laudantium eos quas cumque dolorum hic exercitationem id nisi. Incidunt omnis magni.", new DateTime(2024, 10, 25, 10, 17, 14, 158, DateTimeKind.Local).AddTicks(5818), new DateTime(2024, 9, 25, 10, 17, 14, 158, DateTimeKind.Local).AddTicks(5758) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 2,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Vel dolorem sint aut amet aut aut enim possimus. Est non qui laborum ducimus a aut facere est. Est est molestias. Qui ipsum officiis cumque ipsum modi accusamus sint eligendi. Sed cupiditate culpa voluptas. Sunt a veritatis natus doloribus quam est harum.", new DateTime(2024, 10, 25, 10, 17, 14, 158, DateTimeKind.Local).AddTicks(8788), new DateTime(2024, 9, 25, 10, 17, 14, 158, DateTimeKind.Local).AddTicks(8781) });

            migrationBuilder.UpdateData(
                table: "VisitProjects",
                keyColumn: "VisitProcessId",
                keyValue: 1,
                columns: new[] { "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { new DateTime(2024, 10, 25, 10, 17, 14, 148, DateTimeKind.Local).AddTicks(9293), new DateTime(2024, 9, 25, 10, 17, 14, 148, DateTimeKind.Local).AddTicks(9174) });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 1,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Mayert, Sawayn and Daugherty", new DateTime(2024, 9, 6, 7, 24, 37, 402, DateTimeKind.Unspecified).AddTicks(7509), "9be925v2ev", "0344032499", false, new DateTime(2024, 9, 6, 7, 24, 37, 402, DateTimeKind.Unspecified).AddTicks(7509), "Cristal Shields" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 2,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Cartwright - Block", new DateTime(2024, 9, 9, 7, 27, 12, 736, DateTimeKind.Unspecified).AddTicks(4417), "iedyj3wg5p", "0758992551", false, new DateTime(2024, 9, 9, 7, 27, 12, 736, DateTimeKind.Unspecified).AddTicks(4417), "Augustine Kozey" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 3,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Kiehn, Jast and Braun", new DateTime(2024, 9, 18, 10, 15, 31, 878, DateTimeKind.Unspecified).AddTicks(4178), "auhoxfjqhw", "0722837084", new DateTime(2024, 9, 18, 10, 15, 31, 878, DateTimeKind.Unspecified).AddTicks(4178), "Matt Dickinson" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 4,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Kemmer, Boehm and Robel", new DateTime(2024, 9, 3, 12, 52, 23, 322, DateTimeKind.Unspecified).AddTicks(1797), "s43o02vs02", "0297155591", true, new DateTime(2024, 9, 3, 12, 52, 23, 322, DateTimeKind.Unspecified).AddTicks(1797), "Gerardo Christiansen" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 5,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Kihn Group", new DateTime(2024, 9, 11, 16, 31, 43, 273, DateTimeKind.Unspecified).AddTicks(6010), 2, "91b82qe6gp", "0880567019", true, new DateTime(2024, 9, 11, 16, 31, 43, 273, DateTimeKind.Unspecified).AddTicks(6010), "Henriette Koepp" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 6,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Wunsch LLC", new DateTime(2024, 9, 15, 3, 3, 25, 967, DateTimeKind.Unspecified).AddTicks(1043), "tzmeq5ig11", "0227161465", new DateTime(2024, 9, 15, 3, 3, 25, 967, DateTimeKind.Unspecified).AddTicks(1043), "Betsy Littel" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 7,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Gaylord, Abbott and O'Conner", new DateTime(2024, 9, 7, 22, 10, 41, 591, DateTimeKind.Unspecified).AddTicks(1763), "m0qfimtuij", "0537107402", false, new DateTime(2024, 9, 7, 22, 10, 41, 591, DateTimeKind.Unspecified).AddTicks(1763), "Carley Sawayn" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 8,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Hessel, Carroll and Cartwright", new DateTime(2024, 9, 5, 20, 33, 56, 209, DateTimeKind.Unspecified).AddTicks(8765), 2, "yc5bk6pn44", "0596021935", new DateTime(2024, 9, 5, 20, 33, 56, 209, DateTimeKind.Unspecified).AddTicks(8765), "Julianne Luettgen" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 9,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Streich - Buckridge", new DateTime(2024, 9, 8, 11, 4, 50, 435, DateTimeKind.Unspecified).AddTicks(3379), 2, "yi6zfwojze", "0766996913", new DateTime(2024, 9, 8, 11, 4, 50, 435, DateTimeKind.Unspecified).AddTicks(3379), "Ambrose Wehner" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 10,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Spinka, Heidenreich and Homenick", new DateTime(2024, 9, 24, 14, 46, 34, 229, DateTimeKind.Unspecified).AddTicks(4399), 1, "d0jtijjoze", "0531695082", true, new DateTime(2024, 9, 24, 14, 46, 34, 229, DateTimeKind.Unspecified).AddTicks(4399), "Winston Crist" });

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 1,
                column: "DateRegister",
                value: new DateTime(2024, 9, 24, 10, 17, 14, 147, DateTimeKind.Local).AddTicks(3183));
        }
    }
}
