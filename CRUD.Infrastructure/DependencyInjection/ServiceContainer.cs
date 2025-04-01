using CRUD.Domain.RepositoryInterface;
using CRUD.Infrastructure.DatabaseContext;
using CRUD.Infrastructure.RepositoryImplementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CRUD.Infrastructure.DependencyInjection;

public static class ServiceContainer
{
    public static IServiceCollection AddInfrastructureService(this IServiceCollection services,
        IConfiguration config)
    {
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        });
        services.AddScoped<IProductRepository, ProductRepository>();
        return services;
    }
}
