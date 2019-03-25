using System;
using System.Configuration;
using System.Text;
using System.IO;

namespace Utils
{
    public class SimpleLog
    {
        //private static SimpleLog _objSimpleLog;
        //private static bool _blCreated;

        


        ///// <summary>
        ///// Implementacion Singleton de la conexion
        ///// </summary>
        ///// <returns></returns>
        //public static SimpleLog Instancia()
        //{
        //    if (_blCreated == false)
        //    {
        //        _objSimpleLog = new SimpleLog();
        //        _blCreated = true;
        //        return _objSimpleLog;
        //    }
        //    return _objSimpleLog;
        //}


        ///// <summary>
        ///// Constructor de la clase (Oculto)
        ///// </summary>
        //private SimpleLog()
        //{

        //}
        


        /// <summary>
        /// Registra una entrada en el log de Presentacion
        /// </summary>
        /// <returns></returns>
        public static void GuardarWebLog(string message, string nameSpace, string clase, string metodo)
        {
            if (Convert.ToBoolean(ConfigurationManager.AppSettings["EnableDebugLogs"]))
            {
                string filePath = ConfigurationManager.AppSettings["WebLogFilePath"];

                StreamWriter sw = null;
                try
                {
                    //Preparar el mensaje
                    var strBuider = new StringBuilder();
                    strBuider.Append("FECHA: ");
                    strBuider.Append(DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString() + ", " + Environment.NewLine);
                    strBuider.Append("NIVEL EN DEPLOY: " + nameSpace + ". " + Environment.NewLine);
                    strBuider.Append("CLASE GENERADORA: " + clase + ". " + Environment.NewLine);
                    strBuider.Append("METODO: " + metodo + ". " + Environment.NewLine);
                    strBuider.Append("Excepcion completa: " + Environment.NewLine + message + Environment.NewLine);
                    strBuider.Append("-------------------------------------------------------------------- " + Environment.NewLine + Environment.NewLine);

                    sw = new StreamWriter(filePath, true, Encoding.UTF8);
                    sw.WriteLine(strBuider.ToString());
                    sw.Close();
                }
                catch (Exception)
                {
                    //throw new Exception("Error al intentar generar el LOG del servicio (WebLog).");
                }
                finally
                {
                    if (sw != null) sw.Dispose();
                }
            }
        }



        /// <summary>
        /// Registra una entrada en el log de comportamiento
        /// </summary>
        /// <returns></returns>
        public static void GuardarComportamientoLog(string message, string nameSpace, string clase, string metodo)
        {
            if (Convert.ToBoolean(ConfigurationManager.AppSettings["EnableDebugLogs"]))
            {
                string filePath = ConfigurationManager.AppSettings["ComportamientoLogFilePath"];

                StreamWriter sw = null;
                try
                {
                    //Preparar el mensaje
                    var strBuider = new StringBuilder();
                    strBuider.Append("FECHA: ");
                    strBuider.Append(DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString() + ", " + Environment.NewLine);
                    strBuider.Append("NIVEL EN DEPLOY: " + nameSpace + ". " + Environment.NewLine);
                    strBuider.Append("CLASE GENERADORA: " + clase + ". " + Environment.NewLine);
                    strBuider.Append("METODO: " + metodo + ". " + Environment.NewLine);
                    strBuider.Append("Excepcion completa: " + Environment.NewLine + message + Environment.NewLine);
                    strBuider.Append("-------------------------------------------------------------------- " + Environment.NewLine + Environment.NewLine);

                    sw = new StreamWriter(filePath, true, Encoding.UTF8);
                    sw.WriteLine(strBuider.ToString());
                    sw.Close();
                }
                catch (Exception)
                {
                    //throw ex;
                    //throw new Exception("Error al intentar generar el LOG del servicio (Comportamiento).");
                }
                finally
                {
                    if (sw != null) sw.Dispose();
                }
            }





            //StreamWriter sw2 = null;
            //try
            //{
            //    var strBuider = new StringBuilder();
            //    strBuider.Append("Variable: ");
            //    strBuider.Append(nombreVariable);
            //    strBuider.Append(Environment.NewLine);
            //    strBuider.Append("VALUE : " + Environment.NewLine);
            //    strBuider.Append(value + Environment.NewLine);
            //    strBuider.Append("-------------------------------------------------------------------- " + Environment.NewLine + Environment.NewLine);

            //    sw2 = new StreamWriter("C://log//WebLogFilePath.txt", true, Encoding.UTF8);
            //    sw2.WriteLine(strBuider.ToString());
            //    sw2.Close();
            //}
            //catch (Exception ex)
            //{
            //    EventLog.WriteEntry("Ha ocurrido un evento", ex.Message);
            //}
        }



