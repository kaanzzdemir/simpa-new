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
            var contact_text = _context.Contacts.ToList();

            var viewModel = new LayoutViewModel
            {
                Contacts = contact_text
            };

            return View(contact_text);
        }
    }
}
