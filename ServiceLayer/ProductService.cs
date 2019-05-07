using BusinessLayer;
using DomainLayer;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class ProductService : IProductService
    {
        public List<Product> List(int pageSize, int page)
        {
            return new ProductBL().List(pageSize, page);
        }

        public Task<int> Create(Product product)
        {
            return new ProductBL().Create(product);
        }

        public Task<bool> Delete(Product product)
        {
            return new ProductBL().Delete(product);
        }

        public Task<bool> Update(Product product)
        {
            return new ProductBL().Update(product);
        }

        public Product Fetch(int productId)
        {
            return new ProductBL().Fetch(productId);
        }
    }
}