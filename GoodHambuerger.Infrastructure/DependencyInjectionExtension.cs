using GoodHambuerger.Domain.Interfaces;
using GoodHambuerger.Infrastructure.Persistence;
using GoodHambuerger.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GoodHambuerger.Infrastructure;

public static class DependencyInjectionExtension
{
    public static void AddInfrastructure(this IServiceCollection services)
    {
        services.AddDbContext<GoodHamburgerDbContext>(options =>
            options.UseInMemoryDatabase("GoodHamburgerInMemory"));

        services.AddScoped<IItemRepository, ItemRepository>();
        services.AddScoped<IOrderRepository, OrderRepository>();
    }
}
