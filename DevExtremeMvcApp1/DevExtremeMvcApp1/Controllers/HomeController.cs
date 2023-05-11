using DevExtremeMvcApp1.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevExtremeMvcApp1.Controllers {
    public class HomeController : Controller {

        public readonly ICronosService cronosService;

        public HomeController(ICronosService cs)
        {
            cronosService = cs;
        }
        public ActionResult Index() {
            Console.WriteLine("initialisation is working working");
            return View();
        }
        public ActionResult FormCronos()
        {

            Debug.WriteLine("initialisation is working working");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult calculateString(string Minutes,string Hours,string Day,string Month,string Week) {
            Debug.WriteLine($"post working : minutes{Minutes} ,hours :{Hours} ,Day :{Day} ,Month:{Month} ,Week:{Week}");

            string cron_exp= cronosService.generateExpressionCronos(Minutes, Hours, Day, Month);

            Debug.WriteLine($"cronos example : * {cron_exp} {Week}");
            return RedirectToAction("FormCronos"); 
        }
    }
}