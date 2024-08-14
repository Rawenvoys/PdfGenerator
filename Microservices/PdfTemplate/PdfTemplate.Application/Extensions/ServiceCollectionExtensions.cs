using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using PdfTemplate.Infrastracture.Extensions;

namespace PdfTemplate.Application.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddPdfTemplate(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddInfrastracture();
        }
    }
}
