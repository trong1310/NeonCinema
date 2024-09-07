using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using NeonCinema_Application.Interface;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Extention;
using NeonCinema_Infrastructure.Extention.AutoMapperProfile;
using System.Text;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddTransient<IEmployeesRepository, EmployeesRepository>();
//builder.Services.AddTransient<IWorkShiftRepository, WorkShiftRepository>();
//builder.Services.AddTransient<IShiftChangeRepository, ShiftChangesRepository>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
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
