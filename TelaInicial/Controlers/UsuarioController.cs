using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Controllers
{
    public class UsuarioController : IBaseController<Usuarios>
    {
        Contexto contexto = new Contexto();

  
        public void Adicionar(Usuarios P)
        {
            contexto.Usuarios.Add(P);
            contexto.SaveChanges();
            throw new NotImplementedException();
        }
    }
}
    