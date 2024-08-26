using PdfGenerator.Request.Domain.Models;

namespace PdfGenerator.Request.Domain.IServices;
public interface IRequestService
{
    public Task<RequestModel> Save(string templateName, string xmlData);
}
