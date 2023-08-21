using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace AutomotiveApi.Migrations
{
    /// <inheritdoc />
    public partial class add_pienceJointes_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isAgence",
                table: "lld_responses",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "PieceJointes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FileName = table.Column<string>(type: "longtext", nullable: false),
                    IdLLDReponse = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PieceJointes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PieceJointes_lld_responses_IdLLDReponse",
                        column: x => x.IdLLDReponse,
                        principalTable: "lld_responses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

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
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 6, 5, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IdClient", "IsConducteur" },
                values: new object[] { 1, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IdReservation", "IsConducteur" },
                values: new object[] { 3, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 2, 8 });

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
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 8, 2, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 4, 10, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 8,
                column: "IdReservation",
                value: 6);

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
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 2, 6 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 21, 1, 25, 27, 324, DateTimeKind.Local).AddTicks(111), new DateTime(2023, 8, 22, 4, 9, 55, 745, DateTimeKind.Local).AddTicks(4758), new DateTime(2023, 12, 23, 11, 55, 35, 971, DateTimeKind.Local).AddTicks(7042), 3, 7.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 20, 21, 20, 40, 151, DateTimeKind.Local).AddTicks(1439), new DateTime(2023, 8, 22, 6, 9, 54, 298, DateTimeKind.Local).AddTicks(4882), new DateTime(2023, 10, 17, 6, 59, 41, 751, DateTimeKind.Local).AddTicks(6026), 1, 9.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 20, 22, 46, 6, 65, DateTimeKind.Local).AddTicks(9098), new DateTime(2023, 8, 22, 17, 19, 24, 769, DateTimeKind.Local).AddTicks(9937), new DateTime(2024, 5, 20, 21, 1, 12, 735, DateTimeKind.Local).AddTicks(588), 8, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 21, 17, 34, 28, 508, DateTimeKind.Local).AddTicks(3145), new DateTime(2023, 8, 22, 16, 38, 3, 852, DateTimeKind.Local).AddTicks(4271), new DateTime(2024, 6, 15, 3, 19, 4, 670, DateTimeKind.Local).AddTicks(1186), 6, 10.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 21, 6, 32, 57, 989, DateTimeKind.Local).AddTicks(5273), new DateTime(2023, 8, 22, 11, 22, 13, 114, DateTimeKind.Local).AddTicks(3530), new DateTime(2024, 7, 26, 10, 10, 13, 433, DateTimeKind.Local).AddTicks(7431), 4, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 20, 22, 26, 16, 570, DateTimeKind.Local).AddTicks(2425), new DateTime(2023, 8, 22, 4, 15, 24, 798, DateTimeKind.Local).AddTicks(1847), new DateTime(2024, 2, 27, 3, 22, 4, 476, DateTimeKind.Local).AddTicks(1707), 10.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 21, 19, 57, 42, 579, DateTimeKind.Local).AddTicks(7354), new DateTime(2023, 8, 21, 23, 51, 18, 795, DateTimeKind.Local).AddTicks(226), new DateTime(2024, 2, 5, 13, 13, 33, 512, DateTimeKind.Local).AddTicks(3422), 8, 2.0, true });

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
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 21, 16, 31, 55, 937, DateTimeKind.Local).AddTicks(3225), new DateTime(2023, 8, 22, 17, 34, 14, 752, DateTimeKind.Local).AddTicks(1745), new DateTime(2024, 1, 15, 4, 18, 40, 380, DateTimeKind.Local).AddTicks(4249), 5, 1.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 21, 20, 52, 24, 3, DateTimeKind.Local).AddTicks(9744), new DateTime(2023, 8, 22, 11, 13, 12, 475, DateTimeKind.Local).AddTicks(7292), new DateTime(2024, 7, 29, 3, 46, 39, 73, DateTimeKind.Local).AddTicks(2574), 6, 4.0, true });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 21, 5, 27, 15, 327, DateTimeKind.Local).AddTicks(7272), new DateTime(2023, 8, 22, 14, 34, 9, 422, DateTimeKind.Local).AddTicks(9441), new DateTime(2024, 8, 4, 1, 50, 3, 218, DateTimeKind.Local).AddTicks(8632), 2, "00fd1c0d-d751-4ee7-a3ee-a24252d18197" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 21, 8, 10, 4, 546, DateTimeKind.Local).AddTicks(5092), new DateTime(2023, 8, 22, 4, 8, 13, 52, DateTimeKind.Local).AddTicks(6330), new DateTime(2023, 11, 10, 20, 29, 16, 473, DateTimeKind.Local).AddTicks(3238), 10, "c422b648-90bb-419d-8693-15f0631848a1" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 21, 20, 50, 37, 990, DateTimeKind.Local).AddTicks(9960), new DateTime(2023, 8, 22, 0, 32, 24, 982, DateTimeKind.Local).AddTicks(5301), new DateTime(2024, 8, 11, 11, 56, 36, 824, DateTimeKind.Local).AddTicks(4461), "2d5d0a0d-921c-41a3-b26b-2a0dd84027c7" });

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
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 21, 9, 58, 32, 588, DateTimeKind.Local).AddTicks(4004), new DateTime(2023, 8, 22, 3, 32, 17, 83, DateTimeKind.Local).AddTicks(7411), new DateTime(2023, 9, 10, 1, 37, 38, 912, DateTimeKind.Local).AddTicks(2552), 8, "f5ba7427-bfbd-4943-b8d0-2064067e4d7b" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 21, 12, 11, 56, 438, DateTimeKind.Local).AddTicks(833), new DateTime(2023, 8, 22, 7, 7, 50, 960, DateTimeKind.Local).AddTicks(1687), new DateTime(2023, 12, 3, 0, 0, 43, 909, DateTimeKind.Local).AddTicks(3779), 4, "35f20257-df42-4d5a-84ea-2c473c81b32a", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 21, 0, 20, 35, 822, DateTimeKind.Local).AddTicks(5039), new DateTime(2023, 8, 22, 7, 37, 35, 898, DateTimeKind.Local).AddTicks(1104), new DateTime(2024, 1, 27, 14, 13, 30, 59, DateTimeKind.Local).AddTicks(7189), 4, "9d6b4be6-4ef5-4daf-8e3e-642867ea7837" });

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
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 22, 16, 37, 47, 529, DateTimeKind.Local).AddTicks(8082), "Rashad_Effertz6@yahoo.com", "Bradford", 3, 1, false, "Lindgren", "$2a$11$p2YFOenohCjckl45QSCmOOYFw4HHMWCWu/.gKCNv8BtAFNopi/zmq" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 8, 2, 10, 48, 20, 814, DateTimeKind.Local).AddTicks(5003), "Carlos_OReilly96@hotmail.com", "Francesco", 2, "Gislason", "$2a$11$qw3v1n/WLT6T53nKAcw.i.qm.FfUWKTfU7Iq.pumIoT3KOEuwc9Am" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 6, 11, 5, 41, 874, DateTimeKind.Local).AddTicks(7631), "Destany52@gmail.com", "Dane", 8, true, "Schamberger", "$2a$11$ACyqkWV5yjzfj01hstKjEekPPOk7q.wulLMIsiRunZXGZhGaJWBYW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 6, 10, 54, 50, 87, DateTimeKind.Local).AddTicks(1267), "Orville_Dicki@hotmail.com", "Braden", 4, "VonRueden", "$2a$11$I11zTODW7pVVLcRZL3Lce.0PYUgErBEYEL2.laF2/VCc./Ww/1ri2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 24, 23, 34, 8, 918, DateTimeKind.Local).AddTicks(7879), "Manuel_Jones@yahoo.com", "Verner", 5, 2, true, "Pfannerstill", "$2a$11$NU9dItNduEESZ1Pil6mxGeyGWbm0cFXEDuyDypit6BccUq8B2aiOa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 22, 16, 37, 11, 700, DateTimeKind.Local).AddTicks(2538), "Mack_Graham@gmail.com", "Juanita", 6, 1, true, "Luettgen", "$2a$11$T0ex3g/.vlHyVMtJQUjFgeQWN.vjSAOxoorVkwebLXWcjms0yBDj2" });

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
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 11, 18, 10, 32, 7, 792, DateTimeKind.Local).AddTicks(530), "Betty.Walsh@gmail.com", "Josefina", 8, 1, true, "Crona", "$2a$11$i/xBzaJEnT9i3msNEsSlDOgDzd2X4IeUCoveD.zIMn3kdv3t9AInC" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 11, 11, 17, 14, 46, 535, DateTimeKind.Local).AddTicks(2998), "Muriel_Kuhn32@gmail.com", "Gordon", 6, true, "Schiller", "$2a$11$IYnQ4dqZBF/tJ/UOSkVNZeCB7BrHGZG3AIARKf87WnlRO5rdlOa1O" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 10, 5, 17, 16, 45, 310, DateTimeKind.Local).AddTicks(9564), "Anne_Harris@hotmail.com", "Arthur", "VonRueden", "$2a$11$WjK5IK6dJ4lBA1IVFs81D.5pjdJDSqtAXYLu9sSlMZednSKtjMM9q" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, false, new DateTime(2022, 8, 29, 19, 57, 27, 194, DateTimeKind.Local).AddTicks(9294), "cnpwxoktxd", 3, 130, 1429, "dvnwxnikfn", "jetuigoofu", "egzibxexjy", 10, 5, 7.0, "doqxrysycr" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2023, 3, 11, 9, 3, 34, 531, DateTimeKind.Local).AddTicks(6016), "fxqfdxtacl", 5, 70, 6859, "phmvwqtktl", "yswirsokmg", "ghbajvvwqf", 10, 2, 9.0, "ngfdiyjxvf" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2022, 12, 26, 22, 19, 7, 234, DateTimeKind.Local).AddTicks(9282), "nkrozjuhea", 125, 6988, "rtdfjedmaq", "fsuxzhgjjg", "oeayogrkcg", 5, 6, 4.0, "rsabmzyuny" });

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
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2023, 3, 23, 13, 8, 5, 935, DateTimeKind.Local).AddTicks(421), "afmbholonx", 3, 324, 690, "xbfcjrxxqn", "nfpgpxyqps", "zyzpvvxexv", 8, 7, 10.0, "zbvxfwalnk" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, false, new DateTime(2022, 11, 20, 0, 1, 1, 681, DateTimeKind.Local).AddTicks(3788), "isascudhdx", 6, 317, 3588, "kuhkpknpkx", "lubkakktxu", "kirjoiroau", 3, 5, 1.0, "uekuckmtbm" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2023, 1, 10, 18, 47, 3, 342, DateTimeKind.Local).AddTicks(9236), "plekhdlwis", 1, 233, 4613, "rdtwowxqbb", "pkichczfjv", "aueposapyc", 8, 2, 6.0, "yyfiarfade" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, false, new DateTime(2023, 7, 15, 8, 59, 19, 844, DateTimeKind.Local).AddTicks(1975), "fuyldknbma", 8, 130, 1948, "pcrtwuawep", "dlxdulmkfj", "hsdpjwmwvb", 9, 10, 2.0, "vgzgfnsedg" });

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
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "Type" },
                values: new object[] { false, false, new DateTime(2023, 3, 5, 21, 51, 29, 259, DateTimeKind.Local).AddTicks(7044), "xbasofqsdu", 9, 245, 8665, "hodapvbrso", "yyicqrhcqd", "rgwgigyjaw", 7, "qdbfvfgmaj" });

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
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 1, 19, 8, 32, 48, 264, DateTimeKind.Local).AddTicks(2957), "fpkmvhldzn", 71, "ymardyprru", "uaspxnlmke", "Stiedemann", "McCullough - Larson", "Karlee", "1-719-902-0061 x60948", "Greenfelder", "Lake Vinnie", "95325" });

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

            migrationBuilder.CreateIndex(
                name: "IX_PieceJointes_IdLLDReponse",
                table: "PieceJointes",
                column: "IdLLDReponse");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PieceJointes");

            migrationBuilder.DropColumn(
                name: "isAgence",
                table: "lld_responses");

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "3997 Skiles Track", "Eveville", new DateTime(2023, 1, 7, 1, 58, 11, 474, DateTimeKind.Local).AddTicks(9169), "Adrienne_Batz@hotmail.com", -13.338200000000001, -172.4392, "Global Data Agent", "915-557-9627 x2020", "74654" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "078 Legros Garden", "East Orphachester", new DateTime(2022, 11, 23, 1, 6, 13, 189, DateTimeKind.Local).AddTicks(7835), "Anya_Schroeder@yahoo.com", 57.449599999999997, 57.203200000000002, "National Infrastructure Developer", "251-215-9043", "20806" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "6067 Larkin View", "Hobartside", new DateTime(2023, 7, 30, 5, 7, 15, 930, DateTimeKind.Local).AddTicks(4171), "Laurine9@yahoo.com", -4.0521000000000003, -117.03830000000001, "Lead Response Specialist", "507-296-7434", "23065" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "258 Kuhlman Causeway", "West Haydenmouth", new DateTime(2022, 8, 31, 0, 23, 59, 175, DateTimeKind.Local).AddTicks(1262), "Audie.Thompson@hotmail.com", 61.891500000000001, -4.0331999999999999, "Central Accounts Assistant", "601-763-8891", "54509" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "437 Wilburn Manor", "Stromanfurt", new DateTime(2022, 9, 27, 18, 27, 34, 98, DateTimeKind.Local).AddTicks(4299), "Joel_Hickle@gmail.com", 84.596599999999995, -77.456000000000003, "Chief Operations Engineer", "(304) 421-5818", "71908-9084" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "0322 Ledner Street", "North Cynthia", new DateTime(2023, 6, 8, 12, 2, 44, 583, DateTimeKind.Local).AddTicks(1134), "Shayna27@gmail.com", -65.199299999999994, -64.309899999999999, "Regional Interactions Officer", "261.659.1349", "93582" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "045 Jalen Ways", "New Krystinaville", new DateTime(2022, 8, 30, 8, 21, 27, 216, DateTimeKind.Local).AddTicks(1975), "Taya76@gmail.com", 17.637899999999998, -23.491800000000001, "Principal Implementation Designer", "256-617-9176 x96551", "17141" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "56328 Wilkinson Fork", "Boyerstad", new DateTime(2022, 9, 19, 20, 41, 20, 440, DateTimeKind.Local).AddTicks(7669), "Seamus29@yahoo.com", 76.165000000000006, 149.77590000000001, "Investor Tactics Liaison", "(233) 643-2797", "44174-6500" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "011 Yundt Pines", "Lake Adeletown", new DateTime(2022, 11, 25, 17, 32, 59, 809, DateTimeKind.Local).AddTicks(9765), "Emmy.Rath@yahoo.com", 11.594799999999999, -166.8467, "Direct Creative Administrator", "355-663-3209", "09305" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "438 Johnston Parks", "Wizafurt", new DateTime(2022, 9, 26, 19, 23, 18, 56, DateTimeKind.Local).AddTicks(2867), "Milan_Pagac@hotmail.com", 72.724900000000005, 134.54060000000001, "Regional Implementation Planner", "603-294-9996 x9787", "85332" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "72010 Annetta Road", "223 Odessa Islands", new DateTime(2022, 11, 19, 21, 41, 7, 440, DateTimeKind.Local).AddTicks(1182), "Lucas7@yahoo.com", "Renee", "Hermiston", "https://picsum.photos/640/480/?image=538", "https://picsum.photos/640/480/?image=441", "512.689.0855", "Lake Dylanburgh", "51301-8822" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "43419 Darlene Corners", "0859 Kari Rapids", new DateTime(2022, 9, 16, 2, 10, 52, 747, DateTimeKind.Local).AddTicks(699), "Larissa15@gmail.com", "Elta", "Daniel", "https://picsum.photos/640/480/?image=12", "https://picsum.photos/640/480/?image=909", "(500) 864-6605 x64462", "West Brookeburgh", "36486-4602" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "346 Collins Center", "4210 Smith Junction", new DateTime(2023, 6, 27, 3, 3, 32, 855, DateTimeKind.Local).AddTicks(2087), "Cleta29@hotmail.com", "Stella", "Will", "https://picsum.photos/640/480/?image=54", "https://picsum.photos/640/480/?image=40", "714.737.3554", "Garthburgh", "37524" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "199 Lori Coves", "3313 Tia Knoll", new DateTime(2022, 10, 17, 17, 27, 8, 35, DateTimeKind.Local).AddTicks(2641), "Shirley_Gibson81@hotmail.com", "Silas", "Green", "https://picsum.photos/640/480/?image=1019", "https://picsum.photos/640/480/?image=199", "975.542.7935 x17374", "Dareview", "64356" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "79652 Vandervort Road", "96544 Ethyl Keys", new DateTime(2022, 11, 6, 7, 56, 14, 725, DateTimeKind.Local).AddTicks(7948), "Regan9@hotmail.com", "Carlee", "Weimann", "https://picsum.photos/640/480/?image=729", "https://picsum.photos/640/480/?image=1051", "(536) 609-8582 x8292", "North Dannie", "07764-2465" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "67937 Rosario Junction", "6531 Roberto Canyon", new DateTime(2022, 8, 24, 7, 12, 59, 529, DateTimeKind.Local).AddTicks(7027), "Edmund56@yahoo.com", "Christelle", "Leannon", "https://picsum.photos/640/480/?image=112", "https://picsum.photos/640/480/?image=105", "(374) 827-0745 x92312", "Corwinhaven", "82443" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "988 Halvorson Branch", "1295 Pouros Summit", new DateTime(2023, 4, 22, 9, 33, 30, 320, DateTimeKind.Local).AddTicks(6142), "Esmeralda_Grady@hotmail.com", "Kayli", "Kulas", "https://picsum.photos/640/480/?image=635", "https://picsum.photos/640/480/?image=1046", "706.986.6226", "Kshlerinberg", "39233" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "83992 Alison Lane", "2343 Stark Forges", new DateTime(2023, 2, 7, 9, 18, 43, 358, DateTimeKind.Local).AddTicks(8605), "Rebeka79@gmail.com", "Nigel", "Stracke", "https://picsum.photos/640/480/?image=820", "https://picsum.photos/640/480/?image=356", "(419) 518-5316 x440", "West Lauryn", "40399-4569" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "47134 Kayley Turnpike", "88443 Nya Branch", new DateTime(2023, 7, 17, 15, 10, 20, 871, DateTimeKind.Local).AddTicks(1765), "Victoria.Anderson92@hotmail.com", "Alisa", "Robel", "https://picsum.photos/640/480/?image=141", "https://picsum.photos/640/480/?image=341", "887.896.6249 x84046", "Ziemestad", "65635" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "716 Hassie Circle", "28221 Leannon Squares", new DateTime(2023, 4, 18, 17, 0, 29, 959, DateTimeKind.Local).AddTicks(3035), "Savannah.Kutch@gmail.com", "Gilda", "Goldner", "https://picsum.photos/640/480/?image=967", "https://picsum.photos/640/480/?image=631", "391-207-1561", "South Bryanafort", "91923" });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 3, 8, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IdClient", "IsConducteur" },
                values: new object[] { 2, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IdReservation", "IsConducteur" },
                values: new object[] { 10, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 6, 4 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 9, 9, false });

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
                values: new object[] { 2, 2, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 8,
                column: "IdReservation",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 7, 9 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 4, 1 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 21, 3, 16, 3, 256, DateTimeKind.Local).AddTicks(1822), new DateTime(2023, 8, 21, 23, 54, 36, 573, DateTimeKind.Local).AddTicks(8313), new DateTime(2024, 7, 2, 13, 12, 50, 140, DateTimeKind.Local).AddTicks(1837), 4, 5.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 21, 11, 43, 45, 761, DateTimeKind.Local).AddTicks(8492), new DateTime(2023, 8, 22, 8, 57, 15, 926, DateTimeKind.Local).AddTicks(1686), new DateTime(2024, 2, 13, 5, 54, 30, 942, DateTimeKind.Local).AddTicks(2667), 5, 10.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 20, 19, 24, 16, 680, DateTimeKind.Local).AddTicks(3422), new DateTime(2023, 8, 22, 13, 8, 54, 308, DateTimeKind.Local).AddTicks(1129), new DateTime(2023, 11, 8, 15, 32, 35, 686, DateTimeKind.Local).AddTicks(7603), 4, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 20, 21, 23, 3, 87, DateTimeKind.Local).AddTicks(2048), new DateTime(2023, 8, 22, 9, 9, 18, 911, DateTimeKind.Local).AddTicks(9918), new DateTime(2024, 3, 19, 23, 30, 0, 704, DateTimeKind.Local).AddTicks(590), 4, 8.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 21, 4, 51, 5, 867, DateTimeKind.Local).AddTicks(5449), new DateTime(2023, 8, 22, 3, 25, 5, 23, DateTimeKind.Local).AddTicks(3963), new DateTime(2024, 5, 18, 3, 28, 49, 733, DateTimeKind.Local).AddTicks(368), 7, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 21, 5, 49, 0, 380, DateTimeKind.Local).AddTicks(157), new DateTime(2023, 8, 22, 1, 11, 43, 339, DateTimeKind.Local).AddTicks(7294), new DateTime(2024, 2, 28, 3, 54, 1, 691, DateTimeKind.Local).AddTicks(2149), 5.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 20, 21, 9, 34, 881, DateTimeKind.Local).AddTicks(1895), new DateTime(2023, 8, 21, 19, 25, 35, 380, DateTimeKind.Local).AddTicks(5145), new DateTime(2024, 6, 11, 8, 48, 6, 19, DateTimeKind.Local).AddTicks(6013), 7, 3.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 20, 23, 52, 20, 604, DateTimeKind.Local).AddTicks(26), new DateTime(2023, 8, 22, 11, 27, 22, 176, DateTimeKind.Local).AddTicks(2828), new DateTime(2024, 6, 17, 4, 26, 14, 799, DateTimeKind.Local).AddTicks(4127), 3, 6.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 20, 19, 52, 28, 982, DateTimeKind.Local).AddTicks(2816), new DateTime(2023, 8, 22, 5, 46, 14, 150, DateTimeKind.Local).AddTicks(8982), new DateTime(2023, 10, 1, 23, 46, 29, 138, DateTimeKind.Local).AddTicks(4263), 8, 3.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 21, 7, 2, 4, 537, DateTimeKind.Local).AddTicks(9496), new DateTime(2023, 8, 21, 22, 53, 28, 749, DateTimeKind.Local).AddTicks(4453), new DateTime(2023, 9, 21, 17, 51, 8, 987, DateTimeKind.Local).AddTicks(5579), 5, 1.0, false });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 21, 18, 7, 23, 700, DateTimeKind.Local).AddTicks(8008), new DateTime(2023, 8, 22, 9, 31, 10, 631, DateTimeKind.Local).AddTicks(8444), new DateTime(2024, 5, 7, 0, 55, 18, 478, DateTimeKind.Local).AddTicks(2222), 7, "5beefbb7-a331-4011-866e-538df46c0481" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 21, 15, 20, 43, 683, DateTimeKind.Local).AddTicks(8726), new DateTime(2023, 8, 21, 21, 26, 31, 769, DateTimeKind.Local).AddTicks(8496), new DateTime(2023, 10, 23, 1, 36, 47, 293, DateTimeKind.Local).AddTicks(1180), 7, "22c46dd9-26af-4d33-b1a7-3a47ee1db0bb" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 21, 2, 59, 59, 606, DateTimeKind.Local).AddTicks(4129), new DateTime(2023, 8, 22, 10, 8, 32, 1, DateTimeKind.Local).AddTicks(2905), new DateTime(2024, 1, 26, 6, 19, 1, 194, DateTimeKind.Local).AddTicks(4422), "e352f5a6-c6e9-453d-b1c3-afba7f81f576" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 21, 18, 25, 46, 287, DateTimeKind.Local).AddTicks(9796), new DateTime(2023, 8, 21, 22, 32, 30, 125, DateTimeKind.Local).AddTicks(896), new DateTime(2024, 6, 8, 5, 10, 32, 399, DateTimeKind.Local).AddTicks(2488), 8, "0d2cb33b-93e6-4c82-93ed-525d96ba7c9d", "Expiré" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 21, 14, 27, 54, 745, DateTimeKind.Local).AddTicks(3447), new DateTime(2023, 8, 22, 5, 13, 19, 98, DateTimeKind.Local).AddTicks(2537), new DateTime(2024, 3, 1, 23, 41, 55, 149, DateTimeKind.Local).AddTicks(6552), 3, "da594d40-1210-458f-b7c5-74bba3108496" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 21, 7, 47, 21, 966, DateTimeKind.Local).AddTicks(3804), new DateTime(2023, 8, 22, 12, 43, 12, 83, DateTimeKind.Local).AddTicks(5308), new DateTime(2023, 12, 21, 14, 25, 28, 962, DateTimeKind.Local).AddTicks(6713), 6, "d62c0c2b-8b82-484d-b6a7-8612f6c953a5", "Confirmé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 20, 19, 35, 17, 314, DateTimeKind.Local).AddTicks(77), new DateTime(2023, 8, 21, 23, 36, 14, 832, DateTimeKind.Local).AddTicks(3700), new DateTime(2023, 11, 26, 22, 21, 15, 144, DateTimeKind.Local).AddTicks(6944), 6, "7340f7fa-a63c-490b-a85a-d280a6a4c284" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 21, 12, 2, 17, 256, DateTimeKind.Local).AddTicks(4172), new DateTime(2023, 8, 22, 15, 18, 30, 109, DateTimeKind.Local).AddTicks(1810), new DateTime(2024, 1, 14, 4, 7, 37, 675, DateTimeKind.Local).AddTicks(3648), 1, "0d5a5e42-bfce-4abe-adc8-10d0df7ac6ee", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 21, 9, 48, 19, 210, DateTimeKind.Local).AddTicks(4905), new DateTime(2023, 8, 22, 10, 14, 34, 233, DateTimeKind.Local).AddTicks(2498), new DateTime(2023, 11, 4, 22, 28, 54, 117, DateTimeKind.Local).AddTicks(6183), 4, "9ff72d9d-264d-4cbb-b78c-99b80cdfcf56", "Annulé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 21, 18, 5, 29, 867, DateTimeKind.Local).AddTicks(7982), new DateTime(2023, 8, 21, 22, 54, 0, 514, DateTimeKind.Local).AddTicks(3348), new DateTime(2024, 5, 14, 19, 16, 8, 792, DateTimeKind.Local).AddTicks(1566), 1, "d9a47f25-bc67-487b-b489-df237307274b", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 7, 3, 21, 33, 23, 111, DateTimeKind.Local).AddTicks(6843), "Eliane4@hotmail.com", "Mckenzie", 7, 2, true, "Considine", "$2a$11$W7RAvQeuxUu5G7mPB8oIievC7x1DNUi5fkMup.9PkO3S6AvIOVg7e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 1, 6, 46, 58, 76, DateTimeKind.Local).AddTicks(2489), "Keon75@gmail.com", "Nicolette", 1, "Braun", "$2a$11$v/pA7HrgX721sven8XW93uVTVckM.1dIFfHX.9WmaWluAzoR7qf1u" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 7, 20, 38, 23, 978, DateTimeKind.Local).AddTicks(7369), "Manley24@gmail.com", "Serenity", 5, false, "Skiles", "$2a$11$m2QxKJBbLnHoBPzOH7FVTu8zLhN9pkuGhKO/BYvukOcOEsJqPt0ua" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 10, 2, 15, 2, 51, 345, DateTimeKind.Local).AddTicks(2819), "Savannah62@hotmail.com", "Kailee", 3, "Becker", "$2a$11$1XzKeXWwpmjwvQ7MjDeHKusPz.wOHJiY/Xo3IZm3Bi1iKf2kkyNCe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 4, 18, 1, 51, 13, 386, DateTimeKind.Local).AddTicks(2250), "Trenton_Swift83@gmail.com", "Dora", 1, 1, false, "Haley", "$2a$11$AkPkPW63bUwBB82WfsMKsOnrnLf2pq7txHCmctfCYybPZoyZnOZf2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 4, 29, 20, 1, 55, 650, DateTimeKind.Local).AddTicks(751), "Nasir.Okuneva@hotmail.com", "Gene", 3, 2, false, "Barton", "$2a$11$vSKxAostSfaK391X15GPOOj9gWM/NitRDKy/uaX3dPe9p1juUjf8a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 4, 17, 14, 14, 31, 294, DateTimeKind.Local).AddTicks(7511), "Howard74@yahoo.com", "Gerard", 10, "Kuhlman", "$2a$11$lU54/UOSOAv5/g9e6P5pyusyEoRBWeJEXhp1E5S0tDRGszOiJaUTO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 22, 3, 39, 21, 83, DateTimeKind.Local).AddTicks(1115), "Anastasia_Goldner9@yahoo.com", "Naomie", 7, 2, false, "Herzog", "$2a$11$JQyzp74wwtIggnxkDQ9YTembMVocgQcGPZKvsA4wXwbM4HnUePbnu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 25, 37, 948, DateTimeKind.Local).AddTicks(5655), "Rachel.Walsh@gmail.com", "Leopold", 2, false, "Johnston", "$2a$11$9TqIO8xghAWTmKZvMtau9ucPPOaFKKQ4ktVhYxqVNNmlTHD8VSRgW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 11, 21, 19, 59, 52, 736, DateTimeKind.Local).AddTicks(3518), "Dagmar32@gmail.com", "Jeff", "Cruickshank", "$2a$11$WQd8wGa/VmQv9RuZ535dauYfyy0CMN/b5hlXvGFVeN/NwcyiEAjee" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, true, new DateTime(2022, 9, 30, 10, 28, 12, 586, DateTimeKind.Local).AddTicks(332), "siozrkusva", 10, 31, 3885, "jhinwbjujo", "apexxohnjf", "bcsuskpcbe", 4, 4, 1.0, "udthlcoknk" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2023, 3, 25, 2, 19, 19, 753, DateTimeKind.Local).AddTicks(4635), "qkmgjllyvd", 1, 55, 661, "zerzbpvqfu", "wfqzkwpfur", "ntjbpkmusl", 8, 10, 7.0, "zsnxedsxgw" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Climat", "CreatedAt", "Gearbox", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2023, 5, 10, 19, 2, 16, 355, DateTimeKind.Local).AddTicks(7935), "iwpzpbjnbv", 192, 8957, "iwhgmhwjst", "dqeftcvjmf", "uisqltlrpe", 1, 2, 2.0, "rmyjmffsru" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2023, 8, 18, 5, 45, 24, 689, DateTimeKind.Local).AddTicks(5484), "zasmsidahv", 1, 156, 7068, "comfxynepq", "auuppbmjxr", "nxiihlyyvn", 6, 2, 6.0, "mbexqbzagf" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2023, 3, 9, 6, 10, 8, 353, DateTimeKind.Local).AddTicks(6454), "bzwkppsajn", 9, 292, 2155, "jnckdstmyn", "ypppwqiyhf", "fbespfazut", 10, 3, 1.0, "lqbdrvtfmg" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, true, new DateTime(2022, 11, 2, 18, 23, 59, 856, DateTimeKind.Local).AddTicks(8064), "alplamwtzo", 2, 83, 9095, "vnlejwziws", "nfwszcqdsg", "ivwztfgesy", 7, 7, 9.0, "lybzpwufkb" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2022, 10, 18, 3, 14, 5, 719, DateTimeKind.Local).AddTicks(8988), "udhxeakgkj", 8, 45, 6697, "ppwrdykadj", "ffjjfxukst", "vhngyjuyoh", 5, 6, 7.0, "skjfczmcts" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, true, new DateTime(2022, 10, 8, 18, 36, 8, 67, DateTimeKind.Local).AddTicks(5388), "iixapdlihs", 1, 83, 2851, "qwgydvakbv", "sciwuvnmhl", "lvuvpdbttd", 5, 3, 10.0, "npztksspar" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2022, 10, 18, 8, 34, 13, 933, DateTimeKind.Local).AddTicks(5385), "hkxmvrnfax", 8, 258, 9323, "mhicbzrmxs", "hxzpwycehg", "jbkdvczzkh", 10, 5, 7.0, "kxmwfuhanf" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "Type" },
                values: new object[] { true, true, new DateTime(2023, 1, 5, 23, 57, 33, 418, DateTimeKind.Local).AddTicks(6000), "jezyybvhok", 5, 51, 8519, "eocewwcjuk", "yhbxzrnsyo", "xbqlqpxigd", 10, "fsjmqcccsu" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 12, 31, 18, 8, 50, 120, DateTimeKind.Local).AddTicks(516), "wrkxywpyfo", 32, "sauwqfllxa", "zewzfozdkl", "Kunze", 27, "Connelly Inc", "Linwood", "258-579-2975 x993", "Upton", "Port Rollinside", "79160" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 7, 10, 18, 12, 50, 624, DateTimeKind.Local).AddTicks(1523), "eymhqmzzou", 325, "fqebadpifh", "ihvyqdrzem", "Ferry", 20, "Simonis - Runolfsdottir", "Columbus", "940-651-0030", "Spencer", "Lambertmouth", "86026-2952" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 12, 27, 16, 42, 2, 398, DateTimeKind.Local).AddTicks(791), "bgyeazaxjo", 302, "emmmjevpqe", "glinodguud", "Robel", 28, "Jacobi, Dooley and Zulauf", "Gracie", "217-609-7069", "Larson", "Hillsburgh", "95914" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 11, 24, 14, 12, 17, 344, DateTimeKind.Local).AddTicks(3339), "ytledxgkgp", 232, "woxascnfmg", "valrvvfgvs", "Schinner", "Jones - Quitzon", "Lila", "760.256.7060 x07610", "Mraz", "Lake Ericview", "40551" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 6, 1, 17, 43, 54, 618, DateTimeKind.Local).AddTicks(2865), "ysbzoeudcv", 77, "lsqzyjifka", "blzjxvdtkf", "Dooley", 30, "Beer LLC", "Bridgette", "(305) 634-4655 x783", "Hagenes", "Amymouth", "85081-1716" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 12, 17, 17, 7, 8, 644, DateTimeKind.Local).AddTicks(6713), "qvwkzotfxl", 286, "uiuwegxosc", "qcasxlgzgj", "VonRueden", 21, "Batz, Willms and Goyette", "Orion", "1-378-209-9134", "Howell", "Titusport", "98751" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 3, 20, 8, 22, 17, 328, DateTimeKind.Local).AddTicks(848), "lldwzoytpk", 2, "mrubhwnjra", "jsbdizunwo", "Bruen", 27, "Muller Inc", "Hunter", "(524) 527-7932", "Dibbert", "North Akeemberg", "74549-1903" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 1, 14, 8, 35, 52, 32, DateTimeKind.Local).AddTicks(8324), "shjtidhucz", 309, "fhpqyxehjb", "edyzedixvv", "Collier", 24, "Nikolaus - Feil", "Blanche", "758.225.5769 x209", "D'Amore", "Silasland", "73424-9505" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 10, 7, 20, 37, 57, 917, DateTimeKind.Local).AddTicks(8352), "lclbskejmq", 171, "goslkiaicp", "uuuyygrnpq", "Kutch", 32, "Fahey, Hirthe and Heaney", "Leilani", "332-762-4767", "Lubowitz", "Lazaroland", "06860" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 10, 26, 0, 24, 18, 498, DateTimeKind.Local).AddTicks(9152), "vvysvdgbfi", 257, "oyxraxvyfj", "wqquyjnmzo", "Koch", 20, "Hauck Inc", "Samara", "(570) 461-4306", "Ullrich", "Electaport", "72435-8596" });
        }
    }
}
