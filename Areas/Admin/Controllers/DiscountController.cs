using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test1.EF;

namespace Test1.Areas.Admin.Controllers
{
    public class DiscountController : Controller
    {
        FashionShopEntities db = new FashionShopEntities();
        // GET: Admin/Discount
        public ActionResult Index()
        {
            return View(db.khuyenmais.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(khuyenmai model)
        {
            if (ModelState.IsValid)
            {
                db.khuyenmais.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Thông tin nhập liệu không chính xác ! Hãy xem lại .");
            return View();
        }

        public ActionResult Edit(string Id)
        {
            var query = (from d in db.khuyenmais
                         where d.makhuyenmai == Id
                         select d).FirstOrDefault();
            return View(query);
        }

        [HttpPost]
        public ActionResult Edit(khuyenmai model)
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
            var query = db.khuyenmais.Find(Id);
            db.khuyenmais.Remove(query);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}