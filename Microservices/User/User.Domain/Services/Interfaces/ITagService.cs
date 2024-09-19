using PdfGenerator.User.Domain.Models;

namespace PdfGenerator.User.Domain.Services.Interfaces;
public interface ITagService
{
    public Task<TagModel> GenerateUniqueAsync();
}
