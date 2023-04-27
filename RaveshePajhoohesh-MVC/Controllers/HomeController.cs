using Microsoft.AspNetCore.Mvc;
using RaveshePajhoohesh_MVC.Models;
using System.Diagnostics;

namespace RaveshePajhoohesh_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult ShowNames()
        {
            return View();
        }





















        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

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