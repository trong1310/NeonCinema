// Program.cs
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Extensions.DependencyInjection;
using Blazored.LocalStorage;
using NeonCinema_Client.Data;
/*using NeonCinema_Client.Services; */// Đảm bảo rằng dịch vụ UserService nằm trong namespace này

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

//// Configure the HttpClient for UserService
//builder.Services.AddHttpClient<UserService>(client =>
//{
//    client.BaseAddress = new Uri("https://yourapiurl.com/"); // Thay đổi URL cho phù hợp với API của bạn
//});

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
app.MapFallbackToPage("/_Host");

app.Run();
