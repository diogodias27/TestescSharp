using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApresentation.Models;

namespace WebApresentation.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            var model = new List<UsuarioModel>();

            model.Add(new UsuarioModel()
            {
                fAtivo = false,
                ID = 1,
                sSenha = "",
                sNome = "Diogo",
                sLogin = "Dias"
            });
            return View(model);
        }

        public ActionResult CadAlter(int? idUsuario)
        {
            try
            {
                if (idUsuario == null)
                {
                    return View();
                }
                else
                {
                    var model = new UsuarioModel()
                    {
                        fAtivo = false,
                        ID = 1,
                        sSenha = "",
                        sNome = "Diogoss",
                        sLogin = "Diasss"
                    };

                    return View(model);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPost]
        public ActionResult CadAlter(UsuarioModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return RedirectToAction("Index");

                }
                else
                {
                    return View(model);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}