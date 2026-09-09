using System.Diagnostics;
using IT_ELECTIVE_2__BSIT_31E3__PREFINAL_EXAM_Sumalinog_Sophia.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_2__BSIT_31E3__PREFINAL_EXAM_Sumalinog_Sophia.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
