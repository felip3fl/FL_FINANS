using FL.Point.Api.Configuration;
using FL.Point.Data.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApiConfiguration();
builder.Services.AddSwaggerConfiguration();
builder.Services.ResolveDependencies();
var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<DataBaseContext>();

    context.Database.EnsureCreated();
}

    // Configure the HTTP request pipeline.
app.UseSwaggerConfiguration();
app.UseApiConfiguration(app.Environment);
app.MapControllers();

app.Run();
