using PdfGenerator.Template.Domain.Exceptions;
using PdfGenerator.Template.Domain.IServices;
using PdfGenerator.Template.Domain.Models;
using PdfGenerator.Template.Infrastracture.IFinders;

namespace PdfGenerator.Template.Infrastracture.Services;
internal class TemplateService(ITemplateFinder _templateFinder, IContentFinder _contentFinder) : ITemplateService
{
    public async Task<TemplateModel> GetAsync(string templateName)
    {
        var templateDto = await _templateFinder.FindAsync(templateName);
        if (templateDto == null) throw new TemplateNotFoundException(templateName);

        var content = _contentFinder.Find(templateDto.FileStoragePath);
        return new TemplateModel(templateDto.Id, templateName, templateDto.FileStoragePath, content);
    }
}
