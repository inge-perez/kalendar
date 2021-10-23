using Microsoft.EntityFrameworkCore.Migrations;

namespace AppEventos.Server.Migrations
{
    public partial class UpMunicipioNombre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Municipio_Departamentos_DepartamentoId",
                table: "Municipio");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Municipio",
                table: "Municipio");

            migrationBuilder.RenameTable(
                name: "Municipio",
                newName: "Municipios");

            migrationBuilder.RenameIndex(
                name: "IX_Municipio_DepartamentoId",
                table: "Municipios",
                newName: "IX_Municipios_DepartamentoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Municipios",
                table: "Municipios",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Municipios_Departamentos_DepartamentoId",
                table: "Municipios",
                column: "DepartamentoId",
                principalTable: "Departamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Municipios_Departamentos_DepartamentoId",
                table: "Municipios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Municipios",
                table: "Municipios");

            migrationBuilder.RenameTable(
                name: "Municipios",
                newName: "Municipio");

            migrationBuilder.RenameIndex(
                name: "IX_Municipios_DepartamentoId",
                table: "Municipio",
                newName: "IX_Municipio_DepartamentoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Municipio",
                table: "Municipio",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Municipio_Departamentos_DepartamentoId",
                table: "Municipio",
                column: "DepartamentoId",
                principalTable: "Departamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
