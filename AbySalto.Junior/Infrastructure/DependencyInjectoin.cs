using AbySalto.Junior.Domain.Interfaces;
using AbySalto.Junior.Infrastructure.Database;
using AbySalto.Junior.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AbySalto.Junior.Infrastructure;

public static class DependencyInjectoin
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration config)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(config.GetConnectionString("DefaultConnection"))); 
        
        
        services.AddScoped<IOrderRepository, OrderRepository>();

        return services; 
    }
}