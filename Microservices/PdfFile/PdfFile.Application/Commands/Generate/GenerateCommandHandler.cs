using PdfGenerator.MediatR.Lib.Models.Command;

namespace PdfFile.Application.Commands.Generate;
public class GenerateCommandHandler : ICommandHandler<GenerateCommand, GenerateCommandResponse>
{
    public async Task<GenerateCommandResponse> Handle(GenerateCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
