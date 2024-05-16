using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Servidor.Migrations
{
    /// <inheritdoc />
    public partial class CombioId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Usuarios",
                newName: "UsuarioId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Comentarios",
                newName: "ComentarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Usuarios",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ComentarioId",
                table: "Comentarios",
                newName: "Id");
        }
    }
}
