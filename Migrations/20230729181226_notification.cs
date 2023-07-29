using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AutomotiveApi.Migrations
{
    /// <inheritdoc />
    public partial class notification : Migration
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
                    City = table.Column<string>(type: "longtext", nullable: true),
                    ZipCode = table.Column<string>(type: "longtext", nullable: true),
                    Latitude = table.Column<double>(type: "double", nullable: true),
                    Longitude = table.Column<double>(type: "double", nullable: true),
                    IsVerified = table.Column<bool>(type: "tinyint(1)", nullable: false),
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
                    Password = table.Column<string>(type: "longtext", nullable: true),
                    ZipCode = table.Column<string>(type: "longtext", nullable: true),
                    Adresse = table.Column<string>(type: "longtext", nullable: true),
                    Adresse2 = table.Column<string>(type: "longtext", nullable: true),
                    PermisRecto = table.Column<string>(type: "longtext", nullable: true),
                    PermisVerso = table.Column<string>(type: "longtext", nullable: true),
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
                    Image = table.Column<string>(type: "longtext", nullable: false),
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
                name: "long_term_rentals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    prenom = table.Column<string>(type: "longtext", nullable: false),
                    nom = table.Column<string>(type: "longtext", nullable: false),
                    phone = table.Column<string>(type: "longtext", nullable: false),
                    ville = table.Column<string>(type: "longtext", nullable: false),
                    email = table.Column<string>(type: "longtext", nullable: false),
                    zip = table.Column<string>(type: "longtext", nullable: false),
                    entreprise = table.Column<string>(type: "longtext", nullable: false),
                    duree = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "longtext", nullable: false),
                    NumeroReservation = table.Column<string>(type: "longtext", nullable: false),
                    status = table.Column<string>(type: "longtext", nullable: false),
                    idAgence = table.Column<int>(type: "int", nullable: true),
                    IdModele = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_long_term_rentals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservation_id_modele",
                        column: x => x.IdModele,
                        principalTable: "Modeles",
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
                    Gearbox = table.Column<string>(type: "longtext", nullable: false),
                    Moteur = table.Column<string>(type: "longtext", nullable: false),
                    IdAgence = table.Column<int>(type: "int", nullable: false),
                    IdModele = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "longtext", nullable: false),
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
                name: "lld_responses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    prix = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "longtext", nullable: false),
                    idAgence = table.Column<int>(type: "int", nullable: false),
                    idLongTermRental = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lld_responses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Modeles_id_Agence",
                        column: x => x.idAgence,
                        principalTable: "Agences",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Modeles_id_LongTermRental",
                        column: x => x.idLongTermRental,
                        principalTable: "long_term_rentals",
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
                    isPublic = table.Column<bool>(type: "tinyint(1)", nullable: false),
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
                    NumeroReservation = table.Column<string>(type: "longtext", nullable: false),
                    Status = table.Column<string>(type: "longtext", nullable: false),
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
                    IsConducteur = table.Column<bool>(type: "tinyint(1)", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ReservationId = table.Column<int>(type: "int", nullable: false),
                    LLDReservationId = table.Column<int>(type: "int", nullable: true),
                    Message = table.Column<string>(type: "longtext", nullable: false),
                    IsRead = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservation_id_LongTermRental",
                        column: x => x.LLDReservationId,
                        principalTable: "long_term_rentals",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reservation_id_reservation",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Agences",
                columns: new[] { "Id", "Address", "City", "CreatedAt", "DeletedAt", "Email", "IsVerified", "Latitude", "Longitude", "Name", "Tel", "UpdatedAt", "ZipCode" },
                values: new object[,]
                {
                    { 1, "803 Lindsay Prairie", "East Vivian", new DateTime(2022, 8, 19, 5, 47, 19, 948, DateTimeKind.Local).AddTicks(5478), null, "Rita.Turcotte17@yahoo.com", false, 44.011099999999999, -47.679400000000001, "Principal Accounts Officer", "(447) 205-2477 x0886", null, "53632" },
                    { 2, "29607 Josephine Pass", "Metzburgh", new DateTime(2022, 9, 16, 2, 52, 4, 349, DateTimeKind.Local).AddTicks(6443), null, "Jane.Stokes@yahoo.com", false, -87.694100000000006, -39.072499999999998, "Dynamic Identity Producer", "234-989-8123 x717", null, "63164" },
                    { 3, "366 Janet Causeway", "Stiedemannton", new DateTime(2023, 1, 1, 9, 4, 37, 924, DateTimeKind.Local).AddTicks(7722), null, "Joanne_Bernhard@yahoo.com", false, -72.477400000000003, 175.90430000000001, "Dynamic Assurance Engineer", "(349) 259-2528", null, "83194" },
                    { 4, "25557 Rodrick Ports", "O'Connellton", new DateTime(2023, 6, 21, 5, 43, 27, 428, DateTimeKind.Local).AddTicks(1128), null, "Sabrina24@yahoo.com", false, -40.413800000000002, -67.113, "Legacy Solutions Representative", "856-820-5533 x3122", null, "36712" },
                    { 5, "542 Lynch Trafficway", "Ondrickamouth", new DateTime(2022, 10, 7, 21, 12, 48, 445, DateTimeKind.Local).AddTicks(9911), null, "Jamarcus_Rosenbaum@yahoo.com", false, 50.758200000000002, -5.0719000000000003, "Direct Markets Producer", "662-945-0371 x7823", null, "13913" },
                    { 6, "3506 Lincoln Locks", "West Martina", new DateTime(2023, 1, 21, 3, 6, 38, 236, DateTimeKind.Local).AddTicks(3548), null, "Dominique33@hotmail.com", false, -46.551699999999997, 86.971900000000005, "Investor Quality Director", "(232) 506-3238", null, "84168" },
                    { 7, "336 Raheem Grove", "Kleinmouth", new DateTime(2022, 11, 14, 19, 29, 17, 192, DateTimeKind.Local).AddTicks(2084), null, "Zoila93@gmail.com", false, 56.912199999999999, 104.8115, "Senior Research Consultant", "613.512.2607", null, "76648-2628" },
                    { 8, "896 Streich Keys", "Schimmelport", new DateTime(2022, 10, 2, 0, 40, 52, 42, DateTimeKind.Local).AddTicks(8342), null, "Saige73@yahoo.com", false, 68.231800000000007, 132.94329999999999, "Global Creative Executive", "873.714.8979 x7646", null, "91644" },
                    { 9, "726 Sophia Summit", "Lydiafurt", new DateTime(2022, 8, 15, 6, 20, 36, 945, DateTimeKind.Local).AddTicks(5918), null, "Sonny.Cummerata@hotmail.com", false, 89.502099999999999, -61.570300000000003, "Dynamic Branding Strategist", "564-258-7546 x25463", null, "36730-0779" },
                    { 10, "3298 Hegmann Shoals", "Charlesville", new DateTime(2023, 4, 15, 19, 22, 58, 116, DateTimeKind.Local).AddTicks(771), null, "Dale.Bogan34@gmail.com", false, -10.260400000000001, -74.812899999999999, "Human Intranet Strategist", "1-330-333-3188", null, "57489-7794" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Adresse", "Adresse2", "CreatedAt", "DeletedAt", "Email", "FirstName", "LastName", "Password", "PermisRecto", "PermisVerso", "Tel", "UpdatedAt", "Ville", "ZipCode" },
                values: new object[,]
                {
                    { 1, "929 Reginald Locks", "4568 Spinka Port", new DateTime(2022, 11, 15, 6, 21, 22, 250, DateTimeKind.Local).AddTicks(561), null, "Josefa64@gmail.com", "Kitty", "Sanford", null, "https://picsum.photos/640/480/?image=753", "https://picsum.photos/640/480/?image=599", "(925) 841-5715 x94645", null, "Seamusborough", "08757-2401" },
                    { 2, "1681 Quinn Freeway", "544 Ettie Mountains", new DateTime(2022, 10, 8, 5, 50, 0, 621, DateTimeKind.Local).AddTicks(5068), null, "Giovanny.Raynor@gmail.com", "Queenie", "Fay", null, "https://picsum.photos/640/480/?image=389", "https://picsum.photos/640/480/?image=860", "(347) 403-7166", null, "West Nilsview", "61328-4110" },
                    { 3, "9436 Einar Expressway", "757 Reyes Turnpike", new DateTime(2022, 11, 8, 16, 33, 2, 792, DateTimeKind.Local).AddTicks(8167), null, "Arnold.Predovic7@hotmail.com", "Asa", "Simonis", null, "https://picsum.photos/640/480/?image=944", "https://picsum.photos/640/480/?image=802", "(377) 841-0017", null, "East Paolo", "40910-4090" },
                    { 4, "70114 Abigale Keys", "687 Monahan Inlet", new DateTime(2022, 12, 8, 21, 42, 20, 34, DateTimeKind.Local).AddTicks(244), null, "Sierra.Lowe8@hotmail.com", "Raleigh", "Kunze", null, "https://picsum.photos/640/480/?image=84", "https://picsum.photos/640/480/?image=891", "(776) 877-4557 x33671", null, "VonRuedenville", "03017" },
                    { 5, "588 Bobby Brook", "95934 Hoeger Lights", new DateTime(2023, 4, 23, 7, 51, 28, 24, DateTimeKind.Local).AddTicks(2035), null, "Christopher.Lynch@hotmail.com", "Savanna", "Berge", null, "https://picsum.photos/640/480/?image=367", "https://picsum.photos/640/480/?image=519", "941.639.7521 x08659", null, "East Bernardoberg", "72813" },
                    { 6, "2065 Will Terrace", "5059 Karlie Ways", new DateTime(2022, 11, 11, 9, 6, 29, 282, DateTimeKind.Local).AddTicks(8353), null, "Vicky56@gmail.com", "Shanie", "Murazik", null, "https://picsum.photos/640/480/?image=724", "https://picsum.photos/640/480/?image=64", "1-780-709-7836 x2879", null, "Feeneymouth", "67419-5324" },
                    { 7, "743 Wilderman Forest", "196 Candice Spurs", new DateTime(2023, 4, 3, 13, 49, 55, 540, DateTimeKind.Local).AddTicks(6330), null, "Faye_Ryan@gmail.com", "Lowell", "Ebert", null, "https://picsum.photos/640/480/?image=308", "https://picsum.photos/640/480/?image=6", "266-812-5526", null, "West Sophieview", "81780" },
                    { 8, "14953 Lesch Radial", "9067 Gabrielle Trail", new DateTime(2022, 12, 26, 20, 40, 31, 795, DateTimeKind.Local).AddTicks(6623), null, "Stephany.Schmidt@yahoo.com", "Estel", "Mann", null, "https://picsum.photos/640/480/?image=208", "https://picsum.photos/640/480/?image=902", "852.914.6192", null, "Thielport", "99804-4024" },
                    { 9, "278 Fadel Mountain", "33646 Rogahn Island", new DateTime(2023, 3, 23, 4, 9, 53, 698, DateTimeKind.Local).AddTicks(3360), null, "Cleta.Jacobi89@gmail.com", "Jaleel", "Bayer", null, "https://picsum.photos/640/480/?image=722", "https://picsum.photos/640/480/?image=286", "(672) 824-3889 x14767", null, "North Thaliastad", "08881" },
                    { 10, "393 Chaya Dam", "17701 Dariana Points", new DateTime(2023, 6, 11, 6, 59, 19, 428, DateTimeKind.Local).AddTicks(5836), null, "Cassie_Collins@yahoo.com", "Baron", "Braun", null, "https://picsum.photos/640/480/?image=524", "https://picsum.photos/640/480/?image=813", "(494) 303-2454 x3739", null, "South Velmaton", "60456-5519" }
                });

            migrationBuilder.InsertData(
                table: "Marques",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ABARTH", null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ALFA-ROMEO", null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ASTON-MARTIN", null },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "AUDI", null },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "BENTLEY", null },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "BMW", null },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CHERY", null },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CITROEN", null },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CUPRA", null },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "DACIA", null },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "DFSK", null },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "DS", null },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "FERRARI", null },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "FIAT", null },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "FORD", null },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "FOTON", null },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "GAZ", null },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "HONDA", null },
                    { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "HYUNDAI", null },
                    { 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ISUZU", null },
                    { 21, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "JAGUAR", null },
                    { 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "JEEP", null },
                    { 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "KIA", null },
                    { 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "LAND-ROVER", null },
                    { 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "LEXUS", null },
                    { 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MAHINDRA", null },
                    { 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MAZDA", null },
                    { 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MERCEDES", null },
                    { 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MG", null },
                    { 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MINI", null },
                    { 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MITSUBISHI", null },
                    { 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "NISSAN", null },
                    { 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OPEL", null },
                    { 34, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "PEUGEOT", null },
                    { 35, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "PORSCHE", null },
                    { 36, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "RENAULT", null },
                    { 37, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "SEAT", null },
                    { 38, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "SERES", null },
                    { 39, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "SKODA", null },
                    { 40, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "SSANGYONG", null },
                    { 41, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "SUZUKI", null },
                    { 42, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "TATA", null },
                    { 43, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "TOYOTA", null },
                    { 44, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "VOLKSWAGEN", null },
                    { 45, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "VOLVO", null }
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
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IdMarque", "Image", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "modeles/595.png", "595", null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "modeles/595-cabriolet.png", "595 cabriolet", null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, "modeles/4c.png", "4c", null },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, "modeles/giulia.png", "giulia", null },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, "modeles/giulietta.png", "giulietta", null },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, "modeles/stelvio.png", "stelvio", null },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, "modeles/tonale.png", "tonale", null },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, "modeles/db11.png", "db11", null },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, "modeles/dbs-supperleggera.png", "dbs supperleggera", null },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, "modeles/dbx.png", "dbx", null },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, "modeles/vantage.png", "vantage", null },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, "modeles/a1.png", "a1", null },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, "modeles/a3.png", "a3", null },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, "modeles/a3-berline.png", "a3 berline", null },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, "modeles/a4.png", "a4", null },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, "modeles/a5-coupe.png", "a5 coupe", null },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, "modeles/a5-sportback.png", "a5 SPORTBACK", null },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, "modeles/a6.png", "a6", null },
                    { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, "modeles/a7.png", "a7", null },
                    { 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, "modeles/a8.png", "a8", null },
                    { 21, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, "modeles/e-tron.png", "e-tron", null },
                    { 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, "modeles/e-tron-sportback.png", "e-tron sportback", null },
                    { 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, "modeles/q2.png", "q2", null },
                    { 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, "modeles/q3.png", "q3", null },
                    { 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, "modeles/q3-sportback.png", "q3 sportback", null },
                    { 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, "modeles/q5.png", "q5", null },
                    { 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, "modeles/q5-sportback.png", "q5 sportback", null },
                    { 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, "modeles/q7.png", "q7", null },
                    { 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, "modeles/q8.png", "q8", null },
                    { 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, "modeles/r8.png", "r8", null },
                    { 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, "modeles/tt.png", "tt", null },
                    { 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "modeles/bentayga.png", "bentayga", null },
                    { 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "modeles/flying-spur.png", "flying spur", null },
                    { 34, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "modeles/mulsanne.png", "mulsanne", null },
                    { 35, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, "modeles/i4.png", "i4", null },
                    { 36, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, "modeles/ix.png", "ix", null },
                    { 37, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, "modeles/m2.png", "m2", null },
                    { 38, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, "modeles/m5.png", "m5", null },
                    { 39, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, "modeles/serie-1.png", "serie", null },
                    { 40, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, "modeles/serie-2.png", "serie", null },
                    { 41, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, "modeles/serie-2-gran-coupe.png", "serie gran coupe", null },
                    { 42, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, "modeles/serie-3.png", "serie", null },
                    { 43, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, "modeles/serie-4-cabriolet.png", "serie cabriolet", null },
                    { 44, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, "modeles/serie-4-gran-coupe.png", "serie gran coupe", null },
                    { 45, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, "modeles/serie-5.png", "serie", null },
                    { 46, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, "modeles/serie-7.png", "serie", null },
                    { 47, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, "modeles/serie-8.png", "serie", null },
                    { 48, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, "modeles/serie-8-cabriolet.png", "serie cabriolet", null },
                    { 49, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, "modeles/serie-8-gran-coupe.png", "serie gran coupe", null },
                    { 50, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, "modeles/x1.png", "x1", null },
                    { 51, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, "modeles/x2.png", "x2", null },
                    { 52, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, "modeles/x3.png", "x3", null },
                    { 53, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, "modeles/x4.png", "x4", null },
                    { 54, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, "modeles/x5.png", "x5", null },
                    { 55, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, "modeles/x6.png", "x6", null },
                    { 56, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, "modeles/x7.png", "x7", null },
                    { 57, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, "modeles/z4.png", "z4", null },
                    { 58, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, "modeles/tiggo-2-pro.png", "tiggo pro", null },
                    { 59, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, "modeles/tiggo-4-pro.png", "tiggo pro", null },
                    { 60, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, "modeles/tiggo-7-pro.png", "tiggo pro", null },
                    { 61, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, "modeles/tiggo-8-pro.png", "tiggo pro", null },
                    { 62, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, "modeles/ami.png", "ami", null },
                    { 63, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, "modeles/berlingo.png", "berlingo", null },
                    { 64, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, "modeles/berlingo-vu.jpg", "berlingo vu", null },
                    { 65, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, "modeles/c-elysee.png", "c-elysee", null },
                    { 66, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, "modeles/c1.png", "c1", null },
                    { 67, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, "modeles/c3.png", "c3", null },
                    { 68, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, "modeles/c3-aircross.png", "c3 aircross", null },
                    { 69, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, "modeles/c4.png", "c4", null },
                    { 70, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, "modeles/c4-x.png", "c4 x", null },
                    { 71, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, "modeles/c5-aircross.png", "c5 aircross", null },
                    { 72, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, "modeles/jumper.png", "jumper", null },
                    { 73, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, "modeles/jumpy.png", "jumpy", null },
                    { 74, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, "modeles/nemo.png", "nemo", null },
                    { 75, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, "modeles/spacetourer.png", "spacetourer", null },
                    { 76, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, "modeles/formentor.png", "formentor", null },
                    { 77, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, "modeles/duster.png", "duster", null },
                    { 78, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, "modeles/lodgy.png", "lodgy", null },
                    { 79, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, "modeles/logan.png", "logan", null },
                    { 80, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, "modeles/sandero-stepway.png", "sandero stepway", null },
                    { 81, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, "modeles/sandero-streetway.png", "sandero streetway", null },
                    { 82, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, "modeles/spring.png", "spring", null },
                    { 83, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, "modeles/c31.jpg", "c31", null },
                    { 84, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, "modeles/c35.png", "c35", null },
                    { 85, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, "modeles/glory-500.png", "glory00", null },
                    { 86, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, "modeles/glory-580.png", "glory80", null },
                    { 87, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, "modeles/glory-ix5.png", "glory ix5", null },
                    { 88, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, "modeles/k01h.png", "k01h", null },
                    { 89, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, "modeles/k01l.png", "k01l", null },
                    { 90, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, "modeles/k01s.png", "k01s", null },
                    { 91, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, "modeles/k05.jpg", "k05", null },
                    { 92, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, "modeles/super-cab.png", "super cab", null },
                    { 93, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, "modeles/ds4.png", "ds4", null },
                    { 94, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, "modeles/ds7.png", "ds7", null },
                    { 95, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, "modeles/812-superfast.png", "812 superfast", null },
                    { 96, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, "modeles/gtc4lusso.png", "gtc4lusso", null },
                    { 97, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, "modeles/500.png", "500", null },
                    { 98, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, "modeles/500c.png", "500c", null },
                    { 99, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, "modeles/500x.png", "500x", null },
                    { 100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, "modeles/doblo.jpg", "doblo", null },
                    { 101, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, "modeles/fiorino.png", "fiorino", null },
                    { 102, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, "modeles/fullback.png", "fullback", null },
                    { 103, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, "modeles/panda.png", "panda", null },
                    { 104, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, "modeles/talento.png", "talento", null },
                    { 105, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, "modeles/tipo.png", "tipo", null },
                    { 106, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, "modeles/tipo-hatchback.png", "tipo hatchback", null },
                    { 107, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, "modeles/c-max.png", "c max", null },
                    { 108, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, "modeles/ecosport.png", "ecosport", null },
                    { 109, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, "modeles/explorer.png", "explorer", null },
                    { 110, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, "modeles/focus-4p.png", "focusP", null },
                    { 111, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, "modeles/focus-5p.png", "focusp", null },
                    { 112, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, "modeles/fusion.png", "fusion", null },
                    { 113, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, "modeles/kuga.png", "kuga", null },
                    { 114, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, "modeles/mustang.png", "mustang", null },
                    { 115, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, "modeles/ranger.jpg", "ranger", null },
                    { 116, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, "modeles/tourneo-connect.png", "tourneo connect", null },
                    { 117, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, "modeles/transit.png", "transit", null },
                    { 118, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, "modeles/transit-custom.png", "transit custom", null },
                    { 119, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, "modeles/tm.png", "tm", null },
                    { 120, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, "modeles/next.png", "next", null },
                    { 121, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, "modeles/next-van.png", "next van", null },
                    { 122, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, "modeles/accord.png", "accord", null },
                    { 123, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, "modeles/civic.png", "civic", null },
                    { 124, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, "modeles/cr-v.png", "cr-v", null },
                    { 125, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, "modeles/hr-v.png", "hr-v", null },
                    { 126, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, "modeles/jazz.png", "jazz", null },
                    { 127, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, "modeles/accent.png", "accent", null },
                    { 128, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, "modeles/creta.png", "creta", null },
                    { 129, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, "modeles/elantra.png", "elantra", null },
                    { 130, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, "modeles/i10.png", "i10", null },
                    { 131, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, "modeles/i20.png", "i20", null },
                    { 132, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, "modeles/i30.png", "i30", null },
                    { 133, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, "modeles/ioniq-5.png", "ioniq", null },
                    { 134, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, "modeles/kona.png", "kona", null },
                    { 135, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, "modeles/santa-fe.png", "santa fe", null },
                    { 136, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, "modeles/sonata.png", "sonata", null },
                    { 137, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, "modeles/tucson.png", "tucson", null },
                    { 138, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, "modeles/d-max.png", "d-max", null },
                    { 139, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, "modeles/e-pace.png", "e-pace", null },
                    { 140, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, "modeles/f-pace.png", "f-pace", null },
                    { 141, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, "modeles/f-type.png", "F-TYPE", null },
                    { 142, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, "modeles/i-pace.png", "i-pace", null },
                    { 143, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, "modeles/xe.png", "xe", null },
                    { 144, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, "modeles/xf.png", "xf", null },
                    { 145, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, "modeles/xj.png", "xj", null },
                    { 146, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, "modeles/cherokee.png", "cherokee", null },
                    { 147, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, "modeles/compass.png", "compass", null },
                    { 148, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, "modeles/grand-cherokee.png", "grand cherokee", null },
                    { 149, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, "modeles/renegade.png", "renegade", null },
                    { 150, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, "modeles/wrangler.png", "wrangler", null },
                    { 151, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, "modeles/carens.png", "carens", null },
                    { 152, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, "modeles/carnival.png", "carnival", null },
                    { 153, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, "modeles/ceed.png", "ceed", null },
                    { 154, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, "modeles/cerato.png", "cerato", null },
                    { 155, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, "modeles/k2500.png", "k2500", null },
                    { 156, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, "modeles/k5.png", "k5", null },
                    { 157, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, "modeles/niro.png", "niro", null },
                    { 158, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, "modeles/picanto.png", "picanto", null },
                    { 159, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, "modeles/rio.png", "rio", null },
                    { 160, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, "modeles/seltos.png", "seltos", null },
                    { 161, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, "modeles/sonet.png", "sonet", null },
                    { 162, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, "modeles/sorento.png", "sorento", null },
                    { 163, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, "modeles/sorento-hybrid.png", "sorento hybrid", null },
                    { 164, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, "modeles/sportage.png", "sportage", null },
                    { 165, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, "modeles/sportage-hybrid.png", "sportage hybrid", null },
                    { 166, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, "modeles/stinger.png", "stinger", null },
                    { 167, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, "modeles/defender.png", "defender", null },
                    { 168, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, "modeles/discovery.png", "discovery", null },
                    { 169, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, "modeles/discovery-sport.png", "discovery sport", null },
                    { 170, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, "modeles/range-rover-evoque.png", "range rover evoque", null },
                    { 171, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, "modeles/range-rover-sport.png", "range rover sport", null },
                    { 172, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, "modeles/range-rover-velar.png", "range rover velar", null },
                    { 173, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, "modeles/range-rover-vogue.png", "range rover vogue", null },
                    { 174, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, "modeles/es.png", "es", null },
                    { 175, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, "modeles/is.png", "is", null },
                    { 176, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, "modeles/ls.png", "ls", null },
                    { 177, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, "modeles/nx.png", "nx", null },
                    { 178, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, "modeles/rx.png", "rx", null },
                    { 179, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, "modeles/rx-350h.png", "rx50h", null },
                    { 180, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, "modeles/ux.png", "ux", null },
                    { 181, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, "modeles/kuv-100.jpg", "kuv00", null },
                    { 182, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, "modeles/scorpio.jpg", "scorpio", null },
                    { 183, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, "modeles/xuv-500.jpg", "xuv00", null },
                    { 184, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, "modeles/6.png", "6", null },
                    { 185, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, "modeles/cx-3.png", "cx-3", null },
                    { 186, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, "modeles/cx-5.png", "cx-5", null },
                    { 187, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, "modeles/cla.png", "cla", null },
                    { 188, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, "modeles/classe-a.png", "classe a", null },
                    { 189, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, "modeles/classe-a-berline.png", "classe a berline", null },
                    { 190, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, "modeles/classe-b.png", "classe b", null },
                    { 191, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, "modeles/classe-c.png", "classe c", null },
                    { 192, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, "modeles/classe-c-coupe.png", "Classe C Coupe", null },
                    { 193, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, "modeles/classe-e.png", "classe e", null },
                    { 194, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, "modeles/classe-e-coupe.png", "classe e coupe", null },
                    { 195, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, "modeles/classe-g.png", "classe g", null },
                    { 196, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, "modeles/classe-s.png", "classe s", null },
                    { 197, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, "modeles/cls.png", "cls", null },
                    { 198, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, "modeles/gla.png", "gla", null },
                    { 199, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, "modeles/glc.png", "glc", null },
                    { 200, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, "modeles/glc-coupe.png", "glc coupe", null },
                    { 201, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, "modeles/gle.png", "gle", null },
                    { 202, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, "modeles/gle-coupe.png", "gle coupe", null },
                    { 203, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, "modeles/gls.png", "gls", null },
                    { 204, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, "modeles/slc.png", "slc", null },
                    { 205, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, "modeles/hs-phev.png", "hs Phev", null },
                    { 206, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, "modeles/mg-3.jpg", "MG", null },
                    { 207, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, "modeles/mg-hs.png", "MG HS", null },
                    { 208, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, "modeles/mg4.png", "mg4", null },
                    { 209, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, "modeles/mg5.png", "mg5", null },
                    { 210, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, "modeles/zs.png", "zs", null },
                    { 211, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, "modeles/zs-ev.png", "zs-ev", null },
                    { 212, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, "modeles/cabrio.png", "cabrio", null },
                    { 213, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, "modeles/clubman.png", "clubman", null },
                    { 214, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, "modeles/countryman.png", "countryman", null },
                    { 215, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, "modeles/hatch-3-portes.png", "HATCH portes", null },
                    { 216, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, "modeles/hatch-5-portes.png", "HATCH portes", null },
                    { 217, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 31, "modeles/l200.png", "l200", null },
                    { 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 31, "modeles/outlander.png", "outlander", null },
                    { 219, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 31, "modeles/pajero-sport.png", "pajero sport", null },
                    { 220, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 32, "modeles/evalia.png", "evalia", null },
                    { 221, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 32, "modeles/juke.png", "juke", null },
                    { 222, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 32, "modeles/micra.png", "micra", null },
                    { 223, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 32, "modeles/navara.png", "navara", null },
                    { 224, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 32, "modeles/qashqai.png", "qashqai", null },
                    { 225, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 32, "modeles/x-trail.png", "x trail", null },
                    { 226, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33, "modeles/astra.png", "astra", null },
                    { 227, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33, "modeles/combo-life.png", "combo life", null },
                    { 228, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33, "modeles/corsa.png", "corsa", null },
                    { 229, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33, "modeles/crossland.png", "crossland", null },
                    { 230, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33, "modeles/grandland.png", "grandland", null },
                    { 231, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33, "modeles/insignia-grand-sport.png", "insignia Grand Sport", null },
                    { 232, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33, "modeles/mokka.png", "mokka", null },
                    { 233, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34, "modeles/108.png", "108", null },
                    { 234, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34, "modeles/2008.png", "2008", null },
                    { 235, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34, "modeles/208.png", "208", null },
                    { 236, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34, "modeles/3008.png", "3008", null },
                    { 237, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34, "modeles/301.png", "301", null },
                    { 238, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34, "modeles/308.png", "308", null },
                    { 239, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34, "modeles/5008.png", "5008", null },
                    { 240, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34, "modeles/508.png", "508", null },
                    { 241, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34, "modeles/bipper.png", "bipper", null },
                    { 242, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34, "modeles/boxer.png", "boxer", null },
                    { 243, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34, "modeles/expert.png", "expert", null },
                    { 244, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34, "modeles/landtrek.png", "landtrek", null },
                    { 245, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34, "modeles/partner.png", "partner", null },
                    { 246, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34, "modeles/rifter.png", "rifter", null },
                    { 247, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34, "modeles/traveller.png", "traveller", null },
                    { 248, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35, "modeles/718-boxster.png", "718 boxster", null },
                    { 249, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35, "modeles/718-cayman.png", "718 cayman", null },
                    { 250, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35, "modeles/911.png", "911", null },
                    { 251, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35, "modeles/cayenne.png", "cayenne", null },
                    { 252, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35, "modeles/cayenne-coupe.png", "cayenne coupe", null },
                    { 253, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35, "modeles/macan.png", "macan", null },
                    { 254, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35, "modeles/panamera.png", "panamera", null },
                    { 255, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35, "modeles/taycan.png", "taycan", null },
                    { 256, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35, "modeles/taycan-cross-turismo.png", "taycan cross turismo", null },
                    { 257, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 36, "modeles/arkana.png", "arkana", null },
                    { 258, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 36, "modeles/captur.png", "captur", null },
                    { 259, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 36, "modeles/clio.png", "clio", null },
                    { 260, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 36, "modeles/express.png", "express", null },
                    { 261, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 36, "modeles/express-van.png", "express van", null },
                    { 262, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 36, "modeles/kadjar.png", "kadjar", null },
                    { 263, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 36, "modeles/kangoo.png", "kangoo", null },
                    { 264, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 36, "modeles/koleos.png", "koleos", null },
                    { 265, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 36, "modeles/master.png", "master", null },
                    { 266, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 36, "modeles/megane.png", "megane", null },
                    { 267, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 36, "modeles/megane-sedan.png", "megane sedan", null },
                    { 268, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 36, "modeles/talisman.png", "talisman", null },
                    { 269, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 36, "modeles/trafic.png", "trafic", null },
                    { 270, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 37, "modeles/arona.png", "arona", null },
                    { 271, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 37, "modeles/ateca.png", "ateca", null },
                    { 272, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 37, "modeles/ibiza.png", "ibiza", null },
                    { 273, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 37, "modeles/leon.png", "leon", null },
                    { 274, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 37, "modeles/mii.png", "mii", null },
                    { 275, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 37, "modeles/tarraco.png", "tarraco", null },
                    { 276, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 38, "modeles/3.png", "3", null },
                    { 277, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 38, "modeles/sf5.png", "sf5", null },
                    { 278, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 39, "modeles/karoq.png", "karoq", null },
                    { 279, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 39, "modeles/kodiaq.png", "kodiaq", null },
                    { 280, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 39, "modeles/octavia.png", "octavia", null },
                    { 281, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 39, "modeles/superb.png", "superb", null },
                    { 282, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 40, "modeles/korando.png", "korando", null },
                    { 283, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 40, "modeles/rexton.png", "rexton", null },
                    { 284, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 40, "modeles/stavic.png", "stavic", null },
                    { 285, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 40, "modeles/tivoli.png", "tivoli", null },
                    { 286, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 40, "modeles/xlv.png", "xlv", null },
                    { 287, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 41, "modeles/baleno.png", "baleno", null },
                    { 288, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 41, "modeles/ignis.png", "ignis", null },
                    { 289, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 41, "modeles/jimny.png", "jimny", null },
                    { 290, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 41, "modeles/s-cross.png", "s-cross", null },
                    { 291, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 41, "modeles/swift.png", "swift", null },
                    { 292, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 41, "modeles/vitara.png", "vitara", null },
                    { 293, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 42, "modeles/super-ace.png", "super ace", null },
                    { 294, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 42, "modeles/xenon.png", "xenon", null },
                    { 295, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 43, "modeles/auris.png", "auris", null },
                    { 296, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 43, "modeles/c-hr.png", "c-hr", null },
                    { 297, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 43, "modeles/corolla-prestige.png", "corolla prestige", null },
                    { 298, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 43, "modeles/corolla-sport.png", "corolla sport", null },
                    { 299, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 43, "modeles/fortuner.png", "fortuner", null },
                    { 300, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 43, "modeles/hilux.png", "hilux", null },
                    { 301, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 43, "modeles/land-cruiser.png", "land cruiser", null },
                    { 302, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 43, "modeles/new-corolla-x-air.png", "new corolla x air", null },
                    { 303, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 43, "modeles/new-rav4.png", "new rav4", null },
                    { 304, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 43, "modeles/prado.png", "prado", null },
                    { 305, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 43, "modeles/prius.png", "prius", null },
                    { 306, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 43, "modeles/yaris.png", "yaris", null },
                    { 307, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 43, "modeles/yaris-cross.png", "yaris cross", null },
                    { 308, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 44, "modeles/amarok.png", "amarok", null },
                    { 309, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 44, "modeles/arteon.png", "arteon", null },
                    { 310, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 44, "modeles/caddy.png", "caddy", null },
                    { 311, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 44, "modeles/caravelle.png", "caravelle", null },
                    { 312, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 44, "modeles/coccinelle.png", "coccinelle", null },
                    { 313, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 44, "modeles/crafter.png", "crafter", null },
                    { 314, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 44, "modeles/golf-8.png", "golf", null },
                    { 315, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 44, "modeles/jetta.png", "jetta", null },
                    { 316, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 44, "modeles/passat.png", "passat", null },
                    { 317, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 44, "modeles/polo.png", "polo", null },
                    { 318, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 44, "modeles/t-roc.png", "t-roc", null },
                    { 319, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 44, "modeles/tiguan.png", "tiguan", null },
                    { 320, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 44, "modeles/touareg.png", "touareg", null },
                    { 321, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 44, "modeles/touran.png", "touran", null },
                    { 322, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 45, "modeles/s60.png", "s60", null },
                    { 323, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 45, "modeles/s90.png", "s90", null },
                    { 324, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 45, "modeles/xc40.png", "xc40", null },
                    { 325, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 45, "modeles/xc60.png", "xc60", null },
                    { 326, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 45, "modeles/xc90.png", "xc90", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 18, 3, 17, 1, 123, DateTimeKind.Local).AddTicks(7740), null, "Natalie.Sporer@gmail.com", "Trever", 6, 1, true, "Gorczany", "$2a$11$bxVoVh7MpVSskQo2wVNwjeSi43TnWa4ehuyfxPVxVExbAaFnCdlVG", null },
                    { 2, new DateTime(2023, 7, 22, 20, 17, 54, 569, DateTimeKind.Local).AddTicks(4529), null, "Bessie8@hotmail.com", "Laurence", 6, 1, false, "Rice", "$2a$11$5UQJ1xdYZrppgEH0yY2D4OmnRTmmaM8uSX0HXoJjrAtZ/SQ/nEPUq", null },
                    { 3, new DateTime(2022, 9, 28, 5, 8, 23, 604, DateTimeKind.Local).AddTicks(3432), null, "Karlie_Schaden35@yahoo.com", "Curtis", 10, 3, true, "Ebert", "$2a$11$i5vIbKiRsIKJzF3af2tFEefUfgRCgYGRWp1ZCVHzTyaHrdI.hC7fm", null },
                    { 4, new DateTime(2023, 7, 15, 8, 41, 24, 108, DateTimeKind.Local).AddTicks(9303), null, "Kale28@gmail.com", "Ike", 2, 3, true, "Howell", "$2a$11$qNmGMxQFO4P2ZUZRVf4L1.9.Vpx6Q77nRY5n31w.yUurUxxLsclje", null },
                    { 5, new DateTime(2023, 2, 10, 0, 12, 54, 177, DateTimeKind.Local).AddTicks(3139), null, "Frederique35@hotmail.com", "Angie", 3, 1, false, "Goyette", "$2a$11$yhVJ1HGObRqy3EsmQWA16Oxz6OySPQBuF6Jz/EmumVhpiJQCpynFO", null },
                    { 6, new DateTime(2023, 5, 6, 8, 10, 49, 172, DateTimeKind.Local).AddTicks(9230), null, "Alberto88@yahoo.com", "Ewell", 6, 1, true, "Ruecker", "$2a$11$GJng.QowpCogH9Yd9fNKp.9FRt9c3nfiSKPtUDJEqq6O1xYaex.5q", null },
                    { 7, new DateTime(2022, 12, 30, 23, 7, 23, 410, DateTimeKind.Local).AddTicks(651), null, "Jamie.Huel@yahoo.com", "Troy", 1, 1, false, "Dooley", "$2a$11$uIxD.aa2IFouRNBeqhlqBuqBol08ve703BLhnywWF7ZXdG2iDqF7a", null },
                    { 8, new DateTime(2023, 7, 3, 7, 26, 27, 342, DateTimeKind.Local).AddTicks(7345), null, "Aniya_Reilly@gmail.com", "Rodger", 8, 3, false, "Harris", "$2a$11$/hgS4hCZwlG1Lrh27/CdLuqvoIZavFqqeramlG6Si01Z/38bGENy.", null },
                    { 9, new DateTime(2023, 5, 17, 13, 46, 38, 997, DateTimeKind.Local).AddTicks(7606), null, "Reagan57@gmail.com", "Llewellyn", 1, 4, true, "Flatley", "$2a$11$j3YazwumorjCZWMEMhCT9uj09FS13PEcM6UUGzWuCf5LlCouzPG.2", null },
                    { 10, new DateTime(2023, 2, 16, 19, 50, 17, 90, DateTimeKind.Local).AddTicks(6392), null, "Katherine.Kohler63@hotmail.com", "Elmore", 7, 3, false, "Jenkins", "$2a$11$1ex7Td.DUtiwGoJROTAZZ.zmDlzdAepybnClwZsNdnWsKBvng3mmi", null }
                });

            migrationBuilder.InsertData(
                table: "Vehicules",
                columns: new[] { "Id", "Airbag", "Climat", "CreatedAt", "DeletedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, false, true, new DateTime(2023, 1, 6, 3, 26, 46, 827, DateTimeKind.Local).AddTicks(7724), null, "yfovessedn", 1, 263, 6066, "uofkfpnetl", "hbmalmnbys", "ftcquswyex", 6, 10, 3.0, "nzqggdyrvj", null },
                    { 2, true, true, new DateTime(2023, 1, 1, 11, 46, 27, 501, DateTimeKind.Local).AddTicks(567), null, "cqhpmohhku", 4, 135, 5944, "xqrbaghgom", "hhetjarkvu", "iokogkgehd", 1, 7, 8.0, "ofwojukxhg", null },
                    { 3, false, true, new DateTime(2023, 4, 17, 5, 25, 36, 312, DateTimeKind.Local).AddTicks(6673), null, "ossoglabuv", 5, 207, 7865, "hpqkynyghy", "azpxafphhz", "zquccjneci", 1, 8, 8.0, "kggsmapmvc", null },
                    { 4, false, true, new DateTime(2022, 10, 7, 14, 15, 5, 841, DateTimeKind.Local).AddTicks(5615), null, "edqihtkkhe", 2, 252, 5588, "ybxystoqyy", "jattbtstuf", "umkcijpjbq", 2, 7, 7.0, "rueaqwopwc", null },
                    { 5, false, false, new DateTime(2023, 1, 27, 9, 49, 11, 302, DateTimeKind.Local).AddTicks(8821), null, "wlpnpopbab", 10, 101, 8164, "hhhdwasopp", "ooxowxtcub", "wxnzxlctzq", 9, 4, 5.0, "yaqmqodrwp", null },
                    { 6, false, true, new DateTime(2023, 1, 2, 19, 31, 35, 983, DateTimeKind.Local).AddTicks(2868), null, "vcifaijtcy", 9, 106, 7871, "qagubtlter", "mfvdwsgvwn", "xtjwcnubzi", 6, 7, 9.0, "ieidtmjgjd", null },
                    { 7, false, true, new DateTime(2022, 8, 14, 8, 12, 14, 658, DateTimeKind.Local).AddTicks(486), null, "bgxfdhhdcf", 7, 291, 4009, "ceiukjhetj", "yujczlgbmc", "pgrzmcbhfe", 8, 9, 1.0, "lxaszcixis", null },
                    { 8, true, false, new DateTime(2022, 11, 13, 10, 47, 51, 475, DateTimeKind.Local).AddTicks(6555), null, "njoynlibnv", 5, 92, 7287, "jhjdwitbqe", "yjkzxgvzxh", "zdithtdykn", 10, 3, 10.0, "cjgnjmdfub", null },
                    { 9, true, false, new DateTime(2023, 3, 11, 7, 34, 4, 418, DateTimeKind.Local).AddTicks(5347), null, "gqbjkzpxlm", 2, 23, 211, "xcptwgonps", "ezcuxcvuhj", "tahjkxyhjj", 6, 7, 5.0, "bdbtskfeql", null },
                    { 10, true, false, new DateTime(2022, 8, 19, 12, 40, 17, 992, DateTimeKind.Local).AddTicks(2393), null, "qeqrydddrt", 1, 149, 3486, "vefzdwkzvh", "cvknyorobm", "uybfwmsxhg", 5, 10, 9.0, "evdayktgsd", null }
                });

            migrationBuilder.InsertData(
                table: "long_term_rentals",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IdModele", "NumeroReservation", "UpdatedAt", "description", "duree", "email", "entreprise", "idAgence", "nom", "phone", "prenom", "status", "ville", "zip" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 10, 0, 24, 18, 316, DateTimeKind.Local).AddTicks(7001), null, 1, "Barney", null, "Stamm", 2, "Milo45@gmail.com", "McKenzie - Wolf", null, "Joseph", "916-719-8665", "Grant", "Sibyl", "Hamillshire", "93967-3728" },
                    { 2, new DateTime(2023, 4, 21, 2, 40, 32, 752, DateTimeKind.Local).AddTicks(8452), null, 1, "Marguerite", null, "Mayert", 3, "Randi4@hotmail.com", "Carroll - Stiedemann", null, "Clinton", "957.423.2111", "Schmidt", "Willis", "South Hermannberg", "42316" },
                    { 3, new DateTime(2023, 5, 3, 13, 57, 52, 125, DateTimeKind.Local).AddTicks(3598), null, 1, "Josiane", null, "Thompson", 4, "Donato.Smith@gmail.com", "Nicolas - Zieme", null, "Thora", "323.792.9415 x0370", "Medhurst", "Tobin", "New Imogenestad", "21544" },
                    { 4, new DateTime(2023, 6, 16, 0, 5, 13, 718, DateTimeKind.Local).AddTicks(8730), null, 1, "Verla", null, "Mosciski", 5, "Lorine.Jenkins43@hotmail.com", "Cassin - Skiles", null, "Waylon", "697-832-4425", "Ratke", "Lempi", "Watersborough", "65233" },
                    { 5, new DateTime(2022, 9, 6, 14, 47, 18, 522, DateTimeKind.Local).AddTicks(7657), null, 1, "Maximo", null, "Bins", 6, "Dedrick83@yahoo.com", "King and Sons", null, "Fredrick", "249-471-1459 x4938", "Ebert", "Ryder", "Moenberg", "33490" },
                    { 6, new DateTime(2023, 4, 26, 11, 52, 15, 443, DateTimeKind.Local).AddTicks(2227), null, 1, "Clare", null, "Schiller", 7, "Antwan_Hand@yahoo.com", "Oberbrunner, Spinka and Bogan", null, "Gideon", "297.816.0881", "Kuhlman", "Vito", "Lake Chase", "91046-5469" },
                    { 7, new DateTime(2022, 10, 27, 22, 58, 50, 943, DateTimeKind.Local).AddTicks(177), null, 1, "Winnifred", null, "Wiza", 8, "Jerrod.Maggio64@gmail.com", "Collins LLC", null, "Carmelo", "1-986-698-9907 x952", "Bauch", "Giles", "South Kaylinstad", "98965-7200" },
                    { 8, new DateTime(2022, 11, 28, 7, 10, 50, 696, DateTimeKind.Local).AddTicks(2378), null, 1, "Leora", null, "Mayer", 9, "Pierre.Murray38@gmail.com", "Ebert, Bradtke and Witting", null, "Emmanuel", "1-428-935-8185", "Howe", "Warren", "Kirlinhaven", "89125" },
                    { 9, new DateTime(2023, 5, 31, 15, 8, 12, 756, DateTimeKind.Local).AddTicks(5611), null, 1, "Sammy", null, "Cassin", 10, "Nellie60@gmail.com", "Rohan - Kihn", null, "Myles", "860.684.4641 x88145", "Rolfson", "Turner", "North Kayli", "65811-2967" },
                    { 10, new DateTime(2023, 2, 6, 7, 9, 37, 237, DateTimeKind.Local).AddTicks(4962), null, 1, "Doris", null, "Leffler", 11, "Rosalee76@yahoo.com", "Medhurst and Sons", null, "Isai", "218.930.3138", "Barton", "Evelyn", "North Carmen", "63176" }
                });

            migrationBuilder.InsertData(
                table: "Offres",
                columns: new[] { "Id", "CreatedAt", "DateDebut", "DateFin", "DeletedAt", "IdVehicule", "Prix", "UpdatedAt", "isPublic" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 6, 18, 57, 0, 332, DateTimeKind.Local).AddTicks(2356), new DateTime(2022, 11, 25, 10, 30, 49, 449, DateTimeKind.Local).AddTicks(1103), new DateTime(2023, 6, 4, 12, 37, 58, 563, DateTimeKind.Local).AddTicks(2899), null, 10, 3.0, null, false },
                    { 2, new DateTime(2023, 3, 4, 17, 52, 57, 37, DateTimeKind.Local).AddTicks(7606), new DateTime(2022, 8, 17, 23, 16, 44, 124, DateTimeKind.Local).AddTicks(8867), new DateTime(2022, 10, 23, 0, 45, 39, 851, DateTimeKind.Local).AddTicks(7462), null, 6, 2.0, null, false },
                    { 3, new DateTime(2023, 7, 6, 17, 59, 22, 998, DateTimeKind.Local).AddTicks(3588), new DateTime(2023, 1, 4, 19, 6, 15, 536, DateTimeKind.Local).AddTicks(8790), new DateTime(2023, 1, 29, 21, 11, 4, 937, DateTimeKind.Local).AddTicks(1850), null, 6, 3.0, null, false },
                    { 4, new DateTime(2022, 8, 23, 15, 20, 43, 15, DateTimeKind.Local).AddTicks(5086), new DateTime(2023, 2, 27, 7, 58, 28, 634, DateTimeKind.Local).AddTicks(4517), new DateTime(2023, 3, 21, 9, 56, 19, 26, DateTimeKind.Local).AddTicks(9110), null, 5, 10.0, null, false },
                    { 5, new DateTime(2023, 6, 3, 20, 16, 21, 454, DateTimeKind.Local).AddTicks(3588), new DateTime(2023, 1, 10, 6, 52, 0, 200, DateTimeKind.Local).AddTicks(2488), new DateTime(2022, 8, 14, 21, 33, 44, 941, DateTimeKind.Local).AddTicks(3458), null, 3, 6.0, null, false },
                    { 6, new DateTime(2022, 10, 15, 5, 27, 58, 42, DateTimeKind.Local).AddTicks(9784), new DateTime(2022, 9, 16, 1, 56, 56, 145, DateTimeKind.Local).AddTicks(1434), new DateTime(2022, 8, 2, 16, 11, 16, 343, DateTimeKind.Local).AddTicks(4879), null, 1, 3.0, null, false },
                    { 7, new DateTime(2023, 1, 24, 7, 41, 44, 609, DateTimeKind.Local).AddTicks(6132), new DateTime(2023, 6, 23, 18, 33, 30, 840, DateTimeKind.Local).AddTicks(2538), new DateTime(2023, 2, 24, 2, 3, 11, 41, DateTimeKind.Local).AddTicks(7853), null, 5, 4.0, null, false },
                    { 8, new DateTime(2022, 10, 27, 11, 50, 27, 632, DateTimeKind.Local).AddTicks(8321), new DateTime(2023, 4, 30, 11, 38, 12, 75, DateTimeKind.Local).AddTicks(3622), new DateTime(2023, 7, 10, 8, 17, 46, 991, DateTimeKind.Local).AddTicks(7949), null, 5, 5.0, null, false },
                    { 9, new DateTime(2023, 3, 27, 22, 31, 14, 295, DateTimeKind.Local).AddTicks(3646), new DateTime(2023, 5, 15, 16, 24, 54, 167, DateTimeKind.Local).AddTicks(388), new DateTime(2022, 8, 9, 6, 22, 39, 246, DateTimeKind.Local).AddTicks(8585), null, 5, 3.0, null, false },
                    { 10, new DateTime(2023, 4, 9, 6, 59, 41, 753, DateTimeKind.Local).AddTicks(2598), new DateTime(2023, 2, 14, 3, 8, 51, 250, DateTimeKind.Local).AddTicks(5220), new DateTime(2023, 2, 2, 6, 48, 46, 674, DateTimeKind.Local).AddTicks(3944), null, 10, 1.0, null, false }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CreatedAt", "DateDepart", "DateRetour", "DeletedAt", "IdVehicule", "NumeroReservation", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 15, 7, 31, 39, 703, DateTimeKind.Local).AddTicks(7394), new DateTime(2023, 2, 16, 23, 14, 56, 947, DateTimeKind.Local).AddTicks(5813), new DateTime(2023, 3, 18, 18, 34, 47, 403, DateTimeKind.Local).AddTicks(2827), null, 5, "3e1e4491-a1eb-494a-bcbb-5dda7e6939a7", "Confirmé", null },
                    { 2, new DateTime(2023, 3, 12, 1, 33, 43, 425, DateTimeKind.Local).AddTicks(8884), new DateTime(2022, 10, 22, 2, 44, 59, 27, DateTimeKind.Local).AddTicks(9284), new DateTime(2023, 1, 28, 6, 1, 14, 853, DateTimeKind.Local).AddTicks(8039), null, 10, "bbab6e48-9e8a-4973-a4f0-15460e085a9a", "Expiré", null },
                    { 3, new DateTime(2022, 9, 5, 23, 7, 53, 835, DateTimeKind.Local).AddTicks(2752), new DateTime(2023, 5, 25, 10, 30, 47, 392, DateTimeKind.Local).AddTicks(7185), new DateTime(2023, 6, 17, 11, 44, 8, 700, DateTimeKind.Local).AddTicks(7310), null, 10, "f68f2a46-c533-46f8-93b7-293c8907804b", "Expiré", null },
                    { 4, new DateTime(2023, 5, 13, 22, 47, 51, 565, DateTimeKind.Local).AddTicks(7164), new DateTime(2022, 9, 3, 19, 9, 6, 632, DateTimeKind.Local).AddTicks(4995), new DateTime(2022, 12, 3, 15, 50, 17, 891, DateTimeKind.Local).AddTicks(1208), null, 10, "6f4ba53e-7176-4616-9ae6-65462c28e876", "Annulé", null },
                    { 5, new DateTime(2022, 11, 29, 19, 18, 31, 211, DateTimeKind.Local).AddTicks(5479), new DateTime(2023, 6, 25, 13, 27, 5, 682, DateTimeKind.Local).AddTicks(9358), new DateTime(2023, 5, 19, 3, 15, 27, 307, DateTimeKind.Local).AddTicks(18), null, 2, "3af1c00f-4dc8-4a68-ae49-5b73756d3baf", "Confirmé", null },
                    { 6, new DateTime(2023, 7, 29, 10, 57, 58, 323, DateTimeKind.Local).AddTicks(6668), new DateTime(2023, 4, 30, 12, 37, 51, 534, DateTimeKind.Local).AddTicks(6523), new DateTime(2023, 2, 2, 20, 57, 2, 561, DateTimeKind.Local).AddTicks(3903), null, 6, "181d02be-dc78-466f-bdfc-d89869d7c9c6", "Expiré", null },
                    { 7, new DateTime(2023, 5, 6, 17, 57, 39, 755, DateTimeKind.Local).AddTicks(9256), new DateTime(2023, 4, 4, 0, 32, 14, 224, DateTimeKind.Local).AddTicks(7573), new DateTime(2023, 2, 14, 1, 20, 52, 299, DateTimeKind.Local).AddTicks(9104), null, 6, "e5246f5e-3c31-4bad-9a4b-fa59401db7cb", "Annulé", null },
                    { 8, new DateTime(2023, 6, 21, 16, 16, 31, 13, DateTimeKind.Local).AddTicks(5380), new DateTime(2022, 8, 1, 7, 24, 28, 597, DateTimeKind.Local).AddTicks(720), new DateTime(2023, 6, 29, 20, 8, 56, 555, DateTimeKind.Local).AddTicks(1370), null, 8, "79ee1174-88af-4165-9c4e-d002b080f73c", "Expiré", null },
                    { 9, new DateTime(2023, 4, 24, 13, 53, 22, 802, DateTimeKind.Local).AddTicks(7949), new DateTime(2022, 12, 11, 5, 56, 9, 646, DateTimeKind.Local).AddTicks(2841), new DateTime(2022, 11, 11, 11, 30, 11, 631, DateTimeKind.Local).AddTicks(1861), null, 3, "5b3e1769-18e1-4824-8d64-645186301e3d", "Annulé", null },
                    { 10, new DateTime(2023, 5, 27, 16, 36, 59, 231, DateTimeKind.Local).AddTicks(6278), new DateTime(2023, 2, 4, 4, 3, 31, 593, DateTimeKind.Local).AddTicks(566), new DateTime(2023, 3, 29, 13, 27, 8, 360, DateTimeKind.Local).AddTicks(5898), null, 7, "12a89bd2-6436-4156-9b02-1c017554848e", "Expiré", null }
                });

            migrationBuilder.InsertData(
                table: "Contrats",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IdClient", "IdReservation", "IsConducteur", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, 3, false, null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, 3, false, null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, 5, false, null },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 5, true, null },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, 1, true, null },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, 10, false, null },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, 10, true, null },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, 4, true, null },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, 10, true, null },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, 1, false, null }
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
                name: "IX_lld_responses_idAgence",
                table: "lld_responses",
                column: "idAgence");

            migrationBuilder.CreateIndex(
                name: "IX_lld_responses_idLongTermRental",
                table: "lld_responses",
                column: "idLongTermRental");

            migrationBuilder.CreateIndex(
                name: "IX_long_term_rentals_IdModele",
                table: "long_term_rentals",
                column: "IdModele");

            migrationBuilder.CreateIndex(
                name: "IX_Modeles_IdMarque",
                table: "Modeles",
                column: "IdMarque");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_LLDReservationId",
                table: "Notifications",
                column: "LLDReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_ReservationId",
                table: "Notifications",
                column: "ReservationId");

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
                name: "lld_responses");

            migrationBuilder.DropTable(
                name: "log_journal");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Offres");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "long_term_rentals");

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
