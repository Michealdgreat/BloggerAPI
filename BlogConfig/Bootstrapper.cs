﻿using Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using MediatR;
using PresentationFacade;

namespace BlogConfig;

public static class Bootstrapper
{

    public static void ConfigBootstrapper(this IServiceCollection services)
    {
        InfrastructureBootstrapper.InfrastructureDependency(services);
        // services.AddMediatR(config => config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

        services.AddMediatR(cf => cf.RegisterServicesFromAssembly(typeof(Bootstrapper).Assembly));

        FacadeBootstrapper.FacadeLibraryDependency(services);

    }
}