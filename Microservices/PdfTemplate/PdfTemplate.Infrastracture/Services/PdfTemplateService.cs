using PdfTemplate.Domain.IServices;
using PdfTemplate.Domain.Models;
using PdfTemplate.Infrastracture.Exceptions;
using PdfTemplate.Infrastracture.IFinders;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PdfTemplate.Infrastracture.Services
{
    internal class PdfTemplateService : IPdfTemplateService
    {
        private readonly IPdfTemplateFinder _pdfTemplateFinder;
        private readonly IContentFinder _contentFinder;

        public PdfTemplateService(IPdfTemplateFinder pdfTemplateFinder, IContentFinder fileFinder)
        {
            _pdfTemplateFinder = pdfTemplateFinder;
            _contentFinder = fileFinder;
        }

        public async Task<PdfTemplateModel> Get(Guid id)
        {
            var pdfTemplateDto = await _pdfTemplateFinder.Get(id);
            if (pdfTemplateDto is null)
                throw new PdfTemplateNotFoundException(id); 

            var content = _contentFinder.Get(pdfTemplateDto.FilePath);

            return new PdfTemplateModel(pdfTemplateDto.Id, pdfTemplateDto.Name, content);
        }
    }
}
