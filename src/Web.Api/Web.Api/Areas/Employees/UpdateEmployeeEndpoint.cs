﻿using FastEndpoints;
using FastEndpointsDotNet.Application.Common.Utilities;
using FastEndpointsDotNet.Application.Features.Employees.Command;
using FastEndpointsDotNet.Application.Features.Employees.Command.Dtos;
using MediatR;

namespace Web.Api.Areas.Employees;

public class UpdateEmployeeEndpoint : Endpoint<UpdateEmployeeDto, Result>
{
    private readonly IMediator _mediator;

    public UpdateEmployeeEndpoint(IMediator mediator)
    {
        _mediator = mediator;
    }
    public override void Configure()
    {
        Put("api/employee/");
        AllowAnonymous();
    }

    public override async Task HandleAsync(UpdateEmployeeDto req, CancellationToken ct)
    {
        var validationResult = new UpdateEmployeeDtoValidator().Validate(req);
        Result result;
        if (!validationResult.IsValid)
        {
            result = Utility.GetValidationFailedMsg(FluentValidationHelper.GetErrorMessage(validationResult.Errors));
            ThrowIfAnyErrors(statusCode: result.StatusCode);
        }
        else
        {
            var command = new UpdateEmployeeCommand(req);
            result = await _mediator.Send(command, ct);
        }
        await SendAsync(result, result.StatusCode, cancellation: ct);

    }
}
