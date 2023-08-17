using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomotiveApi.Migrations
{
    /// <inheritdoc />
    public partial class logoagences : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Logo",
                table: "Agences",
                type: "longtext",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Logo", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "838 Juliet Glens", "Mayerbury", new DateTime(2023, 8, 10, 18, 55, 2, 331, DateTimeKind.Local).AddTicks(9044), "Brown9@gmail.com", 69.957400000000007, null, -73.581000000000003, "Investor Program Representative", "(337) 663-2905 x3249", "67504-7844" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Logo", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "720 Bashirian Mission", "South Esperanzahaven", new DateTime(2023, 5, 21, 14, 15, 2, 867, DateTimeKind.Local).AddTicks(2125), "Christine_Gerhold38@hotmail.com", -87.073499999999996, null, 129.82589999999999, "Investor Usability Analyst", "743-426-3197 x974", "82820-5222" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Logo", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "78176 Feest Summit", "East Jennie", new DateTime(2023, 2, 13, 12, 14, 22, 959, DateTimeKind.Local).AddTicks(457), "Jammie.Gibson71@yahoo.com", 69.613200000000006, null, 173.41810000000001, "International Applications Administrator", "1-738-629-3562 x152", "75650" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Logo", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "027 Jacquelyn Fords", "New Brannonberg", new DateTime(2023, 1, 12, 20, 57, 39, 857, DateTimeKind.Local).AddTicks(2513), "Audrey81@yahoo.com", -73.742900000000006, null, -50.222900000000003, "Dynamic Brand Director", "1-309-267-8073 x746", "23248" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Logo", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "058 Lubowitz Villages", "Port Andy", new DateTime(2023, 5, 5, 23, 4, 47, 194, DateTimeKind.Local).AddTicks(2392), "Raymundo.Hermiston@yahoo.com", -75.089100000000002, null, 173.52459999999999, "Global Identity Assistant", "1-862-273-9684", "36321" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Logo", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "1315 Fadel Parkways", "Kyleebury", new DateTime(2023, 3, 24, 9, 23, 28, 934, DateTimeKind.Local).AddTicks(3796), "Rubie49@yahoo.com", 26.295999999999999, null, 143.5872, "Forward Accounts Producer", "(632) 463-3148 x377", "80450" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Logo", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "415 Marquardt Ranch", "Hailieberg", new DateTime(2022, 8, 25, 10, 41, 30, 383, DateTimeKind.Local).AddTicks(371), "Chaim_Robel@yahoo.com", -66.7119, null, -148.1285, "Dynamic Implementation Administrator", "751.465.6212 x12053", "96547" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Logo", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "93134 Gibson Orchard", "South Leahaven", new DateTime(2023, 8, 1, 17, 44, 33, 781, DateTimeKind.Local).AddTicks(8593), "Mitchell84@yahoo.com", 79.666499999999999, null, 8.5662000000000003, "Dynamic Directives Architect", "537.649.9594", "49979-6640" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Logo", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "96715 Thompson Trace", "Sengerbury", new DateTime(2022, 10, 10, 14, 40, 45, 745, DateTimeKind.Local).AddTicks(8597), "Zakary.Ratke4@gmail.com", 63.116199999999999, null, 109.7533, "Dynamic Mobility Administrator", "1-698-433-1953", "88311" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Logo", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "446 Labadie Road", "East Sophiaport", new DateTime(2022, 10, 6, 12, 53, 11, 494, DateTimeKind.Local).AddTicks(4571), "Milton_Barton6@hotmail.com", -72.828599999999994, null, 150.46789999999999, "Future Accounts Assistant", "(535) 575-5514 x81504", "94571" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "493 Ebert Plains", "428 Tyrique Creek", new DateTime(2023, 7, 7, 19, 32, 19, 390, DateTimeKind.Local).AddTicks(3400), "Iliana54@gmail.com", "Laron", "Schuster", "https://picsum.photos/640/480/?image=848", "https://picsum.photos/640/480/?image=755", "(690) 232-1629 x411", "East Reymundotown", "99456" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "578 Kiana Keys", "6449 Windler Spring", new DateTime(2023, 5, 29, 19, 21, 21, 190, DateTimeKind.Local).AddTicks(9895), "Walker69@gmail.com", "Gaston", "Cremin", "https://picsum.photos/640/480/?image=607", "https://picsum.photos/640/480/?image=1047", "1-980-931-6378", "South Laney", "10169-3423" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "50482 Mylene Locks", "0047 Torp Trafficway", new DateTime(2023, 5, 26, 15, 13, 33, 706, DateTimeKind.Local).AddTicks(4529), "Nelle.Denesik@yahoo.com", "Rickey", "Hilll", "https://picsum.photos/640/480/?image=616", "https://picsum.photos/640/480/?image=379", "1-890-448-0521", "South Bailey", "44595-4138" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "01238 Brock Ferry", "1683 Dibbert Radial", new DateTime(2023, 1, 17, 15, 26, 42, 268, DateTimeKind.Local).AddTicks(8870), "Elmira.Littel25@yahoo.com", "Josephine", "Hilll", "https://picsum.photos/640/480/?image=933", "https://picsum.photos/640/480/?image=772", "456-609-4211 x37450", "Bashirianborough", "47506" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "93343 Effertz Brook", "793 Nedra Roads", new DateTime(2023, 1, 24, 4, 10, 53, 891, DateTimeKind.Local).AddTicks(6902), "Albin_Rogahn14@yahoo.com", "Garnet", "Luettgen", "https://picsum.photos/640/480/?image=302", "https://picsum.photos/640/480/?image=23", "(267) 230-2796 x266", "West Juliannetown", "56922-8893" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "75508 Cruickshank Burg", "88754 Quitzon Light", new DateTime(2022, 10, 18, 18, 32, 0, 426, DateTimeKind.Local).AddTicks(21), "Emie19@gmail.com", "Yolanda", "Boehm", "https://picsum.photos/640/480/?image=129", "https://picsum.photos/640/480/?image=200", "831.841.2572 x127", "New Floy", "92181-2225" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "28560 Dejah Stravenue", "894 Ewell Extension", new DateTime(2023, 1, 30, 9, 38, 37, 409, DateTimeKind.Local).AddTicks(8796), "Fanny.Rowe75@gmail.com", "Assunta", "Hauck", "https://picsum.photos/640/480/?image=594", "https://picsum.photos/640/480/?image=310", "486-609-2275 x04716", "Luellafurt", "77826" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "41036 Bradtke Lake", "9728 Anderson Harbors", new DateTime(2023, 2, 27, 2, 7, 59, 210, DateTimeKind.Local).AddTicks(8451), "Kaden.Dooley74@yahoo.com", "Betsy", "Pacocha", "https://picsum.photos/640/480/?image=807", "https://picsum.photos/640/480/?image=571", "1-417-306-5764 x414", "O'Haraborough", "36799" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "8404 Cristal Islands", "18599 Damien Summit", new DateTime(2023, 7, 5, 0, 35, 37, 504, DateTimeKind.Local).AddTicks(9312), "Arnulfo_Considine@gmail.com", "Lysanne", "Koepp", "https://picsum.photos/640/480/?image=443", "https://picsum.photos/640/480/?image=138", "746.571.0642 x753", "New Gavin", "79301" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "599 Kayleigh Way", "11230 Lueilwitz Summit", new DateTime(2022, 10, 24, 8, 27, 42, 880, DateTimeKind.Local).AddTicks(253), "Webster_Mueller88@gmail.com", "Janie", "Senger", "https://picsum.photos/640/480/?image=981", "https://picsum.photos/640/480/?image=1046", "570.467.2458", "Reichelland", "13512-2811" });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 1,
                column: "IdReservation",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 7, 2, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 10, 5 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 3, 10 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 10, 10 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 6, 6, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 8,
                column: "IdClient",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 6, 2 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 9, 9, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 17, 10, 0, 11, 623, DateTimeKind.Local).AddTicks(3217), new DateTime(2023, 8, 18, 0, 58, 5, 342, DateTimeKind.Local).AddTicks(6967), new DateTime(2024, 5, 5, 10, 25, 18, 87, DateTimeKind.Local).AddTicks(7815), 5, 2.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 17, 9, 7, 47, 500, DateTimeKind.Local).AddTicks(304), new DateTime(2023, 8, 17, 21, 41, 25, 940, DateTimeKind.Local).AddTicks(8807), new DateTime(2023, 12, 27, 0, 21, 50, 483, DateTimeKind.Local).AddTicks(4331), 4, 5.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 17, 6, 57, 23, 319, DateTimeKind.Local).AddTicks(8352), new DateTime(2023, 8, 18, 2, 58, 9, 257, DateTimeKind.Local).AddTicks(9860), new DateTime(2024, 1, 9, 8, 4, 57, 664, DateTimeKind.Local).AddTicks(762), 5, 5.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 17, 6, 35, 21, 309, DateTimeKind.Local).AddTicks(6326), new DateTime(2023, 8, 18, 8, 51, 56, 608, DateTimeKind.Local).AddTicks(5827), new DateTime(2024, 4, 6, 8, 21, 5, 995, DateTimeKind.Local).AddTicks(5573), 9, 2.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 17, 16, 43, 42, 823, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 8, 18, 9, 11, 3, 105, DateTimeKind.Local).AddTicks(4568), new DateTime(2024, 3, 14, 12, 36, 19, 788, DateTimeKind.Local).AddTicks(2086), 4, 8.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 17, 0, 17, 6, 956, DateTimeKind.Local).AddTicks(9988), new DateTime(2023, 8, 18, 16, 21, 48, 257, DateTimeKind.Local).AddTicks(3861), new DateTime(2023, 8, 19, 6, 3, 16, 688, DateTimeKind.Local).AddTicks(5562), 6, 1.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 17, 18, 13, 24, 369, DateTimeKind.Local).AddTicks(1334), new DateTime(2023, 8, 18, 14, 0, 38, 958, DateTimeKind.Local).AddTicks(231), new DateTime(2024, 2, 27, 16, 46, 12, 553, DateTimeKind.Local).AddTicks(9785), 3, 4.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 17, 2, 19, 15, 629, DateTimeKind.Local).AddTicks(4127), new DateTime(2023, 8, 17, 20, 54, 7, 152, DateTimeKind.Local).AddTicks(8862), new DateTime(2024, 2, 6, 18, 36, 47, 701, DateTimeKind.Local).AddTicks(6990), 8, 4.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 17, 7, 53, 38, 931, DateTimeKind.Local).AddTicks(8687), new DateTime(2023, 8, 18, 1, 7, 35, 766, DateTimeKind.Local).AddTicks(573), new DateTime(2023, 8, 22, 2, 18, 18, 511, DateTimeKind.Local).AddTicks(217), 3, 10.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 17, 1, 23, 9, 90, DateTimeKind.Local).AddTicks(6130), new DateTime(2023, 8, 18, 14, 53, 9, 375, DateTimeKind.Local).AddTicks(2986), new DateTime(2023, 9, 25, 1, 44, 42, 590, DateTimeKind.Local).AddTicks(6399), 9, 6.0, true });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 17, 10, 33, 35, 208, DateTimeKind.Local).AddTicks(5857), new DateTime(2023, 8, 17, 20, 57, 18, 761, DateTimeKind.Local).AddTicks(987), new DateTime(2024, 5, 12, 10, 42, 18, 821, DateTimeKind.Local).AddTicks(5), "d468f208-100a-4677-af6b-7ad55326590a", "Annulé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 16, 19, 31, 12, 800, DateTimeKind.Local).AddTicks(5900), new DateTime(2023, 8, 18, 5, 55, 57, 758, DateTimeKind.Local).AddTicks(2193), new DateTime(2024, 2, 21, 17, 16, 24, 658, DateTimeKind.Local).AddTicks(3654), 6, "cb3e4d6a-c6e5-4013-ab81-5aebe7c80c33", "Annulé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 17, 7, 49, 52, 11, DateTimeKind.Local).AddTicks(1186), new DateTime(2023, 8, 17, 22, 9, 11, 490, DateTimeKind.Local).AddTicks(3860), new DateTime(2023, 8, 22, 9, 12, 31, 947, DateTimeKind.Local).AddTicks(5840), 5, "bebbc68b-d1e3-4867-8baa-849ae8fce4b2", "Confirmé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 17, 9, 43, 18, 885, DateTimeKind.Local).AddTicks(1385), new DateTime(2023, 8, 18, 1, 40, 27, 598, DateTimeKind.Local).AddTicks(715), new DateTime(2023, 10, 1, 22, 55, 45, 727, DateTimeKind.Local).AddTicks(450), 10, "6426301e-b59f-43d0-a6d0-77f1f8868c7e", "Confirmé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 17, 17, 55, 12, 836, DateTimeKind.Local).AddTicks(4628), new DateTime(2023, 8, 17, 23, 59, 5, 636, DateTimeKind.Local).AddTicks(718), new DateTime(2023, 11, 27, 13, 26, 27, 422, DateTimeKind.Local).AddTicks(5460), 2, "cfc5721a-86e4-486f-bb03-e93be28c649e" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 17, 0, 32, 50, 623, DateTimeKind.Local).AddTicks(8336), new DateTime(2023, 8, 18, 15, 54, 6, 55, DateTimeKind.Local).AddTicks(3876), new DateTime(2024, 2, 4, 7, 54, 33, 613, DateTimeKind.Local).AddTicks(7316), 1, "cd551645-29ab-4621-bd65-b9c25ac91977", "Expiré" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 16, 19, 1, 36, 436, DateTimeKind.Local).AddTicks(3552), new DateTime(2023, 8, 18, 1, 31, 16, 113, DateTimeKind.Local).AddTicks(32), new DateTime(2024, 7, 27, 22, 10, 45, 728, DateTimeKind.Local).AddTicks(3744), 7, "af0a2c7e-2f07-4ca5-85dd-3ed0b95df03c", "Expiré" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 17, 6, 33, 54, 494, DateTimeKind.Local).AddTicks(6571), new DateTime(2023, 8, 18, 8, 33, 9, 705, DateTimeKind.Local).AddTicks(2197), new DateTime(2023, 12, 1, 11, 9, 51, 943, DateTimeKind.Local).AddTicks(8832), 4, "9f882de5-0ba7-4fcb-8876-2e321ef2f7eb", "Confirmé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 17, 3, 33, 20, 358, DateTimeKind.Local).AddTicks(3709), new DateTime(2023, 8, 18, 4, 29, 1, 706, DateTimeKind.Local).AddTicks(8462), new DateTime(2024, 3, 9, 21, 8, 34, 746, DateTimeKind.Local).AddTicks(5220), 5, "d7ef342f-1154-42c6-9171-0796d8e7c017", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 17, 15, 42, 41, 758, DateTimeKind.Local).AddTicks(2060), new DateTime(2023, 8, 18, 15, 8, 22, 552, DateTimeKind.Local).AddTicks(4012), new DateTime(2024, 6, 24, 2, 51, 51, 211, DateTimeKind.Local).AddTicks(1560), 8, "390647ba-7c24-4796-b652-2819f4375c00", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 20, 14, 45, 54, 25, DateTimeKind.Local).AddTicks(4216), "Providenci_Krajcik58@yahoo.com", "Angie", 5, 2, "Steuber", "$2a$11$CT7grVgCJB3NEeWF5jZMJe8XdWB9HLXplUd3Xk0kq6bk.XK2FLY6O" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 8, 5, 19, 41, 48, 862, DateTimeKind.Local).AddTicks(7237), "Freddy36@gmail.com", "Daphnee", 4, 1, "Prosacco", "$2a$11$h7lpZ7al6x6dor1BHGT.UuT/CsbtxqPMA55VKD2WTfXwSb.t8ESPS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 2, 26, 6, 28, 48, 590, DateTimeKind.Local).AddTicks(3213), "Maybell_Smitham69@hotmail.com", "Corrine", 8, false, "Murray", "$2a$11$.1xslCp6I/sALCLCwsEvGOiG02NG47yWYEnlFgub4cdh8Gq5kPpx6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 16, 58, 319, DateTimeKind.Local).AddTicks(673), "Layne.Kovacek41@hotmail.com", "Maddison", 4, 2, false, "Ondricka", "$2a$11$3M/FN5TcPEzgDVrzMJ1DOudtzW0orupDFSptCQ5A5VW58QKoHaLHK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 2, 11, 12, 10, 11, 919, DateTimeKind.Local).AddTicks(9808), "Kade.Morissette53@hotmail.com", "Elmore", 6, 1, "Langosh", "$2a$11$.88ivUO4yJFERlp9FMLCXOR43nRbd4RNJc3QmW9vyra3Lcym3bkHK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 10, 23, 3, 38, 955, DateTimeKind.Local).AddTicks(9071), "Queenie_Sawayn20@hotmail.com", "Sister", 6, 2, false, "Hirthe", "$2a$11$PYDTVZskyTzYHNp1CdswIuQWy5GvEqdMfjUhhUFeeptku/zcH4O.W" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 8, 15, 18, 24, 6, 311, DateTimeKind.Local).AddTicks(4321), "Halle2@yahoo.com", "Alverta", 3, 2, true, "Kub", "$2a$11$OLZBtsGh7EjHd6ret812QOrD4G3/ZEbSeuasxY6XFBPKgDG8zLIv2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 7, 26, 14, 58, 6, 644, DateTimeKind.Local).AddTicks(2132), "Darius63@hotmail.com", "Warren", 7, 2, "Hammes", "$2a$11$/8V6rCps4ODaBsUB0lbPxOD8y7qWpHkbvhNYCSYbkbo6X1bSLw31y" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 28, 10, 19, 42, 296, DateTimeKind.Local).AddTicks(7686), "Mortimer.Murazik53@gmail.com", "Angel", 6, 1, "Ondricka", "$2a$11$oCH57JMH3VU1oT4eAsb8XupLvzdJ9f7HcB2UFchKapVjzkcRwvc4G" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 52, 14, 901, DateTimeKind.Local).AddTicks(6217), "Vesta39@gmail.com", "Jimmy", 7, 1, true, "Heaney", "$2a$11$QYhORrpOqzDytGB1XjlUJeUdLlyuf30cmhAo1F6lRPfYL6bA9Dpzy" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2023, 1, 10, 11, 1, 22, 95, DateTimeKind.Local).AddTicks(3038), "kyvdzsdgvd", 8, 100, 9777, "bitgnbjren", "adyqktccxw", "iaujhprjiy", 9, 4.0, "rweugzlqzo" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2022, 9, 15, 22, 48, 3, 941, DateTimeKind.Local).AddTicks(5721), "kiuvferqqg", 5, 111, 290, "goxbpfdtoy", "bilahlgvqh", "wjeerqciab", 2, 7, 5.0, "gavlcrvljj" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2023, 6, 7, 1, 28, 13, 665, DateTimeKind.Local).AddTicks(2605), "fgoeooslpl", 9, 319, 3558, "lzwcmzxwvs", "rlucgmoiiy", "iabslmyaxu", 8, 1, 9.0, "keabsbscvz" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2023, 2, 8, 17, 1, 51, 788, DateTimeKind.Local).AddTicks(2127), "uyowshyhze", 1, 36, 4000, "rqqxundgap", "skeemxyskp", "cpsjwmowyo", 5, 6, 2.0, "bxyonuassk" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2023, 5, 21, 20, 44, 4, 224, DateTimeKind.Local).AddTicks(6536), "ctunutimjy", 18, 9494, "qnzbgptijn", "dkhmtksynx", "bbykwjpvyz", 7, 5, 6.0, "kqsayjxggj" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "Prix", "Type" },
                values: new object[] { true, new DateTime(2022, 10, 8, 20, 26, 59, 432, DateTimeKind.Local).AddTicks(7408), "bbddwfhbwc", 1, 235, 3681, "jpjkfplfep", "crmryevsxu", "wylgduvvzg", 10.0, "xpmatxwlxz" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2023, 4, 29, 7, 45, 20, 848, DateTimeKind.Local).AddTicks(8977), "erthpsmhdn", 4, 163, 7467, "ldigdfyifb", "olmjpukrbz", "covhcarubn", 8, 4.0, "hcjuuecjac" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Type" },
                values: new object[] { new DateTime(2022, 8, 26, 13, 23, 31, 892, DateTimeKind.Local).AddTicks(7278), "mbngkiiatz", 4, 38, 5653, "upugtcfwhh", "xcacjyijdx", "pgsuuxsjaq", 10, 5, "hnnxdfxfms" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, true, new DateTime(2023, 7, 19, 6, 40, 15, 882, DateTimeKind.Local).AddTicks(4291), "cxplgwqoqk", 9, 29, 3655, "qsgueruahv", "htllifcyvq", "alnqucapgp", 4, 3, 1.0, "sfoisateay" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2023, 4, 30, 23, 26, 20, 84, DateTimeKind.Local).AddTicks(8170), "utlrvtcvar", 6, 255, 3452, "qdfxsuykcw", "dgrzbxolcy", "yaildptnjy", 7, 9.0, "ywdqvyrgil" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 8, 18, 11, 59, 18, 570, DateTimeKind.Local).AddTicks(9036), 220, "oetlkoxpgy", "Kunze", 31, "Emmerich - Miller", "Tavares", "1-666-780-5343", "Little", "Keeblerstad", "53699" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 10, 16, 4, 36, 55, 273, DateTimeKind.Local).AddTicks(6122), 156, "bbcuhtgjnm", "Marvin", 25, "Mitchell - Terry", "Audrey", "1-978-807-2325 x20243", "Boyer", "West Gretchen", "27797" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 9, 27, 23, 26, 59, 406, DateTimeKind.Local).AddTicks(1204), 295, "tpftxzyoag", "O'Conner", 21, "Jacobson, Baumbach and Larkin", "Ronny", "852-702-0681 x2890", "Rutherford", "Foresthaven", "86711-1788" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 2, 2, 21, 58, 11, 402, DateTimeKind.Local).AddTicks(3035), 46, "ebfhcsbtuf", "Keebler", 20, "McDermott Group", "Alvera", "873.686.4535 x032", "Moen", "Port Carley", "67092" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 8, 28, 2, 45, 59, 760, DateTimeKind.Local).AddTicks(291), 171, "zfrtkzuhpd", "Treutel", 26, "Greenholt - Bruen", "Isabelle", "1-521-416-9744 x8633", "Sawayn", "Nicolasstad", "73632" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 11, 4, 1, 28, 4, 627, DateTimeKind.Local).AddTicks(6800), 203, "layjipfctn", "Wehner", 30, "Kessler - Kuhlman", "Dayana", "409.403.4380", "Boehm", "Padbergmouth", "93138-4759" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 7, 5, 10, 52, 53, 443, DateTimeKind.Local).AddTicks(8773), 41, "lremakqgpw", "Heaney", "Wilkinson, Murazik and White", "Fletcher", "752.687.6596", "Berge", "Michelebury", "56000" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 1, 17, 3, 59, 50, 698, DateTimeKind.Local).AddTicks(8261), 251, "ygqclgybns", "Kunze", 27, "Wilkinson Inc", "Kelvin", "1-347-388-4469", "Adams", "Raleighshire", "27288" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 10, 6, 11, 58, 18, 872, DateTimeKind.Local).AddTicks(1042), 15, "welpbtqjyu", "Rohan", 19, "Upton - Strosin", "Letitia", "(258) 751-8957 x0603", "Fahey", "Herzogborough", "04015-3595" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 3, 1, 11, 40, 22, 897, DateTimeKind.Local).AddTicks(9437), 5, "fovumklqlb", "Hammes", 18, "Beier - Conn", "Libby", "898.336.0976", "Hills", "Cassiechester", "94517-5481" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Logo",
                table: "Agences");

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "34513 Zulauf Fort", "East Carli", new DateTime(2023, 4, 22, 10, 16, 57, 720, DateTimeKind.Local).AddTicks(1639), "Lisette_Block@yahoo.com", 17.0655, 115.07559999999999, "Dynamic Optimization Administrator", "638-730-6229 x7661", "03871-1833" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "8494 Christine Path", "Schroederside", new DateTime(2023, 2, 11, 23, 37, 17, 579, DateTimeKind.Local).AddTicks(6038), "Davin_Kuvalis36@hotmail.com", -85.098600000000005, 31.055800000000001, "Investor Solutions Facilitator", "584.993.7931 x504", "60283" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "5084 Hettinger Trafficway", "Hahntown", new DateTime(2023, 7, 7, 6, 36, 36, 141, DateTimeKind.Local).AddTicks(2296), "Eula64@gmail.com", -44.425600000000003, -57.238500000000002, "District Response Agent", "410-436-9266 x74024", "29306-1615" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "78101 Jerde Motorway", "New Moises", new DateTime(2023, 6, 3, 14, 4, 52, 359, DateTimeKind.Local).AddTicks(4938), "Alba.Macejkovic89@gmail.com", -40.4816, 105.946, "Future Web Officer", "1-783-962-5673", "60589-9907" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "11801 Jasper Ranch", "Mrazmouth", new DateTime(2023, 2, 21, 1, 13, 33, 774, DateTimeKind.Local).AddTicks(5904), "Kenneth17@yahoo.com", -85.118799999999993, 15.3391, "National Solutions Architect", "(334) 706-4263", "58655-7801" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "50287 Schmeler Ford", "Arnoldside", new DateTime(2023, 1, 13, 17, 55, 55, 950, DateTimeKind.Local).AddTicks(9782), "Margarete2@hotmail.com", 44.585299999999997, -100.4208, "Lead Response Liaison", "(632) 369-8710", "35142" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "539 Brekke Avenue", "Boyerhaven", new DateTime(2022, 8, 30, 23, 5, 19, 778, DateTimeKind.Local).AddTicks(1449), "Daphnee_Koelpin@hotmail.com", -23.0853, -82.488500000000002, "Central Functionality Manager", "1-900-637-7143 x594", "13861" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "730 Halvorson Village", "Boydbury", new DateTime(2022, 11, 29, 11, 45, 38, 456, DateTimeKind.Local).AddTicks(7437), "Willy3@gmail.com", -45.244799999999998, 147.9426, "Senior Group Consultant", "730.428.9942 x2580", "33735-0100" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "71867 Schneider Highway", "North Wardshire", new DateTime(2023, 6, 1, 13, 4, 28, 685, DateTimeKind.Local).AddTicks(8430), "Joaquin_Beier@yahoo.com", 80.819500000000005, -136.8244, "Direct Solutions Architect", "734-888-0703", "14054" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "68112 Conn Turnpike", "New Alessandra", new DateTime(2023, 4, 14, 15, 8, 40, 289, DateTimeKind.Local).AddTicks(5946), "Micheal_Oberbrunner@yahoo.com", -6.6924999999999999, 100.5856, "Corporate Intranet Consultant", "981-425-2452", "86113" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "993 Emard Inlet", "14503 Hallie Isle", new DateTime(2022, 9, 13, 22, 6, 3, 999, DateTimeKind.Local).AddTicks(8632), "Jazmin88@gmail.com", "Javon", "Mann", "https://picsum.photos/640/480/?image=519", "https://picsum.photos/640/480/?image=185", "389-877-5473 x3954", "Krisshire", "94660" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "8857 Jarrell Mews", "958 Dylan Isle", new DateTime(2023, 2, 11, 4, 14, 55, 814, DateTimeKind.Local).AddTicks(2268), "Jerome.Schmidt@yahoo.com", "Travis", "Walter", "https://picsum.photos/640/480/?image=627", "https://picsum.photos/640/480/?image=78", "892.949.3019", "Marquisetown", "90412" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "4760 Zachary Terrace", "3957 Arthur Lodge", new DateTime(2023, 1, 19, 9, 49, 53, 45, DateTimeKind.Local).AddTicks(2442), "Kaleb.Denesik@gmail.com", "Marcia", "O'Conner", "https://picsum.photos/640/480/?image=570", "https://picsum.photos/640/480/?image=700", "1-624-799-8434", "New Mavisbury", "71949" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "3342 Heller Road", "066 Casandra Track", new DateTime(2023, 6, 10, 8, 0, 41, 100, DateTimeKind.Local).AddTicks(3175), "Destany88@hotmail.com", "Yoshiko", "Tremblay", "https://picsum.photos/640/480/?image=24", "https://picsum.photos/640/480/?image=770", "698-780-2659 x81260", "New Franco", "46235" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "85342 Alvah Gateway", "4945 Shaniya Ramp", new DateTime(2023, 1, 31, 4, 2, 27, 55, DateTimeKind.Local).AddTicks(7079), "Rudolph22@hotmail.com", "Gregoria", "Becker", "https://picsum.photos/640/480/?image=330", "https://picsum.photos/640/480/?image=611", "1-233-314-0694 x0278", "East Sheila", "55656-5209" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "85961 Borer Estates", "8776 Jeremie Lake", new DateTime(2022, 10, 16, 16, 51, 22, 531, DateTimeKind.Local).AddTicks(2652), "Nikki_Raynor@gmail.com", "Michele", "Kulas", "https://picsum.photos/640/480/?image=964", "https://picsum.photos/640/480/?image=514", "402-778-0818 x6420", "North Deangeloshire", "60648-9504" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "20958 Arch Island", "150 Jenkins Lodge", new DateTime(2022, 9, 19, 3, 11, 8, 993, DateTimeKind.Local).AddTicks(7203), "Dixie.Schuppe@gmail.com", "Ubaldo", "Waelchi", "https://picsum.photos/640/480/?image=639", "https://picsum.photos/640/480/?image=189", "958-291-6990 x6934", "Pollichmouth", "97610" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "67602 Willms Cliffs", "03206 Hassan Ferry", new DateTime(2022, 9, 27, 3, 16, 47, 194, DateTimeKind.Local).AddTicks(1450), "Rudy_Lehner33@yahoo.com", "Nasir", "Stamm", "https://picsum.photos/640/480/?image=541", "https://picsum.photos/640/480/?image=55", "670-366-5797 x988", "South Abigail", "51407" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "76422 Darrion Mission", "731 Adelle Radial", new DateTime(2023, 5, 3, 5, 12, 39, 734, DateTimeKind.Local).AddTicks(9762), "Bridget_Kunde92@gmail.com", "Russ", "Volkman", "https://picsum.photos/640/480/?image=803", "https://picsum.photos/640/480/?image=638", "820.427.2518 x978", "New Bradfordville", "61519" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "907 River Row", "47152 Jesus Canyon", new DateTime(2023, 1, 26, 17, 27, 38, 905, DateTimeKind.Local).AddTicks(3282), "Cora_Carter@gmail.com", "Shany", "Wuckert", "https://picsum.photos/640/480/?image=465", "https://picsum.photos/640/480/?image=377", "364-783-9652 x35827", "Beattyside", "82750-8608" });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 1,
                column: "IdReservation",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 8, 3, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 3, 6 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 6, 6 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 6, 5 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 4, 1, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 3, 8 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 8,
                column: "IdClient",
                value: 7);

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
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 2, 4, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 14, 5, 53, 56, 537, DateTimeKind.Local).AddTicks(7419), new DateTime(2023, 8, 15, 1, 30, 14, 632, DateTimeKind.Local).AddTicks(7794), new DateTime(2023, 8, 27, 16, 36, 28, 96, DateTimeKind.Local).AddTicks(852), 10, 4.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 14, 22, 38, 14, 876, DateTimeKind.Local).AddTicks(6709), new DateTime(2023, 8, 15, 12, 51, 13, 811, DateTimeKind.Local).AddTicks(1454), new DateTime(2024, 7, 6, 16, 46, 34, 552, DateTimeKind.Local).AddTicks(5120), 8, 9.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 14, 9, 41, 54, 283, DateTimeKind.Local).AddTicks(7385), new DateTime(2023, 8, 15, 12, 1, 49, 943, DateTimeKind.Local).AddTicks(7328), new DateTime(2024, 1, 15, 13, 22, 9, 821, DateTimeKind.Local).AddTicks(7961), 10, 6.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 14, 4, 23, 24, 144, DateTimeKind.Local).AddTicks(228), new DateTime(2023, 8, 15, 15, 32, 45, 446, DateTimeKind.Local).AddTicks(7908), new DateTime(2023, 11, 30, 21, 28, 42, 359, DateTimeKind.Local).AddTicks(1721), 3, 7.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 14, 16, 8, 49, 832, DateTimeKind.Local).AddTicks(3416), new DateTime(2023, 8, 15, 15, 6, 55, 11, DateTimeKind.Local).AddTicks(9370), new DateTime(2023, 9, 8, 19, 57, 18, 484, DateTimeKind.Local).AddTicks(1148), 6, 9.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 14, 9, 38, 16, 482, DateTimeKind.Local).AddTicks(1077), new DateTime(2023, 8, 15, 18, 3, 27, 553, DateTimeKind.Local).AddTicks(8816), new DateTime(2023, 12, 9, 1, 49, 6, 472, DateTimeKind.Local).AddTicks(9963), 4, 9.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 14, 9, 28, 50, 338, DateTimeKind.Local).AddTicks(7088), new DateTime(2023, 8, 15, 2, 10, 7, 992, DateTimeKind.Local).AddTicks(597), new DateTime(2023, 12, 28, 13, 23, 14, 836, DateTimeKind.Local).AddTicks(7081), 5, 3.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 14, 4, 45, 49, 143, DateTimeKind.Local).AddTicks(901), new DateTime(2023, 8, 15, 7, 42, 26, 305, DateTimeKind.Local).AddTicks(1118), new DateTime(2024, 6, 14, 2, 6, 10, 279, DateTimeKind.Local).AddTicks(4865), 7, 5.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 14, 3, 16, 53, 906, DateTimeKind.Local).AddTicks(1911), new DateTime(2023, 8, 16, 0, 3, 30, 230, DateTimeKind.Local).AddTicks(8421), new DateTime(2024, 6, 27, 16, 23, 43, 628, DateTimeKind.Local).AddTicks(5452), 8, 1.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 14, 8, 28, 50, 443, DateTimeKind.Local).AddTicks(912), new DateTime(2023, 8, 15, 3, 29, 43, 26, DateTimeKind.Local).AddTicks(9245), new DateTime(2024, 1, 25, 20, 43, 56, 408, DateTimeKind.Local).AddTicks(2461), 1, 8.0, false });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 14, 20, 0, 55, 175, DateTimeKind.Local).AddTicks(8776), new DateTime(2023, 8, 15, 14, 13, 26, 374, DateTimeKind.Local).AddTicks(8026), new DateTime(2023, 8, 15, 19, 48, 52, 683, DateTimeKind.Local).AddTicks(8007), "b6f792ac-5f68-4a5b-94a4-47e4abaa6cef", "Expiré" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 14, 20, 39, 21, 843, DateTimeKind.Local).AddTicks(7582), new DateTime(2023, 8, 15, 5, 13, 2, 105, DateTimeKind.Local).AddTicks(1487), new DateTime(2023, 10, 24, 17, 42, 4, 696, DateTimeKind.Local).AddTicks(9957), 10, "c3f2093b-44e4-4232-a4c0-eec843099b27", "Expiré" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 14, 3, 46, 42, 672, DateTimeKind.Local).AddTicks(6068), new DateTime(2023, 8, 15, 15, 26, 46, 962, DateTimeKind.Local).AddTicks(4567), new DateTime(2024, 5, 4, 4, 46, 36, 850, DateTimeKind.Local).AddTicks(2604), 8, "c74a1192-007e-45df-890b-b69ead1be066", "Annulé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 14, 13, 13, 6, 305, DateTimeKind.Local).AddTicks(8019), new DateTime(2023, 8, 15, 22, 8, 29, 805, DateTimeKind.Local).AddTicks(4686), new DateTime(2024, 5, 17, 19, 21, 23, 175, DateTimeKind.Local).AddTicks(5380), 5, "19f6b7d3-a167-4040-bb27-47a831ad0798", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 14, 16, 14, 10, 321, DateTimeKind.Local).AddTicks(3663), new DateTime(2023, 8, 15, 13, 0, 46, 509, DateTimeKind.Local).AddTicks(7589), new DateTime(2023, 9, 15, 6, 7, 5, 870, DateTimeKind.Local).AddTicks(7358), 8, "b7bd8035-9514-49ec-ac34-0d6b22f27a43" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 14, 7, 5, 37, 515, DateTimeKind.Local).AddTicks(1014), new DateTime(2023, 8, 15, 17, 31, 14, 538, DateTimeKind.Local).AddTicks(8377), new DateTime(2024, 5, 9, 6, 44, 38, 224, DateTimeKind.Local).AddTicks(2847), 4, "2ddaf3f2-37ba-44d0-baef-6e2a53c64105", "Annulé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 14, 17, 46, 33, 557, DateTimeKind.Local).AddTicks(299), new DateTime(2023, 8, 15, 7, 6, 52, 632, DateTimeKind.Local).AddTicks(5127), new DateTime(2024, 4, 4, 23, 57, 45, 857, DateTimeKind.Local).AddTicks(7432), 2, "cf593144-870c-4109-a46f-87e14309b405", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 14, 0, 49, 48, 846, DateTimeKind.Local).AddTicks(7434), new DateTime(2023, 8, 15, 13, 28, 7, 79, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 6, 28, 11, 47, 36, 631, DateTimeKind.Local).AddTicks(7193), 5, "590f586a-09d6-4b12-a95a-fe466a0444f5", "Expiré" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 15, 0, 5, 36, 832, DateTimeKind.Local).AddTicks(392), new DateTime(2023, 8, 15, 22, 2, 17, 152, DateTimeKind.Local).AddTicks(2610), new DateTime(2024, 6, 16, 22, 47, 30, 99, DateTimeKind.Local).AddTicks(2804), 2, "1fec2dd7-6278-421a-a943-f37a2a102787", "Confirmé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 14, 2, 29, 14, 432, DateTimeKind.Local).AddTicks(3527), new DateTime(2023, 8, 15, 12, 0, 5, 188, DateTimeKind.Local).AddTicks(1954), new DateTime(2023, 12, 25, 7, 16, 25, 519, DateTimeKind.Local).AddTicks(8344), 10, "7b6e712d-4a5f-4451-b100-2c2a0b6a7e64", "Annulé" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 10, 10, 1, 31, 53, 961, DateTimeKind.Local).AddTicks(9454), "Idella_Mante@hotmail.com", "Caroline", 10, 1, "Von", "$2a$11$ftWRfQxdZhoqv12KAfts5e0AvVlL.MnrQWeojKigAFO8Om4UpJsWK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 8, 6, 21, 56, 59, 249, DateTimeKind.Local).AddTicks(4231), "Elouise.Zboncak66@gmail.com", "Weston", 8, 2, "Hauck", "$2a$11$lu6oPCXa7nWj3Pu.yY2kc.g.FDqqQryzMRMQBY6495GPwuO/vEE.K" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 16, 12, 39, 33, 983, DateTimeKind.Local).AddTicks(3475), "Joshua63@yahoo.com", "Hailee", 2, true, "Runolfsdottir", "$2a$11$R8CfETf5YMu3LlR6KixMiONz.Efpadi5Vw4Kg3UTkfh5dLWkDtWOu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 12, 4, 35, 27, 601, DateTimeKind.Local).AddTicks(740), "Cyril37@gmail.com", "Kamren", 10, 1, true, "Johnston", "$2a$11$aKJ26k9rbpVdnmq6ocnPR.z9jsHgrFVQfyJvSQPkbULi3ryE66vpW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 18, 22, 51, 24, 240, DateTimeKind.Local).AddTicks(4403), "Laury.Hayes@hotmail.com", "Clare", 3, 2, "Rodriguez", "$2a$11$evtdofJZt5t24dOUDUMKpuUWX20jR7tOyRMqiHLcvRqFLiipYperO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 19, 17, 12, 54, 349, DateTimeKind.Local).AddTicks(415), "Annabelle_Schuster14@gmail.com", "Reid", 9, 1, true, "Wunsch", "$2a$11$BYKdcoGX6DFsYzq38C.hq.beSLYU5yYkmsjEYzirUWWo3hlOQQobK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 18, 17, 20, 34, 949, DateTimeKind.Local).AddTicks(4622), "Stephen.Jast@yahoo.com", "Dell", 2, 1, false, "Cormier", "$2a$11$egiy/MfFoG6.C7p45GZJsuM9pFWXAP91RLMaN7gpF6hcdJhORrIK6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 10, 18, 8, 29, 24, 388, DateTimeKind.Local).AddTicks(7515), "Guido20@hotmail.com", "Antwan", 10, 1, "Wiza", "$2a$11$OXegvqwR.6TXRzklYWdcn.ZXyf3ksU0V/BPTxZ5bkzeNyppFVPJ8W" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 7, 20, 7, 34, 4, 511, DateTimeKind.Local).AddTicks(9990), "Gina.Heller@yahoo.com", "Ethan", 4, 2, "Towne", "$2a$11$GJ.oMGRdqe5CkanrQQn9uuVBQ5ROWxFLw/de3Rf.nw1rWd6su9eaa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 6, 22, 9, 11, 374, DateTimeKind.Local).AddTicks(6879), "Laurianne40@hotmail.com", "Freeman", 10, 2, false, "Ankunding", "$2a$11$RlCmSaTI2OX9znCwTY9wUe.hKcfUohkl0/7Z3navMkGP2eK/0g3c." });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2023, 3, 7, 19, 58, 44, 12, DateTimeKind.Local).AddTicks(9208), "bkwfohryph", 10, 166, 3061, "dirbnaupqq", "hgmmkjgmdw", "vusxfghdzv", 7, 1.0, "gkeguvlseo" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2023, 4, 11, 1, 10, 45, 421, DateTimeKind.Local).AddTicks(3464), "ugrkbneeay", 9, 54, 9167, "gmvrbcndnt", "vjowusqofu", "ulmueszvlo", 1, 10, 9.0, "rslfvqygbv" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2022, 11, 28, 16, 7, 41, 985, DateTimeKind.Local).AddTicks(3714), "imnupqgblg", 1, 24, 6795, "cepcvqikbm", "aouzajuaar", "roqtujbmfi", 6, 3, 3.0, "udglmafbjj" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2023, 2, 5, 22, 3, 46, 156, DateTimeKind.Local).AddTicks(8544), "glroqdmnor", 6, 269, 4925, "qncivnkiez", "trlgzblxdt", "lnvheaqysn", 2, 10, 7.0, "sizcenqntq" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2022, 9, 23, 9, 50, 55, 988, DateTimeKind.Local).AddTicks(7713), "txagywcxte", 58, 8988, "wpmgmaoauh", "kwksrvckca", "bdmwpttvqk", 9, 7, 5.0, "dnjpnqjlfe" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "Prix", "Type" },
                values: new object[] { false, new DateTime(2022, 11, 14, 20, 7, 17, 682, DateTimeKind.Local).AddTicks(8125), "vdcmecsjgl", 5, 109, 5013, "slmccoxxma", "xpzebtmcdi", "tswemsapiv", 8.0, "txdgcfbhlk" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2023, 1, 17, 19, 39, 12, 645, DateTimeKind.Local).AddTicks(1004), "viqywxvjei", 1, 58, 515, "hgfbjrjqgz", "zyrkkhqwqz", "zpidscrcjk", 7, 2.0, "zjeftaypxj" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Type" },
                values: new object[] { new DateTime(2023, 5, 25, 21, 45, 31, 312, DateTimeKind.Local).AddTicks(2562), "sqtofzitvn", 3, 106, 3270, "yveeaffepa", "xwypmqyzxn", "pxdcgfdwhx", 9, 9, "sutwkqrrdw" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, false, new DateTime(2023, 6, 24, 3, 26, 10, 948, DateTimeKind.Local).AddTicks(6580), "hwgccudqao", 4, 6, 6775, "qvcmwpvynu", "atszwmobjb", "wephkeqeic", 6, 4, 3.0, "ekzkyhkpoe" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2022, 10, 19, 11, 57, 41, 626, DateTimeKind.Local).AddTicks(2747), "zgkimytryf", 5, 322, 5991, "cydwquyrkj", "lwakqentzc", "dfyqydgyse", 3, 4.0, "uzweyklnbp" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 5, 4, 16, 18, 36, 66, DateTimeKind.Local).AddTicks(3429), 154, "nxkuegkoaa", "Rau", 28, "Jakubowski - Schiller", "Cheyanne", "507-906-4863", "Will", "Friesenstad", "31425-8421" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 4, 16, 11, 18, 10, 106, DateTimeKind.Local).AddTicks(5864), 305, "vuzvoeyxvs", "Gerlach", 32, "Bruen Group", "Eddie", "654.221.7075 x4361", "Senger", "East Arturo", "57400" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 2, 19, 20, 25, 23, 495, DateTimeKind.Local).AddTicks(6503), 47, "tpmahrrhts", "Hayes", 20, "Hickle, Homenick and Russel", "Marjorie", "971-886-7224 x8034", "Hartmann", "Mayertchester", "74533" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 5, 12, 18, 9, 55, 123, DateTimeKind.Local).AddTicks(7504), 134, "vwgrfyjkqh", "Schimmel", 19, "Will - Kuhlman", "Emory", "612-346-1695", "Langosh", "North Schuyler", "51897" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 5, 20, 21, 52, 0, 645, DateTimeKind.Local).AddTicks(3504), 277, "ppmzbchzde", "Schumm", 20, "Schaden LLC", "Arno", "679-587-8854 x10731", "Hamill", "East Annettebury", "75622" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 5, 5, 14, 12, 47, 265, DateTimeKind.Local).AddTicks(2110), 240, "mxfdhbjtfs", "Keebler", 18, "Effertz - Lubowitz", "Norval", "(618) 481-2538", "Wolf", "East Danny", "16465" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 8, 16, 14, 29, 46, 607, DateTimeKind.Local).AddTicks(1669), 103, "yvdheswjff", "Dicki", "Conroy, Kuhn and Funk", "Hattie", "669-240-6295 x875", "Gerlach", "New Juwanfurt", "46259-3638" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 7, 3, 9, 27, 58, 751, DateTimeKind.Local).AddTicks(6274), 41, "hmvnywdvfj", "Greenfelder", 20, "McClure - Lind", "Wayne", "766-698-5897", "Ullrich", "Quigleyfort", "62330-2211" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 44, 38, 604, DateTimeKind.Local).AddTicks(7766), 68, "ugxokrlede", "Bailey", 25, "Wunsch and Sons", "Arvid", "(484) 250-3122", "Prosacco", "Haleyberg", "06463-2632" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 4, 15, 21, 12, 19, 393, DateTimeKind.Local).AddTicks(8253), 115, "epjmmctndb", "Ullrich", 19, "Langworth, Koepp and Zemlak", "Gino", "738-410-7676", "Collier", "Naderton", "28529-3562" });
        }
    }
}
