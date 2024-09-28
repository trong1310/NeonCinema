// Program.cs
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Extensions.DependencyInjection;
using Blazored.LocalStorage;
using NeonCinema_Client.Data;
using NeonCinema_Client.Data.IServices.User;
using NeonCinema_Client.Services.User;
using NeonCinema_Client.Pages.Admin.Users;

/*using NeonCinema_Client.Services; */// Đảm bảo rằng dịch vụ UserService nằm trong namespace này


using NeonCinema_Application.DataTransferObject.Utilities;
using NeonCinema_Client.Models;
using NeonCinema_Client.Data.Services.Cinemas;
using NeonCinema_Client.Data.IServices.Cinemas;
using NeonCinema_Client.Data.IServices.FlimsUser;
using NeonCinema_Client.Data.Services.FilmUsers;
using MudBlazor.Services;
<<<<<<< HEAD
using NeonCinema_Client.Data.IServices.IRoom;
using NeonCinema_Client.Data.Services.Room;
using NeonCinema_Application.Interface.Room;
using NeonCinema_Infrastructure.Implement.Room;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Infrastructure.Database.AppDbContext;
=======
using NeonCinema_Client.Data.IServices.IMoviesServices;
using NeonCinema_Client.Services.MoivesService;
using NeonCinema_Client.Data.IServices.Language;
using Blazored.Toast;
using NeonCinema_Domain.Database.Entities;
>>>>>>> 2d7fbc3d366e050598d179abb36d7fe9f722c374


var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<ICinemasService, CinemasService>();
builder.Services.AddScoped<IUserServices, UserServices>();
builder.Services.AddTransient<IFlimUsers, FlimUsers>();
<<<<<<< HEAD
builder.Services.AddScoped<IRoomService, RoomService>();
builder.Services.AddScoped<IRoomRepository, RoomRepository>();
builder.Services.AddDbContext<NeonCinemasContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
=======
builder.Services.AddTransient<IMovieservices, MoviesServices>();


>>>>>>> 2d7fbc3d366e050598d179abb36d7fe9f722c374
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.AllowAnyOrigin();
                      });
});

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7211/") });


builder.Services.AddDbContext<NeonCinemasContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddHttpClient();
builder.Services.AddScoped<LoginModels>();
builder.Services.AddScoped<IUserServices, UserServices>();
builder.Services.AddScoped<ILanguageService, LanguageService>();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddMudServices();
builder.Services.AddBlazoredToast();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseCors(MyAllowSpecificOrigins);
app.MapBlazorHub();
app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapFallbackToPage("/_Host"); 
});


app.Run();
