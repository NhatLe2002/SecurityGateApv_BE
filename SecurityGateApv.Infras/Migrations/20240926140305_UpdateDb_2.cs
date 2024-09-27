using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecurityGateApv.Infras.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDb_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VisitProjects_Processes_ProcessId",
                table: "VisitProjects");

            migrationBuilder.DropForeignKey(
                name: "FK_VisitProjects_Visits_VisitId",
                table: "VisitProjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VisitProjects",
                table: "VisitProjects");

            migrationBuilder.RenameTable(
                name: "VisitProjects",
                newName: "VisitProcesses");

            migrationBuilder.RenameIndex(
                name: "IX_VisitProjects_VisitId",
                table: "VisitProcesses",
                newName: "IX_VisitProcesses_VisitId");

            migrationBuilder.RenameIndex(
                name: "IX_VisitProjects_ProcessId",
                table: "VisitProcesses",
                newName: "IX_VisitProcesses_ProcessId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VisitProcesses",
                table: "VisitProcesses",
                column: "VisitProcessId");

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
                values: new object[] { 5, new DateTime(2024, 9, 14, 17, 29, 1, 444, DateTimeKind.Utc).AddTicks(6787), "Phòng Nhân sự", "Placeat consectetur rerum fugiat.", new DateTime(2024, 9, 14, 17, 29, 1, 444, DateTimeKind.Utc).AddTicks(6787) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 15, 4, 42, 8, 564, DateTimeKind.Utc).AddTicks(5646), "Phòng Nhân sự", "Quaerat enim et nesciunt possimus veritatis numquam in.", new DateTime(2024, 9, 15, 4, 42, 8, 564, DateTimeKind.Utc).AddTicks(5646) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "AcceptLevel", "CreateDate", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 3, 21, 19, 1, 81, DateTimeKind.Utc).AddTicks(2807), "Fugiat quia facilis.", new DateTime(2024, 9, 3, 21, 19, 1, 81, DateTimeKind.Utc).AddTicks(2807) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4,
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 19, 21, 32, 17, 638, DateTimeKind.Utc).AddTicks(697), "Phòng IT", "Sed consequatur cum ad laborum tempore consequatur dolores nam.", new DateTime(2024, 9, 19, 21, 32, 17, 638, DateTimeKind.Utc).AddTicks(697) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5,
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 21, 46, 14, 396, DateTimeKind.Utc).AddTicks(1757), "Phòng Nhân sự", "Accusamus et voluptate animi assumenda ut expedita quam.", new DateTime(2024, 9, 25, 21, 46, 14, 396, DateTimeKind.Utc).AddTicks(1757) });

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
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 4, new DateTime(2024, 9, 11, 23, 52, 19, 248, DateTimeKind.Utc).AddTicks(3647), "Phòng IT", "Sit quia similique voluptas et possimus autem.", new DateTime(2024, 9, 11, 23, 52, 19, 248, DateTimeKind.Utc).AddTicks(3647) });

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
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 24, 14, 3, 5, 125, DateTimeKind.Utc).AddTicks(8055), "Practical Soft Mouse", true });

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
                columns: new[] { "CreateTime", "ProcessName" },
                values: new object[] { new DateTime(2024, 9, 24, 14, 3, 5, 125, DateTimeKind.Utc).AddTicks(8090), "Gorgeous Fresh Tuna" });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 1,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId" },
                values: new object[] { new Guid("ece5de14-04ba-4ba4-a42c-65a3c46f2f1e"), new DateTime(2024, 9, 26, 21, 3, 5, 167, DateTimeKind.Local).AddTicks(268), new DateTime(2024, 10, 26, 21, 3, 5, 167, DateTimeKind.Local).AddTicks(268), 1 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 2,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardTypeId" },
                values: new object[] { new Guid("c73da352-a17b-49f4-9e73-3b321be65345"), new DateTime(2024, 9, 26, 21, 3, 5, 167, DateTimeKind.Local).AddTicks(456), new DateTime(2024, 10, 26, 21, 3, 5, 167, DateTimeKind.Local).AddTicks(456), 1 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 3,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("d4315112-7ffd-496d-a209-6136e9c4a338"), new DateTime(2024, 9, 26, 21, 3, 5, 167, DateTimeKind.Local).AddTicks(468), new DateTime(2024, 10, 26, 21, 3, 5, 167, DateTimeKind.Local).AddTicks(468) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 4,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId" },
                values: new object[] { new Guid("e14d6c25-7fab-4421-9b14-de07523911f4"), new DateTime(2024, 9, 26, 21, 3, 5, 167, DateTimeKind.Local).AddTicks(476), new DateTime(2024, 10, 26, 21, 3, 5, 167, DateTimeKind.Local).AddTicks(476), 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 5,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId" },
                values: new object[] { new Guid("2899667c-a36f-497a-99f2-e576346adfd2"), new DateTime(2024, 9, 26, 21, 3, 5, 167, DateTimeKind.Local).AddTicks(483), new DateTime(2024, 10, 26, 21, 3, 5, 167, DateTimeKind.Local).AddTicks(483), 1 });

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
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId" },
                values: new object[] { new Guid("c1072234-9bdf-4b34-b073-575cfccb39c7"), new DateTime(2024, 9, 26, 21, 3, 5, 167, DateTimeKind.Local).AddTicks(510), new DateTime(2024, 10, 26, 21, 3, 5, 167, DateTimeKind.Local).AddTicks(510), 1 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 8,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("f33222a6-9836-4eeb-ab14-5eb32e3f97ec"), new DateTime(2024, 9, 26, 21, 3, 5, 167, DateTimeKind.Local).AddTicks(516), new DateTime(2024, 10, 26, 21, 3, 5, 167, DateTimeKind.Local).AddTicks(516) });

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
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardTypeId" },
                values: new object[] { new Guid("e36cd8c3-fe4e-4924-a1e6-c14d00b8babe"), new DateTime(2024, 9, 26, 21, 3, 5, 167, DateTimeKind.Local).AddTicks(530), new DateTime(2024, 10, 26, 21, 3, 5, 167, DateTimeKind.Local).AddTicks(530), 1 });

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
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 1, 7 });

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
                column: "UserId",
                value: 12);

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
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 10, 23 });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 22, 4, 49, 3, 99, DateTimeKind.Unspecified).AddTicks(4462), "gmail.com.Botsford79@gmail.com", "Sigrid Morar", "11shoe", "0303930993", new DateTime(2024, 9, 22, 4, 49, 3, 99, DateTimeKind.Unspecified).AddTicks(4462), "Berniece.Daugherty" });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 17, 16, 19, 27, 603, DateTimeKind.Unspecified).AddTicks(3487), "gmail.com5@yahoo.com", "Mara Barton", "f6x6lz", "0795732876", new DateTime(2024, 9, 17, 16, 19, 27, 603, DateTimeKind.Unspecified).AddTicks(3487), "Ruth16" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 17, 22, 22, 15, 650, DateTimeKind.Unspecified).AddTicks(1352), "gmail.com.Hansen72@yahoo.com", "Katlyn Crona", "8np1ig", "0235348308", 2, new DateTime(2024, 9, 17, 22, 22, 15, 650, DateTimeKind.Unspecified).AddTicks(1352), "Luther88" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 6, 21, 47, 43, 963, DateTimeKind.Unspecified).AddTicks(3248), "gmail.com.Schulist92@hotmail.com", "Dexter Crona", "kt920x", "0642349016", new DateTime(2024, 9, 6, 21, 47, 43, 963, DateTimeKind.Unspecified).AddTicks(3248), "Daphne_Baumbach" });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 12, 1, 22, 49, 817, DateTimeKind.Unspecified).AddTicks(6804), "gmail.com_Dach71@gmail.com", "Brock Torp", "3retk0", "0865642984", new DateTime(2024, 9, 12, 1, 22, 49, 817, DateTimeKind.Unspecified).AddTicks(6804), "Federico_Spencer" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 12, 7, 48, 24, 254, DateTimeKind.Unspecified).AddTicks(3765), "gmail.com_Krajcik87@hotmail.com", "Ebony Krajcik", "3gh28x", "0593442985", new DateTime(2024, 9, 12, 7, 48, 24, 254, DateTimeKind.Unspecified).AddTicks(3765), "Adolf.Wilderman85" });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 8, 3, 9, 41, 111, DateTimeKind.Unspecified).AddTicks(9770), "gmail.com.Dooley64@yahoo.com", "Dagmar Kessler", "eklr4s", "0352564289", new DateTime(2024, 9, 8, 3, 9, 41, 111, DateTimeKind.Unspecified).AddTicks(9770), "Alana.Cummings52" });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 24, 7, 31, 18, 801, DateTimeKind.Unspecified).AddTicks(401), "gmail.com24@yahoo.com", "Cassandre Champlin", "rhini3", "0990818444", 5, new DateTime(2024, 9, 24, 7, 31, 18, 801, DateTimeKind.Unspecified).AddTicks(401), "Kane.Hand" });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 19, 19, 41, 50, 541, DateTimeKind.Unspecified).AddTicks(4589), "gmail.com68@hotmail.com", "Johan O'Conner", "01fv6k", "0662040845", new DateTime(2024, 9, 19, 19, 41, 50, 541, DateTimeKind.Unspecified).AddTicks(4589), "Mireya_Wyman" });

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
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Autem aliquam culpa. Magni voluptas velit fugit assumenda nostrum minima quo et. Laboriosam in dolores facilis dolorem suscipit maiores ducimus neque ipsa. Assumenda dicta minima numquam sit sit consequatur. Molestiae quam magni. Et optio ut odio non.", new DateTime(2024, 10, 25, 21, 3, 5, 129, DateTimeKind.Local).AddTicks(5968), new DateTime(2024, 9, 25, 21, 3, 5, 129, DateTimeKind.Local).AddTicks(5965), 1 });

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
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Explicabo voluptate hic voluptatem provident dolorem odit qui porro corrupti. Saepe ut quo et aspernatur voluptas animi et. Enim voluptatem nihil quis placeat modi hic.", new DateTime(2024, 9, 27, 21, 3, 5, 153, DateTimeKind.Local).AddTicks(1571), new DateTime(2024, 9, 26, 21, 3, 5, 153, DateTimeKind.Local).AddTicks(1569), 9 });

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
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Omnis placeat asperiores assumenda quos sed beatae nam. Praesentium error et nostrum exercitationem rem incidunt doloribus est. Error temporibus non sit tempore.", new DateTime(2024, 9, 27, 21, 3, 5, 154, DateTimeKind.Local).AddTicks(4924), new DateTime(2024, 9, 26, 21, 3, 5, 154, DateTimeKind.Local).AddTicks(4921) });

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
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Non cupiditate dolorum accusantium. Error illo odit quos. Impedit quia ut commodi et et quidem aut animi suscipit. Qui sed aut sit similique cum voluptates occaecati. Unde distinctio id.", new DateTime(2024, 9, 27, 21, 3, 5, 155, DateTimeKind.Local).AddTicks(5925), new DateTime(2024, 9, 26, 21, 3, 5, 155, DateTimeKind.Local).AddTicks(5922) });

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
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Voluptatem qui ea praesentium qui. Totam qui maxime consectetur. Veritatis officia ab sequi illum. Aliquid aspernatur ducimus libero iure voluptas nemo pariatur. Odit commodi tenetur sequi qui.", new DateTime(2024, 9, 27, 21, 3, 5, 157, DateTimeKind.Local).AddTicks(8436), new DateTime(2024, 9, 26, 21, 3, 5, 157, DateTimeKind.Local).AddTicks(8411), 10 });

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
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Perspiciatis magni ex ipsum. In animi voluptate enim voluptatibus. Assumenda fugit nesciunt vel numquam esse nihil enim quia. Aut voluptatem qui quam adipisci. Commodi soluta totam alias. Voluptates tempore aliquid veritatis aut qui.", new DateTime(2024, 9, 27, 21, 3, 5, 164, DateTimeKind.Local).AddTicks(5871), new DateTime(2024, 9, 26, 21, 3, 5, 164, DateTimeKind.Local).AddTicks(5844), 10 });

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
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Gulgowski, Williamson and Littel", new DateTime(2024, 9, 6, 20, 5, 47, 786, DateTimeKind.Unspecified).AddTicks(459), "tyghrsdbe8", "0149291766", new DateTime(2024, 9, 6, 20, 5, 47, 786, DateTimeKind.Unspecified).AddTicks(459), "Dusty Ebert" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 2,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Brown, Ebert and Block", new DateTime(2024, 9, 14, 6, 41, 53, 740, DateTimeKind.Unspecified).AddTicks(4875), "yk2nrxhjl6", "0442335366", true, new DateTime(2024, 9, 14, 6, 41, 53, 740, DateTimeKind.Unspecified).AddTicks(4875), "Clarissa Beer" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 3,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Okuneva Inc", new DateTime(2024, 9, 19, 17, 2, 57, 868, DateTimeKind.Unspecified).AddTicks(296), "e1i0vw752q", "0588954920", new DateTime(2024, 9, 19, 17, 2, 57, 868, DateTimeKind.Unspecified).AddTicks(296), "Sterling Weber" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 4,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Leannon LLC", new DateTime(2024, 9, 19, 18, 17, 17, 808, DateTimeKind.Unspecified).AddTicks(9273), "1c9rjdol4u", "0250456062", new DateTime(2024, 9, 19, 18, 17, 17, 808, DateTimeKind.Unspecified).AddTicks(9273), "Jaunita Douglas" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 5,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Herman and Sons", new DateTime(2024, 9, 1, 21, 55, 39, 175, DateTimeKind.Unspecified).AddTicks(839), 2, "0hfmkql55u", "0771976198", false, new DateTime(2024, 9, 1, 21, 55, 39, 175, DateTimeKind.Unspecified).AddTicks(839), "Elise Sporer" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 6,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Hirthe - Marquardt", new DateTime(2024, 9, 5, 23, 23, 22, 97, DateTimeKind.Unspecified).AddTicks(4218), 2, "k2wt33ue4v", "0685821577", false, new DateTime(2024, 9, 5, 23, 23, 22, 97, DateTimeKind.Unspecified).AddTicks(4218), "Wendy Runte" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 7,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Bechtelar - Stokes", new DateTime(2024, 9, 5, 21, 24, 53, 156, DateTimeKind.Unspecified).AddTicks(6104), 1, "69w78phbux", "0533618354", new DateTime(2024, 9, 5, 21, 24, 53, 156, DateTimeKind.Unspecified).AddTicks(6104), "Ryan Hermiston" });

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
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Krajcik, Jacobi and Emmerich", new DateTime(2024, 9, 20, 21, 30, 30, 713, DateTimeKind.Unspecified).AddTicks(5275), 2, "b4p6qzmx94", "0583766934", new DateTime(2024, 9, 20, 21, 30, 30, 713, DateTimeKind.Unspecified).AddTicks(5275), "Gianni Volkman" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_VisitProcesses_Processes_ProcessId",
                table: "VisitProcesses",
                column: "ProcessId",
                principalTable: "Processes",
                principalColumn: "ProcessId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VisitProcesses_Visits_VisitId",
                table: "VisitProcesses",
                column: "VisitId",
                principalTable: "Visits",
                principalColumn: "VisitId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VisitProcesses_Processes_ProcessId",
                table: "VisitProcesses");

            migrationBuilder.DropForeignKey(
                name: "FK_VisitProcesses_Visits_VisitId",
                table: "VisitProcesses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VisitProcesses",
                table: "VisitProcesses");

            migrationBuilder.RenameTable(
                name: "VisitProcesses",
                newName: "VisitProjects");

            migrationBuilder.RenameIndex(
                name: "IX_VisitProcesses_VisitId",
                table: "VisitProjects",
                newName: "IX_VisitProjects_VisitId");

            migrationBuilder.RenameIndex(
                name: "IX_VisitProcesses_ProcessId",
                table: "VisitProjects",
                newName: "IX_VisitProjects_ProcessId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VisitProjects",
                table: "VisitProjects",
                column: "VisitProcessId");

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
                columns: new[] { "AcceptLevel", "CreateDate", "Description", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 4, 18, 53, 26, 524, DateTimeKind.Utc).AddTicks(253), "Velit ut magni dolores exercitationem.", new DateTime(2024, 9, 4, 18, 53, 26, 524, DateTimeKind.Utc).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4,
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 6, 57, 959, DateTimeKind.Utc).AddTicks(6175), "Phòng Chăm sóc khách hàng", "Laboriosam harum amet labore ea nobis sint accusantium magni.", new DateTime(2024, 9, 12, 22, 6, 57, 959, DateTimeKind.Utc).AddTicks(6175) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5,
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 6, 28, 8, 496, DateTimeKind.Utc).AddTicks(2588), "Phòng Chăm sóc khách hàng", "Quae in similique.", new DateTime(2024, 9, 11, 6, 28, 8, 496, DateTimeKind.Utc).AddTicks(2588) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 6,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 10, 12, 2, 4, 320, DateTimeKind.Utc).AddTicks(4826), "Phòng Marketing", "Tempore aut molestiae provident.", new DateTime(2024, 9, 10, 12, 2, 4, 320, DateTimeKind.Utc).AddTicks(4826) });

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
                columns: new[] { "CreateTime", "ProcessName" },
                values: new object[] { new DateTime(2024, 9, 24, 13, 58, 59, 289, DateTimeKind.Utc).AddTicks(5450), "Refined Granite Chair" });

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
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId" },
                values: new object[] { new Guid("52cf61e7-af39-41ad-b625-f715b10a61ed"), new DateTime(2024, 9, 26, 20, 58, 59, 359, DateTimeKind.Local).AddTicks(9828), new DateTime(2024, 10, 26, 20, 58, 59, 359, DateTimeKind.Local).AddTicks(9828), 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 2,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardTypeId" },
                values: new object[] { new Guid("0740a1b2-0279-4fa7-8483-d3c012168056"), new DateTime(2024, 9, 26, 20, 58, 59, 360, DateTimeKind.Local).AddTicks(135), new DateTime(2024, 10, 26, 20, 58, 59, 360, DateTimeKind.Local).AddTicks(135), 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 3,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("5813acbe-9749-4440-a04c-0216a98a670b"), new DateTime(2024, 9, 26, 20, 58, 59, 360, DateTimeKind.Local).AddTicks(153), new DateTime(2024, 10, 26, 20, 58, 59, 360, DateTimeKind.Local).AddTicks(153) });

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
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId" },
                values: new object[] { new Guid("8d3fdbcc-48c9-4aaa-abf1-7a317ff7216c"), new DateTime(2024, 9, 26, 20, 58, 59, 360, DateTimeKind.Local).AddTicks(192), new DateTime(2024, 10, 26, 20, 58, 59, 360, DateTimeKind.Local).AddTicks(192), 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 6,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("0176a987-218f-4d18-9132-bab289272c84"), new DateTime(2024, 9, 26, 20, 58, 59, 360, DateTimeKind.Local).AddTicks(203), new DateTime(2024, 10, 26, 20, 58, 59, 360, DateTimeKind.Local).AddTicks(203) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 7,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId" },
                values: new object[] { new Guid("4a08da74-6a02-4eab-8c6a-3d5384a5dd7b"), new DateTime(2024, 9, 26, 20, 58, 59, 360, DateTimeKind.Local).AddTicks(212), new DateTime(2024, 10, 26, 20, 58, 59, 360, DateTimeKind.Local).AddTicks(212), 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 8,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("adc74f61-9047-4f0b-9c32-643d56540f1d"), new DateTime(2024, 9, 26, 20, 58, 59, 360, DateTimeKind.Local).AddTicks(275), new DateTime(2024, 10, 26, 20, 58, 59, 360, DateTimeKind.Local).AddTicks(275) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 9,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardTypeId" },
                values: new object[] { new Guid("e23859ee-679d-4f2d-8e06-98794c0bcc92"), new DateTime(2024, 9, 26, 20, 58, 59, 360, DateTimeKind.Local).AddTicks(297), new DateTime(2024, 10, 26, 20, 58, 59, 360, DateTimeKind.Local).AddTicks(297), 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 10,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardTypeId" },
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
                column: "UserId",
                value: 6);

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
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 8 });

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
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 2, 21 });

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
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 2, 14 });

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
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 6 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 23,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 7 });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 9, 9, 46, 23, 759, DateTimeKind.Unspecified).AddTicks(5753), "gmail.com.Wehner8@gmail.com", "Lucy Mann", "nkl7u1", "0782943701", new DateTime(2024, 9, 9, 9, 46, 23, 759, DateTimeKind.Unspecified).AddTicks(5753), "Shanny35" });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 17, 10, 53, 39, 588, DateTimeKind.Unspecified).AddTicks(5921), "gmail.com15@gmail.com", "Joanie Roberts", "dvm0b1", "0212554892", new DateTime(2024, 9, 17, 10, 53, 39, 588, DateTimeKind.Unspecified).AddTicks(5921), "Brian.Zboncak59" });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 19, 15, 19, 24, 97, DateTimeKind.Unspecified).AddTicks(6156), "gmail.com_Greenfelder11@gmail.com", "Deion Huel", "znjesg", "0350810904", new DateTime(2024, 9, 19, 15, 19, 24, 97, DateTimeKind.Unspecified).AddTicks(6156), "Silas19" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 19, 10, 32, 46, 50, DateTimeKind.Unspecified).AddTicks(3321), "gmail.com.Volkman@yahoo.com", "Sylvia Padberg", "82rwka", "0843976366", new DateTime(2024, 9, 19, 10, 32, 46, 50, DateTimeKind.Unspecified).AddTicks(3321), "Rosa.Metz" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 6, 21, 27, 10, 30, DateTimeKind.Unspecified).AddTicks(5876), "gmail.com24@yahoo.com", "Alf Steuber", "pol45x", "0202220360", new DateTime(2024, 9, 6, 21, 27, 10, 30, DateTimeKind.Unspecified).AddTicks(5876), "Berry_Streich97" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 16, 21, 25, 3, 56, DateTimeKind.Unspecified).AddTicks(3470), "gmail.com.Krajcik@gmail.com", "Yasmine Grimes", "pxngof", "0340309130", new DateTime(2024, 9, 16, 21, 25, 3, 56, DateTimeKind.Unspecified).AddTicks(3470), "Dangelo_Schaden" });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 18, 10, 23, 49, 120, DateTimeKind.Unspecified).AddTicks(5576), "gmail.com.Abshire48@hotmail.com", "Marianne Mueller", "716w0s", "0196947239", new DateTime(2024, 9, 18, 10, 23, 49, 120, DateTimeKind.Unspecified).AddTicks(5576), "Conrad_Rodriguez76" });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 2, 4, 44, 10, 478, DateTimeKind.Unspecified).AddTicks(65), "gmail.com.Jacobson76@yahoo.com", "Quentin Hickle", "4jpv43", "0582383611", 1, new DateTime(2024, 9, 2, 4, 44, 10, 478, DateTimeKind.Unspecified).AddTicks(65), "Keon5" });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 15, 17, 175, DateTimeKind.Unspecified).AddTicks(3900), "gmail.com.Padberg28@yahoo.com", "Jerod Dickinson", "1uljjo", "0847287169", 2, new DateTime(2024, 9, 14, 15, 15, 17, 175, DateTimeKind.Unspecified).AddTicks(3900), "Gisselle.Shields39" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 23, 4, 20, 37, 587, DateTimeKind.Unspecified).AddTicks(1063), "gmail.com52@hotmail.com", "Idella Kilback", "yg0k45", "0807234758", new DateTime(2024, 9, 23, 4, 20, 37, 587, DateTimeKind.Unspecified).AddTicks(1063), "Velva.Wiegand" });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 1,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Minus quia veniam velit quaerat exercitationem sed eum assumenda. Provident nisi impedit necessitatibus voluptatem officia. Nostrum earum officiis est dignissimos quis consequuntur sed iste.", new DateTime(2024, 10, 25, 20, 58, 59, 294, DateTimeKind.Local).AddTicks(2282), new DateTime(2024, 9, 25, 20, 58, 59, 294, DateTimeKind.Local).AddTicks(2243) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 2,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Accusamus laudantium qui pariatur sunt molestiae et aliquam impedit. Molestias aspernatur inventore cum recusandae voluptatibus et. Nihil ut est sed. Sequi repellendus odit nostrum earum sed commodi.", new DateTime(2024, 10, 25, 20, 58, 59, 294, DateTimeKind.Local).AddTicks(2725), new DateTime(2024, 9, 25, 20, 58, 59, 294, DateTimeKind.Local).AddTicks(2722), 2 });

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
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Sunt qui autem doloremque. Odio quis qui rerum omnis. Aliquam enim qui quae sit dolorem nobis.", new DateTime(2024, 9, 27, 20, 58, 59, 296, DateTimeKind.Local).AddTicks(5192), new DateTime(2024, 9, 26, 20, 58, 59, 296, DateTimeKind.Local).AddTicks(5190), 5 });

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
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Praesentium laudantium sed ad dicta qui aut architecto reprehenderit fuga. Non ut ex vero incidunt ut. Vel beatae in omnis itaque quo.", new DateTime(2024, 9, 27, 20, 58, 59, 298, DateTimeKind.Local).AddTicks(8908), new DateTime(2024, 9, 26, 20, 58, 59, 298, DateTimeKind.Local).AddTicks(8881), 1 });

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
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Pariatur et esse unde blanditiis doloribus repellendus sed enim. Rerum nobis debitis asperiores temporibus odio. Ullam exercitationem enim.", new DateTime(2024, 9, 27, 20, 58, 59, 305, DateTimeKind.Local).AddTicks(4330), new DateTime(2024, 9, 26, 20, 58, 59, 305, DateTimeKind.Local).AddTicks(4325), 9 });

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
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Fuga suscipit fugiat doloremque. Et magni magni aperiam sed facilis. Magnam iusto magnam. In repellendus tempore repellat molestiae.", new DateTime(2024, 9, 27, 20, 58, 59, 331, DateTimeKind.Local).AddTicks(2517), new DateTime(2024, 9, 26, 20, 58, 59, 331, DateTimeKind.Local).AddTicks(2513) });

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
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Tempora id rerum. Ratione impedit et ut eius sit reiciendis et eos voluptatibus. Qui sit odit quo voluptas nihil quia eos aut.", new DateTime(2024, 9, 27, 20, 58, 59, 334, DateTimeKind.Local).AddTicks(9810), new DateTime(2024, 9, 26, 20, 58, 59, 334, DateTimeKind.Local).AddTicks(9807) });

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
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Rerum magnam qui quis ducimus non. Optio qui dicta iure quas. Doloribus qui at qui corporis et autem tempora excepturi minima. Voluptas doloribus in consequatur. Minus qui illo ut. Ipsam veritatis dolores fugiat nemo nesciunt.", new DateTime(2024, 9, 27, 20, 58, 59, 342, DateTimeKind.Local).AddTicks(3706), new DateTime(2024, 9, 26, 20, 58, 59, 342, DateTimeKind.Local).AddTicks(3647), 6 });

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
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Neque enim molestiae laboriosam ut cum porro quis. Quam debitis quia ullam nulla. Ad dolores id dolor rerum.", new DateTime(2024, 9, 27, 20, 58, 59, 355, DateTimeKind.Local).AddTicks(3702), new DateTime(2024, 9, 26, 20, 58, 59, 355, DateTimeKind.Local).AddTicks(3648), 7 });

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
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Nader Group", new DateTime(2024, 9, 14, 8, 33, 26, 940, DateTimeKind.Unspecified).AddTicks(5472), "js31golb59", "0250466952", false, new DateTime(2024, 9, 14, 8, 33, 26, 940, DateTimeKind.Unspecified).AddTicks(5472), "Conrad Quitzon" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 3,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Fahey, Becker and Kuphal", new DateTime(2024, 9, 18, 23, 4, 5, 621, DateTimeKind.Unspecified).AddTicks(732), "ccjcwmfnbl", "0261441998", new DateTime(2024, 9, 18, 23, 4, 5, 621, DateTimeKind.Unspecified).AddTicks(732), "Scot Murphy" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 4,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Hegmann LLC", new DateTime(2024, 9, 5, 12, 7, 7, 384, DateTimeKind.Unspecified).AddTicks(1445), "o9x8mi6rm4", "0811922387", new DateTime(2024, 9, 5, 12, 7, 7, 384, DateTimeKind.Unspecified).AddTicks(1445), "Adrianna Lynch" });

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
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Greenfelder LLC", new DateTime(2024, 9, 4, 15, 3, 23, 431, DateTimeKind.Unspecified).AddTicks(8673), 2, "cmofrzg03l", "0605586477", new DateTime(2024, 9, 4, 15, 3, 23, 431, DateTimeKind.Unspecified).AddTicks(8673), "Brando Schowalter" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 8,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Lehner Inc", new DateTime(2024, 9, 3, 10, 22, 27, 607, DateTimeKind.Unspecified).AddTicks(608), "p1ng83ju7l", "0149744522", new DateTime(2024, 9, 3, 10, 22, 27, 607, DateTimeKind.Unspecified).AddTicks(608), "Raul Smitham" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_VisitProjects_Processes_ProcessId",
                table: "VisitProjects",
                column: "ProcessId",
                principalTable: "Processes",
                principalColumn: "ProcessId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VisitProjects_Visits_VisitId",
                table: "VisitProjects",
                column: "VisitId",
                principalTable: "Visits",
                principalColumn: "VisitId");
        }
    }
}
