using PTR.ORM.WebApp.Data;
using PTR.ORM.WebApp.Entities;
using PTR.ORM.WebApp.Models.Dtos.Requests;
using PTR.ORM.WebApp.Repositories.Interfaces;

namespace PTR.ORM.WebApp.Repositories.Implementations;

public class UserRepository(RestaurantApiContext context) : IUserRepository
{
    private readonly RestaurantApiContext _context = context;

    public User? GetById(int userId)
    {
        return _context.Users.SingleOrDefault(u => u.Id == userId);
    }

    public User? ValidateUser(AuthenticationRequestDto authRequestBody)
    {
        return _context.Users.FirstOrDefault(x => x.RestaurantName == authRequestBody.RestaurantName && x.Password == authRequestBody.Password);
    }

    public IEnumerable<User> GetAll()
    {
        return _context.Users.AsEnumerable();
    }

    public void Update(User updatedUser, int userId)
    {
        User userToUpdate = _context.Users.First(u => u.Id == userId);
        userToUpdate.FirstName = updatedUser.FirstName;
        //userToUpdate.UserName = dto.NombreDeUsuario; //Esto no deberíamos actualizarlo, lo mejor es crear un dto para actualización que no contenga este campo.
        userToUpdate.LastName = updatedUser.LastName;
        userToUpdate.Password = updatedUser.Password;
        _context.SaveChanges();
    }

    public void DeleteUser(int userId)
    {
        User? user = _context.Users.FirstOrDefault(x => x.Id == userId);
        if (user is null)
        {
            throw new Exception("El cliente que intenta eliminar no existe");
        }
        _context.Users.Remove(user);
        _context.SaveChanges();
    }

    public User Create(User newUser)
    {
        User user = _context.Users.Add(newUser).Entity;
        _context.SaveChanges();
        return user;
    }

    public bool CheckIfUserExists(int userId)
    {
        throw new NotImplementedException();
    }
}
