using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecurityGateApv.Infras.Migrations
{
    /// <inheritdoc />
    public partial class SeedData_4 : Migration
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
                values: new object[] { 5, new DateTime(2024, 9, 19, 15, 33, 48, 365, DateTimeKind.Utc).AddTicks(6083), "Phòng Pháp chế", "Et voluptates voluptas excepturi aut quos id id.", new DateTime(2024, 9, 19, 15, 33, 48, 365, DateTimeKind.Utc).AddTicks(6083) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 22, 10, 40, 619, DateTimeKind.Utc).AddTicks(1274), "Phòng Marketing", "Adipisci numquam et dolor autem odio sed autem aut.", new DateTime(2024, 9, 11, 22, 10, 40, 619, DateTimeKind.Utc).AddTicks(1274) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2024, 9, 3, 23, 7, 8, 288, DateTimeKind.Utc).AddTicks(3762), "Phòng Kinh doanh", "Sed voluptas architecto eum aut.", new DateTime(2024, 9, 3, 23, 7, 8, 288, DateTimeKind.Utc).AddTicks(3762) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 4, new DateTime(2024, 9, 19, 3, 31, 1, 334, DateTimeKind.Utc).AddTicks(8492), "Phòng Kế toán", "Optio dolorum quisquam sed.", new DateTime(2024, 9, 19, 3, 31, 1, 334, DateTimeKind.Utc).AddTicks(8492) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 4, new DateTime(2024, 9, 6, 13, 45, 34, 567, DateTimeKind.Utc).AddTicks(1628), "Phòng IT", "Nobis temporibus consequatur.", new DateTime(2024, 9, 6, 13, 45, 34, 567, DateTimeKind.Utc).AddTicks(1628) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 6,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 4, new DateTime(2024, 9, 22, 9, 45, 2, 446, DateTimeKind.Utc).AddTicks(6213), "Phòng Nhân sự", "Consectetur sed aliquam ut.", new DateTime(2024, 9, 22, 9, 45, 2, 446, DateTimeKind.Utc).AddTicks(6213) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 7,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 21, 1, 48, 6, 245, DateTimeKind.Utc).AddTicks(1912), "Phòng Kinh doanh", "Non recusandae fuga qui non.", new DateTime(2024, 9, 21, 1, 48, 6, 245, DateTimeKind.Utc).AddTicks(1912) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 8,
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 2, 15, 49, 13, 978, DateTimeKind.Utc).AddTicks(6457), "Phòng Kinh doanh", "Aut sunt tempore qui.", new DateTime(2024, 9, 2, 15, 49, 13, 978, DateTimeKind.Utc).AddTicks(6457) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 9,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 19, 4, 8, 29, 36, DateTimeKind.Utc).AddTicks(2180), "Phòng R&D", "Rerum dolores quia voluptas officiis.", new DateTime(2024, 9, 19, 4, 8, 29, 36, DateTimeKind.Utc).AddTicks(2180) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 10,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 4, 8, 24, 45, 678, DateTimeKind.Utc).AddTicks(3330), "Phòng Marketing", "Et ducimus porro.", new DateTime(2024, 9, 4, 8, 24, 45, 678, DateTimeKind.Utc).AddTicks(3330) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProcessId",
                keyValue: 1,
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 24, 3, 36, 14, 614, DateTimeKind.Utc).AddTicks(5635), "Generic Plastic Car", true });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProcessId",
                keyValue: 2,
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 24, 3, 36, 14, 614, DateTimeKind.Utc).AddTicks(7186), "Licensed Frozen Chair", false });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProcessId",
                keyValue: 3,
                columns: new[] { "CreateTime", "ProcessName" },
                values: new object[] { new DateTime(2024, 9, 24, 3, 36, 14, 614, DateTimeKind.Utc).AddTicks(7215), "Gorgeous Rubber Chair" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProcessId",
                keyValue: 4,
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 24, 3, 36, 14, 614, DateTimeKind.Utc).AddTicks(7234), "Handcrafted Granite Pants", true });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProcessId",
                keyValue: 5,
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 24, 3, 36, 14, 614, DateTimeKind.Utc).AddTicks(7252), "Tasty Wooden Bacon", true });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 1,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId", "QRCardTypeId" },
                values: new object[] { new Guid("feaacadb-65a1-4a35-b17b-f146d438fab0"), new DateTime(2024, 9, 26, 10, 36, 14, 641, DateTimeKind.Local).AddTicks(3431), new DateTime(2024, 10, 26, 10, 36, 14, 641, DateTimeKind.Local).AddTicks(3431), 2, 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 2,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId" },
                values: new object[] { new Guid("fd777383-becc-48f9-9437-99febbecf6fb"), new DateTime(2024, 9, 26, 10, 36, 14, 641, DateTimeKind.Local).AddTicks(3617), new DateTime(2024, 10, 26, 10, 36, 14, 641, DateTimeKind.Local).AddTicks(3617), 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 3,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("e5d71f51-f97b-4bfa-beeb-8c867b1495e0"), new DateTime(2024, 9, 26, 10, 36, 14, 641, DateTimeKind.Local).AddTicks(3630), new DateTime(2024, 10, 26, 10, 36, 14, 641, DateTimeKind.Local).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 4,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardTypeId" },
                values: new object[] { new Guid("d96b058e-e1c5-48db-b8b8-07d8a298c2bd"), new DateTime(2024, 9, 26, 10, 36, 14, 641, DateTimeKind.Local).AddTicks(3638), new DateTime(2024, 10, 26, 10, 36, 14, 641, DateTimeKind.Local).AddTicks(3638), 1 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 5,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("308c525e-1b37-4457-ae0a-a1e2afc44486"), new DateTime(2024, 9, 26, 10, 36, 14, 641, DateTimeKind.Local).AddTicks(3654), new DateTime(2024, 10, 26, 10, 36, 14, 641, DateTimeKind.Local).AddTicks(3654) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 6,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardTypeId" },
                values: new object[] { new Guid("95da113a-fa97-445f-986e-0b6c8b68db14"), new DateTime(2024, 9, 26, 10, 36, 14, 641, DateTimeKind.Local).AddTicks(3661), new DateTime(2024, 10, 26, 10, 36, 14, 641, DateTimeKind.Local).AddTicks(3661), 1 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 7,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId", "QRCardTypeId" },
                values: new object[] { new Guid("98c2abbf-3cf5-4bb9-8ef5-1bc440c9f629"), new DateTime(2024, 9, 26, 10, 36, 14, 641, DateTimeKind.Local).AddTicks(3668), new DateTime(2024, 10, 26, 10, 36, 14, 641, DateTimeKind.Local).AddTicks(3668), 2, 1 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 8,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardTypeId" },
                values: new object[] { new Guid("acdc2de7-a9ff-4425-9660-e6bf297d6685"), new DateTime(2024, 9, 26, 10, 36, 14, 641, DateTimeKind.Local).AddTicks(3674), new DateTime(2024, 10, 26, 10, 36, 14, 641, DateTimeKind.Local).AddTicks(3674), 1 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 9,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId", "QRCardTypeId" },
                values: new object[] { new Guid("e9f8d3c0-0297-4c38-b1e8-bf216ce65dbd"), new DateTime(2024, 9, 26, 10, 36, 14, 641, DateTimeKind.Local).AddTicks(3681), new DateTime(2024, 10, 26, 10, 36, 14, 641, DateTimeKind.Local).AddTicks(3681), 2, 1 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 10,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId" },
                values: new object[] { new Guid("12a11578-e955-4586-9e91-d9da6b37c6db"), new DateTime(2024, 9, 26, 10, 36, 14, 641, DateTimeKind.Local).AddTicks(3690), new DateTime(2024, 10, 26, 10, 36, 14, 641, DateTimeKind.Local).AddTicks(3690), 1 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 4,
                column: "DepartmentId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 5,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 19 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 6,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 6 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 7,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 4, 12 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 8,
                column: "UserId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 9,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 7 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 10,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 21 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 11,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 5, 11 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 12,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 14 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 13,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 1, 17 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 14,
                column: "UserId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 15,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 5, 20 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 16,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 4, 24 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 17,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 17 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 18,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 21 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 19,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 16 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 20,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 22 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 21,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 1, 16 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 22,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 4, 7 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 23,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 10, 10 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 3, 36, 14, 599, DateTimeKind.Utc).AddTicks(1839), new DateTime(2024, 9, 26, 3, 36, 14, 599, DateTimeKind.Utc).AddTicks(1846) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 26, 3, 36, 14, 599, DateTimeKind.Utc).AddTicks(1848), new DateTime(2024, 9, 26, 3, 36, 14, 599, DateTimeKind.Utc).AddTicks(1849) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 26, 3, 36, 14, 599, DateTimeKind.Utc).AddTicks(1851), new DateTime(2024, 9, 26, 3, 36, 14, 599, DateTimeKind.Utc).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 3, 36, 14, 599, DateTimeKind.Utc).AddTicks(1853), new DateTime(2024, 9, 26, 3, 36, 14, 599, DateTimeKind.Utc).AddTicks(1853) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 26, 3, 36, 14, 599, DateTimeKind.Utc).AddTicks(1855), new DateTime(2024, 9, 26, 3, 36, 14, 599, DateTimeKind.Utc).AddTicks(1855) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 20, 1, 26, 7, 842, DateTimeKind.Unspecified).AddTicks(9485), "gmail.com.Leannon@gmail.com", "Damon Ebert", "0d6n16", "0220111683", 2, new DateTime(2024, 9, 20, 1, 26, 7, 842, DateTimeKind.Unspecified).AddTicks(9485), "Mary.Koss" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 7, 1, 10, 39, 306, DateTimeKind.Unspecified).AddTicks(5549), "gmail.com.Legros87@gmail.com", "Ida Mante", "tkouc3", "0431242079", new DateTime(2024, 9, 7, 1, 10, 39, 306, DateTimeKind.Unspecified).AddTicks(5549), "Nona_Volkman" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 7, 2, 55, 57, 227, DateTimeKind.Unspecified).AddTicks(5271), "gmail.com26@yahoo.com", "Christopher Roob", "8ekqlx", "0727010136", new DateTime(2024, 9, 7, 2, 55, 57, 227, DateTimeKind.Unspecified).AddTicks(5271), "Carlotta.Conroy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 19, 15, 9, 25, 635, DateTimeKind.Unspecified).AddTicks(861), "gmail.com64@gmail.com", "Armand Padberg", "t4795k", "0591259712", 1, new DateTime(2024, 9, 19, 15, 9, 25, 635, DateTimeKind.Unspecified).AddTicks(861), "Hassie.Harvey" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 10, 5, 14, 47, 366, DateTimeKind.Unspecified).AddTicks(470), "gmail.com.Cummings@yahoo.com", "Isai Heidenreich", "g6x76h", "0876020354", 3, new DateTime(2024, 9, 10, 5, 14, 47, 366, DateTimeKind.Unspecified).AddTicks(470), "Danyka.Keeling21" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 13, 9, 24, 14, 452, DateTimeKind.Unspecified).AddTicks(8814), "gmail.com_Lemke@gmail.com", "Michaela Bins", "am8uy0", "0100773471", new DateTime(2024, 9, 13, 9, 24, 14, 452, DateTimeKind.Unspecified).AddTicks(8814), "Milford_Wintheiser" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 7, 9, 25, 19, 417, DateTimeKind.Unspecified).AddTicks(9623), "gmail.com.Orn73@hotmail.com", "Alison Emard", "n2u4t3", "0882584535", new DateTime(2024, 9, 7, 9, 25, 19, 417, DateTimeKind.Unspecified).AddTicks(9623), "Hiram72" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 11, 18, 21, 40, 968, DateTimeKind.Unspecified).AddTicks(2518), "gmail.com_Harber@yahoo.com", "Deon Heaney", "6g4o3q", "0368600164", 3, new DateTime(2024, 9, 11, 18, 21, 40, 968, DateTimeKind.Unspecified).AddTicks(2518), "Albin_Lubowitz74" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 2, 19, 6, 10, 137, DateTimeKind.Unspecified).AddTicks(6359), "gmail.com55@gmail.com", "Lola Corkery", "lmbuis", "0277592075", 3, new DateTime(2024, 9, 2, 19, 6, 10, 137, DateTimeKind.Unspecified).AddTicks(6359), "Gregoria26" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 13, 8, 46, 48, 53, DateTimeKind.Unspecified).AddTicks(2016), "gmail.com_Rosenbaum@gmail.com", "Misty Herzog", "c2wb9t", "0371321014", 5, new DateTime(2024, 9, 13, 8, 46, 48, 53, DateTimeKind.Unspecified).AddTicks(2016), "Elliott.Moore36" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 20, 23, 53, 48, 708, DateTimeKind.Unspecified).AddTicks(4937), "gmail.com.Marquardt64@hotmail.com", "Rogelio Shields", "l6mngk", "0382234816", 2, new DateTime(2024, 9, 20, 23, 53, 48, 708, DateTimeKind.Unspecified).AddTicks(4937), "Adelle.Emmerich40" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 25, 9, 40, 49, 613, DateTimeKind.Unspecified).AddTicks(4428), "gmail.com.Dietrich83@gmail.com", "Megane Sauer", "nfnxcg", "0664300065", 4, new DateTime(2024, 9, 25, 9, 40, 49, 613, DateTimeKind.Unspecified).AddTicks(4428), "Daisy19" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 15, 9, 55, 42, 294, DateTimeKind.Unspecified).AddTicks(6341), "gmail.com.Wolff@yahoo.com", "Jaycee Simonis", "aiaoka", "0944507242", new DateTime(2024, 9, 15, 9, 55, 42, 294, DateTimeKind.Unspecified).AddTicks(6341), "Jace.Hudson94" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 13, 15, 55, 7, 97, DateTimeKind.Unspecified).AddTicks(6294), "gmail.com_Bosco96@gmail.com", "Nina Balistreri", "6yvgfg", "0134106991", 5, new DateTime(2024, 9, 13, 15, 55, 7, 97, DateTimeKind.Unspecified).AddTicks(6294), "Reina_Buckridge" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 25, 11, 17, 17, 717, DateTimeKind.Unspecified).AddTicks(345), "gmail.com_OConner4@hotmail.com", "Sonya Rosenbaum", "coeu4x", "0616532121", 1, new DateTime(2024, 9, 25, 11, 17, 17, 717, DateTimeKind.Unspecified).AddTicks(345), "Martin_Rogahn" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 7, 51, 447, DateTimeKind.Unspecified).AddTicks(425), "gmail.com11@hotmail.com", "Haven Moore", "wp0v67", "0602017912", 1, new DateTime(2024, 9, 15, 13, 7, 51, 447, DateTimeKind.Unspecified).AddTicks(425), "Kasey67" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 11, 18, 32, 31, 752, DateTimeKind.Unspecified).AddTicks(5096), "gmail.com.Pouros46@gmail.com", "Anna Rice", "a8wi21", "0200878000", new DateTime(2024, 9, 11, 18, 32, 31, 752, DateTimeKind.Unspecified).AddTicks(5096), "Lyla.Baumbach18" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 21, 9, 13, 33, 274, DateTimeKind.Unspecified).AddTicks(3680), "gmail.com.Stehr@hotmail.com", "Nelson Schimmel", "33mbgf", "0847117786", 4, new DateTime(2024, 9, 21, 9, 13, 33, 274, DateTimeKind.Unspecified).AddTicks(3680), "Davin_Greenfelder" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 5, 19, 50, 2, 213, DateTimeKind.Unspecified).AddTicks(3472), "gmail.com_Schmitt74@yahoo.com", "Ulises Effertz", "5s2etn", "0263798362", 1, new DateTime(2024, 9, 5, 19, 50, 2, 213, DateTimeKind.Unspecified).AddTicks(3472), "Enid.Wunsch59" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 8, 9, 24, 50, 193, DateTimeKind.Unspecified).AddTicks(9319), "gmail.com_Rutherford71@hotmail.com", "Madalyn Nolan", "qs5o3f", "0906601799", new DateTime(2024, 9, 8, 9, 24, 50, 193, DateTimeKind.Unspecified).AddTicks(9319), "Dean_Johnson" });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 1,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Voluptas nesciunt recusandae aspernatur ullam adipisci quia commodi. Amet facere reiciendis. Quia ipsum recusandae incidunt voluptatibus sapiente et. Animi ipsam aut non veniam voluptatibus.", new DateTime(2024, 10, 25, 10, 36, 14, 619, DateTimeKind.Local).AddTicks(8329), new DateTime(2024, 9, 25, 10, 36, 14, 619, DateTimeKind.Local).AddTicks(8289) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 2,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Ex est aut et sed. Nulla dicta aperiam commodi aperiam enim rerum eligendi molestiae molestiae. Itaque officia suscipit impedit assumenda.", new DateTime(2024, 10, 25, 10, 36, 14, 619, DateTimeKind.Local).AddTicks(8745), new DateTime(2024, 9, 25, 10, 36, 14, 619, DateTimeKind.Local).AddTicks(8742) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 3,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "VisitorId" },
                values: new object[] { "Dicta dolor aut dolores. Aspernatur enim consequatur. Optio doloremque officiis iure tempore nihil et dolores blanditiis perferendis. Ea nihil sint et. Totam dolores quia minus enim deleniti repellat minima dignissimos quia. Nulla vitae necessitatibus ut dignissimos vitae autem sed aperiam.", new DateTime(2024, 9, 26, 10, 36, 14, 622, DateTimeKind.Local).AddTicks(1403), new TimeSpan(0, 12, 0, 0, 0), new DateTime(2024, 9, 27, 10, 36, 14, 622, DateTimeKind.Local).AddTicks(1434), new TimeSpan(0, 7, 0, 0, 0), 9 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 4,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "VisitorId" },
                values: new object[] { "Est distinctio repudiandae blanditiis placeat et sit animi totam possimus. Incidunt sint ut aut harum officiis. Non sit corporis sapiente. Esse autem illo. Vel sit quis in voluptatibus incidunt provident.", new DateTime(2024, 9, 26, 10, 36, 14, 622, DateTimeKind.Local).AddTicks(1710), new TimeSpan(0, 12, 0, 0, 0), new DateTime(2024, 9, 27, 10, 36, 14, 622, DateTimeKind.Local).AddTicks(1713), new TimeSpan(0, 7, 0, 0, 0), 6 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 5,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "Status", "VisitorId" },
                values: new object[] { "Voluptatibus est consequatur odio aut. Ipsa aspernatur aut. Id perferendis consequuntur dolorum ipsam delectus magni.", new DateTime(2024, 9, 26, 10, 36, 14, 623, DateTimeKind.Local).AddTicks(2742), new TimeSpan(0, 12, 0, 0, 0), new DateTime(2024, 9, 27, 10, 36, 14, 623, DateTimeKind.Local).AddTicks(2775), new TimeSpan(0, 7, 0, 0, 0), true, 10 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 6,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "Status" },
                values: new object[] { "Perferendis et culpa sunt aperiam sequi molestiae illo. Iste deleniti suscipit. Quibusdam qui qui qui. Non atque accusantium.", new DateTime(2024, 9, 26, 10, 36, 14, 623, DateTimeKind.Local).AddTicks(2982), new TimeSpan(0, 12, 0, 0, 0), new DateTime(2024, 9, 27, 10, 36, 14, 623, DateTimeKind.Local).AddTicks(2984), new TimeSpan(0, 7, 0, 0, 0), true });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 7,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "VisitorId" },
                values: new object[] { "Aliquid ut vel quia ut. Eum eum aut quisquam libero consequatur quis dolorem vel debitis. Sapiente quo a. Rerum non provident debitis in enim.", new DateTime(2024, 9, 26, 10, 36, 14, 624, DateTimeKind.Local).AddTicks(3874), new TimeSpan(0, 12, 0, 0, 0), new DateTime(2024, 9, 27, 10, 36, 14, 624, DateTimeKind.Local).AddTicks(3899), new TimeSpan(0, 7, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 8,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "Status" },
                values: new object[] { "Deserunt quasi atque consequatur voluptatibus et tenetur. Accusamus eum eveniet. Quam quae sint eveniet perferendis odio reiciendis. Explicabo soluta quis eveniet repudiandae explicabo tenetur vel laborum similique.", new DateTime(2024, 9, 26, 10, 36, 14, 624, DateTimeKind.Local).AddTicks(4190), new TimeSpan(0, 12, 0, 0, 0), new DateTime(2024, 9, 27, 10, 36, 14, 624, DateTimeKind.Local).AddTicks(4192), new TimeSpan(0, 7, 0, 0, 0), true });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 9,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "VisitorId" },
                values: new object[] { "A voluptas voluptatum deserunt sequi cupiditate explicabo. Nobis quisquam ut hic similique fuga nulla vitae inventore error. Vel quibusdam adipisci voluptas facilis quia nesciunt non et qui. Illo molestiae enim voluptatem molestias quisquam et non dolor dolores. Quasi commodi dolor non aperiam similique laudantium nulla temporibus reiciendis.", new DateTime(2024, 9, 26, 10, 36, 14, 625, DateTimeKind.Local).AddTicks(4758), new TimeSpan(0, 12, 0, 0, 0), new DateTime(2024, 9, 27, 10, 36, 14, 625, DateTimeKind.Local).AddTicks(4782), new TimeSpan(0, 7, 0, 0, 0), 10 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 10,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "VisitorId" },
                values: new object[] { "Aliquam ut sit excepturi. Harum numquam eum rerum dolorem cum nihil delectus accusamus. Ex omnis non. Qui dolorem molestiae culpa et at. Rerum repellat consequatur repellat et distinctio sed. Dolorem repudiandae nam voluptatem nihil.", new DateTime(2024, 9, 26, 10, 36, 14, 625, DateTimeKind.Local).AddTicks(5031), new TimeSpan(0, 12, 0, 0, 0), new DateTime(2024, 9, 27, 10, 36, 14, 625, DateTimeKind.Local).AddTicks(5033), new TimeSpan(0, 7, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 11,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "VisitorId" },
                values: new object[] { "Vel quisquam ut modi ut officia unde sapiente eius architecto. Distinctio ut expedita cupiditate nostrum alias perspiciatis. Architecto esse ullam impedit. Voluptatem quam sapiente quae.", new DateTime(2024, 9, 26, 10, 36, 14, 626, DateTimeKind.Local).AddTicks(6010), new TimeSpan(0, 12, 0, 0, 0), new DateTime(2024, 9, 27, 10, 36, 14, 626, DateTimeKind.Local).AddTicks(6037), new TimeSpan(0, 7, 0, 0, 0), 9 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 12,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "Status", "VisitorId" },
                values: new object[] { "Perferendis debitis ea animi est ut. Eos dolores doloribus eveniet esse consequatur suscipit. Ipsum incidunt ea aut. Rem voluptas ad aut.", new DateTime(2024, 9, 26, 10, 36, 14, 626, DateTimeKind.Local).AddTicks(6261), new TimeSpan(0, 12, 0, 0, 0), new DateTime(2024, 9, 27, 10, 36, 14, 626, DateTimeKind.Local).AddTicks(6264), new TimeSpan(0, 7, 0, 0, 0), true, 7 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 13,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "Status", "VisitorId" },
                values: new object[] { "Eos voluptas quia totam ut. Doloribus vitae velit ut facilis consequatur itaque. Dolores unde tenetur doloribus labore.", new DateTime(2024, 9, 26, 10, 36, 14, 629, DateTimeKind.Local).AddTicks(2197), new TimeSpan(0, 12, 0, 0, 0), new DateTime(2024, 9, 27, 10, 36, 14, 629, DateTimeKind.Local).AddTicks(2225), new TimeSpan(0, 7, 0, 0, 0), true, 10 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 14,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "VisitorId" },
                values: new object[] { "Exercitationem non ex maiores sint maiores ipsum omnis earum. Magni quas natus et quos. Maxime unde inventore dolor atque est impedit sit ut. Est facere ab facilis possimus.", new DateTime(2024, 9, 26, 10, 36, 14, 629, DateTimeKind.Local).AddTicks(2473), new TimeSpan(0, 12, 0, 0, 0), new DateTime(2024, 9, 27, 10, 36, 14, 629, DateTimeKind.Local).AddTicks(2475), new TimeSpan(0, 7, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 15,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "VisitorId" },
                values: new object[] { "Illo molestiae maiores facilis earum voluptatem a enim. Nemo ratione mollitia ipsum aliquid ullam nihil iusto. Aut mollitia deleniti enim sit expedita accusamus. Consequatur ad et pariatur esse illo sint itaque.", new DateTime(2024, 9, 26, 10, 36, 14, 630, DateTimeKind.Local).AddTicks(3640), new TimeSpan(0, 12, 0, 0, 0), new DateTime(2024, 9, 27, 10, 36, 14, 630, DateTimeKind.Local).AddTicks(3667), new TimeSpan(0, 7, 0, 0, 0), 9 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 16,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "VisitorId" },
                values: new object[] { "Assumenda necessitatibus fugiat laboriosam quaerat ad rerum nesciunt. Magnam velit sint. Sed placeat voluptatem tempora quidem dolorem aut beatae quo architecto. Non cum sed magnam eos.", new DateTime(2024, 9, 26, 10, 36, 14, 630, DateTimeKind.Local).AddTicks(3890), new TimeSpan(0, 12, 0, 0, 0), new DateTime(2024, 9, 27, 10, 36, 14, 630, DateTimeKind.Local).AddTicks(3892), new TimeSpan(0, 7, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 17,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "VisitorId" },
                values: new object[] { "Voluptatibus id voluptatem perspiciatis laudantium ut qui accusantium vel. Aperiam tempora harum earum. Ducimus occaecati et est accusamus ad aut eligendi eaque iure. Nisi est suscipit alias reiciendis assumenda quis. Illum repudiandae quam nihil molestias explicabo. A vel cumque sit aut quia quia eos.", new DateTime(2024, 9, 26, 10, 36, 14, 631, DateTimeKind.Local).AddTicks(4578), new TimeSpan(0, 12, 0, 0, 0), new DateTime(2024, 9, 27, 10, 36, 14, 631, DateTimeKind.Local).AddTicks(4668), new TimeSpan(0, 7, 0, 0, 0), 9 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 18,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "Status", "VisitorId" },
                values: new object[] { "Voluptatem dolore iste. Repudiandae mollitia aut nihil ut quidem nam autem. Soluta eos non eligendi sed corporis ut id id. Est harum qui harum sint consequatur harum numquam qui ratione.", new DateTime(2024, 9, 26, 10, 36, 14, 631, DateTimeKind.Local).AddTicks(4903), new TimeSpan(0, 12, 0, 0, 0), new DateTime(2024, 9, 27, 10, 36, 14, 631, DateTimeKind.Local).AddTicks(4906), new TimeSpan(0, 7, 0, 0, 0), true, 1 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 19,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "VisitorId" },
                values: new object[] { "Facere ut saepe modi dicta ea fugit sit. Error et dolores sunt pariatur. Totam alias recusandae labore minima excepturi molestiae atque optio.", new DateTime(2024, 9, 26, 10, 36, 14, 632, DateTimeKind.Local).AddTicks(5746), new TimeSpan(0, 12, 0, 0, 0), new DateTime(2024, 9, 27, 10, 36, 14, 632, DateTimeKind.Local).AddTicks(5772), new TimeSpan(0, 7, 0, 0, 0), 5 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 20,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "VisitorId" },
                values: new object[] { "Et ut vel repellendus quia sunt voluptatem. At doloribus a. Est id molestiae ducimus aut. Voluptas nihil veniam aliquam. Iure qui sit veniam at sunt sit fuga.", new DateTime(2024, 9, 26, 10, 36, 14, 632, DateTimeKind.Local).AddTicks(6003), new TimeSpan(0, 12, 0, 0, 0), new DateTime(2024, 9, 27, 10, 36, 14, 632, DateTimeKind.Local).AddTicks(6005), new TimeSpan(0, 7, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 21,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "Status", "VisitorId" },
                values: new object[] { "Sint ullam placeat. Et sed nulla nisi placeat totam quidem. Quod aut facilis ipsa rerum culpa distinctio voluptate repellendus perspiciatis. Harum doloribus vel dicta soluta est iure molestiae reiciendis cupiditate. Quaerat nemo id excepturi dignissimos autem quasi ut odit deleniti.", new DateTime(2024, 9, 26, 10, 36, 14, 633, DateTimeKind.Local).AddTicks(6667), new TimeSpan(0, 12, 0, 0, 0), new DateTime(2024, 9, 27, 10, 36, 14, 633, DateTimeKind.Local).AddTicks(6692), new TimeSpan(0, 7, 0, 0, 0), true, 2 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 22,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "VisitorId" },
                values: new object[] { "Quasi non rerum ut in vel ipsa eos. Unde provident error amet. Nesciunt ut explicabo. Voluptas rerum sequi in harum aperiam.", new DateTime(2024, 9, 26, 10, 36, 14, 633, DateTimeKind.Local).AddTicks(6906), new TimeSpan(0, 12, 0, 0, 0), new DateTime(2024, 9, 27, 10, 36, 14, 633, DateTimeKind.Local).AddTicks(6909), new TimeSpan(0, 7, 0, 0, 0), 6 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 23,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "VisitorId" },
                values: new object[] { "Aut porro officia quo eos. Fugiat quidem quam repudiandae saepe consequuntur quia vero recusandae. Sunt laudantium repudiandae reiciendis architecto.", new DateTime(2024, 9, 26, 10, 36, 14, 634, DateTimeKind.Local).AddTicks(8917), new TimeSpan(0, 12, 0, 0, 0), new DateTime(2024, 9, 27, 10, 36, 14, 634, DateTimeKind.Local).AddTicks(8942), new TimeSpan(0, 7, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 24,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "VisitorId" },
                values: new object[] { "Deleniti beatae praesentium sed rerum quisquam quia fugit velit maiores. Ad mollitia consequatur perferendis assumenda et laborum dolore aut. Atque architecto fugit qui laboriosam vero. Enim aperiam blanditiis accusamus voluptates dolores vero culpa. Id est numquam aut nisi minima eaque sit atque.", new DateTime(2024, 9, 26, 10, 36, 14, 634, DateTimeKind.Local).AddTicks(9209), new TimeSpan(0, 12, 0, 0, 0), new DateTime(2024, 9, 27, 10, 36, 14, 634, DateTimeKind.Local).AddTicks(9211), new TimeSpan(0, 7, 0, 0, 0), 7 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 25,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "Status", "VisitorId" },
                values: new object[] { "Totam impedit placeat cupiditate delectus nihil nesciunt. Ut non aut inventore nulla odio accusamus in. Inventore voluptas dicta earum quisquam asperiores et sit ducimus sit. Consectetur inventore distinctio perspiciatis nisi rerum. Enim eum odio ipsam fuga consectetur et dolores et.", new DateTime(2024, 9, 26, 10, 36, 14, 636, DateTimeKind.Local).AddTicks(152), new TimeSpan(0, 12, 0, 0, 0), new DateTime(2024, 9, 27, 10, 36, 14, 636, DateTimeKind.Local).AddTicks(177), new TimeSpan(0, 7, 0, 0, 0), true, 7 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 26,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "Status", "VisitorId" },
                values: new object[] { "Aut ipsum repellat iste. Nesciunt hic nobis et non recusandae ut. Voluptate hic omnis aut et qui. Tempore veritatis aut et dolorem repellendus velit aliquid molestias impedit. Culpa nostrum enim et.", new DateTime(2024, 9, 26, 10, 36, 14, 636, DateTimeKind.Local).AddTicks(416), new TimeSpan(0, 12, 0, 0, 0), new DateTime(2024, 9, 27, 10, 36, 14, 636, DateTimeKind.Local).AddTicks(418), new TimeSpan(0, 7, 0, 0, 0), true, 9 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 27,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "Status", "VisitorId" },
                values: new object[] { "Eos sunt architecto ut quas ea omnis. Et unde dolorem perferendis ut. Magni ea saepe minima assumenda officiis.", new DateTime(2024, 9, 26, 10, 36, 14, 637, DateTimeKind.Local).AddTicks(908), new TimeSpan(0, 12, 0, 0, 0), new DateTime(2024, 9, 27, 10, 36, 14, 637, DateTimeKind.Local).AddTicks(932), new TimeSpan(0, 7, 0, 0, 0), true, 7 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 28,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "Status", "VisitorId" },
                values: new object[] { "Modi quam unde autem hic. Maxime aut iure sit incidunt totam. Magni velit reiciendis ea perferendis eos qui eos.", new DateTime(2024, 9, 26, 10, 36, 14, 637, DateTimeKind.Local).AddTicks(1133), new TimeSpan(0, 12, 0, 0, 0), new DateTime(2024, 9, 27, 10, 36, 14, 637, DateTimeKind.Local).AddTicks(1135), new TimeSpan(0, 7, 0, 0, 0), true, 6 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 29,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "VisitorId" },
                values: new object[] { "Consequatur in rerum deleniti ab. Dolores suscipit dicta mollitia eum neque minima autem. Fugiat temporibus non. Est neque culpa dolorem repellat. Aliquam et voluptate est. Est distinctio natus aliquam voluptatem quos esse a ullam.", new DateTime(2024, 9, 26, 10, 36, 14, 638, DateTimeKind.Local).AddTicks(9886), new TimeSpan(0, 12, 0, 0, 0), new DateTime(2024, 9, 27, 10, 36, 14, 638, DateTimeKind.Local).AddTicks(9918), new TimeSpan(0, 7, 0, 0, 0), 9 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 30,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "Status", "VisitorId" },
                values: new object[] { "Dolorem illum recusandae eius delectus hic quisquam architecto. Rerum veritatis dicta odit minus dolor est unde iste voluptatem. Aspernatur occaecati dolorem animi voluptates qui dignissimos labore ullam rerum. Libero ipsa aut natus adipisci expedita occaecati. Modi officiis id sint aut molestiae. Sit mollitia eaque quas officia.", new DateTime(2024, 9, 26, 10, 36, 14, 639, DateTimeKind.Local).AddTicks(199), new TimeSpan(0, 12, 0, 0, 0), new DateTime(2024, 9, 27, 10, 36, 14, 639, DateTimeKind.Local).AddTicks(202), new TimeSpan(0, 7, 0, 0, 0), true, 4 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 31,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "VisitorId" },
                values: new object[] { "Tempora porro debitis libero odio. Rerum sint aliquam et et explicabo occaecati exercitationem debitis sint. Itaque perspiciatis autem necessitatibus et. Qui minus nisi qui ad quia. Aliquid numquam aut voluptas et. Minima aliquid magnam aut quaerat laborum numquam error id est.", new DateTime(2024, 9, 26, 10, 36, 14, 640, DateTimeKind.Local).AddTicks(1381), new TimeSpan(0, 12, 0, 0, 0), new DateTime(2024, 9, 27, 10, 36, 14, 640, DateTimeKind.Local).AddTicks(1412), new TimeSpan(0, 7, 0, 0, 0), 8 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 32,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "Status", "VisitorId" },
                values: new object[] { "Officia et nulla dolores. Tenetur eum necessitatibus quasi a aut. Hic sint quisquam corporis tempore ipsum eos fuga incidunt voluptatum. Sint quam tempora minima voluptas saepe qui facilis recusandae ipsa. Facere vitae dolores aut aut est a nobis.", new DateTime(2024, 9, 26, 10, 36, 14, 640, DateTimeKind.Local).AddTicks(1656), new TimeSpan(0, 12, 0, 0, 0), new DateTime(2024, 9, 27, 10, 36, 14, 640, DateTimeKind.Local).AddTicks(1658), new TimeSpan(0, 7, 0, 0, 0), true, 4 });

            migrationBuilder.UpdateData(
                table: "VisitProjects",
                keyColumn: "VisitProcessId",
                keyValue: 1,
                columns: new[] { "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { new DateTime(2024, 10, 25, 10, 36, 14, 616, DateTimeKind.Local).AddTicks(9174), new DateTime(2024, 9, 25, 10, 36, 14, 616, DateTimeKind.Local).AddTicks(9141) });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 1,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Gulgowski Inc", new DateTime(2024, 9, 3, 20, 9, 23, 379, DateTimeKind.Unspecified).AddTicks(4679), 2, "mwpj1y4k4u", "0234171487", new DateTime(2024, 9, 3, 20, 9, 23, 379, DateTimeKind.Unspecified).AddTicks(4679), "Gregorio Lemke" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 2,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Stehr, Kassulke and Johnston", new DateTime(2024, 9, 21, 9, 29, 51, 717, DateTimeKind.Unspecified).AddTicks(8134), "u21rsr7xm2", "0247807559", false, new DateTime(2024, 9, 21, 9, 29, 51, 717, DateTimeKind.Unspecified).AddTicks(8134), "Orin Mayer" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 3,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Reinger - Nolan", new DateTime(2024, 9, 17, 7, 42, 31, 145, DateTimeKind.Unspecified).AddTicks(9170), 1, "oej2t31v91", "0739218090", false, new DateTime(2024, 9, 17, 7, 42, 31, 145, DateTimeKind.Unspecified).AddTicks(9170), "Raphael Boyle" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 4,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Douglas - Terry", new DateTime(2024, 9, 8, 11, 54, 43, 8, DateTimeKind.Unspecified).AddTicks(3209), 1, "tm81p79jvk", "0589188705", true, new DateTime(2024, 9, 8, 11, 54, 43, 8, DateTimeKind.Unspecified).AddTicks(3209), "Cali Schiller" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 5,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Mosciski LLC", new DateTime(2024, 9, 21, 23, 33, 3, 593, DateTimeKind.Unspecified).AddTicks(8317), "ii30iazfve", "0323981932", new DateTime(2024, 9, 21, 23, 33, 3, 593, DateTimeKind.Unspecified).AddTicks(8317), "Estrella McDermott" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 6,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Sanford Group", new DateTime(2024, 9, 20, 17, 7, 6, 624, DateTimeKind.Unspecified).AddTicks(4674), 1, "r62r5x4jpf", "0633675726", new DateTime(2024, 9, 20, 17, 7, 6, 624, DateTimeKind.Unspecified).AddTicks(4674), "Anabelle Beahan" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 7,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Dooley - Stark", new DateTime(2024, 9, 21, 18, 26, 32, 714, DateTimeKind.Unspecified).AddTicks(3336), 2, "877vmja2k0", "0358068131", new DateTime(2024, 9, 21, 18, 26, 32, 714, DateTimeKind.Unspecified).AddTicks(3336), "Rachael Kovacek" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 8,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Medhurst Inc", new DateTime(2024, 9, 6, 3, 48, 43, 839, DateTimeKind.Unspecified).AddTicks(2299), 2, "am5xpvhymz", "0283136949", false, new DateTime(2024, 9, 6, 3, 48, 43, 839, DateTimeKind.Unspecified).AddTicks(2299), "Dagmar Doyle" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 9,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Altenwerth, Deckow and Will", new DateTime(2024, 9, 13, 0, 53, 20, 848, DateTimeKind.Unspecified).AddTicks(5313), "jwpsm07yo7", "0696546225", new DateTime(2024, 9, 13, 0, 53, 20, 848, DateTimeKind.Unspecified).AddTicks(5313), "Sylvia Schuppe" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 10,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Greenholt - Weimann", new DateTime(2024, 9, 15, 1, 16, 30, 551, DateTimeKind.Unspecified).AddTicks(4884), 1, "d5xvd2qs4w", "0690427093", true, new DateTime(2024, 9, 15, 1, 16, 30, 551, DateTimeKind.Unspecified).AddTicks(4884), "Ladarius Boyle" });

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 1,
                column: "DateRegister",
                value: new DateTime(2024, 9, 24, 10, 36, 14, 615, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 2,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 3, 36, 14, 620, DateTimeKind.Utc).AddTicks(9689));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 3,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 3, 36, 14, 620, DateTimeKind.Utc).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 4,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 3, 36, 14, 620, DateTimeKind.Utc).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 5,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 3, 36, 14, 620, DateTimeKind.Utc).AddTicks(9866));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 6,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 3, 36, 14, 620, DateTimeKind.Utc).AddTicks(9874));
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
                values: new object[] { 3, new DateTime(2024, 9, 17, 15, 14, 47, 762, DateTimeKind.Utc).AddTicks(4917), "Phòng Hành chính", "Inventore voluptas placeat sed assumenda.", new DateTime(2024, 9, 17, 15, 14, 47, 762, DateTimeKind.Utc).AddTicks(4917) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 7, 51, 27, 677, DateTimeKind.Utc).AddTicks(3287), "Phòng Kế toán", "Ut sint sed cum nulla similique voluptate.", new DateTime(2024, 9, 11, 7, 51, 27, 677, DateTimeKind.Utc).AddTicks(3287) });

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
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 9, 9, 3, 15, 33, 667, DateTimeKind.Utc).AddTicks(2213), "Phòng R&D", "Quis accusantium sapiente suscipit explicabo eaque omnis error.", new DateTime(2024, 9, 9, 3, 15, 33, 667, DateTimeKind.Utc).AddTicks(2213) });

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
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 24, 3, 33, 39, 747, DateTimeKind.Utc).AddTicks(799), "Ergonomic Soft Bike", true });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProcessId",
                keyValue: 3,
                columns: new[] { "CreateTime", "ProcessName" },
                values: new object[] { new DateTime(2024, 9, 24, 3, 33, 39, 747, DateTimeKind.Utc).AddTicks(829), "Ergonomic Wooden Chicken" });

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
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 24, 3, 33, 39, 747, DateTimeKind.Utc).AddTicks(864), "Gorgeous Wooden Gloves", false });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 1,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId", "QRCardTypeId" },
                values: new object[] { new Guid("c7d91ce2-5454-474f-99b6-4fefc9306987"), new DateTime(2024, 9, 26, 10, 33, 39, 782, DateTimeKind.Local).AddTicks(9765), new DateTime(2024, 10, 26, 10, 33, 39, 782, DateTimeKind.Local).AddTicks(9765), 1, 1 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 2,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId" },
                values: new object[] { new Guid("d7d70999-9e5f-4e97-8582-d308845325eb"), new DateTime(2024, 9, 26, 10, 33, 39, 782, DateTimeKind.Local).AddTicks(9965), new DateTime(2024, 10, 26, 10, 33, 39, 782, DateTimeKind.Local).AddTicks(9965), 1 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 3,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("c1361f13-99f3-4ef0-98f0-2c660db49469"), new DateTime(2024, 9, 26, 10, 33, 39, 782, DateTimeKind.Local).AddTicks(9976), new DateTime(2024, 10, 26, 10, 33, 39, 782, DateTimeKind.Local).AddTicks(9976) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 4,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardTypeId" },
                values: new object[] { new Guid("f7e74be1-410b-4619-bbbf-f94b512a34cf"), new DateTime(2024, 9, 26, 10, 33, 39, 782, DateTimeKind.Local).AddTicks(9983), new DateTime(2024, 10, 26, 10, 33, 39, 782, DateTimeKind.Local).AddTicks(9983), 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 5,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("00598625-25c4-44be-be93-ce74279a8330"), new DateTime(2024, 9, 26, 10, 33, 39, 782, DateTimeKind.Local).AddTicks(9990), new DateTime(2024, 10, 26, 10, 33, 39, 782, DateTimeKind.Local).AddTicks(9990) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 6,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardTypeId" },
                values: new object[] { new Guid("8411d285-9b76-4287-9abf-9e27dd8c843d"), new DateTime(2024, 9, 26, 10, 33, 39, 782, DateTimeKind.Local).AddTicks(9996), new DateTime(2024, 10, 26, 10, 33, 39, 782, DateTimeKind.Local).AddTicks(9996), 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 7,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId", "QRCardTypeId" },
                values: new object[] { new Guid("02f6b50a-6b12-4c3e-89ec-74319c121ecc"), new DateTime(2024, 9, 26, 10, 33, 39, 783, DateTimeKind.Local).AddTicks(2), new DateTime(2024, 10, 26, 10, 33, 39, 783, DateTimeKind.Local).AddTicks(2), 1, 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 8,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardTypeId" },
                values: new object[] { new Guid("820657b7-471d-4446-b1f5-61c5509aa92e"), new DateTime(2024, 9, 26, 10, 33, 39, 783, DateTimeKind.Local).AddTicks(21), new DateTime(2024, 10, 26, 10, 33, 39, 783, DateTimeKind.Local).AddTicks(21), 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 9,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId", "QRCardTypeId" },
                values: new object[] { new Guid("3ba9dca5-f5c6-4fff-84e8-ae1d76e431e4"), new DateTime(2024, 9, 26, 10, 33, 39, 783, DateTimeKind.Local).AddTicks(36), new DateTime(2024, 10, 26, 10, 33, 39, 783, DateTimeKind.Local).AddTicks(36), 1, 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 10,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId" },
                values: new object[] { new Guid("f9eb3fb1-e0e5-46af-96a0-a02e3cdfc97f"), new DateTime(2024, 9, 26, 10, 33, 39, 783, DateTimeKind.Local).AddTicks(43), new DateTime(2024, 10, 26, 10, 33, 39, 783, DateTimeKind.Local).AddTicks(43), 2 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 4,
                column: "DepartmentId",
                value: 5);

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
                column: "UserId",
                value: 9);

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
                column: "UserId",
                value: 8);

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 14, 7, 24, 45, 213, DateTimeKind.Unspecified).AddTicks(689), "gmail.com.Braun@hotmail.com", "Damian Lehner", "yh37m1", "0457631742", new DateTime(2024, 9, 14, 7, 24, 45, 213, DateTimeKind.Unspecified).AddTicks(689), "Macie_Pfannerstill43" });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 2, 3, 7, 45, 401, DateTimeKind.Unspecified).AddTicks(5097), "gmail.com_Ullrich@gmail.com", "Holden Williamson", "69ylw2", "0699063021", new DateTime(2024, 9, 2, 3, 7, 45, 401, DateTimeKind.Unspecified).AddTicks(5097), "Micheal.Toy" });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 1, 48, 651, DateTimeKind.Unspecified).AddTicks(3715), "gmail.com.Dach@gmail.com", "Kiley Leffler", "58zo8x", "0479382672", new DateTime(2024, 9, 1, 14, 1, 48, 651, DateTimeKind.Unspecified).AddTicks(3715), "Owen_Lockman46" });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 4, 8, 53, 11, 347, DateTimeKind.Unspecified).AddTicks(9523), "gmail.com7@hotmail.com", "Brianne Barton", "p2qq8l", "0701253582", 4, new DateTime(2024, 9, 4, 8, 53, 11, 347, DateTimeKind.Unspecified).AddTicks(9523), "Bryana36" });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 25, 8, 52, 3, 822, DateTimeKind.Unspecified).AddTicks(8271), "gmail.com.Schiller@hotmail.com", "Jannie Kshlerin", "rkvg0w", "0917218440", new DateTime(2024, 9, 25, 8, 52, 3, 822, DateTimeKind.Unspecified).AddTicks(8271), "Jaydon.Schiller" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 5, 9, 9, 44, 342, DateTimeKind.Unspecified).AddTicks(8392), "gmail.com22@yahoo.com", "Jerald Terry", "x7wdm6", "0495002427", 1, new DateTime(2024, 9, 5, 9, 9, 44, 342, DateTimeKind.Unspecified).AddTicks(8392), "Lula.DAmore95" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 24, 1, 35, 23, 117, DateTimeKind.Unspecified).AddTicks(7025), "gmail.com.Cruickshank9@gmail.com", "Maurice Grady", "h0h3f2", "0316855727", 3, new DateTime(2024, 9, 24, 1, 35, 23, 117, DateTimeKind.Unspecified).AddTicks(7025), "Luz.OConnell" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 29, 5, 122, DateTimeKind.Unspecified).AddTicks(163), "gmail.com91@gmail.com", "Mavis Veum", "dgbapa", "0725773473", new DateTime(2024, 9, 5, 15, 29, 5, 122, DateTimeKind.Unspecified).AddTicks(163), "Addison.Bergnaum71" });

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
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 3,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "VisitorId" },
                values: new object[] { "Qui magnam quidem atque aliquam mollitia velit non est adipisci. Velit autem accusamus voluptas. Sed tenetur inventore optio necessitatibus modi enim.", new DateTime(2024, 9, 26, 10, 33, 39, 762, DateTimeKind.Local).AddTicks(2095), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 762, DateTimeKind.Local).AddTicks(2126), new TimeSpan(0, 0, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 4,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "VisitorId" },
                values: new object[] { "Quia nam impedit recusandae natus explicabo. Voluptas dolore laudantium ut et vel sed. Id odit et voluptatem similique tempore id explicabo placeat. Ipsa sit reiciendis et quos cum omnis corrupti dolores officia. Odit cumque minus rem nesciunt quisquam quas.", new DateTime(2024, 9, 26, 10, 33, 39, 762, DateTimeKind.Local).AddTicks(2382), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 762, DateTimeKind.Local).AddTicks(2385), new TimeSpan(0, 0, 0, 0, 0), 8 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 5,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "Status", "VisitorId" },
                values: new object[] { "Deserunt quis dolorem est dolor voluptas quaerat. Aut ut quaerat non. Quam ducimus dolores nisi tempora aliquid.", new DateTime(2024, 9, 26, 10, 33, 39, 763, DateTimeKind.Local).AddTicks(5718), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 763, DateTimeKind.Local).AddTicks(5749), new TimeSpan(0, 0, 0, 0, 0), false, 9 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 6,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "Status" },
                values: new object[] { "Et nam omnis ea laboriosam omnis perspiciatis soluta ut similique. Ut omnis culpa et necessitatibus. Amet delectus fugiat ipsam neque corrupti cumque in molestiae alias.", new DateTime(2024, 9, 26, 10, 33, 39, 763, DateTimeKind.Local).AddTicks(5952), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 763, DateTimeKind.Local).AddTicks(5954), new TimeSpan(0, 0, 0, 0, 0), false });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 7,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "VisitorId" },
                values: new object[] { "Et molestiae labore a qui. Deserunt veniam voluptas et magni dolore eligendi voluptatibus aut rem. Sit voluptatem eligendi ut. Placeat debitis possimus ut debitis earum accusantium ad blanditiis omnis.", new DateTime(2024, 9, 26, 10, 33, 39, 764, DateTimeKind.Local).AddTicks(7938), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 764, DateTimeKind.Local).AddTicks(7965), new TimeSpan(0, 0, 0, 0, 0), 6 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 8,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "Status" },
                values: new object[] { "Natus ut et a dolore voluptatem ipsum. Laborum rerum tempora error ut dolore dolore iste nihil. Hic molestias quia quia. Doloremque aspernatur soluta.", new DateTime(2024, 9, 26, 10, 33, 39, 764, DateTimeKind.Local).AddTicks(8304), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 764, DateTimeKind.Local).AddTicks(8307), new TimeSpan(0, 0, 0, 0, 0), false });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 9,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "VisitorId" },
                values: new object[] { "Commodi perspiciatis officiis. Aliquam ut impedit quaerat perspiciatis nobis dolorem quis distinctio similique. Officia hic officiis repudiandae incidunt nulla aut facere.", new DateTime(2024, 9, 26, 10, 33, 39, 765, DateTimeKind.Local).AddTicks(9307), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 765, DateTimeKind.Local).AddTicks(9336), new TimeSpan(0, 0, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 10,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "VisitorId" },
                values: new object[] { "Nihil quo minus aperiam eligendi ea nemo voluptatem cumque. Doloremque cumque illo molestiae odit corporis et optio deserunt. Aut libero omnis. Nam quisquam beatae blanditiis maxime.", new DateTime(2024, 9, 26, 10, 33, 39, 765, DateTimeKind.Local).AddTicks(9529), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 765, DateTimeKind.Local).AddTicks(9532), new TimeSpan(0, 0, 0, 0, 0), 6 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 11,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "VisitorId" },
                values: new object[] { "Quia excepturi tempore eius et et distinctio odio. Quis ut animi voluptas architecto quia. Voluptatem sit voluptatem enim rerum asperiores perferendis consequatur maiores molestiae.", new DateTime(2024, 9, 26, 10, 33, 39, 767, DateTimeKind.Local).AddTicks(436), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 767, DateTimeKind.Local).AddTicks(462), new TimeSpan(0, 0, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 12,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "Status", "VisitorId" },
                values: new object[] { "Est consequatur qui suscipit quas dicta minima nisi alias cum. Ea rerum deserunt sit placeat possimus commodi quia. Temporibus dignissimos quibusdam et dolore deleniti velit. Voluptatum aut excepturi neque magni.", new DateTime(2024, 9, 26, 10, 33, 39, 767, DateTimeKind.Local).AddTicks(660), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 767, DateTimeKind.Local).AddTicks(662), new TimeSpan(0, 0, 0, 0, 0), false, 5 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 13,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "Status", "VisitorId" },
                values: new object[] { "Quos eius alias. Et facere qui quia debitis distinctio laudantium ipsam. Et et animi expedita culpa mollitia. Tenetur tempore dolorum deleniti ea. Soluta quam officia sed omnis qui qui sed. Ut sed ea qui et consequatur modi molestias velit.", new DateTime(2024, 9, 26, 10, 33, 39, 770, DateTimeKind.Local).AddTicks(319), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 770, DateTimeKind.Local).AddTicks(364), new TimeSpan(0, 0, 0, 0, 0), false, 3 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 14,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "VisitorId" },
                values: new object[] { "Cupiditate culpa inventore laborum sint aspernatur voluptatibus dolorem ut tenetur. Dolor voluptatem qui numquam aut corrupti excepturi rerum nulla. Itaque et nam est quasi omnis. Ea repellendus illum. Voluptatem neque architecto incidunt ut amet.", new DateTime(2024, 9, 26, 10, 33, 39, 770, DateTimeKind.Local).AddTicks(617), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 770, DateTimeKind.Local).AddTicks(619), new TimeSpan(0, 0, 0, 0, 0), 5 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 15,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "VisitorId" },
                values: new object[] { "Doloribus eligendi incidunt qui aut velit assumenda nam. Rerum ducimus enim quae. Odit velit nisi pariatur occaecati perferendis dolores accusamus consectetur est.", new DateTime(2024, 9, 26, 10, 33, 39, 771, DateTimeKind.Local).AddTicks(4610), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 771, DateTimeKind.Local).AddTicks(4712), new TimeSpan(0, 0, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 16,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "VisitorId" },
                values: new object[] { "Rerum ullam iusto dignissimos facere hic non. Labore asperiores explicabo tenetur aliquam veniam magnam repudiandae quo quibusdam. Pariatur accusantium deleniti similique corrupti deserunt qui. Maiores et id neque est nobis eum.", new DateTime(2024, 9, 26, 10, 33, 39, 771, DateTimeKind.Local).AddTicks(5157), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 771, DateTimeKind.Local).AddTicks(5160), new TimeSpan(0, 0, 0, 0, 0), 7 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 17,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "VisitorId" },
                values: new object[] { "Fugiat qui occaecati. Deleniti aperiam cumque rerum et sit exercitationem optio recusandae. In eveniet animi id architecto magnam qui in ipsum repellat.", new DateTime(2024, 9, 26, 10, 33, 39, 772, DateTimeKind.Local).AddTicks(8703), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 772, DateTimeKind.Local).AddTicks(8734), new TimeSpan(0, 0, 0, 0, 0), 6 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 18,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "Status", "VisitorId" },
                values: new object[] { "Cum iste quia recusandae error accusamus. Corrupti quis et et id autem qui omnis. Laboriosam libero quo harum neque voluptas nemo occaecati atque. In beatae non eveniet rerum ducimus aut.", new DateTime(2024, 9, 26, 10, 33, 39, 772, DateTimeKind.Local).AddTicks(8937), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 772, DateTimeKind.Local).AddTicks(8940), new TimeSpan(0, 0, 0, 0, 0), false, 6 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 19,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "VisitorId" },
                values: new object[] { "Explicabo veritatis ipsa rem iste eaque perspiciatis rem. Totam consequatur consectetur ut inventore ut id eligendi. Molestias at minima dolores. Adipisci et corporis numquam sed eum. Provident quo deleniti porro consequatur ipsum neque molestiae.", new DateTime(2024, 9, 26, 10, 33, 39, 773, DateTimeKind.Local).AddTicks(9997), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 774, DateTimeKind.Local).AddTicks(23), new TimeSpan(0, 0, 0, 0, 0), 6 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 20,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "VisitorId" },
                values: new object[] { "Voluptatibus libero totam doloremque enim amet. Corporis doloribus vitae aut suscipit non accusantium. Sed dicta dolorem ut quae aliquam natus porro. Vel dolorem id soluta eos. Nesciunt ut dolor. Tempora nisi quas recusandae magni dicta dicta.", new DateTime(2024, 9, 26, 10, 33, 39, 774, DateTimeKind.Local).AddTicks(234), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 774, DateTimeKind.Local).AddTicks(236), new TimeSpan(0, 0, 0, 0, 0), 10 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 21,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "Status", "VisitorId" },
                values: new object[] { "Et omnis omnis laborum aliquam sit. Facere architecto dolores est repellendus molestiae magni. Enim non repellendus iste nam id. Quidem blanditiis aspernatur. Nostrum rerum dolores ullam molestiae odit quo fugit consequatur. Reiciendis et voluptas ut cupiditate amet quo laudantium.", new DateTime(2024, 9, 26, 10, 33, 39, 775, DateTimeKind.Local).AddTicks(1254), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 775, DateTimeKind.Local).AddTicks(1283), new TimeSpan(0, 0, 0, 0, 0), false, 9 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 22,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "VisitorId" },
                values: new object[] { "Facere in nesciunt necessitatibus. Quos quia est velit. Sed fuga temporibus impedit sint et inventore. Soluta quis qui qui explicabo magni rem. Iste dolore consequatur commodi est inventore in voluptas illum.", new DateTime(2024, 9, 26, 10, 33, 39, 775, DateTimeKind.Local).AddTicks(1491), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 775, DateTimeKind.Local).AddTicks(1493), new TimeSpan(0, 0, 0, 0, 0), 9 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 23,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "VisitorId" },
                values: new object[] { "Voluptates illo voluptas modi perspiciatis ducimus quidem fuga sed. Et maiores veritatis officiis soluta. Aspernatur asperiores reprehenderit dolorem voluptatem adipisci. Sunt quia maiores magnam sequi voluptatem est repudiandae. Excepturi explicabo nihil minima sit praesentium aliquid. Doloremque nobis dolorum libero sed voluptas exercitationem.", new DateTime(2024, 9, 26, 10, 33, 39, 776, DateTimeKind.Local).AddTicks(2168), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 776, DateTimeKind.Local).AddTicks(2212), new TimeSpan(0, 0, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 24,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "VisitorId" },
                values: new object[] { "Cupiditate ipsum autem ut voluptas at rerum occaecati. Molestiae exercitationem dolore est molestiae repudiandae deleniti rerum est. Et id ut. Itaque delectus qui excepturi vero provident.", new DateTime(2024, 9, 26, 10, 33, 39, 776, DateTimeKind.Local).AddTicks(2395), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 776, DateTimeKind.Local).AddTicks(2397), new TimeSpan(0, 0, 0, 0, 0), 5 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 25,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "Status", "VisitorId" },
                values: new object[] { "Illo et aut. Repellendus tempora corporis architecto culpa maiores inventore aut hic sit. Incidunt expedita doloribus quisquam sit.", new DateTime(2024, 9, 26, 10, 33, 39, 777, DateTimeKind.Local).AddTicks(3002), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 777, DateTimeKind.Local).AddTicks(3030), new TimeSpan(0, 0, 0, 0, 0), false, 1 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 26,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "Status", "VisitorId" },
                values: new object[] { "Quae deleniti magni id iure nemo. Autem corporis veniam. Ut iure esse quidem assumenda est fugit pariatur assumenda consequuntur. Voluptatem in consequatur quia dignissimos qui dolores tempora beatae totam. Est in corrupti excepturi quia hic veritatis laudantium rerum.", new DateTime(2024, 9, 26, 10, 33, 39, 777, DateTimeKind.Local).AddTicks(3328), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 777, DateTimeKind.Local).AddTicks(3330), new TimeSpan(0, 0, 0, 0, 0), false, 1 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 27,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "Status", "VisitorId" },
                values: new object[] { "Debitis veritatis fuga aut deserunt. Atque vel sunt sed consequatur dolorem velit. Soluta dolorem dolores omnis nemo architecto sit. Beatae sed quia expedita dolor consequuntur quia. Laborum cumque aspernatur saepe dolores cumque fuga aut.", new DateTime(2024, 9, 26, 10, 33, 39, 778, DateTimeKind.Local).AddTicks(3789), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 778, DateTimeKind.Local).AddTicks(3817), new TimeSpan(0, 0, 0, 0, 0), false, 10 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 28,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "Status", "VisitorId" },
                values: new object[] { "Rerum doloribus nam magni pariatur beatae recusandae dolores quibusdam. Aperiam facilis quam adipisci ea laudantium recusandae aut. Maxime ut totam sapiente nostrum blanditiis eveniet. Veniam debitis sunt dolorem non. Aut eaque minus expedita doloribus est qui.", new DateTime(2024, 9, 26, 10, 33, 39, 778, DateTimeKind.Local).AddTicks(4030), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 778, DateTimeKind.Local).AddTicks(4032), new TimeSpan(0, 0, 0, 0, 0), false, 4 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 29,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "VisitorId" },
                values: new object[] { "Debitis ratione eaque exercitationem reprehenderit et vero sunt exercitationem corporis. Corrupti aliquid eos quasi fugiat eum. Vel velit incidunt quis quibusdam omnis hic facere. Quia hic ipsam sed facere facere cumque qui dolorem. Itaque est ea id culpa ducimus aut. Necessitatibus enim quae eum culpa velit quidem et.", new DateTime(2024, 9, 26, 10, 33, 39, 780, DateTimeKind.Local).AddTicks(3824), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 780, DateTimeKind.Local).AddTicks(3856), new TimeSpan(0, 0, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 30,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "Status", "VisitorId" },
                values: new object[] { "Quae quaerat molestias nesciunt. Delectus animi ea inventore quo. Aliquid provident voluptatem vitae voluptate nihil est culpa.", new DateTime(2024, 9, 26, 10, 33, 39, 780, DateTimeKind.Local).AddTicks(4031), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 780, DateTimeKind.Local).AddTicks(4033), new TimeSpan(0, 0, 0, 0, 0), false, 8 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 31,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "VisitorId" },
                values: new object[] { "Quas nisi molestiae et ullam sint. Voluptatem blanditiis minus veniam. Id natus consectetur ut tempora illum sint quia. Beatae sint sapiente quia sunt quam. Quia modi in doloremque.", new DateTime(2024, 9, 26, 10, 33, 39, 781, DateTimeKind.Local).AddTicks(5498), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 781, DateTimeKind.Local).AddTicks(5527), new TimeSpan(0, 0, 0, 0, 0), 7 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 32,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "Status", "VisitorId" },
                values: new object[] { "Voluptatem sapiente voluptas consequatur sunt rem et nihil neque est. Iste possimus veniam voluptatem alias. Fugiat aut voluptas labore qui laborum aut.", new DateTime(2024, 9, 26, 10, 33, 39, 781, DateTimeKind.Local).AddTicks(5783), new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 9, 27, 10, 33, 39, 781, DateTimeKind.Local).AddTicks(5785), new TimeSpan(0, 0, 0, 0, 0), false, 1 });

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
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Veum - Macejkovic", new DateTime(2024, 9, 16, 5, 2, 48, 837, DateTimeKind.Unspecified).AddTicks(1954), 1, "fla2me9dro", "0366515124", new DateTime(2024, 9, 16, 5, 2, 48, 837, DateTimeKind.Unspecified).AddTicks(1954), "Elbert Rippin" });

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
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Kirlin - Veum", new DateTime(2024, 9, 25, 0, 18, 15, 246, DateTimeKind.Unspecified).AddTicks(5086), 2, "04hiqp4rte", "0150176053", true, new DateTime(2024, 9, 25, 0, 18, 15, 246, DateTimeKind.Unspecified).AddTicks(5086), "Alexander Robel" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 4,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Friesen Group", new DateTime(2024, 9, 13, 17, 13, 22, 423, DateTimeKind.Unspecified).AddTicks(3486), 2, "z878cushvu", "0913845818", false, new DateTime(2024, 9, 13, 17, 13, 22, 423, DateTimeKind.Unspecified).AddTicks(3486), "Hanna Monahan" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 5,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Lubowitz, Hoppe and Kilback", new DateTime(2024, 9, 18, 0, 51, 0, 481, DateTimeKind.Unspecified).AddTicks(5150), "fy48mcdqne", "0270704305", new DateTime(2024, 9, 18, 0, 51, 0, 481, DateTimeKind.Unspecified).AddTicks(5150), "Addison Zulauf" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 6,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "O'Kon - Kilback", new DateTime(2024, 9, 5, 19, 7, 29, 233, DateTimeKind.Unspecified).AddTicks(1471), 2, "xpyivd0v6t", "0702122086", new DateTime(2024, 9, 5, 19, 7, 29, 233, DateTimeKind.Unspecified).AddTicks(1471), "Alicia Smith" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 7,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Ledner - Wolf", new DateTime(2024, 9, 12, 22, 27, 29, 304, DateTimeKind.Unspecified).AddTicks(6576), 1, "0q98jaomat", "0216217526", new DateTime(2024, 9, 12, 22, 27, 29, 304, DateTimeKind.Unspecified).AddTicks(6576), "Karen Roberts" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 8,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Gleichner - Wilkinson", new DateTime(2024, 9, 2, 20, 31, 47, 691, DateTimeKind.Unspecified).AddTicks(2915), 1, "3ad836w0e0", "0329699322", true, new DateTime(2024, 9, 2, 20, 31, 47, 691, DateTimeKind.Unspecified).AddTicks(2915), "Destin Quigley" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 9,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Balistreri - Rau", new DateTime(2024, 9, 7, 15, 52, 35, 822, DateTimeKind.Unspecified).AddTicks(9562), "im1cxlc8lo", "0108138373", new DateTime(2024, 9, 7, 15, 52, 35, 822, DateTimeKind.Unspecified).AddTicks(9562), "Keanu Zemlak" });

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

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 2,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 3, 33, 39, 761, DateTimeKind.Utc).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 3,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 3, 33, 39, 761, DateTimeKind.Utc).AddTicks(303));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 4,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 3, 33, 39, 761, DateTimeKind.Utc).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 5,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 3, 33, 39, 761, DateTimeKind.Utc).AddTicks(324));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 6,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 3, 33, 39, 761, DateTimeKind.Utc).AddTicks(333));
        }
    }
}
