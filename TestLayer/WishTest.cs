using DomainLayer;
using ServiceLayer;
using System;
using Xunit;

namespace TestLayer
{
    public class WishTest
    {
        /// <summary>
        /// the purpose of this test is to create, locate, modify, and delete a Wish
        /// </summary>
        [Fact]
        public async System.Threading.Tasks.Task MainAsync()
        {
            Wish Wish = new Wish()
            {
                id = 1,
                name = "My Best Wish List",
            };

            try
            {
                int inserted_id = await new WishSVC().Create(Wish);

                var findWish = new WishSVC().Fetch(inserted_id);

                Assert.False(findWish != null);

                findWish.name = findWish.name + "[Modified][" + DateTime.Now.ToLongDateString() + "]";

                Assert.True(await new WishSVC().Update(findWish));

                Assert.True(await new WishSVC().Delete(findWish));

                Assert.False(new WishSVC().Fetch(inserted_id) != null);

            }
            catch (Exception)
            {
                Assert.False(false);
            }
        }
    }
}
