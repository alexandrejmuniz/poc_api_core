using DomainLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Context
{
    public class ProductWishTypeConfiguration : IEntityTypeConfiguration<ProductWish>
    {
        public void Configure(EntityTypeBuilder<ProductWish> builder)
        {
            builder.HasKey(bc => new { bc.ProductId, bc.WishId });

            builder
                .HasOne(bc => bc.Product)
                .WithMany(b => b.ProductWish)
                .HasForeignKey(bc => bc.ProductId);

            builder
                .HasOne(bc => bc.Wish)
                .WithMany(c => c.ProductWish)
                .HasForeignKey(bc => bc.WishId);
        }
    }
}