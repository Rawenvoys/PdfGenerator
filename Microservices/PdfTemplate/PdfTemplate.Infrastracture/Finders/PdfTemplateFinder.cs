using System;
using System.Threading.Tasks;
using PdfTemplate.Infrastracture.Dto;
using PdfTemplate.Infrastracture.IFinders;

namespace PdfTemplate.Infrastracture.Finders
{
    internal class PdfTemplateFinder : IPdfTemplateFinder
    {
        public Task<PdfTemplateDto> Get(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
