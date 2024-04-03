namespace BuberDinner.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(Guid userId, string firstname, string lastName);
}