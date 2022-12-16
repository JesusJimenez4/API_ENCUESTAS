using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EncuestasAPI.Models
{
    public class DB: DbContext
    {
        public DB(DbContextOptions<DB> options) : base(options) { }
        public DbSet<Cateegoria> Cateegoria { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Encuesta> Encuesta { get; set; }
        public DbSet<Preguntas> Preguntas { get; set; }
        public DbSet<Respuestas> Respuestas { get; set; }

    }
}
