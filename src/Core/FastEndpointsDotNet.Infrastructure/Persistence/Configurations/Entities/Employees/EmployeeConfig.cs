using FastEndpointsDotNet.Domain.Entities.Employees;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FastEndpointsDotNet.Infrastructure.Persistence.Configurations.Entities.Employees;

public sealed class EmployeeConfig : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.ToTable("Employees", "public");
        builder.HasKey(k => k.Id);

        builder.Property(k => k.EmployeeCode)
            .IsRequired()
            .HasMaxLength(200);
        builder.Property(k => k.FirstName)
            .IsRequired()
            .HasMaxLength(200);
        builder.Property(k => k.LastName)
            .HasMaxLength(200);
        builder.Property(k => k.Email)
            .IsRequired();
        builder.Property(k => k.Phone)
            .IsRequired();
    }
}
