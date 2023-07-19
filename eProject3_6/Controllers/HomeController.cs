using eProject3_6.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace eProject3_6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult contact() 
        { 
            return View();
        }
        public IActionResult loginandsignup() 
        {
            return View();
        }
        public IActionResult aboutus() 
        {
            return View();
        }

        public IActionResult Support() 
        {
            return View();
        }
        public IActionResult rechargeplant() 
        {
            return View();
        }

        public IActionResult UserAccount() 
        {
            return View();
        }
        public IActionResult youroder() 
        {
            return View();
        }

        public IActionResult payment() 
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