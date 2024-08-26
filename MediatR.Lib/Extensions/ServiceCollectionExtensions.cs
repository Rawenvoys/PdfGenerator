using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace PdfGenerator.MediatR.Lib.Extensions;
public static class ServiceCollectionExtensions
{
    public static void AddMediatR(this IServiceCollection services) 
        => services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
}
