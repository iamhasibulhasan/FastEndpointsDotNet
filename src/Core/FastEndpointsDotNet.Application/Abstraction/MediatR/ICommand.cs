using FastEndpointsDotNet.Application.Common.Utilities;
using MediatR;

namespace FastEndpointsDotNet.Application.Abstraction.MediatR;

public interface ICommand : IRequest<Result>
{
}

public interface ICommand<TResponse> : IRequest<Result<TResponse>>
{
}
