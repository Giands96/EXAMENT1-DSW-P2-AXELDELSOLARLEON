using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExamenT1P2AxelDelSolar.Migrations
{
    /// <inheritdoc />
    public partial class CorregirTablaNivelAcademico : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "nivel_academico",
                newName: "Descripcion");

            migrationBuilder.AddColumn<int>(
                name: "Orden",
                table: "nivel_academico",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "nivel_academico",
                columns: new[] { "nivel_academico_id", "Descripcion", "Orden" },
                values: new object[,]
                {
                    { 1, "Pregrado", 1 },
                    { 2, "Maestría", 2 },
                    { 3, "Diplomado", 3 }
                });

            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "curso_id", "codigo_curso", "creditos", "horas_semanales", "nivel_academico_id" },
                values: new object[,]
                {
                    { 1, "CS101", 4, 6, 1 },
                    { 2, "CS102", 5, 6, 1 },
                    { 3, "MST500", 5, 5, 2 },
                    { 4, "DIP001", 3, 3, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cursos",
                keyColumn: "curso_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cursos",
                keyColumn: "curso_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cursos",
                keyColumn: "curso_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cursos",
                keyColumn: "curso_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "nivel_academico",
                keyColumn: "nivel_academico_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "nivel_academico",
                keyColumn: "nivel_academico_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "nivel_academico",
                keyColumn: "nivel_academico_id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Orden",
                table: "nivel_academico");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "nivel_academico",
                newName: "nombre");
        }
    }
}
