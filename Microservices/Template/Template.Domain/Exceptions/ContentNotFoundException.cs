namespace PdfGenerator.Template.Domain.Exceptions;
public class ContentNotFoundException(string fileStoragePath) : FileNotFoundException($"Unable to find the specified file in path {fileStoragePath}")
{
}
