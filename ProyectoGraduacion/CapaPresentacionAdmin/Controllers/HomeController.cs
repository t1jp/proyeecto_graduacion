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

        public ActionResult InformacionEntidad()
        {
            return View();
        }

        public ActionResult Entrevistas()
        {
            return View();
        }

        public ActionResult Encuestas()
        {
            return View();
        }

        public ActionResult AnalisisComparativosEsFinan()
        {
            return View();
        }

        public ActionResult FODA()
        {
            return View();
        }

        public ActionResult CausaEfecto()
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

        public ActionResult Riesgo()
        {
            return View();
        }

        public ActionResult Materialidad()
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

        public ActionResult PapelesTrabajo()
        {
            return View();
        }

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