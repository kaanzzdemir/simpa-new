using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimPlastik.Models.Context;
using SimPlastik.Models.ViewModels;

namespace SimPlastik.Controllers
{
    public class ProductController : Controller
    {
        private readonly SimpaDbContext _context;

        public ProductController(SimpaDbContext context)
        {
            _context = context;
        }

        public IActionResult ProductList()
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
        public IActionResult ProductListByCategory(int categoryId)
        {
            var productViewModel = new LayoutViewModel
            {
                Contacts = _context.Contacts.ToList(),
                Abouts = _context.Abouts.ToList(),
                Categories = _context.Categories.ToList(),
                Products = _context.Products.Where(p => p.category_id == categoryId).ToList()
            };
            return View("ProductList", productViewModel);
        }
        [HttpGet("Product/ProductDetail")]
        public IActionResult ProductDetail(int productId)
        {
            var productViewModel = new LayoutViewModel
            {
                Contacts = _context.Contacts.ToList(),
                Abouts = _context.Abouts.ToList(),
                Products = _context.Products.ToList(),
                Categories = _context.Categories.ToList()
            };
            ViewBag.prodId = productId;
            ViewBag.prodTitle = productViewModel.Products.First(x => x.product_id == productId).product_name;
            ViewBag.prodCode = productViewModel.Products.First(x => x.product_id == productId).product_code;
            return View(productViewModel);
        }
    }
}
