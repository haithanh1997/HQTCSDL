using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test1.Areas.Admin.Controllers
{
    public class NewFeedController : Controller
    {
        // GET: Admin/NewFeed
        public ActionResult Slider()
        {
            return View();
        }
        public ActionResult NewFeeds()
        {
            return View();
        }
    }
}