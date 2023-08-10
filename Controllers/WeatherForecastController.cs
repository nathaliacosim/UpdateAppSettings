using Microsoft.AspNetCore.Mvc;

namespace UpdateAppSettings.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {        
        [HttpGet(Name = "GetWeatherForecast")]
        public IActionResult Get()
        {
            UpdateConnection.Atualiza();
            return Ok("It's ok.");
        }
    }
}