using FastEndpointsDotNet.Application.Common.Utilities;

namespace FastEndpointsDotNet.Application.ServiceInterfaces.Employees;

public interface IEmployeeQueryService
{
    Task<Result> GetAll(CancellationToken cancellationToken);
    Task<Result> GetById(int id, CancellationToken cancellationToken);
}
