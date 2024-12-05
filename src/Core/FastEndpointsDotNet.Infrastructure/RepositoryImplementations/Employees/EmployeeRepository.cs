using FastEndpointsDotNet.Application.RepositoryInterfaces.Employees;
using FastEndpointsDotNet.Domain.Entities.Employees;
using FastEndpointsDotNet.Infrastructure.Persistence;
using FastEndpointsDotNet.Infrastructure.RepositoryImplementations.Common;

namespace FastEndpointsDotNet.Infrastructure.RepositoryImplementations.Employees;

public sealed class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
{
    private readonly FEDbContext _fEDbContext;

    public EmployeeRepository(FEDbContext fEDbContext) : base(fEDbContext)
    {
        _fEDbContext = fEDbContext;
    }
}
