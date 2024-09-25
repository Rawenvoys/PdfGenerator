using PdfGenerator.MediatR.Lib.Models.Command;

namespace PdfGenerator.Client.Application.Commands.RegisterUser;
public class RegisterUserHandler : ICommandHandler<RegisterUserCommand, RegisterUserResponse>
{
    public Task<RegisterUserResponse> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}