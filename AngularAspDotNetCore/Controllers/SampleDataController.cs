using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AngularAspDotNetCore.Controllers
{
    [Route("api/sampledata")]
    public class SampleDataController : Controller
    {
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        /// <summary>
        /// This is working with https://localhost:44300/api/SampleData
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<WeatherForecast> WeatherForecasts()
        {
            var header1 = Request.Headers["header1"];
            var header2 = Request.Headers["header2"];
            System.Diagnostics.Debug.WriteLine("header1: " + header1);
            System.Diagnostics.Debug.WriteLine("header2: " + header2);
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        }

        public class WeatherForecast
        {
            public string DateFormatted { get; set; }
            public int TemperatureC { get; set; }
            public string Summary { get; set; }

            public int TemperatureF {
                get {
                    return 32 + (int)(TemperatureC / 0.5556);
                }
            }
        }
    }
}
