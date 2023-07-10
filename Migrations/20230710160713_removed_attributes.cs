using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AutomotiveApi.Migrations
{
    /// <inheritdoc />
    public partial class removed_attributes : Migration
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
                    { 1, "79629 Oberbrunner Avenue", "North Gordon", new DateTime(2022, 12, 22, 14, 17, 52, 767, DateTimeKind.Local).AddTicks(7126), null, "Hester83@gmail.com", 47.193199999999997, -7.8311999999999999, "Central Division Administrator", "453-531-5494", null, "91781" },
                    { 2, "788 Ottilie Isle", "Ortizfurt", new DateTime(2022, 12, 19, 23, 10, 37, 16, DateTimeKind.Local).AddTicks(8168), null, "Daron73@gmail.com", -43.854700000000001, -62.965499999999999, "Senior Brand Agent", "1-463-861-1675", null, "04133" },
                    { 3, "0414 Dayne Oval", "Vandervortland", new DateTime(2022, 11, 13, 6, 15, 28, 162, DateTimeKind.Local).AddTicks(3680), null, "Zita.Wolff59@hotmail.com", 8.7499000000000002, -82.788499999999999, "International Applications Producer", "678-904-0850 x03777", null, "36813-0200" },
                    { 4, "2856 Ryan Ridges", "South Rosanna", new DateTime(2023, 5, 22, 10, 43, 9, 687, DateTimeKind.Local).AddTicks(9412), null, "Jesse.Green60@hotmail.com", 89.936300000000003, 161.69290000000001, "Central Functionality Orchestrator", "257-391-0723", null, "71988-7227" },
                    { 5, "552 Reilly Springs", "Rossiefort", new DateTime(2022, 7, 28, 16, 34, 18, 577, DateTimeKind.Local).AddTicks(7686), null, "Corrine92@gmail.com", -15.3253, 111.7672, "Global Interactions Analyst", "1-430-430-2458", null, "82811" },
                    { 6, "8915 Strosin Vista", "West Reginaldview", new DateTime(2023, 1, 26, 10, 36, 59, 351, DateTimeKind.Local).AddTicks(4775), null, "Bert_Gerlach6@hotmail.com", 11.6127, -54.220700000000001, "Forward Mobility Planner", "(224) 667-0420 x3841", null, "18824" },
                    { 7, "0759 Marlene Burg", "Runtechester", new DateTime(2022, 12, 6, 8, 2, 26, 36, DateTimeKind.Local).AddTicks(8773), null, "Zane.Prohaska@gmail.com", 75.878799999999998, 14.2905, "Chief Directives Engineer", "633-811-4567 x51615", null, "52943" },
                    { 8, "479 Cheyenne Cove", "Abigailborough", new DateTime(2022, 10, 22, 11, 17, 32, 755, DateTimeKind.Local).AddTicks(8925), null, "Damian.Bernier12@hotmail.com", -20.214700000000001, 33.482199999999999, "District Communications Specialist", "731-646-7323 x47982", null, "41704-8688" },
                    { 9, "3244 Johnathon Knolls", "Torpside", new DateTime(2022, 7, 26, 19, 12, 56, 663, DateTimeKind.Local).AddTicks(1916), null, "Nyasia99@hotmail.com", -52.965400000000002, 127.89790000000001, "Dynamic Data Engineer", "1-443-567-3739 x0840", null, "79166-0611" },
                    { 10, "8494 Leffler Ways", "Lisettechester", new DateTime(2022, 8, 5, 4, 3, 9, 645, DateTimeKind.Local).AddTicks(5695), null, "Trevor.Brown54@yahoo.com", -75.372500000000002, -21.748200000000001, "District Operations Liaison", "985.456.3678", null, "91201-4489" }
                });

            migrationBuilder.InsertData(
                table: "Marques",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 30, 3, 50, 16, 892, DateTimeKind.Local).AddTicks(4327), null, "BMW", null },
                    { 2, new DateTime(2022, 11, 10, 20, 43, 29, 632, DateTimeKind.Local).AddTicks(9737), null, "Rolls Royce", null },
                    { 3, new DateTime(2023, 3, 29, 19, 7, 47, 477, DateTimeKind.Local).AddTicks(2022), null, "Mercedes Benz", null },
                    { 4, new DateTime(2022, 9, 29, 4, 54, 56, 530, DateTimeKind.Local).AddTicks(2958), null, "Smart", null },
                    { 5, new DateTime(2022, 11, 5, 16, 31, 33, 801, DateTimeKind.Local).AddTicks(7298), null, "Volvo", null },
                    { 6, new DateTime(2022, 9, 3, 7, 29, 8, 615, DateTimeKind.Local).AddTicks(4438), null, "Polestar", null },
                    { 7, new DateTime(2023, 3, 22, 22, 37, 45, 40, DateTimeKind.Local).AddTicks(7140), null, "BMW", null },
                    { 8, new DateTime(2022, 8, 28, 12, 22, 51, 431, DateTimeKind.Local).AddTicks(1757), null, "Ferrari", null },
                    { 9, new DateTime(2023, 1, 17, 19, 43, 32, 72, DateTimeKind.Local).AddTicks(1690), null, "Kia", null },
                    { 10, new DateTime(2023, 2, 19, 2, 5, 34, 103, DateTimeKind.Local).AddTicks(4550), null, "Smart", null }
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
                    { 1, new DateTime(2023, 4, 7, 10, 32, 19, 580, DateTimeKind.Local).AddTicks(7699), null, 5, "Corvette", null },
                    { 2, new DateTime(2023, 5, 12, 14, 23, 22, 230, DateTimeKind.Local).AddTicks(4861), null, 4, "Fiesta", null },
                    { 3, new DateTime(2022, 8, 22, 10, 9, 21, 490, DateTimeKind.Local).AddTicks(7367), null, 3, "Accord", null },
                    { 4, new DateTime(2023, 2, 12, 5, 28, 20, 649, DateTimeKind.Local).AddTicks(2808), null, 9, "Corvette", null },
                    { 5, new DateTime(2023, 6, 13, 3, 19, 13, 701, DateTimeKind.Local).AddTicks(4978), null, 9, "Countach", null },
                    { 6, new DateTime(2022, 9, 4, 9, 11, 23, 503, DateTimeKind.Local).AddTicks(766), null, 2, "Explorer", null },
                    { 7, new DateTime(2022, 9, 30, 7, 47, 29, 224, DateTimeKind.Local).AddTicks(8582), null, 2, "2", null },
                    { 8, new DateTime(2023, 5, 10, 7, 5, 12, 395, DateTimeKind.Local).AddTicks(7790), null, 5, "Expedition", null },
                    { 9, new DateTime(2023, 7, 4, 16, 56, 56, 839, DateTimeKind.Local).AddTicks(8075), null, 10, "911", null },
                    { 10, new DateTime(2023, 4, 1, 13, 27, 54, 191, DateTimeKind.Local).AddTicks(2647), null, 8, "Wrangler", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 12, 6, 19, 19, 484, DateTimeKind.Local).AddTicks(7899), null, "Darrick.Swift@hotmail.com", "Kailee", 5, 4, true, "Kris", "$2a$11$KQFqoWGSF04NsMpLbtKtMuq93MGnMmJWk9qtcY/I2P.p9itVpOd5K", null },
                    { 2, new DateTime(2023, 3, 27, 1, 29, 40, 261, DateTimeKind.Local).AddTicks(1914), null, "Moriah.Collins@gmail.com", "Adelia", 2, 4, false, "Simonis", "$2a$11$61YmrWpHzTaWP7mJ3DB1TeX99jKOE.tgXg0lk.s4xx4NL.eVjGxsC", null },
                    { 3, new DateTime(2022, 7, 29, 3, 56, 40, 794, DateTimeKind.Local).AddTicks(57), null, "Alisha54@hotmail.com", "Destin", 10, 4, false, "Green", "$2a$11$9.6g2zMNKTSoD/yE6QHqpO4pd1ipSEU43LAdLbNTR0sApJEaojXGW", null },
                    { 4, new DateTime(2022, 9, 18, 4, 47, 17, 216, DateTimeKind.Local).AddTicks(1845), null, "Misty73@gmail.com", "Rose", 7, 2, false, "Homenick", "$2a$11$GjtQldAb4V1q0HjaIoDBvuFhu5iMIbV2BVMDDFzxyThjokNLNBQGq", null },
                    { 5, new DateTime(2022, 12, 16, 14, 52, 48, 390, DateTimeKind.Local).AddTicks(6925), null, "Melody26@hotmail.com", "Glenda", 9, 4, false, "Rath", "$2a$11$YOP3jD31p39IED/wqRCJzeqMLPtfKTsOwWfGlVXUO9nzBT4nWmbzy", null },
                    { 6, new DateTime(2023, 7, 10, 8, 46, 46, 121, DateTimeKind.Local).AddTicks(9544), null, "Yadira.VonRueden@gmail.com", "Jacklyn", 3, 4, false, "Berge", "$2a$11$73H1AL/wFkvBFNhuMdUEau95UzJejkqN3FlNVGl6TUYqslNMR0XVm", null },
                    { 7, new DateTime(2022, 11, 20, 15, 0, 47, 266, DateTimeKind.Local).AddTicks(2028), null, "Laisha12@gmail.com", "Freddie", 4, 2, true, "Denesik", "$2a$11$T2hQPeemviYIIeqrHF2zTeC7gBUhz2jFGWJFlbT0Zlyg.diSMcfPy", null },
                    { 8, new DateTime(2023, 2, 25, 1, 17, 39, 170, DateTimeKind.Local).AddTicks(4787), null, "Viviane_Hodkiewicz@hotmail.com", "Adelle", 2, 3, true, "Aufderhar", "$2a$11$afVivWzjIyAix9iEyi.YQ.rE9w3M2tWWtcqCBEqcH18gGkzsG2mvO", null },
                    { 9, new DateTime(2023, 3, 4, 15, 28, 47, 596, DateTimeKind.Local).AddTicks(6402), null, "Evan.Kilback93@hotmail.com", "Anissa", 8, 3, false, "Rau", "$2a$11$5rYEy9lSCQvNYpahY1pyqOygQjjOS87/dEeFhm7qxJp5GtmLxX.gG", null },
                    { 10, new DateTime(2022, 7, 19, 0, 17, 5, 875, DateTimeKind.Local).AddTicks(9347), null, "Norwood_Frami45@yahoo.com", "Francesco", 2, 1, true, "Daugherty", "$2a$11$oj47kJwhn6ZcQ8zPDzJEfuxDiCPL.tFO8Kc7PePo95k4NhgDX.que", null }
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
