using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecurityGateApv.Infras.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDb_5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusNumber",
                table: "QRCardStatus");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateById",
                table: "Visits",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "QRCardStatus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                values: new object[] { 5, new DateTime(2024, 9, 23, 17, 49, 32, 884, DateTimeKind.Utc).AddTicks(3363), "Phòng Sản xuất", "Reprehenderit id quos voluptas incidunt.", new DateTime(2024, 9, 23, 17, 49, 32, 884, DateTimeKind.Utc).AddTicks(3363) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 7, 33, 46, 754, DateTimeKind.Utc).AddTicks(305), "Phòng Kinh doanh", "Doloremque rem ducimus doloribus quod autem mollitia sapiente ipsam voluptatem.", new DateTime(2024, 9, 11, 7, 33, 46, 754, DateTimeKind.Utc).AddTicks(305) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 9, 7, 18, 4, 37, 214, DateTimeKind.Utc).AddTicks(9611), "Phòng Nhân sự", "Exercitationem quam mollitia.", new DateTime(2024, 9, 7, 18, 4, 37, 214, DateTimeKind.Utc).AddTicks(9611) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2024, 9, 8, 15, 58, 19, 623, DateTimeKind.Utc).AddTicks(2381), "Phòng Nhân sự", "Cupiditate dolor laudantium libero officiis aliquid repellat.", new DateTime(2024, 9, 8, 15, 58, 19, 623, DateTimeKind.Utc).AddTicks(2381) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5,
                columns: new[] { "AcceptLevel", "CreateDate", "Description", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2024, 9, 10, 3, 0, 14, 404, DateTimeKind.Utc).AddTicks(5117), "Recusandae vel velit doloribus illo animi veritatis sit beatae.", new DateTime(2024, 9, 10, 3, 0, 14, 404, DateTimeKind.Utc).AddTicks(5117) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 6,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2024, 9, 19, 21, 54, 32, 513, DateTimeKind.Utc).AddTicks(1702), "Phòng Sản xuất", "Consectetur vero totam.", new DateTime(2024, 9, 19, 21, 54, 32, 513, DateTimeKind.Utc).AddTicks(1702) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 7,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 11, 23, 19, 59, 132, DateTimeKind.Utc).AddTicks(7769), "Phòng Nhân sự", "Ipsam non est suscipit aut.", new DateTime(2024, 9, 11, 23, 19, 59, 132, DateTimeKind.Utc).AddTicks(7769) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 8,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2024, 9, 14, 17, 11, 43, 515, DateTimeKind.Utc).AddTicks(5138), "Phòng Sản xuất", "Rerum quasi velit soluta quia voluptate officiis.", new DateTime(2024, 9, 14, 17, 11, 43, 515, DateTimeKind.Utc).AddTicks(5138) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 9,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 14, 10, 14, 46, 463, DateTimeKind.Utc).AddTicks(5708), "Phòng Kế toán", "Animi temporibus aut distinctio libero culpa dolorum quibusdam non est.", new DateTime(2024, 9, 14, 10, 14, 46, 463, DateTimeKind.Utc).AddTicks(5708) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 10,
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 20, 3, 22, 53, 926, DateTimeKind.Utc).AddTicks(4812), "Phòng Nhân sự", "Et libero ab eligendi.", new DateTime(2024, 9, 20, 3, 22, 53, 926, DateTimeKind.Utc).AddTicks(4812) });

            migrationBuilder.UpdateData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: 1,
                columns: new[] { "CreateTime", "ProcessName" },
                values: new object[] { new DateTime(2024, 9, 25, 6, 49, 7, 520, DateTimeKind.Utc).AddTicks(6008), "Generic Cotton Towels" });

            migrationBuilder.UpdateData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: 2,
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 25, 6, 49, 7, 520, DateTimeKind.Utc).AddTicks(7628), "Practical Cotton Pizza", false });

            migrationBuilder.UpdateData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: 3,
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 25, 6, 49, 7, 520, DateTimeKind.Utc).AddTicks(7657), "Awesome Granite Shoes", true });

            migrationBuilder.UpdateData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: 4,
                columns: new[] { "CreateTime", "ProcessName" },
                values: new object[] { new DateTime(2024, 9, 25, 6, 49, 7, 520, DateTimeKind.Utc).AddTicks(7678), "Incredible Steel Chips" });

            migrationBuilder.UpdateData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: 5,
                columns: new[] { "CreateTime", "ProcessName" },
                values: new object[] { new DateTime(2024, 9, 25, 6, 49, 7, 520, DateTimeKind.Utc).AddTicks(7697), "Sleek Frozen Pizza" });

            migrationBuilder.UpdateData(
                table: "QRCardStatus",
                keyColumn: "QRCardStatusId",
                keyValue: 1,
                column: "Description",
                value: "Thẻ đang được dùng checkin");

            migrationBuilder.UpdateData(
                table: "QRCardStatus",
                keyColumn: "QRCardStatusId",
                keyValue: 2,
                column: "Description",
                value: "Thẻ chưa dùng cho bảo vệ");

            migrationBuilder.InsertData(
                table: "QRCardStatus",
                columns: new[] { "QRCardStatusId", "Description", "StatusName" },
                values: new object[] { 3, "Thẻ đã hết hạn", "Disable" });

            migrationBuilder.UpdateData(
                table: "QRCardType",
                keyColumn: "QRCardTypeId",
                keyValue: 1,
                columns: new[] { "CardTypeName", "TypeDescription" },
                values: new object[] { "Vehicle", "Vehicle QR Card" });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 1,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId" },
                values: new object[] { new Guid("69bf92f4-5556-45e4-abb2-dfdd9ba51946"), new DateTime(2024, 9, 27, 13, 49, 7, 564, DateTimeKind.Local).AddTicks(5107), new DateTime(2024, 9, 27, 13, 49, 7, 564, DateTimeKind.Local).AddTicks(5188), 1 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 2,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("3fad4ee3-59fb-41ff-8b96-bbaf6765109a"), new DateTime(2024, 9, 27, 13, 49, 7, 564, DateTimeKind.Local).AddTicks(5334), new DateTime(2024, 9, 27, 13, 49, 7, 564, DateTimeKind.Local).AddTicks(5336) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 3,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId", "QRCardTypeId" },
                values: new object[] { new Guid("b9c0d83b-d2bc-4a87-bcf4-ef1bd0ddacf7"), new DateTime(2024, 9, 27, 13, 49, 7, 564, DateTimeKind.Local).AddTicks(5347), new DateTime(2024, 9, 27, 13, 49, 7, 564, DateTimeKind.Local).AddTicks(5348), 2, 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 4,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("bb98d75e-46af-4588-b61e-3403005ea6c5"), new DateTime(2024, 9, 27, 13, 49, 7, 564, DateTimeKind.Local).AddTicks(5355), new DateTime(2024, 9, 27, 13, 49, 7, 564, DateTimeKind.Local).AddTicks(5356) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 5,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("d709b3c6-0c2d-421e-9437-75cb8ee70969"), new DateTime(2024, 9, 27, 13, 49, 7, 564, DateTimeKind.Local).AddTicks(5362), new DateTime(2024, 9, 27, 13, 49, 7, 564, DateTimeKind.Local).AddTicks(5363) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 6,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId", "QRCardTypeId" },
                values: new object[] { new Guid("4f159c40-9b58-4bc4-8cf6-29c305850b5c"), new DateTime(2024, 9, 27, 13, 49, 7, 564, DateTimeKind.Local).AddTicks(5379), new DateTime(2024, 9, 27, 13, 49, 7, 564, DateTimeKind.Local).AddTicks(5380), 1, 1 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 7,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId" },
                values: new object[] { new Guid("3fd68ccb-0704-40e2-b660-9f4ea7b2d204"), new DateTime(2024, 9, 27, 13, 49, 7, 564, DateTimeKind.Local).AddTicks(5387), new DateTime(2024, 9, 27, 13, 49, 7, 564, DateTimeKind.Local).AddTicks(5388), 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 8,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardTypeId" },
                values: new object[] { new Guid("13dbe9a0-5699-4001-bf4a-e9098318a236"), new DateTime(2024, 9, 27, 13, 49, 7, 564, DateTimeKind.Local).AddTicks(5394), new DateTime(2024, 9, 27, 13, 49, 7, 564, DateTimeKind.Local).AddTicks(5395), 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 9,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("9adca385-5874-44a6-b7d7-bf2930b12186"), new DateTime(2024, 9, 27, 13, 49, 7, 564, DateTimeKind.Local).AddTicks(5401), new DateTime(2024, 9, 27, 13, 49, 7, 564, DateTimeKind.Local).AddTicks(5402) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 10,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId", "QRCardTypeId" },
                values: new object[] { new Guid("15d9beb7-5c6d-4c5b-a246-0fb7ea53349c"), new DateTime(2024, 9, 27, 13, 49, 7, 564, DateTimeKind.Local).AddTicks(5408), new DateTime(2024, 9, 27, 13, 49, 7, 564, DateTimeKind.Local).AddTicks(5409), 2, 2 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 4,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 6, 19 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 5,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 5, 16 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 6,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 3, 18 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 7,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 10, 12 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 8,
                column: "UserId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 9,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 4, 25 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 10,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 16 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 11,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 6 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 12,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 3, 19 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 13,
                column: "UserId",
                value: 23);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 14,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 1, 20 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 15,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 16 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 16,
                column: "UserId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 17,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 19 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 18,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 10, 16 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 19,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 3, 21 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 20,
                column: "UserId",
                value: 9);

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
                values: new object[] { 3, 7 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 23,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 20 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 27, 6, 49, 7, 499, DateTimeKind.Utc).AddTicks(2931), new DateTime(2024, 9, 27, 6, 49, 7, 499, DateTimeKind.Utc).AddTicks(2938) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 6, 49, 7, 499, DateTimeKind.Utc).AddTicks(2960), new DateTime(2024, 9, 27, 6, 49, 7, 499, DateTimeKind.Utc).AddTicks(2961) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 6, 49, 7, 499, DateTimeKind.Utc).AddTicks(2963), new DateTime(2024, 9, 27, 6, 49, 7, 499, DateTimeKind.Utc).AddTicks(2963) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 27, 6, 49, 7, 499, DateTimeKind.Utc).AddTicks(2965), new DateTime(2024, 9, 27, 6, 49, 7, 499, DateTimeKind.Utc).AddTicks(2965) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 27, 6, 49, 7, 499, DateTimeKind.Utc).AddTicks(2967), new DateTime(2024, 9, 27, 6, 49, 7, 499, DateTimeKind.Utc).AddTicks(2967) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 8, 17, 3, 47, 700, DateTimeKind.Unspecified).AddTicks(3262), "gmail.com.Ruecker26@gmail.com", "Lyric Kulas", "pyjula", "0321392092", 1, new DateTime(2024, 9, 8, 17, 3, 47, 700, DateTimeKind.Unspecified).AddTicks(3262), "Darren_VonRueden70" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 24, 19, 32, 15, 635, DateTimeKind.Unspecified).AddTicks(1841), "gmail.com_Schoen@yahoo.com", "Tom Waters", "s3bc8t", "0102084555", 2, new DateTime(2024, 9, 24, 19, 32, 15, 635, DateTimeKind.Unspecified).AddTicks(1841), "Emmitt.Zieme" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 2, 13, 30, 4, 427, DateTimeKind.Unspecified).AddTicks(9839), "gmail.com.Bins@hotmail.com", "Kay Sanford", "fn0w0j", "0308041056", 4, new DateTime(2024, 9, 2, 13, 30, 4, 427, DateTimeKind.Unspecified).AddTicks(9839), "Kellie_Jaskolski" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 22, 13, 32, 0, 918, DateTimeKind.Unspecified).AddTicks(3563), "gmail.com31@yahoo.com", "Yvette Schultz", "h3jrs6", "0908764909", 2, new DateTime(2024, 9, 22, 13, 32, 0, 918, DateTimeKind.Unspecified).AddTicks(3563), "Dina_Hyatt" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 12, 3, 43, 3, 371, DateTimeKind.Unspecified).AddTicks(8485), "gmail.com_Vandervort49@gmail.com", "Candido Jenkins", "yoj2uu", "0812427428", 4, new DateTime(2024, 9, 12, 3, 43, 3, 371, DateTimeKind.Unspecified).AddTicks(8485), "Tyshawn_Feeney" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 56, 54, 843, DateTimeKind.Unspecified).AddTicks(9196), "gmail.com_Bashirian@hotmail.com", "Darrell Jacobs", "tr917v", "0139193113", 4, new DateTime(2024, 9, 4, 14, 56, 54, 843, DateTimeKind.Unspecified).AddTicks(9196), "Annalise_Runolfsson8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 17, 20, 54, 3, 303, DateTimeKind.Unspecified).AddTicks(8607), "gmail.com.Lebsack@gmail.com", "Annetta Hirthe", "asjwtu", "0452974350", 1, new DateTime(2024, 9, 17, 20, 54, 3, 303, DateTimeKind.Unspecified).AddTicks(8607), "Sterling_Stokes17" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 3, 6, 8, 20, 838, DateTimeKind.Unspecified).AddTicks(5073), "gmail.com_Jakubowski45@hotmail.com", "Bernardo Botsford", "db0c67", "0529216305", 2, new DateTime(2024, 9, 3, 6, 8, 20, 838, DateTimeKind.Unspecified).AddTicks(5073), "Luna.Vandervort51" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 18, 5, 13, 21, 371, DateTimeKind.Unspecified).AddTicks(9193), "gmail.com26@gmail.com", "Eloisa Grant", "bjiayo", "0312018550", new DateTime(2024, 9, 18, 5, 13, 21, 371, DateTimeKind.Unspecified).AddTicks(9193), "Reed79" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 3, 18, 58, 5, 128, DateTimeKind.Unspecified).AddTicks(2127), "gmail.com.Fisher31@gmail.com", "Braeden Heller", "vhdrvi", "0234423082", 3, new DateTime(2024, 9, 3, 18, 58, 5, 128, DateTimeKind.Unspecified).AddTicks(2127), "Skylar_Carroll96" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 10, 6, 11, 32, 829, DateTimeKind.Unspecified).AddTicks(4979), "gmail.com7@hotmail.com", "Trudie Larson", "qmxcep", "0520584627", 1, new DateTime(2024, 9, 10, 6, 11, 32, 829, DateTimeKind.Unspecified).AddTicks(4979), "Brown37" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 13, 21, 44, 50, 251, DateTimeKind.Unspecified).AddTicks(4749), "gmail.com49@gmail.com", "Ericka Denesik", "3177ht", "0945506960", 3, new DateTime(2024, 9, 13, 21, 44, 50, 251, DateTimeKind.Unspecified).AddTicks(4749), "Lucie_Stehr" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 1, 19, 3, 58, 849, DateTimeKind.Unspecified).AddTicks(4207), "gmail.com_Kozey20@hotmail.com", "Reyna Klocko", "vno0kn", "0686775973", 2, new DateTime(2024, 9, 1, 19, 3, 58, 849, DateTimeKind.Unspecified).AddTicks(4207), "Consuelo.McLaughlin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 17, 13, 23, 33, 676, DateTimeKind.Unspecified).AddTicks(8483), "gmail.com_Jenkins58@gmail.com", "Florencio Hoppe", "b3le8k", "0951733081", 3, new DateTime(2024, 9, 17, 13, 23, 33, 676, DateTimeKind.Unspecified).AddTicks(8483), "Meagan.Funk" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 19, 4, 10, 20, 286, DateTimeKind.Unspecified).AddTicks(170), "gmail.com_Corkery@gmail.com", "Shyann Armstrong", "nwq1nd", "0723087346", 5, new DateTime(2024, 9, 19, 4, 10, 20, 286, DateTimeKind.Unspecified).AddTicks(170), "Liliana18" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 20, 17, 29, 14, 423, DateTimeKind.Unspecified).AddTicks(4235), "gmail.com_Jones48@yahoo.com", "Kayli Bartell", "uxs4h6", "0531562772", 3, new DateTime(2024, 9, 20, 17, 29, 14, 423, DateTimeKind.Unspecified).AddTicks(4235), "Chad.Nader42" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 1, 16, 12, 36, 582, DateTimeKind.Unspecified).AddTicks(456), "gmail.com1@hotmail.com", "Marianne VonRueden", "5bszvl", "0482392146", 1, new DateTime(2024, 9, 1, 16, 12, 36, 582, DateTimeKind.Unspecified).AddTicks(456), "Cleora_Flatley91" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 8, 11, 28, 52, 355, DateTimeKind.Unspecified).AddTicks(9271), "gmail.com.Weber@hotmail.com", "Melissa Smith", "3ir5uw", "0313993462", 2, new DateTime(2024, 9, 8, 11, 28, 52, 355, DateTimeKind.Unspecified).AddTicks(9271), "Ivah_Green25" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 1, 8, 58, 27, 852, DateTimeKind.Unspecified).AddTicks(8424), "gmail.com35@hotmail.com", "Elmer Armstrong", "dsu8ks", "0933081997", 1, new DateTime(2024, 9, 1, 8, 58, 27, 852, DateTimeKind.Unspecified).AddTicks(8424), "Kiel.Rice" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 22, 10, 51, 18, 78, DateTimeKind.Unspecified).AddTicks(875), "gmail.com71@hotmail.com", "Solon Brekke", "doh52i", "0648348756", 4, new DateTime(2024, 9, 22, 10, 51, 18, 78, DateTimeKind.Unspecified).AddTicks(875), "Kevon.Schaden" });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 1,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Nesciunt voluptates est dolorum consequatur. Eos quod nihil provident rem rem autem magni assumenda vitae. Minus saepe aut ea commodi id consequatur. Quis occaecati eveniet nesciunt sit dolor et. Ratione accusantium voluptatem et a dolorem eveniet.", new DateTime(2024, 10, 26, 13, 49, 7, 526, DateTimeKind.Local).AddTicks(8819), new DateTime(2024, 9, 26, 13, 49, 7, 526, DateTimeKind.Local).AddTicks(8765), 1 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 2,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Quos ipsum corporis non aut dolorem aut. Voluptas autem dolor nesciunt provident quod. Tempore accusantium labore rerum adipisci eos excepturi iusto. Iusto autem voluptatem quis modi impedit architecto. Exercitationem minus dolor non voluptas aut velit. Et optio aliquid deleniti quam.", new DateTime(2024, 10, 26, 13, 49, 7, 526, DateTimeKind.Local).AddTicks(9810), new DateTime(2024, 9, 26, 13, 49, 7, 526, DateTimeKind.Local).AddTicks(9808) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 3,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Perspiciatis aperiam tempore laborum sunt quisquam eos. Ratione eaque accusantium. Aspernatur ut aut.", new DateTime(2024, 9, 28, 13, 49, 7, 529, DateTimeKind.Local).AddTicks(7116), new DateTime(2024, 9, 27, 13, 49, 7, 529, DateTimeKind.Local).AddTicks(7078), 10 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 4,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Temporibus quibusdam rerum perspiciatis ipsam veritatis sequi rerum velit dignissimos. Praesentium delectus voluptas qui. Aspernatur sequi laborum eius consectetur quas. Laudantium ducimus omnis molestias dolorem omnis.", new DateTime(2024, 9, 28, 13, 49, 7, 529, DateTimeKind.Local).AddTicks(7391), new DateTime(2024, 9, 27, 13, 49, 7, 529, DateTimeKind.Local).AddTicks(7388), 9 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 5,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Earum aliquam sed. Adipisci sed est. Beatae aliquam ex rerum molestiae. Eius recusandae quia. Amet quia et.", new DateTime(2024, 9, 28, 13, 49, 7, 531, DateTimeKind.Local).AddTicks(1117), new DateTime(2024, 9, 27, 13, 49, 7, 531, DateTimeKind.Local).AddTicks(1051), 5 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 6,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Sed perferendis sit velit vero laborum sed voluptas. Quod nobis numquam voluptatem sed amet impedit recusandae at eius. Sed illum unde molestias et sequi distinctio perspiciatis corrupti. Voluptatum nam nihil. Autem iure quae non velit non architecto perspiciatis nulla aliquid. Fugit et repellat illum porro.", new DateTime(2024, 9, 28, 13, 49, 7, 531, DateTimeKind.Local).AddTicks(1701), new DateTime(2024, 9, 27, 13, 49, 7, 531, DateTimeKind.Local).AddTicks(1697), 7 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 7,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Totam et eligendi velit ex velit. Velit et tempore alias. Vel autem odit omnis neque eum nam qui illum.", new DateTime(2024, 9, 28, 13, 49, 7, 533, DateTimeKind.Local).AddTicks(7142), new DateTime(2024, 9, 27, 13, 49, 7, 533, DateTimeKind.Local).AddTicks(7073), 2 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 8,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Ea laboriosam ratione nihil est et laudantium omnis soluta enim. Quae voluptatem inventore. Debitis iure esse sunt. Ut porro enim harum explicabo dicta.", new DateTime(2024, 9, 28, 13, 49, 7, 533, DateTimeKind.Local).AddTicks(7734), new DateTime(2024, 9, 27, 13, 49, 7, 533, DateTimeKind.Local).AddTicks(7730), 1 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 9,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Consequatur ut necessitatibus velit. Et itaque ipsa minus cum ea exercitationem consequatur dolor. Quisquam nihil maiores voluptatem voluptatem. Eos pariatur quia et.", new DateTime(2024, 9, 28, 13, 49, 7, 536, DateTimeKind.Local).AddTicks(4058), new DateTime(2024, 9, 27, 13, 49, 7, 536, DateTimeKind.Local).AddTicks(3997), 4 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 10,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Voluptatem amet modi rerum id inventore illum ut cupiditate. Eum cum omnis quo consequuntur quo et hic nesciunt. Doloremque est qui aut cum provident.", new DateTime(2024, 9, 28, 13, 49, 7, 536, DateTimeKind.Local).AddTicks(4493), new DateTime(2024, 9, 27, 13, 49, 7, 536, DateTimeKind.Local).AddTicks(4488), 9 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 11,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Quis ab qui ea. Quos eveniet impedit minus et pariatur. Minima ut non. Id exercitationem possimus nostrum sint error commodi qui sit vel. A eius esse suscipit cumque qui dicta nemo. Magnam labore dolores aut consequuntur consequuntur ut hic tenetur rerum.", new DateTime(2024, 9, 28, 13, 49, 7, 538, DateTimeKind.Local).AddTicks(5599), new DateTime(2024, 9, 27, 13, 49, 7, 538, DateTimeKind.Local).AddTicks(5541), 7 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 12,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Iste aut dolores distinctio architecto. Autem perferendis quas est aspernatur odio aut. Ut ab tenetur. Veniam reiciendis earum a neque modi deserunt cumque. Quia consequuntur expedita voluptatem non odio voluptatem provident eveniet accusantium. Placeat quaerat minus ut ipsa.", new DateTime(2024, 9, 28, 13, 49, 7, 538, DateTimeKind.Local).AddTicks(6096), new DateTime(2024, 9, 27, 13, 49, 7, 538, DateTimeKind.Local).AddTicks(6090), 1 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 13,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Totam sunt enim sed delectus excepturi qui nostrum quis rerum. Ullam quia cupiditate velit veritatis dolorem ut et rerum. Repellat qui aut. Tempore quia expedita consequatur accusantium. Ipsam corporis veritatis eaque quia dolorem omnis voluptatem similique cumque. Necessitatibus assumenda deserunt quia aut temporibus.", new DateTime(2024, 9, 28, 13, 49, 7, 542, DateTimeKind.Local).AddTicks(9189), new DateTime(2024, 9, 27, 13, 49, 7, 542, DateTimeKind.Local).AddTicks(9138) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 14,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Aut fuga perferendis. Natus qui odit eum unde est dolor debitis corporis rerum. Est eveniet velit illum eos qui et esse voluptas.", new DateTime(2024, 9, 28, 13, 49, 7, 542, DateTimeKind.Local).AddTicks(9606), new DateTime(2024, 9, 27, 13, 49, 7, 542, DateTimeKind.Local).AddTicks(9601), 8 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 15,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Exercitationem non a. Unde et quis quaerat. Blanditiis veniam officiis et et veniam. Quo perferendis molestiae accusamus sapiente quisquam mollitia soluta iure.", new DateTime(2024, 9, 28, 13, 49, 7, 545, DateTimeKind.Local).AddTicks(1), new DateTime(2024, 9, 27, 13, 49, 7, 544, DateTimeKind.Local).AddTicks(9956), 2 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 16,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Exercitationem aspernatur quas possimus corporis nam aspernatur quod sed. Molestiae dolores expedita sapiente nobis accusantium enim. Aliquid dolores laudantium quia qui nam sequi porro delectus.", new DateTime(2024, 9, 28, 13, 49, 7, 545, DateTimeKind.Local).AddTicks(383), new DateTime(2024, 9, 27, 13, 49, 7, 545, DateTimeKind.Local).AddTicks(379), 8 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 17,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Ut reiciendis enim inventore consequatur corporis beatae enim soluta et. In ut explicabo officia accusamus aut suscipit et nam aliquid. Rerum blanditiis sit officiis modi voluptatibus consequatur accusamus nam quisquam. Laboriosam et quia. Dolor cum facere veritatis deleniti sequi hic minus sit molestiae. Quia ea dignissimos.", new DateTime(2024, 9, 28, 13, 49, 7, 547, DateTimeKind.Local).AddTicks(1593), new DateTime(2024, 9, 27, 13, 49, 7, 547, DateTimeKind.Local).AddTicks(1534), 10 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 18,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Dolore velit ullam minus eos autem aut eos ipsa ab. Ratione ipsam ipsam voluptatem quidem quia dolor adipisci et eum. Et possimus deleniti maxime ea. Est ad ipsa ab nobis in. Animi est reiciendis ut assumenda.", new DateTime(2024, 9, 28, 13, 49, 7, 547, DateTimeKind.Local).AddTicks(2266), new DateTime(2024, 9, 27, 13, 49, 7, 547, DateTimeKind.Local).AddTicks(2261), 9 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 19,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Atque sequi numquam ut accusantium et explicabo. Tenetur enim alias eius sed est aliquam atque atque. Commodi eveniet dolore odit voluptatibus dolorem quia sapiente. Quis earum nemo eos.", new DateTime(2024, 9, 28, 13, 49, 7, 549, DateTimeKind.Local).AddTicks(3310), new DateTime(2024, 9, 27, 13, 49, 7, 549, DateTimeKind.Local).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 20,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Itaque aspernatur laboriosam aperiam. Minus qui perferendis. Quaerat debitis quam officiis. Sint placeat sed fugit et consequuntur consectetur dolores quasi.", new DateTime(2024, 9, 28, 13, 49, 7, 549, DateTimeKind.Local).AddTicks(3710), new DateTime(2024, 9, 27, 13, 49, 7, 549, DateTimeKind.Local).AddTicks(3705), 3 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 21,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Sunt ex dolorum. Dolor non accusantium sed. Unde atque sunt perferendis maiores. Hic asperiores omnis non voluptatem deleniti cumque ullam. Ut et tempore harum consequatur voluptatem repudiandae est qui deleniti.", new DateTime(2024, 9, 28, 13, 49, 7, 551, DateTimeKind.Local).AddTicks(2705), new DateTime(2024, 9, 27, 13, 49, 7, 551, DateTimeKind.Local).AddTicks(2660), 9 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 22,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Et aperiam dolorem officiis numquam reiciendis voluptatem. Perspiciatis ut deleniti nobis natus est ullam. Laborum provident quia natus. Illum dolor ullam dolorem non qui laborum non voluptas.", new DateTime(2024, 9, 28, 13, 49, 7, 551, DateTimeKind.Local).AddTicks(3096), new DateTime(2024, 9, 27, 13, 49, 7, 551, DateTimeKind.Local).AddTicks(3092), 8 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 23,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Corporis tempore at porro quidem. Consectetur tempore rerum ex porro voluptatum enim animi ullam cumque. Tempora qui dolorem et nostrum officia qui recusandae. Ut modi in voluptatibus et consequatur.", new DateTime(2024, 9, 28, 13, 49, 7, 553, DateTimeKind.Local).AddTicks(1485), new DateTime(2024, 9, 27, 13, 49, 7, 553, DateTimeKind.Local).AddTicks(1440), 2 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 24,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Et blanditiis facilis. Id natus nam magnam modi ut laborum quam aut. Nostrum sint nulla temporibus. Ut amet in. Voluptatibus occaecati molestiae vel quia et modi magnam.", new DateTime(2024, 9, 28, 13, 49, 7, 553, DateTimeKind.Local).AddTicks(1876), new DateTime(2024, 9, 27, 13, 49, 7, 553, DateTimeKind.Local).AddTicks(1871), 10 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 25,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Quia iure fugiat. Quis dolorem voluptatum. Laborum quaerat consequuntur velit dolores et enim aut. Consequatur deleniti sed qui.", new DateTime(2024, 9, 28, 13, 49, 7, 555, DateTimeKind.Local).AddTicks(1063), new DateTime(2024, 9, 27, 13, 49, 7, 555, DateTimeKind.Local).AddTicks(1017), 2 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 26,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Aut doloribus dolorem. Sit fuga voluptatem error ut quam. Nobis accusamus quisquam ut quasi corporis ad rerum harum et. Id minus numquam tenetur aut. Id est quia et porro porro molestiae.", new DateTime(2024, 9, 28, 13, 49, 7, 555, DateTimeKind.Local).AddTicks(1500), new DateTime(2024, 9, 27, 13, 49, 7, 555, DateTimeKind.Local).AddTicks(1496), 7 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 27,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Aperiam ratione repellendus illum enim aut. Consectetur ducimus numquam autem sit totam. Voluptatem consequatur iste. Aut nihil deserunt quis. Eligendi ut et officia deleniti.", new DateTime(2024, 9, 28, 13, 49, 7, 557, DateTimeKind.Local).AddTicks(340), new DateTime(2024, 9, 27, 13, 49, 7, 557, DateTimeKind.Local).AddTicks(291), 3 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 28,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Dolor assumenda culpa quae voluptatum adipisci esse. Qui ad molestias. Minima maiores facilis odio.", new DateTime(2024, 9, 28, 13, 49, 7, 557, DateTimeKind.Local).AddTicks(698), new DateTime(2024, 9, 27, 13, 49, 7, 557, DateTimeKind.Local).AddTicks(693) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 29,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Non dolor atque quod repellat. Quisquam reiciendis et tempore quam a ut labore id consequatur. Architecto commodi ut placeat nostrum perspiciatis reprehenderit quidem consectetur. Adipisci ut consequuntur aperiam rerum nemo.", new DateTime(2024, 9, 28, 13, 49, 7, 560, DateTimeKind.Local).AddTicks(3806), new DateTime(2024, 9, 27, 13, 49, 7, 560, DateTimeKind.Local).AddTicks(3752), 10 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 30,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Voluptas omnis laboriosam. Dolor similique maxime et consequatur eum ex facere sunt. Autem voluptatibus sit excepturi sit soluta tempore. Aut ut ipsum officiis maxime ut. Et reiciendis cumque perferendis ducimus quo reiciendis dolorem vel molestiae.", new DateTime(2024, 9, 28, 13, 49, 7, 560, DateTimeKind.Local).AddTicks(4268), new DateTime(2024, 9, 27, 13, 49, 7, 560, DateTimeKind.Local).AddTicks(4263), 4 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 31,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Eos quibusdam odio veniam numquam neque aut minima maiores iure. Quisquam sed adipisci soluta repellendus inventore cumque architecto. Repellendus et nostrum voluptas itaque in molestiae consequatur eos. Qui a illum. Aut asperiores aut in laborum accusantium. Aut non temporibus non voluptatibus.", new DateTime(2024, 9, 28, 13, 49, 7, 562, DateTimeKind.Local).AddTicks(3986), new DateTime(2024, 9, 27, 13, 49, 7, 562, DateTimeKind.Local).AddTicks(3938), 8 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 32,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Iste et et mollitia consequatur sed. Et maxime molestiae esse molestias qui quis sed maxime tempora. Reiciendis ad et provident quisquam.", new DateTime(2024, 9, 28, 13, 49, 7, 562, DateTimeKind.Local).AddTicks(4371), new DateTime(2024, 9, 27, 13, 49, 7, 562, DateTimeKind.Local).AddTicks(4366), 1 });

            migrationBuilder.UpdateData(
                table: "VisitProcesses",
                keyColumn: "VisitProcessId",
                keyValue: 1,
                columns: new[] { "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { new DateTime(2024, 10, 26, 13, 49, 7, 524, DateTimeKind.Local).AddTicks(8180), new DateTime(2024, 9, 26, 13, 49, 7, 524, DateTimeKind.Local).AddTicks(8120) });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 1,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Farrell - Stehr", new DateTime(2024, 9, 8, 0, 16, 3, 203, DateTimeKind.Unspecified).AddTicks(553), 2, "yk6hnp8uzo", "0517845108", false, new DateTime(2024, 9, 8, 0, 16, 3, 203, DateTimeKind.Unspecified).AddTicks(553), "Susan Crona" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 2,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Quigley, Frami and Hickle", new DateTime(2024, 9, 20, 7, 45, 29, 516, DateTimeKind.Unspecified).AddTicks(9502), 1, "lg6enhaefw", "0377966062", new DateTime(2024, 9, 20, 7, 45, 29, 516, DateTimeKind.Unspecified).AddTicks(9502), "Norma Zulauf" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 3,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Torp - Pollich", new DateTime(2024, 9, 8, 0, 31, 52, 156, DateTimeKind.Unspecified).AddTicks(733), 1, "5xp257fq95", "0623417177", new DateTime(2024, 9, 8, 0, 31, 52, 156, DateTimeKind.Unspecified).AddTicks(733), "Holly Smitham" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 4,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Mitchell Group", new DateTime(2024, 9, 19, 17, 48, 57, 571, DateTimeKind.Unspecified).AddTicks(6099), 1, "vw8z725bh2", "0128439770", false, new DateTime(2024, 9, 19, 17, 48, 57, 571, DateTimeKind.Unspecified).AddTicks(6099), "Jakob Effertz" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 5,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Harvey - Reichel", new DateTime(2024, 9, 8, 5, 40, 58, 232, DateTimeKind.Unspecified).AddTicks(1715), "qm4itwpobn", "0621193486", new DateTime(2024, 9, 8, 5, 40, 58, 232, DateTimeKind.Unspecified).AddTicks(1715), "Kenyatta Moore" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 6,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Smith Group", new DateTime(2024, 9, 26, 8, 34, 9, 427, DateTimeKind.Unspecified).AddTicks(1385), 2, "1128cddt1f", "0594718893", false, new DateTime(2024, 9, 26, 8, 34, 9, 427, DateTimeKind.Unspecified).AddTicks(1385), "Shanel Cummings" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 7,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Heller, Corwin and Stracke", new DateTime(2024, 9, 2, 17, 8, 58, 730, DateTimeKind.Unspecified).AddTicks(9989), 2, "0nhy7i5hyf", "0726028648", false, new DateTime(2024, 9, 2, 17, 8, 58, 730, DateTimeKind.Unspecified).AddTicks(9989), "Omari Kautzer" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 8,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Hansen - O'Hara", new DateTime(2024, 9, 24, 19, 49, 36, 247, DateTimeKind.Unspecified).AddTicks(887), 1, "vjg2vnu9h3", "0222503419", true, new DateTime(2024, 9, 24, 19, 49, 36, 247, DateTimeKind.Unspecified).AddTicks(887), "Dayne Kuvalis" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 9,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Christiansen - Schmitt", new DateTime(2024, 9, 1, 2, 19, 14, 317, DateTimeKind.Unspecified).AddTicks(9147), 2, "ana5fqqaum", "0490798974", new DateTime(2024, 9, 1, 2, 19, 14, 317, DateTimeKind.Unspecified).AddTicks(9147), "Kacey Mitchell" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 10,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Reichert, Hand and DuBuque", new DateTime(2024, 9, 14, 10, 35, 29, 191, DateTimeKind.Unspecified).AddTicks(1112), "5u0ckz8ibt", "0889988455", false, new DateTime(2024, 9, 14, 10, 35, 29, 191, DateTimeKind.Unspecified).AddTicks(1112), "Ozella Ritchie" });

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 1,
                column: "DateRegister",
                value: new DateTime(2024, 9, 25, 13, 49, 7, 521, DateTimeKind.Local).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 2,
                column: "DateRegister",
                value: new DateTime(2024, 9, 27, 6, 49, 7, 528, DateTimeKind.Utc).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 3,
                column: "DateRegister",
                value: new DateTime(2024, 9, 27, 6, 49, 7, 528, DateTimeKind.Utc).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 4,
                column: "DateRegister",
                value: new DateTime(2024, 9, 27, 6, 49, 7, 528, DateTimeKind.Utc).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 5,
                column: "DateRegister",
                value: new DateTime(2024, 9, 27, 6, 49, 7, 528, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 6,
                column: "DateRegister",
                value: new DateTime(2024, 9, 27, 6, 49, 7, 528, DateTimeKind.Utc).AddTicks(5200));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "QRCardStatus",
                keyColumn: "QRCardStatusId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "QRCardStatus");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateById",
                table: "Visits",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatusNumber",
                table: "QRCardStatus",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                values: new object[] { 1, new DateTime(2024, 9, 18, 8, 30, 25, 623, DateTimeKind.Utc).AddTicks(4506), "Phòng IT", "Molestias omnis ut.", new DateTime(2024, 9, 18, 8, 30, 25, 623, DateTimeKind.Utc).AddTicks(4506) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 24, 18, 35, 24, 448, DateTimeKind.Utc).AddTicks(2476), "Phòng Nhân sự", "Quos aut molestiae unde dolores debitis ad aut rerum harum.", new DateTime(2024, 9, 24, 18, 35, 24, 448, DateTimeKind.Utc).AddTicks(2476) });

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
                columns: new[] { "AcceptLevel", "CreateDate", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 20, 14, 16, 27, 856, DateTimeKind.Utc).AddTicks(2007), "Saepe laborum vel.", new DateTime(2024, 9, 20, 14, 16, 27, 856, DateTimeKind.Utc).AddTicks(2007) });

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
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 12, 6, 27, 15, 454, DateTimeKind.Utc).AddTicks(1813), "Phòng IT", "Enim cum voluptate similique aperiam alias voluptates vel.", new DateTime(2024, 9, 12, 6, 27, 15, 454, DateTimeKind.Utc).AddTicks(1813) });

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
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 19, 23, 39, 33, 131, DateTimeKind.Utc).AddTicks(4733), "Phòng Sản xuất", "Quas laudantium est rerum quo numquam occaecati.", new DateTime(2024, 9, 19, 23, 39, 33, 131, DateTimeKind.Utc).AddTicks(4733) });

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
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 24, 17, 44, 35, 261, DateTimeKind.Utc).AddTicks(91), "Fantastic Granite Salad", true });

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
                columns: new[] { "CreateTime", "ProcessName" },
                values: new object[] { new DateTime(2024, 9, 24, 17, 44, 35, 261, DateTimeKind.Utc).AddTicks(153), "Refined Wooden Salad" });

            migrationBuilder.UpdateData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: 5,
                columns: new[] { "CreateTime", "ProcessName" },
                values: new object[] { new DateTime(2024, 9, 24, 17, 44, 35, 261, DateTimeKind.Utc).AddTicks(183), "Practical Concrete Chicken" });

            migrationBuilder.UpdateData(
                table: "QRCardStatus",
                keyColumn: "QRCardStatusId",
                keyValue: 1,
                column: "StatusNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "QRCardStatus",
                keyColumn: "QRCardStatusId",
                keyValue: 2,
                column: "StatusNumber",
                value: 0);

            migrationBuilder.UpdateData(
                table: "QRCardType",
                keyColumn: "QRCardTypeId",
                keyValue: 1,
                columns: new[] { "CardTypeName", "TypeDescription" },
                values: new object[] { "Employee", "Employee QR Card" });

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
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId", "QRCardTypeId" },
                values: new object[] { new Guid("5cae4542-64a4-402b-ae5f-18d7e92b4cd5"), new DateTime(2024, 9, 27, 0, 44, 35, 290, DateTimeKind.Local).AddTicks(9060), new DateTime(2024, 10, 27, 0, 44, 35, 290, DateTimeKind.Local).AddTicks(9060), 1, 1 });

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
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId", "QRCardTypeId" },
                values: new object[] { new Guid("6937454c-35d3-4262-b2f9-b9174fa17c1e"), new DateTime(2024, 9, 27, 0, 44, 35, 290, DateTimeKind.Local).AddTicks(9109), new DateTime(2024, 10, 27, 0, 44, 35, 290, DateTimeKind.Local).AddTicks(9109), 2, 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 7,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId" },
                values: new object[] { new Guid("c61fdcc6-c2b7-436a-9e3b-a39df1e1947d"), new DateTime(2024, 9, 27, 0, 44, 35, 290, DateTimeKind.Local).AddTicks(9117), new DateTime(2024, 10, 27, 0, 44, 35, 290, DateTimeKind.Local).AddTicks(9117), 1 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 8,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardTypeId" },
                values: new object[] { new Guid("f7237fb9-425a-4fea-9ea2-33ec774df898"), new DateTime(2024, 9, 27, 0, 44, 35, 290, DateTimeKind.Local).AddTicks(9124), new DateTime(2024, 10, 27, 0, 44, 35, 290, DateTimeKind.Local).AddTicks(9124), 1 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 9,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("3a486339-b74e-4b25-b9c6-b99265ae584f"), new DateTime(2024, 9, 27, 0, 44, 35, 290, DateTimeKind.Local).AddTicks(9131), new DateTime(2024, 10, 27, 0, 44, 35, 290, DateTimeKind.Local).AddTicks(9131) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 10,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId", "QRCardTypeId" },
                values: new object[] { new Guid("080fbedb-c95e-4b76-8f77-fbdee145f6a6"), new DateTime(2024, 9, 27, 0, 44, 35, 290, DateTimeKind.Local).AddTicks(9138), new DateTime(2024, 10, 27, 0, 44, 35, 290, DateTimeKind.Local).AddTicks(9138), 1, 1 });

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
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 1, 9 });

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
                column: "UserId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 9,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 2, 8 });

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
                column: "UserId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 14,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 6, 9 });

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
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 16 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 20,
                column: "UserId",
                value: 17);

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
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 44, 35, 230, DateTimeKind.Utc).AddTicks(2672), new DateTime(2024, 9, 26, 17, 44, 35, 230, DateTimeKind.Utc).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 26, 17, 44, 35, 230, DateTimeKind.Utc).AddTicks(2696), new DateTime(2024, 9, 26, 17, 44, 35, 230, DateTimeKind.Utc).AddTicks(2697) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 26, 17, 44, 35, 230, DateTimeKind.Utc).AddTicks(2699), new DateTime(2024, 9, 26, 17, 44, 35, 230, DateTimeKind.Utc).AddTicks(2699) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 17, 44, 35, 230, DateTimeKind.Utc).AddTicks(2702), new DateTime(2024, 9, 26, 17, 44, 35, 230, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 26, 17, 44, 35, 230, DateTimeKind.Utc).AddTicks(2707), new DateTime(2024, 9, 26, 17, 44, 35, 230, DateTimeKind.Utc).AddTicks(2707) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 24, 8, 39, 54, 885, DateTimeKind.Unspecified).AddTicks(7745), "gmail.com.Blanda39@yahoo.com", "Lonie Mosciski", "ulwkv5", "0991567878", 2, new DateTime(2024, 9, 24, 8, 39, 54, 885, DateTimeKind.Unspecified).AddTicks(7745), "Lorine.Mann" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 23, 12, 25, 57, 788, DateTimeKind.Unspecified).AddTicks(4181), "gmail.com.Donnelly@hotmail.com", "Lester Labadie", "jgb01q", "0553365070", 4, new DateTime(2024, 9, 23, 12, 25, 57, 788, DateTimeKind.Unspecified).AddTicks(4181), "Alene4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 16, 16, 17, 51, 94, DateTimeKind.Unspecified).AddTicks(6245), "gmail.com.Mohr95@hotmail.com", "Lane Predovic", "knc5r6", "0221970523", 2, new DateTime(2024, 9, 16, 16, 17, 51, 94, DateTimeKind.Unspecified).AddTicks(6245), "Bonita.Bogisich" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 23, 16, 52, 32, 787, DateTimeKind.Unspecified).AddTicks(396), "gmail.com77@hotmail.com", "Tyra Williamson", "jv9inh", "0116328159", 1, new DateTime(2024, 9, 23, 16, 52, 32, 787, DateTimeKind.Unspecified).AddTicks(396), "Jalon47" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 11, 10, 52, 29, 864, DateTimeKind.Unspecified).AddTicks(5030), "gmail.com_Towne49@gmail.com", "Cornelius Jaskolski", "grgy2y", "0151938174", 5, new DateTime(2024, 9, 11, 10, 52, 29, 864, DateTimeKind.Unspecified).AddTicks(5030), "Miguel11" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 20, 15, 37, 54, 216, DateTimeKind.Unspecified).AddTicks(7994), "gmail.com_Legros@yahoo.com", "Laron Armstrong", "ge2no4", "0214893544", 1, new DateTime(2024, 9, 20, 15, 37, 54, 216, DateTimeKind.Unspecified).AddTicks(7994), "Bruce53" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 8, 14, 37, 30, 367, DateTimeKind.Unspecified).AddTicks(9963), "gmail.com_Kovacek86@gmail.com", "Milford Beer", "nnfyjk", "0646218918", 5, new DateTime(2024, 9, 8, 14, 37, 30, 367, DateTimeKind.Unspecified).AddTicks(9963), "Henry_Wisozk84" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 8, 12, 16, 17, 26, DateTimeKind.Unspecified).AddTicks(8095), "gmail.com.Pagac@gmail.com", "Vidal Dickinson", "0cml1p", "0588937542", 5, new DateTime(2024, 9, 8, 12, 16, 17, 26, DateTimeKind.Unspecified).AddTicks(8095), "Geraldine.Witting24" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 13, 16, 43, 25, 241, DateTimeKind.Unspecified).AddTicks(8567), "gmail.com.Walter6@hotmail.com", "Antonina Mann", "mj0ol5", "0595465226", new DateTime(2024, 9, 13, 16, 43, 25, 241, DateTimeKind.Unspecified).AddTicks(8567), "Elliott78" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 16, 8, 32, 20, 893, DateTimeKind.Unspecified).AddTicks(8664), "gmail.com_Romaguera64@yahoo.com", "Vivianne Cronin", "khvh3f", "0360935333", 1, new DateTime(2024, 9, 16, 8, 32, 20, 893, DateTimeKind.Unspecified).AddTicks(8664), "Reanna60" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 21, 14, 41, 46, 773, DateTimeKind.Unspecified).AddTicks(1851), "gmail.com71@hotmail.com", "Irma Rempel", "4g67g8", "0447578667", 3, new DateTime(2024, 9, 21, 14, 41, 46, 773, DateTimeKind.Unspecified).AddTicks(1851), "Darrick_Corwin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 26, 2, 51, 7, 635, DateTimeKind.Unspecified).AddTicks(8708), "gmail.com_Russel@hotmail.com", "Morton Goyette", "wstw0a", "0149790096", 1, new DateTime(2024, 9, 26, 2, 51, 7, 635, DateTimeKind.Unspecified).AddTicks(8708), "Kyra.Bins" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 22, 17, 10, 59, 312, DateTimeKind.Unspecified).AddTicks(4969), "gmail.com_Hodkiewicz@hotmail.com", "Dominic Jacobi", "i681ks", "0509532710", 5, new DateTime(2024, 9, 22, 17, 10, 59, 312, DateTimeKind.Unspecified).AddTicks(4969), "Toney_Keebler" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 25, 12, 7, 55, 728, DateTimeKind.Unspecified).AddTicks(3257), "gmail.com24@yahoo.com", "Tyrique Wunsch", "u9mney", "0465510087", 5, new DateTime(2024, 9, 25, 12, 7, 55, 728, DateTimeKind.Unspecified).AddTicks(3257), "Mortimer.OKeefe64" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 22, 9, 43, 22, 443, DateTimeKind.Unspecified).AddTicks(3949), "gmail.com.OHara@hotmail.com", "Kaylie Maggio", "9msl8j", "0304581793", 3, new DateTime(2024, 9, 22, 9, 43, 22, 443, DateTimeKind.Unspecified).AddTicks(3949), "Aurelio_Bayer67" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 15, 20, 55, 59, 764, DateTimeKind.Unspecified).AddTicks(1779), "gmail.com.Frami@yahoo.com", "Warren Wolf", "60stzm", "0500706938", 2, new DateTime(2024, 9, 15, 20, 55, 59, 764, DateTimeKind.Unspecified).AddTicks(1779), "Lucious52" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 1, 4, 46, 45, 906, DateTimeKind.Unspecified).AddTicks(9554), "gmail.com45@hotmail.com", "Ronny Grant", "qqpkpx", "0226422437", 3, new DateTime(2024, 9, 1, 4, 46, 45, 906, DateTimeKind.Unspecified).AddTicks(9554), "Rosina63" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 7, 20, 46, 44, 831, DateTimeKind.Unspecified).AddTicks(6705), "gmail.com.Mraz@hotmail.com", "Caitlyn Boyle", "sbl7wz", "0844750600", 4, new DateTime(2024, 9, 7, 20, 46, 44, 831, DateTimeKind.Unspecified).AddTicks(6705), "Gino.Kuphal" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 12, 18, 10, 2, 32, DateTimeKind.Unspecified).AddTicks(5193), "gmail.com25@hotmail.com", "Hassan Weber", "m1ceb4", "0209969692", 2, new DateTime(2024, 9, 12, 18, 10, 2, 32, DateTimeKind.Unspecified).AddTicks(5193), "Alaina0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 11, 5, 2, 6, 196, DateTimeKind.Unspecified).AddTicks(8113), "gmail.com.Dicki@hotmail.com", "Delores Pfeffer", "xkb0v7", "0522252336", 1, new DateTime(2024, 9, 11, 5, 2, 6, 196, DateTimeKind.Unspecified).AddTicks(8113), "Johan.Bahringer95" });

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
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Accusantium eveniet delectus aut dolor sed mollitia optio. Fuga rerum in unde sint sit est sed laudantium. Voluptate aperiam quibusdam. Corporis porro voluptatem qui et ut quia aspernatur qui. Dicta enim minus labore. Eum facilis qui sit delectus distinctio.", new DateTime(2024, 9, 28, 0, 44, 35, 272, DateTimeKind.Local).AddTicks(2273), new DateTime(2024, 9, 27, 0, 44, 35, 272, DateTimeKind.Local).AddTicks(2269), 2 });

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
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Reiciendis nostrum et et maxime eaque fugit ducimus. Et molestias voluptates corporis. Sed nulla consequatur ut libero dolores reiciendis. Laboriosam facere suscipit expedita ratione maiores ut et.", new DateTime(2024, 9, 28, 0, 44, 35, 277, DateTimeKind.Local).AddTicks(6703), new DateTime(2024, 9, 27, 0, 44, 35, 277, DateTimeKind.Local).AddTicks(6653) });

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
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Quia non saepe sit aperiam. Veritatis facere aperiam corrupti velit est. Quo explicabo delectus.", new DateTime(2024, 9, 28, 0, 44, 35, 280, DateTimeKind.Local).AddTicks(2249), new DateTime(2024, 9, 27, 0, 44, 35, 280, DateTimeKind.Local).AddTicks(2245), 3 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 19,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Odit nobis quis repudiandae ut. Laboriosam voluptatem et dolorem quae. Eos repudiandae culpa nulla.", new DateTime(2024, 9, 28, 0, 44, 35, 281, DateTimeKind.Local).AddTicks(3950), new DateTime(2024, 9, 27, 0, 44, 35, 281, DateTimeKind.Local).AddTicks(3913) });

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
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Omnis quos ab vitae nihil. Vel numquam consequatur facilis. Similique velit et quis ipsa et nesciunt quia earum. Possimus voluptatem earum beatae qui et qui inventore perspiciatis. Necessitatibus cumque sint. Amet velit qui.", new DateTime(2024, 9, 28, 0, 44, 35, 286, DateTimeKind.Local).AddTicks(2311), new DateTime(2024, 9, 27, 0, 44, 35, 286, DateTimeKind.Local).AddTicks(2307) });

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
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Koss, Douglas and Hegmann", new DateTime(2024, 9, 5, 1, 5, 23, 828, DateTimeKind.Unspecified).AddTicks(2468), 2, "y35vdtmnuu", "0788662882", new DateTime(2024, 9, 5, 1, 5, 23, 828, DateTimeKind.Unspecified).AddTicks(2468), "Keith Hackett" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 3,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Lockman LLC", new DateTime(2024, 9, 24, 3, 31, 18, 141, DateTimeKind.Unspecified).AddTicks(1184), 2, "2czgaebm2q", "0433830887", new DateTime(2024, 9, 24, 3, 31, 18, 141, DateTimeKind.Unspecified).AddTicks(1184), "Ashlee Braun" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 4,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Swift - Kling", new DateTime(2024, 9, 18, 13, 56, 6, 309, DateTimeKind.Unspecified).AddTicks(3245), 2, "9v2aebajpq", "0255123828", true, new DateTime(2024, 9, 18, 13, 56, 6, 309, DateTimeKind.Unspecified).AddTicks(3245), "Keshawn Hickle" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 5,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Gaylord - Lynch", new DateTime(2024, 9, 10, 8, 3, 12, 369, DateTimeKind.Unspecified).AddTicks(8176), "c90usnsnqe", "0331274585", new DateTime(2024, 9, 10, 8, 3, 12, 369, DateTimeKind.Unspecified).AddTicks(8176), "Pauline Hegmann" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 6,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Toy, Bode and Schuster", new DateTime(2024, 9, 14, 18, 14, 10, 547, DateTimeKind.Unspecified).AddTicks(388), 1, "qmsqphh7d3", "0108962028", true, new DateTime(2024, 9, 14, 18, 14, 10, 547, DateTimeKind.Unspecified).AddTicks(388), "Milton Tromp" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 7,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Mertz, Cole and Abernathy", new DateTime(2024, 9, 8, 19, 2, 44, 447, DateTimeKind.Unspecified).AddTicks(8471), 1, "nakn16hn0t", "0737561338", true, new DateTime(2024, 9, 8, 19, 2, 44, 447, DateTimeKind.Unspecified).AddTicks(8471), "Chanelle Kuhn" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 8,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Lueilwitz - Hammes", new DateTime(2024, 9, 19, 13, 0, 2, 28, DateTimeKind.Unspecified).AddTicks(3782), 2, "asz53w3i38", "0799065748", false, new DateTime(2024, 9, 19, 13, 0, 2, 28, DateTimeKind.Unspecified).AddTicks(3782), "Kyla Gusikowski" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 9,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Gerhold Group", new DateTime(2024, 9, 18, 6, 15, 57, 750, DateTimeKind.Unspecified).AddTicks(224), 1, "lege78crxr", "0964428277", new DateTime(2024, 9, 18, 6, 15, 57, 750, DateTimeKind.Unspecified).AddTicks(224), "Savion Gerlach" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 10,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Wuckert, Kilback and Legros", new DateTime(2024, 9, 1, 19, 55, 45, 516, DateTimeKind.Unspecified).AddTicks(2638), "bcgmq0fzka", "0484624694", true, new DateTime(2024, 9, 1, 19, 55, 45, 516, DateTimeKind.Unspecified).AddTicks(2638), "Makayla Jacobson" });

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
    }
}
