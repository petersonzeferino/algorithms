using Algorithms.Ioc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

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
