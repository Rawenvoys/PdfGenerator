using PdfGenerator.Template.Domain.Models;

namespace PdfGenerator.Template.Domain.IServices;
public interface ITemplateService
{
    public Task<TemplateModel> GetAsync(string templateName);
}
