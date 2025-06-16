using MadeWithLove.Data.Base;
using MadeWithLove.Models;
using Microsoft.EntityFrameworkCore;

namespace MadeWithLove.Data.Services
{
    public class ProductsService : EntityBaseRepository<Product>, IProductsService
    {
        private readonly AppDbContext _context;
        public ProductsService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            var productDetails = await _context.Products.FirstOrDefaultAsync(n  => n.Id == id);
            return productDetails;
        }

        // Add new Product to database
        public async Task AddNewProductAsync(NewProductVM data)
        {
            var newProduct = new Product()
            {
                ProductName = data.ProductName,
                ProductDescription = data.ProductDescription,
                ProductCategory = data.ProductCategory,
                ProductPrice = data.ProductPrice,
                ImageURL = data.ImageURL,
            };
            await _context.Products.AddAsync(newProduct);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateProductAsync(NewProductVM data)
        {
            var dbProduct = await _context.Products.FirstOrDefaultAsync(n => n.Id == data.Id);

            if (dbProduct != null)
            {
                dbProduct.ProductName = data.ProductName;
                dbProduct.ProductDescription = data.ProductDescription;
                dbProduct.ProductCategory = data.ProductCategory;
                dbProduct.ProductPrice = data.ProductPrice;
                dbProduct.ImageURL = data.ImageURL;

                await _context.SaveChangesAsync();
            }

        }

    }
}
