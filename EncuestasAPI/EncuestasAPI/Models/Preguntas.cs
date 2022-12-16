using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace EncuestasAPI.Models
{
    [Table("Preguntas")]
    public class Preguntas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdPreguntas")]
        public int IdPreguntas { get; set; }
        [Column("Pregunta")]
        public string Pregunta { get; set; }

    }
}
