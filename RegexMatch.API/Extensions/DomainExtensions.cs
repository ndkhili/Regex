using Microsoft.Extensions.DependencyInjection;
using RegexMatch.Domain;

namespace RegexMatch.API.Extensions
{
    public static class DomainExtensions
    {
        public static IServiceCollection AddDomain(this IServiceCollection services)
        {
            services.AddScoped<IRegexMatch, RegexMatch.Domain.RegexMatch>();

            return services;
        }
    }
}
