using DomainLayer;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ProductBL
    {
        public List<Product> List(int page_size, int page)
        {
            List<Product> lstProducts = new List<Product>();

            lstProducts.Add(new Product() { Id = 1, Name = "Product 1" });
            lstProducts.Add(new Product() { Id = 2, Name = "Product 2" });

            return lstProducts;
        }

        public Product Fetch(int Product_id)
        {
            if (Product_id > 1)
            {
                /**
                 * purposely to be able to perform Product test not found
                 */
                return null;
            }
            return new Product() { Id = Product_id, Name = "Product " };
        }

        /// <summary>
        /// Method of inserting new Products
        /// </summary>
        /// <param name="Product"></param>
        /// <returns>Product code entered</returns>
        public async Task<int> Create(Product Product)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(5000));
            /// then
            /// I return the Product code
            return 1;
        }

        public async Task<bool> Delete(Product Product)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(5000));
            /// then
            /// I return the status of operation
            return true;
        }

        public async Task<bool> Update(Product Product)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(5000));
            /// then
            /// I return the status of operation
            return true;
        }

        public bool Remove(int Product_id)
        {
            try
            {
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}