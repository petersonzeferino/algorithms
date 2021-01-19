using Algorithms.Application;
using Algorithms.Application.Services.Algorithms;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

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
