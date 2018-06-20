using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using FirstAssignmentTheta.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace FirstAssignmentTheta.Controllers
{
    public class FirstController : Controller
    {
        KidsToysSystemContext ORM = null;
        IHostingEnvironment Oenv = null;
        public FirstController(KidsToysSystemContext _ORM , IHostingEnvironment _Oenv)
        {
            ORM = _ORM;
            Oenv = _Oenv;
        }
        [HttpGet]
        public IActionResult ToysCreate()
        {

            return View();
        }
        [HttpPost]
        public IActionResult ToysCreate(ToysProperties A)
        {
            try
            {
                var Oemail = new MailMessage();
                Oemail.To.Add(A.Email);
                Oemail.From = new MailAddress("sialkotem@gmail.com");
                Oemail.Bcc.Add("shahjahan7868@outlook.com");
                Oemail.CC.Add("shahjahan7868@outlook.com");
                Oemail.Subject = "THis is Email Sending Procedure";
                Oemail.Body = "This is the body portion";

                var Osmtp = new SmtpClient();
                Osmtp.Host = "smtp.gmail.com";
                Osmtp.Credentials = new System.Net.NetworkCredential("sialkotem@gmail.com", "sialkot7868");
                Osmtp.UseDefaultCredentials = false;
                Osmtp.Port = 587;
                Osmtp.EnableSsl = true;
                Osmtp.Send(Oemail);

                return View();
            }
            catch(Exception e)
            {
                ViewBag.Message = "Eror Find//////" + e.Message;
            }


            ORM.ToysProperties.Add(A);
            ORM.SaveChanges();
            ViewBag.Message = "Kid Toys Successful Save";
            return View();
        }
        public IActionResult ToysAllViews()
        {
            IList<ToysProperties> obj = ORM.ToysProperties.ToList<ToysProperties>();
            return View(obj);
        }

        public IActionResult ToysDelete(ToysProperties ad)
        {
            ORM.ToysProperties.Remove(ad);
            ORM.SaveChanges();
           return RedirectToAction("ToysAllViews");

        }
        public IActionResult ToysDetail(int iD)
        {
           IList< ToysProperties> Reg = ORM.ToysProperties.Where(a => a.Id == iD).ToList<ToysProperties>();
            return View(Reg);
        }
        [HttpGet]
        public IActionResult ToysEdit(int iD)
        {
           ToysProperties TEdit = ORM.ToysProperties.Where(a => a.Id == iD).SingleOrDefault<ToysProperties>();
            return View(TEdit);
        }
        [HttpPost]
        public IActionResult ToysEdit(ToysProperties tp)
        {
            var id = tp.Id;
            var name = tp.Name;
            var price = tp.Price;
            var color = tp.Color;
            var weight = tp.Weight;
            var age=tp.Age;
            var email=tp.Email;
            ORM.ToysProperties.Update(tp);
           ORM.SaveChanges();
            return RedirectToAction("ToysAllViews");
        }
        [HttpGet]
        public IActionResult ToysSearch()
        {
            return View();

        }
        [HttpPost]
        public IActionResult ToysSearch(string prmeter)
        {
            IList<ToysProperties> se = ORM.ToysProperties.Where(a => a.Name.Contains(prmeter)).ToList<ToysProperties>();
            return View(se);
        }

    }
}