using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EncuestasAPI.Models
{
    [Table("Categoria")]
    public class Cateegoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdCategoria")]
        public int Id { get; set; }
        [Column("NombreCategoria")]
        [Required]
        public string NombreCategoria { get; set; }
    }
}
