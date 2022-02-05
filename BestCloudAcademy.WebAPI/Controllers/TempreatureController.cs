using BestCloudAcademy.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;

namespace BestCloudAcademy.WebAPI.Controllers
{
    [Route("")]
    [ApiController]
    public class TempreatureController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            string output = JsonConvert.SerializeObject(new DefaultReturn { firstname = "Onur Nafi", lastname = "Güzel" }, Formatting.Indented);
            return output;
        }

        [HttpGet("temperature")]
        public string GetByCity(string city)
        {
            string apiKey = "15272a3b824b17a23b8ec8a087c64ee9";
            string connection = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}";
            float convert = (float)273.15;

            WebClient client = new WebClient();
            string jsonText = client.DownloadString(connection);
            var jsonString = JsonConvert.DeserializeObject<Rootobject>(jsonText);
            float kelvin = jsonString.main.temp;
            float celcius = (float)System.Math.Round(kelvin - convert, 2);
            string output = JsonConvert.SerializeObject(new ReturnWithCity { city = city, temperature = celcius });
            return output;
        }
    }
}
