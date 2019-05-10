using DomainLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Context
{
    public class WishTypeConfiguration : IEntityTypeConfiguration<Wish>
    {
        public void Configure(EntityTypeBuilder<Wish> builder)
        {
            builder.HasKey(e => e.WishId);

            builder.Property(e => e.WishId)
                .ValueGeneratedNever()
                .IsRequired();

            builder.Property(e => e.Name)
                .IsRequired();

            builder.Property(e => e.TimeCreation)
                .IsRequired();

            builder.HasOne(e => e.User)
                .WithMany(p => p.Wishes)
                .HasForeignKey(d => d.WishId);
        }
    }
}