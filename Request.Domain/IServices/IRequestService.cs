using PdfGenerator.Request.Domain.Models;

namespace PdfGenerator.Request.Domain.IServices;
public interface IRequestService
{
    public Task<Guid> SaveAsync(string templateName, string json);
}
