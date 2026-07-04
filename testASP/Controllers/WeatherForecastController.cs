using Microsoft.AspNetCore.Mvc;

namespace testASP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {//сюда нужно будет так же забросить через конструктор интерфейс нужного Handle, который будет использовать нужный репозиторий и через его методы делать запросы CRUDE.
     //Само собой в этих Handlers будет преобразование в нужную DTO посредством мапера из Application и эту DTO мы получаем уже тут в методах, а дальше отправляем по запросу
        [HttpGet(Name = "GetWeatherForecast")]
        public List<string> Get(int id)
        {
            List<string> somethingData = new List<string>();
            return somethingData;
        }
    }
}
