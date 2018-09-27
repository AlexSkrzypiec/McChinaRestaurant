using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Produtos
    {
        [Key]
        public int IdProduto { get; set; }
        public String NomeProduto { get; set; }
        public float ValorProduto { get; set; }

    }
}
