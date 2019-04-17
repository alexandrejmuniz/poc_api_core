using BusinessLayer;
using DomainLayer;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class UserSVC
    {
        public List<User> List(int page_size, int page)
        {
            return new UserBL().List(page_size, page);
        }

        public Task<int>  Create(User user)
        {
            return new UserBL().Create(user);
        }

        public Task<bool> Delete(User user)
        {
            return new UserBL().Delete(user);
        }

        public Task<bool> Update(User user)
        {
            return new UserBL().Update(user);
        }


        public User Fetch(int user_id)
        {
            return new UserBL().Fetch(user_id);
        }
    }
}
