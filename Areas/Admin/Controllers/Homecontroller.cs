using Microsoft.AspNetCore.Mvc;

namespace aspcore.Areas.Admin.Controllers
{
    [Area("Admin")]
     public class HomeController:Controller{
         public IActionResult Index(){

            return Json("Admin");
         }
    }

}