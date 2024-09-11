using PdfGenerator.Template.Infrastracture.Dtos;
using PdfGenerator.Template.Infrastracture.IFinders;
using Dapper.Lib.Extensions;
using PdfGenerator.Template.Infrastracture.StoredProcedure;

namespace PdfGenerator.Template.Infrastracture.Finders;
internal class TemplateFinder(PdfGeneratorDbContext dbContext) : ITemplateFinder
{
    private readonly PdfGeneratorDbContext _dbContext = dbContext;

    public async Task<TemplateDto> FindAsync(string templateName)
    {
        TemplateFind templateFind = new TemplateFind(templateName);
        return await _dbContext.ExecuteAsync<TemplateDto>(templateFind);
    }
}
