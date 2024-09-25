using PdfGenerator.MediatR.Lib.Models.Command;

namespace PdfGenerator.Client.Application.Commands.RegisterUser;
public class RegisterUserCommand(string email, string password) : ICommand<RegisterUserResponse>
{
    public string Email { get; set; } = email;
    public string Password { get; set; } = password;
}
