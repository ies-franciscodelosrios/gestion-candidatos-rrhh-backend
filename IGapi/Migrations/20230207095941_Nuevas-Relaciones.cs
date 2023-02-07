using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IGapi.Migrations
{
    /// <inheritdoc />
    public partial class NuevasRelaciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offer_Candidates_CandidateId",
                table: "Offer");

            migrationBuilder.DropIndex(
                name: "IX_Offer_CandidateId",
                table: "Offer");

            migrationBuilder.DropColumn(
                name: "CandidateId",
                table: "Offer");

            migrationBuilder.DropColumn(
                name: "Id_Selected",
                table: "Offer");

            migrationBuilder.DropColumn(
                name: "IsAccepted",
                table: "Candidates");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CandidateId",
                table: "Offer",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id_Selected",
                table: "Offer",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsAccepted",
                table: "Candidates",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Offer_CandidateId",
                table: "Offer",
                column: "CandidateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Offer_Candidates_CandidateId",
                table: "Offer",
                column: "CandidateId",
                principalTable: "Candidates",
                principalColumn: "Id");
        }
    }
}
