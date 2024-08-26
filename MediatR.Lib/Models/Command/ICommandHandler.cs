﻿using MediatR;

namespace PdfGenerator.MediatR.Lib.Models.Command;
public interface ICommandHandler<in TCommand, TCommandResponse>
    : IRequestHandler<TCommand, TCommandResponse>
    where TCommand : ICommand<TCommandResponse>
    where TCommandResponse : ICommandResponse
{ }

public interface ICommandHandler<in TCommand> 
    : IRequestHandler<TCommand>
    where TCommand : ICommand
{ }