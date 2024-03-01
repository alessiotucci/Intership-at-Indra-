using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetflixClone.Migrations
{
    /// <inheritdoc />
    public partial class addedNavigationProp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Completata",
                table: "Videos",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateOnly>(
                name: "DataFine",
                table: "Videos",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<DateOnly>(
                name: "DataInizio",
                table: "Videos",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Videos",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "DurataInMin",
                table: "Videos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Episodi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Stagione = table.Column<int>(type: "int", nullable: false),
                    Numero_Episodio = table.Column<int>(type: "int", nullable: false),
                    Titolo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sinossi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Episodi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProfiloVideo",
                columns: table => new
                {
                    VideoVistiId = table.Column<int>(type: "int", nullable: false),
                    VisualizzatoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfiloVideo", x => new { x.VideoVistiId, x.VisualizzatoriId });
                    table.ForeignKey(
                        name: "FK_ProfiloVideo_Profili_VisualizzatoriId",
                        column: x => x.VisualizzatoriId,
                        principalTable: "Profili",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfiloVideo_Videos_VideoVistiId",
                        column: x => x.VideoVistiId,
                        principalTable: "Videos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stagioni",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Serie = table.Column<int>(type: "int", nullable: false),
                    NumeroStagione = table.Column<int>(type: "int", nullable: false),
                    InizioVisibilita = table.Column<DateOnly>(type: "date", nullable: false),
                    FineVisibilita = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stagioni", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Profili_Id_Utente",
                table: "Profili",
                column: "Id_Utente");

            migrationBuilder.CreateIndex(
                name: "IX_ProfiloVideo_VisualizzatoriId",
                table: "ProfiloVideo",
                column: "VisualizzatoriId");

            migrationBuilder.AddForeignKey(
                name: "FK_Profili_Utenti_Id_Utente",
                table: "Profili",
                column: "Id_Utente",
                principalTable: "Utenti",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profili_Utenti_Id_Utente",
                table: "Profili");

            migrationBuilder.DropTable(
                name: "Episodi");

            migrationBuilder.DropTable(
                name: "ProfiloVideo");

            migrationBuilder.DropTable(
                name: "Stagioni");

            migrationBuilder.DropIndex(
                name: "IX_Profili_Id_Utente",
                table: "Profili");

            migrationBuilder.DropColumn(
                name: "Completata",
                table: "Videos");

            migrationBuilder.DropColumn(
                name: "DataFine",
                table: "Videos");

            migrationBuilder.DropColumn(
                name: "DataInizio",
                table: "Videos");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Videos");

            migrationBuilder.DropColumn(
                name: "DurataInMin",
                table: "Videos");
        }
    }
}
