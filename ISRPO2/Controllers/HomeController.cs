using ISRPO2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
			int result = 0;
			if (Convert.ToInt32(firstNum) > 0 && Convert.ToInt32(secondNum) > 0 && Convert.ToInt32(thirdNum) > 0 && firstNum != null && secondNum != null && thirdNum != null)
			{
				result = (Convert.ToInt32(firstNum) + Convert.ToInt32(secondNum) + Convert.ToInt32(thirdNum)) / 3;
			}
			else if (firstNum != null && secondNum != null && thirdNum != null)
			{
				result = Convert.ToInt32(firstNum) * Convert.ToInt32(secondNum) * Convert.ToInt32(thirdNum);
			}
			ViewBag.H = Convert.ToInt32(result);
			return View();
		}
		[HttpPost]
		public IActionResult TaskSecond (string forCheck)
		{
			string result;
			if (Convert.ToInt32(forCheck) != null && Convert.ToInt32(forCheck) >= 100 && Convert.ToInt32(forCheck) <= 999)
			{
				result = "Число трёхзначное";
			}
			else
			{
				result = "Число не трёхзначное или отрицательное";
			}
			ViewBag.H = result;
			return View();
		}
    }
}
