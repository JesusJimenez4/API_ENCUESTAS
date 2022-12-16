using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json.Serialization;

namespace EncuestasAPI.Models
{
    [Table("Respuestas")]
    public class Respuestas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdRespuesta")]
        public int IdRespuesta { get; set; }
        [Column("Opcion")]
        [Required]
        public int Opcion { get; set; }
        [Column("RespuestaAbierta")]
        [Required]
        public string RespuestaAbierta { get; set; }
        [ForeignKey("fk_Pregunta")]
        [Column("IdPregunta")]
        public int? IdPregunta { get; set; }

        [JsonIgnore]
        public Preguntas fk_Pregunta { get; set; }


    }
}
