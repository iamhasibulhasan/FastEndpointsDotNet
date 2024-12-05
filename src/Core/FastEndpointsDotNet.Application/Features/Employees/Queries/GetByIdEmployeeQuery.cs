using FastEndpointsDotNet.Application.Abstraction.MediatR;
using FastEndpointsDotNet.Application.Common.Utilities;
using FastEndpointsDotNet.Application.ServiceInterfaces.Employees;

namespace FastEndpointsDotNet.Application.Features.Employees.Queries;

public sealed record GetByIdEmployeeQuery(int id) : IQuery<Result>;
public sealed class GetByIdEmployeeQueryHandler : IQueryHandler<GetByIdEmployeeQuery, Result>
{
    private readonly IEmployeeQueryService _employeeQueryService;

    public GetByIdEmployeeQueryHandler(IEmployeeQueryService employeeQueryService)
    {
        _employeeQueryService = employeeQueryService;
    }

    public async Task<Result> Handle(GetByIdEmployeeQuery request, CancellationToken cancellationToken)
    {
        return await _employeeQueryService.GetById(request.id, cancellationToken);
    }
}
