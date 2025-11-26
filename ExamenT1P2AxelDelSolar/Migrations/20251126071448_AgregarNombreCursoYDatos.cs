using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamenT1P2AxelDelSolar.Migrations
{
    /// <inheritdoc />
    public partial class AgregarNombreCursoYDatos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "nombre_curso",
                table: "Cursos",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Cursos",
                keyColumn: "curso_id",
                keyValue: 1,
                column: "nombre_curso",
                value: "Introducción a la Computación");

            migrationBuilder.UpdateData(
                table: "Cursos",
                keyColumn: "curso_id",
                keyValue: 2,
                column: "nombre_curso",
                value: "Algoritmos y Estructuras");

            migrationBuilder.UpdateData(
                table: "Cursos",
                keyColumn: "curso_id",
                keyValue: 3,
                column: "nombre_curso",
                value: "Gestión de Proyectos TI");

            migrationBuilder.UpdateData(
                table: "Cursos",
                keyColumn: "curso_id",
                keyValue: 4,
                column: "nombre_curso",
                value: "Fundamentos de Marketing");

            migrationBuilder.UpdateData(
                table: "Cursos",
                keyColumn: "curso_id",
                keyValue: 5,
                column: "nombre_curso",
                value: "Estrategias Digitales");

            migrationBuilder.UpdateData(
                table: "Cursos",
                keyColumn: "curso_id",
                keyValue: 6,
                column: "nombre_curso",
                value: "Base de Datos Avanzada");

            migrationBuilder.UpdateData(
                table: "Cursos",
                keyColumn: "curso_id",
                keyValue: 7,
                column: "nombre_curso",
                value: "Inteligencia de Negocios");

            migrationBuilder.UpdateData(
                table: "Cursos",
                keyColumn: "curso_id",
                keyValue: 8,
                column: "nombre_curso",
                value: "Seminario de Tesis");

            migrationBuilder.UpdateData(
                table: "Cursos",
                keyColumn: "curso_id",
                keyValue: 9,
                column: "nombre_curso",
                value: "Arquitectura de Software");

            migrationBuilder.UpdateData(
                table: "Cursos",
                keyColumn: "curso_id",
                keyValue: 10,
                column: "nombre_curso",
                value: "Ética Profesional");

            migrationBuilder.UpdateData(
                table: "Cursos",
                keyColumn: "curso_id",
                keyValue: 11,
                column: "nombre_curso",
                value: "Experiencia de Usuario (UX)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "nombre_curso",
                table: "Cursos");
        }
    }
}
