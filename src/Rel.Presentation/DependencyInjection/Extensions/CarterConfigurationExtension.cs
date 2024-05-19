using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rel.Presentation.DependencyInjection.Extensions;

public static class CarterConfigurationExtension
{
    public static IServiceCollection AddCarterConfiguraion(this IServiceCollection services)
    {
        services.AddCarter();
        return services;
    }

    public static void UserCarter(this WebApplication app)
    {
        app.MapCarter();
    }
}
