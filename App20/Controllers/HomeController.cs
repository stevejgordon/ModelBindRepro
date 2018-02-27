using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace App20.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("/Home/{statusCode}")]
        public IActionResult Error([FromRoute]int statusCode)
        {
            if (statusCode == (int)HttpStatusCode.NotFound)
            {
                // do something
            }

            return Ok();
        }
    }
}
