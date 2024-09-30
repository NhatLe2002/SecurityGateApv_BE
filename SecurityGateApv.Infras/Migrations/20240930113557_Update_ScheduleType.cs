using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecurityGateApv.Infras.Migrations
{
    /// <inheritdoc />
    public partial class Update_ScheduleType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ScheduleTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "ScheduleTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
                column: "Description",
                value: "Eligendi eos eaque vitae accusamus aliquid sunt ducimus accusantium hic.");

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
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng IT", "Ea deserunt commodi deleniti dolor maiores nam aut." });

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
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng IT", "Veniam dolorem consequatur sed." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 6,
                column: "Description",
                value: "Hic voluptas et dolorum.");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "ScheduleTypes");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ScheduleTypes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "CredentialCardTypes",
                keyColumn: "CredentialCardTypeId",
                keyValue: 1,
                column: "Description",
                value: "Et error cumque.");

            migrationBuilder.UpdateData(
                table: "CredentialCardTypes",
                keyColumn: "CredentialCardTypeId",
                keyValue: 2,
                column: "Description",
                value: "Modi voluptatem quis vitae ratione quia nam.");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Sản xuất", "Natus eum magni at." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Nhân sự", "Possimus ipsam quia rem molestiae cumque occaecati molestiae explicabo itaque." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Kinh doanh", "Delectus ut unde est ratione aspernatur aliquid praesentium odio tenetur." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Kinh doanh", "Molestiae cupiditate omnis rerum delectus est voluptatem nemo accusantium rerum." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Kế toán", "Sed officia dolores aut." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 6,
                column: "Description",
                value: "Aspernatur eum veniam sapiente.");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 7,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Chăm sóc khách hàng", "Quibusdam et dolorem cupiditate suscipit rerum et." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 8,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Kế toán", "Vel ex voluptas quis." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 9,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Pháp chế", "Eveniet alias distinctio quam." });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 10,
                columns: new[] { "DepartmentName", "Description" },
                values: new object[] { "Phòng Marketing", "Totam est omnis laudantium corrupti quia temporibus quasi error iusto." });
        }
    }
}
