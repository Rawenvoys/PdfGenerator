using MediatR;
using System;

namespace PdfTemplate.Application.Queries.GetPdfTemplate
{
    public class GetPdfTemplateQuery : IRequest<GetPdfTemplateResponse>
    {
        public Guid Id { get; set; }

        public GetPdfTemplateQuery(Guid id)
        {
            Id = id;
        }
    }
}
