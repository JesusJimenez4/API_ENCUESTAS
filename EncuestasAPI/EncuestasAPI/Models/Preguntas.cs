using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

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
        [Required]
        public string Pregunta { get; set; }
        [ForeignKey("fk_Encuestas")]
        [Column("IdEncuestas")]
        public int? IdEncuestas { get; set; }

        [JsonIgnore]
        public Encuesta fk_Encuestas { get; set; }

    }
}
