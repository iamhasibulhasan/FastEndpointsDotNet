using FastEndpoints;
using FastEndpointsDotNet.Application.Common.Utilities;
using FastEndpointsDotNet.Application.Features.Employees.Queries;
using MediatR;

namespace Web.Api.Areas.Employees;

public class GetAllEmployeeEndpoint : EndpointWithoutRequest
{
    private readonly IMediator _mediator;

    public GetAllEmployeeEndpoint(IMediator mediator)
    {
        _mediator = mediator;
    }

    public override void Configure()
    {
        Get("api/employee/getall");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        Result result;
        var command = new GetAllEmployeeQuery();
        result = await _mediator.Send(command, ct);
        await SendAsync(result, result.StatusCode, cancellation: ct);
    }
}
