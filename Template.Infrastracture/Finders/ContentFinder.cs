using PdfGenerator.Template.Domain.Exceptions;
using PdfGenerator.Template.Infrastracture.IFinders;

namespace PdfGenerator.Template.Infrastracture.Finders;
internal class ContentFinder : IContentFinder
{
    public string Find(string fileStoragePath)
    {
        if (!File.Exists(fileStoragePath)) throw new ContentNotFoundException(fileStoragePath);
        return File.ReadAllText(fileStoragePath);
    }
}
