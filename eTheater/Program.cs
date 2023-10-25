using eTheater.Services;
using eTheater.Services.Database;
using eTheater.Services.Mapping;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ETheaterContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IHallService, HallService>();
builder.Services.AddTransient<IShowService, ShowService>();


builder.Services.AddAutoMapper(typeof(Program), typeof(MapperProfiles));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    string? connection = app.Configuration.GetConnectionString("DefaultConnection");
    var dataContext = scope.ServiceProvider.GetRequiredService<ETheaterContext>();
    dataContext.Database.Migrate();
}

app.Run();
