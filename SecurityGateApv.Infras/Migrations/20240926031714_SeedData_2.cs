using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SecurityGateApv.Infras.Migrations
{
    /// <inheritdoc />
    public partial class SeedData_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Visits",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "VisitDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 1, 37, 3, 694, DateTimeKind.Utc).AddTicks(7483), "Phòng Kinh doanh", "Sit itaque laboriosam odio et.", new DateTime(2024, 9, 9, 1, 37, 3, 694, DateTimeKind.Utc).AddTicks(7483) });

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
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 20, 45, 49, 236, DateTimeKind.Utc).AddTicks(3413), "Phòng Pháp chế", "Nihil nam sit suscipit.", new DateTime(2024, 9, 15, 20, 45, 49, 236, DateTimeKind.Utc).AddTicks(3413) });

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
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 14, 1, 460, DateTimeKind.Utc).AddTicks(8567), "Phòng Nhân sự", "Quis facere ex et est veritatis accusamus.", new DateTime(2024, 9, 11, 21, 14, 1, 460, DateTimeKind.Utc).AddTicks(8567) });

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
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2024, 9, 20, 1, 7, 44, 959, DateTimeKind.Utc).AddTicks(4003), "Phòng R&D", "Pariatur quasi in tempore aut velit animi necessitatibus.", new DateTime(2024, 9, 20, 1, 7, 44, 959, DateTimeKind.Utc).AddTicks(4003) });

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
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 24, 3, 17, 14, 145, DateTimeKind.Utc).AddTicks(6771), "Incredible Fresh Bacon", true });

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
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 24, 3, 17, 14, 145, DateTimeKind.Utc).AddTicks(6835), "Practical Rubber Table", false });

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
                column: "DepartmentId",
                value: 2);

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 19, 10, 7, 6, 103, DateTimeKind.Unspecified).AddTicks(7610), "gmail.com.Robel@yahoo.com", "Leon Jones", "kk6vsa", "0884744236", 2, new DateTime(2024, 9, 19, 10, 7, 6, 103, DateTimeKind.Unspecified).AddTicks(7610), "Patience.Kassulke" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 1, 11, 29, 29, 663, DateTimeKind.Unspecified).AddTicks(2909), "gmail.com61@yahoo.com", "Carley Stark", "vojr8c", "0669391328", new DateTime(2024, 9, 1, 11, 29, 29, 663, DateTimeKind.Unspecified).AddTicks(2909), "Lucinda63" });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 16, 12, 20, 32, 487, DateTimeKind.Unspecified).AddTicks(9702), "gmail.com_Lesch@yahoo.com", "Amelie Stoltenberg", "pdplxd", "0975028154", 2, new DateTime(2024, 9, 16, 12, 20, 32, 487, DateTimeKind.Unspecified).AddTicks(9702), "Stella_Metz" });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 9, 20, 44, 36, 827, DateTimeKind.Unspecified).AddTicks(354), "gmail.com.Shields51@yahoo.com", "Rodger Moen", "6p4386", "0955635866", new DateTime(2024, 9, 9, 20, 44, 36, 827, DateTimeKind.Unspecified).AddTicks(354), "Franco_Braun" });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 11, 23, 19, 46, 723, DateTimeKind.Unspecified).AddTicks(6547), "gmail.com40@hotmail.com", "Lucile Abernathy", "puq8s1", "0906409321", 4, new DateTime(2024, 9, 11, 23, 19, 46, 723, DateTimeKind.Unspecified).AddTicks(6547), "Mable.Mann" });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 21, 23, 48, 48, 713, DateTimeKind.Unspecified).AddTicks(5109), "gmail.com2@gmail.com", "Laura Veum", "alek7n", "0337355594", 1, new DateTime(2024, 9, 21, 23, 48, 48, 713, DateTimeKind.Unspecified).AddTicks(5109), "Nyah78" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 13, 13, 30, 53, 238, DateTimeKind.Unspecified).AddTicks(6523), "gmail.com41@hotmail.com", "Sandrine Watsica", "563bx3", "0724931273", 3, new DateTime(2024, 9, 13, 13, 30, 53, 238, DateTimeKind.Unspecified).AddTicks(6523), "Ashly79" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 12, 11, 58, 54, 134, DateTimeKind.Unspecified).AddTicks(679), "gmail.com.Hansen@yahoo.com", "Federico Beahan", "5eiulz", "0907208467", 3, new DateTime(2024, 9, 12, 11, 58, 54, 134, DateTimeKind.Unspecified).AddTicks(679), "Ariel.Beer57" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 1,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Mayert, Sawayn and Daugherty", new DateTime(2024, 9, 6, 7, 24, 37, 402, DateTimeKind.Unspecified).AddTicks(7509), 1, "9be925v2ev", "0344032499", new DateTime(2024, 9, 6, 7, 24, 37, 402, DateTimeKind.Unspecified).AddTicks(7509), "Cristal Shields" });

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
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Kiehn, Jast and Braun", new DateTime(2024, 9, 18, 10, 15, 31, 878, DateTimeKind.Unspecified).AddTicks(4178), 2, "auhoxfjqhw", "0722837084", true, new DateTime(2024, 9, 18, 10, 15, 31, 878, DateTimeKind.Unspecified).AddTicks(4178), "Matt Dickinson" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 4,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Kemmer, Boehm and Robel", new DateTime(2024, 9, 3, 12, 52, 23, 322, DateTimeKind.Unspecified).AddTicks(1797), "s43o02vs02", "0297155591", new DateTime(2024, 9, 3, 12, 52, 23, 322, DateTimeKind.Unspecified).AddTicks(1797), "Gerardo Christiansen" });

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
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Wunsch LLC", new DateTime(2024, 9, 15, 3, 3, 25, 967, DateTimeKind.Unspecified).AddTicks(1043), 2, "tzmeq5ig11", "0227161465", new DateTime(2024, 9, 15, 3, 3, 25, 967, DateTimeKind.Unspecified).AddTicks(1043), "Betsy Littel" });

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
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Spinka, Heidenreich and Homenick", new DateTime(2024, 9, 24, 14, 46, 34, 229, DateTimeKind.Unspecified).AddTicks(4399), "d0jtijjoze", "0531695082", true, new DateTime(2024, 9, 24, 14, 46, 34, 229, DateTimeKind.Unspecified).AddTicks(4399), "Winston Crist" });

            migrationBuilder.InsertData(
                table: "Visits",
                columns: new[] { "VisitId", "AcceptLevel", "CreateById", "DateRegister", "Description", "UpdateById", "VisitName", "VisitQuantity", "VisitType" },
                values: new object[] { 1, 1, 3, new DateTime(2024, 9, 24, 10, 17, 14, 147, DateTimeKind.Local).AddTicks(3183), null, 4, "Dọn vệ sinh", 2, "ProcessWeek" });

            migrationBuilder.InsertData(
                table: "VisitDetails",
                columns: new[] { "VisitDetailId", "Description", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "Status", "VisitId", "VisitorId" },
                values: new object[,]
                {
                    { 1, "Odio autem molestias et magni neque. Reiciendis expedita eaque accusantium beatae omnis recusandae consequuntur quas. Nobis fuga in. Tempore maiores ab aut voluptatem doloribus aut debitis. Vel laudantium eos quas cumque dolorum hic exercitationem id nisi. Incidunt omnis magni.", new DateTime(2024, 10, 25, 10, 17, 14, 158, DateTimeKind.Local).AddTicks(5818), new TimeSpan(0, 12, 0, 0, 0), new DateTime(2024, 9, 25, 10, 17, 14, 158, DateTimeKind.Local).AddTicks(5758), new TimeSpan(0, 7, 0, 0, 0), true, 1, 1 },
                    { 2, "Vel dolorem sint aut amet aut aut enim possimus. Est non qui laborum ducimus a aut facere est. Est est molestias. Qui ipsum officiis cumque ipsum modi accusamus sint eligendi. Sed cupiditate culpa voluptas. Sunt a veritatis natus doloribus quam est harum.", new DateTime(2024, 10, 25, 10, 17, 14, 158, DateTimeKind.Local).AddTicks(8788), new TimeSpan(0, 12, 0, 0, 0), new DateTime(2024, 9, 25, 10, 17, 14, 158, DateTimeKind.Local).AddTicks(8781), new TimeSpan(0, 7, 0, 0, 0), true, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "VisitProjects",
                columns: new[] { "VisitProcessId", "DaysOfProcess", "ExpectedEndDate", "ExpectedEndTime", "ExpectedStartDate", "ExpectedStartTime", "ProcessId", "Status", "VisitId", "VisitQuantity" },
                values: new object[] { 1, "Monday", new DateTime(2024, 10, 25, 10, 17, 14, 148, DateTimeKind.Local).AddTicks(9293), new TimeSpan(0, 12, 0, 0, 0), new DateTime(2024, 9, 25, 10, 17, 14, 148, DateTimeKind.Local).AddTicks(9174), new TimeSpan(0, 7, 0, 0, 0), 1, "Processing", 1, 2 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VisitProjects",
                keyColumn: "VisitProcessId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Visits",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "VisitDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 21, 10, 25, 19, DateTimeKind.Utc).AddTicks(2219), "Phòng R&D", "Placeat repellendus odio quam omnis tenetur cupiditate cum exercitationem.", new DateTime(2024, 9, 10, 21, 10, 25, 19, DateTimeKind.Utc).AddTicks(2219) });

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
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 2, 13, 8, 15, DateTimeKind.Utc).AddTicks(3930), "Phòng IT", "Ducimus est ipsa sequi omnis.", new DateTime(2024, 9, 15, 2, 13, 8, 15, DateTimeKind.Utc).AddTicks(3930) });

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
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 25, 1, 41, 46, 144, DateTimeKind.Utc).AddTicks(2667), "Phòng Sản xuất", "Et enim mollitia accusamus vel ut velit ut alias esse.", new DateTime(2024, 9, 25, 1, 41, 46, 144, DateTimeKind.Utc).AddTicks(2667) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 6,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2024, 9, 23, 13, 55, 28, 871, DateTimeKind.Utc).AddTicks(1981), "Phòng Chăm sóc khách hàng", "Et maxime illum sed sequi eaque maiores.", new DateTime(2024, 9, 23, 13, 55, 28, 871, DateTimeKind.Utc).AddTicks(1981) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 7,
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 20, 10, 39, 59, 457, DateTimeKind.Utc).AddTicks(8617), "Phòng Pháp chế", "Nulla voluptatum consequatur quo nostrum maiores.", new DateTime(2024, 9, 20, 10, 39, 59, 457, DateTimeKind.Utc).AddTicks(8617) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 8,
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 11, 14, 39, 54, 527, DateTimeKind.Utc).AddTicks(2139), "Phòng Marketing", "Dolores nemo officia placeat ut ipsa.", new DateTime(2024, 9, 11, 14, 39, 54, 527, DateTimeKind.Utc).AddTicks(2139) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 9,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 4, new DateTime(2024, 9, 24, 8, 55, 7, 86, DateTimeKind.Utc).AddTicks(1707), "Phòng Marketing", "Aspernatur et quas voluptatibus ut praesentium voluptatibus eos enim modi.", new DateTime(2024, 9, 24, 8, 55, 7, 86, DateTimeKind.Utc).AddTicks(1707) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 10,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 4, new DateTime(2024, 9, 20, 20, 33, 26, 595, DateTimeKind.Utc).AddTicks(7604), "Phòng Nhân sự", "Debitis aut et.", new DateTime(2024, 9, 20, 20, 33, 26, 595, DateTimeKind.Utc).AddTicks(7604) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProcessId",
                keyValue: 1,
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 25, 16, 37, 8, 630, DateTimeKind.Utc).AddTicks(2253), "Awesome Cotton Gloves", false });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProcessId",
                keyValue: 2,
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 25, 16, 37, 8, 630, DateTimeKind.Utc).AddTicks(3869), "Handcrafted Concrete Hat", false });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProcessId",
                keyValue: 3,
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 25, 16, 37, 8, 630, DateTimeKind.Utc).AddTicks(3906), "Intelligent Cotton Computer", false });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProcessId",
                keyValue: 4,
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 25, 16, 37, 8, 630, DateTimeKind.Utc).AddTicks(3926), "Ergonomic Soft Pants", false });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProcessId",
                keyValue: 5,
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 25, 16, 37, 8, 630, DateTimeKind.Utc).AddTicks(3945), "Gorgeous Cotton Fish", true });

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
                column: "DepartmentId",
                value: 3);

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 19, 3, 19, 43, 194, DateTimeKind.Unspecified).AddTicks(8507), "gmail.com39@gmail.com", "Jabari Ferry", "880sxv", "0901182356", new DateTime(2024, 9, 19, 3, 19, 43, 194, DateTimeKind.Unspecified).AddTicks(8507), "Caroline31" });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 13, 14, 34, 59, 254, DateTimeKind.Unspecified).AddTicks(6747), "gmail.com.Hartmann@hotmail.com", "Marcos Schoen", "hmvh67", "0763492957", 2, new DateTime(2024, 9, 13, 14, 34, 59, 254, DateTimeKind.Unspecified).AddTicks(6747), "Elza58" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 25, 5, 1, 12, 779, DateTimeKind.Unspecified).AddTicks(864), "gmail.com_Cartwright@yahoo.com", "Misty Graham", "jt6405", "0846014889", 3, new DateTime(2024, 9, 25, 5, 1, 12, 779, DateTimeKind.Unspecified).AddTicks(864), "Letitia26" });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 8, 12, 51, 17, 661, DateTimeKind.Unspecified).AddTicks(4496), "gmail.com_Littel@yahoo.com", "Hollie Murray", "sb4o1x", "0114739383", new DateTime(2024, 9, 8, 12, 51, 17, 661, DateTimeKind.Unspecified).AddTicks(4496), "Joany28" });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 23, 6, 26, 36, 722, DateTimeKind.Unspecified).AddTicks(1458), "gmail.com.Bogisich@hotmail.com", "Abigail Hahn", "c0m44y", "0290092921", 3, new DateTime(2024, 9, 23, 6, 26, 36, 722, DateTimeKind.Unspecified).AddTicks(1458), "Marisa.Okuneva" });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 16, 13, 25, 19, 69, DateTimeKind.Unspecified).AddTicks(4193), "gmail.com.Walsh@hotmail.com", "Miracle Morar", "hixlox", "0616986661", 2, new DateTime(2024, 9, 16, 13, 25, 19, 69, DateTimeKind.Unspecified).AddTicks(4193), "Kaleb.Veum62" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 1,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Kuhic, O'Kon and Schultz", new DateTime(2024, 9, 20, 1, 36, 43, 416, DateTimeKind.Unspecified).AddTicks(145), 2, "wrftyq1e7v", "0734464693", new DateTime(2024, 9, 20, 1, 36, 43, 416, DateTimeKind.Unspecified).AddTicks(145), "Candice Bogisich" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 2,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Mills, Watsica and Stark", new DateTime(2024, 9, 2, 22, 16, 28, 397, DateTimeKind.Unspecified).AddTicks(4860), "2vdvsi4a22", "0636809047", true, new DateTime(2024, 9, 2, 22, 16, 28, 397, DateTimeKind.Unspecified).AddTicks(4860), "Mabel Kihn" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 3,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Marks, Gleichner and Renner", new DateTime(2024, 9, 20, 12, 33, 29, 576, DateTimeKind.Unspecified).AddTicks(6083), 1, "v8o9wfbue4", "0157460540", false, new DateTime(2024, 9, 20, 12, 33, 29, 576, DateTimeKind.Unspecified).AddTicks(6083), "Stefan Balistreri" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 4,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Fisher - Stamm", new DateTime(2024, 9, 16, 2, 24, 6, 927, DateTimeKind.Unspecified).AddTicks(939), "fegww4fpf1", "0753370001", new DateTime(2024, 9, 16, 2, 24, 6, 927, DateTimeKind.Unspecified).AddTicks(939), "Milo Schulist" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 5,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Casper, Boyer and Lesch", new DateTime(2024, 9, 9, 4, 5, 58, 907, DateTimeKind.Unspecified).AddTicks(2287), 1, "00lqs54raa", "0329159872", false, new DateTime(2024, 9, 9, 4, 5, 58, 907, DateTimeKind.Unspecified).AddTicks(2287), "Robyn Parisian" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 6,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "O'Reilly, Heller and Graham", new DateTime(2024, 9, 16, 1, 18, 43, 564, DateTimeKind.Unspecified).AddTicks(698), 1, "72c986ayy0", "0795334114", new DateTime(2024, 9, 16, 1, 18, 43, 564, DateTimeKind.Unspecified).AddTicks(698), "Jacky Towne" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 7,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Blanda, Bode and Murphy", new DateTime(2024, 9, 4, 0, 59, 16, 176, DateTimeKind.Unspecified).AddTicks(9833), "tu7jupqtad", "0755667049", true, new DateTime(2024, 9, 4, 0, 59, 16, 176, DateTimeKind.Unspecified).AddTicks(9833), "Buster Abshire" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 8,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Labadie LLC", new DateTime(2024, 9, 4, 7, 38, 2, 627, DateTimeKind.Unspecified).AddTicks(1474), 1, "gew0niqkg5", "0307507461", new DateTime(2024, 9, 4, 7, 38, 2, 627, DateTimeKind.Unspecified).AddTicks(1474), "Jakayla Lind" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 9,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Hartmann, Ondricka and Kohler", new DateTime(2024, 9, 5, 18, 40, 42, 545, DateTimeKind.Unspecified).AddTicks(3586), 1, "yb7dx5vobn", "0832041776", new DateTime(2024, 9, 5, 18, 40, 42, 545, DateTimeKind.Unspecified).AddTicks(3586), "Rylan Rippin" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 10,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Hodkiewicz Group", new DateTime(2024, 9, 4, 12, 29, 22, 958, DateTimeKind.Unspecified).AddTicks(2517), "meboukxxgv", "0493509614", false, new DateTime(2024, 9, 4, 12, 29, 22, 958, DateTimeKind.Unspecified).AddTicks(2517), "Sally Mohr" });
        }
    }
}
