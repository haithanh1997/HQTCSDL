using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test1.EF;

namespace Test1.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        FashionShopEntities db = new FashionShopEntities();
        // GET: Admin/Category
        public ActionResult Index()
        {
            return View(db.danhmucsanphams.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(danhmucsanpham model)
        {
            if (ModelState.IsValid)
            {
                db.danhmucsanphams.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Thông tin nhập liệu không chính xác ! Hãy xem lại .");
            return View();
        }
        //danh mục sản phẩm không cần chi tiết làm gì :v
 /*       public ActionResult Details(string Id)
        {
            var model = (from c in db.danhmucsanphams
                         where c.madanhmuc == Id
                         select c).FirstOrDefault();
            return View(model);
        }*/
        public ActionResult Edit(string Id)
        {
            var model = (from c in db.danhmucsanphams
                         where c.madanhmuc == Id
                         select c).FirstOrDefault();
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(danhmucsanpham model)
        {
            if(ModelState.IsValid)
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
            var category = db.danhmucsanphams.Find(Id);
            db.danhmucsanphams.Remove(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}