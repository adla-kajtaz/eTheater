using eTheater;
using eTheater.Services;
using eTheater.Services.Database;
using eTheater.Services.Mapping;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

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
    options.UseSqlServer(connectionString, b => b.MigrationsAssembly("eTheater")));

builder.Services.AddSwaggerGen(sw => sw.SwaggerDoc("v1", new OpenApiInfo { Title = "eTheater", Version = "1.0"}));

builder.Services.AddSwaggerGen(s => s.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
{
    In = ParameterLocation.Header,
    Description = "JWT Authorization",
    Name = "Authorization",
    Type = SecuritySchemeType.Http,
    BearerFormat = "JWT",
    Scheme = "bearer"
}));

builder.Services.AddSwaggerGen(s => s.AddSecurityRequirement(new OpenApiSecurityRequirement
{
    {
        new OpenApiSecurityScheme
        {
            Reference = new OpenApiReference
            {
                Type = ReferenceType.SecurityScheme,
                Id = "Bearer"
            }
        },
        new string[]{}
    }
}));

builder.Services.AddTransient<IHallService, HallService>();
builder.Services.AddTransient<IShowService, ShowService>();
builder.Services.AddTransient<IShowScheduleService, ShowScheduleService>();
builder.Services.AddTransient<ITicketService, TicketService>();
builder.Services.AddTransient<ITheaterInfoService, TheaterInfoService>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IAuthService, AuthService>();
builder.Services.AddTransient<ITokenService, TokenService>();
builder.Services.AddTransient<INotificationService, NotificationService>();
builder.Services.AddTransient<IPurchaseService, PurchaseService>();
builder.Services.AddTransient<IActorService, ActorService>();
builder.Services.AddTransient<IShowActorService, ShowActorService>();
builder.Services.AddTransient<StripeService>();


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




builder.Services.AddAutoMapper(typeof(IUserService));

var jwtSettings = builder.Configuration.GetSection("JwtSettings");
var key = Encoding.UTF8.GetBytes(jwtSettings["SecretKey"]);
builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = jwtSettings["Issuer"],
            ValidAudience = jwtSettings["Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(key)
        };
    });
builder.Services.AddAuthorization();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    string? connection = app.Configuration.GetConnectionString("DefaultConnection");
    var dataContext = scope.ServiceProvider.GetRequiredService<ETheaterContext>();
    dataContext.Database.Migrate();
}

app.Run();
