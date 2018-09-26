using Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
