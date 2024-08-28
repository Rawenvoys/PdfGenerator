using Microsoft.AspNetCore.Hosting;
using PdfGenerator.Template.Domain.IServices;

namespace PdfGenerator.Template.Infrastracture.Services;
//ToDo: public for test project. think about access member per project
public class FileService(IWebHostEnvironment _webHostEnvironment) : IFileService
{
    public string GetFilePath(Guid userId, Guid templateId) 
        => Path.Combine(_webHostEnvironment.WebRootPath, userId.ToString().ToUpper(), templateId.ToString().ToUpper());
}
