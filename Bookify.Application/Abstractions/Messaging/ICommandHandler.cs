using Bookify.Domain.Abstractions;
using MediatR;
// ReSharper disable TypeParameterCanBeVariant

namespace Bookify.Application.Abstractions.Messaging;

public interface ICommandHandler<TCommand> : IRequestHandler<TCommand, Result>
    where TCommand : IСommand
{
}

public interface ICommandHandler<TCommand, TResponse> : IRequestHandler<TCommand, Result<TResponse>>
    where TCommand : IСommand<TResponse>
{
}