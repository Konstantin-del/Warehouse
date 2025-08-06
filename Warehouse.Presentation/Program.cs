
using Warehouse.Application.Configurations;
using Warehouse.Application.Mappings;
using Warehouse.Persistence;
using Warehouse.Presentation.Mappings;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(
        typeof(ClientDtoMapperProfile),
        typeof(ClientMapperProfile)
    );

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var configuration = builder.Configuration;
builder.Services.ConfigurePersistence(configuration);
builder.Services.ConfigureApplication(configuration);



//builder.Services.AddScoped<IResourceService, ResourceService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
