using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [Route("{id:int:min(10):max(20)}")]
        public string GetById(int id)
        {
            return "hello int " + id;
        }

        [Route("{id}")]
        public string GetByString(string id)
        {
            return "hello string " + id;
        }

    }
}
