using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test1.EF;

namespace Test1.Areas.Admin.Controllers
{
    public class TypeController : Controller
    {
        FashionShopEntities db = new FashionShopEntities();
        // GET: Admin/Type
        public ActionResult Index()
        {
            return View(db.loaisanphams.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(loaisanpham Model)
        {
            if (ModelState.IsValid)
            {
                db.loaisanphams.Add(Model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Thông tin nhập liệu không chính xác ! Hãy xem lại .");
            return View();
        }

        public ActionResult Edit(string Id)
        {
            var query = (from t in db.loaisanphams
                         where t.maloai == Id
                         select t).FirstOrDefault();
            return View(query);
        }

        [HttpPost]
        public ActionResult Edit(loaisanpham model)
        {
            if (ModelState.IsValid)
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Thông tin không chính xác");
            return View(model);
        }

        public ActionResult Delete(string Id)
        {
            var type = db.loaisanphams.Find(Id);
            db.loaisanphams.Remove(type);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}