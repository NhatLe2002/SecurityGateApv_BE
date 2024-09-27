using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecurityGateApv.Infras.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDb_4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

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
                values: new object[] { 1, new DateTime(2024, 9, 18, 8, 30, 25, 623, DateTimeKind.Utc).AddTicks(4506), "Phòng IT", "Molestias omnis ut.", new DateTime(2024, 9, 18, 8, 30, 25, 623, DateTimeKind.Utc).AddTicks(4506) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 24, 18, 35, 24, 448, DateTimeKind.Utc).AddTicks(2476), "Phòng Nhân sự", "Quos aut molestiae unde dolores debitis ad aut rerum harum.", new DateTime(2024, 9, 24, 18, 35, 24, 448, DateTimeKind.Utc).AddTicks(2476) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2024, 9, 24, 18, 55, 54, 920, DateTimeKind.Utc).AddTicks(5639), "Phòng Marketing", "Qui eum vel cum voluptatem aut qui voluptatibus quisquam ab.", new DateTime(2024, 9, 24, 18, 55, 54, 920, DateTimeKind.Utc).AddTicks(5639) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 4, new DateTime(2024, 9, 8, 10, 54, 40, 303, DateTimeKind.Utc).AddTicks(5422), "Phòng Pháp chế", "Tempora corporis corrupti voluptatem.", new DateTime(2024, 9, 8, 10, 54, 40, 303, DateTimeKind.Utc).AddTicks(5422) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 20, 14, 16, 27, 856, DateTimeKind.Utc).AddTicks(2007), "Phòng Sản xuất", "Saepe laborum vel.", new DateTime(2024, 9, 20, 14, 16, 27, 856, DateTimeKind.Utc).AddTicks(2007) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 6,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 4, new DateTime(2024, 9, 24, 3, 47, 57, 753, DateTimeKind.Utc).AddTicks(9582), "Phòng Nhân sự", "Molestiae ab accusamus aut id ad placeat voluptas.", new DateTime(2024, 9, 24, 3, 47, 57, 753, DateTimeKind.Utc).AddTicks(9582) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 7,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 10, 13, 14, 11, 678, DateTimeKind.Utc).AddTicks(1517), "Phòng Hành chính", "Et vel voluptas ut eum.", new DateTime(2024, 9, 10, 13, 14, 11, 678, DateTimeKind.Utc).AddTicks(1517) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 8,
                columns: new[] { "AcceptLevel", "CreateDate", "Description", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 12, 6, 27, 15, 454, DateTimeKind.Utc).AddTicks(1813), "Enim cum voluptate similique aperiam alias voluptates vel.", new DateTime(2024, 9, 12, 6, 27, 15, 454, DateTimeKind.Utc).AddTicks(1813) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 9,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 9, 10, 15, 35, 37, 478, DateTimeKind.Utc).AddTicks(2053), "Phòng Hành chính", "Fuga deleniti enim temporibus quam.", new DateTime(2024, 9, 10, 15, 35, 37, 478, DateTimeKind.Utc).AddTicks(2053) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 10,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2024, 9, 19, 23, 39, 33, 131, DateTimeKind.Utc).AddTicks(4733), "Phòng Sản xuất", "Quas laudantium est rerum quo numquam occaecati.", new DateTime(2024, 9, 19, 23, 39, 33, 131, DateTimeKind.Utc).AddTicks(4733) });

            migrationBuilder.UpdateData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: 1,
                columns: new[] { "CreateTime", "ProcessName" },
                values: new object[] { new DateTime(2024, 9, 24, 17, 44, 35, 260, DateTimeKind.Utc).AddTicks(8338), "Rustic Steel Shoes" });

            migrationBuilder.UpdateData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: 2,
                columns: new[] { "CreateTime", "ProcessName" },
                values: new object[] { new DateTime(2024, 9, 24, 17, 44, 35, 261, DateTimeKind.Utc).AddTicks(91), "Fantastic Granite Salad" });

            migrationBuilder.UpdateData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: 3,
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 24, 17, 44, 35, 261, DateTimeKind.Utc).AddTicks(127), "Intelligent Wooden Shoes", false });

            migrationBuilder.UpdateData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: 4,
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 24, 17, 44, 35, 261, DateTimeKind.Utc).AddTicks(153), "Refined Wooden Salad", true });

            migrationBuilder.UpdateData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: 5,
                columns: new[] { "CreateTime", "ProcessName" },
                values: new object[] { new DateTime(2024, 9, 24, 17, 44, 35, 261, DateTimeKind.Utc).AddTicks(183), "Practical Concrete Chicken" });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 1,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId" },
                values: new object[] { new Guid("e888c3d4-138d-46bd-bea6-66e3d2d7bd34"), new DateTime(2024, 9, 27, 0, 44, 35, 290, DateTimeKind.Local).AddTicks(8837), new DateTime(2024, 10, 27, 0, 44, 35, 290, DateTimeKind.Local).AddTicks(8837), 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 2,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("305ab38e-1256-4614-a2e7-4454831ca218"), new DateTime(2024, 9, 27, 0, 44, 35, 290, DateTimeKind.Local).AddTicks(9041), new DateTime(2024, 10, 27, 0, 44, 35, 290, DateTimeKind.Local).AddTicks(9041) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 3,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId" },
                values: new object[] { new Guid("5cae4542-64a4-402b-ae5f-18d7e92b4cd5"), new DateTime(2024, 9, 27, 0, 44, 35, 290, DateTimeKind.Local).AddTicks(9060), new DateTime(2024, 10, 27, 0, 44, 35, 290, DateTimeKind.Local).AddTicks(9060), 1 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 4,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("675b6228-e611-43b4-aeb0-166599800840"), new DateTime(2024, 9, 27, 0, 44, 35, 290, DateTimeKind.Local).AddTicks(9082), new DateTime(2024, 10, 27, 0, 44, 35, 290, DateTimeKind.Local).AddTicks(9082) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 5,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("d229e783-bbba-4397-9b3e-dae97c1aea64"), new DateTime(2024, 9, 27, 0, 44, 35, 290, DateTimeKind.Local).AddTicks(9091), new DateTime(2024, 10, 27, 0, 44, 35, 290, DateTimeKind.Local).AddTicks(9091) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 6,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardTypeId" },
                values: new object[] { new Guid("6937454c-35d3-4262-b2f9-b9174fa17c1e"), new DateTime(2024, 9, 27, 0, 44, 35, 290, DateTimeKind.Local).AddTicks(9109), new DateTime(2024, 10, 27, 0, 44, 35, 290, DateTimeKind.Local).AddTicks(9109), 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 7,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardTypeId" },
                values: new object[] { new Guid("c61fdcc6-c2b7-436a-9e3b-a39df1e1947d"), new DateTime(2024, 9, 27, 0, 44, 35, 290, DateTimeKind.Local).AddTicks(9117), new DateTime(2024, 10, 27, 0, 44, 35, 290, DateTimeKind.Local).AddTicks(9117), 1 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 8,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("f7237fb9-425a-4fea-9ea2-33ec774df898"), new DateTime(2024, 9, 27, 0, 44, 35, 290, DateTimeKind.Local).AddTicks(9124), new DateTime(2024, 10, 27, 0, 44, 35, 290, DateTimeKind.Local).AddTicks(9124) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 9,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId" },
                values: new object[] { new Guid("3a486339-b74e-4b25-b9c6-b99265ae584f"), new DateTime(2024, 9, 27, 0, 44, 35, 290, DateTimeKind.Local).AddTicks(9131), new DateTime(2024, 10, 27, 0, 44, 35, 290, DateTimeKind.Local).AddTicks(9131), 1 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 10,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("080fbedb-c95e-4b76-8f77-fbdee145f6a6"), new DateTime(2024, 9, 27, 0, 44, 35, 290, DateTimeKind.Local).AddTicks(9138), new DateTime(2024, 10, 27, 0, 44, 35, 290, DateTimeKind.Local).AddTicks(9138) });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 4,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 8 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 5,
                column: "UserId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 6,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 1, 10 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 7,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 6, 16 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 8,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 4, 15 });

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
                values: new object[] { 8, 24 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 11,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 3, 15 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 12,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 17 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 13,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 4, 6 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 14,
                column: "DepartmentId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 15,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 10, 19 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 16,
                column: "UserId",
                value: 22);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 17,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 1, 13 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 18,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 10 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 19,
                column: "UserId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 20,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 2, 17 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 21,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 2, 18 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 22,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 17 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 23,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 6, 13 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Image", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 44, 35, 230, DateTimeKind.Utc).AddTicks(2672), "data:image/jpeg;base64,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", new DateTime(2024, 9, 26, 17, 44, 35, 230, DateTimeKind.Utc).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Image", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 26, 17, 44, 35, 230, DateTimeKind.Utc).AddTicks(2696), "data:image/jpeg;base64,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", new DateTime(2024, 9, 26, 17, 44, 35, 230, DateTimeKind.Utc).AddTicks(2697) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Image", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 26, 17, 44, 35, 230, DateTimeKind.Utc).AddTicks(2699), "data:image/jpeg;base64,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", new DateTime(2024, 9, 26, 17, 44, 35, 230, DateTimeKind.Utc).AddTicks(2699) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Image", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 17, 44, 35, 230, DateTimeKind.Utc).AddTicks(2702), "data:image/jpeg;base64,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", new DateTime(2024, 9, 26, 17, 44, 35, 230, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Image", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 26, 17, 44, 35, 230, DateTimeKind.Utc).AddTicks(2707), "data:image/jpeg;base64,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", new DateTime(2024, 9, 26, 17, 44, 35, 230, DateTimeKind.Utc).AddTicks(2707) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Email", "FullName", "Image", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 24, 8, 39, 54, 885, DateTimeKind.Unspecified).AddTicks(7745), "gmail.com.Blanda39@yahoo.com", "Lonie Mosciski", null, "ulwkv5", "0991567878", new DateTime(2024, 9, 24, 8, 39, 54, 885, DateTimeKind.Unspecified).AddTicks(7745), "Lorine.Mann" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Email", "FullName", "Image", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 23, 12, 25, 57, 788, DateTimeKind.Unspecified).AddTicks(4181), "gmail.com.Donnelly@hotmail.com", "Lester Labadie", null, "jgb01q", "0553365070", new DateTime(2024, 9, 23, 12, 25, 57, 788, DateTimeKind.Unspecified).AddTicks(4181), "Alene4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Email", "FullName", "Image", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 16, 16, 17, 51, 94, DateTimeKind.Unspecified).AddTicks(6245), "gmail.com.Mohr95@hotmail.com", "Lane Predovic", null, "knc5r6", "0221970523", 2, new DateTime(2024, 9, 16, 16, 17, 51, 94, DateTimeKind.Unspecified).AddTicks(6245), "Bonita.Bogisich" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Email", "FullName", "Image", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 23, 16, 52, 32, 787, DateTimeKind.Unspecified).AddTicks(396), "gmail.com77@hotmail.com", "Tyra Williamson", null, "jv9inh", "0116328159", 1, new DateTime(2024, 9, 23, 16, 52, 32, 787, DateTimeKind.Unspecified).AddTicks(396), "Jalon47" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Email", "FullName", "Image", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 11, 10, 52, 29, 864, DateTimeKind.Unspecified).AddTicks(5030), "gmail.com_Towne49@gmail.com", "Cornelius Jaskolski", null, "grgy2y", "0151938174", new DateTime(2024, 9, 11, 10, 52, 29, 864, DateTimeKind.Unspecified).AddTicks(5030), "Miguel11" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Email", "FullName", "Image", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 20, 15, 37, 54, 216, DateTimeKind.Unspecified).AddTicks(7994), "gmail.com_Legros@yahoo.com", "Laron Armstrong", null, "ge2no4", "0214893544", 1, new DateTime(2024, 9, 20, 15, 37, 54, 216, DateTimeKind.Unspecified).AddTicks(7994), "Bruce53" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Email", "FullName", "Image", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 8, 14, 37, 30, 367, DateTimeKind.Unspecified).AddTicks(9963), "gmail.com_Kovacek86@gmail.com", "Milford Beer", null, "nnfyjk", "0646218918", 5, new DateTime(2024, 9, 8, 14, 37, 30, 367, DateTimeKind.Unspecified).AddTicks(9963), "Henry_Wisozk84" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Email", "FullName", "Image", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 8, 12, 16, 17, 26, DateTimeKind.Unspecified).AddTicks(8095), "gmail.com.Pagac@gmail.com", "Vidal Dickinson", null, "0cml1p", "0588937542", 5, new DateTime(2024, 9, 8, 12, 16, 17, 26, DateTimeKind.Unspecified).AddTicks(8095), "Geraldine.Witting24" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Email", "FullName", "Image", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 13, 16, 43, 25, 241, DateTimeKind.Unspecified).AddTicks(8567), "gmail.com.Walter6@hotmail.com", "Antonina Mann", null, "mj0ol5", "0595465226", new DateTime(2024, 9, 13, 16, 43, 25, 241, DateTimeKind.Unspecified).AddTicks(8567), "Elliott78" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Email", "FullName", "Image", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 16, 8, 32, 20, 893, DateTimeKind.Unspecified).AddTicks(8664), "gmail.com_Romaguera64@yahoo.com", "Vivianne Cronin", null, "khvh3f", "0360935333", 1, new DateTime(2024, 9, 16, 8, 32, 20, 893, DateTimeKind.Unspecified).AddTicks(8664), "Reanna60" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Email", "FullName", "Image", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 21, 14, 41, 46, 773, DateTimeKind.Unspecified).AddTicks(1851), "gmail.com71@hotmail.com", "Irma Rempel", null, "4g67g8", "0447578667", 3, new DateTime(2024, 9, 21, 14, 41, 46, 773, DateTimeKind.Unspecified).AddTicks(1851), "Darrick_Corwin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Email", "FullName", "Image", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 26, 2, 51, 7, 635, DateTimeKind.Unspecified).AddTicks(8708), "gmail.com_Russel@hotmail.com", "Morton Goyette", null, "wstw0a", "0149790096", 1, new DateTime(2024, 9, 26, 2, 51, 7, 635, DateTimeKind.Unspecified).AddTicks(8708), "Kyra.Bins" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Email", "FullName", "Image", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 22, 17, 10, 59, 312, DateTimeKind.Unspecified).AddTicks(4969), "gmail.com_Hodkiewicz@hotmail.com", "Dominic Jacobi", null, "i681ks", "0509532710", 5, new DateTime(2024, 9, 22, 17, 10, 59, 312, DateTimeKind.Unspecified).AddTicks(4969), "Toney_Keebler" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Email", "FullName", "Image", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 25, 12, 7, 55, 728, DateTimeKind.Unspecified).AddTicks(3257), "gmail.com24@yahoo.com", "Tyrique Wunsch", null, "u9mney", "0465510087", 5, new DateTime(2024, 9, 25, 12, 7, 55, 728, DateTimeKind.Unspecified).AddTicks(3257), "Mortimer.OKeefe64" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Email", "FullName", "Image", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 22, 9, 43, 22, 443, DateTimeKind.Unspecified).AddTicks(3949), "gmail.com.OHara@hotmail.com", "Kaylie Maggio", null, "9msl8j", "0304581793", 3, new DateTime(2024, 9, 22, 9, 43, 22, 443, DateTimeKind.Unspecified).AddTicks(3949), "Aurelio_Bayer67" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Email", "FullName", "Image", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 15, 20, 55, 59, 764, DateTimeKind.Unspecified).AddTicks(1779), "gmail.com.Frami@yahoo.com", "Warren Wolf", null, "60stzm", "0500706938", 2, new DateTime(2024, 9, 15, 20, 55, 59, 764, DateTimeKind.Unspecified).AddTicks(1779), "Lucious52" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Email", "FullName", "Image", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 1, 4, 46, 45, 906, DateTimeKind.Unspecified).AddTicks(9554), "gmail.com45@hotmail.com", "Ronny Grant", null, "qqpkpx", "0226422437", 3, new DateTime(2024, 9, 1, 4, 46, 45, 906, DateTimeKind.Unspecified).AddTicks(9554), "Rosina63" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Email", "FullName", "Image", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 7, 20, 46, 44, 831, DateTimeKind.Unspecified).AddTicks(6705), "gmail.com.Mraz@hotmail.com", "Caitlyn Boyle", null, "sbl7wz", "0844750600", 4, new DateTime(2024, 9, 7, 20, 46, 44, 831, DateTimeKind.Unspecified).AddTicks(6705), "Gino.Kuphal" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Email", "FullName", "Image", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 12, 18, 10, 2, 32, DateTimeKind.Unspecified).AddTicks(5193), "gmail.com25@hotmail.com", "Hassan Weber", null, "m1ceb4", "0209969692", 2, new DateTime(2024, 9, 12, 18, 10, 2, 32, DateTimeKind.Unspecified).AddTicks(5193), "Alaina0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Email", "FullName", "Image", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 11, 5, 2, 6, 196, DateTimeKind.Unspecified).AddTicks(8113), "gmail.com.Dicki@hotmail.com", "Delores Pfeffer", null, "xkb0v7", "0522252336", new DateTime(2024, 9, 11, 5, 2, 6, 196, DateTimeKind.Unspecified).AddTicks(8113), "Johan.Bahringer95" });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 1,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Sit qui voluptas temporibus voluptatem. Odit sit laborum dolorem deleniti laborum voluptatem. Enim distinctio consequuntur dolor maiores corrupti.", new DateTime(2024, 10, 26, 0, 44, 35, 266, DateTimeKind.Local).AddTicks(7169), new DateTime(2024, 9, 26, 0, 44, 35, 266, DateTimeKind.Local).AddTicks(7112), 2 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 2,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Atque voluptatem quidem nihil. Nisi ut facilis velit recusandae ducimus sint natus quia. Fugiat optio at sint repellat consectetur blanditiis molestiae mollitia repellat.", new DateTime(2024, 10, 26, 0, 44, 35, 266, DateTimeKind.Local).AddTicks(7693), new DateTime(2024, 9, 26, 0, 44, 35, 266, DateTimeKind.Local).AddTicks(7687) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 3,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Earum voluptates est dolor voluptatem quis maiores. Natus vitae dolores voluptas et eum ipsa et aut. Eos consequatur nostrum.", new DateTime(2024, 9, 28, 0, 44, 35, 269, DateTimeKind.Local).AddTicks(6613), new DateTime(2024, 9, 27, 0, 44, 35, 269, DateTimeKind.Local).AddTicks(6551), 1 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 4,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Quaerat exercitationem omnis at consectetur magnam. Voluptas delectus ut. Earum quod asperiores impedit quibusdam optio nemo odit minus quia. Voluptas voluptatem cupiditate autem. Et aut consectetur ea ex repellendus tenetur voluptatem quos.", new DateTime(2024, 9, 28, 0, 44, 35, 269, DateTimeKind.Local).AddTicks(6979), new DateTime(2024, 9, 27, 0, 44, 35, 269, DateTimeKind.Local).AddTicks(6975), 10 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 5,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Voluptatem ut dignissimos ut doloribus aut sed exercitationem. Cum quia ex quibusdam sapiente earum quo illo inventore. Mollitia aut non itaque unde sunt dolorem. Ut corrupti nulla maxime et officiis. Nam veritatis iste quis sed iusto fugiat in quasi. Voluptas optio aut aperiam velit.", new DateTime(2024, 9, 28, 0, 44, 35, 271, DateTimeKind.Local).AddTicks(188), new DateTime(2024, 9, 27, 0, 44, 35, 271, DateTimeKind.Local).AddTicks(150), 1 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 6,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Facilis reiciendis aut molestiae dolor molestiae quis aperiam quo. Quam est tenetur numquam. Ut odio nulla ea velit voluptas velit. Fuga ullam et laborum officiis sunt labore qui.", new DateTime(2024, 9, 28, 0, 44, 35, 271, DateTimeKind.Local).AddTicks(475), new DateTime(2024, 9, 27, 0, 44, 35, 271, DateTimeKind.Local).AddTicks(471), 3 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 7,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Et dignissimos enim officia. Cum est rerum occaecati quas et aliquid ea. Ex hic aut voluptatibus et fugiat quidem architecto hic qui. Quam non reprehenderit illo quia dignissimos.", new DateTime(2024, 9, 28, 0, 44, 35, 272, DateTimeKind.Local).AddTicks(1978), new DateTime(2024, 9, 27, 0, 44, 35, 272, DateTimeKind.Local).AddTicks(1946), 6 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 8,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Accusantium eveniet delectus aut dolor sed mollitia optio. Fuga rerum in unde sint sit est sed laudantium. Voluptate aperiam quibusdam. Corporis porro voluptatem qui et ut quia aspernatur qui. Dicta enim minus labore. Eum facilis qui sit delectus distinctio.", new DateTime(2024, 9, 28, 0, 44, 35, 272, DateTimeKind.Local).AddTicks(2273), new DateTime(2024, 9, 27, 0, 44, 35, 272, DateTimeKind.Local).AddTicks(2269) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 9,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Ut enim expedita voluptas rerum nisi. Sapiente saepe neque aut voluptas dignissimos eum eum. Aut et laborum voluptas blanditiis. Consequuntur aut atque dolorem et deserunt saepe ipsam totam. Sapiente possimus temporibus. Et explicabo exercitationem earum velit.", new DateTime(2024, 9, 28, 0, 44, 35, 273, DateTimeKind.Local).AddTicks(3558), new DateTime(2024, 9, 27, 0, 44, 35, 273, DateTimeKind.Local).AddTicks(3524), 5 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 10,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Neque sit delectus facilis consectetur eos unde. Odit enim fugiat voluptatibus. Sed et eaque. Blanditiis nihil voluptatem sit iusto sunt corrupti quos quasi voluptatum. Laudantium vero blanditiis.", new DateTime(2024, 9, 28, 0, 44, 35, 273, DateTimeKind.Local).AddTicks(3817), new DateTime(2024, 9, 27, 0, 44, 35, 273, DateTimeKind.Local).AddTicks(3813), 3 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 11,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Et perferendis voluptatem. Expedita voluptatem odit quos nesciunt occaecati voluptate deserunt dolores quibusdam. Dicta aut exercitationem eos eligendi atque. Sunt ipsa aut et odio sed mollitia rerum modi neque.", new DateTime(2024, 9, 28, 0, 44, 35, 274, DateTimeKind.Local).AddTicks(6000), new DateTime(2024, 9, 27, 0, 44, 35, 274, DateTimeKind.Local).AddTicks(5957), 4 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 12,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Distinctio incidunt et et. Commodi eligendi eum ad tenetur non dolor quasi porro. Ex voluptas et amet ratione ea. Molestiae qui blanditiis ab dolores quia mollitia ullam et excepturi.", new DateTime(2024, 9, 28, 0, 44, 35, 274, DateTimeKind.Local).AddTicks(6274), new DateTime(2024, 9, 27, 0, 44, 35, 274, DateTimeKind.Local).AddTicks(6270), 5 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 13,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Reiciendis nostrum et et maxime eaque fugit ducimus. Et molestias voluptates corporis. Sed nulla consequatur ut libero dolores reiciendis. Laboriosam facere suscipit expedita ratione maiores ut et.", new DateTime(2024, 9, 28, 0, 44, 35, 277, DateTimeKind.Local).AddTicks(6703), new DateTime(2024, 9, 27, 0, 44, 35, 277, DateTimeKind.Local).AddTicks(6653), 10 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 14,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "A blanditiis vero aut aut non molestiae. Molestiae at dolorum iusto id maxime. Ipsum sit corrupti quasi sunt.", new DateTime(2024, 9, 28, 0, 44, 35, 277, DateTimeKind.Local).AddTicks(7066), new DateTime(2024, 9, 27, 0, 44, 35, 277, DateTimeKind.Local).AddTicks(7061), 9 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 15,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Assumenda vel est totam et iusto similique quia sit enim. Sed mollitia corrupti consectetur. Nulla culpa aut non assumenda. Possimus quasi nulla quod aspernatur in unde impedit iste et.", new DateTime(2024, 9, 28, 0, 44, 35, 278, DateTimeKind.Local).AddTicks(9707), new DateTime(2024, 9, 27, 0, 44, 35, 278, DateTimeKind.Local).AddTicks(9670), 4 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 16,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Voluptatem qui tenetur. Optio consequatur voluptatem veniam. Ut ipsam neque. Fugit nulla praesentium minima doloremque nam doloribus exercitationem velit quia. Quas consectetur error vel facere aspernatur est.", new DateTime(2024, 9, 28, 0, 44, 35, 278, DateTimeKind.Local).AddTicks(9995), new DateTime(2024, 9, 27, 0, 44, 35, 278, DateTimeKind.Local).AddTicks(9991), 4 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 17,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Eum aut suscipit. Modi autem qui repudiandae sequi. Delectus consequatur minima similique rerum omnis qui quia tempora rerum. Quam veniam neque quas. Pariatur rem repellendus aut doloremque nesciunt ad aliquam voluptatem soluta. Rem necessitatibus omnis consequatur omnis odio in aliquid.", new DateTime(2024, 9, 28, 0, 44, 35, 280, DateTimeKind.Local).AddTicks(2002), new DateTime(2024, 9, 27, 0, 44, 35, 280, DateTimeKind.Local).AddTicks(1967), 3 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 18,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Quia non saepe sit aperiam. Veritatis facere aperiam corrupti velit est. Quo explicabo delectus.", new DateTime(2024, 9, 28, 0, 44, 35, 280, DateTimeKind.Local).AddTicks(2249), new DateTime(2024, 9, 27, 0, 44, 35, 280, DateTimeKind.Local).AddTicks(2245) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 19,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Odit nobis quis repudiandae ut. Laboriosam voluptatem et dolorem quae. Eos repudiandae culpa nulla.", new DateTime(2024, 9, 28, 0, 44, 35, 281, DateTimeKind.Local).AddTicks(3950), new DateTime(2024, 9, 27, 0, 44, 35, 281, DateTimeKind.Local).AddTicks(3913), 5 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 20,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Optio impedit sint veniam in quis quae quo maxime. Possimus dicta architecto aliquid ut qui tempora. Voluptates mollitia modi officiis repudiandae similique.", new DateTime(2024, 9, 28, 0, 44, 35, 281, DateTimeKind.Local).AddTicks(4223), new DateTime(2024, 9, 27, 0, 44, 35, 281, DateTimeKind.Local).AddTicks(4219), 5 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 21,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Perferendis earum eum ea incidunt ducimus. Dolores tenetur consequatur minima. Id quis debitis et sint necessitatibus hic. Blanditiis omnis quia exercitationem quia sed. In eos totam voluptas cupiditate quidem modi commodi. Eveniet voluptas sequi error fuga.", new DateTime(2024, 9, 28, 0, 44, 35, 282, DateTimeKind.Local).AddTicks(5708), new DateTime(2024, 9, 27, 0, 44, 35, 282, DateTimeKind.Local).AddTicks(5671), 7 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 22,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Officia laboriosam quos laboriosam ut et nesciunt optio laudantium totam. Voluptates magnam enim. Reprehenderit eveniet sunt nam est.", new DateTime(2024, 9, 28, 0, 44, 35, 282, DateTimeKind.Local).AddTicks(5949), new DateTime(2024, 9, 27, 0, 44, 35, 282, DateTimeKind.Local).AddTicks(5945), 4 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 23,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Sunt consequatur consequuntur ut minima ducimus. Dolores et qui perferendis. Voluptas dolorem cupiditate natus.", new DateTime(2024, 9, 28, 0, 44, 35, 283, DateTimeKind.Local).AddTicks(7312), new DateTime(2024, 9, 27, 0, 44, 35, 283, DateTimeKind.Local).AddTicks(7273), 5 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 24,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Consequatur maiores neque. Quis voluptates odio. Rerum non deserunt aut eligendi dolores itaque maiores iste.", new DateTime(2024, 9, 28, 0, 44, 35, 283, DateTimeKind.Local).AddTicks(7550), new DateTime(2024, 9, 27, 0, 44, 35, 283, DateTimeKind.Local).AddTicks(7546), 4 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 25,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Nobis omnis soluta. A pariatur sed sint sunt magnam sit doloribus natus quae. Qui est repellat. Unde eius sit consequatur repudiandae adipisci ratione. Repellendus illo impedit sapiente molestiae recusandae consequuntur.", new DateTime(2024, 9, 28, 0, 44, 35, 285, DateTimeKind.Local).AddTicks(248), new DateTime(2024, 9, 27, 0, 44, 35, 285, DateTimeKind.Local).AddTicks(208), 3 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 26,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Officia blanditiis sit amet occaecati tempore. Vero sit eius qui assumenda. Sint tempora unde dicta adipisci sint sit.", new DateTime(2024, 9, 28, 0, 44, 35, 285, DateTimeKind.Local).AddTicks(500), new DateTime(2024, 9, 27, 0, 44, 35, 285, DateTimeKind.Local).AddTicks(497), 8 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 27,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Totam perspiciatis et eveniet omnis sit illo non est. Corrupti unde voluptas rem omnis voluptatum aut possimus praesentium. Asperiores incidunt est. Enim repellat at est omnis suscipit et ea. Ipsum commodi qui fugit quod rerum corporis ut. Blanditiis a eos et officiis.", new DateTime(2024, 9, 28, 0, 44, 35, 286, DateTimeKind.Local).AddTicks(1996), new DateTime(2024, 9, 27, 0, 44, 35, 286, DateTimeKind.Local).AddTicks(1957), 4 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 28,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Omnis quos ab vitae nihil. Vel numquam consequatur facilis. Similique velit et quis ipsa et nesciunt quia earum. Possimus voluptatem earum beatae qui et qui inventore perspiciatis. Necessitatibus cumque sint. Amet velit qui.", new DateTime(2024, 9, 28, 0, 44, 35, 286, DateTimeKind.Local).AddTicks(2311), new DateTime(2024, 9, 27, 0, 44, 35, 286, DateTimeKind.Local).AddTicks(2307), 8 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 29,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Odio ad nihil quam modi dolores deleniti ut quo dicta. Eum a dolores sed aliquam similique voluptatibus velit praesentium. Assumenda quas voluptatem consectetur. Et in doloremque dolore. Laborum et quis ut dolorem totam. Autem quae qui optio rerum non voluptatem dolorem sapiente facilis.", new DateTime(2024, 9, 28, 0, 44, 35, 288, DateTimeKind.Local).AddTicks(3543), new DateTime(2024, 9, 27, 0, 44, 35, 288, DateTimeKind.Local).AddTicks(3503), 9 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 30,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Dolorem voluptate et sequi voluptatibus quasi voluptatibus. Nihil consequatur ipsam explicabo sit error rerum quia quo similique. Facilis rerum consequuntur. Qui voluptas qui dolor totam unde. Aperiam illum laborum quidem.", new DateTime(2024, 9, 28, 0, 44, 35, 288, DateTimeKind.Local).AddTicks(3834), new DateTime(2024, 9, 27, 0, 44, 35, 288, DateTimeKind.Local).AddTicks(3830), 7 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 31,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Assumenda aut doloremque ut. Sit saepe molestiae itaque voluptatem aut voluptatem sed. Quia maiores voluptas quia voluptate.", new DateTime(2024, 9, 28, 0, 44, 35, 289, DateTimeKind.Local).AddTicks(5685), new DateTime(2024, 9, 27, 0, 44, 35, 289, DateTimeKind.Local).AddTicks(5649), 1 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 32,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Voluptas aspernatur et. Neque ratione ea. Accusantium et nostrum.", new DateTime(2024, 9, 28, 0, 44, 35, 289, DateTimeKind.Local).AddTicks(5912), new DateTime(2024, 9, 27, 0, 44, 35, 289, DateTimeKind.Local).AddTicks(5902), 4 });

            migrationBuilder.UpdateData(
                table: "VisitProcesses",
                keyColumn: "VisitProcessId",
                keyValue: 1,
                columns: new[] { "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { new DateTime(2024, 10, 26, 0, 44, 35, 265, DateTimeKind.Local).AddTicks(1121), new DateTime(2024, 9, 26, 0, 44, 35, 265, DateTimeKind.Local).AddTicks(1059) });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 1,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Becker - Stokes", new DateTime(2024, 9, 26, 12, 48, 17, 550, DateTimeKind.Unspecified).AddTicks(3469), 1, "hmzd45t8kq", "0853799750", true, new DateTime(2024, 9, 26, 12, 48, 17, 550, DateTimeKind.Unspecified).AddTicks(3469), "Dominic Williamson" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 2,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Koss, Douglas and Hegmann", new DateTime(2024, 9, 5, 1, 5, 23, 828, DateTimeKind.Unspecified).AddTicks(2468), "y35vdtmnuu", "0788662882", new DateTime(2024, 9, 5, 1, 5, 23, 828, DateTimeKind.Unspecified).AddTicks(2468), "Keith Hackett" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 3,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Lockman LLC", new DateTime(2024, 9, 24, 3, 31, 18, 141, DateTimeKind.Unspecified).AddTicks(1184), 2, "2czgaebm2q", "0433830887", true, new DateTime(2024, 9, 24, 3, 31, 18, 141, DateTimeKind.Unspecified).AddTicks(1184), "Ashlee Braun" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 4,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Swift - Kling", new DateTime(2024, 9, 18, 13, 56, 6, 309, DateTimeKind.Unspecified).AddTicks(3245), "9v2aebajpq", "0255123828", new DateTime(2024, 9, 18, 13, 56, 6, 309, DateTimeKind.Unspecified).AddTicks(3245), "Keshawn Hickle" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 5,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Gaylord - Lynch", new DateTime(2024, 9, 10, 8, 3, 12, 369, DateTimeKind.Unspecified).AddTicks(8176), "c90usnsnqe", "0331274585", true, new DateTime(2024, 9, 10, 8, 3, 12, 369, DateTimeKind.Unspecified).AddTicks(8176), "Pauline Hegmann" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 6,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Toy, Bode and Schuster", new DateTime(2024, 9, 14, 18, 14, 10, 547, DateTimeKind.Unspecified).AddTicks(388), 1, "qmsqphh7d3", "0108962028", new DateTime(2024, 9, 14, 18, 14, 10, 547, DateTimeKind.Unspecified).AddTicks(388), "Milton Tromp" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 7,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Mertz, Cole and Abernathy", new DateTime(2024, 9, 8, 19, 2, 44, 447, DateTimeKind.Unspecified).AddTicks(8471), "nakn16hn0t", "0737561338", true, new DateTime(2024, 9, 8, 19, 2, 44, 447, DateTimeKind.Unspecified).AddTicks(8471), "Chanelle Kuhn" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 8,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Lueilwitz - Hammes", new DateTime(2024, 9, 19, 13, 0, 2, 28, DateTimeKind.Unspecified).AddTicks(3782), "asz53w3i38", "0799065748", false, new DateTime(2024, 9, 19, 13, 0, 2, 28, DateTimeKind.Unspecified).AddTicks(3782), "Kyla Gusikowski" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 9,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Gerhold Group", new DateTime(2024, 9, 18, 6, 15, 57, 750, DateTimeKind.Unspecified).AddTicks(224), 1, "lege78crxr", "0964428277", true, new DateTime(2024, 9, 18, 6, 15, 57, 750, DateTimeKind.Unspecified).AddTicks(224), "Savion Gerlach" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 10,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Wuckert, Kilback and Legros", new DateTime(2024, 9, 1, 19, 55, 45, 516, DateTimeKind.Unspecified).AddTicks(2638), 2, "bcgmq0fzka", "0484624694", new DateTime(2024, 9, 1, 19, 55, 45, 516, DateTimeKind.Unspecified).AddTicks(2638), "Makayla Jacobson" });

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 1,
                column: "DateRegister",
                value: new DateTime(2024, 9, 25, 0, 44, 35, 262, DateTimeKind.Local).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 2,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 17, 44, 35, 268, DateTimeKind.Utc).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 3,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 17, 44, 35, 268, DateTimeKind.Utc).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 4,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 17, 44, 35, 268, DateTimeKind.Utc).AddTicks(654));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 5,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 17, 44, 35, 268, DateTimeKind.Utc).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 6,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 17, 44, 35, 268, DateTimeKind.Utc).AddTicks(684));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Users");

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
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 20, 4, 56, 57, 986, DateTimeKind.Utc).AddTicks(5568), "Phòng R&D", "Qui odio doloremque maxime.", new DateTime(2024, 9, 20, 4, 56, 57, 986, DateTimeKind.Utc).AddTicks(5568) });

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
                columns: new[] { "AcceptLevel", "CreateDate", "Description", "UpdatedDate" },
                values: new object[] { 4, new DateTime(2024, 9, 5, 4, 58, 6, 993, DateTimeKind.Utc).AddTicks(2195), "Atque eius laboriosam dicta velit velit maiores impedit adipisci.", new DateTime(2024, 9, 5, 4, 58, 6, 993, DateTimeKind.Utc).AddTicks(2195) });

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
                columns: new[] { "CreateTime", "ProcessName" },
                values: new object[] { new DateTime(2024, 9, 24, 15, 1, 56, 562, DateTimeKind.Utc).AddTicks(4189), "Handmade Granite Pants" });

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
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 24, 15, 1, 56, 562, DateTimeKind.Utc).AddTicks(5980), "Intelligent Metal Tuna", true });

            migrationBuilder.UpdateData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: 4,
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 24, 15, 1, 56, 562, DateTimeKind.Utc).AddTicks(6000), "Practical Wooden Hat", false });

            migrationBuilder.UpdateData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: 5,
                columns: new[] { "CreateTime", "ProcessName" },
                values: new object[] { new DateTime(2024, 9, 24, 15, 1, 56, 562, DateTimeKind.Utc).AddTicks(6018), "Intelligent Fresh Chips" });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 1,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId" },
                values: new object[] { new Guid("f97fb998-cac6-4f1d-8c30-df91aa3c4c8f"), new DateTime(2024, 9, 26, 22, 1, 56, 618, DateTimeKind.Local).AddTicks(8355), new DateTime(2024, 10, 26, 22, 1, 56, 618, DateTimeKind.Local).AddTicks(8355), 1 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 2,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("dc7ecff1-6371-4e59-9af2-11f0c76ae65d"), new DateTime(2024, 9, 26, 22, 1, 56, 618, DateTimeKind.Local).AddTicks(8665), new DateTime(2024, 10, 26, 22, 1, 56, 618, DateTimeKind.Local).AddTicks(8665) });

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
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("74e7aff9-10b8-437d-926e-e37dc1fb192a"), new DateTime(2024, 9, 26, 22, 1, 56, 618, DateTimeKind.Local).AddTicks(8707), new DateTime(2024, 10, 26, 22, 1, 56, 618, DateTimeKind.Local).AddTicks(8707) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 6,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardTypeId" },
                values: new object[] { new Guid("d3d47821-a881-4653-8dd1-4aa7454e5619"), new DateTime(2024, 9, 26, 22, 1, 56, 618, DateTimeKind.Local).AddTicks(8726), new DateTime(2024, 10, 26, 22, 1, 56, 618, DateTimeKind.Local).AddTicks(8726), 1 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 7,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardTypeId" },
                values: new object[] { new Guid("ae1369d3-ec84-497c-a774-381f4a1739b0"), new DateTime(2024, 9, 26, 22, 1, 56, 618, DateTimeKind.Local).AddTicks(8734), new DateTime(2024, 10, 26, 22, 1, 56, 618, DateTimeKind.Local).AddTicks(8734), 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 8,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("3b9c3005-ef82-4cb2-a2fa-2d5b23876371"), new DateTime(2024, 9, 26, 22, 1, 56, 618, DateTimeKind.Local).AddTicks(8740), new DateTime(2024, 10, 26, 22, 1, 56, 618, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 9,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId" },
                values: new object[] { new Guid("666f60d5-4954-49f8-874b-53008418be01"), new DateTime(2024, 9, 26, 22, 1, 56, 618, DateTimeKind.Local).AddTicks(8747), new DateTime(2024, 10, 26, 22, 1, 56, 618, DateTimeKind.Local).AddTicks(8747), 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 10,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("41947d75-7cb2-47af-a82d-f30c1b849649"), new DateTime(2024, 9, 26, 22, 1, 56, 618, DateTimeKind.Local).AddTicks(8753), new DateTime(2024, 10, 26, 22, 1, 56, 618, DateTimeKind.Local).AddTicks(8753) });

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
                column: "UserId",
                value: 23);

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
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 3, 23 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 14,
                column: "DepartmentId",
                value: 7);

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
                column: "UserId",
                value: 20);

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
                column: "UserId",
                value: 18);

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 24, 20, 55, 10, 697, DateTimeKind.Unspecified).AddTicks(6479), "gmail.com_West7@yahoo.com", "Sidney Wisozk", "leh5mo", "0484157380", new DateTime(2024, 9, 24, 20, 55, 10, 697, DateTimeKind.Unspecified).AddTicks(6479), "Shania85" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 4, 16, 27, 44, 48, DateTimeKind.Unspecified).AddTicks(5029), "gmail.com78@yahoo.com", "Effie Gibson", "eoyk0s", "0619697971", new DateTime(2024, 9, 4, 16, 27, 44, 48, DateTimeKind.Unspecified).AddTicks(5029), "Annette_Hand74" });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 22, 22, 4, 29, 168, DateTimeKind.Unspecified).AddTicks(3459), "gmail.com77@gmail.com", "Raoul Fritsch", "bs14fe", "0486777244", new DateTime(2024, 9, 22, 22, 4, 29, 168, DateTimeKind.Unspecified).AddTicks(3459), "Micaela33" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 21, 19, 3, 32, 971, DateTimeKind.Unspecified).AddTicks(7250), "gmail.com.Lockman70@yahoo.com", "Jovany Reilly", "5bq0lj", "0514227000", 2, new DateTime(2024, 9, 21, 19, 3, 32, 971, DateTimeKind.Unspecified).AddTicks(7250), "Kendra_Breitenberg72" });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 21, 22, 29, 3, 509, DateTimeKind.Unspecified).AddTicks(8194), "gmail.com36@hotmail.com", "Virginie Wuckert", "wiqrb0", "0870583135", 2, new DateTime(2024, 9, 21, 22, 29, 3, 509, DateTimeKind.Unspecified).AddTicks(8194), "Willow_Hilpert38" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 26, 12, 16, 4, 402, DateTimeKind.Unspecified).AddTicks(9538), "gmail.com_Orn@gmail.com", "Theron Buckridge", "hfwm12", "0284126576", new DateTime(2024, 9, 26, 12, 16, 4, 402, DateTimeKind.Unspecified).AddTicks(9538), "Josianne_Welch" });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 22, 16, 52, 11, 968, DateTimeKind.Unspecified).AddTicks(9135), "gmail.com_Bartell99@yahoo.com", "Crawford Dickens", "la634p", "0519665316", 5, new DateTime(2024, 9, 22, 16, 52, 11, 968, DateTimeKind.Unspecified).AddTicks(9135), "Alex.Hills" });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 14, 19, 44, 24, 313, DateTimeKind.Unspecified).AddTicks(3021), "gmail.com.Hills@hotmail.com", "Emma Bosco", "jhedxa", "0353301750", new DateTime(2024, 9, 14, 19, 44, 24, 313, DateTimeKind.Unspecified).AddTicks(3021), "Lia.Funk99" });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 1,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Officiis et similique cupiditate exercitationem. Iure saepe deleniti aspernatur rerum dolorem eveniet consequatur nesciunt. Fuga et voluptatem sapiente et. Est ad consectetur adipisci perferendis. Odit accusantium dolor at magni. Aut et corrupti asperiores vel omnis error.", new DateTime(2024, 10, 25, 22, 1, 56, 574, DateTimeKind.Local).AddTicks(531), new DateTime(2024, 9, 25, 22, 1, 56, 574, DateTimeKind.Local).AddTicks(468), 1 });

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
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Asperiores perspiciatis et et et qui maiores. Qui deserunt et natus architecto vero officiis quam id. Sed in tempora sunt deleniti eum tenetur.", new DateTime(2024, 9, 27, 22, 1, 56, 588, DateTimeKind.Local).AddTicks(9691), new DateTime(2024, 9, 26, 22, 1, 56, 588, DateTimeKind.Local).AddTicks(9686) });

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
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Error soluta tenetur est consectetur. Et quas enim id et est facilis. Eum nulla laudantium rerum beatae quaerat non velit aliquam. Consequuntur corrupti consectetur qui eos tempora deleniti enim.", new DateTime(2024, 9, 27, 22, 1, 56, 591, DateTimeKind.Local).AddTicks(5146), new DateTime(2024, 9, 26, 22, 1, 56, 591, DateTimeKind.Local).AddTicks(5144), 9 });

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
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Tenetur fugiat est nam quas. Ad nesciunt quam sunt omnis corrupti impedit rerum. Atque voluptates laborum quam provident soluta et rerum earum. Recusandae dolores error consequatur.", new DateTime(2024, 9, 27, 22, 1, 56, 598, DateTimeKind.Local).AddTicks(994), new DateTime(2024, 9, 26, 22, 1, 56, 598, DateTimeKind.Local).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 19,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Rem excepturi explicabo laboriosam non quo expedita aut. Cumque ratione molestiae cupiditate est excepturi corrupti. Assumenda iste ad. Voluptatem doloremque rerum. Est molestiae autem architecto et et ut pariatur est nulla. Magnam dolor eius vel.", new DateTime(2024, 9, 27, 22, 1, 56, 600, DateTimeKind.Local).AddTicks(8345), new DateTime(2024, 9, 26, 22, 1, 56, 600, DateTimeKind.Local).AddTicks(8268), 10 });

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
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Necessitatibus enim minima. Ut corrupti ipsa laudantium dolore quia maxime. Sint expedita soluta. Reiciendis adipisci odio nam est. Itaque incidunt quia totam quis. Non velit dolorum sed voluptatem accusamus numquam libero quibusdam maiores.", new DateTime(2024, 9, 27, 22, 1, 56, 615, DateTimeKind.Local).AddTicks(6822), new DateTime(2024, 9, 26, 22, 1, 56, 615, DateTimeKind.Local).AddTicks(6772), 10 });

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
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Yost - Cronin", new DateTime(2024, 9, 7, 19, 37, 31, 179, DateTimeKind.Unspecified).AddTicks(9536), "mro4qbl7sq", "0112633713", new DateTime(2024, 9, 7, 19, 37, 31, 179, DateTimeKind.Unspecified).AddTicks(9536), "Margaret Daniel" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 3,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Kovacek - Leuschke", new DateTime(2024, 9, 22, 8, 3, 14, 359, DateTimeKind.Unspecified).AddTicks(6875), 1, "llekvzqas1", "0441545014", false, new DateTime(2024, 9, 22, 8, 3, 14, 359, DateTimeKind.Unspecified).AddTicks(6875), "Fae Kris" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 4,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Carroll, Erdman and Nicolas", new DateTime(2024, 9, 7, 13, 8, 47, 933, DateTimeKind.Unspecified).AddTicks(9821), "90yc96jdd5", "0624278818", new DateTime(2024, 9, 7, 13, 8, 47, 933, DateTimeKind.Unspecified).AddTicks(9821), "Betsy Schmeler" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 5,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Cruickshank Group", new DateTime(2024, 9, 8, 21, 9, 47, 484, DateTimeKind.Unspecified).AddTicks(7661), "awiki8nu39", "0178576530", false, new DateTime(2024, 9, 8, 21, 9, 47, 484, DateTimeKind.Unspecified).AddTicks(7661), "Gene Pollich" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 6,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Klocko - Mertz", new DateTime(2024, 9, 14, 15, 9, 11, 931, DateTimeKind.Unspecified).AddTicks(3179), 2, "54k1hvos1u", "0860263744", new DateTime(2024, 9, 14, 15, 9, 11, 931, DateTimeKind.Unspecified).AddTicks(3179), "Veronica Moen" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 7,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Streich and Sons", new DateTime(2024, 9, 12, 12, 9, 24, 616, DateTimeKind.Unspecified).AddTicks(4343), "fgdnu67pqe", "0225187916", false, new DateTime(2024, 9, 12, 12, 9, 24, 616, DateTimeKind.Unspecified).AddTicks(4343), "Unique Lowe" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 8,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Stracke Group", new DateTime(2024, 9, 9, 3, 29, 55, 234, DateTimeKind.Unspecified).AddTicks(727), "ir0pw4qyyl", "0902292846", true, new DateTime(2024, 9, 9, 3, 29, 55, 234, DateTimeKind.Unspecified).AddTicks(727), "Jazmyn Casper" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 9,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Thompson LLC", new DateTime(2024, 9, 4, 2, 26, 39, 926, DateTimeKind.Unspecified).AddTicks(984), 2, "t6ogjglyug", "0840123812", false, new DateTime(2024, 9, 4, 2, 26, 39, 926, DateTimeKind.Unspecified).AddTicks(984), "Myrtie Langworth" });

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
    }
}
