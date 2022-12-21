using Microsoft.AspNetCore.Mvc;
using RH_PJ.Base;
using RH_PJ.Business;
using RHPJ.Base;

namespace RH_PJ.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : BaseController
    {
        public WeatherForecastController(UnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public object Get()
        {
            var a = Test.Get();
            return a;
        }
    }
}