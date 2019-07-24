using ASP_NET_MVC_Q6.ActionFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_NET_MVC_Q6.Areas.Product.Controllers
{
    public class MainController : Controller
    {
        // GET: Product/Main
        [ActionDetail]
        public ActionResult List(int category)
        {
            ViewBag.Category = category;
            return View();
        }
    }
}