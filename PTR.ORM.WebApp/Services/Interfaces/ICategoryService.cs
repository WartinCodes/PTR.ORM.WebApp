using PTR.ORM.WebApp.Models.Dtos.Requests;
using PTR.ORM.WebApp.Models.Dtos.Responses;

namespace PTR.ORM.WebApp.Services.Interfaces
{
    public interface ICategoryService
    {
        IEnumerable<CategoryResponseDto> GetAllByUserId(int userId);
        CategoryResponseDto Create(CreateCategoryRequestDto request);
        void Delete(int id);
    }
}
