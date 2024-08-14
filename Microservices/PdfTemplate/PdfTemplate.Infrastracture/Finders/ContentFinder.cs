using System.IO;
using System.Threading.Tasks;
using PdfTemplate.Infrastracture.IFinders;

namespace PdfTemplate.Infrastracture.Finders
{
    internal class ContentFinder : IContentFinder
    {
        public string Get(string path) 
            => File.ReadAllText(path);
    }
}
