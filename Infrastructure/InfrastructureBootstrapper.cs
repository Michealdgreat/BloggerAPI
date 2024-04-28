using Infrastructure.DataAccess;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class InfrastructureBootstrapper
{
    public static void InfrastructureDependency(this IServiceCollection services)
    {
        services.AddTransient<IRepositoryBase, RepositoryBase>();
    }
}
