using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace ConsoleApp1.Controllers
{
    [ApiController]
    [Route("test")]
    public class TestController : ControllerBase
    {
        [Route("get")]
        public string Get()
        {
            return "Esse é o get da api";
        }

        [Route("get1")]
        public string Get1()
        {
            return "Esse é o get111 da api";
        }
    }
}
