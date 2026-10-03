using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TEST.Models;

namespace TEST.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Barcelona()
        {

            StudentModel student = new StudentModel();
            student.ID = 1;
            student.FirstName = "Hedrix Bryan";
            student.MiddleName = "Espiritu";
            student.LastName = "Barcelona";
            student.Address = "Rizal";

            ViewBag.WelcomeMessage = "MEMBER 1";
            ViewData["Quote"] = "Yessir";

            return View(student);
        }
        public IActionResult Harvey()
        {

            StudentModel student = new StudentModel();
            student.ID = 2;
            student.FirstName = "John Harvey";
            student.MiddleName = "Yes";
            student.LastName = "Catud";
            student.Address = "Manila";

            ViewBag.WelcomeMessage = "MEMBER 2";
            ViewData["Quote"] = "yes";

            return View(student);
        }
        public IActionResult Lowen()
        {

            StudentModel student = new StudentModel();
            student.ID = 3;
            student.FirstName = "Cristianne";
            student.MiddleName = "lowen";
            student.LastName = "Lili";
            student.Address = "Bulacan";

            ViewBag.WelcomeMessage = "MEMBER 3";
            ViewData["Quote"] = "Etits";

            return View(student);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
