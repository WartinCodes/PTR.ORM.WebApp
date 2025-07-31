using PTR.ORM.WebApp.Entities;

namespace PTR.ORM.WebApp.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllByUserId(int userId);
        Category Create(Category newCategory);
        void Delete(int id);
    }
}