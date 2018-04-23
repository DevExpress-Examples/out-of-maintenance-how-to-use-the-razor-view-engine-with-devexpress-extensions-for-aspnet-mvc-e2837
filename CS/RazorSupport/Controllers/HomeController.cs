using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RazorSupport.Models;

namespace RazorSupport.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return GridView();
        }
        public ActionResult GridView() {
            return View("GridView", NorthwindDataProvider.GetInvoices());
        }
        public ActionResult GridViewPartial() {
            return PartialView("GridViewPartial", NorthwindDataProvider.GetInvoices());
        }
    }
}