        /// <summary>
        /// Registra una entrada en el log de Acceso a Datos
        /// </summary>
        /// <returns></returns>
        public static void GuardarDataLog(Exception ex, string nameSpace, string clase, string metodo, string mensajeOpcional = "")
        {
            if (Convert.ToBoolean(ConfigurationManager.AppSettings["EnableDebugLogs"]))
            {
                string filePath = ConfigurationManager.AppSettings["AccesoDatosLogFilePath"];

                StreamWriter sw = null;
                try
                {
                    string message = ex.Message;

                    if (ex.InnerException != null)
                    {
                        message += Environment.NewLine + Environment.NewLine + "Inner Exception: " + ex.InnerException.Message;
                    }
                    
                    //Preparar el mensaje
                    var strBuider = new StringBuilder();
                    strBuider.Append("FECHA: ");
                    strBuider.Append(DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString() + ", " + Environment.NewLine);
                    strBuider.Append("NIVEL EN DEPLOY: " + nameSpace + ". " + Environment.NewLine);
                    strBuider.Append("CLASE GENERADORA: " + clase + ". " + Environment.NewLine);
                    strBuider.Append("METODO: " + metodo + ". " + Environment.NewLine);
                    strBuider.Append("Excepcion completa: " + Environment.NewLine + message + Environment.NewLine);

                    if (!string.IsNullOrEmpty(mensajeOpcional))
                        strBuider.Append("Mensaje Opcional: " + Environment.NewLine + mensajeOpcional + Environment.NewLine);

                    strBuider.Append("-------------------------------------------------------------------- " + Environment.NewLine + Environment.NewLine);

                    sw = new StreamWriter(filePath, true, Encoding.UTF8);
                    sw.WriteLine(strBuider.ToString());
                    sw.Close();
                }
                catch (Exception)
                {
                    //throw ex;
                    //throw new Exception("Error al intentar generar el LOG de datos.");
                }
                finally
                {
                    if (sw != null) sw.Dispose();
                }
            }
        }

        public static void GuardarGeneralLog(string message, string nameSpace, string clase, string metodo)
        {
            if (Convert.ToBoolean(ConfigurationManager.AppSettings["EnableDebugLogs"]))
            {
                string filePath = ConfigurationManager.AppSettings["GeneralLogFilePath"];

                StreamWriter sw = null;
                try
                {
                    //Preparar el mensaje
                    var strBuider = new StringBuilder();
                    strBuider.Append("FECHA: ");
                    strBuider.Append(DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString() + ", " + Environment.NewLine);
                    strBuider.Append("NIVEL EN DEPLOY: " + nameSpace + ". " + Environment.NewLine);
                    strBuider.Append("CLASE GENERADORA: " + clase + ". " + Environment.NewLine);
                    strBuider.Append("METODO: " + metodo + ". " + Environment.NewLine);
                    strBuider.Append("Excepcion completa: " + Environment.NewLine + message + Environment.NewLine);
                    strBuider.Append("-------------------------------------------------------------------- " + Environment.NewLine + Environment.NewLine);

                    sw = new StreamWriter(filePath, true, Encoding.UTF8);
                    sw.WriteLine(strBuider.ToString());
                    sw.Close();
                }
                catch (Exception)
                {
                    //throw ex;
                    //throw new Exception("Error al intentar generar el LOG de datos.");
                }
                finally
                {
                    if (sw != null) sw.Dispose();
                }
            }
        }

        public static void GuardarPCRLog(string message, string nameSpace, string clase, string metodo)
        {
            if (Convert.ToBoolean(ConfigurationManager.AppSettings["EnableDebugLogs"]))
            {
                string filePath = ConfigurationManager.AppSettings["PCRLogFilePath"];

                StreamWriter sw = null;
                try
                {
                    //Preparar el mensaje
                    var strBuider = new StringBuilder();
                    strBuider.Append("FECHA: ");
                    strBuider.Append(DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString() + ", " + Environment.NewLine);
                    strBuider.Append("NIVEL EN DEPLOY: " + nameSpace + ". " + Environment.NewLine);
                    strBuider.Append("CLASE GENERADORA: " + clase + ". " + Environment.NewLine);
                    strBuider.Append("METODO: " + metodo + ". " + Environment.NewLine);
                    strBuider.Append("Excepcion completa: " + Environment.NewLine + message + Environment.NewLine);
                    strBuider.Append("-------------------------------------------------------------------- " + Environment.NewLine + Environment.NewLine);

                    sw = new StreamWriter(filePath, true, Encoding.UTF8);
                    sw.WriteLine(strBuider.ToString());
                    sw.Close();
                }
                catch (Exception)
                {
                    //throw ex;
                    //throw new Exception("Error al intentar generar el LOG de datos.");
                }
                finally
                {
                    if (sw != null) sw.Dispose();
                }
            }
        }



    }
}
