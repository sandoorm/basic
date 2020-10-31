using System;
using System.Collections.Generic;
using System.Linq;
using basic.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace basic.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ISummaryProvider summaryProvider;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ISummaryProvider summaryProvider)
        {
            _logger = logger;
            this.summaryProvider = summaryProvider;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            var summaries = this.summaryProvider.GetSummaries();

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = summaries[rng.Next(summaries.Length)]
            })
            .ToArray();
        }
    }
}