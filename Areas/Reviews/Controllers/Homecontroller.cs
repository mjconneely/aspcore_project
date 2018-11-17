using Microsoft.AspNetCore.Mvc;
using aspcore.Areas.Home.Models;
namespace aspcore.Areas.Reviews.Controllers
{


    [Area("Reviews")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
    }

}