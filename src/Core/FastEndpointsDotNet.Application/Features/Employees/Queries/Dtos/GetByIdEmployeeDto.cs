namespace FastEndpointsDotNet.Application.Features.Employees.Queries.Dtos;

public sealed class GetByIdEmployeeDto
{
    public int Id { get; set; }
    public string EmployeeCode { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public int StatusId { get; set; }
}
