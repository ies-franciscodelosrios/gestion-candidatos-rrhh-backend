using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IGapi.Migrations
{
    /// <inheritdoc />
    public partial class Spring1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offer_Application_Candidates_CandidateId",
                table: "Offer_Application");

            migrationBuilder.DropForeignKey(
                name: "FK_Offer_Application_Offer_OfferId",
                table: "Offer_Application");

            migrationBuilder.DropIndex(
                name: "IX_Offer_Application_CandidateId",
                table: "Offer_Application");

            migrationBuilder.DropIndex(
                name: "IX_Offer_Application_OfferId",
                table: "Offer_Application");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Offer",
                table: "Offer");

            migrationBuilder.DropColumn(
                name: "CandidateId",
                table: "Offer_Application");

            migrationBuilder.DropColumn(
                name: "OfferId",
                table: "Offer_Application");

            migrationBuilder.DropColumn(
                name: "Technical_Test",
                table: "Offer_Application");

            migrationBuilder.RenameTable(
                name: "Offer",
                newName: "OfertasdeTrabajo");

            migrationBuilder.RenameColumn(
                name: "Id_Oferta",
                table: "Offer_Application",
                newName: "id_Oferta");

            migrationBuilder.AlterColumn<int>(
                name: "id_Oferta",
                table: "Offer_Application",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Id_Candidate",
                table: "Offer_Application",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OfertasdeTrabajo",
                table: "OfertasdeTrabajo",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Offer_Application_Id_Candidate",
                table: "Offer_Application",
                column: "Id_Candidate");

            migrationBuilder.CreateIndex(
                name: "IX_Offer_Application_id_Oferta",
                table: "Offer_Application",
                column: "id_Oferta");

            migrationBuilder.AddForeignKey(
                name: "FK_Offer_Application_Candidates_Id_Candidate",
                table: "Offer_Application",
                column: "Id_Candidate",
                principalTable: "Candidates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Offer_Application_OfertasdeTrabajo_id_Oferta",
                table: "Offer_Application",
                column: "id_Oferta",
                principalTable: "OfertasdeTrabajo",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offer_Application_Candidates_Id_Candidate",
                table: "Offer_Application");

            migrationBuilder.DropForeignKey(
                name: "FK_Offer_Application_OfertasdeTrabajo_id_Oferta",
                table: "Offer_Application");

            migrationBuilder.DropIndex(
                name: "IX_Offer_Application_Id_Candidate",
                table: "Offer_Application");

            migrationBuilder.DropIndex(
                name: "IX_Offer_Application_id_Oferta",
                table: "Offer_Application");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OfertasdeTrabajo",
                table: "OfertasdeTrabajo");

            migrationBuilder.RenameTable(
                name: "OfertasdeTrabajo",
                newName: "Offer");

            migrationBuilder.RenameColumn(
                name: "id_Oferta",
                table: "Offer_Application",
                newName: "Id_Oferta");

            migrationBuilder.AlterColumn<int>(
                name: "Id_Oferta",
                table: "Offer_Application",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id_Candidate",
                table: "Offer_Application",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CandidateId",
                table: "Offer_Application",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OfferId",
                table: "Offer_Application",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<byte[]>(
                name: "Technical_Test",
                table: "Offer_Application",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Offer",
                table: "Offer",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Offer_Application_CandidateId",
                table: "Offer_Application",
                column: "CandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_Offer_Application_OfferId",
                table: "Offer_Application",
                column: "OfferId");

            migrationBuilder.AddForeignKey(
                name: "FK_Offer_Application_Candidates_CandidateId",
                table: "Offer_Application",
                column: "CandidateId",
                principalTable: "Candidates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Offer_Application_Offer_OfferId",
                table: "Offer_Application",
                column: "OfferId",
                principalTable: "Offer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
