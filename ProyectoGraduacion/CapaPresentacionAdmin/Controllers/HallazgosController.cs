using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapaPresentacionAdmin.Controllers
{
    public class HallazgosController : Controller
    {
        // GET: Hallazgos
        public ActionResult HallazgosCondicion()
        {
            return View();
        }

        public ActionResult HallazgosCriterio()
        {
            return View();
        }

        public ActionResult HallazgosCausa()
        {
            return View();
        }

        public ActionResult HallazgosEfecto()
        {
            return View();
        }
    }
}