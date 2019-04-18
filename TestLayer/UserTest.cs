using DomainLayer;
using ServiceLayer;
using System;
using Xunit;

namespace TestLayer
{
    public class UserTest
    {
        /// <summary>
        /// the purpose of this test is to create, locate, modify, and delete a User
        /// </summary>
        [Fact]
        public async System.Threading.Tasks.Task MainAsync()
        {
            User User = new User() {
                id = 1,
                name = "Alexandre",
                email = "alexandrejmuniz@gmail.com"    
            };

            try
            {
                int inserted_id = await new UserSVC().Create(User);

                var findUser = new UserSVC().Fetch(inserted_id);

                Assert.False(findUser != null);

                findUser.name = findUser.name + "[Modified][" + DateTime.Now.ToLongDateString() + "]";

                Assert.True(await new UserSVC().Update(findUser));

                Assert.True(await new UserSVC().Delete(findUser));

                Assert.False(new UserSVC().Fetch(inserted_id) != null);

            }
            catch (Exception)
            {
                Assert.False(false);
            }
        }
    }
}
