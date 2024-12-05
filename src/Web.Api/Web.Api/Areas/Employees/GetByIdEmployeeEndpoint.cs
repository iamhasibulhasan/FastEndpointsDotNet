using FastEndpoints;
using FastEndpointsDotNet.Application.Common.Utilities;
using FastEndpointsDotNet.Application.Features.Employees.Queries;
using MediatR;

namespace Web.Api.Areas.Employees;

public class GetByIdEmployeeEndpoint : Endpoint<GetByIdEmployeeEndpointRequest, Result>
{
    private readonly IMediator _mediator;

    public GetByIdEmployeeEndpoint(IMediator mediator)
    {
        _mediator = mediator;
    }

    public override void Configure()
    {
        Get("api/employee/getbyid/{id}");
        AllowAnonymous();
    }
    public override async Task HandleAsync(GetByIdEmployeeEndpointRequest req, CancellationToken ct)
    {
        Result result;
        var command = new GetByIdEmployeeQuery(req.Id);
        result = await _mediator.Send(command, ct);
        await SendAsync(result, result.StatusCode, cancellation: ct);
    }
}
public class GetByIdEmployeeEndpointRequest
{
    [BindFrom("id")]
    public int Id { get; init; }
}
