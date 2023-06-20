using Microsoft.AspNetCore.Mvc;

namespace CalculatR.Api.Controllers
{
    [ApiController]
    [Route("pai/Controller")]
    public class DelateMe : ControllerBase
    {
        [HttpGet]
        public string Get() => "hello";
    }
}
