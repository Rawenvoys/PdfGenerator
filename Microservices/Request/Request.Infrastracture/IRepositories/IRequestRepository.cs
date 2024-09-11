
namespace PdfGenerator.Request.Infrastracture.IRepositories;
internal interface IRequestRepository
{
    Task<Guid> SaveAsync(Guid templateId);
}
