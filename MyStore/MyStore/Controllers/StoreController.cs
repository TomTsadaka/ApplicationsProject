using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoreApp.Controllers
{
    public class StoreController : Controller
    {
        // GET: Blog
        public ActionResult Store()
        {
            return View();
        }

        // GET: Blog/Details
        public ActionResult Details(int id)
        {
            return View();
        }
    }
}