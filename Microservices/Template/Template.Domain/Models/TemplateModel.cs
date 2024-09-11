namespace PdfGenerator.Template.Domain.Models;
public class TemplateModel(Guid id, string name, string fileStoragePath, string content)
{
    public Guid Id { get; set; } = id;
    public string Name { get; set; } = name;
    public ContentModel Content { get; set; } = new(fileStoragePath, content);
}
