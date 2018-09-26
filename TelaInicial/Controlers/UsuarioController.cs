using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using Modelos;
using Controllers;

namespace Controllers
{
    public class UsuarioController : IBaseController<UsuarioController>
    {
        private Contexto contexto = new Contexto();

        public void Adicionar(UsuarioController P)
        {
            contexto.Usuarios.Add(P);
            contexto.SaveChanges();

        }

    }
}
