using System.Security.Claims;
using BuberDinner.Application.Common.Interfaces.Authentication;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using BuberDinner.Application.Common.Interfaces.Services;

namespace BuberDinner.Infrastructure.Authentication;

public class JwtTokenGenerator : IJwtTokenGenerator
{
    private readonly IDateTimeProvider _dateTimeProvider;

    public JwtTokenGenerator(IDateTimeProvider dateTimeProvider)
    {
        _dateTimeProvider = dateTimeProvider;
    }
    public string GenerateToken(Guid userId, string firstname, string lastName)
    {
        var signingCredentials = new SigningCredentials(
            new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes("super-secret-key-generated-forexample")),
            SecurityAlgorithms.HmacSha256);

        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, userId.ToString()),
            new Claim(JwtRegisteredClaimNames.GivenName, firstname),
            new Claim(JwtRegisteredClaimNames.FamilyName, lastName),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
        };

        var securityToken = new JwtSecurityToken(
            issuer: "BuberDinner",
            expires: _dateTimeProvider.UtcNow.AddMinutes(60),
            claims: claims,
            signingCredentials: signingCredentials);

        var token = new JwtSecurityTokenHandler().WriteToken(securityToken);
        return token;
    }
}
