using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using New_DDD_System.Application.Core.Data;
using New_DDD_System.Domain.Users;
using New_DDD_System.Infrastructure.Database;
using New_DDD_System.Infrastructure.Repositories;

namespace New_DDD_System.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        // Register dbContext. to the Container.
        services.AddDbContext<AppDbContext>(options =>
        {
            string connectionString = configuration.GetConnectionString("Local-SqlServer") ?? throw new InvalidOperationException("ConnectionString Does't exsit.....");

            options.UseSqlServer(connectionString);
        });

        services.AddScoped<IDbContext>(serviceProvider => serviceProvider.GetRequiredService<AppDbContext>());

        services.AddScoped<IUnitOfWork>(serviceProvider => serviceProvider.GetRequiredService<AppDbContext>());

        // Register Repositories to the Container.
        services.AddScoped<IUserRepository, UserRepository>();

        return services;
    }
}
