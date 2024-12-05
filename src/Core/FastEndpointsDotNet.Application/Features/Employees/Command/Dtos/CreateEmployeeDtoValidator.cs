using FluentValidation;

namespace FastEndpointsDotNet.Application.Features.Employees.Command.Dtos;

public sealed class CreateEmployeeDtoValidator : AbstractValidator<CreateEmployeeDto>
{
    public CreateEmployeeDtoValidator()
    {
        RuleFor(x => x.EmployeeCode).NotEmpty().WithMessage("{PropertyName} is required!");
        RuleFor(x => x.FirstName).NotEmpty().WithMessage("{PropertyName} is required!");
        RuleFor(x => x.LastName).NotEmpty().WithMessage("{PropertyName} is required!");
        RuleFor(x => x.DateOfBirth).NotEmpty().WithMessage("{PropertyName} is required!");
        RuleFor(x => x.Phone).NotEmpty().WithMessage("{PropertyName} is required!");
        RuleFor(x => x.Email).NotEmpty().WithMessage("{PropertyName} is required!");
    }
}
