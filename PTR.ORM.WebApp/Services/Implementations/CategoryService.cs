using PTR.ORM.WebApp.Entities;
using PTR.ORM.WebApp.Models.Dtos.Requests;
using PTR.ORM.WebApp.Models.Dtos.Responses;
using PTR.ORM.WebApp.Repositories.Interfaces;
using PTR.ORM.WebApp.Services.Interfaces;
using AutoMapper;

namespace PTR.ORM.WebApp.Services.Implementations;

public class CategoryService(ICategoryRepository categoryRepository, IMapper mapper) : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository = categoryRepository;
    private readonly IMapper _mapper = mapper;

    public CategoryResponseDto Create(CreateCategoryRequestDto request)
    {
        Category category = _mapper.Map<Category>(request);
        Category createdCategory = _categoryRepository.Create(category);
        return _mapper.Map<CategoryResponseDto>(createdCategory);
    }

    public IEnumerable<CategoryResponseDto> GetAllByUserId(int userId)
    {
        var categories = _categoryRepository.GetAllByUserId(userId);
        return _mapper.Map<IEnumerable<CategoryResponseDto>>(categories);
    }

    public void Delete(int id)
    {
        _categoryRepository.Delete(id);
    }
}