using PdfGenerator.MediatR.Lib.Models.Command;

namespace PdfGenerator.Client.Application.Commands.RegisterUser;
public class RegisterUserResponse : ICommandResponse
{
    public bool Success { get; set; }
    public Guid UserId { get; set; }
    public List<string> Errors { get; set; }
}
