using Microsoft.AspNetCore.Mvc;
using Restaurant.Dal.Contexts;
using Serilog;
using System.Reflection;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.Console()
    .WriteTo.File("logs/logs.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();

var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Logging.AddConsole();
builder.Host.UseSerilog();

// Add services to the container.

builder.Services.AddControllers(configure =>
{
    configure.ReturnHttpNotAcceptable = true;
    configure.Filters.Add(new ProducesResponseTypeAttribute(StatusCodes.Status400BadRequest));
    configure.Filters.Add(new ProducesResponseTypeAttribute(StatusCodes.Status500InternalServerError));
    configure.Filters.Add(new ProducesResponseTypeAttribute(StatusCodes.Status406NotAcceptable));

}).AddNewtonsoftJson()
    .AddXmlSerializerFormatters()
    .AddJsonOptions(options => { options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()); });
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(setupAction =>
{
    setupAction.SwaggerDoc("CarShowroomOpenAPISpecification", new()
    {
        Title = "Restaurant API",
        Version = "v1",
        Description = "Through this API you can access to Restaurant database and make CRUD operation with entities",
        Contact = new()
        {
            Email = "salivandaniil95@gmail.com",
            Name = "Danyil Salivon"
        }
    });

    setupAction.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, $"{Assembly.Load("Restaurant.API").GetName().Name}.xml"));
    setupAction.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, $"{Assembly.Load("Restaurant.Bll").GetName().Name}.xml"));
    setupAction.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, $"{Assembly.Load("Restaurant.Dal").GetName().Name}.xml"));
});

builder.Services.AddDbContext<RestaurantContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(setupAction =>
    {
        setupAction.SwaggerEndpoint("/swagger/RestaurantOpenAPISpecification/swagger.json", "Restaurant API");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
