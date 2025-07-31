using PTR.ORM.WebApp.Data;
using PTR.ORM.WebApp.Entities;
using PTR.ORM.WebApp.Repositories.Interfaces;

namespace PTR.ORM.WebApp.Repositories.Implementations
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(RestaurantApiContext context) : base(context) { }

        public IEnumerable<Product> GetAllByUserId(int userId)
        {
            return _context.Products.Where(x => x.UserId == userId).ToList();
        }

        public Product? GetByProductId(int productId)
        {
            return _context.Products.FirstOrDefault(x => x.Id == productId);
        }
    }
}