﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleDeEstoqueCPM.Controllers
{
    public class CadastroController : Controller
    {
      [Authorize]
        public ActionResult GrupoProduto()
        {
            return View();

        }
        [Authorize]
        public ActionResult Marcaproduto()
        {
            return View();
        }
        [Authorize]
        public ActionResult Localproduto()
        {
            return View();
        }
        [Authorize]
        public ActionResult UnidadeMedida()
        {
            return View();
        }
        [Authorize]
        public ActionResult Produto()
        {
            return View();
        }
        [Authorize]
        public ActionResult Pais()
        {
            return View();
        }
        [Authorize]
        public ActionResult Estado()
        {
            return View();
        }
        [Authorize]
        public ActionResult Cidade()
        {
            return View();
        }
        [Authorize]
        public ActionResult Fornecedor()
        {
            return View();
        }
        [Authorize]
        public ActionResult PerfilUsuario()
        {
            return View();
        }
        [Authorize]
        public ActionResult Usuario()
        {
            return View();
        }
    }
}