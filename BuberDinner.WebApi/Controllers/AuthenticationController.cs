using System.Reflection.Metadata.Ecma335;
using BuberDinner.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace BuberDinner.WebApi.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticationController : Controller
{
    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {

        AuthenticationResponse response = new AuthenticationResponse
        (

            Id : Guid.NewGuid(),
            FirstName : request.FirstName,
            LastName : request.LastName,
            Email : request.Email
        );

        return Ok(response);
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        return Ok(request);
    }
}