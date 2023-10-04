using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapaPresentacionAdmin.Controllers
{
    public class PruebasController : Controller
    {
        // GET: Pruebas
        public ActionResult PruebaControl()
        {
            return View();
        }

        public ActionResult PruebaAnalitica()
        {
            return View();
        }

        public ActionResult PruebaSustantiva()
        {
            return View();
        }

    }
}