using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using FirstAssignmentTheta.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstAssignmentTheta.Controllers
{
    public class EmailController : Controller
    {
        //// GET: /SendMailer/   
        //public IActionResult EmailSender()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public ViewResult EmailSender(MailModel _objModelMail)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        MailMessage mail = new MailMessage();
        //        mail.To.Add(_objModelMail.To);
        //        mail.From = new MailAddress(_objModelMail.From);
        //        mail.Subject = _objModelMail.Subject;
        //        string Body = _objModelMail.Body;
        //        mail.Body = Body;
        //        mail.IsBodyHtml = true;
        //        SmtpClient smtp = new SmtpClient();
        //        smtp.Host = "smtp.gmail.com";
        //        smtp.Port = 587;
        //        smtp.UseDefaultCredentials = false;
        //        smtp.Credentials = new System.Net.NetworkCredential("shahjahanblouch", "vicky_7868"); // Enter seders User name and password  
        //        smtp.EnableSsl = true;
        //        smtp.Send(mail);
        //        return View("EmailSender", _objModelMail);
        //    }
        //    else
        //    {
        //        return View();
        //    }
        //}




    }
}