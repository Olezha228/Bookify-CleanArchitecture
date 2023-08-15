using Bookify.Domain.Abstractions;
using MediatR;
// ReSharper disable TypeParameterCanBeVariant

namespace Bookify.Application.Abstractions.Messaging;

public interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, Result<TResponse>>
    where TQuery : IQuery<TResponse>
{
}
