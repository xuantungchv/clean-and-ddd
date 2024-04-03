using Microsoft.Extensions.DependencyInjection;
using TungTest.Application.Services.Authentication;

namespace TungTest.Application;
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        return services;
    }
}