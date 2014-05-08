using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitTest1.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Git er töffari arnar kári er moneyman og svessi er lefty";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Nú er gaman";

			return View();
		}
	}
}