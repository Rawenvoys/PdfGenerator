using PdfGenerator.MediatR.Lib.Models.Command;

namespace PdfGenerator.External.Application.Commands.SaveRequest
{
    public class SaveRequestCommandHandler : ICommandHandler<SaveRequestCommand, SaveRequestCommandResponse>
    {
        public Task<SaveRequestCommandResponse> Handle(SaveRequestCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
