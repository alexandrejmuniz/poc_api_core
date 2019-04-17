using DomainLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class UserBL
    {
        public List<User> List(int page_size, int page)
        {
            List<User> lstUsers = new List<User>();

            lstUsers.Add(new User() { id = 1, name = "Alexandre Muniz", email = "alexandrejmuniz@gmail.com" });
            lstUsers.Add(new User() { id = 2, name = "Other Client", email = "other@client.com" });

            return lstUsers;

        }

        public User Fetch(int user_id)
        {

            if (user_id>1)
            {
                /**
                 * purposely to be able to perform user test not found
                 */
                return null;
            }
            return new User() { id = user_id, name = "Alexandre Muniz", email = "alexandrejmuniz@gmail.com" };
        }

        /// <summary>
        /// Method of inserting new users
        /// </summary>
        /// <param name="user"></param>
        /// <returns>user code entered</returns>
        public async Task <int> Create(User user)
        {
            #region persistence layer or api call for insertion

            #endregion
            await Task.Delay( TimeSpan.FromMilliseconds(5000) );
            /// then 
            /// I return the user code
            return 1;
        }

        public async Task<bool> Delete(User user)
        {
            #region persistence layer or api call for DELETE

            #endregion
            await Task.Delay(TimeSpan.FromMilliseconds(5000));
            /// then 
            /// I return the status of operation
            return true;
        }

        public async Task<bool> Update(User user)
        {
            #region persistence layer or api call for UPDATE

            #endregion
            await Task.Delay(TimeSpan.FromMilliseconds(5000));
            /// then 
            /// I return the status of operation
            return true;
        }

        public bool Remove(int user_id)
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
