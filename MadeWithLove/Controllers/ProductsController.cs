using MadeWithLove.Data;
using MadeWithLove.Data.Enum;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MadeWithLove.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string category, bool sales = false)
        {
            var products = _context.Products.AsQueryable();

            if (!string.IsNullOrEmpty(category) &&
                Enum.TryParse<ProductCategory>(category, out var parsedCategory))
            {
                products = products.Where(p => p.ProductCategory == parsedCategory);
            }

            if (sales)
            {
                products = products.Where(p => p.IsOnSale);
            }

            var productList = await products.ToListAsync();
            return View(productList);
        }

        public IActionResult Create()
        {
            return View();
        }


    }
}
