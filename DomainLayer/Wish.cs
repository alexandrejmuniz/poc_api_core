using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer
{
    public class Wish
    {
        public int id { get; set; }

        public string name { get; set; }

        public User user { get; set; }

        public DateTime timeCreation { get; set; }

        public List<Product> products { get; set; }
    }
}
