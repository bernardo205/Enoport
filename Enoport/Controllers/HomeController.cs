using Enoport.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Enoport.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();

        [HttpGet("/team")]
        public IActionResult Team() => View();

        [HttpGet("/shop")]
        public IActionResult Shop() => View();
    }
}
