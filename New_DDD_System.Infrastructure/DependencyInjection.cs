using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using New_DDD_System.Infrastructure.Database;

namespace New_DDD_System.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
        {
            string connectionString = configuration.GetConnectionString("Local-SqlServer") ?? throw new InvalidOperationException("ConnectionString Does't exsit.....");

            options.UseSqlServer(connectionString);
        });

        return services;
    }
}
