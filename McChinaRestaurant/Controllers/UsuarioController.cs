using Controllers.Base;
using Controllers.DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class UsuarioController : IBaseController<Usuario>
    {

        Contexto contexto = new Contexto();

        public void Adicionar(Usuario P)
        {
            contexto.Usuario.Add(P);
            contexto.SaveChanges();

        }

    }
}
