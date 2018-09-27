using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Pedido
    {
        [Key]
        public int IdPedido { get; set; }
        public string NomePedido { get; set; }
        public string DataPedido { get; set; }
        public string TipoPedido { get; set; }
        public int IdUsuario { get; set; }

        public virtual Usuario _User { get; set; }

    }
}
