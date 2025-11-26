using ExamenT1P2AxelDelSolar.Models;
using Microsoft.EntityFrameworkCore;

namespace ExamenT1P2AxelDelSolar.Data
{
    public class DataDBContext : DbContext
    {
        public DataDBContext(DbContextOptions<DataDBContext> options) : base(options)
        {
        }

        public DbSet<Curso> Cursos { get; set; }
        public DbSet<NivelAcademico> NivelAcademicos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<NivelAcademico>()
                .HasMany(n => n.Cursos)
                .WithOne(c => c.NivelAcademico)
                .HasForeignKey(c => c.NivelAcademicoId);

            modelBuilder.Entity<NivelAcademico>().HasData(
                new NivelAcademico { NivelAcademicoId = 1, Descripcion = "Pregrado", Orden = 1 },
                new NivelAcademico { NivelAcademicoId = 2, Descripcion = "Maestría", Orden = 2 },
                new NivelAcademico { NivelAcademicoId = 3, Descripcion = "Diplomado", Orden = 3 }
            );

            modelBuilder.Entity<Curso>().HasData(
                new Curso { CursoId = 1, CodigoCurso = "CS101",  Creditos = 4, HorasSemanales = 6, NivelAcademicoId = 1 },
                new Curso { CursoId = 2, CodigoCurso = "CS102", Creditos = 5, HorasSemanales = 6, NivelAcademicoId = 1 },
                new Curso { CursoId = 3, CodigoCurso = "MST500",  Creditos = 5, HorasSemanales = 5, NivelAcademicoId = 2 },
                new Curso { CursoId = 4, CodigoCurso = "DIP001",  Creditos = 3, HorasSemanales = 3, NivelAcademicoId = 3 }
            );

        }

    }
}
