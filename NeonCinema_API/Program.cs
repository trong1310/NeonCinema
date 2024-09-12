using Com.CloudRail.SI.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using NeonCinema_Application.DataTransferObject.Utilities;
using NeonCinema_Application.Interface;
using NeonCinema_Application.Interface.Cinemas;

using NeonCinema_Application.Interface.Countrys;
using NeonCinema_Application.Interface.Roles;
using NeonCinema_Application.Interface.Room;
using NeonCinema_Application.Interface.ShiftChange;
using NeonCinema_Application.Interface.Users;
using NeonCinema_Application.Interface.WorkShidt;
using NeonCinema_Domain.Database.Entities;

using NeonCinema_Infrastructure.Extention;
using NeonCinema_Infrastructure.Implement;
using NeonCinema_Infrastructure.Implement.Cinemas;

using NeonCinema_Infrastructure.Implement.Countrys;
using NeonCinema_Infrastructure.Implement.Roles;
using NeonCinema_Infrastructure.Implement.Room;
using NeonCinema_Infrastructure.Implement.ShiftChange;
using NeonCinema_Infrastructure.Implement.Users;
using NeonCinema_Infrastructure.Implement.WorkShift;
using System.Text;
using Twilio;



var builder = WebApplication.CreateBuilder(args);



  


builder.Services.AddControllers();
// Capcha Login

// builder.Services.Configure<ReCapchaRequest>(builder.Configuration.GetSection("RecaptchaSettings"));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddScoped<TwilioClient, TwilioClient>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IRolesRepository, RoleRepository>();
builder.Services.AddScoped<ICountryRepository,CountryRepository>();
builder.Services.AddScoped<ICinemasRepository, CinemasRepository>();

builder.Services.AddScoped<IWorkShiftRepository, WorkShiftRepository>();
builder.Services.AddScoped<IShiftChangeRepository, ShiftChangeRepository>();
builder.Services.AddScoped<IRoomRepository, RoomRepository>();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(
        option => option.TokenValidationParameters = new TokenValidationParameters()
        {
			ValidateIssuer = true,
			ValidateAudience = true,
			ValidateLifetime = true,
			ValidateIssuerSigningKey = true,
			ValidIssuer = builder.Configuration["JWT:Issuer"],
			ValidAudience = builder.Configuration["JWT:Audience"],
			IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Secret"]))
		}
    );
builder.Services.AddAuthorization();
builder.Services.AddApplication(); //use automapper
builder.Services.AddEventBus(builder.Configuration);
builder.Services.AddCors(options =>////
{
	options.AddPolicy("AllowLocalhost",
		builder =>
		{
			builder.AllowAnyOrigin()
				   .AllowAnyMethod()
				   .AllowAnyHeader();
		});
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseCors("AllowLocalhost");
app.MapControllers();

app.Run();
