using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace eProject3_6.Models
{
    /*public class SendMail : IEmailSender
    {
        public async Task<string> SendEmailAsync(string email, string subject, string htmlMessage)
        {
            using (MailMessage mailMessage = new MailMessage())
            {
                mailMessage.From = new MailAddress(email);
                mailMessage.Subject = subject;
                mailMessage.Body = email + htmlMessage;
                mailMessage.IsBodyHtml = true;
                mailMessage.To.Add(new MailAddress("phanminhduc159@gmail.com"));
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                System.Net.NetworkCredential NetworkCred = new System.Net.NetworkCredential();
                NetworkCred.UserName = "phanminhduc159@gmail.com";
                NetworkCred.Password = "jirhklutcubguuul";
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = NetworkCred;
                smtp.Port = 587;
                try
                {
                    await smtp.SendMailAsync(mailMessage);
                    return "thanhcong";
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return "ko thanhcong" + e.Message;
                }

            }
        }*/
    public class SendMail
    {
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}

