using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecurityGateApv.Infras.Migrations
{
    /// <inheritdoc />
    public partial class NewTableScheduleUserUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotificationUsers_Users_ReceiverID",
                table: "NotificationUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_ScheduleUsers_Users_AssignToId",
                table: "ScheduleUsers");

            migrationBuilder.AddColumn<int>(
                name: "AssignFromId",
                table: "ScheduleUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "CredentialCardTypes",
                keyColumn: "CredentialCardTypeId",
                keyValue: 1,
                columns: new[] { "CredentialCardTypeName", "Description" },
                values: new object[] { "Giấy phép lái xe", "Deleniti corporis beatae dignissimos suscipit." });

            migrationBuilder.UpdateData(
                table: "CredentialCardTypes",
                keyColumn: "CredentialCardTypeId",
                keyValue: 2,
                columns: new[] { "CredentialCardTypeName", "Description" },
                values: new object[] { "Giấy phép lái xe", "Dignissimos at pariatur sit possimus explicabo." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Kinh doanh", "Soluta dolores alias sapiente alias neque rerum." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng R&D", "Quia ut deleniti nihil consectetur corrupti minus." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Hành chính", "Tempora molestiae quia provident nesciunt eos." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Hành chính", "Mollitia optio at voluptate dolorem eum praesentium non amet occaecati." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Kế toán", "Eius numquam adipisci est tempora." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 6,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Pháp chế", "Ex est rerum asperiores." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 7,
                column: "Description",
                value: "Architecto doloremque quaerat omnis voluptate saepe voluptatum omnis voluptate.");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 8,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Kế toán", "Nisi eveniet necessitatibus." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 9,
                column: "Description",
                value: "Iure odio excepturi.");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 10,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Kinh doanh", "Omnis quo blanditiis odio odio ut autem." });

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleUsers_AssignFromId",
                table: "ScheduleUsers",
                column: "AssignFromId");

            migrationBuilder.AddForeignKey(
                name: "FK_NotificationUsers_Users_ReceiverID",
                table: "NotificationUsers",
                column: "ReceiverID",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ScheduleUsers_Users_AssignFromId",
                table: "ScheduleUsers",
                column: "AssignFromId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ScheduleUsers_Users_AssignToId",
                table: "ScheduleUsers",
                column: "AssignToId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotificationUsers_Users_ReceiverID",
                table: "NotificationUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_ScheduleUsers_Users_AssignFromId",
                table: "ScheduleUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_ScheduleUsers_Users_AssignToId",
                table: "ScheduleUsers");

            migrationBuilder.DropIndex(
                name: "IX_ScheduleUsers_AssignFromId",
                table: "ScheduleUsers");

            migrationBuilder.DropColumn(
                name: "AssignFromId",
                table: "ScheduleUsers");

            migrationBuilder.UpdateData(
                table: "CredentialCardTypes",
                keyColumn: "CredentialCardTypeId",
                keyValue: 1,
                columns: new[] { "CredentialCardTypeName", "Description" },
                values: new object[] { "Căn cước công dân", "Ratione nemo modi animi veritatis et eius et voluptas." });

            migrationBuilder.UpdateData(
                table: "CredentialCardTypes",
                keyColumn: "CredentialCardTypeId",
                keyValue: 2,
                columns: new[] { "CredentialCardTypeName", "Description" },
                values: new object[] { "Căn cước công dân", "Ipsa voluptatibus exercitationem aut ut libero amet." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Marketing", "Doloribus omnis dolorum velit officia." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Sản xuất", "Quia nostrum cumque enim deleniti nesciunt vel." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Chăm sóc khách hàng", "Cupiditate aut rerum." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Kinh doanh", "Est delectus consequatur laudantium sunt incidunt laboriosam." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Chăm sóc khách hàng", "Ut quis quia aliquid praesentium." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 6,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng IT", "Id et fugit hic nihil." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 7,
                column: "Description",
                value: "Quidem ut accusamus consequuntur suscipit sit repellat sit.");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 8,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Pháp chế", "Molestiae distinctio velit et earum." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 9,
                column: "Description",
                value: "Enim molestiae sit voluptas nisi labore expedita accusantium vitae numquam.");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 10,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Sản xuất", "Corporis velit error consequatur tempora." });

            migrationBuilder.AddForeignKey(
                name: "FK_NotificationUsers_Users_ReceiverID",
                table: "NotificationUsers",
                column: "ReceiverID",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ScheduleUsers_Users_AssignToId",
                table: "ScheduleUsers",
                column: "AssignToId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
