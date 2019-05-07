using System.Collections.Generic;
using System.Threading.Tasks;
using DomainLayer;

namespace ServiceLayer
{
    public interface IProductService
    {
        List<Product> List(int pageSize, int page);

        Task<int> Create(Product product);

        Task<bool> Delete(Product product);

        Task<bool> Update(Product product);

        Product Fetch(int productId);
    }
}