using Modelos;
using System.Data.Entity;

namespace Controllers
{
    public class Contexto : DbContext
    {
        public Contexto() : base("McChinaBD")

        {
        }
        public virtual DbSet<Pedidos> Pedidos { get; set; }
        public virtual DbSet<Produtos> Produtos { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

    }
}
