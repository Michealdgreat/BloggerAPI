using Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using MediatR;
using PresentationFacade;
using Application.Post.CreatePost;
using Application.Post.DeletePost;
using Application.Post.UpdatePost;
using Query.Post.GetAll;
using Query.Post.GetByCategory;
using Query.Post.GetById;
using Query.Post.GetByTitle;

namespace BlogConfig;

public static class Bootstrapper
{

    public static void ConfigBootstrapper(this IServiceCollection services)
    {
        InfrastructureBootstrapper.InfrastructureDependency(services);
        // services.AddMediatR(config => config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

        services.AddMediatR(cf => cf.RegisterServicesFromAssembly(typeof(Bootstrapper).Assembly));

        FacadeBootstrapper.FacadeLibraryDependency(services);

        services.AddMediatR(cf => cf.RegisterServicesFromAssembly(typeof(CreatePostCommandHandler).Assembly));

        services.AddMediatR(cf => cf.RegisterServicesFromAssembly(typeof(UpdatePostCommandHandler).Assembly));

        services.AddMediatR(cf => cf.RegisterServicesFromAssembly(typeof(DeletePostCommandHandler).Assembly));

        services.AddMediatR(cf => cf.RegisterServicesFromAssembly(typeof(GetPostByCategoryQueryHandler).Assembly));

        services.AddMediatR(cf => cf.RegisterServicesFromAssembly(typeof(GetPostByIdQueryHandler).Assembly));

        services.AddMediatR(cf => cf.RegisterServicesFromAssembly(typeof(GetPostByTitleQueryHandler).Assembly));

        services.AddMediatR(cf => cf.RegisterServicesFromAssembly(typeof(GetPostListQueryHandler).Assembly));

    }
}
