using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapaPresentacionAdmin.Controllers
{
    public class AnalisisRiesgoMaterialidadController : Controller
    {
        // GET: AnalisisRiesgoMaterialidad
        public ActionResult Riesgo()
        {
            return View();
        }

        public ActionResult Materialidad()
        {
            return View();
        }

    }
}