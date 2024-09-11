using Dapper.Lib.Models.DbContext;
using Microsoft.Extensions.DependencyInjection;

namespace Dapper.Lib.Extensions;
public static class ServiceCollectionExtensions
{
    public static void AddDbContext<TDbContext>(this IServiceCollection services)
        where TDbContext : ADbContext
        => services.AddTransient<TDbContext>();
}
