using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AutomotiveApi.Migrations
{
    /// <inheritdoc />
    public partial class addpermissions : Migration
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
                name: "Permissions",
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
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    IdAgence = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Roles_id_agence",
                        column: x => x.IdAgence,
                        principalTable: "Agences",
                        principalColumn: "Id");
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
                name: "RolePermissions",
                columns: table => new
                {
                    IdRole = table.Column<int>(type: "int", nullable: false),
                    IdPermission = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermissions", x => new { x.IdRole, x.IdPermission });
                    table.ForeignKey(
                        name: "FK_RolePermission_id_permission",
                        column: x => x.IdPermission,
                        principalTable: "Permissions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RolePermission_id_role",
                        column: x => x.IdRole,
                        principalTable: "Roles",
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
                        name: "FK_Reservation_id_agence",
                        column: x => x.idAgence,
                        principalTable: "Agences",
                        principalColumn: "Id");
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
                    ReservationId = table.Column<int>(type: "int", nullable: true),
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
                    { 1, "5298 Nedra Summit", "Lonzostad", new DateTime(2023, 2, 4, 10, 44, 41, 471, DateTimeKind.Local).AddTicks(4091), null, "Nickolas63@hotmail.com", false, 73.305800000000005, 64.108099999999993, "Human Brand Liaison", "982.913.4565 x7745", null, "32663-5064" },
                    { 2, "228 Arely Ridges", "Trantowfort", new DateTime(2022, 12, 2, 23, 11, 46, 600, DateTimeKind.Local).AddTicks(6309), null, "Fanny_Mayer@yahoo.com", false, -78.6571, 179.90369999999999, "Product Group Analyst", "701.644.7807", null, "78270" },
                    { 3, "2610 Freeman Knolls", "West Roderick", new DateTime(2022, 10, 1, 0, 8, 58, 158, DateTimeKind.Local).AddTicks(4356), null, "Eula_Hermiston86@hotmail.com", false, 81.468100000000007, -131.78460000000001, "Chief Creative Architect", "297.808.9770 x1023", null, "98492" },
                    { 4, "170 Pat Village", "Deckowburgh", new DateTime(2023, 4, 11, 17, 57, 4, 82, DateTimeKind.Local).AddTicks(4833), null, "Evan_Swaniawski56@hotmail.com", false, 80.431299999999993, -21.928999999999998, "International Security Planner", "558-860-8448 x878", null, "22748" },
                    { 5, "809 Afton Pine", "Myrnaton", new DateTime(2023, 4, 10, 0, 45, 22, 755, DateTimeKind.Local).AddTicks(1651), null, "Salma31@gmail.com", false, 17.5959, -155.7671, "Forward Program Supervisor", "1-817-651-0985 x79906", null, "44277" },
                    { 6, "8654 Wolf Grove", "North Akeembury", new DateTime(2023, 3, 6, 3, 52, 27, 602, DateTimeKind.Local).AddTicks(3093), null, "Drew29@yahoo.com", false, 66.691999999999993, -54.575299999999999, "Global Brand Administrator", "604.323.9333", null, "53489-5328" },
                    { 7, "87481 Kraig Mount", "Bruentown", new DateTime(2022, 8, 14, 2, 23, 22, 264, DateTimeKind.Local).AddTicks(8763), null, "Saige68@hotmail.com", false, 18.3629, -151.92359999999999, "Global Intranet Developer", "(273) 265-3486 x2203", null, "52712" },
                    { 8, "330 McKenzie Pass", "Farrellview", new DateTime(2022, 11, 17, 20, 13, 0, 78, DateTimeKind.Local).AddTicks(8963), null, "Vergie.Rogahn@gmail.com", false, 66.033799999999999, 179.1309, "Principal Factors Orchestrator", "312.816.7300 x481", null, "71080-6651" },
                    { 9, "27580 Anderson Drive", "Bartonport", new DateTime(2023, 7, 20, 14, 35, 57, 766, DateTimeKind.Local).AddTicks(5669), null, "Paige_Macejkovic@gmail.com", false, -10.206099999999999, -27.2484, "Corporate Identity Manager", "780.737.3673 x059", null, "95681" },
                    { 10, "2527 Welch Port", "Kubmouth", new DateTime(2022, 12, 7, 22, 11, 57, 220, DateTimeKind.Local).AddTicks(8766), null, "Dannie.Mitchell28@yahoo.com", false, 44.079599999999999, -28.941299999999998, "District Program Officer", "(492) 214-8736", null, "57265-9913" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Adresse", "Adresse2", "CreatedAt", "DeletedAt", "Email", "FirstName", "LastName", "Password", "PermisRecto", "PermisVerso", "Tel", "UpdatedAt", "Ville", "ZipCode" },
                values: new object[,]
                {
                    { 1, "767 Bode Mission", "8790 Sterling Wall", new DateTime(2023, 7, 20, 10, 30, 11, 858, DateTimeKind.Local).AddTicks(8404), null, "Kolby13@hotmail.com", "Tyrique", "Hand", null, "https://picsum.photos/640/480/?image=132", "https://picsum.photos/640/480/?image=364", "997-972-5599", null, "South Zechariah", "61464" },
                    { 2, "5338 Joe Lodge", "0849 Murazik Green", new DateTime(2022, 11, 8, 22, 8, 7, 811, DateTimeKind.Local).AddTicks(3797), null, "Dante.Dicki37@gmail.com", "Astrid", "Hilll", null, "https://picsum.photos/640/480/?image=1000", "https://picsum.photos/640/480/?image=592", "908.995.1835 x76178", null, "Lake Clydebury", "47322-2828" },
                    { 3, "64117 Woodrow Rapid", "130 Weber Place", new DateTime(2022, 10, 7, 16, 19, 23, 34, DateTimeKind.Local).AddTicks(1848), null, "Ariane2@gmail.com", "Anika", "Tillman", null, "https://picsum.photos/640/480/?image=233", "https://picsum.photos/640/480/?image=817", "(742) 544-1261", null, "Lake Ferminbury", "56568-0810" },
                    { 4, "529 O'Reilly Plain", "9665 Davin Burg", new DateTime(2023, 3, 23, 14, 7, 43, 797, DateTimeKind.Local).AddTicks(8349), null, "Alberta.Olson70@yahoo.com", "Sarah", "McCullough", null, "https://picsum.photos/640/480/?image=966", "https://picsum.photos/640/480/?image=109", "708.636.6611 x706", null, "Port Baylee", "14748-6963" },
                    { 5, "79858 Bernice Cape", "813 Kasey Burgs", new DateTime(2022, 11, 8, 11, 57, 39, 379, DateTimeKind.Local).AddTicks(7828), null, "Sterling.Hickle@yahoo.com", "Alessia", "Smitham", null, "https://picsum.photos/640/480/?image=552", "https://picsum.photos/640/480/?image=837", "444-442-1948", null, "South Letha", "35868-8964" },
                    { 6, "2701 Francisca Fork", "088 Darron Ville", new DateTime(2023, 2, 1, 21, 47, 44, 264, DateTimeKind.Local).AddTicks(46), null, "Adalberto.Grady@yahoo.com", "Hosea", "Howe", null, "https://picsum.photos/640/480/?image=514", "https://picsum.photos/640/480/?image=940", "1-590-248-0726 x6618", null, "West Roycehaven", "50272-2533" },
                    { 7, "52422 Yundt Mill", "7075 D'Amore Brook", new DateTime(2022, 9, 22, 16, 24, 59, 456, DateTimeKind.Local).AddTicks(2009), null, "Mathilde.Cartwright16@gmail.com", "Lina", "Trantow", null, "https://picsum.photos/640/480/?image=1061", "https://picsum.photos/640/480/?image=12", "(610) 240-1353", null, "Waldoview", "88709-8886" },
                    { 8, "869 Fredrick Summit", "033 Brain Port", new DateTime(2023, 7, 21, 0, 44, 23, 309, DateTimeKind.Local).AddTicks(2139), null, "Camille63@yahoo.com", "Keith", "Christiansen", null, "https://picsum.photos/640/480/?image=158", "https://picsum.photos/640/480/?image=438", "774.948.2390", null, "Lake Deionview", "38210" },
                    { 9, "5797 Stacey Glen", "60058 Juana Ferry", new DateTime(2023, 4, 27, 13, 56, 50, 730, DateTimeKind.Local).AddTicks(2419), null, "Cristal_Krajcik70@hotmail.com", "Novella", "Satterfield", null, "https://picsum.photos/640/480/?image=134", "https://picsum.photos/640/480/?image=560", "(590) 800-2124", null, "Floborough", "55534-5936" },
                    { 10, "8808 Gleichner Mills", "0106 Auer Green", new DateTime(2023, 6, 29, 15, 58, 24, 406, DateTimeKind.Local).AddTicks(2982), null, "Lewis.Douglas@yahoo.com", "Eric", "Halvorson", null, "https://picsum.photos/640/480/?image=8", "https://picsum.photos/640/480/?image=859", "1-532-813-5030 x136", null, "Olgaport", "33706-3757" }
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
                table: "Permissions",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Users", null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Roles", null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Permissions", null },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Agences", null },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Marques", null },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Modeles", null },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Reservations", null },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Clients", null },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "LongTerm", null },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Vehicles", null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IdAgence", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "SuperAdmin", null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Admin", null }
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
                table: "RolePermissions",
                columns: new[] { "IdPermission", "IdRole", "CreatedAt", "DeletedAt", "Id", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null },
                    { 2, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, null },
                    { 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, null },
                    { 4, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, null },
                    { 7, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 6, 22, 53, 47, 164, DateTimeKind.Local).AddTicks(3450), null, "Orin_Weissnat@gmail.com", "Baylee", 6, 2, true, "Dare", "$2a$11$C0Mjq6NsxUM2w2vN7uzchuBX4g1.yJdifCN3CwZKcfqQCKFJdNsiS", null },
                    { 2, new DateTime(2022, 8, 3, 3, 55, 47, 583, DateTimeKind.Local).AddTicks(6988), null, "Jeanette.Harris@gmail.com", "Jessyca", 5, 1, true, "Quitzon", "$2a$11$NsOD7i7ZmbIlDa26MBKZS.xXEu0pSCcDEzQ17J1p3GwyIzHQaFDt2", null },
                    { 3, new DateTime(2022, 12, 28, 16, 19, 11, 506, DateTimeKind.Local).AddTicks(430), null, "Otto_Funk51@yahoo.com", "Maxie", 4, 2, false, "Feeney", "$2a$11$QsLi3zqwLE2ZM5Oboj2vOuOhI7xxjROlKI.Q1PRVv6GoxcpC0VcfO", null },
                    { 4, new DateTime(2022, 8, 22, 5, 23, 3, 116, DateTimeKind.Local).AddTicks(4289), null, "Viviane.Thiel41@gmail.com", "Morris", 8, 1, false, "Hessel", "$2a$11$IrGOOBLEZZ4AJaen/6uIP.WHGWbIbDF5Rmf8DJRtTv1zMdT/cGwYC", null },
                    { 5, new DateTime(2023, 5, 6, 22, 15, 38, 767, DateTimeKind.Local).AddTicks(2779), null, "Millie.OKon1@hotmail.com", "Leonie", 5, 1, false, "Weimann", "$2a$11$jRcwNsd7DjNVVNKaT0gFRu.2g/zSrhuxCJTmrD70SZTO9jC8p9cKi", null },
                    { 6, new DateTime(2022, 12, 23, 4, 24, 21, 793, DateTimeKind.Local).AddTicks(6756), null, "Larue_Hegmann@yahoo.com", "Hertha", 9, 1, true, "Stracke", "$2a$11$LNIsU0/EN6qdIzVuD9t7AOLpQ8V0/KbhqgVAyRlR4Pgy7ciDGlQIy", null },
                    { 7, new DateTime(2023, 4, 18, 13, 40, 57, 562, DateTimeKind.Local).AddTicks(312), null, "Enid12@yahoo.com", "Cathy", 2, 2, false, "Sipes", "$2a$11$Zd4j6lJvgOT4Zzn0xrdDMus2RqJ9akaXLX6.BhKpcZf9udZhdFUli", null },
                    { 8, new DateTime(2022, 12, 19, 22, 0, 32, 172, DateTimeKind.Local).AddTicks(1761), null, "Yasmine41@yahoo.com", "Amelia", 10, 1, true, "Cartwright", "$2a$11$XYBGall7ZLhiDW7/OsSg3uq/FPC1E.DA3oWybKuT3JapA.cTEihoC", null },
                    { 9, new DateTime(2022, 10, 12, 22, 1, 27, 400, DateTimeKind.Local).AddTicks(2287), null, "Marcelo51@hotmail.com", "Esta", 7, 2, true, "Shields", "$2a$11$dGCBAsVa4HKu2BbMKplbD.V9j3GBX23bsr1JF3PYzTMBdrsUd/ot2", null },
                    { 10, new DateTime(2022, 12, 5, 20, 45, 42, 5, DateTimeKind.Local).AddTicks(6106), null, "Terry_Walker@hotmail.com", "Sylvia", 7, 1, false, "Renner", "$2a$11$6B0SjOKkBPmayd8nkHZcNO4VIxwB/egrPCTQENtgcgbvHjHdBXO.a", null }
                });

            migrationBuilder.InsertData(
                table: "Vehicules",
                columns: new[] { "Id", "Airbag", "Climat", "CreatedAt", "DeletedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, false, true, new DateTime(2022, 8, 11, 1, 3, 56, 389, DateTimeKind.Local).AddTicks(2278), null, "efetqrwcpl", 8, 97, 5555, "jqsmkuklla", "itxkqwmnrq", "ngzzmbqcpi", 5, 7, 8.0, "tmycbeamqt", null },
                    { 2, false, false, new DateTime(2023, 7, 10, 11, 47, 6, 757, DateTimeKind.Local).AddTicks(214), null, "nfvetgyceh", 9, 87, 319, "sjbfslucqw", "xzyijklfaw", "guyvddmgrd", 7, 7, 3.0, "nfrgmdrmrb", null },
                    { 3, false, false, new DateTime(2022, 10, 7, 1, 23, 50, 201, DateTimeKind.Local).AddTicks(3883), null, "gurdtpbwmx", 10, 220, 8831, "jibsqmcoxb", "lgzblqqiak", "afsxhqnooh", 7, 7, 1.0, "cdlwmeiehf", null },
                    { 4, false, true, new DateTime(2022, 12, 27, 12, 40, 38, 56, DateTimeKind.Local).AddTicks(6377), null, "jtwmgnxdwe", 6, 216, 5963, "enjiyewxzo", "pgtbdouwpr", "eoovgtbhes", 8, 2, 8.0, "qvjspukjbn", null },
                    { 5, false, true, new DateTime(2023, 3, 20, 19, 12, 57, 665, DateTimeKind.Local).AddTicks(9894), null, "jytpjiziak", 1, 69, 11, "rwtkdgtnai", "ctryarvncl", "qhdgfwkile", 5, 10, 8.0, "agzqwyhjxd", null },
                    { 6, true, false, new DateTime(2022, 12, 12, 2, 35, 13, 885, DateTimeKind.Local).AddTicks(666), null, "bdrmahlzcr", 7, 243, 494, "ftaoejdewa", "qhhykxlsux", "urittdjjhf", 6, 6, 4.0, "flmzwttdvb", null },
                    { 7, true, true, new DateTime(2022, 10, 5, 1, 58, 24, 637, DateTimeKind.Local).AddTicks(7449), null, "jxhbkzcxvl", 1, 4, 6538, "gtnvgpqcdr", "isbpmtechu", "yhhpeqjkjy", 8, 5, 6.0, "kqtxhyfhkv", null },
                    { 8, true, false, new DateTime(2022, 8, 14, 10, 42, 22, 627, DateTimeKind.Local).AddTicks(1508), null, "zhoxppzamt", 8, 229, 7333, "ryhxupodzt", "uactxnejpo", "ygoljqhrip", 1, 9, 8.0, "fgsfjfcvws", null },
                    { 9, true, false, new DateTime(2023, 4, 29, 13, 11, 19, 464, DateTimeKind.Local).AddTicks(7710), null, "mikexzoxub", 9, 217, 6710, "zvgynmbico", "tdkezirhgc", "nguyvxlvlu", 5, 7, 8.0, "ugsfjmpzqy", null },
                    { 10, true, true, new DateTime(2023, 7, 18, 21, 52, 43, 277, DateTimeKind.Local).AddTicks(4986), null, "aldfuvwaqy", 3, 151, 9461, "mjjtagvooh", "aprvrzdlvq", "jxogkgxcbg", 10, 2, 6.0, "jdrdjvsxlo", null }
                });

            migrationBuilder.InsertData(
                table: "long_term_rentals",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IdModele", "NumeroReservation", "UpdatedAt", "description", "duree", "email", "entreprise", "idAgence", "nom", "phone", "prenom", "status", "ville", "zip" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 22, 3, 50, 13, 416, DateTimeKind.Local).AddTicks(4380), null, 231, "oekfywtrxi", null, "Marvin", 26, "RyanGosling@drive.com", "Zboncak - Cremin", null, "Dena", "(956) 662-6057 x7193", "Heidenreich", "Enattente", "East Ravenport", "41332" },
                    { 2, new DateTime(2023, 2, 16, 22, 32, 26, 456, DateTimeKind.Local).AddTicks(3146), null, 250, "awsdjnifoz", null, "Jenkins", 19, "RyanGosling@drive.com", "Bahringer Group", null, "Kaden", "532.996.7476", "Littel", "Enattente", "Faustoberg", "99517" },
                    { 3, new DateTime(2023, 1, 27, 22, 39, 35, 591, DateTimeKind.Local).AddTicks(1336), null, 206, "jmdmfxxiou", null, "Abbott", 20, "RyanGosling@drive.com", "Crooks - Wolff", null, "Tremayne", "786.809.2414", "Dach", "Enattente", "Lake Baron", "04783" },
                    { 4, new DateTime(2023, 2, 14, 9, 4, 47, 779, DateTimeKind.Local).AddTicks(3222), null, 308, "ewrtejvuwa", null, "Walter", 29, "RyanGosling@drive.com", "Stoltenberg, Brown and Ritchie", null, "Joyce", "(981) 638-4291 x50840", "Sanford", "Enattente", "Bayleefort", "63375" },
                    { 5, new DateTime(2023, 1, 2, 4, 23, 44, 788, DateTimeKind.Local).AddTicks(3010), null, 75, "cqznbtogua", null, "Aufderhar", 29, "RyanGosling@drive.com", "Lynch Inc", null, "Autumn", "1-726-741-9310 x034", "Auer", "Enattente", "Selinamouth", "32203" },
                    { 6, new DateTime(2023, 2, 1, 5, 25, 44, 332, DateTimeKind.Local).AddTicks(6519), null, 212, "rniyviellw", null, "Fisher", 30, "RyanGosling@drive.com", "Ebert LLC", null, "Lucas", "1-889-610-4094 x2621", "Hudson", "Enattente", "Prestonton", "39118" },
                    { 7, new DateTime(2023, 6, 2, 5, 46, 7, 272, DateTimeKind.Local).AddTicks(4211), null, 250, "zlkwfccijr", null, "Kulas", 20, "RyanGosling@drive.com", "Grant - Gleichner", null, "Bernie", "(487) 308-0198 x0268", "Lakin", "Enattente", "Lake Sally", "40690-1678" },
                    { 8, new DateTime(2023, 1, 18, 3, 17, 32, 693, DateTimeKind.Local).AddTicks(4949), null, 208, "xsjtvocgmk", null, "Dibbert", 20, "RyanGosling@drive.com", "Kshlerin, Runolfsson and Stokes", null, "Khalil", "(256) 841-4280 x9682", "Little", "Enattente", "Randallbury", "98315-0783" },
                    { 9, new DateTime(2022, 9, 1, 0, 42, 38, 187, DateTimeKind.Local).AddTicks(4208), null, 94, "zdkmogtyvk", null, "Tremblay", 20, "RyanGosling@drive.com", "King, Tromp and Leuschke", null, "Hope", "512.841.9832 x6951", "Zboncak", "Enattente", "New Arneborough", "27354" },
                    { 10, new DateTime(2022, 11, 4, 12, 48, 25, 458, DateTimeKind.Local).AddTicks(1540), null, 245, "yovmyqhuid", null, "Lemke", 25, "RyanGosling@drive.com", "Roberts Group", null, "Wilfrid", "316.938.0974 x853", "Murray", "Enattente", "Mosciskiland", "97946-7467" }
                });

            migrationBuilder.InsertData(
                table: "Offres",
                columns: new[] { "Id", "CreatedAt", "DateDebut", "DateFin", "DeletedAt", "IdVehicule", "Prix", "UpdatedAt", "isPublic" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 2, 0, 47, 0, 679, DateTimeKind.Local).AddTicks(5554), new DateTime(2023, 8, 3, 9, 14, 43, 291, DateTimeKind.Local).AddTicks(5103), new DateTime(2024, 2, 9, 4, 15, 8, 389, DateTimeKind.Local).AddTicks(1728), null, 7, 8.0, null, true },
                    { 2, new DateTime(2023, 8, 1, 20, 44, 54, 952, DateTimeKind.Local).AddTicks(4954), new DateTime(2023, 8, 3, 1, 25, 40, 366, DateTimeKind.Local).AddTicks(1522), new DateTime(2024, 3, 3, 4, 15, 17, 955, DateTimeKind.Local).AddTicks(5092), null, 6, 9.0, null, false },
                    { 3, new DateTime(2023, 8, 1, 17, 15, 21, 281, DateTimeKind.Local).AddTicks(9599), new DateTime(2023, 8, 3, 14, 19, 3, 558, DateTimeKind.Local).AddTicks(238), new DateTime(2024, 5, 30, 4, 48, 52, 658, DateTimeKind.Local).AddTicks(8641), null, 9, 3.0, null, false },
                    { 4, new DateTime(2023, 8, 2, 2, 3, 37, 976, DateTimeKind.Local).AddTicks(9597), new DateTime(2023, 8, 3, 0, 25, 22, 816, DateTimeKind.Local).AddTicks(6592), new DateTime(2023, 10, 3, 7, 53, 44, 946, DateTimeKind.Local).AddTicks(6587), null, 2, 6.0, null, true },
                    { 5, new DateTime(2023, 8, 2, 14, 20, 42, 472, DateTimeKind.Local).AddTicks(2550), new DateTime(2023, 8, 3, 6, 18, 48, 69, DateTimeKind.Local).AddTicks(5868), new DateTime(2023, 11, 27, 15, 33, 27, 554, DateTimeKind.Local).AddTicks(5263), null, 5, 2.0, null, true },
                    { 6, new DateTime(2023, 8, 2, 4, 59, 17, 871, DateTimeKind.Local).AddTicks(6621), new DateTime(2023, 8, 3, 5, 0, 56, 359, DateTimeKind.Local).AddTicks(5805), new DateTime(2023, 10, 11, 4, 24, 4, 616, DateTimeKind.Local).AddTicks(4911), null, 4, 10.0, null, true },
                    { 7, new DateTime(2023, 8, 1, 20, 43, 4, 186, DateTimeKind.Local).AddTicks(1231), new DateTime(2023, 8, 3, 14, 26, 58, 819, DateTimeKind.Local).AddTicks(6513), new DateTime(2023, 8, 7, 11, 28, 22, 94, DateTimeKind.Local).AddTicks(8597), null, 4, 4.0, null, false },
                    { 8, new DateTime(2023, 8, 1, 23, 19, 54, 384, DateTimeKind.Local).AddTicks(9865), new DateTime(2023, 8, 3, 5, 1, 43, 166, DateTimeKind.Local).AddTicks(7749), new DateTime(2023, 8, 28, 10, 2, 51, 46, DateTimeKind.Local).AddTicks(8871), null, 9, 3.0, null, true },
                    { 9, new DateTime(2023, 8, 2, 7, 41, 49, 556, DateTimeKind.Local).AddTicks(6183), new DateTime(2023, 8, 3, 13, 44, 41, 147, DateTimeKind.Local).AddTicks(2460), new DateTime(2024, 2, 3, 12, 49, 38, 224, DateTimeKind.Local).AddTicks(6503), null, 8, 7.0, null, true },
                    { 10, new DateTime(2023, 8, 2, 4, 33, 28, 469, DateTimeKind.Local).AddTicks(2129), new DateTime(2023, 8, 3, 7, 38, 31, 171, DateTimeKind.Local).AddTicks(7796), new DateTime(2023, 11, 12, 1, 59, 16, 402, DateTimeKind.Local).AddTicks(2330), null, 9, 3.0, null, false }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CreatedAt", "DateDepart", "DateRetour", "DeletedAt", "IdVehicule", "NumeroReservation", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 1, 18, 58, 44, 139, DateTimeKind.Local).AddTicks(6002), new DateTime(2023, 8, 3, 12, 42, 2, 95, DateTimeKind.Local).AddTicks(1323), new DateTime(2023, 8, 11, 18, 13, 53, 302, DateTimeKind.Local).AddTicks(6781), null, 10, "195c0755-c0c2-452c-9359-3ac967702049", "Annulé", null },
                    { 2, new DateTime(2023, 8, 1, 22, 2, 41, 68, DateTimeKind.Local).AddTicks(8882), new DateTime(2023, 8, 3, 14, 46, 29, 992, DateTimeKind.Local).AddTicks(5820), new DateTime(2023, 10, 11, 0, 58, 57, 571, DateTimeKind.Local).AddTicks(7569), null, 2, "0ca806a1-e1c8-4871-8fc0-26a1123acf29", "Expiré", null },
                    { 3, new DateTime(2023, 8, 2, 15, 46, 20, 408, DateTimeKind.Local).AddTicks(7296), new DateTime(2023, 8, 3, 15, 57, 38, 102, DateTimeKind.Local).AddTicks(4610), new DateTime(2023, 9, 4, 19, 58, 8, 461, DateTimeKind.Local).AddTicks(4151), null, 5, "6e14d54f-5c1e-4783-95d3-1d8892af3b42", "Confirmé", null },
                    { 4, new DateTime(2023, 8, 2, 11, 35, 5, 725, DateTimeKind.Local).AddTicks(6780), new DateTime(2023, 8, 2, 18, 26, 17, 434, DateTimeKind.Local).AddTicks(1305), new DateTime(2023, 8, 29, 9, 29, 25, 215, DateTimeKind.Local).AddTicks(1579), null, 3, "0f8ac749-18d0-402f-90f5-d512fb56d75b", "Enattente", null },
                    { 5, new DateTime(2023, 8, 1, 18, 15, 45, 680, DateTimeKind.Local).AddTicks(3575), new DateTime(2023, 8, 3, 11, 0, 49, 924, DateTimeKind.Local).AddTicks(4706), new DateTime(2023, 12, 17, 17, 58, 44, 375, DateTimeKind.Local).AddTicks(7218), null, 2, "a8f41841-dc4d-41cb-a4cb-a4847dbb66ee", "Annulé", null },
                    { 6, new DateTime(2023, 8, 1, 21, 54, 42, 847, DateTimeKind.Local).AddTicks(773), new DateTime(2023, 8, 2, 17, 31, 37, 967, DateTimeKind.Local).AddTicks(5952), new DateTime(2024, 1, 22, 15, 33, 52, 568, DateTimeKind.Local).AddTicks(3937), null, 3, "0fd939ac-75c9-4af4-86d8-6b645b7186f1", "Annulé", null },
                    { 7, new DateTime(2023, 8, 2, 16, 21, 34, 820, DateTimeKind.Local).AddTicks(9079), new DateTime(2023, 8, 2, 23, 14, 2, 807, DateTimeKind.Local).AddTicks(5469), new DateTime(2023, 12, 30, 1, 52, 42, 714, DateTimeKind.Local).AddTicks(6703), null, 6, "f9c513a9-3646-4a14-91a8-1e40c33265e1", "Confirmé", null },
                    { 8, new DateTime(2023, 8, 2, 11, 22, 14, 174, DateTimeKind.Local).AddTicks(5099), new DateTime(2023, 8, 3, 12, 58, 42, 972, DateTimeKind.Local).AddTicks(112), new DateTime(2024, 4, 1, 14, 8, 7, 891, DateTimeKind.Local).AddTicks(9848), null, 3, "6bfb2377-76a5-4e56-a615-77167ceb5ef1", "Annulé", null },
                    { 9, new DateTime(2023, 8, 1, 17, 30, 11, 694, DateTimeKind.Local).AddTicks(2192), new DateTime(2023, 8, 3, 5, 45, 12, 982, DateTimeKind.Local).AddTicks(7119), new DateTime(2023, 11, 30, 13, 2, 27, 895, DateTimeKind.Local).AddTicks(3868), null, 2, "39b5222e-ecfb-448e-bc5d-92a0b0239ec0", "Confirmé", null },
                    { 10, new DateTime(2023, 8, 2, 12, 32, 29, 917, DateTimeKind.Local).AddTicks(2782), new DateTime(2023, 8, 2, 20, 17, 10, 17, DateTimeKind.Local).AddTicks(988), new DateTime(2024, 3, 5, 6, 29, 59, 505, DateTimeKind.Local).AddTicks(9948), null, 2, "47225109-352c-4807-8334-37a677d844a2", "Expiré", null }
                });

            migrationBuilder.InsertData(
                table: "Contrats",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IdClient", "IdReservation", "IsConducteur", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, 5, true, null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 9, false, null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, 2, true, null },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 9, false, null },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 3, false, null },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 7, true, null },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, 7, true, null },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, 7, false, null },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, 5, false, null },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 5, false, null }
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
                name: "IX_long_term_rentals_idAgence",
                table: "long_term_rentals",
                column: "idAgence");

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
                name: "IX_RolePermissions_IdPermission",
                table: "RolePermissions",
                column: "IdPermission");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_IdAgence",
                table: "Roles",
                column: "IdAgence");

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
                name: "RolePermissions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "long_term_rentals");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Permissions");

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
