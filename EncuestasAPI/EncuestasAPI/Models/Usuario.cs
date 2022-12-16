using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EncuestasAPI.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }
        [Column("Nombre")]
        public string Nombre { get; set; }
        [Column("ApellidoPaterno")]
        public string ApellidoPaterno { get; set; }
        [Column("ApellidoMaterno")]
        public string ApellidoMaterno { get; set; }
        [Column("Email")]
        public string Email { get; set; }
        [Column("Estatus")]
        public string Estatus { get; set; }
        [Column("Rol")]
        public string Rol { get; set; }
        [Column("Pass")]
        public string Pass { get; set; }
        [Column("Foto")]
        public string Foto { get; set; }
    }
}
