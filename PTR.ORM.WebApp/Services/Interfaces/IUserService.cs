using PTR.ORM.WebApp.Models.Dtos.Requests;
using PTR.ORM.WebApp.Models.Dtos.Responses;

namespace PTR.ORM.WebApp.Services.Interfaces
{
    public interface IUserService
    {
        IEnumerable<UserResponseDto> GetAll();
        UserResponseDto GetById(int id);
        UserResponseDto CreateUser(CreateUserRequestDto request);
        Task<UserResponseDto> Authenticate(AuthenticationRequestDto request);
        void DeleteUser(int id);
    }
}
