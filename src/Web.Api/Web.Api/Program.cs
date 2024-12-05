using FastEndpoints;
using FastEndpoints.Swagger;
using FastEndpointsDotNet.Application;
using FastEndpointsDotNet.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services
    .AddApplication()
    .AddInfrastructure(configuration);


builder.Services.AddFastEndpoints().SwaggerDocument();

var app = builder.Build();




// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.UseFastEndpoints().UseSwaggerGen();
app.Run();
