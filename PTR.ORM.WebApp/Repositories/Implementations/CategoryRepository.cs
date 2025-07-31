using Microsoft.EntityFrameworkCore;
using PTR.ORM.WebApp.Data;
using PTR.ORM.WebApp.Entities;
using PTR.ORM.WebApp.Repositories.Implementations;
using PTR.ORM.WebApp.Repositories.Interfaces;

public class CategoryRepository : Repository<Category>, ICategoryRepository
{
    public CategoryRepository(RestaurantApiContext context) : base(context) { }

    public IEnumerable<Category> GetAllByUserId(int userId)
    {
        return _context.Categories.Where(x => x.UserId == userId).ToList();
    }
}