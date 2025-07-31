using PTR.ORM.WebApp.Entities;
using PTR.ORM.WebApp.Models.Dtos.Requests;
using PTR.ORM.WebApp.Repositories.Interfaces;

public interface IUserRepository : IRepository<User>
{
    bool CheckIfUserExists(int userId);
    User? ValidateUser(AuthenticationRequestDto authRequestBody);
}