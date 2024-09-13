using Microsoft.AspNetCore.Mvc;
using RepairShop2.Service.Services.Abstractions;
using RepairShop2.Web.Models;
using System.Diagnostics;

namespace RepairShop2.Web.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly IFaultService faultService;

		public HomeController(ILogger<HomeController> logger, IFaultService faultService)
		{
			_logger = logger;
			this.faultService = faultService;
		}

		public async Task<IActionResult> Index()
		{
			var allFaults =  await faultService.GetAllFaultsAsync();
			return View(allFaults);
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
	}
}
