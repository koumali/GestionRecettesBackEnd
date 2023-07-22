using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AutomotiveApi.Migrations
{
    /// <inheritdoc />
    public partial class seedmarquemodeleimgs : Migration
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

            migrationBuilder.InsertData(
                table: "Agences",
                columns: new[] { "Id", "Address", "City", "CreatedAt", "DeletedAt", "Email", "IsVerified", "Latitude", "Longitude", "Name", "Tel", "UpdatedAt", "ZipCode" },
                values: new object[,]
                {
                    { 1, "2347 Howe Lights", "South Maybellbury", new DateTime(2023, 3, 20, 19, 13, 5, 44, DateTimeKind.Local).AddTicks(2901), null, "Madison52@gmail.com", false, -76.848799999999997, -141.97319999999999, "Customer Web Analyst", "402.748.9127 x969", null, "72024" },
                    { 2, "211 Donnelly Plaza", "Bettyburgh", new DateTime(2023, 6, 13, 4, 54, 29, 520, DateTimeKind.Local).AddTicks(3936), null, "Ashley_Hand60@yahoo.com", false, -71.048199999999994, 18.3992, "Dynamic Paradigm Officer", "1-992-587-8038 x583", null, "34649-7322" },
                    { 3, "4849 Buckridge Lock", "Port Rupertmouth", new DateTime(2023, 4, 1, 21, 14, 39, 304, DateTimeKind.Local).AddTicks(6488), null, "Tressa47@gmail.com", false, -24.936399999999999, 38.589300000000001, "Legacy Integration Planner", "(309) 741-6393 x80667", null, "85767-4683" },
                    { 4, "44708 Heidenreich Mission", "Sanfordchester", new DateTime(2023, 2, 8, 14, 9, 28, 608, DateTimeKind.Local).AddTicks(586), null, "Norbert84@gmail.com", false, -73.221999999999994, 122.9653, "Corporate Applications Officer", "1-529-432-3344", null, "25484" },
                    { 5, "951 Sigmund Spurs", "West Milton", new DateTime(2023, 4, 23, 7, 15, 33, 895, DateTimeKind.Local).AddTicks(5403), null, "Lorena55@gmail.com", false, -86.2517, -161.90280000000001, "International Paradigm Designer", "789.510.6665", null, "36182-2403" },
                    { 6, "719 Von Streets", "New Altown", new DateTime(2023, 2, 26, 7, 47, 14, 351, DateTimeKind.Local).AddTicks(8126), null, "Talon.Dicki67@yahoo.com", false, -52.242899999999999, 154.48240000000001, "Forward Quality Architect", "(295) 707-9461 x911", null, "26937-3754" },
                    { 7, "0725 Bernhard Village", "Wardhaven", new DateTime(2023, 2, 28, 19, 15, 23, 819, DateTimeKind.Local).AddTicks(3372), null, "Jeff82@gmail.com", false, -74.8399, 22.685600000000001, "Customer Directives Liaison", "(428) 986-6306 x7876", null, "63754-8485" },
                    { 8, "92997 Volkman Dale", "Halieton", new DateTime(2023, 2, 27, 16, 50, 59, 111, DateTimeKind.Local).AddTicks(6088), null, "Belle87@yahoo.com", false, -74.8476, 68.467799999999997, "Customer Functionality Associate", "486-795-4464 x7683", null, "20933" },
                    { 9, "0105 Connelly Mountain", "Meaganport", new DateTime(2022, 12, 27, 10, 1, 16, 636, DateTimeKind.Local).AddTicks(7975), null, "Elaina.Mosciski@yahoo.com", false, 41.432000000000002, -5.3098000000000001, "Future Functionality Planner", "(789) 262-1852", null, "15220-2391" },
                    { 10, "026 Elmo Ranch", "Hegmannville", new DateTime(2023, 7, 10, 19, 2, 22, 787, DateTimeKind.Local).AddTicks(2290), null, "Antonina.Koelpin50@yahoo.com", false, -15.1844, -136.9778, "Dynamic Security Associate", "1-773-838-3386 x1055", null, "37367" }
                });

            migrationBuilder.InsertData(
                table: "Marques",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ALFA-ROMEO", null },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ASTON-MARTIN", null },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "AUDI", null },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "BENTLEY", null },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "BMW", null },
                    { 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CHERY", null },
                    { 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CITROEN", null },
                    { 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "DACIA", null },
                    { 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "FERRARI", null },
                    { 34, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "FIAT", null },
                    { 35, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "FORD", null },
                    { 42, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "HONDA", null },
                    { 43, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "HYUNDAI", null },
                    { 45, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ISUZU", null },
                    { 47, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "JAGUAR", null },
                    { 48, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "JEEP", null },
                    { 50, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "KIA", null },
                    { 56, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "LAND-ROVER", null },
                    { 58, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "LEXUS", null },
                    { 63, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MAHINDRA", null },
                    { 67, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MAZDA", null },
                    { 69, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MERCEDES", null },
                    { 72, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MINI", null },
                    { 73, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MITSUBISHI", null },
                    { 75, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "NISSAN", null },
                    { 76, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OPEL", null },
                    { 77, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "PEUGEOT", null },
                    { 81, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "PORSCHE", null },
                    { 83, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "RENAULT", null },
                    { 88, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "SEAT", null },
                    { 91, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "SKODA", null },
                    { 94, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "SSANGYONG", null },
                    { 96, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "SUZUKI", null },
                    { 98, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "TATA", null },
                    { 99, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "TOYOTA", null },
                    { 103, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "VOLKSWAGEN", null },
                    { 104, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "VOLVO", null },
                    { 439, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "DS", null },
                    { 453, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ABARTH", null },
                    { 458, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "DFSK", null },
                    { 472, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "FOTON", null },
                    { 480, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CUPRA", null },
                    { 484, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "GAZ", null },
                    { 494, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "SERES", null },
                    { 510, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MG", null }
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
                    { 1, new DateTime(2022, 9, 6, 5, 13, 38, 787, DateTimeKind.Local).AddTicks(904), null, null, "Upton", 2, "Nicklaus.Gottlieb72@hotmail.com", "McCullough and Sons", "Gaston", "1-563-848-7685 x21599", "Schowalter", 1, "Mandymouth", "63672" },
                    { 2, new DateTime(2023, 1, 25, 9, 56, 8, 189, DateTimeKind.Local).AddTicks(8361), null, null, "Glover", 3, "Shayne.Crooks16@hotmail.com", "Corwin - Brakus", "Lea", "1-618-230-8902", "Grimes", 1, "South Reubenland", "39672" },
                    { 3, new DateTime(2022, 11, 2, 12, 7, 13, 285, DateTimeKind.Local).AddTicks(2725), null, null, "Larkin", 4, "Alek62@yahoo.com", "Koch - Wyman", "Madelyn", "(258) 856-4094 x62481", "Wisozk", 1, "Allenfort", "26095-0019" },
                    { 4, new DateTime(2023, 3, 19, 23, 4, 8, 473, DateTimeKind.Local).AddTicks(3130), null, null, "Ortiz", 5, "Dangelo.Jaskolski39@gmail.com", "Strosin - Pfannerstill", "Kelley", "(993) 656-3532 x962", "Beahan", 1, "Kihnburgh", "07641-4954" },
                    { 5, new DateTime(2022, 9, 20, 3, 29, 46, 678, DateTimeKind.Local).AddTicks(2632), null, null, "Kohler", 6, "Cayla72@gmail.com", "Schaden Group", "Kamren", "(938) 887-5654", "Wisoky", 1, "Flossieburgh", "71874" },
                    { 6, new DateTime(2023, 3, 17, 5, 48, 56, 247, DateTimeKind.Local).AddTicks(1689), null, null, "Collins", 7, "Lelia.Waelchi68@yahoo.com", "Heaney - Collins", "Emmanuel", "861.615.7621", "Rath", 1, "South Shanny", "73017" },
                    { 7, new DateTime(2023, 6, 15, 14, 59, 17, 74, DateTimeKind.Local).AddTicks(7321), null, null, "McClure", 8, "Brendan36@yahoo.com", "Goodwin - McClure", "Khalid", "1-432-811-4420 x1846", "Schultz", 1, "Lake Lucieview", "48157" },
                    { 8, new DateTime(2023, 3, 17, 13, 47, 11, 37, DateTimeKind.Local).AddTicks(9436), null, null, "Ernser", 9, "Valentine.Lockman36@gmail.com", "Bins, Koss and O'Kon", "Myrtice", "1-227-844-9586", "Hudson", 1, "Laynemouth", "82159" },
                    { 9, new DateTime(2022, 11, 8, 19, 46, 4, 601, DateTimeKind.Local).AddTicks(2163), null, null, "Christiansen", 10, "Javonte_Quigley@yahoo.com", "Denesik, O'Reilly and Schroeder", "Isac", "(203) 246-2333", "Nikolaus", 1, "Elmerfort", "05451-3980" },
                    { 10, new DateTime(2023, 4, 15, 7, 28, 43, 583, DateTimeKind.Local).AddTicks(9746), null, null, "Jenkins", 11, "Marco41@yahoo.com", "VonRueden and Sons", "Kole", "467.752.6573", "Stroman", 1, "North Dorothealand", "20512-3445" }
                });

            migrationBuilder.InsertData(
                table: "Modeles",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IdMarque", "Image", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "modeles/giulietta.png", "giulietta", null },
                    { 48, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, "modeles/vantage.png", "vantage", null },
                    { 54, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, "modeles/a1.png", "a1", null },
                    { 56, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, "modeles/a3.png", "a3", null },
                    { 57, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, "modeles/a4.png", "a4", null },
                    { 58, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, "modeles/a5-sportback.png", "a5 SPORTBACK", null },
                    { 59, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, "modeles/a6.png", "a6", null },
                    { 60, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, "modeles/a7.png", "a7", null },
                    { 61, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, "modeles/a8.png", "a8", null },
                    { 64, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, "modeles/q3.png", "q3", null },
                    { 65, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, "modeles/q5.png", "q5", null },
                    { 66, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, "modeles/q7.png", "q7", null },
                    { 67, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, "modeles/r8.png", "r8", null },
                    { 78, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, "modeles/tt.png", "tt", null },
                    { 89, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, "modeles/bentayga.png", "bentayga", null },
                    { 108, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, "modeles/m5.png", "m5", null },
                    { 110, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, "modeles/serie-1.png", "serie 1", null },
                    { 111, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, "modeles/serie-3.png", "serie 3", null },
                    { 113, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, "modeles/serie-5.png", "serie 5", null },
                    { 115, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, "modeles/serie-7.png", "serie 7", null },
                    { 116, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, "modeles/serie-8.png", "serie 8", null },
                    { 117, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, "modeles/x1.png", "x1", null },
                    { 118, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, "modeles/x3.png", "x3", null },
                    { 119, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, "modeles/x4.png", "x4", null },
                    { 120, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, "modeles/x5.png", "x5", null },
                    { 121, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, "modeles/x6.png", "x6", null },
                    { 124, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, "modeles/z4.png", "z4", null },
                    { 228, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, "modeles/berlingo.png", "berlingo", null },
                    { 231, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, "modeles/c-elysee.png", "c-elysee", null },
                    { 232, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, "modeles/c1.png", "c1", null },
                    { 236, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, "modeles/c3.png", "c3", null },
                    { 239, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, "modeles/c4.png", "c4", null },
                    { 252, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, "modeles/jumper.png", "jumper", null },
                    { 253, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, "modeles/jumpy.png", "jumpy", null },
                    { 254, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, "modeles/nemo.png", "nemo", null },
                    { 264, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, "modeles/duster.png", "duster", null },
                    { 265, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, "modeles/lodgy.png", "lodgy", null },
                    { 266, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, "modeles/logan.png", "logan", null },
                    { 347, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34, "modeles/500.png", "500", null },
                    { 357, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34, "modeles/doblo.jpg", "doblo", null },
                    { 359, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34, "modeles/fiorino.png", "fiorino", null },
                    { 367, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34, "modeles/panda.png", "panda", null },
                    { 377, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34, "modeles/tipo.png", "tipo", null },
                    { 382, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35, "modeles/c-max.png", "c max", null },
                    { 393, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35, "modeles/explorer.png", "explorer", null },
                    { 398, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35, "modeles/focus-5p.png", "focus 5p", null },
                    { 400, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35, "modeles/fusion.png", "fusion", null },
                    { 408, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35, "modeles/mustang.png", "mustang", null },
                    { 413, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35, "modeles/ranger.jpg", "ranger", null },
                    { 420, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35, "modeles/tourneo-connect.png", "tourneo connect", null },
                    { 421, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35, "modeles/transit.png", "transit", null },
                    { 448, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 42, "modeles/accord.png", "accord", null },
                    { 453, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 42, "modeles/civic.png", "civic", null },
                    { 455, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 42, "modeles/cr-v.png", "cr-v", null },
                    { 458, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 42, "modeles/hr-v.png", "hr-v", null },
                    { 470, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 43, "modeles/accent.png", "accent", null },
                    { 476, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 43, "modeles/creta.png", "creta", null },
                    { 477, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 43, "modeles/elantra.png", "elantra", null },
                    { 487, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 43, "modeles/i10.png", "i10", null },
                    { 488, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 43, "modeles/i20.png", "i20", null },
                    { 489, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 43, "modeles/i30.png", "i30", null },
                    { 496, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 43, "modeles/santa-fe.png", "santa fe", null },
                    { 499, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 43, "modeles/sonata.png", "sonata", null },
                    { 503, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 43, "modeles/tucson.png", "tucson", null },
                    { 518, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 45, "modeles/d-max.png", "d-max", null },
                    { 533, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 47, "modeles/f-type.png", "F-TYPE", null },
                    { 536, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 47, "modeles/xe.png", "xe", null },
                    { 537, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 47, "modeles/xf.png", "xf", null },
                    { 538, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 47, "modeles/xj.png", "xj", null },
                    { 545, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 48, "modeles/cherokee.png", "cherokee", null },
                    { 548, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 48, "modeles/compass.png", "compass", null },
                    { 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 48, "modeles/grand-cherokee.png", "grand cherokee", null },
                    { 555, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 48, "modeles/wrangler.png", "wrangler", null },
                    { 559, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50, "modeles/carens.png", "carens", null },
                    { 560, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50, "modeles/carnival.png", "carnival", null },
                    { 561, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50, "modeles/ceed.png", "ceed", null },
                    { 562, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50, "modeles/cerato.png", "cerato", null },
                    { 569, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50, "modeles/picanto.png", "picanto", null },
                    { 572, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50, "modeles/rio.png", "rio", null },
                    { 575, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50, "modeles/sorento.png", "sorento", null },
                    { 577, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50, "modeles/sportage.png", "sportage", null },
                    { 610, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 56, "modeles/defender.png", "defender", null },
                    { 611, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 56, "modeles/discovery.png", "discovery", null },
                    { 620, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 58, "modeles/is.png", "is", null },
                    { 621, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 58, "modeles/ls.png", "ls", null },
                    { 623, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 58, "modeles/rx.png", "rx", null },
                    { 645, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 63, "modeles/scorpio.jpg", "scorpio", null },
                    { 666, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 67, "modeles/6.png", "6", null },
                    { 672, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 67, "modeles/cx-3.png", "cx-3", null },
                    { 724, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 69, "modeles/classe-a.png", "classe a", null },
                    { 725, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 69, "modeles/classe-b.png", "classe b", null },
                    { 726, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 69, "modeles/classe-c.png", "classe c", null },
                    { 728, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 69, "modeles/cla.png", "cla", null },
                    { 731, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 69, "modeles/cls.png", "cls", null },
                    { 732, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 69, "modeles/classe-e.png", "classe e", null },
                    { 733, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 69, "modeles/classe-g.png", "classe g", null },
                    { 735, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 69, "modeles/gla.png", "gla", null },
                    { 736, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 69, "modeles/glc.png", "glc", null },
                    { 737, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 69, "modeles/gle.png", "gle", null },
                    { 741, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 69, "modeles/classe-s.png", "classe s", null },
                    { 743, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 69, "modeles/slc.png", "slc", null },
                    { 768, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 72, "modeles/clubman.png", "clubman", null },
                    { 770, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 72, "modeles/countryman.png", "countryman", null },
                    { 778, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 73, "modeles/l200.png", "l200", null },
                    { 783, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 73, "modeles/outlander.png", "outlander", null },
                    { 806, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 75, "modeles/juke.png", "juke", null },
                    { 811, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 75, "modeles/micra.png", "micra", null },
                    { 813, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 75, "modeles/navara.png", "navara", null },
                    { 821, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 75, "modeles/qashqai.png", "qashqai", null },
                    { 831, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 75, "modeles/x-trail.png", "x trail", null },
                    { 836, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 76, "modeles/astra.png", "astra", null },
                    { 846, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 76, "modeles/mokka.png", "mokka", null },
                    { 863, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 77, "modeles/2008.png", "2008", null },
                    { 873, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 77, "modeles/208.png", "208", null },
                    { 874, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 77, "modeles/3008.png", "3008", null },
                    { 875, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 77, "modeles/301.png", "301", null },
                    { 882, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 77, "modeles/308.png", "308", null },
                    { 894, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 77, "modeles/5008.png", "5008", null },
                    { 897, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 77, "modeles/508.png", "508", null },
                    { 903, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 77, "modeles/bipper.png", "bipper", null },
                    { 904, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 77, "modeles/boxer.png", "boxer", null },
                    { 905, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 77, "modeles/expert.png", "expert", null },
                    { 908, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 77, "modeles/partner.png", "partner", null },
                    { 936, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 81, "modeles/911.png", "911", null },
                    { 945, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 81, "modeles/cayenne.png", "cayenne", null },
                    { 947, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 81, "modeles/macan.png", "macan", null },
                    { 949, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 81, "modeles/panamera.png", "panamera", null },
                    { 964, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 83, "modeles/captur.png", "captur", null },
                    { 965, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 83, "modeles/clio.png", "clio", null },
                    { 968, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 83, "modeles/express.png", "express", null },
                    { 974, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 83, "modeles/kangoo.png", "kangoo", null },
                    { 975, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 83, "modeles/koleos.png", "koleos", null },
                    { 980, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 83, "modeles/master.png", "master", null },
                    { 981, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 83, "modeles/megane.png", "megane", null },
                    { 1004, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 83, "modeles/trafic.png", "trafic", null },
                    { 1043, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 88, "modeles/ibiza.png", "ibiza", null },
                    { 1045, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 88, "modeles/leon.png", "leon", null },
                    { 1063, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 91, "modeles/octavia.png", "octavia", null },
                    { 1066, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 91, "modeles/superb.png", "superb", null },
                    { 1079, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 94, "modeles/korando.png", "korando", null },
                    { 1082, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 94, "modeles/rexton.png", "rexton", null },
                    { 1084, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 94, "modeles/stavic.png", "stavic", null },
                    { 1097, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 96, "modeles/baleno.png", "baleno", null },
                    { 1101, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 96, "modeles/ignis.png", "ignis", null },
                    { 1102, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 96, "modeles/jimny.png", "jimny", null },
                    { 1107, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 96, "modeles/swift.png", "swift", null },
                    { 1109, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 96, "modeles/vitara.png", "vitara", null },
                    { 1118, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 98, "modeles/xenon.png", "xenon", null },
                    { 1120, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 99, "modeles/auris.png", "auris", null },
                    { 1132, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 99, "modeles/hilux.png", "hilux", null },
                    { 1134, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 99, "modeles/land-cruiser.png", "land cruiser", null },
                    { 1140, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 99, "modeles/prado.png", "prado", null },
                    { 1142, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 99, "modeles/prius.png", "prius", null },
                    { 1151, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 99, "modeles/yaris.png", "yaris", null },
                    { 1170, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 103, "modeles/amarok.png", "amarok", null },
                    { 1172, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 103, "modeles/caddy.png", "caddy", null },
                    { 1173, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 103, "modeles/caravelle.png", "caravelle", null },
                    { 1174, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 103, "modeles/coccinelle.png", "coccinelle", null },
                    { 1177, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 103, "modeles/crafter.png", "crafter", null },
                    { 1189, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 103, "modeles/jetta.png", "jetta", null },
                    { 1196, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 103, "modeles/passat.png", "passat", null },
                    { 1198, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 103, "modeles/polo.png", "polo", null },
                    { 1202, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 103, "modeles/tiguan.png", "tiguan", null },
                    { 1203, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 103, "modeles/touareg.png", "touareg", null },
                    { 1204, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 103, "modeles/touran.png", "touran", null },
                    { 1225, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 104, "modeles/s60.png", "s60", null },
                    { 1232, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 104, "modeles/xc60.png", "xc60", null },
                    { 1234, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 104, "modeles/xc90.png", "xc90", null },
                    { 7961, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 83, "modeles/kadjar.png", "kadjar", null },
                    { 7962, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 83, "modeles/talisman.png", "talisman", null },
                    { 10004, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34, "modeles/500c.png", "500c", null },
                    { 10008, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 67, "modeles/cx-5.png", "cx-5", null },
                    { 10009, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "modeles/giulia.png", "giulia ", null },
                    { 10010, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "modeles/4c.png", "4c", null },
                    { 10011, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, "modeles/serie-2.png", "serie 2", null },
                    { 10016, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 75, "modeles/evalia.png", "evalia", null },
                    { 10018, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 69, "modeles/classe-c-coupe.png", "Classe C Coupe", null },
                    { 10026, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34, "modeles/500x.png", "500x", null },
                    { 10039, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 48, "modeles/renegade.png", "renegade", null },
                    { 10040, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 56, "modeles/range-rover-vogue.png", "range rover vogue ", null },
                    { 10041, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 56, "modeles/range-rover-sport.png", "range rover sport ", null },
                    { 10042, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 56, "modeles/range-rover-evoque.png", "range rover evoque ", null },
                    { 10044, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 56, "modeles/discovery-sport.png", "discovery sport ", null },
                    { 10052, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, "modeles/q2.png", "q2", null },
                    { 10057, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 69, "modeles/classe-e-coupe.png", "classe e coupe", null },
                    { 10058, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 69, "modeles/gle-coupe.png", "gle coupe", null },
                    { 10059, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 69, "modeles/glc-coupe.png", "glc coupe", null },
                    { 10065, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 439, "modeles/ds4.png", "ds4 ", null },
                    { 10079, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 99, "modeles/c-hr.png", "c-hr", null },
                    { 10080, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 104, "modeles/s90.png", "s90", null },
                    { 10088, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 81, "modeles/718-cayman.png", "718 cayman", null },
                    { 10089, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 81, "modeles/718-boxster.png", "718 boxster", null },
                    { 10090, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 88, "modeles/mii.png", "mii", null },
                    { 10091, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 88, "modeles/ateca.png", "ateca", null },
                    { 10094, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 83, "modeles/megane-sedan.png", "megane sedan", null },
                    { 10097, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 77, "modeles/108.png", "108", null },
                    { 10098, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "modeles/stelvio.png", "stelvio", null },
                    { 10107, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34, "modeles/fullback.png", "fullback", null },
                    { 10108, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 69, "modeles/gls.png", "gls", null },
                    { 10109, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 56, "modeles/range-rover-velar.png", "range rover velar", null },
                    { 10112, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, "modeles/mulsanne.png", "mulsanne", null },
                    { 10113, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, "modeles/flying-spur.png", "flying spur", null },
                    { 10116, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 94, "modeles/tivoli.png", "tivoli", null },
                    { 10117, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 94, "modeles/xlv.png", "xlv", null },
                    { 10120, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 63, "modeles/xuv-500.jpg", "xuv 500", null },
                    { 10127, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 103, "modeles/arteon.png", "arteon ", null },
                    { 10131, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33, "modeles/812-superfast.png", "812 superfast", null },
                    { 10133, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33, "modeles/gtc4lusso.png", "gtc4lusso ", null },
                    { 10140, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 76, "modeles/crossland.png", "crossland", null },
                    { 10149, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 91, "modeles/kodiaq.png", "kodiaq", null },
                    { 10153, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, "modeles/x2.png", "x2", null },
                    { 10156, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 47, "modeles/e-pace.png", "e-pace", null },
                    { 10164, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35, "modeles/ecosport.png", "ecosport", null },
                    { 10165, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 99, "modeles/fortuner.png", "fortuner", null },
                    { 10166, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, "modeles/a3-berline.png", "a3 berline", null },
                    { 10167, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, "modeles/a5-coupe.png", "a5 coupe", null },
                    { 10182, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, "modeles/c3-aircross.png", "c3 aircross", null },
                    { 10186, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, "modeles/q8.png", "q8", null },
                    { 10188, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 104, "modeles/xc40.png", "xc40", null },
                    { 10210, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 453, "modeles/595.png", "595", null },
                    { 10214, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 91, "modeles/karoq.png", "karoq", null },
                    { 10216, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 76, "modeles/grandland.png", "grandland ", null },
                    { 10230, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 73, "modeles/pajero-sport.png", "pajero sport", null },
                    { 10232, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 43, "modeles/kona.png", "kona", null },
                    { 10238, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 58, "modeles/nx.png", "nx", null },
                    { 10242, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 96, "modeles/s-cross.png", "s-cross", null },
                    { 10243, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 103, "modeles/t-roc.png", "t-roc", null },
                    { 10253, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 58, "modeles/es.png", "es", null },
                    { 10256, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 76, "modeles/combo-life.png", "combo life", null },
                    { 10258, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 99, "modeles/corolla-sport.png", "corolla sport", null },
                    { 10259, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 99, "modeles/corolla-prestige.png", "corolla prestige", null },
                    { 10268, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, "modeles/c5-aircross.png", "c5 aircross", null },
                    { 10275, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 77, "modeles/rifter.png", "rifter", null },
                    { 10283, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 99, "modeles/new-rav4.png", "new rav4", null },
                    { 10298, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 58, "modeles/ux.png", "ux", null },
                    { 10299, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, "modeles/x7.png", "x7", null },
                    { 10300, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, "modeles/m2.png", "m2", null },
                    { 10307, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 47, "modeles/i-pace.png", "i-pace", null },
                    { 10311, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 63, "modeles/kuv-100.jpg", "kuv 100", null },
                    { 10324, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 458, "modeles/c31.jpg", "c31", null },
                    { 10344, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 81, "modeles/taycan.png", "taycan", null },
                    { 10348, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 458, "modeles/glory-580.png", "glory 580", null },
                    { 10354, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 76, "modeles/insignia-grand-sport.png", "insignia Grand Sport", null },
                    { 10357, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, "modeles/serie-2-gran-coupe.png", "serie 2 gran coupe", null },
                    { 10358, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, "modeles/serie-8-cabriolet.png", "serie 8 cabriolet", null },
                    { 10359, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50, "modeles/k2500.png", "k2500", null },
                    { 10360, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 69, "modeles/classe-a-berline.png", "classe a berline", null },
                    { 10362, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, "modeles/spacetourer.png", "spacetourer", null },
                    { 10364, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 77, "modeles/traveller.png", "traveller", null },
                    { 10366, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35, "modeles/transit-custom.png", "transit custom", null },
                    { 10370, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 76, "modeles/corsa.png", "corsa", null },
                    { 10372, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34, "modeles/tipo-hatchback.png", "tipo hatchback", null },
                    { 10374, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 88, "modeles/arona.png", "arona", null },
                    { 10380, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, "modeles/ami.png", "ami", null },
                    { 10381, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 72, "modeles/hatch-3-portes.png", "HATCH 3 portes", null },
                    { 10383, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 72, "modeles/hatch-5-portes.png", "HATCH 5 portes", null },
                    { 10393, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 453, "modeles/595-cabriolet.png", "595 cabriolet", null },
                    { 10395, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 42, "modeles/jazz.png", "jazz", null },
                    { 10421, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, "modeles/dbx.png", "dbx", null },
                    { 10428, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50, "modeles/seltos.png", "seltos", null },
                    { 10432, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, "modeles/q3-sportback.png", "q3 sportback", null },
                    { 10433, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50, "modeles/niro.png", "niro", null },
                    { 10434, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 458, "modeles/glory-ix5.png", "glory ix5", null },
                    { 10435, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35, "modeles/focus-4p.png", "focus 4P", null },
                    { 10436, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50, "modeles/k5.png", "k5", null },
                    { 10437, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, "modeles/e-tron.png", "e-tron", null },
                    { 10438, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 103, "modeles/golf-8.png", "golf 8", null },
                    { 10439, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 458, "modeles/k01h.png", "k01h", null },
                    { 10440, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 458, "modeles/k01l.png", "k01l", null },
                    { 10441, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 458, "modeles/k05.jpg", "k05", null },
                    { 10442, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 458, "modeles/c35.png", "c35", null },
                    { 10443, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 458, "modeles/super-cab.png", "super cab", null },
                    { 10444, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 458, "modeles/k01s.png", "k01s", null },
                    { 10445, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, "modeles/serie-4-gran-coupe.png", "serie 4 gran coupe", null },
                    { 10446, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35, "modeles/kuga.png", "kuga", null },
                    { 10447, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, "modeles/e-tron-sportback.png", "e-tron sportback", null },
                    { 10448, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 81, "modeles/cayenne-coupe.png", "cayenne coupe", null },
                    { 10449, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 47, "modeles/f-pace.png", "f-pace", null },
                    { 10451, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34, "modeles/talento.png", "talento", null },
                    { 10472, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, "modeles/dbs-supperleggera.png", "dbs supperleggera", null },
                    { 10474, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, "modeles/db11.png", "db11", null },
                    { 10529, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 77, "modeles/landtrek.png", "landtrek", null },
                    { 10549, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50, "modeles/stinger.png", "stinger", null },
                    { 10562, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 484, "modeles/next.png", "next", null },
                    { 10572, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 484, "modeles/next-van.png", "next van", null },
                    { 10588, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, "modeles/serie-4-cabriolet.png", "serie 4 cabriolet", null },
                    { 10589, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 83, "modeles/express-van.png", "express van", null },
                    { 10611, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, "modeles/serie-8-gran-coupe.png", "serie 8 gran coupe", null },
                    { 10613, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 72, "modeles/cabrio.png", "cabrio", null },
                    { 10614, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, "modeles/q5-sportback.png", "q5 sportback", null },
                    { 10633, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 494, "modeles/sf5.png", "sf5", null },
                    { 10634, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 494, "modeles/3.png", "3", null },
                    { 10647, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, "modeles/sandero-streetway.png", "sandero streetway", null },
                    { 10648, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, "modeles/sandero-stepway.png", "sandero stepway", null },
                    { 10658, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 98, "modeles/super-ace.png", "super ace", null },
                    { 10673, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 81, "modeles/taycan-cross-turismo.png", "taycan cross turismo", null },
                    { 10676, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 472, "modeles/tm.png", "tm", null },
                    { 10689, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, "modeles/ix.png", "ix", null },
                    { 10690, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, "modeles/i4.png", "i4", null },
                    { 10708, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50, "modeles/sonet.png", "sonet", null },
                    { 10715, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 99, "modeles/yaris-cross.png", "yaris cross", null },
                    { 10716, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, "modeles/tiggo-2-pro.png", "tiggo 2 pro", null },
                    { 10717, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, "modeles/tiggo-7-pro.png", "tiggo 7 pro", null },
                    { 10723, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, "modeles/tonale.png", "tonale", null },
                    { 10727, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, "modeles/spring.png", "spring", null },
                    { 10733, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, "modeles/tiggo-8-pro.png", "tiggo 8 pro", null },
                    { 10734, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, "modeles/tiggo-4-pro.png", "tiggo 4 pro", null },
                    { 10740, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50, "modeles/sportage-hybrid.png", "sportage hybrid", null },
                    { 10743, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 43, "modeles/ioniq-5.png", "ioniq 5", null },
                    { 10806, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 480, "modeles/formentor.png", "formentor", null },
                    { 10843, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 458, "modeles/glory-500.png", "glory 500", null },
                    { 10847, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 88, "modeles/tarraco.png", "tarraco", null },
                    { 10848, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50, "modeles/sorento-hybrid.png", "sorento hybrid", null },
                    { 10867, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 510, "modeles/mg-3.jpg", "MG 3", null },
                    { 10868, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 510, "modeles/mg4.png", "mg4", null },
                    { 10869, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 510, "modeles/mg-hs.png", "MG HS", null },
                    { 10870, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 510, "modeles/hs-phev.png", "hs Phev", null },
                    { 10871, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 510, "modeles/zs.png", "zs", null },
                    { 10872, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 510, "modeles/mg5.png", "mg5", null },
                    { 10873, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 439, "modeles/ds7.png", "ds7", null },
                    { 10874, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 510, "modeles/zs-ev.png", "zs-ev", null },
                    { 10882, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, "modeles/berlingo-vu.jpg", "berlingo vu", null },
                    { 10883, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, "modeles/c4-x.png", "c4 x", null },
                    { 10886, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 58, "modeles/rx-350h.png", "rx 350h", null },
                    { 10888, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 83, "modeles/arkana.png", "arkana", null },
                    { 10889, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 99, "modeles/new-corolla-x-air.png", "new corolla x air", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 4, 3, 44, 15, 400, DateTimeKind.Local).AddTicks(6183), null, "Felicity_Kreiger@yahoo.com", "Delphia", 8, 3, false, "VonRueden", "$2a$11$wo2P9BCtO8aY2lvzpKCM7OReseu9IUESMwO6exfHMzgkYH8ZOZgiK", null },
                    { 2, new DateTime(2023, 1, 12, 19, 22, 55, 267, DateTimeKind.Local).AddTicks(7691), null, "Margot_Kiehn@gmail.com", "Agustina", 9, 1, false, "Cremin", "$2a$11$icCuNmzrmmgar6peRnZBDOdnSWlY8ZDAbUXXve87ylLA9ou0yIcRS", null },
                    { 3, new DateTime(2023, 6, 14, 8, 44, 23, 909, DateTimeKind.Local).AddTicks(1843), null, "Cristian.Ziemann@gmail.com", "Anabel", 5, 4, true, "Schuster", "$2a$11$chRci31xC9q2lA/0/qsv9.pzba5X.48gFYff2UQlx8Yj5s4abOJye", null },
                    { 4, new DateTime(2022, 12, 20, 19, 5, 32, 186, DateTimeKind.Local).AddTicks(6299), null, "Amber.Breitenberg36@gmail.com", "Laurine", 2, 1, false, "Weber", "$2a$11$.Jz5cFxo8KWkBxAMGgxamOAcgIyqAJwangxdzbJkQ.mraIuVgSwaq", null },
                    { 5, new DateTime(2022, 9, 27, 15, 16, 42, 796, DateTimeKind.Local).AddTicks(2732), null, "Roberto.Hilll54@gmail.com", "Nolan", 10, 2, false, "Zulauf", "$2a$11$WTSqqxRa9hcI/osYgcr12OLxRYaQwGNNqlvuw6vP7taMScRvJ/CUe", null },
                    { 6, new DateTime(2023, 6, 22, 20, 35, 45, 209, DateTimeKind.Local).AddTicks(9796), null, "Savannah68@hotmail.com", "Fiona", 10, 1, false, "Metz", "$2a$11$X4V81utrlFlRdRnVimV.H.wC2Zpw/NnAIoRmWQvUrvtS3hJcP/Sce", null },
                    { 7, new DateTime(2023, 3, 7, 9, 8, 3, 952, DateTimeKind.Local).AddTicks(9706), null, "Emma_Tillman@hotmail.com", "Pietro", 6, 1, false, "Stark", "$2a$11$SUwAlmcAZTJAV6xVoxgWW./Hj2e8cm7jofLo/ptdMWDu00Qka/Acu", null },
                    { 8, new DateTime(2023, 7, 16, 12, 52, 39, 768, DateTimeKind.Local).AddTicks(230), null, "Abbey49@yahoo.com", "Chet", 4, 1, true, "Schmitt", "$2a$11$i3bivcd4c2IJyYiEZ.3E5eawXXvLYJin.fMM6c4e5r0F4By3VsHfK", null },
                    { 9, new DateTime(2022, 12, 19, 4, 36, 5, 751, DateTimeKind.Local).AddTicks(5478), null, "Ewald.Leffler64@gmail.com", "Rudy", 7, 2, false, "King", "$2a$11$VWTc9iGvMuq2LjmcPC/bbeDAIi0egySP.ThZHJMKQhvJWNpbfbNHG", null },
                    { 10, new DateTime(2023, 5, 15, 13, 5, 3, 358, DateTimeKind.Local).AddTicks(9311), null, "Jonathon_Quitzon72@gmail.com", "Chyna", 1, 2, true, "Goodwin", "$2a$11$lcfmhKKN/0MaKql0iaomwu1LFQkLWPxQx1zhZgTBMX1NnIU3xFMnC", null }
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
