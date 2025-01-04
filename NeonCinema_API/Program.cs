
using Com.CloudRail.SI.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.FileProviders;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using NeonCinema_API.Controllers.Service;
using NeonCinema_API.SendMail;
using NeonCinema_API.Timer;
using NeonCinema_Application.DataTransferObject.Utilities;
using NeonCinema_Application.Interface;

using NeonCinema_Application.Interface.Cinemas;
using NeonCinema_Application.Interface.Countrys;
using NeonCinema_Application.Interface.Directors;
using NeonCinema_Application.Interface.IBookingHistory;
using NeonCinema_Application.Interface.Point;
using NeonCinema_Application.Interface.RannkMember;
using NeonCinema_Application.Interface.Roles;
using NeonCinema_Application.Interface.Room;
using NeonCinema_Application.Interface.Seats;
using NeonCinema_Application.Interface.ShiftChange;
using NeonCinema_Application.Interface.ShowTime;
using NeonCinema_Application.Interface.Statistics;
using NeonCinema_Application.Interface.TicketPriceSetting;
using NeonCinema_Application.Interface.Users;
using NeonCinema_Application.Interface.WorkShidt;
using NeonCinema_Infrastructure.Extention;
using NeonCinema_Infrastructure.Implement;
using NeonCinema_Infrastructure.Implement.BookingHistory;
using NeonCinema_Infrastructure.Implement.Cinemas;
using NeonCinema_Infrastructure.Implement.Countrys;
using NeonCinema_Infrastructure.Implement.Directors;
using NeonCinema_Infrastructure.Implement.RankMembers;
using NeonCinema_Infrastructure.Implement.Roles;
using NeonCinema_Infrastructure.Implement.Room;
using NeonCinema_Infrastructure.Implement.Screenings;
using NeonCinema_Infrastructure.Implement.Seats;
using NeonCinema_Infrastructure.Implement.Statistics;
using NeonCinema_Infrastructure.Implement.TicketPriceSetting;
using NeonCinema_Infrastructure.Implement.Users;
using NeonCinema_Infrastructure.Services;
using System.Text;
using Twilio;
var builder = WebApplication.CreateBuilder(args);
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IRolesRepository, RoleRepository>();
builder.Services.AddScoped<ICountryRepository, CountryRepository>();
builder.Services.AddScoped<ICinemasRepository, CinemasRepository>();
//builder.Services.AddScoped<IActorRepositories, ActorResp>();
builder.Services.AddScoped<ISeatRepository, SeatRepository>();
builder.Services.AddScoped<IShowTimeRepository, ShowTimeRepository>();
builder.Services.AddScoped<IRankMemberRepository, RankMemberRepositories>();
builder.Services.AddScoped<IRoomRepository, RoomRepository>();
builder.Services.AddScoped<ISeatTypeRepository, SeatTypeRepository>();
builder.Services.AddScoped<IDirectorRepositories, DirectorRepositories>();
builder.Services.AddScoped<IStatisticsRepository, StatisticsRepository>();
builder.Services.AddScoped<IHistoryRepository, HistoryRepository>();
builder.Services.AddScoped<ITicketPriceSettingRepository, TicketPriceSettingRepository>();
builder.Services.AddScoped<IScreeningRepository, ScreeningRepository>();
builder.Services.AddScoped<ISendMailService, SendMailService>();
builder.Services.AddScoped<UserProfile>();
builder.Services.AddScoped<ISV, SV>();
builder.Services.AddScoped<UpdateUserProfileRequest>();

builder.Services.AddScoped<IUserServicesss, UserService>();
builder.Services.AddHostedService<TimerProcess>();
builder.Services.AddLogging();
builder.Services.AddTransient<EmailServices>();

builder.Services.Configure<FormOptions>(options =>
{
    options.MultipartBodyLengthLimit = 20 * 1024 * 1024; // Giới hạn kích thước file upload (20MB)
});
var key = builder.Configuration.GetSection("Jwt:Key").Value;
builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(option =>
{
    option.RequireHttpsMetadata = false;
    option.SaveToken = true;
    option.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key))
    };


});
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.AllowAnyOrigin();
                      });
});
builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description =
        "JWT Authorization header using the Bearer scheme. \r\n\r\n" +
        "Enter 'Bearer' [space] and then your token in the text input below. \r\n\r\n" +
        "Example: \"Bearer 12345abcdef\""
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
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
            new List<string> {}
        }
    });
});
builder.Services.AddAuthentication();
builder.Services.AddAuthorization();
builder.Services.AddApplication(); //use automapper
builder.Services.AddEventBus(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//app.UseStaticFiles(new StaticFileOptions
//{
//    FileProvider = new PhysicalFileProvider(
//        Path.Combine(builder.Environment.ContentRootPath, "Resources")),
//    RequestPath = new PathString("/Resources")
//});
app.UseStaticFiles(); // Kích hoạt phục vụ file tĩnh
app.UseMiddleware<TokenValidationMiddleware>();

app.UseHttpsRedirection();
app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();
