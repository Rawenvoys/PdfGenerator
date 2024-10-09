using PdfGenerator.User.Domain.Enums;

namespace PdfGenerator.User.Domain.IRepositories;
internal interface IStatusRepository
{
    Task SetAsync(Guid userId, Status status);
}
