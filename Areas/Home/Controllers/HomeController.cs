using Microsoft.AspNetCore.Mvc;
using aspcore.Areas.Home.Models;
namespace aspcore.Areas.Home.Controllers
{


    [Area("Home")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
    }

}