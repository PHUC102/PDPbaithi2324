using Microsoft.AspNetCore.Mvc;
using PDPbaithi2324.Models;

namespace PDPbaithi2324.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Person ps)
        {
            return View();
        }
    }
}