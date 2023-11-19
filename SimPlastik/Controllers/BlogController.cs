using Microsoft.AspNetCore.Mvc;

namespace SimPlastik.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
