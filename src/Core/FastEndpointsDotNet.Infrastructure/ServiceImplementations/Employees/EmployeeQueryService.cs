using FastEndpointsDotNet.Application.Common.Utilities;
using FastEndpointsDotNet.Application.RepositoryInterfaces.Employees;
using FastEndpointsDotNet.Application.ServiceInterfaces.Employees;

namespace FastEndpointsDotNet.Infrastructure.ServiceImplementations.Employees;

public sealed class EmployeeQueryService : IEmployeeQueryService
{
    private readonly IEmployeeRepository _employeeRepository;

    public EmployeeQueryService(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public async Task<Result> GetAll(CancellationToken cancellationToken)
    {
        var res = await _employeeRepository.GetAllAsync(cancellationToken);
        return Utility.GetSuccessMsg(CommonMessages.DataExists, res);
    }

    public async Task<Result> GetById(int id, CancellationToken cancellationToken)
    {
        var res = await _employeeRepository.GetByIdAsync(id, cancellationToken);
        return Utility.GetSuccessMsg(CommonMessages.DataExists, res);
    }
}
