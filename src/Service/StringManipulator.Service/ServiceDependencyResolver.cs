using Microsoft.Extensions.DependencyInjection;
using StringManipulator.Application;

namespace StringManipulator.Service
{
    public static class ServiceDependencyResolver
    {
        public static IServiceCollection ResolveServicesDependency(this IServiceCollection services)
        {
            services.AddScoped<IReverseService, ReverseService>();
            return services;
        }
    }
}
