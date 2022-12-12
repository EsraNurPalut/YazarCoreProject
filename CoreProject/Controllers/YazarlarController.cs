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
    public class YazarlarController : Controller
    {
        YazarlarManager ym = new YazarlarManager(new EFYazarlarDal());

        public IActionResult Index()
        {
            var values = ym.GetList();
            return View(values);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Yazarlar p)
        {

            if (ModelState.IsValid)
            {
                ym.AddYazar(p);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Edit(int id)
        {
            var values = ym.GetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult Edit(Yazarlar p)
        {
            if (ModelState.IsValid)
            {
                ym.UpdateYazar(p);
                return RedirectToAction("Index");

            }
            return View(p);
        }

        public IActionResult Delete(int id)
        {
            var values = ym.GetByID(id);
            ym.DeleteYazar(values);

            return RedirectToAction("Index");
        }
    }
}
