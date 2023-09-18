using _02_Mapster;
using _02_Mapster.Mapster;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Mapster
builder.Services.RegisterMapsterConfiguration();
    
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/new-person", () =>
{
    var person = MappingFunctions.MapPersonToNewDto();
    return Results.Ok(person);
});

app.MapGet("/existing-person", () =>
{
    var person = MappingFunctions.MapPersonToExistingDto();
    return Results.Ok(person);
});

app.MapGet("/people", () =>
{
    var people = MappingFunctions.MapPersonQueryableToDtoQueryable();
    return Results.Ok(people);
});

app.MapGet("/short-info-person", () =>
{
    var person = MappingFunctions.CustomMapPersonToShortInfoDto();
    return Results.Ok(person);
});

app.MapGet("/dto-to-entity", () =>
{
    var person = MappingFunctions.MapPersonDtoToPersonEntity();
    return Results.Ok(person);
});

app.Run();