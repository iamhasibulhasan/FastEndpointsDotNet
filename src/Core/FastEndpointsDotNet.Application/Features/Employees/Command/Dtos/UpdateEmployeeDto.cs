namespace FastEndpointsDotNet.Application.Features.Employees.Command.Dtos;

public sealed class UpdateEmployeeDto
{
    public int Id { get; set; }
    public string EmployeeCode { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
}
