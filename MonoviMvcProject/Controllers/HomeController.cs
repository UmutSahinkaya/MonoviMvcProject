using MonoviMvcProject.Models.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MonoviMvcProject.Controllers
{
    public class HomeController : Controller
    {
        MonoviDBContext db = new MonoviDBContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EmployeeList()
        {
            var result = db.Employees.Select(x => x);
            return View(result);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}