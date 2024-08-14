using System;
using System.Collections.Generic;
using System.Text;

namespace PdfTemplate.Domain.Models
{
    public class PdfTemplateModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }

        public PdfTemplateModel(Guid id, string name, string content)
        {
            Id = id;
            Name = name;
            Content = content;
        }
    }
}
