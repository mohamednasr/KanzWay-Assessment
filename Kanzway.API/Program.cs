using Asp.Versioning;
using Microsoft.AspNetCore.Builder;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddApiVersioning(config =>
{
    config.ReportApiVersions = true;
    config.AssumeDefaultVersionWhenUnspecified = true;
    config.DefaultApiVersion = new ApiVersion(1, 0);
});
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Kanzway API", Description = "Kanzway API" });
    var xmlFile1 = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath1 = Path.Combine(AppContext.BaseDirectory, xmlFile1);
    c.IncludeXmlComments(xmlPath1);
});
var app = builder.Build();
app.UseSwagger();

app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Kanzway API V1");
});

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
