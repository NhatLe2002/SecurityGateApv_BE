using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SecurityGateApv.Infras.Migrations
{
    /// <inheritdoc />
    public partial class SeedData_8 : Migration
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
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 1,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 6, "Excepturi a doloribus.", "Licensed Cotton Pants", 3 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 2,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 6, "Iste vel vitae quia rerum.", "Licensed Wooden Bacon", 3 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 3,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 4, "Excepturi odio aut impedit sapiente quis sunt rerum qui.", "Fantastic Wooden Bacon", 3 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 4,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 2, "Aperiam ea sapiente necessitatibus saepe minus est qui.", "Handcrafted Granite Bacon", 4 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 5,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 9, "Quidem illum neque voluptas commodi sit molestiae a rerum in.", "Refined Plastic Pizza", 2 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 6,
                columns: new[] { "DepartmentId", "Description", "Name" },
                values: new object[] { 10, "Et sint asperiores voluptas ut necessitatibus enim deleniti est.", "Intelligent Concrete Shirt" });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 7,
                columns: new[] { "DepartmentId", "Description", "Name" },
                values: new object[] { 7, "Consequatur eos totam perspiciatis cum eos explicabo.", "Handmade Cotton Bike" });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 8,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 3, "Dolores voluptas ut dicta dolores earum quis voluptates iste.", "Rustic Rubber Pants", 1 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 9,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 8, "Omnis repellendus vitae et in.", "Sleek Soft Salad", 5 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 10,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 5, "Ratione autem et omnis cumque.", "Generic Plastic Sausages", 1 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 11,
                columns: new[] { "DepartmentId", "Description", "Name" },
                values: new object[] { 9, "Totam qui corrupti.", "Tasty Soft Computer" });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 12,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 5, "Nihil dolor fugit ipsam aut natus.", "Handmade Steel Car", 5 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 13,
                columns: new[] { "DepartmentId", "Description", "Name" },
                values: new object[] { 9, "Maxime maxime modi doloremque assumenda exercitationem.", "Tasty Cotton Cheese" });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 14,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 3, "Quas esse aut et eligendi facilis laudantium iste.", "Gorgeous Soft Tuna", 1 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 15,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 10, "Sed non voluptas dolorum dolore dolores.", "Gorgeous Steel Keyboard", 3 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 16,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 7, "Illo voluptas deleniti dolorem libero dolores.", "Intelligent Concrete Fish", 2 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 17,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 10, "Et quia dolorem et eligendi et dolore modi beatae quaerat.", "Awesome Cotton Computer", 4 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 18,
                columns: new[] { "DepartmentId", "Description", "Name" },
                values: new object[] { 3, "Itaque dolores tempore et provident.", "Ergonomic Wooden Chips" });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 19,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 9, "Sint est alias tenetur facilis eveniet cupiditate.", "Practical Fresh Table", 4 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 20,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 6, "Temporibus molestiae ex.", "Handmade Cotton Sausages", 5 });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 9, 11, 1, 22, 191, DateTimeKind.Utc).AddTicks(8357), "Phòng R&D", "Laborum magni praesentium et veritatis mollitia qui eveniet.", new DateTime(2024, 9, 9, 11, 1, 22, 191, DateTimeKind.Utc).AddTicks(8357) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2024, 9, 17, 10, 55, 33, 810, DateTimeKind.Utc).AddTicks(5631), "Phòng Chăm sóc khách hàng", "Occaecati dolores ea cum nulla numquam.", new DateTime(2024, 9, 17, 10, 55, 33, 810, DateTimeKind.Utc).AddTicks(5631) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 4, new DateTime(2024, 9, 6, 9, 10, 14, 34, DateTimeKind.Utc).AddTicks(3713), "Phòng Kinh doanh", "Explicabo fugit eum eum laudantium ratione voluptatem quo.", new DateTime(2024, 9, 6, 9, 10, 14, 34, DateTimeKind.Utc).AddTicks(3713) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4,
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 10, 30, 12, 197, DateTimeKind.Utc).AddTicks(9466), "Phòng R&D", "Repellat eos nihil placeat eos id dolores.", new DateTime(2024, 9, 8, 10, 30, 12, 197, DateTimeKind.Utc).AddTicks(9466) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 4, new DateTime(2024, 9, 3, 15, 12, 42, 839, DateTimeKind.Utc).AddTicks(1667), "Phòng Sản xuất", "Impedit esse numquam officiis ipsum cum saepe est ratione.", new DateTime(2024, 9, 3, 15, 12, 42, 839, DateTimeKind.Utc).AddTicks(1667) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 6,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 2, 16, 1, 12, 567, DateTimeKind.Utc).AddTicks(3117), "Phòng Marketing", "Voluptas porro officia ipsa laborum aliquam cumque.", new DateTime(2024, 9, 2, 16, 1, 12, 567, DateTimeKind.Utc).AddTicks(3117) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 7,
                columns: new[] { "CreateDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 8, 31, 54, 675, DateTimeKind.Utc).AddTicks(1257), "Consequatur aut blanditiis consequatur quia assumenda odio repellendus vero.", new DateTime(2024, 9, 18, 8, 31, 54, 675, DateTimeKind.Utc).AddTicks(1257) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 8,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2024, 9, 15, 23, 52, 19, 474, DateTimeKind.Utc).AddTicks(1254), "Phòng Pháp chế", "Consequatur reprehenderit aperiam nobis veniam harum tenetur vel est.", new DateTime(2024, 9, 15, 23, 52, 19, 474, DateTimeKind.Utc).AddTicks(1254) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 9,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 4, 17, 56, 25, 939, DateTimeKind.Utc).AddTicks(2452), "Phòng Marketing", "Cum delectus nobis perferendis commodi dolores.", new DateTime(2024, 9, 4, 17, 56, 25, 939, DateTimeKind.Utc).AddTicks(2452) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 10,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 14, 13, 33, 26, 302, DateTimeKind.Utc).AddTicks(6813), "Phòng Marketing", "Suscipit consectetur sint consequatur.", new DateTime(2024, 9, 14, 13, 33, 26, 302, DateTimeKind.Utc).AddTicks(6813) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                columns: new[] { "CreateTime", "ProjectName" },
                values: new object[] { new DateTime(2024, 9, 16, 2, 25, 21, 126, DateTimeKind.Unspecified).AddTicks(9920), "Handcrafted Wooden Chicken" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                columns: new[] { "CreateTime", "ProjectName" },
                values: new object[] { new DateTime(2024, 9, 15, 8, 27, 40, 748, DateTimeKind.Unspecified).AddTicks(7721), "Handcrafted Granite Sausages" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                columns: new[] { "CreateTime", "ProjectName", "Status" },
                values: new object[] { new DateTime(2024, 9, 7, 9, 23, 36, 540, DateTimeKind.Unspecified).AddTicks(4358), "Sleek Steel Cheese", false });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4,
                columns: new[] { "CreateTime", "ProjectName" },
                values: new object[] { new DateTime(2024, 9, 5, 12, 40, 40, 43, DateTimeKind.Unspecified).AddTicks(5012), "Generic Soft Chips" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 5,
                columns: new[] { "CreateTime", "ProjectName", "Status" },
                values: new object[] { new DateTime(2024, 9, 12, 19, 5, 43, 698, DateTimeKind.Unspecified).AddTicks(682), "Handcrafted Fresh Chips", false });

            migrationBuilder.UpdateData(
                table: "Reasons",
                keyColumn: "ReasonId",
                keyValue: 1,
                columns: new[] { "Description", "ReasonName" },
                values: new object[] { "Iste mollitia ex.", "Refined Frozen Chips" });

            migrationBuilder.UpdateData(
                table: "Reasons",
                keyColumn: "ReasonId",
                keyValue: 2,
                columns: new[] { "Description", "ReasonName" },
                values: new object[] { "Vel in eos reiciendis expedita qui suscipit ut expedita fugiat.", "Rustic Soft Towels" });

            migrationBuilder.UpdateData(
                table: "Reasons",
                keyColumn: "ReasonId",
                keyValue: 3,
                columns: new[] { "Description", "ReasonName" },
                values: new object[] { "Hic sed molestias rerum laboriosam nisi sed quod.", "Small Metal Tuna" });

            migrationBuilder.UpdateData(
                table: "Reasons",
                keyColumn: "ReasonId",
                keyValue: 4,
                columns: new[] { "Description", "ReasonName" },
                values: new object[] { "Vero aut autem.", "Generic Granite Ball" });

            migrationBuilder.UpdateData(
                table: "Reasons",
                keyColumn: "ReasonId",
                keyValue: 5,
                columns: new[] { "Description", "ReasonName" },
                values: new object[] { "Fugiat nam amet dolores.", "Practical Concrete Bacon" });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 1,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 3, 19 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 2,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 6 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 3,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 3, 23 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 4,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 5,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 22 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 6,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 6 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 7,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 9 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 8,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 5, 17 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 9,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 5, 21 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 10,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 1 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 11,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 5, 21 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 12,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 24 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 13,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 1, 6 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 14,
                column: "UserId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 15,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 2, 11 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 16,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 2, 17 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 17,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 6, 21 });

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
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 20,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 9 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 21,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 3 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 22,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 23,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 6 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 24,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 4 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 25,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 22 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 26,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 2, 10 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 27,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 16 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 28,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 11 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 29,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 10 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 30,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 9 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 19, 6, 14, 21, 534, DateTimeKind.Utc).AddTicks(2828), new DateTime(2024, 9, 19, 6, 14, 21, 534, DateTimeKind.Utc).AddTicks(2835) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 19, 6, 14, 21, 534, DateTimeKind.Utc).AddTicks(2838), new DateTime(2024, 9, 19, 6, 14, 21, 534, DateTimeKind.Utc).AddTicks(2839) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 19, 6, 14, 21, 534, DateTimeKind.Utc).AddTicks(2841), new DateTime(2024, 9, 19, 6, 14, 21, 534, DateTimeKind.Utc).AddTicks(2841) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 19, 6, 14, 21, 534, DateTimeKind.Utc).AddTicks(2843), new DateTime(2024, 9, 19, 6, 14, 21, 534, DateTimeKind.Utc).AddTicks(2843) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 19, 6, 14, 21, 534, DateTimeKind.Utc).AddTicks(2845), new DateTime(2024, 9, 19, 6, 14, 21, 534, DateTimeKind.Utc).AddTicks(2845) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 4, 5, 21, 59, 816, DateTimeKind.Unspecified).AddTicks(6235), "gmail.com.Pfannerstill26@yahoo.com", "Tianna Morar", "z4p1x1", "0639717046", 1, new DateTime(2024, 9, 4, 5, 21, 59, 816, DateTimeKind.Unspecified).AddTicks(6235), "Colton_Bogisich" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 7, 8, 0, 35, 426, DateTimeKind.Unspecified).AddTicks(3586), "gmail.com75@yahoo.com", "Archibald Bashirian", "itgsqm", "0677018812", new DateTime(2024, 9, 7, 8, 0, 35, 426, DateTimeKind.Unspecified).AddTicks(3586), "Johnpaul.Murphy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 15, 2, 58, 23, 112, DateTimeKind.Unspecified).AddTicks(4428), "gmail.com.OKeefe@yahoo.com", "Joy Gutmann", "yu5xpw", "0136627500", 2, new DateTime(2024, 9, 15, 2, 58, 23, 112, DateTimeKind.Unspecified).AddTicks(4428), "Deron94" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 3, 21, 19, 17, 546, DateTimeKind.Unspecified).AddTicks(1055), "gmail.com.Willms@gmail.com", "Forrest Koss", "ooakrz", "0132140761", new DateTime(2024, 9, 3, 21, 19, 17, 546, DateTimeKind.Unspecified).AddTicks(1055), "Doyle_Vandervort33" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 16, 17, 18, 58, 501, DateTimeKind.Unspecified).AddTicks(789), "gmail.com.Mertz5@yahoo.com", "Emmitt Kulas", "386dr1", "0573363134", 1, new DateTime(2024, 9, 16, 17, 18, 58, 501, DateTimeKind.Unspecified).AddTicks(789), "Melany_Reynolds7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 1, 16, 57, 5, 910, DateTimeKind.Unspecified).AddTicks(7667), "gmail.com_Bechtelar53@yahoo.com", "Kenya Cartwright", "rv7chs", "0977068674", 4, new DateTime(2024, 9, 1, 16, 57, 5, 910, DateTimeKind.Unspecified).AddTicks(7667), "Alaina.Kilback87" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 12, 10, 59, 32, 813, DateTimeKind.Unspecified).AddTicks(8052), "gmail.com_Mueller@hotmail.com", "Emmett Cronin", "5v1nv7", "0507056976", new DateTime(2024, 9, 12, 10, 59, 32, 813, DateTimeKind.Unspecified).AddTicks(8052), "Keith.Kshlerin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 8, 12, 17, 31, 158, DateTimeKind.Unspecified).AddTicks(1285), "gmail.com.Grimes19@yahoo.com", "Hilton Gaylord", "dh8ctr", "0642083663", 1, new DateTime(2024, 9, 8, 12, 17, 31, 158, DateTimeKind.Unspecified).AddTicks(1285), "Rashad_Terry17" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 9, 13, 19, 19, 6, DateTimeKind.Unspecified).AddTicks(6596), "gmail.com.Koss74@hotmail.com", "Amir Schimmel", "69bayo", "0311867729", 1, new DateTime(2024, 9, 9, 13, 19, 19, 6, DateTimeKind.Unspecified).AddTicks(6596), "Tia_Kuphal" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 45, 9, 221, DateTimeKind.Unspecified).AddTicks(6610), "gmail.com.Denesik@hotmail.com", "Haleigh Emard", "m008e5", "0532596496", 5, new DateTime(2024, 9, 9, 16, 45, 9, 221, DateTimeKind.Unspecified).AddTicks(6610), "Brayan_Goodwin71" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 15, 18, 11, 36, 887, DateTimeKind.Unspecified).AddTicks(9894), "gmail.com13@yahoo.com", "Emile Runte", "y853yw", "0398748470", 5, new DateTime(2024, 9, 15, 18, 11, 36, 887, DateTimeKind.Unspecified).AddTicks(9894), "Jordan.Keebler72" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 17, 10, 16, 43, 658, DateTimeKind.Unspecified).AddTicks(3951), "gmail.com.Franecki@gmail.com", "Arnold Kling", "ym9w0m", "0697452871", 5, new DateTime(2024, 9, 17, 10, 16, 43, 658, DateTimeKind.Unspecified).AddTicks(3951), "Loraine_Glover" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 3, 9, 44, 43, 2, DateTimeKind.Unspecified).AddTicks(5951), "gmail.com.Hodkiewicz@yahoo.com", "America Conroy", "lb4nwt", "0878186267", 2, new DateTime(2024, 9, 3, 9, 44, 43, 2, DateTimeKind.Unspecified).AddTicks(5951), "Ora90" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 10, 7, 20, 44, 259, DateTimeKind.Unspecified).AddTicks(5716), "gmail.com.Collier@gmail.com", "Myah Metz", "xgv3ix", "0627783284", 3, new DateTime(2024, 9, 10, 7, 20, 44, 259, DateTimeKind.Unspecified).AddTicks(5716), "Kurtis.Ritchie91" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 6, 21, 35, 14, 893, DateTimeKind.Unspecified).AddTicks(3456), "gmail.com.Trantow@hotmail.com", "Armando Koss", "qyvq6n", "0176986915", 5, new DateTime(2024, 9, 6, 21, 35, 14, 893, DateTimeKind.Unspecified).AddTicks(3456), "Myrna_Boehm64" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 5, 17, 58, 47, 110, DateTimeKind.Unspecified).AddTicks(7961), "gmail.com.Bruen88@hotmail.com", "Collin Bashirian", "qpk87b", "0915617378", 1, new DateTime(2024, 9, 5, 17, 58, 47, 110, DateTimeKind.Unspecified).AddTicks(7961), "Benjamin34" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 2, 16, 8, 32, 765, DateTimeKind.Unspecified).AddTicks(5723), "gmail.com_Green74@yahoo.com", "Ezequiel Hansen", "q5no6q", "0366177050", 4, new DateTime(2024, 9, 2, 16, 8, 32, 765, DateTimeKind.Unspecified).AddTicks(5723), "Gene.Bartoletti84" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 8, 10, 14, 55, 311, DateTimeKind.Unspecified).AddTicks(5929), "gmail.com73@gmail.com", "Hillary Predovic", "p1ek63", "0318602712", 1, new DateTime(2024, 9, 8, 10, 14, 55, 311, DateTimeKind.Unspecified).AddTicks(5929), "Alysa75" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 17, 20, 41, 21, 335, DateTimeKind.Unspecified).AddTicks(722), "gmail.com.Emmerich26@gmail.com", "Henderson Huels", "0t1m3d", "0451636146", 3, new DateTime(2024, 9, 17, 20, 41, 21, 335, DateTimeKind.Unspecified).AddTicks(722), "Yoshiko_Treutel" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 15, 18, 51, 10, 323, DateTimeKind.Unspecified).AddTicks(2541), "gmail.com.Pagac@yahoo.com", "Alec Skiles", "m3yogp", "0382900756", 5, new DateTime(2024, 9, 15, 18, 51, 10, 323, DateTimeKind.Unspecified).AddTicks(2541), "Chance.Hermiston54" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 1,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Roob and Sons", new DateTime(2024, 9, 13, 8, 57, 0, 750, DateTimeKind.Unspecified).AddTicks(8347), "mjiql8i54v", "0438131737", false, new DateTime(2024, 9, 13, 8, 57, 0, 750, DateTimeKind.Unspecified).AddTicks(8347), "Marguerite Kozey" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 2,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Berge - Stiedemann", new DateTime(2024, 9, 17, 19, 48, 55, 280, DateTimeKind.Unspecified).AddTicks(3797), 1, "idxwcd1vr3", "0730906586", false, new DateTime(2024, 9, 17, 19, 48, 55, 280, DateTimeKind.Unspecified).AddTicks(3797), "Isabel Davis" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 3,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Tromp Inc", new DateTime(2024, 9, 11, 10, 23, 9, 113, DateTimeKind.Unspecified).AddTicks(2807), "4n9v2sgkmg", "0429779272", true, new DateTime(2024, 9, 11, 10, 23, 9, 113, DateTimeKind.Unspecified).AddTicks(2807), "David Baumbach" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 4,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Leannon Group", new DateTime(2024, 9, 13, 2, 30, 34, 473, DateTimeKind.Unspecified).AddTicks(5584), 2, "szmgogc5jq", "0169407332", false, new DateTime(2024, 9, 13, 2, 30, 34, 473, DateTimeKind.Unspecified).AddTicks(5584), "Cecile Abernathy" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 5,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Nicolas - Hudson", new DateTime(2024, 9, 11, 22, 16, 54, 213, DateTimeKind.Unspecified).AddTicks(550), "fcfx81lbm1", "0979985324", new DateTime(2024, 9, 11, 22, 16, 54, 213, DateTimeKind.Unspecified).AddTicks(550), "Noelia Terry" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 6,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Kassulke, Nicolas and Schmeler", new DateTime(2024, 9, 3, 15, 35, 51, 938, DateTimeKind.Unspecified).AddTicks(1237), 2, "tzb8x2yg5s", "0379351955", true, new DateTime(2024, 9, 3, 15, 35, 51, 938, DateTimeKind.Unspecified).AddTicks(1237), "Olin Crist" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 7,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Emard LLC", new DateTime(2024, 9, 17, 22, 6, 36, 393, DateTimeKind.Unspecified).AddTicks(1567), 2, "s78rfj5zrr", "0408108141", false, new DateTime(2024, 9, 17, 22, 6, 36, 393, DateTimeKind.Unspecified).AddTicks(1567), "Mackenzie Hackett" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 8,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Marks Group", new DateTime(2024, 9, 9, 20, 41, 7, 488, DateTimeKind.Unspecified).AddTicks(6287), "tfg9x3y9qj", "0164577087", new DateTime(2024, 9, 9, 20, 41, 7, 488, DateTimeKind.Unspecified).AddTicks(6287), "Lenora Altenwerth" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 9,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Dach, Langosh and Heidenreich", new DateTime(2024, 9, 17, 14, 8, 4, 770, DateTimeKind.Unspecified).AddTicks(7310), "ks2rkbzjcw", "0815508392", new DateTime(2024, 9, 17, 14, 8, 4, 770, DateTimeKind.Unspecified).AddTicks(7310), "Arno Hackett" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 10,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Bins LLC", new DateTime(2024, 9, 3, 5, 7, 39, 751, DateTimeKind.Unspecified).AddTicks(5483), 1, "y1a1ipugk4", "0103584779", new DateTime(2024, 9, 3, 5, 7, 39, 751, DateTimeKind.Unspecified).AddTicks(5483), "Heidi Hessel" });

            migrationBuilder.InsertData(
                table: "Visits",
                columns: new[] { "VisitId", "AcceptLevel", "CreateById", "DateRegister", "DepartmentReasonId", "UpdateById", "VisitQuantity" },
                values: new object[,]
                {
                    { 1, 3, 4, new DateTime(2024, 9, 17, 9, 39, 57, 486, DateTimeKind.Unspecified).AddTicks(5561), 5, 4, 2 },
                    { 2, 2, 4, new DateTime(2024, 9, 7, 13, 7, 31, 983, DateTimeKind.Unspecified).AddTicks(8732), 5, 4, 7 },
                    { 3, 1, 4, new DateTime(2024, 9, 13, 18, 59, 41, 21, DateTimeKind.Unspecified).AddTicks(5), 2, 4, 1 },
                    { 4, 1, 4, new DateTime(2024, 9, 9, 19, 48, 37, 190, DateTimeKind.Unspecified).AddTicks(8112), 5, 4, 4 },
                    { 5, 4, 4, new DateTime(2024, 9, 6, 8, 57, 58, 787, DateTimeKind.Unspecified).AddTicks(2753), 2, 4, 7 }
                });

            migrationBuilder.InsertData(
                table: "VisitDetails",
                columns: new[] { "VisitDetailId", "Description", "ExpectedTimeIn", "ExpectedTimeOut", "Status", "VisitDetailName", "VisitId", "VisitorId" },
                values: new object[,]
                {
                    { 1, "Est in sit doloribus eius officia quos. Minima autem rerum. Et voluptas non voluptate ratione est.", new DateTime(2025, 5, 19, 21, 27, 21, 765, DateTimeKind.Local).AddTicks(2665), new DateTime(2025, 2, 23, 17, 46, 54, 855, DateTimeKind.Local).AddTicks(2012), true, "Generic Granite Table", 3, 6 },
                    { 2, "Facilis enim nulla enim sit doloremque fuga nihil et sunt. Assumenda omnis odio fugit quaerat voluptates ipsam minus. Quaerat fugiat maiores praesentium natus incidunt consequatur quo et. Et ad iure.", new DateTime(2025, 2, 27, 6, 20, 36, 462, DateTimeKind.Local).AddTicks(7093), new DateTime(2025, 6, 1, 1, 23, 4, 344, DateTimeKind.Local).AddTicks(7484), true, "Handcrafted Wooden Fish", 2, 10 },
                    { 3, "Aperiam expedita id modi reprehenderit sapiente. Sunt reprehenderit iusto animi ut. Occaecati tenetur neque repellendus. Alias ea omnis illo. Consectetur voluptate consequuntur sint sit non delectus itaque tenetur adipisci. Est eos quia ut voluptatum consectetur.", new DateTime(2025, 9, 6, 3, 34, 39, 438, DateTimeKind.Local).AddTicks(984), new DateTime(2025, 1, 22, 6, 27, 55, 31, DateTimeKind.Local).AddTicks(2713), true, "Incredible Plastic Table", 5, 3 },
                    { 4, "Rem soluta dignissimos eos id quidem voluptatem est est in. Odit voluptatem atque laboriosam nihil in eum. Blanditiis ratione voluptatem excepturi id autem cupiditate. Culpa suscipit dolores doloribus rerum illo provident quia qui. Fugit velit sint autem est praesentium et harum. Hic error expedita veritatis ducimus.", new DateTime(2025, 9, 18, 15, 55, 15, 355, DateTimeKind.Local).AddTicks(9463), new DateTime(2025, 1, 2, 18, 18, 0, 192, DateTimeKind.Local).AddTicks(7799), false, "Incredible Frozen Sausages", 1, 4 },
                    { 5, "Ad voluptatum est ut nostrum eos iste cupiditate et velit. Ab expedita consequatur expedita quae quas exercitationem consequatur. Fugit doloribus ipsam aspernatur et veritatis quaerat a. Voluptas atque maiores et id.", new DateTime(2025, 8, 20, 16, 22, 17, 412, DateTimeKind.Local).AddTicks(8362), new DateTime(2025, 8, 11, 3, 10, 37, 12, DateTimeKind.Local).AddTicks(7941), false, "Awesome Granite Chips", 3, 10 },
                    { 6, "Velit et voluptatem molestiae sequi consectetur porro expedita quia. Veniam fugiat id harum et quo laboriosam omnis. Cupiditate occaecati ratione sapiente sunt id. Eius hic eligendi. Quis quia odit.", new DateTime(2025, 4, 24, 9, 22, 23, 775, DateTimeKind.Local).AddTicks(8092), new DateTime(2025, 5, 20, 5, 36, 20, 153, DateTimeKind.Local).AddTicks(9713), true, "Generic Cotton Shirt", 2, 4 },
                    { 7, "Facere est laboriosam quo. Id delectus sapiente veritatis temporibus ratione fugit. Voluptatem ex ab numquam cum et voluptas cupiditate aperiam alias. Veritatis eos possimus tempora. Velit enim deleniti neque. Quae nihil at culpa rerum.", new DateTime(2024, 12, 30, 16, 51, 25, 550, DateTimeKind.Local).AddTicks(8785), new DateTime(2025, 1, 1, 16, 13, 1, 30, DateTimeKind.Local).AddTicks(1942), true, "Awesome Steel Gloves", 3, 5 },
                    { 8, "Sit non iure quis in dicta in et itaque. Et enim soluta dolor quo molestiae rerum. Est dolores id perspiciatis. Ipsam quidem porro voluptatem cupiditate repudiandae itaque aut. Eos optio fugiat. Velit maiores ut.", new DateTime(2025, 8, 24, 18, 40, 9, 993, DateTimeKind.Local).AddTicks(5343), new DateTime(2025, 4, 9, 12, 29, 26, 230, DateTimeKind.Local).AddTicks(3098), true, "Unbranded Frozen Bike", 2, 1 },
                    { 9, "Odit et dolorem asperiores sapiente neque architecto ea nisi et. Quos eius ut dolorem dolorem ut. Repudiandae provident dicta similique amet corrupti eos consectetur aut maxime. Illo quidem voluptatibus.", new DateTime(2025, 9, 1, 15, 8, 43, 990, DateTimeKind.Local).AddTicks(6744), new DateTime(2025, 8, 21, 0, 39, 35, 370, DateTimeKind.Local).AddTicks(605), false, "Unbranded Metal Pizza", 4, 3 },
                    { 10, "Nesciunt accusamus quo qui sed qui adipisci explicabo voluptatem. Commodi natus sunt nesciunt. Officia maxime in porro ab inventore vitae aut. Sequi deleniti voluptas ut placeat. Earum culpa qui quia. Impedit inventore doloribus quod aut beatae laudantium dolor nam architecto.", new DateTime(2025, 9, 16, 21, 19, 42, 823, DateTimeKind.Local).AddTicks(5501), new DateTime(2025, 9, 3, 1, 42, 39, 839, DateTimeKind.Local).AddTicks(5750), true, "Practical Soft Chips", 1, 2 }
                });
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
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "CredentialCardTypes",
                keyColumn: "CredentialCardTypeId",
                keyValue: 2,
                column: "CredentialCardTypeName",
                value: "Căn cước công dân");

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
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 4, "Praesentium sed sapiente ut corrupti consequatur non dignissimos voluptas.", "Gorgeous Concrete Gloves", 5 });

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
                columns: new[] { "DepartmentId", "Description", "Name" },
                values: new object[] { 4, "Minus sed fuga officiis temporibus aut tempora ut sit quo.", "Rustic Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 7,
                columns: new[] { "DepartmentId", "Description", "Name" },
                values: new object[] { 8, "Reprehenderit consequuntur ea inventore voluptatibus quia quaerat.", "Small Rubber Computer" });

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
                columns: new[] { "DepartmentId", "Description", "Name" },
                values: new object[] { 3, "Veniam sunt iusto quo rerum ut reprehenderit sunt tenetur placeat.", "Incredible Plastic Pizza" });

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
                columns: new[] { "DepartmentId", "Description", "Name" },
                values: new object[] { 2, "Autem iusto at maxime fugiat id.", "Unbranded Steel Pizza" });

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
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 1, "Natus numquam sapiente et beatae ipsum sint debitis expedita.", "Small Frozen Chips", 3 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 18,
                columns: new[] { "DepartmentId", "Description", "Name" },
                values: new object[] { 8, "Aut quis ut ut.", "Tasty Fresh Bike" });

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
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 10, 20, 42, 32, 528, DateTimeKind.Utc).AddTicks(586), "Phòng Kế toán", "Beatae voluptatem ullam porro et optio.", new DateTime(2024, 9, 10, 20, 42, 32, 528, DateTimeKind.Utc).AddTicks(586) });

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
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 12, 14, 57, 43, 322, DateTimeKind.Utc).AddTicks(194), "Phòng Hành chính", "Exercitationem maiores inventore aliquam ullam eum et.", new DateTime(2024, 9, 12, 14, 57, 43, 322, DateTimeKind.Utc).AddTicks(194) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 7,
                columns: new[] { "CreateDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 8, 15, 47, 19, 689, DateTimeKind.Utc).AddTicks(1622), "Labore consequatur ut autem esse labore.", new DateTime(2024, 9, 8, 15, 47, 19, 689, DateTimeKind.Utc).AddTicks(1622) });

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
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 6, 1, 57, 6, 697, DateTimeKind.Utc).AddTicks(5916), "Phòng Nhân sự", "Rem pariatur voluptatem voluptatem harum temporibus aliquam quibusdam velit.", new DateTime(2024, 9, 6, 1, 57, 6, 697, DateTimeKind.Utc).AddTicks(5916) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                columns: new[] { "CreateTime", "ProjectName" },
                values: new object[] { new DateTime(2024, 9, 11, 0, 30, 58, 134, DateTimeKind.Unspecified).AddTicks(3836), "Practical Steel Towels" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                columns: new[] { "CreateTime", "ProjectName" },
                values: new object[] { new DateTime(2024, 9, 15, 7, 40, 47, 921, DateTimeKind.Unspecified).AddTicks(1512), "Awesome Fresh Pants" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                columns: new[] { "CreateTime", "ProjectName", "Status" },
                values: new object[] { new DateTime(2024, 9, 3, 23, 1, 28, 23, DateTimeKind.Unspecified).AddTicks(5312), "Handcrafted Rubber Soap", true });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4,
                columns: new[] { "CreateTime", "ProjectName" },
                values: new object[] { new DateTime(2024, 9, 2, 0, 29, 40, 568, DateTimeKind.Unspecified).AddTicks(1793), "Ergonomic Granite Mouse" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 5,
                columns: new[] { "CreateTime", "ProjectName", "Status" },
                values: new object[] { new DateTime(2024, 9, 18, 8, 2, 27, 742, DateTimeKind.Unspecified).AddTicks(4526), "Fantastic Cotton Tuna", true });

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
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 4, 19 });

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
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 2 });

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
                column: "UserId",
                value: 14);

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
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 10, 11 });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 18, 3, 12, 29, 616, DateTimeKind.Unspecified).AddTicks(2783), "gmail.com_Runolfsson7@hotmail.com", "Khalid Klein", "ooofx7", "0527926609", 2, new DateTime(2024, 9, 18, 3, 12, 29, 616, DateTimeKind.Unspecified).AddTicks(2783), "Elva54" });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 1, 11, 56, 48, 565, DateTimeKind.Unspecified).AddTicks(3492), "gmail.com_Haley@gmail.com", "Emmett Paucek", "icdxzr", "0568190871", 4, new DateTime(2024, 9, 1, 11, 56, 48, 565, DateTimeKind.Unspecified).AddTicks(3492), "Addie_Greenholt70" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 14, 21, 47, 6, 428, DateTimeKind.Unspecified).AddTicks(648), "gmail.com_Jones97@hotmail.com", "Lorine Gorczany", "af6leg", "0904913235", new DateTime(2024, 9, 14, 21, 47, 6, 428, DateTimeKind.Unspecified).AddTicks(648), "Declan_Maggio98" });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 3, 13, 43, 24, 251, DateTimeKind.Unspecified).AddTicks(2312), "gmail.com4@yahoo.com", "Sophie Predovic", "8mt40z", "0776485118", 4, new DateTime(2024, 9, 3, 13, 43, 24, 251, DateTimeKind.Unspecified).AddTicks(2312), "Verna.Swift" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 12, 9, 48, 16, 533, DateTimeKind.Unspecified).AddTicks(5409), "gmail.com74@hotmail.com", "Afton Jacobs", "602k7i", "0655747313", 2, new DateTime(2024, 9, 12, 9, 48, 16, 533, DateTimeKind.Unspecified).AddTicks(5409), "Kennedi_Bode22" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 19, 38, 899, DateTimeKind.Unspecified).AddTicks(9761), "gmail.com9@hotmail.com", "Sarai Rolfson", "0l2xpi", "0680949617", 2, new DateTime(2024, 9, 2, 17, 19, 38, 899, DateTimeKind.Unspecified).AddTicks(9761), "Stephany89" });

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

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 1,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Beahan Inc", new DateTime(2024, 9, 9, 5, 56, 48, 112, DateTimeKind.Unspecified).AddTicks(1378), "chpvacllr1", "0959243904", true, new DateTime(2024, 9, 9, 5, 56, 48, 112, DateTimeKind.Unspecified).AddTicks(1378), "Kathleen Zemlak" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 2,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Lesch, Torp and Bosco", new DateTime(2024, 9, 12, 11, 39, 35, 698, DateTimeKind.Unspecified).AddTicks(2522), 2, "62j7y5lmbt", "0759401056", true, new DateTime(2024, 9, 12, 11, 39, 35, 698, DateTimeKind.Unspecified).AddTicks(2522), "Ayden Yundt" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 3,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Rau - Feeney", new DateTime(2024, 9, 17, 3, 41, 46, 16, DateTimeKind.Unspecified).AddTicks(4570), "me80xz44wh", "0529873894", false, new DateTime(2024, 9, 17, 3, 41, 46, 16, DateTimeKind.Unspecified).AddTicks(4570), "Armani Wolff" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 4,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Kunde - Greenfelder", new DateTime(2024, 9, 1, 1, 36, 35, 997, DateTimeKind.Unspecified).AddTicks(248), 1, "mo8p2vv38t", "0391337578", true, new DateTime(2024, 9, 1, 1, 36, 35, 997, DateTimeKind.Unspecified).AddTicks(248), "Bethel Mohr" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 5,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Mitchell - Bayer", new DateTime(2024, 9, 2, 6, 32, 56, 904, DateTimeKind.Unspecified).AddTicks(8861), "tok2rit1tn", "0585198803", new DateTime(2024, 9, 2, 6, 32, 56, 904, DateTimeKind.Unspecified).AddTicks(8861), "Wilton DuBuque" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 6,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Bednar Group", new DateTime(2024, 9, 6, 11, 16, 34, 897, DateTimeKind.Unspecified).AddTicks(4735), 1, "zxksdwyp3x", "0851739853", false, new DateTime(2024, 9, 6, 11, 16, 34, 897, DateTimeKind.Unspecified).AddTicks(4735), "Derrick Rolfson" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 7,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Schimmel and Sons", new DateTime(2024, 9, 7, 8, 35, 37, 984, DateTimeKind.Unspecified).AddTicks(1137), 1, "pvmzahewxy", "0511536460", true, new DateTime(2024, 9, 7, 8, 35, 37, 984, DateTimeKind.Unspecified).AddTicks(1137), "Nasir Littel" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 8,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Conn, Ernser and Fadel", new DateTime(2024, 9, 9, 13, 24, 32, 593, DateTimeKind.Unspecified).AddTicks(2866), "sz0sxxh2vr", "0143258434", new DateTime(2024, 9, 9, 13, 24, 32, 593, DateTimeKind.Unspecified).AddTicks(2866), "Alia Osinski" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 9,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Ledner, Daugherty and Bayer", new DateTime(2024, 9, 10, 16, 20, 30, 20, DateTimeKind.Unspecified).AddTicks(9948), "9hmba295wj", "0583409318", new DateTime(2024, 9, 10, 16, 20, 30, 20, DateTimeKind.Unspecified).AddTicks(9948), "Toney Haley" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 10,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Nolan - Langosh", new DateTime(2024, 9, 15, 12, 38, 54, 276, DateTimeKind.Unspecified).AddTicks(1227), 2, "ly07btyrrc", "0889509949", new DateTime(2024, 9, 15, 12, 38, 54, 276, DateTimeKind.Unspecified).AddTicks(1227), "Bernardo Hettinger" });
        }
    }
}
