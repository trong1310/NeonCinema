// Program.cs
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Extensions.DependencyInjection;
using Blazored.LocalStorage;
using NeonCinema_Client.Data;
using NeonCinema_Client.IServices.User;
using NeonCinema_Client.Services.User;
using NeonCinema_Client.Pages.Users;
/*using NeonCinema_Client.Services; */// Đảm bảo rằng dịch vụ UserService nằm trong namespace này

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddScoped<IUserServices, UserServices>();
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress =
    new Uri("https://localhost:5039/")
});



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

app.MapBlazorHub();
app.UseEndpoints(endpoints =>
{
    endpoints.MapFallbackToPage("/_Host"); // Nếu bạn sử dụng Blazor Server
});


app.Run();
