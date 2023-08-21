using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AutomotiveApi.Migrations
{
    /// <inheritdoc />
    public partial class add_offre_details_and_montantReservation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "MontantTotal",
                table: "Reservations",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "OffreDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    IdOffre = table.Column<int>(type: "int", nullable: false),
                    Titre = table.Column<string>(type: "longtext", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OffreDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OffreDetail_id_offre",
                        column: x => x.IdOffre,
                        principalTable: "Offres",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "107 Bruen Freeway", "Port Maxineside", new DateTime(2023, 3, 31, 14, 22, 50, 244, DateTimeKind.Local).AddTicks(8674), "Lonzo43@gmail.com", 77.183300000000003, 97.7958, "Central Mobility Associate", "773.213.5357", "16678-1857" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "3571 Oliver Coves", "Dellafurt", new DateTime(2022, 10, 21, 9, 7, 27, 156, DateTimeKind.Local).AddTicks(7835), "Stone36@gmail.com", 47.3157, 67.239099999999993, "Direct Communications Orchestrator", "1-881-207-8141 x37857", "71118-3765" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "4288 Tyra Forest", "New Queenshire", new DateTime(2023, 4, 27, 2, 23, 13, 677, DateTimeKind.Local).AddTicks(6346), "Hal_Mertz@yahoo.com", -28.0395, 77.130499999999998, "International Marketing Engineer", "1-868-576-4018 x31343", "79903" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "554 Drake Land", "North Conrad", new DateTime(2023, 6, 1, 5, 18, 31, 36, DateTimeKind.Local).AddTicks(7313), "Bernadette_Maggio61@yahoo.com", 38.091299999999997, 96.870800000000003, "Global Optimization Liaison", "1-687-853-1117 x30146", "54306" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "3424 Balistreri Expressway", "New Chaneltown", new DateTime(2022, 12, 22, 12, 51, 13, 52, DateTimeKind.Local).AddTicks(3021), "Adrianna.Lesch2@gmail.com", 88.018699999999995, 89.467399999999998, "Lead Research Coordinator", "1-707-829-0375 x640", "01226-7947" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "627 Braden Track", "North Justina", new DateTime(2023, 7, 24, 19, 48, 54, 402, DateTimeKind.Local).AddTicks(5796), "Armand_Zemlak60@gmail.com", 17.315300000000001, -6.3228999999999997, "Investor Data Liaison", "1-977-228-2225 x5457", "45246-0500" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "9533 Janice Extension", "Thaliaburgh", new DateTime(2023, 1, 22, 22, 8, 9, 624, DateTimeKind.Local).AddTicks(7385), "Americo.Barrows@yahoo.com", -84.463099999999997, -146.20949999999999, "Regional Quality Manager", "(814) 513-5286 x41489", "85437-9807" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "734 Nienow Ways", "New Unique", new DateTime(2023, 7, 6, 23, 29, 52, 105, DateTimeKind.Local).AddTicks(6720), "Osborne_Dibbert7@hotmail.com", 20.6782, -77.658799999999999, "Direct Interactions Facilitator", "605-725-1601 x266", "57835" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "73974 Abbie Mission", "Reytown", new DateTime(2022, 9, 20, 5, 18, 24, 505, DateTimeKind.Local).AddTicks(5510), "Hiram_Quitzon@gmail.com", -39.194600000000001, 122.43989999999999, "Legacy Configuration Technician", "291.224.3895 x614", "22569-7286" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "15882 Domenico Prairie", "Luisafurt", new DateTime(2022, 12, 4, 5, 5, 11, 30, DateTimeKind.Local).AddTicks(5204), "Carolina.Breitenberg@yahoo.com", -36.308, -73.584299999999999, "Senior Usability Supervisor", "986.695.3976", "17006" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "39901 Craig Light", "21397 Yesenia Freeway", new DateTime(2023, 6, 9, 17, 37, 2, 271, DateTimeKind.Local).AddTicks(7950), "Aurelia.Luettgen27@gmail.com", "Alexandro", "Morissette", "https://picsum.photos/640/480/?image=412", "https://picsum.photos/640/480/?image=962", "(667) 737-7521 x23287", "Trevionland", "95098-9660" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "5193 Harris Spurs", "9299 Connelly Shoals", new DateTime(2023, 7, 4, 17, 20, 2, 83, DateTimeKind.Local).AddTicks(5071), "Ricardo81@gmail.com", "Princess", "Lockman", "https://picsum.photos/640/480/?image=151", "https://picsum.photos/640/480/?image=9", "421.932.4112", "Danniefort", "50175-5111" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "1514 Tromp Divide", "111 Jaylin Turnpike", new DateTime(2023, 2, 2, 21, 19, 28, 406, DateTimeKind.Local).AddTicks(1893), "Anabelle.Swaniawski10@hotmail.com", "Jett", "Upton", "https://picsum.photos/640/480/?image=309", "https://picsum.photos/640/480/?image=1050", "(968) 958-5259 x34990", "Lake Lafayetteton", "71341" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "505 Ebert Isle", "41110 Kulas Hollow", new DateTime(2023, 5, 13, 5, 10, 2, 319, DateTimeKind.Local).AddTicks(518), "Lawson10@hotmail.com", "Camden", "Dibbert", "https://picsum.photos/640/480/?image=802", "https://picsum.photos/640/480/?image=531", "1-780-291-8929", "Jeromeside", "21158-1147" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "42764 Elnora Ridges", "3375 Eldridge Ridge", new DateTime(2022, 11, 29, 14, 22, 8, 226, DateTimeKind.Local).AddTicks(3542), "Brannon70@gmail.com", "Kaela", "Stanton", "https://picsum.photos/640/480/?image=478", "https://picsum.photos/640/480/?image=89", "(822) 885-1498", "Pagacfort", "43663-0277" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "54337 Rosenbaum Avenue", "12274 Alivia Greens", new DateTime(2022, 9, 30, 12, 2, 34, 219, DateTimeKind.Local).AddTicks(9133), "Alessia_Blick51@gmail.com", "Reyes", "Kiehn", "https://picsum.photos/640/480/?image=587", "https://picsum.photos/640/480/?image=409", "913.737.3251", "New Serenitytown", "75283-9049" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "2869 Kub Square", "2004 Giovanni Mall", new DateTime(2023, 7, 24, 10, 36, 57, 221, DateTimeKind.Local).AddTicks(9636), "Melyssa13@gmail.com", "Lessie", "Upton", "https://picsum.photos/640/480/?image=214", "https://picsum.photos/640/480/?image=363", "1-403-800-9841 x747", "Schultzchester", "44253" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "5516 Harvey Stream", "3835 Frami Parkways", new DateTime(2022, 10, 17, 16, 6, 11, 889, DateTimeKind.Local).AddTicks(1194), "Elliot_Fahey@hotmail.com", "Justine", "Prosacco", "https://picsum.photos/640/480/?image=775", "https://picsum.photos/640/480/?image=178", "1-922-226-3310 x5174", "Kennedytown", "02951" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "554 Chadd Landing", "3373 Prohaska Locks", new DateTime(2022, 8, 25, 5, 4, 16, 150, DateTimeKind.Local).AddTicks(2497), "Alexandrine.Pacocha@hotmail.com", "Tara", "Kris", "https://picsum.photos/640/480/?image=994", "https://picsum.photos/640/480/?image=79", "325.567.7205 x746", "D'Amoreport", "87622" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "9510 Bruen Branch", "7014 Dietrich Point", new DateTime(2023, 7, 29, 18, 37, 16, 217, DateTimeKind.Local).AddTicks(2679), "Davin76@gmail.com", "Brendan", "Schiller", "https://picsum.photos/640/480/?image=76", "https://picsum.photos/640/480/?image=774", "696.204.0074 x467", "Vernton", "85022-0915" });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 8, 5, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 2,
                column: "IdClient",
                value: 8);

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
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 7, 6 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 7, 5 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 6,
                column: "IdReservation",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 10, 10 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 8, 1, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "IdClient", "IsConducteur" },
                values: new object[] { 1, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 10, 3, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 20, 1, 41, 38, 842, DateTimeKind.Local).AddTicks(3303), new DateTime(2023, 8, 21, 23, 21, 54, 211, DateTimeKind.Local).AddTicks(5412), new DateTime(2023, 9, 7, 22, 16, 50, 954, DateTimeKind.Local).AddTicks(3221), 6, 7.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 21, 0, 11, 21, 628, DateTimeKind.Local).AddTicks(3095), new DateTime(2023, 8, 21, 16, 34, 1, 553, DateTimeKind.Local).AddTicks(8099), new DateTime(2023, 8, 27, 21, 21, 5, 642, DateTimeKind.Local).AddTicks(755), 2, 6.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 20, 17, 23, 4, 775, DateTimeKind.Local).AddTicks(775), new DateTime(2023, 8, 21, 11, 26, 31, 931, DateTimeKind.Local).AddTicks(5545), new DateTime(2023, 10, 31, 1, 58, 41, 909, DateTimeKind.Local).AddTicks(1220), 2, 4.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 20, 21, 32, 23, 873, DateTimeKind.Local).AddTicks(5993), new DateTime(2023, 8, 21, 14, 28, 28, 494, DateTimeKind.Local).AddTicks(5361), new DateTime(2023, 12, 5, 22, 4, 51, 956, DateTimeKind.Local).AddTicks(2324), 8, 4.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 20, 6, 0, 37, 228, DateTimeKind.Local).AddTicks(1693), new DateTime(2023, 8, 21, 20, 58, 51, 386, DateTimeKind.Local).AddTicks(6228), new DateTime(2024, 2, 23, 2, 29, 35, 415, DateTimeKind.Local).AddTicks(6256), 3, 9.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 20, 1, 45, 44, 495, DateTimeKind.Local).AddTicks(620), new DateTime(2023, 8, 21, 18, 43, 53, 577, DateTimeKind.Local).AddTicks(6029), new DateTime(2023, 12, 24, 13, 54, 55, 697, DateTimeKind.Local).AddTicks(8308), 3, 2.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 20, 1, 46, 53, 83, DateTimeKind.Local).AddTicks(638), new DateTime(2023, 8, 21, 6, 19, 1, 255, DateTimeKind.Local).AddTicks(7209), new DateTime(2023, 9, 22, 0, 26, 18, 612, DateTimeKind.Local).AddTicks(4224), 6, 8.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 20, 3, 28, 28, 686, DateTimeKind.Local).AddTicks(881), new DateTime(2023, 8, 21, 1, 24, 55, 193, DateTimeKind.Local).AddTicks(4075), new DateTime(2024, 3, 3, 17, 54, 2, 265, DateTimeKind.Local).AddTicks(313), 6, 1.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 20, 16, 56, 55, 445, DateTimeKind.Local).AddTicks(9012), new DateTime(2023, 8, 21, 2, 58, 32, 551, DateTimeKind.Local).AddTicks(7997), new DateTime(2024, 4, 1, 23, 0, 38, 180, DateTimeKind.Local).AddTicks(8016), 6, 4.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 20, 7, 57, 59, 232, DateTimeKind.Local).AddTicks(2028), new DateTime(2023, 8, 21, 1, 33, 58, 867, DateTimeKind.Local).AddTicks(5087), new DateTime(2024, 6, 25, 19, 24, 39, 334, DateTimeKind.Local).AddTicks(3933), 8, false });

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
                keyValue: 3,
                column: "Name",
                value: "Roles");

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
                keyValue: 6,
                column: "Name",
                value: "Marques");

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
                values: new object[,]
                {
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Offres", null },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "LogJournal", null }
                });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "MontantTotal", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 20, 9, 4, 14, 646, DateTimeKind.Local).AddTicks(6237), new DateTime(2023, 8, 21, 15, 55, 59, 572, DateTimeKind.Local).AddTicks(2382), new DateTime(2024, 6, 30, 10, 34, 30, 540, DateTimeKind.Local).AddTicks(4204), 6, 0.0, "1fdfed46-c7a9-400e-a9cb-c4e815184b8b", "Confirmé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "MontantTotal", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 20, 3, 30, 48, 355, DateTimeKind.Local).AddTicks(1741), new DateTime(2023, 8, 21, 16, 37, 22, 273, DateTimeKind.Local).AddTicks(2915), new DateTime(2023, 11, 19, 18, 17, 37, 581, DateTimeKind.Local).AddTicks(4606), 10, 0.0, "1c71f826-68f4-4455-b272-eaf638ace731", "Expiré" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "MontantTotal", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 20, 10, 10, 23, 798, DateTimeKind.Local).AddTicks(4880), new DateTime(2023, 8, 21, 18, 52, 13, 517, DateTimeKind.Local).AddTicks(9961), new DateTime(2023, 12, 18, 14, 26, 0, 82, DateTimeKind.Local).AddTicks(5413), 8, 0.0, "773212ac-560e-4984-8bf9-8b92692fcc74", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "MontantTotal", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 20, 18, 37, 30, 344, DateTimeKind.Local).AddTicks(7749), new DateTime(2023, 8, 21, 14, 13, 9, 971, DateTimeKind.Local).AddTicks(5206), new DateTime(2023, 11, 24, 16, 49, 15, 238, DateTimeKind.Local).AddTicks(3481), 8, 0.0, "d46adf9e-8814-4899-ad93-9b8c25875358", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "MontantTotal", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 20, 0, 53, 45, 873, DateTimeKind.Local).AddTicks(3277), new DateTime(2023, 8, 21, 10, 24, 22, 333, DateTimeKind.Local).AddTicks(6375), new DateTime(2024, 5, 7, 3, 12, 48, 131, DateTimeKind.Local).AddTicks(1270), 6, 0.0, "dbcb5932-7ade-4778-85f2-edd2e6e53910", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "MontantTotal", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 20, 6, 41, 5, 521, DateTimeKind.Local).AddTicks(6697), new DateTime(2023, 8, 21, 20, 27, 46, 865, DateTimeKind.Local).AddTicks(8959), new DateTime(2024, 4, 29, 2, 12, 46, 416, DateTimeKind.Local).AddTicks(9048), 2, 0.0, "46697912-3cf8-4d6c-9305-7cdfb45d49bd", "Confirmé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "MontantTotal", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 20, 20, 36, 10, 475, DateTimeKind.Local).AddTicks(7444), new DateTime(2023, 8, 21, 3, 46, 24, 996, DateTimeKind.Local).AddTicks(874), new DateTime(2024, 2, 22, 13, 21, 29, 760, DateTimeKind.Local).AddTicks(5379), 10, 0.0, "920f7ec7-9592-475a-8618-dfc9addd1fef" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "MontantTotal", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 20, 9, 38, 49, 984, DateTimeKind.Local).AddTicks(8572), new DateTime(2023, 8, 21, 0, 52, 10, 890, DateTimeKind.Local).AddTicks(8394), new DateTime(2023, 9, 13, 21, 7, 59, 797, DateTimeKind.Local).AddTicks(8335), 5, 0.0, "289d4337-8610-4c71-846c-9f4de679ca17", "Annulé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "MontantTotal", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 20, 5, 43, 18, 597, DateTimeKind.Local).AddTicks(1529), new DateTime(2023, 8, 21, 13, 56, 38, 291, DateTimeKind.Local).AddTicks(3194), new DateTime(2023, 12, 6, 21, 42, 11, 219, DateTimeKind.Local).AddTicks(2975), 10, 0.0, "f7530e2d-aa18-4b08-8ed0-7f3676062e91" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "MontantTotal", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 20, 23, 35, 37, 388, DateTimeKind.Local).AddTicks(1684), new DateTime(2023, 8, 21, 23, 33, 11, 535, DateTimeKind.Local).AddTicks(552), new DateTime(2024, 7, 24, 23, 17, 15, 204, DateTimeKind.Local).AddTicks(460), 9, 0.0, "5ca081e6-e0d5-4501-994b-cb0ca2d517fe", "Expiré" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 28, 23, 10, 56, 111, DateTimeKind.Local).AddTicks(8592), "Marjorie3@gmail.com", "Avis", 7, "Emard", "$2a$11$ExGK1Hiv.Z8FlIXFICahCuRR6AGpI4QetpHGcEMQwmo0ANAH9FZdW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 26, 5, 15, 32, 466, DateTimeKind.Local).AddTicks(4114), "Braxton.Huel95@gmail.com", "Emelia", 7, 2, false, "Stanton", "$2a$11$EuLA1RVblObl7LviIMSZLOwdX7.ov6PDpvwwJo5OVUaNkDGkZwVpe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 15, 2, 52, 11, 449, DateTimeKind.Local).AddTicks(5128), "Rodrick17@hotmail.com", "Angelo", 6, 2, "Schiller", "$2a$11$x2n5UZabnhbbypBCiP7lHe3s/xEQcI8BLandjMBxq3nEHkJxDN9uy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 10, 4, 21, 4, 43, 237, DateTimeKind.Local).AddTicks(2380), "Florence12@hotmail.com", "Zola", 6, true, "O'Kon", "$2a$11$O03pqqeVepqn9wPcIrkcOuySi/jN.thut9U/S/KZqgmqJBHvC.y7u" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 12, 0, 59, 37, 398, DateTimeKind.Local).AddTicks(872), "Zachary61@yahoo.com", "Zoey", 2, "Larkin", "$2a$11$TiXoygOkmMf8.OMf.7yijezEkk5bgkIt/RSzOQNPF/mtwH.q9FMIW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 25, 15, 53, 36, 878, DateTimeKind.Local).AddTicks(135), "Cleta94@hotmail.com", "Odessa", 8, 1, true, "Shanahan", "$2a$11$kPSVwwtB6UHehxurMiMbY.120Ldr1ML5.uGreGQ.0rP7vVxdQOgCS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 8, 28, 2, 21, 20, 652, DateTimeKind.Local).AddTicks(8404), "Audie.Anderson@hotmail.com", "Jessie", "Walker", "$2a$11$PGUxhJdLDxr9GVOK0I7.TOwaJQClv9KLKhrN4QxGWYCJuhPvB2mUO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 1, 19, 56, 57, 675, DateTimeKind.Local).AddTicks(8264), "Zoe51@hotmail.com", "Emmet", 2, false, "Bahringer", "$2a$11$JLhhpjPAbjyygqAEdoKROu5dD0jutSkDu7zLVWTvKcS/S76XhfWzK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 8, 17, 11, 28, 45, 855, DateTimeKind.Local).AddTicks(7004), "Dennis.Anderson@hotmail.com", "Sammie", 2, true, "Muller", "$2a$11$KUJW7pBOqJRqxSpWzN5buOe9GUJyT3BT8HRzJr0GVam7F0uR0W0qK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 10, 14, 6, 39, 0, 30, DateTimeKind.Local).AddTicks(1562), "Mollie.Bradtke@gmail.com", "Manuela", 8, false, "Dooley", "$2a$11$YyGX.1lNyGh6jogY1DCoA.wt8n0OxDa5R334J9Jl6KFt6le2MGVX2" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2022, 10, 7, 18, 13, 14, 211, DateTimeKind.Local).AddTicks(8819), "qvipfieddk", 9, 172, 1616, "hotvydttkm", "rirlryopfs", "ubmnhgxpbw", 5, 4, 7.0, "lwmtzweyty" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2022, 12, 13, 18, 48, 12, 89, DateTimeKind.Local).AddTicks(3732), "pfcszqljqv", 18, 648, "jrkewfzixf", "vwvdeivzse", "vnxdzboldi", 1, 3.0, "bxihbyipyg" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2023, 4, 14, 17, 16, 17, 791, DateTimeKind.Local).AddTicks(6585), "rosvtkynsx", 1, 73, 6550, "velzlwkuwv", "nhboccwpfj", "jfwrsorxrn", 2, 4.0, "clftazkrif" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2022, 11, 21, 11, 8, 53, 911, DateTimeKind.Local).AddTicks(2464), "flffdtlhae", 278, 516, "arlnoxlknp", "muucaeozow", "laymmfecfg", 2, 8, 6.0, "hvjixbezgl" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, false, new DateTime(2022, 9, 12, 21, 16, 40, 726, DateTimeKind.Local).AddTicks(1050), "ueriqwncso", 6, 125, 3491, "cstguweppm", "ioeywgrvjc", "fblhsotdfl", 1, 1, 1.0, "mrjcumeswl" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2023, 1, 26, 9, 42, 1, 603, DateTimeKind.Local).AddTicks(333), "uadxwtxtmk", 210, 5341, "mipbzuqulm", "upgeujaqkb", "bytkyicozk", 6, 9, 8.0, "owrvlcywif" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2023, 5, 31, 23, 30, 3, 99, DateTimeKind.Local).AddTicks(8058), "mccurduolc", 8, 104, 9838, "vmgxlaukwx", "fzhysyapot", "vnxdxydwod", 2, 1.0, "vjktuvxlnh" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2023, 8, 20, 1, 17, 37, 924, DateTimeKind.Local).AddTicks(5494), "nvvvrhsgdy", 148, 3170, "xtfevitwrq", "srcwwmtlol", "xmrlpqddlb", 7, 9, 7.0, "yyytgrhsny" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2023, 3, 3, 2, 57, 6, 927, DateTimeKind.Local).AddTicks(4529), "wgsyblpayt", 3, 190, 1878, "deyssxqjgz", "vqgrshnnvr", "veppizrqef", 6, 2, 6.0, "mzqhipfuwb" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2022, 11, 25, 20, 59, 49, 338, DateTimeKind.Local).AddTicks(4169), "imtnofruiz", 5, 309, 47, "nlaulhtloq", "poknflunok", "vlqxlqrewv", 3, 5.0, "hqysqaqejj" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 3, 20, 2, 4, 45, 671, DateTimeKind.Local).AddTicks(3814), 28, "fskyvzpgat", "Predovic", 30, "Turner LLC", "Dayana", "1-370-513-2786", "Rippin", "West Adanmouth", "12269" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 7, 30, 4, 14, 12, 274, DateTimeKind.Local).AddTicks(4569), 323, "szvxwpfotr", "Conn", 18, "Larkin and Sons", "Martine", "418-734-4926 x6216", "Runolfsdottir", "South Candacefort", "85336" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 1, 24, 16, 8, 6, 564, DateTimeKind.Local).AddTicks(6235), 78, "typfjkllrs", "Stroman", 30, "Abernathy Group", "Heather", "511.653.2127 x274", "Carter", "Schinnerport", "39568" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 5, 8, 0, 28, 27, 70, DateTimeKind.Local).AddTicks(1407), 224, "tfikdyypck", "Skiles", 32, "Hintz, Schmeler and Kemmer", "Mac", "575-283-4242 x66055", "Lynch", "Alfville", "22457-7585" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 10, 1, 3, 40, 45, 226, DateTimeKind.Local).AddTicks(5619), 218, "zwhfrknqbd", "Franecki", 30, "Lynch - Prosacco", "Keegan", "(647) 457-8672 x5869", "Wiza", "New Jamey", "92584" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 2, 23, 13, 40, 24, 918, DateTimeKind.Local).AddTicks(1383), 72, "ddzolluifs", "Feest", 19, "Collins - Willms", "Yesenia", "(616) 662-2376", "Langworth", "Julianshire", "78019-0275" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 7, 31, 5, 31, 55, 326, DateTimeKind.Local).AddTicks(7909), 185, "jregvvrlir", "Bartoletti", 22, "O'Conner - Carroll", "Russel", "320-754-5711 x6849", "Predovic", "East Percyland", "42293-3633" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 10, 29, 23, 28, 28, 765, DateTimeKind.Local).AddTicks(7342), 23, "fmaulkkxii", "Bartell", 21, "Steuber Group", "Dameon", "284.315.1863 x0547", "Gusikowski", "Antwanburgh", "54661-4510" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 3, 21, 17, 37, 15, 309, DateTimeKind.Local).AddTicks(8749), 179, "zmywprmibh", "Grant", 18, "Fadel and Sons", "Norval", "773-279-9710", "Kemmer", "Lake Erika", "06681-0677" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 7, 26, 2, 26, 23, 68, DateTimeKind.Local).AddTicks(6130), 285, "fyrauvngoo", "Leuschke", 31, "Dietrich and Sons", "Burley", "466.688.0418", "Buckridge", "New Mikefurt", "21309-5917" });

            migrationBuilder.CreateIndex(
                name: "IX_OffreDetails_IdOffre",
                table: "OffreDetails",
                column: "IdOffre");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OffreDetails");

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DropColumn(
                name: "MontantTotal",
                table: "Reservations");

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "838 Juliet Glens", "Mayerbury", new DateTime(2023, 8, 10, 18, 55, 2, 331, DateTimeKind.Local).AddTicks(9044), "Brown9@gmail.com", 69.957400000000007, -73.581000000000003, "Investor Program Representative", "(337) 663-2905 x3249", "67504-7844" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "720 Bashirian Mission", "South Esperanzahaven", new DateTime(2023, 5, 21, 14, 15, 2, 867, DateTimeKind.Local).AddTicks(2125), "Christine_Gerhold38@hotmail.com", -87.073499999999996, 129.82589999999999, "Investor Usability Analyst", "743-426-3197 x974", "82820-5222" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "78176 Feest Summit", "East Jennie", new DateTime(2023, 2, 13, 12, 14, 22, 959, DateTimeKind.Local).AddTicks(457), "Jammie.Gibson71@yahoo.com", 69.613200000000006, 173.41810000000001, "International Applications Administrator", "1-738-629-3562 x152", "75650" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "027 Jacquelyn Fords", "New Brannonberg", new DateTime(2023, 1, 12, 20, 57, 39, 857, DateTimeKind.Local).AddTicks(2513), "Audrey81@yahoo.com", -73.742900000000006, -50.222900000000003, "Dynamic Brand Director", "1-309-267-8073 x746", "23248" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "058 Lubowitz Villages", "Port Andy", new DateTime(2023, 5, 5, 23, 4, 47, 194, DateTimeKind.Local).AddTicks(2392), "Raymundo.Hermiston@yahoo.com", -75.089100000000002, 173.52459999999999, "Global Identity Assistant", "1-862-273-9684", "36321" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "1315 Fadel Parkways", "Kyleebury", new DateTime(2023, 3, 24, 9, 23, 28, 934, DateTimeKind.Local).AddTicks(3796), "Rubie49@yahoo.com", 26.295999999999999, 143.5872, "Forward Accounts Producer", "(632) 463-3148 x377", "80450" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "415 Marquardt Ranch", "Hailieberg", new DateTime(2022, 8, 25, 10, 41, 30, 383, DateTimeKind.Local).AddTicks(371), "Chaim_Robel@yahoo.com", -66.7119, -148.1285, "Dynamic Implementation Administrator", "751.465.6212 x12053", "96547" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "93134 Gibson Orchard", "South Leahaven", new DateTime(2023, 8, 1, 17, 44, 33, 781, DateTimeKind.Local).AddTicks(8593), "Mitchell84@yahoo.com", 79.666499999999999, 8.5662000000000003, "Dynamic Directives Architect", "537.649.9594", "49979-6640" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "96715 Thompson Trace", "Sengerbury", new DateTime(2022, 10, 10, 14, 40, 45, 745, DateTimeKind.Local).AddTicks(8597), "Zakary.Ratke4@gmail.com", 63.116199999999999, 109.7533, "Dynamic Mobility Administrator", "1-698-433-1953", "88311" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "446 Labadie Road", "East Sophiaport", new DateTime(2022, 10, 6, 12, 53, 11, 494, DateTimeKind.Local).AddTicks(4571), "Milton_Barton6@hotmail.com", -72.828599999999994, 150.46789999999999, "Future Accounts Assistant", "(535) 575-5514 x81504", "94571" });

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
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 5, 3, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 2,
                column: "IdClient",
                value: 7);

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
                column: "IdReservation",
                value: 6);

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
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 1, 9, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "IdClient", "IsConducteur" },
                values: new object[] { 6, true });

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
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 17, 10, 0, 11, 623, DateTimeKind.Local).AddTicks(3217), new DateTime(2023, 8, 18, 0, 58, 5, 342, DateTimeKind.Local).AddTicks(6967), new DateTime(2024, 5, 5, 10, 25, 18, 87, DateTimeKind.Local).AddTicks(7815), 5, 2.0, false });

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
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 17, 16, 43, 42, 823, DateTimeKind.Local).AddTicks(7820), new DateTime(2023, 8, 18, 9, 11, 3, 105, DateTimeKind.Local).AddTicks(4568), new DateTime(2024, 3, 14, 12, 36, 19, 788, DateTimeKind.Local).AddTicks(2086), 4, 8.0 });

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
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 17, 18, 13, 24, 369, DateTimeKind.Local).AddTicks(1334), new DateTime(2023, 8, 18, 14, 0, 38, 958, DateTimeKind.Local).AddTicks(231), new DateTime(2024, 2, 27, 16, 46, 12, 553, DateTimeKind.Local).AddTicks(9785), 3, 4.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 17, 2, 19, 15, 629, DateTimeKind.Local).AddTicks(4127), new DateTime(2023, 8, 17, 20, 54, 7, 152, DateTimeKind.Local).AddTicks(8862), new DateTime(2024, 2, 6, 18, 36, 47, 701, DateTimeKind.Local).AddTicks(6990), 8, 4.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 17, 7, 53, 38, 931, DateTimeKind.Local).AddTicks(8687), new DateTime(2023, 8, 18, 1, 7, 35, 766, DateTimeKind.Local).AddTicks(573), new DateTime(2023, 8, 22, 2, 18, 18, 511, DateTimeKind.Local).AddTicks(217), 3, 10.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 17, 1, 23, 9, 90, DateTimeKind.Local).AddTicks(6130), new DateTime(2023, 8, 18, 14, 53, 9, 375, DateTimeKind.Local).AddTicks(2986), new DateTime(2023, 9, 25, 1, 44, 42, 590, DateTimeKind.Local).AddTicks(6399), 9, true });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Users");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Roles");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Permissions");

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
                value: "Marques");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Modeles");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Reservations");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Clients");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "LongTerm");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Vehicles");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Offres");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 17, 10, 33, 35, 208, DateTimeKind.Local).AddTicks(5857), new DateTime(2023, 8, 17, 20, 57, 18, 761, DateTimeKind.Local).AddTicks(987), new DateTime(2024, 5, 12, 10, 42, 18, 821, DateTimeKind.Local).AddTicks(5), 3, "d468f208-100a-4677-af6b-7ad55326590a", "Annulé" });

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
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 17, 17, 55, 12, 836, DateTimeKind.Local).AddTicks(4628), new DateTime(2023, 8, 17, 23, 59, 5, 636, DateTimeKind.Local).AddTicks(718), new DateTime(2023, 11, 27, 13, 26, 27, 422, DateTimeKind.Local).AddTicks(5460), 2, "cfc5721a-86e4-486f-bb03-e93be28c649e", "Confirmé" });

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
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 16, 19, 1, 36, 436, DateTimeKind.Local).AddTicks(3552), new DateTime(2023, 8, 18, 1, 31, 16, 113, DateTimeKind.Local).AddTicks(32), new DateTime(2024, 7, 27, 22, 10, 45, 728, DateTimeKind.Local).AddTicks(3744), 7, "af0a2c7e-2f07-4ca5-85dd-3ed0b95df03c" });

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
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 17, 3, 33, 20, 358, DateTimeKind.Local).AddTicks(3709), new DateTime(2023, 8, 18, 4, 29, 1, 706, DateTimeKind.Local).AddTicks(8462), new DateTime(2024, 3, 9, 21, 8, 34, 746, DateTimeKind.Local).AddTicks(5220), 5, "d7ef342f-1154-42c6-9171-0796d8e7c017" });

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
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 20, 14, 45, 54, 25, DateTimeKind.Local).AddTicks(4216), "Providenci_Krajcik58@yahoo.com", "Angie", 5, "Steuber", "$2a$11$CT7grVgCJB3NEeWF5jZMJe8XdWB9HLXplUd3Xk0kq6bk.XK2FLY6O" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 8, 5, 19, 41, 48, 862, DateTimeKind.Local).AddTicks(7237), "Freddy36@gmail.com", "Daphnee", 4, 1, true, "Prosacco", "$2a$11$h7lpZ7al6x6dor1BHGT.UuT/CsbtxqPMA55VKD2WTfXwSb.t8ESPS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 2, 26, 6, 28, 48, 590, DateTimeKind.Local).AddTicks(3213), "Maybell_Smitham69@hotmail.com", "Corrine", 8, 1, "Murray", "$2a$11$.1xslCp6I/sALCLCwsEvGOiG02NG47yWYEnlFgub4cdh8Gq5kPpx6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 13, 4, 16, 58, 319, DateTimeKind.Local).AddTicks(673), "Layne.Kovacek41@hotmail.com", "Maddison", 4, false, "Ondricka", "$2a$11$3M/FN5TcPEzgDVrzMJ1DOudtzW0orupDFSptCQ5A5VW58QKoHaLHK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 2, 11, 12, 10, 11, 919, DateTimeKind.Local).AddTicks(9808), "Kade.Morissette53@hotmail.com", "Elmore", 1, "Langosh", "$2a$11$.88ivUO4yJFERlp9FMLCXOR43nRbd4RNJc3QmW9vyra3Lcym3bkHK" });

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
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 8, 15, 18, 24, 6, 311, DateTimeKind.Local).AddTicks(4321), "Halle2@yahoo.com", "Alverta", "Kub", "$2a$11$OLZBtsGh7EjHd6ret812QOrD4G3/ZEbSeuasxY6XFBPKgDG8zLIv2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 7, 26, 14, 58, 6, 644, DateTimeKind.Local).AddTicks(2132), "Darius63@hotmail.com", "Warren", 7, true, "Hammes", "$2a$11$/8V6rCps4ODaBsUB0lbPxOD8y7qWpHkbvhNYCSYbkbo6X1bSLw31y" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 28, 10, 19, 42, 296, DateTimeKind.Local).AddTicks(7686), "Mortimer.Murazik53@gmail.com", "Angel", 6, false, "Ondricka", "$2a$11$oCH57JMH3VU1oT4eAsb8XupLvzdJ9f7HcB2UFchKapVjzkcRwvc4G" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 52, 14, 901, DateTimeKind.Local).AddTicks(6217), "Vesta39@gmail.com", "Jimmy", 7, true, "Heaney", "$2a$11$QYhORrpOqzDytGB1XjlUJeUdLlyuf30cmhAo1F6lRPfYL6bA9Dpzy" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2023, 1, 10, 11, 1, 22, 95, DateTimeKind.Local).AddTicks(3038), "kyvdzsdgvd", 8, 100, 9777, "bitgnbjren", "adyqktccxw", "iaujhprjiy", 4, 9, 4.0, "rweugzlqzo" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2022, 9, 15, 22, 48, 3, 941, DateTimeKind.Local).AddTicks(5721), "kiuvferqqg", 111, 290, "goxbpfdtoy", "bilahlgvqh", "wjeerqciab", 7, 5.0, "gavlcrvljj" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2023, 6, 7, 1, 28, 13, 665, DateTimeKind.Local).AddTicks(2605), "fgoeooslpl", 9, 319, 3558, "lzwcmzxwvs", "rlucgmoiiy", "iabslmyaxu", 1, 9.0, "keabsbscvz" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2023, 2, 8, 17, 1, 51, 788, DateTimeKind.Local).AddTicks(2127), "uyowshyhze", 36, 4000, "rqqxundgap", "skeemxyskp", "cpsjwmowyo", 5, 6, 2.0, "bxyonuassk" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, true, new DateTime(2023, 5, 21, 20, 44, 4, 224, DateTimeKind.Local).AddTicks(6536), "ctunutimjy", 2, 18, 9494, "qnzbgptijn", "dkhmtksynx", "bbykwjpvyz", 7, 5, 6.0, "kqsayjxggj" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2022, 10, 8, 20, 26, 59, 432, DateTimeKind.Local).AddTicks(7408), "bbddwfhbwc", 235, 3681, "jpjkfplfep", "crmryevsxu", "wylgduvvzg", 3, 8, 10.0, "xpmatxwlxz" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2023, 4, 29, 7, 45, 20, 848, DateTimeKind.Local).AddTicks(8977), "erthpsmhdn", 4, 163, 7467, "ldigdfyifb", "olmjpukrbz", "covhcarubn", 8, 4.0, "hcjuuecjac" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2022, 8, 26, 13, 23, 31, 892, DateTimeKind.Local).AddTicks(7278), "mbngkiiatz", 38, 5653, "upugtcfwhh", "xcacjyijdx", "pgsuuxsjaq", 10, 5, 2.0, "hnnxdfxfms" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2023, 7, 19, 6, 40, 15, 882, DateTimeKind.Local).AddTicks(4291), "cxplgwqoqk", 9, 29, 3655, "qsgueruahv", "htllifcyvq", "alnqucapgp", 4, 3, 1.0, "sfoisateay" });

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
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 7, 5, 10, 52, 53, 443, DateTimeKind.Local).AddTicks(8773), 41, "lremakqgpw", "Heaney", 33, "Wilkinson, Murazik and White", "Fletcher", "752.687.6596", "Berge", "Michelebury", "56000" });

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
    }
}
