using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace automotive_api.Migrations
{
    /// <inheritdoc />
    public partial class updated : Migration
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
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false),
                    tel = table.Column<string>(type: "longtext", nullable: false),
                    email = table.Column<string>(type: "longtext", nullable: false),
                    address = table.Column<string>(type: "longtext", nullable: false),
                    city = table.Column<string>(type: "longtext", nullable: false),
                    zip_code = table.Column<string>(type: "longtext", nullable: false),
                    latitude = table.Column<double>(type: "double", nullable: false),
                    longitude = table.Column<double>(type: "double", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agences", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    first_name = table.Column<string>(type: "longtext", nullable: false),
                    last_name = table.Column<string>(type: "longtext", nullable: false),
                    tel = table.Column<string>(type: "longtext", nullable: false),
                    email = table.Column<string>(type: "longtext", nullable: false),
                    ville = table.Column<string>(type: "longtext", nullable: false),
                    zipcode = table.Column<string>(type: "longtext", nullable: false),
                    adresse = table.Column<string>(type: "longtext", nullable: false),
                    adresse2 = table.Column<string>(type: "longtext", nullable: false),
                    permis_recto = table.Column<string>(type: "longtext", nullable: false),
                    permis_verso = table.Column<string>(type: "longtext", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "log_journal",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name_controller = table.Column<string>(type: "longtext", nullable: false),
                    name_fonction = table.Column<string>(type: "longtext", nullable: false),
                    description_message = table.Column<string>(type: "longtext", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_log_journal", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Marques",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marques", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Modeles",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modeles", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Vehicules",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false),
                    matricule = table.Column<string>(type: "longtext", nullable: false),
                    prix = table.Column<double>(type: "double", nullable: false),
                    nb_port = table.Column<int>(type: "int", nullable: false),
                    nb_passager = table.Column<int>(type: "int", nullable: false),
                    km = table.Column<int>(type: "int", nullable: false),
                    climat = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    airbag = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    image = table.Column<string>(type: "longtext", nullable: false),
                    gearbox = table.Column<string>(type: "longtext", nullable: false),
                    moteur = table.Column<string>(type: "longtext", nullable: false),
                    id_agence = table.Column<int>(type: "int", nullable: false),
                    id_marque = table.Column<int>(type: "int", nullable: false),
                    id_modele = table.Column<int>(type: "int", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicules", x => x.id);
                    table.ForeignKey(
                        name: "FK_Vehicules_id_agence",
                        column: x => x.id_agence,
                        principalTable: "Agences",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Vehicules_id_marque",
                        column: x => x.id_marque,
                        principalTable: "Marques",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Vehicules_id_modele",
                        column: x => x.id_modele,
                        principalTable: "Modeles",
                        principalColumn: "id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    first_name = table.Column<string>(type: "longtext", nullable: false),
                    last_name = table.Column<string>(type: "longtext", nullable: false),
                    email = table.Column<string>(type: "longtext", nullable: false),
                    password = table.Column<string>(type: "longtext", nullable: false),
                    is_active = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    id_role = table.Column<int>(type: "int", nullable: false),
                    id_agence = table.Column<int>(type: "int", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                    table.ForeignKey(
                        name: "FK_Users_id_agence",
                        column: x => x.id_agence,
                        principalTable: "Agences",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Users_id_role",
                        column: x => x.id_role,
                        principalTable: "Roles",
                        principalColumn: "id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Offres",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    id_vehicule = table.Column<int>(type: "int", nullable: false),
                    id_agence = table.Column<int>(type: "int", nullable: false),
                    date_debut = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    date_fin = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    prix = table.Column<double>(type: "double", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offres", x => x.id);
                    table.ForeignKey(
                        name: "FK_Offre_id_agence",
                        column: x => x.id_agence,
                        principalTable: "Agences",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Offre_id_vehicule",
                        column: x => x.id_vehicule,
                        principalTable: "Vehicules",
                        principalColumn: "id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    date_depart = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    date_retour = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    id_vehicule = table.Column<int>(type: "int", nullable: false),
                    id_agence = table.Column<int>(type: "int", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.id);
                    table.ForeignKey(
                        name: "FK_Reservation_id_agence",
                        column: x => x.id_agence,
                        principalTable: "Agences",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Reservation_id_vehicule",
                        column: x => x.id_vehicule,
                        principalTable: "Vehicules",
                        principalColumn: "id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Contrats",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    id_client = table.Column<int>(type: "int", nullable: false),
                    id_reservation = table.Column<int>(type: "int", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contrats", x => x.id);
                    table.ForeignKey(
                        name: "FK_Contrats_id_client",
                        column: x => x.id_client,
                        principalTable: "Clients",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Contrats_id_reservation",
                        column: x => x.id_reservation,
                        principalTable: "Reservations",
                        principalColumn: "id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "id", "created_at", "deleted_at", "name", "updated_at" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Admin", null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gerant", null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Agent", null },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Client", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contrats_id_client",
                table: "Contrats",
                column: "id_client");

            migrationBuilder.CreateIndex(
                name: "IX_Contrats_id_reservation",
                table: "Contrats",
                column: "id_reservation");

            migrationBuilder.CreateIndex(
                name: "IX_Offres_id_agence",
                table: "Offres",
                column: "id_agence");

            migrationBuilder.CreateIndex(
                name: "IX_Offres_id_vehicule",
                table: "Offres",
                column: "id_vehicule");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_id_agence",
                table: "Reservations",
                column: "id_agence");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_id_vehicule",
                table: "Reservations",
                column: "id_vehicule");

            migrationBuilder.CreateIndex(
                name: "IX_Users_id_agence",
                table: "Users",
                column: "id_agence");

            migrationBuilder.CreateIndex(
                name: "IX_Users_id_role",
                table: "Users",
                column: "id_role");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicules_id_agence",
                table: "Vehicules",
                column: "id_agence");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicules_id_marque",
                table: "Vehicules",
                column: "id_marque");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicules_id_modele",
                table: "Vehicules",
                column: "id_modele");
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
                name: "Marques");

            migrationBuilder.DropTable(
                name: "Modeles");
        }
    }
}
