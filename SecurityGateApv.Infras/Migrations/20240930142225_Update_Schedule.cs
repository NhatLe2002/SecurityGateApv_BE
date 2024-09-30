using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecurityGateApv.Infras.Migrations
{
    /// <inheritdoc />
    public partial class Update_Schedule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DaysOfProcess",
                table: "Schedules",
                newName: "DaysOfSchedule");

            migrationBuilder.UpdateData(
                table: "CredentialCardTypes",
                keyColumn: "CredentialCardTypeId",
                keyValue: 1,
                column: "Description",
                value: "Dolorem dolores consectetur consequuntur.");

            migrationBuilder.UpdateData(
                table: "CredentialCardTypes",
                keyColumn: "CredentialCardTypeId",
                keyValue: 2,
                columns: new[] { "CredentialCardTypeName", "Description" },
                values: new object[] { "Căn cước công dân", "Sit aut repellat explicabo architecto cupiditate blanditiis voluptatem necessitatibus." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Pháp chế", "Temporibus saepe et voluptas qui architecto quaerat est officiis." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                column: "Description",
                value: "Laboriosam officiis voluptatem totam dolores.");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng IT", "Sed non tempora repellat non accusantium suscipit totam architecto voluptatem." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Marketing", "Fugit porro velit et nesciunt et dicta earum qui dolor." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5,
                column: "Description",
                value: "Illum tenetur sed rerum sunt similique molestias error similique.");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 6,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Marketing", "Saepe impedit sequi doloribus non incidunt." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 7,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Kế toán", "Libero tempora sed suscipit nam aut debitis quas." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 8,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng R&D", "In et impedit quasi omnis odit." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 9,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Chăm sóc khách hàng", "Iste debitis dolor dolores nam quia aut." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 10,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Nhân sự", "Eum reiciendis odit molestiae recusandae odio harum consectetur." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DaysOfSchedule",
                table: "Schedules",
                newName: "DaysOfProcess");

            migrationBuilder.UpdateData(
                table: "CredentialCardTypes",
                keyColumn: "CredentialCardTypeId",
                keyValue: 1,
                column: "Description",
                value: "Incidunt aliquid molestiae tempora sint.");

            migrationBuilder.UpdateData(
                table: "CredentialCardTypes",
                keyColumn: "CredentialCardTypeId",
                keyValue: 2,
                columns: new[] { "CredentialCardTypeName", "Description" },
                values: new object[] { "Giấy phép lái xe", "Eligendi eos eaque vitae accusamus aliquid sunt ducimus accusantium hic." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Marketing", "Illum deleniti id excepturi." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                column: "Description",
                value: "Ea deserunt commodi deleniti dolor maiores nam aut.");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Pháp chế", "Quia quam sed." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Hành chính", "Velit impedit blanditiis dolores." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5,
                column: "Description",
                value: "Veniam dolorem consequatur sed.");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 6,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng R&D", "Hic voluptas et dolorum." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 7,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Pháp chế", "Et consequatur rerum veniam velit eum omnis sunt fuga quia." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 8,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Nhân sự", "Minima esse ratione at qui quasi voluptas." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 9,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Sản xuất", "Ut dolores molestias impedit ab necessitatibus qui suscipit iusto." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 10,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Kế toán", "Debitis facilis fugiat molestias illo est eligendi numquam cupiditate." });
        }
    }
}
