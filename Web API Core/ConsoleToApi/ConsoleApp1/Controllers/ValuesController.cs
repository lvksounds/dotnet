using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace ConsoleToWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ValuesController : ControllerBase
    {
        [Route("~/get-all")]
        public string GetAll()
        {
            return "Hello from get all";
        }

        //[Route("get-all-authors")]
  
        public string GetAllAuthors()
        {
            return "Hello from get all authors";
        }

        public string GetById(int id)
        {
            return $"Hello from ID {id}";
        }

        //[Route("books/{id}/author/{authorId}")]
        public string GetAuthorAdressById(int id, int authorId)
        {
            return $"Hello {id} from {authorId}";
        }

        //[Route("search")]
        public string SearchBooks(int id, int authorId, string name, int rating, int price)
        {
            return $"Hello from search";
        }
    }

}
