using Microsoft.Extensions.DependencyInjection;
using Dapper.Lib.Extensions;
using PdfGenerator.Template.Infrastracture.IFinders;
using PdfGenerator.Template.Infrastracture.Finders;
using PdfGenerator.Template.Domain.IServices;
using PdfGenerator.Template.Infrastracture.Services;

namespace PdfGenerator.Template.Infrastracture.Extensions;
public static class ServiceCollectionExtensions
{
    private static void AddDbContext(this IServiceCollection services) 
        => services.AddDbContext<PdfGeneratorDbContext>();

    private static void AddFinders(this IServiceCollection services)
    {
        services.AddScoped<ITemplateFinder, TemplateFinder>();
        services.AddScoped<IContentFinder, ContentFinder>();
    }

    private static void AddRepositories(this IServiceCollection services)
    {

    }

    private static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<ITemplateService, TemplateService>();
        services.AddScoped<IFileService, FileService>();
    }

    public static void AddInfrastracture(this IServiceCollection services)
    {
        services.AddDbContext();
        services.AddFinders();
        services.AddRepositories();
        services.AddServices();
    }
}
