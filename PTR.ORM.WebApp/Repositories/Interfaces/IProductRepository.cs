using PTR.ORM.WebApp.Entities;

namespace PTR.ORM.WebApp.Repositories.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetAllByUserId(int userId);
    }
}
