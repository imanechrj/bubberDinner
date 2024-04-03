<<<<<<< HEAD
using BuberDinner.Application.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace BubberDinner.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();
=======
using BuberDinner.Application.Common.Interfaces.Authentication;
using BuberDinner.Application.Common.Interfaces.Services;
using BuberDinner.Application.Services.Authentication;
using BuberDinner.Infrastructure.Authentication;
using BuberDinner.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BubberDinner.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
>>>>>>> a4ce908 (fix)
        return services;
    }
}