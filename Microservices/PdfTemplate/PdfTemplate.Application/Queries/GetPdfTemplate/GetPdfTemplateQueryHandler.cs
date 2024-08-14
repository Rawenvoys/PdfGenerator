using MediatR;
using PdfTemplate.Domain.IServices;
using System.Threading;
using System.Threading.Tasks;

namespace PdfTemplate.Application.Queries.GetPdfTemplate
{
    public class GetPdfTemplateQueryHandler : IRequestHandler<GetPdfTemplateQuery, GetPdfTemplateResponse>
    {
        private readonly IPdfTemplateService _pdfTemplateService;
        public GetPdfTemplateQueryHandler(IPdfTemplateService pdfTemplateService)
            => _pdfTemplateService = pdfTemplateService;


        public async Task<GetPdfTemplateResponse> Handle(GetPdfTemplateQuery request, CancellationToken cancellationToken)
        {
            var pdfTemplateModel = await _pdfTemplateService.Get(request.Id);
            return new GetPdfTemplateResponse(pdfTemplateModel.Id, pdfTemplateModel.Name, pdfTemplateModel.Content);
        }
    }
}
