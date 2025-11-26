using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ExamenT1P2AxelDelSolar.Models
{
    [Table("Cursos")]
    public class Curso
    {
        [Key]
        [Column("curso_id")]
        public int CursoId { get; set; }

        [Required(ErrorMessage ="El código del curso es obligatorio")]
        [Column("codigo_curso")]
        [MaxLength(50, ErrorMessage ="El código del curso no puede exceder los 10 caracteres")]
        public String CodigoCurso { get; set; } = string.Empty;

        [Required]
        [Column("creditos")]
        public int Creditos { get; set; }

        [Column("horas_semanales")]
        public int HorasSemanales { get; set; }

        [ForeignKey("NivelAcademico")]
        [Column("nivel_academico_id")]
        public int NivelAcademicoId { get; set; }

        
        [JsonIgnore]
        public NivelAcademico? NivelAcademico { get; set; }

    }
}
