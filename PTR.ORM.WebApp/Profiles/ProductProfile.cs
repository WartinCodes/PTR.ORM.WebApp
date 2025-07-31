using PTR.ORM.WebApp.Entities;
using PTR.ORM.WebApp.Models.Dtos.Requests;
using PTR.ORM.WebApp.Models.Dtos.Responses;
using AutoMapper;

namespace PTR.ORM.WebApp.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<CreateProductRequestDto, Product>();
            CreateMap<Product, ProductResponseDto>();
        }
    }
}
