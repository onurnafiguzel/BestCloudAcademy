using BestCloudAcademy.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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
    }
}
