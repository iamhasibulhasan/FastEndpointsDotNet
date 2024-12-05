using FastEndpointsDotNet.Application.Abstraction.MediatR;
using FastEndpointsDotNet.Application.Common.Utilities;
using FastEndpointsDotNet.Application.ServiceInterfaces.Employees;

namespace FastEndpointsDotNet.Application.Features.Employees.Command;

public sealed record DeleteEmployeeCommand(int id) : ICommand;
public sealed class DeleteEmployeeCommandHandler : ICommandHandler<DeleteEmployeeCommand>
{
    private readonly IEmployeeCommandService _employeeCommandService;

    public DeleteEmployeeCommandHandler(IEmployeeCommandService employeeCommandService)
    {
        _employeeCommandService = employeeCommandService;
    }

    public async Task<Result> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
    {
        return await _employeeCommandService.Delete(request.id, cancellationToken);
    }
}
