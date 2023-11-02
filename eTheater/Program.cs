using eTheater;
using eTheater.Services;
using eTheater.Services.Database;
using eTheater.Services.Mapping;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(x =>
{
    x.Filters.Add<ErrorFilter>();
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ETheaterContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IHallService, HallService>();
builder.Services.AddTransient<IShowService, ShowService>();
builder.Services.AddTransient<IShowScheduleService, ShowScheduleService>();
builder.Services.AddTransient<ITicketService, TicketService>();
builder.Services.AddTransient<ITheaterInfoService, TheaterInfoService>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IAuthService, AuthService>();
builder.Services.AddTransient<ITokenService, TokenService>();
builder.Services.AddTransient<INotificationService, NotificationService>();



builder.Services.AddIdentity<User, IdentityRole<int>>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredLength = 8;
    options.User.AllowedUserNameCharacters = string.Empty;
    options.User.RequireUniqueEmail = true;

}).AddEntityFrameworkStores<ETheaterContext>().AddRoles<IdentityRole<int>>().AddDefaultTokenProviders();
builder.Services.AddScoped<UserManager<User>>();
builder.Services.AddScoped<IdentityRole<int>>();




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
