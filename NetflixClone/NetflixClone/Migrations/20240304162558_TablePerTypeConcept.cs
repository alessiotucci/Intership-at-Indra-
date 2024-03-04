using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetflixClone.Migrations
{
    /// <inheritdoc />
    public partial class TablePerTypeConcept : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stagioni_Videos_SerieTvId",
                table: "Stagioni");

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

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Utenti",
                newName: "NomeUtente");

            migrationBuilder.RenameColumn(
                name: "Data_Subscription",
                table: "Utenti",
                newName: "DataCreazione");

            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    DurataInMin = table.Column<int>(type: "int", nullable: false),
                    DataInizio = table.Column<DateOnly>(type: "date", nullable: false),
                    DataFine = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Films_Videos_Id",
                        column: x => x.Id,
                        principalTable: "Videos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SerieTvs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Completata = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SerieTvs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SerieTvs_Videos_Id",
                        column: x => x.Id,
                        principalTable: "Videos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Stagioni_SerieTvs_SerieTvId",
                table: "Stagioni",
                column: "SerieTvId",
                principalTable: "SerieTvs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stagioni_SerieTvs_SerieTvId",
                table: "Stagioni");

            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "SerieTvs");

            migrationBuilder.RenameColumn(
                name: "NomeUtente",
                table: "Utenti",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "DataCreazione",
                table: "Utenti",
                newName: "Data_Subscription");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Stagioni_Videos_SerieTvId",
                table: "Stagioni",
                column: "SerieTvId",
                principalTable: "Videos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
