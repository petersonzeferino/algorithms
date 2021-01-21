using Algorithms.Ioc;
using Microsoft.Extensions.DependencyInjection;

namespace Algorithms.Console.Gateway.Extensions
{
    public static class DependencyInjectionExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            DependencyInjectionResolver.Configure(services);
        }

    }
}
