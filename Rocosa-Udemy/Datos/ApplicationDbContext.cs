using Microsoft.EntityFrameworkCore;
using Rocosa_Udemy.Models;

namespace Rocosa_Udemy.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        // Traer todos los modelos creados
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<TipoAplicacion> TipoAplicacion { get; set; }
    }
}
