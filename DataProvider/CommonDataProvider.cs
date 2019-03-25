using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider
{
    public class CommonDataProvider
    {
        /// <summary>
        /// Obtenemos la cadena de conexion del web.config.
        /// </summary>
        /// <returns></returns>
        public static String ObtenerCadena()
        {
            String conn = ConfigurationManager.AppSettings["sqlconn"];
            return conn;
        }

    }
}
