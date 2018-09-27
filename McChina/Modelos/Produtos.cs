using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Produtos
    {
        [Key]
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public double ValorProduto { get; set; }
       
        public virtual ICollection<Pedido> Pedido { get; set; }
    }
}
