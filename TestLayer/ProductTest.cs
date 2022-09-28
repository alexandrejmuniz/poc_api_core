using DomainLayer;
using ServiceLayer;
using System;
using Xunit;

namespace TestLayer
{
    public class ProductTest
    {
        /// <summary>
        /// the purpose of this test is to create, locate, modify, and delete a product
        /// </summary>
        [Fact]
        public async System.Threading.Tasks.Task MainAsync()
        {
            Product product = new Product() { Name = "Televisão" };

            try
            {
                int inserted_id = await new ProductService().Create(product);

                var findProduct = new ProductService().Fetch(inserted_id);

                Assert.False(findProduct != null);

                findProduct.Name = findProduct.Name + "[Modified][" + DateTime.Now.ToLongDateString() + "]";

                Assert.True(await new ProductService().Update(findProduct));

                Assert.True(await new ProductService().Delete(findProduct));

                Assert.False(new ProductService().Fetch(inserted_id) != null);
            }
            catch (Exception)
            {
                Assert.False(false);
            }
        }
    }
}