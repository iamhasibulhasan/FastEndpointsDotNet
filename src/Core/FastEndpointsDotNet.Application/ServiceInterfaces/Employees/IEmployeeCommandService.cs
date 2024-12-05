using FastEndpointsDotNet.Application.Common.Utilities;
using FastEndpointsDotNet.Application.Features.Employees.Command.Dtos;

namespace FastEndpointsDotNet.Application.ServiceInterfaces.Employees;

public interface IEmployeeCommandService
{
    Task<Result> Create(CreateEmployeeDto model, CancellationToken cancellationToken, bool savechanges = true);
    Task<Result> Update(UpdateEmployeeDto model, CancellationToken cancellationToken, bool savechanges = true);
    Task<Result> Delete(int id, CancellationToken cancellationToken, bool savechanges = true);
}
