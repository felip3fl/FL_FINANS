using Microsoft.OpenApi.Models;
using System.ComponentModel;
using System.Xml.Linq;
using Polly;
using FL.Point.Bff.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(config =>
{
    config.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "FL Enterprise BFF",
        Description = "Esta API faz parte do futuro projeto",
        Contact = new OpenApiContact() { Name = "Felipe Lima", Email = "felip3.fl@gmail.com" },
        License = new OpenApiLicense() { Name = "MIT", Url = new Uri(uriString: "https://opensource.org/1icenses/MIT")}
    });
});

builder.Services.ResolveDependencies();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(config =>
    {
        config.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
