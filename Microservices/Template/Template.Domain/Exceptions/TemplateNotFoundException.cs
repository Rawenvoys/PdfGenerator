namespace PdfGenerator.Template.Domain.Exceptions;
public class TemplateNotFoundException(string templateName) : Exception($"Cannot find template with name: {templateName} in database")
{
}
