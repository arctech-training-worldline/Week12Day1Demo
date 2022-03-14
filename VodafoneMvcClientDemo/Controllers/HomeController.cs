using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using VodafoneMvcClientDemo.Models;
using VodafoneMvcClientDemo.Services;

namespace VodafoneMvcClientDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPopulationService _populationService;

        public HomeController(ILogger<HomeController> logger, IPopulationService populationService)
        {
            _logger = logger;
            _populationService = populationService;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var populationInfo = await _populationService.GetPopulationInfoAsync("mumbai");
            return View(populationInfo);
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
