using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SecurityGateApv.Infras.Migrations
{
    /// <inheritdoc />
    public partial class SeedData_5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2024, 9, 17, 12, 7, 16, 43, DateTimeKind.Utc).AddTicks(95), "Phòng R&D", "Odit exercitationem modi.", new DateTime(2024, 9, 17, 12, 7, 16, 43, DateTimeKind.Utc).AddTicks(95) },
                    { 2, 5, new DateTime(2024, 9, 15, 11, 38, 28, 976, DateTimeKind.Utc).AddTicks(2860), "Phòng Nhân sự", "Beatae placeat ad rerum.", new DateTime(2024, 9, 15, 11, 38, 28, 976, DateTimeKind.Utc).AddTicks(2860) },
                    { 3, 4, new DateTime(2024, 9, 16, 6, 28, 25, 980, DateTimeKind.Utc).AddTicks(4053), "Phòng Kinh doanh", "Corporis vel esse maxime aut corporis ipsa.", new DateTime(2024, 9, 16, 6, 28, 25, 980, DateTimeKind.Utc).AddTicks(4053) },
                    { 4, 1, new DateTime(2024, 9, 13, 18, 29, 6, 172, DateTimeKind.Utc).AddTicks(4322), "Phòng IT", "Consequatur nobis deserunt facere ipsam doloremque.", new DateTime(2024, 9, 13, 18, 29, 6, 172, DateTimeKind.Utc).AddTicks(4322) },
                    { 5, 1, new DateTime(2024, 9, 6, 15, 42, 6, 164, DateTimeKind.Utc).AddTicks(3548), "Phòng Pháp chế", "Enim aliquid aliquam rerum dolorum officia nam.", new DateTime(2024, 9, 6, 15, 42, 6, 164, DateTimeKind.Utc).AddTicks(3548) },
                    { 6, 3, new DateTime(2024, 9, 13, 12, 17, 32, 109, DateTimeKind.Utc).AddTicks(3651), "Phòng R&D", "Deleniti consequatur quis laboriosam consequatur velit unde voluptatibus fugit sit.", new DateTime(2024, 9, 13, 12, 17, 32, 109, DateTimeKind.Utc).AddTicks(3651) },
                    { 7, 1, new DateTime(2024, 9, 17, 3, 51, 55, 823, DateTimeKind.Utc).AddTicks(7939), "Phòng Kinh doanh", "Dolore qui molestias aut quia in dolor reprehenderit modi quo.", new DateTime(2024, 9, 17, 3, 51, 55, 823, DateTimeKind.Utc).AddTicks(7939) },
                    { 8, 1, new DateTime(2024, 9, 9, 23, 30, 32, 124, DateTimeKind.Utc).AddTicks(7706), "Phòng Marketing", "Est nihil dolor ut.", new DateTime(2024, 9, 9, 23, 30, 32, 124, DateTimeKind.Utc).AddTicks(7706) },
                    { 9, 5, new DateTime(2024, 9, 15, 20, 14, 19, 452, DateTimeKind.Utc).AddTicks(3293), "Phòng Kinh doanh", "Rerum qui necessitatibus non animi eum alias expedita possimus.", new DateTime(2024, 9, 15, 20, 14, 19, 452, DateTimeKind.Utc).AddTicks(3293) },
                    { 10, 1, new DateTime(2024, 9, 6, 19, 40, 25, 355, DateTimeKind.Utc).AddTicks(7977), "Phòng R&D", "Voluptatibus ea sed.", new DateTime(2024, 9, 6, 19, 40, 25, 355, DateTimeKind.Utc).AddTicks(7977) }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PhoneNumber", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 19, 5, 44, 44, 687, DateTimeKind.Utc).AddTicks(6616), "0123456789", new DateTime(2024, 9, 19, 5, 44, 44, 687, DateTimeKind.Utc).AddTicks(6625) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 19, 5, 44, 44, 687, DateTimeKind.Utc).AddTicks(6628), new DateTime(2024, 9, 19, 5, 44, 44, 687, DateTimeKind.Utc).AddTicks(6629) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PhoneNumber", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 19, 5, 44, 44, 687, DateTimeKind.Utc).AddTicks(6631), "0112223334", new DateTime(2024, 9, 19, 5, 44, 44, 687, DateTimeKind.Utc).AddTicks(6631) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PhoneNumber", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 19, 5, 44, 44, 687, DateTimeKind.Utc).AddTicks(6633), "0223334445", new DateTime(2024, 9, 19, 5, 44, 44, 687, DateTimeKind.Utc).AddTicks(6634) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "PhoneNumber", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 19, 5, 44, 44, 687, DateTimeKind.Utc).AddTicks(6635), "0334445556", new DateTime(2024, 9, 19, 5, 44, 44, 687, DateTimeKind.Utc).AddTicks(6636) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 18, 7, 59, 27, 837, DateTimeKind.Unspecified).AddTicks(3614), "gmail.com_Yundt@gmail.com", "Hiram Hills", "8ln1gq", "0812457874", 4, new DateTime(2024, 9, 18, 7, 59, 27, 837, DateTimeKind.Unspecified).AddTicks(3614), "Ola68" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 16, 18, 36, 1, 470, DateTimeKind.Unspecified).AddTicks(350), "gmail.com47@yahoo.com", "Hillard Gislason", "4w6i8a", "0711023925", 1, new DateTime(2024, 9, 16, 18, 36, 1, 470, DateTimeKind.Unspecified).AddTicks(350), "Amina.Schimmel42" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 13, 3, 10, 35, 672, DateTimeKind.Unspecified).AddTicks(8882), "gmail.com.Witting71@yahoo.com", "Lane Medhurst", "b6xeia", "0611387735", new DateTime(2024, 9, 13, 3, 10, 35, 672, DateTimeKind.Unspecified).AddTicks(8882), "Cade.Jaskolski" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 7, 9, 54, 38, 820, DateTimeKind.Unspecified).AddTicks(8297), "gmail.com15@yahoo.com", "Shyann Bogan", "etwvid", "0441380177", 3, new DateTime(2024, 9, 7, 9, 54, 38, 820, DateTimeKind.Unspecified).AddTicks(8297), "Maymie21" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 7, 19, 19, 38, 767, DateTimeKind.Unspecified).AddTicks(3954), "gmail.com.Hessel@gmail.com", "Sallie Renner", "h4n80r", "0628038762", 2, new DateTime(2024, 9, 7, 19, 19, 38, 767, DateTimeKind.Unspecified).AddTicks(3954), "Anya.Raynor96" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 4, 2, 19, 42, 510, DateTimeKind.Unspecified).AddTicks(5539), "gmail.com_Kuhlman13@yahoo.com", "Mortimer Hegmann", "13csr9", "0738136556", 3, new DateTime(2024, 9, 4, 2, 19, 42, 510, DateTimeKind.Unspecified).AddTicks(5539), "Monserrat47" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 5, 22, 17, 41, 98, DateTimeKind.Unspecified).AddTicks(7754), "gmail.com3@yahoo.com", "Judge Sanford", "feoche", "0806199895", new DateTime(2024, 9, 5, 22, 17, 41, 98, DateTimeKind.Unspecified).AddTicks(7754), "Emie55" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 1, 9, 12, 42, 349, DateTimeKind.Unspecified).AddTicks(9587), "gmail.com_Doyle20@hotmail.com", "Giovanny Mann", "pjsq7m", "0417631054", 3, new DateTime(2024, 9, 1, 9, 12, 42, 349, DateTimeKind.Unspecified).AddTicks(9587), "Delia77" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 8, 5, 34, 7, 673, DateTimeKind.Unspecified).AddTicks(2087), "gmail.com.Yost8@hotmail.com", "Susan Pagac", "emiea9", "0584261421", new DateTime(2024, 9, 8, 5, 34, 7, 673, DateTimeKind.Unspecified).AddTicks(2087), "Retta.Mueller63" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 8, 14, 35, 8, 71, DateTimeKind.Unspecified).AddTicks(8053), "gmail.com.Harvey@hotmail.com", "Destany Morissette", "5g0cfy", "0232107243", 5, new DateTime(2024, 9, 8, 14, 35, 8, 71, DateTimeKind.Unspecified).AddTicks(8053), "Danika31" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 18, 13, 0, 10, 403, DateTimeKind.Unspecified).AddTicks(9964), "gmail.com_Ziemann73@yahoo.com", "Elna Feeney", "1jiluq", "0902498687", 4, new DateTime(2024, 9, 18, 13, 0, 10, 403, DateTimeKind.Unspecified).AddTicks(9964), "Rickie22" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 3, 15, 43, 56, 360, DateTimeKind.Unspecified).AddTicks(7902), "gmail.com.Russel65@yahoo.com", "Giles Thompson", "8q4vpq", "0870088468", 2, new DateTime(2024, 9, 3, 15, 43, 56, 360, DateTimeKind.Unspecified).AddTicks(7902), "Gretchen23" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 4, 15, 4, 50, 812, DateTimeKind.Unspecified).AddTicks(5842), "gmail.com.Lynch90@yahoo.com", "Adalberto O'Connell", "0v8vkg", "0954096500", 2, new DateTime(2024, 9, 4, 15, 4, 50, 812, DateTimeKind.Unspecified).AddTicks(5842), "Ransom_Hand18" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 2, 21, 31, 46, 194, DateTimeKind.Unspecified).AddTicks(3382), "gmail.com_Borer@gmail.com", "Richmond Emard", "tyb5i6", "0635897609", 2, new DateTime(2024, 9, 2, 21, 31, 46, 194, DateTimeKind.Unspecified).AddTicks(3382), "Keeley.Padberg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 14, 16, 13, 13, 270, DateTimeKind.Unspecified).AddTicks(9090), "gmail.com_Wiegand69@yahoo.com", "Edward Heidenreich", "1ylyfa", "0946675173", 2, new DateTime(2024, 9, 14, 16, 13, 13, 270, DateTimeKind.Unspecified).AddTicks(9090), "Myrna_Buckridge12" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 5, 21, 26, 42, 3, DateTimeKind.Unspecified).AddTicks(2155), "gmail.com_Hilpert53@yahoo.com", "Sydnee Ritchie", "lvc2d4", "0263822269", 3, new DateTime(2024, 9, 5, 21, 26, 42, 3, DateTimeKind.Unspecified).AddTicks(2155), "Reilly.Bogisich" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 5, 18, 48, 57, 996, DateTimeKind.Unspecified).AddTicks(5641), "gmail.com.Kuphal41@hotmail.com", "Flavio Kohler", "a46deh", "0211300844", 3, new DateTime(2024, 9, 5, 18, 48, 57, 996, DateTimeKind.Unspecified).AddTicks(5641), "Terence.Schroeder17" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 5, 16, 57, 59, 261, DateTimeKind.Unspecified).AddTicks(7424), "gmail.com23@gmail.com", "Jack Marquardt", "tij9eq", "0422670828", 4, new DateTime(2024, 9, 5, 16, 57, 59, 261, DateTimeKind.Unspecified).AddTicks(7424), "Bradford_Shanahan" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 2, 21, 47, 28, 774, DateTimeKind.Unspecified).AddTicks(5150), "gmail.com53@gmail.com", "Norval Ernser", "e92y04", "0112113831", 3, new DateTime(2024, 9, 2, 21, 47, 28, 774, DateTimeKind.Unspecified).AddTicks(5150), "Howard9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 16, 13, 6, 12, 853, DateTimeKind.Unspecified).AddTicks(8809), "gmail.com.Stiedemann@hotmail.com", "Trinity Pouros", "4xg4mf", "0514013396", 2, new DateTime(2024, 9, 16, 13, 6, 12, 853, DateTimeKind.Unspecified).AddTicks(8809), "Braden_Ankunding" });

            migrationBuilder.InsertData(
                table: "UserDepartments",
                columns: new[] { "UserDepartmentId", "DepartmentId", "UserId" },
                values: new object[,]
                {
                    { 1, 6, 25 },
                    { 2, 2, 22 },
                    { 3, 5, 24 },
                    { 4, 10, 8 },
                    { 5, 5, 17 },
                    { 6, 3, 8 },
                    { 7, 7, 23 },
                    { 8, 10, 16 },
                    { 9, 6, 24 },
                    { 10, 1, 9 },
                    { 11, 5, 4 },
                    { 12, 9, 3 },
                    { 13, 6, 3 },
                    { 14, 1, 8 },
                    { 15, 7, 12 },
                    { 16, 2, 22 },
                    { 17, 7, 21 },
                    { 18, 9, 17 },
                    { 19, 7, 6 },
                    { 20, 9, 10 },
                    { 21, 4, 12 },
                    { 22, 2, 10 },
                    { 23, 7, 4 },
                    { 24, 4, 2 },
                    { 25, 7, 7 },
                    { 26, 2, 8 },
                    { 27, 4, 23 },
                    { 28, 8, 25 },
                    { 29, 10, 10 },
                    { 30, 10, 8 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PhoneNumber", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 19, 5, 41, 49, 358, DateTimeKind.Utc).AddTicks(2903), "1234567890", new DateTime(2024, 9, 19, 5, 41, 49, 358, DateTimeKind.Utc).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 19, 5, 41, 49, 358, DateTimeKind.Utc).AddTicks(2914), new DateTime(2024, 9, 19, 5, 41, 49, 358, DateTimeKind.Utc).AddTicks(2914) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PhoneNumber", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 19, 5, 41, 49, 358, DateTimeKind.Utc).AddTicks(2916), "1112223334", new DateTime(2024, 9, 19, 5, 41, 49, 358, DateTimeKind.Utc).AddTicks(2917) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PhoneNumber", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 19, 5, 41, 49, 358, DateTimeKind.Utc).AddTicks(2918), "2223334445", new DateTime(2024, 9, 19, 5, 41, 49, 358, DateTimeKind.Utc).AddTicks(2919) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "PhoneNumber", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 19, 5, 41, 49, 358, DateTimeKind.Utc).AddTicks(2920), "3334445556", new DateTime(2024, 9, 19, 5, 41, 49, 358, DateTimeKind.Utc).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 11, 8, 33, 28, 761, DateTimeKind.Unspecified).AddTicks(2366), "gmail.com.Jacobson@yahoo.com", "Nathan Schneider", "820o3y", "0641048822", 2, new DateTime(2024, 9, 11, 8, 33, 28, 761, DateTimeKind.Unspecified).AddTicks(2366), "Graham58" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 1, 11, 54, 47, 447, DateTimeKind.Unspecified).AddTicks(4543), "gmail.com.Armstrong90@gmail.com", "Devin Goldner", "4thop7", "0105768905", 5, new DateTime(2024, 9, 1, 11, 54, 47, 447, DateTimeKind.Unspecified).AddTicks(4543), "Jabari.McCullough" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 1, 15, 8, 47, 370, DateTimeKind.Unspecified).AddTicks(908), "gmail.com.Waelchi60@yahoo.com", "Hazel Champlin", "4ge0fp", "0321059430", new DateTime(2024, 9, 1, 15, 8, 47, 370, DateTimeKind.Unspecified).AddTicks(908), "Alexandrea8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 5, 1, 8, 54, 890, DateTimeKind.Unspecified).AddTicks(3917), "gmail.com27@hotmail.com", "Fredy Jacobi", "rr6gfk", "0285630611", 5, new DateTime(2024, 9, 5, 1, 8, 54, 890, DateTimeKind.Unspecified).AddTicks(3917), "Lambert97" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 13, 22, 11, 33, 922, DateTimeKind.Unspecified).AddTicks(7152), "gmail.com_Quitzon@hotmail.com", "Clement Cremin", "ig6xlw", "0796612345", 3, new DateTime(2024, 9, 13, 22, 11, 33, 922, DateTimeKind.Unspecified).AddTicks(7152), "Moises_Rempel98" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 1, 22, 34, 26, 626, DateTimeKind.Unspecified).AddTicks(6526), "gmail.com81@hotmail.com", "Willow O'Conner", "vvlwss", "0114077762", 2, new DateTime(2024, 9, 1, 22, 34, 26, 626, DateTimeKind.Unspecified).AddTicks(6526), "Jacques_Herzog5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 16, 11, 59, 59, 392, DateTimeKind.Unspecified).AddTicks(9509), "gmail.com38@hotmail.com", "Corbin Runte", "mkxn80", "0613814326", new DateTime(2024, 9, 16, 11, 59, 59, 392, DateTimeKind.Unspecified).AddTicks(9509), "Kaela.Kub94" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 9, 2, 9, 39, 308, DateTimeKind.Unspecified).AddTicks(9509), "gmail.com.Koepp@hotmail.com", "Brody Feeney", "kmyb89", "0935250012", 4, new DateTime(2024, 9, 9, 2, 9, 39, 308, DateTimeKind.Unspecified).AddTicks(9509), "Reba.Koch" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 1, 7, 52, 17, 307, DateTimeKind.Unspecified).AddTicks(1394), "gmail.com_Towne79@hotmail.com", "Durward Gerhold", "ac2hwo", "0363836515", new DateTime(2024, 9, 1, 7, 52, 17, 307, DateTimeKind.Unspecified).AddTicks(1394), "Lexi.Lakin5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 15, 18, 54, 52, 906, DateTimeKind.Unspecified).AddTicks(9036), "gmail.com_White82@yahoo.com", "Icie Thompson", "zg8l6y", "0673020572", 3, new DateTime(2024, 9, 15, 18, 54, 52, 906, DateTimeKind.Unspecified).AddTicks(9036), "Jonas_Kerluke18" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 4, 10, 43, 28, 961, DateTimeKind.Unspecified).AddTicks(3060), "gmail.com91@hotmail.com", "Gunner Gerlach", "ikv8kr", "0755882735", 5, new DateTime(2024, 9, 4, 10, 43, 28, 961, DateTimeKind.Unspecified).AddTicks(3060), "Mariam.Bernhard38" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 11, 3, 16, 24, 413, DateTimeKind.Unspecified).AddTicks(8864), "gmail.com65@gmail.com", "Avis Pagac", "lvfwm8", "0154048461", 4, new DateTime(2024, 9, 11, 3, 16, 24, 413, DateTimeKind.Unspecified).AddTicks(8864), "Lesley.Hand89" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 1, 0, 53, 31, 316, DateTimeKind.Unspecified).AddTicks(6245), "gmail.com_Streich@yahoo.com", "Jodie Heller", "rj20ca", "0337680250", 5, new DateTime(2024, 9, 1, 0, 53, 31, 316, DateTimeKind.Unspecified).AddTicks(6245), "Petra.Hane" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 3, 10, 31, 4, 751, DateTimeKind.Unspecified).AddTicks(6650), "gmail.com98@gmail.com", "Pansy Leuschke", "e1roor", "0454210865", 4, new DateTime(2024, 9, 3, 10, 31, 4, 751, DateTimeKind.Unspecified).AddTicks(6650), "Dan.Beatty" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 18, 12, 31, 31, 609, DateTimeKind.Unspecified).AddTicks(9969), "gmail.com_Reichert@hotmail.com", "Kole Walter", "blcmbk", "0929899524", 4, new DateTime(2024, 9, 18, 12, 31, 31, 609, DateTimeKind.Unspecified).AddTicks(9969), "Priscilla_Grady" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 8, 22, 58, 44, 666, DateTimeKind.Unspecified).AddTicks(9526), "gmail.com.Hane14@yahoo.com", "Pierce O'Connell", "q5wyps", "0333017731", 1, new DateTime(2024, 9, 8, 22, 58, 44, 666, DateTimeKind.Unspecified).AddTicks(9526), "Selina_Mueller73" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 2, 16, 41, 3, 571, DateTimeKind.Unspecified).AddTicks(7646), "gmail.com_Kassulke@gmail.com", "Damian Koelpin", "155ei1", "0418537702", 4, new DateTime(2024, 9, 2, 16, 41, 3, 571, DateTimeKind.Unspecified).AddTicks(7646), "Novella_Kohler79" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 13, 8, 50, 15, 386, DateTimeKind.Unspecified).AddTicks(3545), "gmail.com_Bernhard@gmail.com", "Bernie Lakin", "nku78b", "0732483340", 1, new DateTime(2024, 9, 13, 8, 50, 15, 386, DateTimeKind.Unspecified).AddTicks(3545), "Jackeline_Sporer57" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 5, 9, 47, 2, 984, DateTimeKind.Unspecified).AddTicks(3654), "gmail.com86@yahoo.com", "Tad Abshire", "4qdd0s", "0114944255", 2, new DateTime(2024, 9, 5, 9, 47, 2, 984, DateTimeKind.Unspecified).AddTicks(3654), "Zelma_Wintheiser20" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 9, 21, 31, 34, 906, DateTimeKind.Unspecified).AddTicks(8682), "gmail.com22@hotmail.com", "Maddison Ebert", "qkf9xh", "0472617027", 1, new DateTime(2024, 9, 9, 21, 31, 34, 906, DateTimeKind.Unspecified).AddTicks(8682), "Ernie_Murray" });
        }
    }
}
