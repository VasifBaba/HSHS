using HS_01.Models;
using HS_01.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HS_01.Controllers
{
    public class AnimalController : Controller
    {
        HS0215DB db = new HS0215DB();

        public ActionResult Melumat(int? id)
        {
            if (id == null) return HttpNotFound();

            Animal ani = db.Animals.Find(id);

            if (ani == null) return HttpNotFound();

            var DefaultModel = new DefaultVIiewModel
            {
                aniDetail = ani,
               
                anima = db.Animals.Where(a => a.CategoryID == ani.CategoryID)
            };
            return View(DefaultModel);

        }
    }
}