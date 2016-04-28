using ApplicationToSendEmail.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ApplicationToSendEmail.Controllers
{
    public class EmailController : Controller
    {
        // GET: Email
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EmailSend()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EmailSend(Email model)
        {
            if (ModelState.IsValid)
            {
                var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                var message = new MailMessage();
                //message.To.Add(new MailAddress("chhantyal.devan@gmail.com"));
                //message.To.Add(new MailAddress("iamram515@gmail.com"));
                //  message.To.Add(new MailAddress("iamram515@gmail.com"));
               

                message.From = new MailAddress("chhantyaldevan@outlook.com");
                //message.Attachments.Add(new Attachment(HttpContext.Server.MapPath("~/App_Data/Devendra-CV1.docx")));
                message.Subject = "Message to inform";
               // message.Body = string.Format(body, model.FromName, model.FromEmail, model.Message);
                message.IsBodyHtml = true;
                if (model.Upload != null && model.Upload.ContentLength > 0)
                {
                    message.Attachments.Add(new Attachment(model.Upload.InputStream, Path.GetFileName(model.Upload.FileName)));
                }

                using (var smtp = new SmtpClient())
                {
                    //var credential = new NetworkCredential
                    //{
                    //    UserName = "chhantyaldevan@outlook.com",
                    //    Password = "f0rml0ad"
                    //};
                    //smtp.Credentials = credential;
                    //smtp.Host = "smtp-mail.outlook.com";
                    //smtp.Port = 587;
                    //smtp.EnableSsl = true;
                    await smtp.SendMailAsync(message);
                    return RedirectToAction("Sent");
                }
            }
            return View(model);
        }


        public ActionResult Sent()
        {
            return View();
        }
    }
}