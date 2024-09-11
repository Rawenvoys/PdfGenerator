namespace PdfGenerator.Template.Domain.IServices;
internal interface IFileService
{
    internal string GetFilePath(Guid userId, Guid templateId);
}
