using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DomainLayer;
using Microsoft.EntityFrameworkCore;
using Repositories.Context;
using Repositories.Interfaces;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly InMemoryDbContext _context;

        public ProductRepository(InMemoryDbContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> List(int pageSize, int pageCount)
        {
            var skip = pageSize * (pageCount - 1);

            var products = await _context.Products
                .OrderBy(d => d.Name)
                .Skip(skip)
                .Take(pageSize)
                .ToListAsync();

            return products;
        }

        public async Task<Product> Fetch(int productId)
        {
            return await _context.Products.FirstOrDefaultAsync(p => p.ProductId == productId);
        }

        public async Task<int> Create(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            return product.ProductId;
        }

        public async Task<bool> Delete(Product product)
        {
            var entity =
                await _context.Products.SingleOrDefaultAsync(p => p.ProductId == product.ProductId);

            if (entity == null)
            {
                return false;
            }

            _context.Products.Remove(entity);

            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> Update(Product product)
        {
            var entity =
                await _context.Products.SingleOrDefaultAsync(p => p.ProductId == product.ProductId);

            if (entity == null)
            {
                return false;
            }

            _context.Entry(entity).CurrentValues.SetValues(product);

            await _context.SaveChangesAsync();

            return true;
        }
    }
}