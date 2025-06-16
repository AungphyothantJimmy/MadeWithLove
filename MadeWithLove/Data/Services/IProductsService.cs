using MadeWithLove.Data.Base;
using MadeWithLove.Models;

namespace MadeWithLove.Data.Services
{
    public interface IProductsService : IEntityBaseRepository<Product>
    {
        Task<Product> GetProductByIdAsync(int id);
        Task AddNewProductAsync(NewProductVM data);
        Task UpdateProductAsync(NewProductVM data);

    }
}
