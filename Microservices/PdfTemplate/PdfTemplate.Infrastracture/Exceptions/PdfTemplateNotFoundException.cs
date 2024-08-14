using System;
using System.Collections.Generic;
using System.Text;

namespace PdfTemplate.Infrastracture.Exceptions
{
    internal class PdfTemplateNotFoundException : Exception
    {
        public PdfTemplateNotFoundException(Guid id) : base($"Cannot find PdfTemplate with Id: {id}")
        {

        }
    }
}
