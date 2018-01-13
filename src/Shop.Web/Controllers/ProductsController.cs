﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Core.Domain;
using Shop.Web.Models;

namespace Shop.Web.Controllers
{
    [Route("products")]
    public class ProductsController : Controller
    {
        private static readonly List<Product> _products = new List<Product>
        {
            new Product("Laptop", "Electronics", 3500),
            new Product("Jeans", "Trousers", 150),
            new Product("Hummer", "Tools", 50)
        };

        [HttpGet]
        public IActionResult Index()
        {
            return View(_products);
        }

        [HttpGet("add")]
        public IActionResult Add()
        {
            var viewModel = new ProductViewModel();

            return View(viewModel);
        }

        [HttpPost("add")]
        public IActionResult Add(ProductViewModel viewModel)
        {
            if(!ModelState.IsValid)
            {
                return View(viewModel);
            }
            _products.Add(new Product(viewModel.Name, viewModel.Category, viewModel.Price));

            return RedirectToAction(nameof(Index));
        }
    }
}