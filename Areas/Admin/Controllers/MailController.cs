using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test1.Areas.Admin.Controllers
{
    public class MailController : Controller
    {
        // GET: Admin/Mail
        public ActionResult Mail()
        {
            return View();
        }
        public ActionResult Write()
        {
            return View();
        }
        public ActionResult Sent()
        {
            return View();
        }
    }
}