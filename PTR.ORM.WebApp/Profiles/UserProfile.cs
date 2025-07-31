using PTR.ORM.WebApp.Entities;
using PTR.ORM.WebApp.Models.Dtos.Requests;
using PTR.ORM.WebApp.Models.Dtos.Responses;
using AutoMapper;

namespace PTR.ORM.WebApp.Profiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<CreateUserRequestDto, User>();
        CreateMap<User, UserResponseDto>();
        // UPDATE
    }
}
