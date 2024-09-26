using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecurityGateApv.Infras.Migrations
{
    /// <inheritdoc />
    public partial class SeedData_5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { 1, new DateTime(2024, 9, 21, 6, 34, 11, 248, DateTimeKind.Utc).AddTicks(6602), "Phòng Chăm sóc khách hàng", "Quam iure non.", new DateTime(2024, 9, 21, 6, 34, 11, 248, DateTimeKind.Utc).AddTicks(6602) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 22, 18, 42, 20, 926, DateTimeKind.Utc).AddTicks(350), "Phòng Nhân sự", "Accusamus id corporis enim.", new DateTime(2024, 9, 22, 18, 42, 20, 926, DateTimeKind.Utc).AddTicks(350) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 12, 25, 59, 440, DateTimeKind.Utc).AddTicks(3325), "Phòng R&D", "Vero est ex.", new DateTime(2024, 9, 15, 12, 25, 59, 440, DateTimeKind.Utc).AddTicks(3325) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 9, 3, 20, 21, 27, 45, DateTimeKind.Utc).AddTicks(9847), "Phòng Nhân sự", "Consequuntur eum reprehenderit sunt tenetur ad eligendi qui.", new DateTime(2024, 9, 3, 20, 21, 27, 45, DateTimeKind.Utc).AddTicks(9847) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5,
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 4, 9, 20, 48, 357, DateTimeKind.Utc).AddTicks(7729), "Phòng Pháp chế", "Sit qui quod enim a quam est aut.", new DateTime(2024, 9, 4, 9, 20, 48, 357, DateTimeKind.Utc).AddTicks(7729) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 6,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 7, 11, 55, 13, 592, DateTimeKind.Utc).AddTicks(5825), "Phòng R&D", "Esse voluptatem minus dolores commodi voluptas.", new DateTime(2024, 9, 7, 11, 55, 13, 592, DateTimeKind.Utc).AddTicks(5825) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 7,
                columns: new[] { "AcceptLevel", "CreateDate", "Description", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 9, 25, 11, 53, 53, 220, DateTimeKind.Utc).AddTicks(9329), "Et accusantium nesciunt et.", new DateTime(2024, 9, 25, 11, 53, 53, 220, DateTimeKind.Utc).AddTicks(9329) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 8,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 9, 25, 13, 15, 48, 720, DateTimeKind.Utc).AddTicks(7835), "Phòng Hành chính", "Non voluptates consequuntur saepe odit minima quam nemo dolorem suscipit.", new DateTime(2024, 9, 25, 13, 15, 48, 720, DateTimeKind.Utc).AddTicks(7835) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 9,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 11, 6, 51, 1, 178, DateTimeKind.Utc).AddTicks(1393), "Phòng Pháp chế", "Et odio debitis cumque perferendis sunt.", new DateTime(2024, 9, 11, 6, 51, 1, 178, DateTimeKind.Utc).AddTicks(1393) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 10,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 4, new DateTime(2024, 9, 13, 8, 10, 17, 906, DateTimeKind.Utc).AddTicks(6360), "Phòng IT", "Et quidem aut.", new DateTime(2024, 9, 13, 8, 10, 17, 906, DateTimeKind.Utc).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProcessId",
                keyValue: 1,
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 24, 3, 37, 46, 498, DateTimeKind.Utc).AddTicks(2497), "Gorgeous Plastic Fish", false });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProcessId",
                keyValue: 2,
                columns: new[] { "CreateTime", "ProcessName" },
                values: new object[] { new DateTime(2024, 9, 24, 3, 37, 46, 498, DateTimeKind.Utc).AddTicks(4245), "Tasty Soft Gloves" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProcessId",
                keyValue: 3,
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 24, 3, 37, 46, 498, DateTimeKind.Utc).AddTicks(4273), "Rustic Steel Bacon", true });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProcessId",
                keyValue: 4,
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 24, 3, 37, 46, 498, DateTimeKind.Utc).AddTicks(4293), "Awesome Wooden Chicken", false });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProcessId",
                keyValue: 5,
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 24, 3, 37, 46, 498, DateTimeKind.Utc).AddTicks(4311), "Handmade Cotton Hat", false });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 1,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId" },
                values: new object[] { new Guid("76ab3780-b8cc-4a0a-866e-9bd546f46a97"), new DateTime(2024, 9, 26, 10, 37, 46, 532, DateTimeKind.Local).AddTicks(749), new DateTime(2024, 10, 26, 10, 37, 46, 532, DateTimeKind.Local).AddTicks(749), 1 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 2,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardTypeId" },
                values: new object[] { new Guid("1f3a948e-5e97-43cf-afef-8a7871003b4f"), new DateTime(2024, 9, 26, 10, 37, 46, 532, DateTimeKind.Local).AddTicks(917), new DateTime(2024, 10, 26, 10, 37, 46, 532, DateTimeKind.Local).AddTicks(917), 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 3,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("0f1debf3-dbb9-4063-9dc8-7566c08c5b63"), new DateTime(2024, 9, 26, 10, 37, 46, 532, DateTimeKind.Local).AddTicks(939), new DateTime(2024, 10, 26, 10, 37, 46, 532, DateTimeKind.Local).AddTicks(939) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 4,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId", "QRCardTypeId" },
                values: new object[] { new Guid("b8985168-d4ce-40f9-b138-e1fcd0415099"), new DateTime(2024, 9, 26, 10, 37, 46, 532, DateTimeKind.Local).AddTicks(948), new DateTime(2024, 10, 26, 10, 37, 46, 532, DateTimeKind.Local).AddTicks(948), 1, 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 5,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("71c864bf-9b41-4e9e-a140-d1f34c02bec0"), new DateTime(2024, 9, 26, 10, 37, 46, 532, DateTimeKind.Local).AddTicks(956), new DateTime(2024, 10, 26, 10, 37, 46, 532, DateTimeKind.Local).AddTicks(956) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 6,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId" },
                values: new object[] { new Guid("eac4d56a-17fd-428f-8ec8-5874184a3c42"), new DateTime(2024, 9, 26, 10, 37, 46, 532, DateTimeKind.Local).AddTicks(963), new DateTime(2024, 10, 26, 10, 37, 46, 532, DateTimeKind.Local).AddTicks(963), 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 7,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("87e28ded-8302-4f08-8407-535cd548c029"), new DateTime(2024, 9, 26, 10, 37, 46, 532, DateTimeKind.Local).AddTicks(970), new DateTime(2024, 10, 26, 10, 37, 46, 532, DateTimeKind.Local).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 8,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardTypeId" },
                values: new object[] { new Guid("fa5d6e8d-1fe8-4001-809a-29e578998bb2"), new DateTime(2024, 9, 26, 10, 37, 46, 532, DateTimeKind.Local).AddTicks(977), new DateTime(2024, 10, 26, 10, 37, 46, 532, DateTimeKind.Local).AddTicks(977), 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 9,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("b482ac66-b645-4531-8778-233c1cc82c2c"), new DateTime(2024, 9, 26, 10, 37, 46, 532, DateTimeKind.Local).AddTicks(989), new DateTime(2024, 10, 26, 10, 37, 46, 532, DateTimeKind.Local).AddTicks(989) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 10,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("62e19307-2f5c-4ce6-ba81-3ffa603e9106"), new DateTime(2024, 9, 26, 10, 37, 46, 532, DateTimeKind.Local).AddTicks(996), new DateTime(2024, 10, 26, 10, 37, 46, 532, DateTimeKind.Local).AddTicks(996) });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 4,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 10, 9 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 5,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 2, 21 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 6,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 2, 21 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 7,
                column: "UserId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 8,
                column: "UserId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 9,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 2, 11 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 10,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 20 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 11,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 14 });

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
                values: new object[] { 3, 23 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 14,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 2, 12 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 15,
                column: "UserId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 16,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 3, 11 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 17,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 4, 21 });

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
                column: "UserId",
                value: 21);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 20,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 10, 24 });

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
                values: new object[] { 1, 21 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 23,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 3, 20 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 3, 37, 46, 489, DateTimeKind.Utc).AddTicks(457), new DateTime(2024, 9, 26, 3, 37, 46, 489, DateTimeKind.Utc).AddTicks(464) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 26, 3, 37, 46, 489, DateTimeKind.Utc).AddTicks(467), new DateTime(2024, 9, 26, 3, 37, 46, 489, DateTimeKind.Utc).AddTicks(467) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 26, 3, 37, 46, 489, DateTimeKind.Utc).AddTicks(469), new DateTime(2024, 9, 26, 3, 37, 46, 489, DateTimeKind.Utc).AddTicks(470) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 3, 37, 46, 489, DateTimeKind.Utc).AddTicks(472), new DateTime(2024, 9, 26, 3, 37, 46, 489, DateTimeKind.Utc).AddTicks(472) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 26, 3, 37, 46, 489, DateTimeKind.Utc).AddTicks(474), new DateTime(2024, 9, 26, 3, 37, 46, 489, DateTimeKind.Utc).AddTicks(474) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 24, 6, 46, 55, 959, DateTimeKind.Unspecified).AddTicks(2103), "gmail.com43@yahoo.com", "King Torp", "0imnq9", "0802649440", new DateTime(2024, 9, 24, 6, 46, 55, 959, DateTimeKind.Unspecified).AddTicks(2103), "Jordan37" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 12, 19, 18, 24, 930, DateTimeKind.Unspecified).AddTicks(2141), "gmail.com.Johns@yahoo.com", "Gavin Marvin", "7jzda5", "0601503519", 1, new DateTime(2024, 9, 12, 19, 18, 24, 930, DateTimeKind.Unspecified).AddTicks(2141), "Jaeden_Rippin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 11, 6, 52, 5, 994, DateTimeKind.Unspecified).AddTicks(5987), "gmail.com16@yahoo.com", "Vince Anderson", "5icz3x", "0356080466", 4, new DateTime(2024, 9, 11, 6, 52, 5, 994, DateTimeKind.Unspecified).AddTicks(5987), "Willis_Rogahn99" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 15, 3, 41, 26, 998, DateTimeKind.Unspecified).AddTicks(7127), "gmail.com_Johns77@hotmail.com", "Josefina Lind", "wapuio", "0217542496", 4, new DateTime(2024, 9, 15, 3, 41, 26, 998, DateTimeKind.Unspecified).AddTicks(7127), "Mellie95" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 15, 8, 28, 32, 458, DateTimeKind.Unspecified).AddTicks(6272), "gmail.com_Hahn38@gmail.com", "Myron Dooley", "7berxh", "0382593385", 1, new DateTime(2024, 9, 15, 8, 28, 32, 458, DateTimeKind.Unspecified).AddTicks(6272), "Bernita37" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 22, 9, 946, DateTimeKind.Unspecified).AddTicks(7338), "gmail.com_Schoen58@yahoo.com", "Trystan Ortiz", "rem8qq", "0790122859", new DateTime(2024, 9, 14, 15, 22, 9, 946, DateTimeKind.Unspecified).AddTicks(7338), "Melyssa_MacGyver55" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 12, 9, 7, 3, 242, DateTimeKind.Unspecified).AddTicks(5109), "gmail.com18@hotmail.com", "Porter D'Amore", "3a8f6i", "0234341175", 4, new DateTime(2024, 9, 12, 9, 7, 3, 242, DateTimeKind.Unspecified).AddTicks(5109), "Madelynn83" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 17, 17, 37, 37, 226, DateTimeKind.Unspecified).AddTicks(8961), "gmail.com23@gmail.com", "Timothy Littel", "exdp90", "0424770673", 2, new DateTime(2024, 9, 17, 17, 37, 37, 226, DateTimeKind.Unspecified).AddTicks(8961), "Keshaun_Steuber" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 19, 9, 51, 13, 329, DateTimeKind.Unspecified).AddTicks(5580), "gmail.com.Balistreri@hotmail.com", "Stewart Purdy", "nf16z6", "0703612668", 5, new DateTime(2024, 9, 19, 9, 51, 13, 329, DateTimeKind.Unspecified).AddTicks(5580), "Verner59" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 13, 23, 46, 42, 483, DateTimeKind.Unspecified).AddTicks(8899), "gmail.com_Mraz@gmail.com", "Alice Roob", "k2p1ex", "0618048868", 3, new DateTime(2024, 9, 13, 23, 46, 42, 483, DateTimeKind.Unspecified).AddTicks(8899), "Damon.Buckridge65" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 14, 1, 13, 4, 651, DateTimeKind.Unspecified).AddTicks(4847), "gmail.com_Heathcote@yahoo.com", "Johann Pfeffer", "ayvs6t", "0846020965", 4, new DateTime(2024, 9, 14, 1, 13, 4, 651, DateTimeKind.Unspecified).AddTicks(4847), "Macy.Smitham" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 7, 21, 47, 24, 526, DateTimeKind.Unspecified).AddTicks(7138), "gmail.com2@yahoo.com", "Ludie Conroy", "mp54ev", "0846285375", 5, new DateTime(2024, 9, 7, 21, 47, 24, 526, DateTimeKind.Unspecified).AddTicks(7138), "Alfonso_Goyette27" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 6, 14, 59, 47, 522, DateTimeKind.Unspecified).AddTicks(8540), "gmail.com_Runolfsson@hotmail.com", "Jerad Lowe", "1tmdem", "0274544479", 5, new DateTime(2024, 9, 6, 14, 59, 47, 522, DateTimeKind.Unspecified).AddTicks(8540), "Estevan.Mitchell" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 12, 11, 45, 18, 666, DateTimeKind.Unspecified).AddTicks(378), "gmail.com_Mayert26@gmail.com", "Janis Gutkowski", "wptsg8", "0981421746", new DateTime(2024, 9, 12, 11, 45, 18, 666, DateTimeKind.Unspecified).AddTicks(378), "Cheyanne41" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 10, 16, 14, 45, 586, DateTimeKind.Unspecified).AddTicks(4452), "gmail.com.Kuphal95@hotmail.com", "Dillon Grant", "f6gngb", "0498073103", new DateTime(2024, 9, 10, 16, 14, 45, 586, DateTimeKind.Unspecified).AddTicks(4452), "Margie_Cummerata72" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 11, 3, 23, 36, 596, DateTimeKind.Unspecified).AddTicks(4054), "gmail.com97@hotmail.com", "Junius Kautzer", "285io9", "0223839799", 4, new DateTime(2024, 9, 11, 3, 23, 36, 596, DateTimeKind.Unspecified).AddTicks(4054), "Eva27" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 11, 1, 12, 12, 34, DateTimeKind.Unspecified).AddTicks(2285), "gmail.com.Mohr30@gmail.com", "Britney Dach", "er87iz", "0238522230", new DateTime(2024, 9, 11, 1, 12, 12, 34, DateTimeKind.Unspecified).AddTicks(2285), "Fredrick81" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 9, 4, 55, 15, 219, DateTimeKind.Unspecified).AddTicks(8965), "gmail.com.Feeney@gmail.com", "Dale King", "uomu6y", "0866935268", 2, new DateTime(2024, 9, 9, 4, 55, 15, 219, DateTimeKind.Unspecified).AddTicks(8965), "Pete_Kohler71" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 14, 7, 10, 36, 659, DateTimeKind.Unspecified).AddTicks(9504), "gmail.com60@gmail.com", "Talon Harber", "g6baxt", "0900914495", 5, new DateTime(2024, 9, 14, 7, 10, 36, 659, DateTimeKind.Unspecified).AddTicks(9504), "Elda.Collins58" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 1, 11, 10, 19, 518, DateTimeKind.Unspecified).AddTicks(745), "gmail.com_Swaniawski@gmail.com", "London Douglas", "o5olbu", "0357180130", 5, new DateTime(2024, 9, 1, 11, 10, 19, 518, DateTimeKind.Unspecified).AddTicks(745), "Anastacio_DuBuque24" });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 1,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Perferendis rem eum quibusdam accusantium tenetur. Ea distinctio nesciunt fugiat beatae dicta ab nisi quaerat minima. Possimus consectetur sit consectetur aliquid voluptatem quisquam repellendus. Iure eum sit.", new DateTime(2024, 10, 25, 10, 37, 46, 510, DateTimeKind.Local).AddTicks(797), new DateTime(2024, 9, 25, 10, 37, 46, 510, DateTimeKind.Local).AddTicks(742) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 2,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Dolorum assumenda accusantium ea eligendi saepe et dolores. Ea provident officiis fugiat temporibus voluptatum. Velit nesciunt temporibus perspiciatis qui. Vitae nulla qui officiis quia. Saepe est rerum non aliquid nisi aut optio. Reprehenderit animi est minima eaque voluptatem.", new DateTime(2024, 10, 25, 10, 37, 46, 510, DateTimeKind.Local).AddTicks(1243), new DateTime(2024, 9, 25, 10, 37, 46, 510, DateTimeKind.Local).AddTicks(1241) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 3,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Doloribus delectus consequatur et et veritatis harum et atque qui. Eos ratione nostrum. Magnam temporibus quam sed dolor repellendus.", new DateTime(2024, 9, 27, 10, 37, 46, 512, DateTimeKind.Local).AddTicks(3742), new DateTime(2024, 9, 26, 10, 37, 46, 512, DateTimeKind.Local).AddTicks(3707), 5 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 4,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Quia at facere ut ipsa explicabo rerum officiis. Exercitationem est totam nisi sint cupiditate suscipit voluptas labore unde. Blanditiis repellat nam sit sed. Corrupti deserunt tempore sit deserunt repellendus a aut provident rerum. Ut et et sapiente.", new DateTime(2024, 9, 27, 10, 37, 46, 512, DateTimeKind.Local).AddTicks(4021), new DateTime(2024, 9, 26, 10, 37, 46, 512, DateTimeKind.Local).AddTicks(4018), 2 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 5,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Facere beatae quia. Ipsa fuga autem quo praesentium sit. Magni dolor eum dolorem et. Soluta voluptatem qui deleniti. Libero recusandae qui voluptatibus rerum quam dignissimos perferendis. Alias cupiditate quis qui veritatis qui deleniti.", new DateTime(2024, 9, 27, 10, 37, 46, 513, DateTimeKind.Local).AddTicks(4735), new DateTime(2024, 9, 26, 10, 37, 46, 513, DateTimeKind.Local).AddTicks(4710), 8 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 6,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Voluptatum quasi dolorem cumque. Harum quam eaque nisi ut placeat autem et nisi. Reprehenderit id vel architecto consectetur veritatis laborum voluptatibus ducimus.", new DateTime(2024, 9, 27, 10, 37, 46, 513, DateTimeKind.Local).AddTicks(4945), new DateTime(2024, 9, 26, 10, 37, 46, 513, DateTimeKind.Local).AddTicks(4943), 3 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 7,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Commodi omnis deserunt dolor nesciunt. Mollitia quidem sit nostrum facere nobis blanditiis nulla omnis nobis. Facilis modi modi totam eligendi vero atque tempore qui sed.", new DateTime(2024, 9, 27, 10, 37, 46, 514, DateTimeKind.Local).AddTicks(5875), new DateTime(2024, 9, 26, 10, 37, 46, 514, DateTimeKind.Local).AddTicks(5849), 6 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 8,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Et ipsum laboriosam. Ut aut officia nesciunt vel qui quia odit eum exercitationem. Alias odio quae accusamus aut autem perferendis sed. Eum et nobis necessitatibus non blanditiis numquam nisi cumque tempore. Non dolor quae. Doloremque et minus quia adipisci dolor totam.", new DateTime(2024, 9, 27, 10, 37, 46, 514, DateTimeKind.Local).AddTicks(6147), new DateTime(2024, 9, 26, 10, 37, 46, 514, DateTimeKind.Local).AddTicks(6145), 1 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 9,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Vel est quo dolor. Quidem aspernatur occaecati sed aut sed necessitatibus saepe. Quo commodi et consequatur aut qui accusantium necessitatibus ducimus cumque. Et omnis delectus blanditiis tempora iusto.", new DateTime(2024, 9, 27, 10, 37, 46, 515, DateTimeKind.Local).AddTicks(6859), new DateTime(2024, 9, 26, 10, 37, 46, 515, DateTimeKind.Local).AddTicks(6834), 8 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 10,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Quos maiores at consequuntur quidem doloremque velit ullam facere sed. Quaerat officia officia et totam atque. Est ut sunt iusto earum natus laborum. Dolores eius autem architecto et eaque. Autem alias vitae consequuntur aut.", new DateTime(2024, 9, 27, 10, 37, 46, 515, DateTimeKind.Local).AddTicks(7099), new DateTime(2024, 9, 26, 10, 37, 46, 515, DateTimeKind.Local).AddTicks(7097), 9 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 11,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Itaque velit exercitationem a iste assumenda minus est a commodi. Et voluptas similique omnis. Temporibus neque voluptatum veniam excepturi voluptatem voluptate commodi porro. Quia eum voluptas soluta accusamus ea cum culpa. Consequatur beatae velit odio. Laboriosam officiis quo sed recusandae.", new DateTime(2024, 9, 27, 10, 37, 46, 516, DateTimeKind.Local).AddTicks(7719), new DateTime(2024, 9, 26, 10, 37, 46, 516, DateTimeKind.Local).AddTicks(7693), 2 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 12,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Laborum et voluptatum. Aut eos id laboriosam et atque soluta deleniti beatae odio. Voluptatum unde in dolor ipsa provident mollitia officiis enim. Molestiae vel et veritatis rerum minima perferendis dolorem.", new DateTime(2024, 9, 27, 10, 37, 46, 516, DateTimeKind.Local).AddTicks(7951), new DateTime(2024, 9, 26, 10, 37, 46, 516, DateTimeKind.Local).AddTicks(7949), 2 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 13,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Autem ullam cum perferendis dolorem cupiditate laborum. Impedit et quos fugit quis autem ea. Accusamus et ducimus quia animi debitis sapiente minus quia. Et necessitatibus incidunt adipisci laboriosam ut quod libero et. Quos ducimus beatae eum. Quibusdam excepturi atque in.", new DateTime(2024, 9, 27, 10, 37, 46, 519, DateTimeKind.Local).AddTicks(5570), new DateTime(2024, 9, 26, 10, 37, 46, 519, DateTimeKind.Local).AddTicks(5542), 3 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 14,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Assumenda autem fuga dolorum optio deserunt ab quasi sunt. Qui perspiciatis repellendus inventore inventore ea. Harum sed nihil quia consequatur qui eligendi eligendi. Perferendis ea optio vero qui fuga sed alias maxime. Aperiam ullam qui adipisci eligendi.", new DateTime(2024, 9, 27, 10, 37, 46, 519, DateTimeKind.Local).AddTicks(5831), new DateTime(2024, 9, 26, 10, 37, 46, 519, DateTimeKind.Local).AddTicks(5829), 6 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 15,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Sit itaque necessitatibus ab unde mollitia necessitatibus corporis aperiam. Quia velit accusamus et est et ipsa aut recusandae quisquam. Qui molestias iure. Sit magnam et consequuntur.", new DateTime(2024, 9, 27, 10, 37, 46, 520, DateTimeKind.Local).AddTicks(7109), new DateTime(2024, 9, 26, 10, 37, 46, 520, DateTimeKind.Local).AddTicks(7083), 5 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 16,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Qui aut vel eius beatae magnam dolores consequatur. Id sint eum minima voluptatem eum molestiae vitae omnis. Temporibus modi culpa voluptas in voluptatibus. Voluptatem hic odit. Voluptatem earum in est enim et laborum rerum beatae. Eos dolorem magnam.", new DateTime(2024, 9, 27, 10, 37, 46, 520, DateTimeKind.Local).AddTicks(7360), new DateTime(2024, 9, 26, 10, 37, 46, 520, DateTimeKind.Local).AddTicks(7358), 7 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 17,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Quod sed quis quaerat unde nulla. Ad dolores enim ducimus quisquam occaecati vel et. Non ullam exercitationem nisi veniam illo cupiditate dolores voluptas doloremque. Vel non beatae sed nobis aut perspiciatis corrupti qui. Inventore aliquid harum molestiae tenetur earum accusantium earum. Vel perspiciatis quis dolor et quos aut voluptate.", new DateTime(2024, 9, 27, 10, 37, 46, 521, DateTimeKind.Local).AddTicks(8268), new DateTime(2024, 9, 26, 10, 37, 46, 521, DateTimeKind.Local).AddTicks(8242), 5 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 18,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Et et et quo voluptates ullam quis. Nulla veniam ea est facilis quia iure consequuntur a ut. Sed debitis explicabo dicta expedita beatae est omnis praesentium. Ipsa aut similique.", new DateTime(2024, 9, 27, 10, 37, 46, 521, DateTimeKind.Local).AddTicks(8497), new DateTime(2024, 9, 26, 10, 37, 46, 521, DateTimeKind.Local).AddTicks(8495) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 19,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Nobis sunt voluptas aut deserunt iure rerum dolores similique suscipit. Vel odio inventore ut eum corporis reiciendis. Fugit repellendus magnam tempore occaecati sunt. Quas et cumque est ut repudiandae atque libero. Ad maxime amet ab nesciunt illum animi dolore.", new DateTime(2024, 9, 27, 10, 37, 46, 523, DateTimeKind.Local).AddTicks(2110), new DateTime(2024, 9, 26, 10, 37, 46, 523, DateTimeKind.Local).AddTicks(2075), 8 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 20,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Facere quia accusantium delectus eveniet omnis in ratione nihil officia. Repellendus magnam sunt et nesciunt deserunt sunt reprehenderit velit. Aspernatur quia et quae et qui tempora repellat et. Qui ut qui impedit aspernatur dolor deleniti rerum provident. Distinctio dicta pariatur sit eos.", new DateTime(2024, 9, 27, 10, 37, 46, 523, DateTimeKind.Local).AddTicks(2414), new DateTime(2024, 9, 26, 10, 37, 46, 523, DateTimeKind.Local).AddTicks(2412), 10 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 21,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Velit nihil enim repellendus. Facere perspiciatis commodi numquam dignissimos facere. Quia voluptatem ipsum inventore sunt non dolore ea nihil. Error sint incidunt rerum modi aut. Vel sapiente debitis eos. Voluptatibus distinctio rem quidem laudantium quia incidunt dolores itaque repellendus.", new DateTime(2024, 9, 27, 10, 37, 46, 524, DateTimeKind.Local).AddTicks(4487), new DateTime(2024, 9, 26, 10, 37, 46, 524, DateTimeKind.Local).AddTicks(4454), 6 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 22,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Ullam ullam ex deleniti similique quis quia totam qui aspernatur. Labore voluptatem aliquid aspernatur possimus. Veritatis autem ut maxime ipsum.", new DateTime(2024, 9, 27, 10, 37, 46, 524, DateTimeKind.Local).AddTicks(4791), new DateTime(2024, 9, 26, 10, 37, 46, 524, DateTimeKind.Local).AddTicks(4788), 2 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 23,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Placeat culpa tempora id dolorem qui sunt aspernatur distinctio. Laborum dolores corporis totam. Dolores sit explicabo aut vel velit earum natus.", new DateTime(2024, 9, 27, 10, 37, 46, 525, DateTimeKind.Local).AddTicks(5537), new DateTime(2024, 9, 26, 10, 37, 46, 525, DateTimeKind.Local).AddTicks(5510), 5 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 24,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Eligendi magnam nulla nisi. Labore laudantium quasi perspiciatis eveniet voluptatem vel adipisci magni ut. Enim asperiores omnis sapiente odit molestiae eveniet velit eos. Est aut pariatur voluptatem sed reprehenderit quam. Fugiat dignissimos corrupti dolor et at vitae qui culpa et. Eum qui dicta est eius.", new DateTime(2024, 9, 27, 10, 37, 46, 525, DateTimeKind.Local).AddTicks(5814), new DateTime(2024, 9, 26, 10, 37, 46, 525, DateTimeKind.Local).AddTicks(5812), 8 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 25,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Iure similique consectetur. Eum omnis iusto vero ea quibusdam ab sint. Labore sapiente nesciunt voluptatem velit et velit magni rerum explicabo. Sit sed quia id ut amet cupiditate. Voluptas iusto aut enim.", new DateTime(2024, 9, 27, 10, 37, 46, 526, DateTimeKind.Local).AddTicks(6620), new DateTime(2024, 9, 26, 10, 37, 46, 526, DateTimeKind.Local).AddTicks(6594), 1 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 26,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Dignissimos ut eos provident dicta. Omnis ab aut et provident dolores aspernatur laboriosam. Ipsa deleniti iste aut ea natus quibusdam. Eaque aliquam consequatur ut.", new DateTime(2024, 9, 27, 10, 37, 46, 526, DateTimeKind.Local).AddTicks(6835), new DateTime(2024, 9, 26, 10, 37, 46, 526, DateTimeKind.Local).AddTicks(6833), 10 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 27,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Unde perferendis quasi doloribus architecto rerum. Dolorum est vel perspiciatis reprehenderit quaerat optio. Ipsam ullam rerum qui nesciunt.", new DateTime(2024, 9, 27, 10, 37, 46, 527, DateTimeKind.Local).AddTicks(7475), new DateTime(2024, 9, 26, 10, 37, 46, 527, DateTimeKind.Local).AddTicks(7449) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 28,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Ab dicta qui maiores sint aut. Soluta quas deleniti. Assumenda ea ut. Omnis neque sint corporis accusamus quia quam modi adipisci fuga. At eligendi sint soluta. Necessitatibus enim deserunt consequatur reiciendis nesciunt sit.", new DateTime(2024, 9, 27, 10, 37, 46, 527, DateTimeKind.Local).AddTicks(7714), new DateTime(2024, 9, 26, 10, 37, 46, 527, DateTimeKind.Local).AddTicks(7712), 3 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 29,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Eos saepe in modi est neque possimus consequatur eum. Voluptate quis explicabo nobis doloremque eum maiores sunt id. Quaerat ut dolorem vel necessitatibus non ullam expedita error. Sunt at distinctio repudiandae ea autem. Qui pariatur quo minima fugit.", new DateTime(2024, 9, 27, 10, 37, 46, 529, DateTimeKind.Local).AddTicks(6758), new DateTime(2024, 9, 26, 10, 37, 46, 529, DateTimeKind.Local).AddTicks(6724) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 30,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Qui velit consequatur labore eius. Expedita aliquam quos praesentium enim qui debitis quaerat. Exercitationem maxime et sequi dolores. Ut occaecati et consequuntur est esse.", new DateTime(2024, 9, 27, 10, 37, 46, 529, DateTimeKind.Local).AddTicks(6978), new DateTime(2024, 9, 26, 10, 37, 46, 529, DateTimeKind.Local).AddTicks(6976), 8 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 31,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Iusto blanditiis id ut placeat quia molestiae eos illum. Animi sint nobis adipisci. Consectetur voluptates similique officia accusantium.", new DateTime(2024, 9, 27, 10, 37, 46, 530, DateTimeKind.Local).AddTicks(8160), new DateTime(2024, 9, 26, 10, 37, 46, 530, DateTimeKind.Local).AddTicks(8124), 1 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 32,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Omnis ab officia sit atque ratione eum aperiam. Necessitatibus totam alias labore. Eos dignissimos ab ut quia.", new DateTime(2024, 9, 27, 10, 37, 46, 530, DateTimeKind.Local).AddTicks(8368), new DateTime(2024, 9, 26, 10, 37, 46, 530, DateTimeKind.Local).AddTicks(8366) });

            migrationBuilder.UpdateData(
                table: "VisitProjects",
                keyColumn: "VisitProcessId",
                keyValue: 1,
                columns: new[] { "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { new DateTime(2024, 10, 25, 10, 37, 46, 500, DateTimeKind.Local).AddTicks(6558), new DateTime(2024, 9, 25, 10, 37, 46, 500, DateTimeKind.Local).AddTicks(6521) });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 1,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Marquardt - Yundt", new DateTime(2024, 9, 18, 5, 17, 24, 30, DateTimeKind.Unspecified).AddTicks(9787), "pvc7uan331", "0490385705", false, new DateTime(2024, 9, 18, 5, 17, 24, 30, DateTimeKind.Unspecified).AddTicks(9787), "Sandrine Leuschke" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 2,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Green - O'Reilly", new DateTime(2024, 9, 13, 14, 55, 0, 674, DateTimeKind.Unspecified).AddTicks(3630), 1, "s6er3nssjs", "0383993078", new DateTime(2024, 9, 13, 14, 55, 0, 674, DateTimeKind.Unspecified).AddTicks(3630), "Drew Stanton" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 3,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Ebert LLC", new DateTime(2024, 9, 9, 4, 0, 41, 603, DateTimeKind.Unspecified).AddTicks(5646), "4ns90cdp5u", "0891297487", new DateTime(2024, 9, 9, 4, 0, 41, 603, DateTimeKind.Unspecified).AddTicks(5646), "Sherwood Farrell" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 4,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Carter, Carroll and Wehner", new DateTime(2024, 9, 23, 21, 41, 9, 449, DateTimeKind.Unspecified).AddTicks(7119), "zav15xkr1t", "0376460894", new DateTime(2024, 9, 23, 21, 41, 9, 449, DateTimeKind.Unspecified).AddTicks(7119), "Alessandro Effertz" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 5,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Hoppe, Zboncak and Wyman", new DateTime(2024, 9, 16, 3, 57, 47, 302, DateTimeKind.Unspecified).AddTicks(4037), "p82hnkwaqp", "0989444664", true, new DateTime(2024, 9, 16, 3, 57, 47, 302, DateTimeKind.Unspecified).AddTicks(4037), "Liza Ernser" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 6,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Blanda, Halvorson and Hand", new DateTime(2024, 9, 5, 8, 33, 52, 310, DateTimeKind.Unspecified).AddTicks(1414), 2, "0q2vzusmvv", "0637470226", false, new DateTime(2024, 9, 5, 8, 33, 52, 310, DateTimeKind.Unspecified).AddTicks(1414), "Destin Gottlieb" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 7,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Erdman - Lowe", new DateTime(2024, 9, 6, 23, 5, 50, 586, DateTimeKind.Unspecified).AddTicks(6761), "8m1qqp38zp", "0570849680", false, new DateTime(2024, 9, 6, 23, 5, 50, 586, DateTimeKind.Unspecified).AddTicks(6761), "Braulio Cormier" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 8,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Wisozk and Sons", new DateTime(2024, 9, 22, 21, 33, 42, 723, DateTimeKind.Unspecified).AddTicks(7889), "nr6x3jq57f", "0883931216", new DateTime(2024, 9, 22, 21, 33, 42, 723, DateTimeKind.Unspecified).AddTicks(7889), "Roderick Dooley" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 9,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "McDermott, Larson and Jast", new DateTime(2024, 9, 3, 16, 49, 31, 156, DateTimeKind.Unspecified).AddTicks(2632), "alg07j5uo3", "0975273201", new DateTime(2024, 9, 3, 16, 49, 31, 156, DateTimeKind.Unspecified).AddTicks(2632), "Lorenza Haag" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 10,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Batz, Walter and Lehner", new DateTime(2024, 9, 14, 7, 6, 38, 637, DateTimeKind.Unspecified).AddTicks(7634), 2, "xqr9rp76gp", "0149874652", false, new DateTime(2024, 9, 14, 7, 6, 38, 637, DateTimeKind.Unspecified).AddTicks(7634), "Ilene Fisher" });

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 1,
                column: "DateRegister",
                value: new DateTime(2024, 9, 24, 10, 37, 46, 499, DateTimeKind.Local).AddTicks(5245));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 2,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 3, 37, 46, 511, DateTimeKind.Utc).AddTicks(2361));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 3,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 3, 37, 46, 511, DateTimeKind.Utc).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 4,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 3, 37, 46, 511, DateTimeKind.Utc).AddTicks(2533));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 5,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 3, 37, 46, 511, DateTimeKind.Utc).AddTicks(2542));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 6,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 3, 37, 46, 511, DateTimeKind.Utc).AddTicks(2551));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 9, 11, 22, 10, 40, 619, DateTimeKind.Utc).AddTicks(1274), "Phòng Marketing", "Adipisci numquam et dolor autem odio sed autem aut.", new DateTime(2024, 9, 11, 22, 10, 40, 619, DateTimeKind.Utc).AddTicks(1274) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 23, 7, 8, 288, DateTimeKind.Utc).AddTicks(3762), "Phòng Kinh doanh", "Sed voluptas architecto eum aut.", new DateTime(2024, 9, 3, 23, 7, 8, 288, DateTimeKind.Utc).AddTicks(3762) });

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
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 6, 13, 45, 34, 567, DateTimeKind.Utc).AddTicks(1628), "Phòng IT", "Nobis temporibus consequatur.", new DateTime(2024, 9, 6, 13, 45, 34, 567, DateTimeKind.Utc).AddTicks(1628) });

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
                columns: new[] { "AcceptLevel", "CreateDate", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 21, 1, 48, 6, 245, DateTimeKind.Utc).AddTicks(1912), "Non recusandae fuga qui non.", new DateTime(2024, 9, 21, 1, 48, 6, 245, DateTimeKind.Utc).AddTicks(1912) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 8,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 2, 15, 49, 13, 978, DateTimeKind.Utc).AddTicks(6457), "Phòng Kinh doanh", "Aut sunt tempore qui.", new DateTime(2024, 9, 2, 15, 49, 13, 978, DateTimeKind.Utc).AddTicks(6457) });

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
                columns: new[] { "CreateTime", "ProcessName" },
                values: new object[] { new DateTime(2024, 9, 24, 3, 36, 14, 614, DateTimeKind.Utc).AddTicks(7186), "Licensed Frozen Chair" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProcessId",
                keyValue: 3,
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 24, 3, 36, 14, 614, DateTimeKind.Utc).AddTicks(7215), "Gorgeous Rubber Chair", false });

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
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId" },
                values: new object[] { new Guid("feaacadb-65a1-4a35-b17b-f146d438fab0"), new DateTime(2024, 9, 26, 10, 36, 14, 641, DateTimeKind.Local).AddTicks(3431), new DateTime(2024, 10, 26, 10, 36, 14, 641, DateTimeKind.Local).AddTicks(3431), 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 2,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardTypeId" },
                values: new object[] { new Guid("fd777383-becc-48f9-9437-99febbecf6fb"), new DateTime(2024, 9, 26, 10, 36, 14, 641, DateTimeKind.Local).AddTicks(3617), new DateTime(2024, 10, 26, 10, 36, 14, 641, DateTimeKind.Local).AddTicks(3617), 1 });

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
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId", "QRCardTypeId" },
                values: new object[] { new Guid("d96b058e-e1c5-48db-b8b8-07d8a298c2bd"), new DateTime(2024, 9, 26, 10, 36, 14, 641, DateTimeKind.Local).AddTicks(3638), new DateTime(2024, 10, 26, 10, 36, 14, 641, DateTimeKind.Local).AddTicks(3638), 2, 1 });

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
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId" },
                values: new object[] { new Guid("95da113a-fa97-445f-986e-0b6c8b68db14"), new DateTime(2024, 9, 26, 10, 36, 14, 641, DateTimeKind.Local).AddTicks(3661), new DateTime(2024, 10, 26, 10, 36, 14, 641, DateTimeKind.Local).AddTicks(3661), 1 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 7,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("98c2abbf-3cf5-4bb9-8ef5-1bc440c9f629"), new DateTime(2024, 9, 26, 10, 36, 14, 641, DateTimeKind.Local).AddTicks(3668), new DateTime(2024, 10, 26, 10, 36, 14, 641, DateTimeKind.Local).AddTicks(3668) });

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
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("e9f8d3c0-0297-4c38-b1e8-bf216ce65dbd"), new DateTime(2024, 9, 26, 10, 36, 14, 641, DateTimeKind.Local).AddTicks(3681), new DateTime(2024, 10, 26, 10, 36, 14, 641, DateTimeKind.Local).AddTicks(3681) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 10,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("12a11578-e955-4586-9e91-d9da6b37c6db"), new DateTime(2024, 9, 26, 10, 36, 14, 641, DateTimeKind.Local).AddTicks(3690), new DateTime(2024, 10, 26, 10, 36, 14, 641, DateTimeKind.Local).AddTicks(3690) });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 4,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 6, 24 });

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
                column: "UserId",
                value: 12);

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
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 6, 16 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 15,
                column: "UserId",
                value: 20);

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
                column: "UserId",
                value: 16);

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 20, 1, 26, 7, 842, DateTimeKind.Unspecified).AddTicks(9485), "gmail.com.Leannon@gmail.com", "Damon Ebert", "0d6n16", "0220111683", new DateTime(2024, 9, 20, 1, 26, 7, 842, DateTimeKind.Unspecified).AddTicks(9485), "Mary.Koss" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 7, 1, 10, 39, 306, DateTimeKind.Unspecified).AddTicks(5549), "gmail.com.Legros87@gmail.com", "Ida Mante", "tkouc3", "0431242079", 4, new DateTime(2024, 9, 7, 1, 10, 39, 306, DateTimeKind.Unspecified).AddTicks(5549), "Nona_Volkman" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 7, 2, 55, 57, 227, DateTimeKind.Unspecified).AddTicks(5271), "gmail.com26@yahoo.com", "Christopher Roob", "8ekqlx", "0727010136", 2, new DateTime(2024, 9, 7, 2, 55, 57, 227, DateTimeKind.Unspecified).AddTicks(5271), "Carlotta.Conroy" });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 7, 9, 25, 19, 417, DateTimeKind.Unspecified).AddTicks(9623), "gmail.com.Orn73@hotmail.com", "Alison Emard", "n2u4t3", "0882584535", 2, new DateTime(2024, 9, 7, 9, 25, 19, 417, DateTimeKind.Unspecified).AddTicks(9623), "Hiram72" });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 15, 9, 55, 42, 294, DateTimeKind.Unspecified).AddTicks(6341), "gmail.com.Wolff@yahoo.com", "Jaycee Simonis", "aiaoka", "0944507242", 2, new DateTime(2024, 9, 15, 9, 55, 42, 294, DateTimeKind.Unspecified).AddTicks(6341), "Jace.Hudson94" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 13, 15, 55, 7, 97, DateTimeKind.Unspecified).AddTicks(6294), "gmail.com_Bosco96@gmail.com", "Nina Balistreri", "6yvgfg", "0134106991", new DateTime(2024, 9, 13, 15, 55, 7, 97, DateTimeKind.Unspecified).AddTicks(6294), "Reina_Buckridge" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 25, 11, 17, 17, 717, DateTimeKind.Unspecified).AddTicks(345), "gmail.com_OConner4@hotmail.com", "Sonya Rosenbaum", "coeu4x", "0616532121", new DateTime(2024, 9, 25, 11, 17, 17, 717, DateTimeKind.Unspecified).AddTicks(345), "Martin_Rogahn" });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 8, 9, 24, 50, 193, DateTimeKind.Unspecified).AddTicks(9319), "gmail.com_Rutherford71@hotmail.com", "Madalyn Nolan", "qs5o3f", "0906601799", 2, new DateTime(2024, 9, 8, 9, 24, 50, 193, DateTimeKind.Unspecified).AddTicks(9319), "Dean_Johnson" });

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
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Dicta dolor aut dolores. Aspernatur enim consequatur. Optio doloremque officiis iure tempore nihil et dolores blanditiis perferendis. Ea nihil sint et. Totam dolores quia minus enim deleniti repellat minima dignissimos quia. Nulla vitae necessitatibus ut dignissimos vitae autem sed aperiam.", new DateTime(2024, 9, 26, 10, 36, 14, 622, DateTimeKind.Local).AddTicks(1403), new DateTime(2024, 9, 27, 10, 36, 14, 622, DateTimeKind.Local).AddTicks(1434), 9 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 4,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Est distinctio repudiandae blanditiis placeat et sit animi totam possimus. Incidunt sint ut aut harum officiis. Non sit corporis sapiente. Esse autem illo. Vel sit quis in voluptatibus incidunt provident.", new DateTime(2024, 9, 26, 10, 36, 14, 622, DateTimeKind.Local).AddTicks(1710), new DateTime(2024, 9, 27, 10, 36, 14, 622, DateTimeKind.Local).AddTicks(1713), 6 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 5,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Voluptatibus est consequatur odio aut. Ipsa aspernatur aut. Id perferendis consequuntur dolorum ipsam delectus magni.", new DateTime(2024, 9, 26, 10, 36, 14, 623, DateTimeKind.Local).AddTicks(2742), new DateTime(2024, 9, 27, 10, 36, 14, 623, DateTimeKind.Local).AddTicks(2775), 10 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 6,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Perferendis et culpa sunt aperiam sequi molestiae illo. Iste deleniti suscipit. Quibusdam qui qui qui. Non atque accusantium.", new DateTime(2024, 9, 26, 10, 36, 14, 623, DateTimeKind.Local).AddTicks(2982), new DateTime(2024, 9, 27, 10, 36, 14, 623, DateTimeKind.Local).AddTicks(2984), 7 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 7,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Aliquid ut vel quia ut. Eum eum aut quisquam libero consequatur quis dolorem vel debitis. Sapiente quo a. Rerum non provident debitis in enim.", new DateTime(2024, 9, 26, 10, 36, 14, 624, DateTimeKind.Local).AddTicks(3874), new DateTime(2024, 9, 27, 10, 36, 14, 624, DateTimeKind.Local).AddTicks(3899), 3 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 8,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Deserunt quasi atque consequatur voluptatibus et tenetur. Accusamus eum eveniet. Quam quae sint eveniet perferendis odio reiciendis. Explicabo soluta quis eveniet repudiandae explicabo tenetur vel laborum similique.", new DateTime(2024, 9, 26, 10, 36, 14, 624, DateTimeKind.Local).AddTicks(4190), new DateTime(2024, 9, 27, 10, 36, 14, 624, DateTimeKind.Local).AddTicks(4192), 4 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 9,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "A voluptas voluptatum deserunt sequi cupiditate explicabo. Nobis quisquam ut hic similique fuga nulla vitae inventore error. Vel quibusdam adipisci voluptas facilis quia nesciunt non et qui. Illo molestiae enim voluptatem molestias quisquam et non dolor dolores. Quasi commodi dolor non aperiam similique laudantium nulla temporibus reiciendis.", new DateTime(2024, 9, 26, 10, 36, 14, 625, DateTimeKind.Local).AddTicks(4758), new DateTime(2024, 9, 27, 10, 36, 14, 625, DateTimeKind.Local).AddTicks(4782), 10 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 10,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Aliquam ut sit excepturi. Harum numquam eum rerum dolorem cum nihil delectus accusamus. Ex omnis non. Qui dolorem molestiae culpa et at. Rerum repellat consequatur repellat et distinctio sed. Dolorem repudiandae nam voluptatem nihil.", new DateTime(2024, 9, 26, 10, 36, 14, 625, DateTimeKind.Local).AddTicks(5031), new DateTime(2024, 9, 27, 10, 36, 14, 625, DateTimeKind.Local).AddTicks(5033), 1 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 11,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Vel quisquam ut modi ut officia unde sapiente eius architecto. Distinctio ut expedita cupiditate nostrum alias perspiciatis. Architecto esse ullam impedit. Voluptatem quam sapiente quae.", new DateTime(2024, 9, 26, 10, 36, 14, 626, DateTimeKind.Local).AddTicks(6010), new DateTime(2024, 9, 27, 10, 36, 14, 626, DateTimeKind.Local).AddTicks(6037), 9 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 12,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Perferendis debitis ea animi est ut. Eos dolores doloribus eveniet esse consequatur suscipit. Ipsum incidunt ea aut. Rem voluptas ad aut.", new DateTime(2024, 9, 26, 10, 36, 14, 626, DateTimeKind.Local).AddTicks(6261), new DateTime(2024, 9, 27, 10, 36, 14, 626, DateTimeKind.Local).AddTicks(6264), 7 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 13,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Eos voluptas quia totam ut. Doloribus vitae velit ut facilis consequatur itaque. Dolores unde tenetur doloribus labore.", new DateTime(2024, 9, 26, 10, 36, 14, 629, DateTimeKind.Local).AddTicks(2197), new DateTime(2024, 9, 27, 10, 36, 14, 629, DateTimeKind.Local).AddTicks(2225), 10 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 14,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Exercitationem non ex maiores sint maiores ipsum omnis earum. Magni quas natus et quos. Maxime unde inventore dolor atque est impedit sit ut. Est facere ab facilis possimus.", new DateTime(2024, 9, 26, 10, 36, 14, 629, DateTimeKind.Local).AddTicks(2473), new DateTime(2024, 9, 27, 10, 36, 14, 629, DateTimeKind.Local).AddTicks(2475), 4 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 15,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Illo molestiae maiores facilis earum voluptatem a enim. Nemo ratione mollitia ipsum aliquid ullam nihil iusto. Aut mollitia deleniti enim sit expedita accusamus. Consequatur ad et pariatur esse illo sint itaque.", new DateTime(2024, 9, 26, 10, 36, 14, 630, DateTimeKind.Local).AddTicks(3640), new DateTime(2024, 9, 27, 10, 36, 14, 630, DateTimeKind.Local).AddTicks(3667), 9 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 16,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Assumenda necessitatibus fugiat laboriosam quaerat ad rerum nesciunt. Magnam velit sint. Sed placeat voluptatem tempora quidem dolorem aut beatae quo architecto. Non cum sed magnam eos.", new DateTime(2024, 9, 26, 10, 36, 14, 630, DateTimeKind.Local).AddTicks(3890), new DateTime(2024, 9, 27, 10, 36, 14, 630, DateTimeKind.Local).AddTicks(3892), 3 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 17,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Voluptatibus id voluptatem perspiciatis laudantium ut qui accusantium vel. Aperiam tempora harum earum. Ducimus occaecati et est accusamus ad aut eligendi eaque iure. Nisi est suscipit alias reiciendis assumenda quis. Illum repudiandae quam nihil molestias explicabo. A vel cumque sit aut quia quia eos.", new DateTime(2024, 9, 26, 10, 36, 14, 631, DateTimeKind.Local).AddTicks(4578), new DateTime(2024, 9, 27, 10, 36, 14, 631, DateTimeKind.Local).AddTicks(4668), 9 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 18,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Voluptatem dolore iste. Repudiandae mollitia aut nihil ut quidem nam autem. Soluta eos non eligendi sed corporis ut id id. Est harum qui harum sint consequatur harum numquam qui ratione.", new DateTime(2024, 9, 26, 10, 36, 14, 631, DateTimeKind.Local).AddTicks(4903), new DateTime(2024, 9, 27, 10, 36, 14, 631, DateTimeKind.Local).AddTicks(4906) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 19,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Facere ut saepe modi dicta ea fugit sit. Error et dolores sunt pariatur. Totam alias recusandae labore minima excepturi molestiae atque optio.", new DateTime(2024, 9, 26, 10, 36, 14, 632, DateTimeKind.Local).AddTicks(5746), new DateTime(2024, 9, 27, 10, 36, 14, 632, DateTimeKind.Local).AddTicks(5772), 5 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 20,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Et ut vel repellendus quia sunt voluptatem. At doloribus a. Est id molestiae ducimus aut. Voluptas nihil veniam aliquam. Iure qui sit veniam at sunt sit fuga.", new DateTime(2024, 9, 26, 10, 36, 14, 632, DateTimeKind.Local).AddTicks(6003), new DateTime(2024, 9, 27, 10, 36, 14, 632, DateTimeKind.Local).AddTicks(6005), 4 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 21,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Sint ullam placeat. Et sed nulla nisi placeat totam quidem. Quod aut facilis ipsa rerum culpa distinctio voluptate repellendus perspiciatis. Harum doloribus vel dicta soluta est iure molestiae reiciendis cupiditate. Quaerat nemo id excepturi dignissimos autem quasi ut odit deleniti.", new DateTime(2024, 9, 26, 10, 36, 14, 633, DateTimeKind.Local).AddTicks(6667), new DateTime(2024, 9, 27, 10, 36, 14, 633, DateTimeKind.Local).AddTicks(6692), 2 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 22,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Quasi non rerum ut in vel ipsa eos. Unde provident error amet. Nesciunt ut explicabo. Voluptas rerum sequi in harum aperiam.", new DateTime(2024, 9, 26, 10, 36, 14, 633, DateTimeKind.Local).AddTicks(6906), new DateTime(2024, 9, 27, 10, 36, 14, 633, DateTimeKind.Local).AddTicks(6909), 6 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 23,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Aut porro officia quo eos. Fugiat quidem quam repudiandae saepe consequuntur quia vero recusandae. Sunt laudantium repudiandae reiciendis architecto.", new DateTime(2024, 9, 26, 10, 36, 14, 634, DateTimeKind.Local).AddTicks(8917), new DateTime(2024, 9, 27, 10, 36, 14, 634, DateTimeKind.Local).AddTicks(8942), 4 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 24,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Deleniti beatae praesentium sed rerum quisquam quia fugit velit maiores. Ad mollitia consequatur perferendis assumenda et laborum dolore aut. Atque architecto fugit qui laboriosam vero. Enim aperiam blanditiis accusamus voluptates dolores vero culpa. Id est numquam aut nisi minima eaque sit atque.", new DateTime(2024, 9, 26, 10, 36, 14, 634, DateTimeKind.Local).AddTicks(9209), new DateTime(2024, 9, 27, 10, 36, 14, 634, DateTimeKind.Local).AddTicks(9211), 7 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 25,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Totam impedit placeat cupiditate delectus nihil nesciunt. Ut non aut inventore nulla odio accusamus in. Inventore voluptas dicta earum quisquam asperiores et sit ducimus sit. Consectetur inventore distinctio perspiciatis nisi rerum. Enim eum odio ipsam fuga consectetur et dolores et.", new DateTime(2024, 9, 26, 10, 36, 14, 636, DateTimeKind.Local).AddTicks(152), new DateTime(2024, 9, 27, 10, 36, 14, 636, DateTimeKind.Local).AddTicks(177), 7 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 26,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Aut ipsum repellat iste. Nesciunt hic nobis et non recusandae ut. Voluptate hic omnis aut et qui. Tempore veritatis aut et dolorem repellendus velit aliquid molestias impedit. Culpa nostrum enim et.", new DateTime(2024, 9, 26, 10, 36, 14, 636, DateTimeKind.Local).AddTicks(416), new DateTime(2024, 9, 27, 10, 36, 14, 636, DateTimeKind.Local).AddTicks(418), 9 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 27,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Eos sunt architecto ut quas ea omnis. Et unde dolorem perferendis ut. Magni ea saepe minima assumenda officiis.", new DateTime(2024, 9, 26, 10, 36, 14, 637, DateTimeKind.Local).AddTicks(908), new DateTime(2024, 9, 27, 10, 36, 14, 637, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 28,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Modi quam unde autem hic. Maxime aut iure sit incidunt totam. Magni velit reiciendis ea perferendis eos qui eos.", new DateTime(2024, 9, 26, 10, 36, 14, 637, DateTimeKind.Local).AddTicks(1133), new DateTime(2024, 9, 27, 10, 36, 14, 637, DateTimeKind.Local).AddTicks(1135), 6 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 29,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Consequatur in rerum deleniti ab. Dolores suscipit dicta mollitia eum neque minima autem. Fugiat temporibus non. Est neque culpa dolorem repellat. Aliquam et voluptate est. Est distinctio natus aliquam voluptatem quos esse a ullam.", new DateTime(2024, 9, 26, 10, 36, 14, 638, DateTimeKind.Local).AddTicks(9886), new DateTime(2024, 9, 27, 10, 36, 14, 638, DateTimeKind.Local).AddTicks(9918) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 30,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Dolorem illum recusandae eius delectus hic quisquam architecto. Rerum veritatis dicta odit minus dolor est unde iste voluptatem. Aspernatur occaecati dolorem animi voluptates qui dignissimos labore ullam rerum. Libero ipsa aut natus adipisci expedita occaecati. Modi officiis id sint aut molestiae. Sit mollitia eaque quas officia.", new DateTime(2024, 9, 26, 10, 36, 14, 639, DateTimeKind.Local).AddTicks(199), new DateTime(2024, 9, 27, 10, 36, 14, 639, DateTimeKind.Local).AddTicks(202), 4 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 31,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Tempora porro debitis libero odio. Rerum sint aliquam et et explicabo occaecati exercitationem debitis sint. Itaque perspiciatis autem necessitatibus et. Qui minus nisi qui ad quia. Aliquid numquam aut voluptas et. Minima aliquid magnam aut quaerat laborum numquam error id est.", new DateTime(2024, 9, 26, 10, 36, 14, 640, DateTimeKind.Local).AddTicks(1381), new DateTime(2024, 9, 27, 10, 36, 14, 640, DateTimeKind.Local).AddTicks(1412), 8 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 32,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Officia et nulla dolores. Tenetur eum necessitatibus quasi a aut. Hic sint quisquam corporis tempore ipsum eos fuga incidunt voluptatum. Sint quam tempora minima voluptas saepe qui facilis recusandae ipsa. Facere vitae dolores aut aut est a nobis.", new DateTime(2024, 9, 26, 10, 36, 14, 640, DateTimeKind.Local).AddTicks(1656), new DateTime(2024, 9, 27, 10, 36, 14, 640, DateTimeKind.Local).AddTicks(1658) });

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
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Gulgowski Inc", new DateTime(2024, 9, 3, 20, 9, 23, 379, DateTimeKind.Unspecified).AddTicks(4679), "mwpj1y4k4u", "0234171487", true, new DateTime(2024, 9, 3, 20, 9, 23, 379, DateTimeKind.Unspecified).AddTicks(4679), "Gregorio Lemke" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 2,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Stehr, Kassulke and Johnston", new DateTime(2024, 9, 21, 9, 29, 51, 717, DateTimeKind.Unspecified).AddTicks(8134), 2, "u21rsr7xm2", "0247807559", new DateTime(2024, 9, 21, 9, 29, 51, 717, DateTimeKind.Unspecified).AddTicks(8134), "Orin Mayer" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 3,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Reinger - Nolan", new DateTime(2024, 9, 17, 7, 42, 31, 145, DateTimeKind.Unspecified).AddTicks(9170), "oej2t31v91", "0739218090", new DateTime(2024, 9, 17, 7, 42, 31, 145, DateTimeKind.Unspecified).AddTicks(9170), "Raphael Boyle" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 4,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Douglas - Terry", new DateTime(2024, 9, 8, 11, 54, 43, 8, DateTimeKind.Unspecified).AddTicks(3209), "tm81p79jvk", "0589188705", new DateTime(2024, 9, 8, 11, 54, 43, 8, DateTimeKind.Unspecified).AddTicks(3209), "Cali Schiller" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 5,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Mosciski LLC", new DateTime(2024, 9, 21, 23, 33, 3, 593, DateTimeKind.Unspecified).AddTicks(8317), "ii30iazfve", "0323981932", false, new DateTime(2024, 9, 21, 23, 33, 3, 593, DateTimeKind.Unspecified).AddTicks(8317), "Estrella McDermott" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 6,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Sanford Group", new DateTime(2024, 9, 20, 17, 7, 6, 624, DateTimeKind.Unspecified).AddTicks(4674), 1, "r62r5x4jpf", "0633675726", true, new DateTime(2024, 9, 20, 17, 7, 6, 624, DateTimeKind.Unspecified).AddTicks(4674), "Anabelle Beahan" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 7,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Dooley - Stark", new DateTime(2024, 9, 21, 18, 26, 32, 714, DateTimeKind.Unspecified).AddTicks(3336), "877vmja2k0", "0358068131", true, new DateTime(2024, 9, 21, 18, 26, 32, 714, DateTimeKind.Unspecified).AddTicks(3336), "Rachael Kovacek" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 8,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Medhurst Inc", new DateTime(2024, 9, 6, 3, 48, 43, 839, DateTimeKind.Unspecified).AddTicks(2299), "am5xpvhymz", "0283136949", new DateTime(2024, 9, 6, 3, 48, 43, 839, DateTimeKind.Unspecified).AddTicks(2299), "Dagmar Doyle" });

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
    }
}
