using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecurityGateApv.Infras.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Users_CreateBy",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_VisitTypes_VisitTypeId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_VisitProjects_Projects_ProcessId",
                table: "VisitProjects");

            migrationBuilder.DropForeignKey(
                name: "FK_VisitProjects_Visits_VisitId",
                table: "VisitProjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Projects",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "VisitorSessionsImages");

            migrationBuilder.RenameTable(
                name: "Projects",
                newName: "Processes");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_VisitTypeId",
                table: "Processes",
                newName: "IX_Processes_VisitTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_CreateBy",
                table: "Processes",
                newName: "IX_Processes_CreateBy");

            migrationBuilder.AlterColumn<int>(
                name: "VisitId",
                table: "VisitProjects",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Processes",
                table: "Processes",
                column: "ProcessId");

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
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 4, new DateTime(2024, 9, 12, 10, 39, 18, 935, DateTimeKind.Utc).AddTicks(5116), "Phòng Kế toán", "Provident corporis ipsum ut rerum earum eveniet unde.", new DateTime(2024, 9, 12, 10, 39, 18, 935, DateTimeKind.Utc).AddTicks(5116) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 5, 19, 8, 54, 401, DateTimeKind.Utc).AddTicks(5868), "Phòng R&D", "Et ullam voluptatibus ut et veniam omnis.", new DateTime(2024, 9, 5, 19, 8, 54, 401, DateTimeKind.Utc).AddTicks(5868) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 21, 20, 46, 8, 825, DateTimeKind.Utc).AddTicks(9876), "Phòng Marketing", "Sunt voluptatem temporibus quidem vero voluptatem dolores odit.", new DateTime(2024, 9, 21, 20, 46, 8, 825, DateTimeKind.Utc).AddTicks(9876) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4,
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 23, 0, 16, 184, DateTimeKind.Utc).AddTicks(9151), "Phòng R&D", "Et sit ut veritatis quo molestiae occaecati sed incidunt.", new DateTime(2024, 9, 25, 23, 0, 16, 184, DateTimeKind.Utc).AddTicks(9151) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5,
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 24, 3, 37, 9, 723, DateTimeKind.Utc).AddTicks(5429), "Phòng Kinh doanh", "Labore cumque quo dolore tenetur velit atque.", new DateTime(2024, 9, 24, 3, 37, 9, 723, DateTimeKind.Utc).AddTicks(5429) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 6,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2024, 9, 26, 8, 25, 51, 490, DateTimeKind.Utc).AddTicks(261), "Phòng Marketing", "In corrupti accusantium ipsa in cumque.", new DateTime(2024, 9, 26, 8, 25, 51, 490, DateTimeKind.Utc).AddTicks(261) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 7,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2024, 9, 22, 9, 33, 6, 856, DateTimeKind.Utc).AddTicks(3259), "Phòng Hành chính", "Nulla dolores culpa velit laboriosam molestiae natus quas cupiditate.", new DateTime(2024, 9, 22, 9, 33, 6, 856, DateTimeKind.Utc).AddTicks(3259) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 8,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 9, 6, 28, 57, 94, DateTimeKind.Utc).AddTicks(1621), "Phòng Marketing", "Ad voluptas ea quos voluptas perferendis.", new DateTime(2024, 9, 9, 6, 28, 57, 94, DateTimeKind.Utc).AddTicks(1621) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 9,
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2024, 9, 6, 8, 46, 44, 544, DateTimeKind.Utc).AddTicks(5399), "Phòng Nhân sự", "Dicta ex sed non deserunt et.", new DateTime(2024, 9, 6, 8, 46, 44, 544, DateTimeKind.Utc).AddTicks(5399) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 10,
                columns: new[] { "AcceptLevel", "CreateDate", "Description", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2024, 9, 15, 18, 2, 25, 778, DateTimeKind.Utc).AddTicks(7334), "Et possimus dolore aut.", new DateTime(2024, 9, 15, 18, 2, 25, 778, DateTimeKind.Utc).AddTicks(7334) });

            migrationBuilder.UpdateData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: 1,
                columns: new[] { "CreateTime", "ProcessName" },
                values: new object[] { new DateTime(2024, 9, 24, 10, 18, 21, 706, DateTimeKind.Utc).AddTicks(8093), "Refined Frozen Shoes" });

            migrationBuilder.UpdateData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: 2,
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 24, 10, 18, 21, 706, DateTimeKind.Utc).AddTicks(9657), "Generic Metal Shoes", true });

            migrationBuilder.UpdateData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: 3,
                columns: new[] { "CreateTime", "ProcessName" },
                values: new object[] { new DateTime(2024, 9, 24, 10, 18, 21, 706, DateTimeKind.Utc).AddTicks(9697), "Rustic Metal Pants" });

            migrationBuilder.UpdateData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: 4,
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 24, 10, 18, 21, 706, DateTimeKind.Utc).AddTicks(9716), "Practical Metal Car", true });

            migrationBuilder.UpdateData(
                table: "Processes",
                keyColumn: "ProcessId",
                keyValue: 5,
                columns: new[] { "CreateTime", "ProcessName" },
                values: new object[] { new DateTime(2024, 9, 24, 10, 18, 21, 706, DateTimeKind.Utc).AddTicks(9734), "Handmade Granite Gloves" });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 1,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("d121bd3a-61d2-4b17-8768-0736f1320a09"), new DateTime(2024, 9, 26, 17, 18, 21, 758, DateTimeKind.Local).AddTicks(4518), new DateTime(2024, 10, 26, 17, 18, 21, 758, DateTimeKind.Local).AddTicks(4518) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 2,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("5ca35913-c384-4beb-9640-0ee291410326"), new DateTime(2024, 9, 26, 17, 18, 21, 758, DateTimeKind.Local).AddTicks(4806), new DateTime(2024, 10, 26, 17, 18, 21, 758, DateTimeKind.Local).AddTicks(4806) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 3,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardTypeId" },
                values: new object[] { new Guid("e71b0fde-687b-42ec-a5f8-d663f7d1f419"), new DateTime(2024, 9, 26, 17, 18, 21, 758, DateTimeKind.Local).AddTicks(4830), new DateTime(2024, 10, 26, 17, 18, 21, 758, DateTimeKind.Local).AddTicks(4830), 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 4,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId" },
                values: new object[] { new Guid("8b069652-4ba1-4f78-b8c6-61f6d5799dc3"), new DateTime(2024, 9, 26, 17, 18, 21, 758, DateTimeKind.Local).AddTicks(4846), new DateTime(2024, 10, 26, 17, 18, 21, 758, DateTimeKind.Local).AddTicks(4846), 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 5,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("e5d8b6e7-6b45-49ba-a74f-2da81e112e5c"), new DateTime(2024, 9, 26, 17, 18, 21, 758, DateTimeKind.Local).AddTicks(4859), new DateTime(2024, 10, 26, 17, 18, 21, 758, DateTimeKind.Local).AddTicks(4859) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 6,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardTypeId" },
                values: new object[] { new Guid("dac12ce8-adaf-4b0b-84b1-c42353e080be"), new DateTime(2024, 9, 26, 17, 18, 21, 758, DateTimeKind.Local).AddTicks(4871), new DateTime(2024, 10, 26, 17, 18, 21, 758, DateTimeKind.Local).AddTicks(4871), 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 7,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("6c423121-1120-469b-ab03-b4fe5799d8dc"), new DateTime(2024, 9, 26, 17, 18, 21, 758, DateTimeKind.Local).AddTicks(4904), new DateTime(2024, 10, 26, 17, 18, 21, 758, DateTimeKind.Local).AddTicks(4904) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 8,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId" },
                values: new object[] { new Guid("f44dfe96-44c8-4b8b-ba77-d5d084060a8d"), new DateTime(2024, 9, 26, 17, 18, 21, 758, DateTimeKind.Local).AddTicks(4916), new DateTime(2024, 10, 26, 17, 18, 21, 758, DateTimeKind.Local).AddTicks(4916), 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 9,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId" },
                values: new object[] { new Guid("d6c87007-0df4-4b9f-a2aa-e68a78501927"), new DateTime(2024, 9, 26, 17, 18, 21, 758, DateTimeKind.Local).AddTicks(4928), new DateTime(2024, 10, 26, 17, 18, 21, 758, DateTimeKind.Local).AddTicks(4928), 1 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 10,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardTypeId" },
                values: new object[] { new Guid("3e6fb589-5785-40f1-806f-74f9e34a1295"), new DateTime(2024, 9, 26, 17, 18, 21, 758, DateTimeKind.Local).AddTicks(4939), new DateTime(2024, 10, 26, 17, 18, 21, 758, DateTimeKind.Local).AddTicks(4939), 2 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 4,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 2, 22 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 5,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 13 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 6,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 6, 9 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 7,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 2, 11 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 8,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 20 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 9,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 25 });

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
                values: new object[] { 8, 19 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 12,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 1, 6 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 13,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 4, 24 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 14,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 5, 6 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 15,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 2, 18 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 16,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 21 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 17,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 9, 12 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 18,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 2, 21 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 19,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 7 });

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
                values: new object[] { 8, 19 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 22,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 10 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 23,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 8, 25 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 10, 18, 21, 697, DateTimeKind.Utc).AddTicks(4051), new DateTime(2024, 9, 26, 10, 18, 21, 697, DateTimeKind.Utc).AddTicks(4057) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 26, 10, 18, 21, 697, DateTimeKind.Utc).AddTicks(4060), new DateTime(2024, 9, 26, 10, 18, 21, 697, DateTimeKind.Utc).AddTicks(4061) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 26, 10, 18, 21, 697, DateTimeKind.Utc).AddTicks(4063), new DateTime(2024, 9, 26, 10, 18, 21, 697, DateTimeKind.Utc).AddTicks(4064) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 26, 10, 18, 21, 697, DateTimeKind.Utc).AddTicks(4065), new DateTime(2024, 9, 26, 10, 18, 21, 697, DateTimeKind.Utc).AddTicks(4066) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 26, 10, 18, 21, 697, DateTimeKind.Utc).AddTicks(4067), new DateTime(2024, 9, 26, 10, 18, 21, 697, DateTimeKind.Utc).AddTicks(4068) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 21, 11, 8, 27, 65, DateTimeKind.Unspecified).AddTicks(3812), "gmail.com19@yahoo.com", "Nicola Schumm", "m28i1c", "0941386371", 4, new DateTime(2024, 9, 21, 11, 8, 27, 65, DateTimeKind.Unspecified).AddTicks(3812), "Juston.Luettgen15" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 17, 3, 32, 12, 127, DateTimeKind.Unspecified).AddTicks(2928), "gmail.com.Lakin62@yahoo.com", "Daryl Waters", "d3gsrl", "0672315306", 2, new DateTime(2024, 9, 17, 3, 32, 12, 127, DateTimeKind.Unspecified).AddTicks(2928), "Sonya_Koepp" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 7, 6, 25, 11, 310, DateTimeKind.Unspecified).AddTicks(4040), "gmail.com_Murazik@hotmail.com", "Emmitt Murphy", "2rtd22", "0177873338", new DateTime(2024, 9, 7, 6, 25, 11, 310, DateTimeKind.Unspecified).AddTicks(4040), "Jamey.Price" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 14, 20, 30, 45, 95, DateTimeKind.Unspecified).AddTicks(7659), "gmail.com.Kuhic@gmail.com", "Kenyatta Marquardt", "mfay50", "0538167012", new DateTime(2024, 9, 14, 20, 30, 45, 95, DateTimeKind.Unspecified).AddTicks(7659), "Valentina63" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 7, 1, 5, 38, 275, DateTimeKind.Unspecified).AddTicks(2120), "gmail.com_Nienow80@yahoo.com", "Fleta Kerluke", "uctitj", "0635456333", 2, new DateTime(2024, 9, 7, 1, 5, 38, 275, DateTimeKind.Unspecified).AddTicks(2120), "Rahul56" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 25, 1, 54, 4, 880, DateTimeKind.Unspecified).AddTicks(3555), "gmail.com_Marvin0@yahoo.com", "Julia Huel", "umekjm", "0577056792", new DateTime(2024, 9, 25, 1, 54, 4, 880, DateTimeKind.Unspecified).AddTicks(3555), "Raven43" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 4, 21, 1, 1, 310, DateTimeKind.Unspecified).AddTicks(6639), "gmail.com.Schumm@gmail.com", "Jayden Schimmel", "ot7hr2", "0904967901", new DateTime(2024, 9, 4, 21, 1, 1, 310, DateTimeKind.Unspecified).AddTicks(6639), "Lia_Ryan20" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 9, 10, 5, 11, 874, DateTimeKind.Unspecified).AddTicks(6237), "gmail.com_Barton40@yahoo.com", "Abbie Balistreri", "thja82", "0639628462", 1, new DateTime(2024, 9, 9, 10, 5, 11, 874, DateTimeKind.Unspecified).AddTicks(6237), "Angelita12" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 10, 13, 38, 50, 825, DateTimeKind.Unspecified).AddTicks(7385), "gmail.com19@hotmail.com", "Madisyn Jakubowski", "ph99l3", "0136237305", 3, new DateTime(2024, 9, 10, 13, 38, 50, 825, DateTimeKind.Unspecified).AddTicks(7385), "Danny79" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 22, 12, 59, 58, 315, DateTimeKind.Unspecified).AddTicks(9739), "gmail.com.Olson@gmail.com", "Curtis Aufderhar", "tssaaf", "0955816379", 1, new DateTime(2024, 9, 22, 12, 59, 58, 315, DateTimeKind.Unspecified).AddTicks(9739), "Lurline7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 1, 23, 12, 41, 853, DateTimeKind.Unspecified).AddTicks(9191), "gmail.com_Botsford68@yahoo.com", "Justyn Schmidt", "7d29e4", "0483274594", 3, new DateTime(2024, 9, 1, 23, 12, 41, 853, DateTimeKind.Unspecified).AddTicks(9191), "Jerry16" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 13, 7, 1, 21, 202, DateTimeKind.Unspecified).AddTicks(4719), "gmail.com.Kunze@hotmail.com", "Zander Dooley", "s2f3m2", "0102274509", new DateTime(2024, 9, 13, 7, 1, 21, 202, DateTimeKind.Unspecified).AddTicks(4719), "Letitia84" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 22, 2, 16, 32, 897, DateTimeKind.Unspecified).AddTicks(5871), "gmail.com_Weissnat@yahoo.com", "Ewell Ondricka", "ifhy3t", "0356888970", 4, new DateTime(2024, 9, 22, 2, 16, 32, 897, DateTimeKind.Unspecified).AddTicks(5871), "Arely.Mayer83" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 1, 4, 26, 7, 573, DateTimeKind.Unspecified).AddTicks(2290), "gmail.com_Stokes@hotmail.com", "Torey Champlin", "9w25et", "0266539416", 2, new DateTime(2024, 9, 1, 4, 26, 7, 573, DateTimeKind.Unspecified).AddTicks(2290), "Merritt61" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 6, 6, 13, 24, 105, DateTimeKind.Unspecified).AddTicks(5298), "gmail.com.Haag23@yahoo.com", "Lee Stiedemann", "pale0s", "0317516408", 2, new DateTime(2024, 9, 6, 6, 13, 24, 105, DateTimeKind.Unspecified).AddTicks(5298), "Elisabeth.Trantow88" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 7, 11, 28, 14, 501, DateTimeKind.Unspecified).AddTicks(4269), "gmail.com.Dooley@gmail.com", "Zachery Romaguera", "051cws", "0668963461", 1, new DateTime(2024, 9, 7, 11, 28, 14, 501, DateTimeKind.Unspecified).AddTicks(4269), "Glenna_Roberts" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 19, 8, 15, 31, 921, DateTimeKind.Unspecified).AddTicks(6655), "gmail.com.Bartoletti30@gmail.com", "Elisha Lowe", "idn1ua", "0800530207", new DateTime(2024, 9, 19, 8, 15, 31, 921, DateTimeKind.Unspecified).AddTicks(6655), "Mertie.Schmitt4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 20, 15, 20, 17, 857, DateTimeKind.Unspecified).AddTicks(2920), "gmail.com3@yahoo.com", "Tod Rohan", "zk0ia4", "0112015621", 1, new DateTime(2024, 9, 20, 15, 20, 17, 857, DateTimeKind.Unspecified).AddTicks(2920), "Cecilia94" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 15, 18, 59, 57, 952, DateTimeKind.Unspecified).AddTicks(5910), "gmail.com_Johnston9@yahoo.com", "Velda Murazik", "y9n7w7", "0855406429", 2, new DateTime(2024, 9, 15, 18, 59, 57, 952, DateTimeKind.Unspecified).AddTicks(5910), "Savion.Paucek28" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 15, 5, 1, 54, 248, DateTimeKind.Unspecified).AddTicks(1170), "gmail.com.Predovic@gmail.com", "Drake Greenfelder", "3kgfgo", "0228389435", 3, new DateTime(2024, 9, 15, 5, 1, 54, 248, DateTimeKind.Unspecified).AddTicks(1170), "Vernie79" });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 1,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Facilis voluptas iure ut dolorum similique eum porro ipsum necessitatibus. Nulla eos consequatur fugit autem voluptas consequatur. Occaecati veritatis magni quas iusto. Quis nobis officia aut et aut ea. Eligendi alias recusandae optio sed magnam pariatur at qui eveniet.", new DateTime(2024, 10, 25, 17, 18, 21, 720, DateTimeKind.Local).AddTicks(1551), new DateTime(2024, 9, 25, 17, 18, 21, 720, DateTimeKind.Local).AddTicks(1496), 2 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 2,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Explicabo quibusdam expedita ut earum exercitationem optio earum reiciendis. Quaerat et laboriosam. Ipsa aut quisquam qui. Eos labore quos omnis veniam fugit qui autem aut facilis.", new DateTime(2024, 10, 25, 17, 18, 21, 720, DateTimeKind.Local).AddTicks(2055), new DateTime(2024, 9, 25, 17, 18, 21, 720, DateTimeKind.Local).AddTicks(2051), 2 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 3,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Perspiciatis sunt et exercitationem. Iusto et ad quam cum expedita ullam qui eveniet recusandae. Aut quia corporis sint et placeat officia voluptatibus.", new DateTime(2024, 9, 27, 17, 18, 21, 733, DateTimeKind.Local).AddTicks(8895), new DateTime(2024, 9, 26, 17, 18, 21, 733, DateTimeKind.Local).AddTicks(8854), 6 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 4,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Sed dignissimos enim non. Qui fuga velit. Voluptas dolor ab sint nemo ipsa et autem. Est fuga tenetur. Ab enim expedita modi. Sunt fugit dolores nihil quia amet sit aperiam fugiat.", new DateTime(2024, 9, 27, 17, 18, 21, 733, DateTimeKind.Local).AddTicks(9177), new DateTime(2024, 9, 26, 17, 18, 21, 733, DateTimeKind.Local).AddTicks(9175), 5 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 5,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Voluptates qui qui inventore non quam. Magnam aliquid sunt. Rerum explicabo eum consequatur dicta deserunt reprehenderit eum molestias pariatur. Eius ut deleniti et corrupti laboriosam id sint.", new DateTime(2024, 9, 27, 17, 18, 21, 735, DateTimeKind.Local).AddTicks(530), new DateTime(2024, 9, 26, 17, 18, 21, 735, DateTimeKind.Local).AddTicks(502), 7 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 6,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Autem illo et. Eveniet consequuntur numquam quam nam mollitia. Sit adipisci ratione voluptatem vero rem est nisi laudantium.", new DateTime(2024, 9, 27, 17, 18, 21, 735, DateTimeKind.Local).AddTicks(836), new DateTime(2024, 9, 26, 17, 18, 21, 735, DateTimeKind.Local).AddTicks(834), 8 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 7,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Et labore exercitationem consequuntur id quo placeat maiores. Sint voluptatem minus. Sunt possimus qui pariatur dolor enim necessitatibus quibusdam et rerum. Quam sequi libero ea.", new DateTime(2024, 9, 27, 17, 18, 21, 736, DateTimeKind.Local).AddTicks(2372), new DateTime(2024, 9, 26, 17, 18, 21, 736, DateTimeKind.Local).AddTicks(2345), 1 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 8,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Nostrum eveniet est adipisci laboriosam. Incidunt consequatur id autem et. Ut porro nihil aut magni a. Quisquam dolores aut sint ea doloremque facere. Magni consequatur sed. Deserunt vero vero et laborum quae iure voluptatem explicabo voluptas.", new DateTime(2024, 9, 27, 17, 18, 21, 736, DateTimeKind.Local).AddTicks(2618), new DateTime(2024, 9, 26, 17, 18, 21, 736, DateTimeKind.Local).AddTicks(2617) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 9,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Natus qui a et aliquid autem voluptas nihil quam. Enim maiores qui accusamus laboriosam quidem. Dolorem quam nulla repellendus quas nihil. Voluptates eaque quam ullam cum. Voluptatem sit temporibus et totam dolores earum ipsam. Aut corporis nostrum harum totam inventore ipsam ratione cum.", new DateTime(2024, 9, 27, 17, 18, 21, 737, DateTimeKind.Local).AddTicks(3652), new DateTime(2024, 9, 26, 17, 18, 21, 737, DateTimeKind.Local).AddTicks(3620), 3 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 10,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Libero facere dolorum nisi aut quo dicta corrupti in possimus. Est quaerat rerum et alias voluptatem a quis soluta. Accusamus unde tenetur quae autem et odit dicta quaerat. Recusandae facilis eaque ut voluptatem dicta dolorem. Libero doloremque sed omnis nostrum.", new DateTime(2024, 9, 27, 17, 18, 21, 737, DateTimeKind.Local).AddTicks(3912), new DateTime(2024, 9, 26, 17, 18, 21, 737, DateTimeKind.Local).AddTicks(3910) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 11,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Perspiciatis incidunt neque vel et nam iure alias doloribus. Amet aut sed exercitationem inventore. Eveniet amet ipsum ab a est et et et dolores. Asperiores sed aut similique sapiente voluptatum ipsum dolorem animi. Quia rerum in omnis sit libero fugit dolor magnam. Ipsa id consectetur repellendus.", new DateTime(2024, 9, 27, 17, 18, 21, 738, DateTimeKind.Local).AddTicks(4468), new DateTime(2024, 9, 26, 17, 18, 21, 738, DateTimeKind.Local).AddTicks(4442), 10 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 12,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Necessitatibus esse unde non. Consequuntur voluptatum unde. Magni et tempore nemo. Animi eos et inventore alias ut aut consequuntur dolorem alias. Quidem saepe quia repellendus et vero iusto soluta voluptatem. Non officiis beatae exercitationem dolores vel.", new DateTime(2024, 9, 27, 17, 18, 21, 738, DateTimeKind.Local).AddTicks(4713), new DateTime(2024, 9, 26, 17, 18, 21, 738, DateTimeKind.Local).AddTicks(4711), 8 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 13,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Non odit eos provident rerum. Laudantium in corporis. Vero repellendus nam facilis perferendis deleniti doloribus est ipsam sed. Dolor aspernatur repellat numquam cumque sed voluptatem et.", new DateTime(2024, 9, 27, 17, 18, 21, 741, DateTimeKind.Local).AddTicks(2149), new DateTime(2024, 9, 26, 17, 18, 21, 741, DateTimeKind.Local).AddTicks(2109), 1 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 14,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Error id voluptas aliquam. Dicta officiis dolores suscipit aut. Natus voluptatem provident nemo consectetur molestiae. Quaerat molestias molestiae placeat unde maxime omnis ut illum consequatur. Non fugit veniam minus enim modi sed consequatur totam possimus. Accusamus animi tempore deleniti nihil aut aut.", new DateTime(2024, 9, 27, 17, 18, 21, 741, DateTimeKind.Local).AddTicks(2454), new DateTime(2024, 9, 26, 17, 18, 21, 741, DateTimeKind.Local).AddTicks(2451), 10 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 15,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Facilis vero aliquam rerum ratione neque. Voluptatem pariatur hic quae asperiores. Nulla qui consequuntur est non.", new DateTime(2024, 9, 27, 17, 18, 21, 742, DateTimeKind.Local).AddTicks(4694), new DateTime(2024, 9, 26, 17, 18, 21, 742, DateTimeKind.Local).AddTicks(4658), 9 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 16,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Quisquam aliquam alias voluptatem tenetur saepe dolor ullam. Aut recusandae culpa magnam nisi. Quae vero id et dolorem doloribus qui voluptatem illum. Quos illum quo iure in quod earum. Quasi nesciunt quos in voluptate necessitatibus qui ut amet.", new DateTime(2024, 9, 27, 17, 18, 21, 742, DateTimeKind.Local).AddTicks(4957), new DateTime(2024, 9, 26, 17, 18, 21, 742, DateTimeKind.Local).AddTicks(4954), 6 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 17,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Quia ullam minima et ab aut aut vel. Autem quia harum alias iusto dolores. Dolorem voluptatem minima quo nesciunt nobis. A a eligendi velit quae quisquam quod. Harum architecto dolore id est vero.", new DateTime(2024, 9, 27, 17, 18, 21, 743, DateTimeKind.Local).AddTicks(5724), new DateTime(2024, 9, 26, 17, 18, 21, 743, DateTimeKind.Local).AddTicks(5694), 10 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 18,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Reprehenderit adipisci aperiam velit. Reprehenderit repellat suscipit quis est sequi hic. Ducimus et aliquam in in neque. Tenetur corporis labore sunt voluptatem eos. Et numquam et eum.", new DateTime(2024, 9, 27, 17, 18, 21, 743, DateTimeKind.Local).AddTicks(6099), new DateTime(2024, 9, 26, 17, 18, 21, 743, DateTimeKind.Local).AddTicks(6097), 5 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 19,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Praesentium iusto rem. Sit quaerat assumenda illo tempora et et dolores consequatur. Eveniet minus amet placeat consectetur voluptatem possimus nobis. Accusamus sed officia nam.", new DateTime(2024, 9, 27, 17, 18, 21, 744, DateTimeKind.Local).AddTicks(6924), new DateTime(2024, 9, 26, 17, 18, 21, 744, DateTimeKind.Local).AddTicks(6896), 2 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 20,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Suscipit minima dolor. Dolor deserunt a officiis. Rerum perspiciatis magnam. Cupiditate enim sapiente voluptatem. Id asperiores voluptatem non sit eius cum quam fuga.", new DateTime(2024, 9, 27, 17, 18, 21, 744, DateTimeKind.Local).AddTicks(7140), new DateTime(2024, 9, 26, 17, 18, 21, 744, DateTimeKind.Local).AddTicks(7137), 3 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 21,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Aut quisquam aliquid est esse at. Voluptatem voluptas quod qui soluta occaecati. Non vitae architecto numquam harum non.", new DateTime(2024, 9, 27, 17, 18, 21, 745, DateTimeKind.Local).AddTicks(8745), new DateTime(2024, 9, 26, 17, 18, 21, 745, DateTimeKind.Local).AddTicks(8717) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 22,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Et excepturi nemo sequi. Velit saepe dicta ut mollitia non incidunt. Sed voluptas neque natus laboriosam nostrum deleniti neque. Veritatis excepturi facere atque. Qui facilis itaque voluptatum.", new DateTime(2024, 9, 27, 17, 18, 21, 745, DateTimeKind.Local).AddTicks(8989), new DateTime(2024, 9, 26, 17, 18, 21, 745, DateTimeKind.Local).AddTicks(8987), 7 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 23,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Labore ut reiciendis ut tenetur sapiente libero consequatur. Possimus repellendus doloribus ullam ipsum vel. Consequuntur cumque dolorum est provident odio et maxime earum.", new DateTime(2024, 9, 27, 17, 18, 21, 747, DateTimeKind.Local).AddTicks(624), new DateTime(2024, 9, 26, 17, 18, 21, 747, DateTimeKind.Local).AddTicks(590), 3 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 24,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Delectus dolorem maxime aspernatur dolor necessitatibus voluptatem aspernatur atque et. Modi sint vero debitis. Aspernatur eos nulla fugiat ad. Earum enim id ut eum dolor.", new DateTime(2024, 9, 27, 17, 18, 21, 747, DateTimeKind.Local).AddTicks(862), new DateTime(2024, 9, 26, 17, 18, 21, 747, DateTimeKind.Local).AddTicks(860), 7 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 25,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Suscipit vel sunt sunt eaque eos velit quam commodi. Consequuntur quae numquam et officia inventore voluptas odit. Ab repellendus aspernatur perspiciatis quas atque repudiandae aut. Quis voluptate numquam quis corporis dolores molestiae suscipit. Sunt nam debitis consequuntur voluptates sit. Doloremque qui doloremque vitae veritatis et numquam.", new DateTime(2024, 9, 27, 17, 18, 21, 748, DateTimeKind.Local).AddTicks(4551), new DateTime(2024, 9, 26, 17, 18, 21, 748, DateTimeKind.Local).AddTicks(4496), 5 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 26,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Quod inventore praesentium omnis earum soluta molestiae magnam iusto magni. Voluptatum minus quia rerum recusandae qui eos. Illo consequuntur nihil. Pariatur dignissimos praesentium aperiam omnis qui nostrum. Porro sunt quia. Dignissimos corporis numquam fuga sit.", new DateTime(2024, 9, 27, 17, 18, 21, 748, DateTimeKind.Local).AddTicks(5025), new DateTime(2024, 9, 26, 17, 18, 21, 748, DateTimeKind.Local).AddTicks(5021), 9 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 27,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Qui iusto est totam repellat. Facilis velit consequuntur cumque eligendi quidem. Nostrum animi voluptatem cupiditate libero rerum. Sit quis voluptas est occaecati est. A minus sequi ratione qui consectetur sequi corrupti laudantium consequuntur.", new DateTime(2024, 9, 27, 17, 18, 21, 750, DateTimeKind.Local).AddTicks(6177), new DateTime(2024, 9, 26, 17, 18, 21, 750, DateTimeKind.Local).AddTicks(6126), 8 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 28,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Fuga et officia et quibusdam sit aut quibusdam. Et qui tempore. In illo ad et expedita delectus vel et dolore et. Dolor quasi laudantium commodi quia. Ea eius impedit consequatur et repudiandae dolorem nulla maiores.", new DateTime(2024, 9, 27, 17, 18, 21, 750, DateTimeKind.Local).AddTicks(6613), new DateTime(2024, 9, 26, 17, 18, 21, 750, DateTimeKind.Local).AddTicks(6609) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 29,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Doloremque doloremque voluptas eius fuga rerum maiores fuga. Non eum dolor praesentium nisi et adipisci. Ducimus quis inventore molestiae. Aliquid ad eum aut nam aut vel ut. Aperiam ab eum et velit.", new DateTime(2024, 9, 27, 17, 18, 21, 753, DateTimeKind.Local).AddTicks(9608), new DateTime(2024, 9, 26, 17, 18, 21, 753, DateTimeKind.Local).AddTicks(9549), 7 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 30,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Similique ad sint cum corrupti laudantium. Quis quam nihil corporis. Aut dolor aspernatur fugit unde eum dignissimos vel.", new DateTime(2024, 9, 27, 17, 18, 21, 753, DateTimeKind.Local).AddTicks(9993), new DateTime(2024, 9, 26, 17, 18, 21, 753, DateTimeKind.Local).AddTicks(9989), 4 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 31,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Nisi quia sed. Dolores deleniti animi quas et libero culpa ratione aut recusandae. Sed quis veritatis laborum voluptates eligendi quod.", new DateTime(2024, 9, 27, 17, 18, 21, 756, DateTimeKind.Local).AddTicks(1532), new DateTime(2024, 9, 26, 17, 18, 21, 756, DateTimeKind.Local).AddTicks(1476) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 32,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Minus asperiores ut debitis. Esse aspernatur exercitationem fuga dolores et amet. Sed deleniti in ex voluptas enim consectetur et. Beatae qui dolorum ipsa expedita suscipit.", new DateTime(2024, 9, 27, 17, 18, 21, 756, DateTimeKind.Local).AddTicks(1948), new DateTime(2024, 9, 26, 17, 18, 21, 756, DateTimeKind.Local).AddTicks(1944), 9 });

            migrationBuilder.UpdateData(
                table: "VisitProjects",
                keyColumn: "VisitProcessId",
                keyValue: 1,
                columns: new[] { "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { new DateTime(2024, 10, 25, 17, 18, 21, 709, DateTimeKind.Local).AddTicks(2084), new DateTime(2024, 9, 25, 17, 18, 21, 709, DateTimeKind.Local).AddTicks(2046) });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 1,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Cummerata Inc", new DateTime(2024, 9, 14, 18, 29, 7, 367, DateTimeKind.Unspecified).AddTicks(7069), 1, "sixdew9akn", "0484931191", true, new DateTime(2024, 9, 14, 18, 29, 7, 367, DateTimeKind.Unspecified).AddTicks(7069), "Ethelyn Collier" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 2,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Christiansen LLC", new DateTime(2024, 9, 17, 2, 13, 27, 487, DateTimeKind.Unspecified).AddTicks(6013), "sjfy1246ba", "0400459689", new DateTime(2024, 9, 17, 2, 13, 27, 487, DateTimeKind.Unspecified).AddTicks(6013), "Alberto Harvey" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 3,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Kris Inc", new DateTime(2024, 9, 6, 22, 45, 15, 323, DateTimeKind.Unspecified).AddTicks(8296), 2, "l4n0s1cfcu", "0738543481", true, new DateTime(2024, 9, 6, 22, 45, 15, 323, DateTimeKind.Unspecified).AddTicks(8296), "Samanta Schneider" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 4,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Cummings, Beier and Spinka", new DateTime(2024, 9, 1, 3, 48, 10, 393, DateTimeKind.Unspecified).AddTicks(7065), "e347nmhru6", "0236574185", false, new DateTime(2024, 9, 1, 3, 48, 10, 393, DateTimeKind.Unspecified).AddTicks(7065), "Adrianna Bruen" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 5,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Bins LLC", new DateTime(2024, 9, 3, 21, 27, 12, 207, DateTimeKind.Unspecified).AddTicks(5517), 2, "ph2qmc895u", "0622483669", false, new DateTime(2024, 9, 3, 21, 27, 12, 207, DateTimeKind.Unspecified).AddTicks(5517), "Maxine Gutkowski" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 6,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Tremblay, Boyle and Blanda", new DateTime(2024, 9, 18, 15, 59, 45, 504, DateTimeKind.Unspecified).AddTicks(3243), "vfz9udp928", "0204637495", new DateTime(2024, 9, 18, 15, 59, 45, 504, DateTimeKind.Unspecified).AddTicks(3243), "Nadia Zboncak" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 7,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Veum - Johnston", new DateTime(2024, 9, 10, 1, 44, 0, 465, DateTimeKind.Unspecified).AddTicks(3877), "9gpva451nn", "0436330726", new DateTime(2024, 9, 10, 1, 44, 0, 465, DateTimeKind.Unspecified).AddTicks(3877), "Blaise Bartoletti" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 8,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Monahan - Crist", new DateTime(2024, 9, 2, 10, 29, 12, 787, DateTimeKind.Unspecified).AddTicks(1469), "8h1js8kbty", "0498457297", new DateTime(2024, 9, 2, 10, 29, 12, 787, DateTimeKind.Unspecified).AddTicks(1469), "Ardith Bins" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 9,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Schiller - Hessel", new DateTime(2024, 9, 24, 5, 44, 45, 57, DateTimeKind.Unspecified).AddTicks(5307), 2, "n7nyitw5n7", "0123580206", new DateTime(2024, 9, 24, 5, 44, 45, 57, DateTimeKind.Unspecified).AddTicks(5307), "Timothy Wunsch" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 10,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Jerde - Koelpin", new DateTime(2024, 9, 18, 2, 11, 42, 994, DateTimeKind.Unspecified).AddTicks(2826), "ggsr7fv7tm", "0442672208", true, new DateTime(2024, 9, 18, 2, 11, 42, 994, DateTimeKind.Unspecified).AddTicks(2826), "Rosie Bailey" });

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 1,
                column: "DateRegister",
                value: new DateTime(2024, 9, 24, 17, 18, 21, 708, DateTimeKind.Local).AddTicks(1045));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 2,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 10, 18, 21, 732, DateTimeKind.Utc).AddTicks(6354));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 3,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 10, 18, 21, 732, DateTimeKind.Utc).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 4,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 10, 18, 21, 732, DateTimeKind.Utc).AddTicks(6543));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 5,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 10, 18, 21, 732, DateTimeKind.Utc).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 6,
                column: "DateRegister",
                value: new DateTime(2024, 9, 26, 10, 18, 21, 732, DateTimeKind.Utc).AddTicks(6561));

            migrationBuilder.AddForeignKey(
                name: "FK_Processes_Users_CreateBy",
                table: "Processes",
                column: "CreateBy",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Processes_VisitTypes_VisitTypeId",
                table: "Processes",
                column: "VisitTypeId",
                principalTable: "VisitTypes",
                principalColumn: "VisitTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VisitProjects_Processes_ProcessId",
                table: "VisitProjects",
                column: "ProcessId",
                principalTable: "Processes",
                principalColumn: "ProcessId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VisitProjects_Visits_VisitId",
                table: "VisitProjects",
                column: "VisitId",
                principalTable: "Visits",
                principalColumn: "VisitId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Processes_Users_CreateBy",
                table: "Processes");

            migrationBuilder.DropForeignKey(
                name: "FK_Processes_VisitTypes_VisitTypeId",
                table: "Processes");

            migrationBuilder.DropForeignKey(
                name: "FK_VisitProjects_Processes_ProcessId",
                table: "VisitProjects");

            migrationBuilder.DropForeignKey(
                name: "FK_VisitProjects_Visits_VisitId",
                table: "VisitProjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Processes",
                table: "Processes");

            migrationBuilder.RenameTable(
                name: "Processes",
                newName: "Projects");

            migrationBuilder.RenameIndex(
                name: "IX_Processes_VisitTypeId",
                table: "Projects",
                newName: "IX_Projects_VisitTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Processes_CreateBy",
                table: "Projects",
                newName: "IX_Projects_CreateBy");

            migrationBuilder.AlterColumn<int>(
                name: "VisitId",
                table: "VisitProjects",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "VisitorSessionsImages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Projects",
                table: "Projects",
                column: "ProcessId");

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
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2024, 9, 15, 12, 25, 59, 440, DateTimeKind.Utc).AddTicks(3325), "Phòng R&D", "Vero est ex.", new DateTime(2024, 9, 15, 12, 25, 59, 440, DateTimeKind.Utc).AddTicks(3325) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4,
                columns: new[] { "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 21, 27, 45, DateTimeKind.Utc).AddTicks(9847), "Phòng Nhân sự", "Consequuntur eum reprehenderit sunt tenetur ad eligendi qui.", new DateTime(2024, 9, 3, 20, 21, 27, 45, DateTimeKind.Utc).AddTicks(9847) });

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
                columns: new[] { "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 9, 25, 11, 53, 53, 220, DateTimeKind.Utc).AddTicks(9329), "Phòng Kinh doanh", "Et accusantium nesciunt et.", new DateTime(2024, 9, 25, 11, 53, 53, 220, DateTimeKind.Utc).AddTicks(9329) });

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
                columns: new[] { "AcceptLevel", "CreateDate", "Description", "UpdatedDate" },
                values: new object[] { 4, new DateTime(2024, 9, 13, 8, 10, 17, 906, DateTimeKind.Utc).AddTicks(6360), "Et quidem aut.", new DateTime(2024, 9, 13, 8, 10, 17, 906, DateTimeKind.Utc).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProcessId",
                keyValue: 1,
                columns: new[] { "CreateTime", "ProcessName" },
                values: new object[] { new DateTime(2024, 9, 24, 3, 37, 46, 498, DateTimeKind.Utc).AddTicks(2497), "Gorgeous Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProcessId",
                keyValue: 2,
                columns: new[] { "CreateTime", "ProcessName", "Status" },
                values: new object[] { new DateTime(2024, 9, 24, 3, 37, 46, 498, DateTimeKind.Utc).AddTicks(4245), "Tasty Soft Gloves", false });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProcessId",
                keyValue: 3,
                columns: new[] { "CreateTime", "ProcessName" },
                values: new object[] { new DateTime(2024, 9, 24, 3, 37, 46, 498, DateTimeKind.Utc).AddTicks(4273), "Rustic Steel Bacon" });

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
                columns: new[] { "CreateTime", "ProcessName" },
                values: new object[] { new DateTime(2024, 9, 24, 3, 37, 46, 498, DateTimeKind.Utc).AddTicks(4311), "Handmade Cotton Hat" });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 1,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("76ab3780-b8cc-4a0a-866e-9bd546f46a97"), new DateTime(2024, 9, 26, 10, 37, 46, 532, DateTimeKind.Local).AddTicks(749), new DateTime(2024, 10, 26, 10, 37, 46, 532, DateTimeKind.Local).AddTicks(749) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 2,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate" },
                values: new object[] { new Guid("1f3a948e-5e97-43cf-afef-8a7871003b4f"), new DateTime(2024, 9, 26, 10, 37, 46, 532, DateTimeKind.Local).AddTicks(917), new DateTime(2024, 10, 26, 10, 37, 46, 532, DateTimeKind.Local).AddTicks(917) });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 3,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardTypeId" },
                values: new object[] { new Guid("0f1debf3-dbb9-4063-9dc8-7566c08c5b63"), new DateTime(2024, 9, 26, 10, 37, 46, 532, DateTimeKind.Local).AddTicks(939), new DateTime(2024, 10, 26, 10, 37, 46, 532, DateTimeKind.Local).AddTicks(939), 1 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 4,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId" },
                values: new object[] { new Guid("b8985168-d4ce-40f9-b138-e1fcd0415099"), new DateTime(2024, 9, 26, 10, 37, 46, 532, DateTimeKind.Local).AddTicks(948), new DateTime(2024, 10, 26, 10, 37, 46, 532, DateTimeKind.Local).AddTicks(948), 1 });

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
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardTypeId" },
                values: new object[] { new Guid("eac4d56a-17fd-428f-8ec8-5874184a3c42"), new DateTime(2024, 9, 26, 10, 37, 46, 532, DateTimeKind.Local).AddTicks(963), new DateTime(2024, 10, 26, 10, 37, 46, 532, DateTimeKind.Local).AddTicks(963), 1 });

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
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId" },
                values: new object[] { new Guid("fa5d6e8d-1fe8-4001-809a-29e578998bb2"), new DateTime(2024, 9, 26, 10, 37, 46, 532, DateTimeKind.Local).AddTicks(977), new DateTime(2024, 10, 26, 10, 37, 46, 532, DateTimeKind.Local).AddTicks(977), 1 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 9,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId" },
                values: new object[] { new Guid("b482ac66-b645-4531-8778-233c1cc82c2c"), new DateTime(2024, 9, 26, 10, 37, 46, 532, DateTimeKind.Local).AddTicks(989), new DateTime(2024, 10, 26, 10, 37, 46, 532, DateTimeKind.Local).AddTicks(989), 2 });

            migrationBuilder.UpdateData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 10,
                columns: new[] { "CardGuidId", "CreateDate", "LastCancelDate", "QRCardTypeId" },
                values: new object[] { new Guid("62e19307-2f5c-4ce6-ba81-3ffa603e9106"), new DateTime(2024, 9, 26, 10, 37, 46, 532, DateTimeKind.Local).AddTicks(996), new DateTime(2024, 10, 26, 10, 37, 46, 532, DateTimeKind.Local).AddTicks(996), 1 });

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
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 4, 18 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 8,
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 5, 15 });

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
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 5, 7 });

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
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[] { 7, 21 });

            migrationBuilder.UpdateData(
                table: "UserDepartments",
                keyColumn: "UserDepartmentId",
                keyValue: 20,
                column: "UserId",
                value: 24);

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 24, 6, 46, 55, 959, DateTimeKind.Unspecified).AddTicks(2103), "gmail.com43@yahoo.com", "King Torp", "0imnq9", "0802649440", 2, new DateTime(2024, 9, 24, 6, 46, 55, 959, DateTimeKind.Unspecified).AddTicks(2103), "Jordan37" });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 11, 6, 52, 5, 994, DateTimeKind.Unspecified).AddTicks(5987), "gmail.com16@yahoo.com", "Vince Anderson", "5icz3x", "0356080466", new DateTime(2024, 9, 11, 6, 52, 5, 994, DateTimeKind.Unspecified).AddTicks(5987), "Willis_Rogahn99" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 15, 3, 41, 26, 998, DateTimeKind.Unspecified).AddTicks(7127), "gmail.com_Johns77@hotmail.com", "Josefina Lind", "wapuio", "0217542496", new DateTime(2024, 9, 15, 3, 41, 26, 998, DateTimeKind.Unspecified).AddTicks(7127), "Mellie95" });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 12, 9, 7, 3, 242, DateTimeKind.Unspecified).AddTicks(5109), "gmail.com18@hotmail.com", "Porter D'Amore", "3a8f6i", "0234341175", new DateTime(2024, 9, 12, 9, 7, 3, 242, DateTimeKind.Unspecified).AddTicks(5109), "Madelynn83" });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 7, 21, 47, 24, 526, DateTimeKind.Unspecified).AddTicks(7138), "gmail.com2@yahoo.com", "Ludie Conroy", "mp54ev", "0846285375", new DateTime(2024, 9, 7, 21, 47, 24, 526, DateTimeKind.Unspecified).AddTicks(7138), "Alfonso_Goyette27" });

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
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 12, 11, 45, 18, 666, DateTimeKind.Unspecified).AddTicks(378), "gmail.com_Mayert26@gmail.com", "Janis Gutkowski", "wptsg8", "0981421746", 5, new DateTime(2024, 9, 12, 11, 45, 18, 666, DateTimeKind.Unspecified).AddTicks(378), "Cheyanne41" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 10, 16, 14, 45, 586, DateTimeKind.Unspecified).AddTicks(4452), "gmail.com.Kuphal95@hotmail.com", "Dillon Grant", "f6gngb", "0498073103", 1, new DateTime(2024, 9, 10, 16, 14, 45, 586, DateTimeKind.Unspecified).AddTicks(4452), "Margie_Cummerata72" });

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
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Perferendis rem eum quibusdam accusantium tenetur. Ea distinctio nesciunt fugiat beatae dicta ab nisi quaerat minima. Possimus consectetur sit consectetur aliquid voluptatem quisquam repellendus. Iure eum sit.", new DateTime(2024, 10, 25, 10, 37, 46, 510, DateTimeKind.Local).AddTicks(797), new DateTime(2024, 9, 25, 10, 37, 46, 510, DateTimeKind.Local).AddTicks(742), 1 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 2,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Dolorum assumenda accusantium ea eligendi saepe et dolores. Ea provident officiis fugiat temporibus voluptatum. Velit nesciunt temporibus perspiciatis qui. Vitae nulla qui officiis quia. Saepe est rerum non aliquid nisi aut optio. Reprehenderit animi est minima eaque voluptatem.", new DateTime(2024, 10, 25, 10, 37, 46, 510, DateTimeKind.Local).AddTicks(1243), new DateTime(2024, 9, 25, 10, 37, 46, 510, DateTimeKind.Local).AddTicks(1241), 1 });

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
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Et ipsum laboriosam. Ut aut officia nesciunt vel qui quia odit eum exercitationem. Alias odio quae accusamus aut autem perferendis sed. Eum et nobis necessitatibus non blanditiis numquam nisi cumque tempore. Non dolor quae. Doloremque et minus quia adipisci dolor totam.", new DateTime(2024, 9, 27, 10, 37, 46, 514, DateTimeKind.Local).AddTicks(6147), new DateTime(2024, 9, 26, 10, 37, 46, 514, DateTimeKind.Local).AddTicks(6145) });

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
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Quos maiores at consequuntur quidem doloremque velit ullam facere sed. Quaerat officia officia et totam atque. Est ut sunt iusto earum natus laborum. Dolores eius autem architecto et eaque. Autem alias vitae consequuntur aut.", new DateTime(2024, 9, 27, 10, 37, 46, 515, DateTimeKind.Local).AddTicks(7099), new DateTime(2024, 9, 26, 10, 37, 46, 515, DateTimeKind.Local).AddTicks(7097) });

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
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Et et et quo voluptates ullam quis. Nulla veniam ea est facilis quia iure consequuntur a ut. Sed debitis explicabo dicta expedita beatae est omnis praesentium. Ipsa aut similique.", new DateTime(2024, 9, 27, 10, 37, 46, 521, DateTimeKind.Local).AddTicks(8497), new DateTime(2024, 9, 26, 10, 37, 46, 521, DateTimeKind.Local).AddTicks(8495), 1 });

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
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Velit nihil enim repellendus. Facere perspiciatis commodi numquam dignissimos facere. Quia voluptatem ipsum inventore sunt non dolore ea nihil. Error sint incidunt rerum modi aut. Vel sapiente debitis eos. Voluptatibus distinctio rem quidem laudantium quia incidunt dolores itaque repellendus.", new DateTime(2024, 9, 27, 10, 37, 46, 524, DateTimeKind.Local).AddTicks(4487), new DateTime(2024, 9, 26, 10, 37, 46, 524, DateTimeKind.Local).AddTicks(4454) });

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
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Unde perferendis quasi doloribus architecto rerum. Dolorum est vel perspiciatis reprehenderit quaerat optio. Ipsam ullam rerum qui nesciunt.", new DateTime(2024, 9, 27, 10, 37, 46, 527, DateTimeKind.Local).AddTicks(7475), new DateTime(2024, 9, 26, 10, 37, 46, 527, DateTimeKind.Local).AddTicks(7449), 7 });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 28,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Ab dicta qui maiores sint aut. Soluta quas deleniti. Assumenda ea ut. Omnis neque sint corporis accusamus quia quam modi adipisci fuga. At eligendi sint soluta. Necessitatibus enim deserunt consequatur reiciendis nesciunt sit.", new DateTime(2024, 9, 27, 10, 37, 46, 527, DateTimeKind.Local).AddTicks(7714), new DateTime(2024, 9, 26, 10, 37, 46, 527, DateTimeKind.Local).AddTicks(7712) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 29,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Eos saepe in modi est neque possimus consequatur eum. Voluptate quis explicabo nobis doloremque eum maiores sunt id. Quaerat ut dolorem vel necessitatibus non ullam expedita error. Sunt at distinctio repudiandae ea autem. Qui pariatur quo minima fugit.", new DateTime(2024, 9, 27, 10, 37, 46, 529, DateTimeKind.Local).AddTicks(6758), new DateTime(2024, 9, 26, 10, 37, 46, 529, DateTimeKind.Local).AddTicks(6724), 9 });

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
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate" },
                values: new object[] { "Iusto blanditiis id ut placeat quia molestiae eos illum. Animi sint nobis adipisci. Consectetur voluptates similique officia accusantium.", new DateTime(2024, 9, 27, 10, 37, 46, 530, DateTimeKind.Local).AddTicks(8160), new DateTime(2024, 9, 26, 10, 37, 46, 530, DateTimeKind.Local).AddTicks(8124) });

            migrationBuilder.UpdateData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 32,
                columns: new[] { "Description", "ExpectedEndDate", "ExpectedStartDate", "VisitorId" },
                values: new object[] { "Omnis ab officia sit atque ratione eum aperiam. Necessitatibus totam alias labore. Eos dignissimos ab ut quia.", new DateTime(2024, 9, 27, 10, 37, 46, 530, DateTimeKind.Local).AddTicks(8368), new DateTime(2024, 9, 26, 10, 37, 46, 530, DateTimeKind.Local).AddTicks(8366), 4 });

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
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Marquardt - Yundt", new DateTime(2024, 9, 18, 5, 17, 24, 30, DateTimeKind.Unspecified).AddTicks(9787), 2, "pvc7uan331", "0490385705", false, new DateTime(2024, 9, 18, 5, 17, 24, 30, DateTimeKind.Unspecified).AddTicks(9787), "Sandrine Leuschke" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 2,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Green - O'Reilly", new DateTime(2024, 9, 13, 14, 55, 0, 674, DateTimeKind.Unspecified).AddTicks(3630), "s6er3nssjs", "0383993078", new DateTime(2024, 9, 13, 14, 55, 0, 674, DateTimeKind.Unspecified).AddTicks(3630), "Drew Stanton" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 3,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Ebert LLC", new DateTime(2024, 9, 9, 4, 0, 41, 603, DateTimeKind.Unspecified).AddTicks(5646), 1, "4ns90cdp5u", "0891297487", false, new DateTime(2024, 9, 9, 4, 0, 41, 603, DateTimeKind.Unspecified).AddTicks(5646), "Sherwood Farrell" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 4,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Carter, Carroll and Wehner", new DateTime(2024, 9, 23, 21, 41, 9, 449, DateTimeKind.Unspecified).AddTicks(7119), "zav15xkr1t", "0376460894", true, new DateTime(2024, 9, 23, 21, 41, 9, 449, DateTimeKind.Unspecified).AddTicks(7119), "Alessandro Effertz" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 5,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Hoppe, Zboncak and Wyman", new DateTime(2024, 9, 16, 3, 57, 47, 302, DateTimeKind.Unspecified).AddTicks(4037), 1, "p82hnkwaqp", "0989444664", true, new DateTime(2024, 9, 16, 3, 57, 47, 302, DateTimeKind.Unspecified).AddTicks(4037), "Liza Ernser" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 6,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Blanda, Halvorson and Hand", new DateTime(2024, 9, 5, 8, 33, 52, 310, DateTimeKind.Unspecified).AddTicks(1414), "0q2vzusmvv", "0637470226", new DateTime(2024, 9, 5, 8, 33, 52, 310, DateTimeKind.Unspecified).AddTicks(1414), "Destin Gottlieb" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 7,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "Erdman - Lowe", new DateTime(2024, 9, 6, 23, 5, 50, 586, DateTimeKind.Unspecified).AddTicks(6761), "8m1qqp38zp", "0570849680", new DateTime(2024, 9, 6, 23, 5, 50, 586, DateTimeKind.Unspecified).AddTicks(6761), "Braulio Cormier" });

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
                columns: new[] { "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "UpdatedDate", "VisitorName" },
                values: new object[] { "McDermott, Larson and Jast", new DateTime(2024, 9, 3, 16, 49, 31, 156, DateTimeKind.Unspecified).AddTicks(2632), 1, "alg07j5uo3", "0975273201", new DateTime(2024, 9, 3, 16, 49, 31, 156, DateTimeKind.Unspecified).AddTicks(2632), "Lorenza Haag" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 10,
                columns: new[] { "CompanyName", "CreatedDate", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[] { "Batz, Walter and Lehner", new DateTime(2024, 9, 14, 7, 6, 38, 637, DateTimeKind.Unspecified).AddTicks(7634), "xqr9rp76gp", "0149874652", false, new DateTime(2024, 9, 14, 7, 6, 38, 637, DateTimeKind.Unspecified).AddTicks(7634), "Ilene Fisher" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Users_CreateBy",
                table: "Projects",
                column: "CreateBy",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_VisitTypes_VisitTypeId",
                table: "Projects",
                column: "VisitTypeId",
                principalTable: "VisitTypes",
                principalColumn: "VisitTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VisitProjects_Projects_ProcessId",
                table: "VisitProjects",
                column: "ProcessId",
                principalTable: "Projects",
                principalColumn: "ProcessId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VisitProjects_Visits_VisitId",
                table: "VisitProjects",
                column: "VisitId",
                principalTable: "Visits",
                principalColumn: "VisitId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
