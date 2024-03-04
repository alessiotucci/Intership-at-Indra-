using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetflixClone.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profili_Utenti_Id_Utente",
                table: "Profili");

            migrationBuilder.RenameColumn(
                name: "Id_Serie",
                table: "Stagioni",
                newName: "SerieTvId");

            migrationBuilder.RenameColumn(
                name: "Id_Utente",
                table: "Profili",
                newName: "UtenteId");

            migrationBuilder.RenameIndex(
                name: "IX_Profili_Id_Utente",
                table: "Profili",
                newName: "IX_Profili_UtenteId");

            migrationBuilder.RenameColumn(
                name: "Id_Stagione",
                table: "Episodi",
                newName: "StagioneId");

            migrationBuilder.AlterColumn<string>(
                name: "Sinossi",
                table: "Episodi",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Stagioni_SerieTvId",
                table: "Stagioni",
                column: "SerieTvId");

            migrationBuilder.AddForeignKey(
                name: "FK_Profili_Utenti_UtenteId",
                table: "Profili",
                column: "UtenteId",
                principalTable: "Utenti",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stagioni_Videos_SerieTvId",
                table: "Stagioni",
                column: "SerieTvId",
                principalTable: "Videos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profili_Utenti_UtenteId",
                table: "Profili");

            migrationBuilder.DropForeignKey(
                name: "FK_Stagioni_Videos_SerieTvId",
                table: "Stagioni");

            migrationBuilder.DropIndex(
                name: "IX_Stagioni_SerieTvId",
                table: "Stagioni");

            migrationBuilder.RenameColumn(
                name: "SerieTvId",
                table: "Stagioni",
                newName: "Id_Serie");

            migrationBuilder.RenameColumn(
                name: "UtenteId",
                table: "Profili",
                newName: "Id_Utente");

            migrationBuilder.RenameIndex(
                name: "IX_Profili_UtenteId",
                table: "Profili",
                newName: "IX_Profili_Id_Utente");

            migrationBuilder.RenameColumn(
                name: "StagioneId",
                table: "Episodi",
                newName: "Id_Stagione");

            migrationBuilder.AlterColumn<string>(
                name: "Sinossi",
                table: "Episodi",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Profili_Utenti_Id_Utente",
                table: "Profili",
                column: "Id_Utente",
                principalTable: "Utenti",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
