using Microsoft.Extensions.DependencyInjection;
using RegexMatch.Services.UseCases.Compare;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegexMatch.API.Extensions
{
    public static class UseCaseExtensions
    {
        public static IServiceCollection AddUseCases(this IServiceCollection services)
        {
            services.AddScoped<ICompareUseCase, CompareUseCase>();

            return services;
        }
    }
}
