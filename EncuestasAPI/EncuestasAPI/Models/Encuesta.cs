using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

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

        [ForeignKey("fk_Usuario")]
        [Column("Id")]
        public int? Id { get; set; }
        [ForeignKey("fk_Categoria")]
        [Column("IdCategoria")]
        public int? IdCategoria { get; set; }

        [JsonIgnore]
        public Usuario fk_Usuario { get; set; }
        [JsonIgnore]
        public Cateegoria fk_Categoria { get; set; }
    }
}
}
