using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SecurityGateApv.Infras.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDb_6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "CardGuidId",
                table: "QRCards");

            migrationBuilder.AddColumn<string>(
                name: "CardImage",
                table: "QRCards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CardVerification",
                table: "QRCards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 1, 34, 47, 59, DateTimeKind.Utc).AddTicks(6436), "Phòng Nhân sự", "Quia qui molestiae.", new DateTime(2024, 9, 3, 1, 34, 47, 59, DateTimeKind.Utc).AddTicks(6436) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 8, 10, 11, 44, 422, DateTimeKind.Utc).AddTicks(5923), "Phòng R&D", "Alias dolor quas.", new DateTime(2024, 9, 8, 10, 11, 44, 422, DateTimeKind.Utc).AddTicks(5923) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 11, 5, 25, 41, 970, DateTimeKind.Utc).AddTicks(9107), "Phòng Chăm sóc khách hàng", "At aut est eos.", new DateTime(2024, 9, 11, 5, 25, 41, 970, DateTimeKind.Utc).AddTicks(9107) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 7, 10, 26, 39, 155, DateTimeKind.Utc).AddTicks(6395), "Phòng Kế toán", "Qui corrupti et assumenda dolorem vitae harum.", new DateTime(2024, 9, 7, 10, 26, 39, 155, DateTimeKind.Utc).AddTicks(6395) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 16, 22, 30, 44, 422, DateTimeKind.Utc).AddTicks(554), "Phòng Kinh doanh", "Voluptatem aliquid odio autem tempore deleniti doloremque in.", new DateTime(2024, 9, 16, 22, 30, 44, 422, DateTimeKind.Utc).AddTicks(554) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 6,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 9, 18, 51, 54, 468, DateTimeKind.Utc).AddTicks(5681), "Phòng Kế toán", "In sapiente est quam.", new DateTime(2024, 9, 9, 18, 51, 54, 468, DateTimeKind.Utc).AddTicks(5681) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 7,
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 20, 9, 10, 35, 398, DateTimeKind.Utc).AddTicks(42), "Phòng R&D", "Quas dicta id esse eius ipsam quis voluptatem provident.", new DateTime(2024, 9, 20, 9, 10, 35, 398, DateTimeKind.Utc).AddTicks(42) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 8,
                columns: new[] { "AcceptLevel", "CreateDate", "Description", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 9, 20, 13, 11, 30, 690, DateTimeKind.Utc).AddTicks(9630), "Laborum harum voluptas nemo.", new DateTime(2024, 9, 20, 13, 11, 30, 690, DateTimeKind.Utc).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 9,
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 17, 16, 57, 49, 628, DateTimeKind.Utc).AddTicks(6104), "Phòng IT", "Qui officia delectus dolore similique officia quae expedita itaque.", new DateTime(2024, 9, 17, 16, 57, 49, 628, DateTimeKind.Utc).AddTicks(6104) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 10,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 5, 21, 42, 25, 502, DateTimeKind.Utc).AddTicks(607), "Phòng R&D", "Atque dolores et ut corporis modi.", new DateTime(2024, 9, 5, 21, 42, 25, 502, DateTimeKind.Utc).AddTicks(607) });

            migrationBuilder.UpdateData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: 1,
                columns: new[] { "CreateTime", "ProcessName" },
                values: new object[] { new DateTime(2024, 9, 25, 7, 56, 50, 181, DateTimeKind.Utc).AddTicks(8520), "Incredible Concrete Ball" });

            migrationBuilder.UpdateData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: 2,
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 25, 7, 56, 50, 182, DateTimeKind.Utc).AddTicks(179), "Incredible Soft Bacon", true });

            migrationBuilder.UpdateData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: 3,
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 25, 7, 56, 50, 182, DateTimeKind.Utc).AddTicks(207), "Unbranded Soft Keyboard", false });

            migrationBuilder.UpdateData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: 4,
                columns: new[] { "CreateTime", "ProcessName" },
                values: new object[] { new DateTime(2024, 9, 25, 7, 56, 50, 182, DateTimeKind.Utc).AddTicks(228), "Sleek Metal Car" });

            migrationBuilder.UpdateData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: 5,
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 25, 7, 56, 50, 182, DateTimeKind.Utc).AddTicks(247), "Handcrafted Granite Shirt", false });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 4,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 2, 13 });

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
                values: new object[] { 6, 11 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 7,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 16 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 8,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 25 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 9,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 6, 8 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 10,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 3, 9 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 11,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 3, 7 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 12,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 4, 11 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 13,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 3, 19 });

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
                values: new object[] { 1, 13 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 16,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 1, 17 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 17,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 1, 23 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 18,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 3, 7 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 19,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 6 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 20,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 5, 6 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 21,
                column: "DepartmentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 22,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 10, 13 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 23,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 10 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 27, 7, 56, 50, 146, DateTimeKind.Utc).AddTicks(471), new DateTime(2024, 9, 27, 7, 56, 50, 146, DateTimeKind.Utc).AddTicks(480) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 7, 56, 50, 146, DateTimeKind.Utc).AddTicks(493), new DateTime(2024, 9, 27, 7, 56, 50, 146, DateTimeKind.Utc).AddTicks(494) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 27, 7, 56, 50, 146, DateTimeKind.Utc).AddTicks(496), new DateTime(2024, 9, 27, 7, 56, 50, 146, DateTimeKind.Utc).AddTicks(497) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 27, 7, 56, 50, 146, DateTimeKind.Utc).AddTicks(498), new DateTime(2024, 9, 27, 7, 56, 50, 146, DateTimeKind.Utc).AddTicks(499) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 27, 7, 56, 50, 146, DateTimeKind.Utc).AddTicks(501), new DateTime(2024, 9, 27, 7, 56, 50, 146, DateTimeKind.Utc).AddTicks(502) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 6, 8, 30, 26, 82, DateTimeKind.Unspecified).AddTicks(5140), "gmail.com_Smith@gmail.com", "Blake Thiel", "h6ywhi", "0611215346", 2, new DateTime(2024, 9, 6, 8, 30, 26, 82, DateTimeKind.Unspecified).AddTicks(5140), "Darien63" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 20, 1, 17, 58, 358, DateTimeKind.Unspecified).AddTicks(4155), "gmail.com_Williamson@yahoo.com", "Karley Kuvalis", "wo3jgw", "0521933719", 3, new DateTime(2024, 9, 20, 1, 17, 58, 358, DateTimeKind.Unspecified).AddTicks(4155), "Valentina70" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 3, 3, 18, 8, 698, DateTimeKind.Unspecified).AddTicks(7571), "gmail.com_Kuhic@hotmail.com", "Lorna Douglas", "xjua0l", "0222541758", 5, new DateTime(2024, 9, 3, 3, 18, 8, 698, DateTimeKind.Unspecified).AddTicks(7571), "Vernie1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 20, 17, 25, 41, 747, DateTimeKind.Unspecified).AddTicks(148), "gmail.com10@gmail.com", "Mauricio Tremblay", "qh6m0u", "0944667846", 5, new DateTime(2024, 9, 20, 17, 25, 41, 747, DateTimeKind.Unspecified).AddTicks(148), "Cooper96" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 21, 8, 39, 14, 211, DateTimeKind.Unspecified).AddTicks(4626), "gmail.com_Botsford@yahoo.com", "Rubye Sipes", "wq5uuw", "0820807900", new DateTime(2024, 9, 21, 8, 39, 14, 211, DateTimeKind.Unspecified).AddTicks(4626), "Tracy25" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 1, 4, 30, 33, 382, DateTimeKind.Unspecified).AddTicks(5988), "gmail.com.Maggio@gmail.com", "Bertram Spinka", "dl3nda", "0270653054", 5, new DateTime(2024, 9, 1, 4, 30, 33, 382, DateTimeKind.Unspecified).AddTicks(5988), "Conor15" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 24, 17, 52, 26, 953, DateTimeKind.Unspecified).AddTicks(4120), "gmail.com56@gmail.com", "Isai Simonis", "odgv8t", "0682148525", new DateTime(2024, 9, 24, 17, 52, 26, 953, DateTimeKind.Unspecified).AddTicks(4120), "Zelma42" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 9, 4, 1, 24, 541, DateTimeKind.Unspecified).AddTicks(4557), "gmail.com.Von96@gmail.com", "Frederique Ferry", "rlt7tb", "0513872380", new DateTime(2024, 9, 9, 4, 1, 24, 541, DateTimeKind.Unspecified).AddTicks(4557), "Ronny_Oberbrunner22" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 20, 22, 9, 46, 998, DateTimeKind.Unspecified).AddTicks(7441), "gmail.com_Miller23@yahoo.com", "Margaret Bahringer", "8c3wmq", "0954008027", new DateTime(2024, 9, 20, 22, 9, 46, 998, DateTimeKind.Unspecified).AddTicks(7441), "Kamryn1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 9, 12, 26, 18, 634, DateTimeKind.Unspecified).AddTicks(8712), "gmail.com90@yahoo.com", "Mack Dickinson", "9gz7oe", "0492448778", 2, new DateTime(2024, 9, 9, 12, 26, 18, 634, DateTimeKind.Unspecified).AddTicks(8712), "Shayna45" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 23, 10, 15, 38, 862, DateTimeKind.Unspecified).AddTicks(5427), "gmail.com.McGlynn35@hotmail.com", "Stefan Spencer", "67nr8f", "0278216650", 3, new DateTime(2024, 9, 23, 10, 15, 38, 862, DateTimeKind.Unspecified).AddTicks(5427), "Edgardo_Schinner74" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 14, 41, 899, DateTimeKind.Unspecified).AddTicks(9903), "gmail.com_Mosciski10@yahoo.com", "Bernita Quigley", "0tawfm", "0797961069", 5, new DateTime(2024, 9, 26, 1, 14, 41, 899, DateTimeKind.Unspecified).AddTicks(9903), "Isabella.Mills" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 21, 18, 40, 56, 270, DateTimeKind.Unspecified).AddTicks(9883), "gmail.com_Cruickshank@hotmail.com", "Maximillian Raynor", "ilbwbv", "0723605984", 3, new DateTime(2024, 9, 21, 18, 40, 56, 270, DateTimeKind.Unspecified).AddTicks(9883), "Will_Baumbach" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 18, 7, 33, 20, 388, DateTimeKind.Unspecified).AddTicks(8283), "gmail.com70@gmail.com", "Yasmin Yost", "314vj1", "0650493058", 4, new DateTime(2024, 9, 18, 7, 33, 20, 388, DateTimeKind.Unspecified).AddTicks(8283), "Malvina17" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 15, 6, 0, 7, 302, DateTimeKind.Unspecified).AddTicks(5373), "gmail.com_Parker78@yahoo.com", "Eveline Bode", "d1hc7q", "0662764892", 4, new DateTime(2024, 9, 15, 6, 0, 7, 302, DateTimeKind.Unspecified).AddTicks(5373), "Alvera71" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 14, 11, 30, 27, 990, DateTimeKind.Unspecified).AddTicks(251), "gmail.com67@hotmail.com", "Wiley Kautzer", "k5rlvv", "0834868549", 4, new DateTime(2024, 9, 14, 11, 30, 27, 990, DateTimeKind.Unspecified).AddTicks(251), "Oleta34" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 12, 10, 39, 46, 782, DateTimeKind.Unspecified).AddTicks(9164), "gmail.com32@yahoo.com", "Daniella Thompson", "wahogt", "0116034505", 4, new DateTime(2024, 9, 12, 10, 39, 46, 782, DateTimeKind.Unspecified).AddTicks(9164), "Nathen45" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 12, 13, 10, 33, 13, DateTimeKind.Unspecified).AddTicks(1369), "gmail.com_Bayer@hotmail.com", "Fiona Strosin", "0ubsbg", "0140171354", 5, new DateTime(2024, 9, 12, 13, 10, 33, 13, DateTimeKind.Unspecified).AddTicks(1369), "Zion_Littel" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 5, 5, 13, 59, 994, DateTimeKind.Unspecified).AddTicks(5273), "gmail.com60@yahoo.com", "Milton Pouros", "mvopu2", "0671466332", 4, new DateTime(2024, 9, 5, 5, 13, 59, 994, DateTimeKind.Unspecified).AddTicks(5273), "Garfield_Runolfsdottir" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 17, 20, 40, 48, 533, DateTimeKind.Unspecified).AddTicks(9747), "gmail.com.Carter9@yahoo.com", "Virginia McKenzie", "ha1nc8", "0906872833", 5, new DateTime(2024, 9, 17, 20, 40, 48, 533, DateTimeKind.Unspecified).AddTicks(9747), "Adrianna73" });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 1,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Et ipsa mollitia minima veniam aut aut alias. Voluptas earum veniam laudantium unde. Libero porro nobis rem aut maiores nemo est consectetur. Praesentium delectus ullam aliquid debitis totam magni possimus. Vel ut unde modi est.", new DateTime(2024, 10, 26, 14, 56, 50, 187, DateTimeKind.Local).AddTicks(3020), new DateTime(2024, 9, 26, 14, 56, 50, 187, DateTimeKind.Local).AddTicks(2974), 2 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 2,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Debitis distinctio provident dolor. Est totam voluptas consequatur quae aspernatur ab facere. Maiores quam dolores ex cum provident voluptatem. Cumque et quo deserunt sed beatae. Tempora et rem exercitationem necessitatibus expedita necessitatibus placeat.", new DateTime(2024, 10, 26, 14, 56, 50, 187, DateTimeKind.Local).AddTicks(3430), new DateTime(2024, 9, 26, 14, 56, 50, 187, DateTimeKind.Local).AddTicks(3427), 2 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 3,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Consequatur eveniet ipsa. Tenetur dolor suscipit distinctio. Eius beatae maxime voluptatibus reprehenderit non iusto natus. Vero ut beatae sunt aliquam rerum quae iusto. Id inventore aperiam aliquam.", new DateTime(2024, 9, 28, 14, 56, 50, 189, DateTimeKind.Local).AddTicks(8954), new DateTime(2024, 9, 27, 14, 56, 50, 189, DateTimeKind.Local).AddTicks(8915), 7 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 4,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Mollitia qui aliquam sunt eius qui totam quia. Culpa quos ut voluptatem et impedit. Odit autem perferendis molestiae voluptatem dolorum. Natus molestiae et sed. Maiores quas qui ea rem deserunt in id ea. Minima accusantium temporibus inventore ut ut.", new DateTime(2024, 9, 28, 14, 56, 50, 189, DateTimeKind.Local).AddTicks(9260), new DateTime(2024, 9, 27, 14, 56, 50, 189, DateTimeKind.Local).AddTicks(9257), 3 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 5,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Dolore eum tempora rem quibusdam odit quas. Voluptatem eveniet atque voluptatem tempore dolorem sed quis. Mollitia placeat eum ut tempora temporibus inventore.", new DateTime(2024, 9, 28, 14, 56, 50, 191, DateTimeKind.Local).AddTicks(685), new DateTime(2024, 9, 27, 14, 56, 50, 191, DateTimeKind.Local).AddTicks(655), 3 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 6,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Qui doloremque ut qui sed. Labore repudiandae officia quaerat qui. Deleniti consequuntur aspernatur. Voluptas ut sit quam et doloremque voluptatem.", new DateTime(2024, 9, 28, 14, 56, 50, 191, DateTimeKind.Local).AddTicks(911), new DateTime(2024, 9, 27, 14, 56, 50, 191, DateTimeKind.Local).AddTicks(908), 9 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 7,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Autem tempore qui. Architecto sit accusantium nulla soluta illum consequatur est saepe. Perspiciatis laudantium aut est excepturi. Beatae maxime architecto vel repudiandae sint distinctio sed.", new DateTime(2024, 9, 28, 14, 56, 50, 192, DateTimeKind.Local).AddTicks(4758), new DateTime(2024, 9, 27, 14, 56, 50, 192, DateTimeKind.Local).AddTicks(4694), 1 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 8,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Inventore et qui vitae eum cupiditate deleniti atque ullam dolores. Fugit eaque enim nihil nobis odit et consequatur cumque. Placeat omnis quam rerum sint quas est. Minus at iure amet dignissimos. Voluptas autem expedita quos vitae.", new DateTime(2024, 9, 28, 14, 56, 50, 192, DateTimeKind.Local).AddTicks(5116), new DateTime(2024, 9, 27, 14, 56, 50, 192, DateTimeKind.Local).AddTicks(5113), 10 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 9,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Sapiente quae sed molestias optio voluptatem. Magni perspiciatis porro voluptas error assumenda. Et aut voluptas voluptas. Dolores tenetur dolorem laudantium iure. Adipisci ex unde ab minus.", new DateTime(2024, 9, 28, 14, 56, 50, 194, DateTimeKind.Local).AddTicks(1237), new DateTime(2024, 9, 27, 14, 56, 50, 194, DateTimeKind.Local).AddTicks(1197), 9 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 10,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Possimus quas ducimus sed fuga ut deserunt ut aliquam sit. Debitis eaque necessitatibus beatae vel aut. Enim provident ipsa. Quisquam molestias aut porro eum est dolores ea.", new DateTime(2024, 9, 28, 14, 56, 50, 194, DateTimeKind.Local).AddTicks(1503), new DateTime(2024, 9, 27, 14, 56, 50, 194, DateTimeKind.Local).AddTicks(1501), 4 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 11,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Et qui quod delectus odit sit impedit. Aut mollitia ut saepe. Perspiciatis autem esse et alias nesciunt sint rerum ratione cupiditate.", new DateTime(2024, 9, 28, 14, 56, 50, 196, DateTimeKind.Local).AddTicks(9531), new DateTime(2024, 9, 27, 14, 56, 50, 196, DateTimeKind.Local).AddTicks(9490), 9 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 12,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Aspernatur culpa itaque numquam ut iusto. Quod magnam labore deleniti. Libero deserunt doloribus eum sapiente neque maiores.", new DateTime(2024, 9, 28, 14, 56, 50, 196, DateTimeKind.Local).AddTicks(9773), new DateTime(2024, 9, 27, 14, 56, 50, 196, DateTimeKind.Local).AddTicks(9770), 5 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 13,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Aliquam quidem fugit quo mollitia. Saepe vitae ex. Ullam temporibus animi. At quia quae rerum assumenda eos unde qui quia. Cum quas necessitatibus eum magni sapiente mollitia. Ad et sed ipsa non et nesciunt enim quia.", new DateTime(2024, 9, 28, 14, 56, 50, 198, DateTimeKind.Local).AddTicks(2920), new DateTime(2024, 9, 27, 14, 56, 50, 198, DateTimeKind.Local).AddTicks(2887), 3 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 14,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Quam aut quis veniam dolores enim nostrum beatae. Vitae sed aperiam. Deserunt qui et ut alias dolorem suscipit ea aspernatur. Delectus aliquam et non quo et velit. Beatae reprehenderit iusto ut magni aut deleniti quia ea eum. Voluptatem veniam vitae.", new DateTime(2024, 9, 28, 14, 56, 50, 198, DateTimeKind.Local).AddTicks(3203), new DateTime(2024, 9, 27, 14, 56, 50, 198, DateTimeKind.Local).AddTicks(3201) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 15,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Repellat animi hic quasi. Tempora et quaerat hic quis eius rem fuga dolores cumque. Ab enim nobis velit. Sunt accusantium vel ut porro ad dolore ut et. Necessitatibus autem aut quia aspernatur sunt veniam aut.", new DateTime(2024, 9, 28, 14, 56, 50, 199, DateTimeKind.Local).AddTicks(5390), new DateTime(2024, 9, 27, 14, 56, 50, 199, DateTimeKind.Local).AddTicks(5356), 1 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 16,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Porro recusandae laboriosam voluptate excepturi. Numquam dolorum vel illo ut iure id. Possimus voluptatem doloremque occaecati. Quis reiciendis error libero.", new DateTime(2024, 9, 28, 14, 56, 50, 199, DateTimeKind.Local).AddTicks(5612), new DateTime(2024, 9, 27, 14, 56, 50, 199, DateTimeKind.Local).AddTicks(5610), 2 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 17,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Dolores praesentium et dolores aut praesentium voluptas nulla. Enim deserunt voluptate ad aut tempora a omnis alias qui. Minima ab cupiditate ut et et. Ut voluptas dolor ab officia. Reprehenderit repellat eveniet aperiam ut qui. Cum iste dolor iusto et ut.", new DateTime(2024, 9, 28, 14, 56, 50, 200, DateTimeKind.Local).AddTicks(7603), new DateTime(2024, 9, 27, 14, 56, 50, 200, DateTimeKind.Local).AddTicks(7570), 1 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 18,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Quo tempora facilis velit ut in totam dolorum debitis dolor. Et nisi consectetur velit quae voluptatem minus quas totam. Nostrum id ullam. Aut nobis et placeat eos et sequi. Vel error numquam fuga. Illo et error debitis eaque quis animi et ipsa.", new DateTime(2024, 9, 28, 14, 56, 50, 200, DateTimeKind.Local).AddTicks(7880), new DateTime(2024, 9, 27, 14, 56, 50, 200, DateTimeKind.Local).AddTicks(7877), 8 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 19,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Dolores mollitia dolorem aut. Et quas et repellat iusto. Soluta incidunt magni laboriosam unde sunt eaque qui. Incidunt suscipit veniam autem. Quos dolores magni quaerat accusamus esse quisquam.", new DateTime(2024, 9, 28, 14, 56, 50, 201, DateTimeKind.Local).AddTicks(8997), new DateTime(2024, 9, 27, 14, 56, 50, 201, DateTimeKind.Local).AddTicks(8967), 3 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 20,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Et qui explicabo magni consequatur iure et reprehenderit debitis. Voluptate corporis id. Provident consectetur omnis culpa eaque minima quisquam culpa ipsum. Qui est sapiente voluptas ea et blanditiis ipsam ratione possimus.", new DateTime(2024, 9, 28, 14, 56, 50, 201, DateTimeKind.Local).AddTicks(9235), new DateTime(2024, 9, 27, 14, 56, 50, 201, DateTimeKind.Local).AddTicks(9233), 6 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 21,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Repellat dolore tempore ea ipsam quia laudantium. Minus at cum in. Dicta et rerum voluptatem corporis est molestiae dolore natus voluptatem. Quisquam enim esse ea sunt praesentium. Vel amet nisi delectus neque exercitationem ratione nemo tempora vel. Hic omnis suscipit sint.", new DateTime(2024, 9, 28, 14, 56, 50, 203, DateTimeKind.Local).AddTicks(1076), new DateTime(2024, 9, 27, 14, 56, 50, 203, DateTimeKind.Local).AddTicks(1046), 4 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 22,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Maiores accusantium itaque error. Voluptatem doloremque ut. Id et asperiores labore et illo quas blanditiis quo. Consectetur et repellendus saepe corrupti. Recusandae nulla odio. Ut dolor ut molestiae eos id fugit temporibus numquam.", new DateTime(2024, 9, 28, 14, 56, 50, 203, DateTimeKind.Local).AddTicks(1342), new DateTime(2024, 9, 27, 14, 56, 50, 203, DateTimeKind.Local).AddTicks(1340), 6 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 23,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Omnis a omnis est veniam aperiam laboriosam esse. Et voluptas recusandae in. Velit blanditiis incidunt est sed. Aut ut eum neque veritatis odio quae natus asperiores. Nulla voluptatem mollitia corrupti velit sint placeat aut ea.", new DateTime(2024, 9, 28, 14, 56, 50, 204, DateTimeKind.Local).AddTicks(3860), new DateTime(2024, 9, 27, 14, 56, 50, 204, DateTimeKind.Local).AddTicks(3826), 10 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 24,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Necessitatibus est quaerat reiciendis dicta tenetur. Amet voluptatem omnis harum enim aperiam et. Voluptatem blanditiis vero et voluptatum omnis dolor et architecto. Aliquid cupiditate ut optio hic voluptatem.", new DateTime(2024, 9, 28, 14, 56, 50, 204, DateTimeKind.Local).AddTicks(4105), new DateTime(2024, 9, 27, 14, 56, 50, 204, DateTimeKind.Local).AddTicks(4103), 9 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 25,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Debitis autem porro nostrum eaque itaque quasi magni. Omnis dolorem a velit consequuntur. Veniam ut aut dolores ut illum mollitia quia et accusantium. Eveniet labore aut harum. Quis esse nemo qui. Aut voluptates quas.", new DateTime(2024, 9, 28, 14, 56, 50, 205, DateTimeKind.Local).AddTicks(5445), new DateTime(2024, 9, 27, 14, 56, 50, 205, DateTimeKind.Local).AddTicks(5416), 4 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 26,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Rem rem iure suscipit esse rem non. Tenetur iusto ad voluptas facere officiis beatae nostrum voluptatum placeat. Qui unde adipisci mollitia.", new DateTime(2024, 9, 28, 14, 56, 50, 205, DateTimeKind.Local).AddTicks(5652), new DateTime(2024, 9, 27, 14, 56, 50, 205, DateTimeKind.Local).AddTicks(5649), 4 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 27,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Eius commodi sit reprehenderit. Aspernatur illum rerum sint voluptas provident sint. Neque maxime natus est vel distinctio. Magni et ipsam quia id dicta. Odio molestiae sit eveniet perspiciatis excepturi autem cupiditate. Quidem cupiditate explicabo dolor.", new DateTime(2024, 9, 28, 14, 56, 50, 207, DateTimeKind.Local).AddTicks(6467), new DateTime(2024, 9, 27, 14, 56, 50, 207, DateTimeKind.Local).AddTicks(6433), 6 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 28,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Illo id consequuntur placeat. Sed numquam possimus ut. Porro at aut nobis quibusdam molestiae quo facere. Nihil totam rerum delectus dolorem.", new DateTime(2024, 9, 28, 14, 56, 50, 207, DateTimeKind.Local).AddTicks(6708), new DateTime(2024, 9, 27, 14, 56, 50, 207, DateTimeKind.Local).AddTicks(6706), 2 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 29,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Debitis sed animi provident. Itaque possimus officiis repellendus. Cum tempore rerum nihil dolores odit ab occaecati. Voluptatem consequatur ullam omnis dolorem neque. Ut quasi amet ut perspiciatis non. Autem facilis blanditiis delectus non libero ea voluptatem quis.", new DateTime(2024, 9, 28, 14, 56, 50, 209, DateTimeKind.Local).AddTicks(3773), new DateTime(2024, 9, 27, 14, 56, 50, 209, DateTimeKind.Local).AddTicks(3727), 4 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 30,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Non sit fuga vitae et quod voluptatem vitae. Est animi dolorem laborum autem odio aut aspernatur quia. Doloremque velit est sed aut est facilis debitis architecto illo. Eos officiis ducimus dolorum qui quis expedita eum velit. Odit exercitationem minus fugit omnis blanditiis.", new DateTime(2024, 9, 28, 14, 56, 50, 209, DateTimeKind.Local).AddTicks(4082), new DateTime(2024, 9, 27, 14, 56, 50, 209, DateTimeKind.Local).AddTicks(4079), 8 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 31,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Ea quis rerum corrupti soluta. Suscipit veniam nihil facilis maxime natus quaerat rerum. Recusandae voluptatum consequatur libero et commodi omnis. Quis eius omnis voluptas aut qui.", new DateTime(2024, 9, 28, 14, 56, 50, 210, DateTimeKind.Local).AddTicks(6831), new DateTime(2024, 9, 27, 14, 56, 50, 210, DateTimeKind.Local).AddTicks(6798), 3 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 32,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Debitis laboriosam ratione qui voluptatem ratione. Vitae iure eligendi similique accusamus. Ipsum beatae quibusdam nihil consequatur sit mollitia.", new DateTime(2024, 9, 28, 14, 56, 50, 210, DateTimeKind.Local).AddTicks(7057), new DateTime(2024, 9, 27, 14, 56, 50, 210, DateTimeKind.Local).AddTicks(7055), 5 });

            migrationBuilder.UpdateData(
                table: "VisitProcesses",
                keyColumn: "VisitProcessId",
                keyValue: 1,
                columns: new[] { "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { new DateTime(2024, 10, 26, 14, 56, 50, 185, DateTimeKind.Local).AddTicks(9332), new DateTime(2024, 9, 26, 14, 56, 50, 185, DateTimeKind.Local).AddTicks(9281) });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 1,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Jacobs and Sons", new DateTime(2024, 9, 12, 11, 55, 11, 662, DateTimeKind.Unspecified).AddTicks(9820), 1, "4yplyt6uez", "0898721065", new DateTime(2024, 9, 12, 11, 55, 11, 662, DateTimeKind.Unspecified).AddTicks(9820), "Maxwell Moore" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 2,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Rolfson - Kautzer", new DateTime(2024, 9, 3, 15, 32, 48, 791, DateTimeKind.Unspecified).AddTicks(703), 2, "muhsxgye6a", "0753484471", true, new DateTime(2024, 9, 3, 15, 32, 48, 791, DateTimeKind.Unspecified).AddTicks(703), "Florencio Prosacco" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 3,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Reichert, Abbott and Schoen", new DateTime(2024, 9, 4, 12, 54, 25, 886, DateTimeKind.Unspecified).AddTicks(1878), 2, "snx5ja6p0h", "0489475208", new DateTime(2024, 9, 4, 12, 54, 25, 886, DateTimeKind.Unspecified).AddTicks(1878), "Amparo Hackett" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 4,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Fritsch Inc", new DateTime(2024, 9, 13, 3, 16, 52, 488, DateTimeKind.Unspecified).AddTicks(3049), "tlgx5pumph", "0337746853", new DateTime(2024, 9, 13, 3, 16, 52, 488, DateTimeKind.Unspecified).AddTicks(3049), "Sidney Miller" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 5,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Kozey, Satterfield and Pfeffer", new DateTime(2024, 9, 26, 10, 14, 34, 786, DateTimeKind.Unspecified).AddTicks(6475), "pdrmualwbp", "0113409242", new DateTime(2024, 9, 26, 10, 14, 34, 786, DateTimeKind.Unspecified).AddTicks(6475), "Hiram O'Kon" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 6,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Keeling - McCullough", new DateTime(2024, 9, 19, 3, 57, 18, 507, DateTimeKind.Unspecified).AddTicks(3540), "7eu9flscev", "0332079648", new DateTime(2024, 9, 19, 3, 57, 18, 507, DateTimeKind.Unspecified).AddTicks(3540), "Uriel Wilkinson" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 7,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Herzog - Feeney", new DateTime(2024, 9, 2, 11, 47, 41, 71, DateTimeKind.Unspecified).AddTicks(3484), 1, "soi62r0fnp", "0512536706", true, new DateTime(2024, 9, 2, 11, 47, 41, 71, DateTimeKind.Unspecified).AddTicks(3484), "Johathan Koch" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 8,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Blanda - Stokes", new DateTime(2024, 9, 18, 15, 52, 24, 64, DateTimeKind.Unspecified).AddTicks(3912), "mfp63ct6dr", "0887340197", false, new DateTime(2024, 9, 18, 15, 52, 24, 64, DateTimeKind.Unspecified).AddTicks(3912), "Rachelle Marks" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 9,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Bernhard Group", new DateTime(2024, 9, 20, 14, 3, 40, 84, DateTimeKind.Unspecified).AddTicks(1329), "d8cqtymgkn", "0225330893", false, new DateTime(2024, 9, 20, 14, 3, 40, 84, DateTimeKind.Unspecified).AddTicks(1329), "Elbert Connelly" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 10,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Fahey and Sons", new DateTime(2024, 9, 4, 22, 20, 48, 717, DateTimeKind.Unspecified).AddTicks(9728), "gogvtb8war", "0341492110", true, new DateTime(2024, 9, 4, 22, 20, 48, 717, DateTimeKind.Unspecified).AddTicks(9728), "Juanita Hoeger" });

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 1,
                column: "DateRegister",
                value: new DateTime(2024, 9, 25, 14, 56, 50, 183, DateTimeKind.Local).AddTicks(1762));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 2,
                column: "DateRegister",
                value: new DateTime(2024, 9, 27, 7, 56, 50, 188, DateTimeKind.Utc).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 3,
                column: "DateRegister",
                value: new DateTime(2024, 9, 27, 7, 56, 50, 188, DateTimeKind.Utc).AddTicks(6898));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 4,
                column: "DateRegister",
                value: new DateTime(2024, 9, 27, 7, 56, 50, 188, DateTimeKind.Utc).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 5,
                column: "DateRegister",
                value: new DateTime(2024, 9, 27, 7, 56, 50, 188, DateTimeKind.Utc).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 6,
                column: "DateRegister",
                value: new DateTime(2024, 9, 27, 7, 56, 50, 188, DateTimeKind.Utc).AddTicks(6934));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardImage",
                table: "QRCards");

            migrationBuilder.DropColumn(
                name: "CardVerification",
                table: "QRCards");

            migrationBuilder.AddColumn<Guid>(
                name: "CardGuidId",
                table: "QRCards",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 23, 17, 49, 32, 884, DateTimeKind.Utc).AddTicks(3363), "Phòng Sản xuất", "Reprehenderit id quos voluptas incidunt.", new DateTime(2024, 9, 23, 17, 49, 32, 884, DateTimeKind.Utc).AddTicks(3363) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 11, 7, 33, 46, 754, DateTimeKind.Utc).AddTicks(305), "Phòng Kinh doanh", "Doloremque rem ducimus doloribus quod autem mollitia sapiente ipsam voluptatem.", new DateTime(2024, 9, 11, 7, 33, 46, 754, DateTimeKind.Utc).AddTicks(305) });

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
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2024, 9, 10, 3, 0, 14, 404, DateTimeKind.Utc).AddTicks(5117), "Phòng Sản xuất", "Recusandae vel velit doloribus illo animi veritatis sit beatae.", new DateTime(2024, 9, 10, 3, 0, 14, 404, DateTimeKind.Utc).AddTicks(5117) });

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
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 19, 59, 132, DateTimeKind.Utc).AddTicks(7769), "Phòng Nhân sự", "Ipsam non est suscipit aut.", new DateTime(2024, 9, 11, 23, 19, 59, 132, DateTimeKind.Utc).AddTicks(7769) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 8,
                columns: new[] { "AcceptLevel", "CreateDate", "Description", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2024, 9, 14, 17, 11, 43, 515, DateTimeKind.Utc).AddTicks(5138), "Rerum quasi velit soluta quia voluptate officiis.", new DateTime(2024, 9, 14, 17, 11, 43, 515, DateTimeKind.Utc).AddTicks(5138) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 9,
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 14, 10, 14, 46, 463, DateTimeKind.Utc).AddTicks(5708), "Phòng Kế toán", "Animi temporibus aut distinctio libero culpa dolorum quibusdam non est.", new DateTime(2024, 9, 14, 10, 14, 46, 463, DateTimeKind.Utc).AddTicks(5708) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 10,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2024, 9, 20, 3, 22, 53, 926, DateTimeKind.Utc).AddTicks(4812), "Phòng Nhân sự", "Et libero ab eligendi.", new DateTime(2024, 9, 20, 3, 22, 53, 926, DateTimeKind.Utc).AddTicks(4812) });

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
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 25, 6, 49, 7, 520, DateTimeKind.Utc).AddTicks(7697), "Sleek Frozen Pizza", true });

            migrationBuilder.InsertData(
                table: "QRCards",
                columns: new[] { "QRCardId", "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId", "QRCardTypeId" },
                values: new object[,]
                {
                    { 1, new Guid("69bf92f4-5556-45e4-abb2-dfdd9ba51946"), new DateTime(2024, 9, 27, 13, 49, 7, 564, DateTimeKind.Local).AddTicks(5107), new DateTime(2024, 9, 27, 13, 49, 7, 564, DateTimeKind.Local).AddTicks(5188), 1, 2 },
                    { 2, new Guid("3fad4ee3-59fb-41ff-8b96-bbaf6765109a"), new DateTime(2024, 9, 27, 13, 49, 7, 564, DateTimeKind.Local).AddTicks(5334), new DateTime(2024, 9, 27, 13, 49, 7, 564, DateTimeKind.Local).AddTicks(5336), 1, 1 },
                    { 3, new Guid("b9c0d83b-d2bc-4a87-bcf4-ef1bd0ddacf7"), new DateTime(2024, 9, 27, 13, 49, 7, 564, DateTimeKind.Local).AddTicks(5347), new DateTime(2024, 9, 27, 13, 49, 7, 564, DateTimeKind.Local).AddTicks(5348), 2, 2 },
                    { 4, new Guid("bb98d75e-46af-4588-b61e-3403005ea6c5"), new DateTime(2024, 9, 27, 13, 49, 7, 564, DateTimeKind.Local).AddTicks(5355), new DateTime(2024, 9, 27, 13, 49, 7, 564, DateTimeKind.Local).AddTicks(5356), 2, 2 },
                    { 5, new Guid("d709b3c6-0c2d-421e-9437-75cb8ee70969"), new DateTime(2024, 9, 27, 13, 49, 7, 564, DateTimeKind.Local).AddTicks(5362), new DateTime(2024, 9, 27, 13, 49, 7, 564, DateTimeKind.Local).AddTicks(5363), 2, 2 },
                    { 6, new Guid("4f159c40-9b58-4bc4-8cf6-29c305850b5c"), new DateTime(2024, 9, 27, 13, 49, 7, 564, DateTimeKind.Local).AddTicks(5379), new DateTime(2024, 9, 27, 13, 49, 7, 564, DateTimeKind.Local).AddTicks(5380), 1, 1 },
                    { 7, new Guid("3fd68ccb-0704-40e2-b660-9f4ea7b2d204"), new DateTime(2024, 9, 27, 13, 49, 7, 564, DateTimeKind.Local).AddTicks(5387), new DateTime(2024, 9, 27, 13, 49, 7, 564, DateTimeKind.Local).AddTicks(5388), 2, 1 },
                    { 8, new Guid("13dbe9a0-5699-4001-bf4a-e9098318a236"), new DateTime(2024, 9, 27, 13, 49, 7, 564, DateTimeKind.Local).AddTicks(5394), new DateTime(2024, 9, 27, 13, 49, 7, 564, DateTimeKind.Local).AddTicks(5395), 1, 2 },
                    { 9, new Guid("9adca385-5874-44a6-b7d7-bf2930b12186"), new DateTime(2024, 9, 27, 13, 49, 7, 564, DateTimeKind.Local).AddTicks(5401), new DateTime(2024, 9, 27, 13, 49, 7, 564, DateTimeKind.Local).AddTicks(5402), 1, 2 },
                    { 10, new Guid("15d9beb7-5c6d-4c5b-a246-0fb7ea53349c"), new DateTime(2024, 9, 27, 13, 49, 7, 564, DateTimeKind.Local).AddTicks(5408), new DateTime(2024, 9, 27, 13, 49, 7, 564, DateTimeKind.Local).AddTicks(5409), 2, 2 }
                });

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
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 4, 18 });

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
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 4, 23 });

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
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 2, 18 });

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
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 2, 9 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 21,
                column: "DepartmentId",
                value: 3);

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 12, 3, 43, 3, 371, DateTimeKind.Unspecified).AddTicks(8485), "gmail.com_Vandervort49@gmail.com", "Candido Jenkins", "yoj2uu", "0812427428", new DateTime(2024, 9, 12, 3, 43, 3, 371, DateTimeKind.Unspecified).AddTicks(8485), "Tyshawn_Feeney" });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 17, 20, 54, 3, 303, DateTimeKind.Unspecified).AddTicks(8607), "gmail.com.Lebsack@gmail.com", "Annetta Hirthe", "asjwtu", "0452974350", new DateTime(2024, 9, 17, 20, 54, 3, 303, DateTimeKind.Unspecified).AddTicks(8607), "Sterling_Stokes17" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 3, 6, 8, 20, 838, DateTimeKind.Unspecified).AddTicks(5073), "gmail.com_Jakubowski45@hotmail.com", "Bernardo Botsford", "db0c67", "0529216305", new DateTime(2024, 9, 3, 6, 8, 20, 838, DateTimeKind.Unspecified).AddTicks(5073), "Luna.Vandervort51" });

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
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Quos ipsum corporis non aut dolorem aut. Voluptas autem dolor nesciunt provident quod. Tempore accusantium labore rerum adipisci eos excepturi iusto. Iusto autem voluptatem quis modi impedit architecto. Exercitationem minus dolor non voluptas aut velit. Et optio aliquid deleniti quam.", new DateTime(2024, 10, 26, 13, 49, 7, 526, DateTimeKind.Local).AddTicks(9810), new DateTime(2024, 9, 26, 13, 49, 7, 526, DateTimeKind.Local).AddTicks(9808), 1 });

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
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Totam sunt enim sed delectus excepturi qui nostrum quis rerum. Ullam quia cupiditate velit veritatis dolorem ut et rerum. Repellat qui aut. Tempore quia expedita consequatur accusantium. Ipsam corporis veritatis eaque quia dolorem omnis voluptatem similique cumque. Necessitatibus assumenda deserunt quia aut temporibus.", new DateTime(2024, 9, 28, 13, 49, 7, 542, DateTimeKind.Local).AddTicks(9189), new DateTime(2024, 9, 27, 13, 49, 7, 542, DateTimeKind.Local).AddTicks(9138), 10 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 14,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Aut fuga perferendis. Natus qui odit eum unde est dolor debitis corporis rerum. Est eveniet velit illum eos qui et esse voluptas.", new DateTime(2024, 9, 28, 13, 49, 7, 542, DateTimeKind.Local).AddTicks(9606), new DateTime(2024, 9, 27, 13, 49, 7, 542, DateTimeKind.Local).AddTicks(9601) });

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
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Atque sequi numquam ut accusantium et explicabo. Tenetur enim alias eius sed est aliquam atque atque. Commodi eveniet dolore odit voluptatibus dolorem quia sapiente. Quis earum nemo eos.", new DateTime(2024, 9, 28, 13, 49, 7, 549, DateTimeKind.Local).AddTicks(3310), new DateTime(2024, 9, 27, 13, 49, 7, 549, DateTimeKind.Local).AddTicks(3254), 5 });

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
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Dolor assumenda culpa quae voluptatum adipisci esse. Qui ad molestias. Minima maiores facilis odio.", new DateTime(2024, 9, 28, 13, 49, 7, 557, DateTimeKind.Local).AddTicks(698), new DateTime(2024, 9, 27, 13, 49, 7, 557, DateTimeKind.Local).AddTicks(693), 8 });

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
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Farrell - Stehr", new DateTime(2024, 9, 8, 0, 16, 3, 203, DateTimeKind.Unspecified).AddTicks(553), 2, "yk6hnp8uzo", "0517845108", new DateTime(2024, 9, 8, 0, 16, 3, 203, DateTimeKind.Unspecified).AddTicks(553), "Susan Crona" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 2,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Quigley, Frami and Hickle", new DateTime(2024, 9, 20, 7, 45, 29, 516, DateTimeKind.Unspecified).AddTicks(9502), 1, "lg6enhaefw", "0377966062", false, new DateTime(2024, 9, 20, 7, 45, 29, 516, DateTimeKind.Unspecified).AddTicks(9502), "Norma Zulauf" });

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
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Mitchell Group", new DateTime(2024, 9, 19, 17, 48, 57, 571, DateTimeKind.Unspecified).AddTicks(6099), "vw8z725bh2", "0128439770", new DateTime(2024, 9, 19, 17, 48, 57, 571, DateTimeKind.Unspecified).AddTicks(6099), "Jakob Effertz" });

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
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Smith Group", new DateTime(2024, 9, 26, 8, 34, 9, 427, DateTimeKind.Unspecified).AddTicks(1385), "1128cddt1f", "0594718893", new DateTime(2024, 9, 26, 8, 34, 9, 427, DateTimeKind.Unspecified).AddTicks(1385), "Shanel Cummings" });

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
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Hansen - O'Hara", new DateTime(2024, 9, 24, 19, 49, 36, 247, DateTimeKind.Unspecified).AddTicks(887), "vjg2vnu9h3", "0222503419", true, new DateTime(2024, 9, 24, 19, 49, 36, 247, DateTimeKind.Unspecified).AddTicks(887), "Dayne Kuvalis" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 9,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Christiansen - Schmitt", new DateTime(2024, 9, 1, 2, 19, 14, 317, DateTimeKind.Unspecified).AddTicks(9147), "ana5fqqaum", "0490798974", true, new DateTime(2024, 9, 1, 2, 19, 14, 317, DateTimeKind.Unspecified).AddTicks(9147), "Kacey Mitchell" });

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
    }
}
