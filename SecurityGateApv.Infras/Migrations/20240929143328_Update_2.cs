using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SecurityGateApv.Infras.Migrations
{
    /// <inheritdoc />
    public partial class Update_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VisitorDepartment_UserDepartments_UserDepartmentId",
                table: "VisitorDepartment");

            migrationBuilder.DropForeignKey(
                name: "FK_Visitors_Users_UserId",
                table: "Visitors");

            migrationBuilder.DropTable(
                name: "UserDepartments");

            migrationBuilder.DropIndex(
                name: "IX_Visitors_UserId",
                table: "Visitors");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "Visitors");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Visitors");

            migrationBuilder.DropColumn(
                name: "VisitorImage",
                table: "Visitors");

            migrationBuilder.RenameColumn(
                name: "UserDepartmentId",
                table: "VisitorDepartment",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_VisitorDepartment_UserDepartmentId",
                table: "VisitorDepartment",
                newName: "IX_VisitorDepartment_DepartmentId");

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "VisitorDepartment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Users",
                type: "int",
                nullable: true);

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
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Kinh doanh", "Iure vel id doloribus." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                column: "Description",
                value: "Veniam nobis neque laboriosam.");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Chăm sóc khách hàng", "Dicta molestiae accusantium." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Nhân sự", "Totam autem maiores totam." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng IT", "Quae iusto quia officia placeat voluptatum est omnis." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 6,
                column: "Description",
                value: "Ut cumque et distinctio fuga et asperiores ducimus nihil.");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 7,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng R&D", "Perspiciatis aut omnis." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 8,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Nhân sự", "Omnis aut in eum esse quo numquam voluptates et fugit." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 9,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Pháp chế", "Fugiat animi qui itaque et est omnis." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 10,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Kế toán", "Dolor nemo libero." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DepartmentId", "Image" },
                values: new object[] { null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRdCMjLlNPwkWsEFRDeMI8rLlWCVs4mbaa-Xg&s" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "DepartmentId", "Image" },
                values: new object[] { null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRdCMjLlNPwkWsEFRDeMI8rLlWCVs4mbaa-Xg&s" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "DepartmentId", "Image" },
                values: new object[] { 1, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRdCMjLlNPwkWsEFRDeMI8rLlWCVs4mbaa-Xg&s" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "DepartmentId", "Image" },
                values: new object[] { 1, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRdCMjLlNPwkWsEFRDeMI8rLlWCVs4mbaa-Xg&s" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "DepartmentId", "Image" },
                values: new object[] { 1, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRdCMjLlNPwkWsEFRDeMI8rLlWCVs4mbaa-Xg&s" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "DepartmentId", "Image" },
                values: new object[] { null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRdCMjLlNPwkWsEFRDeMI8rLlWCVs4mbaa-Xg&s" });

            migrationBuilder.CreateIndex(
                name: "IX_Users_DepartmentId",
                table: "Users",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Departments_DepartmentId",
                table: "Users",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_VisitorDepartment_Departments_DepartmentId",
                table: "VisitorDepartment",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Departments_DepartmentId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_VisitorDepartment_Departments_DepartmentId",
                table: "VisitorDepartment");

            migrationBuilder.DropIndex(
                name: "IX_Users_DepartmentId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "VisitorDepartment");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "VisitorDepartment",
                newName: "UserDepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_VisitorDepartment_DepartmentId",
                table: "VisitorDepartment",
                newName: "IX_VisitorDepartment_UserDepartmentId");

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "Visitors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Visitors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VisitorImage",
                table: "Visitors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserDepartments",
                columns: table => new
                {
                    UserDepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDepartments", x => x.UserDepartmentId);
                    table.ForeignKey(
                        name: "FK_UserDepartments_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDepartments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Nhân sự", "Autem vel sapiente voluptatibus veniam et et nisi." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                column: "Description",
                value: "Pariatur officiis nisi necessitatibus.");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Nhân sự", "Eum aut aut nostrum eligendi." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng R&D", "Commodi ullam atque est culpa est blanditiis qui." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng R&D", "Reiciendis commodi nihil et debitis harum debitis aspernatur illo." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 6,
                column: "Description",
                value: "Qui est ab nulla illo totam vel ullam consequatur.");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 7,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Chăm sóc khách hàng", "Rem qui omnis totam et quibusdam necessitatibus quia iure." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 8,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng R&D", "Et repudiandae architecto et voluptatem aut suscipit." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 9,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng IT", "Qui quidem id voluptate blanditiis officiis." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 10,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Marketing", "Praesentium hic nisi consectetur similique et quidem vel omnis iure." });

            migrationBuilder.InsertData(
                table: "UserDepartments",
                columns: new[] { "UserDepartmentId", "DepartmentId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 4 },
                    { 2, 1, 3 },
                    { 3, 2, 3 },
                    { 4, 2, 5 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Image",
                value: "data:image/jpeg;base64,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");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "Image",
                value: "data:image/jpeg;base64,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");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "Image",
                value: "data:image/jpeg;base64,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");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "Image",
                value: "data:image/jpeg;base64,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");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "Image",
                value: "data:image/jpeg;base64,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");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "Image",
                value: "data:image/jpeg;base64,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");

            migrationBuilder.CreateIndex(
                name: "IX_Visitors_UserId",
                table: "Visitors",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserDepartments_DepartmentId",
                table: "UserDepartments",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDepartments_UserId",
                table: "UserDepartments",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VisitorDepartment_UserDepartments_UserDepartmentId",
                table: "VisitorDepartment",
                column: "UserDepartmentId",
                principalTable: "UserDepartments",
                principalColumn: "UserDepartmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Visitors_Users_UserId",
                table: "Visitors",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");
        }
    }
}
