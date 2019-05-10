namespace DomainLayer
{
    public class ProductWish
    {
        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int WishId { get; set; }

        public Wish Wish { get; set; }
    }
}