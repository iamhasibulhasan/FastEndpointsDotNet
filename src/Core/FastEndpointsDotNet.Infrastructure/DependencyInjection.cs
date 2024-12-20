﻿using FastEndpointsDotNet.Infrastructure.Persistence;
using FastEndpointsDotNet.Infrastructure.RepositoryImplementations.Employees;
using FastEndpointsDotNet.Infrastructure.ServiceImplementations.Employees;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetCore.AutoRegisterDi;
using System.Reflection;

namespace FastEndpointsDotNet.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<FEDbContext>(options =>
        options.UseNpgsql(configuration.GetConnectionString("DbConnection"), b => b.MigrationsAssembly(typeof(FEDbContext).Assembly.FullName)));

        Dependency(services);
        return services;
    }
    public static void Dependency(this IServiceCollection services)
    {
        var assembliesToScan = new[]
        {
            Assembly.GetExecutingAssembly(),
            Assembly.GetAssembly(typeof(EmployeeQueryService)),
            Assembly.GetAssembly(typeof(EmployeeRepository))
        };
        services.RegisterAssemblyPublicNonGenericClasses(assembliesToScan)
            .Where(c => c.Name.EndsWith("Service") || c.Name.EndsWith("Repository"))
            .AsPublicImplementedInterfaces();
    }
}

