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
            Product product = new Product() { name = "Televisão" };

            try
            {
                int inserted_id = await new ProductSVC().Create(product);

                var findProduct = new ProductSVC().Fetch(inserted_id);

                Assert.False(findProduct!=null);

                findProduct.name = findProduct.name + "[Modified][" + DateTime.Now.ToLongDateString() + "]";

                Assert.True(await new ProductSVC().Update(findProduct));

                Assert.True(await new ProductSVC().Delete(findProduct));

                Assert.False(new ProductSVC().Fetch(inserted_id)!=null);

            }
            catch (Exception)
            {
                Assert.False(false);
            }
        }
    }
}
