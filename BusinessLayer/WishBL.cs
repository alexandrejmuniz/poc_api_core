//using DomainLayer;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading.Tasks;

//namespace BusinessLayer
//{
//    public class WishBL
//    {
//        public List<Wish> List(int page_size, int page)
//        {
//            List<Wish> lstWishs = new List<Wish>();

//            List<Product> lstProducts = new List<Product>();

//            lstProducts.Add(new Product() { ProductId = 1, Name = "TV" });

//            lstProducts.Add(new Product() { ProductId = 2, Name = "Geladeira" });

//            lstWishs.Add(new Wish()
//            {
//                WishId = 1,
//                Name = "Minha Lista de Desejos",
//                User = new User()
//                {
//                    UserId = 1,
//                    Name = "Alexandre Muniz",
//                    Email = "alexandrejmuniz@gmail.com"
//                },
//                Products = lstProducts
//            });

//            return lstWishs;
//        }

//        public Wish Fetch(int Wish_id)
//        {
//            if (Wish_id > 1)
//            {
//                /**
//                 * purposely to be able to perform Wish test not found
//                 */
//                return null;
//            }

//            List<Product> lstProducts = new List<Product>();

//            lstProducts.Add(new Product() { ProductId = 1, Name = "TV" });

//            lstProducts.Add(new Product() { ProductId = 2, Name = "Geladeira" });

//            return new Wish()
//            {
//                WishId = Wish_id,
//                Name = "Minha Lista de Desejos",
//                User = new User()
//                {
//                    UserId = 1,
//                    Name = "Alexandre Muniz",
//                    Email = "alexandrejmuniz@gmail.com"
//                },
//                Products = lstProducts
//            };
//        }

//        /// <summary>
//        /// Method of inserting new Wishs
//        /// </summary>
//        /// <param name="Wish"></param>
//        /// <returns>Wish code entered</returns>
//        public async Task<int> Create(Wish Wish)
//        {
//            await Task.Delay(TimeSpan.FromMilliseconds(5000));
//            /// then
//            /// I return the Wish code
//            return 1;
//        }

//        public async Task<bool> Delete(Wish Wish)
//        {
//            await Task.Delay(TimeSpan.FromMilliseconds(5000));
//            /// then
//            /// I return the status of operation
//            return true;
//        }

//        public async Task<bool> Update(Wish Wish)
//        {
//            await Task.Delay(TimeSpan.FromMilliseconds(5000));
//            /// then
//            /// I return the status of operation
//            return true;
//        }

//        public bool Remove(int Wish_id)
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