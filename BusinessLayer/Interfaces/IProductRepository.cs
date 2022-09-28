using System.Collections.Generic;
using System.Threading.Tasks;
using DomainLayer;

namespace Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task<List<Product>> List(int pageSize, int pageCount);

        Task<Product> Fetch(int productId);

        Task<int> Create(Product product);

        Task<bool> Delete(Product product);

        Task<bool> Update(Product product);
    }
}