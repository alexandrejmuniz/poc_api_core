//using DomainLayer;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading.Tasks;

//namespace BusinessLayer
//{
//    public class UserBL
//    {
//        public List<User> List(int page_size, int page)
//        {
//            List<User> lstUsers = new List<User>();

//            lstUsers.Add(new User() { UserId = 1, Name = "Alexandre Muniz", Email = "alexandrejmuniz@gmail.com" });
//            lstUsers.Add(new User() { UserId = 2, Name = "Other Client", Email = "other@client.com" });

//            return lstUsers;
//        }

//        public User Fetch(int user_id)
//        {
//            if (user_id > 1)
//            {
//                /**
//                 * purposely to be able to perform user test not found
//                 */
//                return null;
//            }
//            return new User() { UserId = user_id, Name = "Alexandre Muniz", Email = "alexandrejmuniz@gmail.com" };
//        }

//        /// <summary>
//        /// Method of inserting new users
//        /// </summary>
//        /// <param name="user"></param>
//        /// <returns>user code entered</returns>
//        public async Task<int> Create(User user)
//        {
//            await Task.Delay(TimeSpan.FromMilliseconds(5000));
//            /// then
//            /// I return the user code
//            return 1;
//        }

//        public async Task<bool> Delete(User user)
//        {
//            await Task.Delay(TimeSpan.FromMilliseconds(5000));
//            /// then
//            /// I return the status of operation
//            return true;
//        }

//        public async Task<bool> Update(User user)
//        {
//            await Task.Delay(TimeSpan.FromMilliseconds(5000));
//            /// then
//            /// I return the status of operation
//            return true;
//        }

//        public bool Remove(int user_id)
//        {
//            try
//            {
//                return true;
//            }
//            catch (Exception)
//            {
//                return false;
//            }
//        }
//    }
//}