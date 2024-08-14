using PdfTemplate.Infrastracture.Dto;
using System;
using System.Threading.Tasks;

namespace PdfTemplate.Infrastracture.IFinders
{
    internal interface IPdfTemplateFinder
    {
        Task<PdfTemplateDto> Get(Guid id);
    }
}
