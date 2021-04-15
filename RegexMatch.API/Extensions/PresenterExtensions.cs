using Microsoft.Extensions.DependencyInjection;
using RegexMatch.API.Presenters;
using RegexMatch.Services.UseCases.Compare;

namespace RegexMatch.API.Extensions
{
    public static class PresenterExtensions
    {
        public static IServiceCollection AddPresenter(this IServiceCollection services)
        {
            services.AddScoped<ComparePresenter, ComparePresenter>();
            services.AddScoped<ICompareOuputPort>(x => x.GetRequiredService<ComparePresenter>());

            return services;
        }
    }
}
