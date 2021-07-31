using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace joburg_manc_weather.Pages
{
    public record WeatherData
    {
        public decimal MancTempC;
        public decimal JoburgTempC;
    }
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["weather"] = new WeatherData
            {
                MancTempC = 17.5M,
                JoburgTempC = 24.1M
            };

        }
    }
}
