using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SecurityGateApv.Infras.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Visitors",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "CredentialCardTypes",
                columns: new[] { "CredentialCardTypeId", "CredentialCardTypeName" },
                values: new object[,]
                {
                    { 1, "Căn cước công dân" },
                    { 2, "Căn cước công dân" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 5, new DateTime(2024, 9, 5, 22, 4, 55, 667, DateTimeKind.Utc).AddTicks(3278), "Phòng Hành chính", "Amet consequuntur magnam iusto voluptates et repudiandae odio.", new DateTime(2024, 9, 5, 22, 4, 55, 667, DateTimeKind.Utc).AddTicks(3278) },
                    { 2, 5, new DateTime(2024, 9, 4, 18, 26, 28, 975, DateTimeKind.Utc).AddTicks(8559), "Phòng Hành chính", "Tempora ipsum mollitia sunt laborum itaque ipsam.", new DateTime(2024, 9, 4, 18, 26, 28, 975, DateTimeKind.Utc).AddTicks(8559) },
                    { 3, 5, new DateTime(2024, 9, 5, 1, 18, 51, 451, DateTimeKind.Utc).AddTicks(6536), "Phòng Kế toán", "Occaecati consequatur explicabo dolor est aut quas.", new DateTime(2024, 9, 5, 1, 18, 51, 451, DateTimeKind.Utc).AddTicks(6536) },
                    { 4, 1, new DateTime(2024, 9, 12, 5, 48, 12, 464, DateTimeKind.Utc).AddTicks(4551), "Phòng Chăm sóc khách hàng", "Et laudantium quia.", new DateTime(2024, 9, 12, 5, 48, 12, 464, DateTimeKind.Utc).AddTicks(4551) },
                    { 5, 1, new DateTime(2024, 9, 15, 5, 13, 11, 383, DateTimeKind.Utc).AddTicks(7617), "Phòng Sản xuất", "Illum est illum.", new DateTime(2024, 9, 15, 5, 13, 11, 383, DateTimeKind.Utc).AddTicks(7617) },
                    { 6, 2, new DateTime(2024, 9, 13, 21, 41, 38, 66, DateTimeKind.Utc).AddTicks(5081), "Phòng R&D", "Temporibus aspernatur earum eveniet tempore ea in iusto.", new DateTime(2024, 9, 13, 21, 41, 38, 66, DateTimeKind.Utc).AddTicks(5081) },
                    { 7, 3, new DateTime(2024, 9, 19, 3, 20, 11, 979, DateTimeKind.Utc).AddTicks(2228), "Phòng IT", "Voluptatem et debitis rem.", new DateTime(2024, 9, 19, 3, 20, 11, 979, DateTimeKind.Utc).AddTicks(2228) },
                    { 8, 2, new DateTime(2024, 9, 6, 15, 49, 58, 819, DateTimeKind.Utc).AddTicks(7458), "Phòng Pháp chế", "Quam voluptates maxime.", new DateTime(2024, 9, 6, 15, 49, 58, 819, DateTimeKind.Utc).AddTicks(7458) },
                    { 9, 4, new DateTime(2024, 9, 14, 15, 40, 11, 536, DateTimeKind.Utc).AddTicks(8504), "Phòng Kinh doanh", "Rerum laudantium explicabo.", new DateTime(2024, 9, 14, 15, 40, 11, 536, DateTimeKind.Utc).AddTicks(8504) },
                    { 10, 5, new DateTime(2024, 9, 15, 1, 9, 53, 187, DateTimeKind.Utc).AddTicks(8690), "Phòng Kinh doanh", "Veniam eius et qui est perferendis asperiores eius dolore dolor.", new DateTime(2024, 9, 15, 1, 9, 53, 187, DateTimeKind.Utc).AddTicks(8690) }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "Description", "RoleName" },
                values: new object[,]
                {
                    { 1, "Quản lý toàn bộ hệ thống", "Admin" },
                    { 2, "Quản lý toàn bộ công ty", "Manager" },
                    { 3, "Quản lý toàn bộ phòng ban", "DepartmentManaager" },
                    { 4, "Tạo và quản lý khách ra vào của phòng ban", "Staff" },
                    { 5, "Quản lý khách ra vào tại cổng", "Security" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "Status", "UpdatedDate", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 25, 16, 12, 25, 850, DateTimeKind.Utc).AddTicks(6785), "admin1@example.com", "Admin One", "123", "0123456789", 1, "Active", new DateTime(2024, 9, 25, 16, 12, 25, 850, DateTimeKind.Utc).AddTicks(6792), "admin1" },
                    { 2, new DateTime(2024, 6, 25, 16, 12, 25, 850, DateTimeKind.Utc).AddTicks(6794), "manager1@example.com", "Manager One", "123", "0987654321", 2, "Active", new DateTime(2024, 9, 25, 16, 12, 25, 850, DateTimeKind.Utc).AddTicks(6795), "manager1" },
                    { 3, new DateTime(2024, 7, 25, 16, 12, 25, 850, DateTimeKind.Utc).AddTicks(6797), "employee1@example.com", "Department Manager One", "123", "0112223334", 3, "Active", new DateTime(2024, 9, 25, 16, 12, 25, 850, DateTimeKind.Utc).AddTicks(6797), "DM1" },
                    { 4, new DateTime(2024, 8, 25, 16, 12, 25, 850, DateTimeKind.Utc).AddTicks(6799), "hr1@example.com", "Staff One", "123", "0223334445", 4, "Active", new DateTime(2024, 9, 25, 16, 12, 25, 850, DateTimeKind.Utc).AddTicks(6800), "Staff1" },
                    { 5, new DateTime(2024, 5, 25, 16, 12, 25, 850, DateTimeKind.Utc).AddTicks(6801), "it1@example.com", "Security One", "123", "0334445556", 5, "Active", new DateTime(2024, 9, 25, 16, 12, 25, 850, DateTimeKind.Utc).AddTicks(6802), "Security1" },
                    { 6, new DateTime(2024, 9, 17, 2, 29, 39, 760, DateTimeKind.Unspecified).AddTicks(1408), "gmail.com.Mertz@gmail.com", "Wilburn Nikolaus", "2gxkhw", "0358184031", 4, "Active", new DateTime(2024, 9, 17, 2, 29, 39, 760, DateTimeKind.Unspecified).AddTicks(1408), "Sage_Schmeler" },
                    { 7, new DateTime(2024, 9, 6, 9, 50, 51, 668, DateTimeKind.Unspecified).AddTicks(3048), "gmail.com_Bailey38@gmail.com", "Eric Spinka", "0p4yq9", "0656597384", 2, "Active", new DateTime(2024, 9, 6, 9, 50, 51, 668, DateTimeKind.Unspecified).AddTicks(3048), "Clarissa_Zemlak" },
                    { 8, new DateTime(2024, 9, 20, 0, 0, 25, 15, DateTimeKind.Unspecified).AddTicks(9588), "gmail.com.Rogahn32@yahoo.com", "Alayna Renner", "yrlhco", "0276634956", 5, "Active", new DateTime(2024, 9, 20, 0, 0, 25, 15, DateTimeKind.Unspecified).AddTicks(9588), "Matt36" },
                    { 9, new DateTime(2024, 9, 6, 1, 38, 18, 663, DateTimeKind.Unspecified).AddTicks(7033), "gmail.com_Nikolaus62@gmail.com", "Jefferey Heaney", "084pd1", "0411848682", 3, "Active", new DateTime(2024, 9, 6, 1, 38, 18, 663, DateTimeKind.Unspecified).AddTicks(7033), "Leon_Schneider14" },
                    { 10, new DateTime(2024, 9, 10, 11, 52, 38, 572, DateTimeKind.Unspecified).AddTicks(4356), "gmail.com.Bogisich@hotmail.com", "Elena Terry", "27c43e", "0762949919", 2, "Active", new DateTime(2024, 9, 10, 11, 52, 38, 572, DateTimeKind.Unspecified).AddTicks(4356), "Adolf64" },
                    { 11, new DateTime(2024, 9, 24, 14, 29, 47, 159, DateTimeKind.Unspecified).AddTicks(4548), "gmail.com_Oberbrunner@gmail.com", "Gay Toy", "pjtc4q", "0372122902", 2, "Active", new DateTime(2024, 9, 24, 14, 29, 47, 159, DateTimeKind.Unspecified).AddTicks(4548), "Anastacio.Blick" },
                    { 12, new DateTime(2024, 9, 21, 2, 4, 49, 516, DateTimeKind.Unspecified).AddTicks(8541), "gmail.com9@hotmail.com", "Pietro Morissette", "nz5deb", "0191711831", 3, "Active", new DateTime(2024, 9, 21, 2, 4, 49, 516, DateTimeKind.Unspecified).AddTicks(8541), "Fabiola28" },
                    { 13, new DateTime(2024, 9, 11, 10, 40, 5, 338, DateTimeKind.Unspecified).AddTicks(3282), "gmail.com_Kihn@yahoo.com", "Janessa Ernser", "34v1rs", "0379914908", 4, "Active", new DateTime(2024, 9, 11, 10, 40, 5, 338, DateTimeKind.Unspecified).AddTicks(3282), "Sarah91" },
                    { 14, new DateTime(2024, 9, 9, 21, 37, 4, 722, DateTimeKind.Unspecified).AddTicks(6194), "gmail.com.Cronin79@hotmail.com", "Freda Hand", "7hbmc7", "0546219994", 4, "Active", new DateTime(2024, 9, 9, 21, 37, 4, 722, DateTimeKind.Unspecified).AddTicks(6194), "Jayden.Boyer" },
                    { 15, new DateTime(2024, 9, 13, 9, 37, 48, 670, DateTimeKind.Unspecified).AddTicks(14), "gmail.com.Wisozk@hotmail.com", "Myrl Abshire", "a2e1fb", "0195639728", 3, "Active", new DateTime(2024, 9, 13, 9, 37, 48, 670, DateTimeKind.Unspecified).AddTicks(14), "Betsy41" },
                    { 16, new DateTime(2024, 9, 10, 22, 32, 6, 133, DateTimeKind.Unspecified).AddTicks(1891), "gmail.com70@yahoo.com", "Nicolette Stehr", "kpradd", "0710529703", 1, "Active", new DateTime(2024, 9, 10, 22, 32, 6, 133, DateTimeKind.Unspecified).AddTicks(1891), "Ryley.Dare36" },
                    { 17, new DateTime(2024, 9, 1, 3, 0, 17, 358, DateTimeKind.Unspecified).AddTicks(3392), "gmail.com_Jacobi32@yahoo.com", "Raquel Fahey", "v5iniw", "0241223773", 4, "Active", new DateTime(2024, 9, 1, 3, 0, 17, 358, DateTimeKind.Unspecified).AddTicks(3392), "Joany.Baumbach63" },
                    { 18, new DateTime(2024, 9, 22, 21, 7, 10, 473, DateTimeKind.Unspecified).AddTicks(7790), "gmail.com_Kozey37@yahoo.com", "Joey Bednar", "a9hsxa", "0345509790", 4, "Active", new DateTime(2024, 9, 22, 21, 7, 10, 473, DateTimeKind.Unspecified).AddTicks(7790), "Leopold.Turcotte72" },
                    { 19, new DateTime(2024, 9, 23, 4, 56, 53, 604, DateTimeKind.Unspecified).AddTicks(640), "gmail.com_Harris69@yahoo.com", "Misael Kemmer", "j9mp58", "0142800786", 5, "Active", new DateTime(2024, 9, 23, 4, 56, 53, 604, DateTimeKind.Unspecified).AddTicks(640), "Dan_Batz22" },
                    { 20, new DateTime(2024, 9, 16, 10, 0, 14, 792, DateTimeKind.Unspecified).AddTicks(9553), "gmail.com61@gmail.com", "Emile Okuneva", "f897se", "0701111702", 1, "Active", new DateTime(2024, 9, 16, 10, 0, 14, 792, DateTimeKind.Unspecified).AddTicks(9553), "Tanya_Bartoletti37" },
                    { 21, new DateTime(2024, 9, 10, 3, 10, 3, 498, DateTimeKind.Unspecified).AddTicks(6734), "gmail.com.Stoltenberg@hotmail.com", "Charity Kertzmann", "bpzbxq", "0135663761", 1, "Active", new DateTime(2024, 9, 10, 3, 10, 3, 498, DateTimeKind.Unspecified).AddTicks(6734), "Javonte33" },
                    { 22, new DateTime(2024, 9, 22, 20, 23, 5, 911, DateTimeKind.Unspecified).AddTicks(1619), "gmail.com.Jacobson@yahoo.com", "Toney Bailey", "1elc7y", "0956080700", 3, "Active", new DateTime(2024, 9, 22, 20, 23, 5, 911, DateTimeKind.Unspecified).AddTicks(1619), "Bradford4" },
                    { 23, new DateTime(2024, 9, 4, 2, 42, 26, 710, DateTimeKind.Unspecified).AddTicks(1098), "gmail.com85@yahoo.com", "Larissa Goyette", "9pomlw", "0629654378", 1, "Active", new DateTime(2024, 9, 4, 2, 42, 26, 710, DateTimeKind.Unspecified).AddTicks(1098), "Orville.Prohaska" },
                    { 24, new DateTime(2024, 9, 16, 21, 9, 14, 128, DateTimeKind.Unspecified).AddTicks(1766), "gmail.com.Cole18@yahoo.com", "Torrey Rogahn", "ronx1o", "0434673269", 5, "Active", new DateTime(2024, 9, 16, 21, 9, 14, 128, DateTimeKind.Unspecified).AddTicks(1766), "Kaitlin56" },
                    { 25, new DateTime(2024, 9, 10, 3, 35, 7, 814, DateTimeKind.Unspecified).AddTicks(9169), "gmail.com.Zboncak98@gmail.com", "Floyd Morissette", "1acx6x", "0260729199", 2, "Active", new DateTime(2024, 9, 10, 3, 35, 7, 814, DateTimeKind.Unspecified).AddTicks(9169), "Irma.Ankunding13" }
                });

            migrationBuilder.InsertData(
                table: "UserDepartments",
                columns: new[] { "UserDepartmentId", "DepartmentId", "UserId" },
                values: new object[,]
                {
                    { 1, 3, 12 },
                    { 2, 10, 4 },
                    { 3, 10, 9 },
                    { 4, 6, 8 },
                    { 5, 9, 10 },
                    { 6, 4, 23 },
                    { 7, 10, 8 },
                    { 8, 1, 15 },
                    { 9, 3, 9 },
                    { 10, 8, 10 },
                    { 11, 7, 21 },
                    { 12, 8, 13 },
                    { 13, 3, 6 },
                    { 14, 3, 22 },
                    { 15, 2, 9 },
                    { 16, 8, 18 },
                    { 17, 4, 23 },
                    { 18, 3, 22 },
                    { 19, 5, 13 },
                    { 20, 6, 18 },
                    { 21, 7, 25 },
                    { 22, 8, 19 },
                    { 23, 8, 16 },
                    { 24, 5, 6 },
                    { 25, 2, 6 },
                    { 26, 8, 17 },
                    { 27, 2, 24 },
                    { 28, 10, 10 },
                    { 29, 10, 3 },
                    { 30, 6, 14 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Visitors_UserId",
                table: "Visitors",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Visitors_Users_UserId",
                table: "Visitors",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visitors_Users_UserId",
                table: "Visitors");

            migrationBuilder.DropIndex(
                name: "IX_Visitors_UserId",
                table: "Visitors");

            migrationBuilder.DeleteData(
                table: "CredentialCardTypes",
                keyColumn: "CredentialCardTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CredentialCardTypes",
                keyColumn: "CredentialCardTypeId",
                keyValue: 2);

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
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 20);

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

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Visitors");
        }
    }
}
