namespace PTR.ORM.WebApp.Services.Interfaces;

public interface ITokenService
{
    string GenerateToken(string username);
}
