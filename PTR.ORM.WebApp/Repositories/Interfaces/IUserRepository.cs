using PTR.ORM.WebApp.Entities;
using PTR.ORM.WebApp.Models.Dtos.Requests;

namespace PTR.ORM.WebApp.Repositories.Interfaces;

public interface IUserRepository
{
    bool CheckIfUserExists(int userId);
    User Create(User newUser);
    IEnumerable<User> GetAll();
    User? GetById(int userId);
    void DeleteUser(int userId);
    void Update(User updatedUser, int userId);
    User? ValidateUser(AuthenticationRequestDto authRequestBody);
}