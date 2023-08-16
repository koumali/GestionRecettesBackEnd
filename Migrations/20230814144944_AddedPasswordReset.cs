using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace AutomotiveApi.Migrations
{
    /// <inheritdoc />
    public partial class AddedPasswordReset : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsVerified",
                table: "Users",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsVerified",
                table: "Clients",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PasswordResetTokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Token = table.Column<string>(type: "longtext", nullable: false),
                    Email = table.Column<string>(type: "longtext", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PasswordResetTokens", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "1948 Moore Run", "Bettyhaven", new DateTime(2023, 4, 25, 18, 36, 33, 917, DateTimeKind.Local).AddTicks(3555), "Dorothy_Bernhard94@gmail.com", 33.591299999999997, 9.9842999999999993, "Global Accountability Officer", "(804) 782-5580 x07045", "02100-0472" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "49823 Cremin Bridge", "Rathtown", new DateTime(2023, 4, 26, 8, 50, 8, 248, DateTimeKind.Local).AddTicks(7044), "Clemmie.Koelpin@gmail.com", -11.0352, -35.985399999999998, "Internal Directives Supervisor", "(600) 517-6293 x3232", "99176" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "41596 Eileen Parkway", "North Reese", new DateTime(2022, 12, 12, 14, 2, 58, 124, DateTimeKind.Local).AddTicks(6714), "Sheridan24@gmail.com", 74.242599999999996, 104.2817, "Senior Functionality Coordinator", "1-682-242-9750 x599", "20456-6762" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "17295 Braxton Cape", "New Felipeburgh", new DateTime(2023, 2, 5, 3, 33, 13, 180, DateTimeKind.Local).AddTicks(6128), "Carmel31@hotmail.com", -82.132000000000005, -141.21789999999999, "Corporate Metrics Architect", "741-637-8719", "40721" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "441 Jazlyn Stravenue", "Gerryview", new DateTime(2022, 12, 10, 23, 22, 44, 938, DateTimeKind.Local).AddTicks(2909), "Emmalee_Reichert63@gmail.com", 54.717599999999997, -3.516, "Product Intranet Producer", "347-862-4514", "28026" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "20759 Gislason Club", "Jadenborough", new DateTime(2023, 7, 18, 6, 44, 30, 787, DateTimeKind.Local).AddTicks(2498), "Hazle23@gmail.com", 14.893700000000001, -5.7694999999999999, "Dynamic Mobility Director", "(869) 818-1969", "06121-1485" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "7195 Robyn Gardens", "North Alizemouth", new DateTime(2023, 3, 23, 16, 20, 45, 311, DateTimeKind.Local).AddTicks(1104), "Kris_Wilkinson37@yahoo.com", -20.657900000000001, -136.16370000000001, "Forward Applications Assistant", "(258) 916-9908 x900", "36738-1064" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "2639 Maximillia Extension", "Lockmanburgh", new DateTime(2023, 4, 15, 20, 6, 44, 655, DateTimeKind.Local).AddTicks(2057), "Pat62@yahoo.com", -76.888400000000004, 127.92019999999999, "Internal Solutions Consultant", "1-496-840-0140 x758", "78617-3648" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "46116 Augustine Stravenue", "Hirtheshire", new DateTime(2022, 9, 20, 18, 0, 13, 454, DateTimeKind.Local).AddTicks(974), "Kaitlyn_Collier@hotmail.com", 56.150399999999998, -71.494900000000001, "Principal Infrastructure Supervisor", "1-665-740-4486 x87518", "96734-1302" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "044 Ernser Greens", "South Alistad", new DateTime(2022, 9, 22, 6, 16, 8, 944, DateTimeKind.Local).AddTicks(5713), "Roscoe23@yahoo.com", -53.171599999999998, 156.97980000000001, "Legacy Data Planner", "1-644-790-2966 x81488", "45261" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "IsVerified", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "805 Ullrich Flat", "18634 Legros Green", new DateTime(2023, 7, 28, 15, 51, 7, 742, DateTimeKind.Local).AddTicks(2724), "Zita30@gmail.com", "Gladyce", false, "Kling", "https://picsum.photos/640/480/?image=368", "https://picsum.photos/640/480/?image=1059", "1-719-910-1686", "Esmeraldahaven", "77454" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "IsVerified", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "9565 Lois Walks", "4922 Edmond Alley", new DateTime(2022, 12, 26, 8, 5, 11, 137, DateTimeKind.Local).AddTicks(5173), "Gideon.Borer@hotmail.com", "Arden", false, "Collins", "https://picsum.photos/640/480/?image=557", "https://picsum.photos/640/480/?image=446", "714-280-7605 x01699", "Nolanborough", "46933-8561" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "IsVerified", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "5320 Brain Meadow", "04033 Annette Ford", new DateTime(2023, 1, 18, 1, 57, 16, 799, DateTimeKind.Local).AddTicks(2450), "Otha.McGlynn23@yahoo.com", "Lorenz", false, "Boehm", "https://picsum.photos/640/480/?image=160", "https://picsum.photos/640/480/?image=285", "(811) 577-6758", "Demetriusmouth", "88239" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "IsVerified", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "4772 Yost Spur", "090 Delphia Valley", new DateTime(2023, 3, 17, 18, 34, 1, 410, DateTimeKind.Local).AddTicks(1045), "Jennifer_Prohaska72@gmail.com", "Jevon", false, "Bergnaum", "https://picsum.photos/640/480/?image=763", "https://picsum.photos/640/480/?image=953", "488.920.0629 x5948", "West Vicky", "35670-1577" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "IsVerified", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "359 Ondricka Mountain", "36285 Dicki Greens", new DateTime(2022, 11, 25, 11, 47, 2, 595, DateTimeKind.Local).AddTicks(9287), "Westley.OConnell@yahoo.com", "Viva", false, "Shanahan", "https://picsum.photos/640/480/?image=891", "https://picsum.photos/640/480/?image=331", "1-362-647-3306 x14021", "Alyshatown", "99753" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "IsVerified", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "42886 Gabriella Cliffs", "6075 Elsa Points", new DateTime(2023, 7, 30, 18, 40, 18, 43, DateTimeKind.Local).AddTicks(1246), "Jaclyn.Yost52@yahoo.com", "Rowena", false, "Marvin", "https://picsum.photos/640/480/?image=784", "https://picsum.photos/640/480/?image=576", "1-968-588-3284 x382", "Lake Marjorieville", "76715" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "IsVerified", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "6992 Swift Ford", "392 Elmira Mission", new DateTime(2022, 9, 25, 18, 48, 23, 726, DateTimeKind.Local).AddTicks(915), "Halie_Beer@hotmail.com", "Milton", false, "Terry", "https://picsum.photos/640/480/?image=335", "https://picsum.photos/640/480/?image=110", "436.816.8038", "Strackeborough", "79129" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "IsVerified", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "575 Carole Lock", "5358 Russ Turnpike", new DateTime(2023, 1, 9, 1, 11, 26, 529, DateTimeKind.Local).AddTicks(546), "Chesley_Wuckert@hotmail.com", "Emelie", false, "Stokes", "https://picsum.photos/640/480/?image=545", "https://picsum.photos/640/480/?image=801", "1-457-913-6100 x91349", "New Ruthie", "94559" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "IsVerified", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "817 Kaitlyn Ridges", "03433 Walker Light", new DateTime(2023, 7, 23, 9, 29, 7, 33, DateTimeKind.Local).AddTicks(7797), "Wyman.Hammes@gmail.com", "Laurence", false, "Rogahn", "https://picsum.photos/640/480/?image=1082", "https://picsum.photos/640/480/?image=140", "890.363.3568 x83831", "Port Bart", "40442-8622" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "IsVerified", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "783 Kuphal Mountain", "00695 Boyle Forge", new DateTime(2022, 9, 13, 20, 51, 15, 298, DateTimeKind.Local).AddTicks(5056), "Aisha56@gmail.com", "Elody", false, "Schumm", "https://picsum.photos/640/480/?image=285", "https://picsum.photos/640/480/?image=113", "(901) 838-4927 x2791", "Carrollfort", "64311" });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IdClient", "IsConducteur" },
                values: new object[] { 1, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 3, 6 });

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
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 10, 9, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 9, 5 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IdClient", "IsConducteur" },
                values: new object[] { 2, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 5, 4, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 2, 7 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 10,
                column: "IdReservation",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 14, 14, 3, 34, 631, DateTimeKind.Local).AddTicks(3092), new DateTime(2023, 8, 14, 17, 8, 44, 173, DateTimeKind.Local).AddTicks(9282), new DateTime(2023, 9, 11, 23, 30, 50, 631, DateTimeKind.Local).AddTicks(1659), 2, 4.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 14, 11, 29, 41, 424, DateTimeKind.Local).AddTicks(2552), new DateTime(2023, 8, 14, 21, 17, 29, 127, DateTimeKind.Local).AddTicks(9335), new DateTime(2024, 3, 12, 12, 49, 45, 916, DateTimeKind.Local).AddTicks(6847), 7, 6.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "Prix" },
                values: new object[] { new DateTime(2023, 8, 13, 18, 0, 53, 191, DateTimeKind.Local).AddTicks(6716), new DateTime(2023, 8, 15, 0, 17, 1, 963, DateTimeKind.Local).AddTicks(5505), new DateTime(2024, 6, 13, 15, 24, 49, 759, DateTimeKind.Local).AddTicks(4724), 8.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 14, 14, 27, 37, 743, DateTimeKind.Local).AddTicks(632), new DateTime(2023, 8, 15, 8, 41, 46, 990, DateTimeKind.Local).AddTicks(1104), new DateTime(2023, 8, 15, 14, 39, 49, 450, DateTimeKind.Local).AddTicks(2092), 5, 7.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 14, 11, 20, 1, 578, DateTimeKind.Local).AddTicks(6273), new DateTime(2023, 8, 15, 1, 4, 8, 734, DateTimeKind.Local).AddTicks(9931), new DateTime(2024, 1, 16, 8, 14, 37, 477, DateTimeKind.Local).AddTicks(6595), 8, 4.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 13, 21, 13, 16, 37, DateTimeKind.Local).AddTicks(8512), new DateTime(2023, 8, 15, 9, 8, 18, 122, DateTimeKind.Local).AddTicks(519), new DateTime(2024, 6, 20, 5, 23, 20, 613, DateTimeKind.Local).AddTicks(2857), 8, 6.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 14, 1, 51, 3, 550, DateTimeKind.Local).AddTicks(5969), new DateTime(2023, 8, 15, 12, 51, 27, 360, DateTimeKind.Local).AddTicks(1587), new DateTime(2023, 11, 25, 1, 31, 11, 481, DateTimeKind.Local).AddTicks(3498), 1, 4.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 14, 6, 25, 9, 591, DateTimeKind.Local).AddTicks(5204), new DateTime(2023, 8, 15, 12, 7, 42, 993, DateTimeKind.Local).AddTicks(7483), new DateTime(2023, 12, 31, 23, 19, 23, 354, DateTimeKind.Local).AddTicks(5382), 3, 4.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 13, 23, 44, 11, 865, DateTimeKind.Local).AddTicks(6135), new DateTime(2023, 8, 15, 0, 24, 5, 492, DateTimeKind.Local).AddTicks(9905), new DateTime(2023, 10, 2, 23, 14, 7, 578, DateTimeKind.Local).AddTicks(6112), 2, 7.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 14, 10, 59, 4, 686, DateTimeKind.Local).AddTicks(8880), new DateTime(2023, 8, 14, 16, 13, 5, 598, DateTimeKind.Local).AddTicks(5712), new DateTime(2024, 5, 2, 11, 29, 59, 628, DateTimeKind.Local).AddTicks(1274), 9, 8.0 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 14, 13, 59, 54, 710, DateTimeKind.Local).AddTicks(1543), new DateTime(2023, 8, 15, 14, 1, 1, 284, DateTimeKind.Local).AddTicks(851), new DateTime(2024, 8, 4, 19, 28, 30, 615, DateTimeKind.Local).AddTicks(3538), 3, "1568f65d-8c91-4b62-95df-fcafa488da03", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 14, 15, 9, 20, 236, DateTimeKind.Local).AddTicks(2518), new DateTime(2023, 8, 15, 13, 59, 31, 493, DateTimeKind.Local).AddTicks(5266), new DateTime(2023, 11, 7, 10, 2, 14, 770, DateTimeKind.Local).AddTicks(1332), 1, "168917b0-b3f2-47c0-9875-6a3535c851d5", "Expiré" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 14, 4, 44, 7, 655, DateTimeKind.Local).AddTicks(9565), new DateTime(2023, 8, 15, 5, 12, 24, 432, DateTimeKind.Local).AddTicks(7678), new DateTime(2024, 3, 23, 12, 10, 47, 328, DateTimeKind.Local).AddTicks(1290), 4, "89cefa97-9daa-4831-ac27-3f45b691f9f4", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 14, 11, 36, 12, 623, DateTimeKind.Local).AddTicks(5336), new DateTime(2023, 8, 15, 9, 19, 30, 480, DateTimeKind.Local).AddTicks(4639), new DateTime(2024, 6, 14, 20, 16, 54, 412, DateTimeKind.Local).AddTicks(3550), 3, "4fae316f-5b08-4a6c-a20c-f606455d43b5" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 13, 16, 39, 21, 253, DateTimeKind.Local).AddTicks(688), new DateTime(2023, 8, 14, 16, 13, 16, 487, DateTimeKind.Local).AddTicks(7973), new DateTime(2024, 2, 4, 8, 2, 54, 690, DateTimeKind.Local).AddTicks(1051), 1, "6490327a-571f-42a0-9c37-42e698cfb6d9", "Annulé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 14, 2, 59, 51, 898, DateTimeKind.Local).AddTicks(472), new DateTime(2023, 8, 15, 4, 51, 55, 304, DateTimeKind.Local).AddTicks(3959), new DateTime(2024, 2, 3, 22, 40, 39, 326, DateTimeKind.Local).AddTicks(5116), 1, "e583cc0a-9156-429c-b9ff-e4ed6843ade1", "Confirmé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 14, 0, 0, 34, 528, DateTimeKind.Local).AddTicks(8137), new DateTime(2023, 8, 15, 6, 34, 38, 878, DateTimeKind.Local).AddTicks(1922), new DateTime(2023, 11, 23, 9, 41, 27, 322, DateTimeKind.Local).AddTicks(1758), 5, "b1632035-8c7f-4013-81a9-aee3ea53a3fc", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 13, 23, 10, 55, 124, DateTimeKind.Local).AddTicks(8953), new DateTime(2023, 8, 15, 6, 29, 51, 595, DateTimeKind.Local).AddTicks(7799), new DateTime(2023, 11, 21, 16, 43, 46, 873, DateTimeKind.Local).AddTicks(6190), 8, "1d4c1f04-6e1b-49b6-9401-481cc619334e", "Confirmé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 13, 21, 47, 7, 890, DateTimeKind.Local).AddTicks(4650), new DateTime(2023, 8, 15, 14, 52, 36, 662, DateTimeKind.Local).AddTicks(8038), new DateTime(2024, 5, 8, 4, 2, 17, 318, DateTimeKind.Local).AddTicks(1943), "07961e60-5189-40af-bbd4-d5a4b06f33d0" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 14, 6, 28, 14, 540, DateTimeKind.Local).AddTicks(7451), new DateTime(2023, 8, 15, 8, 44, 21, 411, DateTimeKind.Local).AddTicks(9725), new DateTime(2023, 12, 8, 23, 39, 29, 706, DateTimeKind.Local).AddTicks(2700), 9, "15e5adf4-8711-49dc-a146-e8c6442e0533" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsVerified", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 17, 4, 10, 14, 394, DateTimeKind.Local).AddTicks(7336), "Warren.Smitham@yahoo.com", "Glenna", 9, 1, false, "Dicki", "$2a$11$8NIXsu.0GMrn8I2iBAk1muEOo6nIPNyfz.7m89zDDINfK1WLmUg1y" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsVerified", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 11, 9, 5, 23, 8, 928, DateTimeKind.Local).AddTicks(2366), "Damien.Halvorson@hotmail.com", "Hulda", 1, 2, false, "Klocko", "$2a$11$WX0elchnvioFoQNbuLEezuwGgbzX16oX62sUAY4tHV8WFc8dh518W" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsVerified", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 11, 11, 34, 39, 212, DateTimeKind.Local).AddTicks(8629), "Nelson_Hudson34@gmail.com", "Randy", 9, 2, false, "Carroll", "$2a$11$/FcfvXTd1go3vOLGJkdx3uSkJUpPMumiGQr1lcZblq0nrK9GeEQLG" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "IsVerified", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 9, 11, 19, 16, 988, DateTimeKind.Local).AddTicks(1775), "Granville_Schamberger61@yahoo.com", "Quinn", 7, false, false, "Robel", "$2a$11$0QK7wuvLailQAWvvw39M/uKOPb7Gx3Xit/c.LR32FEQOFSPyttB6q" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdRole", "IsActive", "IsVerified", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 15, 3, 58, 45, 263, DateTimeKind.Local).AddTicks(8040), "Sigmund.Morissette@hotmail.com", "Cielo", 1, true, false, "Gutkowski", "$2a$11$BHBuca7bLNQOEAvnahqxse9moqJryCuOnh0b9AIRX/xT1qwcMcqiG" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "IsVerified", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 10, 19, 2, 5, 164, DateTimeKind.Local).AddTicks(523), "Kareem.Rodriguez@yahoo.com", "Orpha", 7, true, false, "Armstrong", "$2a$11$HMadKmia981BTfzZTj3gmOtd01jvKGYBXb4MZUXgvYTcr85bhT5Jm" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "IsVerified", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 7, 5, 0, 3, 53, DateTimeKind.Local).AddTicks(7693), "Destinee.Boehm39@hotmail.com", "Delpha", 2, 1, true, false, "Balistreri", "$2a$11$v5FijxLtP9b5LUKX0qDZPeazTSTsMRy0U6PnXXk8rzii/v6GYoJGS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsVerified", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 13, 8, 54, 1, 296, DateTimeKind.Local).AddTicks(7806), "Riley_Hoppe@hotmail.com", "Shanny", 1, 2, false, "Towne", "$2a$11$bWP0lR1lrXFFYQcqiYiiBOZF/RXwd4ltq68WkcQYqjDQbkGDTuHzS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsVerified", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 7, 9, 43, 27, 627, DateTimeKind.Local).AddTicks(9815), "Violet19@hotmail.com", "Oral", 4, 2, false, "Simonis", "$2a$11$LryQWtnGO0HiprrlPY38kusv.wUtq4qOvSThMjMiHNudzW.bRz00S" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "IsVerified", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 8, 8, 2, 52, 17, 367, DateTimeKind.Local).AddTicks(9250), "Arielle37@hotmail.com", "Ima", 6, true, false, "Kozey", "$2a$11$bRLyVWpiv7GfeE.LQLtv3uBAsFkrXNjEM34ESSFFGmEnzOMzLF4nS" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2023, 5, 24, 5, 35, 11, 123, DateTimeKind.Local).AddTicks(2032), "janecvfevd", 10, 122, 4517, "amrociykhy", "jktemnsvzz", "gwrnjkzerx", 6, 10, 2.0, "znidrdvquk" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, false, new DateTime(2022, 8, 16, 0, 55, 12, 18, DateTimeKind.Local).AddTicks(3559), "hkykrmehnk", 7, 139, 7242, "djggxeqwpn", "rempzvtqjv", "ndkwxbjatt", 6, 4, 6.0, "jbmkucajpv" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, false, new DateTime(2023, 2, 27, 15, 33, 58, 630, DateTimeKind.Local).AddTicks(815), "vcpixnbdzo", 10, 110, 2951, "mtguqhjbmg", "qppwmpsylr", "hsyvnhzieu", 7, 2, 5.0, "fxoaqzxjmw" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, false, new DateTime(2023, 1, 11, 23, 38, 13, 81, DateTimeKind.Local).AddTicks(6905), "oetxysgaqd", 10, 229, 7759, "zrdavagkzr", "ujncimiznj", "ijeombdbtl", 5, 6, 4.0, "bzenejkxee" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2022, 11, 7, 1, 2, 10, 697, DateTimeKind.Local).AddTicks(2473), "ovddiyicxb", 4, 190, 5205, "iivanwinzq", "dsjiigljay", "mtoaymjirc", 6, 5, 2.0, "lfahluhxkr" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2023, 2, 8, 11, 31, 25, 460, DateTimeKind.Local).AddTicks(9482), "qcgdvaxcav", 200, 1243, "qbziqmnsot", "xpaavoooyp", "fyxwbyxfml", 4, 7, 8.0, "revexnkaqu" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2023, 5, 1, 18, 38, 1, 943, DateTimeKind.Local).AddTicks(6083), "cqqjrhkumq", 4, 233, 8989, "cmgpkgkmco", "ccbmwbdskc", "zcqkqskaeq", 1, 3.0, "ownlmjmshx" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "Prix", "Type" },
                values: new object[] { false, false, new DateTime(2022, 11, 11, 22, 38, 20, 164, DateTimeKind.Local).AddTicks(7515), "vahmnzsehi", 4, 93, 117, "ggotizdalx", "vlacokvnhh", "ttxclazvpw", 2, 5.0, "rudugzhqho" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Type" },
                values: new object[] { new DateTime(2022, 9, 7, 3, 38, 44, 398, DateTimeKind.Local).AddTicks(1782), "fozcnflhcz", 5, 313, 4700, "pcrbuuddtt", "obafrumoac", "ivbsxeetjv", 2, 8, "mljsesvscz" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2023, 7, 24, 8, 57, 35, 602, DateTimeKind.Local).AddTicks(2081), "ekpclehsdw", 9, 121, 4414, "ptctelnmvv", "dexicqwsdy", "rmobqbkvzl", 6, 2.0, "eoiblkdkez" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 5, 13, 3, 8, 40, 309, DateTimeKind.Local).AddTicks(5171), 275, "iiknypjkmw", "Grant", 23, "Johnston - Bruen", "Reuben", "442-723-0069 x567", "Waters", "North Watsontown", "09868" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 10, 13, 2, 6, 19, 750, DateTimeKind.Local).AddTicks(5470), 316, "cuuvxzlufu", "Kuvalis", 23, "Johnson, Ward and Hammes", "Lorna", "847.317.4348 x68277", "Fritsch", "New Estefania", "04626" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 1, 23, 0, 42, 10, 134, DateTimeKind.Local).AddTicks(8791), 89, "crlhusscdk", "Wehner", 28, "Johns, Ritchie and Stark", "Lucinda", "220.943.5239 x88066", "Murazik", "Lake Shad", "38998-4224" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 12, 5, 20, 49, 50, 993, DateTimeKind.Local).AddTicks(6503), 81, "ueqeeiwgwl", "Hansen", 18, "Prosacco, Kautzer and Okuneva", "Sarina", "816-303-3003 x3392", "Crooks", "Lessiefort", "66120-8927" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 2, 1, 6, 34, 37, 566, DateTimeKind.Local).AddTicks(2773), 304, "dhicpqnfyw", "Klein", 21, "Pfannerstill, Kub and Hudson", "Ima", "(832) 797-8213", "Hoeger", "Williamsonville", "58176" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 7, 18, 4, 31, 30, 671, DateTimeKind.Local).AddTicks(8900), 282, "tpdfqexcuh", "Welch", 28, "Bogisich - Greenfelder", "Jerrold", "(379) 888-4435", "Schiller", "Lake Laurieton", "45483-3154" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 11, 30, 9, 46, 53, 54, DateTimeKind.Local).AddTicks(3227), 212, "exlhmiotvh", "Herman", 19, "Gulgowski - Langosh", "Saige", "818-435-1489", "Mann", "West Jaceymouth", "19447" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 7, 14, 20, 43, 32, 332, DateTimeKind.Local).AddTicks(5529), 120, "dltqbebgyy", "Hoppe", 25, "Dietrich LLC", "Marta", "(997) 297-8982 x62319", "Schulist", "East Revatown", "01810" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "ville", "zip" },
                values: new object[] { new DateTime(2022, 12, 14, 18, 9, 7, 411, DateTimeKind.Local).AddTicks(6545), 254, "atnorrizlj", "Marks", 24, "Watsica - Tromp", "Kory", "842.582.3094", "Gretchenside", "02849" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 6, 30, 23, 14, 38, 657, DateTimeKind.Local).AddTicks(2247), 306, "mpnydrwuts", "Hansen", 31, "Howe - Jerde", "Kaitlyn", "806.452.2014 x882", "Beatty", "West Breana", "95343" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PasswordResetTokens");

            migrationBuilder.DropColumn(
                name: "IsVerified",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsVerified",
                table: "Clients");

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "4384 Powlowski Cove", "Horacioside", new DateTime(2022, 12, 3, 9, 53, 12, 203, DateTimeKind.Local).AddTicks(124), "Joyce_Lindgren82@yahoo.com", 42.453899999999997, 135.4179, "Principal Intranet Specialist", "351-847-5857 x536", "98967-7437" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "4876 Lelia Street", "Port Colten", new DateTime(2023, 6, 8, 10, 7, 38, 491, DateTimeKind.Local).AddTicks(7583), "Janick_Lebsack@gmail.com", -2.8702999999999999, 41.654800000000002, "National Creative Planner", "404-625-9879 x32420", "23832-0966" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "436 Glover Port", "Lake Martin", new DateTime(2023, 3, 6, 7, 33, 58, 748, DateTimeKind.Local).AddTicks(961), "Albin_Kovacek@gmail.com", 14.284000000000001, 60.600900000000003, "Product Implementation Supervisor", "532.612.6916 x84687", "20334" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "55183 Howell Key", "Wardside", new DateTime(2023, 6, 7, 12, 48, 36, 568, DateTimeKind.Local).AddTicks(9044), "Jacques.Will@yahoo.com", 38.223199999999999, -155.43279999999999, "Legacy Response Architect", "934.625.4397 x29369", "41633" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "97172 Tromp Cliff", "Port Jermain", new DateTime(2022, 12, 20, 4, 57, 52, 27, DateTimeKind.Local).AddTicks(7993), "Audreanne_Mueller@yahoo.com", 80.552400000000006, 97.766300000000001, "Product Operations Officer", "1-783-714-5043 x0051", "14992" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "1060 Taurean Ford", "East Pasquale", new DateTime(2023, 2, 7, 22, 0, 1, 104, DateTimeKind.Local).AddTicks(7107), "Marcellus8@yahoo.com", -74.676900000000003, -71.495199999999997, "Legacy Functionality Executive", "984.842.1917", "69112" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "32619 Walker Mountains", "Lake Mikayla", new DateTime(2023, 5, 4, 9, 38, 59, 3, DateTimeKind.Local).AddTicks(3653), "Dena_Lueilwitz98@hotmail.com", -5.5541999999999998, 14.074199999999999, "District Configuration Manager", "789-209-2754 x441", "60031-9120" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "351 Nova Tunnel", "Port Kyla", new DateTime(2023, 5, 23, 14, 34, 3, 132, DateTimeKind.Local).AddTicks(1477), "Jamir_Schimmel90@gmail.com", 57.046999999999997, 72.047899999999998, "Lead Research Consultant", "753-707-6509", "41178-8439" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "74552 Ernser Park", "North Devante", new DateTime(2023, 4, 28, 9, 51, 21, 264, DateTimeKind.Local).AddTicks(7409), "Corbin.Collier@yahoo.com", 85.632099999999994, 50.746699999999997, "Chief Operations Planner", "857.873.3087 x32688", "94174" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "083 Dach Neck", "Agnesbury", new DateTime(2023, 6, 22, 9, 42, 40, 638, DateTimeKind.Local).AddTicks(6652), "Delaney.Fay17@yahoo.com", -42.561100000000003, 68.341899999999995, "Regional Metrics Consultant", "1-536-813-4604", "54006-6221" });

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
                columns: new[] { "IdClient", "IsConducteur" },
                values: new object[] { 5, false });

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
                column: "IdClient",
                value: 8);

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
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 8, 6 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IdClient", "IsConducteur" },
                values: new object[] { 10, true });

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
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 3, 9 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 1, 10 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 10,
                column: "IdReservation",
                value: 3);

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
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "Prix" },
                values: new object[] { new DateTime(2023, 8, 10, 14, 25, 57, 463, DateTimeKind.Local).AddTicks(3159), new DateTime(2023, 8, 11, 22, 6, 43, 651, DateTimeKind.Local).AddTicks(9294), new DateTime(2023, 11, 28, 21, 42, 20, 88, DateTimeKind.Local).AddTicks(3719), 7.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 10, 10, 17, 50, 440, DateTimeKind.Local).AddTicks(2642), new DateTime(2023, 8, 11, 9, 37, 10, 355, DateTimeKind.Local).AddTicks(8643), new DateTime(2023, 11, 25, 9, 13, 46, 336, DateTimeKind.Local).AddTicks(2912), 9, 9.0, true });

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
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 10, 0, 31, 27, 730, DateTimeKind.Local).AddTicks(8496), new DateTime(2023, 8, 11, 8, 20, 56, 334, DateTimeKind.Local).AddTicks(7751), new DateTime(2024, 7, 15, 5, 30, 31, 343, DateTimeKind.Local).AddTicks(1205), 5, 2.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 10, 5, 28, 53, 599, DateTimeKind.Local).AddTicks(554), new DateTime(2023, 8, 11, 23, 12, 59, 244, DateTimeKind.Local).AddTicks(7973), new DateTime(2024, 6, 18, 23, 37, 47, 309, DateTimeKind.Local).AddTicks(5806), 7, 9.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 10, 14, 8, 10, 642, DateTimeKind.Local).AddTicks(8861), new DateTime(2023, 8, 11, 14, 40, 54, 401, DateTimeKind.Local).AddTicks(3983), new DateTime(2024, 1, 23, 5, 24, 42, 293, DateTimeKind.Local).AddTicks(4758), 7, 2.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 10, 5, 51, 3, 772, DateTimeKind.Local).AddTicks(6808), new DateTime(2023, 8, 11, 5, 11, 27, 615, DateTimeKind.Local).AddTicks(356), new DateTime(2023, 10, 18, 15, 6, 21, 97, DateTimeKind.Local).AddTicks(6960), 7, 4.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 10, 11, 43, 47, 12, DateTimeKind.Local).AddTicks(3357), new DateTime(2023, 8, 11, 11, 38, 32, 106, DateTimeKind.Local).AddTicks(7843), new DateTime(2024, 6, 1, 16, 22, 9, 722, DateTimeKind.Local).AddTicks(3450), 10, 2.0 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 10, 5, 42, 25, 510, DateTimeKind.Local).AddTicks(7743), new DateTime(2023, 8, 11, 16, 37, 0, 505, DateTimeKind.Local).AddTicks(6717), new DateTime(2024, 2, 21, 5, 55, 38, 177, DateTimeKind.Local).AddTicks(8605), 1, "01b2ffd5-3102-4a5b-a4f3-af22a73c4938", "Annulé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 10, 14, 13, 22, 589, DateTimeKind.Local).AddTicks(4606), new DateTime(2023, 8, 11, 20, 18, 57, 910, DateTimeKind.Local).AddTicks(326), new DateTime(2024, 4, 30, 8, 54, 47, 861, DateTimeKind.Local).AddTicks(2765), 3, "6ac3e9f6-c74d-4d65-b040-d720f3d0f787", "Enattente" });

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
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 10, 0, 37, 10, 191, DateTimeKind.Local).AddTicks(3435), new DateTime(2023, 8, 11, 19, 46, 32, 237, DateTimeKind.Local).AddTicks(3348), new DateTime(2023, 11, 5, 6, 36, 14, 390, DateTimeKind.Local).AddTicks(3519), 5, "74f085a8-e54a-4ac1-9f06-6aa5bc9898b7" });

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
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 10, 14, 54, 22, 471, DateTimeKind.Local).AddTicks(8039), new DateTime(2023, 8, 11, 9, 22, 9, 182, DateTimeKind.Local).AddTicks(6875), new DateTime(2024, 3, 30, 7, 6, 38, 409, DateTimeKind.Local).AddTicks(9340), 5, "420dcb83-0c27-4ad0-92cb-45e451ecfa50", "Enattente" });

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
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 10, 9, 10, 31, 104, DateTimeKind.Local).AddTicks(2488), new DateTime(2023, 8, 11, 14, 0, 11, 126, DateTimeKind.Local).AddTicks(1583), new DateTime(2024, 7, 13, 23, 7, 25, 187, DateTimeKind.Local).AddTicks(5351), "831b110f-0c12-4720-bc7b-b9caa5681086" });

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
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 2, 9, 14, 31, 46, 542, DateTimeKind.Local).AddTicks(3754), "Amely67@gmail.com", "Laron", 4, 2, "Labadie", "$2a$11$cDnhOg1SXWUfC2zCr4pZtOOHUgUs1yP95AFXi1a3Dy9PCPHhGmhp6" });

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
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 31, 9, 0, 43, 538, DateTimeKind.Local).AddTicks(5764), "Coty_Cremin@yahoo.com", "Armani", 1, 1, "Lang", "$2a$11$677BbF3UnbXf8tfpYwA8OOEr50qjArHdLD5Bc311bukoOnZva.83a" });

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
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 14, 13, 9, 40, 593, DateTimeKind.Local).AddTicks(4248), "Molly45@yahoo.com", "Eleonore", 2, false, "Kuhic", "$2a$11$ahJpdj9.58VgZEHFXNGPx.3cs4YuUYzUf67Lr4vvoHSbnagmIs.8e" });

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
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 22, 18, 15, 44, 826, DateTimeKind.Local).AddTicks(16), "Kaci.Schulist90@hotmail.com", "Jamar", 4, 2, false, "Moen", "$2a$11$earwcoctcSgrv9oImvAG.OXWdEWlFJ3D6mcdtlCnOasnRRyy4.HNW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 11, 17, 5, 45, 55, 837, DateTimeKind.Local).AddTicks(8157), "Amira34@yahoo.com", "Mazie", 7, 1, "Herman", "$2a$11$yDKoJTJicOyEuR7ALwOm8O0vi7PTrtCwPpkoAvCpeF0PhjU.ZDtEm" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 7, 2, 52, 17, 662, DateTimeKind.Local).AddTicks(7451), "Zoila90@yahoo.com", "Amir", 1, 1, "Reichert", "$2a$11$szCKBjoB6Daf1raS9xkCqeCyNZ//ub8yEabNLzuSOWTl1TxaA.996" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 2, 18, 17, 25, 117, DateTimeKind.Local).AddTicks(7575), "Colby81@gmail.com", "Josh", 8, false, "Schroeder", "$2a$11$Y4BxNAY7n4BlDtxoeL5YYe71L2QARZ4SPAk7sJtIpbQj.14VAVoKS" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2022, 9, 8, 11, 52, 29, 333, DateTimeKind.Local).AddTicks(2598), "mmqpwxsihc", 5, 80, 4473, "twlepduvgr", "bxkdfdoyrn", "tsqkzxnfgh", 5, 8, 10.0, "ltxftlebso" });

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
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, true, new DateTime(2023, 6, 8, 20, 54, 3, 181, DateTimeKind.Local).AddTicks(8912), "hxaenzuihb", 1, 249, 9112, "wtagyhaqsn", "ruovvqkxoc", "ibiaxxsyms", 2, 5, 1.0, "znkgfjyhkw" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, true, new DateTime(2023, 6, 29, 16, 3, 26, 190, DateTimeKind.Local).AddTicks(3819), "pwqpcrixzm", 7, 99, 7561, "axhejpriry", "ugcymsdtbv", "pbemygmnhn", 2, 1, 1.0, "gwvvlvieuc" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2023, 6, 19, 5, 17, 9, 927, DateTimeKind.Local).AddTicks(8380), "qjfbzjkerx", 8, 281, 2513, "vcbafliefb", "mbhzifccvm", "qxalygrank", 3, 10, 4.0, "rpddaxdrar" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2022, 10, 8, 21, 59, 16, 245, DateTimeKind.Local).AddTicks(826), "viggvpvspx", 230, 9312, "ilymgkjrle", "dgrnrgdaxt", "itotsetxtm", 2, 8, 3.0, "einzbphnck" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2022, 12, 30, 20, 40, 21, 2, DateTimeKind.Local).AddTicks(2382), "jkaxprlorw", 2, 236, 9934, "bflaggxjfn", "lmjibyubay", "nlsnhiafej", 5, 9.0, "mgnsfzcpmq" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "Prix", "Type" },
                values: new object[] { true, true, new DateTime(2023, 4, 13, 1, 50, 59, 220, DateTimeKind.Local).AddTicks(5079), "puphsanasg", 5, 41, 9357, "achbjltypj", "cokyfmgorr", "qjrxnhdrnt", 9, 9.0, "bhplkzfecn" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Type" },
                values: new object[] { new DateTime(2023, 1, 3, 19, 28, 0, 320, DateTimeKind.Local).AddTicks(7084), "wjbjpkilib", 9, 270, 6421, "skdpntlicz", "ckbpevkxtk", "xldmiovsob", 10, 7, "alkzrwbbro" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2023, 7, 10, 18, 36, 17, 901, DateTimeKind.Local).AddTicks(8240), "eybqoqznpz", 10, 172, 7848, "osjvsbmuxw", "worivwrses", "ivkbefcnwv", 9, 3.0, "prtdktvhsd" });

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
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "ville", "zip" },
                values: new object[] { new DateTime(2023, 3, 11, 7, 55, 0, 249, DateTimeKind.Local).AddTicks(2422), 277, "nknmobcnkb", "Cremin", 32, "Fahey Group", "Addie", "479-344-1880 x1267", "Devonberg", "83922-9613" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 9, 7, 10, 27, 58, 607, DateTimeKind.Local).AddTicks(6262), 189, "stjtjbjykc", "Cruickshank", 21, "Aufderhar, Feest and Nikolaus", "Jared", "1-288-543-5075 x0261", "Roob", "Effertzland", "82227" });
        }
    }
}
