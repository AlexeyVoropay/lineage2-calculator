using System;
using System.Linq;
using System.Threading.Tasks;
using L2on.Data;
using L2on.Data.Models;

namespace L2onNew.Web.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray());
        }

        public MyItem[] GetTalismans()
        {
            MyItem[] MyItems = L2onData.GetVenirsTalismans().ToArray();
            return MyItems;
        }

        public MyItem[] GetAll(int percent)
        {
            MyItem[] MyItems = L2onData.GetAllItems(percent).ToArray();
            return MyItems;
        }
    }
}
