using PdfGenerator.MediatR.Lib.Models.Command;

namespace PdfFile.Application.Commands.Generate;
public class GenerateCommandResponse(string name, byte[] content) : ICommandResponse
{
    public string Name { get; set; } = name;
    public byte[] Content { get; set; } = content;
}
