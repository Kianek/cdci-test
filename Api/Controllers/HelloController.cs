using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers 
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public string Hello() 
        {
            return "Hello, world!";
        }
    }
}