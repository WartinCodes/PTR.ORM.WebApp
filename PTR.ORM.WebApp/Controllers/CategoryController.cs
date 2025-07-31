using PTR.ORM.WebApp.Models.Dtos.Requests;
using PTR.ORM.WebApp.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PTR.ORM.WebApp.Controllers;

[Route("api/[controller]")]
[Authorize]
[ApiController]
public class CategoryController(ICategoryService categoryService) : ControllerBase
{
    private readonly ICategoryService _categoryService = categoryService;

    [HttpGet]
    public IActionResult GetAllByUserId(int userId)
    {
        var categories = _categoryService.GetAllByUserId(userId);
        return Ok(categories);
    }

    [HttpPost]
    public IActionResult Create(CreateCategoryRequestDto request)
    {
        var newCategory = _categoryService.Create(request);
        return Ok(newCategory);
    }

    [HttpDelete]
    public IActionResult Delete(int id)
    {
        _categoryService.Delete(id);
        return Ok();
    }
}
