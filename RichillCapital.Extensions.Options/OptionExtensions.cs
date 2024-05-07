using Microsoft.Extensions.DependencyInjection;

namespace RichillCapital.Extensions.Options;

public static class OptionExtensions
{
    public static IServiceCollection AddOptionsWithFluentValidation<TOptions>(
        this IServiceCollection services,
        string sectionKey)
        where TOptions : class
    {
        services
            .AddOptions<TOptions>()
            .BindConfiguration(sectionKey)
            .ValidateWithFluentValidation()
            .ValidateOnStart();

        return services;
    }
}