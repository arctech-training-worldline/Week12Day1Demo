using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodafoneClientDemo.Services;

namespace VodafoneClientDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IPopulationService _populationService;

        public IndexModel(ILogger<IndexModel> logger, IPopulationService populationService)
        {
            _logger = logger;
            _populationService = populationService;
        }

        public void OnGet()
        {

        }
    }
}
