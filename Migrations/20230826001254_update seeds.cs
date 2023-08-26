using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AutomotiveApi.Migrations
{
    /// <inheritdoc />
    public partial class updateseeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "IsVerified", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "6087 Isabel Corners", "Beni-mellal", new DateTime(2023, 1, 16, 22, 10, 58, 276, DateTimeKind.Local).AddTicks(3621), "Lilly5@gmail.com", true, 58.683199999999999, -54.802399999999999, "Regional Division Administrator", "754.926.9497", "49099" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "IsVerified", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "22569 Pacocha Mills", "Meknès", new DateTime(2023, 3, 22, 3, 58, 41, 239, DateTimeKind.Local).AddTicks(6361), "Lemuel.Champlin10@yahoo.com", true, -22.8886, 142.99010000000001, "International Infrastructure Producer", "380.565.6419 x32110", "14085" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "IsVerified", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "29589 Keon Canyon", "Tinghir", new DateTime(2022, 9, 22, 0, 37, 37, 610, DateTimeKind.Local).AddTicks(8920), "Bria.Kirlin@yahoo.com", true, -38.57, 20.9209, "Customer Data Consultant", "857.542.1111", "76264" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "IsVerified", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "485 Schowalter Vista", "Laayoune", new DateTime(2023, 4, 21, 12, 53, 54, 359, DateTimeKind.Local).AddTicks(9725), "Kenya.Krajcik68@yahoo.com", true, 67.787700000000001, 107.4873, "Investor Communications Orchestrator", "(869) 766-1649 x281", "17804-8829" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "713 Vladimir Freeway", "Tinghir", new DateTime(2022, 9, 4, 16, 7, 35, 808, DateTimeKind.Local).AddTicks(5664), "Garth_Schowalter52@gmail.com", 24.616900000000001, -108.00360000000001, "International Web Developer", "(412) 277-9385 x9386", "10450-5769" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "IsVerified", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "1277 Jeremie Cliff", "Taza", new DateTime(2023, 3, 20, 1, 33, 13, 813, DateTimeKind.Local).AddTicks(7205), "Stefanie83@hotmail.com", true, 15.2181, -52.633299999999998, "Product Mobility Coordinator", "1-556-866-9942 x708", "64849" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "IsVerified", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "502 Langosh Dam", "Mohammédia", new DateTime(2022, 11, 25, 15, 50, 0, 814, DateTimeKind.Local).AddTicks(3704), "Bertha29@yahoo.com", true, 21.978000000000002, 70.196700000000007, "Future Identity Agent", "836-457-4697", "09492" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "IsVerified", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "601 Muller Neck", "Agadir", new DateTime(2023, 8, 5, 21, 10, 6, 202, DateTimeKind.Local).AddTicks(5349), "Wava.Kub@gmail.com", true, -58.343400000000003, 172.61799999999999, "International Security Associate", "(944) 877-1683", "21157" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "394 Spinka Vista", "Essaouira", new DateTime(2023, 4, 4, 18, 29, 55, 201, DateTimeKind.Local).AddTicks(1838), "Kelley_Leffler11@gmail.com", 89.532399999999996, -11.158899999999999, "Product Configuration Representative", "797-224-1147", "48959-0897" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "IsVerified", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "3020 Clovis Ridges", "Beni-mellal", new DateTime(2023, 3, 18, 6, 20, 41, 484, DateTimeKind.Local).AddTicks(2156), "Brenda_Howe@yahoo.com", true, -53.230400000000003, 60.703200000000002, "Central Optimization Director", "735.520.1841 x967", "72014" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "5268 Little Extension", "22113 Casimer Harbors", new DateTime(2022, 11, 3, 12, 9, 8, 123, DateTimeKind.Local).AddTicks(6894), "Joy.Denesik59@yahoo.com", "Leonard", "Ferry", "https://picsum.photos/640/480/?image=320", "https://picsum.photos/640/480/?image=758", "(881) 347-5564 x5056", "East Oswaldburgh", "86710-0266" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "35670 Wintheiser Ports", "12686 Kunze Parkways", new DateTime(2023, 4, 4, 8, 46, 7, 368, DateTimeKind.Local).AddTicks(1409), "Lucinda.Powlowski@gmail.com", "Monroe", "Hodkiewicz", "https://picsum.photos/640/480/?image=755", "https://picsum.photos/640/480/?image=610", "457.947.8452", "Maxwellhaven", "31019-2082" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "27483 Ethelyn Hill", "8395 Jeramie Fall", new DateTime(2023, 3, 23, 10, 6, 7, 274, DateTimeKind.Local).AddTicks(7015), "Max68@yahoo.com", "Catalina", "Turcotte", "https://picsum.photos/640/480/?image=618", "https://picsum.photos/640/480/?image=269", "(483) 245-1172", "South Kadenfurt", "29755" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "106 Rigoberto Land", "337 Frances Gardens", new DateTime(2023, 1, 19, 23, 36, 10, 172, DateTimeKind.Local).AddTicks(1618), "Claud_Ferry@gmail.com", "Keagan", "Runte", "https://picsum.photos/640/480/?image=504", "https://picsum.photos/640/480/?image=995", "1-370-842-6661", "Dooleystad", "00264-3876" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "25706 Bahringer Passage", "763 Carmela Well", new DateTime(2022, 12, 28, 8, 9, 52, 488, DateTimeKind.Local).AddTicks(9562), "Ruth.Bailey@yahoo.com", "Abbie", "Zulauf", "https://picsum.photos/640/480/?image=620", "https://picsum.photos/640/480/?image=381", "476.418.4744", "Schroederville", "98444-6506" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "27058 Mittie Orchard", "009 Aubrey Greens", new DateTime(2023, 5, 18, 11, 56, 18, 488, DateTimeKind.Local).AddTicks(5799), "Elnora83@yahoo.com", "Brent", "Yundt", "https://picsum.photos/640/480/?image=848", "https://picsum.photos/640/480/?image=385", "1-555-493-7136", "Langoshport", "67109-1608" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "84298 Rogers Stream", "11312 Myrtice Corners", new DateTime(2022, 11, 20, 15, 3, 30, 752, DateTimeKind.Local).AddTicks(3266), "Laurel.Bednar@gmail.com", "Elinore", "Franecki", "https://picsum.photos/640/480/?image=856", "https://picsum.photos/640/480/?image=660", "815.896.5490 x326", "North Jordimouth", "17086" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "380 Carroll Pike", "4814 Cummerata Glen", new DateTime(2023, 7, 20, 18, 8, 4, 527, DateTimeKind.Local).AddTicks(5121), "Maxine86@hotmail.com", "Kathryn", "Goodwin", "https://picsum.photos/640/480/?image=375", "https://picsum.photos/640/480/?image=293", "311.341.4932", "Larkinside", "53531" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "17819 Corwin Manor", "025 Howell Drives", new DateTime(2023, 6, 19, 12, 38, 24, 346, DateTimeKind.Local).AddTicks(409), "Marquise92@yahoo.com", "Bernita", "Stokes", "https://picsum.photos/640/480/?image=476", "https://picsum.photos/640/480/?image=1052", "(551) 310-5452 x1096", "East Alan", "95602" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "470 Hilpert Manor", "2633 Raheem Passage", new DateTime(2023, 2, 15, 17, 15, 30, 339, DateTimeKind.Local).AddTicks(1716), "Marlon_Parisian@yahoo.com", "Norene", "Gaylord", "https://picsum.photos/640/480/?image=888", "https://picsum.photos/640/480/?image=179", "(901) 493-8996", "Lake Dante", "50046-8811" });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 9, 5, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 1, 6 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 3,
                column: "IdClient",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 4,
                column: "IdReservation",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 6, 4, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 9, 8, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 7, 6, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 2, 5, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 9,
                column: "IdClient",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 8, 6, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 25, 4, 15, 52, 883, DateTimeKind.Local).AddTicks(6209), new DateTime(2023, 8, 26, 2, 16, 57, 366, DateTimeKind.Local).AddTicks(9567), new DateTime(2024, 3, 24, 10, 0, 10, 158, DateTimeKind.Local).AddTicks(7908), 4, 302.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 25, 10, 48, 20, 143, DateTimeKind.Local).AddTicks(1638), new DateTime(2023, 8, 26, 15, 19, 58, 461, DateTimeKind.Local).AddTicks(8692), new DateTime(2024, 1, 23, 15, 0, 24, 180, DateTimeKind.Local).AddTicks(3134), 8, 201.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 25, 20, 39, 36, 607, DateTimeKind.Local).AddTicks(1116), new DateTime(2023, 8, 26, 4, 8, 13, 597, DateTimeKind.Local).AddTicks(1527), new DateTime(2024, 4, 11, 0, 40, 43, 927, DateTimeKind.Local).AddTicks(1538), 7, 249.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 25, 16, 5, 10, 533, DateTimeKind.Local).AddTicks(364), new DateTime(2023, 8, 26, 5, 5, 2, 970, DateTimeKind.Local).AddTicks(9168), new DateTime(2024, 4, 17, 15, 28, 37, 651, DateTimeKind.Local).AddTicks(7095), 9, 309.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 25, 23, 38, 55, 866, DateTimeKind.Local).AddTicks(948), new DateTime(2023, 8, 26, 17, 53, 7, 926, DateTimeKind.Local).AddTicks(5755), new DateTime(2023, 9, 24, 8, 11, 53, 928, DateTimeKind.Local).AddTicks(5046), 9, 443.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 25, 16, 1, 26, 866, DateTimeKind.Local).AddTicks(877), new DateTime(2023, 8, 26, 6, 23, 27, 763, DateTimeKind.Local).AddTicks(945), new DateTime(2024, 2, 25, 23, 3, 27, 73, DateTimeKind.Local).AddTicks(1970), 9, 293.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 25, 11, 40, 14, 445, DateTimeKind.Local).AddTicks(2585), new DateTime(2023, 8, 26, 7, 32, 15, 154, DateTimeKind.Local).AddTicks(5797), new DateTime(2024, 6, 22, 19, 58, 16, 92, DateTimeKind.Local).AddTicks(6156), 7, 354.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 25, 16, 4, 32, 360, DateTimeKind.Local).AddTicks(6977), new DateTime(2023, 8, 26, 10, 32, 49, 971, DateTimeKind.Local).AddTicks(6858), new DateTime(2023, 12, 7, 9, 10, 11, 38, DateTimeKind.Local).AddTicks(7468), 9, 363.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 25, 20, 4, 45, 667, DateTimeKind.Local).AddTicks(4585), new DateTime(2023, 8, 26, 1, 22, 30, 693, DateTimeKind.Local).AddTicks(5444), new DateTime(2023, 12, 1, 13, 51, 11, 935, DateTimeKind.Local).AddTicks(9981), 3, 339.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 25, 7, 11, 40, 452, DateTimeKind.Local).AddTicks(9029), new DateTime(2023, 8, 26, 8, 33, 47, 458, DateTimeKind.Local).AddTicks(5270), new DateTime(2023, 11, 12, 3, 2, 17, 108, DateTimeKind.Local).AddTicks(8585), 3, 441.0, true });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Journalisation");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Utilisateurs");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Agences");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Permissions");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Modèles");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Véhicules");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Réservations");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "LLD");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Clients");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 25, 16, 34, 49, 591, DateTimeKind.Local).AddTicks(5216), new DateTime(2023, 8, 26, 23, 1, 26, 154, DateTimeKind.Local).AddTicks(2335), new DateTime(2024, 2, 24, 3, 45, 44, 681, DateTimeKind.Local).AddTicks(5012), 1, "8979ab72-3695-4d2b-b48a-09ea4e53eb20" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 25, 19, 26, 6, 196, DateTimeKind.Local).AddTicks(7890), new DateTime(2023, 8, 26, 8, 0, 46, 897, DateTimeKind.Local).AddTicks(2065), new DateTime(2024, 6, 21, 23, 54, 17, 227, DateTimeKind.Local).AddTicks(8007), 1, "051fff5c-f240-4393-8f6f-2636546b8165", "Annulé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 25, 19, 39, 52, 748, DateTimeKind.Local).AddTicks(6374), new DateTime(2023, 8, 26, 19, 24, 20, 493, DateTimeKind.Local).AddTicks(8206), new DateTime(2024, 8, 5, 3, 29, 52, 298, DateTimeKind.Local).AddTicks(1800), 3, "dbfd5594-b977-4e57-988e-df8b87b89a33", "Expiré" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 25, 19, 13, 17, 798, DateTimeKind.Local).AddTicks(5095), new DateTime(2023, 8, 27, 0, 34, 22, 529, DateTimeKind.Local).AddTicks(460), new DateTime(2024, 8, 2, 14, 49, 50, 622, DateTimeKind.Local).AddTicks(3325), 6, "60a3b46c-a431-422a-80d8-cecd6731f63c" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 25, 2, 57, 27, 293, DateTimeKind.Local).AddTicks(8467), new DateTime(2023, 8, 26, 13, 44, 22, 713, DateTimeKind.Local).AddTicks(9667), new DateTime(2024, 7, 5, 13, 8, 14, 756, DateTimeKind.Local).AddTicks(7293), 10, "a28497cc-ef2b-4c94-8e71-d04ffe9a480a" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 25, 2, 27, 11, 948, DateTimeKind.Local).AddTicks(4000), new DateTime(2023, 8, 26, 8, 15, 39, 50, DateTimeKind.Local).AddTicks(7603), new DateTime(2024, 8, 19, 12, 52, 22, 657, DateTimeKind.Local).AddTicks(6782), 9, "7a01ef1d-9b1b-49bd-a431-8f727704bd77", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 25, 12, 33, 10, 828, DateTimeKind.Local).AddTicks(4206), new DateTime(2023, 8, 26, 12, 18, 2, 185, DateTimeKind.Local).AddTicks(9198), new DateTime(2024, 7, 9, 19, 33, 42, 702, DateTimeKind.Local).AddTicks(8923), 1, "e6694ead-43d5-4569-bb63-7eb3ad5d4858", "Annulé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 25, 1, 57, 15, 691, DateTimeKind.Local).AddTicks(1916), new DateTime(2023, 8, 26, 9, 54, 32, 503, DateTimeKind.Local).AddTicks(5956), new DateTime(2023, 11, 28, 14, 54, 33, 345, DateTimeKind.Local).AddTicks(2024), 1, "7d8c935f-2aeb-4e34-942d-12c0dae2ddf7", "Confirmé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 25, 14, 51, 37, 235, DateTimeKind.Local).AddTicks(7541), new DateTime(2023, 8, 26, 2, 57, 30, 156, DateTimeKind.Local).AddTicks(4499), new DateTime(2024, 8, 21, 2, 35, 14, 150, DateTimeKind.Local).AddTicks(5692), 10, "b18c5ef3-f14b-465c-8421-8ce1df32adbc", "Confirmé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 25, 23, 57, 40, 958, DateTimeKind.Local).AddTicks(5311), new DateTime(2023, 8, 26, 16, 36, 8, 182, DateTimeKind.Local).AddTicks(9782), new DateTime(2024, 1, 5, 16, 10, 34, 326, DateTimeKind.Local).AddTicks(9155), 9, "899d077f-b8e4-4ce1-8919-3d21a02cccf0", "Enattente" });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "IdPermission", "IdRole", "CreatedAt", "DeletedAt", "Id", "UpdatedAt" },
                values: new object[] { 5, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "superadmin@test.com", "Super", null, "Admin", "$2a$11$0aVDodbl2uFUv7I28s2Z8.bQehjjWE28JsPQdqJUoxxVXhx.IvF3a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 11, 20, 0, 2, 25, 67, DateTimeKind.Local).AddTicks(4641), "Odessa_White33@yahoo.com", "Shanny", "Bergnaum", "$2a$11$SD5QCAUpIJ4sjgkW66zTYen2rT6yzlknhSmSLVeoEc1SOYuGsabRG" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 19, 18, 48, 373, DateTimeKind.Local).AddTicks(5327), "Valentin7@yahoo.com", "Enrique", 1, "Green", "$2a$11$niJrU4Z0.ArtpRJPn61TcOgztFnpOLteY8jXL/dVaI53Q2Uyfc8K2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 20, 8, 40, 22, 522, DateTimeKind.Local).AddTicks(9268), "Brittany86@yahoo.com", "Chloe", 9, "Gusikowski", "$2a$11$kBW/.Ehma9eO2Z.wJAjUbeh49WYQNfYDwtO3Zaz67WgfniRjuirL." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 7, 17, 15, 10, 12, 180, DateTimeKind.Local).AddTicks(1973), "Guiseppe50@yahoo.com", "Spencer", 9, "Torp", "$2a$11$2cwNYRce.jfzr994K9a8kes2niTJkIRqAOyFhv2KRaoq9N7WS0UgK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 7, 18, 15, 42, 48, 764, DateTimeKind.Local).AddTicks(4681), "Nona.Marks89@gmail.com", "Hilbert", 9, 2, false, "Greenholt", "$2a$11$x4quslwEaebGgqobzekwturNy4ryPEfkQdv4CUV/HOKoWLy6Fzk7C" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 8, 23, 18, 40, 9, 261, DateTimeKind.Local).AddTicks(8733), "Alden84@yahoo.com", "Lue", 9, 1, "Gerlach", "$2a$11$tzkv3LvmjAs0nh/rL.CXp.nKaPYzRAp1afXuqJIpZ6oyKR/2BbbdO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 8, 30, 19, 32, 42, 571, DateTimeKind.Local).AddTicks(3595), "Lawrence.Dicki@yahoo.com", "Kali", 7, false, "Cronin", "$2a$11$Msl9WWc4sXZwqRTttjf3r.NWLkgYKyDkAd0I3XPc3YDkb8rDMeO8W" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 11, 5, 7, 55, 18, 976, DateTimeKind.Local).AddTicks(6191), "Jannie.Mraz69@gmail.com", "Cornell", 1, "Dickinson", "$2a$11$BAo2bqcYkpwgq.me98KGL.8HRtNB2uI41UWbeP1yjP471whMgDS9a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 8, 24, 9, 25, 38, 922, DateTimeKind.Local).AddTicks(4088), "Shane.Bahringer@gmail.com", "Henry", 7, false, "Stokes", "$2a$11$Atdj2M5Fs8z.5CWg.PLPJ.o2ia46Ux4TrBBQLxYZeknzv5LuSjZc." });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "IsVerified", "LastName", "Password", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2022, 10, 29, 22, 59, 57, 901, DateTimeKind.Local).AddTicks(6218), null, "Felipe45@yahoo.com", "Rashawn", 10, 1, false, false, "Williamson", "$2a$11$f24JNFfzQGmd0.QFxhRHGe0Mx0I8yK/fs4UzPdn/2EkaChx.iEN.q", null });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, false, new DateTime(2023, 3, 1, 8, 24, 47, 24, DateTimeKind.Local).AddTicks(6436), "Hybride", 6, 236, 2669, "pikxiwpvao", "Manuelle", "yybzxcrnuy", 7, 2, 250.0, "Utilitaire" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2022, 10, 1, 17, 40, 55, 205, DateTimeKind.Local).AddTicks(2032), "Essence", 8, 2, 7915, "bddsfojayp", "igskjrehsp", 2, 8, 281.0, "Véhicule" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, true, new DateTime(2022, 12, 5, 8, 57, 6, 226, DateTimeKind.Local).AddTicks(7717), "Électrique", 10, 90, 3617, "dqwagxqlux", "Automatique", "vlsjsxhjrw", 1, 1, 437.0, "Utilitaire" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Name", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2022, 10, 6, 10, 21, 45, 915, DateTimeKind.Local).AddTicks(4787), "Diesel", 4, 264, 6134, "lwjrvttjvh", "itlwdtjtnt", 3, 464.0, "Véhicule" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2022, 9, 28, 11, 57, 41, 513, DateTimeKind.Local).AddTicks(7682), "Diesel", 2, 41, 1991, "nvcbmjcyzz", "Automatique", "vswmynuyiu", 3, 9, 398.0, "Utilitaire" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "IdAgence", "IdModele", "Km", "Matricule", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, false, new DateTime(2022, 12, 20, 6, 24, 15, 973, DateTimeKind.Local).AddTicks(8768), 8, 16, 1582, "blyhdukbik", "mznqshfdqt", 3, 4, 373.0, "Véhicule" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Airbag", "CreatedAt", "IdAgence", "IdModele", "Km", "Matricule", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2022, 9, 20, 2, 50, 55, 142, DateTimeKind.Local).AddTicks(7936), 9, 286, 9619, "mvflhimjix", "kiuezmqhei", 5, 4, 349.0, "Véhicule" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2022, 10, 17, 9, 2, 1, 26, DateTimeKind.Local).AddTicks(6592), "Hybride", 9, 189, 4944, "bkjicsyqjx", "Automatique", "sntplfspgk", 7, 8, 244.0, "Utilitaire" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdModele", "Km", "Matricule", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2022, 9, 5, 16, 2, 49, 838, DateTimeKind.Local).AddTicks(5660), "Diesel", 251, 1586, "icfjephfsr", "lhieflwxsa", 4, 6, 493.0, "Utilitaire" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdModele", "Km", "Matricule", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2022, 9, 21, 14, 23, 51, 584, DateTimeKind.Local).AddTicks(9913), "Hybride", 276, 4108, "oirgvqgzdd", "hdlgtjwhif", 10, 7, 434.0, "Utilitaire" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "Prix", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 20, 13, 77, DateTimeKind.Local).AddTicks(1683), 196, "lkgwzuetzs", 344.0, "Fisher", 21, "Larson, Ullrich and Cronin", "Yasmeen", "931.719.5104 x4919", "Becker", "Grimesburgh", "02105" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IdModele", "Moteur", "NumeroReservation", "Prix", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 4, 23, 1, 36, 27, 756, DateTimeKind.Local).AddTicks(2533), 2, "Manuelle", "ossmeafbja", 228.0, "Crist", 19, "Koepp, Schiller and Stanton", "Lillie", "(921) 873-3075 x70365", "Gislason", "Rosenbaumview", "47135" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "NumeroReservation", "Prix", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 9, 2, 11, 11, 3, 722, DateTimeKind.Local).AddTicks(6170), "Essence", 316, "iwalqfxsuw", 214.0, "Hickle", 30, "Sanford, Hand and Lind", "Danyka", "927-783-0285 x5358", "Schneider", "South Jaquanborough", "11346" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "Prix", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 3, 12, 14, 12, 33, 581, DateTimeKind.Local).AddTicks(1354), "Hybride", 14, "Automatique", "bfdyayesox", 467.0, "Wolff", 32, "Lindgren, Koepp and Huels", "Stanton", "(280) 949-9154 x851", "Krajcik", "Nelsonfort", "47978" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "Prix", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 9, 29, 1, 40, 29, 83, DateTimeKind.Local).AddTicks(7643), "Hybride", 57, "Manuelle", "ownhifzykj", 222.0, "Koch", 33, "Schowalter - Armstrong", "Gabrielle", "(597) 224-5488 x668", "Schaefer", "Alicehaven", "30549" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "NumeroReservation", "Prix", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 9, 28, 17, 57, 0, 51, DateTimeKind.Local).AddTicks(1793), "Électrique", 38, "xkmagiwqbx", 478.0, "Cremin", 33, "Frami, Cummings and Luettgen", "Elsa", "520.593.4639 x82366", "Corkery", "Carletonshire", "46033-3964" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "NumeroReservation", "Prix", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 9, 8, 12, 35, 46, 385, DateTimeKind.Local).AddTicks(4954), "Électrique", 322, "zpodkrlwll", 285.0, "Lemke", 24, "Schneider - Jerde", "Selina", "(963) 794-4741 x3812", "Jones", "Pietromouth", "23802" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "NumeroReservation", "Prix", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 10, 18, 22, 42, 5, 242, DateTimeKind.Local).AddTicks(7317), "Électrique", 187, "ytnohlupec", 449.0, "Bogan", 20, "Glover - Bailey", "Chaya", "226.655.2566 x78201", "Lehner", "East Mollie", "73810-8587" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "NumeroReservation", "Prix", "description", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 11, 3, 9, 44, 42, 622, DateTimeKind.Local).AddTicks(7296), "Hybride", 187, "rnjbhtysxs", 427.0, "Padberg", "Predovic - Dare", "Kelsi", "918.741.0368", "Gottlieb", "Port Ruben", "65294" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "NumeroReservation", "Prix", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 10, 9, 9, 7, 7, 32, DateTimeKind.Local).AddTicks(6858), "Essence", 256, "zfcgfzpdur", 395.0, "Dooley", 27, "Ebert and Sons", "Vincenzo", "(424) 247-0064 x9338", "Klocko", "East Keventon", "35528-5291" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "IdPermission", "IdRole" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "IsVerified", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "961 Rosamond Cape", "Essaouira", new DateTime(2023, 1, 18, 19, 39, 17, 365, DateTimeKind.Local).AddTicks(4904), "David.Bruen65@gmail.com", false, -10.358599999999999, 110.3096, "Dynamic Creative Developer", "(811) 663-9853 x18021", "09094" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "IsVerified", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "20773 Renner Tunnel", "Tinghir", new DateTime(2022, 11, 3, 3, 38, 42, 783, DateTimeKind.Local).AddTicks(2428), "Aiyana_OHara89@gmail.com", false, 56.718000000000004, 101.8951, "Customer Interactions Developer", "1-836-536-6582", "31210-8599" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "IsVerified", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "136 Carroll Falls", "Chefchaouen", new DateTime(2023, 5, 16, 14, 38, 34, 550, DateTimeKind.Local).AddTicks(4133), "Jaqueline21@yahoo.com", false, 51.052300000000002, 22.684999999999999, "Internal Applications Assistant", "(559) 236-7888 x0298", "86506-0827" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "IsVerified", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "928 Purdy Land", "Tinghir", new DateTime(2023, 3, 9, 9, 43, 53, 938, DateTimeKind.Local).AddTicks(9309), "Donato_Reinger26@hotmail.com", false, -51.930500000000002, -143.4743, "Central Web Officer", "286-881-0534", "63149" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "0604 Jerad Cape", "Safi", new DateTime(2023, 5, 25, 23, 30, 5, 361, DateTimeKind.Local).AddTicks(4139), "Norris.Deckow43@yahoo.com", 17.687200000000001, 149.2662, "Internal Integration Representative", "(951) 213-2709", "82968" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "IsVerified", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "5460 Marie Mountains", "Casablanca", new DateTime(2022, 11, 16, 19, 10, 28, 96, DateTimeKind.Local).AddTicks(8825), "Winnifred95@gmail.com", false, 37.734200000000001, -52.897399999999998, "District Usability Administrator", "1-697-408-2494 x2965", "04772-3115" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "IsVerified", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "493 Camryn Landing", "Marrakech", new DateTime(2023, 4, 19, 10, 23, 41, 847, DateTimeKind.Local).AddTicks(4434), "Madisen_Jones83@yahoo.com", false, -81.011600000000001, 88.531300000000002, "District Interactions Planner", "354-357-7815", "06511-5705" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "IsVerified", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "531 Gulgowski Plains", "Chefchaouen", new DateTime(2023, 6, 19, 1, 55, 40, 414, DateTimeKind.Local).AddTicks(2331), "Cristopher.Howe@yahoo.com", false, 78.594499999999996, 39.233899999999998, "Investor Program Agent", "491-658-3500 x42939", "10933-5078" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "93950 Pacocha Unions", "Marrakech", new DateTime(2022, 10, 30, 9, 25, 57, 865, DateTimeKind.Local).AddTicks(9298), "Lukas.Little37@yahoo.com", 67.213099999999997, -35.776699999999998, "Customer Directives Planner", "(860) 662-2143 x89324", "13694-5230" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "IsVerified", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "255 Towne Mount", "Safi", new DateTime(2023, 2, 16, 17, 51, 3, 533, DateTimeKind.Local).AddTicks(9652), "Jaleel.Bernier@hotmail.com", false, 38.743400000000001, -62.353099999999998, "Investor Creative Engineer", "792-459-1003 x110", "18916-0691" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "37098 Turcotte Underpass", "90929 Clementine Expressway", new DateTime(2023, 4, 6, 15, 37, 19, 67, DateTimeKind.Local).AddTicks(2287), "Carlotta_Jacobi@gmail.com", "Denis", "Kilback", "https://picsum.photos/640/480/?image=739", "https://picsum.photos/640/480/?image=1069", "(312) 204-1431", "South Candida", "51049" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "4918 Claudie Mountain", "44470 Martina Forks", new DateTime(2023, 5, 10, 22, 14, 0, 324, DateTimeKind.Local).AddTicks(7291), "Doug_Brakus@yahoo.com", "Raleigh", "Mertz", "https://picsum.photos/640/480/?image=572", "https://picsum.photos/640/480/?image=117", "1-206-813-5230 x3493", "Goyettestad", "68444" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "035 Barrows Inlet", "2282 Okuneva Spring", new DateTime(2023, 2, 26, 23, 34, 57, 83, DateTimeKind.Local).AddTicks(6745), "Jabari.Nader@hotmail.com", "Rocio", "Schaden", "https://picsum.photos/640/480/?image=452", "https://picsum.photos/640/480/?image=992", "447.565.5870", "Port Anissaville", "23966-7062" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "0210 Skiles Turnpike", "36122 O'Reilly Square", new DateTime(2022, 10, 21, 8, 45, 48, 861, DateTimeKind.Local).AddTicks(8200), "Alysha_Kunze@yahoo.com", "Lacey", "Hartmann", "https://picsum.photos/640/480/?image=584", "https://picsum.photos/640/480/?image=1032", "1-604-787-2529 x52925", "Lake Kelleyside", "93987-8752" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "869 Grimes Ridges", "434 Garrett Haven", new DateTime(2023, 7, 31, 15, 42, 27, 250, DateTimeKind.Local).AddTicks(5893), "Evert.Schmidt89@hotmail.com", "Audrey", "Rau", "https://picsum.photos/640/480/?image=321", "https://picsum.photos/640/480/?image=824", "1-420-562-0371", "North Murphy", "89617-4976" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "134 Schuster Course", "1133 Hyman Forest", new DateTime(2023, 6, 11, 14, 38, 16, 539, DateTimeKind.Local).AddTicks(7499), "Isidro.Wintheiser@gmail.com", "Orrin", "Smitham", "https://picsum.photos/640/480/?image=558", "https://picsum.photos/640/480/?image=279", "242.852.5437 x456", "Lake Oral", "03113-9463" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "5476 Hauck Spring", "401 Tremblay Mount", new DateTime(2023, 1, 31, 18, 23, 48, 939, DateTimeKind.Local).AddTicks(116), "Luciano_Conn@gmail.com", "Ally", "Kuhic", "https://picsum.photos/640/480/?image=815", "https://picsum.photos/640/480/?image=887", "1-263-430-4685 x574", "East Amir", "25799" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "665 Erdman Terrace", "1757 Einar Flat", new DateTime(2023, 3, 4, 16, 20, 39, 687, DateTimeKind.Local).AddTicks(1184), "Chanelle.Lueilwitz26@gmail.com", "Eliseo", "Gerhold", "https://picsum.photos/640/480/?image=824", "https://picsum.photos/640/480/?image=1037", "1-985-624-7759", "Roslynbury", "62764-2398" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "9675 Bernier Ranch", "42397 Windler Ramp", new DateTime(2023, 7, 22, 12, 21, 49, 690, DateTimeKind.Local).AddTicks(9293), "Felipe16@hotmail.com", "Karen", "Streich", "https://picsum.photos/640/480/?image=861", "https://picsum.photos/640/480/?image=978", "573.369.0743 x783", "Blickborough", "67386" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "173 Murphy Plaza", "7052 Corwin Viaduct", new DateTime(2022, 8, 31, 17, 38, 52, 944, DateTimeKind.Local).AddTicks(7091), "Lacy.Hand58@gmail.com", "Beau", "Bruen", "https://picsum.photos/640/480/?image=610", "https://picsum.photos/640/480/?image=140", "483.529.0279", "South Stan", "20678" });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 2, 7, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 5, 7 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 3,
                column: "IdClient",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 4,
                column: "IdReservation",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 4, 6, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 2, 7, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 6, 5, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 9, 1, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 9,
                column: "IdClient",
                value: 5);

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
                values: new object[] { new DateTime(2023, 8, 24, 2, 15, 3, 138, DateTimeKind.Local).AddTicks(4196), new DateTime(2023, 8, 25, 18, 50, 4, 27, DateTimeKind.Local).AddTicks(3126), new DateTime(2024, 2, 21, 21, 6, 43, 195, DateTimeKind.Local).AddTicks(2731), 1, 231.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 24, 6, 9, 1, 676, DateTimeKind.Local).AddTicks(8240), new DateTime(2023, 8, 25, 6, 28, 18, 190, DateTimeKind.Local).AddTicks(8527), new DateTime(2024, 6, 9, 16, 47, 27, 230, DateTimeKind.Local).AddTicks(1248), 1, 384.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 24, 9, 24, 12, 391, DateTimeKind.Local).AddTicks(4101), new DateTime(2023, 8, 25, 8, 25, 41, 740, DateTimeKind.Local).AddTicks(3444), new DateTime(2024, 6, 3, 15, 12, 55, 53, DateTimeKind.Local).AddTicks(6200), 10, 442.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 24, 20, 18, 12, 670, DateTimeKind.Local).AddTicks(6998), new DateTime(2023, 8, 25, 11, 35, 35, 463, DateTimeKind.Local).AddTicks(8870), new DateTime(2024, 3, 18, 0, 0, 11, 896, DateTimeKind.Local).AddTicks(3037), 5, 209.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 24, 7, 50, 19, 514, DateTimeKind.Local).AddTicks(2668), new DateTime(2023, 8, 25, 20, 20, 56, 318, DateTimeKind.Local).AddTicks(482), new DateTime(2024, 1, 28, 5, 9, 17, 861, DateTimeKind.Local).AddTicks(695), 8, 401.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 24, 4, 38, 55, 588, DateTimeKind.Local).AddTicks(8980), new DateTime(2023, 8, 25, 8, 2, 47, 491, DateTimeKind.Local).AddTicks(8394), new DateTime(2023, 8, 31, 1, 23, 4, 866, DateTimeKind.Local).AddTicks(8870), 10, 372.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 24, 3, 0, 11, 299, DateTimeKind.Local).AddTicks(7499), new DateTime(2023, 8, 24, 21, 54, 5, 104, DateTimeKind.Local).AddTicks(25), new DateTime(2023, 8, 26, 15, 58, 59, 202, DateTimeKind.Local).AddTicks(6106), 3, 475.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 23, 22, 18, 19, 35, DateTimeKind.Local).AddTicks(4199), new DateTime(2023, 8, 25, 2, 15, 54, 631, DateTimeKind.Local).AddTicks(7149), new DateTime(2024, 1, 23, 20, 49, 48, 953, DateTimeKind.Local).AddTicks(2930), 6, 274.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 24, 14, 41, 44, 666, DateTimeKind.Local).AddTicks(3658), new DateTime(2023, 8, 25, 1, 40, 50, 308, DateTimeKind.Local).AddTicks(3895), new DateTime(2024, 4, 26, 3, 39, 13, 232, DateTimeKind.Local).AddTicks(7133), 7, 303.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 24, 4, 37, 58, 294, DateTimeKind.Local).AddTicks(9748), new DateTime(2023, 8, 25, 1, 27, 5, 384, DateTimeKind.Local).AddTicks(705), new DateTime(2023, 9, 27, 1, 44, 29, 461, DateTimeKind.Local).AddTicks(1845), 10, 286.0, false });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Dashboard");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Users");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Permissions");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Agences");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Modeles");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Reservations");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Clients");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "LongTerm");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Vehicles");

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[] { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "LogJournal", null });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 24, 19, 51, 35, 257, DateTimeKind.Local).AddTicks(8506), new DateTime(2023, 8, 25, 18, 35, 49, 484, DateTimeKind.Local).AddTicks(643), new DateTime(2024, 1, 1, 0, 55, 22, 382, DateTimeKind.Local).AddTicks(1950), 5, "2c85da62-b500-4ab4-b2fe-8ec3c86cca15" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 24, 13, 15, 43, 741, DateTimeKind.Local).AddTicks(7741), new DateTime(2023, 8, 24, 23, 16, 23, 312, DateTimeKind.Local).AddTicks(1429), new DateTime(2024, 7, 8, 0, 57, 32, 247, DateTimeKind.Local).AddTicks(8721), 6, "fd66fbf8-e7b3-4f06-aeaa-8db7e99edff6", "Expiré" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 24, 17, 28, 25, 260, DateTimeKind.Local).AddTicks(1789), new DateTime(2023, 8, 25, 21, 49, 37, 554, DateTimeKind.Local).AddTicks(4591), new DateTime(2024, 3, 31, 2, 27, 38, 0, DateTimeKind.Local).AddTicks(9139), 8, "ac60dcd5-78a7-42e9-adf8-10d41a4e555f", "Confirmé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 24, 11, 10, 25, 267, DateTimeKind.Local).AddTicks(3936), new DateTime(2023, 8, 25, 9, 46, 40, 802, DateTimeKind.Local).AddTicks(6350), new DateTime(2023, 10, 23, 4, 21, 17, 204, DateTimeKind.Local).AddTicks(6589), 5, "934bbd66-79fc-45ec-a187-523647e2f40c" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 24, 1, 58, 27, 575, DateTimeKind.Local).AddTicks(6585), new DateTime(2023, 8, 25, 11, 31, 40, 818, DateTimeKind.Local).AddTicks(5942), new DateTime(2023, 12, 8, 2, 53, 57, 962, DateTimeKind.Local).AddTicks(8869), 7, "1382f95f-aedf-4ed6-837f-4a5f90fa5a90" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 24, 2, 56, 10, 395, DateTimeKind.Local).AddTicks(3123), new DateTime(2023, 8, 25, 6, 49, 18, 682, DateTimeKind.Local).AddTicks(3893), new DateTime(2024, 4, 16, 11, 54, 37, 70, DateTimeKind.Local).AddTicks(5590), 10, "11d770d5-d1ab-4110-9a69-d7a8b1f1c657", "Confirmé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 24, 11, 45, 27, 743, DateTimeKind.Local).AddTicks(1676), new DateTime(2023, 8, 25, 19, 39, 55, 589, DateTimeKind.Local).AddTicks(8735), new DateTime(2024, 6, 17, 16, 19, 25, 582, DateTimeKind.Local).AddTicks(2646), 2, "5e1476c0-ceec-4bdf-b156-f6420c1d12a2", "Confirmé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 24, 9, 30, 41, 796, DateTimeKind.Local).AddTicks(2380), new DateTime(2023, 8, 25, 1, 4, 17, 622, DateTimeKind.Local).AddTicks(8581), new DateTime(2024, 3, 18, 11, 11, 40, 969, DateTimeKind.Local).AddTicks(2508), 7, "713a5685-584f-4c47-8527-30f8f952c2e7", "Annulé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 23, 23, 27, 39, 594, DateTimeKind.Local).AddTicks(8213), new DateTime(2023, 8, 25, 2, 10, 52, 516, DateTimeKind.Local).AddTicks(3314), new DateTime(2024, 8, 21, 7, 0, 6, 859, DateTimeKind.Local).AddTicks(4567), 3, "86edb941-2201-48ff-93fe-fffc928a0e77", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 24, 2, 36, 28, 8, DateTimeKind.Local).AddTicks(7926), new DateTime(2023, 8, 25, 3, 47, 56, 951, DateTimeKind.Local).AddTicks(3688), new DateTime(2024, 2, 18, 3, 24, 8, 653, DateTimeKind.Local).AddTicks(5436), 7, "2dc7ef4f-f324-41dc-b436-9fb1df8fc5d4", "Annulé" });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "IdPermission", "IdRole", "CreatedAt", "DeletedAt", "Id", "UpdatedAt" },
                values: new object[,]
                {
                    { 4, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null },
                    { 12, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 7, 10, 13, 6, 44, 401, DateTimeKind.Local).AddTicks(9349), "Evan6@gmail.com", "Jessy", 7, "Cassin", "$2a$11$.9EgvL7g3PJgSutaiOu/UOuFm1Gsy5juxu81lHjY/kopvkhzt1/aG" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 11, 9, 19, 34, 8, 624, DateTimeKind.Local).AddTicks(1566), "Ruby93@gmail.com", "Claude", "Kovacek", "$2a$11$npiaq4qjFxsnqF2glwL4tuTnqyrXgRe1D.5SvHCER.EkDMLVhwpgm" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 7, 12, 6, 57, 17, 18, DateTimeKind.Local).AddTicks(6423), "Mittie.Hauck@gmail.com", "Flo", 2, "Kuhic", "$2a$11$2SZf/pdCXScg8HvPxP3ubOGQ48ACW54ssEaTsGMgboj/CpZo757dC" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 7, 4, 28, 22, 520, DateTimeKind.Local).AddTicks(9602), "Mallie_Schroeder16@gmail.com", "Max", 7, "Morar", "$2a$11$cCTKHfMEcgmz9uprFnBzD.IyB0EeiO.42Lfy8BsAgzTa8zT2R2Wti" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 8, 6, 1, 45, 8, 127, DateTimeKind.Local).AddTicks(7672), "Norwood_Frami@hotmail.com", "Doris", 8, "White", "$2a$11$IAOslXdnQLDGywJSQR1FRutBRNI.sHQ3r8rJyE/SE5cw78sEZg6/O" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 10, 20, 7, 6, 20, 270, DateTimeKind.Local).AddTicks(1014), "Landen.Nader@hotmail.com", "Russel", 8, 1, true, "Reichert", "$2a$11$WZnbBcmMAwh.NNz54IfOl.3kjQ6IWzHJ6q0GPTIXp3GzWrkVIAh/C" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 26, 16, 49, 55, 675, DateTimeKind.Local).AddTicks(4708), "Benton74@hotmail.com", "Yasmeen", 5, 2, "Schuster", "$2a$11$kMrHmQzsJNQu8p73426TQuRyjLdSMpAe2P7wovEpmkWWyM6kdAQzS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 13, 14, 53, 20, 517, DateTimeKind.Local).AddTicks(8667), "Chelsea39@yahoo.com", "Milton", 10, true, "Ziemann", "$2a$11$zNhp37vgJxSB1wsTlsKTX.unCkHLLzrzxga2VVve7Ouuqu80mNreO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 8, 23, 18, 29, 41, 647, DateTimeKind.Local).AddTicks(8423), "Jamal.Powlowski@gmail.com", "Lambert", 2, "Ankunding", "$2a$11$wQFDs1pOUSrM60thpwymsuZaZ/Aq7MHCAyhD75c0IcUXJ9TAZcyqm" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 2, 28, 12, 52, 48, 873, DateTimeKind.Local).AddTicks(4518), "Gino32@gmail.com", "David", 8, true, "Miller", "$2a$11$vFFnAZ4ZvRE387bPWj7HiuPsXeSyWRN/Cf0NoVHW1ukPBwaGDfO1y" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, true, new DateTime(2023, 4, 7, 18, 9, 6, 616, DateTimeKind.Local).AddTicks(7572), "Diesel", 4, 131, 4880, "suxpxcvnbg", "Automatique", "ktcnhvichm", 4, 4, 299.0, "egwywqdjzz" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2023, 6, 8, 13, 32, 6, 112, DateTimeKind.Local).AddTicks(3866), "Hybride", 7, 84, 796, "vtxndoqszq", "lcgyjmstyf", 4, 10, 385.0, "xqyqvpfyrn" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, false, new DateTime(2023, 4, 14, 1, 41, 2, 609, DateTimeKind.Local).AddTicks(3334), "Essence", 3, 66, 5089, "vmvwhzghqp", "Manuelle", "erbaldrkss", 6, 4, 239.0, "jpajcsbelg" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Name", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2023, 7, 25, 16, 48, 14, 201, DateTimeKind.Local).AddTicks(5874), "Essence", 7, 261, 7738, "yyttzekduu", "znlkrbyfin", 8, 475.0, "gqtcfcfcmx" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2023, 2, 26, 15, 1, 29, 568, DateTimeKind.Local).AddTicks(8494), "Essence", 9, 278, 3368, "xxsepjfovc", "Manuelle", "hpzteekdzb", 2, 4, 294.0, "uutnkiizsj" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "IdAgence", "IdModele", "Km", "Matricule", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, true, new DateTime(2023, 8, 19, 18, 46, 46, 801, DateTimeKind.Local).AddTicks(6497), 7, 17, 3770, "tjgpaqgsxk", "ksdgweakpt", 7, 3, 437.0, "gqmvbnwrcg" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Airbag", "CreatedAt", "IdAgence", "IdModele", "Km", "Matricule", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2022, 11, 23, 16, 5, 21, 794, DateTimeKind.Local).AddTicks(7950), 8, 48, 9610, "txysxlnfch", "qstfedvepj", 6, 7, 418.0, "jtuiaiaclq" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2023, 4, 27, 5, 16, 31, 773, DateTimeKind.Local).AddTicks(4999), "Électrique", 2, 313, 5651, "dxxpqapvml", "Manuelle", "survrbrzpo", 1, 7, 422.0, "jhvkvggjol" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdModele", "Km", "Matricule", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2023, 1, 1, 6, 29, 52, 874, DateTimeKind.Local).AddTicks(63), "Hybride", 276, 1351, "edrwyiphmu", "nejtozubog", 2, 8, 481.0, "kexoodkmqr" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdModele", "Km", "Matricule", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2023, 8, 13, 12, 42, 22, 887, DateTimeKind.Local).AddTicks(5092), "Essence", 275, 93, "zvtvedisee", "ailtqzjtmb", 8, 2, 289.0, "mpxczqsgyv" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "Prix", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 9, 18, 20, 38, 42, 528, DateTimeKind.Local).AddTicks(961), 19, "cdbodvswlg", 249.0, "O'Hara", 26, "Pfannerstill, Kerluke and Kutch", "Selena", "714-955-0481 x6264", "Vandervort", "Roselynview", "14466-8940" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IdModele", "Moteur", "NumeroReservation", "Prix", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 8, 14, 7, 22, 34, 58, DateTimeKind.Local).AddTicks(6008), 215, "Automatique", "xkdybvssky", 344.0, "Schinner", 21, "O'Connell and Sons", "Wilford", "1-463-285-2754 x12246", "Dickinson", "Kirlinberg", "21498" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "NumeroReservation", "Prix", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 11, 29, 7, 24, 19, 293, DateTimeKind.Local).AddTicks(7363), "Électrique", 270, "lmdxtezbkw", 296.0, "Mayert", 20, "Blick, Senger and Hane", "Raegan", "1-827-444-4870 x6782", "Gutkowski", "New Zetta", "20051-8043" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "Prix", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 1, 14, 5, 39, 8, 68, DateTimeKind.Local).AddTicks(7380), "Électrique", 84, "Manuelle", "dktjsrcwjq", 264.0, "Hartmann", 29, "Gulgowski Group", "Jessyca", "866.617.5858", "Reynolds", "South Markuschester", "67823" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "Prix", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 11, 17, 9, 44, 15, 490, DateTimeKind.Local).AddTicks(7353), "Diesel", 103, "Automatique", "jijrranpps", 337.0, "Stroman", 29, "Smith Group", "Arlie", "1-833-866-9677", "Rolfson", "Schummstad", "22997-2886" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "NumeroReservation", "Prix", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 24, 9, 436, DateTimeKind.Local).AddTicks(7423), "Essence", 256, "rxuyvsnxxe", 300.0, "Gutkowski", 28, "Muller - Gottlieb", "Savanna", "1-223-567-7719 x69935", "Kirlin", "West Vidal", "45439" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "NumeroReservation", "Prix", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 5, 16, 23, 17, 18, 33, DateTimeKind.Local).AddTicks(7404), "Essence", 122, "jgggyzxvfh", 343.0, "Hand", 32, "O'Connell and Sons", "Valentina", "416.631.0244 x516", "Hackett", "Krisbury", "36946" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "NumeroReservation", "Prix", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 12, 4, 21, 4, 53, 620, DateTimeKind.Local).AddTicks(7762), "Diesel", 282, "giefrzdnig", 221.0, "Yost", 23, "Cremin, Schultz and Wilkinson", "Madaline", "1-263-257-9564", "Gislason", "Lake Peteborough", "86502-8611" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "NumeroReservation", "Prix", "description", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 10, 6, 9, 57, 6, 815, DateTimeKind.Local).AddTicks(9319), "Essence", 22, "leuxufmgux", 399.0, "Fay", "Wolf, Langosh and Hermiston", "Marshall", "1-511-801-3195 x2971", "Lebsack", "Kaitlinshire", "71065" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "NumeroReservation", "Prix", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 9, 2, 16, 9, 4, 944, DateTimeKind.Local).AddTicks(2692), "Électrique", 113, "jnpiehnwew", 368.0, "Bins", 25, "Kulas, Beier and Weimann", "Antonetta", "1-764-751-5639", "Kuhlman", "Wizafort", "15100" });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "IdPermission", "IdRole", "CreatedAt", "DeletedAt", "Id", "UpdatedAt" },
                values: new object[] { 13, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null });
        }
    }
}
