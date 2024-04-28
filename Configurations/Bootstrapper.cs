using Microsoft.Extensions.DependencyInjection;
using Application.Post.CreatePost;
using MediatR;
using Infrastructure;
using PresentationFacade;
using System.Reflection;
using System;


namespace Configurations;

public static class Bootstrapper
{
    public static void ConfigBootstrapper(this IServiceCollection services)
    {
        InfrastructureBootstrapper.InfrastructureDependency(services);
        FacadeBootstrapper.FacadeLibraryDependency(services);

        services.AddMediatR(config => config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

    }
}
