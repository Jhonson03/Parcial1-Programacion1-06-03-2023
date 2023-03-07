using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial1.Entidades;

namespace Parcial1.Negocio
{
    public class ClsUsuario
    {
        public bool Autenticacion(Usuario user)
        {
            if (user.usuario.Equals("TUNOMBRE") && user.password.Equals("123"))
            {
                return true;
            }
            return false;
        }
    }
}
