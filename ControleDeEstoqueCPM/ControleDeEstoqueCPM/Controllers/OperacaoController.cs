﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleDeEstoqueCPM.Controllers
{
    public class OperacaoController : Controller
    {
        // GET: Operacao
        [Authorize]
        public ActionResult EntradaEstoque()
        {
            return View();
        }
        [Authorize]
        public ActionResult SaidaEstoque()
        {
            return View();
        }
        [Authorize]
        public ActionResult LancPerdasProdutos()
        {
            return View();
        }
        [Authorize]
        public ActionResult Inventario()
        {
            return View();
        }
    }
}