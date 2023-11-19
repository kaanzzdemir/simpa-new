using Microsoft.AspNetCore.Mvc;
using SimPlastik.Models.Context;
using SimPlastik.Models.ViewModels;

namespace SimPlastik.Controllers
{
    public class AboutController : Controller
    {
        private readonly SimpaDbContext _context;

        public AboutController(SimpaDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var about_text = _context.Abouts.ToList();

            var viewModel = new LayoutViewModel
            {
                Abouts = about_text
            };

            return View(about_text);
        }
    }
}
