using BusinessLayer;
using DomainLayer;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class ProductSVC
    {
        public List<Product> List(int page_size, int page)
        {
            return new ProductBL().List(page_size, page);
        }

        public Task<int>  Create(Product Product)
        {
            return new ProductBL().Create(Product);
        }

        public Task<bool> Delete(Product Product)
        {
            return new ProductBL().Delete(Product);
        }

        public Task<bool> Update(Product Product)
        {
            return new ProductBL().Update(Product);
        }


        public Product Fetch(int Product_id)
        {
            return new ProductBL().Fetch(Product_id);
        }
    }
}
