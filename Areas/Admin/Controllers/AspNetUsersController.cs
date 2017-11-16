using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test1.EF;

namespace Test1.Areas.Admin.Controllers
{
    public class AspNetUsersController : Controller
    {
        FashionShopEntities db = new FashionShopEntities();
        // GET: Admin/AspNetUsers
        public ActionResult Index()
        {
            return View(db.AspNetUsers.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
    }
}