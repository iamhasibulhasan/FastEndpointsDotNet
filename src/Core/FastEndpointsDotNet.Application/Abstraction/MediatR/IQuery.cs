using FastEndpointsDotNet.Application.Common.Utilities;
using MediatR;

namespace FastEndpointsDotNet.Application.Abstraction.MediatR;


public interface IQueryResult<TResponse> : IRequest<Result<TResponse>>
{
}

public interface IQuery<out TResponse> : IRequest<TResponse>
{
}
