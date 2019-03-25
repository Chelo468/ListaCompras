using DataProvider;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class UsuarioService
    {
        public static bool registrar(Usuario usuario, out string error)
        {
            error = "";

            if(validarUsuario(usuario))
            {
                if (string.IsNullOrEmpty(error))
                    return UsuarioDataProvider.registrar(usuario);
            }

            

            return false;
        }

        private static bool validarUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public static Usuario getUsuario(string nombre_usuario, string password)
        {
            return UsuarioDataProvider.getUsuario(nombre_usuario, password);
        }
    }
}
