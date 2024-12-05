using FastEndpointsDotNet.Application.Abstraction.MediatR;
using FastEndpointsDotNet.Application.Common.Utilities;
using FastEndpointsDotNet.Application.ServiceInterfaces.Employees;

namespace FastEndpointsDotNet.Application.Features.Employees.Queries;

public sealed record GetAllEmployeeQuery() : IQuery<Result>;
public sealed class GetAllEmployeeQueryHandler : IQueryHandler<GetAllEmployeeQuery, Result>
{
    private readonly IEmployeeQueryService _employeeQueryService;

    public GetAllEmployeeQueryHandler(IEmployeeQueryService employeeQueryService)
    {
        _employeeQueryService = employeeQueryService;
    }

    public async Task<Result> Handle(GetAllEmployeeQuery request, CancellationToken cancellationToken)
    {
        return await _employeeQueryService.GetAll(cancellationToken);
    }
}
