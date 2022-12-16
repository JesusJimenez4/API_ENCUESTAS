using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

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
        public int Opcion { get; set; }
        [Column("RespuestaAbierta")]
        public string RespuestaAbierta { get; set; }


    }
}
