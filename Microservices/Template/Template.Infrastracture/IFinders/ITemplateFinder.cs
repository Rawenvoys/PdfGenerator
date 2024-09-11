using PdfGenerator.Template.Infrastracture.Dtos;

namespace PdfGenerator.Template.Infrastracture.IFinders;
internal interface ITemplateFinder
{
    public Task<TemplateDto> FindAsync(string templateName);
}
