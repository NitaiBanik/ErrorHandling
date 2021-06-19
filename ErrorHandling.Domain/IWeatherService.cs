using System.Collections.Generic;
using System.Threading.Tasks;
using ErrorHandling.API;

namespace ErrorHandling.Domain
{
    public interface IWeatherService
    {
        IEnumerable<WeatherForecast> Get(string cityName);
    }
}
