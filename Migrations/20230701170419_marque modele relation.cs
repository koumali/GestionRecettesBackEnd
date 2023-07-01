using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace automotive_api.Migrations
{
    /// <inheritdoc />
    public partial class marquemodelerelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offre_id_agence",
                table: "Offres");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_id_agence",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicules_id_marque",
                table: "Vehicules");

            migrationBuilder.DropIndex(
                name: "IX_Vehicules_id_marque",
                table: "Vehicules");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_id_agence",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Offres_id_agence",
                table: "Offres");

            migrationBuilder.DropColumn(
                name: "id_marque",
                table: "Vehicules");

            migrationBuilder.DropColumn(
                name: "id_agence",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "id_agence",
                table: "Offres");

            migrationBuilder.AddColumn<int>(
                name: "id_marque",
                table: "Modeles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Modeles_id_marque",
                table: "Modeles",
                column: "id_marque");

            migrationBuilder.AddForeignKey(
                name: "FK_Modeles_id_marque",
                table: "Modeles",
                column: "id_marque",
                principalTable: "Marques",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modeles_id_marque",
                table: "Modeles");

            migrationBuilder.DropIndex(
                name: "IX_Modeles_id_marque",
                table: "Modeles");

            migrationBuilder.DropColumn(
                name: "id_marque",
                table: "Modeles");

            migrationBuilder.AddColumn<int>(
                name: "id_marque",
                table: "Vehicules",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_agence",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_agence",
                table: "Offres",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicules_id_marque",
                table: "Vehicules",
                column: "id_marque");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_id_agence",
                table: "Reservations",
                column: "id_agence");

            migrationBuilder.CreateIndex(
                name: "IX_Offres_id_agence",
                table: "Offres",
                column: "id_agence");

            migrationBuilder.AddForeignKey(
                name: "FK_Offre_id_agence",
                table: "Offres",
                column: "id_agence",
                principalTable: "Agences",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_id_agence",
                table: "Reservations",
                column: "id_agence",
                principalTable: "Agences",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicules_id_marque",
                table: "Vehicules",
                column: "id_marque",
                principalTable: "Marques",
                principalColumn: "id");
        }
    }
}
