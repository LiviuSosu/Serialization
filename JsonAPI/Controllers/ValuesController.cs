using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using JsonSerializer;
using Microsoft.AspNetCore.Mvc;

namespace JsonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [Route("/api/Test")]
        public ActionResult Test()
        {
            try
            {
                var books = new List<BookInfo>();
                BookInfo bookInfo;

                for (int i = 1; i <= Config.Config.DataSetSize; i++)
                {
                    bookInfo = new BookInfo();

                    bookInfo.Id = i;
                    bookInfo.Authtor = new Author()
                    {
                        Name = "Author name " + i
                    };
                    bookInfo.PageCount = i;
                    bookInfo.Title = "Title " + i;

                    books.Add(bookInfo);
                }

                string serializedBooks = Newtonsoft.Json.JsonConvert.SerializeObject(books);

                return Ok(serializedBooks);
            }
            catch (Exception ex)
            {
                return null;// Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

   
    }
}
