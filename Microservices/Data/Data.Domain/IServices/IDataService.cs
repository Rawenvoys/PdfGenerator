using PdfGenerator.Data.Domain.Models;

namespace PdfGenerator.Data.Domain.IServices;
public interface IDataService
{
    public Task SaveAsync(Guid requestId, DataModel dataModel);
}
