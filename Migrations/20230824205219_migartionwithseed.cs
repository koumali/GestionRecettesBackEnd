using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AutomotiveApi.Migrations
{
    /// <inheritdoc />
    public partial class migartionwithseed : Migration
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
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    Logo = table.Column<string>(type: "longtext", nullable: true),
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
                    IsVerified = table.Column<bool>(type: "tinyint(1)", nullable: true),
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
                    IsVerified = table.Column<bool>(type: "tinyint(1)", nullable: true),
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
                    Gearbox = table.Column<string>(type: "longtext", nullable: false),
                    Moteur = table.Column<string>(type: "longtext", nullable: false),
                    Prix = table.Column<double>(type: "double", nullable: false),
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
                name: "AgenceLongTermRentals",
                columns: table => new
                {
                    AgenceId = table.Column<int>(type: "int", nullable: false),
                    LongTermRentalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgenceLongTermRentals", x => new { x.AgenceId, x.LongTermRentalId });
                    table.ForeignKey(
                        name: "FK_RolePermission_id_agence",
                        column: x => x.AgenceId,
                        principalTable: "Agences",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RolePermission_id_longTermRental",
                        column: x => x.LongTermRentalId,
                        principalTable: "long_term_rentals",
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
                    title = table.Column<string>(type: "longtext", nullable: false),
                    description = table.Column<string>(type: "longtext", nullable: false),
                    idAgence = table.Column<int>(type: "int", nullable: true),
                    idLongTermRental = table.Column<int>(type: "int", nullable: false),
                    isAgence = table.Column<bool>(type: "tinyint(1)", nullable: false),
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
                    MontantTotal = table.Column<double>(type: "double", nullable: false),
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
                columns: new[] { "Id", "Address", "City", "CreatedAt", "DeletedAt", "Email", "IsVerified", "Latitude", "Logo", "Longitude", "Name", "ParentId", "Tel", "UpdatedAt", "ZipCode" },
                values: new object[,]
                {
                    { 1, "961 Rosamond Cape", "Essaouira", new DateTime(2023, 1, 18, 19, 39, 17, 365, DateTimeKind.Local).AddTicks(4904), null, "David.Bruen65@gmail.com", false, -10.358599999999999, null, 110.3096, "Dynamic Creative Developer", null, "(811) 663-9853 x18021", null, "09094" },
                    { 2, "20773 Renner Tunnel", "Tinghir", new DateTime(2022, 11, 3, 3, 38, 42, 783, DateTimeKind.Local).AddTicks(2428), null, "Aiyana_OHara89@gmail.com", false, 56.718000000000004, null, 101.8951, "Customer Interactions Developer", null, "1-836-536-6582", null, "31210-8599" },
                    { 3, "136 Carroll Falls", "Chefchaouen", new DateTime(2023, 5, 16, 14, 38, 34, 550, DateTimeKind.Local).AddTicks(4133), null, "Jaqueline21@yahoo.com", false, 51.052300000000002, null, 22.684999999999999, "Internal Applications Assistant", null, "(559) 236-7888 x0298", null, "86506-0827" },
                    { 4, "928 Purdy Land", "Tinghir", new DateTime(2023, 3, 9, 9, 43, 53, 938, DateTimeKind.Local).AddTicks(9309), null, "Donato_Reinger26@hotmail.com", false, -51.930500000000002, null, -143.4743, "Central Web Officer", null, "286-881-0534", null, "63149" },
                    { 5, "0604 Jerad Cape", "Safi", new DateTime(2023, 5, 25, 23, 30, 5, 361, DateTimeKind.Local).AddTicks(4139), null, "Norris.Deckow43@yahoo.com", false, 17.687200000000001, null, 149.2662, "Internal Integration Representative", null, "(951) 213-2709", null, "82968" },
                    { 6, "5460 Marie Mountains", "Casablanca", new DateTime(2022, 11, 16, 19, 10, 28, 96, DateTimeKind.Local).AddTicks(8825), null, "Winnifred95@gmail.com", false, 37.734200000000001, null, -52.897399999999998, "District Usability Administrator", null, "1-697-408-2494 x2965", null, "04772-3115" },
                    { 7, "493 Camryn Landing", "Marrakech", new DateTime(2023, 4, 19, 10, 23, 41, 847, DateTimeKind.Local).AddTicks(4434), null, "Madisen_Jones83@yahoo.com", false, -81.011600000000001, null, 88.531300000000002, "District Interactions Planner", null, "354-357-7815", null, "06511-5705" },
                    { 8, "531 Gulgowski Plains", "Chefchaouen", new DateTime(2023, 6, 19, 1, 55, 40, 414, DateTimeKind.Local).AddTicks(2331), null, "Cristopher.Howe@yahoo.com", false, 78.594499999999996, null, 39.233899999999998, "Investor Program Agent", null, "491-658-3500 x42939", null, "10933-5078" },
                    { 9, "93950 Pacocha Unions", "Marrakech", new DateTime(2022, 10, 30, 9, 25, 57, 865, DateTimeKind.Local).AddTicks(9298), null, "Lukas.Little37@yahoo.com", false, 67.213099999999997, null, -35.776699999999998, "Customer Directives Planner", null, "(860) 662-2143 x89324", null, "13694-5230" },
                    { 10, "255 Towne Mount", "Safi", new DateTime(2023, 2, 16, 17, 51, 3, 533, DateTimeKind.Local).AddTicks(9652), null, "Jaleel.Bernier@hotmail.com", false, 38.743400000000001, null, -62.353099999999998, "Investor Creative Engineer", null, "792-459-1003 x110", null, "18916-0691" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Adresse", "Adresse2", "CreatedAt", "DeletedAt", "Email", "FirstName", "IsVerified", "LastName", "Password", "PermisRecto", "PermisVerso", "Tel", "UpdatedAt", "Ville", "ZipCode" },
                values: new object[,]
                {
                    { 1, "37098 Turcotte Underpass", "90929 Clementine Expressway", new DateTime(2023, 4, 6, 15, 37, 19, 67, DateTimeKind.Local).AddTicks(2287), null, "Carlotta_Jacobi@gmail.com", "Denis", false, "Kilback", null, "https://picsum.photos/640/480/?image=739", "https://picsum.photos/640/480/?image=1069", "(312) 204-1431", null, "South Candida", "51049" },
                    { 2, "4918 Claudie Mountain", "44470 Martina Forks", new DateTime(2023, 5, 10, 22, 14, 0, 324, DateTimeKind.Local).AddTicks(7291), null, "Doug_Brakus@yahoo.com", "Raleigh", false, "Mertz", null, "https://picsum.photos/640/480/?image=572", "https://picsum.photos/640/480/?image=117", "1-206-813-5230 x3493", null, "Goyettestad", "68444" },
                    { 3, "035 Barrows Inlet", "2282 Okuneva Spring", new DateTime(2023, 2, 26, 23, 34, 57, 83, DateTimeKind.Local).AddTicks(6745), null, "Jabari.Nader@hotmail.com", "Rocio", false, "Schaden", null, "https://picsum.photos/640/480/?image=452", "https://picsum.photos/640/480/?image=992", "447.565.5870", null, "Port Anissaville", "23966-7062" },
                    { 4, "0210 Skiles Turnpike", "36122 O'Reilly Square", new DateTime(2022, 10, 21, 8, 45, 48, 861, DateTimeKind.Local).AddTicks(8200), null, "Alysha_Kunze@yahoo.com", "Lacey", false, "Hartmann", null, "https://picsum.photos/640/480/?image=584", "https://picsum.photos/640/480/?image=1032", "1-604-787-2529 x52925", null, "Lake Kelleyside", "93987-8752" },
                    { 5, "869 Grimes Ridges", "434 Garrett Haven", new DateTime(2023, 7, 31, 15, 42, 27, 250, DateTimeKind.Local).AddTicks(5893), null, "Evert.Schmidt89@hotmail.com", "Audrey", false, "Rau", null, "https://picsum.photos/640/480/?image=321", "https://picsum.photos/640/480/?image=824", "1-420-562-0371", null, "North Murphy", "89617-4976" },
                    { 6, "134 Schuster Course", "1133 Hyman Forest", new DateTime(2023, 6, 11, 14, 38, 16, 539, DateTimeKind.Local).AddTicks(7499), null, "Isidro.Wintheiser@gmail.com", "Orrin", false, "Smitham", null, "https://picsum.photos/640/480/?image=558", "https://picsum.photos/640/480/?image=279", "242.852.5437 x456", null, "Lake Oral", "03113-9463" },
                    { 7, "5476 Hauck Spring", "401 Tremblay Mount", new DateTime(2023, 1, 31, 18, 23, 48, 939, DateTimeKind.Local).AddTicks(116), null, "Luciano_Conn@gmail.com", "Ally", false, "Kuhic", null, "https://picsum.photos/640/480/?image=815", "https://picsum.photos/640/480/?image=887", "1-263-430-4685 x574", null, "East Amir", "25799" },
                    { 8, "665 Erdman Terrace", "1757 Einar Flat", new DateTime(2023, 3, 4, 16, 20, 39, 687, DateTimeKind.Local).AddTicks(1184), null, "Chanelle.Lueilwitz26@gmail.com", "Eliseo", false, "Gerhold", null, "https://picsum.photos/640/480/?image=824", "https://picsum.photos/640/480/?image=1037", "1-985-624-7759", null, "Roslynbury", "62764-2398" },
                    { 9, "9675 Bernier Ranch", "42397 Windler Ramp", new DateTime(2023, 7, 22, 12, 21, 49, 690, DateTimeKind.Local).AddTicks(9293), null, "Felipe16@hotmail.com", "Karen", false, "Streich", null, "https://picsum.photos/640/480/?image=861", "https://picsum.photos/640/480/?image=978", "573.369.0743 x783", null, "Blickborough", "67386" },
                    { 10, "173 Murphy Plaza", "7052 Corwin Viaduct", new DateTime(2022, 8, 31, 17, 38, 52, 944, DateTimeKind.Local).AddTicks(7091), null, "Lacy.Hand58@gmail.com", "Beau", false, "Bruen", null, "https://picsum.photos/640/480/?image=610", "https://picsum.photos/640/480/?image=140", "483.529.0279", null, "South Stan", "20678" }
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
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Dashboard", null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Users", null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Roles", null },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Permissions", null },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Agences", null },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Marques", null },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Modeles", null },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Reservations", null },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Clients", null },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "LongTerm", null },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Vehicles", null },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Offres", null },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "LogJournal", null }
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
                    { 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null },
                    { 2, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null },
                    { 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null },
                    { 4, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null },
                    { 5, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null },
                    { 6, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null },
                    { 7, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null },
                    { 13, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null },
                    { 2, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null },
                    { 3, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null },
                    { 4, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null },
                    { 8, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null },
                    { 9, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null },
                    { 10, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null },
                    { 11, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null },
                    { 12, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "IsVerified", "LastName", "Password", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 10, 13, 6, 44, 401, DateTimeKind.Local).AddTicks(9349), null, "Evan6@gmail.com", "Jessy", 7, 1, true, false, "Cassin", "$2a$11$.9EgvL7g3PJgSutaiOu/UOuFm1Gsy5juxu81lHjY/kopvkhzt1/aG", null },
                    { 2, new DateTime(2022, 11, 9, 19, 34, 8, 624, DateTimeKind.Local).AddTicks(1566), null, "Ruby93@gmail.com", "Claude", 6, 1, false, false, "Kovacek", "$2a$11$npiaq4qjFxsnqF2glwL4tuTnqyrXgRe1D.5SvHCER.EkDMLVhwpgm", null },
                    { 3, new DateTime(2023, 7, 12, 6, 57, 17, 18, DateTimeKind.Local).AddTicks(6423), null, "Mittie.Hauck@gmail.com", "Flo", 7, 2, true, false, "Kuhic", "$2a$11$2SZf/pdCXScg8HvPxP3ubOGQ48ACW54ssEaTsGMgboj/CpZo757dC", null },
                    { 4, new DateTime(2023, 3, 7, 4, 28, 22, 520, DateTimeKind.Local).AddTicks(9602), null, "Mallie_Schroeder16@gmail.com", "Max", 7, 2, false, false, "Morar", "$2a$11$cCTKHfMEcgmz9uprFnBzD.IyB0EeiO.42Lfy8BsAgzTa8zT2R2Wti", null },
                    { 5, new DateTime(2023, 8, 6, 1, 45, 8, 127, DateTimeKind.Local).AddTicks(7672), null, "Norwood_Frami@hotmail.com", "Doris", 8, 1, true, false, "White", "$2a$11$IAOslXdnQLDGywJSQR1FRutBRNI.sHQ3r8rJyE/SE5cw78sEZg6/O", null },
                    { 6, new DateTime(2022, 10, 20, 7, 6, 20, 270, DateTimeKind.Local).AddTicks(1014), null, "Landen.Nader@hotmail.com", "Russel", 8, 1, true, false, "Reichert", "$2a$11$WZnbBcmMAwh.NNz54IfOl.3kjQ6IWzHJ6q0GPTIXp3GzWrkVIAh/C", null },
                    { 7, new DateTime(2023, 1, 26, 16, 49, 55, 675, DateTimeKind.Local).AddTicks(4708), null, "Benton74@hotmail.com", "Yasmeen", 5, 2, true, false, "Schuster", "$2a$11$kMrHmQzsJNQu8p73426TQuRyjLdSMpAe2P7wovEpmkWWyM6kdAQzS", null },
                    { 8, new DateTime(2023, 5, 13, 14, 53, 20, 517, DateTimeKind.Local).AddTicks(8667), null, "Chelsea39@yahoo.com", "Milton", 10, 1, true, false, "Ziemann", "$2a$11$zNhp37vgJxSB1wsTlsKTX.unCkHLLzrzxga2VVve7Ouuqu80mNreO", null },
                    { 9, new DateTime(2023, 8, 23, 18, 29, 41, 647, DateTimeKind.Local).AddTicks(8423), null, "Jamal.Powlowski@gmail.com", "Lambert", 9, 2, false, false, "Ankunding", "$2a$11$wQFDs1pOUSrM60thpwymsuZaZ/Aq7MHCAyhD75c0IcUXJ9TAZcyqm", null },
                    { 10, new DateTime(2023, 2, 28, 12, 52, 48, 873, DateTimeKind.Local).AddTicks(4518), null, "Gino32@gmail.com", "David", 8, 1, true, false, "Miller", "$2a$11$vFFnAZ4ZvRE387bPWj7HiuPsXeSyWRN/Cf0NoVHW1ukPBwaGDfO1y", null }
                });

            migrationBuilder.InsertData(
                table: "Vehicules",
                columns: new[] { "Id", "Airbag", "Climat", "CreatedAt", "DeletedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, false, true, new DateTime(2023, 4, 7, 18, 9, 6, 616, DateTimeKind.Local).AddTicks(7572), null, "Diesel", 4, 131, 4880, "suxpxcvnbg", "Automatique", "ktcnhvichm", 4, 4, 299.0, "egwywqdjzz", null },
                    { 2, true, false, new DateTime(2023, 6, 8, 13, 32, 6, 112, DateTimeKind.Local).AddTicks(3866), null, "Hybride", 7, 84, 796, "vtxndoqszq", "Manuelle", "lcgyjmstyf", 4, 10, 385.0, "xqyqvpfyrn", null },
                    { 3, false, false, new DateTime(2023, 4, 14, 1, 41, 2, 609, DateTimeKind.Local).AddTicks(3334), null, "Essence", 3, 66, 5089, "vmvwhzghqp", "Manuelle", "erbaldrkss", 6, 4, 239.0, "jpajcsbelg", null },
                    { 4, false, false, new DateTime(2023, 7, 25, 16, 48, 14, 201, DateTimeKind.Local).AddTicks(5874), null, "Essence", 7, 261, 7738, "yyttzekduu", "Automatique", "znlkrbyfin", 1, 8, 475.0, "gqtcfcfcmx", null },
                    { 5, false, false, new DateTime(2023, 2, 26, 15, 1, 29, 568, DateTimeKind.Local).AddTicks(8494), null, "Essence", 9, 278, 3368, "xxsepjfovc", "Manuelle", "hpzteekdzb", 2, 4, 294.0, "uutnkiizsj", null },
                    { 6, true, true, new DateTime(2023, 8, 19, 18, 46, 46, 801, DateTimeKind.Local).AddTicks(6497), null, "Essence", 7, 17, 3770, "tjgpaqgsxk", "Automatique", "ksdgweakpt", 7, 3, 437.0, "gqmvbnwrcg", null },
                    { 7, false, false, new DateTime(2022, 11, 23, 16, 5, 21, 794, DateTimeKind.Local).AddTicks(7950), null, "Diesel", 8, 48, 9610, "txysxlnfch", "Manuelle", "qstfedvepj", 6, 7, 418.0, "jtuiaiaclq", null },
                    { 8, true, true, new DateTime(2023, 4, 27, 5, 16, 31, 773, DateTimeKind.Local).AddTicks(4999), null, "Électrique", 2, 313, 5651, "dxxpqapvml", "Manuelle", "survrbrzpo", 1, 7, 422.0, "jhvkvggjol", null },
                    { 9, false, true, new DateTime(2023, 1, 1, 6, 29, 52, 874, DateTimeKind.Local).AddTicks(63), null, "Hybride", 2, 276, 1351, "edrwyiphmu", "Automatique", "nejtozubog", 2, 8, 481.0, "kexoodkmqr", null },
                    { 10, false, true, new DateTime(2023, 8, 13, 12, 42, 22, 887, DateTimeKind.Local).AddTicks(5092), null, "Essence", 1, 275, 93, "zvtvedisee", "Automatique", "ailtqzjtmb", 8, 2, 289.0, "mpxczqsgyv", null }
                });

            migrationBuilder.InsertData(
                table: "long_term_rentals",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "Prix", "UpdatedAt", "description", "duree", "email", "entreprise", "idAgence", "nom", "phone", "prenom", "status", "ville", "zip" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 18, 20, 38, 42, 528, DateTimeKind.Local).AddTicks(961), null, "Diesel", 19, "Manuelle", "cdbodvswlg", 249.0, null, "O'Hara", 26, "RyanGosling@drive.com", "Pfannerstill, Kerluke and Kutch", null, "Selena", "714-955-0481 x6264", "Vandervort", "Enattente", "Roselynview", "14466-8940" },
                    { 2, new DateTime(2023, 8, 14, 7, 22, 34, 58, DateTimeKind.Local).AddTicks(6008), null, "Hybride", 215, "Automatique", "xkdybvssky", 344.0, null, "Schinner", 21, "RyanGosling@drive.com", "O'Connell and Sons", null, "Wilford", "1-463-285-2754 x12246", "Dickinson", "Enattente", "Kirlinberg", "21498" },
                    { 3, new DateTime(2022, 11, 29, 7, 24, 19, 293, DateTimeKind.Local).AddTicks(7363), null, "Électrique", 270, "Automatique", "lmdxtezbkw", 296.0, null, "Mayert", 20, "RyanGosling@drive.com", "Blick, Senger and Hane", null, "Raegan", "1-827-444-4870 x6782", "Gutkowski", "Enattente", "New Zetta", "20051-8043" },
                    { 4, new DateTime(2023, 1, 14, 5, 39, 8, 68, DateTimeKind.Local).AddTicks(7380), null, "Électrique", 84, "Manuelle", "dktjsrcwjq", 264.0, null, "Hartmann", 29, "RyanGosling@drive.com", "Gulgowski Group", null, "Jessyca", "866.617.5858", "Reynolds", "Enattente", "South Markuschester", "67823" },
                    { 5, new DateTime(2022, 11, 17, 9, 44, 15, 490, DateTimeKind.Local).AddTicks(7353), null, "Diesel", 103, "Automatique", "jijrranpps", 337.0, null, "Stroman", 29, "RyanGosling@drive.com", "Smith Group", null, "Arlie", "1-833-866-9677", "Rolfson", "Enattente", "Schummstad", "22997-2886" },
                    { 6, new DateTime(2023, 7, 18, 17, 24, 9, 436, DateTimeKind.Local).AddTicks(7423), null, "Essence", 256, "Automatique", "rxuyvsnxxe", 300.0, null, "Gutkowski", 28, "RyanGosling@drive.com", "Muller - Gottlieb", null, "Savanna", "1-223-567-7719 x69935", "Kirlin", "Enattente", "West Vidal", "45439" },
                    { 7, new DateTime(2023, 5, 16, 23, 17, 18, 33, DateTimeKind.Local).AddTicks(7404), null, "Essence", 122, "Automatique", "jgggyzxvfh", 343.0, null, "Hand", 32, "RyanGosling@drive.com", "O'Connell and Sons", null, "Valentina", "416.631.0244 x516", "Hackett", "Enattente", "Krisbury", "36946" },
                    { 8, new DateTime(2022, 12, 4, 21, 4, 53, 620, DateTimeKind.Local).AddTicks(7762), null, "Diesel", 282, "Manuelle", "giefrzdnig", 221.0, null, "Yost", 23, "RyanGosling@drive.com", "Cremin, Schultz and Wilkinson", null, "Madaline", "1-263-257-9564", "Gislason", "Enattente", "Lake Peteborough", "86502-8611" },
                    { 9, new DateTime(2022, 10, 6, 9, 57, 6, 815, DateTimeKind.Local).AddTicks(9319), null, "Essence", 22, "Manuelle", "leuxufmgux", 399.0, null, "Fay", 27, "RyanGosling@drive.com", "Wolf, Langosh and Hermiston", null, "Marshall", "1-511-801-3195 x2971", "Lebsack", "Enattente", "Kaitlinshire", "71065" },
                    { 10, new DateTime(2022, 9, 2, 16, 9, 4, 944, DateTimeKind.Local).AddTicks(2692), null, "Électrique", 113, "Automatique", "jnpiehnwew", 368.0, null, "Bins", 25, "RyanGosling@drive.com", "Kulas, Beier and Weimann", null, "Antonetta", "1-764-751-5639", "Kuhlman", "Enattente", "Wizafort", "15100" }
                });

            migrationBuilder.InsertData(
                table: "Offres",
                columns: new[] { "Id", "CreatedAt", "DateDebut", "DateFin", "DeletedAt", "IdVehicule", "Prix", "UpdatedAt", "isPublic" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 24, 2, 15, 3, 138, DateTimeKind.Local).AddTicks(4196), new DateTime(2023, 8, 25, 18, 50, 4, 27, DateTimeKind.Local).AddTicks(3126), new DateTime(2024, 2, 21, 21, 6, 43, 195, DateTimeKind.Local).AddTicks(2731), null, 1, 231.0, null, true },
                    { 2, new DateTime(2023, 8, 24, 6, 9, 1, 676, DateTimeKind.Local).AddTicks(8240), new DateTime(2023, 8, 25, 6, 28, 18, 190, DateTimeKind.Local).AddTicks(8527), new DateTime(2024, 6, 9, 16, 47, 27, 230, DateTimeKind.Local).AddTicks(1248), null, 1, 384.0, null, false },
                    { 3, new DateTime(2023, 8, 24, 9, 24, 12, 391, DateTimeKind.Local).AddTicks(4101), new DateTime(2023, 8, 25, 8, 25, 41, 740, DateTimeKind.Local).AddTicks(3444), new DateTime(2024, 6, 3, 15, 12, 55, 53, DateTimeKind.Local).AddTicks(6200), null, 10, 442.0, null, false },
                    { 4, new DateTime(2023, 8, 24, 20, 18, 12, 670, DateTimeKind.Local).AddTicks(6998), new DateTime(2023, 8, 25, 11, 35, 35, 463, DateTimeKind.Local).AddTicks(8870), new DateTime(2024, 3, 18, 0, 0, 11, 896, DateTimeKind.Local).AddTicks(3037), null, 5, 209.0, null, true },
                    { 5, new DateTime(2023, 8, 24, 7, 50, 19, 514, DateTimeKind.Local).AddTicks(2668), new DateTime(2023, 8, 25, 20, 20, 56, 318, DateTimeKind.Local).AddTicks(482), new DateTime(2024, 1, 28, 5, 9, 17, 861, DateTimeKind.Local).AddTicks(695), null, 8, 401.0, null, false },
                    { 6, new DateTime(2023, 8, 24, 4, 38, 55, 588, DateTimeKind.Local).AddTicks(8980), new DateTime(2023, 8, 25, 8, 2, 47, 491, DateTimeKind.Local).AddTicks(8394), new DateTime(2023, 8, 31, 1, 23, 4, 866, DateTimeKind.Local).AddTicks(8870), null, 10, 372.0, null, true },
                    { 7, new DateTime(2023, 8, 24, 3, 0, 11, 299, DateTimeKind.Local).AddTicks(7499), new DateTime(2023, 8, 24, 21, 54, 5, 104, DateTimeKind.Local).AddTicks(25), new DateTime(2023, 8, 26, 15, 58, 59, 202, DateTimeKind.Local).AddTicks(6106), null, 3, 475.0, null, false },
                    { 8, new DateTime(2023, 8, 23, 22, 18, 19, 35, DateTimeKind.Local).AddTicks(4199), new DateTime(2023, 8, 25, 2, 15, 54, 631, DateTimeKind.Local).AddTicks(7149), new DateTime(2024, 1, 23, 20, 49, 48, 953, DateTimeKind.Local).AddTicks(2930), null, 6, 274.0, null, true },
                    { 9, new DateTime(2023, 8, 24, 14, 41, 44, 666, DateTimeKind.Local).AddTicks(3658), new DateTime(2023, 8, 25, 1, 40, 50, 308, DateTimeKind.Local).AddTicks(3895), new DateTime(2024, 4, 26, 3, 39, 13, 232, DateTimeKind.Local).AddTicks(7133), null, 7, 303.0, null, false },
                    { 10, new DateTime(2023, 8, 24, 4, 37, 58, 294, DateTimeKind.Local).AddTicks(9748), new DateTime(2023, 8, 25, 1, 27, 5, 384, DateTimeKind.Local).AddTicks(705), new DateTime(2023, 9, 27, 1, 44, 29, 461, DateTimeKind.Local).AddTicks(1845), null, 10, 286.0, null, false }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CreatedAt", "DateDepart", "DateRetour", "DeletedAt", "IdVehicule", "MontantTotal", "NumeroReservation", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 24, 19, 51, 35, 257, DateTimeKind.Local).AddTicks(8506), new DateTime(2023, 8, 25, 18, 35, 49, 484, DateTimeKind.Local).AddTicks(643), new DateTime(2024, 1, 1, 0, 55, 22, 382, DateTimeKind.Local).AddTicks(1950), null, 5, 0.0, "2c85da62-b500-4ab4-b2fe-8ec3c86cca15", "Confirmé", null },
                    { 2, new DateTime(2023, 8, 24, 13, 15, 43, 741, DateTimeKind.Local).AddTicks(7741), new DateTime(2023, 8, 24, 23, 16, 23, 312, DateTimeKind.Local).AddTicks(1429), new DateTime(2024, 7, 8, 0, 57, 32, 247, DateTimeKind.Local).AddTicks(8721), null, 6, 0.0, "fd66fbf8-e7b3-4f06-aeaa-8db7e99edff6", "Expiré", null },
                    { 3, new DateTime(2023, 8, 24, 17, 28, 25, 260, DateTimeKind.Local).AddTicks(1789), new DateTime(2023, 8, 25, 21, 49, 37, 554, DateTimeKind.Local).AddTicks(4591), new DateTime(2024, 3, 31, 2, 27, 38, 0, DateTimeKind.Local).AddTicks(9139), null, 8, 0.0, "ac60dcd5-78a7-42e9-adf8-10d41a4e555f", "Confirmé", null },
                    { 4, new DateTime(2023, 8, 24, 11, 10, 25, 267, DateTimeKind.Local).AddTicks(3936), new DateTime(2023, 8, 25, 9, 46, 40, 802, DateTimeKind.Local).AddTicks(6350), new DateTime(2023, 10, 23, 4, 21, 17, 204, DateTimeKind.Local).AddTicks(6589), null, 5, 0.0, "934bbd66-79fc-45ec-a187-523647e2f40c", "Enattente", null },
                    { 5, new DateTime(2023, 8, 24, 1, 58, 27, 575, DateTimeKind.Local).AddTicks(6585), new DateTime(2023, 8, 25, 11, 31, 40, 818, DateTimeKind.Local).AddTicks(5942), new DateTime(2023, 12, 8, 2, 53, 57, 962, DateTimeKind.Local).AddTicks(8869), null, 7, 0.0, "1382f95f-aedf-4ed6-837f-4a5f90fa5a90", "Annulé", null },
                    { 6, new DateTime(2023, 8, 24, 2, 56, 10, 395, DateTimeKind.Local).AddTicks(3123), new DateTime(2023, 8, 25, 6, 49, 18, 682, DateTimeKind.Local).AddTicks(3893), new DateTime(2024, 4, 16, 11, 54, 37, 70, DateTimeKind.Local).AddTicks(5590), null, 10, 0.0, "11d770d5-d1ab-4110-9a69-d7a8b1f1c657", "Confirmé", null },
                    { 7, new DateTime(2023, 8, 24, 11, 45, 27, 743, DateTimeKind.Local).AddTicks(1676), new DateTime(2023, 8, 25, 19, 39, 55, 589, DateTimeKind.Local).AddTicks(8735), new DateTime(2024, 6, 17, 16, 19, 25, 582, DateTimeKind.Local).AddTicks(2646), null, 2, 0.0, "5e1476c0-ceec-4bdf-b156-f6420c1d12a2", "Confirmé", null },
                    { 8, new DateTime(2023, 8, 24, 9, 30, 41, 796, DateTimeKind.Local).AddTicks(2380), new DateTime(2023, 8, 25, 1, 4, 17, 622, DateTimeKind.Local).AddTicks(8581), new DateTime(2024, 3, 18, 11, 11, 40, 969, DateTimeKind.Local).AddTicks(2508), null, 7, 0.0, "713a5685-584f-4c47-8527-30f8f952c2e7", "Annulé", null },
                    { 9, new DateTime(2023, 8, 23, 23, 27, 39, 594, DateTimeKind.Local).AddTicks(8213), new DateTime(2023, 8, 25, 2, 10, 52, 516, DateTimeKind.Local).AddTicks(3314), new DateTime(2024, 8, 21, 7, 0, 6, 859, DateTimeKind.Local).AddTicks(4567), null, 3, 0.0, "86edb941-2201-48ff-93fe-fffc928a0e77", "Enattente", null },
                    { 10, new DateTime(2023, 8, 24, 2, 36, 28, 8, DateTimeKind.Local).AddTicks(7926), new DateTime(2023, 8, 25, 3, 47, 56, 951, DateTimeKind.Local).AddTicks(3688), new DateTime(2024, 2, 18, 3, 24, 8, 653, DateTimeKind.Local).AddTicks(5436), null, 7, 0.0, "2dc7ef4f-f324-41dc-b436-9fb1df8fc5d4", "Annulé", null }
                });

            migrationBuilder.InsertData(
                table: "Contrats",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IdClient", "IdReservation", "IsConducteur", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 7, false, null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, 7, true, null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, 5, true, null },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 3, false, null },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, 6, true, null },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 7, false, null },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, 5, true, null },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, 1, false, null },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, 10, true, null },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 4, true, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AgenceLongTermRentals_LongTermRentalId",
                table: "AgenceLongTermRentals",
                column: "LongTermRentalId");

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
                name: "IX_OffreDetails_IdOffre",
                table: "OffreDetails",
                column: "IdOffre");

            migrationBuilder.CreateIndex(
                name: "IX_Offres_IdVehicule",
                table: "Offres",
                column: "IdVehicule");

            migrationBuilder.CreateIndex(
                name: "IX_PieceJointes_IdLLDReponse",
                table: "PieceJointes",
                column: "IdLLDReponse");

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
                name: "AgenceLongTermRentals");

            migrationBuilder.DropTable(
                name: "Contrats");

            migrationBuilder.DropTable(
                name: "EmailVerificationTokens");

            migrationBuilder.DropTable(
                name: "log_journal");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "OffreDetails");

            migrationBuilder.DropTable(
                name: "PasswordResetTokens");

            migrationBuilder.DropTable(
                name: "PieceJointes");

            migrationBuilder.DropTable(
                name: "RolePermissions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Offres");

            migrationBuilder.DropTable(
                name: "lld_responses");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Vehicules");

            migrationBuilder.DropTable(
                name: "long_term_rentals");

            migrationBuilder.DropTable(
                name: "Agences");

            migrationBuilder.DropTable(
                name: "Modeles");

            migrationBuilder.DropTable(
                name: "Marques");
        }
    }
}
