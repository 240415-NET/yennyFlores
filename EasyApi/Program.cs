
using EasyApi.Services;


var builder = WebApplication.CreateBuilder(args);

//Moved this Line Up
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Added THIS LINE change
builder.Services.AddScoped<IServiceCatalogSearch, ServiceCatalogSearch>(); // This adds our UserService, that our UserController then asks for

//Moved this Line down
builder.Services.AddControllers();

//Moved this Line Down
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
