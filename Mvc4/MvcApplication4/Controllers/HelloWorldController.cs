using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace MvcApplication4.Controllers
{
    public class HelloWorldController : Controller
    {
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Welcome(string name, int numTimes = 2)
		{
			ViewBag.Message = "Hello " + name;
			ViewBag.NumTimes = numTimes;

			return View();
		}
    }
}
