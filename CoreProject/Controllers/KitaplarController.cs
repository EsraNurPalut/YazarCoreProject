using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.Controllers
{
    public class KitaplarController : Controller
    {
        KitaplarManager km = new KitaplarManager(new EFKitaplarDal());

        public IActionResult Index()
        {
            var values = km.GetList();
            return View(values);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Kitaplar p)
        {

            if (ModelState.IsValid)
            {
                km.AddKitap(p);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Edit(int id)
        {
            var values = km.GetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult Edit(Kitaplar p)
        {
            if (ModelState.IsValid)
            {
                km.UpdateKitap(p);
                return RedirectToAction("Index");

            }
            return View(p);
        }

        public IActionResult Delete(int id)
        {
            var values = km.GetByID(id);
            km.DeleteKitap(values);
            
            return RedirectToAction("Index");
        }
        

    }
}
