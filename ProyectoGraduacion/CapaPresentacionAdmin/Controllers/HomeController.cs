using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CapaDatos;

namespace CapaPresentacionAdmin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ObjetivoAlcance()
        {
            return View();
        }

        public ActionResult AnalisisPreControlInterno()
        {
            return View();
        }

        public ActionResult PlaneacionEspecifica()
        {
            return View();
        }

        public ActionResult ElaboracionPrograma()
        {
            return View();
        }

        

        public ActionResult PapelesTrabajo()
        {
            return View();
        }

        public ActionResult GenerarInforme()
        {
            return View();
        }

        public JsonResult ListaUsuarios() 
        {
            List<Usuario> oLista = new List<Usuario>();

            oLista = new Usuario().Listar();

            return Json(oLista,JsonRequestBehavior.AllowGet);
        }

    }
}