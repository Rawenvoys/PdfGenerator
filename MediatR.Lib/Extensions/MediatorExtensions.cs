using MediatR;
using PdfGenerator.MediatR.Lib.Models.Command;
using PdfGenerator.MediatR.Lib.Models.Query;

namespace PdfGenerator.MediatR.Lib.Extensions;
public static class MediatorExtensions
{
    public static async Task<ICommandResponse> CommandAsync(this IMediator mediator, ICommand<ICommandResponse> command) 
        => await mediator.Send(command);

    public static async Task<IQueryResponse> QueryAsync(this IMediator mediator, IQuery<IQueryResponse> query)
        => await mediator.Send(query);
}