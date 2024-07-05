namespace Rel.Application.DependencyInjection.Extensions;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddMediatRConfiguration(this IServiceCollection services)
    {
        services
            .AddMediatR(cfg => cfg.RegisterServicesFromAssembly(AssemblyReference.assembly))
            .AddTransient(typeof(IPipelineBehavior<,>), typeof(TransactionPipelineBehavior<,>));
        return services;
    }
    public static IServiceCollection AddAutoMapperConfiguration(this IServiceCollection services)
    {
        services
            .AddAutoMapper(typeof(ProductsProfile));
        //services.AddAutoMapper(typeof(UsersProfile));
        //services.AddAutoMapper(typeof(TrainingProfile));
        return services;
    }
}
