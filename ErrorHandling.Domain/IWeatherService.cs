using System.Collections.Generic;
using System.Threading.Tasks;

namespace ErrorHandling.Domain
{
    public interface IWeatherService
    {
        IEnumerable<WeatherForecast> Get(string cityName);
    }
}
