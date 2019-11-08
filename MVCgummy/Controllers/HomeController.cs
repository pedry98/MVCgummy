using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCgummy.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
		public ActionResult Blog()
		{
			ViewBag.Message = "Your Blog page.";

			return View();
		}
		public ActionResult Pricing()
		{
			ViewBag.Message = "Your Pricing page.";

			return View();
		}
		public ActionResult Appointments()
		{
			ViewBag.Message = "Your Appointments page.";

			return View();
		}
	
	}
}