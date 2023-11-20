using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using SimPlastik.Models.Context;
using SimPlastik.Models.ViewModels;
using SimPlastik.Services;

namespace SimPlastik.Controllers
{
    public class AboutController : Controller
    {
        private readonly SimpaDbContext _context;
        public AboutController(SimpaDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var productViewModel = new LayoutViewModel
            {
                Contacts = _context.Contacts.ToList(),
                Abouts = _context.Abouts.ToList(),
                Products = _context.Products.ToList(),
                Categories = _context.Categories.ToList()
            };
            return View(productViewModel);
        }
    }
}
