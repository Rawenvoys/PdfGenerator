namespace PdfGenerator.Template.Domain.Models;
public class ContentModel(string fileStoragePath, string content)
{
    public string FileStoragePath { get; set; } = fileStoragePath;
    public string Content { get; set; } = content;
}
