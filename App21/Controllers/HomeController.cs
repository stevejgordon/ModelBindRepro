using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using App21.Models;

namespace App21.Controllers
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
