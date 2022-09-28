using DomainLayer;
using ServiceLayer.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using Repositories.Interfaces;

namespace ServiceLayer
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<Product>> List(int pageSize, int page)
        {
            return await _productRepository.List(pageSize, page);
        }

        public async Task<int> Create(Product product)
        {
            return await _productRepository.Create(product);
        }

        public async Task<bool> Delete(Product product)
        {
            return await _productRepository.Delete(product);
        }

        public async Task<bool> Update(Product product)
        {
            return await _productRepository.Update(product);
        }

        public async Task<Product> Fetch(int productId)
        {
            return await _productRepository.Fetch(productId);
        }
    }
}