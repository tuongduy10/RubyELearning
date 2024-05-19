namespace Rel.Api.DependencyInjection.Extensions;

public static class SwaggerConfigurationExtension
{
    public static IServiceCollection AddSwaggerConfiguration(this IServiceCollection services)
    {
        services.AddSwaggerGen();
        return services;
    }
}
