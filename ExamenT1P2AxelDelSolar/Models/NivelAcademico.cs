using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ExamenT1P2AxelDelSolar.Models
{
    [Table("nivel_academico")]
    public class NivelAcademico
    {  
            [Key]
            [Column("nivel_academico_id")]
            public int NivelAcademicoId { get; set; }



            [Required]
            [MaxLength(100)]
            public string Descripcion { get; set; } = string.Empty;

        
            public int Orden { get; set; }

            // Relación 1:N
            [JsonIgnore]
            public ICollection<Curso>? Cursos { get; set; }

            public NivelAcademico()
            {
                Cursos = new List<Curso>();
            }
    }
}

