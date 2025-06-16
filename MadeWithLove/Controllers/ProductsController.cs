using MadeWithLove.Data;
using MadeWithLove.Data.Enum;
using MadeWithLove.Data.Services;
using MadeWithLove.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MadeWithLove.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductsService _service;

        public ProductsController(IProductsService service)
        {
            _service = service;
        }


        public async Task<IActionResult> Index(string category, bool sales = false)
        {
            var productsQuery = await _service.GetAllAsync();

            if (!string.IsNullOrEmpty(category) &&
                Enum.TryParse<ProductCategory>(category, out var parsedCategory))
            {
                productsQuery = productsQuery.Where(p => p.ProductCategory == parsedCategory);
            }

            if (sales)
            {
                productsQuery = productsQuery.Where(p => p.IsOnSale);
            }

            var allProducts = await productsQuery.ToListAsync();
            return View(allProducts);
        }


        // Get: Products/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var movieDetails = await _service.GetProductByIdAsync(id);
            return View(movieDetails);
        }


        // Get: Product/Create/1
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewProductVM product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }

            await _service.AddNewProductAsync(product);
            return RedirectToAction(nameof(Index));
        }


        // Get: Product/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var productDetails = await _service.GetProductByIdAsync(id);
            if (productDetails == null) return View("NotFound");

            var response = new NewProductVM()
            {
                Id = productDetails.Id,
                ProductCategory = productDetails.ProductCategory,
                ProductName = productDetails.ProductName,
                ProductDescription = productDetails.ProductDescription,
                ProductPrice = productDetails.ProductPrice,
                ImageURL = productDetails.ImageURL,
                IsOnSale = productDetails.IsOnSale
            };

            return View(response);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(int id, NewProductVM product)
        {
            if (id != product.Id) return View("NotFound");

            if (!ModelState.IsValid)
            {
                return View(product);
            }

            await _service.UpdateProductAsync(product);
            return RedirectToAction(nameof(Index));
        }
    }
}
