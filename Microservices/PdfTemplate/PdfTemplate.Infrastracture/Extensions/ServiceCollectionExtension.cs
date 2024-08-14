using Microsoft.Extensions.DependencyInjection;
using PdfTemplate.Domain.IServices;
using PdfTemplate.Infrastracture.Finders;
using PdfTemplate.Infrastracture.IFinders;
using PdfTemplate.Infrastracture.Services;

namespace PdfTemplate.Infrastracture.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddFinders(this IServiceCollection services)
        {
            services.AddTransient<IContentFinder, ContentFinder>();
            services.AddTransient<IPdfTemplateFinder, PdfTemplateFinder>();
        }

        public static void AddServices(this IServiceCollection services)
        {
            services.AddTransient<IPdfTemplateService, PdfTemplateService>();
        }

        public static void AddInfrastracture(this IServiceCollection services)
        {
            services.AddFinders();
            services.AddServices();
        }
    }
}
