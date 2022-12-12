using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace CoreProject.Controllers
{
    public class YayınevleriController : Controller
    {
        YayinevleriManager yem = new YayinevleriManager(new EFYayinevleriDal()); 

        public IActionResult Index()
        {
            var values = yem.GetList();
            return View(values);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Yayinevleri p)
        {

            if (ModelState.IsValid)
            {
                yem.AddYayinevleri(p);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        public IActionResult Edit(int id)
        {
            var values = yem.GetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult Edit(Yayinevleri p)
        {
            if (ModelState.IsValid)
            {
                yem.UpdateYayinevleri(p);
                return RedirectToAction("Index");

            }
            return View(p);
        }

        public IActionResult Delete(int id)
        {
            var values = yem.GetByID(id);
            yem.DeleteYayinevleri(values);

            return RedirectToAction("Index");
        }

    }
}
