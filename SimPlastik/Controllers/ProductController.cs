﻿using Microsoft.AspNetCore.Mvc;

namespace SimPlastik.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ProductList()
        {
            return View();
        }
        public IActionResult ProductDetail()
        {
            return View();
        }
    }
}
