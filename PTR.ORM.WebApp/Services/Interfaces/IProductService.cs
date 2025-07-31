using PTR.ORM.WebApp.Models.Dtos.Requests;
using PTR.ORM.WebApp.Models.Dtos.Responses;

namespace PTR.ORM.WebApp.Services.Interfaces;

public interface IProductService
{
    IEnumerable<ProductResponseDto> GetAll();
    IEnumerable<ProductResponseDto> GetAllByUserIdAsync(int userId);
    ProductResponseDto GetByProductId(int productId);
    ProductResponseDto Create(CreateProductRequestDto request);
    //Task<ProductResponseDto> UpdateAsync(UpdateProductRequestDto request, int productId);
    void Delete(int id);
}