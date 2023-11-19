using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using SimPlastik.Models;
using SimPlastik.Models.Context;
using SimPlastik.Models.ViewModels;
using SimPlastik.Services;
using System.Diagnostics;
using System.Globalization;

namespace SimPlastik.Controllers
{



    public class HomeController : Controller
    {

        private readonly SimpaDbContext _context;
        private readonly ILogger<HomeController> _logger;
        private LanguageService _localization;
        public HomeController(ILogger<HomeController> logger, LanguageService localization, SimpaDbContext context)
        {
            _logger = logger;
            _localization = localization;
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.Welcome = _localization.Getkey("Welcome").Value;
            var currentCulture = Thread.CurrentThread.CurrentCulture.Name;

            var productViewModel = new LayoutViewModel
            {
                Contacts = _context.Contacts.ToList(),
                Abouts = _context.Abouts.ToList(),
                Products = _context.Products.ToList(),
                Categories = _context.Categories.ToList()
            };

            return View(productViewModel);
        }

        public IActionResult ChangeLanguage(string culture)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName, CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)), new CookieOptions()
            {
                Expires = DateTimeOffset.UtcNow.AddYears(1)
            });
            return Redirect(Request.Headers["Referer"].ToString());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}