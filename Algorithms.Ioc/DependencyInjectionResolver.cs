using Microsoft.Extensions.DependencyInjection;

namespace Algorithms.Ioc
{
    public class DependencyInjectionResolver
    {
        public static void Configure(IServiceCollection service)
        {
            //When you need to include a dependency, follow the example 
            //service.AddScoped<Inteface, Classe>();
            //service.AddScoped<IAlgorithmsService, AlgorithmsService>();
        }

    }
}
