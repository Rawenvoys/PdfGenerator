using PdfGenerator.MediatR.Lib.Models.Command;

namespace PdfFile.Application.Commands.Generate;
public class GenerateCommand(string html, string fileName) : ICommand<GenerateCommandResponse>
{
    public string Html { get; set; } = html;
    public string FileName { get; set; } = fileName;
}
