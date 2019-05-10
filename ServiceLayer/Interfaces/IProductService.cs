using System.Collections.Generic;
using System.Threading.Tasks;
using DomainLayer;

namespace ServiceLayer.Interfaces
{
    public interface IProductService
    {
        Task<List<Product>> List(int pageSize, int page);

        Task<int> Create(Product product);

        Task<bool> Delete(Product product);

        Task<bool> Update(Product product);

        Task<Product> Fetch(int productId);
    }
}