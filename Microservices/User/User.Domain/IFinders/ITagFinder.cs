using PdfGenerator.User.Domain.Models;

namespace PdfGenerator.User.Domain.IFinders;
public interface ITagFinder
{
    public Task<bool> UniqueAsync(TagModel tag);
}
