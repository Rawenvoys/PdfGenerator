using PdfGenerator.Template.Infrastracture.IFinders;

namespace PdfGenerator.Template.Infrastracture.Finders;
internal class ContentFinder : IContentFinder
{
    public string Find(string fileStoragePath) 
        => File.ReadAllText(fileStoragePath);
}
