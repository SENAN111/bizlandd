using Bizllannd.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Bizllannd.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}