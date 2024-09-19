using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SecurityGateApv.Infras.Migrations
{
    /// <inheritdoc />
    public partial class SeedData_7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CredentialCardTypes",
                columns: new[] { "CredentialCardTypeId", "CredentialCardTypeName" },
                values: new object[,]
                {
                    { 1, "Giấy phép lái xe" },
                    { 2, "Căn cước công dân" }
                });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 1,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 9, "Sunt sed quos qui necessitatibus molestiae dolor cupiditate eum.", "Tasty Wooden Pizza", 2 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 2,
                columns: new[] { "Description", "Name", "ReasonId" },
                values: new object[] { "Praesentium sed sapiente ut corrupti consequatur non dignissimos voluptas.", "Gorgeous Concrete Gloves", 5 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 3,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 2, "In vel iusto reiciendis inventore dignissimos qui esse.", "Ergonomic Cotton Pants", 2 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 4,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 3, "Quo quis expedita voluptas delectus veritatis debitis.", "Fantastic Rubber Salad", 1 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 5,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 1, "Repellendus autem id odio velit accusantium aliquam.", "Sleek Metal Towels", 4 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 6,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 4, "Minus sed fuga officiis temporibus aut tempora ut sit quo.", "Rustic Fresh Cheese", 1 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 7,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 8, "Reprehenderit consequuntur ea inventore voluptatibus quia quaerat.", "Small Rubber Computer", 5 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 8,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 10, "Nam doloremque voluptatem autem.", "Rustic Plastic Ball", 2 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 9,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 5, "Dolores animi at molestiae ut porro.", "Tasty Fresh Pants", 1 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 10,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 7, "Sed vel facere atque incidunt.", "Unbranded Concrete Shoes", 4 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 11,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 3, "Veniam sunt iusto quo rerum ut reprehenderit sunt tenetur placeat.", "Incredible Plastic Pizza", 2 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 12,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 4, "Doloribus sit quia similique eos accusamus enim minus.", "Refined Wooden Mouse", 4 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 13,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 2, "Autem iusto at maxime fugiat id.", "Unbranded Steel Pizza", 3 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 14,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 8, "Molestiae voluptatibus est autem amet recusandae.", "Intelligent Metal Shoes", 4 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 15,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 5, "Exercitationem numquam culpa sit velit sit.", "Tasty Frozen Car", 1 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 16,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 1, "Recusandae autem saepe.", "Unbranded Frozen Salad", 4 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 17,
                columns: new[] { "DepartmentId", "Description", "Name" },
                values: new object[] { 1, "Natus numquam sapiente et beatae ipsum sint debitis expedita.", "Small Frozen Chips" });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 18,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 8, "Aut quis ut ut.", "Tasty Fresh Bike", 3 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 19,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 3, "Perspiciatis rerum quae molestiae.", "Tasty Granite Tuna", 3 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 20,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 2, "Doloremque rerum distinctio.", "Practical Plastic Shirt", 3 });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2024, 9, 4, 8, 50, 49, 194, DateTimeKind.Utc).AddTicks(891), "Phòng Sản xuất", "Distinctio est cum sit ipsum accusantium.", new DateTime(2024, 9, 4, 8, 50, 49, 194, DateTimeKind.Utc).AddTicks(891) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 4, new DateTime(2024, 9, 16, 13, 1, 52, 259, DateTimeKind.Utc).AddTicks(1947), "Phòng Sản xuất", "Rem beatae fugit autem autem.", new DateTime(2024, 9, 16, 13, 1, 52, 259, DateTimeKind.Utc).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 15, 9, 25, 14, 97, DateTimeKind.Utc).AddTicks(3692), "Phòng Chăm sóc khách hàng", "Adipisci perspiciatis quia quaerat.", new DateTime(2024, 9, 15, 9, 25, 14, 97, DateTimeKind.Utc).AddTicks(3692) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4,
                columns: new[] { "CreateDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 20, 42, 32, 528, DateTimeKind.Utc).AddTicks(586), "Beatae voluptatem ullam porro et optio.", new DateTime(2024, 9, 10, 20, 42, 32, 528, DateTimeKind.Utc).AddTicks(586) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 9, 10, 14, 47, 749, DateTimeKind.Utc).AddTicks(4095), "Phòng Kế toán", "Incidunt animi nostrum ratione saepe corrupti aut libero quis quod.", new DateTime(2024, 9, 9, 10, 14, 47, 749, DateTimeKind.Utc).AddTicks(4095) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 6,
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 14, 57, 43, 322, DateTimeKind.Utc).AddTicks(194), "Phòng Hành chính", "Exercitationem maiores inventore aliquam ullam eum et.", new DateTime(2024, 9, 12, 14, 57, 43, 322, DateTimeKind.Utc).AddTicks(194) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 7,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 4, new DateTime(2024, 9, 8, 15, 47, 19, 689, DateTimeKind.Utc).AddTicks(1622), "Phòng Chăm sóc khách hàng", "Labore consequatur ut autem esse labore.", new DateTime(2024, 9, 8, 15, 47, 19, 689, DateTimeKind.Utc).AddTicks(1622) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 8,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 9, 18, 52, 32, 610, DateTimeKind.Utc).AddTicks(1617), "Phòng IT", "Harum porro deleniti quia.", new DateTime(2024, 9, 9, 18, 52, 32, 610, DateTimeKind.Utc).AddTicks(1617) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 9,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 9, 8, 7, 28, 29, 229, DateTimeKind.Utc).AddTicks(4555), "Phòng Kế toán", "Et praesentium velit.", new DateTime(2024, 9, 8, 7, 28, 29, 229, DateTimeKind.Utc).AddTicks(4555) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 10,
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 6, 1, 57, 6, 697, DateTimeKind.Utc).AddTicks(5916), "Phòng Nhân sự", "Rem pariatur voluptatem voluptatem harum temporibus aliquam quibusdam velit.", new DateTime(2024, 9, 6, 1, 57, 6, 697, DateTimeKind.Utc).AddTicks(5916) });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "CreateBy", "CreateTime", "ProjectName", "Status" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2024, 9, 11, 0, 30, 58, 134, DateTimeKind.Unspecified).AddTicks(3836), "Practical Steel Towels", true },
                    { 2, 3, new DateTime(2024, 9, 15, 7, 40, 47, 921, DateTimeKind.Unspecified).AddTicks(1512), "Awesome Fresh Pants", false },
                    { 3, 3, new DateTime(2024, 9, 3, 23, 1, 28, 23, DateTimeKind.Unspecified).AddTicks(5312), "Handcrafted Rubber Soap", true },
                    { 4, 3, new DateTime(2024, 9, 2, 0, 29, 40, 568, DateTimeKind.Unspecified).AddTicks(1793), "Ergonomic Granite Mouse", true },
                    { 5, 3, new DateTime(2024, 9, 18, 8, 2, 27, 742, DateTimeKind.Unspecified).AddTicks(4526), "Fantastic Cotton Tuna", true }
                });

            migrationBuilder.UpdateData(
                table: "Reasons",
                keyColumn: "ReasonId",
                keyValue: 1,
                columns: new[] { "Description", "ReasonName" },
                values: new object[] { "Quo libero ut aut in dolores.", "Gorgeous Rubber Chair" });

            migrationBuilder.UpdateData(
                table: "Reasons",
                keyColumn: "ReasonId",
                keyValue: 2,
                columns: new[] { "Description", "ReasonName" },
                values: new object[] { "Architecto exercitationem unde eum in voluptatem impedit.", "Incredible Rubber Chair" });

            migrationBuilder.UpdateData(
                table: "Reasons",
                keyColumn: "ReasonId",
                keyValue: 3,
                columns: new[] { "Description", "ReasonName" },
                values: new object[] { "Et provident quia et dolorum adipisci praesentium recusandae nostrum.", "Rustic Frozen Mouse" });

            migrationBuilder.UpdateData(
                table: "Reasons",
                keyColumn: "ReasonId",
                keyValue: 4,
                columns: new[] { "Description", "ReasonName" },
                values: new object[] { "Omnis est voluptatem.", "Ergonomic Granite Gloves" });

            migrationBuilder.UpdateData(
                table: "Reasons",
                keyColumn: "ReasonId",
                keyValue: 5,
                columns: new[] { "Description", "ReasonName" },
                values: new object[] { "Atque et cupiditate incidunt ratione.", "Intelligent Steel Mouse" });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 1,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 4, 11 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 2,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 2 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 3,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 2, 8 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 4,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 6, 11 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 5,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 1, 16 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 6,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 5 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 7,
                column: "DepartmentId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 8,
                column: "UserId",
                value: 22);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 9,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 4, 22 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 10,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 4, 24 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 11,
                column: "UserId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 12,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 4, 20 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 13,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 6, 4 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 14,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 6, 14 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 15,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 1, 23 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 16,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 12 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 17,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 22 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 18,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 6, 7 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 19,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 22 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 20,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 5, 22 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 21,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 21 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 22,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 25 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 23,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 10, 21 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 24,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 5, 16 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 25,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 10, 6 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 26,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 4, 9 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 27,
                column: "DepartmentId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 28,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 10, 14 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 29,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 9 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 30,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 6, 21 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 19, 6, 9, 0, 423, DateTimeKind.Utc).AddTicks(4804), new DateTime(2024, 9, 19, 6, 9, 0, 423, DateTimeKind.Utc).AddTicks(4814) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 19, 6, 9, 0, 423, DateTimeKind.Utc).AddTicks(4817), new DateTime(2024, 9, 19, 6, 9, 0, 423, DateTimeKind.Utc).AddTicks(4818) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 19, 6, 9, 0, 423, DateTimeKind.Utc).AddTicks(4819), new DateTime(2024, 9, 19, 6, 9, 0, 423, DateTimeKind.Utc).AddTicks(4820) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 19, 6, 9, 0, 423, DateTimeKind.Utc).AddTicks(4830), new DateTime(2024, 9, 19, 6, 9, 0, 423, DateTimeKind.Utc).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 19, 6, 9, 0, 423, DateTimeKind.Utc).AddTicks(4832), new DateTime(2024, 9, 19, 6, 9, 0, 423, DateTimeKind.Utc).AddTicks(4833) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 18, 3, 12, 29, 616, DateTimeKind.Unspecified).AddTicks(2783), "gmail.com_Runolfsson7@hotmail.com", "Khalid Klein", "ooofx7", "0527926609", new DateTime(2024, 9, 18, 3, 12, 29, 616, DateTimeKind.Unspecified).AddTicks(2783), "Elva54" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 14, 14, 57, 29, 325, DateTimeKind.Unspecified).AddTicks(1333), "gmail.com_McCullough@gmail.com", "Katherine Jacobson", "a5up34", "0653494478", new DateTime(2024, 9, 14, 14, 57, 29, 325, DateTimeKind.Unspecified).AddTicks(1333), "Malinda.Friesen39" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 1, 11, 56, 48, 565, DateTimeKind.Unspecified).AddTicks(3492), "gmail.com_Haley@gmail.com", "Emmett Paucek", "icdxzr", "0568190871", new DateTime(2024, 9, 1, 11, 56, 48, 565, DateTimeKind.Unspecified).AddTicks(3492), "Addie_Greenholt70" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 14, 21, 47, 6, 428, DateTimeKind.Unspecified).AddTicks(648), "gmail.com_Jones97@hotmail.com", "Lorine Gorczany", "af6leg", "0904913235", 3, new DateTime(2024, 9, 14, 21, 47, 6, 428, DateTimeKind.Unspecified).AddTicks(648), "Declan_Maggio98" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 9, 23, 6, 42, 738, DateTimeKind.Unspecified).AddTicks(4045), "gmail.com_Satterfield@yahoo.com", "Leonard Monahan", "fqe3wn", "0237506767", 4, new DateTime(2024, 9, 9, 23, 6, 42, 738, DateTimeKind.Unspecified).AddTicks(4045), "Josefina_Gottlieb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 16, 14, 19, 9, 265, DateTimeKind.Unspecified).AddTicks(18), "gmail.com.Douglas@hotmail.com", "Gunner Daugherty", "9741pd", "0336369725", 3, new DateTime(2024, 9, 16, 14, 19, 9, 265, DateTimeKind.Unspecified).AddTicks(18), "Freida_Lowe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 14, 18, 18, 1, 769, DateTimeKind.Unspecified).AddTicks(7612), "gmail.com_Tromp@gmail.com", "Lola Romaguera", "8f3nn0", "0514607831", new DateTime(2024, 9, 14, 18, 18, 1, 769, DateTimeKind.Unspecified).AddTicks(7612), "Kali_Schoen84" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 3, 16, 10, 53, 557, DateTimeKind.Unspecified).AddTicks(6931), "gmail.com.Goldner@gmail.com", "Sigmund Nikolaus", "3ekoe8", "0248005436", 5, new DateTime(2024, 9, 3, 16, 10, 53, 557, DateTimeKind.Unspecified).AddTicks(6931), "Mercedes_Hermann" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 13, 2, 24, 32, 120, DateTimeKind.Unspecified).AddTicks(5172), "gmail.com.Botsford37@gmail.com", "Randy Bosco", "b3ra02", "0516176792", 4, new DateTime(2024, 9, 13, 2, 24, 32, 120, DateTimeKind.Unspecified).AddTicks(5172), "Marietta.Weimann63" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 3, 3, 37, 14, 144, DateTimeKind.Unspecified).AddTicks(7427), "gmail.com.Volkman39@gmail.com", "Cleve Murazik", "fpxra2", "0892603778", 4, new DateTime(2024, 9, 3, 3, 37, 14, 144, DateTimeKind.Unspecified).AddTicks(7427), "Jake.Pollich43" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 10, 17, 54, 48, 438, DateTimeKind.Unspecified).AddTicks(1159), "gmail.com7@hotmail.com", "Chance Graham", "yqmje1", "0787653898", 2, new DateTime(2024, 9, 10, 17, 54, 48, 438, DateTimeKind.Unspecified).AddTicks(1159), "Clinton90" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 15, 6, 53, 21, 995, DateTimeKind.Unspecified).AddTicks(9683), "gmail.com_Satterfield29@yahoo.com", "Colton Wolf", "fn342m", "0567690286", 3, new DateTime(2024, 9, 15, 6, 53, 21, 995, DateTimeKind.Unspecified).AddTicks(9683), "Haven.VonRueden" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 1, 5, 24, 27, 6, DateTimeKind.Unspecified).AddTicks(7277), "gmail.com59@hotmail.com", "Litzy Mante", "84ko2m", "0191918821", 1, new DateTime(2024, 9, 1, 5, 24, 27, 6, DateTimeKind.Unspecified).AddTicks(7277), "Daphnee87" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 9, 14, 13, 9, 333, DateTimeKind.Unspecified).AddTicks(7039), "gmail.com.Grady35@hotmail.com", "Verna Adams", "9603pn", "0980355639", 4, new DateTime(2024, 9, 9, 14, 13, 9, 333, DateTimeKind.Unspecified).AddTicks(7039), "Nicole_Brakus" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 3, 13, 43, 24, 251, DateTimeKind.Unspecified).AddTicks(2312), "gmail.com4@yahoo.com", "Sophie Predovic", "8mt40z", "0776485118", new DateTime(2024, 9, 3, 13, 43, 24, 251, DateTimeKind.Unspecified).AddTicks(2312), "Verna.Swift" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 12, 9, 48, 16, 533, DateTimeKind.Unspecified).AddTicks(5409), "gmail.com74@hotmail.com", "Afton Jacobs", "602k7i", "0655747313", new DateTime(2024, 9, 12, 9, 48, 16, 533, DateTimeKind.Unspecified).AddTicks(5409), "Kennedi_Bode22" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 19, 38, 899, DateTimeKind.Unspecified).AddTicks(9761), "gmail.com9@hotmail.com", "Sarai Rolfson", "0l2xpi", "0680949617", new DateTime(2024, 9, 2, 17, 19, 38, 899, DateTimeKind.Unspecified).AddTicks(9761), "Stephany89" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 14, 13, 36, 11, 575, DateTimeKind.Unspecified).AddTicks(681), "gmail.com.Schulist@yahoo.com", "Seth Waelchi", "ukpf43", "0489933690", 5, new DateTime(2024, 9, 14, 13, 36, 11, 575, DateTimeKind.Unspecified).AddTicks(681), "Mariah81" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 7, 20, 13, 23, 376, DateTimeKind.Unspecified).AddTicks(2055), "gmail.com10@yahoo.com", "Treva Murray", "hblxna", "0503140877", 5, new DateTime(2024, 9, 7, 20, 13, 23, 376, DateTimeKind.Unspecified).AddTicks(2055), "Joey_Reilly12" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 8, 0, 19, 9, 600, DateTimeKind.Unspecified).AddTicks(8629), "gmail.com.Hilll52@gmail.com", "Albert Wintheiser", "9a4eh0", "0850891389", 2, new DateTime(2024, 9, 8, 0, 19, 9, 600, DateTimeKind.Unspecified).AddTicks(8629), "Reta52" });

            migrationBuilder.InsertData(
                table: "Visitors",
                columns: new[] { "VisitorId", "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[,]
                {
                    { 1, "Beahan Inc", new DateTime(2024, 9, 9, 5, 56, 48, 112, DateTimeKind.Unspecified).AddTicks(1378), 2, "chpvacllr1", "0959243904", true, new DateTime(2024, 9, 9, 5, 56, 48, 112, DateTimeKind.Unspecified).AddTicks(1378), "Kathleen Zemlak" },
                    { 2, "Lesch, Torp and Bosco", new DateTime(2024, 9, 12, 11, 39, 35, 698, DateTimeKind.Unspecified).AddTicks(2522), 2, "62j7y5lmbt", "0759401056", true, new DateTime(2024, 9, 12, 11, 39, 35, 698, DateTimeKind.Unspecified).AddTicks(2522), "Ayden Yundt" },
                    { 3, "Rau - Feeney", new DateTime(2024, 9, 17, 3, 41, 46, 16, DateTimeKind.Unspecified).AddTicks(4570), 2, "me80xz44wh", "0529873894", false, new DateTime(2024, 9, 17, 3, 41, 46, 16, DateTimeKind.Unspecified).AddTicks(4570), "Armani Wolff" },
                    { 4, "Kunde - Greenfelder", new DateTime(2024, 9, 1, 1, 36, 35, 997, DateTimeKind.Unspecified).AddTicks(248), 1, "mo8p2vv38t", "0391337578", true, new DateTime(2024, 9, 1, 1, 36, 35, 997, DateTimeKind.Unspecified).AddTicks(248), "Bethel Mohr" },
                    { 5, "Mitchell - Bayer", new DateTime(2024, 9, 2, 6, 32, 56, 904, DateTimeKind.Unspecified).AddTicks(8861), 1, "tok2rit1tn", "0585198803", false, new DateTime(2024, 9, 2, 6, 32, 56, 904, DateTimeKind.Unspecified).AddTicks(8861), "Wilton DuBuque" },
                    { 6, "Bednar Group", new DateTime(2024, 9, 6, 11, 16, 34, 897, DateTimeKind.Unspecified).AddTicks(4735), 1, "zxksdwyp3x", "0851739853", false, new DateTime(2024, 9, 6, 11, 16, 34, 897, DateTimeKind.Unspecified).AddTicks(4735), "Derrick Rolfson" },
                    { 7, "Schimmel and Sons", new DateTime(2024, 9, 7, 8, 35, 37, 984, DateTimeKind.Unspecified).AddTicks(1137), 1, "pvmzahewxy", "0511536460", true, new DateTime(2024, 9, 7, 8, 35, 37, 984, DateTimeKind.Unspecified).AddTicks(1137), "Nasir Littel" },
                    { 8, "Conn, Ernser and Fadel", new DateTime(2024, 9, 9, 13, 24, 32, 593, DateTimeKind.Unspecified).AddTicks(2866), 1, "sz0sxxh2vr", "0143258434", false, new DateTime(2024, 9, 9, 13, 24, 32, 593, DateTimeKind.Unspecified).AddTicks(2866), "Alia Osinski" },
                    { 9, "Ledner, Daugherty and Bayer", new DateTime(2024, 9, 10, 16, 20, 30, 20, DateTimeKind.Unspecified).AddTicks(9948), 1, "9hmba295wj", "0583409318", false, new DateTime(2024, 9, 10, 16, 20, 30, 20, DateTimeKind.Unspecified).AddTicks(9948), "Toney Haley" },
                    { 10, "Nolan - Langosh", new DateTime(2024, 9, 15, 12, 38, 54, 276, DateTimeKind.Unspecified).AddTicks(1227), 2, "ly07btyrrc", "0889509949", false, new DateTime(2024, 9, 15, 12, 38, 54, 276, DateTimeKind.Unspecified).AddTicks(1227), "Bernardo Hettinger" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CredentialCardTypes",
                keyColumn: "CredentialCardTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CredentialCardTypes",
                keyColumn: "CredentialCardTypeId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 1,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 3, "Reprehenderit autem sint.", "Sleek Plastic Gloves", 4 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 2,
                columns: new[] { "Description", "Name", "ReasonId" },
                values: new object[] { "Ipsum id debitis consequuntur enim mollitia quisquam autem.", "Generic Granite Gloves", 1 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 3,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 4, "Deleniti voluptas quam quisquam distinctio consequatur cumque quia et et.", "Ergonomic Metal Chair", 1 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 4,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 6, "Vero cumque voluptas ducimus autem nostrum est.", "Handmade Cotton Towels", 4 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 5,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 10, "Debitis nihil eum in aut veniam doloribus exercitationem.", "Fantastic Metal Sausages", 1 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 6,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 10, "Sit autem labore aut libero aperiam eligendi.", "Ergonomic Concrete Hat", 5 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 7,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 9, "Voluptatem voluptatibus rerum nam odit.", "Licensed Steel Ball", 1 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 8,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 6, "Similique est sint tempore quas voluptates enim qui.", "Small Rubber Pants", 5 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 9,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 8, "Cupiditate id quo.", "Ergonomic Rubber Sausages", 5 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 10,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 1, "Totam quod aspernatur neque.", "Gorgeous Granite Salad", 3 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 11,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 7, "Voluptatibus quas nihil laudantium quas.", "Handcrafted Fresh Chicken", 4 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 12,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 1, "Odio tenetur ipsa.", "Refined Granite Pizza", 3 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 13,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 6, "Corrupti omnis quia aut earum.", "Tasty Fresh Chair", 5 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 14,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 5, "Neque in facere fugit neque impedit vel quae.", "Ergonomic Concrete Fish", 2 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 15,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 1, "Quasi nihil architecto ab.", "Intelligent Plastic Car", 2 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 16,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 2, "Veniam officiis sed.", "Awesome Wooden Fish", 5 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 17,
                columns: new[] { "DepartmentId", "Description", "Name" },
                values: new object[] { 10, "Architecto iusto porro.", "Ergonomic Metal Soap" });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 18,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 9, "Sint similique labore labore vel eius ad cumque.", "Unbranded Soft Car", 5 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 19,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 1, "Laboriosam modi commodi.", "Licensed Fresh Cheese", 5 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 20,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 3, "Dolorem quia nesciunt quo.", "Incredible Granite Car", 5 });

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
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 9, 3, 16, 44, 2, 970, DateTimeKind.Utc).AddTicks(7900), "Phòng Kinh doanh", "Inventore pariatur numquam ratione dicta recusandae.", new DateTime(2024, 9, 3, 16, 44, 2, 970, DateTimeKind.Utc).AddTicks(7900) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4,
                columns: new[] { "CreateDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 14, 7, 58, 13, 486, DateTimeKind.Utc).AddTicks(9733), "Molestias aut veritatis et.", new DateTime(2024, 9, 14, 7, 58, 13, 486, DateTimeKind.Utc).AddTicks(9733) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 3, 11, 45, 34, 857, DateTimeKind.Utc).AddTicks(1017), "Phòng Pháp chế", "Omnis dolores ipsa.", new DateTime(2024, 9, 3, 11, 45, 34, 857, DateTimeKind.Utc).AddTicks(1017) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 6,
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 1, 9, 53, 19, 607, DateTimeKind.Utc).AddTicks(9948), "Phòng Sản xuất", "Vel sapiente officiis consequatur quos.", new DateTime(2024, 9, 1, 9, 53, 19, 607, DateTimeKind.Utc).AddTicks(9948) });

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
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 13, 22, 27, 10, 736, DateTimeKind.Utc).AddTicks(4723), "Phòng IT", "Vel dolorum non voluptatem porro.", new DateTime(2024, 9, 13, 22, 27, 10, 736, DateTimeKind.Utc).AddTicks(4723) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 10,
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 13, 10, 17, 6, 313, DateTimeKind.Utc).AddTicks(7744), "Phòng Pháp chế", "Libero eius quod in non nam ad.", new DateTime(2024, 9, 13, 10, 17, 6, 313, DateTimeKind.Utc).AddTicks(7744) });

            migrationBuilder.UpdateData(
                table: "Reasons",
                keyColumn: "ReasonId",
                keyValue: 1,
                columns: new[] { "Description", "ReasonName" },
                values: new object[] { "Ut vero officiis quia dolorum eveniet nesciunt.", "Rustic Wooden Hat" });

            migrationBuilder.UpdateData(
                table: "Reasons",
                keyColumn: "ReasonId",
                keyValue: 2,
                columns: new[] { "Description", "ReasonName" },
                values: new object[] { "Aut ad magni.", "Small Rubber Bacon" });

            migrationBuilder.UpdateData(
                table: "Reasons",
                keyColumn: "ReasonId",
                keyValue: 3,
                columns: new[] { "Description", "ReasonName" },
                values: new object[] { "Laboriosam ipsam harum est aut ex aut quod non.", "Small Cotton Chair" });

            migrationBuilder.UpdateData(
                table: "Reasons",
                keyColumn: "ReasonId",
                keyValue: 4,
                columns: new[] { "Description", "ReasonName" },
                values: new object[] { "Omnis amet eos eaque quo.", "Small Plastic Chicken" });

            migrationBuilder.UpdateData(
                table: "Reasons",
                keyColumn: "ReasonId",
                keyValue: 5,
                columns: new[] { "Description", "ReasonName" },
                values: new object[] { "Natus rerum voluptate.", "Fantastic Fresh Keyboard" });

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
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 2, 17 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 6,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 3, 12 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 7,
                column: "DepartmentId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 8,
                column: "UserId",
                value: 19);

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
                column: "UserId",
                value: 5);

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
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 1, 15 });

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
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 4, 6 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 20,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 1 });

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
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 4, 19 });

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
                column: "DepartmentId",
                value: 9);

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 13, 22, 25, 32, 656, DateTimeKind.Unspecified).AddTicks(1309), "gmail.com_Carroll@gmail.com", "Arvel Witting", "pm16ah", "0718901083", new DateTime(2024, 9, 13, 22, 25, 32, 656, DateTimeKind.Unspecified).AddTicks(1309), "Sadye_Gerlach" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 11, 11, 56, 32, 721, DateTimeKind.Unspecified).AddTicks(7665), "gmail.com45@hotmail.com", "Brannon Gleichner", "ayevxx", "0887524404", new DateTime(2024, 9, 11, 11, 56, 32, 721, DateTimeKind.Unspecified).AddTicks(7665), "Ezequiel_Batz85" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 14, 20, 57, 21, 751, DateTimeKind.Unspecified).AddTicks(2988), "gmail.com.Altenwerth@gmail.com", "Martine Kozey", "av6otp", "0316446128", new DateTime(2024, 9, 14, 20, 57, 21, 751, DateTimeKind.Unspecified).AddTicks(2988), "Raphaelle42" });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 19, 0, 40, 7, 930, DateTimeKind.Unspecified).AddTicks(744), "gmail.com.Wolff96@hotmail.com", "Dorris Morar", "ejdyjf", "0456343057", 2, new DateTime(2024, 9, 19, 0, 40, 7, 930, DateTimeKind.Unspecified).AddTicks(744), "Dolly_Hegmann" });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 14, 4, 4, 2, 643, DateTimeKind.Unspecified).AddTicks(3674), "gmail.com.Mayer79@hotmail.com", "Garland Zulauf", "ollizq", "0806481939", 2, new DateTime(2024, 9, 14, 4, 4, 2, 643, DateTimeKind.Unspecified).AddTicks(3674), "Waino69" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 2, 4, 31, 32, 325, DateTimeKind.Unspecified).AddTicks(191), "gmail.com_Wehner@yahoo.com", "Dorothy Witting", "ahioc4", "0194213497", new DateTime(2024, 9, 2, 4, 31, 32, 325, DateTimeKind.Unspecified).AddTicks(191), "Davon71" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 1, 1, 49, 5, 569, DateTimeKind.Unspecified).AddTicks(471), "gmail.com.Kohler@gmail.com", "Sigmund Swift", "6m1vgo", "0266929988", new DateTime(2024, 9, 1, 1, 49, 5, 569, DateTimeKind.Unspecified).AddTicks(471), "Lindsay93" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 39, 24, 846, DateTimeKind.Unspecified).AddTicks(9092), "gmail.com.Lebsack@gmail.com", "Alan Beahan", "a15tyg", "0282805895", new DateTime(2024, 9, 7, 13, 39, 24, 846, DateTimeKind.Unspecified).AddTicks(9092), "Hoyt_Casper" });

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
        }
    }
}
