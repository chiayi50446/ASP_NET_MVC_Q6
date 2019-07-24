using ASP_NET_MVC_Q6.ActionFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_NET_MVC_Q6.Areas.Order.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Order/Default
        [ActionDetail]
        public ActionResult List(int page)
        {
            ViewBag.Page = page;
            return View();
        }
        // GET: Order/Default
        [ActionDetail]
        public ActionResult Detail(int id)
        {
            ViewBag.Id = id;
            return View();
        }
    }
}