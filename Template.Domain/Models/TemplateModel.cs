namespace PdfGenerator.Template.Domain.Models;
public class TemplateModel(Guid id, string name, string fileStoragePath, string content)
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public ContentModel Content { get; set; } = new(fileStoragePath, content);
}
