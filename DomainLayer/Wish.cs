using System;
using System.Collections.Generic;

namespace DomainLayer
{
    public class Wish
    {
        public int WishId { get; set; }

        public string Name { get; set; }

        public User User { get; set; }

        public DateTime TimeCreation { get; set; }

        public ICollection<ProductWish> ProductWish { get; set; } = new List<ProductWish>();
    }
}