using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapaPresentacionAdmin.Controllers
{
    public class MuestrasController : Controller
    {
        // GET: Muestras
        public ActionResult MuestrasBloque()
        {
            return View();
        }

        public ActionResult MuestrasIncidental()
        {
            return View();
        }

        public ActionResult MuestrasUnidad()
        {
            return View();
        }

        public ActionResult MuestrasSistematicas()
        {
            return View();
        }

        public ActionResult MuestrasAleatorias()
        {
            return View();
        }
    }
}