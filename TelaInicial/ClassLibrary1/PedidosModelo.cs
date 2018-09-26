using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class PedidosModelo
    {
        
        public int idPedido { get; set; }
        public String NomePedido { get; set; }
        public String DataPedido { get; set; }
        public String TipoPedido { get; set; }
        public int idUsuario { get; set; }
        public int idProduto { get; set; }


    }
}
