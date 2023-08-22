using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomotiveApi.Migrations
{
    /// <inheritdoc />
    public partial class add_montant_to_lld_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "MontantTotal",
                table: "long_term_rentals",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "2370 Samara Path", "Kovacekville", new DateTime(2022, 9, 16, 23, 8, 16, 207, DateTimeKind.Local).AddTicks(7139), "Breana57@hotmail.com", -67.302700000000002, -138.88659999999999, "Internal Data Coordinator", "399.479.2372 x364", "97702" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "45555 Marquise Islands", "North Diego", new DateTime(2022, 10, 6, 6, 20, 20, 856, DateTimeKind.Local).AddTicks(7733), "Geraldine_Lockman9@hotmail.com", 25.300899999999999, 121.621, "Future Data Producer", "1-633-385-9107 x972", "35542-6276" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "5696 Connie Fall", "Howemouth", new DateTime(2022, 10, 7, 20, 30, 40, 582, DateTimeKind.Local).AddTicks(6987), "Maybelle29@yahoo.com", -46.006599999999999, 139.36850000000001, "Regional Intranet Assistant", "289-244-6906", "49977" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "5591 Schulist Forge", "Lake Luz", new DateTime(2022, 11, 29, 1, 55, 18, 631, DateTimeKind.Local).AddTicks(4353), "Ronaldo_Wolf@hotmail.com", -13.9757, -100.5689, "National Paradigm Producer", "(958) 950-1433 x84113", "29472-3443" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "79963 Lueilwitz River", "Carterfurt", new DateTime(2022, 8, 30, 16, 59, 51, 79, DateTimeKind.Local).AddTicks(1700), "Gayle.Kuhlman@gmail.com", 17.657900000000001, -78.132400000000004, "Lead Branding Consultant", "956-596-0682 x504", "26808" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "716 Carolyne Ways", "North Elverahaven", new DateTime(2022, 12, 13, 23, 5, 40, 609, DateTimeKind.Local).AddTicks(6863), "Hilbert77@gmail.com", -70.916499999999999, -13.490399999999999, "Corporate Communications Administrator", "904.942.9694", "15819-8265" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "57816 Andre Pines", "Lake Aditya", new DateTime(2023, 4, 1, 21, 32, 15, 108, DateTimeKind.Local).AddTicks(4756), "Ebony_Emard30@yahoo.com", 71.241600000000005, 28.058199999999999, "Corporate Brand Manager", "(958) 242-8499 x5029", "66418-5033" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "926 Stacy Viaduct", "Kevinport", new DateTime(2022, 11, 20, 20, 51, 24, 45, DateTimeKind.Local).AddTicks(3519), "Megane.Bartoletti@yahoo.com", -75.512200000000007, -109.7852, "Forward Branding Liaison", "473-990-3932", "97596" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "997 Ella Squares", "Port Aidenberg", new DateTime(2023, 5, 12, 4, 17, 18, 652, DateTimeKind.Local).AddTicks(7147), "Brionna_Durgan43@gmail.com", 35.535800000000002, 53.645299999999999, "Legacy Quality Officer", "395.877.0659", "38497-8838" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "019 Rosie Isle", "West Lionel", new DateTime(2023, 4, 19, 4, 25, 41, 314, DateTimeKind.Local).AddTicks(352), "Cornelius_Gleichner@yahoo.com", -13.0268, 16.988600000000002, "Central Accounts Associate", "1-608-519-5271 x209", "33859-2191" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "0118 Weimann Parks", "030 Dorthy Loop", new DateTime(2022, 12, 31, 0, 37, 8, 29, DateTimeKind.Local).AddTicks(7531), "Lilly.Ruecker@yahoo.com", "Bartholome", "Mosciski", "https://picsum.photos/640/480/?image=1007", "https://picsum.photos/640/480/?image=996", "932-610-6050", "Lake Salvatore", "80715" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "9878 Brooks Drive", "924 Gaylord Cliffs", new DateTime(2023, 7, 17, 0, 54, 35, 222, DateTimeKind.Local).AddTicks(3468), "Andre49@hotmail.com", "Adolph", "Fay", "https://picsum.photos/640/480/?image=520", "https://picsum.photos/640/480/?image=911", "(386) 750-0975", "Andersonville", "62393" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "89311 Ritchie Rapid", "583 Considine Forge", new DateTime(2022, 12, 13, 8, 30, 8, 477, DateTimeKind.Local).AddTicks(4579), "Sheila.Wilderman62@hotmail.com", "Norberto", "Zieme", "https://picsum.photos/640/480/?image=699", "https://picsum.photos/640/480/?image=230", "(930) 724-3374 x3968", "O'Reillyside", "22369-1067" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "375 Robel Gateway", "415 Neil Mountains", new DateTime(2023, 2, 28, 14, 49, 29, 470, DateTimeKind.Local).AddTicks(2671), "Murphy_Harris@gmail.com", "Salma", "Treutel", "https://picsum.photos/640/480/?image=78", "https://picsum.photos/640/480/?image=860", "(909) 613-9385 x066", "Daytonport", "14126-8309" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "3369 Eric Well", "79999 Shields Squares", new DateTime(2022, 10, 27, 3, 56, 47, 689, DateTimeKind.Local).AddTicks(3089), "Hailey.Bernier@yahoo.com", "Manley", "Howe", "https://picsum.photos/640/480/?image=1004", "https://picsum.photos/640/480/?image=970", "791.248.7493 x49565", "East Arnoldofurt", "40550-5674" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "0164 Jayne Lodge", "14514 Schroeder Walks", new DateTime(2022, 12, 22, 12, 36, 53, 343, DateTimeKind.Local).AddTicks(8514), "Ebba.Padberg@hotmail.com", "Julia", "Kuhlman", "https://picsum.photos/640/480/?image=105", "https://picsum.photos/640/480/?image=259", "1-600-739-5674", "Zulaufburgh", "58227" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "42991 Nathen Valley", "09610 Altenwerth Lodge", new DateTime(2023, 7, 15, 14, 18, 21, 387, DateTimeKind.Local).AddTicks(8357), "Gennaro.Okuneva62@gmail.com", "Esteban", "Stehr", "https://picsum.photos/640/480/?image=516", "https://picsum.photos/640/480/?image=62", "1-484-571-3263 x217", "Retatown", "02880-4023" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "690 Ezekiel Valley", "1773 Flavie Dam", new DateTime(2023, 4, 25, 1, 59, 56, 942, DateTimeKind.Local).AddTicks(2965), "Rosalinda64@gmail.com", "Aimee", "Hamill", "https://picsum.photos/640/480/?image=235", "https://picsum.photos/640/480/?image=674", "714-283-4529 x50920", "North Conradton", "30797" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "8511 Koepp Groves", "292 Hermann Mountains", new DateTime(2022, 9, 3, 19, 7, 36, 80, DateTimeKind.Local).AddTicks(8720), "Buster.Weissnat@yahoo.com", "Joanie", "O'Reilly", "https://picsum.photos/640/480/?image=954", "https://picsum.photos/640/480/?image=22", "487-627-2593", "Isaiahfurt", "05122" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "09551 Enrico Place", "95519 Garland Estate", new DateTime(2023, 2, 26, 10, 22, 27, 621, DateTimeKind.Local).AddTicks(8369), "Jordy67@hotmail.com", "Edythe", "Senger", "https://picsum.photos/640/480/?image=111", "https://picsum.photos/640/480/?image=308", "1-988-228-8683 x4920", "New Ronberg", "76731" });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 8, 9 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 8, 10, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IdClient", "IsConducteur" },
                values: new object[] { 1, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 3, 2, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 9, 6, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 2, 6 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 6, 5 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 5, 8 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 10,
                column: "IdClient",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule" },
                values: new object[] { new DateTime(2023, 8, 21, 21, 39, 28, 610, DateTimeKind.Local).AddTicks(2725), new DateTime(2023, 8, 23, 5, 13, 58, 261, DateTimeKind.Local).AddTicks(8890), new DateTime(2024, 6, 22, 16, 20, 10, 466, DateTimeKind.Local).AddTicks(8053), 5 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 21, 13, 53, 21, 147, DateTimeKind.Local).AddTicks(7801), new DateTime(2023, 8, 23, 2, 36, 1, 799, DateTimeKind.Local).AddTicks(29), new DateTime(2023, 11, 26, 21, 26, 25, 796, DateTimeKind.Local).AddTicks(6858), 7.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 21, 14, 56, 58, 995, DateTimeKind.Local).AddTicks(7340), new DateTime(2023, 8, 22, 15, 5, 11, 703, DateTimeKind.Local).AddTicks(2926), new DateTime(2024, 1, 19, 16, 25, 23, 747, DateTimeKind.Local).AddTicks(8763), 4, 4.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 22, 2, 41, 3, 965, DateTimeKind.Local).AddTicks(9155), new DateTime(2023, 8, 22, 22, 56, 8, 592, DateTimeKind.Local).AddTicks(3903), new DateTime(2023, 12, 19, 12, 10, 17, 336, DateTimeKind.Local).AddTicks(5651), 8, 6.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule" },
                values: new object[] { new DateTime(2023, 8, 21, 20, 57, 38, 796, DateTimeKind.Local).AddTicks(3307), new DateTime(2023, 8, 23, 0, 56, 27, 630, DateTimeKind.Local).AddTicks(4595), new DateTime(2024, 3, 6, 14, 28, 22, 655, DateTimeKind.Local).AddTicks(7494), 5 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 21, 18, 53, 40, 947, DateTimeKind.Local).AddTicks(6545), new DateTime(2023, 8, 22, 21, 26, 33, 231, DateTimeKind.Local).AddTicks(2338), new DateTime(2023, 10, 1, 15, 37, 29, 62, DateTimeKind.Local).AddTicks(4032), 5, 9.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 21, 15, 52, 4, 35, DateTimeKind.Local).AddTicks(676), new DateTime(2023, 8, 22, 23, 30, 2, 768, DateTimeKind.Local).AddTicks(391), new DateTime(2024, 3, 22, 11, 46, 19, 290, DateTimeKind.Local).AddTicks(3772), 10, 8.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 21, 14, 26, 15, 159, DateTimeKind.Local).AddTicks(288), new DateTime(2023, 8, 23, 6, 40, 58, 132, DateTimeKind.Local).AddTicks(8702), new DateTime(2024, 6, 11, 16, 32, 43, 896, DateTimeKind.Local).AddTicks(7241), 3, 6.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "Prix" },
                values: new object[] { new DateTime(2023, 8, 21, 23, 29, 1, 135, DateTimeKind.Local).AddTicks(9965), new DateTime(2023, 8, 22, 22, 35, 33, 529, DateTimeKind.Local).AddTicks(9987), new DateTime(2024, 6, 4, 1, 40, 4, 43, DateTimeKind.Local).AddTicks(8574), 4.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 22, 0, 22, 6, 351, DateTimeKind.Local).AddTicks(8528), new DateTime(2023, 8, 23, 5, 7, 49, 346, DateTimeKind.Local).AddTicks(3694), new DateTime(2024, 2, 6, 14, 1, 32, 28, DateTimeKind.Local).AddTicks(2778), 2, 1.0 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 5, 29, 6, 273, DateTimeKind.Local).AddTicks(149), new DateTime(2023, 8, 22, 20, 52, 0, 274, DateTimeKind.Local).AddTicks(6060), new DateTime(2024, 5, 18, 11, 36, 36, 673, DateTimeKind.Local).AddTicks(9537), 10, "1d4dd72a-84c7-4a34-b67f-2b155e2b763d", "Annulé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 2, 19, 29, 672, DateTimeKind.Local).AddTicks(1971), new DateTime(2023, 8, 23, 1, 29, 21, 800, DateTimeKind.Local).AddTicks(6079), new DateTime(2024, 2, 15, 13, 18, 39, 839, DateTimeKind.Local).AddTicks(207), 2, "b059d72e-b91c-4f35-95e9-ae479a646e4d", "Confirmé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 21, 18, 12, 29, 669, DateTimeKind.Local).AddTicks(975), new DateTime(2023, 8, 22, 17, 46, 55, 284, DateTimeKind.Local).AddTicks(5777), new DateTime(2024, 1, 27, 14, 19, 3, 413, DateTimeKind.Local).AddTicks(848), 10, "31718131-19cf-4ec9-827f-af134117a343", "Expiré" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 21, 12, 58, 20, 730, DateTimeKind.Local).AddTicks(826), new DateTime(2023, 8, 23, 8, 26, 13, 558, DateTimeKind.Local).AddTicks(4826), new DateTime(2023, 10, 8, 9, 19, 27, 345, DateTimeKind.Local).AddTicks(6667), 1, "c009e699-5208-4202-bf37-a473ae243b3c", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 21, 14, 54, 25, 897, DateTimeKind.Local).AddTicks(4087), new DateTime(2023, 8, 23, 3, 2, 50, 324, DateTimeKind.Local).AddTicks(7349), new DateTime(2024, 1, 25, 19, 31, 25, 919, DateTimeKind.Local).AddTicks(7396), 7, "5025574f-3f39-4742-9975-159026742bd2", "Expiré" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 21, 20, 45, 1, 959, DateTimeKind.Local).AddTicks(6507), new DateTime(2023, 8, 23, 5, 58, 1, 665, DateTimeKind.Local).AddTicks(3829), new DateTime(2024, 3, 18, 16, 52, 32, 154, DateTimeKind.Local).AddTicks(968), 1, "15ff6da6-8c35-4024-834e-6b39254d4615" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 21, 19, 7, 28, 472, DateTimeKind.Local).AddTicks(7694), new DateTime(2023, 8, 22, 20, 41, 31, 402, DateTimeKind.Local).AddTicks(8363), new DateTime(2024, 6, 19, 8, 13, 33, 387, DateTimeKind.Local).AddTicks(4400), 8, "5e631e9d-b7db-4b55-be7c-0e7f2c4cc93f", "Annulé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 21, 15, 58, 44, 853, DateTimeKind.Local).AddTicks(3160), new DateTime(2023, 8, 23, 9, 43, 5, 214, DateTimeKind.Local).AddTicks(836), new DateTime(2024, 7, 6, 19, 12, 50, 217, DateTimeKind.Local).AddTicks(2528), 5, "d4351a42-aeb2-4ff4-8e86-b5d0dc97f439", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 11, 35, 48, 506, DateTimeKind.Local).AddTicks(9111), new DateTime(2023, 8, 22, 16, 33, 32, 249, DateTimeKind.Local).AddTicks(3264), new DateTime(2024, 3, 7, 18, 29, 15, 986, DateTimeKind.Local).AddTicks(9069), 5, "0b6c498f-8ac8-44fa-a0d8-c85d2042001d", "Confirmé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 5, 30, 40, 157, DateTimeKind.Local).AddTicks(9115), new DateTime(2023, 8, 22, 18, 13, 36, 757, DateTimeKind.Local).AddTicks(5340), new DateTime(2024, 3, 23, 19, 40, 12, 36, DateTimeKind.Local).AddTicks(1930), 4, "1dfb4ae9-3d7f-4a46-a1c5-444759edc360", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 8, 10, 24, 7, 680, DateTimeKind.Local).AddTicks(7796), "Thomas.Romaguera11@gmail.com", "Jonathan", 1, 2, "Botsford", "$2a$11$Ic0ulAtoNK5Y/TNkoX1PHOjdv.kZYpVt47qyOJcs2PPvB0gkpKNn." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 4, 7, 19, 20, 30, 980, DateTimeKind.Local).AddTicks(5673), "Abe_Predovic26@gmail.com", "Jefferey", 1, false, "Kulas", "$2a$11$UOcLShlNyW/qwho.rVyHF.46NoTK4H07ycMjyALKbpRc83goZz8Eu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 31, 11, 30, 11, 319, DateTimeKind.Local).AddTicks(983), "Johnson.Gleason4@hotmail.com", "Keshawn", 3, 1, false, "Bogan", "$2a$11$ld5d5b.BLxZbdEZxP1/GWenQJgnqbi.hcj9HX1DVm3k9MshTBKo7C" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 6, 6, 25, 47, 252, DateTimeKind.Local).AddTicks(3246), "Boris.Bruen@hotmail.com", "Theresa", 10, false, "Kozey", "$2a$11$3ATEF57ZgPwPHDS5AI20w.MIgUWlHacTMfku2yur3FrPz13GR91JK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 4, 27, 13, 35, 47, 677, DateTimeKind.Local).AddTicks(8445), "Connie_Goldner7@gmail.com", "Amara", 10, false, "Crist", "$2a$11$hFnedXtERNYHvINNF5EcZeDKublyHXk1bd/DhHuesr7EJTmTYftMm" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 11, 27, 4, 46, 50, 804, DateTimeKind.Local).AddTicks(1015), "Chelsie80@gmail.com", "Danielle", 1, false, "Lockman", "$2a$11$gJ.6kwuGeGlp34T/pi4X6.vbWTrWB7kOSZJXYQUbTxELP7/qlfidi" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 13, 9, 55, 41, 170, DateTimeKind.Local).AddTicks(2759), "Rachael_Brown2@gmail.com", "Malachi", 4, "Schaefer", "$2a$11$UGVAfCsdkQa/Z/jIk84uFeaGkpEBA7NrZij7uvI20OA3sS9hJodS2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 2, 10, 12, 56, 153, DateTimeKind.Local).AddTicks(870), "Bernadine.Volkman@yahoo.com", "Alanis", 5, false, "Schimmel", "$2a$11$XoAoYnHJfmyMBybWL5rQReSeksVss.Gvlr.y7NnGRYpFpj20SjKu." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 8, 5, 6, 49, 57, 136, DateTimeKind.Local).AddTicks(7390), "Braxton_Hirthe@gmail.com", "Antwan", 1, "Dibbert", "$2a$11$1wyeIXVIMOyA2I5ELmPCIeAM2d.y4PW6b.n4tlFh8WgS6yL/sUlH." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 8, 12, 3, 31, 5, 678, DateTimeKind.Local).AddTicks(3493), "Letha_Beier55@yahoo.com", "Clementina", 6, "Yost", "$2a$11$eVzmb2Y.0LQcLU4.YW7xCesn50./jBDy3Fk4HM1fQRjhYLDt5p3fS" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2023, 7, 9, 7, 38, 39, 552, DateTimeKind.Local).AddTicks(8784), "mlvcwmnclv", 9, 290, 5800, "mtswalwdbb", "xpdiwiavnm", "qmrkdmfowk", 3, 9, 2.0, "zmajqnpoey" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2022, 12, 29, 0, 41, 43, 391, DateTimeKind.Local).AddTicks(1325), "jfijitopei", 7, 67, 5830, "rtdrkpfgfh", "xgfveaggzc", "wzwnuvcpbe", 8, 1, 6.0, "iwggzcdmyo" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "Prix", "Type" },
                values: new object[] { new DateTime(2023, 8, 3, 3, 56, 35, 432, DateTimeKind.Local).AddTicks(4115), "njroygnjec", 55, 2999, "jauxrqtejv", "zubkwbiaue", "aracflcfff", 9, 2.0, "qtfwdjotra" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2023, 6, 26, 22, 25, 3, 14, DateTimeKind.Local).AddTicks(6659), "hacsexosmm", 7, 294, 1616, "kqblbeqdqf", "axuhgrfkoq", "lqjgxvkpal", 8, 7, 10.0, "lwzbsretak" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2023, 2, 14, 21, 36, 9, 557, DateTimeKind.Local).AddTicks(3549), "rjcjrawwgk", 9, 15, 4149, "pnavpycgud", "gitlhyjnhn", "xdinoibecy", 7, 3, 9.0, "ttylbsdpzk" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2023, 5, 14, 18, 12, 7, 60, DateTimeKind.Local).AddTicks(6603), "nyxwkzsvzw", 10, 213, 9566, "rynkdcuxog", "xqwwvdsjnu", "xcnrufvfyc", 2, 1, 8.0, "qdhgstcmdg" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2023, 1, 23, 18, 44, 41, 627, DateTimeKind.Local).AddTicks(554), "wnvltavzzw", 6, 224, 5904, "dgoxyksclo", "zgkknwsblx", "edqzxmpuaz", 10, 9, 5.0, "owzlfkpmoh" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2023, 4, 24, 18, 2, 51, 709, DateTimeKind.Local).AddTicks(2404), "dsikhbwkbn", 2, 309, 5226, "tcgkzjzgka", "bfkkzvhxiv", "sajhnmixfk", 1, 8, 8.0, "wocosmnjln" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2022, 11, 30, 0, 31, 58, 334, DateTimeKind.Local).AddTicks(4175), "gejnjltbmo", 6, 167, 3616, "hfkobedhrr", "smkotkoylu", "ptdwdkcgzz", 8, 6, 8.0, "eorgnhnvrq" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2023, 3, 10, 21, 47, 17, 891, DateTimeKind.Local).AddTicks(5994), "kwwtsoopyh", 4, 8, 5313, "nuussqcuno", "ogdcszpwea", "pquwlvnkou", 10, 1, 3.0, "liqbclzldo" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "MontantTotal", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 6, 13, 9, 43, 32, 22, DateTimeKind.Local).AddTicks(2112), "frluwtqilg", 225, 10.0, "oemjxlnwlu", "edmjhqhcsr", "Douglas", 18, "Jacobi Inc", "Bette", "(313) 517-9935", "Volkman", "North Brenna", "33046" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "MontantTotal", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 35, 18, 826, DateTimeKind.Local).AddTicks(6976), "whycgbgqmo", 287, 6.0, "lkhjlqkesq", "phgsbnrsrx", "Bode", 30, "Jerde - Mertz", "Jolie", "1-610-859-7787 x573", "Marvin", "Port Kennedybury", "61887" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "MontantTotal", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 5, 17, 20, 28, 17, 73, DateTimeKind.Local).AddTicks(8255), "ghvjvrvpwq", 7, 7.0, "vnndjkeuws", "lzymrxhrnn", "Pfeffer", 26, "D'Amore Group", "Alisha", "(941) 350-6583 x364", "Weissnat", "Buckstad", "77088-4546" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "MontantTotal", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 2, 27, 22, 4, 15, 60, DateTimeKind.Local).AddTicks(5050), "fanxmbxsza", 230, 7.0, "ofqcwinyuy", "znymbdtktn", "Leuschke", 18, "Torp Group", "Shaina", "1-973-371-7633 x1316", "Walker", "North Sadie", "81881" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "MontantTotal", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 5, 6, 14, 17, 14, 466, DateTimeKind.Local).AddTicks(9535), "agmqagtmoa", 16, 6.0, "kclgmjueyq", "lzolhouqgc", "Jakubowski", 33, "Aufderhar - Bednar", "Adriel", "482-718-1572", "Bayer", "New Maya", "61451-9560" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "MontantTotal", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 4, 13, 21, 47, 55, 399, DateTimeKind.Local).AddTicks(60), "hxidtwkmmd", 18, 9.0, "qykyxffzbl", "wasshogojj", "Lynch", 21, "Sawayn - Metz", "Yolanda", "(283) 762-7669 x6553", "Oberbrunner", "Leuschkeberg", "29568-5647" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "MontantTotal", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 5, 26, 14, 3, 55, 508, DateTimeKind.Local).AddTicks(9009), "jyjotxzubw", 92, 5.0, "bprzghzywe", "affksljbqy", "Altenwerth", 22, "Padberg - Cole", "Reed", "799-424-9207 x92841", "MacGyver", "Geovanymouth", "08470-7538" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "MontantTotal", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 9, 29, 22, 1, 27, 187, DateTimeKind.Local).AddTicks(123), "esrawsjumc", 232, 4.0, "cixhovkdtu", "wdcdlkxomv", "Rohan", 26, "Frami Inc", "Emmett", "(582) 949-5817", "Pagac", "Hintzville", "18020-7458" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "MontantTotal", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 5, 23, 2, 33, 13, 717, DateTimeKind.Local).AddTicks(7708), "uxpyzjihxx", 178, 10.0, "xnuerzximv", "senueyhaak", "Jakubowski", 28, "Kiehn - Gislason", "Erwin", "1-297-707-4734 x246", "Nader", "Barrowsland", "15216" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "MontantTotal", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 12, 29, 20, 58, 44, 599, DateTimeKind.Local).AddTicks(8134), "sfpgoloxgu", 195, 7.0, "hqccqnbspv", "yhquictdek", "McLaughlin", 28, "Lockman, Cruickshank and Treutel", "Ansley", "683-526-2852 x23707", "Ebert", "Littleside", "19349-4522" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MontantTotal",
                table: "long_term_rentals");

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "84178 Magnus Plain", "East Conorville", new DateTime(2022, 12, 8, 4, 19, 32, 356, DateTimeKind.Local).AddTicks(4082), "Shanny_Rolfson@gmail.com", -82.587599999999995, 21.827200000000001, "District Paradigm Planner", "340.746.4148", "23215" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "8603 Kovacek Via", "Jerroldburgh", new DateTime(2022, 9, 4, 8, 8, 23, 36, DateTimeKind.Local).AddTicks(8210), "Abigail_Wilkinson99@yahoo.com", -81.387600000000006, -15.501099999999999, "Regional Creative Manager", "656-905-6141 x3866", "80015" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "4105 Schiller Village", "Lake Rodger", new DateTime(2023, 2, 15, 22, 40, 49, 31, DateTimeKind.Local).AddTicks(7240), "Fred.Monahan@gmail.com", -76.161500000000004, 49.553600000000003, "Direct Program Officer", "743.627.3167 x2810", "40575" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "436 Deven Place", "New Virginiehaven", new DateTime(2022, 10, 20, 12, 49, 56, 372, DateTimeKind.Local).AddTicks(2293), "Skye_Hessel67@yahoo.com", 57.512, 34.724899999999998, "District Group Consultant", "1-608-578-6121", "19095-9854" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "938 Scot Coves", "North Gerardoborough", new DateTime(2023, 2, 12, 1, 59, 8, 249, DateTimeKind.Local).AddTicks(2785), "Abbey_Koepp@yahoo.com", 57.489899999999999, -65.064599999999999, "Dynamic Infrastructure Representative", "(940) 257-6895 x463", "07330-4793" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "6658 Effertz Trail", "Schmelerchester", new DateTime(2023, 2, 3, 21, 14, 50, 972, DateTimeKind.Local).AddTicks(7847), "Geoffrey_Parisian@yahoo.com", -71.497799999999998, -161.3597, "Product Infrastructure Representative", "1-428-564-5951 x60846", "95855" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "097 Wuckert Mountain", "East Armandbury", new DateTime(2023, 6, 14, 7, 30, 32, 109, DateTimeKind.Local).AddTicks(5173), "Frederic.Kozey@gmail.com", -41.2502, -88.579800000000006, "Chief Research Producer", "(334) 319-7199 x042", "14086" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "63293 Renner Forest", "Rohanhaven", new DateTime(2023, 4, 25, 21, 37, 15, 701, DateTimeKind.Local).AddTicks(2551), "Casandra.Christiansen@hotmail.com", -61.646099999999997, 94.253399999999999, "Dynamic Usability Associate", "484-322-7121 x7459", "25510-1955" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "6791 Vance Parkways", "Karsonfurt", new DateTime(2023, 6, 14, 20, 9, 37, 67, DateTimeKind.Local).AddTicks(7356), "Jamey20@yahoo.com", 26.567599999999999, -74.738500000000002, "Corporate Implementation Architect", "(248) 631-5315", "70764" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "641 Marquardt Junction", "Dellmouth", new DateTime(2023, 2, 11, 14, 22, 10, 478, DateTimeKind.Local).AddTicks(8841), "Lucious_Hermiston73@gmail.com", -49.232999999999997, -140.5779, "Legacy Applications Planner", "(628) 798-3149", "74162" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "147 Dach Mission", "09879 Kessler Roads", new DateTime(2023, 7, 5, 1, 32, 58, 332, DateTimeKind.Local).AddTicks(5877), "Briana22@gmail.com", "Mozell", "Hoppe", "https://picsum.photos/640/480/?image=1005", "https://picsum.photos/640/480/?image=377", "(803) 650-6788", "Jedediahmouth", "83968-2367" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "5792 Gene Stravenue", "8339 Gaylord Mountain", new DateTime(2023, 1, 30, 4, 27, 12, 299, DateTimeKind.Local).AddTicks(8176), "Odessa47@hotmail.com", "Adelbert", "Kuhn", "https://picsum.photos/640/480/?image=936", "https://picsum.photos/640/480/?image=854", "1-828-494-2663 x805", "Grahamshire", "86490" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "661 Duncan Knolls", "01628 Waino Loop", new DateTime(2023, 1, 6, 2, 7, 46, 33, DateTimeKind.Local).AddTicks(2042), "Austin.Conn51@yahoo.com", "Sigmund", "Morar", "https://picsum.photos/640/480/?image=748", "https://picsum.photos/640/480/?image=520", "525-432-0393 x33633", "Rileychester", "41245-8146" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "293 Becker Drive", "69818 Kshlerin Bypass", new DateTime(2022, 10, 15, 21, 20, 56, 113, DateTimeKind.Local).AddTicks(9666), "Buster37@gmail.com", "Clint", "Ledner", "https://picsum.photos/640/480/?image=57", "https://picsum.photos/640/480/?image=589", "734-801-5716", "North Isaiberg", "71845-6372" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "349 Balistreri Curve", "832 Kurt Centers", new DateTime(2023, 4, 9, 13, 54, 20, 13, DateTimeKind.Local).AddTicks(2292), "Jazlyn.Herman@yahoo.com", "Opal", "Ferry", "https://picsum.photos/640/480/?image=38", "https://picsum.photos/640/480/?image=642", "646.398.4067", "Rethaport", "30234" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "451 Hoyt Squares", "62848 Clinton Cape", new DateTime(2022, 8, 28, 17, 18, 33, 541, DateTimeKind.Local).AddTicks(4756), "Ashleigh62@yahoo.com", "Ernie", "Cole", "https://picsum.photos/640/480/?image=1069", "https://picsum.photos/640/480/?image=574", "253-638-6745 x8453", "Veronafort", "60807" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "5779 Bins Villages", "949 Valentina Mews", new DateTime(2023, 5, 6, 15, 21, 13, 985, DateTimeKind.Local).AddTicks(2573), "Chanel_Hessel54@yahoo.com", "Helene", "Fadel", "https://picsum.photos/640/480/?image=900", "https://picsum.photos/640/480/?image=616", "738-753-5532 x142", "Yeseniaborough", "69623" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "72752 Cartwright Rue", "53027 Erdman Rest", new DateTime(2023, 5, 12, 17, 50, 1, 774, DateTimeKind.Local).AddTicks(5061), "Keven.Cartwright46@gmail.com", "Autumn", "Walker", "https://picsum.photos/640/480/?image=220", "https://picsum.photos/640/480/?image=756", "345.261.7376 x6602", "Lake Margiemouth", "34181-3883" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "15357 Kling Stream", "31205 Franecki Brook", new DateTime(2023, 4, 29, 20, 21, 16, 909, DateTimeKind.Local).AddTicks(3246), "Estell54@yahoo.com", "Zackary", "Herzog", "https://picsum.photos/640/480/?image=744", "https://picsum.photos/640/480/?image=1019", "(558) 885-5185", "Natashashire", "27619" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "1125 Alessandra Orchard", "23082 Kennedy Freeway", new DateTime(2023, 6, 25, 12, 14, 1, 820, DateTimeKind.Local).AddTicks(305), "Bulah14@yahoo.com", "Queen", "Mitchell", "https://picsum.photos/640/480/?image=812", "https://picsum.photos/640/480/?image=454", "837-454-9610", "Beckerland", "28110-3881" });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 6, 5 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 1, 4, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IdClient", "IsConducteur" },
                values: new object[] { 10, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 2, 8, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 4, 7, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 8, 2 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 4, 10 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 2, 6 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 6, 6 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 10,
                column: "IdClient",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule" },
                values: new object[] { new DateTime(2023, 8, 21, 1, 25, 27, 324, DateTimeKind.Local).AddTicks(111), new DateTime(2023, 8, 22, 4, 9, 55, 745, DateTimeKind.Local).AddTicks(4758), new DateTime(2023, 12, 23, 11, 55, 35, 971, DateTimeKind.Local).AddTicks(7042), 3 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 20, 21, 20, 40, 151, DateTimeKind.Local).AddTicks(1439), new DateTime(2023, 8, 22, 6, 9, 54, 298, DateTimeKind.Local).AddTicks(4882), new DateTime(2023, 10, 17, 6, 59, 41, 751, DateTimeKind.Local).AddTicks(6026), 9.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 20, 22, 46, 6, 65, DateTimeKind.Local).AddTicks(9098), new DateTime(2023, 8, 22, 17, 19, 24, 769, DateTimeKind.Local).AddTicks(9937), new DateTime(2024, 5, 20, 21, 1, 12, 735, DateTimeKind.Local).AddTicks(588), 8, 9.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 21, 17, 34, 28, 508, DateTimeKind.Local).AddTicks(3145), new DateTime(2023, 8, 22, 16, 38, 3, 852, DateTimeKind.Local).AddTicks(4271), new DateTime(2024, 6, 15, 3, 19, 4, 670, DateTimeKind.Local).AddTicks(1186), 6, 10.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule" },
                values: new object[] { new DateTime(2023, 8, 21, 6, 32, 57, 989, DateTimeKind.Local).AddTicks(5273), new DateTime(2023, 8, 22, 11, 22, 13, 114, DateTimeKind.Local).AddTicks(3530), new DateTime(2024, 7, 26, 10, 10, 13, 433, DateTimeKind.Local).AddTicks(7431), 4 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 20, 22, 26, 16, 570, DateTimeKind.Local).AddTicks(2425), new DateTime(2023, 8, 22, 4, 15, 24, 798, DateTimeKind.Local).AddTicks(1847), new DateTime(2024, 2, 27, 3, 22, 4, 476, DateTimeKind.Local).AddTicks(1707), 2, 10.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 21, 19, 57, 42, 579, DateTimeKind.Local).AddTicks(7354), new DateTime(2023, 8, 21, 23, 51, 18, 795, DateTimeKind.Local).AddTicks(226), new DateTime(2024, 2, 5, 13, 13, 33, 512, DateTimeKind.Local).AddTicks(3422), 8, 2.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 21, 0, 25, 14, 928, DateTimeKind.Local).AddTicks(9550), new DateTime(2023, 8, 22, 13, 24, 39, 732, DateTimeKind.Local).AddTicks(3152), new DateTime(2023, 11, 15, 16, 25, 10, 529, DateTimeKind.Local).AddTicks(7737), 5, 5.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "Prix" },
                values: new object[] { new DateTime(2023, 8, 21, 16, 31, 55, 937, DateTimeKind.Local).AddTicks(3225), new DateTime(2023, 8, 22, 17, 34, 14, 752, DateTimeKind.Local).AddTicks(1745), new DateTime(2024, 1, 15, 4, 18, 40, 380, DateTimeKind.Local).AddTicks(4249), 1.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 21, 20, 52, 24, 3, DateTimeKind.Local).AddTicks(9744), new DateTime(2023, 8, 22, 11, 13, 12, 475, DateTimeKind.Local).AddTicks(7292), new DateTime(2024, 7, 29, 3, 46, 39, 73, DateTimeKind.Local).AddTicks(2574), 6, 4.0 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 21, 5, 27, 15, 327, DateTimeKind.Local).AddTicks(7272), new DateTime(2023, 8, 22, 14, 34, 9, 422, DateTimeKind.Local).AddTicks(9441), new DateTime(2024, 8, 4, 1, 50, 3, 218, DateTimeKind.Local).AddTicks(8632), 2, "00fd1c0d-d751-4ee7-a3ee-a24252d18197", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 21, 8, 10, 4, 546, DateTimeKind.Local).AddTicks(5092), new DateTime(2023, 8, 22, 4, 8, 13, 52, DateTimeKind.Local).AddTicks(6330), new DateTime(2023, 11, 10, 20, 29, 16, 473, DateTimeKind.Local).AddTicks(3238), 10, "c422b648-90bb-419d-8693-15f0631848a1", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 21, 20, 50, 37, 990, DateTimeKind.Local).AddTicks(9960), new DateTime(2023, 8, 22, 0, 32, 24, 982, DateTimeKind.Local).AddTicks(5301), new DateTime(2024, 8, 11, 11, 56, 36, 824, DateTimeKind.Local).AddTicks(4461), 7, "2d5d0a0d-921c-41a3-b26b-2a0dd84027c7", "Annulé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 21, 10, 14, 13, 46, DateTimeKind.Local).AddTicks(380), new DateTime(2023, 8, 22, 4, 7, 33, 656, DateTimeKind.Local).AddTicks(1187), new DateTime(2024, 7, 14, 16, 3, 58, 34, DateTimeKind.Local).AddTicks(9003), 10, "dc426d9d-8a9e-4b00-b2b3-ee3f93d6c2b6", "Confirmé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 21, 9, 58, 32, 588, DateTimeKind.Local).AddTicks(4004), new DateTime(2023, 8, 22, 3, 32, 17, 83, DateTimeKind.Local).AddTicks(7411), new DateTime(2023, 9, 10, 1, 37, 38, 912, DateTimeKind.Local).AddTicks(2552), 8, "f5ba7427-bfbd-4943-b8d0-2064067e4d7b", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 21, 12, 11, 56, 438, DateTimeKind.Local).AddTicks(833), new DateTime(2023, 8, 22, 7, 7, 50, 960, DateTimeKind.Local).AddTicks(1687), new DateTime(2023, 12, 3, 0, 0, 43, 909, DateTimeKind.Local).AddTicks(3779), 4, "35f20257-df42-4d5a-84ea-2c473c81b32a" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 21, 0, 20, 35, 822, DateTimeKind.Local).AddTicks(5039), new DateTime(2023, 8, 22, 7, 37, 35, 898, DateTimeKind.Local).AddTicks(1104), new DateTime(2024, 1, 27, 14, 13, 30, 59, DateTimeKind.Local).AddTicks(7189), 4, "9d6b4be6-4ef5-4daf-8e3e-642867ea7837", "Confirmé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 20, 22, 50, 18, 958, DateTimeKind.Local).AddTicks(44), new DateTime(2023, 8, 22, 9, 28, 11, 829, DateTimeKind.Local).AddTicks(731), new DateTime(2024, 2, 20, 0, 33, 5, 692, DateTimeKind.Local).AddTicks(1031), 10, "cba67f68-3ad5-4d88-b077-bc6131ab6b1c", "Confirmé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 21, 16, 53, 27, 930, DateTimeKind.Local).AddTicks(8136), new DateTime(2023, 8, 22, 7, 14, 10, 322, DateTimeKind.Local).AddTicks(2819), new DateTime(2023, 10, 20, 5, 20, 45, 768, DateTimeKind.Local).AddTicks(1916), 3, "a1ef0b8d-334e-4800-be3b-abb708634a6a", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 21, 19, 40, 50, 539, DateTimeKind.Local).AddTicks(322), new DateTime(2023, 8, 22, 14, 4, 41, 835, DateTimeKind.Local).AddTicks(1937), new DateTime(2023, 9, 12, 20, 9, 10, 896, DateTimeKind.Local).AddTicks(2392), 9, "6f76a8c1-f37c-424e-a31e-060281180d33", "Confirmé" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 22, 16, 37, 47, 529, DateTimeKind.Local).AddTicks(8082), "Rashad_Effertz6@yahoo.com", "Bradford", 3, 1, "Lindgren", "$2a$11$p2YFOenohCjckl45QSCmOOYFw4HHMWCWu/.gKCNv8BtAFNopi/zmq" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 8, 2, 10, 48, 20, 814, DateTimeKind.Local).AddTicks(5003), "Carlos_OReilly96@hotmail.com", "Francesco", 2, true, "Gislason", "$2a$11$qw3v1n/WLT6T53nKAcw.i.qm.FfUWKTfU7Iq.pumIoT3KOEuwc9Am" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 6, 11, 5, 41, 874, DateTimeKind.Local).AddTicks(7631), "Destany52@gmail.com", "Dane", 8, 2, true, "Schamberger", "$2a$11$ACyqkWV5yjzfj01hstKjEekPPOk7q.wulLMIsiRunZXGZhGaJWBYW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 6, 10, 54, 50, 87, DateTimeKind.Local).AddTicks(1267), "Orville_Dicki@hotmail.com", "Braden", 4, true, "VonRueden", "$2a$11$I11zTODW7pVVLcRZL3Lce.0PYUgErBEYEL2.laF2/VCc./Ww/1ri2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 24, 23, 34, 8, 918, DateTimeKind.Local).AddTicks(7879), "Manuel_Jones@yahoo.com", "Verner", 5, true, "Pfannerstill", "$2a$11$NU9dItNduEESZ1Pil6mxGeyGWbm0cFXEDuyDypit6BccUq8B2aiOa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 22, 16, 37, 11, 700, DateTimeKind.Local).AddTicks(2538), "Mack_Graham@gmail.com", "Juanita", 6, true, "Luettgen", "$2a$11$T0ex3g/.vlHyVMtJQUjFgeQWN.vjSAOxoorVkwebLXWcjms0yBDj2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 3, 12, 33, 11, 457, DateTimeKind.Local).AddTicks(4994), "Alysa_Russel@gmail.com", "Marta", 7, "Moen", "$2a$11$UloaMCmQIj4LUWONJWc8cOYGU/af23r1cEmvnBz/8EmDv/Bd7CBOu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 11, 18, 10, 32, 7, 792, DateTimeKind.Local).AddTicks(530), "Betty.Walsh@gmail.com", "Josefina", 8, true, "Crona", "$2a$11$i/xBzaJEnT9i3msNEsSlDOgDzd2X4IeUCoveD.zIMn3kdv3t9AInC" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 11, 11, 17, 14, 46, 535, DateTimeKind.Local).AddTicks(2998), "Muriel_Kuhn32@gmail.com", "Gordon", 2, "Schiller", "$2a$11$IYnQ4dqZBF/tJ/UOSkVNZeCB7BrHGZG3AIARKf87WnlRO5rdlOa1O" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 10, 5, 17, 16, 45, 310, DateTimeKind.Local).AddTicks(9564), "Anne_Harris@hotmail.com", "Arthur", 1, "VonRueden", "$2a$11$WjK5IK6dJ4lBA1IVFs81D.5pjdJDSqtAXYLu9sSlMZednSKtjMM9q" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2022, 8, 29, 19, 57, 27, 194, DateTimeKind.Local).AddTicks(9294), "cnpwxoktxd", 3, 130, 1429, "dvnwxnikfn", "jetuigoofu", "egzibxexjy", 10, 5, 7.0, "doqxrysycr" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2023, 3, 11, 9, 3, 34, 531, DateTimeKind.Local).AddTicks(6016), "fxqfdxtacl", 5, 70, 6859, "phmvwqtktl", "yswirsokmg", "ghbajvvwqf", 10, 2, 9.0, "ngfdiyjxvf" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "Prix", "Type" },
                values: new object[] { new DateTime(2022, 12, 26, 22, 19, 7, 234, DateTimeKind.Local).AddTicks(9282), "nkrozjuhea", 125, 6988, "rtdfjedmaq", "fsuxzhgjjg", "oeayogrkcg", 5, 4.0, "rsabmzyuny" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2022, 9, 9, 12, 46, 25, 67, DateTimeKind.Local).AddTicks(5615), "ucfnhjrvfu", 9, 147, 2410, "voxoeartck", "zvxdqlmuds", "ijctcumine", 5, 4, 8.0, "thpwapwbok" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2023, 3, 23, 13, 8, 5, 935, DateTimeKind.Local).AddTicks(421), "afmbholonx", 3, 324, 690, "xbfcjrxxqn", "nfpgpxyqps", "zyzpvvxexv", 8, 7, 10.0, "zbvxfwalnk" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2022, 11, 20, 0, 1, 1, 681, DateTimeKind.Local).AddTicks(3788), "isascudhdx", 6, 317, 3588, "kuhkpknpkx", "lubkakktxu", "kirjoiroau", 3, 5, 1.0, "uekuckmtbm" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2023, 1, 10, 18, 47, 3, 342, DateTimeKind.Local).AddTicks(9236), "plekhdlwis", 1, 233, 4613, "rdtwowxqbb", "pkichczfjv", "aueposapyc", 8, 2, 6.0, "yyfiarfade" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2023, 7, 15, 8, 59, 19, 844, DateTimeKind.Local).AddTicks(1975), "fuyldknbma", 8, 130, 1948, "pcrtwuawep", "dlxdulmkfj", "hsdpjwmwvb", 9, 10, 2.0, "vgzgfnsedg" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2022, 10, 13, 20, 35, 49, 82, DateTimeKind.Local).AddTicks(106), "jhjsgpxagv", 5, 98, 12, "yzcvnwbnrw", "pweaeqtvcv", "mukyxxoeji", 2, 3, 4.0, "ljiuxopubc" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2023, 3, 5, 21, 51, 29, 259, DateTimeKind.Local).AddTicks(7044), "xbasofqsdu", 9, 245, 8665, "hodapvbrso", "yyicqrhcqd", "rgwgigyjaw", 7, 5, 9.0, "qdbfvfgmaj" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 2, 14, 16, 47, 0, 618, DateTimeKind.Local).AddTicks(3013), "tpxyesdstq", 259, "ajekamrgsv", "njrkrwmula", "Stiedemann", 29, "Wisoky, Johnston and Feil", "Emil", "897-371-9714", "Murray", "West Alfordmouth", "11779" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 2, 26, 3, 28, 56, 858, DateTimeKind.Local).AddTicks(4072), "arnntkdqsf", 166, "psikdgssim", "ipqkepiqyl", "Vandervort", 31, "Purdy and Sons", "Delbert", "(339) 955-5493 x63733", "Hudson", "Lake Jazmyn", "50489-7891" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 7, 18, 23, 32, 51, 51, DateTimeKind.Local).AddTicks(541), "xqemkhcoiq", 243, "mfcdhaffjd", "bwzivpoaro", "Graham", 25, "Kreiger - Reynolds", "Jeramie", "(498) 991-4953 x730", "Harber", "Croninmouth", "28540" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 1, 19, 8, 32, 48, 264, DateTimeKind.Local).AddTicks(2957), "fpkmvhldzn", 71, "ymardyprru", "uaspxnlmke", "Stiedemann", 33, "McCullough - Larson", "Karlee", "1-719-902-0061 x60948", "Greenfelder", "Lake Vinnie", "95325" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 6, 7, 10, 23, 24, 456, DateTimeKind.Local).AddTicks(2658), "dfwxmhsfsf", 200, "brldblissh", "sioqwosvuy", "Fahey", 28, "Sanford - Hodkiewicz", "Hayley", "(443) 876-8834 x69425", "Vandervort", "Runolfsdottirmouth", "63873" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 2, 8, 2, 52, 52, 202, DateTimeKind.Local).AddTicks(786), "pyluyxpkuf", 190, "tcgyosupro", "jppsbmymue", "Hammes", 28, "Keeling Inc", "Raymundo", "(638) 667-5590 x146", "Armstrong", "Metzshire", "89077-6448" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 1, 13, 2, 8, 7, 310, DateTimeKind.Local).AddTicks(4032), "pcvquvbdst", 260, "dnaqoyakji", "fqegejrecv", "Romaguera", 19, "Morar LLC", "Rosemary", "652.801.8085 x128", "Hilll", "Heathcotefurt", "50744" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 11, 4, 2, 44, 7, 1, DateTimeKind.Local).AddTicks(9465), "kprgigtzuw", 41, "tlrsillqmg", "mbunklogxm", "Bogisich", 30, "Renner - Mitchell", "Ezequiel", "(813) 346-1538 x74636", "Cronin", "Port Sophie", "35128" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 9, 28, 8, 22, 8, 921, DateTimeKind.Local).AddTicks(3729), "wikxgjtgki", 218, "azlbhyqgnw", "crvbnlndea", "Klein", 21, "Walter and Sons", "Lysanne", "936.647.6805 x4909", "Doyle", "New Willow", "40138" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 11, 20, 0, 54, 40, 798, DateTimeKind.Local).AddTicks(2142), "sgivrtnjzi", 134, "nxwqdqnikc", "brxfumgphi", "Schoen", 32, "Rolfson, Dare and Wolf", "Margaret", "1-305-364-8735 x8877", "McClure", "Port Aryanna", "26489" });
        }
    }
}
