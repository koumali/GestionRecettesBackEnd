using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomotiveApi.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "41235 Alphonso Lakes", "West Rafael", new DateTime(2023, 8, 16, 20, 50, 56, 288, DateTimeKind.Local).AddTicks(8833), "Hassie50@hotmail.com", 5.3593999999999999, 142.09739999999999, "Direct Accounts Engineer", "669-937-5232 x6052", "31127" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "9349 Meta Lodge", "Alport", new DateTime(2023, 5, 17, 13, 49, 17, 733, DateTimeKind.Local).AddTicks(7200), "Vada_Homenick36@yahoo.com", -5.2637999999999998, 150.66419999999999, "Senior Mobility Orchestrator", "994.347.5398 x551", "24700-1613" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "893 Stoltenberg Trace", "Lake Arvillafurt", new DateTime(2023, 8, 10, 14, 9, 18, 281, DateTimeKind.Local).AddTicks(9786), "Linnea.West25@hotmail.com", -39.380299999999998, 169.1636, "Dynamic Directives Specialist", "334-668-0563", "98575-6872" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "0887 Oleta Highway", "South Pattie", new DateTime(2023, 2, 5, 13, 57, 23, 104, DateTimeKind.Local).AddTicks(5911), "Terrell28@hotmail.com", -87.432100000000005, 139.7483, "Dynamic Solutions Analyst", "264.388.3379 x55319", "99644-7251" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "69525 Addie Port", "Georgetteview", new DateTime(2023, 4, 12, 1, 38, 49, 822, DateTimeKind.Local).AddTicks(9054), "Kacie.Medhurst84@yahoo.com", -88.005099999999999, -107.16160000000001, "District Configuration Producer", "1-870-417-6642", "94611" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "85764 Heidenreich Brooks", "Stehrfort", new DateTime(2023, 3, 23, 20, 9, 34, 91, DateTimeKind.Local).AddTicks(4146), "Elvie94@gmail.com", 5.2134, 151.96350000000001, "Customer Directives Facilitator", "431.383.9406", "29907-6616" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "946 Chelsie Court", "Odessastad", new DateTime(2023, 2, 2, 14, 16, 36, 561, DateTimeKind.Local).AddTicks(6339), "Thomas1@hotmail.com", -0.59289999999999998, 163.2946, "Senior Mobility Analyst", "(254) 736-7412", "19725" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "625 Gleichner Plaza", "Lake Kellie", new DateTime(2022, 10, 25, 3, 20, 52, 712, DateTimeKind.Local).AddTicks(9210), "Shayna_Feest84@hotmail.com", 46.172499999999999, 166.4873, "Direct Group Producer", "1-360-821-2556", "84112" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "672 Cydney Summit", "Runolfsdottirport", new DateTime(2023, 7, 9, 7, 17, 13, 22, DateTimeKind.Local).AddTicks(1099), "Angie_Torp@yahoo.com", -47.644199999999998, 57.603999999999999, "Internal Factors Agent", "404-521-8884 x575", "81300" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "6490 O'Keefe Route", "Lake Almouth", new DateTime(2023, 1, 29, 3, 17, 36, 320, DateTimeKind.Local).AddTicks(1165), "Murray10@hotmail.com", 84.470699999999994, -33.022399999999998, "Chief Paradigm Director", "(696) 974-0225", "47982" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "567 Langosh Passage", "68437 Wiegand Squares", new DateTime(2023, 2, 9, 9, 53, 33, 530, DateTimeKind.Local).AddTicks(6431), "Naomie.Lang23@gmail.com", "Riley", "Runolfsson", "https://picsum.photos/640/480/?image=948", "https://picsum.photos/640/480/?image=264", "865.385.8967 x1270", "North Marcos", "35583-7267" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "895 Hansen Keys", "4823 Botsford Track", new DateTime(2023, 3, 22, 5, 33, 41, 512, DateTimeKind.Local).AddTicks(1800), "Arnoldo_Stamm@gmail.com", "Louisa", "Auer", "https://picsum.photos/640/480/?image=562", "https://picsum.photos/640/480/?image=829", "832.216.5712 x65888", "West Muhammad", "68367" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "74272 Virgie Meadow", "23001 O'Connell Valley", new DateTime(2022, 9, 2, 14, 41, 12, 282, DateTimeKind.Local).AddTicks(2816), "Arnold_Parisian72@gmail.com", "Derrick", "Schamberger", "https://picsum.photos/640/480/?image=836", "https://picsum.photos/640/480/?image=115", "(274) 824-8809", "Michaelaside", "36545" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "31706 Isabel Trail", "05712 Garnett Drive", new DateTime(2023, 8, 20, 4, 18, 30, 910, DateTimeKind.Local).AddTicks(103), "Howard_Hamill30@gmail.com", "Eldred", "Schmitt", "https://picsum.photos/640/480/?image=417", "https://picsum.photos/640/480/?image=516", "832-990-4873", "Bergetown", "21244-3334" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "7867 Carmella Plains", "8370 McClure Mission", new DateTime(2023, 3, 3, 15, 53, 44, 307, DateTimeKind.Local).AddTicks(7008), "Giovanny_Windler89@gmail.com", "Elmira", "Hauck", "https://picsum.photos/640/480/?image=606", "https://picsum.photos/640/480/?image=406", "998.249.4690 x513", "Raquelview", "42203" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "707 Orpha Island", "7212 Sigmund Parks", new DateTime(2023, 1, 18, 9, 59, 0, 701, DateTimeKind.Local).AddTicks(1597), "Daphney.Ernser@hotmail.com", "Elmore", "Carroll", "https://picsum.photos/640/480/?image=977", "https://picsum.photos/640/480/?image=164", "(836) 472-3439", "North Alphonsoview", "65412" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "866 Pearl Burgs", "2181 Thompson View", new DateTime(2022, 12, 5, 23, 27, 33, 870, DateTimeKind.Local).AddTicks(6794), "Loma.Runolfsdottir13@gmail.com", "Anne", "Koepp", "https://picsum.photos/640/480/?image=122", "https://picsum.photos/640/480/?image=538", "1-723-828-2979", "Ludieburgh", "08586" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "6398 Nathen Locks", "395 Lyda Mission", new DateTime(2023, 8, 20, 23, 32, 24, 346, DateTimeKind.Local).AddTicks(9006), "Ansley5@gmail.com", "Zoey", "Ferry", "https://picsum.photos/640/480/?image=8", "https://picsum.photos/640/480/?image=929", "1-742-594-0890 x62756", "Strackemouth", "88605" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "457 Donnie Light", "7996 Willms Grove", new DateTime(2023, 7, 15, 23, 8, 38, 780, DateTimeKind.Local).AddTicks(8589), "Madge_Lynch31@hotmail.com", "Roslyn", "Bode", "https://picsum.photos/640/480/?image=530", "https://picsum.photos/640/480/?image=1027", "777-827-4577 x17171", "Jenkinsland", "86469" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "0029 Haley Key", "02858 Frami Skyway", new DateTime(2023, 3, 17, 2, 9, 17, 68, DateTimeKind.Local).AddTicks(205), "Florine.Gutkowski79@yahoo.com", "Melvina", "Glover", "https://picsum.photos/640/480/?image=322", "https://picsum.photos/640/480/?image=614", "583-233-7104 x4419", "West Colten", "43048" });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 8, 2, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 7, 10 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 4,
                column: "IdClient",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 6, 4 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 1, 8 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 7, 6 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 8,
                column: "IdReservation",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 7, 10 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 6, 1, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 22, 6, 4, 58, 362, DateTimeKind.Local).AddTicks(6407), new DateTime(2023, 8, 23, 7, 8, 47, 296, DateTimeKind.Local).AddTicks(2924), new DateTime(2024, 1, 5, 9, 57, 6, 134, DateTimeKind.Local).AddTicks(2200), 4, 9.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 21, 19, 54, 28, 701, DateTimeKind.Local).AddTicks(9396), new DateTime(2023, 8, 23, 7, 58, 20, 365, DateTimeKind.Local).AddTicks(5600), new DateTime(2023, 9, 25, 8, 5, 16, 313, DateTimeKind.Local).AddTicks(9765), 10, 5.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 22, 7, 34, 22, 489, DateTimeKind.Local).AddTicks(3603), new DateTime(2023, 8, 23, 7, 30, 48, 141, DateTimeKind.Local).AddTicks(2967), new DateTime(2024, 7, 5, 14, 9, 53, 616, DateTimeKind.Local).AddTicks(2513), 4, 3.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 21, 16, 21, 51, 495, DateTimeKind.Local).AddTicks(8882), new DateTime(2023, 8, 22, 22, 24, 13, 334, DateTimeKind.Local).AddTicks(7196), new DateTime(2023, 10, 20, 3, 22, 20, 381, DateTimeKind.Local).AddTicks(9585), 6, 5.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 21, 11, 3, 18, 80, DateTimeKind.Local).AddTicks(655), new DateTime(2023, 8, 22, 22, 44, 18, 385, DateTimeKind.Local).AddTicks(2132), new DateTime(2024, 7, 1, 3, 6, 53, 1, DateTimeKind.Local).AddTicks(5855), 3, 6.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 22, 3, 36, 32, 246, DateTimeKind.Local).AddTicks(3518), new DateTime(2023, 8, 23, 2, 38, 44, 562, DateTimeKind.Local).AddTicks(7411), new DateTime(2024, 7, 6, 10, 18, 57, 514, DateTimeKind.Local).AddTicks(8065), 7, 7.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 21, 16, 19, 44, 904, DateTimeKind.Local).AddTicks(6189), new DateTime(2023, 8, 22, 12, 21, 51, 16, DateTimeKind.Local).AddTicks(8779), new DateTime(2023, 9, 7, 7, 20, 17, 702, DateTimeKind.Local).AddTicks(2459), 6.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 21, 10, 24, 46, 711, DateTimeKind.Local).AddTicks(4334), new DateTime(2023, 8, 23, 1, 18, 21, 824, DateTimeKind.Local).AddTicks(1391), new DateTime(2023, 11, 2, 0, 37, 38, 906, DateTimeKind.Local).AddTicks(2060), 2, 1.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 21, 17, 24, 56, 438, DateTimeKind.Local).AddTicks(7555), new DateTime(2023, 8, 23, 7, 7, 28, 70, DateTimeKind.Local).AddTicks(95), new DateTime(2023, 12, 2, 9, 33, 26, 419, DateTimeKind.Local).AddTicks(3880), 1, 6.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 22, 7, 3, 21, 365, DateTimeKind.Local).AddTicks(7041), new DateTime(2023, 8, 23, 8, 36, 43, 394, DateTimeKind.Local).AddTicks(1982), new DateTime(2023, 9, 20, 20, 51, 39, 778, DateTimeKind.Local).AddTicks(2320), 5, 3.0 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 21, 15, 33, 23, 660, DateTimeKind.Local).AddTicks(9040), new DateTime(2023, 8, 23, 6, 14, 54, 312, DateTimeKind.Local).AddTicks(4876), new DateTime(2024, 1, 10, 10, 46, 15, 374, DateTimeKind.Local).AddTicks(6807), 4, "c14eaa4a-a999-4ca8-a283-019309dea4ea", "Annulé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 4, 12, 57, 784, DateTimeKind.Local).AddTicks(8944), new DateTime(2023, 8, 23, 1, 16, 53, 633, DateTimeKind.Local).AddTicks(2385), new DateTime(2024, 1, 29, 16, 57, 44, 327, DateTimeKind.Local).AddTicks(3806), 10, "55660b74-1618-40b8-af66-79125e215ddb", "Annulé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 0, 33, 59, 350, DateTimeKind.Local).AddTicks(5945), new DateTime(2023, 8, 22, 18, 1, 27, 351, DateTimeKind.Local).AddTicks(8510), new DateTime(2024, 1, 18, 10, 4, 26, 496, DateTimeKind.Local).AddTicks(6931), 8, "cd58ebd8-ede7-4a97-b649-9cbdeaf1846d", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 21, 18, 46, 34, 627, DateTimeKind.Local).AddTicks(2432), new DateTime(2023, 8, 22, 16, 34, 44, 817, DateTimeKind.Local).AddTicks(5161), new DateTime(2024, 1, 9, 6, 56, 48, 785, DateTimeKind.Local).AddTicks(4519), 6, "ee625f41-c57e-426e-a205-4040e439dad0", "Expiré" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 6, 54, 55, 180, DateTimeKind.Local).AddTicks(7670), new DateTime(2023, 8, 23, 5, 46, 12, 962, DateTimeKind.Local).AddTicks(7874), new DateTime(2023, 8, 24, 14, 56, 23, 49, DateTimeKind.Local).AddTicks(1319), 1, "3aac686e-960e-4306-85bf-bbf032ac463c", "Expiré" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 2, 39, 22, 378, DateTimeKind.Local).AddTicks(3926), new DateTime(2023, 8, 22, 12, 12, 13, 431, DateTimeKind.Local).AddTicks(2958), new DateTime(2024, 7, 9, 20, 53, 29, 72, DateTimeKind.Local).AddTicks(6160), "ad2aa4a9-8123-46d9-85bf-dbb2a57fe62c", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 6, 20, 31, 952, DateTimeKind.Local).AddTicks(9753), new DateTime(2023, 8, 22, 21, 56, 58, 497, DateTimeKind.Local).AddTicks(2854), new DateTime(2023, 11, 7, 2, 6, 46, 874, DateTimeKind.Local).AddTicks(2418), 4, "a6ed3cfe-de40-40c9-8649-0c8864e2bb38", "Expiré" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 21, 16, 36, 47, 266, DateTimeKind.Local).AddTicks(9182), new DateTime(2023, 8, 22, 23, 20, 49, 358, DateTimeKind.Local).AddTicks(1615), new DateTime(2024, 3, 17, 11, 57, 57, 76, DateTimeKind.Local).AddTicks(8775), 9, "e4176e3b-16fa-498a-b930-7fef47f26699", "Annulé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 21, 18, 18, 58, 534, DateTimeKind.Local).AddTicks(8055), new DateTime(2023, 8, 22, 10, 8, 35, 148, DateTimeKind.Local).AddTicks(1609), new DateTime(2024, 4, 9, 0, 28, 15, 451, DateTimeKind.Local).AddTicks(3471), 7, "5dfe58c8-04dc-454d-9509-85fe6c02e36e", "Expiré" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 21, 19, 30, 24, 493, DateTimeKind.Local).AddTicks(1745), new DateTime(2023, 8, 22, 12, 46, 40, 877, DateTimeKind.Local).AddTicks(3528), new DateTime(2023, 10, 29, 17, 18, 30, 838, DateTimeKind.Local).AddTicks(1515), 8, "4e9be13c-7bb9-4383-8a06-8f61361f2225" });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 1, 1 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 2, 1 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 3, 1 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 4, 1 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 5, 1 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 6, 1 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 7, 1 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 13, 1 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 2, 2 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 3, 2 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 4, 2 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 6, 2 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 7, 2 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 8, 2 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 9, 2 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 10, 2 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 11, 2 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 12, 2 },
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 4, 20, 12, 35, 40, 240, DateTimeKind.Local).AddTicks(1729), "Hollis78@gmail.com", "Reggie", 4, 2, "Ritchie", "$2a$11$Z0mvc1zJZV.gTLyewcNfuODwFrovOotNO.NtG0LI9ydC91cwG.9Qa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 7, 8, 56, 46, 122, DateTimeKind.Local).AddTicks(9138), "Nikki82@gmail.com", "Bailee", 3, 2, true, "Stark", "$2a$11$zwGCh1HVZGLRotM9UH1EQupO7kK7oAOK4o20WlClYiPZYQArCVX7i" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 16, 13, 38, 42, 757, DateTimeKind.Local).AddTicks(6107), "Gabe.Morar44@hotmail.com", "Mauricio", 1, 1, "Bartoletti", "$2a$11$a9LVTDjXwniBSoPSUWu8qOiYxdspvCuXbtqlQz11ZfwBXfKnUqtCi" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 17, 10, 52, 6, 9, DateTimeKind.Local).AddTicks(5710), "Joaquin_Hayes@hotmail.com", "Justine", true, "Larkin", "$2a$11$JsuD7MsVMIhA7BMQC3U/WuXulrXP18DLKCfT/bEnZiegkvqrYSDY6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 31, 13, 29, 22, 23, DateTimeKind.Local).AddTicks(6665), "Laurianne_Boyle26@hotmail.com", "Hulda", 2, true, "Ledner", "$2a$11$yEBJ6rkxqMk7IB8mB7mh5u0Cusi8/9s3i397vquIGSYCDg/Mn.B02" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 7, 18, 51, 29, 918, DateTimeKind.Local).AddTicks(1423), "Elza_Kuvalis42@gmail.com", "Sim", 3, "Flatley", "$2a$11$9pjVD6uX8gd4y27BjJn4/.um1nMh33ZUG1GD8kgXlzu47.3jjtH3G" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 8, 27, 11, 55, 52, 77, DateTimeKind.Local).AddTicks(5385), "Mafalda15@yahoo.com", "Arlene", 2, "Gusikowski", "$2a$11$thO7NqYRD.xG0poCOXVZr.qm/XoMRPd/Acd7Q9.9XDh/8Dm4pYqrG" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 9, 21, 30, 42, 532, DateTimeKind.Local).AddTicks(9291), "Desmond_Pfannerstill@gmail.com", "Adella", 7, true, "Hyatt", "$2a$11$JaBsY0nevgwOmxDEUt6yTervNMZwH59TrRuyZsOITzRE27EJ8Gbou" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 31, 19, 23, 36, 755, DateTimeKind.Local).AddTicks(633), "Quentin_Upton62@gmail.com", "Ezra", 7, false, "Hyatt", "$2a$11$bi2n9l2UO3beKh/joTyy..YvK1NIAb49TaZBQl8TrELs1cBCtJOSS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 4, 9, 54, 58, 84, DateTimeKind.Local).AddTicks(5497), "Dianna17@yahoo.com", "Eve", 5, 1, "Zboncak", "$2a$11$er1hs1NornRu77CnLjGQnehxTzC3qfunl86klhNr/uIniu/14FA1y" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPort", "Type" },
                values: new object[] { true, false, new DateTime(2023, 2, 7, 21, 21, 40, 696, DateTimeKind.Local).AddTicks(9438), "ygmgvkolfw", 8, 121, 3928, "jsbmeuuhnp", "yhsvzmdlbp", "izohuwhaoi", 10, "egpmzpriub" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2023, 4, 21, 3, 3, 0, 967, DateTimeKind.Local).AddTicks(4415), "ilpswczisr", 6, 15, 6161, "vixqiqrwsm", "rsvsmiwywn", "hvmbsedgrw", 9, 6, 3.0, "ldmwogtjbf" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, false, new DateTime(2023, 1, 30, 16, 28, 3, 936, DateTimeKind.Local).AddTicks(2256), "amtkyngblw", 10, 101, 8266, "jevxjibtdv", "qevldevdzc", "ixilscoonu", 5, 1, 3.0, "hkacddarxi" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, false, new DateTime(2023, 3, 1, 4, 9, 51, 336, DateTimeKind.Local).AddTicks(1337), "nkphpzkibo", 307, 9190, "guxcdyvuhy", "wgyjpxwkfg", "gtjjfgioki", 9, 4, 4.0, "pivhuvlmwj" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "Prix", "Type" },
                values: new object[] { false, new DateTime(2023, 3, 8, 20, 48, 50, 928, DateTimeKind.Local).AddTicks(9647), "mnwomkcvws", 10, 4, 2708, "etfgnkkwdq", "ekstcpmzot", "arqnvrvimm", 4.0, "rptzqwvgtx" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2022, 10, 25, 19, 47, 11, 48, DateTimeKind.Local).AddTicks(7069), "rwrztdysfz", 3, 43, 8204, "ifurfkepex", "xhdlwlrnnc", "diabsjfctt", 3, 9, 6.0, "ozizdxoiqy" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "Type" },
                values: new object[] { true, new DateTime(2023, 6, 3, 7, 44, 30, 389, DateTimeKind.Local).AddTicks(6988), "nalvgeteaj", 10, 52, 5946, "wurwznrfnb", "vabpgrhurt", "vstobasglm", 10, "nnqirvdgfh" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2023, 4, 29, 14, 8, 59, 952, DateTimeKind.Local).AddTicks(5237), "hefsbqvxqc", 6, 77, 4207, "jofqrvsdix", "jyiichpmnd", "vdpfacfvak", 2, 2, 3.0, "lreojrwhox" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2023, 2, 28, 8, 22, 44, 624, DateTimeKind.Local).AddTicks(1258), "acqoeqpklr", 3, 60, 7060, "asvlksnrcs", "jksvqvzayl", "rnhzgsgzxk", 6, 3, 4.0, "wfiwhereky" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2023, 1, 13, 7, 24, 19, 48, DateTimeKind.Local).AddTicks(2585), "pmmirbyucx", 260, 6866, "ttlvivoexg", "fvxdlbvine", "tjniajzyey", 8, 10, 10.0, "cycveoaogm" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 4, 24, 20, 21, 52, 2, DateTimeKind.Local).AddTicks(6105), "yvuzhygvye", 133, "fdaaqyetse", "nrvgtwxmpu", "Marks", 31, "Howe Group", "Laurel", "(331) 613-0231 x4351", "Feeney", "New Mckenna", "09735-6140" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 10, 12, 6, 1, 58, 870, DateTimeKind.Local).AddTicks(1620), "qqtfteusqa", 119, "mvovjljjma", "nxgguyfuik", "Kuphal", 24, "Bernhard, Fisher and Murphy", "Marta", "495-545-3290 x7431", "Klocko", "Port Seamuston", "59737-6477" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 7, 31, 20, 56, 28, 496, DateTimeKind.Local).AddTicks(4379), "fbzknxxsdb", 229, "xnisbxxzyl", "dzbhoewbrn", "Effertz", 26, "Lind Inc", "May", "837.879.9767 x612", "Miller", "Ismaelburgh", "36758" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 6, 10, 22, 50, 34, 466, DateTimeKind.Local).AddTicks(1785), "elvljdroil", 139, "wurzjuraco", "xazkuzxpeh", "Gleichner", 22, "Kovacek and Sons", "Montana", "(536) 565-4195 x18694", "Rutherford", "North Dangelostad", "87811-0597" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 3, 20, 19, 30, 8, 268, DateTimeKind.Local).AddTicks(5176), "ryentjliey", 301, "vecinhnuhw", "alnjyouzjj", "Bauch", 29, "Dicki, Schimmel and Rice", "Greta", "767-913-0361 x20951", "Greenholt", "Schusterhaven", "93322" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 10, 23, 14, 40, 5, 340, DateTimeKind.Local).AddTicks(819), "vgvddhyryf", 213, "qnrjyebxet", "lbujelcwmg", "West", 18, "Goyette Inc", "Jayson", "387.389.6154", "Weissnat", "Monroeshire", "08064-3535" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 5, 16, 15, 52, 10, 842, DateTimeKind.Local).AddTicks(2235), "ihorzsnlpn", 165, "izvyddekpn", "cpxhcrwspg", "Hudson", 25, "Marvin - Harber", "Brycen", "353-727-8676 x814", "Prosacco", "Viviennechester", "78098-8320" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 6, 15, 19, 2, 52, 475, DateTimeKind.Local).AddTicks(5611), "sicnvogkvz", 223, "tqxgncongu", "tmtseeyvup", "Shields", 24, "Krajcik - O'Hara", "Erica", "793-200-4497 x413", "Greenfelder", "Annettaview", "02407-8919" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 8, 9, 16, 39, 30, 53, DateTimeKind.Local).AddTicks(872), "khgxbbqyed", 179, "pjezjbelih", "wwxsnpqwtl", "Sawayn", 30, "Renner - Kuhlman", "Judson", "1-700-819-1000", "Maggio", "Vernerhaven", "25447-6542" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 9, 25, 15, 53, 49, 223, DateTimeKind.Local).AddTicks(1957), "oketdfohlf", 310, "xmaiphevbf", "nxtclhdgjn", "Abernathy", 27, "Durgan, Kunze and Ebert", "Isac", "(534) 644-2752 x801", "Medhurst", "North Edytheside", "93319-0853" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "32747 Hahn Cliffs", "Cathyborough", new DateTime(2023, 7, 9, 18, 46, 28, 917, DateTimeKind.Local).AddTicks(5453), "Delbert_OKon@gmail.com", 58.366, 25.145299999999999, "Regional Web Consultant", "552-925-3027 x52045", "17924-6491" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "4415 Little Streets", "North Maxie", new DateTime(2023, 4, 21, 7, 43, 48, 694, DateTimeKind.Local).AddTicks(9762), "Lemuel.Gottlieb73@hotmail.com", -10.8071, 129.1207, "Human Communications Liaison", "739.276.5089 x6128", "27911-5807" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "60879 Lorenzo Street", "Marciachester", new DateTime(2022, 12, 20, 23, 48, 18, 256, DateTimeKind.Local).AddTicks(9226), "Emerald91@yahoo.com", 33.049300000000002, 134.9847, "Internal Program Assistant", "(273) 375-2349", "55133" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "0218 Ebert Plains", "New Stefanie", new DateTime(2023, 5, 23, 16, 7, 44, 986, DateTimeKind.Local).AddTicks(351), "Melba.Lebsack@hotmail.com", 31.633400000000002, 157.82560000000001, "Senior Factors Facilitator", "440-456-8711", "06930-0256" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "316 Solon Field", "Starkfort", new DateTime(2023, 6, 6, 16, 46, 44, 164, DateTimeKind.Local).AddTicks(9194), "Tavares19@yahoo.com", -60.456000000000003, 49.950099999999999, "National Optimization Producer", "(281) 726-3351", "62696" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "760 Paucek Lane", "Catalinashire", new DateTime(2023, 7, 1, 17, 0, 1, 181, DateTimeKind.Local).AddTicks(6877), "Esperanza.Quigley87@yahoo.com", 50.065899999999999, 43.371200000000002, "Corporate Security Liaison", "932-860-5798", "72268" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "568 Hamill Mount", "West Neil", new DateTime(2022, 9, 5, 0, 23, 50, 441, DateTimeKind.Local).AddTicks(5109), "Novella94@hotmail.com", 52.913600000000002, 102.3415, "International Accountability Liaison", "(343) 942-1204 x05836", "03325-0652" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "082 Amos Roads", "Jaceyhaven", new DateTime(2023, 3, 29, 20, 32, 2, 68, DateTimeKind.Local).AddTicks(6263), "Margarita39@yahoo.com", -6.1501000000000001, 116.1311, "Central Branding Developer", "682.610.6508 x30836", "76933" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "911 Osinski Village", "Uliceston", new DateTime(2023, 5, 9, 14, 40, 18, 490, DateTimeKind.Local).AddTicks(5137), "Lilly_Brakus35@gmail.com", -38.715800000000002, -155.9614, "Chief Quality Designer", "760-290-9210 x09957", "26209" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "57306 Destinee Valleys", "Ezekielburgh", new DateTime(2023, 4, 15, 19, 1, 23, 725, DateTimeKind.Local).AddTicks(5506), "Wilmer_McDermott48@yahoo.com", 6.2991999999999999, -99.904600000000002, "Direct Configuration Liaison", "636.915.7189", "29070-2379" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "292 Towne Green", "9308 Lucienne Estate", new DateTime(2023, 6, 30, 1, 34, 21, 276, DateTimeKind.Local).AddTicks(7506), "Hettie.Hirthe47@hotmail.com", "Monty", "Rau", "https://picsum.photos/640/480/?image=104", "https://picsum.photos/640/480/?image=249", "997-702-7603 x4553", "East Karaburgh", "58886-0629" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "372 Brennon Island", "145 Leuschke Mount", new DateTime(2023, 4, 25, 1, 59, 13, 840, DateTimeKind.Local).AddTicks(1965), "Raven_Wunsch27@hotmail.com", "Vena", "Corwin", "https://picsum.photos/640/480/?image=731", "https://picsum.photos/640/480/?image=714", "304-290-2127", "West Adonis", "13983-1145" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "500 Turner Groves", "7247 Raynor Circles", new DateTime(2023, 6, 30, 11, 13, 1, 21, DateTimeKind.Local).AddTicks(6161), "Chauncey_Kessler11@yahoo.com", "Dagmar", "Gottlieb", "https://picsum.photos/640/480/?image=667", "https://picsum.photos/640/480/?image=173", "891-470-3541 x5269", "East Zakaryberg", "73314" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "522 Watsica Gardens", "9109 Dante Ports", new DateTime(2022, 10, 11, 22, 21, 28, 487, DateTimeKind.Local).AddTicks(3634), "Sedrick.Buckridge@gmail.com", "Aleen", "Wolff", "https://picsum.photos/640/480/?image=877", "https://picsum.photos/640/480/?image=153", "(419) 494-0894 x5834", "Jamirview", "94191-1399" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "7048 Finn Loop", "75688 Bernhard Turnpike", new DateTime(2022, 12, 4, 18, 30, 36, 585, DateTimeKind.Local).AddTicks(5995), "Estefania_Mitchell69@gmail.com", "Burley", "O'Connell", "https://picsum.photos/640/480/?image=517", "https://picsum.photos/640/480/?image=689", "626-962-3323", "Tillmantown", "89290-7280" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "37396 Zboncak Street", "579 Mosciski Stream", new DateTime(2023, 3, 19, 10, 37, 49, 90, DateTimeKind.Local).AddTicks(3402), "Elda_Runolfsson@yahoo.com", "Conrad", "Ortiz", "https://picsum.photos/640/480/?image=890", "https://picsum.photos/640/480/?image=729", "341.848.2910", "Lynchland", "26667-0111" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "178 Edyth Square", "7815 Weissnat Rapids", new DateTime(2023, 6, 8, 15, 22, 5, 424, DateTimeKind.Local).AddTicks(8561), "Gina_Schaefer@yahoo.com", "Eusebio", "Quigley", "https://picsum.photos/640/480/?image=392", "https://picsum.photos/640/480/?image=490", "1-832-509-5310 x194", "Leannonstad", "08778" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "3803 Hayes Mountain", "3348 Barrett Flats", new DateTime(2022, 12, 11, 15, 29, 28, 737, DateTimeKind.Local).AddTicks(4974), "Derrick.Jacobson81@yahoo.com", "Craig", "Dooley", "https://picsum.photos/640/480/?image=1027", "https://picsum.photos/640/480/?image=951", "803.420.6365 x09997", "Elviechester", "08020-9325" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "49652 Daniel Squares", "1814 Stiedemann Via", new DateTime(2023, 4, 9, 15, 28, 54, 452, DateTimeKind.Local).AddTicks(2131), "Travon28@gmail.com", "Barrett", "Powlowski", "https://picsum.photos/640/480/?image=829", "https://picsum.photos/640/480/?image=262", "1-481-726-4662", "Efrenchester", "24015-6154" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "9677 Junior Streets", "71270 Kub Viaduct", new DateTime(2023, 8, 4, 10, 26, 26, 518, DateTimeKind.Local).AddTicks(7326), "Dangelo_Senger40@gmail.com", "Betsy", "Streich", "https://picsum.photos/640/480/?image=198", "https://picsum.photos/640/480/?image=344", "668.985.9181", "Port Lorenza", "96144-4937" });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 5, 3, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 7, 1 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 4,
                column: "IdClient",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 3, 10 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 9, 6 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 2, 7 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 8,
                column: "IdReservation",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 8, 3 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 9, 2, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 22, 5, 32, 10, 387, DateTimeKind.Local).AddTicks(6940), new DateTime(2023, 8, 22, 21, 24, 12, 308, DateTimeKind.Local).AddTicks(4041), new DateTime(2023, 11, 4, 11, 43, 11, 921, DateTimeKind.Local).AddTicks(3564), 8, 4.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 22, 2, 48, 54, 509, DateTimeKind.Local).AddTicks(8896), new DateTime(2023, 8, 23, 3, 23, 22, 376, DateTimeKind.Local).AddTicks(4552), new DateTime(2023, 9, 9, 5, 26, 24, 562, DateTimeKind.Local).AddTicks(2927), 8, 7.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 21, 13, 57, 44, 52, DateTimeKind.Local).AddTicks(2089), new DateTime(2023, 8, 23, 7, 54, 11, 510, DateTimeKind.Local).AddTicks(2821), new DateTime(2024, 6, 13, 6, 14, 55, 991, DateTimeKind.Local).AddTicks(3433), 2, 6.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 21, 15, 3, 16, 386, DateTimeKind.Local).AddTicks(2111), new DateTime(2023, 8, 23, 6, 0, 11, 556, DateTimeKind.Local).AddTicks(6587), new DateTime(2023, 12, 25, 5, 55, 45, 156, DateTimeKind.Local).AddTicks(7753), 4, 9.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 22, 4, 5, 18, 149, DateTimeKind.Local).AddTicks(118), new DateTime(2023, 8, 23, 8, 12, 54, 706, DateTimeKind.Local).AddTicks(6507), new DateTime(2024, 6, 20, 19, 16, 14, 546, DateTimeKind.Local).AddTicks(8374), 4, 3.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 21, 18, 49, 49, 390, DateTimeKind.Local).AddTicks(5988), new DateTime(2023, 8, 22, 22, 29, 14, 319, DateTimeKind.Local).AddTicks(1399), new DateTime(2023, 9, 7, 5, 14, 16, 417, DateTimeKind.Local).AddTicks(4136), 5, 3.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 22, 8, 46, 0, 318, DateTimeKind.Local).AddTicks(5240), new DateTime(2023, 8, 23, 0, 13, 18, 46, DateTimeKind.Local).AddTicks(624), new DateTime(2024, 4, 23, 22, 26, 26, 807, DateTimeKind.Local).AddTicks(6250), 10.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 21, 21, 58, 47, 968, DateTimeKind.Local).AddTicks(1604), new DateTime(2023, 8, 22, 16, 28, 6, 824, DateTimeKind.Local).AddTicks(2357), new DateTime(2024, 4, 27, 18, 12, 52, 499, DateTimeKind.Local).AddTicks(3202), 10, 4.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 22, 6, 0, 18, 311, DateTimeKind.Local).AddTicks(9191), new DateTime(2023, 8, 23, 6, 53, 52, 143, DateTimeKind.Local).AddTicks(244), new DateTime(2023, 12, 17, 9, 10, 49, 991, DateTimeKind.Local).AddTicks(6343), 3, 1.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 21, 19, 45, 41, 880, DateTimeKind.Local).AddTicks(33), new DateTime(2023, 8, 22, 12, 22, 17, 963, DateTimeKind.Local).AddTicks(9888), new DateTime(2024, 7, 14, 14, 26, 1, 434, DateTimeKind.Local).AddTicks(9053), 1, 8.0 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 21, 16, 18, 16, 662, DateTimeKind.Local).AddTicks(5076), new DateTime(2023, 8, 22, 15, 23, 31, 633, DateTimeKind.Local).AddTicks(1938), new DateTime(2023, 11, 29, 12, 8, 35, 696, DateTimeKind.Local).AddTicks(5014), 6, "37d4e867-5f12-41b9-91bc-2e2039707e67", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 21, 19, 8, 57, 616, DateTimeKind.Local).AddTicks(2161), new DateTime(2023, 8, 22, 20, 31, 28, 411, DateTimeKind.Local).AddTicks(2422), new DateTime(2023, 11, 6, 1, 38, 48, 759, DateTimeKind.Local).AddTicks(3996), 6, "b9b1d418-770c-43cb-8522-e1b04bf0a0f6", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 1, 27, 53, 242, DateTimeKind.Local).AddTicks(3552), new DateTime(2023, 8, 22, 19, 4, 21, 179, DateTimeKind.Local).AddTicks(7156), new DateTime(2024, 6, 13, 10, 54, 49, 856, DateTimeKind.Local).AddTicks(6361), 7, "79d7c87c-131c-4807-9d93-bed05ebf0945", "Annulé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 6, 26, 29, 485, DateTimeKind.Local).AddTicks(5989), new DateTime(2023, 8, 23, 1, 0, 38, 699, DateTimeKind.Local).AddTicks(9400), new DateTime(2024, 4, 14, 23, 11, 27, 221, DateTimeKind.Local).AddTicks(4077), 2, "d489559b-4bfc-41a6-b4bd-fabe059468a6", "Annulé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 21, 14, 37, 12, 175, DateTimeKind.Local).AddTicks(9641), new DateTime(2023, 8, 22, 22, 54, 29, 181, DateTimeKind.Local).AddTicks(1080), new DateTime(2024, 7, 23, 23, 7, 28, 579, DateTimeKind.Local).AddTicks(3970), 7, "acc6cb21-6b36-426d-b063-519343962fbe", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 21, 23, 56, 42, 812, DateTimeKind.Local).AddTicks(7287), new DateTime(2023, 8, 23, 4, 44, 5, 24, DateTimeKind.Local).AddTicks(9767), new DateTime(2024, 1, 25, 17, 18, 10, 327, DateTimeKind.Local).AddTicks(3509), "5f68bb74-23b0-4c3c-96dc-7b74370e1203", "Expiré" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 21, 23, 38, 16, 129, DateTimeKind.Local).AddTicks(8223), new DateTime(2023, 8, 22, 10, 55, 21, 306, DateTimeKind.Local).AddTicks(2545), new DateTime(2024, 4, 10, 18, 16, 42, 967, DateTimeKind.Local).AddTicks(4887), 7, "6c8ea4de-8992-452a-b984-e8cf91ea0e27", "Confirmé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 21, 20, 50, 23, 100, DateTimeKind.Local).AddTicks(4428), new DateTime(2023, 8, 23, 1, 36, 23, 692, DateTimeKind.Local).AddTicks(3968), new DateTime(2024, 6, 17, 2, 9, 41, 292, DateTimeKind.Local).AddTicks(9816), 3, "8fa7e2f6-2c12-4975-bee5-343b4d042db1", "Confirmé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 5, 18, 0, 482, DateTimeKind.Local).AddTicks(5902), new DateTime(2023, 8, 22, 15, 1, 3, 103, DateTimeKind.Local).AddTicks(5999), new DateTime(2024, 4, 25, 22, 41, 49, 814, DateTimeKind.Local).AddTicks(596), 2, "a6618f8f-f662-4339-b475-b654386733f2", "Annulé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 21, 17, 50, 41, 539, DateTimeKind.Local).AddTicks(3043), new DateTime(2023, 8, 23, 3, 48, 19, 65, DateTimeKind.Local).AddTicks(3454), new DateTime(2023, 9, 14, 5, 16, 40, 284, DateTimeKind.Local).AddTicks(8672), 4, "b7477856-3d93-435b-924d-817026821339" });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 1, 1 },
                column: "Id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 2, 1 },
                column: "Id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 3, 1 },
                column: "Id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 4, 1 },
                column: "Id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 5, 1 },
                column: "Id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 6, 1 },
                column: "Id",
                value: 6);

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 7, 1 },
                column: "Id",
                value: 7);

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 13, 1 },
                column: "Id",
                value: 8);

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 2, 2 },
                column: "Id",
                value: 9);

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 3, 2 },
                column: "Id",
                value: 10);

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 4, 2 },
                column: "Id",
                value: 11);

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 6, 2 },
                column: "Id",
                value: 12);

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 7, 2 },
                column: "Id",
                value: 13);

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 8, 2 },
                column: "Id",
                value: 14);

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 9, 2 },
                column: "Id",
                value: 15);

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 10, 2 },
                column: "Id",
                value: 16);

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 11, 2 },
                column: "Id",
                value: 17);

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 12, 2 },
                column: "Id",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 18, 14, 14, 41, 679, DateTimeKind.Local).AddTicks(3421), "Johan7@hotmail.com", "Winifred", 6, 1, "Heathcote", "$2a$11$jlpFO3KVwkNzXlEwZiBMk.3IksVFsTtUl5n/i52ITAIdvRLdLfKSC" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 2, 20, 7, 29, 49, 143, DateTimeKind.Local).AddTicks(3236), "Lea.Nader@yahoo.com", "Wilhelm", 7, 1, false, "Jacobi", "$2a$11$i4Pbu9rgYZ6qMt.lBzQQYuYDCGiHbYN5dPgHS4O/iNMDdZZ5OBPRG" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 19, 9, 28, 33, 272, DateTimeKind.Local).AddTicks(4298), "Suzanne_Bernier68@yahoo.com", "Evalyn", 3, 2, "Crona", "$2a$11$tYyvph5kSygL66frbaM/P./uN6u/3DfEqScNy6ZCmXvd0Ex0H7/U6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 3, 0, 44, 25, 888, DateTimeKind.Local).AddTicks(2554), "Wanda_Kihn97@gmail.com", "Bria", false, "Wuckert", "$2a$11$j6AQ0HmdXvji.u8x/L.znu95wzZKq0lDdZFTTRf98ZGvBEQx6lEE6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 4, 20, 6, 12, 5, 112, DateTimeKind.Local).AddTicks(9190), "Clifton55@hotmail.com", "Ryann", 1, false, "Harber", "$2a$11$HaGTS18y0wN8cfCinBA6TOUHYyyq/SqO5VMw6v59mFRlx0O5DnKM2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 4, 30, 3, 59, 1, 565, DateTimeKind.Local).AddTicks(9339), "Caden7@gmail.com", "Meredith", 10, "Osinski", "$2a$11$/nkRqFg/rUtR3XharnFivOmtA.w9fWEfo6dKv8m0z1smmyokpWW3e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 18, 16, 9, 33, 702, DateTimeKind.Local).AddTicks(3925), "Luella.Hilll@hotmail.com", "Melvin", 7, "Johns", "$2a$11$KfdXCZ.2PGYwqrikIKzfbuMbif7TnkFTMnjO8nK/aVxe79Acycrhi" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 4, 16, 18, 23, 571, DateTimeKind.Local).AddTicks(7451), "Russel31@yahoo.com", "Maia", 6, false, "Von", "$2a$11$kmN18AMD0LauXwv3VGqajuxTQtvUSowpH6t5umwhYeFKi5gR45Do2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 9, 13, 13, 24, 55, DateTimeKind.Local).AddTicks(2144), "Jordi_Schowalter66@yahoo.com", "Uriel", 2, true, "Ledner", "$2a$11$.1S/8Erd4aiIQ775vAnHeOo0cSjOfyq6ahUVCrrwcdwMIsrUDwCKO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 7, 7, 15, 22, 38, 588, DateTimeKind.Local).AddTicks(63), "Columbus.Mosciski24@hotmail.com", "Melba", 6, 2, "Fay", "$2a$11$8C2HidRWVO/N5wThBuAiUuHgnlKBG0rdv.Fihj6Wggvx8hNTlpYAy" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPort", "Type" },
                values: new object[] { false, true, new DateTime(2022, 9, 18, 11, 16, 6, 520, DateTimeKind.Local).AddTicks(1714), "rwlrhlboco", 6, 69, 1126, "dvvicejzcp", "imdirwlrmj", "gffjhpryqx", 2, "dcuyrxmzek" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2022, 12, 22, 13, 7, 0, 316, DateTimeKind.Local).AddTicks(6394), "goqslmpiwa", 5, 302, 8846, "nyxumieayr", "pkcouheetl", "hdkpxbkgzu", 6, 5, 6.0, "oxiertpsdq" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, true, new DateTime(2023, 1, 18, 21, 52, 30, 436, DateTimeKind.Local).AddTicks(4275), "tlcyhnshws", 3, 191, 7056, "uzxnxsxgbl", "xqflxrfjww", "slrgzdjqtv", 10, 3, 2.0, "notyqyvmal" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, true, new DateTime(2022, 12, 2, 11, 6, 53, 51, DateTimeKind.Local).AddTicks(5268), "hcywgrwuco", 88, 7871, "wdwsefwkxz", "zbbwluovyy", "ylqtbsilrq", 1, 2, 10.0, "mdpkpohqnd" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "Prix", "Type" },
                values: new object[] { true, new DateTime(2023, 4, 13, 4, 25, 51, 160, DateTimeKind.Local).AddTicks(5371), "zxvegizzvt", 1, 224, 713, "qdqpmtudsl", "bhmjqvdpdr", "tmukelcngy", 5.0, "sioyxdfpse" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2023, 7, 8, 3, 54, 43, 839, DateTimeKind.Local).AddTicks(9629), "otiouvpvgx", 10, 118, 6770, "ryjglstrmu", "cprggcsfic", "ejjktygwla", 4, 3, 10.0, "jbnpycnyjx" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "Type" },
                values: new object[] { false, new DateTime(2023, 5, 7, 22, 44, 57, 756, DateTimeKind.Local).AddTicks(2719), "phfggkfvnu", 8, 136, 1748, "cwpvthcqhr", "yqlocohevg", "mfeadjqaxe", 7, "vbrttthwwi" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2022, 10, 7, 15, 4, 19, 768, DateTimeKind.Local).AddTicks(2591), "pspdkvcvhx", 9, 156, 9124, "veydnvyvim", "bttpswpcub", "mdriqfxgym", 8, 5, 4.0, "alnpbfovdn" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2023, 6, 30, 11, 50, 43, 891, DateTimeKind.Local).AddTicks(5205), "ejaogimbtr", 10, 34, 835, "zvnupldiqp", "ygfgqleddd", "rtincdiqjk", 8, 5, 10.0, "ssthawuawe" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2023, 4, 23, 15, 7, 30, 749, DateTimeKind.Local).AddTicks(1823), "eszujkoitr", 49, 3238, "bdqutgsvcv", "uhvitvxque", "mrsricoavf", 1, 6, 4.0, "ebbbyfcdmw" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 5, 11, 0, 24, 17, 928, DateTimeKind.Local).AddTicks(9845), "vycdxmgclp", 166, "unkkjywnuz", "xyusjfdccv", "Bauch", 20, "Feeney - Mayer", "Fannie", "1-674-491-3175", "Renner", "Cormierview", "09134" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 4, 21, 14, 13, 56, 600, DateTimeKind.Local).AddTicks(2566), "smelbfnlsv", 173, "sqicfdsaev", "nvhyngvkns", "Rempel", 22, "Murray and Sons", "Yesenia", "355.277.3138", "Stroman", "East Daneborough", "97856" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 6, 26, 10, 49, 36, 484, DateTimeKind.Local).AddTicks(5570), "orasxqigvf", 28, "ndccndtsij", "rcztgundzu", "Cummings", 33, "Murphy, Moore and Lockman", "Herta", "915-664-9755", "Kris", "Lake Chet", "28123-3779" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 11, 29, 6, 44, 12, 752, DateTimeKind.Local).AddTicks(9249), "fdkdlwmzpk", 104, "iyavmsjscq", "xsmcyeugxe", "Waters", 32, "Bradtke, Hoppe and Gleichner", "Zander", "(644) 474-4221", "Kshlerin", "Kianview", "58564-0627" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 4, 27, 21, 10, 30, 230, DateTimeKind.Local).AddTicks(7249), "oitirdkvhp", 114, "clvjwhczzk", "odrycbfsio", "Mosciski", 20, "Bergnaum Inc", "Kiel", "821-293-0776", "Walter", "Adrienneborough", "11589" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 2, 4, 2, 33, 9, 274, DateTimeKind.Local).AddTicks(9259), "olbmnspxwz", 233, "faalobytek", "ecirvhhscz", "Connelly", 23, "Littel, Homenick and Kreiger", "Cyrus", "857-809-8216", "Bayer", "Beatriceview", "70379-5290" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 8, 18, 1, 42, 47, 600, DateTimeKind.Local).AddTicks(8371), "oldcvdphjy", 279, "ipjwiuaizq", "miogderaxz", "Lynch", 28, "Reilly - Ratke", "Adrienne", "(291) 990-0606", "Kautzer", "Port Steveborough", "77785" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 4, 3, 7, 57, 52, 775, DateTimeKind.Local).AddTicks(9106), "pcrvhjofnf", 81, "tiovdntemh", "dmszocovtt", "Ortiz", 19, "Carter - Dach", "Misael", "581.674.5917", "Jones", "Gavinfurt", "82550" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 3, 12, 22, 57, 21, 32, DateTimeKind.Local).AddTicks(9529), "izhsarevbv", 78, "zajjiyizsn", "yciyglkhig", "Kautzer", 25, "Kub, Friesen and Vandervort", "Davonte", "(694) 852-8177", "Sipes", "Rempelhaven", "25033" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 8, 8, 4, 24, 28, 324, DateTimeKind.Local).AddTicks(5090), "sbuscmksac", 62, "zpmdmzdvbw", "idbvrcaocl", "Stoltenberg", 22, "Schulist, Cruickshank and Koch", "Akeem", "867.801.6458", "Abshire", "Gorczanyville", "18668" });
        }
    }
}
