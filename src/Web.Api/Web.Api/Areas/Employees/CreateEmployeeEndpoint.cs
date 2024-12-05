using FastEndpoints;
using FastEndpointsDotNet.Application.Common.Utilities;
using FastEndpointsDotNet.Application.Features.Employees.Command;
using FastEndpointsDotNet.Application.Features.Employees.Command.Dtos;
using MediatR;

namespace Web.Api.Areas.Employees;

public class CreateEmployeeEndpoint : Endpoint<CreateEmployeeDto, Result>
{
    private readonly IMediator _mediator;

    public CreateEmployeeEndpoint(IMediator mediator)
    {
        _mediator = mediator;
    }

    public override void Configure()
    {
        Post("api/employee/create");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CreateEmployeeDto req, CancellationToken ct)
    {
        var validationResult = new CreateEmployeeDtoValidator().Validate(req);
        Result result;
        if (!validationResult.IsValid)
        {
            result = Utility.GetValidationFailedMsg(FluentValidationHelper.GetErrorMessage(validationResult.Errors));
            ThrowIfAnyErrors(statusCode: result.StatusCode);
        }
        else
        {
            var command = new CreateEmployeeCommand(req);
            result = await _mediator.Send(command, ct);
        }
        await SendAsync(result, result.StatusCode, cancellation: ct);

    }
}

