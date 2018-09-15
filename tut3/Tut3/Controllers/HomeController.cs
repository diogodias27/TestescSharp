using System.Collections.Generic;
using System.Web.Mvc;


namespace Tut3.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            List<Empregados> empregados = new List<Empregados>
            {
                new Empregados(){EmpId = 1, EmpName= "diogo", EmpSalary = 8000},
                new Empregados(){EmpId = 2, EmpName="Dias", EmpSalary=8000},
                new Empregados(){EmpId = 3, EmpName = "silva",EmpSalary=12000}
            };
            ViewBag.Empregados = empregados;// passa a lista de empregados para ser utilizada na view..
            return View();
        }
       
        public class Empregados
        {
            public int EmpId { get; set; }

            public string EmpName { get; set; }

            public int EmpSalary { get; set; }

        }

    }
}
