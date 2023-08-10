using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AutomotiveApi.Migrations
{
    /// <inheritdoc />
    public partial class add_some_seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "6182 Beahan Divide", "Robbietown", new DateTime(2023, 3, 26, 15, 7, 1, 857, DateTimeKind.Local).AddTicks(6143), "Royal.Schmidt22@hotmail.com", -0.61799999999999999, -29.8934, "Chief Mobility Specialist", "1-394-704-3596", "68508" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "531 Dejuan Valleys", "South Pasqualechester", new DateTime(2022, 9, 29, 9, 35, 31, 59, DateTimeKind.Local).AddTicks(5784), "Alex0@yahoo.com", -75.291700000000006, -107.9713, "Senior Interactions Associate", "1-977-801-7637 x1038", "88564-4022" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "74580 Heidenreich Cliff", "Port Carsontown", new DateTime(2023, 4, 3, 18, 14, 6, 430, DateTimeKind.Local).AddTicks(609), "Dulce.Dicki@yahoo.com", 86.934299999999993, -14.308400000000001, "National Infrastructure Agent", "697-286-4906 x7886", "28125" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "89353 Baylee Roads", "Duanefort", new DateTime(2023, 1, 9, 6, 29, 57, 537, DateTimeKind.Local).AddTicks(4628), "Cierra_Rosenbaum@yahoo.com", -21.313099999999999, -141.6507, "Dynamic Integration Developer", "776.351.6658 x682", "40001" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "04090 Yost Ford", "Feilland", new DateTime(2022, 8, 31, 2, 4, 0, 294, DateTimeKind.Local).AddTicks(6186), "Jesus.Mueller@gmail.com", 19.499300000000002, -27.8703, "Direct Quality Manager", "1-733-534-5949 x782", "28256" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "191 Hammes Stravenue", "East Dwighttown", new DateTime(2022, 10, 4, 12, 36, 28, 490, DateTimeKind.Local).AddTicks(8823), "Mac_Kerluke66@yahoo.com", -7.9211999999999998, 53.584600000000002, "Future Response Technician", "282-746-6551", "71140" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "6448 Torphy Inlet", "Rosenbaumton", new DateTime(2022, 10, 16, 20, 1, 52, 234, DateTimeKind.Local).AddTicks(9503), "Wilburn_Wisozk@hotmail.com", 74.978300000000004, 5.8747999999999996, "Senior Mobility Developer", "(867) 672-4229 x38323", "20775" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "74651 McClure Trafficway", "Lake Codybury", new DateTime(2023, 6, 7, 16, 29, 31, 546, DateTimeKind.Local).AddTicks(5338), "Norma.Kilback@hotmail.com", 25.6068, 102.9462, "Forward Quality Representative", "538-639-9852 x187", "87458" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "556 Kaylee Fall", "North Adalberto", new DateTime(2023, 1, 4, 9, 38, 6, 252, DateTimeKind.Local).AddTicks(3233), "Carissa_McGlynn76@yahoo.com", -78.281499999999994, -153.40880000000001, "National Markets Strategist", "(563) 974-9792", "50173" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "923 Shakira Ports", "Walkerbury", new DateTime(2023, 1, 16, 1, 42, 0, 169, DateTimeKind.Local).AddTicks(8780), "Ceasar.Zboncak@gmail.com", 82.485600000000005, -98.504800000000003, "Future Applications Consultant", "309-829-9167 x78431", "21014-8702" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "86757 Luettgen Wall", "0356 Krystal View", new DateTime(2022, 9, 14, 21, 6, 9, 500, DateTimeKind.Local).AddTicks(119), "Caleigh_Considine60@yahoo.com", "Amalia", "Dach", "https://picsum.photos/640/480/?image=175", "https://picsum.photos/640/480/?image=346", "950.855.5080 x80048", "New Nelle", "96637-8622" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "2889 Adela Keys", "8153 Prosacco Drive", new DateTime(2023, 1, 12, 19, 41, 35, 469, DateTimeKind.Local).AddTicks(4452), "Ludwig75@yahoo.com", "Laverne", "Daniel", "https://picsum.photos/640/480/?image=68", "https://picsum.photos/640/480/?image=1072", "1-829-849-0463", "Lake Liliane", "81015" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "9836 Gleichner Ports", "735 Monahan Spur", new DateTime(2023, 3, 23, 2, 40, 13, 251, DateTimeKind.Local).AddTicks(6888), "Rebecca19@gmail.com", "Hugh", "McCullough", "https://picsum.photos/640/480/?image=253", "https://picsum.photos/640/480/?image=223", "816.496.4432", "Doylehaven", "82065" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "12384 Ullrich Common", "281 Kihn Ranch", new DateTime(2022, 9, 8, 11, 39, 53, 311, DateTimeKind.Local).AddTicks(2076), "Gail_Walter49@yahoo.com", "Theodore", "Mayert", "https://picsum.photos/640/480/?image=398", "https://picsum.photos/640/480/?image=136", "1-691-520-7150", "Blandaview", "06271-5065" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "82848 Rosenbaum Burgs", "662 Kiarra Land", new DateTime(2023, 2, 10, 9, 39, 41, 221, DateTimeKind.Local).AddTicks(6141), "Maryse.Auer@gmail.com", "Jameson", "Jacobs", "https://picsum.photos/640/480/?image=507", "https://picsum.photos/640/480/?image=321", "(330) 215-5836 x65719", "South Therese", "95690" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "60963 Abshire Creek", "27967 McCullough Fall", new DateTime(2022, 9, 12, 14, 34, 15, 713, DateTimeKind.Local).AddTicks(6443), "Pinkie87@hotmail.com", "Evelyn", "Herman", "https://picsum.photos/640/480/?image=1021", "https://picsum.photos/640/480/?image=46", "(952) 810-8508 x67783", "South Uriel", "10156-2817" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "02099 Fadel Unions", "127 Janet Way", new DateTime(2023, 2, 22, 6, 44, 24, 767, DateTimeKind.Local).AddTicks(4061), "Sid.Mayer@yahoo.com", "Emmanuelle", "Kunde", "https://picsum.photos/640/480/?image=313", "https://picsum.photos/640/480/?image=659", "341-931-7999", "Lake Everett", "45998" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "092 Little Landing", "01420 Missouri Rapid", new DateTime(2023, 2, 14, 7, 3, 49, 766, DateTimeKind.Local).AddTicks(8297), "Thurman.Ebert@gmail.com", "Buford", "Abshire", "https://picsum.photos/640/480/?image=613", "https://picsum.photos/640/480/?image=621", "1-546-264-0277", "Dayneland", "78359" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "27162 Nadia Knoll", "93450 Brekke Wall", new DateTime(2023, 5, 16, 18, 46, 45, 405, DateTimeKind.Local).AddTicks(9580), "Leonel.Ruecker@gmail.com", "Corbin", "Ryan", "https://picsum.photos/640/480/?image=508", "https://picsum.photos/640/480/?image=428", "789.543.5569 x4814", "Felipestad", "85263" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "6136 Mosciski Pines", "061 Albin Trace", new DateTime(2022, 11, 16, 9, 27, 52, 8, DateTimeKind.Local).AddTicks(7203), "Norval_Yundt@hotmail.com", "Dedric", "Schroeder", "https://picsum.photos/640/480/?image=1049", "https://picsum.photos/640/480/?image=435", "(595) 750-3992 x3875", "New Steviebury", "98232" });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 1, 7, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 3,
                column: "IdReservation",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 7, 7, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 5,
                column: "IdReservation",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 10, 10, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 8, 9, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 7, 8, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 4, 8, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 7, 7, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 9, 14, 43, 13, 316, DateTimeKind.Local).AddTicks(2639), new DateTime(2023, 8, 9, 21, 39, 21, 833, DateTimeKind.Local).AddTicks(836), new DateTime(2024, 5, 17, 8, 53, 16, 734, DateTimeKind.Local).AddTicks(4241), 8.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 9, 17, 22, 2, 130, DateTimeKind.Local).AddTicks(7088), new DateTime(2023, 8, 10, 16, 45, 51, 976, DateTimeKind.Local).AddTicks(7605), new DateTime(2024, 5, 5, 22, 9, 25, 924, DateTimeKind.Local).AddTicks(8362), 10, 3.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 9, 2, 0, 22, 656, DateTimeKind.Local).AddTicks(1606), new DateTime(2023, 8, 10, 8, 40, 15, 136, DateTimeKind.Local).AddTicks(4534), new DateTime(2024, 7, 4, 13, 59, 28, 915, DateTimeKind.Local).AddTicks(6354), 3, 3.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 8, 22, 20, 2, 806, DateTimeKind.Local).AddTicks(2817), new DateTime(2023, 8, 9, 21, 52, 41, 57, DateTimeKind.Local).AddTicks(2381), new DateTime(2023, 11, 20, 13, 32, 22, 828, DateTimeKind.Local).AddTicks(6), 5, 5.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 9, 4, 17, 44, 70, DateTimeKind.Local).AddTicks(46), new DateTime(2023, 8, 10, 16, 22, 32, 159, DateTimeKind.Local).AddTicks(5114), new DateTime(2023, 12, 3, 17, 49, 9, 288, DateTimeKind.Local).AddTicks(8386), 7, 10.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 9, 5, 24, 13, 470, DateTimeKind.Local).AddTicks(8371), new DateTime(2023, 8, 10, 4, 14, 2, 148, DateTimeKind.Local).AddTicks(9190), new DateTime(2024, 1, 5, 6, 20, 26, 700, DateTimeKind.Local).AddTicks(4317), 7, 9.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 9, 6, 6, 54, 751, DateTimeKind.Local).AddTicks(5538), new DateTime(2023, 8, 10, 15, 16, 39, 658, DateTimeKind.Local).AddTicks(8363), new DateTime(2024, 7, 31, 12, 14, 40, 200, DateTimeKind.Local).AddTicks(4221), 7, 10.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 9, 14, 51, 51, 175, DateTimeKind.Local).AddTicks(6529), new DateTime(2023, 8, 10, 18, 49, 4, 568, DateTimeKind.Local).AddTicks(6540), new DateTime(2023, 12, 3, 23, 31, 53, 714, DateTimeKind.Local).AddTicks(7075), false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 9, 13, 47, 4, 921, DateTimeKind.Local).AddTicks(6032), new DateTime(2023, 8, 10, 7, 44, 24, 162, DateTimeKind.Local).AddTicks(9852), new DateTime(2023, 8, 19, 21, 5, 54, 269, DateTimeKind.Local).AddTicks(6468), 9, 9.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 9, 17, 59, 41, 644, DateTimeKind.Local).AddTicks(3409), new DateTime(2023, 8, 9, 22, 49, 40, 458, DateTimeKind.Local).AddTicks(3809), new DateTime(2024, 3, 24, 20, 51, 40, 27, DateTimeKind.Local).AddTicks(3704), 4, 5.0 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 9, 4, 49, 21, 801, DateTimeKind.Local).AddTicks(4341), new DateTime(2023, 8, 10, 5, 32, 18, 356, DateTimeKind.Local).AddTicks(5270), new DateTime(2024, 7, 29, 22, 23, 44, 589, DateTimeKind.Local).AddTicks(4400), 7, "8e8c2434-9b8c-45d1-9f07-6f8ac7e335f0", "Annulé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 9, 11, 22, 22, 825, DateTimeKind.Local).AddTicks(2247), new DateTime(2023, 8, 10, 5, 19, 22, 878, DateTimeKind.Local).AddTicks(5598), new DateTime(2024, 4, 15, 12, 53, 40, 776, DateTimeKind.Local).AddTicks(4071), 2, "ea8396d7-63c6-433c-8844-c54e19ecb657" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 9, 2, 47, 23, 256, DateTimeKind.Local).AddTicks(1332), new DateTime(2023, 8, 9, 23, 29, 12, 725, DateTimeKind.Local).AddTicks(844), new DateTime(2023, 10, 30, 23, 20, 6, 174, DateTimeKind.Local).AddTicks(8011), 8, "c55c90fe-1aaf-4ed6-915a-8b9d9ab00403", "Expiré" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 9, 5, 38, 24, 374, DateTimeKind.Local).AddTicks(3554), new DateTime(2023, 8, 10, 17, 34, 57, 376, DateTimeKind.Local).AddTicks(6063), new DateTime(2023, 9, 30, 16, 57, 0, 718, DateTimeKind.Local).AddTicks(2761), 8, "040aaa8f-45e7-48b8-a540-805299ceaa75" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 9, 10, 18, 54, 588, DateTimeKind.Local).AddTicks(3692), new DateTime(2023, 8, 10, 15, 50, 46, 103, DateTimeKind.Local).AddTicks(1081), new DateTime(2023, 9, 28, 14, 59, 6, 100, DateTimeKind.Local).AddTicks(980), 5, "35a4ea5a-c5db-464d-91e9-934ae559c5ea" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 9, 16, 45, 6, 365, DateTimeKind.Local).AddTicks(2775), new DateTime(2023, 8, 10, 6, 50, 34, 864, DateTimeKind.Local).AddTicks(5803), new DateTime(2023, 10, 31, 14, 13, 53, 428, DateTimeKind.Local).AddTicks(6891), 3, "33ef466d-dafb-4e18-8ee5-448f0570f8ba" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 8, 22, 41, 26, 21, DateTimeKind.Local).AddTicks(1991), new DateTime(2023, 8, 10, 17, 7, 45, 963, DateTimeKind.Local).AddTicks(9884), new DateTime(2024, 4, 18, 9, 23, 32, 383, DateTimeKind.Local).AddTicks(5315), 4, "47403d05-735e-481a-b813-b0a80949d4de" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 8, 23, 13, 11, 591, DateTimeKind.Local).AddTicks(8666), new DateTime(2023, 8, 10, 9, 53, 28, 148, DateTimeKind.Local).AddTicks(6150), new DateTime(2024, 6, 10, 7, 59, 8, 297, DateTimeKind.Local).AddTicks(6511), 8, "7843eff6-f323-4ce6-953e-4f1a4b749218", "Annulé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 8, 22, 39, 38, 208, DateTimeKind.Local).AddTicks(5677), new DateTime(2023, 8, 10, 6, 24, 3, 613, DateTimeKind.Local).AddTicks(2555), new DateTime(2024, 5, 16, 14, 51, 51, 15, DateTimeKind.Local).AddTicks(2397), "3063bebc-b787-41a1-83a7-a7c05fd8b4d6", "Confirmé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 9, 0, 24, 35, 169, DateTimeKind.Local).AddTicks(5200), new DateTime(2023, 8, 10, 4, 52, 54, 118, DateTimeKind.Local).AddTicks(2816), new DateTime(2023, 11, 25, 6, 6, 11, 217, DateTimeKind.Local).AddTicks(4692), 9, "2b814e33-d56e-4b33-89b3-e7694dc92bee", "Annulé" });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 7, 2 },
                column: "Id",
                value: 7);

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "IdPermission", "IdRole", "CreatedAt", "DeletedAt", "Id", "UpdatedAt" },
                values: new object[,]
                {
                    { 5, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, null },
                    { 6, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 11, 5, 23, 14, 58, 147, DateTimeKind.Local).AddTicks(1830), "Prince.Farrell@gmail.com", "Adalberto", "Weissnat", "$2a$11$G19YAdP9ISd0KMYp4zNN6eW2.ZsJ6gIFfOuyF/tCqEg7gXHySDGYi" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 7, 18, 13, 57, 33, 714, DateTimeKind.Local).AddTicks(6057), "Stevie_Roberts83@yahoo.com", "Layla", 3, 2, true, "Fisher", "$2a$11$8k6pbPb7xvYTkwWVt2W/f.de3BwrTo8/d7ILmYa3JJQMKyArNJgN6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 10, 14, 49, 46, 695, DateTimeKind.Local).AddTicks(9277), "Sonny.Schaden@gmail.com", "Cordia", 3, true, "Bosco", "$2a$11$dxCd44dXoUGjA/aTdWUYieQLkk9uM4IphmyNel8E7l71Zi2r9Jo.S" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 21, 21, 40, 7, 839, DateTimeKind.Local).AddTicks(5749), "Casimer_Rolfson@gmail.com", "Dock", 1, "Douglas", "$2a$11$SRoJ1EjE5DzwY9JGJETrVe0ZG5Bn8hia.NWsh6dc3bLzApLWE4YnS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 10, 12, 21, 40, 14, 546, DateTimeKind.Local).AddTicks(5654), "Weston_Hermiston@gmail.com", "Justen", 2, false, "Spencer", "$2a$11$mLyonU9ivYYWirHWbTSOSesOMHo8pK20zK.bNJP5QC5roJANJxZBa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 9, 5, 44, 14, 424, DateTimeKind.Local).AddTicks(6882), "Hermina_Ratke@gmail.com", "Kavon", 9, 1, true, "Carter", "$2a$11$DvDbEXn6f8vs6U1cXoOjouT4Yf23FWJs4Hvxldfd3gAEeIsb3NLRe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 11, 28, 8, 17, 13, 714, DateTimeKind.Local).AddTicks(4728), "Candido98@yahoo.com", "Grover", 1, true, "Nicolas", "$2a$11$jamMkBLlYEMjKvaWPLurcuumIHkYzY9kvR6d6/QttqQItE4TskveG" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 10, 1, 48, 45, 964, DateTimeKind.Local).AddTicks(818), "Jaquelin13@hotmail.com", "Araceli", 8, true, "Tremblay", "$2a$11$DV0Pz01rR7xO0sXUJaiCl.N7PEOdLECk5La0EIsfrx2FpJWaXu7Tu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 6, 1, 28, 33, 989, DateTimeKind.Local).AddTicks(5506), "Haskell29@yahoo.com", "Vernon", 10, 1, "Corkery", "$2a$11$NgcgmbeQhoXekhhSIVfHHOw./1HlQvdW4J03flksTgRgeDio2F7Fq" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 5, 6, 18, 3, 826, DateTimeKind.Local).AddTicks(2066), "Providenci_Renner53@hotmail.com", "Ahmad", 4, true, "Kovacek", "$2a$11$PHu72DiE.iOy80CIxoPZ4ugSntwzSaydbQTjiYpgFln9RaaBPzS56" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2023, 4, 24, 9, 30, 40, 675, DateTimeKind.Local).AddTicks(337), "peirzvtlma", 9, 300, 693, "xmhnralilh", "cykupeznqb", "weknolezmq", 7, 2, 4.0, "mpbyeguaql" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2023, 5, 14, 15, 10, 9, 232, DateTimeKind.Local).AddTicks(7453), "yvrsxprhgu", 3, 13, 1406, "boyisuqhcn", "lokhrrerbz", "abdonvfhuh", 2, 5, 5.0, "lxmevquqzm" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, true, new DateTime(2022, 11, 20, 18, 57, 40, 60, DateTimeKind.Local).AddTicks(5003), "ihheukjelv", 1, 199, 6119, "ujgkoryfnc", "ionegjazmi", "afkrqlocgs", 5, 7, 10.0, "pwfaxeafok" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, true, new DateTime(2022, 10, 17, 11, 12, 25, 407, DateTimeKind.Local).AddTicks(6610), "rlxlacbquy", 10, 171, 1862, "wkmyoxqntv", "vtxckmqnek", "zhlqgmtpea", 3, 6, 4.0, "amxrhlxuhp" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2023, 5, 15, 0, 0, 48, 883, DateTimeKind.Local).AddTicks(8418), "pftwymulec", 32, 2396, "mmadxrsaoy", "hfvvftyydm", "laljcvivep", 9, 10, 6.0, "rfxnzjcqod" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2022, 8, 21, 4, 0, 57, 355, DateTimeKind.Local).AddTicks(996), "yzsljnktkx", 7, 127, 8947, "ptumbfnhco", "jyqpfxibjx", "bamtknuzcc", 5, 6, 9.0, "gnrlnkhrfl" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2022, 8, 15, 17, 36, 1, 397, DateTimeKind.Local).AddTicks(5297), "jqlybcbyjz", 3, 239, 6085, "hvhyileswy", "eezxyzixeu", "pelmlmhxvv", 2, 3, 5.0, "gkcbrclvjg" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "Prix", "Type" },
                values: new object[] { true, new DateTime(2023, 4, 19, 18, 16, 39, 880, DateTimeKind.Local).AddTicks(1425), "mrqyzucejt", 8, 184, 2070, "fiwiabacbk", "kyqknivwfd", "stgwatitpl", 8, 4.0, "zmzvgjfjon" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2023, 4, 2, 15, 23, 53, 607, DateTimeKind.Local).AddTicks(6329), "ckxkcblofl", 1, 187, 9816, "uwohwldmrp", "ebcfpxsnrs", "jxqwyitojv", 5, 4, 7.0, "kegftpauqa" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2022, 12, 10, 21, 21, 23, 871, DateTimeKind.Local).AddTicks(5277), "eihtbsmore", 2, 120, 5045, "giynrbwfkh", "tonccbwrfo", "aipbcplamc", 8, 4, 7.0, "wmfgcbanor" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 7, 24, 10, 10, 28, 354, DateTimeKind.Local).AddTicks(5082), 76, "gioirbxcqk", "Connelly", 27, "Kihn - Luettgen", "Phoebe", "(989) 712-6873", "Wilderman", "New Kenyattashire", "80258-7377" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 5, 5, 13, 33, 19, 592, DateTimeKind.Local).AddTicks(6641), 259, "kqoxigkloe", "Padberg", 22, "Rowe, Pfeffer and Mosciski", "Florence", "(353) 743-9234", "Littel", "Konopelskibury", "39249-1565" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 10, 1, 23, 47, 14, 56, DateTimeKind.Local).AddTicks(4865), 71, "jbnicggkgt", "DuBuque", 23, "Wyman, Hodkiewicz and Smitham", "Mathew", "(451) 808-9808 x96218", "Satterfield", "Weststad", "61057" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 4, 18, 14, 37, 52, 765, DateTimeKind.Local).AddTicks(5556), 167, "hnmlwzzpph", "D'Amore", 23, "Turcotte - Kertzmann", "Leila", "535.348.8265", "Sawayn", "Herbertmouth", "00863-6690" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 11, 27, 20, 30, 56, 957, DateTimeKind.Local).AddTicks(1805), 47, "zrupuayqnw", "Hermiston", "Pouros, Murphy and Dare", "Quincy", "288-366-3512 x748", "Turner", "Schulisthaven", "92544-5496" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 7, 26, 5, 10, 8, 836, DateTimeKind.Local).AddTicks(2654), 89, "nifddypgof", "Botsford", 23, "Feeney and Sons", "Lucienne", "682.614.2396 x43700", "Gutmann", "Lake Joseph", "77369" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 10, 19, 4, 12, 28, 450, DateTimeKind.Local).AddTicks(7511), 266, "dprfutpghh", "Gorczany", 29, "Batz LLC", "Rhett", "941.674.3574 x76252", "Emmerich", "Stehrchester", "86004-2662" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 9, 16, 16, 17, 44, 895, DateTimeKind.Local).AddTicks(71), 16, "azdznvercz", "McLaughlin", 25, "Pfeffer - Cummerata", "Jayson", "515-604-4569", "Hudson", "South Alexandretown", "86359-7739" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 11, 2, 7, 8, 27, 614, DateTimeKind.Local).AddTicks(4416), 89, "ahfygkhfyw", "Schinner", 29, "Roob - Feest", "Clemens", "875.469.9366 x52010", "Glover", "New Suzanne", "49822-2103" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 10, 6, 18, 50, 31, 759, DateTimeKind.Local).AddTicks(4020), 188, "wtwimtnjes", 31, "Wiza and Sons", "Damien", "1-467-381-7089", "Bins", "Raynormouth", "08850" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 6, 1 });

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
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 4, 10, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 3,
                column: "IdReservation",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 3, 6, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 5,
                column: "IdReservation",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 2, 3, false });

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
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 10, 1, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 3, 1, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 7, 8, 21, 46, 656, DateTimeKind.Local).AddTicks(2780), new DateTime(2023, 8, 8, 9, 30, 16, 398, DateTimeKind.Local).AddTicks(1874), new DateTime(2024, 2, 12, 3, 7, 10, 163, DateTimeKind.Local).AddTicks(8327), 5.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 6, 15, 30, 38, 247, DateTimeKind.Local).AddTicks(8071), new DateTime(2023, 8, 7, 15, 13, 6, 33, DateTimeKind.Local).AddTicks(1776), new DateTime(2023, 8, 30, 15, 39, 1, 597, DateTimeKind.Local).AddTicks(8182), 6, 2.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 7, 4, 3, 37, 935, DateTimeKind.Local).AddTicks(9765), new DateTime(2023, 8, 7, 21, 18, 36, 300, DateTimeKind.Local).AddTicks(6317), new DateTime(2023, 11, 19, 11, 8, 35, 852, DateTimeKind.Local).AddTicks(1562), 8, 5.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 7, 3, 46, 36, 784, DateTimeKind.Local).AddTicks(1127), new DateTime(2023, 8, 7, 20, 30, 6, 854, DateTimeKind.Local).AddTicks(5040), new DateTime(2023, 11, 16, 15, 2, 38, 752, DateTimeKind.Local).AddTicks(4751), 2, 3.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 7, 10, 56, 36, 38, DateTimeKind.Local).AddTicks(7106), new DateTime(2023, 8, 7, 18, 52, 10, 561, DateTimeKind.Local).AddTicks(2869), new DateTime(2023, 8, 7, 17, 52, 3, 506, DateTimeKind.Local).AddTicks(3615), 5, 6.0 });

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
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 6, 14, 41, 57, 732, DateTimeKind.Local).AddTicks(9792), new DateTime(2023, 8, 8, 9, 33, 51, 589, DateTimeKind.Local).AddTicks(9665), new DateTime(2024, 4, 14, 9, 27, 35, 43, DateTimeKind.Local).AddTicks(6886), true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 6, 17, 0, 0, 69, DateTimeKind.Local).AddTicks(7995), new DateTime(2023, 8, 7, 20, 23, 12, 423, DateTimeKind.Local).AddTicks(3700), new DateTime(2024, 2, 7, 12, 17, 37, 169, DateTimeKind.Local).AddTicks(5243), 10, 4.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 8, 23, 997, DateTimeKind.Local).AddTicks(7133), new DateTime(2023, 8, 7, 22, 25, 53, 265, DateTimeKind.Local).AddTicks(2590), new DateTime(2023, 11, 7, 3, 14, 53, 35, DateTimeKind.Local).AddTicks(2392), 5, 1.0 });

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
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 7, 11, 23, 42, 145, DateTimeKind.Local).AddTicks(3901), new DateTime(2023, 8, 7, 15, 54, 38, 165, DateTimeKind.Local).AddTicks(6131), new DateTime(2024, 1, 16, 4, 36, 18, 339, DateTimeKind.Local).AddTicks(7472), 5, "d670edda-b45e-4bfe-aac1-9ab9e51bf309" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 7, 11, 34, 1, 996, DateTimeKind.Local).AddTicks(976), new DateTime(2023, 8, 8, 6, 45, 56, 77, DateTimeKind.Local).AddTicks(8002), new DateTime(2023, 11, 6, 23, 10, 34, 421, DateTimeKind.Local).AddTicks(4304), 10, "59136721-945c-43b5-9f9f-c8fad42a7735", "Enattente" });

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
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 12, 29, 512, DateTimeKind.Local).AddTicks(4297), new DateTime(2023, 8, 8, 9, 27, 24, 369, DateTimeKind.Local).AddTicks(7027), new DateTime(2023, 11, 17, 5, 29, 39, 962, DateTimeKind.Local).AddTicks(7550), 9, "74b3aff0-cb09-41b7-877e-d1b32cf18bc1" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 6, 18, 53, 48, 79, DateTimeKind.Local).AddTicks(3331), new DateTime(2023, 8, 8, 1, 8, 27, 855, DateTimeKind.Local).AddTicks(7916), new DateTime(2023, 9, 17, 11, 8, 5, 221, DateTimeKind.Local).AddTicks(725), 6, "f579dc7f-b0b3-42fa-b45e-5b17f441c9d3" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 7, 3, 46, 4, 542, DateTimeKind.Local).AddTicks(9667), new DateTime(2023, 8, 7, 14, 22, 4, 596, DateTimeKind.Local).AddTicks(515), new DateTime(2024, 1, 17, 2, 32, 17, 78, DateTimeKind.Local).AddTicks(9069), 8, "d8ea83fc-dc4a-4019-8914-0d9f9170fb9f" });

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
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 7, 7, 0, 32, 438, DateTimeKind.Local).AddTicks(9203), new DateTime(2023, 8, 8, 1, 39, 58, 933, DateTimeKind.Local).AddTicks(5474), new DateTime(2024, 4, 16, 21, 33, 27, 596, DateTimeKind.Local).AddTicks(3878), "480d8010-4f69-4d80-8b89-074badb7d56f", "Expiré" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 7, 10, 51, 8, 753, DateTimeKind.Local).AddTicks(9697), new DateTime(2023, 8, 8, 11, 21, 38, 50, DateTimeKind.Local).AddTicks(3255), new DateTime(2023, 9, 3, 11, 16, 14, 195, DateTimeKind.Local).AddTicks(5165), 6, "a753a511-d64c-4106-b2dc-1aac71e75ca9", "Enattente" });

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 7, 2 },
                column: "Id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 17, 11, 8, 8, 460, DateTimeKind.Local).AddTicks(4367), "Kaci.Schuster@yahoo.com", "Allene", "Cole", "$2a$11$tdFcgI5S3Ytj/fTdqMxit.57y3rKjRGlM9JfCY5OSoHAugRqt.5zS" });

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
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 2, 21, 15, 4, 7, 358, DateTimeKind.Local).AddTicks(7620), "Britney.Kling99@gmail.com", "Russell", 2, "O'Reilly", "$2a$11$dhK2bIkNjGpNUDiTPwMFeeETnMfl2Y6QYSmi1OkKlvkfrcV3fMT1W" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 12, 14, 44, 43, 749, DateTimeKind.Local).AddTicks(8374), "Elsie4@yahoo.com", "Keshawn", 5, true, "Howe", "$2a$11$tLrOqkjgJcDJxh8/VFKbsezXgtKjd0.yYR94VD2Cf12nkdj.MGE/e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 6, 11, 6, 43, 791, DateTimeKind.Local).AddTicks(9627), "Keven45@gmail.com", "Nina", 6, 2, false, "Stark", "$2a$11$1uhTp9laDPH3KN9S7gSksOVcx7jYcwV0erU37S4oauaF3H2jMf7g." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 11, 26, 20, 39, 4, 14, DateTimeKind.Local).AddTicks(9693), "Guiseppe16@hotmail.com", "Cydney", 2, false, "Koss", "$2a$11$dYm9m.167icopcJE6ljOwu.INA4WRUih90Jk8.V//grg1nWE4XyMS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 10, 12, 1, 3, 51, 62, DateTimeKind.Local).AddTicks(3048), "Green38@hotmail.com", "Elza", 1, false, "Renner", "$2a$11$Bv8.VATjLe.uJ0w1bMi0pu2EW0CnOY92zPqYVewpin6BJf7ctiELO" });

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
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 2, 17, 17, 39, 57, 92, DateTimeKind.Local).AddTicks(4911), "Donnie.Trantow@hotmail.com", "Kelley", 2, false, "Gislason", "$2a$11$UC4T.CFTzVVb15CNoH1LSeZP82p3pdp9oHVaIPxSAnXoZjgAYxSYu" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2023, 3, 13, 6, 15, 51, 36, DateTimeKind.Local).AddTicks(8505), "wzcczhqrjk", 8, 259, 8654, "uszsltasid", "crqoskxeau", "hceipafion", 8, 1, 10.0, "vhcgldrawu" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2023, 1, 10, 14, 24, 7, 872, DateTimeKind.Local).AddTicks(2377), "gjobsxbksr", 10, 194, 6522, "bengztfahy", "wpqzsdjtce", "ztxuuhzjbu", 7, 4, 4.0, "fsqgcqnuio" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, false, new DateTime(2022, 8, 8, 7, 16, 38, 90, DateTimeKind.Local).AddTicks(333), "jfpkvylfzc", 6, 156, 5427, "kxdaeuqpxq", "pzqodhzriy", "cppjablvgn", 7, 8, 5.0, "chtdzxpcxf" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, false, new DateTime(2023, 3, 18, 18, 28, 9, 805, DateTimeKind.Local).AddTicks(3289), "qbxvijqyrv", 1, 62, 8697, "zcijryybsk", "izvaxtmvha", "cefncrfxnn", 2, 9, 9.0, "vwpjtgmqyw" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2023, 5, 3, 1, 35, 35, 695, DateTimeKind.Local).AddTicks(5050), "firjzeckti", 300, 3771, "ycdxdjdkik", "fnrhqnmize", "yavfecdgvr", 3, 1, 3.0, "niucxtixkz" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2022, 12, 17, 4, 13, 56, 131, DateTimeKind.Local).AddTicks(1238), "zoxnzyuzia", 9, 42, 2028, "ktxmvvfyhp", "bspjjyeuov", "bceqkxkxvb", 8, 1, 4.0, "judtbvibqv" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2023, 2, 16, 16, 21, 2, 363, DateTimeKind.Local).AddTicks(5722), "eqkbhwpnwj", 4, 152, 4462, "hygspsonpv", "eokkwyktus", "cirrcdilwr", 6, 7, 1.0, "keuicpwpac" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "Prix", "Type" },
                values: new object[] { false, new DateTime(2023, 1, 15, 0, 18, 43, 832, DateTimeKind.Local).AddTicks(3583), "hhkrmfgidd", 10, 100, 8909, "xxbnysfctg", "lzuinyzzbj", "yqqdbjuqzz", 4, 3.0, "nikqnrguqj" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2023, 6, 1, 8, 14, 39, 110, DateTimeKind.Local).AddTicks(5918), "dayyxlydnf", 5, 39, 8121, "lspffzykoj", "lizuvdpihu", "rvjupokluo", 8, 6, 8.0, "vaidmhcwxl" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2023, 7, 18, 17, 31, 10, 250, DateTimeKind.Local).AddTicks(8743), "tjcndwetfo", 8, 222, 1256, "zrbpyqgimm", "sodxbtbqhp", "mdvmvrofnl", 1, 5, 10.0, "utywtihbhe" });

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
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 10, 8, 3, 26, 11, 732, DateTimeKind.Local).AddTicks(1151), 126, "qgzhmouudc", "Reichel", "Deckow - Kutch", "Coleman", "1-965-723-4592 x533", "Terry", "Walterhaven", "81922-6679" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 3, 22, 3, 36, 40, 876, DateTimeKind.Local).AddTicks(6282), 43, "guawebtjgn", "Mitchell", 25, "Larson LLC", "Paige", "924-478-7202", "Jerde", "Batzborough", "56342-0349" });

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
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 5, 6, 18, 13, 37, 401, DateTimeKind.Local).AddTicks(7318), 206, "ctudvgbcpb", 23, "Bashirian, Schaden and Langworth", "Hans", "1-711-669-1980", "Marks", "East Serenity", "81693" });
        }
    }
}
