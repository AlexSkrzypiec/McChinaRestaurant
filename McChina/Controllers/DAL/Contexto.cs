using Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.DAL
{
    public class Contexto : DbContext
    {
        public Contexto() : base("DBChina")

        {
        }
        public virtual DbSet<Pedido> Pedido { get; set; }
        public virtual DbSet<Produtos> Produtos { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }


    }
}
