using System;

namespace PdfTemplate.Infrastracture.Dto
{
    internal class PdfTemplateDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string FilePath { get; set; }
    }
}
