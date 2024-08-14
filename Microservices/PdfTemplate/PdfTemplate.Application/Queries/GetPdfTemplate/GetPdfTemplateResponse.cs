using System;
using System.Collections.Generic;
using System.Text;

namespace PdfTemplate.Application.Queries.GetPdfTemplate
{
    public class GetPdfTemplateResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }

        public GetPdfTemplateResponse(Guid id, string name, string content)
        {
            Id = id;
            Name = name;
            Content = content;
        }
    }
}
