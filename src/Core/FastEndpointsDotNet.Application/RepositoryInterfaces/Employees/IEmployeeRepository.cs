using FastEndpointsDotNet.Application.RepositoryInterfaces.Common;
using FastEndpointsDotNet.Domain.Entities.Employees;

namespace FastEndpointsDotNet.Application.RepositoryInterfaces.Employees;

public interface IEmployeeRepository : IGenericRepository<Employee>
{
}
