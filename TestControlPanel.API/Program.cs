using TestControlPanel.API.Extensions;
using TestControlPanel.IoC;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddSwaggerExtension();
builder.Services.AddCorsExtension();

DependencyContainer.RegisterServices(builder.Services);
DependencyContainer.AddAutoMapper(builder.Services);
AddServiceProvider.AddDatabaseContext(builder.Services, builder.Configuration);

var app = builder.Build();

app.UseErrorHandlingMiddleware();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwaggerExtension();
    app.UseHttpLogging();
}

app.UseCorsExtension();
app.UseAuthorization();
app.MapControllers();
await app.RunAsync();