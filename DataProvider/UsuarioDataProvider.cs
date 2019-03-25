using Entidades;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace DataProvider
{
    public class UsuarioDataProvider
    {
        public static Usuario getUsuario(string nombre_usuario, string password)
        {
            Usuario usuario = new Usuario();

            string storedProcedure = "";

            object[] parametros = new object[2];

            try
            {
                parametros[0] = nombre_usuario;
                parametros[1] = password;

                DataTable result = SqlHelper.ExecuteDataset(CommonDataProvider.ObtenerCadena(), storedProcedure, parametros).Tables[0];

                usuario = (Usuario)Util.DataTableToObjectList(result, typeof(Usuario)).FirstOrDefault();
            }
            catch (Exception ex)
            {
                string mensajeOpcional = "SP: " + storedProcedure;

                if(parametros.Length > 0)
                {
                    mensajeOpcional += " | Parametros: ";
                    for (int i = 0; i < parametros.Length; i++)
                    {
                        mensajeOpcional += parametros[i] + ",";
                    }

                    mensajeOpcional.Substring(0, mensajeOpcional.Length - 1);
                }

                SimpleLog.GuardarDataLog(ex, "DataProvider", "UsuarioDataProvider", "getUsuario", mensajeOpcional);
                throw ex;
            }            

            return usuario;
        }

        public static bool registrar(Usuario usuario)
        {
            bool resultado = false;

            string storedProcedure = "usuario_insert";

            object[] parametros = new object[6];

            try
            {
                parametros[0] = usuario.nombre_usuario;
                parametros[1] = usuario.password;
                parametros[2] = DateTime.Now;
                parametros[3] = usuario.calle;
                parametros[4] = usuario.calle_nro;
                parametros[5] = usuario.telefono;

                DataTable result = SqlHelper.ExecuteDataset(CommonDataProvider.ObtenerCadena(),storedProcedure, parametros).Tables[0];

                if(result.Rows.Count > 0)
                {
                    int id_usuario = int.Parse(result.Rows[0][0].ToString());

                    if (id_usuario > 0)
                        resultado = true;
                }

                
            }
            catch (Exception ex)
            {
                string mensajeOpcional = "SP: " + storedProcedure;

                if (parametros.Length > 0)
                {
                    mensajeOpcional += " | Parametros: ";
                    for (int i = 0; i < parametros.Length; i++)
                    {
                        mensajeOpcional += parametros[i] + ",";
                    }

                    mensajeOpcional.Substring(0, mensajeOpcional.Length - 1);
                }

                SimpleLog.GuardarDataLog(ex, "DataProvider", "UsuarioDataProvider", "registrar", mensajeOpcional);
                throw ex;
            }


            return resultado;
        }
    }
}
