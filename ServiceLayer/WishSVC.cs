//using BusinessLayer;
//using DomainLayer;
//using System;
//using System.Collections.Generic;
//using System.Threading.Tasks;

//namespace ServiceLayer
//{
//    public class WishSVC
//    {
//        public List<Wish> List(int page_size, int page)
//        {
//            return new WishBL().List(page_size, page);
//        }

//        public Task<int>  Create(Wish Wish)
//        {
//            return new WishBL().Create(Wish);
//        }

//        public Task<bool> Delete(Wish Wish)
//        {
//            return new WishBL().Delete(Wish);
//        }

//        public Task<bool> Update(Wish Wish)
//        {
//            return new WishBL().Update(Wish);
//        }

//        public Wish Fetch(int Wish_id)
//        {
//            return new WishBL().Fetch(Wish_id);
//        }
//    }
//}