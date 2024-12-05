using FastEndpointsDotNet.Domain.Common;

namespace FastEndpointsDotNet.Domain.Entities.Employees;

public sealed class Employee : BaseEntity
{
    public string EmployeeCode { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public DateTime DateOfBirth { get; private set; }
    public string Email { get; private set; }
    public string Phone { get; private set; }

    public static Employee Create(string employeeCode, string firstName, string lastName, DateTime dateOfBirth, string email, string phone)
    {
        Employee employee = new Employee();
        employee.EmployeeCode = employeeCode;
        employee.FirstName = firstName;
        employee.LastName = lastName;
        employee.DateOfBirth = dateOfBirth;
        employee.Email = email;
        employee.Phone = phone;
        return employee;
    }

    public void Update(string employeeCode, string firstName, string lastName, DateTime dateOfBirth, string email, string phone)
    {
        EmployeeCode = employeeCode;
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        Email = email;
        Phone = phone;
    }
}

