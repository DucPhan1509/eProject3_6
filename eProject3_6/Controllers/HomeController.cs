using eProject3_6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using System.IO;
using System.Net;
using System.Net.Mail;
using Microsoft.Extensions.Configuration;


namespace eProject3_6.Controllers
{
    public class HomeController : Controller
    {



        public ActionResult Index()
        {
            return View();
        }
        // contact 
        /*private readonly IEmailSender _emailSender;

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
*/
        private IConfiguration Configuration;
        public HomeController(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }

        // GET: Home
        public IActionResult contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult contact(SendMail model)
        {
            //Read SMTP settings from AppSettings.json.
            string host = this.Configuration.GetValue<string>("Smtp:smtp.gmail.com");
            int port = this.Configuration.GetValue<int>("Smtp:587");
            string fromAddress = this.Configuration.GetValue<string>("Smtp:FromAddress");
            string userName = this.Configuration.GetValue<string>("Smtp:phanminhduc159@gmail.com");
            string password = this.Configuration.GetValue<string>("Smtp:yrseqepzdlzmljvf");

            using (MailMessage mm = new MailMessage(fromAddress, "phanminhduc159@gmail.com"))
            {
                mm.Subject = model.Subject;
                mm.Body = "Email: " + model.Email + "<br />" + model.Message;
                mm.IsBodyHtml = true;


                using (SmtpClient smtp = new SmtpClient())
                {
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;
                    NetworkCredential NetworkCred = new NetworkCredential("phanminhduc159@gmail.com", "yrseqepzdlzmljvf");
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = NetworkCred;
                    smtp.Port = 587; ;
                    smtp.Send(mm);
                    ViewBag.msg = "Email sent sucessfully.";
                }
            }

            return View();
        }
        //
        public ActionResult Loginandsignup() 
        {
            return View();
        }
        public ActionResult Aboutus() 
        {
            return View();
        }

        public ActionResult Support() 
        {
            return View();
        }
        public ActionResult Rechargeplant() 
        {
            return View();
        }

        public ActionResult UserAccount() 
        {
            return View();
        }
        public ActionResult Youroder() 
        {
            return View();
        }

        public ActionResult Payment() 
        {
            return View();
        }
        public ActionResult Privacy()
        {
            return View();
        }


    }
}