using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test1.Areas.Admin.Controllers
{
    public class InvoiceController : Controller
    {
        // GET: Admin/Invoice
        public ActionResult Old()
        {
            return View();
        }
        public ActionResult New()
        {
            return View();
        }
        public ActionResult Print()
        {
            return View();
        }
    }
}