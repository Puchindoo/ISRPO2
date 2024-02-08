using ISRPO2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ISRPO2.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
		public IActionResult TaskFirst()
		{
			return View();
		}
        public IActionResult TaskSecond()
        {
            return View();
        }
        public IActionResult TaskThird()
        {
            return View();
        }
		[HttpPost]
		public IActionResult TaskFirst(string firstNum, string secondNum, string thirdNum)
		{
			int result;
			if (Convert.ToInt32(firstNum) > 0 && Convert.ToInt32(secondNum) > 0 && Convert.ToInt32(thirdNum) > 0 && firstNum == null && secondNum == null && thirdNum == null)
			{
				result = (Convert.ToInt32(firstNum) + Convert.ToInt32(secondNum) + Convert.ToInt32(thirdNum)) / 3;
			}
			else
			{
				result = Convert.ToInt32(firstNum) * Convert.ToInt32(secondNum) * Convert.ToInt32(thirdNum);
			}
			ViewBag.H = Convert.ToInt32(result);
			return View();
		}
    }
}
