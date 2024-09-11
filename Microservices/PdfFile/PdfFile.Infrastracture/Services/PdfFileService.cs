using PdfGenerator.Html.Domain.Models;
using PdfGenerator.PdfFile.Domain.IServices;
using PdfGenerator.PdfFile.Domain.Models;
using SelectPdf;
using System.Web;

namespace PdfGenerator.PdfFile.Infrastracture.Services;
//ToDo: Zastanowic sie czy wszystko w warstwie infrastracture nie powinno byc internal
internal class PdfFileService : IPdfFileService
{
    public PdfFileModel Generate(HtmlModel html, string fileName)
    {
        var pdfDocument = new HtmlToPdf().ConvertHtmlString(html.Html);
        var pdfContent = pdfDocument.Save();
        return new PdfFileModel(fileName, pdfContent);
    }
}
