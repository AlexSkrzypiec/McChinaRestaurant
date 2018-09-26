using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class UsuariosModelo
    {
        [Key]
        public int idUsuario { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }

        public virtual PedidosModelo Pedidos { get; set; }

}
}
