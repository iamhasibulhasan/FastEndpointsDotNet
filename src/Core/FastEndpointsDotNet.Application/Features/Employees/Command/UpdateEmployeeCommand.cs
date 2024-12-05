using FastEndpointsDotNet.Application.Abstraction.MediatR;
using FastEndpointsDotNet.Application.Common.Utilities;
using FastEndpointsDotNet.Application.Features.Employees.Command.Dtos;
using FastEndpointsDotNet.Application.ServiceInterfaces.Employees;

namespace FastEndpointsDotNet.Application.Features.Employees.Command;

public sealed record UpdateEmployeeCommand(UpdateEmployeeDto model) : ICommand;
public sealed class UpdateEmployeeCommandHandler : ICommandHandler<UpdateEmployeeCommand>
{
    private readonly IEmployeeCommandService _employeeCommandService;

    public UpdateEmployeeCommandHandler(IEmployeeCommandService employeeCommandService)
    {
        _employeeCommandService = employeeCommandService;
    }

    public async Task<Result> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
    {
        return await _employeeCommandService.Update(request.model, cancellationToken);
    }
}
