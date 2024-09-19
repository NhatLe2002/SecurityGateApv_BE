using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecurityGateApv.Infras.Migrations
{
    /// <inheritdoc />
    public partial class SeedData_4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 19, 5, 41, 49, 358, DateTimeKind.Utc).AddTicks(2903), new DateTime(2024, 9, 19, 5, 41, 49, 358, DateTimeKind.Utc).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 19, 5, 41, 49, 358, DateTimeKind.Utc).AddTicks(2914), new DateTime(2024, 9, 19, 5, 41, 49, 358, DateTimeKind.Utc).AddTicks(2914) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 19, 5, 41, 49, 358, DateTimeKind.Utc).AddTicks(2916), new DateTime(2024, 9, 19, 5, 41, 49, 358, DateTimeKind.Utc).AddTicks(2917) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 19, 5, 41, 49, 358, DateTimeKind.Utc).AddTicks(2918), new DateTime(2024, 9, 19, 5, 41, 49, 358, DateTimeKind.Utc).AddTicks(2919) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 19, 5, 41, 49, 358, DateTimeKind.Utc).AddTicks(2920), new DateTime(2024, 9, 19, 5, 41, 49, 358, DateTimeKind.Utc).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 11, 8, 33, 28, 761, DateTimeKind.Unspecified).AddTicks(2366), "gmail.com.Jacobson@yahoo.com", "Nathan Schneider", "820o3y", "0641048822", new DateTime(2024, 9, 11, 8, 33, 28, 761, DateTimeKind.Unspecified).AddTicks(2366), "Graham58" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 1, 11, 54, 47, 447, DateTimeKind.Unspecified).AddTicks(4543), "gmail.com.Armstrong90@gmail.com", "Devin Goldner", "4thop7", "0105768905", 5, new DateTime(2024, 9, 1, 11, 54, 47, 447, DateTimeKind.Unspecified).AddTicks(4543), "Jabari.McCullough" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 1, 15, 8, 47, 370, DateTimeKind.Unspecified).AddTicks(908), "gmail.com.Waelchi60@yahoo.com", "Hazel Champlin", "4ge0fp", "0321059430", 2, new DateTime(2024, 9, 1, 15, 8, 47, 370, DateTimeKind.Unspecified).AddTicks(908), "Alexandrea8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 5, 1, 8, 54, 890, DateTimeKind.Unspecified).AddTicks(3917), "gmail.com27@hotmail.com", "Fredy Jacobi", "rr6gfk", "0285630611", 5, new DateTime(2024, 9, 5, 1, 8, 54, 890, DateTimeKind.Unspecified).AddTicks(3917), "Lambert97" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 13, 22, 11, 33, 922, DateTimeKind.Unspecified).AddTicks(7152), "gmail.com_Quitzon@hotmail.com", "Clement Cremin", "ig6xlw", "0796612345", 3, new DateTime(2024, 9, 13, 22, 11, 33, 922, DateTimeKind.Unspecified).AddTicks(7152), "Moises_Rempel98" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 1, 22, 34, 26, 626, DateTimeKind.Unspecified).AddTicks(6526), "gmail.com81@hotmail.com", "Willow O'Conner", "vvlwss", "0114077762", 2, new DateTime(2024, 9, 1, 22, 34, 26, 626, DateTimeKind.Unspecified).AddTicks(6526), "Jacques_Herzog5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 16, 11, 59, 59, 392, DateTimeKind.Unspecified).AddTicks(9509), "gmail.com38@hotmail.com", "Corbin Runte", "mkxn80", "0613814326", 4, new DateTime(2024, 9, 16, 11, 59, 59, 392, DateTimeKind.Unspecified).AddTicks(9509), "Kaela.Kub94" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 9, 2, 9, 39, 308, DateTimeKind.Unspecified).AddTicks(9509), "gmail.com.Koepp@hotmail.com", "Brody Feeney", "kmyb89", "0935250012", 4, new DateTime(2024, 9, 9, 2, 9, 39, 308, DateTimeKind.Unspecified).AddTicks(9509), "Reba.Koch" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 1, 7, 52, 17, 307, DateTimeKind.Unspecified).AddTicks(1394), "gmail.com_Towne79@hotmail.com", "Durward Gerhold", "ac2hwo", "0363836515", 5, new DateTime(2024, 9, 1, 7, 52, 17, 307, DateTimeKind.Unspecified).AddTicks(1394), "Lexi.Lakin5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 15, 18, 54, 52, 906, DateTimeKind.Unspecified).AddTicks(9036), "gmail.com_White82@yahoo.com", "Icie Thompson", "zg8l6y", "0673020572", new DateTime(2024, 9, 15, 18, 54, 52, 906, DateTimeKind.Unspecified).AddTicks(9036), "Jonas_Kerluke18" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 4, 10, 43, 28, 961, DateTimeKind.Unspecified).AddTicks(3060), "gmail.com91@hotmail.com", "Gunner Gerlach", "ikv8kr", "0755882735", 5, new DateTime(2024, 9, 4, 10, 43, 28, 961, DateTimeKind.Unspecified).AddTicks(3060), "Mariam.Bernhard38" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 11, 3, 16, 24, 413, DateTimeKind.Unspecified).AddTicks(8864), "gmail.com65@gmail.com", "Avis Pagac", "lvfwm8", "0154048461", new DateTime(2024, 9, 11, 3, 16, 24, 413, DateTimeKind.Unspecified).AddTicks(8864), "Lesley.Hand89" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 1, 0, 53, 31, 316, DateTimeKind.Unspecified).AddTicks(6245), "gmail.com_Streich@yahoo.com", "Jodie Heller", "rj20ca", "0337680250", 5, new DateTime(2024, 9, 1, 0, 53, 31, 316, DateTimeKind.Unspecified).AddTicks(6245), "Petra.Hane" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 3, 10, 31, 4, 751, DateTimeKind.Unspecified).AddTicks(6650), "gmail.com98@gmail.com", "Pansy Leuschke", "e1roor", "0454210865", 4, new DateTime(2024, 9, 3, 10, 31, 4, 751, DateTimeKind.Unspecified).AddTicks(6650), "Dan.Beatty" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 18, 12, 31, 31, 609, DateTimeKind.Unspecified).AddTicks(9969), "gmail.com_Reichert@hotmail.com", "Kole Walter", "blcmbk", "0929899524", 4, new DateTime(2024, 9, 18, 12, 31, 31, 609, DateTimeKind.Unspecified).AddTicks(9969), "Priscilla_Grady" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 8, 22, 58, 44, 666, DateTimeKind.Unspecified).AddTicks(9526), "gmail.com.Hane14@yahoo.com", "Pierce O'Connell", "q5wyps", "0333017731", 1, new DateTime(2024, 9, 8, 22, 58, 44, 666, DateTimeKind.Unspecified).AddTicks(9526), "Selina_Mueller73" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 2, 16, 41, 3, 571, DateTimeKind.Unspecified).AddTicks(7646), "gmail.com_Kassulke@gmail.com", "Damian Koelpin", "155ei1", "0418537702", 4, new DateTime(2024, 9, 2, 16, 41, 3, 571, DateTimeKind.Unspecified).AddTicks(7646), "Novella_Kohler79" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 13, 8, 50, 15, 386, DateTimeKind.Unspecified).AddTicks(3545), "gmail.com_Bernhard@gmail.com", "Bernie Lakin", "nku78b", "0732483340", 1, new DateTime(2024, 9, 13, 8, 50, 15, 386, DateTimeKind.Unspecified).AddTicks(3545), "Jackeline_Sporer57" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 5, 9, 47, 2, 984, DateTimeKind.Unspecified).AddTicks(3654), "gmail.com86@yahoo.com", "Tad Abshire", "4qdd0s", "0114944255", 2, new DateTime(2024, 9, 5, 9, 47, 2, 984, DateTimeKind.Unspecified).AddTicks(3654), "Zelma_Wintheiser20" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 9, 21, 31, 34, 906, DateTimeKind.Unspecified).AddTicks(8682), "gmail.com22@hotmail.com", "Maddison Ebert", "qkf9xh", "0472617027", 1, new DateTime(2024, 9, 9, 21, 31, 34, 906, DateTimeKind.Unspecified).AddTicks(8682), "Ernie_Murray" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 19, 5, 32, 2, 677, DateTimeKind.Utc).AddTicks(4768), new DateTime(2024, 9, 19, 5, 32, 2, 677, DateTimeKind.Utc).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 19, 5, 32, 2, 677, DateTimeKind.Utc).AddTicks(4779), new DateTime(2024, 9, 19, 5, 32, 2, 677, DateTimeKind.Utc).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 7, 19, 5, 32, 2, 677, DateTimeKind.Utc).AddTicks(4788), new DateTime(2024, 9, 19, 5, 32, 2, 677, DateTimeKind.Utc).AddTicks(4788) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 19, 5, 32, 2, 677, DateTimeKind.Utc).AddTicks(4790), new DateTime(2024, 9, 19, 5, 32, 2, 677, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 19, 5, 32, 2, 677, DateTimeKind.Utc).AddTicks(4792), new DateTime(2024, 9, 19, 5, 32, 2, 677, DateTimeKind.Utc).AddTicks(4792) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 8, 9, 23, 22, 33, 592, DateTimeKind.Utc).AddTicks(6110), "Elaina96@gmail.com", "Kelsi West", "VrILJa", "+84 925 578 3301", new DateTime(2024, 8, 9, 23, 22, 33, 592, DateTimeKind.Utc).AddTicks(6110), "Eden29" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 2, 6, 835, DateTimeKind.Utc).AddTicks(7237), "Wilfrid84@gmail.com", "Eleazar Tremblay", "L2D8jD", "+84 932 389 6890", 2, new DateTime(2024, 8, 31, 3, 2, 6, 835, DateTimeKind.Utc).AddTicks(7237), "Emmett9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 8, 5, 20, 26, 886, DateTimeKind.Utc).AddTicks(4098), "Jayme37@gmail.com", "Ransom Hagenes", "zz69zW", "+84 058 168 6229", 1, new DateTime(2024, 9, 8, 5, 20, 26, 886, DateTimeKind.Utc).AddTicks(4098), "Saige.Beatty73" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 7, 10, 46, 31, 961, DateTimeKind.Utc).AddTicks(8014), "Jakob_Bergnaum8@gmail.com", "Hans Beahan", "5AO5Zl", "+84 746 880 4775", 2, new DateTime(2024, 9, 7, 10, 46, 31, 961, DateTimeKind.Utc).AddTicks(8014), "Roman.Glover" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 9, 8, 23, 57, 207, DateTimeKind.Utc).AddTicks(5187), "Darion.Mann22@gmail.com", "Johann Donnelly", "R7PUEG", "+84 541 058 8609", 5, new DateTime(2024, 9, 9, 8, 23, 57, 207, DateTimeKind.Utc).AddTicks(5187), "Alize.Ankunding" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 8, 24, 22, 52, 4, 513, DateTimeKind.Utc).AddTicks(1025), "Jeffrey71@gmail.com", "Audrey Medhurst", "OAsLk2", "+84 316 956 1340", 1, new DateTime(2024, 8, 24, 22, 52, 4, 513, DateTimeKind.Utc).AddTicks(1025), "Robyn3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 8, 2, 1, 45, 32, 23, DateTimeKind.Utc).AddTicks(7598), "Hector_Hackett43@gmail.com", "Bailey Shanahan", "39WmyS", "+84 753 179 2379", 3, new DateTime(2024, 8, 2, 1, 45, 32, 23, DateTimeKind.Utc).AddTicks(7598), "Gracie.Effertz" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 8, 25, 18, 26, 4, 494, DateTimeKind.Utc).AddTicks(3650), "Enrique_Murazik@gmail.com", "Webster Lindgren", "OqiK23", "+84 486 867 7444", 5, new DateTime(2024, 8, 25, 18, 26, 4, 494, DateTimeKind.Utc).AddTicks(3650), "Aisha26" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 8, 15, 8, 12, 22, 435, DateTimeKind.Utc).AddTicks(5646), "Bonita69@gmail.com", "Delia Christiansen", "dKr0zo", "+84 384 263 2680", 4, new DateTime(2024, 8, 15, 8, 12, 22, 435, DateTimeKind.Utc).AddTicks(5646), "Jana_Ortiz86" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 8, 5, 20, 51, 4, 659, DateTimeKind.Utc).AddTicks(5755), "Griffin_Flatley@gmail.com", "Leon Braun", "7QDlgd", "+84 885 874 4966", new DateTime(2024, 8, 5, 20, 51, 4, 659, DateTimeKind.Utc).AddTicks(5755), "Caesar21" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 8, 10, 1, 43, 29, 239, DateTimeKind.Utc).AddTicks(5075), "Alec_Blanda18@gmail.com", "Aurore Hickle", "Q6K3KT", "+84 919 006 1892", 4, new DateTime(2024, 8, 10, 1, 43, 29, 239, DateTimeKind.Utc).AddTicks(5075), "Lincoln_Boyer" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 11, 3, 37, 55, 912, DateTimeKind.Utc).AddTicks(6244), "Daron_Jaskolski27@gmail.com", "Lina Corkery", "TqKBmh", "+84 167 589 2430", new DateTime(2024, 9, 11, 3, 37, 55, 912, DateTimeKind.Utc).AddTicks(6244), "Carmella23" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 8, 16, 13, 14, 11, 723, DateTimeKind.Utc).AddTicks(2925), "Eloisa25@gmail.com", "Angela Morissette", "qDtr71", "+84 494 969 6410", 2, new DateTime(2024, 8, 16, 13, 14, 11, 723, DateTimeKind.Utc).AddTicks(2925), "Stephany_Grimes10" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 6, 2, 40, 23, 617, DateTimeKind.Utc).AddTicks(9713), "Jillian_Schimmel@gmail.com", "Nathanial Dickinson", "2ND223", "+84 833 940 3239", 3, new DateTime(2024, 9, 6, 2, 40, 23, 617, DateTimeKind.Utc).AddTicks(9713), "Brock.Hirthe37" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 8, 5, 12, 6, 0, 646, DateTimeKind.Utc).AddTicks(897), "Keeley_Herzog@gmail.com", "Shayne Gibson", "NRXEHC", "+84 704 095 5903", 2, new DateTime(2024, 8, 5, 12, 6, 0, 646, DateTimeKind.Utc).AddTicks(897), "Clair_Hudson74" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 1, 11, 12, 33, 834, DateTimeKind.Utc).AddTicks(9122), "Asia_Bogan3@gmail.com", "Alvina Larkin", "jbL0XN", "+84 843 931 6268", 5, new DateTime(2024, 9, 1, 11, 12, 33, 834, DateTimeKind.Utc).AddTicks(9122), "Opal2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 8, 3, 19, 51, 29, 397, DateTimeKind.Utc).AddTicks(4147), "Hazle53@gmail.com", "Bette Swift", "k0sLiy", "+84 711 397 8618", 1, new DateTime(2024, 8, 3, 19, 51, 29, 397, DateTimeKind.Utc).AddTicks(4147), "Brycen_Powlowski" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 8, 7, 10, 5, 11, 710, DateTimeKind.Utc).AddTicks(8277), "Edmund_Cassin@gmail.com", "Cecelia Bradtke", "8SgOHy", "+84 885 078 7345", 4, new DateTime(2024, 8, 7, 10, 5, 11, 710, DateTimeKind.Utc).AddTicks(8277), "Kara_Bogisich8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 9, 2, 16, 31, 4, 773, DateTimeKind.Utc).AddTicks(7429), "Telly.Bashirian7@gmail.com", "Garret Nitzsche", "W2cn4A", "+84 219 220 0753", 1, new DateTime(2024, 9, 2, 16, 31, 4, 773, DateTimeKind.Utc).AddTicks(7429), "Jazmyne_Jacobson" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Email", "FullName", "Password", "PhoneNumber", "RoleId", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 8, 7, 3, 3, 1, 306, DateTimeKind.Utc).AddTicks(5919), "Quinn_Ankunding15@gmail.com", "Randi Nienow", "8t7IOd", "+84 868 055 5391", 4, new DateTime(2024, 8, 7, 3, 3, 1, 306, DateTimeKind.Utc).AddTicks(5919), "Jett_McCullough" });
        }
    }
}
