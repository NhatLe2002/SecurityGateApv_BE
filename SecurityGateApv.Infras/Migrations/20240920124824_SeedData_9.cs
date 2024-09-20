using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SecurityGateApv.Infras.Migrations
{
    /// <inheritdoc />
    public partial class SeedData_9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StatusName",
                table: "QRCardStatus",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "CredentialCardTypes",
                columns: new[] { "CredentialCardTypeId", "CredentialCardTypeName" },
                values: new object[,]
                {
                    { 1, "Giấy phép lái xe" },
                    { 2, "Căn cước công dân" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "AcceptLevel", "CreateDate", "DepartmentName", "Description", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2024, 9, 10, 4, 26, 30, 689, DateTimeKind.Utc).AddTicks(5219), "Phòng IT", "Eveniet culpa illo veniam odit qui eaque voluptatum nisi.", new DateTime(2024, 9, 10, 4, 26, 30, 689, DateTimeKind.Utc).AddTicks(5219) },
                    { 2, 1, new DateTime(2024, 9, 9, 3, 0, 16, 76, DateTimeKind.Utc).AddTicks(9562), "Phòng Sản xuất", "Consequatur fuga ducimus nam aperiam quod illum.", new DateTime(2024, 9, 9, 3, 0, 16, 76, DateTimeKind.Utc).AddTicks(9562) },
                    { 3, 3, new DateTime(2024, 9, 12, 7, 10, 45, 613, DateTimeKind.Utc).AddTicks(9426), "Phòng Marketing", "Enim nesciunt distinctio est debitis fuga illo consectetur.", new DateTime(2024, 9, 12, 7, 10, 45, 613, DateTimeKind.Utc).AddTicks(9426) },
                    { 4, 5, new DateTime(2024, 9, 3, 8, 17, 38, 109, DateTimeKind.Utc).AddTicks(9333), "Phòng Sản xuất", "Voluptates omnis sunt.", new DateTime(2024, 9, 3, 8, 17, 38, 109, DateTimeKind.Utc).AddTicks(9333) },
                    { 5, 1, new DateTime(2024, 9, 7, 14, 15, 58, 121, DateTimeKind.Utc).AddTicks(7591), "Phòng Hành chính", "Consequatur nesciunt minima possimus veniam quia.", new DateTime(2024, 9, 7, 14, 15, 58, 121, DateTimeKind.Utc).AddTicks(7591) },
                    { 6, 5, new DateTime(2024, 9, 16, 15, 4, 4, 832, DateTimeKind.Utc).AddTicks(6401), "Phòng Marketing", "Est aperiam hic.", new DateTime(2024, 9, 16, 15, 4, 4, 832, DateTimeKind.Utc).AddTicks(6401) },
                    { 7, 2, new DateTime(2024, 9, 10, 14, 43, 46, 351, DateTimeKind.Utc).AddTicks(4240), "Phòng Nhân sự", "Ut fugiat eligendi voluptatem ab quod labore adipisci consequuntur sed.", new DateTime(2024, 9, 10, 14, 43, 46, 351, DateTimeKind.Utc).AddTicks(4240) },
                    { 8, 2, new DateTime(2024, 9, 13, 2, 28, 12, 904, DateTimeKind.Utc).AddTicks(9219), "Phòng Hành chính", "Pariatur modi nemo ut distinctio voluptatem sed voluptatem repellendus.", new DateTime(2024, 9, 13, 2, 28, 12, 904, DateTimeKind.Utc).AddTicks(9219) },
                    { 9, 4, new DateTime(2024, 9, 3, 15, 58, 53, 706, DateTimeKind.Utc).AddTicks(5232), "Phòng Hành chính", "Molestias eos in consequuntur reprehenderit modi incidunt ab quibusdam sed.", new DateTime(2024, 9, 3, 15, 58, 53, 706, DateTimeKind.Utc).AddTicks(5232) },
                    { 10, 5, new DateTime(2024, 9, 8, 13, 29, 7, 683, DateTimeKind.Utc).AddTicks(7023), "Phòng Sản xuất", "Magnam error et assumenda deserunt consequatur explicabo ut.", new DateTime(2024, 9, 8, 13, 29, 7, 683, DateTimeKind.Utc).AddTicks(7023) }
                });

            migrationBuilder.InsertData(
                table: "Gates",
                columns: new[] { "GateId", "GateCoordinate", "GateName" },
                values: new object[,]
                {
                    { 1, "Ra vào trong ngày", "Cổng 1" },
                    { 2, "Ra vào trong ngày", "Cổng 2" }
                });

            migrationBuilder.InsertData(
                table: "QRCardStatus",
                columns: new[] { "QRCardStatusId", "StatusName", "StatusNumber" },
                values: new object[,]
                {
                    { 1, "Active", 1 },
                    { 2, "Inactive", 0 }
                });

            migrationBuilder.InsertData(
                table: "QRCardType",
                columns: new[] { "QRCardTypeId", "CardTypeName", "TypeDescription" },
                values: new object[,]
                {
                    { 1, "Employee", "Employee QR Card" },
                    { 2, "Visitor", "Visitor QR Card" }
                });

            migrationBuilder.InsertData(
                table: "Reasons",
                columns: new[] { "ReasonId", "Description", "ReasonName" },
                values: new object[,]
                {
                    { 1, "Labore quidem dolore minus aut ad.", "Refined Metal Soap" },
                    { 2, "Ut quisquam voluptates assumenda tempore nihil eaque.", "Unbranded Frozen Fish" },
                    { 3, "Eaque magnam dicta.", "Intelligent Plastic Chips" },
                    { 4, "Soluta illum debitis quia.", "Small Soft Bacon" },
                    { 5, "Recusandae natus aut.", "Sleek Plastic Keyboard" }
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
                table: "DepartmentReasons",
                columns: new[] { "DepartmentReasonId", "DepartmentId", "Description", "Name", "ReasonId" },
                values: new object[,]
                {
                    { 1, 2, "Eos autem aut temporibus commodi quis quia ad doloremque ut.", "Generic Metal Shirt", 3 },
                    { 2, 2, "Nisi temporibus dolore aspernatur.", "Incredible Frozen Shoes", 3 },
                    { 3, 9, "Iste qui voluptatem ut deleniti maxime corporis delectus laboriosam.", "Ergonomic Concrete Bike", 1 },
                    { 4, 6, "Et quo quaerat ipsa et libero.", "Ergonomic Cotton Sausages", 5 },
                    { 5, 10, "Cumque saepe est est molestias id nobis rerum.", "Unbranded Plastic Chips", 2 },
                    { 6, 1, "Aut possimus sed voluptas ea occaecati voluptate expedita ut.", "Rustic Concrete Shirt", 3 },
                    { 7, 8, "Eius voluptatum repudiandae possimus.", "Incredible Concrete Salad", 2 },
                    { 8, 2, "Rem in alias sunt.", "Ergonomic Concrete Bike", 5 },
                    { 9, 1, "Quaerat qui est qui delectus quia id non quibusdam.", "Awesome Granite Bike", 5 },
                    { 10, 7, "Porro dolor in error amet voluptatum.", "Rustic Steel Chicken", 4 },
                    { 11, 7, "Itaque labore eligendi adipisci.", "Generic Plastic Computer", 4 },
                    { 12, 1, "Temporibus minus enim in voluptatem rerum alias.", "Rustic Soft Sausages", 2 },
                    { 13, 8, "Blanditiis molestias nesciunt et molestias sint quia inventore molestias sed.", "Licensed Frozen Chair", 1 },
                    { 14, 1, "Vel nesciunt itaque in nostrum iste.", "Intelligent Cotton Pizza", 2 },
                    { 15, 5, "Sint reiciendis quis odio aut illum.", "Practical Plastic Bacon", 2 },
                    { 16, 2, "Tempora quo alias et ut placeat eos molestiae voluptatum.", "Sleek Granite Gloves", 3 },
                    { 17, 4, "Consequatur temporibus sed commodi soluta aut natus iste impedit et.", "Ergonomic Rubber Sausages", 3 },
                    { 18, 10, "Qui culpa ex et.", "Intelligent Concrete Shoes", 2 },
                    { 19, 6, "Maxime vel atque dolores in officiis.", "Generic Soft Hat", 2 },
                    { 20, 3, "A repudiandae voluptatum.", "Awesome Steel Car", 5 }
                });

            migrationBuilder.InsertData(
                table: "QRCards",
                columns: new[] { "QRCardId", "CardGuidId", "CreateDate", "LastCancelDate", "QRCardStatusId", "QRCardTypeId" },
                values: new object[,]
                {
                    { 1, new Guid("fcfb0bcc-d518-4085-876f-3ea91d62b56f"), new DateTime(2024, 9, 20, 19, 48, 23, 929, DateTimeKind.Local).AddTicks(1020), new DateTime(2024, 10, 20, 19, 48, 23, 929, DateTimeKind.Local).AddTicks(1020), 2, 1 },
                    { 2, new Guid("1e5815de-226b-4b71-840f-6106e52568b3"), new DateTime(2024, 9, 20, 19, 48, 23, 929, DateTimeKind.Local).AddTicks(1211), new DateTime(2024, 10, 20, 19, 48, 23, 929, DateTimeKind.Local).AddTicks(1211), 2, 1 },
                    { 3, new Guid("44fffa77-db0a-4cca-b23c-f5568f80b193"), new DateTime(2024, 9, 20, 19, 48, 23, 929, DateTimeKind.Local).AddTicks(1224), new DateTime(2024, 10, 20, 19, 48, 23, 929, DateTimeKind.Local).AddTicks(1224), 2, 2 },
                    { 4, new Guid("78774d5e-3084-4fc3-bca4-2f3e02a9ce07"), new DateTime(2024, 9, 20, 19, 48, 23, 929, DateTimeKind.Local).AddTicks(1233), new DateTime(2024, 10, 20, 19, 48, 23, 929, DateTimeKind.Local).AddTicks(1233), 2, 1 },
                    { 5, new Guid("c590675c-ea3e-4663-8725-e1b0dd006f01"), new DateTime(2024, 9, 20, 19, 48, 23, 929, DateTimeKind.Local).AddTicks(1251), new DateTime(2024, 10, 20, 19, 48, 23, 929, DateTimeKind.Local).AddTicks(1251), 1, 2 },
                    { 6, new Guid("3a72cf98-5da6-4a99-90c1-c19a5ab971e4"), new DateTime(2024, 9, 20, 19, 48, 23, 929, DateTimeKind.Local).AddTicks(1259), new DateTime(2024, 10, 20, 19, 48, 23, 929, DateTimeKind.Local).AddTicks(1259), 1, 1 },
                    { 7, new Guid("db04521d-3196-446c-b4f9-83b9979df3bd"), new DateTime(2024, 9, 20, 19, 48, 23, 929, DateTimeKind.Local).AddTicks(1266), new DateTime(2024, 10, 20, 19, 48, 23, 929, DateTimeKind.Local).AddTicks(1266), 2, 2 },
                    { 8, new Guid("50cf87c8-bd64-413c-bd0e-900c2cbdac8c"), new DateTime(2024, 9, 20, 19, 48, 23, 929, DateTimeKind.Local).AddTicks(1273), new DateTime(2024, 10, 20, 19, 48, 23, 929, DateTimeKind.Local).AddTicks(1273), 2, 2 },
                    { 9, new Guid("c7802cd1-c959-4c9d-a51d-48e4c7f5cbc8"), new DateTime(2024, 9, 20, 19, 48, 23, 929, DateTimeKind.Local).AddTicks(1279), new DateTime(2024, 10, 20, 19, 48, 23, 929, DateTimeKind.Local).AddTicks(1279), 2, 1 },
                    { 10, new Guid("a789af1e-1625-4a75-bb29-85058b0c0ef8"), new DateTime(2024, 9, 20, 19, 48, 23, 929, DateTimeKind.Local).AddTicks(1286), new DateTime(2024, 10, 20, 19, 48, 23, 929, DateTimeKind.Local).AddTicks(1286), 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "Status", "UpdatedDate", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 20, 12, 48, 23, 912, DateTimeKind.Utc).AddTicks(3291), "admin1@example.com", "Admin One", "123", "0123456789", 1, "Active", new DateTime(2024, 9, 20, 12, 48, 23, 912, DateTimeKind.Utc).AddTicks(3303), "admin1" },
                    { 2, new DateTime(2024, 6, 20, 12, 48, 23, 912, DateTimeKind.Utc).AddTicks(3306), "manager1@example.com", "Manager One", "123", "0987654321", 2, "Active", new DateTime(2024, 9, 20, 12, 48, 23, 912, DateTimeKind.Utc).AddTicks(3307), "manager1" },
                    { 3, new DateTime(2024, 7, 20, 12, 48, 23, 912, DateTimeKind.Utc).AddTicks(3309), "employee1@example.com", "Department Manager One", "123", "0112223334", 3, "Active", new DateTime(2024, 9, 20, 12, 48, 23, 912, DateTimeKind.Utc).AddTicks(3310), "DM1" },
                    { 4, new DateTime(2024, 8, 20, 12, 48, 23, 912, DateTimeKind.Utc).AddTicks(3311), "hr1@example.com", "Staff One", "123", "0223334445", 4, "Active", new DateTime(2024, 9, 20, 12, 48, 23, 912, DateTimeKind.Utc).AddTicks(3312), "Staff1" },
                    { 5, new DateTime(2024, 5, 20, 12, 48, 23, 912, DateTimeKind.Utc).AddTicks(3313), "it1@example.com", "Security One", "123", "0334445556", 5, "Active", new DateTime(2024, 9, 20, 12, 48, 23, 912, DateTimeKind.Utc).AddTicks(3314), "Security1" },
                    { 6, new DateTime(2024, 9, 4, 14, 52, 30, 896, DateTimeKind.Unspecified).AddTicks(5047), "gmail.com.Rath3@hotmail.com", "Dayana Murray", "1jgari", "0494709628", 3, "Active", new DateTime(2024, 9, 4, 14, 52, 30, 896, DateTimeKind.Unspecified).AddTicks(5047), "Amos14" },
                    { 7, new DateTime(2024, 9, 8, 1, 36, 45, 93, DateTimeKind.Unspecified).AddTicks(3087), "gmail.com.Champlin48@yahoo.com", "Lily Ritchie", "v1atiw", "0786469089", 2, "Active", new DateTime(2024, 9, 8, 1, 36, 45, 93, DateTimeKind.Unspecified).AddTicks(3087), "Joanny24" },
                    { 8, new DateTime(2024, 9, 1, 18, 50, 19, 452, DateTimeKind.Unspecified).AddTicks(9756), "gmail.com17@gmail.com", "Maximilian Effertz", "9gy1mm", "0819469217", 4, "Active", new DateTime(2024, 9, 1, 18, 50, 19, 452, DateTimeKind.Unspecified).AddTicks(9756), "Kyra_Bauch48" },
                    { 9, new DateTime(2024, 9, 6, 16, 38, 3, 483, DateTimeKind.Unspecified).AddTicks(3801), "gmail.com31@hotmail.com", "Bettie Reichert", "0j8sb7", "0397173325", 2, "Active", new DateTime(2024, 9, 6, 16, 38, 3, 483, DateTimeKind.Unspecified).AddTicks(3801), "Rosella.Goldner97" },
                    { 10, new DateTime(2024, 9, 15, 21, 32, 35, 64, DateTimeKind.Unspecified).AddTicks(4127), "gmail.com.Gislason@hotmail.com", "Audra Pacocha", "58p1j3", "0533310956", 2, "Active", new DateTime(2024, 9, 15, 21, 32, 35, 64, DateTimeKind.Unspecified).AddTicks(4127), "Tod_Purdy10" },
                    { 11, new DateTime(2024, 9, 19, 12, 9, 20, 839, DateTimeKind.Unspecified).AddTicks(7512), "gmail.com4@gmail.com", "Birdie Kuhlman", "nohzw1", "0154790706", 4, "Active", new DateTime(2024, 9, 19, 12, 9, 20, 839, DateTimeKind.Unspecified).AddTicks(7512), "Mohammad_Turcotte" },
                    { 12, new DateTime(2024, 9, 15, 7, 16, 43, 35, DateTimeKind.Unspecified).AddTicks(7933), "gmail.com.Swaniawski@hotmail.com", "Fabiola Williamson", "sro2o6", "0319271086", 1, "Active", new DateTime(2024, 9, 15, 7, 16, 43, 35, DateTimeKind.Unspecified).AddTicks(7933), "Kirsten68" },
                    { 13, new DateTime(2024, 9, 17, 2, 13, 48, 488, DateTimeKind.Unspecified).AddTicks(7596), "gmail.com.Gutkowski37@gmail.com", "Veda D'Amore", "zocg54", "0753983410", 4, "Active", new DateTime(2024, 9, 17, 2, 13, 48, 488, DateTimeKind.Unspecified).AddTicks(7596), "Bartholome.Konopelski" },
                    { 14, new DateTime(2024, 9, 16, 17, 20, 42, 737, DateTimeKind.Unspecified).AddTicks(5738), "gmail.com.Graham84@hotmail.com", "Garrison Kreiger", "kuaywz", "0224259543", 1, "Active", new DateTime(2024, 9, 16, 17, 20, 42, 737, DateTimeKind.Unspecified).AddTicks(5738), "Paige.Hodkiewicz" },
                    { 15, new DateTime(2024, 9, 8, 11, 6, 3, 303, DateTimeKind.Unspecified).AddTicks(1951), "gmail.com74@gmail.com", "Roxane Graham", "5geyd0", "0384796402", 4, "Active", new DateTime(2024, 9, 8, 11, 6, 3, 303, DateTimeKind.Unspecified).AddTicks(1951), "Amparo.Shields" },
                    { 16, new DateTime(2024, 9, 8, 18, 38, 9, 80, DateTimeKind.Unspecified).AddTicks(4890), "gmail.com18@yahoo.com", "Evans Stracke", "nnmw5q", "0997319411", 4, "Active", new DateTime(2024, 9, 8, 18, 38, 9, 80, DateTimeKind.Unspecified).AddTicks(4890), "Reed_Terry" },
                    { 17, new DateTime(2024, 9, 6, 21, 47, 57, 504, DateTimeKind.Unspecified).AddTicks(41), "gmail.com.Beatty@hotmail.com", "Madyson Schulist", "cip2bu", "0456142837", 3, "Active", new DateTime(2024, 9, 6, 21, 47, 57, 504, DateTimeKind.Unspecified).AddTicks(41), "Wallace_Okuneva" },
                    { 18, new DateTime(2024, 9, 12, 17, 55, 21, 113, DateTimeKind.Unspecified).AddTicks(4356), "gmail.com34@gmail.com", "Shana Hilll", "wctrv4", "0608570233", 4, "Active", new DateTime(2024, 9, 12, 17, 55, 21, 113, DateTimeKind.Unspecified).AddTicks(4356), "Grayson50" },
                    { 19, new DateTime(2024, 9, 17, 4, 22, 4, 488, DateTimeKind.Unspecified).AddTicks(8766), "gmail.com.Gaylord91@gmail.com", "Zackary Predovic", "bybcp7", "0645931406", 2, "Active", new DateTime(2024, 9, 17, 4, 22, 4, 488, DateTimeKind.Unspecified).AddTicks(8766), "Kiara_Metz43" },
                    { 20, new DateTime(2024, 9, 14, 17, 22, 13, 645, DateTimeKind.Unspecified).AddTicks(6684), "gmail.com_Bins@gmail.com", "Chase Gorczany", "ne3mj2", "0966827236", 5, "Active", new DateTime(2024, 9, 14, 17, 22, 13, 645, DateTimeKind.Unspecified).AddTicks(6684), "Roel87" },
                    { 21, new DateTime(2024, 9, 4, 0, 38, 50, 178, DateTimeKind.Unspecified).AddTicks(1336), "gmail.com.Mante59@yahoo.com", "Itzel Bins", "2f9wml", "0895515644", 4, "Active", new DateTime(2024, 9, 4, 0, 38, 50, 178, DateTimeKind.Unspecified).AddTicks(1336), "Lavonne75" },
                    { 22, new DateTime(2024, 9, 14, 13, 21, 14, 462, DateTimeKind.Unspecified).AddTicks(1692), "gmail.com.Johnston27@gmail.com", "Ebba Koch", "ftd83g", "0626378941", 5, "Active", new DateTime(2024, 9, 14, 13, 21, 14, 462, DateTimeKind.Unspecified).AddTicks(1692), "Berenice.Jones56" },
                    { 23, new DateTime(2024, 9, 15, 18, 51, 27, 714, DateTimeKind.Unspecified).AddTicks(4774), "gmail.com11@gmail.com", "Kitty Turner", "8e3x59", "0779918618", 1, "Active", new DateTime(2024, 9, 15, 18, 51, 27, 714, DateTimeKind.Unspecified).AddTicks(4774), "Thea_Stokes" },
                    { 24, new DateTime(2024, 9, 9, 13, 14, 43, 338, DateTimeKind.Unspecified).AddTicks(5864), "gmail.com.Bosco@hotmail.com", "Eladio VonRueden", "4r0djy", "0236678624", 1, "Active", new DateTime(2024, 9, 9, 13, 14, 43, 338, DateTimeKind.Unspecified).AddTicks(5864), "Eldred70" },
                    { 25, new DateTime(2024, 9, 1, 18, 3, 43, 870, DateTimeKind.Unspecified).AddTicks(1452), "gmail.com82@hotmail.com", "Jaylan Wiegand", "1476hj", "0600037343", 5, "Active", new DateTime(2024, 9, 1, 18, 3, 43, 870, DateTimeKind.Unspecified).AddTicks(1452), "Felicia.Bailey21" }
                });

            migrationBuilder.InsertData(
                table: "Visitors",
                columns: new[] { "VisitorId", "CompanyName", "CreatedDate", "CredentialCardTypeId", "CredentialsCard", "PhoneNumber", "Status", "UpdatedDate", "VisitorName" },
                values: new object[,]
                {
                    { 1, "Romaguera Group", new DateTime(2024, 9, 4, 16, 7, 17, 129, DateTimeKind.Unspecified).AddTicks(2173), 2, "1tspxqjjb4", "0853154255", false, new DateTime(2024, 9, 4, 16, 7, 17, 129, DateTimeKind.Unspecified).AddTicks(2173), "Dolly Skiles" },
                    { 2, "Schulist LLC", new DateTime(2024, 9, 16, 0, 7, 28, 979, DateTimeKind.Unspecified).AddTicks(4044), 2, "vof4gxkegy", "0352895765", true, new DateTime(2024, 9, 16, 0, 7, 28, 979, DateTimeKind.Unspecified).AddTicks(4044), "Moises Tremblay" },
                    { 3, "Berge, Rempel and Kirlin", new DateTime(2024, 9, 7, 9, 46, 16, 558, DateTimeKind.Unspecified).AddTicks(9409), 2, "2ker7sltyx", "0487063541", false, new DateTime(2024, 9, 7, 9, 46, 16, 558, DateTimeKind.Unspecified).AddTicks(9409), "Norval Ebert" },
                    { 4, "Lehner Inc", new DateTime(2024, 9, 14, 6, 32, 2, 626, DateTimeKind.Unspecified).AddTicks(957), 1, "rnfqv2zswh", "0421454373", true, new DateTime(2024, 9, 14, 6, 32, 2, 626, DateTimeKind.Unspecified).AddTicks(957), "Rafael Hamill" },
                    { 5, "Balistreri Group", new DateTime(2024, 9, 8, 9, 31, 49, 295, DateTimeKind.Unspecified).AddTicks(993), 2, "woc9ydwtvc", "0874583943", true, new DateTime(2024, 9, 8, 9, 31, 49, 295, DateTimeKind.Unspecified).AddTicks(993), "Karlee Vandervort" },
                    { 6, "Price LLC", new DateTime(2024, 9, 16, 3, 7, 57, 301, DateTimeKind.Unspecified).AddTicks(7397), 1, "cqt3bszjac", "0205930983", true, new DateTime(2024, 9, 16, 3, 7, 57, 301, DateTimeKind.Unspecified).AddTicks(7397), "Aletha Adams" },
                    { 7, "Mitchell Inc", new DateTime(2024, 9, 14, 6, 16, 5, 125, DateTimeKind.Unspecified).AddTicks(8166), 2, "lnrh20nehg", "0105094296", true, new DateTime(2024, 9, 14, 6, 16, 5, 125, DateTimeKind.Unspecified).AddTicks(8166), "Ora Hammes" },
                    { 8, "Crona - Crona", new DateTime(2024, 9, 20, 3, 10, 56, 926, DateTimeKind.Unspecified).AddTicks(6022), 2, "g8mhkv72oi", "0405291221", true, new DateTime(2024, 9, 20, 3, 10, 56, 926, DateTimeKind.Unspecified).AddTicks(6022), "Clint Armstrong" },
                    { 9, "Goldner, Waelchi and Weimann", new DateTime(2024, 9, 6, 7, 5, 34, 779, DateTimeKind.Unspecified).AddTicks(8203), 1, "p2tv37h9o7", "0783746442", true, new DateTime(2024, 9, 6, 7, 5, 34, 779, DateTimeKind.Unspecified).AddTicks(8203), "Imogene Carter" },
                    { 10, "Farrell - Konopelski", new DateTime(2024, 9, 10, 23, 8, 58, 907, DateTimeKind.Unspecified).AddTicks(9205), 2, "8e4z58pck4", "0866640852", false, new DateTime(2024, 9, 10, 23, 8, 58, 907, DateTimeKind.Unspecified).AddTicks(9205), "Hellen Deckow" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "CreateBy", "CreateTime", "ProjectName", "Status" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2024, 9, 11, 22, 52, 31, 905, DateTimeKind.Unspecified).AddTicks(3854), "Unbranded Steel Bacon", true },
                    { 2, 3, new DateTime(2024, 9, 11, 1, 19, 33, 761, DateTimeKind.Unspecified).AddTicks(1211), "Unbranded Soft Hat", true },
                    { 3, 3, new DateTime(2024, 9, 12, 19, 9, 42, 170, DateTimeKind.Unspecified).AddTicks(3401), "Tasty Plastic Shirt", true },
                    { 4, 3, new DateTime(2024, 9, 10, 21, 19, 39, 500, DateTimeKind.Unspecified).AddTicks(4372), "Tasty Concrete Pants", true },
                    { 5, 3, new DateTime(2024, 9, 4, 21, 56, 56, 126, DateTimeKind.Unspecified).AddTicks(3555), "Ergonomic Wooden Hat", true }
                });

            migrationBuilder.InsertData(
                table: "UserDepartments",
                columns: new[] { "UserDepartmentId", "DepartmentId", "UserId" },
                values: new object[,]
                {
                    { 1, 7, 1 },
                    { 2, 7, 10 },
                    { 3, 9, 9 },
                    { 4, 2, 10 },
                    { 5, 1, 21 },
                    { 6, 10, 11 },
                    { 7, 1, 3 },
                    { 8, 5, 13 },
                    { 9, 8, 14 },
                    { 10, 1, 18 },
                    { 11, 4, 2 },
                    { 12, 1, 14 },
                    { 13, 6, 23 },
                    { 14, 4, 21 },
                    { 15, 9, 14 },
                    { 16, 8, 12 },
                    { 17, 9, 21 },
                    { 18, 4, 24 },
                    { 19, 9, 10 },
                    { 20, 1, 13 },
                    { 21, 5, 20 },
                    { 22, 3, 10 },
                    { 23, 10, 5 },
                    { 24, 6, 19 },
                    { 25, 8, 13 },
                    { 26, 9, 5 },
                    { 27, 2, 25 },
                    { 28, 5, 7 },
                    { 29, 1, 22 },
                    { 30, 3, 23 }
                });

            migrationBuilder.InsertData(
                table: "Visits",
                columns: new[] { "VisitId", "AcceptLevel", "CreateById", "DateRegister", "DepartmentReasonId", "UpdateById", "VisitQuantity" },
                values: new object[,]
                {
                    { 1, 1, 4, new DateTime(2024, 9, 14, 1, 21, 37, 434, DateTimeKind.Unspecified).AddTicks(5563), 1, 4, 6 },
                    { 2, 1, 4, new DateTime(2024, 9, 6, 5, 32, 46, 885, DateTimeKind.Unspecified).AddTicks(1179), 1, 4, 4 },
                    { 3, 2, 4, new DateTime(2024, 9, 9, 12, 49, 55, 578, DateTimeKind.Unspecified).AddTicks(2190), 5, 4, 2 },
                    { 4, 3, 4, new DateTime(2024, 9, 9, 22, 49, 6, 451, DateTimeKind.Unspecified).AddTicks(1959), 2, 4, 1 },
                    { 5, 2, 4, new DateTime(2024, 9, 1, 1, 42, 46, 637, DateTimeKind.Unspecified).AddTicks(618), 3, 4, 3 }
                });

            migrationBuilder.InsertData(
                table: "VisitDetails",
                columns: new[] { "VisitDetailId", "Description", "ExpectedTimeIn", "ExpectedTimeOut", "Status", "VisitDetailName", "VisitId", "VisitorId" },
                values: new object[,]
                {
                    { 1, "Accusantium aut quis neque beatae saepe debitis adipisci. Doloremque nobis dolore perspiciatis aut eos nesciunt quo tenetur aut. Maiores ad quis atque inventore doloribus et fugiat. Ut occaecati illum est aut velit accusamus autem soluta ullam.", new DateTime(2024, 9, 21, 19, 48, 23, 927, DateTimeKind.Local).AddTicks(6994), new DateTime(2024, 9, 22, 19, 48, 23, 927, DateTimeKind.Local).AddTicks(7039), false, "Rustic Granite Bacon", 1, 9 },
                    { 2, "Qui placeat cupiditate illo delectus. Voluptates quidem impedit. Aut omnis at. Consequuntur maiores quas architecto fuga. Perspiciatis cupiditate et tempore alias autem.", new DateTime(2024, 9, 21, 19, 48, 23, 927, DateTimeKind.Local).AddTicks(8115), new DateTime(2024, 9, 22, 19, 48, 23, 927, DateTimeKind.Local).AddTicks(8121), false, "Awesome Granite Bacon", 2, 1 },
                    { 3, "Accusamus ea asperiores harum. Illum nostrum nisi sequi. Incidunt quo sed et illum. Vel tenetur fugit excepturi aut et nihil et autem magnam.", new DateTime(2024, 9, 21, 19, 48, 23, 927, DateTimeKind.Local).AddTicks(8223), new DateTime(2024, 9, 22, 19, 48, 23, 927, DateTimeKind.Local).AddTicks(8225), true, "Incredible Concrete Keyboard", 4, 1 },
                    { 4, "Magni ut mollitia possimus voluptatibus. Laudantium iusto ut eum et libero quo enim reprehenderit. Dolor incidunt architecto autem. Nam nam sit modi minima corrupti quas dolorem.", new DateTime(2024, 9, 21, 19, 48, 23, 927, DateTimeKind.Local).AddTicks(8326), new DateTime(2024, 9, 22, 19, 48, 23, 927, DateTimeKind.Local).AddTicks(8328), false, "Incredible Plastic Car", 5, 6 },
                    { 5, "Atque optio totam autem et nulla et. Qui quibusdam voluptatibus et velit sed voluptatem et quasi. Ea porro provident nulla aut aperiam mollitia exercitationem aperiam occaecati.", new DateTime(2024, 9, 21, 19, 48, 23, 927, DateTimeKind.Local).AddTicks(8416), new DateTime(2024, 9, 22, 19, 48, 23, 927, DateTimeKind.Local).AddTicks(8417), false, "Rustic Concrete Shirt", 4, 1 },
                    { 6, "Deleniti neque quos corporis sed qui minima sapiente. Aut ut ut. Esse id consequatur. Voluptas exercitationem totam dolorum laboriosam aut et pariatur aut architecto. Quasi voluptatum rerum numquam odio est. Illum aut repellendus velit odit vero tempora.", new DateTime(2024, 9, 21, 19, 48, 23, 927, DateTimeKind.Local).AddTicks(8545), new DateTime(2024, 9, 22, 19, 48, 23, 927, DateTimeKind.Local).AddTicks(8547), true, "Ergonomic Wooden Table", 1, 1 },
                    { 7, "In vitae perspiciatis facilis aut nulla sint reprehenderit. At officia ut quaerat maxime tempore. Asperiores sint nam ut. Voluptatibus eveniet enim. Eaque et distinctio vel non a et eos minima. Sapiente nihil sit dolor.", new DateTime(2024, 9, 21, 19, 48, 23, 927, DateTimeKind.Local).AddTicks(8664), new DateTime(2024, 9, 22, 19, 48, 23, 927, DateTimeKind.Local).AddTicks(8666), false, "Refined Concrete Shoes", 5, 1 },
                    { 8, "Quisquam voluptatem iste est eum minus saepe quia libero sit. Hic eos voluptate nihil maiores nisi. Beatae voluptatem voluptatum vero labore.", new DateTime(2024, 9, 21, 19, 48, 23, 927, DateTimeKind.Local).AddTicks(8739), new DateTime(2024, 9, 22, 19, 48, 23, 927, DateTimeKind.Local).AddTicks(8741), true, "Refined Frozen Tuna", 2, 1 },
                    { 9, "Et facere et expedita qui vitae sunt. Quo illo deleniti repellat dignissimos qui est voluptate dicta. Vero dolores itaque odit modi laborum harum.", new DateTime(2024, 9, 21, 19, 48, 23, 927, DateTimeKind.Local).AddTicks(8824), new DateTime(2024, 9, 22, 19, 48, 23, 927, DateTimeKind.Local).AddTicks(8826), false, "Intelligent Rubber Table", 2, 6 },
                    { 10, "Laudantium nam consequatur. Aliquam harum modi recusandae et. Cupiditate suscipit nam omnis nisi et dolor quis ab illum. Qui repellat dolores nisi. Explicabo sed quis et repellendus asperiores ea exercitationem tempora. Laboriosam qui et ratione molestias unde fugit molestiae eveniet itaque.", new DateTime(2024, 9, 21, 19, 48, 23, 927, DateTimeKind.Local).AddTicks(8966), new DateTime(2024, 9, 22, 19, 48, 23, 927, DateTimeKind.Local).AddTicks(8967), true, "Unbranded Soft Shoes", 2, 4 }
                });

            migrationBuilder.InsertData(
                table: "VisitorSessions",
                columns: new[] { "VisitorSessionId", "CheckinTime", "CheckoutTime", "GateId", "QRCardId", "SecurityID", "VisitDetailId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 21, 12, 48, 23, 930, DateTimeKind.Utc).AddTicks(2386), new DateTime(2024, 9, 23, 0, 48, 23, 930, DateTimeKind.Utc).AddTicks(2386), 2, 6, 5, 7 },
                    { 2, new DateTime(2024, 9, 21, 12, 48, 23, 930, DateTimeKind.Utc).AddTicks(4073), new DateTime(2024, 9, 23, 0, 48, 23, 930, DateTimeKind.Utc).AddTicks(4073), 2, 10, 5, 4 },
                    { 3, new DateTime(2024, 9, 21, 12, 48, 23, 930, DateTimeKind.Utc).AddTicks(4090), new DateTime(2024, 9, 23, 0, 48, 23, 930, DateTimeKind.Utc).AddTicks(4090), 1, 1, 5, 9 },
                    { 4, new DateTime(2024, 9, 21, 12, 48, 23, 930, DateTimeKind.Utc).AddTicks(4099), new DateTime(2024, 9, 23, 0, 48, 23, 930, DateTimeKind.Utc).AddTicks(4099), 2, 9, 5, 3 },
                    { 5, new DateTime(2024, 9, 21, 12, 48, 23, 930, DateTimeKind.Utc).AddTicks(4108), new DateTime(2024, 9, 23, 0, 48, 23, 930, DateTimeKind.Utc).AddTicks(4108), 2, 3, 5, 7 }
                });

            migrationBuilder.InsertData(
                table: "VisitorSessionsImages",
                columns: new[] { "VisitorSessionsImageId", "ImageType", "ImageURL", "Name", "VisitorSessionId" },
                values: new object[,]
                {
                    { 1, "jpg", "https://example.com/images/1_1.jpg", "Image_1_1", 1 },
                    { 2, "jpg", "https://example.com/images/1_2.jpg", "Image_1_2", 1 },
                    { 3, "jpg", "https://example.com/images/1_3.jpg", "Image_1_3", 1 },
                    { 4, "jpg", "https://example.com/images/2_1.jpg", "Image_2_1", 2 },
                    { 5, "jpg", "https://example.com/images/2_2.jpg", "Image_2_2", 2 },
                    { 6, "jpg", "https://example.com/images/2_3.jpg", "Image_2_3", 2 },
                    { 7, "jpg", "https://example.com/images/3_1.jpg", "Image_3_1", 3 },
                    { 8, "jpg", "https://example.com/images/3_2.jpg", "Image_3_2", 3 },
                    { 9, "jpg", "https://example.com/images/3_3.jpg", "Image_3_3", 3 },
                    { 10, "jpg", "https://example.com/images/4_1.jpg", "Image_4_1", 4 },
                    { 11, "jpg", "https://example.com/images/4_2.jpg", "Image_4_2", 4 },
                    { 12, "jpg", "https://example.com/images/4_3.jpg", "Image_4_3", 4 },
                    { 13, "jpg", "https://example.com/images/5_1.jpg", "Image_5_1", 5 },
                    { 14, "jpg", "https://example.com/images/5_2.jpg", "Image_5_2", 5 },
                    { 15, "jpg", "https://example.com/images/5_3.jpg", "Image_5_3", 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 4);

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
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 8);

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
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8);

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
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "VisitorSessionsImages",
                keyColumn: "VisitorSessionsImageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VisitorSessionsImages",
                keyColumn: "VisitorSessionsImageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VisitorSessionsImages",
                keyColumn: "VisitorSessionsImageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VisitorSessionsImages",
                keyColumn: "VisitorSessionsImageId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VisitorSessionsImages",
                keyColumn: "VisitorSessionsImageId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VisitorSessionsImages",
                keyColumn: "VisitorSessionsImageId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "VisitorSessionsImages",
                keyColumn: "VisitorSessionsImageId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "VisitorSessionsImages",
                keyColumn: "VisitorSessionsImageId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "VisitorSessionsImages",
                keyColumn: "VisitorSessionsImageId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "VisitorSessionsImages",
                keyColumn: "VisitorSessionsImageId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "VisitorSessionsImages",
                keyColumn: "VisitorSessionsImageId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "VisitorSessionsImages",
                keyColumn: "VisitorSessionsImageId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "VisitorSessionsImages",
                keyColumn: "VisitorSessionsImageId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "VisitorSessionsImages",
                keyColumn: "VisitorSessionsImageId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "VisitorSessionsImages",
                keyColumn: "VisitorSessionsImageId",
                keyValue: 15);

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
                keyValue: 5);

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
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DepartmentReasons",
                keyColumn: "DepartmentReasonId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1);

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
                table: "Reasons",
                keyColumn: "ReasonId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reasons",
                keyColumn: "ReasonId",
                keyValue: 5);

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
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7);

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
                keyValue: 11);

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
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 20);

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
                table: "VisitorSessions",
                keyColumn: "VisitorSessionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VisitorSessions",
                keyColumn: "VisitorSessionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VisitorSessions",
                keyColumn: "VisitorSessionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VisitorSessions",
                keyColumn: "VisitorSessionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VisitorSessions",
                keyColumn: "VisitorSessionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Gates",
                keyColumn: "GateId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Gates",
                keyColumn: "GateId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "QRCards",
                keyColumn: "QRCardId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reasons",
                keyColumn: "ReasonId",
                keyValue: 2);

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
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5);

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
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "VisitDetails",
                keyColumn: "VisitDetailId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "QRCardStatus",
                keyColumn: "QRCardStatusId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "QRCardStatus",
                keyColumn: "QRCardStatusId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "QRCardType",
                keyColumn: "QRCardTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "QRCardType",
                keyColumn: "QRCardTypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Visitors",
                keyColumn: "VisitorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Visits",
                keyColumn: "VisitId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CredentialCardTypes",
                keyColumn: "CredentialCardTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CredentialCardTypes",
                keyColumn: "CredentialCardTypeId",
                keyValue: 2);

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
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reasons",
                keyColumn: "ReasonId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reasons",
                keyColumn: "ReasonId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4);

            migrationBuilder.AlterColumn<int>(
                name: "StatusName",
                table: "QRCardStatus",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
