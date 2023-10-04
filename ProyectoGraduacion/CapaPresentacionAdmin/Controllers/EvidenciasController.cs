using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapaPresentacionAdmin.Controllers
{
    public class EvidenciasController : Controller
    {
        // GET: Evidencias
        public ActionResult EvidenciasFisicas()
        {
            return View();
        }

        public ActionResult EvidenciasDocumentales()
        {
            return View();
        }

        public ActionResult EvidenciasTestimoniales()
        {
            return View();
        }

        public ActionResult EvidenciasAnaliticas()
        {
            return View();
        }
    }
}