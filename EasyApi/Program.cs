
using EasyApi.Services;
//using TrackMyStuff.API.Data;
//using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddScoped<IServiceCatalogSearch, ServiceCatalogSearch>(); // This adds our UserService, that our UserController then asks for
// Configure the HTTP request pipeline.

//string connectionString = File.ReadAllText(@"C:\Users\JonathanDeLaCruz\Documents\Revature\240415-CC-Geico-NET\connstring.txt");

//builder.Services.AddDbContext<TrackMyStuffContext>(options => 
 //   options.UseSqlServer(connectionString));


builder.Services.AddControllers();

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
