using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using eProject3_6.Models;
using eProject3_6.ViewModel;

namespace eProject3_6.Controllers
{
    public class HomeController : Controller
    {



        public IActionResult Index()
        {
            return View();
        }
        // contact 
        private readonly IEmailSender _emailSender;

        public HomeController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        [HttpGet]
        public IActionResult Contact() 
        { 
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Contact(Contact contact)
        {
            var msg = contact.Subject + "" + contact.Message;
            await _emailSender.SendEmailAsync(contact.Email, "Contact Message", msg);
            ViewBag.Message = "Thank for your contact";
            return View();
        }

        //
        public IActionResult Loginandsignup() 
        {
            return View();
        }
        public IActionResult Aboutus() 
        {
            return View();
        }

        public IActionResult Support() 
        {
            return View();
        }
        public IActionResult Rechargeplant() 
        {
            return View();
        }

        public IActionResult UserAccount() 
        {
            return View();
        }
        public IActionResult Youroder() 
        {
            return View();
        }

        public IActionResult Payment() 
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