using PdfGenerator.Html.Domain.Models;
using PdfGenerator.PdfFile.Domain.Models;

namespace PdfGenerator.PdfFile.Domain.IServices;
public interface IPdfFileService
{
    //ToDo: Czy async?
    public PdfFileModel Generate(HtmlModel html, string fileName);
}
