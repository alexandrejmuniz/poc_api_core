using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public ICollection<ProductWish> ProductWish { get; set; } = new List<ProductWish>();
    }
}