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

            lstProducts.Add(new Product() { id = 1, name = "Product 1" });
            lstProducts.Add(new Product() { id = 2, name = "Product 2" });

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
            return new Product() { id = Product_id, name = "Product " };
        }

        /// <summary>
        /// Method of inserting new Products
        /// </summary>
        /// <param name="Product"></param>
        /// <returns>Product code entered</returns>
        public async Task<int> Create(Product Product)
        {
            #region persistence layer or api call for insertion

            #endregion
            await Task.Delay(TimeSpan.FromMilliseconds(5000));
            /// then 
            /// I return the Product code
            return 1;
        }

        public async Task<bool> Delete(Product Product)
        {
            #region persistence layer or api call for DELETE

            #endregion
            await Task.Delay(TimeSpan.FromMilliseconds(5000));
            /// then 
            /// I return the status of operation
            return true;
        }

        public async Task<bool> Update(Product Product)
        {
            #region persistence layer or api call for UPDATE

            #endregion
            await Task.Delay(TimeSpan.FromMilliseconds(5000));
            /// then 
            /// I return the status of operation
            return true;
        }

        public bool Remove(int Product_id)
        {
            try
            {
                #region Logic for persistence in the data repository

                #endregion

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }

}
