using MvcAngular.Models.Registrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAngular.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Default1/
        private RegistrationFactory registrationFactory = new RegistrationFactory();

        public ActionResult Index()
        {
            return View("Index", "", registrationFactory.BuildRegistration());
        }

    }
}
