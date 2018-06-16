using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstAssignmentTheta.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstAssignmentTheta.Controllers
{
    public class FirstController : Controller
    {
        KidsToysSystemContext ORM = null;
        public FirstController(KidsToysSystemContext _ORM)
        {
            ORM = _ORM;
        }
        [HttpGet]
        public IActionResult ToysCreate()
        {

            return View();
        }
        [HttpPost]
        public IActionResult ToysCreate(ToysProperties A)
        {
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