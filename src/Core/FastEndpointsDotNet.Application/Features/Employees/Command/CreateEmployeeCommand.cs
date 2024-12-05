
using FastEndpointsDotNet.Application.Abstraction.MediatR;
using FastEndpointsDotNet.Application.Common.Utilities;
using FastEndpointsDotNet.Application.Features.Employees.Command.Dtos;
using FastEndpointsDotNet.Application.ServiceInterfaces.Employees;

namespace FastEndpointsDotNet.Application.Features.Employees.Command;

public sealed record CreateEmployeeCommand(CreateEmployeeDto model) : ICommand;
public sealed class CreateEmployeeCommandHandler : ICommandHandler<CreateEmployeeCommand>
{
    private readonly IEmployeeCommandService _employeeCommandService;

    public CreateEmployeeCommandHandler(IEmployeeCommandService employeeCommandService)
    {
        _employeeCommandService = employeeCommandService;
    }

    public async Task<Result> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
    {
        return await _employeeCommandService.Create(request.model, cancellationToken);
    }
}
