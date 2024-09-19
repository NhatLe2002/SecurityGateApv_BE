using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SecurityGateApv.Infras.Migrations
{
    /// <inheritdoc />
    public partial class SeedData_6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 16, 9, 21, 37, 370, DateTimeKind.Utc).AddTicks(5536), "Phòng Kế toán", "Quasi dolorem magni perferendis facilis.", new DateTime(2024, 9, 16, 9, 21, 37, 370, DateTimeKind.Utc).AddTicks(5536) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2024, 9, 18, 19, 24, 58, 134, DateTimeKind.Utc).AddTicks(2946), "Phòng Kế toán", "Facilis voluptatem impedit dolor.", new DateTime(2024, 9, 18, 19, 24, 58, 134, DateTimeKind.Utc).AddTicks(2946) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "AcceptLevel", "CreateDate", "Description", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 9, 3, 16, 44, 2, 970, DateTimeKind.Utc).AddTicks(7900), "Inventore pariatur numquam ratione dicta recusandae.", new DateTime(2024, 9, 3, 16, 44, 2, 970, DateTimeKind.Utc).AddTicks(7900) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 14, 7, 58, 13, 486, DateTimeKind.Utc).AddTicks(9733), "Phòng Kế toán", "Molestias aut veritatis et.", new DateTime(2024, 9, 14, 7, 58, 13, 486, DateTimeKind.Utc).AddTicks(9733) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5,
                columns: new[] { "AcceptLevel", "CreateDate", "Description", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 3, 11, 45, 34, 857, DateTimeKind.Utc).AddTicks(1017), "Omnis dolores ipsa.", new DateTime(2024, 9, 3, 11, 45, 34, 857, DateTimeKind.Utc).AddTicks(1017) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 6,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 1, 9, 53, 19, 607, DateTimeKind.Utc).AddTicks(9948), "Phòng Sản xuất", "Vel sapiente officiis consequatur quos.", new DateTime(2024, 9, 1, 9, 53, 19, 607, DateTimeKind.Utc).AddTicks(9948) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 7,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 9, 13, 30, 7, 963, DateTimeKind.Utc).AddTicks(3366), "Phòng R&D", "Impedit fugiat nemo tenetur.", new DateTime(2024, 9, 9, 13, 30, 7, 963, DateTimeKind.Utc).AddTicks(3366) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 8,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2024, 9, 5, 19, 39, 31, 520, DateTimeKind.Utc).AddTicks(3084), "Phòng Kế toán", "Quos ab quae voluptatem possimus.", new DateTime(2024, 9, 5, 19, 39, 31, 520, DateTimeKind.Utc).AddTicks(3084) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 9,
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 13, 22, 27, 10, 736, DateTimeKind.Utc).AddTicks(4723), "Phòng IT", "Vel dolorum non voluptatem porro.", new DateTime(2024, 9, 13, 22, 27, 10, 736, DateTimeKind.Utc).AddTicks(4723) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 10,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 13, 10, 17, 6, 313, DateTimeKind.Utc).AddTicks(7744), "Phòng Pháp chế", "Libero eius quod in non nam ad.", new DateTime(2024, 9, 13, 10, 17, 6, 313, DateTimeKind.Utc).AddTicks(7744) });

            migrationBuilder.InsertData(
                table: "Reasons",
                columns: new[] { "ReasonId", "Description", "ReasonName" },
                values: new object[,]
                {
                    { 1, "Ut vero officiis quia dolorum eveniet nesciunt.", "Rustic Wooden Hat" },
                    { 2, "Aut ad magni.", "Small Rubber Bacon" },
                    { 3, "Laboriosam ipsam harum est aut ex aut quod non.", "Small Cotton Chair" },
                    { 4, "Omnis amet eos eaque quo.", "Small Plastic Chicken" },
                    { 5, "Natus rerum voluptate.", "Fantastic Fresh Keyboard" }
                });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 1,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 1, 24 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 2,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 3, 16 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 3,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 10, 22 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 4,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 4, 10 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 5,
                column: "DepartmentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 6,
                column: "UserId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 7,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 5, 19 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 8,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 19 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 9,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 10,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 2 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 11,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 5 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 12,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 10, 15 });

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
                column: "UserId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 15,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 5, 24 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 16,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 14 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 17,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 10 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 18,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 2, 23 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 19,
                column: "DepartmentId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 20,
                column: "UserId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 21,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 6, 20 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 22,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 18 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 23,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 2 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 24,
                column: "UserId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 25,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 23 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 26,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 14 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 27,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 11 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 28,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 17 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 29,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 6, 14 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 30,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 5, 24 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 19, 5, 55, 52, 536, DateTimeKind.Utc).AddTicks(2080), new DateTime(2024, 9, 19, 5, 55, 52, 536, DateTimeKind.Utc).AddTicks(2088) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 19, 5, 55, 52, 536, DateTimeKind.Utc).AddTicks(2091), new DateTime(2024, 9, 19, 5, 55, 52, 536, DateTimeKind.Utc).AddTicks(2092) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 19, 5, 55, 52, 536, DateTimeKind.Utc).AddTicks(2093), new DateTime(2024, 9, 19, 5, 55, 52, 536, DateTimeKind.Utc).AddTicks(2094) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 19, 5, 55, 52, 536, DateTimeKind.Utc).AddTicks(2095), new DateTime(2024, 9, 19, 5, 55, 52, 536, DateTimeKind.Utc).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 19, 5, 55, 52, 536, DateTimeKind.Utc).AddTicks(2097), new DateTime(2024, 9, 19, 5, 55, 52, 536, DateTimeKind.Utc).AddTicks(2098) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 13, 22, 25, 32, 656, DateTimeKind.Unspecified).AddTicks(1309), "gmail.com_Carroll@gmail.com", "Arvel Witting", "pm16ah", "0718901083", 2, new DateTime(2024, 9, 13, 22, 25, 32, 656, DateTimeKind.Unspecified).AddTicks(1309), "Sadye_Gerlach" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 11, 11, 56, 32, 721, DateTimeKind.Unspecified).AddTicks(7665), "gmail.com45@hotmail.com", "Brannon Gleichner", "ayevxx", "0887524404", 4, new DateTime(2024, 9, 11, 11, 56, 32, 721, DateTimeKind.Unspecified).AddTicks(7665), "Ezequiel_Batz85" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 14, 20, 57, 21, 751, DateTimeKind.Unspecified).AddTicks(2988), "gmail.com.Altenwerth@gmail.com", "Martine Kozey", "av6otp", "0316446128", 4, new DateTime(2024, 9, 14, 20, 57, 21, 751, DateTimeKind.Unspecified).AddTicks(2988), "Raphaelle42" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 17, 4, 58, 49, 536, DateTimeKind.Unspecified).AddTicks(7866), "gmail.com.Hickle@gmail.com", "Rene Daugherty", "fadigt", "0445975936", 4, new DateTime(2024, 9, 17, 4, 58, 49, 536, DateTimeKind.Unspecified).AddTicks(7866), "Ismael_Sporer83" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 28, 37, 434, DateTimeKind.Unspecified).AddTicks(5610), "gmail.com.Weber@gmail.com", "Aniya Reichert", "n7tonn", "0780629902", 1, new DateTime(2024, 9, 8, 16, 28, 37, 434, DateTimeKind.Unspecified).AddTicks(5610), "Khalid16" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 5, 1, 30, 44, 775, DateTimeKind.Unspecified).AddTicks(3962), "gmail.com.Gibson@yahoo.com", "Lauren Tremblay", "1acmbo", "0501360178", 4, new DateTime(2024, 9, 5, 1, 30, 44, 775, DateTimeKind.Unspecified).AddTicks(3962), "Spencer.Walsh" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 15, 0, 3, 15, 199, DateTimeKind.Unspecified).AddTicks(6360), "gmail.com_Mante@gmail.com", "Evie Littel", "2wmrq5", "0630618424", new DateTime(2024, 9, 15, 0, 3, 15, 199, DateTimeKind.Unspecified).AddTicks(6360), "Rosie99" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 10, 15, 3, 44, 425, DateTimeKind.Unspecified).AddTicks(6234), "gmail.com.Parisian@hotmail.com", "Casimir Kub", "ha8hqb", "0838940194", 1, new DateTime(2024, 9, 10, 15, 3, 44, 425, DateTimeKind.Unspecified).AddTicks(6234), "Misty.Connelly" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 17, 15, 33, 29, 481, DateTimeKind.Unspecified).AddTicks(3046), "gmail.com.Crooks96@yahoo.com", "Hillary Mayert", "aepbj3", "0284591715", 1, new DateTime(2024, 9, 17, 15, 33, 29, 481, DateTimeKind.Unspecified).AddTicks(3046), "Janae.Reilly" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 15, 2, 6, 25, 67, DateTimeKind.Unspecified).AddTicks(4375), "gmail.com52@hotmail.com", "Breana Kris", "kpfjfu", "0559913983", 1, new DateTime(2024, 9, 15, 2, 6, 25, 67, DateTimeKind.Unspecified).AddTicks(4375), "Ashlynn.Cole" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 13, 16, 27, 50, 658, DateTimeKind.Unspecified).AddTicks(2193), "gmail.com93@gmail.com", "Mabelle Klein", "9ky09s", "0741427139", 3, new DateTime(2024, 9, 13, 16, 27, 50, 658, DateTimeKind.Unspecified).AddTicks(2193), "Agustina50" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 19, 0, 40, 7, 930, DateTimeKind.Unspecified).AddTicks(744), "gmail.com.Wolff96@hotmail.com", "Dorris Morar", "ejdyjf", "0456343057", new DateTime(2024, 9, 19, 0, 40, 7, 930, DateTimeKind.Unspecified).AddTicks(744), "Dolly_Hegmann" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 7, 0, 14, 19, 500, DateTimeKind.Unspecified).AddTicks(4963), "gmail.com.Schuster83@hotmail.com", "Adela Schuster", "i7fbrq", "0691576615", 4, new DateTime(2024, 9, 7, 0, 14, 19, 500, DateTimeKind.Unspecified).AddTicks(4963), "Ally_Kiehn" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 14, 4, 4, 2, 643, DateTimeKind.Unspecified).AddTicks(3674), "gmail.com.Mayer79@hotmail.com", "Garland Zulauf", "ollizq", "0806481939", new DateTime(2024, 9, 14, 4, 4, 2, 643, DateTimeKind.Unspecified).AddTicks(3674), "Waino69" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 2, 4, 31, 32, 325, DateTimeKind.Unspecified).AddTicks(191), "gmail.com_Wehner@yahoo.com", "Dorothy Witting", "ahioc4", "0194213497", 4, new DateTime(2024, 9, 2, 4, 31, 32, 325, DateTimeKind.Unspecified).AddTicks(191), "Davon71" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 1, 1, 49, 5, 569, DateTimeKind.Unspecified).AddTicks(471), "gmail.com.Kohler@gmail.com", "Sigmund Swift", "6m1vgo", "0266929988", 2, new DateTime(2024, 9, 1, 1, 49, 5, 569, DateTimeKind.Unspecified).AddTicks(471), "Lindsay93" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 39, 24, 846, DateTimeKind.Unspecified).AddTicks(9092), "gmail.com.Lebsack@gmail.com", "Alan Beahan", "a15tyg", "0282805895", 2, new DateTime(2024, 9, 7, 13, 39, 24, 846, DateTimeKind.Unspecified).AddTicks(9092), "Hoyt_Casper" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 8, 11, 15, 33, 4, DateTimeKind.Unspecified).AddTicks(7384), "gmail.com_Jacobson@yahoo.com", "Duane Mraz", "0gt3ul", "0689041431", 2, new DateTime(2024, 9, 8, 11, 15, 33, 4, DateTimeKind.Unspecified).AddTicks(7384), "Justus_Pagac1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 13, 13, 11, 14, 971, DateTimeKind.Unspecified).AddTicks(4944), "gmail.com.Rau@gmail.com", "Michel Lang", "055zgs", "0316975787", 2, new DateTime(2024, 9, 13, 13, 11, 14, 971, DateTimeKind.Unspecified).AddTicks(4944), "Forrest.Grant27" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 9, 18, 23, 7, 580, DateTimeKind.Unspecified).AddTicks(6552), "gmail.com44@gmail.com", "Cassie Toy", "53c5nb", "0252799967", 3, new DateTime(2024, 9, 9, 18, 23, 7, 580, DateTimeKind.Unspecified).AddTicks(6552), "Leonardo99" });

            migrationBuilder.InsertData(
                table: "DepartmentReasons",
                columns: new[] { "DepartmentReasonId", "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[,]
                {
                    { 1, 3, "Reprehenderit autem sint.", "Sleek Plastic Gloves", 4 },
                    { 2, 4, "Ipsum id debitis consequuntur enim mollitia quisquam autem.", "Generic Granite Gloves", 1 },
                    { 3, 4, "Deleniti voluptas quam quisquam distinctio consequatur cumque quia et et.", "Ergonomic Metal Chair", 1 },
                    { 4, 6, "Vero cumque voluptas ducimus autem nostrum est.", "Handmade Cotton Towels", 4 },
                    { 5, 10, "Debitis nihil eum in aut veniam doloribus exercitationem.", "Fantastic Metal Sausages", 1 },
                    { 6, 10, "Sit autem labore aut libero aperiam eligendi.", "Ergonomic Concrete Hat", 5 },
                    { 7, 9, "Voluptatem voluptatibus rerum nam odit.", "Licensed Steel Ball", 1 },
                    { 8, 6, "Similique est sint tempore quas voluptates enim qui.", "Small Rubber Pants", 5 },
                    { 9, 8, "Cupiditate id quo.", "Ergonomic Rubber Sausages", 5 },
                    { 10, 1, "Totam quod aspernatur neque.", "Gorgeous Granite Salad", 3 },
                    { 11, 7, "Voluptatibus quas nihil laudantium quas.", "Handcrafted Fresh Chicken", 4 },
                    { 12, 1, "Odio tenetur ipsa.", "Refined Granite Pizza", 3 },
                    { 13, 6, "Corrupti omnis quia aut earum.", "Tasty Fresh Chair", 5 },
                    { 14, 5, "Neque in facere fugit neque impedit vel quae.", "Ergonomic Concrete Fish", 2 },
                    { 15, 1, "Quasi nihil architecto ab.", "Intelligent Plastic Car", 2 },
                    { 16, 2, "Veniam officiis sed.", "Awesome Wooden Fish", 5 },
                    { 17, 10, "Architecto iusto porro.", "Ergonomic Metal Soap", 3 },
                    { 18, 9, "Sint similique labore labore vel eius ad cumque.", "Unbranded Soft Car", 5 },
                    { 19, 1, "Laboriosam modi commodi.", "Licensed Fresh Cheese", 5 },
                    { 20, 3, "Dolorem quia nesciunt quo.", "Incredible Granite Car", 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Reasons",
                keyColumn: "ReasonId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reasons",
                keyColumn: "ReasonId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reasons",
                keyColumn: "ReasonId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reasons",
                keyColumn: "ReasonId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reasons",
                keyColumn: "ReasonId",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2024, 9, 17, 12, 7, 16, 43, DateTimeKind.Utc).AddTicks(95), "Phòng R&D", "Odit exercitationem modi.", new DateTime(2024, 9, 17, 12, 7, 16, 43, DateTimeKind.Utc).AddTicks(95) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 15, 11, 38, 28, 976, DateTimeKind.Utc).AddTicks(2860), "Phòng Nhân sự", "Beatae placeat ad rerum.", new DateTime(2024, 9, 15, 11, 38, 28, 976, DateTimeKind.Utc).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "AcceptLevel", "CreateDate", "Description", "UpdatedDate" },
                values: new object[] { 4, new DateTime(2024, 9, 16, 6, 28, 25, 980, DateTimeKind.Utc).AddTicks(4053), "Corporis vel esse maxime aut corporis ipsa.", new DateTime(2024, 9, 16, 6, 28, 25, 980, DateTimeKind.Utc).AddTicks(4053) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 9, 13, 18, 29, 6, 172, DateTimeKind.Utc).AddTicks(4322), "Phòng IT", "Consequatur nobis deserunt facere ipsam doloremque.", new DateTime(2024, 9, 13, 18, 29, 6, 172, DateTimeKind.Utc).AddTicks(4322) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5,
                columns: new[] { "AcceptLevel", "CreateDate", "Description", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 9, 6, 15, 42, 6, 164, DateTimeKind.Utc).AddTicks(3548), "Enim aliquid aliquam rerum dolorum officia nam.", new DateTime(2024, 9, 6, 15, 42, 6, 164, DateTimeKind.Utc).AddTicks(3548) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 6,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 13, 12, 17, 32, 109, DateTimeKind.Utc).AddTicks(3651), "Phòng R&D", "Deleniti consequatur quis laboriosam consequatur velit unde voluptatibus fugit sit.", new DateTime(2024, 9, 13, 12, 17, 32, 109, DateTimeKind.Utc).AddTicks(3651) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 7,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 9, 17, 3, 51, 55, 823, DateTimeKind.Utc).AddTicks(7939), "Phòng Kinh doanh", "Dolore qui molestias aut quia in dolor reprehenderit modi quo.", new DateTime(2024, 9, 17, 3, 51, 55, 823, DateTimeKind.Utc).AddTicks(7939) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 8,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 9, 9, 23, 30, 32, 124, DateTimeKind.Utc).AddTicks(7706), "Phòng Marketing", "Est nihil dolor ut.", new DateTime(2024, 9, 9, 23, 30, 32, 124, DateTimeKind.Utc).AddTicks(7706) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 9,
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 15, 20, 14, 19, 452, DateTimeKind.Utc).AddTicks(3293), "Phòng Kinh doanh", "Rerum qui necessitatibus non animi eum alias expedita possimus.", new DateTime(2024, 9, 15, 20, 14, 19, 452, DateTimeKind.Utc).AddTicks(3293) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 10,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 9, 6, 19, 40, 25, 355, DateTimeKind.Utc).AddTicks(7977), "Phòng R&D", "Voluptatibus ea sed.", new DateTime(2024, 9, 6, 19, 40, 25, 355, DateTimeKind.Utc).AddTicks(7977) });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 1,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 6, 25 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 2,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 2, 22 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 3,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 5, 24 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 4,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 10, 8 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 5,
                column: "DepartmentId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 6,
                column: "UserId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 7,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 23 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 8,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 10, 16 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 9,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 6, 24 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 10,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 1, 9 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 11,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 5, 4 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 12,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 3 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 13,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 6, 3 });

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
                values: new object[] { 7, 12 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 16,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 2, 22 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 17,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 21 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 18,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 17 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 19,
                column: "DepartmentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 20,
                column: "UserId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 21,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 4, 12 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 22,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 2, 10 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 23,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 4 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 24,
                column: "UserId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 25,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 7 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 26,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 2, 8 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 27,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 4, 23 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 28,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 25 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 29,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 10, 10 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 30,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 10, 8 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 19, 5, 44, 44, 687, DateTimeKind.Utc).AddTicks(6616), new DateTime(2024, 9, 19, 5, 44, 44, 687, DateTimeKind.Utc).AddTicks(6625) });

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
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 19, 5, 44, 44, 687, DateTimeKind.Utc).AddTicks(6631), new DateTime(2024, 9, 19, 5, 44, 44, 687, DateTimeKind.Utc).AddTicks(6631) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 19, 5, 44, 44, 687, DateTimeKind.Utc).AddTicks(6633), new DateTime(2024, 9, 19, 5, 44, 44, 687, DateTimeKind.Utc).AddTicks(6634) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 19, 5, 44, 44, 687, DateTimeKind.Utc).AddTicks(6635), new DateTime(2024, 9, 19, 5, 44, 44, 687, DateTimeKind.Utc).AddTicks(6636) });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 13, 3, 10, 35, 672, DateTimeKind.Unspecified).AddTicks(8882), "gmail.com.Witting71@yahoo.com", "Lane Medhurst", "b6xeia", "0611387735", 2, new DateTime(2024, 9, 13, 3, 10, 35, 672, DateTimeKind.Unspecified).AddTicks(8882), "Cade.Jaskolski" });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 8, 5, 34, 7, 673, DateTimeKind.Unspecified).AddTicks(2087), "gmail.com.Yost8@hotmail.com", "Susan Pagac", "emiea9", "0584261421", 5, new DateTime(2024, 9, 8, 5, 34, 7, 673, DateTimeKind.Unspecified).AddTicks(2087), "Retta.Mueller63" });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 3, 15, 43, 56, 360, DateTimeKind.Unspecified).AddTicks(7902), "gmail.com.Russel65@yahoo.com", "Giles Thompson", "8q4vpq", "0870088468", new DateTime(2024, 9, 3, 15, 43, 56, 360, DateTimeKind.Unspecified).AddTicks(7902), "Gretchen23" });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 2, 21, 31, 46, 194, DateTimeKind.Unspecified).AddTicks(3382), "gmail.com_Borer@gmail.com", "Richmond Emard", "tyb5i6", "0635897609", new DateTime(2024, 9, 2, 21, 31, 46, 194, DateTimeKind.Unspecified).AddTicks(3382), "Keeley.Padberg" });

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
        }
    }
}
