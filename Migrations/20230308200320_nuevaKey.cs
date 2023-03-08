using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IGApi.Migrations
{
    /// <inheritdoc />
    public partial class nuevaKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidato_Rol_Rolid",
                table: "Candidato");

            migrationBuilder.AlterColumn<int>(
                name: "Rolid",
                table: "Candidato",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Candidato_Rol_Rolid",
                table: "Candidato",
                column: "Rolid",
                principalTable: "Rol",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidato_Rol_Rolid",
                table: "Candidato");

            migrationBuilder.AlterColumn<int>(
                name: "Rolid",
                table: "Candidato",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidato_Rol_Rolid",
                table: "Candidato",
                column: "Rolid",
                principalTable: "Rol",
                principalColumn: "Id");
        }
    }
}
