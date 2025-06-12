using MadeWithLove.Data.Base;
using MadeWithLove.Models;

namespace MadeWithLove.Data.Services
{
    public class ProductsService : EntityBaseRepository<Product>, IProductsService
    {
        public ProductsService(AppDbContext context) : base(context) { }
    }
}
