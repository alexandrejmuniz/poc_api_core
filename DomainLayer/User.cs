using System.Collections.Generic;

namespace DomainLayer
{
    public class User
    {
        public int UserId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public ICollection<Wish> Wishes { get; set; } = new List<Wish>();
    }
}