using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AutomotiveApi.Migrations
{
    /// <inheritdoc />
    public partial class updateseeds : Migration
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
                    { 1, "2753 Jovanny Valley", "El Jadida", new DateTime(2023, 4, 1, 12, 33, 5, 593, DateTimeKind.Local).AddTicks(332), null, "Schuyler.Williamson@hotmail.com", true, 30.695799999999998, null, 54.001100000000001, "Investor Factors Agent", null, "880-714-9203", null, "73394-7546" },
                    { 2, "33061 Feeney Cape", "Mohammédia", new DateTime(2023, 5, 13, 23, 13, 11, 482, DateTimeKind.Local).AddTicks(3118), null, "Megane.Beahan38@gmail.com", true, 46.124299999999998, null, 78.747100000000003, "Principal Configuration Developer", null, "686.526.0384 x840", null, "78175" },
                    { 3, "298 Kuhic Radial", "El Jadida", new DateTime(2022, 11, 22, 2, 20, 27, 369, DateTimeKind.Local).AddTicks(5146), null, "Gerhard55@hotmail.com", false, -22.867699999999999, null, -168.20089999999999, "Legacy Accountability Planner", null, "1-507-664-6477", null, "70077" },
                    { 4, "192 Arnulfo Causeway", "Beni-mellal", new DateTime(2023, 2, 21, 2, 27, 55, 974, DateTimeKind.Local).AddTicks(433), null, "Clair40@yahoo.com", true, 31.0806, null, -12.6006, "Forward Accountability Manager", null, "(753) 968-5242 x73758", null, "25361-5204" },
                    { 5, "055 Fay Terrace", "El Jadida", new DateTime(2022, 10, 29, 11, 5, 37, 329, DateTimeKind.Local).AddTicks(3977), null, "Antonia_Parisian87@hotmail.com", false, 85.166399999999996, null, -39.218600000000002, "Central Response Liaison", null, "354-805-1642 x341", null, "22545" },
                    { 6, "839 Schultz Road", "Fès", new DateTime(2023, 5, 24, 4, 37, 36, 699, DateTimeKind.Local).AddTicks(1201), null, "Una14@gmail.com", false, 29.395, null, -144.50380000000001, "Human Optimization Consultant", null, "244-245-8751 x7332", null, "35953" },
                    { 7, "00716 Rowe Tunnel", "Mohammédia", new DateTime(2023, 2, 9, 12, 55, 35, 840, DateTimeKind.Local).AddTicks(1429), null, "Hester_Purdy8@hotmail.com", true, 87.105699999999999, null, 86.003200000000007, "Forward Usability Analyst", null, "683.653.6287", null, "64350-6624" },
                    { 8, "94766 Anissa Courts", "Khouribga", new DateTime(2022, 9, 21, 21, 4, 54, 282, DateTimeKind.Local).AddTicks(9779), null, "Birdie.Homenick38@gmail.com", false, -4.1878000000000002, null, 96.288899999999998, "Product Functionality Planner", null, "593-479-8031 x7244", null, "14645-1392" },
                    { 9, "19848 Parisian Inlet", "Tanger", new DateTime(2023, 4, 15, 1, 54, 28, 266, DateTimeKind.Local).AddTicks(2067), null, "Manuel_Kertzmann@gmail.com", true, 73.775400000000005, null, -103.1996, "Global Assurance Manager", null, "1-806-525-4341", null, "84415" },
                    { 10, "65637 Langosh Fall", "Safi", new DateTime(2023, 5, 22, 18, 37, 43, 543, DateTimeKind.Local).AddTicks(588), null, "Haleigh.Olson@hotmail.com", false, 27.034300000000002, null, 161.7431, "Human Quality Assistant", null, "798-538-3097 x8765", null, "98407-7670" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Adresse", "Adresse2", "CreatedAt", "DeletedAt", "Email", "FirstName", "IsVerified", "LastName", "Password", "PermisRecto", "PermisVerso", "Tel", "UpdatedAt", "Ville", "ZipCode" },
                values: new object[,]
                {
                    { 1, "097 Eloisa Avenue", "3988 Forest Lodge", new DateTime(2022, 9, 3, 15, 25, 10, 365, DateTimeKind.Local).AddTicks(5865), null, "Nasir.Emmerich31@gmail.com", "Lewis", false, "Beer", null, "https://picsum.photos/640/480/?image=1045", "https://picsum.photos/640/480/?image=704", "787-494-2535 x342", null, "Port Mckaylamouth", "66227-8324" },
                    { 2, "76484 Tillman Rest", "781 Konopelski Centers", new DateTime(2023, 6, 12, 13, 19, 14, 560, DateTimeKind.Local).AddTicks(2370), null, "Ken95@gmail.com", "Kelli", false, "Paucek", null, "https://picsum.photos/640/480/?image=787", "https://picsum.photos/640/480/?image=129", "1-895-596-0001 x51647", null, "East Gennaro", "85576-4416" },
                    { 3, "025 Zieme Burgs", "7752 Alison Expressway", new DateTime(2022, 9, 23, 21, 43, 56, 125, DateTimeKind.Local).AddTicks(47), null, "Marques_Feeney80@hotmail.com", "Buford", false, "Konopelski", null, "https://picsum.photos/640/480/?image=921", "https://picsum.photos/640/480/?image=492", "1-710-201-5370", null, "Lake Madalynfort", "96121" },
                    { 4, "838 Will Greens", "45489 Wuckert Expressway", new DateTime(2023, 5, 10, 16, 54, 47, 890, DateTimeKind.Local).AddTicks(2989), null, "Cristopher.Rau10@yahoo.com", "Velva", false, "Kub", null, "https://picsum.photos/640/480/?image=389", "https://picsum.photos/640/480/?image=366", "511.761.4692 x669", null, "South Leonardo", "29945" },
                    { 5, "6603 Mozelle Square", "06347 Lorine Loaf", new DateTime(2023, 5, 10, 3, 26, 56, 322, DateTimeKind.Local).AddTicks(6413), null, "Oran_Moore@gmail.com", "Verda", false, "Gleason", null, "https://picsum.photos/640/480/?image=1013", "https://picsum.photos/640/480/?image=234", "308.822.1629 x0676", null, "South Allyborough", "26648-9872" },
                    { 6, "24705 Van Shores", "940 Toni Trafficway", new DateTime(2023, 8, 18, 3, 45, 44, 283, DateTimeKind.Local).AddTicks(6120), null, "Terrell69@yahoo.com", "Melba", false, "O'Hara", null, "https://picsum.photos/640/480/?image=821", "https://picsum.photos/640/480/?image=713", "296.276.9754 x042", null, "MacGyverland", "74502-4116" },
                    { 7, "3799 Abbott Way", "78206 Rodriguez Canyon", new DateTime(2023, 7, 14, 6, 6, 6, 831, DateTimeKind.Local).AddTicks(2235), null, "Sylvan.Williamson@gmail.com", "Okey", false, "Vandervort", null, "https://picsum.photos/640/480/?image=568", "https://picsum.photos/640/480/?image=1066", "1-643-435-9060", null, "East Gayle", "22892-5533" },
                    { 8, "6851 Abshire Summit", "20891 Bruen Ways", new DateTime(2023, 4, 5, 16, 36, 44, 385, DateTimeKind.Local).AddTicks(6297), null, "Dariana42@hotmail.com", "Scot", false, "Green", null, "https://picsum.photos/640/480/?image=172", "https://picsum.photos/640/480/?image=858", "796-297-7572", null, "Macejkovicfort", "78633" },
                    { 9, "33755 Boyle Course", "7347 Fadel Tunnel", new DateTime(2023, 3, 1, 10, 26, 19, 61, DateTimeKind.Local).AddTicks(1540), null, "Adolfo.Hagenes74@yahoo.com", "Chris", false, "Cartwright", null, "https://picsum.photos/640/480/?image=766", "https://picsum.photos/640/480/?image=849", "1-648-897-7506 x8984", null, "South Fayeland", "30378" },
                    { 10, "33810 Abigayle Wall", "900 Toy Vista", new DateTime(2023, 2, 6, 17, 39, 54, 276, DateTimeKind.Local).AddTicks(5104), null, "Tremaine.Stark88@gmail.com", "Frederique", false, "Schultz", null, "https://picsum.photos/640/480/?image=1036", "https://picsum.photos/640/480/?image=312", "1-636-977-8699", null, "Prosaccohaven", "58498" }
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
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Journalisation", null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Utilisateurs", null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Roles", null },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Agences", null },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Permissions", null },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Marques", null },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Modèles", null },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Véhicules", null },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Réservations", null },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "LLD", null },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Clients", null },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Offres", null }
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
                    { 2, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null },
                    { 3, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null },
                    { 5, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null },
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
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "superadmin@test.com", "Super", null, 1, true, false, "Admin", "$2a$11$r.DHOQcRaqMxZ5IX70FHEem3.Tm2sFELpr6ERxNqHTtiSLuSv8N3q", null },
                    { 2, new DateTime(2023, 6, 12, 9, 25, 29, 381, DateTimeKind.Local).AddTicks(1403), null, "Abigayle17@gmail.com", "Erich", 3, 2, false, false, "Pollich", "$2a$11$HAo5CT/.J7Gy.zdcjoylseO56cieZQ53nAUr0kbqfPRNnWnXkb5d2", null },
                    { 3, new DateTime(2022, 12, 6, 21, 7, 59, 229, DateTimeKind.Local).AddTicks(465), null, "Katelin_Ankunding@hotmail.com", "Ricardo", 6, 2, false, false, "Gerhold", "$2a$11$sQn2Y/i7gVITxEbGctNZ2.6Eny02QGkCgMzzVU26DU155RkdwkqbO", null },
                    { 4, new DateTime(2023, 1, 9, 10, 39, 22, 433, DateTimeKind.Local).AddTicks(2631), null, "Brock45@gmail.com", "Mariah", 5, 2, false, false, "Wiza", "$2a$11$cUzSGMieQ.dsXP2zP9aMzeVK3FWsOJBOOeiNF7ywXgWawiG.AMzL2", null },
                    { 5, new DateTime(2023, 7, 1, 4, 30, 52, 817, DateTimeKind.Local).AddTicks(2985), null, "Flavio_Schoen32@gmail.com", "Deven", 8, 1, false, false, "Graham", "$2a$11$oPp/0AgYbrZZeejqRTBSNu2oqe2ionIAgNWFRdN9L6IoYstsTk3aS", null },
                    { 6, new DateTime(2023, 3, 23, 0, 28, 52, 647, DateTimeKind.Local).AddTicks(3602), null, "Quincy_Erdman@yahoo.com", "Eve", 7, 2, true, false, "Metz", "$2a$11$75G5j2rp9d7heHYk71/NIe7VGQx3EobQJIsWvPe/U/G7qHa3MmuUG", null },
                    { 7, new DateTime(2023, 4, 3, 7, 26, 10, 432, DateTimeKind.Local).AddTicks(2788), null, "Claude_Purdy@gmail.com", "Mohammed", 2, 2, false, false, "Sporer", "$2a$11$T03z4Oikgy.jSl5IKWsSAOWL24nELfQRuNSAVl5ip2IvrvJ9VeOzK", null },
                    { 8, new DateTime(2023, 3, 21, 12, 42, 12, 370, DateTimeKind.Local).AddTicks(945), null, "Antonina.Lesch29@yahoo.com", "Burdette", 1, 1, false, false, "Pollich", "$2a$11$O2VemX.Hokof3jrkyfelNeeKd4NyIgrGjmTN3pfplSoPF1B4i6mPO", null },
                    { 9, new DateTime(2022, 10, 13, 8, 3, 58, 949, DateTimeKind.Local).AddTicks(5589), null, "Geraldine.Streich@yahoo.com", "Barry", 7, 2, true, false, "Sauer", "$2a$11$dHcbGXiyeQrlZj3jHtK0v.615cFl1RgV7upaG4PdmZqMToxEYGy8.", null },
                    { 10, new DateTime(2023, 6, 13, 14, 28, 48, 539, DateTimeKind.Local).AddTicks(6724), null, "Lane_Keebler@yahoo.com", "Deondre", 10, 1, true, false, "Pacocha", "$2a$11$UX6nyrlo6PhefyBeeJn56.mMGppiyjA/Y8G5CuQSnNMeksyg7EepC", null },
                    { 11, new DateTime(2023, 3, 23, 15, 13, 58, 941, DateTimeKind.Local).AddTicks(9176), null, "Karson_Denesik@gmail.com", "Jameson", 1, 1, false, false, "Koss", "$2a$11$Da1taa0RYb..Vlt.pd2Hn.v7gTztob.Ezpzadm.od99DBqBcW2ICu", null }
                });

            migrationBuilder.InsertData(
                table: "Vehicules",
                columns: new[] { "Id", "Airbag", "Climat", "CreatedAt", "DeletedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, false, false, new DateTime(2023, 7, 10, 18, 47, 37, 247, DateTimeKind.Local).AddTicks(111), null, "Manuelle", 2, 216, 5290, "nuwujeftzr", "Diesel", "esrenwyign", 10, 3, 258.0, "Véhicule", null },
                    { 2, false, false, new DateTime(2023, 8, 2, 4, 36, 42, 710, DateTimeKind.Local).AddTicks(2070), null, "Manuelle", 2, 36, 4294, "lzxbzsdlph", "Essence", "vmfitjnjcg", 7, 2, 353.0, "Véhicule", null },
                    { 3, false, true, new DateTime(2023, 7, 7, 9, 42, 3, 336, DateTimeKind.Local).AddTicks(6607), null, "Manuelle", 4, 137, 4864, "dqajbaukyg", "Hybride", "lzmkmoaiyc", 10, 3, 205.0, "Véhicule", null },
                    { 4, true, false, new DateTime(2023, 7, 3, 14, 39, 21, 195, DateTimeKind.Local).AddTicks(3708), null, "Automatique", 9, 253, 2723, "wbtyekbkgs", "Essence", "ertmdqgioj", 8, 9, 294.0, "Véhicule", null },
                    { 5, false, false, new DateTime(2023, 8, 6, 20, 30, 35, 169, DateTimeKind.Local).AddTicks(5569), null, "Manuelle", 1, 95, 5881, "sugfblqpid", "Essence", "ohasrcvvgx", 7, 4, 289.0, "Véhicule", null },
                    { 6, false, false, new DateTime(2022, 11, 25, 1, 0, 0, 431, DateTimeKind.Local).AddTicks(8930), null, "Manuelle", 5, 145, 8574, "srazkteyjf", "Hybride", "qrdhfoxjnt", 9, 3, 448.0, "Véhicule", null },
                    { 7, false, false, new DateTime(2022, 9, 23, 3, 0, 22, 219, DateTimeKind.Local).AddTicks(3756), null, "Manuelle", 4, 269, 3246, "baixbnijpf", "Électrique", "riqwqkwwdl", 2, 7, 411.0, "Utilitaire", null },
                    { 8, true, true, new DateTime(2023, 3, 7, 22, 3, 28, 658, DateTimeKind.Local).AddTicks(4516), null, "Automatique", 6, 72, 7355, "avyswlhmca", "Électrique", "rlxvplcyqy", 8, 9, 371.0, "Véhicule", null },
                    { 9, true, true, new DateTime(2022, 9, 2, 2, 14, 5, 433, DateTimeKind.Local).AddTicks(1419), null, "Manuelle", 10, 223, 750, "murqbnhdhf", "Électrique", "onbixpdbmb", 5, 9, 438.0, "Véhicule", null },
                    { 10, false, false, new DateTime(2022, 10, 31, 14, 54, 31, 298, DateTimeKind.Local).AddTicks(8411), null, "Automatique", 3, 161, 8797, "townoudiuo", "Hybride", "vhrueyiirg", 1, 8, 346.0, "Utilitaire", null }
                });

            migrationBuilder.InsertData(
                table: "long_term_rentals",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "Prix", "UpdatedAt", "description", "duree", "email", "entreprise", "idAgence", "nom", "phone", "prenom", "status", "ville", "zip" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 14, 18, 58, 44, 782, DateTimeKind.Local).AddTicks(2851), null, "Manuelle", 71, "Hybride", "gazrurxzzw", 481.0, null, "Willms", 28, "RyanGosling@drive.com", "Mitchell Group", null, "Candido", "485.925.5917 x23030", "McClure", "Enattente", "Javonteside", "76572-8475" },
                    { 2, new DateTime(2023, 4, 4, 5, 27, 23, 835, DateTimeKind.Local).AddTicks(5492), null, "Manuelle", 267, "Diesel", "hozrvospih", 234.0, null, "Bode", 32, "RyanGosling@drive.com", "Jones - Braun", null, "Eunice", "(529) 495-2690 x18394", "Koelpin", "Enattente", "North Camylle", "37446" },
                    { 3, new DateTime(2023, 2, 6, 7, 41, 30, 131, DateTimeKind.Local).AddTicks(3123), null, "Automatique", 233, "Hybride", "hsntkqraxk", 319.0, null, "Reichert", 32, "RyanGosling@drive.com", "Muller, Bartell and Barrows", null, "Whitney", "967.749.8201", "Rohan", "Enattente", "Wizachester", "30937-1325" },
                    { 4, new DateTime(2023, 6, 13, 4, 38, 51, 41, DateTimeKind.Local).AddTicks(9004), null, "Automatique", 169, "Électrique", "ykkpgfdpxd", 323.0, null, "Rippin", 30, "RyanGosling@drive.com", "Kuhlman, Gibson and Spinka", null, "Modesta", "1-927-623-0291", "Conroy", "Enattente", "Angusfort", "72795-4091" },
                    { 5, new DateTime(2022, 12, 3, 19, 52, 37, 15, DateTimeKind.Local).AddTicks(7089), null, "Manuelle", 81, "Hybride", "jlwjernfwi", 364.0, null, "Champlin", 32, "RyanGosling@drive.com", "Ritchie - Hudson", null, "Caterina", "359-559-8278", "Weissnat", "Enattente", "Armanistad", "49896" },
                    { 6, new DateTime(2022, 11, 20, 2, 39, 7, 869, DateTimeKind.Local).AddTicks(1886), null, "Automatique", 214, "Électrique", "ntployoila", 405.0, null, "Upton", 24, "RyanGosling@drive.com", "Roob, Green and O'Connell", null, "Gaylord", "204-514-5016", "Satterfield", "Enattente", "West Darronview", "52852-7505" },
                    { 7, new DateTime(2023, 8, 4, 9, 29, 9, 393, DateTimeKind.Local).AddTicks(7467), null, "Manuelle", 271, "Hybride", "ujtbwncgzz", 449.0, null, "Gottlieb", 29, "RyanGosling@drive.com", "Simonis, Kub and Schumm", null, "Berneice", "(673) 340-0541 x301", "Cummerata", "Enattente", "Port Trevaton", "43121" },
                    { 8, new DateTime(2023, 6, 23, 13, 22, 34, 282, DateTimeKind.Local).AddTicks(9436), null, "Automatique", 181, "Diesel", "jkqdqbnopo", 213.0, null, "Hoeger", 26, "RyanGosling@drive.com", "Kihn Inc", null, "Taylor", "1-458-718-6500 x05762", "Haag", "Enattente", "Quitzonburgh", "51368-9033" },
                    { 9, new DateTime(2023, 6, 18, 9, 51, 2, 671, DateTimeKind.Local).AddTicks(2802), null, "Automatique", 302, "Hybride", "mnqcmdisxc", 488.0, null, "Will", 23, "RyanGosling@drive.com", "Bashirian Group", null, "Hal", "764.456.5497 x07353", "Friesen", "Enattente", "North Montyburgh", "76088" },
                    { 10, new DateTime(2023, 6, 6, 12, 3, 40, 559, DateTimeKind.Local).AddTicks(1454), null, "Automatique", 101, "Essence", "gzlrwckpej", 245.0, null, "Hudson", 18, "RyanGosling@drive.com", "Toy Group", null, "Vickie", "1-936-972-9006 x16605", "O'Hara", "Enattente", "Bartellfurt", "69984" }
                });

            migrationBuilder.InsertData(
                table: "Offres",
                columns: new[] { "Id", "CreatedAt", "DateDebut", "DateFin", "DeletedAt", "IdVehicule", "Prix", "UpdatedAt", "isPublic" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 26, 15, 49, 23, 963, DateTimeKind.Local).AddTicks(7262), new DateTime(2023, 8, 27, 11, 57, 21, 73, DateTimeKind.Local).AddTicks(9003), new DateTime(2024, 2, 5, 20, 47, 20, 353, DateTimeKind.Local).AddTicks(1484), null, 5, 228.0, null, true },
                    { 2, new DateTime(2023, 8, 26, 16, 58, 2, 820, DateTimeKind.Local).AddTicks(8555), new DateTime(2023, 8, 27, 2, 13, 28, 39, DateTimeKind.Local).AddTicks(4068), new DateTime(2023, 10, 28, 17, 16, 25, 99, DateTimeKind.Local).AddTicks(3687), null, 9, 445.0, null, true },
                    { 3, new DateTime(2023, 8, 26, 2, 12, 31, 884, DateTimeKind.Local).AddTicks(2685), new DateTime(2023, 8, 27, 9, 7, 36, 878, DateTimeKind.Local).AddTicks(41), new DateTime(2024, 4, 21, 6, 6, 1, 445, DateTimeKind.Local).AddTicks(8471), null, 5, 325.0, null, true },
                    { 4, new DateTime(2023, 8, 26, 16, 18, 53, 42, DateTimeKind.Local).AddTicks(6582), new DateTime(2023, 8, 27, 16, 6, 13, 98, DateTimeKind.Local).AddTicks(1824), new DateTime(2023, 8, 28, 3, 1, 11, 251, DateTimeKind.Local).AddTicks(2073), null, 9, 274.0, null, false },
                    { 5, new DateTime(2023, 8, 26, 0, 7, 10, 977, DateTimeKind.Local).AddTicks(5095), new DateTime(2023, 8, 26, 21, 23, 22, 523, DateTimeKind.Local).AddTicks(7556), new DateTime(2024, 4, 22, 16, 21, 40, 708, DateTimeKind.Local).AddTicks(2883), null, 9, 409.0, null, true },
                    { 6, new DateTime(2023, 8, 25, 19, 51, 12, 867, DateTimeKind.Local).AddTicks(5983), new DateTime(2023, 8, 27, 1, 24, 33, 874, DateTimeKind.Local).AddTicks(1897), new DateTime(2024, 6, 25, 5, 13, 11, 821, DateTimeKind.Local).AddTicks(7080), null, 4, 459.0, null, false },
                    { 7, new DateTime(2023, 8, 25, 21, 23, 53, 699, DateTimeKind.Local).AddTicks(9351), new DateTime(2023, 8, 27, 3, 51, 44, 658, DateTimeKind.Local).AddTicks(4799), new DateTime(2024, 7, 12, 1, 6, 53, 887, DateTimeKind.Local).AddTicks(611), null, 1, 263.0, null, true },
                    { 8, new DateTime(2023, 8, 26, 0, 37, 7, 362, DateTimeKind.Local).AddTicks(3143), new DateTime(2023, 8, 27, 8, 27, 3, 155, DateTimeKind.Local).AddTicks(190), new DateTime(2023, 9, 16, 0, 16, 42, 534, DateTimeKind.Local).AddTicks(4428), null, 2, 457.0, null, true },
                    { 9, new DateTime(2023, 8, 26, 0, 24, 31, 567, DateTimeKind.Local).AddTicks(7136), new DateTime(2023, 8, 27, 1, 14, 51, 853, DateTimeKind.Local).AddTicks(3538), new DateTime(2023, 10, 16, 0, 16, 42, 980, DateTimeKind.Local).AddTicks(2204), null, 2, 369.0, null, true },
                    { 10, new DateTime(2023, 8, 26, 4, 41, 9, 926, DateTimeKind.Local).AddTicks(1197), new DateTime(2023, 8, 27, 6, 7, 50, 357, DateTimeKind.Local).AddTicks(2740), new DateTime(2023, 11, 6, 19, 14, 24, 772, DateTimeKind.Local).AddTicks(4895), null, 7, 484.0, null, false }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CreatedAt", "DateDepart", "DateRetour", "DeletedAt", "IdVehicule", "MontantTotal", "NumeroReservation", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 26, 5, 16, 15, 412, DateTimeKind.Local).AddTicks(1042), new DateTime(2023, 8, 27, 6, 20, 27, 205, DateTimeKind.Local).AddTicks(9683), new DateTime(2024, 5, 31, 9, 45, 6, 517, DateTimeKind.Local).AddTicks(7204), null, 6, 0.0, "00dc6ff0-1446-4636-99be-ca45824a42cf", "Expiré", null },
                    { 2, new DateTime(2023, 8, 26, 9, 50, 6, 721, DateTimeKind.Local).AddTicks(9301), new DateTime(2023, 8, 27, 16, 44, 34, 6, DateTimeKind.Local).AddTicks(522), new DateTime(2023, 9, 4, 22, 39, 55, 771, DateTimeKind.Local).AddTicks(5832), null, 8, 0.0, "d485b846-7a03-44f1-93b0-673647126b40", "Confirmé", null },
                    { 3, new DateTime(2023, 8, 25, 23, 29, 25, 88, DateTimeKind.Local).AddTicks(2896), new DateTime(2023, 8, 27, 15, 1, 24, 701, DateTimeKind.Local).AddTicks(2745), new DateTime(2024, 1, 4, 0, 33, 30, 563, DateTimeKind.Local).AddTicks(6381), null, 8, 0.0, "e3671625-6b11-4c47-be9f-1a93fff19b91", "Enattente", null },
                    { 4, new DateTime(2023, 8, 26, 16, 57, 51, 717, DateTimeKind.Local).AddTicks(302), new DateTime(2023, 8, 26, 19, 46, 27, 798, DateTimeKind.Local).AddTicks(247), new DateTime(2023, 10, 13, 15, 16, 37, 376, DateTimeKind.Local).AddTicks(848), null, 9, 0.0, "7a8c5170-1460-4c34-86c1-d4b0298632ba", "Enattente", null },
                    { 5, new DateTime(2023, 8, 26, 17, 25, 24, 835, DateTimeKind.Local).AddTicks(4733), new DateTime(2023, 8, 27, 14, 4, 4, 233, DateTimeKind.Local).AddTicks(8807), new DateTime(2023, 12, 9, 11, 21, 16, 496, DateTimeKind.Local).AddTicks(1984), null, 8, 0.0, "8bdbd602-8b12-4177-8805-4f186d335e9e", "Expiré", null },
                    { 6, new DateTime(2023, 8, 26, 9, 56, 38, 169, DateTimeKind.Local).AddTicks(7515), new DateTime(2023, 8, 27, 2, 16, 16, 763, DateTimeKind.Local).AddTicks(8724), new DateTime(2024, 6, 26, 15, 22, 59, 542, DateTimeKind.Local).AddTicks(2785), null, 3, 0.0, "a5d66578-7b4b-4d6a-aa14-f31a14f8fbdf", "Confirmé", null },
                    { 7, new DateTime(2023, 8, 26, 12, 37, 58, 324, DateTimeKind.Local).AddTicks(9612), new DateTime(2023, 8, 27, 12, 44, 33, 882, DateTimeKind.Local).AddTicks(3074), new DateTime(2023, 12, 27, 9, 52, 28, 334, DateTimeKind.Local).AddTicks(3508), null, 6, 0.0, "5cbd178b-f678-4bef-8ed3-9bb652e1b414", "Expiré", null },
                    { 8, new DateTime(2023, 8, 26, 4, 23, 10, 908, DateTimeKind.Local).AddTicks(6611), new DateTime(2023, 8, 27, 14, 24, 23, 482, DateTimeKind.Local).AddTicks(5407), new DateTime(2024, 7, 9, 0, 6, 54, 648, DateTimeKind.Local).AddTicks(6234), null, 8, 0.0, "f14ce8a2-9126-4c36-a658-389c40d7416b", "Expiré", null },
                    { 9, new DateTime(2023, 8, 26, 17, 5, 40, 444, DateTimeKind.Local).AddTicks(2724), new DateTime(2023, 8, 27, 2, 6, 29, 503, DateTimeKind.Local).AddTicks(1153), new DateTime(2023, 10, 11, 8, 22, 3, 880, DateTimeKind.Local).AddTicks(4088), null, 4, 0.0, "1bbf4da3-0b19-4c7c-bad0-d13c29e73a7e", "Enattente", null },
                    { 10, new DateTime(2023, 8, 26, 9, 26, 5, 797, DateTimeKind.Local).AddTicks(5728), new DateTime(2023, 8, 26, 23, 38, 57, 106, DateTimeKind.Local).AddTicks(2054), new DateTime(2024, 3, 12, 23, 7, 59, 889, DateTimeKind.Local).AddTicks(8975), null, 4, 0.0, "7bb247ef-533c-4559-bccc-ed0aa652ad66", "Enattente", null }
                });

            migrationBuilder.InsertData(
                table: "Contrats",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IdClient", "IdReservation", "IsConducteur", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 5, false, null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, 2, false, null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, 8, false, null },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, 6, false, null },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 2, false, null },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, 1, false, null },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, 1, true, null },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, 10, false, null },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, 8, true, null },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, 8, true, null }
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
