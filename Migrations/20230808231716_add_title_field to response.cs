using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomotiveApi.Migrations
{
    /// <inheritdoc />
    public partial class add_title_fieldtoresponse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "title",
                table: "lld_responses",
                type: "longtext",
                nullable: false);

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "2246 Kelley Walks", "New Alisonburgh", new DateTime(2022, 8, 10, 21, 1, 59, 875, DateTimeKind.Local).AddTicks(663), "Reymundo_Wintheiser@yahoo.com", 45.507199999999997, 137.16480000000001, "Dynamic Operations Analyst", "986.781.7263 x8166", "15483-5887" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "7784 Casper Manors", "Dorcasshire", new DateTime(2022, 11, 6, 6, 50, 0, 112, DateTimeKind.Local).AddTicks(397), "Sandrine.Huel79@yahoo.com", 16.43, 13.417999999999999, "Corporate Data Supervisor", "989.769.4362 x095", "37601" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "315 Harber Overpass", "Maggiobury", new DateTime(2022, 10, 30, 8, 54, 13, 841, DateTimeKind.Local).AddTicks(3913), "Obie_Little@hotmail.com", -82.917000000000002, -102.7353, "Internal Identity Coordinator", "(564) 288-3931 x3510", "94871" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "471 Jada Extensions", "North Lamarbury", new DateTime(2023, 6, 3, 12, 11, 1, 97, DateTimeKind.Local).AddTicks(3435), "Aiyana_Gusikowski@yahoo.com", -34.581899999999997, -37.872900000000001, "Principal Marketing Producer", "1-799-614-3273 x70600", "17191-8626" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "970 Tiara Groves", "North Ewell", new DateTime(2023, 3, 27, 19, 6, 39, 273, DateTimeKind.Local).AddTicks(2838), "Alexanne81@yahoo.com", -40.325000000000003, 72.039599999999993, "Product Response Technician", "(606) 390-6054 x51316", "56056" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "65244 Kiehn Springs", "North Amya", new DateTime(2022, 8, 30, 12, 17, 20, 311, DateTimeKind.Local).AddTicks(9100), "Cedrick54@hotmail.com", -61.060000000000002, -1.9831000000000001, "Corporate Tactics Administrator", "826.471.0744 x7827", "25976-0602" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "432 Eveline Junctions", "Mattiemouth", new DateTime(2023, 6, 30, 6, 18, 58, 945, DateTimeKind.Local).AddTicks(7122), "Cary.Baumbach85@hotmail.com", -34.2331, 103.2841, "Senior Operations Associate", "848.629.4647 x178", "13655-7481" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "663 Runte Mill", "Port Justice", new DateTime(2022, 11, 15, 23, 15, 4, 333, DateTimeKind.Local).AddTicks(970), "Tyra10@hotmail.com", -30.679099999999998, -53.543500000000002, "Dynamic Security Associate", "1-897-900-7719 x88758", "36149-2090" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "1116 Bernadine Glen", "New Vitomouth", new DateTime(2023, 3, 24, 0, 56, 44, 347, DateTimeKind.Local).AddTicks(2599), "Alize.Mante9@gmail.com", -4.851, 123.07550000000001, "Lead Mobility Representative", "777.350.7657", "03590" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "9012 Floy Valleys", "Lake Abigale", new DateTime(2023, 1, 11, 17, 34, 51, 843, DateTimeKind.Local).AddTicks(6248), "Douglas92@hotmail.com", 74.508099999999999, 171.18610000000001, "International Operations Engineer", "(347) 741-5087", "90622-8933" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "14739 Maya Course", "136 Kautzer Gateway", new DateTime(2023, 7, 17, 12, 37, 51, 800, DateTimeKind.Local).AddTicks(988), "Vilma_MacGyver89@yahoo.com", "Alvina", "Weber", "https://picsum.photos/640/480/?image=883", "https://picsum.photos/640/480/?image=460", "997.377.6673", "North Karsonville", "62755" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "3592 Oceane Ramp", "1792 Khalil Creek", new DateTime(2022, 10, 6, 4, 27, 27, 404, DateTimeKind.Local).AddTicks(8454), "Eleonore_Gutmann16@hotmail.com", "Adah", "Ullrich", "https://picsum.photos/640/480/?image=896", "https://picsum.photos/640/480/?image=492", "819.654.0955 x98398", "Lake Virgiemouth", "46913" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "91926 Meaghan Lane", "544 Carlotta Turnpike", new DateTime(2022, 11, 8, 18, 37, 58, 23, DateTimeKind.Local).AddTicks(6853), "Gladyce50@yahoo.com", "Bria", "Roberts", "https://picsum.photos/640/480/?image=115", "https://picsum.photos/640/480/?image=377", "1-582-476-1194 x46228", "New Barretttown", "43555-6612" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "06672 Eriberto Passage", "2348 Glover Parkway", new DateTime(2023, 7, 1, 13, 21, 24, 932, DateTimeKind.Local).AddTicks(7665), "Kolby8@hotmail.com", "Alberta", "Heaney", "https://picsum.photos/640/480/?image=455", "https://picsum.photos/640/480/?image=183", "649-611-4063 x9685", "Raynorfort", "48825" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "32756 Morissette Ports", "109 Wehner Park", new DateTime(2023, 3, 3, 1, 46, 37, 738, DateTimeKind.Local).AddTicks(1556), "Chauncey66@hotmail.com", "Jeremie", "Rippin", "https://picsum.photos/640/480/?image=459", "https://picsum.photos/640/480/?image=848", "(581) 208-2697 x811", "Annalisefurt", "91360" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "4361 Medhurst Wells", "1616 Bernier Views", new DateTime(2022, 8, 13, 21, 23, 26, 754, DateTimeKind.Local).AddTicks(5412), "Alta.Nikolaus@yahoo.com", "Lon", "Kohler", "https://picsum.photos/640/480/?image=1016", "https://picsum.photos/640/480/?image=462", "960.383.8063", "Port Amiya", "18154-7889" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "8120 Mills Loaf", "8223 Mueller View", new DateTime(2023, 3, 11, 10, 21, 45, 464, DateTimeKind.Local).AddTicks(7822), "Teresa_Green78@yahoo.com", "Ernest", "Reichel", "https://picsum.photos/640/480/?image=822", "https://picsum.photos/640/480/?image=851", "1-489-825-5922", "Cordiaborough", "35507-7588" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "102 Lehner Way", "728 Renner Mission", new DateTime(2023, 1, 19, 7, 13, 18, 428, DateTimeKind.Local).AddTicks(2056), "Ulises_Olson39@hotmail.com", "Shanelle", "Towne", "https://picsum.photos/640/480/?image=366", "https://picsum.photos/640/480/?image=765", "1-384-882-6110", "Pacochaborough", "85777" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "641 Conn Mill", "4516 Fahey Cliffs", new DateTime(2023, 1, 2, 3, 29, 41, 370, DateTimeKind.Local).AddTicks(8313), "Vincent_OHara32@hotmail.com", "Keith", "Prosacco", "https://picsum.photos/640/480/?image=403", "https://picsum.photos/640/480/?image=14", "215.459.7708 x660", "Willbury", "88807-6516" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "0940 Yolanda Parkways", "70490 Fredrick Grove", new DateTime(2023, 4, 14, 3, 49, 15, 408, DateTimeKind.Local).AddTicks(7033), "Carmella.Kuphal@gmail.com", "Ruth", "O'Hara", "https://picsum.photos/640/480/?image=245", "https://picsum.photos/640/480/?image=1025", "1-752-764-8784 x2416", "Port Clint", "86352" });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsConducteur",
                value: false);

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 10, 7, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 5, 7, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 4,
                column: "IdReservation",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 9, 4, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 6,
                column: "IdClient",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 1, 5, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 7, 4, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "IdReservation", "IsConducteur" },
                values: new object[] { 6, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 6, 8 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 8, 10, 6, 48, 841, DateTimeKind.Local).AddTicks(4844), new DateTime(2023, 8, 9, 1, 13, 40, 87, DateTimeKind.Local).AddTicks(6240), new DateTime(2023, 12, 19, 19, 17, 56, 310, DateTimeKind.Local).AddTicks(2266), 2, 4.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 8, 1, 55, 55, 683, DateTimeKind.Local).AddTicks(2452), new DateTime(2023, 8, 9, 20, 11, 25, 441, DateTimeKind.Local).AddTicks(3311), new DateTime(2024, 4, 19, 15, 4, 1, 661, DateTimeKind.Local).AddTicks(7713), 3, 5.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule" },
                values: new object[] { new DateTime(2023, 8, 8, 17, 25, 20, 748, DateTimeKind.Local).AddTicks(3107), new DateTime(2023, 8, 9, 19, 5, 11, 688, DateTimeKind.Local).AddTicks(4263), new DateTime(2024, 7, 29, 18, 47, 53, 371, DateTimeKind.Local).AddTicks(1159), 6 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 8, 11, 59, 47, 976, DateTimeKind.Local).AddTicks(4695), new DateTime(2023, 8, 9, 5, 7, 37, 384, DateTimeKind.Local).AddTicks(6413), new DateTime(2024, 4, 24, 23, 59, 7, 736, DateTimeKind.Local).AddTicks(6520), 6, 9.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 8, 2, 45, 3, 226, DateTimeKind.Local).AddTicks(6935), new DateTime(2023, 8, 9, 3, 48, 55, 183, DateTimeKind.Local).AddTicks(2200), new DateTime(2024, 7, 31, 5, 5, 15, 383, DateTimeKind.Local).AddTicks(1853), 8, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 8, 8, 48, 28, 958, DateTimeKind.Local).AddTicks(8411), new DateTime(2023, 8, 9, 16, 27, 40, 811, DateTimeKind.Local).AddTicks(3697), new DateTime(2024, 3, 22, 23, 47, 29, 194, DateTimeKind.Local).AddTicks(6609), 9, 5.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 8, 14, 26, 22, 345, DateTimeKind.Local).AddTicks(7800), new DateTime(2023, 8, 9, 4, 32, 1, 305, DateTimeKind.Local).AddTicks(8461), new DateTime(2023, 11, 22, 22, 21, 22, 905, DateTimeKind.Local).AddTicks(8992), 6, 6.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 8, 9, 39, 42, 254, DateTimeKind.Local).AddTicks(1910), new DateTime(2023, 8, 9, 14, 44, 10, 516, DateTimeKind.Local).AddTicks(124), new DateTime(2024, 5, 11, 7, 48, 23, 763, DateTimeKind.Local).AddTicks(7534), 2, 5.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule" },
                values: new object[] { new DateTime(2023, 8, 8, 18, 13, 30, 943, DateTimeKind.Local).AddTicks(2798), new DateTime(2023, 8, 9, 23, 39, 52, 364, DateTimeKind.Local).AddTicks(6904), new DateTime(2023, 12, 20, 10, 26, 44, 991, DateTimeKind.Local).AddTicks(2812), 2 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 8, 5, 40, 0, 166, DateTimeKind.Local).AddTicks(4535), new DateTime(2023, 8, 9, 15, 33, 47, 57, DateTimeKind.Local).AddTicks(7276), new DateTime(2024, 5, 4, 18, 28, 27, 786, DateTimeKind.Local).AddTicks(3294), 6, 9.0, false });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 8, 20, 11, 50, 382, DateTimeKind.Local).AddTicks(8213), new DateTime(2023, 8, 10, 0, 4, 9, 267, DateTimeKind.Local).AddTicks(2993), new DateTime(2024, 3, 30, 12, 21, 20, 910, DateTimeKind.Local).AddTicks(6560), 1, "7df6a69a-1fe8-4718-80ab-910d5cc5ec2e", "Annulé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 8, 22, 24, 51, 897, DateTimeKind.Local).AddTicks(8650), new DateTime(2023, 8, 9, 22, 3, 36, 932, DateTimeKind.Local).AddTicks(8129), new DateTime(2023, 12, 17, 0, 23, 31, 896, DateTimeKind.Local).AddTicks(2764), 3, "5d5a906b-4aeb-4a58-8046-6741279e9295", "Confirmé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 8, 8, 25, 53, 92, DateTimeKind.Local).AddTicks(5684), new DateTime(2023, 8, 9, 18, 38, 25, 651, DateTimeKind.Local).AddTicks(8551), new DateTime(2023, 11, 22, 17, 46, 8, 226, DateTimeKind.Local).AddTicks(7118), "ae555553-480a-4868-a668-dfe9c85e1ade", "Confirmé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 8, 6, 56, 42, 17, DateTimeKind.Local).AddTicks(8242), new DateTime(2023, 8, 9, 22, 14, 13, 519, DateTimeKind.Local).AddTicks(598), new DateTime(2024, 7, 5, 0, 17, 56, 31, DateTimeKind.Local).AddTicks(5202), 5, "add5f922-0fc8-4246-b429-ce0ecb8c7d0e" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 8, 20, 35, 28, 754, DateTimeKind.Local).AddTicks(9312), new DateTime(2023, 8, 9, 21, 56, 46, 796, DateTimeKind.Local).AddTicks(3065), new DateTime(2023, 12, 15, 5, 31, 9, 42, DateTimeKind.Local).AddTicks(3388), 4, "61972ba6-a44e-47f6-aa3a-52152a6c8894", "Expiré" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 8, 6, 35, 41, 431, DateTimeKind.Local).AddTicks(5750), new DateTime(2023, 8, 10, 0, 1, 26, 987, DateTimeKind.Local).AddTicks(504), new DateTime(2023, 8, 29, 17, 7, 43, 683, DateTimeKind.Local).AddTicks(211), 7, "de560410-cf7a-4372-987e-79261da05d8f", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 8, 19, 18, 19, 710, DateTimeKind.Local).AddTicks(3210), new DateTime(2023, 8, 9, 10, 16, 22, 936, DateTimeKind.Local).AddTicks(2542), new DateTime(2024, 1, 5, 19, 24, 56, 933, DateTimeKind.Local).AddTicks(9182), 2, "dc374b7b-660a-4b70-9d73-4c4a9f886ce2", "Confirmé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 8, 23, 43, 53, 762, DateTimeKind.Local).AddTicks(489), new DateTime(2023, 8, 9, 8, 26, 46, 9, DateTimeKind.Local).AddTicks(3021), new DateTime(2023, 9, 7, 2, 1, 50, 478, DateTimeKind.Local).AddTicks(1370), 3, "6692943c-6a9f-44e9-98c9-b511b5f59d02", "Expiré" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 8, 3, 15, 39, 280, DateTimeKind.Local).AddTicks(5586), new DateTime(2023, 8, 9, 19, 19, 15, 212, DateTimeKind.Local).AddTicks(5207), new DateTime(2024, 7, 16, 7, 13, 49, 798, DateTimeKind.Local).AddTicks(4607), 3, "e17a57fb-4b16-498b-9be7-1e1e9da63a5b", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 8, 10, 14, 14, 475, DateTimeKind.Local).AddTicks(4542), new DateTime(2023, 8, 9, 15, 9, 23, 6, DateTimeKind.Local).AddTicks(4324), new DateTime(2023, 12, 5, 19, 52, 43, 978, DateTimeKind.Local).AddTicks(4985), 7, "fb93045a-0917-44e2-af7b-5e1141c41698", "Confirmé" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 2, 13, 0, 23, 7, 510, DateTimeKind.Local).AddTicks(4904), "Nellie16@gmail.com", "Jacynthe", 7, true, "Mertz", "$2a$11$/SdOKWBteYPGWaNC5kQnT.KPguoUJkGr8ys3XEdldvcvxWcmUD19i" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 24, 9, 53, 7, 399, DateTimeKind.Local).AddTicks(3116), "Bobbie22@gmail.com", "Stephany", 5, 2, true, "Lemke", "$2a$11$bDVDUcP7sZV4yI02DTertOPjzwRLuXyPKLbcP7MsjP6jawr1GKjVu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 22, 16, 20, 6, 104, DateTimeKind.Local).AddTicks(1550), "Mara82@gmail.com", "Max", 9, true, "Strosin", "$2a$11$doFou8U3/4oRfcH0xusHU.y2kZrPyXKWwjWLbZw5iOJPVkoUO4CP2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 28, 16, 13, 2, 266, DateTimeKind.Local).AddTicks(3463), "Ada48@hotmail.com", "Alta", 1, "Adams", "$2a$11$ecP1aQRkaf1evPyvmwJN1.wcG.iruhYp7US79DgvZ0QSk6/R2oX9i" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 24, 20, 49, 6, 528, DateTimeKind.Local).AddTicks(2994), "Tyshawn94@hotmail.com", "Helen", 2, "Swaniawski", "$2a$11$QHRh6N74e3MnjVGX7Q1eg.DoCoUIOktpywQi656zAzCnsEyK7Ntuy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 7, 20, 787, DateTimeKind.Local).AddTicks(5440), "Jody_Will1@yahoo.com", "Carlie", 10, true, "Berge", "$2a$11$hb6VOsTgwWxscuRCJJkRqOlAEctujIxFNV0bUg86AUUGXL06OLR26" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 4, 20, 14, 20, 48, 230, DateTimeKind.Local).AddTicks(1967), "Karolann_Ankunding6@hotmail.com", "Elinore", 5, true, "O'Reilly", "$2a$11$oFNHbVla5xdnh2na26t7kefCn.NanhJNoljv3dKSWlgEQtHq/K6y." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 10, 25, 7, 51, 15, 103, DateTimeKind.Local).AddTicks(3025), "Caden_Price@gmail.com", "Sadye", 3, "Altenwerth", "$2a$11$8tP8ffj.lyOeAbKFKqFfeOH3XocQ6jnAWkiN5j/VLrQCNHjVYM7ha" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 30, 5, 30, 30, 691, DateTimeKind.Local).AddTicks(1593), "Ariane9@gmail.com", "Ignatius", 3, 1, "Larkin", "$2a$11$AOVektAoOBq7uddS6ir01eU8x5H7u/h5vXdNDOoYwqpH/AAh/IIB2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 11, 13, 16, 43, 14, 599, DateTimeKind.Local).AddTicks(6097), "Kristopher_DAmore4@gmail.com", "Tanner", 10, "Lang", "$2a$11$80JaEg.WTAMqo/0f8qnyJuK7zJBpwp0Iu9V9IFAsUedfsk6ooAWWC" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "Type" },
                values: new object[] { new DateTime(2023, 1, 25, 14, 50, 22, 369, DateTimeKind.Local).AddTicks(1162), "bfzdoolkal", 5, 204, 1296, "quagchmrfl", "tszmpmyvsi", "cnjxkyrtii", 6, "vydirovuhy" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2023, 3, 10, 11, 4, 46, 414, DateTimeKind.Local).AddTicks(1473), "eierwgfotg", 6, 198, 5854, "fjejzoxzeg", "cttcgrggmr", "bepaeqvyaq", 3, 2, 10.0, "uiptgpmxhk" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2023, 6, 2, 7, 26, 10, 591, DateTimeKind.Local).AddTicks(6184), "qnioiawhtz", 7, 259, 2220, "dgeewgtxnc", "bovdjcocys", "qdxajduevo", 6, 5, 9.0, "zrxxrngfhe" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2022, 8, 11, 3, 38, 57, 658, DateTimeKind.Local).AddTicks(793), "rmqkoezbmq", 6, 170, 7457, "epjzsumrnx", "xoruzigajt", "ouwfhfwilm", 1, 1, 3.0, "vcakypjzae" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2022, 10, 31, 13, 44, 6, 560, DateTimeKind.Local).AddTicks(3451), "rknmwyulby", 8, 61, 5225, "cftskqyzzt", "weartbveax", "pmfiklutxe", 5, 3, 1.0, "uxtjodwwoh" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2023, 5, 10, 8, 17, 29, 468, DateTimeKind.Local).AddTicks(7241), "wqofeklvpj", 3, 300, 2335, "islwjjmtju", "raoehbvqmr", "eldmxhlyij", 6, 2, 6.0, "hzmtkcueod" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "Km", "Matricule", "Moteur", "Name", "NbPassager", "Prix", "Type" },
                values: new object[] { true, false, new DateTime(2022, 12, 28, 6, 8, 5, 523, DateTimeKind.Local).AddTicks(364), "mlxgvigjwo", 8, 3064, "izdpzoiywo", "kempylpyrs", "iavepwspnh", 2, 2.0, "ogywavahrh" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "Prix", "Type" },
                values: new object[] { new DateTime(2023, 7, 21, 20, 44, 30, 439, DateTimeKind.Local).AddTicks(2384), "ttycayjbse", 4, 1, 940, "egtqxnlipg", "nljlqolbfe", "vrizbeywjv", 7.0, "ihhoyutcil" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2022, 9, 5, 5, 23, 16, 479, DateTimeKind.Local).AddTicks(5839), "pkjhpttjjh", 304, 9759, "lhyswrjeht", "kwaxdiupom", "yrbvotvthl", 1, 5, 5.0, "jcljtccioh" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2022, 9, 30, 7, 15, 16, 94, DateTimeKind.Local).AddTicks(6571), "rpirmcpcin", 7, 241, 1426, "zegllfapfx", "qvghtarsum", "kgifbsawph", 4, 4.0, "jamfiepoid" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 7, 12, 7, 25, 7, 796, DateTimeKind.Local).AddTicks(8472), 319, "dlfobczeoq", "Dickens", 25, "Denesik - Nader", "Jeramy", "745-842-0240", "Rice", "Karlieborough", "81330" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 7, 14, 2, 47, 23, 99, DateTimeKind.Local).AddTicks(6495), 117, "nccvmrhzeo", "Bernier", 31, "Muller - Adams", "Luther", "(560) 292-9627 x4684", "Gaylord", "Lake Braeden", "57590" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 5, 11, 20, 47, 20, 178, DateTimeKind.Local).AddTicks(9267), 137, "boyglawqhj", "Denesik", 28, "Zieme Inc", "Lindsey", "1-949-995-3770 x0201", "Hamill", "New Deshawn", "31481-5139" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 8, 3, 3, 10, 22, 99, DateTimeKind.Local).AddTicks(4434), 107, "xnlkvxkarh", "McDermott", 31, "Kessler Group", "Nicola", "531.796.0961", "Wintheiser", "Greenfelderborough", "21029-4134" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 2, 6, 12, 21, 28, 106, DateTimeKind.Local).AddTicks(1825), 219, "elgzmbwron", "Lang", 25, "Collins - Kerluke", "Hardy", "(431) 670-9116", "Prohaska", "South Abelardo", "79961" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 10, 8, 20, 37, 57, 943, DateTimeKind.Local).AddTicks(1083), 66, "lbbfjntifc", "Klein", "Douglas - VonRueden", "Allie", "751.735.9214 x6364", "Kreiger", "East Jevon", "56769" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 12, 23, 16, 32, 49, 514, DateTimeKind.Local).AddTicks(4413), 300, "xpzobqfugp", "Pacocha", 20, "Kunze - Wyman", "Dimitri", "729.386.9494 x85481", "Brown", "Makenzieborough", "99695-4724" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 10, 19, 0, 42, 14, 854, DateTimeKind.Local).AddTicks(9575), 7, "umgytseoqx", "Glover", 28, "Runolfsdottir, Abbott and Hegmann", "Monroe", "1-331-401-7204", "Homenick", "Hermanchester", "31619-0192" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 9, 23, 3, 8, 5, 237, DateTimeKind.Local).AddTicks(6908), 71, "opllnnsawx", "Kling", 32, "Doyle, Botsford and Kerluke", "Arlo", "421.812.6563 x286", "Reinger", "Lomaville", "67619" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 9, 25, 16, 10, 3, 695, DateTimeKind.Local).AddTicks(4559), 50, "cztacgdqti", "Walker", 25, "Bayer - Keeling", "Adriana", "228-923-5206 x470", "Terry", "Port Ellsworthberg", "28266" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "title",
                table: "lld_responses");

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "083 Sandy Views", "Hesselborough", new DateTime(2023, 8, 4, 13, 29, 9, 324, DateTimeKind.Local).AddTicks(353), "Kallie_Cartwright@yahoo.com", -88.497299999999996, -75.971199999999996, "Dynamic Creative Strategist", "1-702-475-1055 x29713", "13089-9875" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "2477 Cecile Ridge", "North Chelsie", new DateTime(2023, 6, 28, 14, 45, 34, 747, DateTimeKind.Local).AddTicks(2614), "Marcus_Turner@gmail.com", 1.2943, 57.4253, "Human Paradigm Consultant", "1-622-361-4880 x2874", "41371-3631" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "67224 Roberts Station", "Jeffreyland", new DateTime(2022, 8, 29, 4, 12, 50, 578, DateTimeKind.Local).AddTicks(2316), "Erling.Will18@gmail.com", -62.618099999999998, -80.902500000000003, "Forward Metrics Specialist", "929.974.1802 x2964", "39057" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "5359 Schulist Valley", "Joesphchester", new DateTime(2023, 1, 20, 8, 5, 49, 624, DateTimeKind.Local).AddTicks(220), "Hilma_Greenfelder@hotmail.com", -24.028099999999998, 62.537700000000001, "Product Mobility Supervisor", "500-443-1993 x33699", "34188" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "064 Sigmund Circles", "Hackettport", new DateTime(2023, 4, 28, 1, 37, 38, 279, DateTimeKind.Local).AddTicks(5327), "Shana_Borer@gmail.com", 12.078099999999999, -143.03309999999999, "Dynamic Web Technician", "276.312.6914 x1053", "05425-9045" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "663 Marvin Radial", "Ferrystad", new DateTime(2023, 6, 7, 18, 27, 34, 145, DateTimeKind.Local).AddTicks(2920), "Kaylee_Zemlak73@gmail.com", 5.3666999999999998, -62.634300000000003, "Dynamic Applications Executive", "655.986.6983", "45251" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "26840 Kenna Tunnel", "Hammesstad", new DateTime(2023, 7, 16, 13, 17, 57, 295, DateTimeKind.Local).AddTicks(9249), "Ewell.Frami@hotmail.com", -15.936, 145.39089999999999, "Product Applications Facilitator", "(874) 447-1059", "75886" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "538 Isobel Square", "Lake Karineburgh", new DateTime(2023, 7, 9, 7, 4, 3, 552, DateTimeKind.Local).AddTicks(3433), "Dario26@gmail.com", 10.9361, -172.07310000000001, "Customer Paradigm Orchestrator", "548-686-1999 x1776", "67311-7793" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "62347 Carmela Summit", "North Cole", new DateTime(2023, 3, 20, 17, 40, 5, 762, DateTimeKind.Local).AddTicks(1550), "Abigale.Reinger@gmail.com", 62.541600000000003, 166.65350000000001, "Future Accounts Officer", "522-385-1975 x175", "45062-5572" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "53788 Bernier Place", "Anastacioside", new DateTime(2023, 4, 20, 13, 37, 42, 38, DateTimeKind.Local).AddTicks(1433), "Damaris39@gmail.com", -18.4361, 51.939300000000003, "Forward Functionality Assistant", "692-794-4039", "90314-1937" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "8688 Cathryn Forge", "0194 White Fields", new DateTime(2022, 10, 23, 10, 48, 30, 719, DateTimeKind.Local).AddTicks(3458), "Darlene_Wuckert51@yahoo.com", "Palma", "Bartoletti", "https://picsum.photos/640/480/?image=1075", "https://picsum.photos/640/480/?image=53", "876.389.5954 x33638", "West Effie", "84434-9504" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "6367 Makenzie Plains", "551 Ryan Valley", new DateTime(2023, 2, 20, 6, 0, 17, 764, DateTimeKind.Local).AddTicks(2299), "Shayna.Hauck96@gmail.com", "Belle", "Turner", "https://picsum.photos/640/480/?image=239", "https://picsum.photos/640/480/?image=479", "658.744.2105", "Bartonshire", "89319-2379" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "9242 Macie Stravenue", "14144 Elmo Wall", new DateTime(2022, 12, 30, 11, 51, 2, 124, DateTimeKind.Local).AddTicks(3212), "Shana_Spencer21@hotmail.com", "Emile", "Toy", "https://picsum.photos/640/480/?image=741", "https://picsum.photos/640/480/?image=696", "665-884-6988 x1089", "Port Billieside", "58677-4806" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "4452 Huel Landing", "8785 Schoen Street", new DateTime(2023, 3, 27, 20, 17, 29, 158, DateTimeKind.Local).AddTicks(2225), "Lora82@yahoo.com", "Manuel", "Zulauf", "https://picsum.photos/640/480/?image=477", "https://picsum.photos/640/480/?image=155", "275-801-6598", "Kassandrabury", "06517" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "395 Vandervort Pass", "8524 Dortha Villages", new DateTime(2023, 4, 29, 21, 36, 25, 557, DateTimeKind.Local).AddTicks(1583), "Kailey_Ernser@gmail.com", "Joseph", "Bailey", "https://picsum.photos/640/480/?image=1013", "https://picsum.photos/640/480/?image=482", "324.835.7821 x923", "Lake Claudinemouth", "63932-6763" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "64447 Schmidt Turnpike", "99877 O'Conner Inlet", new DateTime(2023, 5, 2, 1, 38, 7, 208, DateTimeKind.Local).AddTicks(3097), "Dolores27@hotmail.com", "Janessa", "Kuhn", "https://picsum.photos/640/480/?image=316", "https://picsum.photos/640/480/?image=488", "903-699-2464", "Oberbrunnerville", "99552" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "20735 Rosenbaum Spur", "9127 O'Connell Keys", new DateTime(2023, 6, 7, 21, 12, 33, 884, DateTimeKind.Local).AddTicks(648), "Isabel.Conroy76@hotmail.com", "Lila", "Schimmel", "https://picsum.photos/640/480/?image=471", "https://picsum.photos/640/480/?image=981", "1-670-867-3415", "Lake Kelsichester", "54832-5380" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "747 Ryleigh Prairie", "475 Cartwright Ridges", new DateTime(2022, 9, 3, 0, 20, 18, 791, DateTimeKind.Local).AddTicks(3278), "Scotty35@gmail.com", "Odell", "Becker", "https://picsum.photos/640/480/?image=179", "https://picsum.photos/640/480/?image=488", "1-958-557-0325 x81929", "North Earlinestad", "94797" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "50114 Jermain Extensions", "55086 Giovanny Port", new DateTime(2023, 6, 24, 4, 14, 26, 30, DateTimeKind.Local).AddTicks(5542), "Evelyn37@hotmail.com", "Mandy", "Lakin", "https://picsum.photos/640/480/?image=546", "https://picsum.photos/640/480/?image=181", "731.710.3749", "Domenickshire", "39175" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "12924 Gerlach Land", "99701 Lucie Hills", new DateTime(2023, 6, 4, 17, 37, 7, 220, DateTimeKind.Local).AddTicks(248), "Harley83@gmail.com", "Tristian", "Runolfsson", "https://picsum.photos/640/480/?image=741", "https://picsum.photos/640/480/?image=1032", "(917) 694-4513", "Kuphalville", "49953" });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsConducteur",
                value: true);

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 8, 9, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 2, 6, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 4,
                column: "IdReservation",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 4, 9, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 6,
                column: "IdClient",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 5, 3, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 9, 9, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "IdReservation", "IsConducteur" },
                values: new object[] { 1, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 7, 8, 21, 46, 656, DateTimeKind.Local).AddTicks(2780), new DateTime(2023, 8, 8, 9, 30, 16, 398, DateTimeKind.Local).AddTicks(1874), new DateTime(2024, 2, 12, 3, 7, 10, 163, DateTimeKind.Local).AddTicks(8327), 1, 5.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 6, 15, 30, 38, 247, DateTimeKind.Local).AddTicks(8071), new DateTime(2023, 8, 7, 15, 13, 6, 33, DateTimeKind.Local).AddTicks(1776), new DateTime(2023, 8, 30, 15, 39, 1, 597, DateTimeKind.Local).AddTicks(8182), 6, 2.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule" },
                values: new object[] { new DateTime(2023, 8, 7, 4, 3, 37, 935, DateTimeKind.Local).AddTicks(9765), new DateTime(2023, 8, 7, 21, 18, 36, 300, DateTimeKind.Local).AddTicks(6317), new DateTime(2023, 11, 19, 11, 8, 35, 852, DateTimeKind.Local).AddTicks(1562), 8 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 7, 3, 46, 36, 784, DateTimeKind.Local).AddTicks(1127), new DateTime(2023, 8, 7, 20, 30, 6, 854, DateTimeKind.Local).AddTicks(5040), new DateTime(2023, 11, 16, 15, 2, 38, 752, DateTimeKind.Local).AddTicks(4751), 2, 3.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 7, 10, 56, 36, 38, DateTimeKind.Local).AddTicks(7106), new DateTime(2023, 8, 7, 18, 52, 10, 561, DateTimeKind.Local).AddTicks(2869), new DateTime(2023, 8, 7, 17, 52, 3, 506, DateTimeKind.Local).AddTicks(3615), 5, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 7, 11, 14, 46, 912, DateTimeKind.Local).AddTicks(8323), new DateTime(2023, 8, 7, 17, 28, 23, 773, DateTimeKind.Local).AddTicks(6365), new DateTime(2024, 4, 18, 12, 0, 10, 718, DateTimeKind.Local).AddTicks(8791), 1, 1.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 6, 16, 8, 24, 770, DateTimeKind.Local).AddTicks(4781), new DateTime(2023, 8, 7, 21, 59, 32, 540, DateTimeKind.Local).AddTicks(1912), new DateTime(2023, 8, 18, 13, 0, 48, 753, DateTimeKind.Local).AddTicks(1950), 5, 1.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 6, 14, 41, 57, 732, DateTimeKind.Local).AddTicks(9792), new DateTime(2023, 8, 8, 9, 33, 51, 589, DateTimeKind.Local).AddTicks(9665), new DateTime(2024, 4, 14, 9, 27, 35, 43, DateTimeKind.Local).AddTicks(6886), 5, 8.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule" },
                values: new object[] { new DateTime(2023, 8, 6, 17, 0, 0, 69, DateTimeKind.Local).AddTicks(7995), new DateTime(2023, 8, 7, 20, 23, 12, 423, DateTimeKind.Local).AddTicks(3700), new DateTime(2024, 2, 7, 12, 17, 37, 169, DateTimeKind.Local).AddTicks(5243), 10 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 8, 23, 997, DateTimeKind.Local).AddTicks(7133), new DateTime(2023, 8, 7, 22, 25, 53, 265, DateTimeKind.Local).AddTicks(2590), new DateTime(2023, 11, 7, 3, 14, 53, 35, DateTimeKind.Local).AddTicks(2392), 5, 1.0, true });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 6, 17, 13, 27, 200, DateTimeKind.Local).AddTicks(1990), new DateTime(2023, 8, 8, 2, 53, 43, 751, DateTimeKind.Local).AddTicks(4791), new DateTime(2024, 7, 30, 16, 53, 0, 621, DateTimeKind.Local).AddTicks(9014), 2, "23629552-e648-4967-8f5d-e639ae580279", "Confirmé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 7, 11, 23, 42, 145, DateTimeKind.Local).AddTicks(3901), new DateTime(2023, 8, 7, 15, 54, 38, 165, DateTimeKind.Local).AddTicks(6131), new DateTime(2024, 1, 16, 4, 36, 18, 339, DateTimeKind.Local).AddTicks(7472), 5, "d670edda-b45e-4bfe-aac1-9ab9e51bf309", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 7, 11, 34, 1, 996, DateTimeKind.Local).AddTicks(976), new DateTime(2023, 8, 8, 6, 45, 56, 77, DateTimeKind.Local).AddTicks(8002), new DateTime(2023, 11, 6, 23, 10, 34, 421, DateTimeKind.Local).AddTicks(4304), "59136721-945c-43b5-9f9f-c8fad42a7735", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 6, 15, 47, 10, 70, DateTimeKind.Local).AddTicks(405), new DateTime(2023, 8, 8, 8, 12, 25, 349, DateTimeKind.Local).AddTicks(9215), new DateTime(2023, 12, 30, 5, 52, 59, 850, DateTimeKind.Local).AddTicks(9580), 4, "385e066f-d7b6-4a97-909e-82dbd80cc0f0" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 12, 29, 512, DateTimeKind.Local).AddTicks(4297), new DateTime(2023, 8, 8, 9, 27, 24, 369, DateTimeKind.Local).AddTicks(7027), new DateTime(2023, 11, 17, 5, 29, 39, 962, DateTimeKind.Local).AddTicks(7550), 9, "74b3aff0-cb09-41b7-877e-d1b32cf18bc1", "Confirmé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 53, 48, 79, DateTimeKind.Local).AddTicks(3331), new DateTime(2023, 8, 8, 1, 8, 27, 855, DateTimeKind.Local).AddTicks(7916), new DateTime(2023, 9, 17, 11, 8, 5, 221, DateTimeKind.Local).AddTicks(725), 6, "f579dc7f-b0b3-42fa-b45e-5b17f441c9d3", "Confirmé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 7, 3, 46, 4, 542, DateTimeKind.Local).AddTicks(9667), new DateTime(2023, 8, 7, 14, 22, 4, 596, DateTimeKind.Local).AddTicks(515), new DateTime(2024, 1, 17, 2, 32, 17, 78, DateTimeKind.Local).AddTicks(9069), 8, "d8ea83fc-dc4a-4019-8914-0d9f9170fb9f", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 6, 21, 57, 32, 316, DateTimeKind.Local).AddTicks(8073), new DateTime(2023, 8, 7, 19, 8, 43, 339, DateTimeKind.Local).AddTicks(5145), new DateTime(2024, 6, 8, 4, 55, 24, 529, DateTimeKind.Local).AddTicks(2656), 5, "d0cb8478-5126-4573-83c2-c3504ff5ae43", "Confirmé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 7, 7, 0, 32, 438, DateTimeKind.Local).AddTicks(9203), new DateTime(2023, 8, 8, 1, 39, 58, 933, DateTimeKind.Local).AddTicks(5474), new DateTime(2024, 4, 16, 21, 33, 27, 596, DateTimeKind.Local).AddTicks(3878), 8, "480d8010-4f69-4d80-8b89-074badb7d56f", "Expiré" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 7, 10, 51, 8, 753, DateTimeKind.Local).AddTicks(9697), new DateTime(2023, 8, 8, 11, 21, 38, 50, DateTimeKind.Local).AddTicks(3255), new DateTime(2023, 9, 3, 11, 16, 14, 195, DateTimeKind.Local).AddTicks(5165), 6, "a753a511-d64c-4106-b2dc-1aac71e75ca9", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 17, 11, 8, 8, 460, DateTimeKind.Local).AddTicks(4367), "Kaci.Schuster@yahoo.com", "Allene", 9, false, "Cole", "$2a$11$tdFcgI5S3Ytj/fTdqMxit.57y3rKjRGlM9JfCY5OSoHAugRqt.5zS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 4, 27, 13, 28, 32, 376, DateTimeKind.Local).AddTicks(8454), "Darwin.Bechtelar@gmail.com", "Cole", 2, 1, false, "Waelchi", "$2a$11$Bme32nXk4tRrKZ5aQOpn3uBRNxyNaYuB5N8DjAarHtTNenuhZfx4a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 30, 23, 23, 34, 621, DateTimeKind.Local).AddTicks(8456), "Delphia57@gmail.com", "Silas", 10, false, "Runolfsson", "$2a$11$FCaexurRE8eNHxWcg0vm7ezOdK2lXptuyVtkQ3Aco4y7tlwdprLtC" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 2, 21, 15, 4, 7, 358, DateTimeKind.Local).AddTicks(7620), "Britney.Kling99@gmail.com", "Russell", 5, "O'Reilly", "$2a$11$dhK2bIkNjGpNUDiTPwMFeeETnMfl2Y6QYSmi1OkKlvkfrcV3fMT1W" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 12, 14, 44, 43, 749, DateTimeKind.Local).AddTicks(8374), "Elsie4@yahoo.com", "Keshawn", 5, "Howe", "$2a$11$tLrOqkjgJcDJxh8/VFKbsezXgtKjd0.yYR94VD2Cf12nkdj.MGE/e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 6, 43, 791, DateTimeKind.Local).AddTicks(9627), "Keven45@gmail.com", "Nina", 6, false, "Stark", "$2a$11$1uhTp9laDPH3KN9S7gSksOVcx7jYcwV0erU37S4oauaF3H2jMf7g." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 11, 26, 20, 39, 4, 14, DateTimeKind.Local).AddTicks(9693), "Guiseppe16@hotmail.com", "Cydney", 2, false, "Koss", "$2a$11$dYm9m.167icopcJE6ljOwu.INA4WRUih90Jk8.V//grg1nWE4XyMS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 10, 12, 1, 3, 51, 62, DateTimeKind.Local).AddTicks(3048), "Green38@hotmail.com", "Elza", 1, "Renner", "$2a$11$Bv8.VATjLe.uJ0w1bMi0pu2EW0CnOY92zPqYVewpin6BJf7ctiELO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 19, 5, 53, 51, 449, DateTimeKind.Local).AddTicks(1433), "Marquise_Pacocha@yahoo.com", "Dayne", 9, 2, "Roob", "$2a$11$IG70jlC/jpN0k/Si1Vf/U.GWpM3PTlwbM0ikw8FZmXrU1mHmQWF8e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 2, 17, 17, 39, 57, 92, DateTimeKind.Local).AddTicks(4911), "Donnie.Trantow@hotmail.com", "Kelley", 2, "Gislason", "$2a$11$UC4T.CFTzVVb15CNoH1LSeZP82p3pdp9oHVaIPxSAnXoZjgAYxSYu" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "Type" },
                values: new object[] { new DateTime(2023, 3, 13, 6, 15, 51, 36, DateTimeKind.Local).AddTicks(8505), "wzcczhqrjk", 8, 259, 8654, "uszsltasid", "crqoskxeau", "hceipafion", 8, "vhcgldrawu" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2023, 1, 10, 14, 24, 7, 872, DateTimeKind.Local).AddTicks(2377), "gjobsxbksr", 10, 194, 6522, "bengztfahy", "wpqzsdjtce", "ztxuuhzjbu", 7, 4, 4.0, "fsqgcqnuio" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2022, 8, 8, 7, 16, 38, 90, DateTimeKind.Local).AddTicks(333), "jfpkvylfzc", 6, 156, 5427, "kxdaeuqpxq", "pzqodhzriy", "cppjablvgn", 7, 8, 5.0, "chtdzxpcxf" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2023, 3, 18, 18, 28, 9, 805, DateTimeKind.Local).AddTicks(3289), "qbxvijqyrv", 1, 62, 8697, "zcijryybsk", "izvaxtmvha", "cefncrfxnn", 2, 9, 9.0, "vwpjtgmqyw" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2023, 5, 3, 1, 35, 35, 695, DateTimeKind.Local).AddTicks(5050), "firjzeckti", 9, 300, 3771, "ycdxdjdkik", "fnrhqnmize", "yavfecdgvr", 3, 1, 3.0, "niucxtixkz" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2022, 12, 17, 4, 13, 56, 131, DateTimeKind.Local).AddTicks(1238), "zoxnzyuzia", 9, 42, 2028, "ktxmvvfyhp", "bspjjyeuov", "bceqkxkxvb", 8, 1, 4.0, "judtbvibqv" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "Km", "Matricule", "Moteur", "Name", "NbPassager", "Prix", "Type" },
                values: new object[] { false, true, new DateTime(2023, 2, 16, 16, 21, 2, 363, DateTimeKind.Local).AddTicks(5722), "eqkbhwpnwj", 4, 4462, "hygspsonpv", "eokkwyktus", "cirrcdilwr", 6, 1.0, "keuicpwpac" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "Prix", "Type" },
                values: new object[] { new DateTime(2023, 1, 15, 0, 18, 43, 832, DateTimeKind.Local).AddTicks(3583), "hhkrmfgidd", 10, 100, 8909, "xxbnysfctg", "lzuinyzzbj", "yqqdbjuqzz", 3.0, "nikqnrguqj" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2023, 6, 1, 8, 14, 39, 110, DateTimeKind.Local).AddTicks(5918), "dayyxlydnf", 39, 8121, "lspffzykoj", "lizuvdpihu", "rvjupokluo", 8, 6, 8.0, "vaidmhcwxl" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 31, 10, 250, DateTimeKind.Local).AddTicks(8743), "tjcndwetfo", 8, 222, 1256, "zrbpyqgimm", "sodxbtbqhp", "mdvmvrofnl", 5, 10.0, "utywtihbhe" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 1, 31, 3, 30, 18, 681, DateTimeKind.Local).AddTicks(3216), 251, "mgmqbvvpne", "Cremin", 29, "Rippin LLC", "Talia", "(942) 782-6891", "Von", "Kiaramouth", "28242" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 11, 6, 0, 20, 27, 12, DateTimeKind.Local).AddTicks(5367), 288, "pqfdsjxysy", "Jones", 24, "Wiza - Stamm", "Cydney", "329-830-6126", "D'Amore", "North Carolinafort", "95190" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 6, 19, 5, 19, 9, 111, DateTimeKind.Local).AddTicks(9668), 161, "cyiwcqbusy", "Stracke", 32, "Roob Group", "Jenifer", "(456) 881-1068", "Kilback", "Rudolphfort", "58750" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 12, 18, 14, 27, 29, 155, DateTimeKind.Local).AddTicks(7612), 90, "evijotwkrn", "O'Reilly", 18, "Hartmann, Buckridge and Walker", "Monique", "917-422-6036", "Hudson", "West Shanaview", "41647-7643" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 10, 8, 3, 26, 11, 732, DateTimeKind.Local).AddTicks(1151), 126, "qgzhmouudc", "Reichel", 24, "Deckow - Kutch", "Coleman", "1-965-723-4592 x533", "Terry", "Walterhaven", "81922-6679" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 3, 22, 3, 36, 40, 876, DateTimeKind.Local).AddTicks(6282), 43, "guawebtjgn", "Mitchell", "Larson LLC", "Paige", "924-478-7202", "Jerde", "Batzborough", "56342-0349" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 6, 17, 4, 55, 44, 614, DateTimeKind.Local).AddTicks(1630), 162, "ipcyyxnqfo", "Waters", 28, "D'Amore - Hintz", "Shaniya", "553-789-9257", "Heaney", "Wardberg", "36848-0603" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 5, 8, 1, 3, 31, 719, DateTimeKind.Local).AddTicks(5493), 220, "ltkbgqxzhj", "Roberts", 26, "Hamill LLC", "Hailee", "494.440.0733 x89824", "Bechtelar", "Petrahaven", "95389" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 11, 6, 11, 3, 31, 916, DateTimeKind.Local).AddTicks(8287), 36, "eidgwjyqez", "Hills", 25, "Lynch - Streich", "Nick", "245-233-0832", "Senger", "Lake Jakobfurt", "45162-7077" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 5, 6, 18, 13, 37, 401, DateTimeKind.Local).AddTicks(7318), 206, "ctudvgbcpb", "Hahn", 23, "Bashirian, Schaden and Langworth", "Hans", "1-711-669-1980", "Marks", "East Serenity", "81693" });
        }
    }
}
