using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetflixClone.Migrations
{
    /// <inheritdoc />
    public partial class FluentApi1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Films_Videos_Id",
                table: "Films");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfiloVideo_Videos_VideoVistiId",
                table: "ProfiloVideo");

            migrationBuilder.DropForeignKey(
                name: "FK_SerieTvs_Videos_Id",
                table: "SerieTvs");

            migrationBuilder.DropForeignKey(
                name: "FK_Stagioni_SerieTvs_SerieTvId",
                table: "Stagioni");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Videos",
                table: "Videos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SerieTvs",
                table: "SerieTvs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Films",
                table: "Films");

            migrationBuilder.RenameTable(
                name: "Videos",
                newName: "Video");

            migrationBuilder.RenameTable(
                name: "SerieTvs",
                newName: "SerieTv");

            migrationBuilder.RenameTable(
                name: "Films",
                newName: "Film");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Video",
                table: "Video",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SerieTv",
                table: "SerieTv",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Film",
                table: "Film",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Film_Video_Id",
                table: "Film",
                column: "Id",
                principalTable: "Video",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProfiloVideo_Video_VideoVistiId",
                table: "ProfiloVideo",
                column: "VideoVistiId",
                principalTable: "Video",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SerieTv_Video_Id",
                table: "SerieTv",
                column: "Id",
                principalTable: "Video",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stagioni_SerieTv_SerieTvId",
                table: "Stagioni",
                column: "SerieTvId",
                principalTable: "SerieTv",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Film_Video_Id",
                table: "Film");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfiloVideo_Video_VideoVistiId",
                table: "ProfiloVideo");

            migrationBuilder.DropForeignKey(
                name: "FK_SerieTv_Video_Id",
                table: "SerieTv");

            migrationBuilder.DropForeignKey(
                name: "FK_Stagioni_SerieTv_SerieTvId",
                table: "Stagioni");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Video",
                table: "Video");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SerieTv",
                table: "SerieTv");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Film",
                table: "Film");

            migrationBuilder.RenameTable(
                name: "Video",
                newName: "Videos");

            migrationBuilder.RenameTable(
                name: "SerieTv",
                newName: "SerieTvs");

            migrationBuilder.RenameTable(
                name: "Film",
                newName: "Films");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Videos",
                table: "Videos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SerieTvs",
                table: "SerieTvs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Films",
                table: "Films",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Films_Videos_Id",
                table: "Films",
                column: "Id",
                principalTable: "Videos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProfiloVideo_Videos_VideoVistiId",
                table: "ProfiloVideo",
                column: "VideoVistiId",
                principalTable: "Videos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SerieTvs_Videos_Id",
                table: "SerieTvs",
                column: "Id",
                principalTable: "Videos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stagioni_SerieTvs_SerieTvId",
                table: "Stagioni",
                column: "SerieTvId",
                principalTable: "SerieTvs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
