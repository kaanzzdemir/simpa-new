using Microsoft.AspNetCore.Mvc;
using SimPlastik.Models.Context;
using SimPlastik.Models.Entity;
using SimPlastik.Models.ViewModels;

namespace SimPlastik.Controllers
{
    public class ContactController : Controller
    {
        private readonly SimpaDbContext _context;

        public ContactController(SimpaDbContext context)
        {
            _context = context;
        }
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
