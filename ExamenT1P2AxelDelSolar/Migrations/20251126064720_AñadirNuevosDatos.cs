using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExamenT1P2AxelDelSolar.Migrations
{
    /// <inheritdoc />
    public partial class AñadirNuevosDatos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "curso_id", "codigo_curso", "creditos", "horas_semanales", "nivel_academico_id" },
                values: new object[,]
                {
                    { 5, "DIP002", 3, 3, 3 },
                    { 6, "DIP003", 4, 6, 1 },
                    { 7, "DIP004", 5, 5, 1 },
                    { 8, "DIP005", 1, 4, 2 },
                    { 9, "DIP006", 3, 7, 2 },
                    { 10, "DIP007", 2, 3, 1 },
                    { 11, "DIP008", 5, 2, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cursos",
                keyColumn: "curso_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cursos",
                keyColumn: "curso_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cursos",
                keyColumn: "curso_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cursos",
                keyColumn: "curso_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cursos",
                keyColumn: "curso_id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cursos",
                keyColumn: "curso_id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cursos",
                keyColumn: "curso_id",
                keyValue: 11);
        }
    }
}
