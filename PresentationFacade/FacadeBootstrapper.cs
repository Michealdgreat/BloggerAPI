using Microsoft.Extensions.DependencyInjection;
using PresentationFacade.Post;

namespace PresentationFacade;

public static class FacadeBootstrapper
{
    public static void FacadeLibraryDependency(this IServiceCollection services)
    {
        services.AddTransient<IPostFacade, PostFacade>();
    }

}
