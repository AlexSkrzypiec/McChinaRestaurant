//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Pedidos
    {
        [Key]    
        public int idPedido { get; set; }
        public string NomePedido { get; set; }
        public string DataPedido { get; set; }
        public string TipoPedido { get; set; }
        public Nullable<int> idUsuario { get; set; }
        public Nullable<int> idProduto { get; set; }
    
        public virtual Produtos Produtos { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}
