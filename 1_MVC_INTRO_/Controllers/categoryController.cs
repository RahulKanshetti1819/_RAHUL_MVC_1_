using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1_MVC_INTRO_.Controllers
{
    public class categoryController : Controller
    {
        // GET: category
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public ViewResult Index()
        {
           // return View();
            //return View("Index 1");
            return View("/view/studnt/index.cshtml");
        }

        public ViewResult AllCategories()
        {
            return View();
        }
    }
}