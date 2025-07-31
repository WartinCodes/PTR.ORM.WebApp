using PTR.ORM.WebApp.Data;
using PTR.ORM.WebApp.Entities;
using PTR.ORM.WebApp.Models.Dtos.Requests;

namespace PTR.ORM.WebApp.Repositories.Implementations
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(RestaurantApiContext context) : base(context) { }

        public bool CheckIfUserExists(int userId)
        {
            return _context.Users.Any(u => u.Id == userId);
        }

        public User? ValidateUser(AuthenticationRequestDto authRequestBody)
        {
            return _context.Users.FirstOrDefault
                (x => x.RestaurantName == authRequestBody.RestaurantName
                && x.Password == authRequestBody.Password);
        }
    }
}
