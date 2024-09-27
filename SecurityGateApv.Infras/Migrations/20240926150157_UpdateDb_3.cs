using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecurityGateApv.Infras.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDb_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { 2, new DateTime(2024, 9, 12, 13, 59, 47, 356, DateTimeKind.Utc).AddTicks(3102), "Phòng Pháp chế", "Quia commodi neque nam illo in dolor aut distinctio omnis.", new DateTime(2024, 9, 12, 13, 59, 47, 356, DateTimeKind.Utc).AddTicks(3102) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 20, 4, 56, 57, 986, DateTimeKind.Utc).AddTicks(5568), "Phòng R&D", "Qui odio doloremque maxime.", new DateTime(2024, 9, 20, 4, 56, 57, 986, DateTimeKind.Utc).AddTicks(5568) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 14, 5, 7, 18, 853, DateTimeKind.Utc).AddTicks(1804), "Phòng Kế toán", "Velit velit voluptas et expedita officia.", new DateTime(2024, 9, 14, 5, 7, 18, 853, DateTimeKind.Utc).AddTicks(1804) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2024, 9, 24, 22, 7, 54, 310, DateTimeKind.Utc).AddTicks(1282), "Phòng Hành chính", "Culpa quae molestiae.", new DateTime(2024, 9, 24, 22, 7, 54, 310, DateTimeKind.Utc).AddTicks(1282) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 13, 11, 59, 47, 45, DateTimeKind.Utc).AddTicks(5481), "Phòng Hành chính", "Explicabo esse aut et magnam.", new DateTime(2024, 9, 13, 11, 59, 47, 45, DateTimeKind.Utc).AddTicks(5481) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 6,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 11, 7, 2, 9, 604, DateTimeKind.Utc).AddTicks(4683), "Phòng Pháp chế", "Quibusdam veniam repellat et dignissimos.", new DateTime(2024, 9, 11, 7, 2, 9, 604, DateTimeKind.Utc).AddTicks(4683) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 7,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 19, 12, 29, 52, 866, DateTimeKind.Utc).AddTicks(2538), "Phòng Kinh doanh", "Facilis sint earum accusantium consectetur id placeat.", new DateTime(2024, 9, 19, 12, 29, 52, 866, DateTimeKind.Utc).AddTicks(2538) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 8,
                columns: new[] { "CreateDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 4, 58, 6, 993, DateTimeKind.Utc).AddTicks(2195), "Atque eius laboriosam dicta velit velit maiores impedit adipisci.", new DateTime(2024, 9, 5, 4, 58, 6, 993, DateTimeKind.Utc).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 9,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 15, 21, 14, 35, 164, DateTimeKind.Utc).AddTicks(9232), "Phòng Pháp chế", "Unde quae dignissimos ducimus sequi.", new DateTime(2024, 9, 15, 21, 14, 35, 164, DateTimeKind.Utc).AddTicks(9232) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 10,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 19, 7, 49, 3, 988, DateTimeKind.Utc).AddTicks(9141), "Phòng R&D", "Quia excepturi itaque reprehenderit est.", new DateTime(2024, 9, 19, 7, 49, 3, 988, DateTimeKind.Utc).AddTicks(9141) });

            migrationBuilder.UpdateData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: 1,
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 24, 15, 1, 56, 562, DateTimeKind.Utc).AddTicks(4189), "Handmade Granite Pants", true });

            migrationBuilder.UpdateData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: 2,
                columns: new[] { "CreateTime", "ProcessName" },
                values: new object[] { new DateTime(2024, 9, 24, 15, 1, 56, 562, DateTimeKind.Utc).AddTicks(5948), "Practical Steel Salad" });

            migrationBuilder.UpdateData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: 3,
                columns: new[] { "CreateTime", "ProcessName" },
                values: new object[] { new DateTime(2024, 9, 24, 15, 1, 56, 562, DateTimeKind.Utc).AddTicks(5980), "Intelligent Metal Tuna" });

            migrationBuilder.UpdateData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: 4,
                columns: new[] { "CreateTime", "ProcessName" },
                values: new object[] { new DateTime(2024, 9, 24, 15, 1, 56, 562, DateTimeKind.Utc).AddTicks(6000), "Practical Wooden Hat" });

            migrationBuilder.UpdateData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: 5,
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 24, 15, 1, 56, 562, DateTimeKind.Utc).AddTicks(6018), "Intelligent Fresh Chips", true });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 1,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardTypeId" },
                values: new object[] { new Guid("f97fb998-cac6-4f1d-8c30-df91aa3c4c8f"), new DateTime(2024, 9, 26, 22, 1, 56, 618, DateTimeKind.Local).AddTicks(8355), new DateTime(2024, 10, 26, 22, 1, 56, 618, DateTimeKind.Local).AddTicks(8355), 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 2,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId" },
                values: new object[] { new Guid("dc7ecff1-6371-4e59-9af2-11f0c76ae65d"), new DateTime(2024, 9, 26, 22, 1, 56, 618, DateTimeKind.Local).AddTicks(8665), new DateTime(2024, 10, 26, 22, 1, 56, 618, DateTimeKind.Local).AddTicks(8665), 1 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 3,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId" },
                values: new object[] { new Guid("aef735dd-844a-4c1a-99d4-d3301f47b4c3"), new DateTime(2024, 9, 26, 22, 1, 56, 618, DateTimeKind.Local).AddTicks(8680), new DateTime(2024, 10, 26, 22, 1, 56, 618, DateTimeKind.Local).AddTicks(8680), 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 4,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("8f6e262b-3690-4954-878b-b36fad669d03"), new DateTime(2024, 9, 26, 22, 1, 56, 618, DateTimeKind.Local).AddTicks(8688), new DateTime(2024, 10, 26, 22, 1, 56, 618, DateTimeKind.Local).AddTicks(8688) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 5,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId", "QRCardTypeId" },
                values: new object[] { new Guid("74e7aff9-10b8-437d-926e-e37dc1fb192a"), new DateTime(2024, 9, 26, 22, 1, 56, 618, DateTimeKind.Local).AddTicks(8707), new DateTime(2024, 10, 26, 22, 1, 56, 618, DateTimeKind.Local).AddTicks(8707), 2, 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 6,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("d3d47821-a881-4653-8dd1-4aa7454e5619"), new DateTime(2024, 9, 26, 22, 1, 56, 618, DateTimeKind.Local).AddTicks(8726), new DateTime(2024, 10, 26, 22, 1, 56, 618, DateTimeKind.Local).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 7,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("ae1369d3-ec84-497c-a774-381f4a1739b0"), new DateTime(2024, 9, 26, 22, 1, 56, 618, DateTimeKind.Local).AddTicks(8734), new DateTime(2024, 10, 26, 22, 1, 56, 618, DateTimeKind.Local).AddTicks(8734) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 8,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardTypeId" },
                values: new object[] { new Guid("3b9c3005-ef82-4cb2-a2fa-2d5b23876371"), new DateTime(2024, 9, 26, 22, 1, 56, 618, DateTimeKind.Local).AddTicks(8740), new DateTime(2024, 10, 26, 22, 1, 56, 618, DateTimeKind.Local).AddTicks(8740), 1 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 9,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardTypeId" },
                values: new object[] { new Guid("666f60d5-4954-49f8-874b-53008418be01"), new DateTime(2024, 9, 26, 22, 1, 56, 618, DateTimeKind.Local).AddTicks(8747), new DateTime(2024, 10, 26, 22, 1, 56, 618, DateTimeKind.Local).AddTicks(8747), 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 10,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId" },
                values: new object[] { new Guid("41947d75-7cb2-47af-a82d-f30c1b849649"), new DateTime(2024, 9, 26, 22, 1, 56, 618, DateTimeKind.Local).AddTicks(8753), new DateTime(2024, 10, 26, 22, 1, 56, 618, DateTimeKind.Local).AddTicks(8753), 1 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 4,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 4, 6 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 5,
                column: "UserId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 6,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 5, 22 });

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
                values: new object[] { 10, 25 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 9,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 2, 23 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 10,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 5, 20 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 11,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 10, 21 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 12,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 10, 21 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 13,
                column: "DepartmentId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 14,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 9 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 15,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 3, 16 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 16,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 2, 20 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 17,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 3, 15 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 18,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 13 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 19,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 18 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 20,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 24 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 21,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 6, 11 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 22,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 5, 10 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 23,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 10, 24 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 15, 1, 56, 540, DateTimeKind.Utc).AddTicks(4422), new DateTime(2024, 9, 26, 15, 1, 56, 540, DateTimeKind.Utc).AddTicks(4434) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 26, 15, 1, 56, 540, DateTimeKind.Utc).AddTicks(4440), new DateTime(2024, 9, 26, 15, 1, 56, 540, DateTimeKind.Utc).AddTicks(4441) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 26, 15, 1, 56, 540, DateTimeKind.Utc).AddTicks(4443), new DateTime(2024, 9, 26, 15, 1, 56, 540, DateTimeKind.Utc).AddTicks(4443) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 15, 1, 56, 540, DateTimeKind.Utc).AddTicks(4445), new DateTime(2024, 9, 26, 15, 1, 56, 540, DateTimeKind.Utc).AddTicks(4446) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 26, 15, 1, 56, 540, DateTimeKind.Utc).AddTicks(4448), new DateTime(2024, 9, 26, 15, 1, 56, 540, DateTimeKind.Utc).AddTicks(4449) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 24, 20, 55, 10, 697, DateTimeKind.Unspecified).AddTicks(6479), "gmail.com_West7@yahoo.com", "Sidney Wisozk", "leh5mo", "0484157380", 2, new DateTime(2024, 9, 24, 20, 55, 10, 697, DateTimeKind.Unspecified).AddTicks(6479), "Shania85" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 4, 16, 27, 44, 48, DateTimeKind.Unspecified).AddTicks(5029), "gmail.com78@yahoo.com", "Effie Gibson", "eoyk0s", "0619697971", 4, new DateTime(2024, 9, 4, 16, 27, 44, 48, DateTimeKind.Unspecified).AddTicks(5029), "Annette_Hand74" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 14, 16, 9, 1, 533, DateTimeKind.Unspecified).AddTicks(2723), "gmail.com_Ritchie9@yahoo.com", "Fannie Jacobi", "id5802", "0130441622", 3, new DateTime(2024, 9, 14, 16, 9, 1, 533, DateTimeKind.Unspecified).AddTicks(2723), "Camron88" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 16, 6, 37, 7, 901, DateTimeKind.Unspecified).AddTicks(8514), "gmail.com_Schamberger@gmail.com", "Vivian Dickens", "x6rg10", "0908472880", 3, new DateTime(2024, 9, 16, 6, 37, 7, 901, DateTimeKind.Unspecified).AddTicks(8514), "Alia70" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 4, 29, 168, DateTimeKind.Unspecified).AddTicks(3459), "gmail.com77@gmail.com", "Raoul Fritsch", "bs14fe", "0486777244", 5, new DateTime(2024, 9, 22, 22, 4, 29, 168, DateTimeKind.Unspecified).AddTicks(3459), "Micaela33" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 21, 19, 3, 32, 971, DateTimeKind.Unspecified).AddTicks(7250), "gmail.com.Lockman70@yahoo.com", "Jovany Reilly", "5bq0lj", "0514227000", new DateTime(2024, 9, 21, 19, 3, 32, 971, DateTimeKind.Unspecified).AddTicks(7250), "Kendra_Breitenberg72" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 22, 3, 2, 56, 754, DateTimeKind.Unspecified).AddTicks(5466), "gmail.com.Langosh67@gmail.com", "Johnnie O'Reilly", "mzxxkw", "0372425936", 1, new DateTime(2024, 9, 22, 3, 2, 56, 754, DateTimeKind.Unspecified).AddTicks(5466), "Mavis_Block" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 21, 22, 29, 3, 509, DateTimeKind.Unspecified).AddTicks(8194), "gmail.com36@hotmail.com", "Virginie Wuckert", "wiqrb0", "0870583135", new DateTime(2024, 9, 21, 22, 29, 3, 509, DateTimeKind.Unspecified).AddTicks(8194), "Willow_Hilpert38" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 26, 12, 16, 4, 402, DateTimeKind.Unspecified).AddTicks(9538), "gmail.com_Orn@gmail.com", "Theron Buckridge", "hfwm12", "0284126576", 5, new DateTime(2024, 9, 26, 12, 16, 4, 402, DateTimeKind.Unspecified).AddTicks(9538), "Josianne_Welch" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 1, 19, 46, 59, 176, DateTimeKind.Unspecified).AddTicks(8107), "gmail.com_Friesen@hotmail.com", "Jerrell Raynor", "pydbrk", "0882796181", 2, new DateTime(2024, 9, 1, 19, 46, 59, 176, DateTimeKind.Unspecified).AddTicks(8107), "Bernadine.Ruecker86" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 8, 18, 24, 52, 70, DateTimeKind.Unspecified).AddTicks(3859), "gmail.com47@gmail.com", "Constantin Hagenes", "nnprad", "0661492837", 1, new DateTime(2024, 9, 8, 18, 24, 52, 70, DateTimeKind.Unspecified).AddTicks(3859), "Kenyatta_Larkin87" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 25, 7, 33, 58, 99, DateTimeKind.Unspecified).AddTicks(4769), "gmail.com.Gerlach@yahoo.com", "Jensen Ullrich", "rhsbe8", "0446834523", 5, new DateTime(2024, 9, 25, 7, 33, 58, 99, DateTimeKind.Unspecified).AddTicks(4769), "Marvin.Murazik31" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 5, 22, 55, 35, 948, DateTimeKind.Unspecified).AddTicks(1265), "gmail.com.OKon@gmail.com", "Ward Wilderman", "50mupf", "0236054712", 4, new DateTime(2024, 9, 5, 22, 55, 35, 948, DateTimeKind.Unspecified).AddTicks(1265), "Karson71" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 15, 0, 1, 53, 384, DateTimeKind.Unspecified).AddTicks(9887), "gmail.com_Wilderman82@yahoo.com", "Conor Feest", "yq0okm", "0950020636", 4, new DateTime(2024, 9, 15, 0, 1, 53, 384, DateTimeKind.Unspecified).AddTicks(9887), "Clemens_Gibson" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 18, 2, 15, 15, 319, DateTimeKind.Unspecified).AddTicks(5839), "gmail.com_Bernhard@hotmail.com", "Lyla Swaniawski", "qblws5", "0141089722", 2, new DateTime(2024, 9, 18, 2, 15, 15, 319, DateTimeKind.Unspecified).AddTicks(5839), "Leta_Hettinger14" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 11, 20, 53, 25, 251, DateTimeKind.Unspecified).AddTicks(4082), "gmail.com.Boyle@gmail.com", "Catalina Jenkins", "49qvsc", "0780665504", 5, new DateTime(2024, 9, 11, 20, 53, 25, 251, DateTimeKind.Unspecified).AddTicks(4082), "Demetrius.Von12" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 22, 16, 52, 11, 968, DateTimeKind.Unspecified).AddTicks(9135), "gmail.com_Bartell99@yahoo.com", "Crawford Dickens", "la634p", "0519665316", new DateTime(2024, 9, 22, 16, 52, 11, 968, DateTimeKind.Unspecified).AddTicks(9135), "Alex.Hills" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 18, 7, 16, 13, 763, DateTimeKind.Unspecified).AddTicks(4525), "gmail.com73@yahoo.com", "Lamont Murray", "6f5l1j", "0949171824", 2, new DateTime(2024, 9, 18, 7, 16, 13, 763, DateTimeKind.Unspecified).AddTicks(4525), "Anastasia.Moen" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 19, 1, 25, 8, 544, DateTimeKind.Unspecified).AddTicks(6448), "gmail.com_Waelchi@hotmail.com", "Ryder Cassin", "c3wry1", "0694422490", 3, new DateTime(2024, 9, 19, 1, 25, 8, 544, DateTimeKind.Unspecified).AddTicks(6448), "Miles72" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 14, 19, 44, 24, 313, DateTimeKind.Unspecified).AddTicks(3021), "gmail.com.Hills@hotmail.com", "Emma Bosco", "jhedxa", "0353301750", 1, new DateTime(2024, 9, 14, 19, 44, 24, 313, DateTimeKind.Unspecified).AddTicks(3021), "Lia.Funk99" });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 1,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Officiis et similique cupiditate exercitationem. Iure saepe deleniti aspernatur rerum dolorem eveniet consequatur nesciunt. Fuga et voluptatem sapiente et. Est ad consectetur adipisci perferendis. Odit accusantium dolor at magni. Aut et corrupti asperiores vel omnis error.", new DateTime(2024, 10, 25, 22, 1, 56, 574, DateTimeKind.Local).AddTicks(531), new DateTime(2024, 9, 25, 22, 1, 56, 574, DateTimeKind.Local).AddTicks(468) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 2,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Et porro ut quas. Dignissimos ad consequatur minima fugit maiores incidunt explicabo. Nobis qui dignissimos ut ut in qui possimus. Fugit et sint distinctio et et temporibus aut rerum eius.", new DateTime(2024, 10, 25, 22, 1, 56, 574, DateTimeKind.Local).AddTicks(1106), new DateTime(2024, 9, 25, 22, 1, 56, 574, DateTimeKind.Local).AddTicks(1103) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 3,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Dolores quisquam pariatur a et. Sunt sed enim ex est hic enim. Magni veritatis sint eos assumenda rerum non necessitatibus. Et ut adipisci eaque.", new DateTime(2024, 9, 27, 22, 1, 56, 584, DateTimeKind.Local).AddTicks(6650), new DateTime(2024, 9, 26, 22, 1, 56, 584, DateTimeKind.Local).AddTicks(6542), 2 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 4,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Dolor modi et earum iure earum. Cumque voluptas ipsum non id ex nisi sequi non odit. Amet et iusto assumenda ut qui qui est ducimus. At voluptas vero non enim velit vel. At commodi saepe voluptatem impedit quam est fugit molestias consequatur. Ea aut nihil aut quas quo commodi quos eum.", new DateTime(2024, 9, 27, 22, 1, 56, 584, DateTimeKind.Local).AddTicks(7334), new DateTime(2024, 9, 26, 22, 1, 56, 584, DateTimeKind.Local).AddTicks(7329), 9 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 5,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Et tenetur et dolores eius minima qui cum consequuntur fugiat. Aliquam a placeat qui molestias. Reiciendis vitae suscipit inventore qui dolores velit aut minima.", new DateTime(2024, 9, 27, 22, 1, 56, 587, DateTimeKind.Local).AddTicks(1721), new DateTime(2024, 9, 26, 22, 1, 56, 587, DateTimeKind.Local).AddTicks(1645), 2 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 6,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "In nihil deleniti eius commodi ut accusantium porro suscipit rerum. Consequuntur quis quibusdam et tempore consequuntur. Veritatis illum iusto velit facere accusantium. Est quisquam eum et architecto et ex. Consequuntur sit qui natus consequatur velit similique voluptatem.", new DateTime(2024, 9, 27, 22, 1, 56, 587, DateTimeKind.Local).AddTicks(2229), new DateTime(2024, 9, 26, 22, 1, 56, 587, DateTimeKind.Local).AddTicks(2225), 7 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 7,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Tenetur quo et quia et. Aut sed nisi minima tenetur. Temporibus accusantium at nostrum quibusdam eaque est. Tempora ut occaecati.", new DateTime(2024, 9, 27, 22, 1, 56, 588, DateTimeKind.Local).AddTicks(9388), new DateTime(2024, 9, 26, 22, 1, 56, 588, DateTimeKind.Local).AddTicks(9338), 9 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 8,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Asperiores perspiciatis et et et qui maiores. Qui deserunt et natus architecto vero officiis quam id. Sed in tempora sunt deleniti eum tenetur.", new DateTime(2024, 9, 27, 22, 1, 56, 588, DateTimeKind.Local).AddTicks(9691), new DateTime(2024, 9, 26, 22, 1, 56, 588, DateTimeKind.Local).AddTicks(9686), 2 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 9,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Porro non officiis doloremque accusamus voluptas commodi suscipit molestiae incidunt. Doloremque aut rerum tempore illo id voluptatem. Quisquam atque sunt excepturi ipsam.", new DateTime(2024, 9, 27, 22, 1, 56, 590, DateTimeKind.Local).AddTicks(2683), new DateTime(2024, 9, 26, 22, 1, 56, 590, DateTimeKind.Local).AddTicks(2649), 4 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 10,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Delectus laudantium expedita sint nihil. Est aperiam repellendus et dolorum repudiandae ea libero nihil mollitia. Et consequuntur vel suscipit iste quo quasi rerum id. Molestiae accusamus temporibus eum repudiandae et et veritatis nostrum.", new DateTime(2024, 9, 27, 22, 1, 56, 590, DateTimeKind.Local).AddTicks(2942), new DateTime(2024, 9, 26, 22, 1, 56, 590, DateTimeKind.Local).AddTicks(2940), 9 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 11,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Nobis velit et amet quis modi. Accusantium dolorum qui. Vero quia quis ad nam ratione qui aut. Quibusdam est iure quo sed perspiciatis voluptas pariatur. Odio quos necessitatibus dolores aut eligendi ex.", new DateTime(2024, 9, 27, 22, 1, 56, 591, DateTimeKind.Local).AddTicks(4915), new DateTime(2024, 9, 26, 22, 1, 56, 591, DateTimeKind.Local).AddTicks(4885), 9 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 12,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Error soluta tenetur est consectetur. Et quas enim id et est facilis. Eum nulla laudantium rerum beatae quaerat non velit aliquam. Consequuntur corrupti consectetur qui eos tempora deleniti enim.", new DateTime(2024, 9, 27, 22, 1, 56, 591, DateTimeKind.Local).AddTicks(5146), new DateTime(2024, 9, 26, 22, 1, 56, 591, DateTimeKind.Local).AddTicks(5144) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 13,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Qui eum quia voluptatem. Blanditiis sint eum autem. Asperiores eum temporibus quo voluptatem. Rerum dolores amet assumenda exercitationem beatae saepe aut autem sit. Sint perspiciatis numquam ducimus sint aut modi voluptas dolore.", new DateTime(2024, 9, 27, 22, 1, 56, 594, DateTimeKind.Local).AddTicks(8936), new DateTime(2024, 9, 26, 22, 1, 56, 594, DateTimeKind.Local).AddTicks(8774), 7 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 14,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Velit dolor iure repudiandae. Saepe dolorem rerum est. Eaque sapiente est nemo sit necessitatibus sunt eius error non. Culpa reprehenderit labore aut dolorem sed nihil. Illum dolorem voluptatibus sit nostrum incidunt voluptas eaque quia qui. Placeat qui qui.", new DateTime(2024, 9, 27, 22, 1, 56, 594, DateTimeKind.Local).AddTicks(9296), new DateTime(2024, 9, 26, 22, 1, 56, 594, DateTimeKind.Local).AddTicks(9293), 4 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 15,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Molestias non ut. Voluptas aut labore quia voluptatibus ab maxime provident magni. Voluptatum doloremque eveniet fuga maiores est ipsum. Fuga quas quia molestiae. Qui quia nobis tempore quod corporis voluptatem.", new DateTime(2024, 9, 27, 22, 1, 56, 596, DateTimeKind.Local).AddTicks(3275), new DateTime(2024, 9, 26, 22, 1, 56, 596, DateTimeKind.Local).AddTicks(3235), 9 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 16,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Quasi repudiandae nobis optio ut. Minus est aut fugiat enim quia fuga quasi placeat. Maxime aut excepturi deserunt non. Praesentium nisi harum mollitia possimus officia mollitia. Sapiente explicabo earum non ipsa porro accusantium quam quia. Impedit ipsam aut quia voluptate ut ad quia.", new DateTime(2024, 9, 27, 22, 1, 56, 596, DateTimeKind.Local).AddTicks(3582), new DateTime(2024, 9, 26, 22, 1, 56, 596, DateTimeKind.Local).AddTicks(3580), 7 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 17,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Corporis ut molestiae sunt unde excepturi quis autem et quia. Ut beatae nesciunt. Atque libero est doloribus. Dolor ut dolorum fuga voluptatem placeat. Ut neque dignissimos quaerat facere dolorem pariatur velit. Omnis vel nemo illo error qui.", new DateTime(2024, 9, 27, 22, 1, 56, 597, DateTimeKind.Local).AddTicks(9758), new DateTime(2024, 9, 26, 22, 1, 56, 597, DateTimeKind.Local).AddTicks(9589), 7 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 18,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Tenetur fugiat est nam quas. Ad nesciunt quam sunt omnis corrupti impedit rerum. Atque voluptates laborum quam provident soluta et rerum earum. Recusandae dolores error consequatur.", new DateTime(2024, 9, 27, 22, 1, 56, 598, DateTimeKind.Local).AddTicks(994), new DateTime(2024, 9, 26, 22, 1, 56, 598, DateTimeKind.Local).AddTicks(984), 3 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 19,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Rem excepturi explicabo laboriosam non quo expedita aut. Cumque ratione molestiae cupiditate est excepturi corrupti. Assumenda iste ad. Voluptatem doloremque rerum. Est molestiae autem architecto et et ut pariatur est nulla. Magnam dolor eius vel.", new DateTime(2024, 9, 27, 22, 1, 56, 600, DateTimeKind.Local).AddTicks(8345), new DateTime(2024, 9, 26, 22, 1, 56, 600, DateTimeKind.Local).AddTicks(8268) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 20,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Eos natus eveniet incidunt. Ut dolorem voluptates et aut. Quis neque eos quae.", new DateTime(2024, 9, 27, 22, 1, 56, 600, DateTimeKind.Local).AddTicks(8750), new DateTime(2024, 9, 26, 22, 1, 56, 600, DateTimeKind.Local).AddTicks(8745), 2 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 21,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Beatae quia quidem labore rerum. Sit aspernatur modi explicabo eius. Ea in ut tempora placeat. Dignissimos qui magnam.", new DateTime(2024, 9, 27, 22, 1, 56, 603, DateTimeKind.Local).AddTicks(2984), new DateTime(2024, 9, 26, 22, 1, 56, 603, DateTimeKind.Local).AddTicks(2916), 1 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 22,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Iure dignissimos dolorum illum hic excepturi aut. Eaque iusto sed quae voluptatem in eum. Rerum dignissimos non est sunt. Quo et est iusto nihil. Aut blanditiis delectus eum. Amet dignissimos impedit dolor non qui tempora.", new DateTime(2024, 9, 27, 22, 1, 56, 603, DateTimeKind.Local).AddTicks(3531), new DateTime(2024, 9, 26, 22, 1, 56, 603, DateTimeKind.Local).AddTicks(3523), 2 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 23,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Voluptates reiciendis in quia. Vel eaque vel. Provident et aut. Quos dignissimos unde perferendis omnis temporibus rerum. Est natus error aut earum asperiores assumenda hic et.", new DateTime(2024, 9, 27, 22, 1, 56, 606, DateTimeKind.Local).AddTicks(7309), new DateTime(2024, 9, 26, 22, 1, 56, 606, DateTimeKind.Local).AddTicks(7237), 1 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 24,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Excepturi quas nobis ut dolorum alias provident velit et beatae. Exercitationem ad beatae. Qui voluptatum tempora eos iure aut numquam aut sequi ab.", new DateTime(2024, 9, 27, 22, 1, 56, 606, DateTimeKind.Local).AddTicks(7761), new DateTime(2024, 9, 26, 22, 1, 56, 606, DateTimeKind.Local).AddTicks(7756), 10 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 25,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Libero est ipsam. Eligendi nisi quia vel doloremque. Quia eum exercitationem perferendis modi in quis dolore minima.", new DateTime(2024, 9, 27, 22, 1, 56, 609, DateTimeKind.Local).AddTicks(4853), new DateTime(2024, 9, 26, 22, 1, 56, 609, DateTimeKind.Local).AddTicks(4758), 7 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 26,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Repellat aperiam pariatur voluptatem dolores et ut. Consequatur vel fugit aperiam veniam nemo autem ut. Possimus magni sed reiciendis rerum. Asperiores impedit in suscipit distinctio iste consequatur. Voluptatibus eum minima distinctio aliquid aut ut.", new DateTime(2024, 9, 27, 22, 1, 56, 609, DateTimeKind.Local).AddTicks(5983), new DateTime(2024, 9, 26, 22, 1, 56, 609, DateTimeKind.Local).AddTicks(5978), 9 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 27,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Molestiae blanditiis nihil rem eligendi. Id sed ea voluptas expedita nihil molestiae eum sit laborum. Qui adipisci quia doloribus. Tempora et et.", new DateTime(2024, 9, 27, 22, 1, 56, 612, DateTimeKind.Local).AddTicks(5167), new DateTime(2024, 9, 26, 22, 1, 56, 612, DateTimeKind.Local).AddTicks(5090), 5 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 28,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Enim consequatur nisi est dolor commodi sed atque molestiae quia. Minima nihil voluptates illo quas reprehenderit dolor perferendis odit. Id a impedit. Eos tempore sit et dolor aut.", new DateTime(2024, 9, 27, 22, 1, 56, 612, DateTimeKind.Local).AddTicks(5542), new DateTime(2024, 9, 26, 22, 1, 56, 612, DateTimeKind.Local).AddTicks(5540), 7 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 29,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Necessitatibus enim minima. Ut corrupti ipsa laudantium dolore quia maxime. Sint expedita soluta. Reiciendis adipisci odio nam est. Itaque incidunt quia totam quis. Non velit dolorum sed voluptatem accusamus numquam libero quibusdam maiores.", new DateTime(2024, 9, 27, 22, 1, 56, 615, DateTimeKind.Local).AddTicks(6822), new DateTime(2024, 9, 26, 22, 1, 56, 615, DateTimeKind.Local).AddTicks(6772) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 30,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Odit laborum tempore rerum veritatis deserunt perferendis. Recusandae veritatis distinctio veniam dolores consequatur eveniet fugiat sit corporis. Velit et nesciunt optio molestiae quod quaerat adipisci ut. Odio porro sapiente ducimus quasi ut sit mollitia qui optio. Vel inventore consectetur libero ea vel dolorum vitae id.", new DateTime(2024, 9, 27, 22, 1, 56, 615, DateTimeKind.Local).AddTicks(7145), new DateTime(2024, 9, 26, 22, 1, 56, 615, DateTimeKind.Local).AddTicks(7143), 1 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 31,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Quis ex magni et voluptas iure aspernatur repellendus. Vero adipisci voluptas. Occaecati nobis quia eius nobis quia quia sit rerum nobis.", new DateTime(2024, 9, 27, 22, 1, 56, 616, DateTimeKind.Local).AddTicks(9258), new DateTime(2024, 9, 26, 22, 1, 56, 616, DateTimeKind.Local).AddTicks(9229), 8 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 32,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Minus quo non adipisci. Odit expedita iusto. Doloribus reiciendis cupiditate aut quos sit sed corporis. Ex ex officia. Sit veritatis quaerat ut mollitia.", new DateTime(2024, 9, 27, 22, 1, 56, 616, DateTimeKind.Local).AddTicks(9490), new DateTime(2024, 9, 26, 22, 1, 56, 616, DateTimeKind.Local).AddTicks(9487), 5 });

            migrationBuilder.UpdateData(
                table: "VisitProcesses",
                keyColumn: "VisitProcessId",
                keyValue: 1,
                columns: new[] { "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { new DateTime(2024, 10, 25, 22, 1, 56, 564, DateTimeKind.Local).AddTicks(8765), new DateTime(2024, 9, 25, 22, 1, 56, 564, DateTimeKind.Local).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 1,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Turner Inc", new DateTime(2024, 9, 4, 11, 15, 26, 921, DateTimeKind.Unspecified).AddTicks(963), 2, "4l0zq7goah", "0138159709", false, new DateTime(2024, 9, 4, 11, 15, 26, 921, DateTimeKind.Unspecified).AddTicks(963), "Virgil Ziemann" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 2,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Yost - Cronin", new DateTime(2024, 9, 7, 19, 37, 31, 179, DateTimeKind.Unspecified).AddTicks(9536), 2, "mro4qbl7sq", "0112633713", false, new DateTime(2024, 9, 7, 19, 37, 31, 179, DateTimeKind.Unspecified).AddTicks(9536), "Margaret Daniel" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 3,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Kovacek - Leuschke", new DateTime(2024, 9, 22, 8, 3, 14, 359, DateTimeKind.Unspecified).AddTicks(6875), 1, "llekvzqas1", "0441545014", new DateTime(2024, 9, 22, 8, 3, 14, 359, DateTimeKind.Unspecified).AddTicks(6875), "Fae Kris" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 4,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Carroll, Erdman and Nicolas", new DateTime(2024, 9, 7, 13, 8, 47, 933, DateTimeKind.Unspecified).AddTicks(9821), 2, "90yc96jdd5", "0624278818", new DateTime(2024, 9, 7, 13, 8, 47, 933, DateTimeKind.Unspecified).AddTicks(9821), "Betsy Schmeler" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 5,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Cruickshank Group", new DateTime(2024, 9, 8, 21, 9, 47, 484, DateTimeKind.Unspecified).AddTicks(7661), 1, "awiki8nu39", "0178576530", new DateTime(2024, 9, 8, 21, 9, 47, 484, DateTimeKind.Unspecified).AddTicks(7661), "Gene Pollich" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 6,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Klocko - Mertz", new DateTime(2024, 9, 14, 15, 9, 11, 931, DateTimeKind.Unspecified).AddTicks(3179), "54k1hvos1u", "0860263744", true, new DateTime(2024, 9, 14, 15, 9, 11, 931, DateTimeKind.Unspecified).AddTicks(3179), "Veronica Moen" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 7,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Streich and Sons", new DateTime(2024, 9, 12, 12, 9, 24, 616, DateTimeKind.Unspecified).AddTicks(4343), "fgdnu67pqe", "0225187916", new DateTime(2024, 9, 12, 12, 9, 24, 616, DateTimeKind.Unspecified).AddTicks(4343), "Unique Lowe" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 8,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Stracke Group", new DateTime(2024, 9, 9, 3, 29, 55, 234, DateTimeKind.Unspecified).AddTicks(727), "ir0pw4qyyl", "0902292846", new DateTime(2024, 9, 9, 3, 29, 55, 234, DateTimeKind.Unspecified).AddTicks(727), "Jazmyn Casper" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 9,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Thompson LLC", new DateTime(2024, 9, 4, 2, 26, 39, 926, DateTimeKind.Unspecified).AddTicks(984), "t6ogjglyug", "0840123812", new DateTime(2024, 9, 4, 2, 26, 39, 926, DateTimeKind.Unspecified).AddTicks(984), "Myrtie Langworth" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 10,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Runte LLC", new DateTime(2024, 9, 15, 5, 2, 14, 518, DateTimeKind.Unspecified).AddTicks(7631), 1, "g6hqx7j1k5", "0933306822", new DateTime(2024, 9, 15, 5, 2, 14, 518, DateTimeKind.Unspecified).AddTicks(7631), "Libbie Jones" });

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 1,
                column: "DateRegister",
                value: new DateTime(2024, 9, 24, 22, 1, 56, 563, DateTimeKind.Local).AddTicks(7527));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 2,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 15, 1, 56, 576, DateTimeKind.Utc).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 3,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 15, 1, 56, 576, DateTimeKind.Utc).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 4,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 15, 1, 56, 576, DateTimeKind.Utc).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 5,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 15, 1, 56, 576, DateTimeKind.Utc).AddTicks(6153));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 6,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 15, 1, 56, 576, DateTimeKind.Utc).AddTicks(6163));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { 5, new DateTime(2024, 9, 14, 17, 29, 1, 444, DateTimeKind.Utc).AddTicks(6787), "Phòng Nhân sự", "Placeat consectetur rerum fugiat.", new DateTime(2024, 9, 14, 17, 29, 1, 444, DateTimeKind.Utc).AddTicks(6787) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 4, 42, 8, 564, DateTimeKind.Utc).AddTicks(5646), "Phòng Nhân sự", "Quaerat enim et nesciunt possimus veritatis numquam in.", new DateTime(2024, 9, 15, 4, 42, 8, 564, DateTimeKind.Utc).AddTicks(5646) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 3, 21, 19, 1, 81, DateTimeKind.Utc).AddTicks(2807), "Phòng Kinh doanh", "Fugiat quia facilis.", new DateTime(2024, 9, 3, 21, 19, 1, 81, DateTimeKind.Utc).AddTicks(2807) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 4, new DateTime(2024, 9, 19, 21, 32, 17, 638, DateTimeKind.Utc).AddTicks(697), "Phòng IT", "Sed consequatur cum ad laborum tempore consequatur dolores nam.", new DateTime(2024, 9, 19, 21, 32, 17, 638, DateTimeKind.Utc).AddTicks(697) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2024, 9, 25, 21, 46, 14, 396, DateTimeKind.Utc).AddTicks(1757), "Phòng Nhân sự", "Accusamus et voluptate animi assumenda ut expedita quam.", new DateTime(2024, 9, 25, 21, 46, 14, 396, DateTimeKind.Utc).AddTicks(1757) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 6,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 17, 1, 49, 53, 702, DateTimeKind.Utc).AddTicks(3256), "Phòng Kế toán", "Sint ea ut earum possimus est ut adipisci.", new DateTime(2024, 9, 17, 1, 49, 53, 702, DateTimeKind.Utc).AddTicks(3256) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 7,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 4, new DateTime(2024, 9, 19, 22, 52, 18, 274, DateTimeKind.Utc).AddTicks(2542), "Phòng Pháp chế", "Vitae doloribus incidunt libero qui voluptas voluptatem similique natus beatae.", new DateTime(2024, 9, 19, 22, 52, 18, 274, DateTimeKind.Utc).AddTicks(2542) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 8,
                columns: new[] { "CreateDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 52, 19, 248, DateTimeKind.Utc).AddTicks(3647), "Sit quia similique voluptas et possimus autem.", new DateTime(2024, 9, 11, 23, 52, 19, 248, DateTimeKind.Utc).AddTicks(3647) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 9,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2024, 9, 4, 1, 3, 3, 821, DateTimeKind.Utc).AddTicks(300), "Phòng Sản xuất", "Consequatur quas blanditiis ducimus pariatur perspiciatis.", new DateTime(2024, 9, 4, 1, 3, 3, 821, DateTimeKind.Utc).AddTicks(300) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 10,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 9, 15, 8, 25, 49, 871, DateTimeKind.Utc).AddTicks(9162), "Phòng Chăm sóc khách hàng", "Molestiae rerum temporibus et eos rerum maiores.", new DateTime(2024, 9, 15, 8, 25, 49, 871, DateTimeKind.Utc).AddTicks(9162) });

            migrationBuilder.UpdateData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: 1,
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 24, 14, 3, 5, 125, DateTimeKind.Utc).AddTicks(6164), "Unbranded Wooden Ball", false });

            migrationBuilder.UpdateData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: 2,
                columns: new[] { "CreateTime", "ProcessName" },
                values: new object[] { new DateTime(2024, 9, 24, 14, 3, 5, 125, DateTimeKind.Utc).AddTicks(8027), "Tasty Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: 3,
                columns: new[] { "CreateTime", "ProcessName" },
                values: new object[] { new DateTime(2024, 9, 24, 14, 3, 5, 125, DateTimeKind.Utc).AddTicks(8055), "Practical Soft Mouse" });

            migrationBuilder.UpdateData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: 4,
                columns: new[] { "CreateTime", "ProcessName" },
                values: new object[] { new DateTime(2024, 9, 24, 14, 3, 5, 125, DateTimeKind.Utc).AddTicks(8073), "Gorgeous Cotton Computer" });

            migrationBuilder.UpdateData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: 5,
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 24, 14, 3, 5, 125, DateTimeKind.Utc).AddTicks(8090), "Gorgeous Fresh Tuna", false });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 1,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardTypeId" },
                values: new object[] { new Guid("ece5de14-04ba-4ba4-a42c-65a3c46f2f1e"), new DateTime(2024, 9, 26, 21, 3, 5, 167, DateTimeKind.Local).AddTicks(268), new DateTime(2024, 10, 26, 21, 3, 5, 167, DateTimeKind.Local).AddTicks(268), 1 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 2,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId" },
                values: new object[] { new Guid("c73da352-a17b-49f4-9e73-3b321be65345"), new DateTime(2024, 9, 26, 21, 3, 5, 167, DateTimeKind.Local).AddTicks(456), new DateTime(2024, 10, 26, 21, 3, 5, 167, DateTimeKind.Local).AddTicks(456), 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 3,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId" },
                values: new object[] { new Guid("d4315112-7ffd-496d-a209-6136e9c4a338"), new DateTime(2024, 9, 26, 21, 3, 5, 167, DateTimeKind.Local).AddTicks(468), new DateTime(2024, 10, 26, 21, 3, 5, 167, DateTimeKind.Local).AddTicks(468), 1 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 4,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("e14d6c25-7fab-4421-9b14-de07523911f4"), new DateTime(2024, 9, 26, 21, 3, 5, 167, DateTimeKind.Local).AddTicks(476), new DateTime(2024, 10, 26, 21, 3, 5, 167, DateTimeKind.Local).AddTicks(476) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 5,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId", "QRCardTypeId" },
                values: new object[] { new Guid("2899667c-a36f-497a-99f2-e576346adfd2"), new DateTime(2024, 9, 26, 21, 3, 5, 167, DateTimeKind.Local).AddTicks(483), new DateTime(2024, 10, 26, 21, 3, 5, 167, DateTimeKind.Local).AddTicks(483), 1, 1 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 6,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("6935d4ec-edd0-476f-950d-2703a2ee01a7"), new DateTime(2024, 9, 26, 21, 3, 5, 167, DateTimeKind.Local).AddTicks(503), new DateTime(2024, 10, 26, 21, 3, 5, 167, DateTimeKind.Local).AddTicks(503) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 7,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("c1072234-9bdf-4b34-b073-575cfccb39c7"), new DateTime(2024, 9, 26, 21, 3, 5, 167, DateTimeKind.Local).AddTicks(510), new DateTime(2024, 10, 26, 21, 3, 5, 167, DateTimeKind.Local).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 8,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardTypeId" },
                values: new object[] { new Guid("f33222a6-9836-4eeb-ab14-5eb32e3f97ec"), new DateTime(2024, 9, 26, 21, 3, 5, 167, DateTimeKind.Local).AddTicks(516), new DateTime(2024, 10, 26, 21, 3, 5, 167, DateTimeKind.Local).AddTicks(516), 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 9,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardTypeId" },
                values: new object[] { new Guid("f1c55b40-e612-4869-92b8-ae148cc0c7a1"), new DateTime(2024, 9, 26, 21, 3, 5, 167, DateTimeKind.Local).AddTicks(523), new DateTime(2024, 10, 26, 21, 3, 5, 167, DateTimeKind.Local).AddTicks(523), 1 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 10,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId" },
                values: new object[] { new Guid("e36cd8c3-fe4e-4924-a1e6-c14d00b8babe"), new DateTime(2024, 9, 26, 21, 3, 5, 167, DateTimeKind.Local).AddTicks(530), new DateTime(2024, 10, 26, 21, 3, 5, 167, DateTimeKind.Local).AddTicks(530), 2 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 4,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 1, 18 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 5,
                column: "UserId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 6,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 19 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 7,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 6, 12 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 8,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 6, 20 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 9,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 6, 20 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 10,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 1, 10 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 11,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 4, 10 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 12,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 5, 13 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 13,
                column: "DepartmentId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 14,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 4, 7 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 15,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 2, 12 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 16,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 15 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 17,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 5, 6 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 18,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 3, 10 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 19,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 3, 10 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 20,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 25 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 21,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 10, 16 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 22,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 3, 22 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 23,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 2, 23 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 14, 3, 5, 115, DateTimeKind.Utc).AddTicks(7724), new DateTime(2024, 9, 26, 14, 3, 5, 115, DateTimeKind.Utc).AddTicks(7731) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 26, 14, 3, 5, 115, DateTimeKind.Utc).AddTicks(7733), new DateTime(2024, 9, 26, 14, 3, 5, 115, DateTimeKind.Utc).AddTicks(7734) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 26, 14, 3, 5, 115, DateTimeKind.Utc).AddTicks(7736), new DateTime(2024, 9, 26, 14, 3, 5, 115, DateTimeKind.Utc).AddTicks(7737) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 3, 5, 115, DateTimeKind.Utc).AddTicks(7738), new DateTime(2024, 9, 26, 14, 3, 5, 115, DateTimeKind.Utc).AddTicks(7739) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 26, 14, 3, 5, 115, DateTimeKind.Utc).AddTicks(7740), new DateTime(2024, 9, 26, 14, 3, 5, 115, DateTimeKind.Utc).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 21, 10, 17, 21, 318, DateTimeKind.Unspecified).AddTicks(4704), "gmail.com53@hotmail.com", "Jimmie Reynolds", "arv6at", "0665974443", 4, new DateTime(2024, 9, 21, 10, 17, 21, 318, DateTimeKind.Unspecified).AddTicks(4704), "Emmanuelle_Windler" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 5, 19, 37, 7, 976, DateTimeKind.Unspecified).AddTicks(7784), "gmail.com90@yahoo.com", "Caesar King", "0xryjf", "0291205743", 5, new DateTime(2024, 9, 5, 19, 37, 7, 976, DateTimeKind.Unspecified).AddTicks(7784), "Cleora_Howell" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 22, 4, 49, 3, 99, DateTimeKind.Unspecified).AddTicks(4462), "gmail.com.Botsford79@gmail.com", "Sigrid Morar", "11shoe", "0303930993", 2, new DateTime(2024, 9, 22, 4, 49, 3, 99, DateTimeKind.Unspecified).AddTicks(4462), "Berniece.Daugherty" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 23, 5, 9, 42, 158, DateTimeKind.Unspecified).AddTicks(8122), "gmail.com.Armstrong@gmail.com", "Rosemary Schuster", "9bvh1b", "0753101194", 5, new DateTime(2024, 9, 23, 5, 9, 42, 158, DateTimeKind.Unspecified).AddTicks(8122), "Jena_Orn" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 17, 16, 19, 27, 603, DateTimeKind.Unspecified).AddTicks(3487), "gmail.com5@yahoo.com", "Mara Barton", "f6x6lz", "0795732876", 4, new DateTime(2024, 9, 17, 16, 19, 27, 603, DateTimeKind.Unspecified).AddTicks(3487), "Ruth16" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 17, 22, 22, 15, 650, DateTimeKind.Unspecified).AddTicks(1352), "gmail.com.Hansen72@yahoo.com", "Katlyn Crona", "8np1ig", "0235348308", new DateTime(2024, 9, 17, 22, 22, 15, 650, DateTimeKind.Unspecified).AddTicks(1352), "Luther88" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 6, 21, 47, 43, 963, DateTimeKind.Unspecified).AddTicks(3248), "gmail.com.Schulist92@hotmail.com", "Dexter Crona", "kt920x", "0642349016", 3, new DateTime(2024, 9, 6, 21, 47, 43, 963, DateTimeKind.Unspecified).AddTicks(3248), "Daphne_Baumbach" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 26, 5, 6, 6, 246, DateTimeKind.Unspecified).AddTicks(4025), "gmail.com82@yahoo.com", "Jared Schroeder", "pfe1ft", "0577689162", new DateTime(2024, 9, 26, 5, 6, 6, 246, DateTimeKind.Unspecified).AddTicks(4025), "Elmira_Turcotte" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 12, 1, 22, 49, 817, DateTimeKind.Unspecified).AddTicks(6804), "gmail.com_Dach71@gmail.com", "Brock Torp", "3retk0", "0865642984", 4, new DateTime(2024, 9, 12, 1, 22, 49, 817, DateTimeKind.Unspecified).AddTicks(6804), "Federico_Spencer" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 12, 7, 48, 24, 254, DateTimeKind.Unspecified).AddTicks(3765), "gmail.com_Krajcik87@hotmail.com", "Ebony Krajcik", "3gh28x", "0593442985", 5, new DateTime(2024, 9, 12, 7, 48, 24, 254, DateTimeKind.Unspecified).AddTicks(3765), "Adolf.Wilderman85" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 3, 22, 6, 40, 38, DateTimeKind.Unspecified).AddTicks(8811), "gmail.com87@gmail.com", "Selina Stamm", "2b71f3", "0381805576", 5, new DateTime(2024, 9, 3, 22, 6, 40, 38, DateTimeKind.Unspecified).AddTicks(8811), "Valentin20" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 8, 3, 9, 41, 111, DateTimeKind.Unspecified).AddTicks(9770), "gmail.com.Dooley64@yahoo.com", "Dagmar Kessler", "eklr4s", "0352564289", 4, new DateTime(2024, 9, 8, 3, 9, 41, 111, DateTimeKind.Unspecified).AddTicks(9770), "Alana.Cummings52" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 3, 13, 50, 58, 321, DateTimeKind.Unspecified).AddTicks(224), "gmail.com_Heidenreich69@gmail.com", "Gene Durgan", "x9a9dz", "0366988498", 1, new DateTime(2024, 9, 3, 13, 50, 58, 321, DateTimeKind.Unspecified).AddTicks(224), "Coleman.Hessel" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 7, 21, 55, 19, 605, DateTimeKind.Unspecified).AddTicks(8441), "gmail.com.Davis@gmail.com", "Kenya Walsh", "43cp3l", "0942738479", 5, new DateTime(2024, 9, 7, 21, 55, 19, 605, DateTimeKind.Unspecified).AddTicks(8441), "Mittie.Heller26" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 14, 18, 39, 52, 367, DateTimeKind.Unspecified).AddTicks(4496), "gmail.com.Marvin@gmail.com", "Bettye Glover", "hc3nzx", "0405171272", 5, new DateTime(2024, 9, 14, 18, 39, 52, 367, DateTimeKind.Unspecified).AddTicks(4496), "Torrey_Rempel" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 17, 7, 44, 47, 97, DateTimeKind.Unspecified).AddTicks(1506), "gmail.com_Carroll1@hotmail.com", "Rico Purdy", "5q8ig3", "0788160925", 4, new DateTime(2024, 9, 17, 7, 44, 47, 97, DateTimeKind.Unspecified).AddTicks(1506), "Jerome_Kunde51" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 24, 7, 31, 18, 801, DateTimeKind.Unspecified).AddTicks(401), "gmail.com24@yahoo.com", "Cassandre Champlin", "rhini3", "0990818444", new DateTime(2024, 9, 24, 7, 31, 18, 801, DateTimeKind.Unspecified).AddTicks(401), "Kane.Hand" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 17, 3, 52, 19, 28, DateTimeKind.Unspecified).AddTicks(2489), "gmail.com_Moen5@gmail.com", "Felix Ritchie", "mgwpwn", "0264742827", 1, new DateTime(2024, 9, 17, 3, 52, 19, 28, DateTimeKind.Unspecified).AddTicks(2489), "Libbie.Lind" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 25, 18, 30, 15, 925, DateTimeKind.Unspecified).AddTicks(9626), "gmail.com_Fadel25@yahoo.com", "Esperanza Dach", "rlx6x3", "0139837893", 4, new DateTime(2024, 9, 25, 18, 30, 15, 925, DateTimeKind.Unspecified).AddTicks(9626), "Buddy78" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 19, 19, 41, 50, 541, DateTimeKind.Unspecified).AddTicks(4589), "gmail.com68@hotmail.com", "Johan O'Conner", "01fv6k", "0662040845", 5, new DateTime(2024, 9, 19, 19, 41, 50, 541, DateTimeKind.Unspecified).AddTicks(4589), "Mireya_Wyman" });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 1,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Iste et cumque et et nemo necessitatibus sit. Voluptas dignissimos enim dolorem perspiciatis. Rem quasi perferendis officia adipisci tenetur mollitia. Sunt in ut blanditiis voluptas adipisci ullam qui quia quis. Optio consequatur voluptates earum et ipsa.", new DateTime(2024, 10, 25, 21, 3, 5, 129, DateTimeKind.Local).AddTicks(5485), new DateTime(2024, 9, 25, 21, 3, 5, 129, DateTimeKind.Local).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 2,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Autem aliquam culpa. Magni voluptas velit fugit assumenda nostrum minima quo et. Laboriosam in dolores facilis dolorem suscipit maiores ducimus neque ipsa. Assumenda dicta minima numquam sit sit consequatur. Molestiae quam magni. Et optio ut odio non.", new DateTime(2024, 10, 25, 21, 3, 5, 129, DateTimeKind.Local).AddTicks(5968), new DateTime(2024, 9, 25, 21, 3, 5, 129, DateTimeKind.Local).AddTicks(5965) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 3,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Nesciunt reprehenderit omnis consectetur expedita dolorem ducimus non sed. Explicabo officia culpa nostrum recusandae eaque iste quaerat quia. Est explicabo debitis sit harum eos aut dolores. Aut quo optio iste pariatur accusamus.", new DateTime(2024, 9, 27, 21, 3, 5, 131, DateTimeKind.Local).AddTicks(7534), new DateTime(2024, 9, 26, 21, 3, 5, 131, DateTimeKind.Local).AddTicks(7506), 3 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 4,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Optio maiores suscipit similique dolores quas facere id. Magni est qui libero. Consequatur consequatur assumenda aperiam aut aut numquam recusandae qui rerum. Natus rerum magnam. Explicabo reiciendis fugiat aperiam.", new DateTime(2024, 9, 27, 21, 3, 5, 131, DateTimeKind.Local).AddTicks(7771), new DateTime(2024, 9, 26, 21, 3, 5, 131, DateTimeKind.Local).AddTicks(7769), 8 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 5,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Labore error a. Sit similique repellendus aut neque et est occaecati voluptas aut. Nesciunt sed quo labore enim ratione voluptas dolores dolorem eos.", new DateTime(2024, 9, 27, 21, 3, 5, 132, DateTimeKind.Local).AddTicks(8256), new DateTime(2024, 9, 26, 21, 3, 5, 132, DateTimeKind.Local).AddTicks(8231), 8 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 6,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Ea fugiat qui voluptatibus similique aut delectus. Amet cupiditate dolores fuga vero et. Fugiat in qui nisi corporis ut nostrum et sapiente.", new DateTime(2024, 9, 27, 21, 3, 5, 132, DateTimeKind.Local).AddTicks(8456), new DateTime(2024, 9, 26, 21, 3, 5, 132, DateTimeKind.Local).AddTicks(8454), 5 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 7,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Aspernatur repellat repellat eaque adipisci. Iure et libero deleniti debitis. Suscipit ut tenetur aspernatur qui omnis quia animi. Molestias veniam non ut libero et iste voluptas doloremque est. Consequatur odio error odio aperiam iusto cupiditate exercitationem expedita nam.", new DateTime(2024, 9, 27, 21, 3, 5, 133, DateTimeKind.Local).AddTicks(8964), new DateTime(2024, 9, 26, 21, 3, 5, 133, DateTimeKind.Local).AddTicks(8939), 7 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 8,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Ad dolor consequatur totam perferendis culpa. Sed facilis ratione. Omnis impedit sapiente beatae blanditiis aut est voluptatem.", new DateTime(2024, 9, 27, 21, 3, 5, 133, DateTimeKind.Local).AddTicks(9162), new DateTime(2024, 9, 26, 21, 3, 5, 133, DateTimeKind.Local).AddTicks(9160), 1 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 9,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Qui nam et nulla quod non iste dicta aut. Omnis dolore facilis molestiae qui. Vitae in reprehenderit. Omnis minima ipsa consequuntur aliquam cupiditate repellendus dolor. Hic sit animi. Totam quis fugiat deserunt est cumque.", new DateTime(2024, 9, 27, 21, 3, 5, 137, DateTimeKind.Local).AddTicks(1937), new DateTime(2024, 9, 26, 21, 3, 5, 137, DateTimeKind.Local).AddTicks(1899), 1 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 10,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "In tenetur impedit tenetur sunt. Odit dolor ipsa nihil ipsa quisquam quia ut assumenda. Libero eveniet rerum aliquam suscipit nostrum officia porro est corporis. Ut optio dolorem incidunt. Deleniti libero aliquam.", new DateTime(2024, 9, 27, 21, 3, 5, 137, DateTimeKind.Local).AddTicks(2208), new DateTime(2024, 9, 26, 21, 3, 5, 137, DateTimeKind.Local).AddTicks(2205), 6 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 11,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Omnis alias consectetur autem ut qui exercitationem est minima illum. Amet natus ipsam non reiciendis et id quam rerum. Quis voluptate nam asperiores quis est. Vel perferendis laboriosam est deserunt qui est autem.", new DateTime(2024, 9, 27, 21, 3, 5, 153, DateTimeKind.Local).AddTicks(1271), new DateTime(2024, 9, 26, 21, 3, 5, 153, DateTimeKind.Local).AddTicks(1222), 4 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 12,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Explicabo voluptate hic voluptatem provident dolorem odit qui porro corrupti. Saepe ut quo et aspernatur voluptas animi et. Enim voluptatem nihil quis placeat modi hic.", new DateTime(2024, 9, 27, 21, 3, 5, 153, DateTimeKind.Local).AddTicks(1571), new DateTime(2024, 9, 26, 21, 3, 5, 153, DateTimeKind.Local).AddTicks(1569) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 13,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Repellendus dolorem non sed ut odio qui qui. Aliquid sed recusandae. Aspernatur vitae facilis et eveniet. Repellat veniam dolores voluptas.", new DateTime(2024, 9, 27, 21, 3, 5, 154, DateTimeKind.Local).AddTicks(4689), new DateTime(2024, 9, 26, 21, 3, 5, 154, DateTimeKind.Local).AddTicks(4658), 10 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 14,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Omnis placeat asperiores assumenda quos sed beatae nam. Praesentium error et nostrum exercitationem rem incidunt doloribus est. Error temporibus non sit tempore.", new DateTime(2024, 9, 27, 21, 3, 5, 154, DateTimeKind.Local).AddTicks(4924), new DateTime(2024, 9, 26, 21, 3, 5, 154, DateTimeKind.Local).AddTicks(4921), 6 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 15,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Vitae labore dicta. Numquam et earum quaerat. Sit voluptatem accusamus repudiandae sit nesciunt iusto repellendus. Adipisci ipsa consectetur. Illo soluta in mollitia est.", new DateTime(2024, 9, 27, 21, 3, 5, 155, DateTimeKind.Local).AddTicks(5694), new DateTime(2024, 9, 26, 21, 3, 5, 155, DateTimeKind.Local).AddTicks(5666), 4 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 16,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Non cupiditate dolorum accusantium. Error illo odit quos. Impedit quia ut commodi et et quidem aut animi suscipit. Qui sed aut sit similique cum voluptates occaecati. Unde distinctio id.", new DateTime(2024, 9, 27, 21, 3, 5, 155, DateTimeKind.Local).AddTicks(5925), new DateTime(2024, 9, 26, 21, 3, 5, 155, DateTimeKind.Local).AddTicks(5922), 8 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 17,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Voluptate ut beatae occaecati eum aut at et molestias. Quaerat cum molestiae aspernatur voluptatem ea. Rerum unde modi aliquam neque aut labore. A id sed.", new DateTime(2024, 9, 27, 21, 3, 5, 156, DateTimeKind.Local).AddTicks(7180), new DateTime(2024, 9, 26, 21, 3, 5, 156, DateTimeKind.Local).AddTicks(7154), 2 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 18,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Quo qui maxime nisi. Eos ea a ex molestiae sunt cupiditate non nesciunt. Quia sunt fuga. Ducimus non repellat suscipit dolor ratione eum rerum. Odio numquam tenetur sunt nemo nam iure sint et laborum.", new DateTime(2024, 9, 27, 21, 3, 5, 156, DateTimeKind.Local).AddTicks(7417), new DateTime(2024, 9, 26, 21, 3, 5, 156, DateTimeKind.Local).AddTicks(7415), 6 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 19,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Voluptatem qui ea praesentium qui. Totam qui maxime consectetur. Veritatis officia ab sequi illum. Aliquid aspernatur ducimus libero iure voluptas nemo pariatur. Odit commodi tenetur sequi qui.", new DateTime(2024, 9, 27, 21, 3, 5, 157, DateTimeKind.Local).AddTicks(8436), new DateTime(2024, 9, 26, 21, 3, 5, 157, DateTimeKind.Local).AddTicks(8411) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 20,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Sunt voluptatum eaque et aut sed eum ab ducimus vel. Fuga voluptates omnis ut rerum. Necessitatibus ab repellendus est quis.", new DateTime(2024, 9, 27, 21, 3, 5, 157, DateTimeKind.Local).AddTicks(8637), new DateTime(2024, 9, 26, 21, 3, 5, 157, DateTimeKind.Local).AddTicks(8635), 8 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 21,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Iste quia aut ad unde deserunt enim molestias in fuga. Animi quos aut est voluptas sed porro. Et sed vel. Eaque blanditiis inventore dolore sint. Labore saepe et perferendis facere non totam. Odio consequatur quasi ut placeat nam ea et est.", new DateTime(2024, 9, 27, 21, 3, 5, 158, DateTimeKind.Local).AddTicks(9917), new DateTime(2024, 9, 26, 21, 3, 5, 158, DateTimeKind.Local).AddTicks(9888), 9 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 22,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Sit et nemo. Optio fugiat ipsa qui qui. Accusamus rerum quidem. Iusto sed est delectus omnis ea accusamus.", new DateTime(2024, 9, 27, 21, 3, 5, 159, DateTimeKind.Local).AddTicks(122), new DateTime(2024, 9, 26, 21, 3, 5, 159, DateTimeKind.Local).AddTicks(120), 7 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 23,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Nesciunt dolorum aut. Qui beatae quibusdam fugit doloribus cumque nam accusantium. Quia voluptas aspernatur nam. Vel voluptas eveniet porro porro dolor nesciunt. Iste rerum dolorem accusamus et.", new DateTime(2024, 9, 27, 21, 3, 5, 160, DateTimeKind.Local).AddTicks(1441), new DateTime(2024, 9, 26, 21, 3, 5, 160, DateTimeKind.Local).AddTicks(1415), 3 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 24,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Et ab magni necessitatibus earum. Enim amet voluptatum non est ut tempora quia nemo debitis. Soluta fugiat aut fugit debitis quo deserunt saepe id. Incidunt autem dolorem aut aut sed minima consectetur consectetur.", new DateTime(2024, 9, 27, 21, 3, 5, 160, DateTimeKind.Local).AddTicks(1674), new DateTime(2024, 9, 26, 21, 3, 5, 160, DateTimeKind.Local).AddTicks(1672), 4 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 25,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Quam aperiam vitae aliquam expedita natus nam iure quod. Rerum inventore cum ad nihil voluptate. Sed voluptatum dolorem deserunt.", new DateTime(2024, 9, 27, 21, 3, 5, 162, DateTimeKind.Local).AddTicks(3921), new DateTime(2024, 9, 26, 21, 3, 5, 162, DateTimeKind.Local).AddTicks(3891), 9 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 26,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Voluptatem laudantium nesciunt porro saepe autem ea laudantium officiis nam. Fugit voluptatum consequatur facere. Quas doloremque aut aut quaerat quae culpa velit porro veniam.", new DateTime(2024, 9, 27, 21, 3, 5, 162, DateTimeKind.Local).AddTicks(4158), new DateTime(2024, 9, 26, 21, 3, 5, 162, DateTimeKind.Local).AddTicks(4156), 4 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 27,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Voluptatem iusto et cupiditate commodi eveniet quis. Maiores aut tempore. Odio cum qui impedit ex nesciunt sed aspernatur. Fugiat ut sit dolorum dolorem facilis ut quia eos dolor.", new DateTime(2024, 9, 27, 21, 3, 5, 163, DateTimeKind.Local).AddTicks(5002), new DateTime(2024, 9, 26, 21, 3, 5, 163, DateTimeKind.Local).AddTicks(4975), 4 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 28,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Dolores officia aut. Explicabo occaecati ut et. Id sit tempore eos dolorem at et soluta inventore accusamus. Adipisci aut eum eveniet pariatur. Dicta exercitationem explicabo nobis.", new DateTime(2024, 9, 27, 21, 3, 5, 163, DateTimeKind.Local).AddTicks(5224), new DateTime(2024, 9, 26, 21, 3, 5, 163, DateTimeKind.Local).AddTicks(5222), 9 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 29,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Perspiciatis magni ex ipsum. In animi voluptate enim voluptatibus. Assumenda fugit nesciunt vel numquam esse nihil enim quia. Aut voluptatem qui quam adipisci. Commodi soluta totam alias. Voluptates tempore aliquid veritatis aut qui.", new DateTime(2024, 9, 27, 21, 3, 5, 164, DateTimeKind.Local).AddTicks(5871), new DateTime(2024, 9, 26, 21, 3, 5, 164, DateTimeKind.Local).AddTicks(5844) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 30,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "At doloremque vel consequuntur dolorem voluptas quisquam illum officiis. A laboriosam quia voluptates voluptates similique dolore tempore. Et sit ullam doloremque. Molestiae repudiandae ut fugiat delectus hic est consequatur dolores. Eos nihil ipsa unde alias sit.", new DateTime(2024, 9, 27, 21, 3, 5, 164, DateTimeKind.Local).AddTicks(6114), new DateTime(2024, 9, 26, 21, 3, 5, 164, DateTimeKind.Local).AddTicks(6112), 3 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 31,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Et quidem nobis architecto voluptate ut. Sapiente hic ut sed omnis. Et suscipit saepe consequatur excepturi ut et minima quaerat. Ex delectus atque minima accusantium quidem harum ipsam minima.", new DateTime(2024, 9, 27, 21, 3, 5, 165, DateTimeKind.Local).AddTicks(7058), new DateTime(2024, 9, 26, 21, 3, 5, 165, DateTimeKind.Local).AddTicks(7030), 7 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 32,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Eum ex nisi. Omnis optio minima. Qui architecto est et tempora voluptate nobis consequatur pariatur. Aspernatur sint voluptas maxime quo tempora sed pariatur. A vero vel dignissimos exercitationem reiciendis magnam facere non. Excepturi temporibus et et sapiente quod.", new DateTime(2024, 9, 27, 21, 3, 5, 165, DateTimeKind.Local).AddTicks(7310), new DateTime(2024, 9, 26, 21, 3, 5, 165, DateTimeKind.Local).AddTicks(7307), 6 });

            migrationBuilder.UpdateData(
                table: "VisitProcesses",
                keyColumn: "VisitProcessId",
                keyValue: 1,
                columns: new[] { "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { new DateTime(2024, 10, 25, 21, 3, 5, 128, DateTimeKind.Local).AddTicks(1747), new DateTime(2024, 9, 25, 21, 3, 5, 128, DateTimeKind.Local).AddTicks(1711) });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 1,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Gulgowski, Williamson and Littel", new DateTime(2024, 9, 6, 20, 5, 47, 786, DateTimeKind.Unspecified).AddTicks(459), 1, "tyghrsdbe8", "0149291766", true, new DateTime(2024, 9, 6, 20, 5, 47, 786, DateTimeKind.Unspecified).AddTicks(459), "Dusty Ebert" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 2,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Brown, Ebert and Block", new DateTime(2024, 9, 14, 6, 41, 53, 740, DateTimeKind.Unspecified).AddTicks(4875), 1, "yk2nrxhjl6", "0442335366", true, new DateTime(2024, 9, 14, 6, 41, 53, 740, DateTimeKind.Unspecified).AddTicks(4875), "Clarissa Beer" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 3,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Okuneva Inc", new DateTime(2024, 9, 19, 17, 2, 57, 868, DateTimeKind.Unspecified).AddTicks(296), 2, "e1i0vw752q", "0588954920", new DateTime(2024, 9, 19, 17, 2, 57, 868, DateTimeKind.Unspecified).AddTicks(296), "Sterling Weber" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 4,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Leannon LLC", new DateTime(2024, 9, 19, 18, 17, 17, 808, DateTimeKind.Unspecified).AddTicks(9273), 1, "1c9rjdol4u", "0250456062", new DateTime(2024, 9, 19, 18, 17, 17, 808, DateTimeKind.Unspecified).AddTicks(9273), "Jaunita Douglas" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 5,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Herman and Sons", new DateTime(2024, 9, 1, 21, 55, 39, 175, DateTimeKind.Unspecified).AddTicks(839), 2, "0hfmkql55u", "0771976198", new DateTime(2024, 9, 1, 21, 55, 39, 175, DateTimeKind.Unspecified).AddTicks(839), "Elise Sporer" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 6,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Hirthe - Marquardt", new DateTime(2024, 9, 5, 23, 23, 22, 97, DateTimeKind.Unspecified).AddTicks(4218), "k2wt33ue4v", "0685821577", false, new DateTime(2024, 9, 5, 23, 23, 22, 97, DateTimeKind.Unspecified).AddTicks(4218), "Wendy Runte" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 7,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Bechtelar - Stokes", new DateTime(2024, 9, 5, 21, 24, 53, 156, DateTimeKind.Unspecified).AddTicks(6104), "69w78phbux", "0533618354", new DateTime(2024, 9, 5, 21, 24, 53, 156, DateTimeKind.Unspecified).AddTicks(6104), "Ryan Hermiston" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 8,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Stark - Miller", new DateTime(2024, 9, 14, 10, 2, 56, 98, DateTimeKind.Unspecified).AddTicks(1626), "aagjlexv92", "0162175938", new DateTime(2024, 9, 14, 10, 2, 56, 98, DateTimeKind.Unspecified).AddTicks(1626), "Abigayle Zieme" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 9,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Krajcik, Jacobi and Emmerich", new DateTime(2024, 9, 20, 21, 30, 30, 713, DateTimeKind.Unspecified).AddTicks(5275), "b4p6qzmx94", "0583766934", new DateTime(2024, 9, 20, 21, 30, 30, 713, DateTimeKind.Unspecified).AddTicks(5275), "Gianni Volkman" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 10,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Reynolds, Toy and Adams", new DateTime(2024, 9, 19, 22, 50, 48, 735, DateTimeKind.Unspecified).AddTicks(8527), 2, "y8ihw104ow", "0191787215", new DateTime(2024, 9, 19, 22, 50, 48, 735, DateTimeKind.Unspecified).AddTicks(8527), "Jermain O'Hara" });

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 1,
                column: "DateRegister",
                value: new DateTime(2024, 9, 24, 21, 3, 5, 127, DateTimeKind.Local).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 2,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 14, 3, 5, 130, DateTimeKind.Utc).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 3,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 14, 3, 5, 130, DateTimeKind.Utc).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 4,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 14, 3, 5, 130, DateTimeKind.Utc).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 5,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 14, 3, 5, 130, DateTimeKind.Utc).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 6,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 14, 3, 5, 130, DateTimeKind.Utc).AddTicks(6937));
        }
    }
}
