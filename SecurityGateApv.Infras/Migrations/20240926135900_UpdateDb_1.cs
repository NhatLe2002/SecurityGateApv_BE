using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecurityGateApv.Infras.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDb_1 : Migration
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
                table: "CredentialCardTypes",
                keyColumn: "CredentialCardTypeId",
                keyValue: 2,
                column: "CredentialCardTypeName",
                value: "Căn cước công dân");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 9, 25, 6, 54, 21, 513, DateTimeKind.Utc).AddTicks(9465), "Phòng Kinh doanh", "Qui iusto ab id numquam.", new DateTime(2024, 9, 25, 6, 54, 21, 513, DateTimeKind.Utc).AddTicks(9465) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 9, 9, 8, 55, 55, 555, DateTimeKind.Utc).AddTicks(4554), "Phòng Chăm sóc khách hàng", "Ut dolore eos.", new DateTime(2024, 9, 9, 8, 55, 55, 555, DateTimeKind.Utc).AddTicks(4554) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 4, 18, 53, 26, 524, DateTimeKind.Utc).AddTicks(253), "Phòng Kinh doanh", "Velit ut magni dolores exercitationem.", new DateTime(2024, 9, 4, 18, 53, 26, 524, DateTimeKind.Utc).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 4, new DateTime(2024, 9, 12, 22, 6, 57, 959, DateTimeKind.Utc).AddTicks(6175), "Phòng Chăm sóc khách hàng", "Laboriosam harum amet labore ea nobis sint accusantium magni.", new DateTime(2024, 9, 12, 22, 6, 57, 959, DateTimeKind.Utc).AddTicks(6175) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2024, 9, 11, 6, 28, 8, 496, DateTimeKind.Utc).AddTicks(2588), "Phòng Chăm sóc khách hàng", "Quae in similique.", new DateTime(2024, 9, 11, 6, 28, 8, 496, DateTimeKind.Utc).AddTicks(2588) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 6,
                columns: new[] { "AcceptLevel", "CreateDate", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 10, 12, 2, 4, 320, DateTimeKind.Utc).AddTicks(4826), "Tempore aut molestiae provident.", new DateTime(2024, 9, 10, 12, 2, 4, 320, DateTimeKind.Utc).AddTicks(4826) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 7,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 11, 16, 12, 34, 606, DateTimeKind.Utc).AddTicks(9764), "Phòng Kinh doanh", "Beatae voluptas mollitia.", new DateTime(2024, 9, 11, 16, 12, 34, 606, DateTimeKind.Utc).AddTicks(9764) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 8,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 9, 14, 14, 10, 17, 43, DateTimeKind.Utc).AddTicks(981), "Phòng Kinh doanh", "Voluptates voluptatem qui quia praesentium quia.", new DateTime(2024, 9, 14, 14, 10, 17, 43, DateTimeKind.Utc).AddTicks(981) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 9,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 4, new DateTime(2024, 9, 13, 16, 30, 38, 922, DateTimeKind.Utc).AddTicks(5353), "Phòng Marketing", "Sit incidunt libero.", new DateTime(2024, 9, 13, 16, 30, 38, 922, DateTimeKind.Utc).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 10,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2024, 9, 17, 11, 5, 13, 899, DateTimeKind.Utc).AddTicks(6473), "Phòng Sản xuất", "Quo ut non commodi corporis eveniet iusto cum illum.", new DateTime(2024, 9, 17, 11, 5, 13, 899, DateTimeKind.Utc).AddTicks(6473) });

            migrationBuilder.UpdateData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: 1,
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 24, 13, 58, 59, 289, DateTimeKind.Utc).AddTicks(2434), "Sleek Wooden Cheese", true });

            migrationBuilder.UpdateData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: 2,
                columns: new[] { "CreateTime", "ProcessName" },
                values: new object[] { new DateTime(2024, 9, 24, 13, 58, 59, 289, DateTimeKind.Utc).AddTicks(5398), "Generic Frozen Salad" });

            migrationBuilder.UpdateData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: 3,
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 24, 13, 58, 59, 289, DateTimeKind.Utc).AddTicks(5433), "Licensed Concrete Shirt", false });

            migrationBuilder.UpdateData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: 4,
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 24, 13, 58, 59, 289, DateTimeKind.Utc).AddTicks(5450), "Refined Granite Chair", false });

            migrationBuilder.UpdateData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: 5,
                columns: new[] { "CreateTime", "ProcessName" },
                values: new object[] { new DateTime(2024, 9, 24, 13, 58, 59, 289, DateTimeKind.Utc).AddTicks(5467), "Generic Cotton Towels" });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 1,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId", "QRCardTypeId" },
                values: new object[] { new Guid("52cf61e7-af39-41ad-b625-f715b10a61ed"), new DateTime(2024, 9, 26, 20, 58, 59, 359, DateTimeKind.Local).AddTicks(9828), new DateTime(2024, 10, 26, 20, 58, 59, 359, DateTimeKind.Local).AddTicks(9828), 2, 1 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 2,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("0740a1b2-0279-4fa7-8483-d3c012168056"), new DateTime(2024, 9, 26, 20, 58, 59, 360, DateTimeKind.Local).AddTicks(135), new DateTime(2024, 10, 26, 20, 58, 59, 360, DateTimeKind.Local).AddTicks(135) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 3,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardTypeId" },
                values: new object[] { new Guid("5813acbe-9749-4440-a04c-0216a98a670b"), new DateTime(2024, 9, 26, 20, 58, 59, 360, DateTimeKind.Local).AddTicks(153), new DateTime(2024, 10, 26, 20, 58, 59, 360, DateTimeKind.Local).AddTicks(153), 1 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 4,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId" },
                values: new object[] { new Guid("153c8b04-82bf-454d-ac65-965f377e8b9c"), new DateTime(2024, 9, 26, 20, 58, 59, 360, DateTimeKind.Local).AddTicks(165), new DateTime(2024, 10, 26, 20, 58, 59, 360, DateTimeKind.Local).AddTicks(165), 1 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 5,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardTypeId" },
                values: new object[] { new Guid("8d3fdbcc-48c9-4aaa-abf1-7a317ff7216c"), new DateTime(2024, 9, 26, 20, 58, 59, 360, DateTimeKind.Local).AddTicks(192), new DateTime(2024, 10, 26, 20, 58, 59, 360, DateTimeKind.Local).AddTicks(192), 1 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 6,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardTypeId" },
                values: new object[] { new Guid("0176a987-218f-4d18-9132-bab289272c84"), new DateTime(2024, 9, 26, 20, 58, 59, 360, DateTimeKind.Local).AddTicks(203), new DateTime(2024, 10, 26, 20, 58, 59, 360, DateTimeKind.Local).AddTicks(203), 1 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 7,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardTypeId" },
                values: new object[] { new Guid("4a08da74-6a02-4eab-8c6a-3d5384a5dd7b"), new DateTime(2024, 9, 26, 20, 58, 59, 360, DateTimeKind.Local).AddTicks(212), new DateTime(2024, 10, 26, 20, 58, 59, 360, DateTimeKind.Local).AddTicks(212), 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 8,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId" },
                values: new object[] { new Guid("adc74f61-9047-4f0b-9c32-643d56540f1d"), new DateTime(2024, 9, 26, 20, 58, 59, 360, DateTimeKind.Local).AddTicks(275), new DateTime(2024, 10, 26, 20, 58, 59, 360, DateTimeKind.Local).AddTicks(275), 1 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 9,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId", "QRCardTypeId" },
                values: new object[] { new Guid("e23859ee-679d-4f2d-8e06-98794c0bcc92"), new DateTime(2024, 9, 26, 20, 58, 59, 360, DateTimeKind.Local).AddTicks(297), new DateTime(2024, 10, 26, 20, 58, 59, 360, DateTimeKind.Local).AddTicks(297), 2, 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 10,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId" },
                values: new object[] { new Guid("09f809e1-1f25-444f-b7ec-ea5ca32b1f9f"), new DateTime(2024, 9, 26, 20, 58, 59, 360, DateTimeKind.Local).AddTicks(308), new DateTime(2024, 10, 26, 20, 58, 59, 360, DateTimeKind.Local).AddTicks(308), 2 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 4,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 3, 24 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 5,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 10 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 6,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 3, 17 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 7,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 6, 6 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 8,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 1, 16 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 9,
                column: "UserId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 10,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 2, 14 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 11,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 15 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 12,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 25 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 13,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 22 });

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
                values: new object[] { 5, 10 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 16,
                column: "DepartmentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 17,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 10, 21 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 18,
                column: "UserId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 19,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 6, 14 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 20,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 1, 20 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 21,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 3, 10 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 22,
                column: "UserId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 23,
                column: "UserId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 13, 58, 59, 273, DateTimeKind.Utc).AddTicks(9419), new DateTime(2024, 9, 26, 13, 58, 59, 273, DateTimeKind.Utc).AddTicks(9425) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 26, 13, 58, 59, 273, DateTimeKind.Utc).AddTicks(9429), new DateTime(2024, 9, 26, 13, 58, 59, 273, DateTimeKind.Utc).AddTicks(9430) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 26, 13, 58, 59, 273, DateTimeKind.Utc).AddTicks(9432), new DateTime(2024, 9, 26, 13, 58, 59, 273, DateTimeKind.Utc).AddTicks(9432) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 13, 58, 59, 273, DateTimeKind.Utc).AddTicks(9434), new DateTime(2024, 9, 26, 13, 58, 59, 273, DateTimeKind.Utc).AddTicks(9434) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 26, 13, 58, 59, 273, DateTimeKind.Utc).AddTicks(9436), new DateTime(2024, 9, 26, 13, 58, 59, 273, DateTimeKind.Utc).AddTicks(9436) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 6, 12, 54, 41, 18, DateTimeKind.Unspecified).AddTicks(9972), "gmail.com_Daugherty25@gmail.com", "Nelle Labadie", "k90o18", "0221635545", 2, new DateTime(2024, 9, 6, 12, 54, 41, 18, DateTimeKind.Unspecified).AddTicks(9972), "Margaretta46" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 21, 16, 44, 50, 540, DateTimeKind.Unspecified).AddTicks(94), "gmail.com28@gmail.com", "Dortha Nikolaus", "lpsjea", "0765958967", 1, new DateTime(2024, 9, 21, 16, 44, 50, 540, DateTimeKind.Unspecified).AddTicks(94), "Ottilie96" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 9, 9, 46, 23, 759, DateTimeKind.Unspecified).AddTicks(5753), "gmail.com.Wehner8@gmail.com", "Lucy Mann", "nkl7u1", "0782943701", 2, new DateTime(2024, 9, 9, 9, 46, 23, 759, DateTimeKind.Unspecified).AddTicks(5753), "Shanny35" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 10, 10, 28, 54, 710, DateTimeKind.Unspecified).AddTicks(5595), "gmail.com_Murray11@hotmail.com", "Deonte Purdy", "xo62k8", "0940722049", 1, new DateTime(2024, 9, 10, 10, 28, 54, 710, DateTimeKind.Unspecified).AddTicks(5595), "Laurence_Kirlin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 17, 10, 53, 39, 588, DateTimeKind.Unspecified).AddTicks(5921), "gmail.com15@gmail.com", "Joanie Roberts", "dvm0b1", "0212554892", 4, new DateTime(2024, 9, 17, 10, 53, 39, 588, DateTimeKind.Unspecified).AddTicks(5921), "Brian.Zboncak59" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 5, 8, 15, 12, 869, DateTimeKind.Unspecified).AddTicks(8651), "gmail.com90@yahoo.com", "Mario Halvorson", "2kd5xq", "0590308271", 1, new DateTime(2024, 9, 5, 8, 15, 12, 869, DateTimeKind.Unspecified).AddTicks(8651), "Camille13" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 19, 15, 19, 24, 97, DateTimeKind.Unspecified).AddTicks(6156), "gmail.com_Greenfelder11@gmail.com", "Deion Huel", "znjesg", "0350810904", 3, new DateTime(2024, 9, 19, 15, 19, 24, 97, DateTimeKind.Unspecified).AddTicks(6156), "Silas19" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 19, 10, 32, 46, 50, DateTimeKind.Unspecified).AddTicks(3321), "gmail.com.Volkman@yahoo.com", "Sylvia Padberg", "82rwka", "0843976366", 2, new DateTime(2024, 9, 19, 10, 32, 46, 50, DateTimeKind.Unspecified).AddTicks(3321), "Rosa.Metz" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 6, 21, 27, 10, 30, DateTimeKind.Unspecified).AddTicks(5876), "gmail.com24@yahoo.com", "Alf Steuber", "pol45x", "0202220360", 4, new DateTime(2024, 9, 6, 21, 27, 10, 30, DateTimeKind.Unspecified).AddTicks(5876), "Berry_Streich97" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 16, 21, 25, 3, 56, DateTimeKind.Unspecified).AddTicks(3470), "gmail.com.Krajcik@gmail.com", "Yasmine Grimes", "pxngof", "0340309130", 5, new DateTime(2024, 9, 16, 21, 25, 3, 56, DateTimeKind.Unspecified).AddTicks(3470), "Dangelo_Schaden" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 13, 13, 12, 44, 130, DateTimeKind.Unspecified).AddTicks(6178), "gmail.com.Grimes53@yahoo.com", "Tremayne Zboncak", "hogk85", "0618549087", 4, new DateTime(2024, 9, 13, 13, 12, 44, 130, DateTimeKind.Unspecified).AddTicks(6178), "Theron_Rippin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 18, 10, 23, 49, 120, DateTimeKind.Unspecified).AddTicks(5576), "gmail.com.Abshire48@hotmail.com", "Marianne Mueller", "716w0s", "0196947239", 4, new DateTime(2024, 9, 18, 10, 23, 49, 120, DateTimeKind.Unspecified).AddTicks(5576), "Conrad_Rodriguez76" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 16, 22, 51, 14, 69, DateTimeKind.Unspecified).AddTicks(5175), "gmail.com24@hotmail.com", "Damaris Schaefer", "ltoxnn", "0355706275", 2, new DateTime(2024, 9, 16, 22, 51, 14, 69, DateTimeKind.Unspecified).AddTicks(5175), "Royce.Blanda41" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 3, 1, 40, 26, 347, DateTimeKind.Unspecified).AddTicks(839), "gmail.com91@gmail.com", "Darrion Hintz", "3gp9pj", "0240066616", 4, new DateTime(2024, 9, 3, 1, 40, 26, 347, DateTimeKind.Unspecified).AddTicks(839), "Wilmer72" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 6, 13, 3, 3, 37, DateTimeKind.Unspecified).AddTicks(5917), "gmail.com75@gmail.com", "Jazmyn Pollich", "07g62s", "0538853522", 4, new DateTime(2024, 9, 6, 13, 3, 3, 37, DateTimeKind.Unspecified).AddTicks(5917), "Reymundo50" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 2, 4, 44, 10, 478, DateTimeKind.Unspecified).AddTicks(65), "gmail.com.Jacobson76@yahoo.com", "Quentin Hickle", "4jpv43", "0582383611", new DateTime(2024, 9, 2, 4, 44, 10, 478, DateTimeKind.Unspecified).AddTicks(65), "Keon5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 25, 4, 38, 51, 499, DateTimeKind.Unspecified).AddTicks(973), "gmail.com.Von14@gmail.com", "Tia Feeney", "23z1f2", "0494540006", 4, new DateTime(2024, 9, 25, 4, 38, 51, 499, DateTimeKind.Unspecified).AddTicks(973), "Adrienne1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 1, 1, 34, 51, 256, DateTimeKind.Unspecified).AddTicks(761), "gmail.com54@hotmail.com", "Cathrine Jerde", "vzzpd2", "0718169191", 2, new DateTime(2024, 9, 1, 1, 34, 51, 256, DateTimeKind.Unspecified).AddTicks(761), "Remington16" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 15, 17, 175, DateTimeKind.Unspecified).AddTicks(3900), "gmail.com.Padberg28@yahoo.com", "Jerod Dickinson", "1uljjo", "0847287169", new DateTime(2024, 9, 14, 15, 15, 17, 175, DateTimeKind.Unspecified).AddTicks(3900), "Gisselle.Shields39" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 23, 4, 20, 37, 587, DateTimeKind.Unspecified).AddTicks(1063), "gmail.com52@hotmail.com", "Idella Kilback", "yg0k45", "0807234758", 5, new DateTime(2024, 9, 23, 4, 20, 37, 587, DateTimeKind.Unspecified).AddTicks(1063), "Velva.Wiegand" });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 1,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Minus quia veniam velit quaerat exercitationem sed eum assumenda. Provident nisi impedit necessitatibus voluptatem officia. Nostrum earum officiis est dignissimos quis consequuntur sed iste.", new DateTime(2024, 10, 25, 20, 58, 59, 294, DateTimeKind.Local).AddTicks(2282), new DateTime(2024, 9, 25, 20, 58, 59, 294, DateTimeKind.Local).AddTicks(2243), 1 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 2,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Accusamus laudantium qui pariatur sunt molestiae et aliquam impedit. Molestias aspernatur inventore cum recusandae voluptatibus et. Nihil ut est sed. Sequi repellendus odit nostrum earum sed commodi.", new DateTime(2024, 10, 25, 20, 58, 59, 294, DateTimeKind.Local).AddTicks(2725), new DateTime(2024, 9, 25, 20, 58, 59, 294, DateTimeKind.Local).AddTicks(2722) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 3,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Quis aut perferendis accusamus quam tempore cum. Est ut quas vitae odit autem ut rerum laboriosam. Nulla tempore sed nisi tenetur eligendi.", new DateTime(2024, 9, 27, 20, 58, 59, 296, DateTimeKind.Local).AddTicks(4954), new DateTime(2024, 9, 26, 20, 58, 59, 296, DateTimeKind.Local).AddTicks(4921), 10 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 4,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Sunt qui autem doloremque. Odio quis qui rerum omnis. Aliquam enim qui quae sit dolorem nobis.", new DateTime(2024, 9, 27, 20, 58, 59, 296, DateTimeKind.Local).AddTicks(5192), new DateTime(2024, 9, 26, 20, 58, 59, 296, DateTimeKind.Local).AddTicks(5190) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 5,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Hic ipsam sit. Atque dignissimos et. Est ad et. Qui eos rerum eum eaque modi. Deserunt rerum in quo magni aspernatur. Debitis tenetur aperiam beatae ab.", new DateTime(2024, 9, 27, 20, 58, 59, 297, DateTimeKind.Local).AddTicks(7615), new DateTime(2024, 9, 26, 20, 58, 59, 297, DateTimeKind.Local).AddTicks(7583), 2 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 6,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Dolor perspiciatis vel quis cupiditate ut voluptas. Dolorem facere assumenda. Rerum cumque expedita esse deserunt. Voluptas labore unde a. Aperiam praesentium est recusandae repellat.", new DateTime(2024, 9, 27, 20, 58, 59, 297, DateTimeKind.Local).AddTicks(7860), new DateTime(2024, 9, 26, 20, 58, 59, 297, DateTimeKind.Local).AddTicks(7857), 1 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 7,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Praesentium laudantium sed ad dicta qui aut architecto reprehenderit fuga. Non ut ex vero incidunt ut. Vel beatae in omnis itaque quo.", new DateTime(2024, 9, 27, 20, 58, 59, 298, DateTimeKind.Local).AddTicks(8908), new DateTime(2024, 9, 26, 20, 58, 59, 298, DateTimeKind.Local).AddTicks(8881) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 8,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Ratione eligendi eius. Incidunt modi quisquam sunt ut omnis natus recusandae modi deserunt. Eveniet minima culpa. Provident temporibus quam est iure quibusdam voluptatem aut.", new DateTime(2024, 9, 27, 20, 58, 59, 298, DateTimeKind.Local).AddTicks(9132), new DateTime(2024, 9, 26, 20, 58, 59, 298, DateTimeKind.Local).AddTicks(9123), 2 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 9,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Quidem ut maxime maiores. Vel fuga qui. Minus dolorem qui qui molestiae libero facilis. Earum doloremque non. Eos delectus ut ullam explicabo sed autem. Iusto enim tempora officia fugit perferendis qui inventore totam autem.", new DateTime(2024, 9, 27, 20, 58, 59, 305, DateTimeKind.Local).AddTicks(3835), new DateTime(2024, 9, 26, 20, 58, 59, 305, DateTimeKind.Local).AddTicks(3760), 9 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 10,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Pariatur et esse unde blanditiis doloribus repellendus sed enim. Rerum nobis debitis asperiores temporibus odio. Ullam exercitationem enim.", new DateTime(2024, 9, 27, 20, 58, 59, 305, DateTimeKind.Local).AddTicks(4330), new DateTime(2024, 9, 26, 20, 58, 59, 305, DateTimeKind.Local).AddTicks(4325) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 11,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Corrupti consequuntur sequi aut. Et id ipsum ratione consectetur aut dicta. Soluta quae facilis est et.", new DateTime(2024, 9, 27, 20, 58, 59, 328, DateTimeKind.Local).AddTicks(3178), new DateTime(2024, 9, 26, 20, 58, 59, 328, DateTimeKind.Local).AddTicks(3092), 3 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 12,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Reiciendis aut nobis. Rerum sit dolor facere eos et dolore nihil est deserunt. Et repudiandae amet molestiae eum consectetur possimus distinctio vero.", new DateTime(2024, 9, 27, 20, 58, 59, 328, DateTimeKind.Local).AddTicks(3883), new DateTime(2024, 9, 26, 20, 58, 59, 328, DateTimeKind.Local).AddTicks(3875), 1 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 13,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Voluptatibus ea et dolores praesentium fugit. Labore animi aspernatur molestiae omnis ipsum. Dignissimos dolorem repellendus. Tenetur culpa cum veniam dolor ea iusto ea. At atque voluptas voluptatum tenetur numquam nulla nostrum. Nesciunt ut maiores provident totam dolor et at debitis quis.", new DateTime(2024, 9, 27, 20, 58, 59, 331, DateTimeKind.Local).AddTicks(2124), new DateTime(2024, 9, 26, 20, 58, 59, 331, DateTimeKind.Local).AddTicks(2054), 6 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 14,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Fuga suscipit fugiat doloremque. Et magni magni aperiam sed facilis. Magnam iusto magnam. In repellendus tempore repellat molestiae.", new DateTime(2024, 9, 27, 20, 58, 59, 331, DateTimeKind.Local).AddTicks(2517), new DateTime(2024, 9, 26, 20, 58, 59, 331, DateTimeKind.Local).AddTicks(2513), 6 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 15,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Provident iste eos mollitia accusamus expedita earum et fugiat maxime. Qui aut hic nulla reiciendis quibusdam dignissimos ullam praesentium non. Et ex rerum rerum. A nobis labore aut velit esse aut.", new DateTime(2024, 9, 27, 20, 58, 59, 334, DateTimeKind.Local).AddTicks(9406), new DateTime(2024, 9, 26, 20, 58, 59, 334, DateTimeKind.Local).AddTicks(9355), 1 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 16,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Tempora id rerum. Ratione impedit et ut eius sit reiciendis et eos voluptatibus. Qui sit odit quo voluptas nihil quia eos aut.", new DateTime(2024, 9, 27, 20, 58, 59, 334, DateTimeKind.Local).AddTicks(9810), new DateTime(2024, 9, 26, 20, 58, 59, 334, DateTimeKind.Local).AddTicks(9807), 8 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 17,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Culpa dolore voluptatem voluptatem dolor minus dicta. Accusantium ducimus repellendus nostrum sint. Iure praesentium ea ea corrupti. Ut aut nostrum labore. Tempore totam et eum et in sequi ut qui. Tempore voluptatum quibusdam vel velit voluptas.", new DateTime(2024, 9, 27, 20, 58, 59, 337, DateTimeKind.Local).AddTicks(3443), new DateTime(2024, 9, 26, 20, 58, 59, 337, DateTimeKind.Local).AddTicks(3359), 4 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 18,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Sequi quod perspiciatis. Ea nulla occaecati quam officiis. Facilis mollitia modi atque rerum sequi non et. Aut repellendus assumenda eum. Adipisci aut officiis nostrum est. Dolores asperiores et vel voluptas minima vitae eligendi aspernatur vitae.", new DateTime(2024, 9, 27, 20, 58, 59, 337, DateTimeKind.Local).AddTicks(3908), new DateTime(2024, 9, 26, 20, 58, 59, 337, DateTimeKind.Local).AddTicks(3904), 1 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 19,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Itaque libero iste et atque ducimus sint esse et quisquam. Commodi blanditiis eius. Amet amet unde et voluptatibus nemo. Dolores enim aut aspernatur cumque quod sint odio ut reprehenderit.", new DateTime(2024, 9, 27, 20, 58, 59, 339, DateTimeKind.Local).AddTicks(6065), new DateTime(2024, 9, 26, 20, 58, 59, 339, DateTimeKind.Local).AddTicks(6016), 6 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 20,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Aspernatur hic quis vel quas autem doloribus eos quisquam minima. Occaecati et aut id ipsa et. Aliquam consequatur harum velit dignissimos cupiditate. Culpa fugiat labore sunt ducimus rerum. Totam aut iste debitis qui.", new DateTime(2024, 9, 27, 20, 58, 59, 339, DateTimeKind.Local).AddTicks(6473), new DateTime(2024, 9, 26, 20, 58, 59, 339, DateTimeKind.Local).AddTicks(6470), 4 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 21,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Rerum magnam qui quis ducimus non. Optio qui dicta iure quas. Doloribus qui at qui corporis et autem tempora excepturi minima. Voluptas doloribus in consequatur. Minus qui illo ut. Ipsam veritatis dolores fugiat nemo nesciunt.", new DateTime(2024, 9, 27, 20, 58, 59, 342, DateTimeKind.Local).AddTicks(3706), new DateTime(2024, 9, 26, 20, 58, 59, 342, DateTimeKind.Local).AddTicks(3647) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 22,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Nisi delectus beatae velit. Ipsa earum molestiae corrupti sint. Consequatur exercitationem et explicabo. Praesentium corrupti illum.", new DateTime(2024, 9, 27, 20, 58, 59, 342, DateTimeKind.Local).AddTicks(4057), new DateTime(2024, 9, 26, 20, 58, 59, 342, DateTimeKind.Local).AddTicks(4052), 1 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 23,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Dolorum quae excepturi id corrupti corrupti labore. Sed dolor aspernatur et voluptas quibusdam aliquam. Molestias debitis aut nam consequuntur nihil ex sunt non. Et fugiat consectetur quia est deserunt dignissimos.", new DateTime(2024, 9, 27, 20, 58, 59, 345, DateTimeKind.Local).AddTicks(3792), new DateTime(2024, 9, 26, 20, 58, 59, 345, DateTimeKind.Local).AddTicks(3739), 5 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 24,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Quos optio adipisci enim aut. Sed sed libero saepe voluptatem sunt quia. Commodi nisi laboriosam quasi nesciunt sequi mollitia libero.", new DateTime(2024, 9, 27, 20, 58, 59, 345, DateTimeKind.Local).AddTicks(4136), new DateTime(2024, 9, 26, 20, 58, 59, 345, DateTimeKind.Local).AddTicks(4132), 9 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 25,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Et est neque sunt natus. Dolorem non asperiores officiis temporibus iste. Cumque fugit id aliquid et quo nisi officia magni beatae. Vitae culpa iure ducimus cumque qui vero omnis accusantium. Accusantium et est magnam.", new DateTime(2024, 9, 27, 20, 58, 59, 350, DateTimeKind.Local).AddTicks(7981), new DateTime(2024, 9, 26, 20, 58, 59, 350, DateTimeKind.Local).AddTicks(7908), 8 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 26,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Ut eum voluptatem adipisci exercitationem qui reprehenderit quibusdam nesciunt eligendi. Quis quos rerum velit accusamus ducimus nam ut. Est adipisci id aut. A repellat omnis debitis repellendus dolores enim error.", new DateTime(2024, 9, 27, 20, 58, 59, 350, DateTimeKind.Local).AddTicks(8459), new DateTime(2024, 9, 26, 20, 58, 59, 350, DateTimeKind.Local).AddTicks(8455), 8 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 27,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Quia suscipit repellendus. Sed recusandae dolorem aliquam ipsa quis quisquam ea. Aliquid aperiam aliquam beatae cum sint unde adipisci ducimus. Iusto et delectus nihil sint et dolores consequatur.", new DateTime(2024, 9, 27, 20, 58, 59, 352, DateTimeKind.Local).AddTicks(9400), new DateTime(2024, 9, 26, 20, 58, 59, 352, DateTimeKind.Local).AddTicks(9357), 2 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 28,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Ab eveniet hic. Laudantium qui deserunt doloribus nemo qui. Voluptatem aut dicta sed. Dolor eos iusto sit fugit eum quos.", new DateTime(2024, 9, 27, 20, 58, 59, 352, DateTimeKind.Local).AddTicks(9732), new DateTime(2024, 9, 26, 20, 58, 59, 352, DateTimeKind.Local).AddTicks(9727), 6 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 29,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Neque enim molestiae laboriosam ut cum porro quis. Quam debitis quia ullam nulla. Ad dolores id dolor rerum.", new DateTime(2024, 9, 27, 20, 58, 59, 355, DateTimeKind.Local).AddTicks(3702), new DateTime(2024, 9, 26, 20, 58, 59, 355, DateTimeKind.Local).AddTicks(3648) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 30,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Omnis aperiam sint libero ducimus sapiente aperiam molestiae. Laborum eum illum at dolore. Natus amet quaerat maiores et voluptatum ut consequatur totam odit. Illum impedit id.", new DateTime(2024, 9, 27, 20, 58, 59, 355, DateTimeKind.Local).AddTicks(4091), new DateTime(2024, 9, 26, 20, 58, 59, 355, DateTimeKind.Local).AddTicks(4086), 7 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 31,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Sint excepturi cumque est. Dolores ipsam magnam fugit sint quae omnis. Quis qui repellat quia optio distinctio. Eligendi perferendis ipsum occaecati consequuntur ratione laudantium aliquid quis velit. Adipisci sit aut ad facilis laudantium veniam ut. Consequatur non aliquid voluptatum aut facilis tenetur.", new DateTime(2024, 9, 27, 20, 58, 59, 357, DateTimeKind.Local).AddTicks(5853), new DateTime(2024, 9, 26, 20, 58, 59, 357, DateTimeKind.Local).AddTicks(5805), 3 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 32,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Consectetur eos unde quo eos non vel sed consectetur. Quibusdam dolores et. Amet nostrum excepturi voluptatem officia doloremque nihil labore. Dicta sunt quo est vel. Qui ipsa illo. Autem eum vel quidem qui fugit eius.", new DateTime(2024, 9, 27, 20, 58, 59, 357, DateTimeKind.Local).AddTicks(6262), new DateTime(2024, 9, 26, 20, 58, 59, 357, DateTimeKind.Local).AddTicks(6258), 1 });

            migrationBuilder.UpdateData(
                table: "VisitProjects",
                keyColumn: "VisitProcessId",
                keyValue: 1,
                columns: new[] { "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { new DateTime(2024, 10, 25, 20, 58, 59, 292, DateTimeKind.Local).AddTicks(8266), new DateTime(2024, 9, 25, 20, 58, 59, 292, DateTimeKind.Local).AddTicks(8221) });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 1,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Bode - Cole", new DateTime(2024, 9, 4, 18, 26, 39, 927, DateTimeKind.Unspecified).AddTicks(4038), "yco4dr57v7", "0775198029", new DateTime(2024, 9, 4, 18, 26, 39, 927, DateTimeKind.Unspecified).AddTicks(4038), "Cecile Schroeder" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 2,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Nader Group", new DateTime(2024, 9, 14, 8, 33, 26, 940, DateTimeKind.Unspecified).AddTicks(5472), "js31golb59", "0250466952", new DateTime(2024, 9, 14, 8, 33, 26, 940, DateTimeKind.Unspecified).AddTicks(5472), "Conrad Quitzon" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 3,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Fahey, Becker and Kuphal", new DateTime(2024, 9, 18, 23, 4, 5, 621, DateTimeKind.Unspecified).AddTicks(732), "ccjcwmfnbl", "0261441998", false, new DateTime(2024, 9, 18, 23, 4, 5, 621, DateTimeKind.Unspecified).AddTicks(732), "Scot Murphy" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 4,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Hegmann LLC", new DateTime(2024, 9, 5, 12, 7, 7, 384, DateTimeKind.Unspecified).AddTicks(1445), "o9x8mi6rm4", "0811922387", true, new DateTime(2024, 9, 5, 12, 7, 7, 384, DateTimeKind.Unspecified).AddTicks(1445), "Adrianna Lynch" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 5,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Fritsch - Herman", new DateTime(2024, 9, 3, 11, 12, 54, 595, DateTimeKind.Unspecified).AddTicks(8462), 1, "qitvzzanlr", "0229102720", true, new DateTime(2024, 9, 3, 11, 12, 54, 595, DateTimeKind.Unspecified).AddTicks(8462), "Monroe Gerhold" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 6,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Gulgowski and Sons", new DateTime(2024, 9, 26, 3, 51, 18, 821, DateTimeKind.Unspecified).AddTicks(2133), 1, "c3ljskbmat", "0270110936", true, new DateTime(2024, 9, 26, 3, 51, 18, 821, DateTimeKind.Unspecified).AddTicks(2133), "Cortney Kirlin" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 7,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Greenfelder LLC", new DateTime(2024, 9, 4, 15, 3, 23, 431, DateTimeKind.Unspecified).AddTicks(8673), "cmofrzg03l", "0605586477", new DateTime(2024, 9, 4, 15, 3, 23, 431, DateTimeKind.Unspecified).AddTicks(8673), "Brando Schowalter" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 8,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Lehner Inc", new DateTime(2024, 9, 3, 10, 22, 27, 607, DateTimeKind.Unspecified).AddTicks(608), "p1ng83ju7l", "0149744522", true, new DateTime(2024, 9, 3, 10, 22, 27, 607, DateTimeKind.Unspecified).AddTicks(608), "Raul Smitham" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 9,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Wilkinson - Kuhn", new DateTime(2024, 9, 15, 22, 20, 57, 73, DateTimeKind.Unspecified).AddTicks(9054), 1, "4ch5aamz62", "0477154571", new DateTime(2024, 9, 15, 22, 20, 57, 73, DateTimeKind.Unspecified).AddTicks(9054), "Geoffrey Rosenbaum" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 10,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Leuschke LLC", new DateTime(2024, 9, 9, 9, 17, 32, 270, DateTimeKind.Unspecified).AddTicks(2841), 1, "x8x0tuj5ga", "0512907034", new DateTime(2024, 9, 9, 9, 17, 32, 270, DateTimeKind.Unspecified).AddTicks(2841), "Matilde Considine" });

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 1,
                column: "DateRegister",
                value: new DateTime(2024, 9, 24, 20, 58, 59, 291, DateTimeKind.Local).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 2,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 13, 58, 59, 295, DateTimeKind.Utc).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 3,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 13, 58, 59, 295, DateTimeKind.Utc).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 4,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 13, 58, 59, 295, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 5,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 13, 58, 59, 295, DateTimeKind.Utc).AddTicks(3776));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 6,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 13, 58, 59, 295, DateTimeKind.Utc).AddTicks(3785));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CredentialCardTypes",
                keyColumn: "CredentialCardTypeId",
                keyValue: 1,
                column: "CredentialCardTypeName",
                value: "Giấy phép lái xe");

            migrationBuilder.UpdateData(
                table: "CredentialCardTypes",
                keyColumn: "CredentialCardTypeId",
                keyValue: 2,
                column: "CredentialCardTypeName",
                value: "Giấy phép lái xe");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 4, new DateTime(2024, 9, 12, 10, 39, 18, 935, DateTimeKind.Utc).AddTicks(5116), "Phòng Kế toán", "Provident corporis ipsum ut rerum earum eveniet unde.", new DateTime(2024, 9, 12, 10, 39, 18, 935, DateTimeKind.Utc).AddTicks(5116) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 5, 19, 8, 54, 401, DateTimeKind.Utc).AddTicks(5868), "Phòng R&D", "Et ullam voluptatibus ut et veniam omnis.", new DateTime(2024, 9, 5, 19, 8, 54, 401, DateTimeKind.Utc).AddTicks(5868) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 21, 20, 46, 8, 825, DateTimeKind.Utc).AddTicks(9876), "Phòng Marketing", "Sunt voluptatem temporibus quidem vero voluptatem dolores odit.", new DateTime(2024, 9, 21, 20, 46, 8, 825, DateTimeKind.Utc).AddTicks(9876) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 9, 25, 23, 0, 16, 184, DateTimeKind.Utc).AddTicks(9151), "Phòng R&D", "Et sit ut veritatis quo molestiae occaecati sed incidunt.", new DateTime(2024, 9, 25, 23, 0, 16, 184, DateTimeKind.Utc).AddTicks(9151) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 4, new DateTime(2024, 9, 24, 3, 37, 9, 723, DateTimeKind.Utc).AddTicks(5429), "Phòng Kinh doanh", "Labore cumque quo dolore tenetur velit atque.", new DateTime(2024, 9, 24, 3, 37, 9, 723, DateTimeKind.Utc).AddTicks(5429) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 6,
                columns: new[] { "AcceptLevel", "CreateDate", "Description", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 26, 8, 25, 51, 490, DateTimeKind.Utc).AddTicks(261), "In corrupti accusantium ipsa in cumque.", new DateTime(2024, 9, 26, 8, 25, 51, 490, DateTimeKind.Utc).AddTicks(261) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 7,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2024, 9, 22, 9, 33, 6, 856, DateTimeKind.Utc).AddTicks(3259), "Phòng Hành chính", "Nulla dolores culpa velit laboriosam molestiae natus quas cupiditate.", new DateTime(2024, 9, 22, 9, 33, 6, 856, DateTimeKind.Utc).AddTicks(3259) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 8,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 9, 6, 28, 57, 94, DateTimeKind.Utc).AddTicks(1621), "Phòng Marketing", "Ad voluptas ea quos voluptas perferendis.", new DateTime(2024, 9, 9, 6, 28, 57, 94, DateTimeKind.Utc).AddTicks(1621) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 9,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2024, 9, 6, 8, 46, 44, 544, DateTimeKind.Utc).AddTicks(5399), "Phòng Nhân sự", "Dicta ex sed non deserunt et.", new DateTime(2024, 9, 6, 8, 46, 44, 544, DateTimeKind.Utc).AddTicks(5399) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 10,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 15, 18, 2, 25, 778, DateTimeKind.Utc).AddTicks(7334), "Phòng IT", "Et possimus dolore aut.", new DateTime(2024, 9, 15, 18, 2, 25, 778, DateTimeKind.Utc).AddTicks(7334) });

            migrationBuilder.UpdateData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: 1,
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 24, 10, 18, 21, 706, DateTimeKind.Utc).AddTicks(8093), "Refined Frozen Shoes", false });

            migrationBuilder.UpdateData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: 2,
                columns: new[] { "CreateTime", "ProcessName" },
                values: new object[] { new DateTime(2024, 9, 24, 10, 18, 21, 706, DateTimeKind.Utc).AddTicks(9657), "Generic Metal Shoes" });

            migrationBuilder.UpdateData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: 3,
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 24, 10, 18, 21, 706, DateTimeKind.Utc).AddTicks(9697), "Rustic Metal Pants", true });

            migrationBuilder.UpdateData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: 4,
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 24, 10, 18, 21, 706, DateTimeKind.Utc).AddTicks(9716), "Practical Metal Car", true });

            migrationBuilder.UpdateData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: 5,
                columns: new[] { "CreateTime", "ProcessName" },
                values: new object[] { new DateTime(2024, 9, 24, 10, 18, 21, 706, DateTimeKind.Utc).AddTicks(9734), "Handmade Granite Gloves" });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 1,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId", "QRCardTypeId" },
                values: new object[] { new Guid("d121bd3a-61d2-4b17-8768-0736f1320a09"), new DateTime(2024, 9, 26, 17, 18, 21, 758, DateTimeKind.Local).AddTicks(4518), new DateTime(2024, 10, 26, 17, 18, 21, 758, DateTimeKind.Local).AddTicks(4518), 1, 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 2,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("5ca35913-c384-4beb-9640-0ee291410326"), new DateTime(2024, 9, 26, 17, 18, 21, 758, DateTimeKind.Local).AddTicks(4806), new DateTime(2024, 10, 26, 17, 18, 21, 758, DateTimeKind.Local).AddTicks(4806) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 3,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardTypeId" },
                values: new object[] { new Guid("e71b0fde-687b-42ec-a5f8-d663f7d1f419"), new DateTime(2024, 9, 26, 17, 18, 21, 758, DateTimeKind.Local).AddTicks(4830), new DateTime(2024, 10, 26, 17, 18, 21, 758, DateTimeKind.Local).AddTicks(4830), 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 4,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId" },
                values: new object[] { new Guid("8b069652-4ba1-4f78-b8c6-61f6d5799dc3"), new DateTime(2024, 9, 26, 17, 18, 21, 758, DateTimeKind.Local).AddTicks(4846), new DateTime(2024, 10, 26, 17, 18, 21, 758, DateTimeKind.Local).AddTicks(4846), 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 5,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardTypeId" },
                values: new object[] { new Guid("e5d8b6e7-6b45-49ba-a74f-2da81e112e5c"), new DateTime(2024, 9, 26, 17, 18, 21, 758, DateTimeKind.Local).AddTicks(4859), new DateTime(2024, 10, 26, 17, 18, 21, 758, DateTimeKind.Local).AddTicks(4859), 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 6,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardTypeId" },
                values: new object[] { new Guid("dac12ce8-adaf-4b0b-84b1-c42353e080be"), new DateTime(2024, 9, 26, 17, 18, 21, 758, DateTimeKind.Local).AddTicks(4871), new DateTime(2024, 10, 26, 17, 18, 21, 758, DateTimeKind.Local).AddTicks(4871), 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 7,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardTypeId" },
                values: new object[] { new Guid("6c423121-1120-469b-ab03-b4fe5799d8dc"), new DateTime(2024, 9, 26, 17, 18, 21, 758, DateTimeKind.Local).AddTicks(4904), new DateTime(2024, 10, 26, 17, 18, 21, 758, DateTimeKind.Local).AddTicks(4904), 1 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 8,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId" },
                values: new object[] { new Guid("f44dfe96-44c8-4b8b-ba77-d5d084060a8d"), new DateTime(2024, 9, 26, 17, 18, 21, 758, DateTimeKind.Local).AddTicks(4916), new DateTime(2024, 10, 26, 17, 18, 21, 758, DateTimeKind.Local).AddTicks(4916), 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 9,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId", "QRCardTypeId" },
                values: new object[] { new Guid("d6c87007-0df4-4b9f-a2aa-e68a78501927"), new DateTime(2024, 9, 26, 17, 18, 21, 758, DateTimeKind.Local).AddTicks(4928), new DateTime(2024, 10, 26, 17, 18, 21, 758, DateTimeKind.Local).AddTicks(4928), 1, 1 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 10,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId" },
                values: new object[] { new Guid("3e6fb589-5785-40f1-806f-74f9e34a1295"), new DateTime(2024, 9, 26, 17, 18, 21, 758, DateTimeKind.Local).AddTicks(4939), new DateTime(2024, 10, 26, 17, 18, 21, 758, DateTimeKind.Local).AddTicks(4939), 1 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 4,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 2, 22 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 5,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 13 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 6,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 6, 9 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 7,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 2, 11 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 8,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 20 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 9,
                column: "UserId",
                value: 25);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 10,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 1, 18 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 11,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 19 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 12,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 1, 6 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 13,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 4, 24 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 14,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 5, 6 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 15,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 2, 18 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 16,
                column: "DepartmentId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 17,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 12 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 18,
                column: "UserId",
                value: 21);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 19,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 7 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 20,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 10, 17 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 21,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 19 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 22,
                column: "UserId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 23,
                column: "UserId",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 10, 18, 21, 697, DateTimeKind.Utc).AddTicks(4051), new DateTime(2024, 9, 26, 10, 18, 21, 697, DateTimeKind.Utc).AddTicks(4057) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 26, 10, 18, 21, 697, DateTimeKind.Utc).AddTicks(4060), new DateTime(2024, 9, 26, 10, 18, 21, 697, DateTimeKind.Utc).AddTicks(4061) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 26, 10, 18, 21, 697, DateTimeKind.Utc).AddTicks(4063), new DateTime(2024, 9, 26, 10, 18, 21, 697, DateTimeKind.Utc).AddTicks(4064) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 10, 18, 21, 697, DateTimeKind.Utc).AddTicks(4065), new DateTime(2024, 9, 26, 10, 18, 21, 697, DateTimeKind.Utc).AddTicks(4066) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 26, 10, 18, 21, 697, DateTimeKind.Utc).AddTicks(4067), new DateTime(2024, 9, 26, 10, 18, 21, 697, DateTimeKind.Utc).AddTicks(4068) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 21, 11, 8, 27, 65, DateTimeKind.Unspecified).AddTicks(3812), "gmail.com19@yahoo.com", "Nicola Schumm", "m28i1c", "0941386371", 4, new DateTime(2024, 9, 21, 11, 8, 27, 65, DateTimeKind.Unspecified).AddTicks(3812), "Juston.Luettgen15" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 17, 3, 32, 12, 127, DateTimeKind.Unspecified).AddTicks(2928), "gmail.com.Lakin62@yahoo.com", "Daryl Waters", "d3gsrl", "0672315306", 2, new DateTime(2024, 9, 17, 3, 32, 12, 127, DateTimeKind.Unspecified).AddTicks(2928), "Sonya_Koepp" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 7, 6, 25, 11, 310, DateTimeKind.Unspecified).AddTicks(4040), "gmail.com_Murazik@hotmail.com", "Emmitt Murphy", "2rtd22", "0177873338", 4, new DateTime(2024, 9, 7, 6, 25, 11, 310, DateTimeKind.Unspecified).AddTicks(4040), "Jamey.Price" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 14, 20, 30, 45, 95, DateTimeKind.Unspecified).AddTicks(7659), "gmail.com.Kuhic@gmail.com", "Kenyatta Marquardt", "mfay50", "0538167012", 4, new DateTime(2024, 9, 14, 20, 30, 45, 95, DateTimeKind.Unspecified).AddTicks(7659), "Valentina63" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 7, 1, 5, 38, 275, DateTimeKind.Unspecified).AddTicks(2120), "gmail.com_Nienow80@yahoo.com", "Fleta Kerluke", "uctitj", "0635456333", 2, new DateTime(2024, 9, 7, 1, 5, 38, 275, DateTimeKind.Unspecified).AddTicks(2120), "Rahul56" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 25, 1, 54, 4, 880, DateTimeKind.Unspecified).AddTicks(3555), "gmail.com_Marvin0@yahoo.com", "Julia Huel", "umekjm", "0577056792", 2, new DateTime(2024, 9, 25, 1, 54, 4, 880, DateTimeKind.Unspecified).AddTicks(3555), "Raven43" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 4, 21, 1, 1, 310, DateTimeKind.Unspecified).AddTicks(6639), "gmail.com.Schumm@gmail.com", "Jayden Schimmel", "ot7hr2", "0904967901", 4, new DateTime(2024, 9, 4, 21, 1, 1, 310, DateTimeKind.Unspecified).AddTicks(6639), "Lia_Ryan20" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 9, 10, 5, 11, 874, DateTimeKind.Unspecified).AddTicks(6237), "gmail.com_Barton40@yahoo.com", "Abbie Balistreri", "thja82", "0639628462", 1, new DateTime(2024, 9, 9, 10, 5, 11, 874, DateTimeKind.Unspecified).AddTicks(6237), "Angelita12" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 10, 13, 38, 50, 825, DateTimeKind.Unspecified).AddTicks(7385), "gmail.com19@hotmail.com", "Madisyn Jakubowski", "ph99l3", "0136237305", 3, new DateTime(2024, 9, 10, 13, 38, 50, 825, DateTimeKind.Unspecified).AddTicks(7385), "Danny79" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 22, 12, 59, 58, 315, DateTimeKind.Unspecified).AddTicks(9739), "gmail.com.Olson@gmail.com", "Curtis Aufderhar", "tssaaf", "0955816379", 1, new DateTime(2024, 9, 22, 12, 59, 58, 315, DateTimeKind.Unspecified).AddTicks(9739), "Lurline7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 1, 23, 12, 41, 853, DateTimeKind.Unspecified).AddTicks(9191), "gmail.com_Botsford68@yahoo.com", "Justyn Schmidt", "7d29e4", "0483274594", 3, new DateTime(2024, 9, 1, 23, 12, 41, 853, DateTimeKind.Unspecified).AddTicks(9191), "Jerry16" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 13, 7, 1, 21, 202, DateTimeKind.Unspecified).AddTicks(4719), "gmail.com.Kunze@hotmail.com", "Zander Dooley", "s2f3m2", "0102274509", 5, new DateTime(2024, 9, 13, 7, 1, 21, 202, DateTimeKind.Unspecified).AddTicks(4719), "Letitia84" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 22, 2, 16, 32, 897, DateTimeKind.Unspecified).AddTicks(5871), "gmail.com_Weissnat@yahoo.com", "Ewell Ondricka", "ifhy3t", "0356888970", 4, new DateTime(2024, 9, 22, 2, 16, 32, 897, DateTimeKind.Unspecified).AddTicks(5871), "Arely.Mayer83" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 1, 4, 26, 7, 573, DateTimeKind.Unspecified).AddTicks(2290), "gmail.com_Stokes@hotmail.com", "Torey Champlin", "9w25et", "0266539416", 2, new DateTime(2024, 9, 1, 4, 26, 7, 573, DateTimeKind.Unspecified).AddTicks(2290), "Merritt61" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 6, 6, 13, 24, 105, DateTimeKind.Unspecified).AddTicks(5298), "gmail.com.Haag23@yahoo.com", "Lee Stiedemann", "pale0s", "0317516408", 2, new DateTime(2024, 9, 6, 6, 13, 24, 105, DateTimeKind.Unspecified).AddTicks(5298), "Elisabeth.Trantow88" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 7, 11, 28, 14, 501, DateTimeKind.Unspecified).AddTicks(4269), "gmail.com.Dooley@gmail.com", "Zachery Romaguera", "051cws", "0668963461", new DateTime(2024, 9, 7, 11, 28, 14, 501, DateTimeKind.Unspecified).AddTicks(4269), "Glenna_Roberts" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 19, 8, 15, 31, 921, DateTimeKind.Unspecified).AddTicks(6655), "gmail.com.Bartoletti30@gmail.com", "Elisha Lowe", "idn1ua", "0800530207", 5, new DateTime(2024, 9, 19, 8, 15, 31, 921, DateTimeKind.Unspecified).AddTicks(6655), "Mertie.Schmitt4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 20, 15, 20, 17, 857, DateTimeKind.Unspecified).AddTicks(2920), "gmail.com3@yahoo.com", "Tod Rohan", "zk0ia4", "0112015621", 1, new DateTime(2024, 9, 20, 15, 20, 17, 857, DateTimeKind.Unspecified).AddTicks(2920), "Cecilia94" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 15, 18, 59, 57, 952, DateTimeKind.Unspecified).AddTicks(5910), "gmail.com_Johnston9@yahoo.com", "Velda Murazik", "y9n7w7", "0855406429", new DateTime(2024, 9, 15, 18, 59, 57, 952, DateTimeKind.Unspecified).AddTicks(5910), "Savion.Paucek28" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 15, 5, 1, 54, 248, DateTimeKind.Unspecified).AddTicks(1170), "gmail.com.Predovic@gmail.com", "Drake Greenfelder", "3kgfgo", "0228389435", 3, new DateTime(2024, 9, 15, 5, 1, 54, 248, DateTimeKind.Unspecified).AddTicks(1170), "Vernie79" });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 1,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Facilis voluptas iure ut dolorum similique eum porro ipsum necessitatibus. Nulla eos consequatur fugit autem voluptas consequatur. Occaecati veritatis magni quas iusto. Quis nobis officia aut et aut ea. Eligendi alias recusandae optio sed magnam pariatur at qui eveniet.", new DateTime(2024, 10, 25, 17, 18, 21, 720, DateTimeKind.Local).AddTicks(1551), new DateTime(2024, 9, 25, 17, 18, 21, 720, DateTimeKind.Local).AddTicks(1496), 2 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 2,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Explicabo quibusdam expedita ut earum exercitationem optio earum reiciendis. Quaerat et laboriosam. Ipsa aut quisquam qui. Eos labore quos omnis veniam fugit qui autem aut facilis.", new DateTime(2024, 10, 25, 17, 18, 21, 720, DateTimeKind.Local).AddTicks(2055), new DateTime(2024, 9, 25, 17, 18, 21, 720, DateTimeKind.Local).AddTicks(2051) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 3,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Perspiciatis sunt et exercitationem. Iusto et ad quam cum expedita ullam qui eveniet recusandae. Aut quia corporis sint et placeat officia voluptatibus.", new DateTime(2024, 9, 27, 17, 18, 21, 733, DateTimeKind.Local).AddTicks(8895), new DateTime(2024, 9, 26, 17, 18, 21, 733, DateTimeKind.Local).AddTicks(8854), 6 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 4,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Sed dignissimos enim non. Qui fuga velit. Voluptas dolor ab sint nemo ipsa et autem. Est fuga tenetur. Ab enim expedita modi. Sunt fugit dolores nihil quia amet sit aperiam fugiat.", new DateTime(2024, 9, 27, 17, 18, 21, 733, DateTimeKind.Local).AddTicks(9177), new DateTime(2024, 9, 26, 17, 18, 21, 733, DateTimeKind.Local).AddTicks(9175) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 5,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Voluptates qui qui inventore non quam. Magnam aliquid sunt. Rerum explicabo eum consequatur dicta deserunt reprehenderit eum molestias pariatur. Eius ut deleniti et corrupti laboriosam id sint.", new DateTime(2024, 9, 27, 17, 18, 21, 735, DateTimeKind.Local).AddTicks(530), new DateTime(2024, 9, 26, 17, 18, 21, 735, DateTimeKind.Local).AddTicks(502), 7 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 6,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Autem illo et. Eveniet consequuntur numquam quam nam mollitia. Sit adipisci ratione voluptatem vero rem est nisi laudantium.", new DateTime(2024, 9, 27, 17, 18, 21, 735, DateTimeKind.Local).AddTicks(836), new DateTime(2024, 9, 26, 17, 18, 21, 735, DateTimeKind.Local).AddTicks(834), 8 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 7,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Et labore exercitationem consequuntur id quo placeat maiores. Sint voluptatem minus. Sunt possimus qui pariatur dolor enim necessitatibus quibusdam et rerum. Quam sequi libero ea.", new DateTime(2024, 9, 27, 17, 18, 21, 736, DateTimeKind.Local).AddTicks(2372), new DateTime(2024, 9, 26, 17, 18, 21, 736, DateTimeKind.Local).AddTicks(2345) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 8,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Nostrum eveniet est adipisci laboriosam. Incidunt consequatur id autem et. Ut porro nihil aut magni a. Quisquam dolores aut sint ea doloremque facere. Magni consequatur sed. Deserunt vero vero et laborum quae iure voluptatem explicabo voluptas.", new DateTime(2024, 9, 27, 17, 18, 21, 736, DateTimeKind.Local).AddTicks(2618), new DateTime(2024, 9, 26, 17, 18, 21, 736, DateTimeKind.Local).AddTicks(2617), 1 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 9,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Natus qui a et aliquid autem voluptas nihil quam. Enim maiores qui accusamus laboriosam quidem. Dolorem quam nulla repellendus quas nihil. Voluptates eaque quam ullam cum. Voluptatem sit temporibus et totam dolores earum ipsam. Aut corporis nostrum harum totam inventore ipsam ratione cum.", new DateTime(2024, 9, 27, 17, 18, 21, 737, DateTimeKind.Local).AddTicks(3652), new DateTime(2024, 9, 26, 17, 18, 21, 737, DateTimeKind.Local).AddTicks(3620), 3 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 10,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Libero facere dolorum nisi aut quo dicta corrupti in possimus. Est quaerat rerum et alias voluptatem a quis soluta. Accusamus unde tenetur quae autem et odit dicta quaerat. Recusandae facilis eaque ut voluptatem dicta dolorem. Libero doloremque sed omnis nostrum.", new DateTime(2024, 9, 27, 17, 18, 21, 737, DateTimeKind.Local).AddTicks(3912), new DateTime(2024, 9, 26, 17, 18, 21, 737, DateTimeKind.Local).AddTicks(3910) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 11,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Perspiciatis incidunt neque vel et nam iure alias doloribus. Amet aut sed exercitationem inventore. Eveniet amet ipsum ab a est et et et dolores. Asperiores sed aut similique sapiente voluptatum ipsum dolorem animi. Quia rerum in omnis sit libero fugit dolor magnam. Ipsa id consectetur repellendus.", new DateTime(2024, 9, 27, 17, 18, 21, 738, DateTimeKind.Local).AddTicks(4468), new DateTime(2024, 9, 26, 17, 18, 21, 738, DateTimeKind.Local).AddTicks(4442), 10 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 12,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Necessitatibus esse unde non. Consequuntur voluptatum unde. Magni et tempore nemo. Animi eos et inventore alias ut aut consequuntur dolorem alias. Quidem saepe quia repellendus et vero iusto soluta voluptatem. Non officiis beatae exercitationem dolores vel.", new DateTime(2024, 9, 27, 17, 18, 21, 738, DateTimeKind.Local).AddTicks(4713), new DateTime(2024, 9, 26, 17, 18, 21, 738, DateTimeKind.Local).AddTicks(4711), 8 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 13,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Non odit eos provident rerum. Laudantium in corporis. Vero repellendus nam facilis perferendis deleniti doloribus est ipsam sed. Dolor aspernatur repellat numquam cumque sed voluptatem et.", new DateTime(2024, 9, 27, 17, 18, 21, 741, DateTimeKind.Local).AddTicks(2149), new DateTime(2024, 9, 26, 17, 18, 21, 741, DateTimeKind.Local).AddTicks(2109), 1 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 14,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Error id voluptas aliquam. Dicta officiis dolores suscipit aut. Natus voluptatem provident nemo consectetur molestiae. Quaerat molestias molestiae placeat unde maxime omnis ut illum consequatur. Non fugit veniam minus enim modi sed consequatur totam possimus. Accusamus animi tempore deleniti nihil aut aut.", new DateTime(2024, 9, 27, 17, 18, 21, 741, DateTimeKind.Local).AddTicks(2454), new DateTime(2024, 9, 26, 17, 18, 21, 741, DateTimeKind.Local).AddTicks(2451), 10 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 15,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Facilis vero aliquam rerum ratione neque. Voluptatem pariatur hic quae asperiores. Nulla qui consequuntur est non.", new DateTime(2024, 9, 27, 17, 18, 21, 742, DateTimeKind.Local).AddTicks(4694), new DateTime(2024, 9, 26, 17, 18, 21, 742, DateTimeKind.Local).AddTicks(4658), 9 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 16,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Quisquam aliquam alias voluptatem tenetur saepe dolor ullam. Aut recusandae culpa magnam nisi. Quae vero id et dolorem doloribus qui voluptatem illum. Quos illum quo iure in quod earum. Quasi nesciunt quos in voluptate necessitatibus qui ut amet.", new DateTime(2024, 9, 27, 17, 18, 21, 742, DateTimeKind.Local).AddTicks(4957), new DateTime(2024, 9, 26, 17, 18, 21, 742, DateTimeKind.Local).AddTicks(4954), 6 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 17,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Quia ullam minima et ab aut aut vel. Autem quia harum alias iusto dolores. Dolorem voluptatem minima quo nesciunt nobis. A a eligendi velit quae quisquam quod. Harum architecto dolore id est vero.", new DateTime(2024, 9, 27, 17, 18, 21, 743, DateTimeKind.Local).AddTicks(5724), new DateTime(2024, 9, 26, 17, 18, 21, 743, DateTimeKind.Local).AddTicks(5694), 10 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 18,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Reprehenderit adipisci aperiam velit. Reprehenderit repellat suscipit quis est sequi hic. Ducimus et aliquam in in neque. Tenetur corporis labore sunt voluptatem eos. Et numquam et eum.", new DateTime(2024, 9, 27, 17, 18, 21, 743, DateTimeKind.Local).AddTicks(6099), new DateTime(2024, 9, 26, 17, 18, 21, 743, DateTimeKind.Local).AddTicks(6097), 5 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 19,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Praesentium iusto rem. Sit quaerat assumenda illo tempora et et dolores consequatur. Eveniet minus amet placeat consectetur voluptatem possimus nobis. Accusamus sed officia nam.", new DateTime(2024, 9, 27, 17, 18, 21, 744, DateTimeKind.Local).AddTicks(6924), new DateTime(2024, 9, 26, 17, 18, 21, 744, DateTimeKind.Local).AddTicks(6896), 2 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 20,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Suscipit minima dolor. Dolor deserunt a officiis. Rerum perspiciatis magnam. Cupiditate enim sapiente voluptatem. Id asperiores voluptatem non sit eius cum quam fuga.", new DateTime(2024, 9, 27, 17, 18, 21, 744, DateTimeKind.Local).AddTicks(7140), new DateTime(2024, 9, 26, 17, 18, 21, 744, DateTimeKind.Local).AddTicks(7137), 3 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 21,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Aut quisquam aliquid est esse at. Voluptatem voluptas quod qui soluta occaecati. Non vitae architecto numquam harum non.", new DateTime(2024, 9, 27, 17, 18, 21, 745, DateTimeKind.Local).AddTicks(8745), new DateTime(2024, 9, 26, 17, 18, 21, 745, DateTimeKind.Local).AddTicks(8717) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 22,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Et excepturi nemo sequi. Velit saepe dicta ut mollitia non incidunt. Sed voluptas neque natus laboriosam nostrum deleniti neque. Veritatis excepturi facere atque. Qui facilis itaque voluptatum.", new DateTime(2024, 9, 27, 17, 18, 21, 745, DateTimeKind.Local).AddTicks(8989), new DateTime(2024, 9, 26, 17, 18, 21, 745, DateTimeKind.Local).AddTicks(8987), 7 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 23,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Labore ut reiciendis ut tenetur sapiente libero consequatur. Possimus repellendus doloribus ullam ipsum vel. Consequuntur cumque dolorum est provident odio et maxime earum.", new DateTime(2024, 9, 27, 17, 18, 21, 747, DateTimeKind.Local).AddTicks(624), new DateTime(2024, 9, 26, 17, 18, 21, 747, DateTimeKind.Local).AddTicks(590), 3 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 24,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Delectus dolorem maxime aspernatur dolor necessitatibus voluptatem aspernatur atque et. Modi sint vero debitis. Aspernatur eos nulla fugiat ad. Earum enim id ut eum dolor.", new DateTime(2024, 9, 27, 17, 18, 21, 747, DateTimeKind.Local).AddTicks(862), new DateTime(2024, 9, 26, 17, 18, 21, 747, DateTimeKind.Local).AddTicks(860), 7 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 25,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Suscipit vel sunt sunt eaque eos velit quam commodi. Consequuntur quae numquam et officia inventore voluptas odit. Ab repellendus aspernatur perspiciatis quas atque repudiandae aut. Quis voluptate numquam quis corporis dolores molestiae suscipit. Sunt nam debitis consequuntur voluptates sit. Doloremque qui doloremque vitae veritatis et numquam.", new DateTime(2024, 9, 27, 17, 18, 21, 748, DateTimeKind.Local).AddTicks(4551), new DateTime(2024, 9, 26, 17, 18, 21, 748, DateTimeKind.Local).AddTicks(4496), 5 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 26,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Quod inventore praesentium omnis earum soluta molestiae magnam iusto magni. Voluptatum minus quia rerum recusandae qui eos. Illo consequuntur nihil. Pariatur dignissimos praesentium aperiam omnis qui nostrum. Porro sunt quia. Dignissimos corporis numquam fuga sit.", new DateTime(2024, 9, 27, 17, 18, 21, 748, DateTimeKind.Local).AddTicks(5025), new DateTime(2024, 9, 26, 17, 18, 21, 748, DateTimeKind.Local).AddTicks(5021), 9 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 27,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Qui iusto est totam repellat. Facilis velit consequuntur cumque eligendi quidem. Nostrum animi voluptatem cupiditate libero rerum. Sit quis voluptas est occaecati est. A minus sequi ratione qui consectetur sequi corrupti laudantium consequuntur.", new DateTime(2024, 9, 27, 17, 18, 21, 750, DateTimeKind.Local).AddTicks(6177), new DateTime(2024, 9, 26, 17, 18, 21, 750, DateTimeKind.Local).AddTicks(6126), 8 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 28,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Fuga et officia et quibusdam sit aut quibusdam. Et qui tempore. In illo ad et expedita delectus vel et dolore et. Dolor quasi laudantium commodi quia. Ea eius impedit consequatur et repudiandae dolorem nulla maiores.", new DateTime(2024, 9, 27, 17, 18, 21, 750, DateTimeKind.Local).AddTicks(6613), new DateTime(2024, 9, 26, 17, 18, 21, 750, DateTimeKind.Local).AddTicks(6609), 3 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 29,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Doloremque doloremque voluptas eius fuga rerum maiores fuga. Non eum dolor praesentium nisi et adipisci. Ducimus quis inventore molestiae. Aliquid ad eum aut nam aut vel ut. Aperiam ab eum et velit.", new DateTime(2024, 9, 27, 17, 18, 21, 753, DateTimeKind.Local).AddTicks(9608), new DateTime(2024, 9, 26, 17, 18, 21, 753, DateTimeKind.Local).AddTicks(9549) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 30,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Similique ad sint cum corrupti laudantium. Quis quam nihil corporis. Aut dolor aspernatur fugit unde eum dignissimos vel.", new DateTime(2024, 9, 27, 17, 18, 21, 753, DateTimeKind.Local).AddTicks(9993), new DateTime(2024, 9, 26, 17, 18, 21, 753, DateTimeKind.Local).AddTicks(9989), 4 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 31,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Nisi quia sed. Dolores deleniti animi quas et libero culpa ratione aut recusandae. Sed quis veritatis laborum voluptates eligendi quod.", new DateTime(2024, 9, 27, 17, 18, 21, 756, DateTimeKind.Local).AddTicks(1532), new DateTime(2024, 9, 26, 17, 18, 21, 756, DateTimeKind.Local).AddTicks(1476), 1 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 32,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Minus asperiores ut debitis. Esse aspernatur exercitationem fuga dolores et amet. Sed deleniti in ex voluptas enim consectetur et. Beatae qui dolorum ipsa expedita suscipit.", new DateTime(2024, 9, 27, 17, 18, 21, 756, DateTimeKind.Local).AddTicks(1948), new DateTime(2024, 9, 26, 17, 18, 21, 756, DateTimeKind.Local).AddTicks(1944), 9 });

            migrationBuilder.UpdateData(
                table: "VisitProjects",
                keyColumn: "VisitProcessId",
                keyValue: 1,
                columns: new[] { "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { new DateTime(2024, 10, 25, 17, 18, 21, 709, DateTimeKind.Local).AddTicks(2084), new DateTime(2024, 9, 25, 17, 18, 21, 709, DateTimeKind.Local).AddTicks(2046) });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 1,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Cummerata Inc", new DateTime(2024, 9, 14, 18, 29, 7, 367, DateTimeKind.Unspecified).AddTicks(7069), "sixdew9akn", "0484931191", new DateTime(2024, 9, 14, 18, 29, 7, 367, DateTimeKind.Unspecified).AddTicks(7069), "Ethelyn Collier" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 2,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Christiansen LLC", new DateTime(2024, 9, 17, 2, 13, 27, 487, DateTimeKind.Unspecified).AddTicks(6013), "sjfy1246ba", "0400459689", new DateTime(2024, 9, 17, 2, 13, 27, 487, DateTimeKind.Unspecified).AddTicks(6013), "Alberto Harvey" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 3,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Kris Inc", new DateTime(2024, 9, 6, 22, 45, 15, 323, DateTimeKind.Unspecified).AddTicks(8296), "l4n0s1cfcu", "0738543481", true, new DateTime(2024, 9, 6, 22, 45, 15, 323, DateTimeKind.Unspecified).AddTicks(8296), "Samanta Schneider" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 4,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Cummings, Beier and Spinka", new DateTime(2024, 9, 1, 3, 48, 10, 393, DateTimeKind.Unspecified).AddTicks(7065), "e347nmhru6", "0236574185", false, new DateTime(2024, 9, 1, 3, 48, 10, 393, DateTimeKind.Unspecified).AddTicks(7065), "Adrianna Bruen" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 5,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Bins LLC", new DateTime(2024, 9, 3, 21, 27, 12, 207, DateTimeKind.Unspecified).AddTicks(5517), 2, "ph2qmc895u", "0622483669", false, new DateTime(2024, 9, 3, 21, 27, 12, 207, DateTimeKind.Unspecified).AddTicks(5517), "Maxine Gutkowski" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 6,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Tremblay, Boyle and Blanda", new DateTime(2024, 9, 18, 15, 59, 45, 504, DateTimeKind.Unspecified).AddTicks(3243), 2, "vfz9udp928", "0204637495", false, new DateTime(2024, 9, 18, 15, 59, 45, 504, DateTimeKind.Unspecified).AddTicks(3243), "Nadia Zboncak" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 7,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Veum - Johnston", new DateTime(2024, 9, 10, 1, 44, 0, 465, DateTimeKind.Unspecified).AddTicks(3877), "9gpva451nn", "0436330726", new DateTime(2024, 9, 10, 1, 44, 0, 465, DateTimeKind.Unspecified).AddTicks(3877), "Blaise Bartoletti" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 8,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Monahan - Crist", new DateTime(2024, 9, 2, 10, 29, 12, 787, DateTimeKind.Unspecified).AddTicks(1469), "8h1js8kbty", "0498457297", false, new DateTime(2024, 9, 2, 10, 29, 12, 787, DateTimeKind.Unspecified).AddTicks(1469), "Ardith Bins" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 9,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Schiller - Hessel", new DateTime(2024, 9, 24, 5, 44, 45, 57, DateTimeKind.Unspecified).AddTicks(5307), 2, "n7nyitw5n7", "0123580206", new DateTime(2024, 9, 24, 5, 44, 45, 57, DateTimeKind.Unspecified).AddTicks(5307), "Timothy Wunsch" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 10,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Jerde - Koelpin", new DateTime(2024, 9, 18, 2, 11, 42, 994, DateTimeKind.Unspecified).AddTicks(2826), 2, "ggsr7fv7tm", "0442672208", new DateTime(2024, 9, 18, 2, 11, 42, 994, DateTimeKind.Unspecified).AddTicks(2826), "Rosie Bailey" });

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 1,
                column: "DateRegister",
                value: new DateTime(2024, 9, 24, 17, 18, 21, 708, DateTimeKind.Local).AddTicks(1045));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 2,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 10, 18, 21, 732, DateTimeKind.Utc).AddTicks(6354));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 3,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 10, 18, 21, 732, DateTimeKind.Utc).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 4,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 10, 18, 21, 732, DateTimeKind.Utc).AddTicks(6543));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 5,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 10, 18, 21, 732, DateTimeKind.Utc).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 6,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 10, 18, 21, 732, DateTimeKind.Utc).AddTicks(6561));
        }
    }
}
