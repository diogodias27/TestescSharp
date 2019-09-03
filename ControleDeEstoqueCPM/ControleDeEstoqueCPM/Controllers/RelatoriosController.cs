using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleDeEstoqueCPM.Controllers
{
    public class RelatorioController : Controller
    {
        // GET: Relatorios[Authorize]
        public ActionResult PosicaoEstoque()
        {
            return View();
        }
        [Authorize]
        public ActionResult Ressuprimento()
        {
            return View();
        }
    }
}