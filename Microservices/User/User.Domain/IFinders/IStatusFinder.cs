using PdfGenerator.User.Domain.Models;

namespace PdfGenerator.User.Domain.IFinders;
internal interface IStatusFinder
{
    Task<StatusModel> GetCurrentStatusAsync(Guid userId);
}
