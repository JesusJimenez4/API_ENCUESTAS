using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EncuestasAPI.Models
{
    [Table("Encuesta")]
    public class Encuesta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdEncuesta")]
        public int IdEncuesta { get; set; }
        [Column("NombreEncuesta")]
        [Required]
        public string NombreEncuesta { get; set; }
        [Column("EstatusEncuesta")]
        [Required]
        public string Estatus { get; set; }
        [Column("FechaEntrada")]
        [Required]
        public string FechaEntrada { get; set; }
    }
}
