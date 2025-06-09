using MadeWithLove.Data;
using Microsoft.AspNetCore.Mvc;

namespace MadeWithLove.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }
        
        public async Task<IActionResult> Index()
        {
            var allProducts = _context.Products.ToList();
            return View(allProducts);
        }
    }
}
