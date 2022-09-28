using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using DomainLayer;
using Repositories.Context.TypeConfiguration;

namespace Repositories.Context
{
    public class InMemoryDbContext : DbContext
    {
        public InMemoryDbContext(DbContextOptions<InMemoryDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ProductTypeConfiguration());
            builder.ApplyConfiguration(new UserTypeConfiguration());
            builder.ApplyConfiguration(new WishTypeConfiguration());
            builder.ApplyConfiguration(new ProductWishTypeConfiguration());

            base.OnModelCreating(builder);
        }

        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Wish> Wishes { get; set; }
    }
}