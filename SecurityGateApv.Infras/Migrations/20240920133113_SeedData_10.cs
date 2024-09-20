using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecurityGateApv.Infras.Migrations
{
    /// <inheritdoc />
    public partial class SeedData_10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VisitorSessions_Gates_GateId",
                table: "VisitorSessions");

            migrationBuilder.DropForeignKey(
                name: "FK_VisitorSessions_Users_SecurityID",
                table: "VisitorSessions");

            migrationBuilder.RenameColumn(
                name: "SecurityID",
                table: "VisitorSessions",
                newName: "SecurityInId");

            migrationBuilder.RenameColumn(
                name: "GateId",
                table: "VisitorSessions",
                newName: "GateInId");

            migrationBuilder.RenameIndex(
                name: "IX_VisitorSessions_SecurityID",
                table: "VisitorSessions",
                newName: "IX_VisitorSessions_SecurityInId");

            migrationBuilder.RenameIndex(
                name: "IX_VisitorSessions_GateId",
                table: "VisitorSessions",
                newName: "IX_VisitorSessions_GateInId");

            migrationBuilder.AddColumn<int>(
                name: "GateOutId",
                table: "VisitorSessions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SecurityOutId",
                table: "VisitorSessions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "VisitorSessions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 1,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 1, "Possimus eum fugit harum debitis unde qui sit dignissimos sed.", "Small Granite Chips", 1 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 2,
                columns: new[] { "Description", "Name", "ReasonId" },
                values: new object[] { "Sunt saepe eos in.", "Unbranded Plastic Ball", 5 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 3,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 1, "Tenetur voluptas repudiandae ex.", "Fantastic Concrete Gloves", 5 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 4,
                columns: new[] { "DepartmentId", "Description", "Name" },
                values: new object[] { 3, "Voluptatem ipsam explicabo veritatis placeat autem corrupti.", "Small Rubber Shoes" });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 5,
                columns: new[] { "DepartmentId", "Description", "Name" },
                values: new object[] { 6, "Sed voluptas nemo est vel porro enim commodi aliquam corrupti.", "Handmade Fresh Gloves" });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 6,
                columns: new[] { "Description", "Name", "ReasonId" },
                values: new object[] { "Molestiae exercitationem vitae ea fugit tempore magni ut a.", "Ergonomic Granite Towels", 1 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 7,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 6, "Maxime quod aut dolorem.", "Small Cotton Fish", 4 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 8,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 5, "Quis totam non distinctio harum a voluptatibus voluptas qui molestiae.", "Intelligent Metal Car", 4 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 9,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 5, "Occaecati sequi natus cupiditate neque qui aut aut.", "Intelligent Soft Chair", 1 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 10,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 5, "Aut sunt consequatur et ut.", "Awesome Fresh Salad", 3 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 11,
                columns: new[] { "DepartmentId", "Description", "Name" },
                values: new object[] { 3, "Saepe saepe consequatur error perferendis facilis sit sit ad aperiam.", "Generic Fresh Chair" });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 12,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 4, "Cum non et quaerat eius.", "Licensed Soft Mouse", 5 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 13,
                columns: new[] { "DepartmentId", "Description", "Name" },
                values: new object[] { 9, "Et voluptas esse velit ut excepturi.", "Practical Concrete Keyboard" });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 14,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 6, "Eaque maxime aut possimus ut sint.", "Handmade Steel Fish", 1 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 15,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 9, "Iure soluta et expedita in facere unde sint quae culpa.", "Practical Cotton Pizza", 5 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 16,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 6, "Qui illum quidem repellat qui.", "Intelligent Metal Tuna", 4 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 17,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 3, "Dolore ut iusto asperiores assumenda quam.", "Refined Metal Computer", 1 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 18,
                columns: new[] { "DepartmentId", "Description", "Name" },
                values: new object[] { 9, "Autem aperiam dolores dolorum at nulla temporibus.", "Sleek Steel Chair" });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 19,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 5, "Temporibus et est praesentium id ea.", "Incredible Granite Pizza", 4 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 20,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 7, "Eaque vitae maiores occaecati pariatur dolorum ullam.", "Refined Fresh Hat", 2 });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 9, 3, 3, 24, 58, 272, DateTimeKind.Utc).AddTicks(5537), "Phòng Chăm sóc khách hàng", "Doloribus saepe non et.", new DateTime(2024, 9, 3, 3, 24, 58, 272, DateTimeKind.Utc).AddTicks(5537) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 14, 7, 54, 11, 975, DateTimeKind.Utc).AddTicks(5368), "Phòng R&D", "Voluptatem sit tempora iure possimus tenetur exercitationem laudantium dignissimos.", new DateTime(2024, 9, 14, 7, 54, 11, 975, DateTimeKind.Utc).AddTicks(5368) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 2, 11, 10, 720, DateTimeKind.Utc).AddTicks(5675), "Phòng Sản xuất", "Dicta tempore magni est est iure.", new DateTime(2024, 9, 12, 2, 11, 10, 720, DateTimeKind.Utc).AddTicks(5675) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4,
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 14, 10, 52, 5, 257, DateTimeKind.Utc).AddTicks(1465), "Phòng Marketing", "Minima quos sapiente in sit voluptatem.", new DateTime(2024, 9, 14, 10, 52, 5, 257, DateTimeKind.Utc).AddTicks(1465) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 17, 10, 8, 12, 913, DateTimeKind.Utc).AddTicks(1825), "Phòng Sản xuất", "Et et laudantium aut vel est aspernatur eos.", new DateTime(2024, 9, 17, 10, 8, 12, 913, DateTimeKind.Utc).AddTicks(1825) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 6,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2024, 9, 14, 4, 50, 36, 589, DateTimeKind.Utc).AddTicks(4797), "Phòng Kế toán", "Facilis sed dolorem.", new DateTime(2024, 9, 14, 4, 50, 36, 589, DateTimeKind.Utc).AddTicks(4797) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 7,
                columns: new[] { "AcceptLevel", "CreateDate", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 16, 2, 32, 55, 679, DateTimeKind.Utc).AddTicks(8436), "Labore aspernatur autem dolores veritatis voluptas deleniti quod.", new DateTime(2024, 9, 16, 2, 32, 55, 679, DateTimeKind.Utc).AddTicks(8436) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 8,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 9, 9, 21, 13, 38, 907, DateTimeKind.Utc).AddTicks(508), "Phòng Pháp chế", "Quidem illum ipsum repellendus earum quis.", new DateTime(2024, 9, 9, 21, 13, 38, 907, DateTimeKind.Utc).AddTicks(508) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 9,
                columns: new[] { "CreateDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 5, 1, 48, 13, 832, DateTimeKind.Utc).AddTicks(4632), "Saepe sunt iusto at quaerat ipsa occaecati eos maxime asperiores.", new DateTime(2024, 9, 5, 1, 48, 13, 832, DateTimeKind.Utc).AddTicks(4632) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 10,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 4, new DateTime(2024, 9, 17, 9, 46, 18, 768, DateTimeKind.Utc).AddTicks(187), "Phòng Kinh doanh", "Et inventore qui totam velit.", new DateTime(2024, 9, 17, 9, 46, 18, 768, DateTimeKind.Utc).AddTicks(187) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                columns: new[] { "CreateTime", "ProjectName" },
                values: new object[] { new DateTime(2024, 9, 19, 0, 51, 55, 470, DateTimeKind.Unspecified).AddTicks(3766), "Gorgeous Wooden Pizza" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                columns: new[] { "CreateTime", "ProjectName", "Status" },
                values: new object[] { new DateTime(2024, 9, 11, 19, 10, 35, 631, DateTimeKind.Unspecified).AddTicks(5264), "Small Metal Keyboard", false });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                columns: new[] { "CreateTime", "ProjectName" },
                values: new object[] { new DateTime(2024, 9, 15, 1, 25, 1, 969, DateTimeKind.Unspecified).AddTicks(2034), "Incredible Granite Towels" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4,
                columns: new[] { "CreateTime", "ProjectName", "Status" },
                values: new object[] { new DateTime(2024, 9, 19, 8, 1, 40, 192, DateTimeKind.Unspecified).AddTicks(4225), "Incredible Concrete Pizza", false });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 5,
                columns: new[] { "CreateTime", "ProjectName" },
                values: new object[] { new DateTime(2024, 9, 3, 23, 12, 59, 211, DateTimeKind.Unspecified).AddTicks(8372), "Intelligent Plastic Sausages" });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 1,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("b5ac846e-5635-4d52-a03c-84b264e2fe55"), new DateTime(2024, 9, 20, 20, 31, 13, 126, DateTimeKind.Local).AddTicks(5529), new DateTime(2024, 10, 20, 20, 31, 13, 126, DateTimeKind.Local).AddTicks(5529) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 2,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("1fb7d064-9030-4a22-b2b0-931190d91ce0"), new DateTime(2024, 9, 20, 20, 31, 13, 126, DateTimeKind.Local).AddTicks(5838), new DateTime(2024, 10, 20, 20, 31, 13, 126, DateTimeKind.Local).AddTicks(5838) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 3,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId" },
                values: new object[] { new Guid("f967afd5-dbb6-4463-ae95-1a1a0cf9c525"), new DateTime(2024, 9, 20, 20, 31, 13, 126, DateTimeKind.Local).AddTicks(5851), new DateTime(2024, 10, 20, 20, 31, 13, 126, DateTimeKind.Local).AddTicks(5851), 1 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 4,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("c98fae66-6ac9-4480-96f9-ec55e7200646"), new DateTime(2024, 9, 20, 20, 31, 13, 126, DateTimeKind.Local).AddTicks(5859), new DateTime(2024, 10, 20, 20, 31, 13, 126, DateTimeKind.Local).AddTicks(5859) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 5,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("07c7cfdf-0d73-4ea5-b6bf-90f04cc40052"), new DateTime(2024, 9, 20, 20, 31, 13, 126, DateTimeKind.Local).AddTicks(5867), new DateTime(2024, 10, 20, 20, 31, 13, 126, DateTimeKind.Local).AddTicks(5867) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 6,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId", "QRCardTypeId" },
                values: new object[] { new Guid("18c45d89-22d6-465c-9ae1-07b54a651954"), new DateTime(2024, 9, 20, 20, 31, 13, 126, DateTimeKind.Local).AddTicks(5875), new DateTime(2024, 10, 20, 20, 31, 13, 126, DateTimeKind.Local).AddTicks(5875), 2, 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 7,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId", "QRCardTypeId" },
                values: new object[] { new Guid("42acc0b2-2dad-45ed-8b7b-d4fcfc720d52"), new DateTime(2024, 9, 20, 20, 31, 13, 126, DateTimeKind.Local).AddTicks(5895), new DateTime(2024, 10, 20, 20, 31, 13, 126, DateTimeKind.Local).AddTicks(5895), 1, 1 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 8,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId", "QRCardTypeId" },
                values: new object[] { new Guid("9cdddf5e-0b42-41b0-90b4-c52901505cd9"), new DateTime(2024, 9, 20, 20, 31, 13, 126, DateTimeKind.Local).AddTicks(5902), new DateTime(2024, 10, 20, 20, 31, 13, 126, DateTimeKind.Local).AddTicks(5902), 1, 1 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 9,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("64eb06bd-f98c-4de1-9c2a-bfcd9ffb02a3"), new DateTime(2024, 9, 20, 20, 31, 13, 126, DateTimeKind.Local).AddTicks(5910), new DateTime(2024, 10, 20, 20, 31, 13, 126, DateTimeKind.Local).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 10,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId", "QRCardTypeId" },
                values: new object[] { new Guid("9bf6d36f-1e94-4a2d-88a2-341358c84b8a"), new DateTime(2024, 9, 20, 20, 31, 13, 126, DateTimeKind.Local).AddTicks(5917), new DateTime(2024, 10, 20, 20, 31, 13, 126, DateTimeKind.Local).AddTicks(5917), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Reasons",
                keyColumn: "ReasonId",
                keyValue: 1,
                columns: new[] { "Description", "ReasonName" },
                values: new object[] { "Et itaque sunt voluptate voluptatem.", "Refined Fresh Shirt" });

            migrationBuilder.UpdateData(
                table: "Reasons",
                keyColumn: "ReasonId",
                keyValue: 2,
                columns: new[] { "Description", "ReasonName" },
                values: new object[] { "Ut corporis labore.", "Handcrafted Fresh Salad" });

            migrationBuilder.UpdateData(
                table: "Reasons",
                keyColumn: "ReasonId",
                keyValue: 3,
                columns: new[] { "Description", "ReasonName" },
                values: new object[] { "Ipsum incidunt sit consequatur.", "Fantastic Frozen Fish" });

            migrationBuilder.UpdateData(
                table: "Reasons",
                keyColumn: "ReasonId",
                keyValue: 4,
                columns: new[] { "Description", "ReasonName" },
                values: new object[] { "Fuga omnis placeat magni est iusto dolores provident libero.", "Unbranded Wooden Salad" });

            migrationBuilder.UpdateData(
                table: "Reasons",
                keyColumn: "ReasonId",
                keyValue: 5,
                columns: new[] { "Description", "ReasonName" },
                values: new object[] { "Repellat consectetur ad sed id aut.", "Tasty Metal Table" });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 1,
                column: "UserId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 2,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 6, 6 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 3,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 20 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 4,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 9 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 5,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 17 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 6,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 2, 16 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 7,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 3, 16 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 8,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 11 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 9,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 20 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 10,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 10, 17 });

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
                values: new object[] { 6, 15 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 13,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 2 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 14,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 24 });

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
                values: new object[] { 7, 18 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 17,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 10, 19 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 18,
                column: "UserId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 19,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 4, 17 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 20,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 4, 14 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 21,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 10, 15 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 22,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 10, 21 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 23,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 3, 10 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 24,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 10 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 25,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 10, 9 });

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
                values: new object[] { 10, 17 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 28,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 6 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 29,
                column: "UserId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 30,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 10, 19 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 20, 13, 31, 13, 107, DateTimeKind.Utc).AddTicks(5434), new DateTime(2024, 9, 20, 13, 31, 13, 107, DateTimeKind.Utc).AddTicks(5442) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 13, 31, 13, 107, DateTimeKind.Utc).AddTicks(5445), new DateTime(2024, 9, 20, 13, 31, 13, 107, DateTimeKind.Utc).AddTicks(5445) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 20, 13, 31, 13, 107, DateTimeKind.Utc).AddTicks(5447), new DateTime(2024, 9, 20, 13, 31, 13, 107, DateTimeKind.Utc).AddTicks(5447) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 31, 13, 107, DateTimeKind.Utc).AddTicks(5449), new DateTime(2024, 9, 20, 13, 31, 13, 107, DateTimeKind.Utc).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 20, 13, 31, 13, 107, DateTimeKind.Utc).AddTicks(5451), new DateTime(2024, 9, 20, 13, 31, 13, 107, DateTimeKind.Utc).AddTicks(5452) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 17, 22, 41, 53, 373, DateTimeKind.Unspecified).AddTicks(3108), "gmail.com_Kuhn46@hotmail.com", "Ebony Ward", "jiafxl", "0386472083", 4, new DateTime(2024, 9, 17, 22, 41, 53, 373, DateTimeKind.Unspecified).AddTicks(3108), "Valentine.Runolfsson" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 17, 3, 16, 29, 940, DateTimeKind.Unspecified).AddTicks(6637), "gmail.com_Murazik@yahoo.com", "Julian Price", "vw223v", "0632256349", new DateTime(2024, 9, 17, 3, 16, 29, 940, DateTimeKind.Unspecified).AddTicks(6637), "Adalberto61" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 6, 11, 18, 17, 596, DateTimeKind.Unspecified).AddTicks(2785), "gmail.com76@yahoo.com", "Mary Boehm", "lo9t10", "0210030197", 1, new DateTime(2024, 9, 6, 11, 18, 17, 596, DateTimeKind.Unspecified).AddTicks(2785), "Jazlyn8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 14, 14, 46, 37, 833, DateTimeKind.Unspecified).AddTicks(9567), "gmail.com_Roberts@hotmail.com", "Karlie Lindgren", "o95323", "0759399387", 3, new DateTime(2024, 9, 14, 14, 46, 37, 833, DateTimeKind.Unspecified).AddTicks(9567), "Lesly91" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 15, 11, 6, 50, 611, DateTimeKind.Unspecified).AddTicks(4239), "gmail.com_Brakus1@hotmail.com", "Giuseppe Stamm", "ljbbux", "0322867257", 3, new DateTime(2024, 9, 15, 11, 6, 50, 611, DateTimeKind.Unspecified).AddTicks(4239), "Madyson.Botsford1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 2, 5, 32, 2, 509, DateTimeKind.Unspecified).AddTicks(1465), "gmail.com.Prosacco39@yahoo.com", "Coty Baumbach", "k57v02", "0465731781", 1, new DateTime(2024, 9, 2, 5, 32, 2, 509, DateTimeKind.Unspecified).AddTicks(1465), "Rashad.Frami" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 15, 20, 26, 50, 295, DateTimeKind.Unspecified).AddTicks(5937), "gmail.com_Reichel20@yahoo.com", "Gregg Smitham", "ie0l7m", "0187824268", 5, new DateTime(2024, 9, 15, 20, 26, 50, 295, DateTimeKind.Unspecified).AddTicks(5937), "Keyshawn.Mayer29" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 4, 19, 21, 11, 901, DateTimeKind.Unspecified).AddTicks(4714), "gmail.com67@yahoo.com", "Harvey Will", "5m6fef", "0102510450", new DateTime(2024, 9, 4, 19, 21, 11, 901, DateTimeKind.Unspecified).AddTicks(4714), "Neal98" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 4, 21, 26, 10, 741, DateTimeKind.Unspecified).AddTicks(7537), "gmail.com_Ankunding53@gmail.com", "Arnaldo Batz", "gl52mo", "0223161036", 4, new DateTime(2024, 9, 4, 21, 26, 10, 741, DateTimeKind.Unspecified).AddTicks(7537), "Braxton_Walker" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 10, 11, 46, 14, 77, DateTimeKind.Unspecified).AddTicks(6760), "gmail.com.Kunde@gmail.com", "Adelle Zulauf", "cbqhj2", "0291645746", 5, new DateTime(2024, 9, 10, 11, 46, 14, 77, DateTimeKind.Unspecified).AddTicks(6760), "Fatima35" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 18, 23, 51, 31, 865, DateTimeKind.Unspecified).AddTicks(7017), "gmail.com65@yahoo.com", "Franco Fritsch", "pry80h", "0812212460", 3, new DateTime(2024, 9, 18, 23, 51, 31, 865, DateTimeKind.Unspecified).AddTicks(7017), "Kathlyn.Hintz" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 11, 14, 15, 40, 398, DateTimeKind.Unspecified).AddTicks(1352), "gmail.com.Barton91@yahoo.com", "Deangelo Morar", "r3hgmp", "0121599493", 4, new DateTime(2024, 9, 11, 14, 15, 40, 398, DateTimeKind.Unspecified).AddTicks(1352), "Noelia.McLaughlin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 17, 2, 15, 12, 507, DateTimeKind.Unspecified).AddTicks(8222), "gmail.com_Strosin@gmail.com", "Cletus Wyman", "jny220", "0605142838", 3, new DateTime(2024, 9, 17, 2, 15, 12, 507, DateTimeKind.Unspecified).AddTicks(8222), "Shana.Wisoky60" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 4, 8, 9, 55, 317, DateTimeKind.Unspecified).AddTicks(3467), "gmail.com_Weimann@hotmail.com", "Buck Ullrich", "2sby6h", "0314180521", 1, new DateTime(2024, 9, 4, 8, 9, 55, 317, DateTimeKind.Unspecified).AddTicks(3467), "Veronica_Torp23" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 16, 16, 49, 6, 10, DateTimeKind.Unspecified).AddTicks(4104), "gmail.com.Rath82@yahoo.com", "Claude Mayer", "j14mdc", "0834050665", 2, new DateTime(2024, 9, 16, 16, 49, 6, 10, DateTimeKind.Unspecified).AddTicks(4104), "Giovanny_Hayes93" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 13, 9, 4, 55, 913, DateTimeKind.Unspecified).AddTicks(378), "gmail.com_Feeney@hotmail.com", "Adrian Dach", "ljgl3c", "0936366957", 1, new DateTime(2024, 9, 13, 9, 4, 55, 913, DateTimeKind.Unspecified).AddTicks(378), "Jessica_Kiehn30" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 11, 18, 43, 44, 960, DateTimeKind.Unspecified).AddTicks(6439), "gmail.com_Turcotte72@gmail.com", "Augustus Lakin", "vedujm", "0436094886", 1, new DateTime(2024, 9, 11, 18, 43, 44, 960, DateTimeKind.Unspecified).AddTicks(6439), "Hobart.Christiansen" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 15, 11, 5, 47, 42, DateTimeKind.Unspecified).AddTicks(2717), "gmail.com_Ankunding88@hotmail.com", "Jasen Hagenes", "woy4al", "0588169454", 2, new DateTime(2024, 9, 15, 11, 5, 47, 42, DateTimeKind.Unspecified).AddTicks(2717), "Trevion_Cormier72" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 18, 12, 23, 26, 717, DateTimeKind.Unspecified).AddTicks(8348), "gmail.com48@yahoo.com", "Evert O'Connell", "ygraur", "0206421415", new DateTime(2024, 9, 18, 12, 23, 26, 717, DateTimeKind.Unspecified).AddTicks(8348), "Lexie_Kozey" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 4, 17, 53, 59, 76, DateTimeKind.Unspecified).AddTicks(6149), "gmail.com.Crooks50@yahoo.com", "Ubaldo Fisher", "p3l9cn", "0806005067", new DateTime(2024, 9, 4, 17, 53, 59, 76, DateTimeKind.Unspecified).AddTicks(6149), "Napoleon.Maggio" });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 1,
                columns: new[] { "Description", "ExpectedTimeIn", "ExpectedTimeOut", "Status", "VisitDetailName", "VisitId", "VisitorId" },
                values: new object[] { "Mollitia minima quia velit quas. Quia quia itaque dicta voluptatem autem consectetur. Sed consequatur ex et. Excepturi earum nemo aspernatur sit at.", new DateTime(2024, 9, 20, 20, 31, 13, 125, DateTimeKind.Local).AddTicks(1835), new DateTime(2024, 9, 21, 20, 31, 13, 125, DateTimeKind.Local).AddTicks(1878), true, "Fantastic Frozen Soap", 5, 1 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 2,
                columns: new[] { "Description", "ExpectedTimeIn", "ExpectedTimeOut", "VisitDetailName", "VisitId", "VisitorId" },
                values: new object[] { "Nihil ut enim nobis magni eum repudiandae. Nihil sint nihil ab facere laborum molestiae magnam adipisci. Rem inventore error natus aspernatur reprehenderit ducimus aut. Aut magnam harum magnam autem illum aut aliquid voluptas. Esse sequi natus et sapiente error est eum. Non ut porro ut odio aut et doloremque.", new DateTime(2024, 9, 20, 20, 31, 13, 125, DateTimeKind.Local).AddTicks(2955), new DateTime(2024, 9, 21, 20, 31, 13, 125, DateTimeKind.Local).AddTicks(2960), "Generic Cotton Pants", 1, 6 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 3,
                columns: new[] { "Description", "ExpectedTimeIn", "ExpectedTimeOut", "Status", "VisitDetailName", "VisitId", "VisitorId" },
                values: new object[] { "Corporis deleniti suscipit iste sed quia ex id officiis. Qui explicabo ut laborum aut. Quas ut ad ut non rerum. Est alias delectus ipsum qui sed et et quos. Necessitatibus pariatur unde harum molestias.", new DateTime(2024, 9, 20, 20, 31, 13, 125, DateTimeKind.Local).AddTicks(3170), new DateTime(2024, 9, 21, 20, 31, 13, 125, DateTimeKind.Local).AddTicks(3173), false, "Handcrafted Plastic Pants", 3, 10 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 4,
                columns: new[] { "Description", "ExpectedTimeIn", "ExpectedTimeOut", "Status", "VisitDetailName", "VisitorId" },
                values: new object[] { "Itaque hic id voluptas at. Sit qui et architecto et et. Fugiat voluptas eos nisi facilis sequi.", new DateTime(2024, 9, 20, 20, 31, 13, 125, DateTimeKind.Local).AddTicks(3255), new DateTime(2024, 9, 21, 20, 31, 13, 125, DateTimeKind.Local).AddTicks(3257), true, "Rustic Frozen Chair", 4 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 5,
                columns: new[] { "Description", "ExpectedTimeIn", "ExpectedTimeOut", "VisitDetailName", "VisitId", "VisitorId" },
                values: new object[] { "Natus aut nostrum consequatur eveniet itaque molestias molestiae. Sequi reiciendis magni quia cupiditate consequuntur accusantium in ab hic. Doloribus deleniti fugiat alias eum corrupti maiores. Maxime repudiandae nisi eveniet quos eos dolore pariatur et perferendis. Consectetur amet qui repellendus nostrum aut et.", new DateTime(2024, 9, 20, 20, 31, 13, 125, DateTimeKind.Local).AddTicks(3389), new DateTime(2024, 9, 21, 20, 31, 13, 125, DateTimeKind.Local).AddTicks(3390), "Unbranded Wooden Pizza", 2, 2 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 6,
                columns: new[] { "Description", "ExpectedTimeIn", "ExpectedTimeOut", "Status", "VisitDetailName", "VisitId" },
                values: new object[] { "Assumenda ut commodi facere mollitia. Fuga aut dolores excepturi quia cumque suscipit rerum quo. Corporis ut facilis magni repellendus distinctio rem ex. Est earum et et optio unde aut et. Fugiat quam doloribus doloremque rerum. Quaerat quibusdam ut.", new DateTime(2024, 9, 20, 20, 31, 13, 125, DateTimeKind.Local).AddTicks(3508), new DateTime(2024, 9, 21, 20, 31, 13, 125, DateTimeKind.Local).AddTicks(3510), false, "Handmade Granite Car", 2 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 7,
                columns: new[] { "Description", "ExpectedTimeIn", "ExpectedTimeOut", "Status", "VisitDetailName", "VisitId", "VisitorId" },
                values: new object[] { "Omnis quidem quae nesciunt libero voluptatibus. Autem porro aliquid iste vero adipisci repellat in. Accusantium esse est qui vero ipsam. Pariatur quasi et minus et.", new DateTime(2024, 9, 20, 20, 31, 13, 125, DateTimeKind.Local).AddTicks(3598), new DateTime(2024, 9, 21, 20, 31, 13, 125, DateTimeKind.Local).AddTicks(3599), true, "Unbranded Steel Soap", 4, 3 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 8,
                columns: new[] { "Description", "ExpectedTimeIn", "ExpectedTimeOut", "VisitDetailName", "VisitId", "VisitorId" },
                values: new object[] { "Et sed at. Dolor officiis nostrum itaque natus est. Et et tempora incidunt qui dolore asperiores eligendi. Harum laborum culpa. Dolorem facilis quis nihil repellendus. Dolorum esse aut quia ab ad et.", new DateTime(2024, 9, 20, 20, 31, 13, 125, DateTimeKind.Local).AddTicks(3710), new DateTime(2024, 9, 21, 20, 31, 13, 125, DateTimeKind.Local).AddTicks(3711), "Unbranded Concrete Hat", 1, 5 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 9,
                columns: new[] { "Description", "ExpectedTimeIn", "ExpectedTimeOut", "Status", "VisitDetailName", "VisitId", "VisitorId" },
                values: new object[] { "Dolor quaerat molestias dolorem. Consectetur maxime quis aspernatur magnam sint id omnis aspernatur. Inventore maiores aut nisi architecto aut occaecati sit. Eos est laborum impedit autem alias rerum accusamus. Dolorem ea quos nobis hic voluptatem nostrum accusantium. Amet et modi ipsam possimus autem dolorem molestiae.", new DateTime(2024, 9, 20, 20, 31, 13, 125, DateTimeKind.Local).AddTicks(3843), new DateTime(2024, 9, 21, 20, 31, 13, 125, DateTimeKind.Local).AddTicks(3849), true, "Refined Plastic Pants", 5, 10 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 10,
                columns: new[] { "Description", "ExpectedTimeIn", "ExpectedTimeOut", "VisitDetailName", "VisitId", "VisitorId" },
                values: new object[] { "Vitae occaecati ipsa soluta velit iusto eaque cum. Fugit praesentium quisquam suscipit totam ut. Harum quia in eos et est. Nesciunt aut sit praesentium sequi est sapiente ut iste. Vel dolor mollitia laborum. Nulla harum ea blanditiis nesciunt.", new DateTime(2024, 9, 20, 20, 31, 13, 125, DateTimeKind.Local).AddTicks(3966), new DateTime(2024, 9, 21, 20, 31, 13, 125, DateTimeKind.Local).AddTicks(3966), "Gorgeous Soft Bacon", 3, 8 });

            migrationBuilder.UpdateData(
                table: "VisitorSessions",
                keyColumn: "VisitorSessionId",
                keyValue: 1,
                columns: new[] { "CheckinTime", "CheckoutTime", "GateOutId", "QRCardId", "SecurityOutId", "Status", "VisitDetailId" },
                values: new object[] { new DateTime(2024, 9, 21, 13, 31, 13, 127, DateTimeKind.Utc).AddTicks(7133), null, null, 10, null, "CheckIn", 2 });

            migrationBuilder.UpdateData(
                table: "VisitorSessions",
                keyColumn: "VisitorSessionId",
                keyValue: 2,
                columns: new[] { "CheckinTime", "CheckoutTime", "GateOutId", "QRCardId", "SecurityOutId", "Status", "VisitDetailId" },
                values: new object[] { new DateTime(2024, 9, 21, 13, 31, 13, 127, DateTimeKind.Utc).AddTicks(9648), null, null, 2, null, "CheckIn", 5 });

            migrationBuilder.UpdateData(
                table: "VisitorSessions",
                keyColumn: "VisitorSessionId",
                keyValue: 3,
                columns: new[] { "CheckinTime", "CheckoutTime", "GateInId", "GateOutId", "QRCardId", "SecurityOutId", "Status", "VisitDetailId" },
                values: new object[] { new DateTime(2024, 9, 21, 13, 31, 13, 127, DateTimeKind.Utc).AddTicks(9676), null, 2, null, 4, null, "CheckIn", 1 });

            migrationBuilder.UpdateData(
                table: "VisitorSessions",
                keyColumn: "VisitorSessionId",
                keyValue: 4,
                columns: new[] { "CheckinTime", "CheckoutTime", "GateInId", "GateOutId", "QRCardId", "SecurityOutId", "Status", "VisitDetailId" },
                values: new object[] { new DateTime(2024, 9, 21, 13, 31, 13, 127, DateTimeKind.Utc).AddTicks(9688), null, 1, null, 2, null, "CheckIn", 10 });

            migrationBuilder.UpdateData(
                table: "VisitorSessions",
                keyColumn: "VisitorSessionId",
                keyValue: 5,
                columns: new[] { "CheckinTime", "CheckoutTime", "GateOutId", "QRCardId", "SecurityOutId", "Status", "VisitDetailId" },
                values: new object[] { new DateTime(2024, 9, 21, 13, 31, 13, 127, DateTimeKind.Utc).AddTicks(9697), null, null, 6, null, "CheckIn", 1 });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 1,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Price - Bahringer", new DateTime(2024, 9, 14, 3, 7, 53, 72, DateTimeKind.Unspecified).AddTicks(7101), "sh9ostzuvh", "0452634738", true, new DateTime(2024, 9, 14, 3, 7, 53, 72, DateTimeKind.Unspecified).AddTicks(7101), "Precious Heaney" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 2,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Reichert - Larson", new DateTime(2024, 9, 7, 9, 28, 14, 272, DateTimeKind.Unspecified).AddTicks(9687), 1, "3qnesktsis", "0727092702", false, new DateTime(2024, 9, 7, 9, 28, 14, 272, DateTimeKind.Unspecified).AddTicks(9687), "Laverna Marquardt" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 3,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "McCullough and Sons", new DateTime(2024, 9, 20, 12, 24, 39, 345, DateTimeKind.Unspecified).AddTicks(5878), "ikajbhvugb", "0270991238", true, new DateTime(2024, 9, 20, 12, 24, 39, 345, DateTimeKind.Unspecified).AddTicks(5878), "Lawrence Mayer" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 4,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Kuhn - Raynor", new DateTime(2024, 9, 12, 0, 53, 26, 508, DateTimeKind.Unspecified).AddTicks(7000), "3at6c547os", "0786124272", false, new DateTime(2024, 9, 12, 0, 53, 26, 508, DateTimeKind.Unspecified).AddTicks(7000), "Nyasia Stanton" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 5,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Osinski Group", new DateTime(2024, 9, 5, 14, 18, 23, 614, DateTimeKind.Unspecified).AddTicks(4311), 1, "psbpnabtgu", "0340274050", new DateTime(2024, 9, 5, 14, 18, 23, 614, DateTimeKind.Unspecified).AddTicks(4311), "Wade Bins" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 6,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Senger - Bartoletti", new DateTime(2024, 9, 3, 3, 32, 15, 166, DateTimeKind.Unspecified).AddTicks(3347), "f39waowmuw", "0807079074", false, new DateTime(2024, 9, 3, 3, 32, 15, 166, DateTimeKind.Unspecified).AddTicks(3347), "Danielle Bosco" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 7,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Jakubowski - Greenholt", new DateTime(2024, 9, 8, 2, 41, 45, 659, DateTimeKind.Unspecified).AddTicks(6898), "ndpy1zo3t0", "0477163766", false, new DateTime(2024, 9, 8, 2, 41, 45, 659, DateTimeKind.Unspecified).AddTicks(6898), "Vilma Hermann" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 8,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Powlowski and Sons", new DateTime(2024, 9, 19, 1, 42, 26, 710, DateTimeKind.Unspecified).AddTicks(5251), 1, "8xlrqss5af", "0624306462", new DateTime(2024, 9, 19, 1, 42, 26, 710, DateTimeKind.Unspecified).AddTicks(5251), "Jaren Stroman" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 9,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Mante - Yost", new DateTime(2024, 9, 18, 6, 16, 18, 840, DateTimeKind.Unspecified).AddTicks(178), "krr5d6q8ow", "0580889411", new DateTime(2024, 9, 18, 6, 16, 18, 840, DateTimeKind.Unspecified).AddTicks(178), "Cole DuBuque" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 10,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Kuhn - Funk", new DateTime(2024, 9, 5, 17, 30, 10, 373, DateTimeKind.Unspecified).AddTicks(7776), "dydunnh8z8", "0765117529", true, new DateTime(2024, 9, 5, 17, 30, 10, 373, DateTimeKind.Unspecified).AddTicks(7776), "Ella Cartwright" });

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 1,
                columns: new[] { "AcceptLevel", "DateRegister", "DepartmentReasonId" },
                values: new object[] { 3, new DateTime(2024, 9, 3, 10, 13, 2, 245, DateTimeKind.Unspecified).AddTicks(6124), 3 });

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 2,
                columns: new[] { "AcceptLevel", "DateRegister", "DepartmentReasonId", "VisitQuantity" },
                values: new object[] { 4, new DateTime(2024, 9, 4, 17, 26, 7, 116, DateTimeKind.Unspecified).AddTicks(2251), 2, 8 });

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 3,
                columns: new[] { "DateRegister", "DepartmentReasonId", "VisitQuantity" },
                values: new object[] { new DateTime(2024, 9, 9, 1, 53, 30, 318, DateTimeKind.Unspecified).AddTicks(745), 3, 4 });

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 4,
                columns: new[] { "AcceptLevel", "DateRegister", "DepartmentReasonId", "VisitQuantity" },
                values: new object[] { 2, new DateTime(2024, 9, 11, 23, 7, 12, 381, DateTimeKind.Unspecified).AddTicks(9518), 5, 2 });

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 5,
                columns: new[] { "AcceptLevel", "DateRegister", "DepartmentReasonId", "VisitQuantity" },
                values: new object[] { 3, new DateTime(2024, 9, 2, 10, 7, 41, 631, DateTimeKind.Unspecified).AddTicks(6281), 1, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_VisitorSessions_GateOutId",
                table: "VisitorSessions",
                column: "GateOutId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitorSessions_SecurityOutId",
                table: "VisitorSessions",
                column: "SecurityOutId");

            migrationBuilder.AddForeignKey(
                name: "FK_VisitorSessions_Gates_GateInId",
                table: "VisitorSessions",
                column: "GateInId",
                principalTable: "Gates",
                principalColumn: "GateId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VisitorSessions_Gates_GateOutId",
                table: "VisitorSessions",
                column: "GateOutId",
                principalTable: "Gates",
                principalColumn: "GateId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VisitorSessions_Users_SecurityInId",
                table: "VisitorSessions",
                column: "SecurityInId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VisitorSessions_Users_SecurityOutId",
                table: "VisitorSessions",
                column: "SecurityOutId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VisitorSessions_Gates_GateInId",
                table: "VisitorSessions");

            migrationBuilder.DropForeignKey(
                name: "FK_VisitorSessions_Gates_GateOutId",
                table: "VisitorSessions");

            migrationBuilder.DropForeignKey(
                name: "FK_VisitorSessions_Users_SecurityInId",
                table: "VisitorSessions");

            migrationBuilder.DropForeignKey(
                name: "FK_VisitorSessions_Users_SecurityOutId",
                table: "VisitorSessions");

            migrationBuilder.DropIndex(
                name: "IX_VisitorSessions_GateOutId",
                table: "VisitorSessions");

            migrationBuilder.DropIndex(
                name: "IX_VisitorSessions_SecurityOutId",
                table: "VisitorSessions");

            migrationBuilder.DropColumn(
                name: "GateOutId",
                table: "VisitorSessions");

            migrationBuilder.DropColumn(
                name: "SecurityOutId",
                table: "VisitorSessions");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "VisitorSessions");

            migrationBuilder.RenameColumn(
                name: "SecurityInId",
                table: "VisitorSessions",
                newName: "SecurityID");

            migrationBuilder.RenameColumn(
                name: "GateInId",
                table: "VisitorSessions",
                newName: "GateId");

            migrationBuilder.RenameIndex(
                name: "IX_VisitorSessions_SecurityInId",
                table: "VisitorSessions",
                newName: "IX_VisitorSessions_SecurityID");

            migrationBuilder.RenameIndex(
                name: "IX_VisitorSessions_GateInId",
                table: "VisitorSessions",
                newName: "IX_VisitorSessions_GateId");

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 1,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 2, "Eos autem aut temporibus commodi quis quia ad doloremque ut.", "Generic Metal Shirt", 3 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 2,
                columns: new[] { "Description", "Name", "ReasonId" },
                values: new object[] { "Nisi temporibus dolore aspernatur.", "Incredible Frozen Shoes", 3 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 3,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 9, "Iste qui voluptatem ut deleniti maxime corporis delectus laboriosam.", "Ergonomic Concrete Bike", 1 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 4,
                columns: new[] { "DepartmentId", "Description", "Name" },
                values: new object[] { 6, "Et quo quaerat ipsa et libero.", "Ergonomic Cotton Sausages" });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 5,
                columns: new[] { "DepartmentId", "Description", "Name" },
                values: new object[] { 10, "Cumque saepe est est molestias id nobis rerum.", "Unbranded Plastic Chips" });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 6,
                columns: new[] { "Description", "Name", "ReasonId" },
                values: new object[] { "Aut possimus sed voluptas ea occaecati voluptate expedita ut.", "Rustic Concrete Shirt", 3 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 7,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 8, "Eius voluptatum repudiandae possimus.", "Incredible Concrete Salad", 2 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 8,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 2, "Rem in alias sunt.", "Ergonomic Concrete Bike", 5 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 9,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 1, "Quaerat qui est qui delectus quia id non quibusdam.", "Awesome Granite Bike", 5 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 10,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 7, "Porro dolor in error amet voluptatum.", "Rustic Steel Chicken", 4 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 11,
                columns: new[] { "DepartmentId", "Description", "Name" },
                values: new object[] { 7, "Itaque labore eligendi adipisci.", "Generic Plastic Computer" });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 12,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 1, "Temporibus minus enim in voluptatem rerum alias.", "Rustic Soft Sausages", 2 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 13,
                columns: new[] { "DepartmentId", "Description", "Name" },
                values: new object[] { 8, "Blanditiis molestias nesciunt et molestias sint quia inventore molestias sed.", "Licensed Frozen Chair" });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 14,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 1, "Vel nesciunt itaque in nostrum iste.", "Intelligent Cotton Pizza", 2 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 15,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 5, "Sint reiciendis quis odio aut illum.", "Practical Plastic Bacon", 2 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 16,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 2, "Tempora quo alias et ut placeat eos molestiae voluptatum.", "Sleek Granite Gloves", 3 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 17,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 4, "Consequatur temporibus sed commodi soluta aut natus iste impedit et.", "Ergonomic Rubber Sausages", 3 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 18,
                columns: new[] { "DepartmentId", "Description", "Name" },
                values: new object[] { 10, "Qui culpa ex et.", "Intelligent Concrete Shoes" });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 19,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 6, "Maxime vel atque dolores in officiis.", "Generic Soft Hat", 2 });

            migrationBuilder.UpdateData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 20,
                columns: new[] { "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[] { 3, "A repudiandae voluptatum.", "Awesome Steel Car", 5 });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 10, 4, 26, 30, 689, DateTimeKind.Utc).AddTicks(5219), "Phòng IT", "Eveniet culpa illo veniam odit qui eaque voluptatum nisi.", new DateTime(2024, 9, 10, 4, 26, 30, 689, DateTimeKind.Utc).AddTicks(5219) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 9, 3, 0, 16, 76, DateTimeKind.Utc).AddTicks(9562), "Phòng Sản xuất", "Consequatur fuga ducimus nam aperiam quod illum.", new DateTime(2024, 9, 9, 3, 0, 16, 76, DateTimeKind.Utc).AddTicks(9562) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 7, 10, 45, 613, DateTimeKind.Utc).AddTicks(9426), "Phòng Marketing", "Enim nesciunt distinctio est debitis fuga illo consectetur.", new DateTime(2024, 9, 12, 7, 10, 45, 613, DateTimeKind.Utc).AddTicks(9426) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4,
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 8, 17, 38, 109, DateTimeKind.Utc).AddTicks(9333), "Phòng Sản xuất", "Voluptates omnis sunt.", new DateTime(2024, 9, 3, 8, 17, 38, 109, DateTimeKind.Utc).AddTicks(9333) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 9, 7, 14, 15, 58, 121, DateTimeKind.Utc).AddTicks(7591), "Phòng Hành chính", "Consequatur nesciunt minima possimus veniam quia.", new DateTime(2024, 9, 7, 14, 15, 58, 121, DateTimeKind.Utc).AddTicks(7591) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 6,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 16, 15, 4, 4, 832, DateTimeKind.Utc).AddTicks(6401), "Phòng Marketing", "Est aperiam hic.", new DateTime(2024, 9, 16, 15, 4, 4, 832, DateTimeKind.Utc).AddTicks(6401) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 7,
                columns: new[] { "AcceptLevel", "CreateDate", "Description", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2024, 9, 10, 14, 43, 46, 351, DateTimeKind.Utc).AddTicks(4240), "Ut fugiat eligendi voluptatem ab quod labore adipisci consequuntur sed.", new DateTime(2024, 9, 10, 14, 43, 46, 351, DateTimeKind.Utc).AddTicks(4240) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 8,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2024, 9, 13, 2, 28, 12, 904, DateTimeKind.Utc).AddTicks(9219), "Phòng Hành chính", "Pariatur modi nemo ut distinctio voluptatem sed voluptatem repellendus.", new DateTime(2024, 9, 13, 2, 28, 12, 904, DateTimeKind.Utc).AddTicks(9219) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 9,
                columns: new[] { "CreateDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 15, 58, 53, 706, DateTimeKind.Utc).AddTicks(5232), "Molestias eos in consequuntur reprehenderit modi incidunt ab quibusdam sed.", new DateTime(2024, 9, 3, 15, 58, 53, 706, DateTimeKind.Utc).AddTicks(5232) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 10,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 8, 13, 29, 7, 683, DateTimeKind.Utc).AddTicks(7023), "Phòng Sản xuất", "Magnam error et assumenda deserunt consequatur explicabo ut.", new DateTime(2024, 9, 8, 13, 29, 7, 683, DateTimeKind.Utc).AddTicks(7023) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                columns: new[] { "CreateTime", "ProjectName" },
                values: new object[] { new DateTime(2024, 9, 11, 22, 52, 31, 905, DateTimeKind.Unspecified).AddTicks(3854), "Unbranded Steel Bacon" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                columns: new[] { "CreateTime", "ProjectName", "Status" },
                values: new object[] { new DateTime(2024, 9, 11, 1, 19, 33, 761, DateTimeKind.Unspecified).AddTicks(1211), "Unbranded Soft Hat", true });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                columns: new[] { "CreateTime", "ProjectName" },
                values: new object[] { new DateTime(2024, 9, 12, 19, 9, 42, 170, DateTimeKind.Unspecified).AddTicks(3401), "Tasty Plastic Shirt" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4,
                columns: new[] { "CreateTime", "ProjectName", "Status" },
                values: new object[] { new DateTime(2024, 9, 10, 21, 19, 39, 500, DateTimeKind.Unspecified).AddTicks(4372), "Tasty Concrete Pants", true });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 5,
                columns: new[] { "CreateTime", "ProjectName" },
                values: new object[] { new DateTime(2024, 9, 4, 21, 56, 56, 126, DateTimeKind.Unspecified).AddTicks(3555), "Ergonomic Wooden Hat" });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 1,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("fcfb0bcc-d518-4085-876f-3ea91d62b56f"), new DateTime(2024, 9, 20, 19, 48, 23, 929, DateTimeKind.Local).AddTicks(1020), new DateTime(2024, 10, 20, 19, 48, 23, 929, DateTimeKind.Local).AddTicks(1020) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 2,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("1e5815de-226b-4b71-840f-6106e52568b3"), new DateTime(2024, 9, 20, 19, 48, 23, 929, DateTimeKind.Local).AddTicks(1211), new DateTime(2024, 10, 20, 19, 48, 23, 929, DateTimeKind.Local).AddTicks(1211) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 3,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId" },
                values: new object[] { new Guid("44fffa77-db0a-4cca-b23c-f5568f80b193"), new DateTime(2024, 9, 20, 19, 48, 23, 929, DateTimeKind.Local).AddTicks(1224), new DateTime(2024, 10, 20, 19, 48, 23, 929, DateTimeKind.Local).AddTicks(1224), 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 4,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("78774d5e-3084-4fc3-bca4-2f3e02a9ce07"), new DateTime(2024, 9, 20, 19, 48, 23, 929, DateTimeKind.Local).AddTicks(1233), new DateTime(2024, 10, 20, 19, 48, 23, 929, DateTimeKind.Local).AddTicks(1233) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 5,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("c590675c-ea3e-4663-8725-e1b0dd006f01"), new DateTime(2024, 9, 20, 19, 48, 23, 929, DateTimeKind.Local).AddTicks(1251), new DateTime(2024, 10, 20, 19, 48, 23, 929, DateTimeKind.Local).AddTicks(1251) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 6,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId", "QRCardTypeId" },
                values: new object[] { new Guid("3a72cf98-5da6-4a99-90c1-c19a5ab971e4"), new DateTime(2024, 9, 20, 19, 48, 23, 929, DateTimeKind.Local).AddTicks(1259), new DateTime(2024, 10, 20, 19, 48, 23, 929, DateTimeKind.Local).AddTicks(1259), 1, 1 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 7,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId", "QRCardTypeId" },
                values: new object[] { new Guid("db04521d-3196-446c-b4f9-83b9979df3bd"), new DateTime(2024, 9, 20, 19, 48, 23, 929, DateTimeKind.Local).AddTicks(1266), new DateTime(2024, 10, 20, 19, 48, 23, 929, DateTimeKind.Local).AddTicks(1266), 2, 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 8,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId", "QRCardTypeId" },
                values: new object[] { new Guid("50cf87c8-bd64-413c-bd0e-900c2cbdac8c"), new DateTime(2024, 9, 20, 19, 48, 23, 929, DateTimeKind.Local).AddTicks(1273), new DateTime(2024, 10, 20, 19, 48, 23, 929, DateTimeKind.Local).AddTicks(1273), 2, 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 9,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("c7802cd1-c959-4c9d-a51d-48e4c7f5cbc8"), new DateTime(2024, 9, 20, 19, 48, 23, 929, DateTimeKind.Local).AddTicks(1279), new DateTime(2024, 10, 20, 19, 48, 23, 929, DateTimeKind.Local).AddTicks(1279) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 10,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId", "QRCardTypeId" },
                values: new object[] { new Guid("a789af1e-1625-4a75-bb29-85058b0c0ef8"), new DateTime(2024, 9, 20, 19, 48, 23, 929, DateTimeKind.Local).AddTicks(1286), new DateTime(2024, 10, 20, 19, 48, 23, 929, DateTimeKind.Local).AddTicks(1286), 2, 2 });

            migrationBuilder.UpdateData(
                table: "Reasons",
                keyColumn: "ReasonId",
                keyValue: 1,
                columns: new[] { "Description", "ReasonName" },
                values: new object[] { "Labore quidem dolore minus aut ad.", "Refined Metal Soap" });

            migrationBuilder.UpdateData(
                table: "Reasons",
                keyColumn: "ReasonId",
                keyValue: 2,
                columns: new[] { "Description", "ReasonName" },
                values: new object[] { "Ut quisquam voluptates assumenda tempore nihil eaque.", "Unbranded Frozen Fish" });

            migrationBuilder.UpdateData(
                table: "Reasons",
                keyColumn: "ReasonId",
                keyValue: 3,
                columns: new[] { "Description", "ReasonName" },
                values: new object[] { "Eaque magnam dicta.", "Intelligent Plastic Chips" });

            migrationBuilder.UpdateData(
                table: "Reasons",
                keyColumn: "ReasonId",
                keyValue: 4,
                columns: new[] { "Description", "ReasonName" },
                values: new object[] { "Soluta illum debitis quia.", "Small Soft Bacon" });

            migrationBuilder.UpdateData(
                table: "Reasons",
                keyColumn: "ReasonId",
                keyValue: 5,
                columns: new[] { "Description", "ReasonName" },
                values: new object[] { "Recusandae natus aut.", "Sleek Plastic Keyboard" });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 1,
                column: "UserId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 2,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 10 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 3,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 9 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 4,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 2, 10 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 5,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 1, 21 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 6,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 10, 11 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 7,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 1, 3 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 8,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 5, 13 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 9,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 14 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 10,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 1, 18 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 11,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 12,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 1, 14 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 13,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 6, 23 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 14,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 4, 21 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 15,
                column: "UserId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 16,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 12 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 17,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 21 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 18,
                column: "UserId",
                value: 24);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 19,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 10 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 20,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 1, 13 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 21,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 5, 20 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 22,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 3, 10 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 23,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 10, 5 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 24,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 6, 19 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 25,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 13 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 26,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 5 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 27,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 2, 25 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 28,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 5, 7 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 29,
                column: "UserId",
                value: 22);

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 30,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 3, 23 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 20, 12, 48, 23, 912, DateTimeKind.Utc).AddTicks(3291), new DateTime(2024, 9, 20, 12, 48, 23, 912, DateTimeKind.Utc).AddTicks(3303) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 20, 12, 48, 23, 912, DateTimeKind.Utc).AddTicks(3306), new DateTime(2024, 9, 20, 12, 48, 23, 912, DateTimeKind.Utc).AddTicks(3307) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 20, 12, 48, 23, 912, DateTimeKind.Utc).AddTicks(3309), new DateTime(2024, 9, 20, 12, 48, 23, 912, DateTimeKind.Utc).AddTicks(3310) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 12, 48, 23, 912, DateTimeKind.Utc).AddTicks(3311), new DateTime(2024, 9, 20, 12, 48, 23, 912, DateTimeKind.Utc).AddTicks(3312) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 20, 12, 48, 23, 912, DateTimeKind.Utc).AddTicks(3313), new DateTime(2024, 9, 20, 12, 48, 23, 912, DateTimeKind.Utc).AddTicks(3314) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 52, 30, 896, DateTimeKind.Unspecified).AddTicks(5047), "gmail.com.Rath3@hotmail.com", "Dayana Murray", "1jgari", "0494709628", 3, new DateTime(2024, 9, 4, 14, 52, 30, 896, DateTimeKind.Unspecified).AddTicks(5047), "Amos14" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 8, 1, 36, 45, 93, DateTimeKind.Unspecified).AddTicks(3087), "gmail.com.Champlin48@yahoo.com", "Lily Ritchie", "v1atiw", "0786469089", new DateTime(2024, 9, 8, 1, 36, 45, 93, DateTimeKind.Unspecified).AddTicks(3087), "Joanny24" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 1, 18, 50, 19, 452, DateTimeKind.Unspecified).AddTicks(9756), "gmail.com17@gmail.com", "Maximilian Effertz", "9gy1mm", "0819469217", 4, new DateTime(2024, 9, 1, 18, 50, 19, 452, DateTimeKind.Unspecified).AddTicks(9756), "Kyra_Bauch48" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 6, 16, 38, 3, 483, DateTimeKind.Unspecified).AddTicks(3801), "gmail.com31@hotmail.com", "Bettie Reichert", "0j8sb7", "0397173325", 2, new DateTime(2024, 9, 6, 16, 38, 3, 483, DateTimeKind.Unspecified).AddTicks(3801), "Rosella.Goldner97" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 15, 21, 32, 35, 64, DateTimeKind.Unspecified).AddTicks(4127), "gmail.com.Gislason@hotmail.com", "Audra Pacocha", "58p1j3", "0533310956", 2, new DateTime(2024, 9, 15, 21, 32, 35, 64, DateTimeKind.Unspecified).AddTicks(4127), "Tod_Purdy10" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 19, 12, 9, 20, 839, DateTimeKind.Unspecified).AddTicks(7512), "gmail.com4@gmail.com", "Birdie Kuhlman", "nohzw1", "0154790706", 4, new DateTime(2024, 9, 19, 12, 9, 20, 839, DateTimeKind.Unspecified).AddTicks(7512), "Mohammad_Turcotte" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 15, 7, 16, 43, 35, DateTimeKind.Unspecified).AddTicks(7933), "gmail.com.Swaniawski@hotmail.com", "Fabiola Williamson", "sro2o6", "0319271086", 1, new DateTime(2024, 9, 15, 7, 16, 43, 35, DateTimeKind.Unspecified).AddTicks(7933), "Kirsten68" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 17, 2, 13, 48, 488, DateTimeKind.Unspecified).AddTicks(7596), "gmail.com.Gutkowski37@gmail.com", "Veda D'Amore", "zocg54", "0753983410", new DateTime(2024, 9, 17, 2, 13, 48, 488, DateTimeKind.Unspecified).AddTicks(7596), "Bartholome.Konopelski" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 16, 17, 20, 42, 737, DateTimeKind.Unspecified).AddTicks(5738), "gmail.com.Graham84@hotmail.com", "Garrison Kreiger", "kuaywz", "0224259543", 1, new DateTime(2024, 9, 16, 17, 20, 42, 737, DateTimeKind.Unspecified).AddTicks(5738), "Paige.Hodkiewicz" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 8, 11, 6, 3, 303, DateTimeKind.Unspecified).AddTicks(1951), "gmail.com74@gmail.com", "Roxane Graham", "5geyd0", "0384796402", 4, new DateTime(2024, 9, 8, 11, 6, 3, 303, DateTimeKind.Unspecified).AddTicks(1951), "Amparo.Shields" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 8, 18, 38, 9, 80, DateTimeKind.Unspecified).AddTicks(4890), "gmail.com18@yahoo.com", "Evans Stracke", "nnmw5q", "0997319411", 4, new DateTime(2024, 9, 8, 18, 38, 9, 80, DateTimeKind.Unspecified).AddTicks(4890), "Reed_Terry" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 6, 21, 47, 57, 504, DateTimeKind.Unspecified).AddTicks(41), "gmail.com.Beatty@hotmail.com", "Madyson Schulist", "cip2bu", "0456142837", 3, new DateTime(2024, 9, 6, 21, 47, 57, 504, DateTimeKind.Unspecified).AddTicks(41), "Wallace_Okuneva" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 12, 17, 55, 21, 113, DateTimeKind.Unspecified).AddTicks(4356), "gmail.com34@gmail.com", "Shana Hilll", "wctrv4", "0608570233", 4, new DateTime(2024, 9, 12, 17, 55, 21, 113, DateTimeKind.Unspecified).AddTicks(4356), "Grayson50" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 17, 4, 22, 4, 488, DateTimeKind.Unspecified).AddTicks(8766), "gmail.com.Gaylord91@gmail.com", "Zackary Predovic", "bybcp7", "0645931406", 2, new DateTime(2024, 9, 17, 4, 22, 4, 488, DateTimeKind.Unspecified).AddTicks(8766), "Kiara_Metz43" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 14, 17, 22, 13, 645, DateTimeKind.Unspecified).AddTicks(6684), "gmail.com_Bins@gmail.com", "Chase Gorczany", "ne3mj2", "0966827236", 5, new DateTime(2024, 9, 14, 17, 22, 13, 645, DateTimeKind.Unspecified).AddTicks(6684), "Roel87" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 4, 0, 38, 50, 178, DateTimeKind.Unspecified).AddTicks(1336), "gmail.com.Mante59@yahoo.com", "Itzel Bins", "2f9wml", "0895515644", 4, new DateTime(2024, 9, 4, 0, 38, 50, 178, DateTimeKind.Unspecified).AddTicks(1336), "Lavonne75" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 14, 13, 21, 14, 462, DateTimeKind.Unspecified).AddTicks(1692), "gmail.com.Johnston27@gmail.com", "Ebba Koch", "ftd83g", "0626378941", 5, new DateTime(2024, 9, 14, 13, 21, 14, 462, DateTimeKind.Unspecified).AddTicks(1692), "Berenice.Jones56" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 15, 18, 51, 27, 714, DateTimeKind.Unspecified).AddTicks(4774), "gmail.com11@gmail.com", "Kitty Turner", "8e3x59", "0779918618", 1, new DateTime(2024, 9, 15, 18, 51, 27, 714, DateTimeKind.Unspecified).AddTicks(4774), "Thea_Stokes" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 9, 13, 14, 43, 338, DateTimeKind.Unspecified).AddTicks(5864), "gmail.com.Bosco@hotmail.com", "Eladio VonRueden", "4r0djy", "0236678624", new DateTime(2024, 9, 9, 13, 14, 43, 338, DateTimeKind.Unspecified).AddTicks(5864), "Eldred70" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 1, 18, 3, 43, 870, DateTimeKind.Unspecified).AddTicks(1452), "gmail.com82@hotmail.com", "Jaylan Wiegand", "1476hj", "0600037343", new DateTime(2024, 9, 1, 18, 3, 43, 870, DateTimeKind.Unspecified).AddTicks(1452), "Felicia.Bailey21" });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 1,
                columns: new[] { "Description", "ExpectedTimeIn", "ExpectedTimeOut", "Status", "VisitDetailName", "VisitId", "VisitorId" },
                values: new object[] { "Accusantium aut quis neque beatae saepe debitis adipisci. Doloremque nobis dolore perspiciatis aut eos nesciunt quo tenetur aut. Maiores ad quis atque inventore doloribus et fugiat. Ut occaecati illum est aut velit accusamus autem soluta ullam.", new DateTime(2024, 9, 21, 19, 48, 23, 927, DateTimeKind.Local).AddTicks(6994), new DateTime(2024, 9, 22, 19, 48, 23, 927, DateTimeKind.Local).AddTicks(7039), false, "Rustic Granite Bacon", 1, 9 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 2,
                columns: new[] { "Description", "ExpectedTimeIn", "ExpectedTimeOut", "VisitDetailName", "VisitId", "VisitorId" },
                values: new object[] { "Qui placeat cupiditate illo delectus. Voluptates quidem impedit. Aut omnis at. Consequuntur maiores quas architecto fuga. Perspiciatis cupiditate et tempore alias autem.", new DateTime(2024, 9, 21, 19, 48, 23, 927, DateTimeKind.Local).AddTicks(8115), new DateTime(2024, 9, 22, 19, 48, 23, 927, DateTimeKind.Local).AddTicks(8121), "Awesome Granite Bacon", 2, 1 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 3,
                columns: new[] { "Description", "ExpectedTimeIn", "ExpectedTimeOut", "Status", "VisitDetailName", "VisitId", "VisitorId" },
                values: new object[] { "Accusamus ea asperiores harum. Illum nostrum nisi sequi. Incidunt quo sed et illum. Vel tenetur fugit excepturi aut et nihil et autem magnam.", new DateTime(2024, 9, 21, 19, 48, 23, 927, DateTimeKind.Local).AddTicks(8223), new DateTime(2024, 9, 22, 19, 48, 23, 927, DateTimeKind.Local).AddTicks(8225), true, "Incredible Concrete Keyboard", 4, 1 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 4,
                columns: new[] { "Description", "ExpectedTimeIn", "ExpectedTimeOut", "Status", "VisitDetailName", "VisitorId" },
                values: new object[] { "Magni ut mollitia possimus voluptatibus. Laudantium iusto ut eum et libero quo enim reprehenderit. Dolor incidunt architecto autem. Nam nam sit modi minima corrupti quas dolorem.", new DateTime(2024, 9, 21, 19, 48, 23, 927, DateTimeKind.Local).AddTicks(8326), new DateTime(2024, 9, 22, 19, 48, 23, 927, DateTimeKind.Local).AddTicks(8328), false, "Incredible Plastic Car", 6 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 5,
                columns: new[] { "Description", "ExpectedTimeIn", "ExpectedTimeOut", "VisitDetailName", "VisitId", "VisitorId" },
                values: new object[] { "Atque optio totam autem et nulla et. Qui quibusdam voluptatibus et velit sed voluptatem et quasi. Ea porro provident nulla aut aperiam mollitia exercitationem aperiam occaecati.", new DateTime(2024, 9, 21, 19, 48, 23, 927, DateTimeKind.Local).AddTicks(8416), new DateTime(2024, 9, 22, 19, 48, 23, 927, DateTimeKind.Local).AddTicks(8417), "Rustic Concrete Shirt", 4, 1 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 6,
                columns: new[] { "Description", "ExpectedTimeIn", "ExpectedTimeOut", "Status", "VisitDetailName", "VisitId" },
                values: new object[] { "Deleniti neque quos corporis sed qui minima sapiente. Aut ut ut. Esse id consequatur. Voluptas exercitationem totam dolorum laboriosam aut et pariatur aut architecto. Quasi voluptatum rerum numquam odio est. Illum aut repellendus velit odit vero tempora.", new DateTime(2024, 9, 21, 19, 48, 23, 927, DateTimeKind.Local).AddTicks(8545), new DateTime(2024, 9, 22, 19, 48, 23, 927, DateTimeKind.Local).AddTicks(8547), true, "Ergonomic Wooden Table", 1 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 7,
                columns: new[] { "Description", "ExpectedTimeIn", "ExpectedTimeOut", "Status", "VisitDetailName", "VisitId", "VisitorId" },
                values: new object[] { "In vitae perspiciatis facilis aut nulla sint reprehenderit. At officia ut quaerat maxime tempore. Asperiores sint nam ut. Voluptatibus eveniet enim. Eaque et distinctio vel non a et eos minima. Sapiente nihil sit dolor.", new DateTime(2024, 9, 21, 19, 48, 23, 927, DateTimeKind.Local).AddTicks(8664), new DateTime(2024, 9, 22, 19, 48, 23, 927, DateTimeKind.Local).AddTicks(8666), false, "Refined Concrete Shoes", 5, 1 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 8,
                columns: new[] { "Description", "ExpectedTimeIn", "ExpectedTimeOut", "VisitDetailName", "VisitId", "VisitorId" },
                values: new object[] { "Quisquam voluptatem iste est eum minus saepe quia libero sit. Hic eos voluptate nihil maiores nisi. Beatae voluptatem voluptatum vero labore.", new DateTime(2024, 9, 21, 19, 48, 23, 927, DateTimeKind.Local).AddTicks(8739), new DateTime(2024, 9, 22, 19, 48, 23, 927, DateTimeKind.Local).AddTicks(8741), "Refined Frozen Tuna", 2, 1 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 9,
                columns: new[] { "Description", "ExpectedTimeIn", "ExpectedTimeOut", "Status", "VisitDetailName", "VisitId", "VisitorId" },
                values: new object[] { "Et facere et expedita qui vitae sunt. Quo illo deleniti repellat dignissimos qui est voluptate dicta. Vero dolores itaque odit modi laborum harum.", new DateTime(2024, 9, 21, 19, 48, 23, 927, DateTimeKind.Local).AddTicks(8824), new DateTime(2024, 9, 22, 19, 48, 23, 927, DateTimeKind.Local).AddTicks(8826), false, "Intelligent Rubber Table", 2, 6 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 10,
                columns: new[] { "Description", "ExpectedTimeIn", "ExpectedTimeOut", "VisitDetailName", "VisitId", "VisitorId" },
                values: new object[] { "Laudantium nam consequatur. Aliquam harum modi recusandae et. Cupiditate suscipit nam omnis nisi et dolor quis ab illum. Qui repellat dolores nisi. Explicabo sed quis et repellendus asperiores ea exercitationem tempora. Laboriosam qui et ratione molestias unde fugit molestiae eveniet itaque.", new DateTime(2024, 9, 21, 19, 48, 23, 927, DateTimeKind.Local).AddTicks(8966), new DateTime(2024, 9, 22, 19, 48, 23, 927, DateTimeKind.Local).AddTicks(8967), "Unbranded Soft Shoes", 2, 4 });

            migrationBuilder.UpdateData(
                table: "VisitorSessions",
                keyColumn: "VisitorSessionId",
                keyValue: 1,
                columns: new[] { "CheckinTime", "CheckoutTime", "QRCardId", "VisitDetailId" },
                values: new object[] { new DateTime(2024, 9, 21, 12, 48, 23, 930, DateTimeKind.Utc).AddTicks(2386), new DateTime(2024, 9, 23, 0, 48, 23, 930, DateTimeKind.Utc).AddTicks(2386), 6, 7 });

            migrationBuilder.UpdateData(
                table: "VisitorSessions",
                keyColumn: "VisitorSessionId",
                keyValue: 2,
                columns: new[] { "CheckinTime", "CheckoutTime", "QRCardId", "VisitDetailId" },
                values: new object[] { new DateTime(2024, 9, 21, 12, 48, 23, 930, DateTimeKind.Utc).AddTicks(4073), new DateTime(2024, 9, 23, 0, 48, 23, 930, DateTimeKind.Utc).AddTicks(4073), 10, 4 });

            migrationBuilder.UpdateData(
                table: "VisitorSessions",
                keyColumn: "VisitorSessionId",
                keyValue: 3,
                columns: new[] { "CheckinTime", "CheckoutTime", "GateId", "QRCardId", "VisitDetailId" },
                values: new object[] { new DateTime(2024, 9, 21, 12, 48, 23, 930, DateTimeKind.Utc).AddTicks(4090), new DateTime(2024, 9, 23, 0, 48, 23, 930, DateTimeKind.Utc).AddTicks(4090), 1, 1, 9 });

            migrationBuilder.UpdateData(
                table: "VisitorSessions",
                keyColumn: "VisitorSessionId",
                keyValue: 4,
                columns: new[] { "CheckinTime", "CheckoutTime", "GateId", "QRCardId", "VisitDetailId" },
                values: new object[] { new DateTime(2024, 9, 21, 12, 48, 23, 930, DateTimeKind.Utc).AddTicks(4099), new DateTime(2024, 9, 23, 0, 48, 23, 930, DateTimeKind.Utc).AddTicks(4099), 2, 9, 3 });

            migrationBuilder.UpdateData(
                table: "VisitorSessions",
                keyColumn: "VisitorSessionId",
                keyValue: 5,
                columns: new[] { "CheckinTime", "CheckoutTime", "QRCardId", "VisitDetailId" },
                values: new object[] { new DateTime(2024, 9, 21, 12, 48, 23, 930, DateTimeKind.Utc).AddTicks(4108), new DateTime(2024, 9, 23, 0, 48, 23, 930, DateTimeKind.Utc).AddTicks(4108), 3, 7 });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 1,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Romaguera Group", new DateTime(2024, 9, 4, 16, 7, 17, 129, DateTimeKind.Unspecified).AddTicks(2173), "1tspxqjjb4", "0853154255", false, new DateTime(2024, 9, 4, 16, 7, 17, 129, DateTimeKind.Unspecified).AddTicks(2173), "Dolly Skiles" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 2,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Schulist LLC", new DateTime(2024, 9, 16, 0, 7, 28, 979, DateTimeKind.Unspecified).AddTicks(4044), 2, "vof4gxkegy", "0352895765", true, new DateTime(2024, 9, 16, 0, 7, 28, 979, DateTimeKind.Unspecified).AddTicks(4044), "Moises Tremblay" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 3,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Berge, Rempel and Kirlin", new DateTime(2024, 9, 7, 9, 46, 16, 558, DateTimeKind.Unspecified).AddTicks(9409), "2ker7sltyx", "0487063541", false, new DateTime(2024, 9, 7, 9, 46, 16, 558, DateTimeKind.Unspecified).AddTicks(9409), "Norval Ebert" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 4,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Lehner Inc", new DateTime(2024, 9, 14, 6, 32, 2, 626, DateTimeKind.Unspecified).AddTicks(957), "rnfqv2zswh", "0421454373", true, new DateTime(2024, 9, 14, 6, 32, 2, 626, DateTimeKind.Unspecified).AddTicks(957), "Rafael Hamill" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 5,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Balistreri Group", new DateTime(2024, 9, 8, 9, 31, 49, 295, DateTimeKind.Unspecified).AddTicks(993), 2, "woc9ydwtvc", "0874583943", new DateTime(2024, 9, 8, 9, 31, 49, 295, DateTimeKind.Unspecified).AddTicks(993), "Karlee Vandervort" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 6,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Price LLC", new DateTime(2024, 9, 16, 3, 7, 57, 301, DateTimeKind.Unspecified).AddTicks(7397), "cqt3bszjac", "0205930983", true, new DateTime(2024, 9, 16, 3, 7, 57, 301, DateTimeKind.Unspecified).AddTicks(7397), "Aletha Adams" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 7,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Mitchell Inc", new DateTime(2024, 9, 14, 6, 16, 5, 125, DateTimeKind.Unspecified).AddTicks(8166), "lnrh20nehg", "0105094296", true, new DateTime(2024, 9, 14, 6, 16, 5, 125, DateTimeKind.Unspecified).AddTicks(8166), "Ora Hammes" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 8,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Crona - Crona", new DateTime(2024, 9, 20, 3, 10, 56, 926, DateTimeKind.Unspecified).AddTicks(6022), 2, "g8mhkv72oi", "0405291221", new DateTime(2024, 9, 20, 3, 10, 56, 926, DateTimeKind.Unspecified).AddTicks(6022), "Clint Armstrong" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 9,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Goldner, Waelchi and Weimann", new DateTime(2024, 9, 6, 7, 5, 34, 779, DateTimeKind.Unspecified).AddTicks(8203), "p2tv37h9o7", "0783746442", new DateTime(2024, 9, 6, 7, 5, 34, 779, DateTimeKind.Unspecified).AddTicks(8203), "Imogene Carter" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 10,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Farrell - Konopelski", new DateTime(2024, 9, 10, 23, 8, 58, 907, DateTimeKind.Unspecified).AddTicks(9205), "8e4z58pck4", "0866640852", false, new DateTime(2024, 9, 10, 23, 8, 58, 907, DateTimeKind.Unspecified).AddTicks(9205), "Hellen Deckow" });

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 1,
                columns: new[] { "AcceptLevel", "DateRegister", "DepartmentReasonId" },
                values: new object[] { 1, new DateTime(2024, 9, 14, 1, 21, 37, 434, DateTimeKind.Unspecified).AddTicks(5563), 1 });

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 2,
                columns: new[] { "AcceptLevel", "DateRegister", "DepartmentReasonId", "VisitQuantity" },
                values: new object[] { 1, new DateTime(2024, 9, 6, 5, 32, 46, 885, DateTimeKind.Unspecified).AddTicks(1179), 1, 4 });

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 3,
                columns: new[] { "DateRegister", "DepartmentReasonId", "VisitQuantity" },
                values: new object[] { new DateTime(2024, 9, 9, 12, 49, 55, 578, DateTimeKind.Unspecified).AddTicks(2190), 5, 2 });

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 4,
                columns: new[] { "AcceptLevel", "DateRegister", "DepartmentReasonId", "VisitQuantity" },
                values: new object[] { 3, new DateTime(2024, 9, 9, 22, 49, 6, 451, DateTimeKind.Unspecified).AddTicks(1959), 2, 1 });

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 5,
                columns: new[] { "AcceptLevel", "DateRegister", "DepartmentReasonId", "VisitQuantity" },
                values: new object[] { 2, new DateTime(2024, 9, 1, 1, 42, 46, 637, DateTimeKind.Unspecified).AddTicks(618), 3, 3 });

            migrationBuilder.AddForeignKey(
                name: "FK_VisitorSessions_Gates_GateId",
                table: "VisitorSessions",
                column: "GateId",
                principalTable: "Gates",
                principalColumn: "GateId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VisitorSessions_Users_SecurityID",
                table: "VisitorSessions",
                column: "SecurityID",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
