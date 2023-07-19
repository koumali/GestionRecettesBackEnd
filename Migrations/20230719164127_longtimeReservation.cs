using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AutomotiveApi.Migrations
{
    /// <inheritdoc />
    public partial class longtimeReservation : Migration
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
                    Email = table.Column<string>(type: "longtext", nullable: true),
                    Ville = table.Column<string>(type: "longtext", nullable: false),
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
                    type_vehicule = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "longtext", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_long_term_rentals", x => x.Id);
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

            migrationBuilder.InsertData(
                table: "Agences",
                columns: new[] { "Id", "Address", "City", "CreatedAt", "DeletedAt", "Email", "IsVerified", "Latitude", "Longitude", "Name", "Tel", "UpdatedAt", "ZipCode" },
                values: new object[,]
                {
                    { 1, "25444 Fay Branch", "Elizachester", new DateTime(2022, 8, 27, 9, 25, 1, 654, DateTimeKind.Local).AddTicks(4410), null, "Aurelia.Wisozk@hotmail.com", false, -55.760300000000001, 29.863099999999999, "Senior Usability Engineer", "679.929.1547", null, "50997" },
                    { 2, "20666 Dicki Lights", "Bogantown", new DateTime(2022, 9, 25, 16, 49, 18, 623, DateTimeKind.Local).AddTicks(1404), null, "Kurtis_OHara@hotmail.com", false, 22.901299999999999, 177.05680000000001, "National Optimization Designer", "(769) 938-7457 x251", null, "57782" },
                    { 3, "5945 Frederic Rest", "Port Mariafurt", new DateTime(2023, 1, 16, 1, 0, 49, 713, DateTimeKind.Local).AddTicks(2664), null, "Norris_Schiller69@yahoo.com", false, -12.9749, -106.277, "Central Applications Officer", "352.839.4837", null, "51916-9450" },
                    { 4, "81434 Kennith Track", "Port Terrencemouth", new DateTime(2022, 11, 17, 5, 55, 26, 721, DateTimeKind.Local).AddTicks(2571), null, "Nia82@hotmail.com", false, 21.6648, 84.4392, "Forward Paradigm Director", "865.779.9934 x425", null, "64261" },
                    { 5, "27271 Stehr Island", "Sporerland", new DateTime(2023, 5, 12, 13, 56, 51, 656, DateTimeKind.Local).AddTicks(9757), null, "Thad.Lakin47@hotmail.com", false, -74.077299999999994, 83.936999999999998, "Senior Program Specialist", "754-449-8481 x81848", null, "14492-2546" },
                    { 6, "415 Ratke Squares", "New Tierra", new DateTime(2023, 4, 14, 17, 50, 17, 668, DateTimeKind.Local).AddTicks(6213), null, "Amani_Dooley@yahoo.com", false, -11.2212, 104.7272, "Global Program Consultant", "474-829-0478 x897", null, "43834-3285" },
                    { 7, "872 Ocie Forges", "North Elisaton", new DateTime(2023, 2, 22, 4, 19, 4, 62, DateTimeKind.Local).AddTicks(1372), null, "Ramona95@yahoo.com", false, -48.526200000000003, 172.899, "Senior Accountability Analyst", "(366) 730-0601", null, "09196" },
                    { 8, "41763 Lauryn Bypass", "Christiansenshire", new DateTime(2022, 11, 18, 1, 16, 51, 392, DateTimeKind.Local).AddTicks(674), null, "Broderick.Mann@yahoo.com", false, 18.828199999999999, 17.020299999999999, "Dynamic Integration Executive", "(982) 658-7116 x55455", null, "98818-9897" },
                    { 9, "768 Rodrigo Pine", "East Emil", new DateTime(2022, 9, 25, 12, 42, 53, 521, DateTimeKind.Local).AddTicks(8047), null, "Georgianna.OConnell51@yahoo.com", false, -55.349899999999998, 105.9289, "Investor Factors Developer", "(518) 384-2569", null, "03797-8792" },
                    { 10, "448 VonRueden Parkway", "New Anabelle", new DateTime(2022, 12, 7, 15, 56, 42, 776, DateTimeKind.Local).AddTicks(7062), null, "Ray87@yahoo.com", false, -26.860700000000001, -161.87450000000001, "Regional Marketing Technician", "1-413-637-2288", null, "53313" }
                });

            migrationBuilder.InsertData(
                table: "Marques",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 2, 4, 52, 3, 913, DateTimeKind.Local).AddTicks(3290), null, "Mini", null },
                    { 2, new DateTime(2022, 11, 2, 4, 32, 7, 67, DateTimeKind.Local).AddTicks(4145), null, "BMW", null },
                    { 3, new DateTime(2023, 1, 4, 14, 52, 16, 518, DateTimeKind.Local).AddTicks(939), null, "Ferrari", null },
                    { 4, new DateTime(2023, 3, 19, 21, 36, 43, 833, DateTimeKind.Local).AddTicks(4951), null, "Jaguar", null },
                    { 5, new DateTime(2022, 10, 19, 12, 10, 11, 98, DateTimeKind.Local).AddTicks(6732), null, "Polestar", null },
                    { 6, new DateTime(2023, 6, 11, 8, 38, 22, 530, DateTimeKind.Local).AddTicks(6043), null, "Ford", null },
                    { 7, new DateTime(2023, 1, 10, 13, 50, 59, 904, DateTimeKind.Local).AddTicks(5284), null, "Hyundai", null },
                    { 8, new DateTime(2023, 2, 14, 5, 50, 46, 847, DateTimeKind.Local).AddTicks(7774), null, "Mercedes Benz", null },
                    { 9, new DateTime(2022, 11, 24, 5, 58, 30, 584, DateTimeKind.Local).AddTicks(2601), null, "Kia", null },
                    { 10, new DateTime(2023, 1, 4, 7, 37, 45, 998, DateTimeKind.Local).AddTicks(3370), null, "Smart", null }
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
                table: "long_term_rentals",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "UpdatedAt", "description", "duree", "email", "entreprise", "nom", "phone", "prenom", "type_vehicule", "ville", "zip" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 17, 5, 14, 9, 227, DateTimeKind.Local).AddTicks(2345), null, null, "White", 2, "Otis.Prosacco57@hotmail.com", "Blanda - Walter", "Nels", "(590) 818-5604", "Pagac", 1, "Lake Jesusburgh", "58928" },
                    { 2, new DateTime(2022, 9, 8, 21, 2, 17, 988, DateTimeKind.Local).AddTicks(2657), null, null, "Harber", 3, "Buddy_Williamson@yahoo.com", "Toy - Roob", "Tremaine", "468-562-0871", "VonRueden", 1, "Titomouth", "06262-9958" },
                    { 3, new DateTime(2022, 10, 10, 20, 22, 58, 796, DateTimeKind.Local).AddTicks(8670), null, null, "Sawayn", 4, "Richie_Bayer@gmail.com", "O'Keefe and Sons", "Frederick", "933-233-3901 x6126", "Wolff", 1, "Port Jaydetown", "74010-2732" },
                    { 4, new DateTime(2022, 7, 24, 20, 10, 36, 154, DateTimeKind.Local).AddTicks(7717), null, null, "Dooley", 5, "Neha49@hotmail.com", "Witting, Stroman and Mueller", "Ivory", "(934) 516-1672", "Witting", 1, "Dickensburgh", "60364" },
                    { 5, new DateTime(2022, 9, 6, 1, 10, 21, 79, DateTimeKind.Local).AddTicks(9695), null, null, "Schamberger", 6, "Monroe49@hotmail.com", "Hartmann - Grady", "Maxwell", "211-247-9966", "Koch", 1, "New Maggiemouth", "94305" },
                    { 6, new DateTime(2023, 6, 20, 19, 26, 6, 844, DateTimeKind.Local).AddTicks(7219), null, null, "Bechtelar", 7, "Haley94@hotmail.com", "Gaylord and Sons", "Haley", "551.418.4030 x73881", "Murray", 1, "West Hipolitotown", "06311-4891" },
                    { 7, new DateTime(2023, 7, 19, 5, 0, 40, 189, DateTimeKind.Local).AddTicks(9770), null, null, "Wintheiser", 8, "Daniella.Ruecker@yahoo.com", "McGlynn, Kerluke and Satterfield", "Halie", "919-995-1789", "Keebler", 1, "Claymouth", "08507" },
                    { 8, new DateTime(2023, 4, 19, 17, 1, 38, 660, DateTimeKind.Local).AddTicks(8534), null, null, "Rutherford", 9, "Nicolas_Stoltenberg@hotmail.com", "Reynolds - Swaniawski", "Ubaldo", "418.311.7533", "Mayert", 1, "Bartonhaven", "06074" },
                    { 9, new DateTime(2023, 6, 25, 13, 11, 43, 656, DateTimeKind.Local).AddTicks(2182), null, null, "Cole", 10, "Raul34@gmail.com", "Hodkiewicz - Hyatt", "Malcolm", "649-404-1676", "Hirthe", 1, "East Carolanne", "78112-9669" },
                    { 10, new DateTime(2023, 3, 13, 6, 0, 36, 510, DateTimeKind.Local).AddTicks(5366), null, null, "Kessler", 11, "Floy_Christiansen@gmail.com", "Legros - Blick", "Maci", "539.755.9221", "Schmitt", 1, "Maeganbury", "13609-5128" }
                });

            migrationBuilder.InsertData(
                table: "Modeles",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IdMarque", "Image", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 24, 6, 54, 57, 33, DateTimeKind.Local).AddTicks(1712), null, 9, "https://picsum.photos/640/480/?image=889", "Challenger", null },
                    { 2, new DateTime(2023, 5, 9, 11, 4, 50, 862, DateTimeKind.Local).AddTicks(2687), null, 3, "https://picsum.photos/640/480/?image=575", "Model T", null },
                    { 3, new DateTime(2022, 8, 17, 19, 57, 55, 183, DateTimeKind.Local).AddTicks(9951), null, 1, "https://picsum.photos/640/480/?image=349", "Focus", null },
                    { 4, new DateTime(2023, 1, 3, 1, 18, 19, 215, DateTimeKind.Local).AddTicks(3173), null, 6, "https://picsum.photos/640/480/?image=364", "XC90", null },
                    { 5, new DateTime(2022, 9, 26, 15, 4, 13, 243, DateTimeKind.Local).AddTicks(9727), null, 8, "https://picsum.photos/640/480/?image=587", "Mustang", null },
                    { 6, new DateTime(2022, 9, 10, 5, 4, 52, 200, DateTimeKind.Local).AddTicks(7034), null, 9, "https://picsum.photos/640/480/?image=372", "Grand Cherokee", null },
                    { 7, new DateTime(2022, 10, 22, 5, 22, 30, 501, DateTimeKind.Local).AddTicks(7361), null, 10, "https://picsum.photos/640/480/?image=870", "Focus", null },
                    { 8, new DateTime(2022, 10, 23, 7, 20, 48, 448, DateTimeKind.Local).AddTicks(453), null, 5, "https://picsum.photos/640/480/?image=151", "Fortwo", null },
                    { 9, new DateTime(2023, 6, 5, 19, 45, 2, 257, DateTimeKind.Local).AddTicks(3610), null, 8, "https://picsum.photos/640/480/?image=19", "Sentra", null },
                    { 10, new DateTime(2022, 9, 25, 19, 17, 46, 95, DateTimeKind.Local).AddTicks(9092), null, 2, "https://picsum.photos/640/480/?image=188", "Colorado", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 3, 14, 21, 50, 722, DateTimeKind.Local).AddTicks(3246), null, "Merle_Nitzsche@yahoo.com", "Francesca", 10, 1, false, "Kuhlman", "$2a$11$lYJ51LGmWiLOTOA5EV6xYu2yEpAGtoaZYa46IoGrfB84cBW5KVZlG", null },
                    { 2, new DateTime(2022, 11, 22, 14, 15, 29, 456, DateTimeKind.Local).AddTicks(5675), null, "Eliane.Beer@gmail.com", "Leonard", 7, 3, true, "Treutel", "$2a$11$uMBJwhYaK3YBX.g7t2tZsOlWOF/2ATGSuy2lsLPMv4cX0n7fa60Eu", null },
                    { 3, new DateTime(2022, 11, 2, 22, 26, 31, 452, DateTimeKind.Local).AddTicks(6812), null, "Maudie.Corwin19@gmail.com", "Terry", 9, 1, false, "Erdman", "$2a$11$FGfbcy6nVSmYiDKcafuUlOi5Oqk8qLNaG3YK7aIFey1eN3MFNuocu", null },
                    { 4, new DateTime(2023, 2, 1, 1, 23, 8, 801, DateTimeKind.Local).AddTicks(1438), null, "Sabrina_Murray87@gmail.com", "Cydney", 7, 3, true, "Schuster", "$2a$11$d7BekGMIu3LJAuZ1TY.JDOwz/2HK6ubCH3sUpwanFmednYSOwvG3e", null },
                    { 5, new DateTime(2023, 5, 2, 9, 16, 23, 439, DateTimeKind.Local).AddTicks(9114), null, "Jarrett91@yahoo.com", "Dallin", 4, 2, true, "Rutherford", "$2a$11$4aOhxaHVccKtjfuN8d0Sb.swJNFM4gAxQkJ2wTRusdcSrVB0x.iKu", null },
                    { 6, new DateTime(2022, 10, 29, 11, 17, 43, 742, DateTimeKind.Local).AddTicks(3711), null, "Flavie_Erdman@yahoo.com", "Ariel", 8, 4, false, "Klocko", "$2a$11$WhUNSxpngBclRn/VlN82Murp/PEnvfA/RgdOJ/O9kMVQ./wlKFwsW", null },
                    { 7, new DateTime(2022, 12, 11, 10, 43, 10, 552, DateTimeKind.Local).AddTicks(389), null, "Clementine95@hotmail.com", "Bianka", 1, 3, true, "Weber", "$2a$11$zn/bgJJFFtxuiFQvWwVJier70S63.1hmx47.RTVWbhxxoYkac4D3W", null },
                    { 8, new DateTime(2023, 5, 29, 22, 22, 16, 502, DateTimeKind.Local).AddTicks(3017), null, "Laverne.Flatley@hotmail.com", "Keanu", 9, 1, true, "Emmerich", "$2a$11$jkA9zmuLHlv2.JeP4hJbHOSCk7VchYCeSAmrGS5NC6qef1H8Foymq", null },
                    { 9, new DateTime(2023, 1, 21, 13, 2, 12, 957, DateTimeKind.Local).AddTicks(7921), null, "Juston.Bartell87@hotmail.com", "Elaina", 3, 3, true, "Lueilwitz", "$2a$11$r9T.NX78MQiSkUh1Ozkj2uEbJUeYcLBq7xmWDctPlw7Xx790Jpqyi", null },
                    { 10, new DateTime(2023, 3, 17, 16, 47, 37, 71, DateTimeKind.Local).AddTicks(914), null, "Colten52@yahoo.com", "Ahmed", 4, 3, true, "Cremin", "$2a$11$urH8f8wQmF9U8wGu1zyKTOr9qRKk4XLEQlCV7Oj3/ZoT4NrhW7beu", null }
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
                name: "long_term_rentals");

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
