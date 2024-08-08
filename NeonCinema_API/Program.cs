using NeonCinema_Application.Interface;

using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Extention;
using NeonCinema_Infrastructure.Extention.AutoMapperProfile;
using NeonCinema_Infrastructure.Implement.Employees;
using NeonCinema_Infrastructure.Implement.Screenings;
using NeonCinema_Infrastructure.Implement.ShiftChanges;
using NeonCinema_Infrastructure.Implement.WorkShift;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<IEmployeesRepository, EmployeesRepository>();
builder.Services.AddTransient<IWorkShiftRepository, WorkShiftRepository>();
builder.Services.AddTransient<IShiftChangeRepository, ShiftChangesRepository>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAuthorization();
builder.Services.AddAutoMapper(typeof(MovieProfile));
builder.Services.AddApplication(); //use automapper
builder.Services.AddEventBus(builder.Configuration);
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

app.Run();
