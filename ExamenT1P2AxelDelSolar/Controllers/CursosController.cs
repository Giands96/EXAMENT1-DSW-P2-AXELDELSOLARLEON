using ExamenT1P2AxelDelSolar.Data;
using ExamenT1P2AxelDelSolar.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ExamenT1P2AxelDelSolar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursosController : ControllerBase
    {

        private readonly DataDBContext _context;

        // Inyección de la base de datos
        public CursosController(DataDBContext context)
        {
            _context = context;
        }

        // c. GET: Listar todos los cursos con sus niveles académicos incluidos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Curso>>> GetCursos()
        {
            
            return await _context.Cursos
                                 .Include(c => c.NivelAcademico)
                                 .ToListAsync();
        }

        // d. GET: Obtener cursos por nivel académico
        [HttpGet("por-nivel/{nivelId}")]
        public async Task<ActionResult<IEnumerable<Curso>>> ListarCursosPorNivel(int nivelId, [FromQuery] int pagina = 1, [FromQuery] int cantidad = 10)
        {

            if (pagina <= 0) pagina = 1;
            if (cantidad <= 0) cantidad = 10;

            var queryPagina = _context.Cursos
                                        .Include(c => c.NivelAcademico)
                                        .Where(c => c.NivelAcademicoId == nivelId);

            var cursosPaginados = await queryPagina
                                .Skip((pagina - 1) * cantidad)
                                .Take(cantidad)
                                .ToListAsync();

            if (!cursosPaginados.Any())
            {
                return NotFound($"No hay cursos en la página {pagina} para el nivel {nivelId}");
            }

            return cursosPaginados;
        }

        // e. POST: Crear un nuevo curso
        [HttpPost]
        public async Task<ActionResult<Curso>> PostCurso(Curso curso)
        {
            var nivelExiste = await _context.NivelAcademicos.AnyAsync(n => n.NivelAcademicoId == curso.NivelAcademicoId);
            if (!nivelExiste)
            {
                return BadRequest("El Nivel Académico especificado no existe.");
            }

            _context.Cursos.Add(curso);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCursos", new { id = curso.CursoId }, curso);
        }

        // f. PUT: Actualizar un curso existente
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCurso(int id, Curso curso)
        {
            if (id != curso.CursoId)
            {
                return BadRequest("El ID del curso no coincide.");
            }

            _context.Entry(curso).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CursoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        private bool CursoExists(int id)
        {
            return _context.Cursos.Any(e => e.CursoId == id);
        }

    }
}
