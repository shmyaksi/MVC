using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVCR1.Models;

namespace WebMVCR1.Controllers
{
    public class MyController : Controller
    {
        // GET: Home
        public string Index(string hel)
        {
            
                string Greeting = ModelClass.ModelHello() + ", " + hel;
                return Greeting;
            

        }

    }
}