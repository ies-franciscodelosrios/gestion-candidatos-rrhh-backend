using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IGapi.Migrations
{
    /// <inheritdoc />
    public partial class Relaciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id_Offer",
                table: "Offer");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Offer_Application",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

            migrationBuilder.AlterColumn<int>(
                name: "Id_Selected",
                table: "Offer",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CandidateId",
                table: "Offer",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthdate",
                table: "Candidates",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.CreateIndex(
                name: "IX_Offer_Application_CandidateId",
                table: "Offer_Application",
                column: "CandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_Offer_Application_OfferId",
                table: "Offer_Application",
                column: "OfferId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offer_Candidates_CandidateId",
                table: "Offer");

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

            migrationBuilder.DropIndex(
                name: "IX_Offer_CandidateId",
                table: "Offer");

            migrationBuilder.DropColumn(
                name: "CandidateId",
                table: "Offer_Application");

            migrationBuilder.DropColumn(
                name: "OfferId",
                table: "Offer_Application");

            migrationBuilder.DropColumn(
                name: "CandidateId",
                table: "Offer");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Offer_Application",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id_Selected",
                table: "Offer",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id_Offer",
                table: "Offer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthdate",
                table: "Candidates",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
