using MediatR;
namespace PdfGenerator.MediatR.Lib.Models.Command;
public interface ICommand<out TCommandResponse> : IRequest<TCommandResponse>
    where TCommandResponse : ICommandResponse
{ }

public interface ICommand : IRequest 
{ }
