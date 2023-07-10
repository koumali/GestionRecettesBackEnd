using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AutomotiveApi.Migrations
{
    /// <inheritdoc />
    public partial class new_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Agences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    Tel = table.Column<string>(type: "longtext", nullable: false),
                    Email = table.Column<string>(type: "longtext", nullable: false),
                    Address = table.Column<string>(type: "longtext", nullable: false),
                    City = table.Column<string>(type: "longtext", nullable: false),
                    ZipCode = table.Column<string>(type: "longtext", nullable: false),
                    Latitude = table.Column<double>(type: "double", nullable: false),
                    Longitude = table.Column<double>(type: "double", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agences", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "longtext", nullable: false),
                    LastName = table.Column<string>(type: "longtext", nullable: false),
                    Tel = table.Column<string>(type: "longtext", nullable: false),
                    Email = table.Column<string>(type: "longtext", nullable: false),
                    Ville = table.Column<string>(type: "longtext", nullable: false),
                    ZipCode = table.Column<string>(type: "longtext", nullable: false),
                    Adresse = table.Column<string>(type: "longtext", nullable: false),
                    Adresse2 = table.Column<string>(type: "longtext", nullable: false),
                    PermisRecto = table.Column<string>(type: "longtext", nullable: false),
                    PermisVerso = table.Column<string>(type: "longtext", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "log_journal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NameController = table.Column<string>(type: "longtext", nullable: false),
                    NameFonction = table.Column<string>(type: "longtext", nullable: false),
                    DescriptionMessage = table.Column<string>(type: "longtext", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_log_journal", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Marques",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marques", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Modeles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    IdMarque = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modeles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Modeles_id_marque",
                        column: x => x.IdMarque,
                        principalTable: "Marques",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "longtext", nullable: false),
                    LastName = table.Column<string>(type: "longtext", nullable: false),
                    Email = table.Column<string>(type: "longtext", nullable: false),
                    Password = table.Column<string>(type: "longtext", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    IdRole = table.Column<int>(type: "int", nullable: false),
                    IdAgence = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_id_agence",
                        column: x => x.IdAgence,
                        principalTable: "Agences",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Users_id_role",
                        column: x => x.IdRole,
                        principalTable: "Roles",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Vehicules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    Matricule = table.Column<string>(type: "longtext", nullable: false),
                    Prix = table.Column<double>(type: "double", nullable: false),
                    NbPort = table.Column<int>(type: "int", nullable: false),
                    NbPassager = table.Column<int>(type: "int", nullable: false),
                    Km = table.Column<int>(type: "int", nullable: false),
                    Climat = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Airbag = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Image = table.Column<string>(type: "longtext", nullable: false),
                    Gearbox = table.Column<string>(type: "longtext", nullable: false),
                    Moteur = table.Column<string>(type: "longtext", nullable: false),
                    IdAgence = table.Column<int>(type: "int", nullable: false),
                    IdModele = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicules_id_agence",
                        column: x => x.IdAgence,
                        principalTable: "Agences",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicules_id_modele",
                        column: x => x.IdModele,
                        principalTable: "Modeles",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Offres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    IdVehicule = table.Column<int>(type: "int", nullable: false),
                    DateDebut = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateFin = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Prix = table.Column<double>(type: "double", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Offre_id_vehicule",
                        column: x => x.IdVehicule,
                        principalTable: "Vehicules",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    DateDepart = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateRetour = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IdVehicule = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservation_id_vehicule",
                        column: x => x.IdVehicule,
                        principalTable: "Vehicules",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Contrats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    IdClient = table.Column<int>(type: "int", nullable: false),
                    IdReservation = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contrats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contrats_id_client",
                        column: x => x.IdClient,
                        principalTable: "Clients",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Contrats_id_reservation",
                        column: x => x.IdReservation,
                        principalTable: "Reservations",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Agences",
                columns: new[] { "Id", "Address", "City", "CreatedAt", "DeletedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "UpdatedAt", "ZipCode" },
                values: new object[,]
                {
                    { 1, "1389 Daniela Canyon", "Naderside", new DateTime(2022, 7, 21, 15, 39, 41, 823, DateTimeKind.Local).AddTicks(4534), null, "Sam_Weber30@hotmail.com", -63.609400000000001, -64.438599999999994, "Future Communications Analyst", "498-533-4602", null, "64494" },
                    { 2, "077 Tillman Green", "New Tatum", new DateTime(2022, 12, 1, 18, 11, 2, 41, DateTimeKind.Local).AddTicks(7636), null, "Courtney_Mills@yahoo.com", 66.005099999999999, 121.80329999999999, "Regional Assurance Facilitator", "1-207-876-4613 x399", null, "42900-0545" },
                    { 3, "40822 Natalia Cape", "Wolffside", new DateTime(2023, 7, 4, 20, 8, 19, 138, DateTimeKind.Local).AddTicks(428), null, "Teresa.Morar59@gmail.com", -71.002200000000002, -1.8561000000000001, "Corporate Web Facilitator", "1-973-309-7161 x044", null, "00269" },
                    { 4, "526 Maryam Junctions", "South Candelario", new DateTime(2022, 8, 24, 15, 50, 35, 705, DateTimeKind.Local).AddTicks(8343), null, "Haylee.Heidenreich@gmail.com", -66.575800000000001, -4.5537999999999998, "Regional Optimization Agent", "861.815.2780", null, "15199" },
                    { 5, "93665 Metz Station", "South Anne", new DateTime(2022, 8, 3, 9, 31, 56, 716, DateTimeKind.Local).AddTicks(7619), null, "Katheryn85@gmail.com", -50.9694, -142.12129999999999, "International Program Administrator", "1-450-572-0099", null, "43387" },
                    { 6, "531 Effertz Ridge", "Emeraldborough", new DateTime(2022, 8, 15, 14, 9, 22, 432, DateTimeKind.Local).AddTicks(8334), null, "Adriel.Rau@gmail.com", -18.127099999999999, -21.066500000000001, "Central Research Agent", "1-694-264-8801 x647", null, "89666-7728" },
                    { 7, "811 Rau Village", "East Osborneport", new DateTime(2022, 12, 21, 12, 35, 54, 716, DateTimeKind.Local).AddTicks(2911), null, "Allie72@yahoo.com", -68.163499999999999, -176.05179999999999, "Principal Division Associate", "1-473-962-4358", null, "49620" },
                    { 8, "642 Ulises Pine", "New Leone", new DateTime(2023, 1, 30, 4, 51, 47, 891, DateTimeKind.Local).AddTicks(48), null, "Coleman.Hirthe@gmail.com", -33.340699999999998, -65.327500000000001, "Internal Brand Producer", "632.496.7293", null, "29758" },
                    { 9, "22090 Vance Ports", "Zboncakshire", new DateTime(2023, 7, 8, 16, 51, 35, 385, DateTimeKind.Local).AddTicks(9269), null, "Kristy83@gmail.com", -57.288400000000003, 145.37459999999999, "Lead Integration Executive", "386.799.5531 x2999", null, "53814" },
                    { 10, "74996 Pearline Garden", "Lake Briannemouth", new DateTime(2023, 3, 23, 0, 18, 33, 516, DateTimeKind.Local).AddTicks(4105), null, "Jocelyn.Daniel@hotmail.com", -77.465999999999994, 9.1988000000000003, "Customer Applications Officer", "(538) 935-8365 x7564", null, "98905-7016" }
                });

            migrationBuilder.InsertData(
                table: "Marques",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 10, 5, 21, 11, 10, 605, DateTimeKind.Local).AddTicks(8619), null, "Bentley", null },
                    { 2, new DateTime(2022, 12, 9, 2, 23, 53, 968, DateTimeKind.Local).AddTicks(1827), null, "Smart", null },
                    { 3, new DateTime(2023, 5, 31, 3, 7, 7, 388, DateTimeKind.Local).AddTicks(5661), null, "Fiat", null },
                    { 4, new DateTime(2023, 4, 30, 18, 25, 26, 88, DateTimeKind.Local).AddTicks(5097), null, "Nissan", null },
                    { 5, new DateTime(2023, 1, 3, 15, 9, 41, 969, DateTimeKind.Local).AddTicks(8491), null, "Rolls Royce", null },
                    { 6, new DateTime(2023, 4, 26, 8, 21, 38, 128, DateTimeKind.Local).AddTicks(9283), null, "Land Rover", null },
                    { 7, new DateTime(2023, 2, 5, 7, 28, 47, 106, DateTimeKind.Local).AddTicks(7440), null, "Aston Martin", null },
                    { 8, new DateTime(2022, 10, 20, 5, 52, 30, 804, DateTimeKind.Local).AddTicks(7273), null, "Bentley", null },
                    { 9, new DateTime(2022, 8, 28, 15, 45, 19, 707, DateTimeKind.Local).AddTicks(6089), null, "Fiat", null },
                    { 10, new DateTime(2023, 1, 10, 7, 13, 3, 640, DateTimeKind.Local).AddTicks(3989), null, "Tesla", null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Admin", null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gerant", null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Agent", null },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Client", null },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Commercial", null }
                });

            migrationBuilder.InsertData(
                table: "Modeles",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IdMarque", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 7, 18, 55, 49, 194, DateTimeKind.Local).AddTicks(8931), null, 8, "Model S", null },
                    { 2, new DateTime(2022, 12, 13, 5, 54, 19, 575, DateTimeKind.Local).AddTicks(8280), null, 7, "XC90", null },
                    { 3, new DateTime(2023, 2, 11, 7, 13, 27, 508, DateTimeKind.Local).AddTicks(716), null, 9, "Charger", null },
                    { 4, new DateTime(2022, 8, 1, 20, 0, 6, 988, DateTimeKind.Local).AddTicks(4620), null, 8, "Challenger", null },
                    { 5, new DateTime(2022, 12, 8, 0, 29, 55, 39, DateTimeKind.Local).AddTicks(1397), null, 5, "Jetta", null },
                    { 6, new DateTime(2023, 1, 4, 12, 13, 5, 622, DateTimeKind.Local).AddTicks(5437), null, 10, "2", null },
                    { 7, new DateTime(2022, 8, 18, 19, 46, 13, 296, DateTimeKind.Local).AddTicks(917), null, 3, "Camry", null },
                    { 8, new DateTime(2023, 5, 3, 15, 4, 47, 48, DateTimeKind.Local).AddTicks(4907), null, 8, "Challenger", null },
                    { 9, new DateTime(2022, 11, 23, 5, 3, 42, 982, DateTimeKind.Local).AddTicks(8772), null, 5, "Cruze", null },
                    { 10, new DateTime(2023, 1, 14, 14, 7, 23, 69, DateTimeKind.Local).AddTicks(6000), null, 2, "LeBaron", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 10, 14, 17, 23, 13, 750, DateTimeKind.Local).AddTicks(204), null, "Katrina_Thiel9@hotmail.com", "Grayson", 2, 4, true, "Hettinger", "$2a$11$c19i4JdgeXXcJm9hEed8/OJq5ZoP2TE88O0LCcrROSX8sATqxbAl6", null },
                    { 2, new DateTime(2022, 7, 30, 0, 17, 39, 171, DateTimeKind.Local).AddTicks(9118), null, "Leif.Dicki@hotmail.com", "Leonora", 4, 2, false, "Stracke", "$2a$11$VV6XKlZErIaIJri4KdmXKeo4p1DmwGLE2.SU46ld/2AqSQ75tupBu", null },
                    { 3, new DateTime(2022, 10, 2, 2, 34, 13, 246, DateTimeKind.Local).AddTicks(9486), null, "Thora68@hotmail.com", "Domingo", 1, 1, true, "Wilkinson", "$2a$11$X6meqXnFIaOppg5vb0Q4qeeWPGnLkAJ7iYqzWEmJgT2lkUmR/as8W", null },
                    { 4, new DateTime(2023, 6, 2, 2, 3, 31, 465, DateTimeKind.Local).AddTicks(3231), null, "Jermain_Feil@yahoo.com", "Jeffery", 1, 2, false, "Mohr", "$2a$11$/agpNactWPiI2gOnmgu44u.Rf3OFbeujjMoaBguTP2mAg/AuqWYBS", null },
                    { 5, new DateTime(2022, 9, 16, 8, 13, 31, 278, DateTimeKind.Local).AddTicks(7179), null, "Joan_Marvin15@gmail.com", "Beulah", 7, 1, true, "O'Kon", "$2a$11$AppaEhKaCTpIYslReK6cn.PJRYuseXr5OTM1zxLIZASvo3iH2oNAm", null },
                    { 6, new DateTime(2022, 11, 2, 15, 0, 32, 872, DateTimeKind.Local).AddTicks(5235), null, "Milford.Romaguera@gmail.com", "Naomie", 9, 4, true, "Volkman", "$2a$11$kXsqiPjiJoZ8geOBQWIcPeEFwpCkArhMgbH7uyRevDBZ/wuNy9N.S", null },
                    { 7, new DateTime(2023, 3, 9, 19, 3, 38, 873, DateTimeKind.Local).AddTicks(5394), null, "Regan54@yahoo.com", "Keon", 7, 1, false, "Torp", "$2a$11$GmkUYkhY6kvTBvS3pwx/wOZ6mmKXGKW0DQxPKdA8exILStFzEEfxe", null },
                    { 8, new DateTime(2023, 7, 2, 20, 10, 35, 609, DateTimeKind.Local).AddTicks(390), null, "Rusty_Hermiston@hotmail.com", "Chloe", 9, 2, false, "Strosin", "$2a$11$orVRvQC4MgadreS4uK1SYufRUhR355sYe40DxXkfxQxLcgZhKRSia", null },
                    { 9, new DateTime(2022, 10, 15, 5, 46, 5, 84, DateTimeKind.Local).AddTicks(2951), null, "Marion_Mante38@yahoo.com", "Dakota", 1, 1, false, "Lemke", "$2a$11$ghUnVNdPoEHPXKcCbZlzZ.f4N3Xmy4pzsN/erk4OQ/U9iMiBboSMW", null },
                    { 10, new DateTime(2022, 11, 4, 10, 3, 7, 441, DateTimeKind.Local).AddTicks(4606), null, "Sofia_Mosciski23@hotmail.com", "Raleigh", 6, 2, false, "Jacobs", "$2a$11$9YkMMPwWbwcaE9bDdUPBKOC/0Rb5qxp6PpsCRimqQYzwEyNBP7IFW", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contrats_IdClient",
                table: "Contrats",
                column: "IdClient");

            migrationBuilder.CreateIndex(
                name: "IX_Contrats_IdReservation",
                table: "Contrats",
                column: "IdReservation");

            migrationBuilder.CreateIndex(
                name: "IX_Modeles_IdMarque",
                table: "Modeles",
                column: "IdMarque");

            migrationBuilder.CreateIndex(
                name: "IX_Offres_IdVehicule",
                table: "Offres",
                column: "IdVehicule");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_IdVehicule",
                table: "Reservations",
                column: "IdVehicule");

            migrationBuilder.CreateIndex(
                name: "IX_Users_IdAgence",
                table: "Users",
                column: "IdAgence");

            migrationBuilder.CreateIndex(
                name: "IX_Users_IdRole",
                table: "Users",
                column: "IdRole");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicules_IdAgence",
                table: "Vehicules",
                column: "IdAgence");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicules_IdModele",
                table: "Vehicules",
                column: "IdModele");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contrats");

            migrationBuilder.DropTable(
                name: "log_journal");

            migrationBuilder.DropTable(
                name: "Offres");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Vehicules");

            migrationBuilder.DropTable(
                name: "Agences");

            migrationBuilder.DropTable(
                name: "Modeles");

            migrationBuilder.DropTable(
                name: "Marques");
        }
    }
}
