namespace BuberDinner.Application.Services.Authentication;

public interface IAuthenticationService
{
    AuthenticationResult Register(string firstName, string lastNmae, string email, string password);
    AuthenticationResult Login(string email, string password);

}