using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AutomotiveApi.Migrations
{
    /// <inheritdoc />
    public partial class agencenavpropertynullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "76379 Cassin Expressway", "Josemouth", new DateTime(2023, 5, 8, 8, 25, 41, 23, DateTimeKind.Local).AddTicks(8638), "Abe_Kemmer93@hotmail.com", 79.444500000000005, -18.790500000000002, "Regional Implementation Facilitator", "962.470.6451 x487", "57514" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "843 Margarita Spring", "Wisozkhaven", new DateTime(2022, 12, 6, 8, 1, 43, 259, DateTimeKind.Local).AddTicks(8074), "Rose.Zboncak@gmail.com", 7.8821000000000003, -138.32060000000001, "Principal Interactions Engineer", "1-225-560-1892 x523", "05688-7467" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "41275 Dahlia Haven", "Port Santinaview", new DateTime(2023, 5, 16, 23, 19, 48, 652, DateTimeKind.Local).AddTicks(5290), "Gordon32@gmail.com", 7.9363999999999999, -142.17189999999999, "Chief Response Strategist", "692.922.4300", "37580-0144" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "1972 Hermiston Locks", "Port Herminio", new DateTime(2023, 7, 7, 12, 57, 13, 916, DateTimeKind.Local).AddTicks(793), "Freddy.Yundt86@gmail.com", 77.481999999999999, 178.46979999999999, "Regional Response Analyst", "(689) 953-3786 x70012", "59839-3879" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "0113 Berniece Crescent", "Port Hymanfort", new DateTime(2023, 1, 4, 2, 28, 52, 100, DateTimeKind.Local).AddTicks(8771), "Kolby.Kuhlman@hotmail.com", -87.002300000000005, -33.277099999999997, "National Infrastructure Producer", "676.426.5409 x98840", "83244" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "7432 Lora Heights", "Anaview", new DateTime(2023, 7, 14, 19, 22, 33, 682, DateTimeKind.Local).AddTicks(2153), "Rogelio_Bernier91@gmail.com", -13.15, -78.930300000000003, "Global Group Coordinator", "298-653-3027 x176", "84905-3518" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "6977 Dennis Row", "Humbertohaven", new DateTime(2023, 2, 17, 7, 1, 46, 943, DateTimeKind.Local).AddTicks(8756), "Alan25@yahoo.com", -14.2453, -4.2202999999999999, "Lead Identity Engineer", "(754) 625-2558 x86107", "39878-2569" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "691 Jada Island", "Isomton", new DateTime(2022, 8, 26, 14, 7, 55, 442, DateTimeKind.Local).AddTicks(3590), "Guido_Hyatt34@yahoo.com", -41.130899999999997, 47.7376, "Product Research Liaison", "755-892-8415", "11673" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "930 Ledner Port", "Port Margarettfort", new DateTime(2023, 6, 10, 1, 1, 4, 345, DateTimeKind.Local).AddTicks(7855), "Johan.Larson@hotmail.com", 13.5847, 48.823300000000003, "Chief Branding Manager", "958.783.2177", "59660-3364" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "467 Hoppe Mills", "East Modesto", new DateTime(2023, 5, 21, 11, 47, 54, 68, DateTimeKind.Local).AddTicks(7266), "Bell_Gislason80@gmail.com", 57.033999999999999, -117.9949, "Internal Branding Supervisor", "765-313-9752 x3220", "92010-3432" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "234 Rudy Common", "3847 Graham Plain", new DateTime(2023, 7, 28, 21, 52, 57, 158, DateTimeKind.Local).AddTicks(5044), "Devin22@gmail.com", "Bobbie", "Johns", "https://picsum.photos/640/480/?image=818", "https://picsum.photos/640/480/?image=579", "409-992-1675 x428", "New Darlenefurt", "41039" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "781 Jerde Meadow", "9877 Kassandra Mission", new DateTime(2023, 1, 1, 22, 41, 43, 181, DateTimeKind.Local).AddTicks(1145), "Henry.DAmore32@hotmail.com", "Kyleigh", "Trantow", "https://picsum.photos/640/480/?image=972", "https://picsum.photos/640/480/?image=141", "602-965-7159 x4133", "Port Casimirville", "82857-0770" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "08186 Mervin Passage", "77984 Hodkiewicz Plain", new DateTime(2023, 5, 17, 3, 3, 16, 967, DateTimeKind.Local).AddTicks(2837), "Mina_Effertz@yahoo.com", "Evalyn", "Conroy", "https://picsum.photos/640/480/?image=783", "https://picsum.photos/640/480/?image=479", "227.298.0733", "North Maxwell", "20192-8887" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "858 Reichert Circle", "3066 Sporer Forge", new DateTime(2023, 4, 10, 6, 13, 15, 501, DateTimeKind.Local).AddTicks(2341), "Eddie35@yahoo.com", "Yoshiko", "Bednar", "https://picsum.photos/640/480/?image=57", "https://picsum.photos/640/480/?image=679", "1-280-993-6135 x6681", "New Adamborough", "78845" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "6503 Dorthy Groves", "095 Dudley Manors", new DateTime(2023, 5, 2, 20, 30, 30, 903, DateTimeKind.Local).AddTicks(187), "Marilou.Collins38@hotmail.com", "Garrett", "Bauch", "https://picsum.photos/640/480/?image=915", "https://picsum.photos/640/480/?image=478", "1-280-945-1002", "Caterinaberg", "78470-3170" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "05274 Williamson Station", "425 Kub Mount", new DateTime(2023, 5, 9, 20, 1, 31, 469, DateTimeKind.Local).AddTicks(3100), "Dave_Sipes@hotmail.com", "Laurine", "Wisoky", "https://picsum.photos/640/480/?image=1062", "https://picsum.photos/640/480/?image=724", "656-846-8856 x890", "Dexterberg", "20837-6234" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "4513 Ortiz Underpass", "546 Griffin Divide", new DateTime(2023, 6, 12, 5, 37, 19, 12, DateTimeKind.Local).AddTicks(1893), "Arthur72@hotmail.com", "Elissa", "Veum", "https://picsum.photos/640/480/?image=55", "https://picsum.photos/640/480/?image=200", "358-483-2537", "Lethaview", "13054-0567" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "554 Magdalen Ramp", "885 Kessler Corner", new DateTime(2022, 9, 21, 9, 18, 17, 779, DateTimeKind.Local).AddTicks(7059), "Kailey.Nader@yahoo.com", "Alexandre", "Bechtelar", "https://picsum.photos/640/480/?image=985", "https://picsum.photos/640/480/?image=498", "213-464-4350 x999", "Lake Chetview", "98622" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "71804 Mayer Drive", "02528 Dare Branch", new DateTime(2023, 8, 1, 3, 24, 54, 591, DateTimeKind.Local).AddTicks(9242), "Keegan.Rosenbaum@yahoo.com", "Dave", "Runolfsson", "https://picsum.photos/640/480/?image=1014", "https://picsum.photos/640/480/?image=463", "(761) 436-5336 x2346", "Lafayettemouth", "95486" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "53242 Yolanda Glens", "38997 Vandervort Common", new DateTime(2023, 5, 13, 7, 42, 14, 178, DateTimeKind.Local).AddTicks(9590), "Abdul_Strosin@yahoo.com", "Alivia", "Rogahn", "https://picsum.photos/640/480/?image=146", "https://picsum.photos/640/480/?image=161", "(237) 209-6332 x20179", "Ziemannside", "20710" });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 8, 10, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 7, 8 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 1, 9, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 6, 3, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 1, 6, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 8, 1, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 3, 3, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 3, 6 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 23, 7, 8, 39, 20, DateTimeKind.Local).AddTicks(6293), new DateTime(2023, 8, 24, 16, 19, 0, 87, DateTimeKind.Local).AddTicks(675), new DateTime(2024, 4, 15, 5, 59, 55, 409, DateTimeKind.Local).AddTicks(3254), 3, 3.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 51, 29, 736, DateTimeKind.Local).AddTicks(6580), new DateTime(2023, 8, 24, 6, 6, 24, 356, DateTimeKind.Local).AddTicks(6235), new DateTime(2024, 6, 28, 9, 45, 34, 186, DateTimeKind.Local).AddTicks(7842), 6, 1.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 22, 16, 52, 46, 291, DateTimeKind.Local).AddTicks(4940), new DateTime(2023, 8, 23, 16, 41, 42, 562, DateTimeKind.Local).AddTicks(9077), new DateTime(2024, 6, 17, 5, 8, 25, 60, DateTimeKind.Local).AddTicks(33), 5, 1.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 23, 4, 41, 19, 238, DateTimeKind.Local).AddTicks(7708), new DateTime(2023, 8, 23, 20, 35, 29, 463, DateTimeKind.Local).AddTicks(3281), new DateTime(2024, 2, 18, 0, 45, 58, 622, DateTimeKind.Local).AddTicks(3243), 5, 3.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 53, 26, 804, DateTimeKind.Local).AddTicks(2629), new DateTime(2023, 8, 24, 5, 20, 30, 15, DateTimeKind.Local).AddTicks(2944), new DateTime(2024, 8, 21, 22, 45, 55, 324, DateTimeKind.Local).AddTicks(7874), 1, 1.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 23, 6, 33, 36, 173, DateTimeKind.Local).AddTicks(8863), new DateTime(2023, 8, 23, 19, 59, 32, 748, DateTimeKind.Local).AddTicks(9996), new DateTime(2024, 7, 9, 4, 13, 19, 443, DateTimeKind.Local).AddTicks(8795), 9, 1.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 23, 5, 29, 48, 625, DateTimeKind.Local).AddTicks(4788), new DateTime(2023, 8, 24, 10, 41, 0, 663, DateTimeKind.Local).AddTicks(2349), new DateTime(2024, 4, 18, 1, 45, 38, 719, DateTimeKind.Local).AddTicks(8441), 4, 2.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 23, 8, 54, 23, 664, DateTimeKind.Local).AddTicks(1035), new DateTime(2023, 8, 24, 9, 55, 6, 665, DateTimeKind.Local).AddTicks(4308), new DateTime(2023, 12, 12, 23, 12, 56, 66, DateTimeKind.Local).AddTicks(1617), 5, 3.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 22, 21, 35, 42, 917, DateTimeKind.Local).AddTicks(9273), new DateTime(2023, 8, 24, 6, 3, 9, 26, DateTimeKind.Local).AddTicks(2374), new DateTime(2024, 8, 7, 2, 3, 11, 153, DateTimeKind.Local).AddTicks(6433), 8, 4.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 22, 16, 46, 40, 293, DateTimeKind.Local).AddTicks(7874), new DateTime(2023, 8, 24, 12, 37, 37, 749, DateTimeKind.Local).AddTicks(9922), new DateTime(2023, 10, 22, 5, 29, 42, 615, DateTimeKind.Local).AddTicks(5317), 10, 4.0, true });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 46, 17, 451, DateTimeKind.Local).AddTicks(2454), new DateTime(2023, 8, 24, 2, 48, 45, 49, DateTimeKind.Local).AddTicks(8335), new DateTime(2024, 4, 1, 20, 4, 6, 956, DateTimeKind.Local).AddTicks(6805), 3, "095222bc-65b0-4f1c-b573-4d54c650e872", "Annulé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 23, 1, 14, 28, 40, DateTimeKind.Local).AddTicks(7297), new DateTime(2023, 8, 24, 0, 45, 33, 526, DateTimeKind.Local).AddTicks(8716), new DateTime(2024, 4, 6, 5, 14, 41, 569, DateTimeKind.Local).AddTicks(1202), 1, "675acb5c-6c40-45ec-81f9-a573c547a57e", "Annulé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 23, 9, 38, 19, 770, DateTimeKind.Local).AddTicks(4200), new DateTime(2023, 8, 24, 9, 24, 35, 65, DateTimeKind.Local).AddTicks(9260), new DateTime(2024, 5, 26, 13, 41, 31, 873, DateTimeKind.Local).AddTicks(3278), 4, "8a838ffa-cea8-4ce6-9ceb-b1480908d1a9" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 23, 9, 14, 52, 257, DateTimeKind.Local).AddTicks(4601), new DateTime(2023, 8, 24, 16, 22, 35, 168, DateTimeKind.Local).AddTicks(8365), new DateTime(2023, 9, 12, 4, 58, 0, 333, DateTimeKind.Local).AddTicks(8967), 8, "3a503ffe-4ba6-4ac8-9440-bd52654986bc", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 18, 43, 13, 509, DateTimeKind.Local).AddTicks(9849), new DateTime(2023, 8, 24, 2, 28, 32, 274, DateTimeKind.Local).AddTicks(1501), new DateTime(2023, 11, 19, 19, 3, 28, 337, DateTimeKind.Local).AddTicks(5334), 2, "6303052a-03ff-49ce-a3b7-18837ea2df3e", "Annulé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 22, 57, 897, DateTimeKind.Local).AddTicks(7038), new DateTime(2023, 8, 23, 17, 56, 42, 425, DateTimeKind.Local).AddTicks(7430), new DateTime(2024, 2, 4, 13, 35, 3, 893, DateTimeKind.Local).AddTicks(815), 5, "4ba149df-0600-41ee-93f1-ad3fffed1a88" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 23, 6, 45, 21, 513, DateTimeKind.Local).AddTicks(3893), new DateTime(2023, 8, 23, 19, 1, 0, 550, DateTimeKind.Local).AddTicks(9540), new DateTime(2024, 8, 17, 6, 31, 28, 334, DateTimeKind.Local).AddTicks(5458), 5, "19f23983-d4f2-47de-b312-faa5e4f9dae4" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 23, 0, 36, 13, 219, DateTimeKind.Local).AddTicks(3520), new DateTime(2023, 8, 24, 10, 53, 10, 965, DateTimeKind.Local).AddTicks(8109), new DateTime(2024, 6, 3, 4, 50, 19, 692, DateTimeKind.Local).AddTicks(8604), 1, "207f6b69-956c-4696-beb2-8a2a61b31ce8" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 23, 16, 10, 9, 655, DateTimeKind.Local).AddTicks(9125), new DateTime(2023, 8, 24, 2, 45, 28, 306, DateTimeKind.Local).AddTicks(8430), new DateTime(2024, 7, 26, 6, 42, 57, 624, DateTimeKind.Local).AddTicks(3835), 6, "a8d5304b-b6c5-47a3-a752-871015854d86", "Annulé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 22, 23, 59, 18, 988, DateTimeKind.Local).AddTicks(7641), new DateTime(2023, 8, 24, 11, 55, 46, 391, DateTimeKind.Local).AddTicks(3143), new DateTime(2024, 7, 13, 11, 32, 12, 415, DateTimeKind.Local).AddTicks(4432), 6, "fb0d8fd4-fe1d-48ac-94e5-89360abb7fdc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 4, 9, 20, 36, 0, 262, DateTimeKind.Local).AddTicks(9941), "Logan_Abshire@hotmail.com", "Robbie", "Zemlak", "$2a$11$23WUfLPwruipxPvl8JWU4uIiQ01C19aXmNkh75yPKrNUosPt5ic62" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 20, 23, 41, 30, 906, DateTimeKind.Local).AddTicks(7662), "Cameron.Hirthe83@yahoo.com", "Krystal", 2, false, "Green", "$2a$11$uK8N2qOJQyCgbB6i9zIOfu8Qgw5TYZxK7CrfJykoqdrEwC6Un2Vs6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 28, 18, 4, 13, 590, DateTimeKind.Local).AddTicks(2379), "Emmet_Hickle3@hotmail.com", "Ron", 2, true, "Mayert", "$2a$11$Ho/3XUkkrtAv5afCULuyxuTRsg4Q6HOIUZNlxfQYIHGntCFHX8RP2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 18, 2, 11, 40, 704, DateTimeKind.Local).AddTicks(8309), "Gennaro26@yahoo.com", "Camille", 2, 2, "Schmidt", "$2a$11$B15cEq29aCq6bZfMSjyM0OrTi6Ia4jp9m5fYN.v24z160C9V0m.nC" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 26, 12, 43, 10, 214, DateTimeKind.Local).AddTicks(2886), "Icie_Skiles@yahoo.com", "Pete", 10, true, "Aufderhar", "$2a$11$hAA35y93vIHO5pDu82WjTu8SSkWcOkqgIMYtQ8TfbKDWUSoz68QZ." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 14, 17, 7, 9, 715, DateTimeKind.Local).AddTicks(5526), "Raphael88@yahoo.com", "Tania", 2, true, "Rogahn", "$2a$11$7VQo2SB2TDt7StFt7cWUSe8ajQ9uGMIuBjtr04DrhBcCspPVJPSF6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 26, 2, 3, 52, 467, DateTimeKind.Local).AddTicks(9544), "Sofia34@hotmail.com", "Lesley", 6, true, "Schroeder", "$2a$11$jwbxDJKfZhfbbhmVQaho4.fbNkYSlcaMQSrqSmlFi/OKuasmn5DbG" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 29, 2, 35, 34, 625, DateTimeKind.Local).AddTicks(1846), "Marjorie_Beatty36@yahoo.com", "Dessie", 4, "Huel", "$2a$11$/pVhX12tW1abLTJqyl1E5eCQLf6UJQboDCM8T5netgw8.ypOlJa4q" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 11, 4, 22, 15, 6, 477, DateTimeKind.Local).AddTicks(5729), "Randi_Senger15@gmail.com", "Deonte", 5, false, "Brown", "$2a$11$5V0hvQMRs/81Q0JQGghrCOKv0k1/PvcxUhjxOA2zJxvaObFCwAduO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 28, 4, 59, 28, 73, DateTimeKind.Local).AddTicks(6684), "Deven.Cormier19@hotmail.com", "Jeramie", 3, "Connelly", "$2a$11$jevZvVtuT6aCIgPinkVqueLnJcAs/Ix7bKuj5wDtveaKFWbUlNGa2" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "Prix", "Type" },
                values: new object[] { false, new DateTime(2023, 5, 27, 5, 34, 41, 941, DateTimeKind.Local).AddTicks(4279), "qivdydmups", 9, 110, 7198, "fcsbhcdxlu", "soowqtcxdm", "fgcdnvbdhw", 10, 10.0, "tygepoomzo" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2023, 1, 17, 6, 49, 56, 0, DateTimeKind.Local).AddTicks(6912), "ckncajixej", 7, 163, 7577, "tvhcennmem", "agvmitmhnq", "jugwzdhega", 6, 5, 7.0, "faciudvlrf" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2023, 3, 16, 8, 8, 35, 461, DateTimeKind.Local).AddTicks(5005), "omhdcuqkpa", 9, 137, 46, "fwcuzggten", "euvmigxpgw", "kvagojzpta", 8, 6, 6.0, "elvdalgzwe" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Type" },
                values: new object[] { false, new DateTime(2023, 6, 20, 0, 51, 39, 435, DateTimeKind.Local).AddTicks(3916), "tnfosjdwsz", 4, 131, 9360, "mfshlquwsd", "mjhzkosjsq", "ucpzxbgxey", 5, 4, "idtkdtunxh" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "Prix", "Type" },
                values: new object[] { new DateTime(2023, 7, 6, 6, 54, 28, 555, DateTimeKind.Local).AddTicks(4568), "zdjsleejhu", 6, 304, 5049, "hahwcigqnl", "oeyjxnncga", "pudmxyzies", 6.0, "ywjmrreaqu" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2023, 6, 3, 9, 15, 50, 596, DateTimeKind.Local).AddTicks(3910), "ibaoqtjcyb", 4, 126, 4195, "bzccygddes", "wfywdlhmpo", "vrfqgxiskd", 1, 1.0, "iepupcyewz" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2023, 5, 17, 13, 13, 13, 769, DateTimeKind.Local).AddTicks(6300), "yolsrmanve", 6, 326, 1985, "mjazoyjuce", "xraamgvejp", "uujwaathfr", 5, 4, 5.0, "jghakmqsly" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, true, new DateTime(2023, 3, 27, 8, 15, 6, 43, DateTimeKind.Local).AddTicks(3442), "olwusdwpqv", 6, 93, 9255, "gzjgwkeexg", "igiwabhbul", "xedfwqmepk", 7, 2, 2.0, "ovyhmmvsqc" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2022, 12, 3, 12, 51, 36, 997, DateTimeKind.Local).AddTicks(5316), "ihzsabridv", 6, 60, 6529, "pmnvsqrywm", "rrjfhhetua", "zlpflejtne", 4, 9, 7.0, "mzhpbdaltv" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2022, 9, 3, 20, 40, 23, 691, DateTimeKind.Local).AddTicks(2982), "jfetfhzhvp", 5, 302, 4225, "zatpokzznz", "xnqsnhvhko", "qvmaoprhiw", 9, 10, 3.0, "vkayzjhynv" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "MontantTotal", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 11, 10, 0, 23, 40, 645, DateTimeKind.Local).AddTicks(1500), "gptypwkbcd", 255, 4.0, "pcohrqzkou", "olevqgaqcl", "Hoeger", 23, "Wuckert - Treutel", "Joyce", "1-774-286-6264 x63171", "Macejkovic", "Hoegerborough", "34129-8783" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "MontantTotal", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 2, 9, 5, 46, 40, 372, DateTimeKind.Local).AddTicks(5248), "vrfysrwqua", 229, 2.0, "gvksjrqddx", "uqdvynoyjp", "Olson", 27, "Leffler Group", "Eulalia", "694.774.9133", "Reilly", "Vallieborough", "15120-4970" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "MontantTotal", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 1, 31, 7, 47, 18, 240, DateTimeKind.Local).AddTicks(8013), "vjcfdapklv", 237, 2.0, "lzgnwtskjm", "tgsvrmtayx", "Waelchi", 18, "Koelpin - Becker", "Estell", "1-785-402-0857 x65733", "Spinka", "New Eladio", "08502" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "MontantTotal", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 5, 25, 16, 1, 34, 762, DateTimeKind.Local).AddTicks(3827), "yutbgiidxv", 122, 10.0, "agzmonnypi", "lieasngbpt", "Renner", 31, "Ernser, Goldner and Reichert", "Cristal", "(497) 513-5697", "Hand", "Robertofurt", "40658" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "MontantTotal", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 8, 23, 22, 37, 48, 240, DateTimeKind.Local).AddTicks(8595), "edbxfjokno", 274, 4.0, "wwcoqcwedh", "zszssksqbb", "Kutch", 20, "Ruecker - Welch", "Diana", "507-338-5318 x7983", "Oberbrunner", "Prosaccomouth", "21253-7935" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "MontantTotal", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 11, 21, 13, 8, 56, 839, DateTimeKind.Local).AddTicks(2063), "ucuemmefdz", 130, 4.0, "gjdkjuvxyy", "zczsgkmbtt", "Predovic", 23, "O'Connell - Stracke", "Scotty", "1-956-911-8492 x6948", "Roob", "Winfieldport", "54866" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "MontantTotal", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 17, 2, 749, DateTimeKind.Local).AddTicks(9347), "ixixsywoym", 139, 8.0, "yzqtgmqtfk", "drcoknoztl", "Harris", 27, "Dare, O'Keefe and Cummerata", "Tyrell", "1-558-630-7444 x8410", "Lakin", "Lake Kristofermouth", "70774" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "MontantTotal", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 7, 17, 0, 22, 47, 267, DateTimeKind.Local).AddTicks(6484), "arifgqgybb", 267, 5.0, "ddhrymrbnl", "kihfwovdiw", "Donnelly", 27, "Hoeger, Anderson and Yundt", "Savion", "690.410.7694 x3281", "Okuneva", "Markston", "32187-5236" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "MontantTotal", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 5, 20, 13, 35, 44, 803, DateTimeKind.Local).AddTicks(5970), "nabxxraafg", 120, 2.0, "hrzbmtvxed", "sklwuzysub", "Metz", 30, "Jakubowski, Quitzon and Parisian", "Edward", "701-797-2169 x719", "Thompson", "Beatricechester", "81026" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "MontantTotal", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 5, 31, 9, 53, 52, 888, DateTimeKind.Local).AddTicks(5933), "bfefcbazrj", 233, 7.0, "kpvmrqlalm", "gskykltasj", "Bruen", 20, "Mitchell Inc", "Darrion", "616.389.2796 x008", "Lang", "North Mallory", "68609" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "0979 Kutch Springs", "Orastad", new DateTime(2022, 10, 11, 7, 3, 10, 125, DateTimeKind.Local).AddTicks(1536), "Johnnie_Berge@yahoo.com", 74.908299999999997, 78.294600000000003, "Human Web Executive", "553.865.0935 x91838", "20817" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "500 Senger Throughway", "Kuvalisland", new DateTime(2023, 4, 25, 3, 57, 32, 342, DateTimeKind.Local).AddTicks(7071), "Percival63@yahoo.com", 48.719900000000003, -25.414899999999999, "Direct Branding Director", "1-403-845-8052", "81623" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "415 Zulauf Island", "Quitzonbury", new DateTime(2022, 12, 25, 22, 10, 51, 676, DateTimeKind.Local).AddTicks(3890), "Peyton_Shields@gmail.com", -28.456499999999998, 16.575199999999999, "Dynamic Functionality Officer", "1-647-840-9332", "58283" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "21291 Breitenberg Squares", "South Cecil", new DateTime(2022, 10, 11, 16, 11, 55, 246, DateTimeKind.Local).AddTicks(7471), "Daron.Mante@yahoo.com", 9.7563999999999993, 123.7487, "Principal Research Executive", "(769) 317-8015 x632", "78715-7641" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "932 Wiegand Ramp", "New Codyfurt", new DateTime(2023, 2, 3, 9, 40, 40, 900, DateTimeKind.Local).AddTicks(4474), "Vincenza.Hayes@hotmail.com", -42.4938, -150.79599999999999, "Chief Web Executive", "1-447-951-5184", "86553" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "41199 Kavon Knolls", "South Shaniya", new DateTime(2023, 1, 19, 0, 7, 39, 514, DateTimeKind.Local).AddTicks(5940), "Lafayette1@hotmail.com", 53.542499999999997, -120.08750000000001, "Global Identity Officer", "1-533-608-8151 x1487", "08732-1329" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "51667 Jeramy Land", "New Chadfort", new DateTime(2023, 7, 11, 14, 18, 31, 931, DateTimeKind.Local).AddTicks(2051), "Gayle_Schmitt92@hotmail.com", -13.6256, -158.21530000000001, "District Factors Administrator", "1-437-299-8807 x47286", "70203" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "9732 Jaylon Court", "Fadelshire", new DateTime(2022, 12, 29, 20, 1, 31, 197, DateTimeKind.Local).AddTicks(9621), "Daren.Johns22@gmail.com", 4.8284000000000002, 85.826899999999995, "Human Directives Consultant", "507.651.7303", "70013" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "65250 McDermott Estate", "Kochstad", new DateTime(2022, 10, 7, 4, 38, 53, 22, DateTimeKind.Local).AddTicks(4159), "Lela_Prohaska65@yahoo.com", 43.519500000000001, 4.2171000000000003, "Future Tactics Technician", "738-758-1896 x00211", "05073" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "379 Mckenzie Ports", "Janismouth", new DateTime(2023, 6, 12, 14, 40, 17, 622, DateTimeKind.Local).AddTicks(4670), "Marlin.Nitzsche85@gmail.com", 70.773300000000006, -37.834899999999998, "Principal Usability Officer", "1-290-283-2617", "98059" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "6638 Janessa Unions", "82749 Tremblay Lodge", new DateTime(2023, 6, 1, 12, 17, 1, 344, DateTimeKind.Local).AddTicks(2874), "Deborah.Corwin@gmail.com", "Damion", "Collins", "https://picsum.photos/640/480/?image=880", "https://picsum.photos/640/480/?image=1019", "(935) 840-9835 x5776", "Nicolasview", "56087" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "45195 Rolfson Ways", "50203 Raquel Stream", new DateTime(2023, 2, 4, 1, 0, 23, 721, DateTimeKind.Local).AddTicks(5066), "Jailyn2@yahoo.com", "Crystal", "Rolfson", "https://picsum.photos/640/480/?image=348", "https://picsum.photos/640/480/?image=212", "(481) 979-3433 x605", "Bergebury", "80126" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "159 Braun Springs", "6405 Johnson Square", new DateTime(2023, 7, 11, 11, 59, 38, 901, DateTimeKind.Local).AddTicks(459), "Dana.Zboncak97@gmail.com", "Nova", "Nikolaus", "https://picsum.photos/640/480/?image=644", "https://picsum.photos/640/480/?image=117", "(621) 626-9263 x19270", "Port Kelleyfurt", "24632-9000" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "31601 Enos Glen", "057 Seamus Run", new DateTime(2023, 4, 4, 23, 40, 5, 535, DateTimeKind.Local).AddTicks(6614), "Rylee_Bayer95@yahoo.com", "Zackary", "Legros", "https://picsum.photos/640/480/?image=1064", "https://picsum.photos/640/480/?image=223", "842-366-1370", "Port Aureliachester", "98342-4957" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "94619 Gladyce Crossroad", "85553 Walsh Haven", new DateTime(2023, 4, 19, 3, 36, 25, 630, DateTimeKind.Local).AddTicks(7435), "Jovani67@yahoo.com", "Levi", "Lynch", "https://picsum.photos/640/480/?image=562", "https://picsum.photos/640/480/?image=764", "281-251-1427 x2906", "Lake Peggieborough", "29181" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "3157 Bednar Mews", "2791 Streich Ranch", new DateTime(2023, 3, 14, 0, 20, 23, 519, DateTimeKind.Local).AddTicks(6705), "Leone78@yahoo.com", "Forrest", "Mayert", "https://picsum.photos/640/480/?image=678", "https://picsum.photos/640/480/?image=457", "1-440-360-3213", "Hoseaville", "28998" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "6811 Nicolas Ports", "4991 Lillie Path", new DateTime(2022, 9, 12, 7, 3, 31, 490, DateTimeKind.Local).AddTicks(5271), "Aurore_Witting90@gmail.com", "Joseph", "DuBuque", "https://picsum.photos/640/480/?image=422", "https://picsum.photos/640/480/?image=965", "1-778-300-9668 x68388", "West Lillyhaven", "27424" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "1916 Harris Landing", "7605 Bechtelar Lodge", new DateTime(2023, 3, 12, 0, 56, 41, 206, DateTimeKind.Local).AddTicks(8798), "Isidro.Watsica@yahoo.com", "Daren", "Bogisich", "https://picsum.photos/640/480/?image=368", "https://picsum.photos/640/480/?image=1029", "864-362-1268 x247", "Susanafort", "30044" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "012 Wyman Squares", "778 Bode Turnpike", new DateTime(2023, 7, 28, 6, 21, 51, 793, DateTimeKind.Local).AddTicks(6828), "Ruth41@gmail.com", "Caesar", "Jacobi", "https://picsum.photos/640/480/?image=1055", "https://picsum.photos/640/480/?image=1070", "559.479.2910 x446", "East Pauline", "52033" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "249 Drew Row", "8954 Maida Ports", new DateTime(2022, 10, 20, 0, 34, 9, 307, DateTimeKind.Local).AddTicks(2998), "Maud85@hotmail.com", "Shaina", "Simonis", "https://picsum.photos/640/480/?image=411", "https://picsum.photos/640/480/?image=292", "332.553.8803", "Whiteshire", "27184-5928" });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 5, 8, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 8, 2 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 2, 10, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 7, 5, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 7, 8, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 3, 9 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 9, 8, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 1, 9, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 1, 9 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 4, 5 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 22, 16, 56, 59, 967, DateTimeKind.Local).AddTicks(3578), new DateTime(2023, 8, 23, 11, 53, 59, 735, DateTimeKind.Local).AddTicks(5512), new DateTime(2024, 7, 27, 3, 29, 22, 622, DateTimeKind.Local).AddTicks(8743), 7, 9.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 22, 20, 20, 48, 748, DateTimeKind.Local).AddTicks(5420), new DateTime(2023, 8, 23, 2, 40, 14, 948, DateTimeKind.Local).AddTicks(7153), new DateTime(2024, 6, 17, 9, 51, 53, 90, DateTimeKind.Local).AddTicks(4747), 2, 6.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 22, 14, 5, 15, 945, DateTimeKind.Local).AddTicks(8290), new DateTime(2023, 8, 22, 23, 52, 40, 616, DateTimeKind.Local).AddTicks(5856), new DateTime(2024, 3, 7, 0, 24, 31, 608, DateTimeKind.Local).AddTicks(4577), 4, 8.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 22, 14, 26, 18, 1, DateTimeKind.Local).AddTicks(1444), new DateTime(2023, 8, 23, 8, 10, 59, 957, DateTimeKind.Local).AddTicks(8499), new DateTime(2024, 5, 21, 5, 42, 35, 78, DateTimeKind.Local).AddTicks(692), 8, 6.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 22, 14, 49, 52, 937, DateTimeKind.Local).AddTicks(6160), new DateTime(2023, 8, 23, 3, 45, 1, 578, DateTimeKind.Local).AddTicks(878), new DateTime(2024, 1, 21, 23, 56, 20, 659, DateTimeKind.Local).AddTicks(4657), 3, 7.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 22, 8, 38, 59, 377, DateTimeKind.Local).AddTicks(4647), new DateTime(2023, 8, 23, 19, 26, 24, 541, DateTimeKind.Local).AddTicks(5760), new DateTime(2023, 8, 23, 3, 43, 33, 129, DateTimeKind.Local).AddTicks(7961), 1, 5.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 22, 16, 33, 7, 841, DateTimeKind.Local).AddTicks(7815), new DateTime(2023, 8, 23, 13, 43, 56, 161, DateTimeKind.Local).AddTicks(6757), new DateTime(2024, 2, 26, 15, 48, 55, 358, DateTimeKind.Local).AddTicks(8854), 1, 6.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 22, 17, 24, 44, 75, DateTimeKind.Local).AddTicks(8565), new DateTime(2023, 8, 23, 5, 53, 17, 131, DateTimeKind.Local).AddTicks(663), new DateTime(2024, 8, 6, 4, 18, 7, 106, DateTimeKind.Local).AddTicks(388), 10, 8.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 22, 19, 6, 39, 365, DateTimeKind.Local).AddTicks(3143), new DateTime(2023, 8, 23, 15, 15, 4, 850, DateTimeKind.Local).AddTicks(3289), new DateTime(2024, 3, 18, 7, 22, 20, 937, DateTimeKind.Local).AddTicks(4116), 2, 5.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 22, 3, 29, 51, 219, DateTimeKind.Local).AddTicks(4519), new DateTime(2023, 8, 23, 20, 15, 52, 198, DateTimeKind.Local).AddTicks(8641), new DateTime(2023, 11, 7, 10, 30, 4, 213, DateTimeKind.Local).AddTicks(5036), 3, 10.0, false });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 16, 31, 11, 911, DateTimeKind.Local).AddTicks(7665), new DateTime(2023, 8, 23, 0, 44, 6, 241, DateTimeKind.Local).AddTicks(3089), new DateTime(2024, 5, 11, 4, 10, 56, 522, DateTimeKind.Local).AddTicks(3228), 1, "8e0e6a8f-cacb-47f0-947d-a945eaad2e4c", "Confirmé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 6, 49, 41, 598, DateTimeKind.Local).AddTicks(4153), new DateTime(2023, 8, 23, 6, 0, 37, 601, DateTimeKind.Local).AddTicks(1555), new DateTime(2023, 12, 23, 15, 10, 55, 743, DateTimeKind.Local).AddTicks(9579), 4, "0394c7bc-4e15-4a67-a284-1d16ea7bb0e7", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 22, 15, 44, 21, 718, DateTimeKind.Local).AddTicks(3432), new DateTime(2023, 8, 23, 1, 40, 22, 246, DateTimeKind.Local).AddTicks(2661), new DateTime(2024, 8, 2, 9, 32, 48, 109, DateTimeKind.Local).AddTicks(280), 10, "b2ae946b-5fc0-4125-9c3b-aab30ea82441" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 8, 10, 35, 703, DateTimeKind.Local).AddTicks(4876), new DateTime(2023, 8, 23, 19, 40, 7, 815, DateTimeKind.Local).AddTicks(820), new DateTime(2024, 6, 21, 5, 41, 30, 98, DateTimeKind.Local).AddTicks(4246), 4, "f236efe7-186f-4d13-bbe8-9b8dd89e19dc", "Expiré" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 3, 53, 48, 42, DateTimeKind.Local).AddTicks(6362), new DateTime(2023, 8, 23, 2, 2, 16, 587, DateTimeKind.Local).AddTicks(4794), new DateTime(2024, 7, 17, 15, 25, 35, 265, DateTimeKind.Local).AddTicks(6682), 7, "d00a48bd-46ad-410e-b53d-671d32aa6115", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 22, 3, 17, 2, 850, DateTimeKind.Local).AddTicks(8434), new DateTime(2023, 8, 23, 23, 33, 40, 948, DateTimeKind.Local).AddTicks(3303), new DateTime(2024, 7, 1, 6, 47, 51, 692, DateTimeKind.Local).AddTicks(180), 3, "ed552926-ad2a-4d7b-ae8d-f763391975dd" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 22, 12, 38, 42, 722, DateTimeKind.Local).AddTicks(5578), new DateTime(2023, 8, 23, 5, 19, 19, 740, DateTimeKind.Local).AddTicks(7181), new DateTime(2024, 3, 13, 9, 39, 32, 45, DateTimeKind.Local).AddTicks(3734), 9, "a9e43de3-eafa-48ff-9a41-7e2b8c2796a5" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 22, 4, 39, 25, 549, DateTimeKind.Local).AddTicks(2752), new DateTime(2023, 8, 23, 1, 14, 15, 241, DateTimeKind.Local).AddTicks(2261), new DateTime(2024, 8, 15, 21, 21, 11, 741, DateTimeKind.Local).AddTicks(3840), 3, "7b8d8aed-44a7-432f-886f-81dcc0cae112" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 3, 13, 55, 572, DateTimeKind.Local).AddTicks(9686), new DateTime(2023, 8, 23, 14, 59, 31, 942, DateTimeKind.Local).AddTicks(1177), new DateTime(2024, 1, 19, 0, 47, 10, 218, DateTimeKind.Local).AddTicks(2113), 4, "95319518-b1c8-4e41-8e82-ff3affcc02dd", "Confirmé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 22, 19, 30, 12, 191, DateTimeKind.Local).AddTicks(2186), new DateTime(2023, 8, 23, 12, 48, 42, 82, DateTimeKind.Local).AddTicks(6252), new DateTime(2024, 3, 5, 15, 32, 40, 146, DateTimeKind.Local).AddTicks(1903), 8, "218f8ed7-53fd-4622-9780-0b3230b81eb7" });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "IdPermission", "IdRole", "CreatedAt", "DeletedAt", "Id", "UpdatedAt" },
                values: new object[,]
                {
                    { 2, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null },
                    { 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null },
                    { 4, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null },
                    { 6, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null },
                    { 7, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null },
                    { 13, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null },
                    { 8, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null },
                    { 9, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null },
                    { 10, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null },
                    { 11, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null },
                    { 12, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 8, 12, 11, 18, 51, 9, DateTimeKind.Local).AddTicks(6552), "Vicky_Nader33@gmail.com", "Joany", "Kassulke", "$2a$11$GHnpmx7pye9ulHPpH0Imjeb/BrGn.0drIGp6pXnr0/8tmMOiOn5ba" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 11, 30, 18, 0, 17, 950, DateTimeKind.Local).AddTicks(8218), "Grover_Watsica17@yahoo.com", "Yazmin", 1, true, "Boyle", "$2a$11$Zo7WgzatMuHFqp5oiiug..4V9cT1SbO7iUYON8bw68W0sdozWPtFW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 2, 18, 57, 55, 617, DateTimeKind.Local).AddTicks(1870), "Shayne.Hermiston95@hotmail.com", "Rhett", 9, false, "Goodwin", "$2a$11$uWKMdBugPzJf0.e524r1q.DreW.jWYvAt.3pf7KOuzCukcN1j6mwa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 2, 22, 9, 27, 29, 852, DateTimeKind.Local).AddTicks(2400), "Adrain_Block@gmail.com", "Trystan", 6, 1, "O'Hara", "$2a$11$Y0di2yr5SVDbXxPDXN32yuPs1eyi9snnK20Pg1s.l0BXmHIIeS4La" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 2, 4, 19, 57, 26, 260, DateTimeKind.Local).AddTicks(2938), "Charlotte.Volkman@gmail.com", "Delfina", 9, false, "Conn", "$2a$11$/.08gTSiYteeZMLoUpDSO.h/mTbX2X8bgUQGfyO40k6IXpXd9QsJq" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 2, 12, 10, 7, 24, 837, DateTimeKind.Local).AddTicks(8451), "Boyd_Parisian54@hotmail.com", "Francisco", 3, false, "Schulist", "$2a$11$WHY4z.H93elphObmPs1SBuBUWCKES0cABVPvdv.gLx1ijBNitbTMi" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 7, 8, 13, 53, 11, 462, DateTimeKind.Local).AddTicks(6872), "Hermann_Witting2@yahoo.com", "Nova", 2, false, "Littel", "$2a$11$8LJDoYaTyLBVNCb1RUT6Q.KgkUNv37zJFi3KSkhXJZATpvo/ITov." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 22, 1, 56, 37, 897, DateTimeKind.Local).AddTicks(3127), "Omer26@gmail.com", "Drake", 9, "Nicolas", "$2a$11$2RmhwvmCDN5GFpQpNQA9seHnBoHHFSIbp2QWbDTavj/wgUl9WZH0S" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 4, 30, 0, 7, 54, 947, DateTimeKind.Local).AddTicks(9095), "Timmy_Luettgen@gmail.com", "Cassandre", 6, true, "Bradtke", "$2a$11$HLMZ7WyJBr/Vp032p4UlYeqyE0BW/iKJCifl56/auqgeLJfqXc14e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 6, 9, 15, 46, 315, DateTimeKind.Local).AddTicks(8932), "Courtney_Hermiston51@gmail.com", "Vance", 6, "Huel", "$2a$11$XQsz2dn1EaqQSyU1kBficupD9ORwDukDlNjhYtywqZf0L.b1eB/VC" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "Prix", "Type" },
                values: new object[] { true, new DateTime(2023, 2, 1, 17, 31, 4, 244, DateTimeKind.Local).AddTicks(6240), "ltmkfewjjg", 5, 25, 8191, "mcbvzkrrtn", "qxwfwywziz", "qmudbvgzxw", 3, 1.0, "qmrvoahvow" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2023, 4, 13, 12, 3, 5, 731, DateTimeKind.Local).AddTicks(3720), "hxreaoywua", 6, 6, 4295, "hripiaafkx", "cxpkwtqllq", "jlutpykbsl", 7, 6, 2.0, "nulaxabtcp" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2023, 3, 19, 8, 59, 32, 619, DateTimeKind.Local).AddTicks(3894), "alpiifozeg", 1, 194, 446, "iibnlhubge", "ciaywqkvqr", "zsdifdtkwx", 1, 7, 3.0, "mgndvhmcch" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Type" },
                values: new object[] { true, new DateTime(2023, 5, 12, 21, 18, 54, 422, DateTimeKind.Local).AddTicks(3784), "nnbrkxeqty", 10, 56, 9255, "fohispmsqk", "endndjzobj", "fjowsqrjqh", 1, 6, "iclbvbtjsv" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "Prix", "Type" },
                values: new object[] { new DateTime(2023, 1, 24, 22, 34, 0, 669, DateTimeKind.Local).AddTicks(8210), "wxxpqkueyw", 4, 32, 7837, "jeabterexs", "ihykqhuhld", "ahpsnbqcbj", 1.0, "eozwrxfada" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2023, 8, 16, 5, 45, 24, 788, DateTimeKind.Local).AddTicks(4430), "ukcqdxvlkl", 3, 77, 509, "zvplggmosm", "vpkijxjppt", "zqoibqkdem", 9, 9.0, "gcuwiefjfb" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2023, 1, 16, 5, 44, 51, 467, DateTimeKind.Local).AddTicks(2055), "bjwkwnxpwi", 9, 174, 2495, "qfpljecsgc", "ljifwtlcqo", "mychlzwqas", 9, 5, 1.0, "xhjmpsfxrk" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, false, new DateTime(2023, 6, 13, 10, 28, 50, 211, DateTimeKind.Local).AddTicks(9438), "fumhwazqus", 1, 295, 9145, "cbwfpdlfeh", "gwgpoklugh", "hjqzzumigu", 4, 3, 3.0, "gzqfljvmhz" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2023, 7, 31, 9, 47, 34, 616, DateTimeKind.Local).AddTicks(2721), "ibejtutkbd", 8, 106, 9446, "hsshbfvlvp", "zmcvmxaixl", "wslgrdjxjz", 7, 5, 9.0, "wiqwzszgxh" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2023, 1, 26, 6, 40, 30, 664, DateTimeKind.Local).AddTicks(5614), "oeoeobkbwv", 7, 282, 5129, "chixxbcbbb", "lqeljfknsg", "npgevptsct", 7, 2, 10.0, "tnmwoozixs" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "MontantTotal", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 1, 29, 16, 8, 50, 484, DateTimeKind.Local).AddTicks(3803), "wzvnejujsb", 276, 9.0, "vccwnpqbpb", "bkhlsajehq", "D'Amore", 18, "Wyman - Durgan", "Keon", "714.528.0472 x831", "Toy", "Grahamstad", "54071" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "MontantTotal", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 2, 26, 21, 28, 25, 333, DateTimeKind.Local).AddTicks(5941), "xpcufhxnxp", 106, 7.0, "szpvabojry", "gampqbpviw", "Lockman", 19, "Williamson, Lehner and Kautzer", "Wilmer", "(836) 702-9946 x11399", "Bailey", "Alekport", "51314-6300" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "MontantTotal", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 4, 8, 17, 15, 48, 582, DateTimeKind.Local).AddTicks(5850), "hgjuzapcyb", 48, 10.0, "yvpouxmgqo", "gdovkibhvk", "Rolfson", 28, "Muller - Toy", "Eloy", "340.980.3345 x42058", "Mosciski", "Halvorsonland", "80596-9385" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "MontantTotal", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 11, 9, 14, 21, 57, 921, DateTimeKind.Local).AddTicks(3972), "rucmxphgio", 255, 7.0, "wslozzwtkz", "cueozyceug", "Terry", 32, "Legros, Prohaska and Price", "Brock", "674-845-2174 x6606", "Sporer", "New Ameliaview", "79926" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "MontantTotal", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 11, 29, 14, 43, 28, 287, DateTimeKind.Local).AddTicks(8569), "cgjulnefzk", 132, 9.0, "dbgfddhdzs", "cmbgokemfi", "Leannon", 23, "Mann, Emard and Lehner", "Darren", "445.611.0857", "Bailey", "East Raheem", "17796" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "MontantTotal", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 12, 5, 3, 49, 10, 828, DateTimeKind.Local).AddTicks(2231), "ygqeijmwvu", 128, 3.0, "ygjjcaajlb", "xfscldcbiz", "Smith", 28, "Kris and Sons", "Dustin", "(449) 538-2668 x04157", "Reichert", "North Michel", "67053" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "MontantTotal", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 1, 6, 2, 2, 24, 951, DateTimeKind.Local).AddTicks(91), "tqhyqyckhl", 78, 3.0, "bbvngcgkfc", "vdsalpiith", "Nitzsche", 33, "Mohr, Reichel and Armstrong", "Era", "1-647-364-4367 x3587", "Paucek", "Haleystad", "48718-7256" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "MontantTotal", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 1, 26, 14, 16, 27, 100, DateTimeKind.Local).AddTicks(9908), "fxxrpirjgw", 55, 9.0, "onlozmmiwu", "zelpncbkil", "Beatty", 30, "Lesch and Sons", "Lauryn", "(551) 429-8493 x61259", "Koepp", "West Addieberg", "68452-2159" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "MontantTotal", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 3, 20, 3, 44, 1, 267, DateTimeKind.Local).AddTicks(5687), "gzixledzts", 246, 8.0, "tkqqmfefxu", "uzwyhbxlwm", "Ryan", 33, "Bashirian and Sons", "Mervin", "287-464-1497 x1854", "Hammes", "Jacobsbury", "36119-5363" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "MontantTotal", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 7, 13, 7, 48, 43, 873, DateTimeKind.Local).AddTicks(9923), "nxbpvwbvok", 294, 8.0, "cuxsjckkfk", "acacoivsqs", "Schaefer", 23, "Koss - Reilly", "Murphy", "1-521-274-9373 x1933", "Kulas", "New Angelostad", "08763-4309" });
        }
    }
}
