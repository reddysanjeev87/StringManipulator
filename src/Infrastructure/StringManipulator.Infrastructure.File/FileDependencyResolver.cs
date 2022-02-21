using Microsoft.Extensions.DependencyInjection;
using StringManipulator.Application;

namespace StringManipulator.Infrastructure
{
    public static class FileDependencyResolver
    {
        public static IServiceCollection ResolveFileDependency(this IServiceCollection services)
        {
            services.AddScoped<IFileReader, FileReader>();
            services.AddScoped<IFileWriter, FileWriter>();
            return services;
        }
    }
}
