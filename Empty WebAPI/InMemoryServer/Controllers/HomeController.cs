using System.Web.Http;

namespace InMemoryServer.controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Test()
        {
            return Json("hola");
        }
    }
}
