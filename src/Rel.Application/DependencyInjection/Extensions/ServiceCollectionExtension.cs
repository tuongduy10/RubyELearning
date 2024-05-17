using Rel.Application.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rel.Application.DependencyInjection.Extensions;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddConfigurationAutoMapper(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(ProductsProfile));
        //services.AddAutoMapper(typeof(UsersProfile));
        //services.AddAutoMapper(typeof(TrainingProfile));
        return services;
    }
}
