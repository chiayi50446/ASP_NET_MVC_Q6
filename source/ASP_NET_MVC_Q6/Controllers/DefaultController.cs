using ASP_NET_MVC_Q6.ActionFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_NET_MVC_Q6.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        [ActionDetail]
        public ActionResult Login()
        {
            return View();
        }

        [ActionDetail]
        public ActionResult List()
        {
            return View();
        }
    }
}