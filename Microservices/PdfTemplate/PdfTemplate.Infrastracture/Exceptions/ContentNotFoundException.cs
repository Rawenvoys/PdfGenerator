using System;
using System.Collections.Generic;
using System.Text;

namespace PdfTemplate.Infrastracture.Exceptions
{
    internal class ContentNotFoundException : Exception
    {
        public ContentNotFoundException(string filePath) : base($"Cannot find content in path: {filePath}")
        {

        }
    }
}
