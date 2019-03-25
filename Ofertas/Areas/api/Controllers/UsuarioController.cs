using Entidades;
using Newtonsoft.Json;
using Ofertas.Areas.api.Models;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ofertas.Areas.api.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: api/UsuarioApi
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult registrar()
        {
            string error = "";

            Usuario usuario = new Usuario();

            if (Request.Headers["usuario"] != null)
                usuario = JsonConvert.DeserializeObject<Usuario>(Request.Headers["usuario"].ToString());
            else
                usuario = null;

            if(usuario != null)
            {
                bool usuarioRegistrado = UsuarioService.registrar(usuario, out error);

                if (!string.IsNullOrEmpty(error))
                {
                    Error errorObj = new Error();

                    errorObj.error = true;
                    errorObj.mensaje = error;

                    return Json(errorObj, JsonRequestBehavior.AllowGet);
                }

                return Json(new Error { error = false, mensaje = "El usuario fue registrado con éxito." }, JsonRequestBehavior.AllowGet);

            }
            else
            {
                return Json(new Error { error = true, mensaje = "Debe enviar un usuario para registrar." }, JsonRequestBehavior.AllowGet);
            }

        }
    }
}