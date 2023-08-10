using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomotiveApi.Migrations
{
    /// <inheritdoc />
    public partial class add_parent_id : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Agences",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "ParentId", "Tel", "ZipCode" },
                values: new object[] { "4384 Powlowski Cove", "Horacioside", new DateTime(2022, 12, 3, 9, 53, 12, 203, DateTimeKind.Local).AddTicks(124), "Joyce_Lindgren82@yahoo.com", 42.453899999999997, 135.4179, "Principal Intranet Specialist", null, "351-847-5857 x536", "98967-7437" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "ParentId", "Tel", "ZipCode" },
                values: new object[] { "4876 Lelia Street", "Port Colten", new DateTime(2023, 6, 8, 10, 7, 38, 491, DateTimeKind.Local).AddTicks(7583), "Janick_Lebsack@gmail.com", -2.8702999999999999, 41.654800000000002, "National Creative Planner", null, "404-625-9879 x32420", "23832-0966" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "ParentId", "Tel", "ZipCode" },
                values: new object[] { "436 Glover Port", "Lake Martin", new DateTime(2023, 3, 6, 7, 33, 58, 748, DateTimeKind.Local).AddTicks(961), "Albin_Kovacek@gmail.com", 14.284000000000001, 60.600900000000003, "Product Implementation Supervisor", null, "532.612.6916 x84687", "20334" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "ParentId", "Tel", "ZipCode" },
                values: new object[] { "55183 Howell Key", "Wardside", new DateTime(2023, 6, 7, 12, 48, 36, 568, DateTimeKind.Local).AddTicks(9044), "Jacques.Will@yahoo.com", 38.223199999999999, -155.43279999999999, "Legacy Response Architect", null, "934.625.4397 x29369", "41633" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "ParentId", "Tel", "ZipCode" },
                values: new object[] { "97172 Tromp Cliff", "Port Jermain", new DateTime(2022, 12, 20, 4, 57, 52, 27, DateTimeKind.Local).AddTicks(7993), "Audreanne_Mueller@yahoo.com", 80.552400000000006, 97.766300000000001, "Product Operations Officer", null, "1-783-714-5043 x0051", "14992" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "ParentId", "Tel", "ZipCode" },
                values: new object[] { "1060 Taurean Ford", "East Pasquale", new DateTime(2023, 2, 7, 22, 0, 1, 104, DateTimeKind.Local).AddTicks(7107), "Marcellus8@yahoo.com", -74.676900000000003, -71.495199999999997, "Legacy Functionality Executive", null, "984.842.1917", "69112" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "ParentId", "Tel", "ZipCode" },
                values: new object[] { "32619 Walker Mountains", "Lake Mikayla", new DateTime(2023, 5, 4, 9, 38, 59, 3, DateTimeKind.Local).AddTicks(3653), "Dena_Lueilwitz98@hotmail.com", -5.5541999999999998, 14.074199999999999, "District Configuration Manager", null, "789-209-2754 x441", "60031-9120" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "ParentId", "Tel", "ZipCode" },
                values: new object[] { "351 Nova Tunnel", "Port Kyla", new DateTime(2023, 5, 23, 14, 34, 3, 132, DateTimeKind.Local).AddTicks(1477), "Jamir_Schimmel90@gmail.com", 57.046999999999997, 72.047899999999998, "Lead Research Consultant", null, "753-707-6509", "41178-8439" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "ParentId", "Tel", "ZipCode" },
                values: new object[] { "74552 Ernser Park", "North Devante", new DateTime(2023, 4, 28, 9, 51, 21, 264, DateTimeKind.Local).AddTicks(7409), "Corbin.Collier@yahoo.com", 85.632099999999994, 50.746699999999997, "Chief Operations Planner", null, "857.873.3087 x32688", "94174" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "ParentId", "Tel", "ZipCode" },
                values: new object[] { "083 Dach Neck", "Agnesbury", new DateTime(2023, 6, 22, 9, 42, 40, 638, DateTimeKind.Local).AddTicks(6652), "Delaney.Fay17@yahoo.com", -42.561100000000003, 68.341899999999995, "Regional Metrics Consultant", null, "1-536-813-4604", "54006-6221" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "4649 Ena Divide", "728 Tyler Forges", new DateTime(2022, 8, 11, 22, 52, 39, 414, DateTimeKind.Local).AddTicks(3026), "Wallace40@gmail.com", "Alvis", "Russel", "https://picsum.photos/640/480/?image=209", "https://picsum.photos/640/480/?image=134", "313.477.4161", "Aliyaport", "29595" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "845 Zelda Well", "88552 Kunde Extension", new DateTime(2022, 11, 13, 20, 21, 34, 413, DateTimeKind.Local).AddTicks(7295), "Luis.Waelchi10@gmail.com", "Grover", "Jacobson", "https://picsum.photos/640/480/?image=638", "https://picsum.photos/640/480/?image=228", "1-594-456-5136 x86429", "Lamontstad", "82428" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "51324 Yolanda Lakes", "5144 Torphy Port", new DateTime(2023, 5, 28, 4, 56, 26, 456, DateTimeKind.Local).AddTicks(9311), "Mateo_Thompson31@yahoo.com", "Trever", "Mohr", "https://picsum.photos/640/480/?image=752", "https://picsum.photos/640/480/?image=1044", "356.608.8382 x430", "Dakotamouth", "48012" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "538 Nitzsche Estate", "652 Estrella Mews", new DateTime(2023, 7, 27, 22, 46, 10, 122, DateTimeKind.Local).AddTicks(9610), "Nyasia_Beier@gmail.com", "Broderick", "Dooley", "https://picsum.photos/640/480/?image=371", "https://picsum.photos/640/480/?image=1045", "(700) 880-2410 x8451", "Raustad", "30027" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "85698 Nicolas Field", "705 Nathan Burg", new DateTime(2023, 3, 11, 21, 8, 38, 502, DateTimeKind.Local).AddTicks(7569), "Kyler91@yahoo.com", "Norris", "Boehm", "https://picsum.photos/640/480/?image=460", "https://picsum.photos/640/480/?image=380", "258-719-8910 x91862", "New Joanniemouth", "81924-6799" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "4917 Liana Court", "2150 Wehner Fields", new DateTime(2023, 6, 2, 20, 37, 37, 317, DateTimeKind.Local).AddTicks(6778), "Stan_Beier47@yahoo.com", "Carmel", "Kilback", "https://picsum.photos/640/480/?image=749", "https://picsum.photos/640/480/?image=45", "699.595.0921", "Ondrickaside", "40549" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "27214 Hugh Drives", "0162 Torp Mills", new DateTime(2023, 2, 8, 6, 54, 52, 806, DateTimeKind.Local).AddTicks(9585), "Gabriel.Kutch@gmail.com", "Keshaun", "Fay", "https://picsum.photos/640/480/?image=71", "https://picsum.photos/640/480/?image=827", "776-848-6448 x952", "West Cierra", "92662" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "991 Terrill Tunnel", "815 Ewell Path", new DateTime(2022, 9, 6, 23, 8, 37, 371, DateTimeKind.Local).AddTicks(1022), "Lydia26@yahoo.com", "Devin", "Cronin", "https://picsum.photos/640/480/?image=720", "https://picsum.photos/640/480/?image=755", "(293) 729-4529", "Mullerton", "96237" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "988 Gerlach Roads", "28832 Aufderhar Garden", new DateTime(2023, 7, 30, 3, 48, 33, 785, DateTimeKind.Local).AddTicks(9108), "Francisca.Williamson@hotmail.com", "Cristobal", "Frami", "https://picsum.photos/640/480/?image=884", "https://picsum.photos/640/480/?image=154", "781-395-7800 x41629", "Sauerborough", "19279-4397" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "2102 Considine Circle", "0120 Deron Stravenue", new DateTime(2022, 8, 31, 18, 0, 41, 904, DateTimeKind.Local).AddTicks(8892), "Jaden.Turcotte@yahoo.com", "Soledad", "Armstrong", "https://picsum.photos/640/480/?image=521", "https://picsum.photos/640/480/?image=117", "1-389-522-6117 x846", "Cartwrightfurt", "50050" });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 5, 9 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 8, 10 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 8, 10 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 6, 2, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 8, 6, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 10, 1, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "IdClient", "IsConducteur" },
                values: new object[] { 6, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 3, 9 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 1, 10, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 3, 3, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 10, 8, 18, 42, 762, DateTimeKind.Local).AddTicks(6271), new DateTime(2023, 8, 11, 12, 16, 43, 71, DateTimeKind.Local).AddTicks(1304), new DateTime(2024, 2, 1, 23, 28, 27, 998, DateTimeKind.Local).AddTicks(9645), 6, 5.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 10, 3, 56, 26, 943, DateTimeKind.Local).AddTicks(1812), new DateTime(2023, 8, 10, 23, 31, 2, 430, DateTimeKind.Local).AddTicks(3417), new DateTime(2023, 11, 1, 5, 39, 31, 673, DateTimeKind.Local).AddTicks(5047), 6, 7.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 10, 14, 25, 57, 463, DateTimeKind.Local).AddTicks(3159), new DateTime(2023, 8, 11, 22, 6, 43, 651, DateTimeKind.Local).AddTicks(9294), new DateTime(2023, 11, 28, 21, 42, 20, 88, DateTimeKind.Local).AddTicks(3719), 1, 7.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule" },
                values: new object[] { new DateTime(2023, 8, 10, 10, 17, 50, 440, DateTimeKind.Local).AddTicks(2642), new DateTime(2023, 8, 11, 9, 37, 10, 355, DateTimeKind.Local).AddTicks(8643), new DateTime(2023, 11, 25, 9, 13, 46, 336, DateTimeKind.Local).AddTicks(2912), 9 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 10, 13, 51, 20, 172, DateTimeKind.Local).AddTicks(8886), new DateTime(2023, 8, 11, 3, 38, 2, 44, DateTimeKind.Local).AddTicks(2844), new DateTime(2024, 4, 8, 11, 13, 19, 88, DateTimeKind.Local).AddTicks(950), 5, 7.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 10, 0, 31, 27, 730, DateTimeKind.Local).AddTicks(8496), new DateTime(2023, 8, 11, 8, 20, 56, 334, DateTimeKind.Local).AddTicks(7751), new DateTime(2024, 7, 15, 5, 30, 31, 343, DateTimeKind.Local).AddTicks(1205), 5, 2.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 10, 5, 28, 53, 599, DateTimeKind.Local).AddTicks(554), new DateTime(2023, 8, 11, 23, 12, 59, 244, DateTimeKind.Local).AddTicks(7973), new DateTime(2024, 6, 18, 23, 37, 47, 309, DateTimeKind.Local).AddTicks(5806), 7, 9.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 10, 14, 8, 10, 642, DateTimeKind.Local).AddTicks(8861), new DateTime(2023, 8, 11, 14, 40, 54, 401, DateTimeKind.Local).AddTicks(3983), new DateTime(2024, 1, 23, 5, 24, 42, 293, DateTimeKind.Local).AddTicks(4758), 7, 2.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule" },
                values: new object[] { new DateTime(2023, 8, 10, 5, 51, 3, 772, DateTimeKind.Local).AddTicks(6808), new DateTime(2023, 8, 11, 5, 11, 27, 615, DateTimeKind.Local).AddTicks(356), new DateTime(2023, 10, 18, 15, 6, 21, 97, DateTimeKind.Local).AddTicks(6960), 7 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 10, 11, 43, 47, 12, DateTimeKind.Local).AddTicks(3357), new DateTime(2023, 8, 11, 11, 38, 32, 106, DateTimeKind.Local).AddTicks(7843), new DateTime(2024, 6, 1, 16, 22, 9, 722, DateTimeKind.Local).AddTicks(3450), 10, 2.0, true });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 10, 5, 42, 25, 510, DateTimeKind.Local).AddTicks(7743), new DateTime(2023, 8, 11, 16, 37, 0, 505, DateTimeKind.Local).AddTicks(6717), new DateTime(2024, 2, 21, 5, 55, 38, 177, DateTimeKind.Local).AddTicks(8605), "01b2ffd5-3102-4a5b-a4f3-af22a73c4938" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 10, 14, 13, 22, 589, DateTimeKind.Local).AddTicks(4606), new DateTime(2023, 8, 11, 20, 18, 57, 910, DateTimeKind.Local).AddTicks(326), new DateTime(2024, 4, 30, 8, 54, 47, 861, DateTimeKind.Local).AddTicks(2765), "6ac3e9f6-c74d-4d65-b040-d720f3d0f787", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 9, 23, 33, 27, 553, DateTimeKind.Local).AddTicks(1806), new DateTime(2023, 8, 11, 10, 14, 57, 534, DateTimeKind.Local).AddTicks(1392), new DateTime(2023, 12, 2, 17, 29, 11, 864, DateTimeKind.Local).AddTicks(3667), 1, "3db0abc3-de7e-4047-b755-d9bc3239e25c", "Annulé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 10, 0, 37, 10, 191, DateTimeKind.Local).AddTicks(3435), new DateTime(2023, 8, 11, 19, 46, 32, 237, DateTimeKind.Local).AddTicks(3348), new DateTime(2023, 11, 5, 6, 36, 14, 390, DateTimeKind.Local).AddTicks(3519), "74f085a8-e54a-4ac1-9f06-6aa5bc9898b7", "Confirmé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 10, 10, 12, 24, 106, DateTimeKind.Local).AddTicks(9246), new DateTime(2023, 8, 11, 22, 46, 6, 276, DateTimeKind.Local).AddTicks(4514), new DateTime(2024, 2, 10, 23, 31, 40, 827, DateTimeKind.Local).AddTicks(8822), 9, "31d166c3-77a1-4b2a-b55c-a8ced7e0fdbf", "Confirmé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 10, 14, 54, 22, 471, DateTimeKind.Local).AddTicks(8039), new DateTime(2023, 8, 11, 9, 22, 9, 182, DateTimeKind.Local).AddTicks(6875), new DateTime(2024, 3, 30, 7, 6, 38, 409, DateTimeKind.Local).AddTicks(9340), 5, "420dcb83-0c27-4ad0-92cb-45e451ecfa50" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 10, 6, 20, 2, 194, DateTimeKind.Local).AddTicks(9930), new DateTime(2023, 8, 11, 8, 12, 30, 72, DateTimeKind.Local).AddTicks(711), new DateTime(2024, 6, 21, 17, 19, 10, 995, DateTimeKind.Local).AddTicks(8001), 1, "07e2a16b-ca9a-42e1-b94e-6221f3f44ec4", "Expiré" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 48, 47, 313, DateTimeKind.Local).AddTicks(1483), new DateTime(2023, 8, 11, 18, 41, 22, 815, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 6, 29, 21, 26, 38, 370, DateTimeKind.Local).AddTicks(5791), 1, "574617e9-6b26-4c1d-8099-86d8c552643e", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 10, 9, 10, 31, 104, DateTimeKind.Local).AddTicks(2488), new DateTime(2023, 8, 11, 14, 0, 11, 126, DateTimeKind.Local).AddTicks(1583), new DateTime(2024, 7, 13, 23, 7, 25, 187, DateTimeKind.Local).AddTicks(5351), 10, "831b110f-0c12-4720-bc7b-b9caa5681086", "Annulé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 10, 13, 58, 57, 421, DateTimeKind.Local).AddTicks(6726), new DateTime(2023, 8, 11, 17, 50, 41, 879, DateTimeKind.Local).AddTicks(2356), new DateTime(2024, 2, 23, 19, 54, 14, 193, DateTimeKind.Local).AddTicks(7199), 5, "66d88170-eb59-4d56-afbc-667ef1c332d4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 2, 9, 14, 31, 46, 542, DateTimeKind.Local).AddTicks(3754), "Amely67@gmail.com", "Laron", 4, false, "Labadie", "$2a$11$cDnhOg1SXWUfC2zCr4pZtOOHUgUs1yP95AFXi1a3Dy9PCPHhGmhp6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 5, 21, 1, 32, 654, DateTimeKind.Local).AddTicks(3284), "Webster_Jones@yahoo.com", "Carleton", 8, 1, "Gleason", "$2a$11$9yMMgza0XNmCDdrZFoLTs.zOpu2iSJL6rygkVZLBlWCMNKKbj6sUy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 31, 9, 0, 43, 538, DateTimeKind.Local).AddTicks(5764), "Coty_Cremin@yahoo.com", "Armani", 1, "Lang", "$2a$11$677BbF3UnbXf8tfpYwA8OOEr50qjArHdLD5Bc311bukoOnZva.83a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 21, 21, 38, 13, 24, DateTimeKind.Local).AddTicks(938), "Howell_Monahan@yahoo.com", "Erika", 4, true, "Hessel", "$2a$11$1ePDFTpx2XcmiSgER1ATyecERHPdS7lSOz77Gd1cVzaXzhUtPecEa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 14, 13, 9, 40, 593, DateTimeKind.Local).AddTicks(4248), "Molly45@yahoo.com", "Eleonore", 1, false, "Kuhic", "$2a$11$ahJpdj9.58VgZEHFXNGPx.3cs4YuUYzUf67Lr4vvoHSbnagmIs.8e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 8, 16, 3, 20, 7, 680, DateTimeKind.Local).AddTicks(6118), "Mavis.Dibbert62@hotmail.com", "D'angelo", 5, false, "Mayert", "$2a$11$hmww6IqSlr9eHjCVBL8T4ucY6tqcSP7OzFcWQE8JkkClRKXSvFMl2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 22, 18, 15, 44, 826, DateTimeKind.Local).AddTicks(16), "Kaci.Schulist90@hotmail.com", "Jamar", 4, false, "Moen", "$2a$11$earwcoctcSgrv9oImvAG.OXWdEWlFJ3D6mcdtlCnOasnRRyy4.HNW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 11, 17, 5, 45, 55, 837, DateTimeKind.Local).AddTicks(8157), "Amira34@yahoo.com", "Mazie", 7, 1, true, "Herman", "$2a$11$yDKoJTJicOyEuR7ALwOm8O0vi7PTrtCwPpkoAvCpeF0PhjU.ZDtEm" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 7, 2, 52, 17, 662, DateTimeKind.Local).AddTicks(7451), "Zoila90@yahoo.com", "Amir", 1, "Reichert", "$2a$11$szCKBjoB6Daf1raS9xkCqeCyNZ//ub8yEabNLzuSOWTl1TxaA.996" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 2, 18, 17, 25, 117, DateTimeKind.Local).AddTicks(7575), "Colby81@gmail.com", "Josh", 8, "Schroeder", "$2a$11$Y4BxNAY7n4BlDtxoeL5YYe71L2QARZ4SPAk7sJtIpbQj.14VAVoKS" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Type" },
                values: new object[] { false, new DateTime(2022, 9, 8, 11, 52, 29, 333, DateTimeKind.Local).AddTicks(2598), "mmqpwxsihc", 80, 4473, "twlepduvgr", "bxkdfdoyrn", "tsqkzxnfgh", 5, 8, "ltxftlebso" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, true, new DateTime(2023, 1, 8, 8, 2, 21, 271, DateTimeKind.Local).AddTicks(1904), "diedzifizq", 8, 146, 5624, "fqxsrkskqk", "ddnytgwyvt", "mfjumbjdkh", 10, 7, 4.0, "cesirsjsxd" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "Prix", "Type" },
                values: new object[] { true, new DateTime(2023, 6, 8, 20, 54, 3, 181, DateTimeKind.Local).AddTicks(8912), "hxaenzuihb", 1, 249, 9112, "wtagyhaqsn", "ruovvqkxoc", "ibiaxxsyms", 2, 1.0, "znkgfjyhkw" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "Prix", "Type" },
                values: new object[] { true, new DateTime(2023, 6, 29, 16, 3, 26, 190, DateTimeKind.Local).AddTicks(3819), "pwqpcrixzm", 7, 99, 7561, "axhejpriry", "ugcymsdtbv", "pbemygmnhn", 2, 1.0, "gwvvlvieuc" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2023, 6, 19, 5, 17, 9, 927, DateTimeKind.Local).AddTicks(8380), "qjfbzjkerx", 281, 2513, "vcbafliefb", "mbhzifccvm", "qxalygrank", 3, 10, 4.0, "rpddaxdrar" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2022, 10, 8, 21, 59, 16, 245, DateTimeKind.Local).AddTicks(826), "viggvpvspx", 9, 230, 9312, "ilymgkjrle", "dgrnrgdaxt", "itotsetxtm", 2, 8, 3.0, "einzbphnck" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2022, 12, 30, 20, 40, 21, 2, DateTimeKind.Local).AddTicks(2382), "jkaxprlorw", 2, 236, 9934, "bflaggxjfn", "lmjibyubay", "nlsnhiafej", 10, 5, 9.0, "mgnsfzcpmq" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, true, new DateTime(2023, 4, 13, 1, 50, 59, 220, DateTimeKind.Local).AddTicks(5079), "puphsanasg", 5, 41, 9357, "achbjltypj", "cokyfmgorr", "qjrxnhdrnt", 9, 5, 9.0, "bhplkzfecn" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, true, new DateTime(2023, 1, 3, 19, 28, 0, 320, DateTimeKind.Local).AddTicks(7084), "wjbjpkilib", 9, 270, 6421, "skdpntlicz", "ckbpevkxtk", "xldmiovsob", 10, 7, 4.0, "alkzrwbbro" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2023, 7, 10, 18, 36, 17, 901, DateTimeKind.Local).AddTicks(8240), "eybqoqznpz", 10, 172, 7848, "osjvsbmuxw", "worivwrses", "ivkbefcnwv", 4, 9, 3.0, "prtdktvhsd" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 9, 12, 16, 20, 0, 519, DateTimeKind.Local).AddTicks(9080), 33, "xotapnbvca", "Davis", 18, "Schaden, Schuppe and McClure", "Lowell", "1-884-983-0726 x81086", "Stark", "Ryanburgh", "37863-1389" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 3, 22, 20, 9, 30, 129, DateTimeKind.Local).AddTicks(9262), 127, "gyzydyexbc", "Muller", 24, "Ritchie, Conroy and Koepp", "Ralph", "1-823-843-1583", "Bashirian", "Port Reese", "71640-9047" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 12, 8, 12, 8, 9, 483, DateTimeKind.Local).AddTicks(444), 236, "awiimbqrpy", "Gutkowski", 30, "Jacobi LLC", "Enos", "(579) 805-6668", "Armstrong", "East Brandonland", "44385" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 7, 6, 22, 51, 7, 605, DateTimeKind.Local).AddTicks(1727), 143, "tydrlsmgug", "Reichel", 24, "Maggio - Raynor", "Tyrique", "485-791-5576 x072", "Fahey", "North Alaina", "42746" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 12, 29, 18, 41, 51, 706, DateTimeKind.Local).AddTicks(6970), 241, "ywghslzhav", "Roob", 28, "Reynolds - Stokes", "Courtney", "(309) 761-5468 x463", "Wisoky", "Reichertberg", "98949-5434" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 4, 6, 3, 55, 17, 50, DateTimeKind.Local).AddTicks(6155), 248, "hwkdyvjmnj", "Jacobs", 30, "Cole, Mills and Ullrich", "Elody", "710.884.6367", "Jast", "New Bobbymouth", "14273" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 12, 7, 16, 25, 38, 304, DateTimeKind.Local).AddTicks(1691), 293, "cozqayjejn", "Wintheiser", 22, "Murray - Lesch", "Henry", "1-956-718-7454", "Streich", "Kertzmannmouth", "75466" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 1, 12, 17, 2, 38, 157, DateTimeKind.Local).AddTicks(578), 169, "kzwluuniyy", "Aufderhar", 22, "McKenzie Group", "Gretchen", "830-520-6701", "Stanton", "Leannonport", "95031-2855" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 3, 11, 7, 55, 0, 249, DateTimeKind.Local).AddTicks(2422), 277, "nknmobcnkb", "Cremin", "Fahey Group", "Addie", "479-344-1880 x1267", "Schroeder", "Devonberg", "83922-9613" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 9, 7, 10, 27, 58, 607, DateTimeKind.Local).AddTicks(6262), 189, "stjtjbjykc", "Cruickshank", 21, "Aufderhar, Feest and Nikolaus", "Jared", "1-288-543-5075 x0261", "Roob", "Effertzland", "82227" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Agences");

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
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 4, 10 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 10, 7 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 5, 7 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 3, 1, true });

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
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 1, 3, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "IdClient", "IsConducteur" },
                values: new object[] { 1, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 7, 4 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 10, 6, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 6, 8, true });

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
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 8, 17, 25, 20, 748, DateTimeKind.Local).AddTicks(3107), new DateTime(2023, 8, 9, 19, 5, 11, 688, DateTimeKind.Local).AddTicks(4263), new DateTime(2024, 7, 29, 18, 47, 53, 371, DateTimeKind.Local).AddTicks(1159), 6, 5.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule" },
                values: new object[] { new DateTime(2023, 8, 8, 11, 59, 47, 976, DateTimeKind.Local).AddTicks(4695), new DateTime(2023, 8, 9, 5, 7, 37, 384, DateTimeKind.Local).AddTicks(6413), new DateTime(2024, 4, 24, 23, 59, 7, 736, DateTimeKind.Local).AddTicks(6520), 6 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 8, 2, 45, 3, 226, DateTimeKind.Local).AddTicks(6935), new DateTime(2023, 8, 9, 3, 48, 55, 183, DateTimeKind.Local).AddTicks(2200), new DateTime(2024, 7, 31, 5, 5, 15, 383, DateTimeKind.Local).AddTicks(1853), 8, 6.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 8, 8, 48, 28, 958, DateTimeKind.Local).AddTicks(8411), new DateTime(2023, 8, 9, 16, 27, 40, 811, DateTimeKind.Local).AddTicks(3697), new DateTime(2024, 3, 22, 23, 47, 29, 194, DateTimeKind.Local).AddTicks(6609), 9, 5.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 8, 14, 26, 22, 345, DateTimeKind.Local).AddTicks(7800), new DateTime(2023, 8, 9, 4, 32, 1, 305, DateTimeKind.Local).AddTicks(8461), new DateTime(2023, 11, 22, 22, 21, 22, 905, DateTimeKind.Local).AddTicks(8992), 6, 6.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 8, 9, 39, 42, 254, DateTimeKind.Local).AddTicks(1910), new DateTime(2023, 8, 9, 14, 44, 10, 516, DateTimeKind.Local).AddTicks(124), new DateTime(2024, 5, 11, 7, 48, 23, 763, DateTimeKind.Local).AddTicks(7534), 2, 5.0 });

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
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 8, 20, 11, 50, 382, DateTimeKind.Local).AddTicks(8213), new DateTime(2023, 8, 10, 0, 4, 9, 267, DateTimeKind.Local).AddTicks(2993), new DateTime(2024, 3, 30, 12, 21, 20, 910, DateTimeKind.Local).AddTicks(6560), "7df6a69a-1fe8-4718-80ab-910d5cc5ec2e" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 8, 22, 24, 51, 897, DateTimeKind.Local).AddTicks(8650), new DateTime(2023, 8, 9, 22, 3, 36, 932, DateTimeKind.Local).AddTicks(8129), new DateTime(2023, 12, 17, 0, 23, 31, 896, DateTimeKind.Local).AddTicks(2764), "5d5a906b-4aeb-4a58-8046-6741279e9295", "Confirmé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 8, 8, 25, 53, 92, DateTimeKind.Local).AddTicks(5684), new DateTime(2023, 8, 9, 18, 38, 25, 651, DateTimeKind.Local).AddTicks(8551), new DateTime(2023, 11, 22, 17, 46, 8, 226, DateTimeKind.Local).AddTicks(7118), 10, "ae555553-480a-4868-a668-dfe9c85e1ade", "Confirmé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 8, 6, 56, 42, 17, DateTimeKind.Local).AddTicks(8242), new DateTime(2023, 8, 9, 22, 14, 13, 519, DateTimeKind.Local).AddTicks(598), new DateTime(2024, 7, 5, 0, 17, 56, 31, DateTimeKind.Local).AddTicks(5202), "add5f922-0fc8-4246-b429-ce0ecb8c7d0e", "Annulé" });

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
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 8, 6, 35, 41, 431, DateTimeKind.Local).AddTicks(5750), new DateTime(2023, 8, 10, 0, 1, 26, 987, DateTimeKind.Local).AddTicks(504), new DateTime(2023, 8, 29, 17, 7, 43, 683, DateTimeKind.Local).AddTicks(211), 7, "de560410-cf7a-4372-987e-79261da05d8f" });

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
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 8, 10, 14, 14, 475, DateTimeKind.Local).AddTicks(4542), new DateTime(2023, 8, 9, 15, 9, 23, 6, DateTimeKind.Local).AddTicks(4324), new DateTime(2023, 12, 5, 19, 52, 43, 978, DateTimeKind.Local).AddTicks(4985), 7, "fb93045a-0917-44e2-af7b-5e1141c41698" });

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
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 24, 9, 53, 7, 399, DateTimeKind.Local).AddTicks(3116), "Bobbie22@gmail.com", "Stephany", 5, 2, "Lemke", "$2a$11$bDVDUcP7sZV4yI02DTertOPjzwRLuXyPKLbcP7MsjP6jawr1GKjVu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 22, 16, 20, 6, 104, DateTimeKind.Local).AddTicks(1550), "Mara82@gmail.com", "Max", 9, "Strosin", "$2a$11$doFou8U3/4oRfcH0xusHU.y2kZrPyXKWwjWLbZw5iOJPVkoUO4CP2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 28, 16, 13, 2, 266, DateTimeKind.Local).AddTicks(3463), "Ada48@hotmail.com", "Alta", 1, false, "Adams", "$2a$11$ecP1aQRkaf1evPyvmwJN1.wcG.iruhYp7US79DgvZ0QSk6/R2oX9i" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 24, 20, 49, 6, 528, DateTimeKind.Local).AddTicks(2994), "Tyshawn94@hotmail.com", "Helen", 2, true, "Swaniawski", "$2a$11$QHRh6N74e3MnjVGX7Q1eg.DoCoUIOktpywQi656zAzCnsEyK7Ntuy" });

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
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 10, 25, 7, 51, 15, 103, DateTimeKind.Local).AddTicks(3025), "Caden_Price@gmail.com", "Sadye", 3, 2, false, "Altenwerth", "$2a$11$8tP8ffj.lyOeAbKFKqFfeOH3XocQ6jnAWkiN5j/VLrQCNHjVYM7ha" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 30, 5, 30, 30, 691, DateTimeKind.Local).AddTicks(1593), "Ariane9@gmail.com", "Ignatius", 3, "Larkin", "$2a$11$AOVektAoOBq7uddS6ir01eU8x5H7u/h5vXdNDOoYwqpH/AAh/IIB2" });

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
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Type" },
                values: new object[] { true, new DateTime(2023, 1, 25, 14, 50, 22, 369, DateTimeKind.Local).AddTicks(1162), "bfzdoolkal", 204, 1296, "quagchmrfl", "tszmpmyvsi", "cnjxkyrtii", 6, 1, "vydirovuhy" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, false, new DateTime(2023, 3, 10, 11, 4, 46, 414, DateTimeKind.Local).AddTicks(1473), "eierwgfotg", 6, 198, 5854, "fjejzoxzeg", "cttcgrggmr", "bepaeqvyaq", 3, 2, 10.0, "uiptgpmxhk" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "Prix", "Type" },
                values: new object[] { false, new DateTime(2023, 6, 2, 7, 26, 10, 591, DateTimeKind.Local).AddTicks(6184), "qnioiawhtz", 7, 259, 2220, "dgeewgtxnc", "bovdjcocys", "qdxajduevo", 6, 9.0, "zrxxrngfhe" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "Prix", "Type" },
                values: new object[] { false, new DateTime(2022, 8, 11, 3, 38, 57, 658, DateTimeKind.Local).AddTicks(793), "rmqkoezbmq", 6, 170, 7457, "epjzsumrnx", "xoruzigajt", "ouwfhfwilm", 1, 3.0, "vcakypjzae" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2022, 10, 31, 13, 44, 6, 560, DateTimeKind.Local).AddTicks(3451), "rknmwyulby", 61, 5225, "cftskqyzzt", "weartbveax", "pmfiklutxe", 5, 3, 1.0, "uxtjodwwoh" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2023, 5, 10, 8, 17, 29, 468, DateTimeKind.Local).AddTicks(7241), "wqofeklvpj", 3, 300, 2335, "islwjjmtju", "raoehbvqmr", "eldmxhlyij", 6, 2, 6.0, "hzmtkcueod" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2022, 12, 28, 6, 8, 5, 523, DateTimeKind.Local).AddTicks(364), "mlxgvigjwo", 8, 152, 3064, "izdpzoiywo", "kempylpyrs", "iavepwspnh", 2, 7, 2.0, "ogywavahrh" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, false, new DateTime(2023, 7, 21, 20, 44, 30, 439, DateTimeKind.Local).AddTicks(2384), "ttycayjbse", 4, 1, 940, "egtqxnlipg", "nljlqolbfe", "vrizbeywjv", 4, 2, 7.0, "ihhoyutcil" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, false, new DateTime(2022, 9, 5, 5, 23, 16, 479, DateTimeKind.Local).AddTicks(5839), "pkjhpttjjh", 5, 304, 9759, "lhyswrjeht", "kwaxdiupom", "yrbvotvthl", 1, 5, 5.0, "jcljtccioh" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2022, 9, 30, 7, 15, 16, 94, DateTimeKind.Local).AddTicks(6571), "rpirmcpcin", 7, 241, 1426, "zegllfapfx", "qvghtarsum", "kgifbsawph", 1, 4, 4.0, "jamfiepoid" });

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
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 10, 8, 20, 37, 57, 943, DateTimeKind.Local).AddTicks(1083), 66, "lbbfjntifc", "Klein", 25, "Douglas - VonRueden", "Allie", "751.735.9214 x6364", "Kreiger", "East Jevon", "56769" });

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
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 9, 23, 3, 8, 5, 237, DateTimeKind.Local).AddTicks(6908), 71, "opllnnsawx", "Kling", "Doyle, Botsford and Kerluke", "Arlo", "421.812.6563 x286", "Reinger", "Lomaville", "67619" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 9, 25, 16, 10, 3, 695, DateTimeKind.Local).AddTicks(4559), 50, "cztacgdqti", "Walker", 25, "Bayer - Keeling", "Adriana", "228-923-5206 x470", "Terry", "Port Ellsworthberg", "28266" });
        }
    }
}
