using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SecurityGateApv.Infras.Migrations
{
    /// <inheritdoc />
    public partial class SeedData_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "Status", "UpdatedDate", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 19, 5, 32, 2, 677, DateTimeKind.Utc).AddTicks(4768), "admin1@example.com", "Admin One", "123", "1234567890", 1, "Active", new DateTime(2024, 9, 19, 5, 32, 2, 677, DateTimeKind.Utc).AddTicks(4776), "admin1" },
                    { 2, new DateTime(2024, 6, 19, 5, 32, 2, 677, DateTimeKind.Utc).AddTicks(4779), "manager1@example.com", "Manager One", "123", "0987654321", 2, "Active", new DateTime(2024, 9, 19, 5, 32, 2, 677, DateTimeKind.Utc).AddTicks(4780), "manager1" },
                    { 3, new DateTime(2024, 7, 19, 5, 32, 2, 677, DateTimeKind.Utc).AddTicks(4788), "employee1@example.com", "Department Manager One", "123", "1112223334", 3, "Active", new DateTime(2024, 9, 19, 5, 32, 2, 677, DateTimeKind.Utc).AddTicks(4788), "DM1" },
                    { 4, new DateTime(2024, 8, 19, 5, 32, 2, 677, DateTimeKind.Utc).AddTicks(4790), "hr1@example.com", "Staff One", "123", "2223334445", 4, "Active", new DateTime(2024, 9, 19, 5, 32, 2, 677, DateTimeKind.Utc).AddTicks(4790), "Staff1" },
                    { 5, new DateTime(2024, 5, 19, 5, 32, 2, 677, DateTimeKind.Utc).AddTicks(4792), "it1@example.com", "Security One", "123", "3334445556", 5, "Active", new DateTime(2024, 9, 19, 5, 32, 2, 677, DateTimeKind.Utc).AddTicks(4792), "Security1" },
                    { 6, new DateTime(2024, 8, 9, 23, 22, 33, 592, DateTimeKind.Utc).AddTicks(6110), "Elaina96@gmail.com", "Kelsi West", "VrILJa", "+84 925 578 3301", 2, "Active", new DateTime(2024, 8, 9, 23, 22, 33, 592, DateTimeKind.Utc).AddTicks(6110), "Eden29" },
                    { 7, new DateTime(2024, 8, 31, 3, 2, 6, 835, DateTimeKind.Utc).AddTicks(7237), "Wilfrid84@gmail.com", "Eleazar Tremblay", "L2D8jD", "+84 932 389 6890", 2, "Active", new DateTime(2024, 8, 31, 3, 2, 6, 835, DateTimeKind.Utc).AddTicks(7237), "Emmett9" },
                    { 8, new DateTime(2024, 9, 8, 5, 20, 26, 886, DateTimeKind.Utc).AddTicks(4098), "Jayme37@gmail.com", "Ransom Hagenes", "zz69zW", "+84 058 168 6229", 1, "Active", new DateTime(2024, 9, 8, 5, 20, 26, 886, DateTimeKind.Utc).AddTicks(4098), "Saige.Beatty73" },
                    { 9, new DateTime(2024, 9, 7, 10, 46, 31, 961, DateTimeKind.Utc).AddTicks(8014), "Jakob_Bergnaum8@gmail.com", "Hans Beahan", "5AO5Zl", "+84 746 880 4775", 2, "Active", new DateTime(2024, 9, 7, 10, 46, 31, 961, DateTimeKind.Utc).AddTicks(8014), "Roman.Glover" },
                    { 10, new DateTime(2024, 9, 9, 8, 23, 57, 207, DateTimeKind.Utc).AddTicks(5187), "Darion.Mann22@gmail.com", "Johann Donnelly", "R7PUEG", "+84 541 058 8609", 5, "Active", new DateTime(2024, 9, 9, 8, 23, 57, 207, DateTimeKind.Utc).AddTicks(5187), "Alize.Ankunding" },
                    { 11, new DateTime(2024, 8, 24, 22, 52, 4, 513, DateTimeKind.Utc).AddTicks(1025), "Jeffrey71@gmail.com", "Audrey Medhurst", "OAsLk2", "+84 316 956 1340", 1, "Active", new DateTime(2024, 8, 24, 22, 52, 4, 513, DateTimeKind.Utc).AddTicks(1025), "Robyn3" },
                    { 12, new DateTime(2024, 8, 2, 1, 45, 32, 23, DateTimeKind.Utc).AddTicks(7598), "Hector_Hackett43@gmail.com", "Bailey Shanahan", "39WmyS", "+84 753 179 2379", 3, "Active", new DateTime(2024, 8, 2, 1, 45, 32, 23, DateTimeKind.Utc).AddTicks(7598), "Gracie.Effertz" },
                    { 13, new DateTime(2024, 8, 25, 18, 26, 4, 494, DateTimeKind.Utc).AddTicks(3650), "Enrique_Murazik@gmail.com", "Webster Lindgren", "OqiK23", "+84 486 867 7444", 5, "Active", new DateTime(2024, 8, 25, 18, 26, 4, 494, DateTimeKind.Utc).AddTicks(3650), "Aisha26" },
                    { 14, new DateTime(2024, 8, 15, 8, 12, 22, 435, DateTimeKind.Utc).AddTicks(5646), "Bonita69@gmail.com", "Delia Christiansen", "dKr0zo", "+84 384 263 2680", 4, "Active", new DateTime(2024, 8, 15, 8, 12, 22, 435, DateTimeKind.Utc).AddTicks(5646), "Jana_Ortiz86" },
                    { 15, new DateTime(2024, 8, 5, 20, 51, 4, 659, DateTimeKind.Utc).AddTicks(5755), "Griffin_Flatley@gmail.com", "Leon Braun", "7QDlgd", "+84 885 874 4966", 3, "Active", new DateTime(2024, 8, 5, 20, 51, 4, 659, DateTimeKind.Utc).AddTicks(5755), "Caesar21" },
                    { 16, new DateTime(2024, 8, 10, 1, 43, 29, 239, DateTimeKind.Utc).AddTicks(5075), "Alec_Blanda18@gmail.com", "Aurore Hickle", "Q6K3KT", "+84 919 006 1892", 4, "Active", new DateTime(2024, 8, 10, 1, 43, 29, 239, DateTimeKind.Utc).AddTicks(5075), "Lincoln_Boyer" },
                    { 17, new DateTime(2024, 9, 11, 3, 37, 55, 912, DateTimeKind.Utc).AddTicks(6244), "Daron_Jaskolski27@gmail.com", "Lina Corkery", "TqKBmh", "+84 167 589 2430", 4, "Active", new DateTime(2024, 9, 11, 3, 37, 55, 912, DateTimeKind.Utc).AddTicks(6244), "Carmella23" },
                    { 18, new DateTime(2024, 8, 16, 13, 14, 11, 723, DateTimeKind.Utc).AddTicks(2925), "Eloisa25@gmail.com", "Angela Morissette", "qDtr71", "+84 494 969 6410", 2, "Active", new DateTime(2024, 8, 16, 13, 14, 11, 723, DateTimeKind.Utc).AddTicks(2925), "Stephany_Grimes10" },
                    { 19, new DateTime(2024, 9, 6, 2, 40, 23, 617, DateTimeKind.Utc).AddTicks(9713), "Jillian_Schimmel@gmail.com", "Nathanial Dickinson", "2ND223", "+84 833 940 3239", 3, "Active", new DateTime(2024, 9, 6, 2, 40, 23, 617, DateTimeKind.Utc).AddTicks(9713), "Brock.Hirthe37" },
                    { 20, new DateTime(2024, 8, 5, 12, 6, 0, 646, DateTimeKind.Utc).AddTicks(897), "Keeley_Herzog@gmail.com", "Shayne Gibson", "NRXEHC", "+84 704 095 5903", 2, "Active", new DateTime(2024, 8, 5, 12, 6, 0, 646, DateTimeKind.Utc).AddTicks(897), "Clair_Hudson74" },
                    { 21, new DateTime(2024, 9, 1, 11, 12, 33, 834, DateTimeKind.Utc).AddTicks(9122), "Asia_Bogan3@gmail.com", "Alvina Larkin", "jbL0XN", "+84 843 931 6268", 5, "Active", new DateTime(2024, 9, 1, 11, 12, 33, 834, DateTimeKind.Utc).AddTicks(9122), "Opal2" },
                    { 22, new DateTime(2024, 8, 3, 19, 51, 29, 397, DateTimeKind.Utc).AddTicks(4147), "Hazle53@gmail.com", "Bette Swift", "k0sLiy", "+84 711 397 8618", 1, "Active", new DateTime(2024, 8, 3, 19, 51, 29, 397, DateTimeKind.Utc).AddTicks(4147), "Brycen_Powlowski" },
                    { 23, new DateTime(2024, 8, 7, 10, 5, 11, 710, DateTimeKind.Utc).AddTicks(8277), "Edmund_Cassin@gmail.com", "Cecelia Bradtke", "8SgOHy", "+84 885 078 7345", 4, "Active", new DateTime(2024, 8, 7, 10, 5, 11, 710, DateTimeKind.Utc).AddTicks(8277), "Kara_Bogisich8" },
                    { 24, new DateTime(2024, 9, 2, 16, 31, 4, 773, DateTimeKind.Utc).AddTicks(7429), "Telly.Bashirian7@gmail.com", "Garret Nitzsche", "W2cn4A", "+84 219 220 0753", 1, "Active", new DateTime(2024, 9, 2, 16, 31, 4, 773, DateTimeKind.Utc).AddTicks(7429), "Jazmyne_Jacobson" },
                    { 25, new DateTime(2024, 8, 7, 3, 3, 1, 306, DateTimeKind.Utc).AddTicks(5919), "Quinn_Ankunding15@gmail.com", "Randi Nienow", "8t7IOd", "+84 868 055 5391", 4, "Active", new DateTime(2024, 8, 7, 3, 3, 1, 306, DateTimeKind.Utc).AddTicks(5919), "Jett_McCullough" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8);

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
        }
    }
}
