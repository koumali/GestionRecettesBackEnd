using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace AutomotiveApi.Migrations
{
    /// <inheritdoc />
    public partial class AddedEmailVerif : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmailVerificationTokens",
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
                    table.PrimaryKey("PK_EmailVerificationTokens", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

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
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 5, 7, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 8, 3 });

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
                values: new object[] { 6, 6, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 5,
                column: "IdClient",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 6,
                column: "IdClient",
                value: 4);

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
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 7, 9, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 3, 6, true });

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
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 14, 5, 53, 56, 537, DateTimeKind.Local).AddTicks(7419), new DateTime(2023, 8, 15, 1, 30, 14, 632, DateTimeKind.Local).AddTicks(7794), new DateTime(2023, 8, 27, 16, 36, 28, 96, DateTimeKind.Local).AddTicks(852), 10, false });

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
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 14, 9, 41, 54, 283, DateTimeKind.Local).AddTicks(7385), new DateTime(2023, 8, 15, 12, 1, 49, 943, DateTimeKind.Local).AddTicks(7328), new DateTime(2024, 1, 15, 13, 22, 9, 821, DateTimeKind.Local).AddTicks(7961), 10, 6.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 14, 4, 23, 24, 144, DateTimeKind.Local).AddTicks(228), new DateTime(2023, 8, 15, 15, 32, 45, 446, DateTimeKind.Local).AddTicks(7908), new DateTime(2023, 11, 30, 21, 28, 42, 359, DateTimeKind.Local).AddTicks(1721), 3, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 14, 16, 8, 49, 832, DateTimeKind.Local).AddTicks(3416), new DateTime(2023, 8, 15, 15, 6, 55, 11, DateTimeKind.Local).AddTicks(9370), new DateTime(2023, 9, 8, 19, 57, 18, 484, DateTimeKind.Local).AddTicks(1148), 6, 9.0 });

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
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 14, 9, 28, 50, 338, DateTimeKind.Local).AddTicks(7088), new DateTime(2023, 8, 15, 2, 10, 7, 992, DateTimeKind.Local).AddTicks(597), new DateTime(2023, 12, 28, 13, 23, 14, 836, DateTimeKind.Local).AddTicks(7081), 5, 3.0 });

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
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 14, 3, 16, 53, 906, DateTimeKind.Local).AddTicks(1911), new DateTime(2023, 8, 16, 0, 3, 30, 230, DateTimeKind.Local).AddTicks(8421), new DateTime(2024, 6, 27, 16, 23, 43, 628, DateTimeKind.Local).AddTicks(5452), 8, 1.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 14, 8, 28, 50, 443, DateTimeKind.Local).AddTicks(912), new DateTime(2023, 8, 15, 3, 29, 43, 26, DateTimeKind.Local).AddTicks(9245), new DateTime(2024, 1, 25, 20, 43, 56, 408, DateTimeKind.Local).AddTicks(2461), 1, false });

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
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 14, 20, 39, 21, 843, DateTimeKind.Local).AddTicks(7582), new DateTime(2023, 8, 15, 5, 13, 2, 105, DateTimeKind.Local).AddTicks(1487), new DateTime(2023, 10, 24, 17, 42, 4, 696, DateTimeKind.Local).AddTicks(9957), 10, "c3f2093b-44e4-4232-a4c0-eec843099b27" });

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
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 14, 16, 14, 10, 321, DateTimeKind.Local).AddTicks(3663), new DateTime(2023, 8, 15, 13, 0, 46, 509, DateTimeKind.Local).AddTicks(7589), new DateTime(2023, 9, 15, 6, 7, 5, 870, DateTimeKind.Local).AddTicks(7358), 8, "b7bd8035-9514-49ec-ac34-0d6b22f27a43", "Confirmé" });

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
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 14, 17, 46, 33, 557, DateTimeKind.Local).AddTicks(299), new DateTime(2023, 8, 15, 7, 6, 52, 632, DateTimeKind.Local).AddTicks(5127), new DateTime(2024, 4, 4, 23, 57, 45, 857, DateTimeKind.Local).AddTicks(7432), 2, "cf593144-870c-4109-a46f-87e14309b405" });

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
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 10, 10, 1, 31, 53, 961, DateTimeKind.Local).AddTicks(9454), "Idella_Mante@hotmail.com", "Caroline", 10, "Von", "$2a$11$ftWRfQxdZhoqv12KAfts5e0AvVlL.MnrQWeojKigAFO8Om4UpJsWK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 8, 6, 21, 56, 59, 249, DateTimeKind.Local).AddTicks(4231), "Elouise.Zboncak66@gmail.com", "Weston", 8, "Hauck", "$2a$11$lu6oPCXa7nWj3Pu.yY2kc.g.FDqqQryzMRMQBY6495GPwuO/vEE.K" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 16, 12, 39, 33, 983, DateTimeKind.Local).AddTicks(3475), "Joshua63@yahoo.com", "Hailee", 2, 1, "Runolfsdottir", "$2a$11$R8CfETf5YMu3LlR6KixMiONz.Efpadi5Vw4Kg3UTkfh5dLWkDtWOu" });

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
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 19, 17, 12, 54, 349, DateTimeKind.Local).AddTicks(415), "Annabelle_Schuster14@gmail.com", "Reid", 9, 1, "Wunsch", "$2a$11$BYKdcoGX6DFsYzq38C.hq.beSLYU5yYkmsjEYzirUWWo3hlOQQobK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 18, 17, 20, 34, 949, DateTimeKind.Local).AddTicks(4622), "Stephen.Jast@yahoo.com", "Dell", false, "Cormier", "$2a$11$egiy/MfFoG6.C7p45GZJsuM9pFWXAP91RLMaN7gpF6hcdJhORrIK6" });

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
                columns: new[] { "CreatedAt", "Email", "FirstName", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 7, 20, 7, 34, 4, 511, DateTimeKind.Local).AddTicks(9990), "Gina.Heller@yahoo.com", "Ethan", false, "Towne", "$2a$11$GJ.oMGRdqe5CkanrQQn9uuVBQ5ROWxFLw/de3Rf.nw1rWd6su9eaa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 6, 22, 9, 11, 374, DateTimeKind.Local).AddTicks(6879), "Laurianne40@hotmail.com", "Freeman", 10, false, "Ankunding", "$2a$11$RlCmSaTI2OX9znCwTY9wUe.hKcfUohkl0/7Z3navMkGP2eK/0g3c." });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2023, 3, 7, 19, 58, 44, 12, DateTimeKind.Local).AddTicks(9208), "bkwfohryph", 166, 3061, "dirbnaupqq", "hgmmkjgmdw", "vusxfghdzv", 4, 7, 1.0, "gkeguvlseo" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, true, new DateTime(2023, 4, 11, 1, 10, 45, 421, DateTimeKind.Local).AddTicks(3464), "ugrkbneeay", 9, 54, 9167, "gmvrbcndnt", "vjowusqofu", "ulmueszvlo", 1, 10, 9.0, "rslfvqygbv" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2022, 11, 28, 16, 7, 41, 985, DateTimeKind.Local).AddTicks(3714), "imnupqgblg", 1, 24, 6795, "cepcvqikbm", "aouzajuaar", "roqtujbmfi", 6, 3, 3.0, "udglmafbjj" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2023, 2, 5, 22, 3, 46, 156, DateTimeKind.Local).AddTicks(8544), "glroqdmnor", 6, 269, 4925, "qncivnkiez", "trlgzblxdt", "lnvheaqysn", 2, 10, 7.0, "sizcenqntq" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2022, 9, 23, 9, 50, 55, 988, DateTimeKind.Local).AddTicks(7713), "txagywcxte", 2, 58, 8988, "wpmgmaoauh", "kwksrvckca", "bdmwpttvqk", 9, 7, 5.0, "dnjpnqjlfe" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Type" },
                values: new object[] { false, new DateTime(2022, 11, 14, 20, 7, 17, 682, DateTimeKind.Local).AddTicks(8125), "vdcmecsjgl", 5, 109, 5013, "slmccoxxma", "xpzebtmcdi", "tswemsapiv", 3, 8, "txdgcfbhlk" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2023, 1, 17, 19, 39, 12, 645, DateTimeKind.Local).AddTicks(1004), "viqywxvjei", 1, 58, 515, "hgfbjrjqgz", "zyrkkhqwqz", "zpidscrcjk", 4, 7, 2.0, "zjeftaypxj" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, true, new DateTime(2023, 5, 25, 21, 45, 31, 312, DateTimeKind.Local).AddTicks(2562), "sqtofzitvn", 3, 106, 3270, "yveeaffepa", "xwypmqyzxn", "pxdcgfdwhx", 9, 9, 2.0, "sutwkqrrdw" });

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
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2022, 10, 19, 11, 57, 41, 626, DateTimeKind.Local).AddTicks(2747), "zgkimytryf", 5, 322, 5991, "cydwquyrkj", "lwakqentzc", "dfyqydgyse", 3, 3, 4.0, "uzweyklnbp" });

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
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 8, 16, 14, 29, 46, 607, DateTimeKind.Local).AddTicks(1669), 103, "yvdheswjff", "Dicki", 33, "Conroy, Kuhn and Funk", "Hattie", "669-240-6295 x875", "Gerlach", "New Juwanfurt", "46259-3638" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmailVerificationTokens");

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
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "805 Ullrich Flat", "18634 Legros Green", new DateTime(2023, 7, 28, 15, 51, 7, 742, DateTimeKind.Local).AddTicks(2724), "Zita30@gmail.com", "Gladyce", "Kling", "https://picsum.photos/640/480/?image=368", "https://picsum.photos/640/480/?image=1059", "1-719-910-1686", "Esmeraldahaven", "77454" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "9565 Lois Walks", "4922 Edmond Alley", new DateTime(2022, 12, 26, 8, 5, 11, 137, DateTimeKind.Local).AddTicks(5173), "Gideon.Borer@hotmail.com", "Arden", "Collins", "https://picsum.photos/640/480/?image=557", "https://picsum.photos/640/480/?image=446", "714-280-7605 x01699", "Nolanborough", "46933-8561" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "5320 Brain Meadow", "04033 Annette Ford", new DateTime(2023, 1, 18, 1, 57, 16, 799, DateTimeKind.Local).AddTicks(2450), "Otha.McGlynn23@yahoo.com", "Lorenz", "Boehm", "https://picsum.photos/640/480/?image=160", "https://picsum.photos/640/480/?image=285", "(811) 577-6758", "Demetriusmouth", "88239" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "4772 Yost Spur", "090 Delphia Valley", new DateTime(2023, 3, 17, 18, 34, 1, 410, DateTimeKind.Local).AddTicks(1045), "Jennifer_Prohaska72@gmail.com", "Jevon", "Bergnaum", "https://picsum.photos/640/480/?image=763", "https://picsum.photos/640/480/?image=953", "488.920.0629 x5948", "West Vicky", "35670-1577" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "359 Ondricka Mountain", "36285 Dicki Greens", new DateTime(2022, 11, 25, 11, 47, 2, 595, DateTimeKind.Local).AddTicks(9287), "Westley.OConnell@yahoo.com", "Viva", "Shanahan", "https://picsum.photos/640/480/?image=891", "https://picsum.photos/640/480/?image=331", "1-362-647-3306 x14021", "Alyshatown", "99753" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "42886 Gabriella Cliffs", "6075 Elsa Points", new DateTime(2023, 7, 30, 18, 40, 18, 43, DateTimeKind.Local).AddTicks(1246), "Jaclyn.Yost52@yahoo.com", "Rowena", "Marvin", "https://picsum.photos/640/480/?image=784", "https://picsum.photos/640/480/?image=576", "1-968-588-3284 x382", "Lake Marjorieville", "76715" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "6992 Swift Ford", "392 Elmira Mission", new DateTime(2022, 9, 25, 18, 48, 23, 726, DateTimeKind.Local).AddTicks(915), "Halie_Beer@hotmail.com", "Milton", "Terry", "https://picsum.photos/640/480/?image=335", "https://picsum.photos/640/480/?image=110", "436.816.8038", "Strackeborough", "79129" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "575 Carole Lock", "5358 Russ Turnpike", new DateTime(2023, 1, 9, 1, 11, 26, 529, DateTimeKind.Local).AddTicks(546), "Chesley_Wuckert@hotmail.com", "Emelie", "Stokes", "https://picsum.photos/640/480/?image=545", "https://picsum.photos/640/480/?image=801", "1-457-913-6100 x91349", "New Ruthie", "94559" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "817 Kaitlyn Ridges", "03433 Walker Light", new DateTime(2023, 7, 23, 9, 29, 7, 33, DateTimeKind.Local).AddTicks(7797), "Wyman.Hammes@gmail.com", "Laurence", "Rogahn", "https://picsum.photos/640/480/?image=1082", "https://picsum.photos/640/480/?image=140", "890.363.3568 x83831", "Port Bart", "40442-8622" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "783 Kuphal Mountain", "00695 Boyle Forge", new DateTime(2022, 9, 13, 20, 51, 15, 298, DateTimeKind.Local).AddTicks(5056), "Aisha56@gmail.com", "Elody", "Schumm", "https://picsum.photos/640/480/?image=285", "https://picsum.photos/640/480/?image=113", "(901) 838-4927 x2791", "Carrollfort", "64311" });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 1, 9, true });

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
                column: "IdReservation",
                value: 10);

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
                column: "IdClient",
                value: 9);

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
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 5, 4 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 4, 2, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 2, 7, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 3, 1, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 14, 14, 3, 34, 631, DateTimeKind.Local).AddTicks(3092), new DateTime(2023, 8, 14, 17, 8, 44, 173, DateTimeKind.Local).AddTicks(9282), new DateTime(2023, 9, 11, 23, 30, 50, 631, DateTimeKind.Local).AddTicks(1659), 2, true });

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
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 13, 18, 0, 53, 191, DateTimeKind.Local).AddTicks(6716), new DateTime(2023, 8, 15, 0, 17, 1, 963, DateTimeKind.Local).AddTicks(5505), new DateTime(2024, 6, 13, 15, 24, 49, 759, DateTimeKind.Local).AddTicks(4724), 1, 8.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 14, 14, 27, 37, 743, DateTimeKind.Local).AddTicks(632), new DateTime(2023, 8, 15, 8, 41, 46, 990, DateTimeKind.Local).AddTicks(1104), new DateTime(2023, 8, 15, 14, 39, 49, 450, DateTimeKind.Local).AddTicks(2092), 5, false });

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
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 14, 1, 51, 3, 550, DateTimeKind.Local).AddTicks(5969), new DateTime(2023, 8, 15, 12, 51, 27, 360, DateTimeKind.Local).AddTicks(1587), new DateTime(2023, 11, 25, 1, 31, 11, 481, DateTimeKind.Local).AddTicks(3498), 1, 4.0 });

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
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 14, 10, 59, 4, 686, DateTimeKind.Local).AddTicks(8880), new DateTime(2023, 8, 14, 16, 13, 5, 598, DateTimeKind.Local).AddTicks(5712), new DateTime(2024, 5, 2, 11, 29, 59, 628, DateTimeKind.Local).AddTicks(1274), 9, true });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 14, 13, 59, 54, 710, DateTimeKind.Local).AddTicks(1543), new DateTime(2023, 8, 15, 14, 1, 1, 284, DateTimeKind.Local).AddTicks(851), new DateTime(2024, 8, 4, 19, 28, 30, 615, DateTimeKind.Local).AddTicks(3538), "1568f65d-8c91-4b62-95df-fcafa488da03", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 14, 15, 9, 20, 236, DateTimeKind.Local).AddTicks(2518), new DateTime(2023, 8, 15, 13, 59, 31, 493, DateTimeKind.Local).AddTicks(5266), new DateTime(2023, 11, 7, 10, 2, 14, 770, DateTimeKind.Local).AddTicks(1332), 1, "168917b0-b3f2-47c0-9875-6a3535c851d5" });

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
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 14, 11, 36, 12, 623, DateTimeKind.Local).AddTicks(5336), new DateTime(2023, 8, 15, 9, 19, 30, 480, DateTimeKind.Local).AddTicks(4639), new DateTime(2024, 6, 14, 20, 16, 54, 412, DateTimeKind.Local).AddTicks(3550), 3, "4fae316f-5b08-4a6c-a20c-f606455d43b5", "Confirmé" });

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
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 14, 0, 0, 34, 528, DateTimeKind.Local).AddTicks(8137), new DateTime(2023, 8, 15, 6, 34, 38, 878, DateTimeKind.Local).AddTicks(1922), new DateTime(2023, 11, 23, 9, 41, 27, 322, DateTimeKind.Local).AddTicks(1758), 5, "b1632035-8c7f-4013-81a9-aee3ea53a3fc" });

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
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 13, 21, 47, 7, 890, DateTimeKind.Local).AddTicks(4650), new DateTime(2023, 8, 15, 14, 52, 36, 662, DateTimeKind.Local).AddTicks(8038), new DateTime(2024, 5, 8, 4, 2, 17, 318, DateTimeKind.Local).AddTicks(1943), 10, "07961e60-5189-40af-bbd4-d5a4b06f33d0", "Annulé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 14, 6, 28, 14, 540, DateTimeKind.Local).AddTicks(7451), new DateTime(2023, 8, 15, 8, 44, 21, 411, DateTimeKind.Local).AddTicks(9725), new DateTime(2023, 12, 8, 23, 39, 29, 706, DateTimeKind.Local).AddTicks(2700), 9, "15e5adf4-8711-49dc-a146-e8c6442e0533", "Confirmé" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 17, 4, 10, 14, 394, DateTimeKind.Local).AddTicks(7336), "Warren.Smitham@yahoo.com", "Glenna", 9, "Dicki", "$2a$11$8NIXsu.0GMrn8I2iBAk1muEOo6nIPNyfz.7m89zDDINfK1WLmUg1y" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 11, 9, 5, 23, 8, 928, DateTimeKind.Local).AddTicks(2366), "Damien.Halvorson@hotmail.com", "Hulda", 1, "Klocko", "$2a$11$WX0elchnvioFoQNbuLEezuwGgbzX16oX62sUAY4tHV8WFc8dh518W" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 11, 11, 34, 39, 212, DateTimeKind.Local).AddTicks(8629), "Nelson_Hudson34@gmail.com", "Randy", 9, 2, "Carroll", "$2a$11$/FcfvXTd1go3vOLGJkdx3uSkJUpPMumiGQr1lcZblq0nrK9GeEQLG" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 9, 11, 19, 16, 988, DateTimeKind.Local).AddTicks(1775), "Granville_Schamberger61@yahoo.com", "Quinn", 7, 2, false, "Robel", "$2a$11$0QK7wuvLailQAWvvw39M/uKOPb7Gx3Xit/c.LR32FEQOFSPyttB6q" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 15, 3, 58, 45, 263, DateTimeKind.Local).AddTicks(8040), "Sigmund.Morissette@hotmail.com", "Cielo", 1, 1, "Gutkowski", "$2a$11$BHBuca7bLNQOEAvnahqxse9moqJryCuOnh0b9AIRX/xT1qwcMcqiG" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 10, 19, 2, 5, 164, DateTimeKind.Local).AddTicks(523), "Kareem.Rodriguez@yahoo.com", "Orpha", 7, 2, "Armstrong", "$2a$11$HMadKmia981BTfzZTj3gmOtd01jvKGYBXb4MZUXgvYTcr85bhT5Jm" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 7, 5, 0, 3, 53, DateTimeKind.Local).AddTicks(7693), "Destinee.Boehm39@hotmail.com", "Delpha", true, "Balistreri", "$2a$11$v5FijxLtP9b5LUKX0qDZPeazTSTsMRy0U6PnXXk8rzii/v6GYoJGS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 13, 8, 54, 1, 296, DateTimeKind.Local).AddTicks(7806), "Riley_Hoppe@hotmail.com", "Shanny", 1, 2, "Towne", "$2a$11$bWP0lR1lrXFFYQcqiYiiBOZF/RXwd4ltq68WkcQYqjDQbkGDTuHzS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 7, 9, 43, 27, 627, DateTimeKind.Local).AddTicks(9815), "Violet19@hotmail.com", "Oral", true, "Simonis", "$2a$11$LryQWtnGO0HiprrlPY38kusv.wUtq4qOvSThMjMiHNudzW.bRz00S" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 8, 8, 2, 52, 17, 367, DateTimeKind.Local).AddTicks(9250), "Arielle37@hotmail.com", "Ima", 6, true, "Kozey", "$2a$11$bRLyVWpiv7GfeE.LQLtv3uBAsFkrXNjEM34ESSFFGmEnzOMzLF4nS" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2023, 5, 24, 5, 35, 11, 123, DateTimeKind.Local).AddTicks(2032), "janecvfevd", 122, 4517, "amrociykhy", "jktemnsvzz", "gwrnjkzerx", 6, 10, 2.0, "znidrdvquk" });

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
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2023, 2, 27, 15, 33, 58, 630, DateTimeKind.Local).AddTicks(815), "vcpixnbdzo", 10, 110, 2951, "mtguqhjbmg", "qppwmpsylr", "hsyvnhzieu", 7, 2, 5.0, "fxoaqzxjmw" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2023, 1, 11, 23, 38, 13, 81, DateTimeKind.Local).AddTicks(6905), "oetxysgaqd", 10, 229, 7759, "zrdavagkzr", "ujncimiznj", "ijeombdbtl", 5, 6, 4.0, "bzenejkxee" });

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
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Type" },
                values: new object[] { true, new DateTime(2023, 2, 8, 11, 31, 25, 460, DateTimeKind.Local).AddTicks(9482), "qcgdvaxcav", 9, 200, 1243, "qbziqmnsot", "xpaavoooyp", "fyxwbyxfml", 4, 7, "revexnkaqu" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2023, 5, 1, 18, 38, 1, 943, DateTimeKind.Local).AddTicks(6083), "cqqjrhkumq", 4, 233, 8989, "cmgpkgkmco", "ccbmwbdskc", "zcqkqskaeq", 10, 1, 3.0, "ownlmjmshx" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, false, new DateTime(2022, 11, 11, 22, 38, 20, 164, DateTimeKind.Local).AddTicks(7515), "vahmnzsehi", 4, 93, 117, "ggotizdalx", "vlacokvnhh", "ttxclazvpw", 2, 5, 5.0, "rudugzhqho" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, true, new DateTime(2022, 9, 7, 3, 38, 44, 398, DateTimeKind.Local).AddTicks(1782), "fozcnflhcz", 5, 313, 4700, "pcrbuuddtt", "obafrumoac", "ivbsxeetjv", 2, 8, 4.0, "mljsesvscz" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2023, 7, 24, 8, 57, 35, 602, DateTimeKind.Local).AddTicks(2081), "ekpclehsdw", 9, 121, 4414, "ptctelnmvv", "dexicqwsdy", "rmobqbkvzl", 4, 6, 2.0, "eoiblkdkez" });

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
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 12, 14, 18, 9, 7, 411, DateTimeKind.Local).AddTicks(6545), 254, "atnorrizlj", "Marks", 24, "Watsica - Tromp", "Kory", "842.582.3094", "Schroeder", "Gretchenside", "02849" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 6, 30, 23, 14, 38, 657, DateTimeKind.Local).AddTicks(2247), 306, "mpnydrwuts", "Hansen", 31, "Howe - Jerde", "Kaitlyn", "806.452.2014 x882", "Beatty", "West Breana", "95343" });
        }
    }
}
