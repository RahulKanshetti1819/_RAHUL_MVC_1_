using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _1_MVC_INTRO_.Controllers
{
    [RoutePrefix("")]
    public class HomeController : Controller
    {
      
        //this is an given a action method

        public string Welcome()
        {
            return "MY first application";
        }
        public string GetResult(int id)
        {
            return $"you have passed {id} input values";
        }
        public string GetEmployeeDate(int id, string name)
        {
            return $"Employee ID :{id} Name: {name}";
        }
       
       
    }
}


