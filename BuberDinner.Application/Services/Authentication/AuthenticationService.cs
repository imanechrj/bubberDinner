<<<<<<< HEAD
=======
using BuberDinner.Application.Common.Interfaces.Authentication;

>>>>>>> a4ce908 (fix)
namespace BuberDinner.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
<<<<<<< HEAD
    public AuthenticationResult Register(string firstName, string lastName, string email, string password)
    {
        return new AuthenticationResult(
            Guid.NewGuid(),
            firstName,
            lastName,
            email,
            "token");
=======
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    public AuthenticationResult Register(string firstName, string lastName, string email, string password)
    {

        Guid userId = Guid.NewGuid();
        var token = _jwtTokenGenerator.GenerateToken(userId, firstName, lastName);

        return new AuthenticationResult(
            userId,
            firstName,
            lastName,
            email,
            token);
>>>>>>> a4ce908 (fix)
    }

    public AuthenticationResult Login(string email, string password)
    {
        return new AuthenticationResult(
            Guid.NewGuid(),
            "firstName",
            "lastName",
            email,
            "token");
    }
}