using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Pedido
    {
        [Key]
        public int IdPedido { get; set; }
        public string NomePedido { get; set; }
        public string DataPedido { get; set; }
        public string TipoPedido { get; set; }

        public virtual Produtos Produtos { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
