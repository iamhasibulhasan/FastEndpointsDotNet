using FastEndpointsDotNet.Application.Common.Utilities;
using FastEndpointsDotNet.Application.Features.Employees.Command.Dtos;
using FastEndpointsDotNet.Application.RepositoryInterfaces.Employees;
using FastEndpointsDotNet.Application.ServiceInterfaces.Employees;
using FastEndpointsDotNet.Domain.Entities.Employees;

namespace FastEndpointsDotNet.Infrastructure.ServiceImplementations.Employees;

public sealed class EmployeeCommandService : IEmployeeCommandService
{
    private readonly IEmployeeRepository _employeeRepository;

    public EmployeeCommandService(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public async Task<Result> Create(CreateEmployeeDto model, CancellationToken cancellationToken, bool savechanges = true)
    {
        Employee employee = Employee.Create(model.EmployeeCode, model.FirstName, model.LastName, model.DateOfBirth, model.Email, model.Phone);
        await _employeeRepository.CreateAsync(employee, savechanges, cancellationToken);

        return Utility.GetSuccessMsg(CommonMessages.SavedSuccessfully);
    }
    public async Task<Result> Delete(int id, CancellationToken cancellationToken, bool savechanges = true)
    {
        var exists = await _employeeRepository.GetByIdAsync(id, cancellationToken);
        if (exists is null)
        {
            return Utility.GetNoDataFoundMsg(CommonMessages.NoDataFound);
        }
        await _employeeRepository.DeleteAsync(id, savechanges, cancellationToken);
        return Utility.GetSuccessMsg(CommonMessages.DeletedSuccessfully);
    }
    public async Task<Result> Update(UpdateEmployeeDto model, CancellationToken cancellationToken, bool savechanges = true)
    {
        var exists = await _employeeRepository.GetByIdAsync(model.Id, cancellationToken);
        if (exists is null)
        {
            return Utility.GetNoDataFoundMsg(CommonMessages.NoDataFound);
        }
        exists.Update(model.EmployeeCode, model.FirstName, model.LastName, model.DateOfBirth, model.Email, model.Phone);
        await _employeeRepository.UpdateAsync(exists, savechanges, cancellationToken);
        return Utility.GetSuccessMsg(CommonMessages.UpdatedSuccessfully);
    }
}
