using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AWT2Demo.Web.Infrastructure;

namespace AWT2Demo.Web.Controllers
{
    public class AuthorizedController : Controller
    {
        //
        // GET: /Authorized/
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Admin()
        {
            return View();
        }

        public ActionResult UserDetails(int id)
        {
            return View();
        }
    }
}
