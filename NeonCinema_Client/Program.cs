// Program.cs
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Extensions.DependencyInjection;
using Blazored.LocalStorage;
using NeonCinema_Client.Services.User;

using NeonCinema_Application.DataTransferObject.Utilities;
using NeonCinema_Client.Data.IServices.User;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();


builder.Services.AddScoped<IUserServices, UserServices>();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.AllowAnyOrigin();
                      });
});

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7211/") });



builder.Services.AddHttpClient();
builder.Services.AddScoped<IUserServices, UserServices>();
builder.Services.AddBlazoredLocalStorage();


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
