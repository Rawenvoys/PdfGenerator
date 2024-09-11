namespace PdfGenerator.PdfFile.Domain.Models;
public class PdfFileModel(string name, byte[] content)
{
    public string Name { get; set; } = name;
    public byte[] Content { get; set; } = content;
}
