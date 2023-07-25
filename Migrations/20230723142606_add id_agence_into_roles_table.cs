using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomotiveApi.Migrations
{
    /// <inheritdoc />
    public partial class addid_agence_into_roles_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdAgence",
                table: "Roles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "7082 Tyshawn Village", "Lynchhaven", new DateTime(2023, 1, 29, 15, 7, 15, 935, DateTimeKind.Local).AddTicks(3813), "Jay21@gmail.com", 39.089599999999997, -17.216899999999999, "Dynamic Brand Liaison", "1-670-473-1536", "41390" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "416 Mariano Streets", "Denesikport", new DateTime(2023, 7, 6, 2, 32, 35, 694, DateTimeKind.Local).AddTicks(650), "Lafayette39@hotmail.com", -41.639099999999999, 144.57589999999999, "Legacy Quality Strategist", "440.346.3530", "74811-7796" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "50495 Herzog Ports", "Port Prince", new DateTime(2022, 12, 6, 0, 27, 1, 73, DateTimeKind.Local).AddTicks(230), "Hugh76@hotmail.com", -28.9011, -58.121600000000001, "National Operations Architect", "375-992-8117", "74813" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "34880 Jonas Viaduct", "North Tre", new DateTime(2023, 3, 8, 8, 15, 36, 677, DateTimeKind.Local).AddTicks(5336), "Otha.Lubowitz9@hotmail.com", 68.265900000000002, 78.034899999999993, "Product Assurance Associate", "427-463-5827 x5862", "50161" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "926 Sheila Skyway", "New Walterland", new DateTime(2022, 10, 18, 8, 50, 20, 642, DateTimeKind.Local).AddTicks(8665), "Mauricio84@hotmail.com", -84.6935, 175.94540000000001, "International Configuration Officer", "(959) 238-9060 x016", "08945" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "068 Eden Point", "East Armandobury", new DateTime(2022, 9, 12, 3, 50, 39, 945, DateTimeKind.Local).AddTicks(3129), "Berneice.Cole11@yahoo.com", -38.082799999999999, 22.272600000000001, "Dynamic Communications Agent", "1-590-523-3108", "30166" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "74501 O'Conner Spring", "New Carrollville", new DateTime(2023, 3, 8, 16, 59, 20, 141, DateTimeKind.Local).AddTicks(4372), "Aliyah10@gmail.com", -42.827199999999998, 13.028700000000001, "Investor Marketing Technician", "345-735-5581 x7197", "11678" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "2351 Guillermo Springs", "Vandervortburgh", new DateTime(2023, 6, 17, 20, 31, 16, 604, DateTimeKind.Local).AddTicks(2731), "Velma67@gmail.com", 15.434699999999999, 110.461, "Internal Implementation Assistant", "587-939-2455", "14590" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "3547 Keanu Flats", "Macejkovicborough", new DateTime(2022, 10, 18, 8, 27, 5, 659, DateTimeKind.Local).AddTicks(927), "Jaleel.Berge@gmail.com", -20.495999999999999, -25.457899999999999, "Dynamic Accountability Coordinator", "1-976-815-2122 x085", "91748" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "95305 Monte Flat", "Lexifort", new DateTime(2022, 9, 25, 20, 6, 15, 161, DateTimeKind.Local).AddTicks(3598), "Christian_Donnelly24@gmail.com", -42.770099999999999, -62.4925, "Direct Accounts Specialist", "1-393-591-1010 x3797", "23629-9703" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "IdAgence",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "IdAgence",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "IdAgence",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "IdAgence",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "IdAgence",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 17, 12, 49, 9, 836, DateTimeKind.Local).AddTicks(1940), "Gudrun_Hudson@yahoo.com", "Alejandra", 3, "Durgan", "$2a$11$cM5lG1wMQNxGLA6KiFKo..1zCruIedH1Y6eWTDslnBMIwOXZ70A3K" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 9, 13, 44, 59, 337, DateTimeKind.Local).AddTicks(8003), "Ona.Kerluke@gmail.com", "Florida", 2, 3, "Bosco", "$2a$11$l0.JMlnuQlc2jgFQmMjqJuMPFRzQ8Z1NVuxc64cXluUC54qWtgHR." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 25, 3, 34, 20, 133, DateTimeKind.Local).AddTicks(9649), "Deontae.Wyman59@yahoo.com", "Ruth", 2, 3, "Reinger", "$2a$11$IzTifLaA3J2mGK6fdjqjrOjZc/P2x/WipWcE4EYj1UdVMqsYeZFKa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 19, 19, 49, 27, 852, DateTimeKind.Local).AddTicks(3533), "Kristina.Williamson63@gmail.com", "Jordan", 7, 3, "Wunsch", "$2a$11$mSW1tZROULX3hE.paVZJKOTMZlBJOQ7HBP7YAftcF1lMSYDgJg1I6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 2, 19, 21, 14, 38, 190, DateTimeKind.Local).AddTicks(2656), "Johnnie.Nitzsche@hotmail.com", "Ofelia", 7, 3, "Goldner", "$2a$11$2iCe.tKiI1y5Hoh59Zb8rOdXM1eKRwp/9aIzG773DoFsWRFvOAziK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 23, 22, 10, 22, 798, DateTimeKind.Local).AddTicks(2597), "Ibrahim87@yahoo.com", "Adeline", 3, 3, "Rath", "$2a$11$WboPpah2GsyccIosq2jfxOyo9t1ZWgudP6SHmBwBj7gDnGBfcSOLK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 1, 5, 35, 38, 335, DateTimeKind.Local).AddTicks(1630), "Annetta80@yahoo.com", "Emelie", 7, 4, "Mueller", "$2a$11$OUoAQoZH7Kn0BLBREF2j7OIBUWqcGzFggYplVGa.n/P7oN7ZlczJG" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 30, 11, 59, 40, 189, DateTimeKind.Local).AddTicks(5261), "Kiera57@hotmail.com", "Christop", 10, 4, "Sanford", "$2a$11$FnfrvT.MIM8Q07YMfzSN/ubQxDEXs55p.nunIHVChAXXErffZ8FNy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 16, 10, 33, 6, 146, DateTimeKind.Local).AddTicks(6201), "Ally30@yahoo.com", "Elisabeth", 6, 1, "Heller", "$2a$11$Ob7VpbFsMhKyGECJajAb9uhe38JlZAEMKxuD5.tm228cK0zvyzJWK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 7, 15, 8, 46, 0, 493, DateTimeKind.Local).AddTicks(312), "Alvera22@hotmail.com", "Reese", 9, 1, "Bechtelar", "$2a$11$K2VLXQ5ipEDNs9Pbx9ebTOQ/.86hSDdcHzG/YWmJtEOUihkGn5sbe" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 11, 12, 13, 2, 36, 116, DateTimeKind.Local).AddTicks(9455), "Wintheiser", "Yoshiko_Mueller@hotmail.com", "Fisher, Bogan and Dicki", "Christelle", "230-622-6594 x25585", "Grimes", "Forestview", "73101" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 6, 6, 3, 26, 41, 639, DateTimeKind.Local).AddTicks(215), "Morar", "Angeline.Keebler@hotmail.com", "Wisoky, Bashirian and Wilkinson", "Yesenia", "1-463-211-2143 x515", "Champlin", "Hellentown", "42954" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 3, 14, 19, 6, 2, 777, DateTimeKind.Local).AddTicks(9264), "Stroman", "Talon_Doyle@gmail.com", "Koss - Walter", "Bradly", "(468) 868-4250 x925", "Windler", "North Alfreda", "97378-1413" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 3, 9, 3, 30, 8, 380, DateTimeKind.Local).AddTicks(3445), "Schinner", "Juvenal_Kshlerin99@gmail.com", "Jast Inc", "Euna", "(503) 404-6540 x888", "Schultz", "Port Dorthafort", "28059-8144" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 6, 14, 1, 35, 16, 282, DateTimeKind.Local).AddTicks(7463), "O'Connell", "Nicholas.Pacocha79@hotmail.com", "Parker LLC", "Mohamed", "801-238-8419 x56428", "Hagenes", "Kassulkeberg", "73306" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 9, 22, 11, 33, 20, 412, DateTimeKind.Local).AddTicks(6999), "Farrell", "Anibal47@yahoo.com", "Towne - Rau", "Lula", "1-388-786-0140", "Heller", "Nonaberg", "36387-1515" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 9, 11, 4, 51, 20, 338, DateTimeKind.Local).AddTicks(1334), "VonRueden", "Gisselle_Veum28@gmail.com", "Oberbrunner LLC", "Aubree", "232.981.9325", "Swift", "Loweshire", "98372" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 11, 9, 1, 17, 48, 311, DateTimeKind.Local).AddTicks(3124), "Smitham", "Dell_Waelchi95@gmail.com", "Ward Inc", "Rosina", "396.479.3204 x5033", "Hilll", "Erinfort", "84495" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 10, 10, 8, 42, 33, 127, DateTimeKind.Local).AddTicks(2302), "Marvin", "Jarrell31@yahoo.com", "Stark, Fahey and Carter", "Ned", "1-477-700-2894", "Beahan", "Emelieview", "16077" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 1, 31, 9, 33, 38, 617, DateTimeKind.Local).AddTicks(9409), "Wolff", "Bernard_MacGyver31@hotmail.com", "Walter, Beatty and Konopelski", "Peter", "1-272-470-8425 x199", "Pfeffer", "New Ramirohaven", "13983" });

            migrationBuilder.CreateIndex(
                name: "IX_Roles_IdAgence",
                table: "Roles",
                column: "IdAgence");

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Agences_IdAgence",
                table: "Roles",
                column: "IdAgence",
                principalTable: "Agences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Agences_IdAgence",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Roles_IdAgence",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "IdAgence",
                table: "Roles");

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "2347 Howe Lights", "South Maybellbury", new DateTime(2023, 3, 20, 19, 13, 5, 44, DateTimeKind.Local).AddTicks(2901), "Madison52@gmail.com", -76.848799999999997, -141.97319999999999, "Customer Web Analyst", "402.748.9127 x969", "72024" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "211 Donnelly Plaza", "Bettyburgh", new DateTime(2023, 6, 13, 4, 54, 29, 520, DateTimeKind.Local).AddTicks(3936), "Ashley_Hand60@yahoo.com", -71.048199999999994, 18.3992, "Dynamic Paradigm Officer", "1-992-587-8038 x583", "34649-7322" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "4849 Buckridge Lock", "Port Rupertmouth", new DateTime(2023, 4, 1, 21, 14, 39, 304, DateTimeKind.Local).AddTicks(6488), "Tressa47@gmail.com", -24.936399999999999, 38.589300000000001, "Legacy Integration Planner", "(309) 741-6393 x80667", "85767-4683" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "44708 Heidenreich Mission", "Sanfordchester", new DateTime(2023, 2, 8, 14, 9, 28, 608, DateTimeKind.Local).AddTicks(586), "Norbert84@gmail.com", -73.221999999999994, 122.9653, "Corporate Applications Officer", "1-529-432-3344", "25484" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "951 Sigmund Spurs", "West Milton", new DateTime(2023, 4, 23, 7, 15, 33, 895, DateTimeKind.Local).AddTicks(5403), "Lorena55@gmail.com", -86.2517, -161.90280000000001, "International Paradigm Designer", "789.510.6665", "36182-2403" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "719 Von Streets", "New Altown", new DateTime(2023, 2, 26, 7, 47, 14, 351, DateTimeKind.Local).AddTicks(8126), "Talon.Dicki67@yahoo.com", -52.242899999999999, 154.48240000000001, "Forward Quality Architect", "(295) 707-9461 x911", "26937-3754" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "0725 Bernhard Village", "Wardhaven", new DateTime(2023, 2, 28, 19, 15, 23, 819, DateTimeKind.Local).AddTicks(3372), "Jeff82@gmail.com", -74.8399, 22.685600000000001, "Customer Directives Liaison", "(428) 986-6306 x7876", "63754-8485" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "92997 Volkman Dale", "Halieton", new DateTime(2023, 2, 27, 16, 50, 59, 111, DateTimeKind.Local).AddTicks(6088), "Belle87@yahoo.com", -74.8476, 68.467799999999997, "Customer Functionality Associate", "486-795-4464 x7683", "20933" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "0105 Connelly Mountain", "Meaganport", new DateTime(2022, 12, 27, 10, 1, 16, 636, DateTimeKind.Local).AddTicks(7975), "Elaina.Mosciski@yahoo.com", 41.432000000000002, -5.3098000000000001, "Future Functionality Planner", "(789) 262-1852", "15220-2391" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "026 Elmo Ranch", "Hegmannville", new DateTime(2023, 7, 10, 19, 2, 22, 787, DateTimeKind.Local).AddTicks(2290), "Antonina.Koelpin50@yahoo.com", -15.1844, -136.9778, "Dynamic Security Associate", "1-773-838-3386 x1055", "37367" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 11, 4, 3, 44, 15, 400, DateTimeKind.Local).AddTicks(6183), "Felicity_Kreiger@yahoo.com", "Delphia", 8, "VonRueden", "$2a$11$wo2P9BCtO8aY2lvzpKCM7OReseu9IUESMwO6exfHMzgkYH8ZOZgiK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 12, 19, 22, 55, 267, DateTimeKind.Local).AddTicks(7691), "Margot_Kiehn@gmail.com", "Agustina", 9, 1, "Cremin", "$2a$11$icCuNmzrmmgar6peRnZBDOdnSWlY8ZDAbUXXve87ylLA9ou0yIcRS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 14, 8, 44, 23, 909, DateTimeKind.Local).AddTicks(1843), "Cristian.Ziemann@gmail.com", "Anabel", 5, 4, "Schuster", "$2a$11$chRci31xC9q2lA/0/qsv9.pzba5X.48gFYff2UQlx8Yj5s4abOJye" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 20, 19, 5, 32, 186, DateTimeKind.Local).AddTicks(6299), "Amber.Breitenberg36@gmail.com", "Laurine", 2, 1, "Weber", "$2a$11$.Jz5cFxo8KWkBxAMGgxamOAcgIyqAJwangxdzbJkQ.mraIuVgSwaq" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 27, 15, 16, 42, 796, DateTimeKind.Local).AddTicks(2732), "Roberto.Hilll54@gmail.com", "Nolan", 10, 2, "Zulauf", "$2a$11$WTSqqxRa9hcI/osYgcr12OLxRYaQwGNNqlvuw6vP7taMScRvJ/CUe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 22, 20, 35, 45, 209, DateTimeKind.Local).AddTicks(9796), "Savannah68@hotmail.com", "Fiona", 10, 1, "Metz", "$2a$11$X4V81utrlFlRdRnVimV.H.wC2Zpw/NnAIoRmWQvUrvtS3hJcP/Sce" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 7, 9, 8, 3, 952, DateTimeKind.Local).AddTicks(9706), "Emma_Tillman@hotmail.com", "Pietro", 6, 1, "Stark", "$2a$11$SUwAlmcAZTJAV6xVoxgWW./Hj2e8cm7jofLo/ptdMWDu00Qka/Acu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 7, 16, 12, 52, 39, 768, DateTimeKind.Local).AddTicks(230), "Abbey49@yahoo.com", "Chet", 4, 1, "Schmitt", "$2a$11$i3bivcd4c2IJyYiEZ.3E5eawXXvLYJin.fMM6c4e5r0F4By3VsHfK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 19, 4, 36, 5, 751, DateTimeKind.Local).AddTicks(5478), "Ewald.Leffler64@gmail.com", "Rudy", 7, 2, "King", "$2a$11$VWTc9iGvMuq2LjmcPC/bbeDAIi0egySP.ThZHJMKQhvJWNpbfbNHG" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 15, 13, 5, 3, 358, DateTimeKind.Local).AddTicks(9311), "Jonathon_Quitzon72@gmail.com", "Chyna", 1, 2, "Goodwin", "$2a$11$lcfmhKKN/0MaKql0iaomwu1LFQkLWPxQx1zhZgTBMX1NnIU3xFMnC" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 9, 6, 5, 13, 38, 787, DateTimeKind.Local).AddTicks(904), "Upton", "Nicklaus.Gottlieb72@hotmail.com", "McCullough and Sons", "Gaston", "1-563-848-7685 x21599", "Schowalter", "Mandymouth", "63672" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 1, 25, 9, 56, 8, 189, DateTimeKind.Local).AddTicks(8361), "Glover", "Shayne.Crooks16@hotmail.com", "Corwin - Brakus", "Lea", "1-618-230-8902", "Grimes", "South Reubenland", "39672" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 11, 2, 12, 7, 13, 285, DateTimeKind.Local).AddTicks(2725), "Larkin", "Alek62@yahoo.com", "Koch - Wyman", "Madelyn", "(258) 856-4094 x62481", "Wisozk", "Allenfort", "26095-0019" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 3, 19, 23, 4, 8, 473, DateTimeKind.Local).AddTicks(3130), "Ortiz", "Dangelo.Jaskolski39@gmail.com", "Strosin - Pfannerstill", "Kelley", "(993) 656-3532 x962", "Beahan", "Kihnburgh", "07641-4954" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 9, 20, 3, 29, 46, 678, DateTimeKind.Local).AddTicks(2632), "Kohler", "Cayla72@gmail.com", "Schaden Group", "Kamren", "(938) 887-5654", "Wisoky", "Flossieburgh", "71874" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 3, 17, 5, 48, 56, 247, DateTimeKind.Local).AddTicks(1689), "Collins", "Lelia.Waelchi68@yahoo.com", "Heaney - Collins", "Emmanuel", "861.615.7621", "Rath", "South Shanny", "73017" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 6, 15, 14, 59, 17, 74, DateTimeKind.Local).AddTicks(7321), "McClure", "Brendan36@yahoo.com", "Goodwin - McClure", "Khalid", "1-432-811-4420 x1846", "Schultz", "Lake Lucieview", "48157" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 3, 17, 13, 47, 11, 37, DateTimeKind.Local).AddTicks(9436), "Ernser", "Valentine.Lockman36@gmail.com", "Bins, Koss and O'Kon", "Myrtice", "1-227-844-9586", "Hudson", "Laynemouth", "82159" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 11, 8, 19, 46, 4, 601, DateTimeKind.Local).AddTicks(2163), "Christiansen", "Javonte_Quigley@yahoo.com", "Denesik, O'Reilly and Schroeder", "Isac", "(203) 246-2333", "Nikolaus", "Elmerfort", "05451-3980" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 4, 15, 7, 28, 43, 583, DateTimeKind.Local).AddTicks(9746), "Jenkins", "Marco41@yahoo.com", "VonRueden and Sons", "Kole", "467.752.6573", "Stroman", "North Dorothealand", "20512-3445" });
        }
    }
}
