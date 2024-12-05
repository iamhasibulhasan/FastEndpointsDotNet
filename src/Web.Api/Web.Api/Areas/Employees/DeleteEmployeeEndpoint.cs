using FastEndpoints;
using FastEndpointsDotNet.Application.Common.Utilities;
using FastEndpointsDotNet.Application.Features.Employees.Command;
using MediatR;

namespace Web.Api.Areas.Employees;

public class DeleteEmployeeEndpoint : Endpoint<DeleteEmployeeEndpointRequest, Result>
{
    private readonly IMediator _mediator;

    public DeleteEmployeeEndpoint(IMediator mediator)
    {
        _mediator = mediator;
    }
    public override void Configure()
    {
        Delete("api/employee/delete/{id}");
        AllowAnonymous();
    }
    public override async Task HandleAsync(DeleteEmployeeEndpointRequest req, CancellationToken ct)
    {
        Result result;
        var command = new DeleteEmployeeCommand(req.Id);
        result = await _mediator.Send(command, ct);
        await SendAsync(result, result.StatusCode, cancellation: ct);
    }

}
public class DeleteEmployeeEndpointRequest
{
    [BindFrom("id")]
    public int Id { get; init; }
}
