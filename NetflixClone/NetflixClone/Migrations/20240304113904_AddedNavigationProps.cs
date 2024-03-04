using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetflixClone.Migrations
{
    /// <inheritdoc />
    public partial class AddedNavigationProps : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Episodi_StagioneId",
                table: "Episodi",
                column: "StagioneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Episodi_Stagioni_StagioneId",
                table: "Episodi",
                column: "StagioneId",
                principalTable: "Stagioni",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Episodi_Stagioni_StagioneId",
                table: "Episodi");

            migrationBuilder.DropIndex(
                name: "IX_Episodi_StagioneId",
                table: "Episodi");
        }
    }
}
