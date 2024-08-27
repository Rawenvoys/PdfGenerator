using PdfGenerator.Request.Domain.Models;

namespace PdfGenerator.Request.Domain.IServices;
public interface IRequestService
{
    public Task<Guid> Save(string templateName, string xmlData);
}
