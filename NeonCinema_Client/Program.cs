using Blazored.LocalStorage;
using NeonCinema_Client.Data;
using NeonCinema_Client.Data.IServices.User;
using NeonCinema_Client.Services.User;
using NeonCinema_Application.DataTransferObject.Utilities;
using NeonCinema_Client.Models;
using NeonCinema_Client.Data.Services.Cinemas;
using NeonCinema_Client.Data.IServices.Cinemas;
using NeonCinema_Client.Data.IServices.FlimsUser;
using NeonCinema_Client.Data.Services.FilmUsers;
using MudBlazor.Services;
using NeonCinema_Client.Data.IServices.IRoom;
using NeonCinema_Client.Data.Services.Room;
using NeonCinema_Application.Interface.Room;
using NeonCinema_Infrastructure.Implement.Room;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Infrastructure.Database.AppDbContext;
using NeonCinema_Client.Data.IServices.IMoviesServices;
using NeonCinema_Client.Services.MoivesService;
using NeonCinema_Client.Data.IServices.Language;
using Blazored.Toast;
using NeonCinema_Client.Data.IServices.Screenning;
using NeonCinema_Client.Data.Services.Screenning;
using NeonCinema_Client.Data.IServices.Promotion;
using NeonCinema_Client.Data.Services.Promotion;
using NeonCinema_Client.Data.IServices.Director;
using NeonCinema_Client.Data.Services.Director;
using NeonCinema_Client.Data.IServices.MovieType;
using NeonCinema_Client.Data.Services.MovieType;
using Microsoft.Extensions.FileProviders;
using NeonCinema_Client.Data.IServices.SeatType;
using NeonCinema_Application.Interface.Seats;
using NeonCinema_Infrastructure.Implement.Seats;
using NeonCinema_Application.Interface;
using NeonCinema_Infrastructure.Implement;
using NeonCinema_Client.Data.IServices.Seat;
using NeonCinema_Client.Data.Services.Seat;
using NeonCinema_Client.Data.IServices.Genre;
using NeonCinema_Client.Data.Services.Genre;
using NeonCinema_Client.Data.IServices.Country;
using NeonCinema_Client.Data.Services.Country;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.IdentityModel.Tokens;
using NeonCinema_Client.Data.Services.BookTicket;
using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
using NeonCinema_Client.Data.IServices.Statistics;
using NeonCinema_Client.Data.Services.StatisticService;
using NeonCinema_Client.Data.IServices.TicketPrice;
using NeonCinema_Client.Data.Services.TicketPriceService;
using NeonCinema_Infrastructure.Implement.Promotion_R;

using NeonCinema_Client.Data.Services.SeatType;

using NeonCinema_Client.Data.Services.TicketPriceSetting;
using NeonCinema_Client.Data.IServices.TicketPriceSetting;
using NeonCinema_API.Controllers.Service;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<ICinemasService, CinemasService>();
builder.Services.AddScoped<IUserServices, UserServices>();
builder.Services.AddTransient<IFlimUsers, FlimUsers>();
builder.Services.AddScoped<IRoomService, RoomService>();
builder.Services.AddScoped<IRoomRepository, RoomRepository>();
builder.Services.AddScoped<IDirectorService, DirectorService>();
builder.Services.AddTransient<IMovieservices, MoviesServices>();
builder.Services.AddScoped<IMovieTypeService, MovieTypeService>();
builder.Services.AddTransient<IPromotionServices, PromotionServices>();
builder.Services.AddTransient<IUserServices, UserServices>();
builder.Services.AddScoped<ISeatTypeRepository , SeatTypeRepository>();
builder.Services.AddScoped<ISeatTypeService, SeatTypeService>();
builder.Services.AddScoped<IStatisticsService, StatisticsService>();
builder.Services.AddScoped<ITicketPriceService, TicketPriceService>();
builder.Services.AddScoped<ITicketPriceSettingService, TicketPriceSettingService>();
builder.Services.AddAutoMapper(typeof(Program));
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
builder.Services.AddScoped<IShowTimeService, ShowTimeService>();
builder.Services.AddScoped<IScreeningService, ScreeningService>();
builder.Services.AddScoped<ICountryService, CountryService>();
builder.Services.AddScoped<IGenreService, GenreService>();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddMudServices();
builder.Services.AddBlazoredToast();
builder.Services.AddScoped<ISeatRepository, SeatRepository>();
builder.Services.AddHttpClient<ISeatService, SeatService>();
builder.Services.AddScoped<ISeatService, SeatService>();
builder.Services.AddScoped<BookTicketServices>();
builder.Services.AddScoped<ISV, SV>();
//builder.Services.AddScoped<ISeatService, SeatService>();
//builder.Services.AddHostedService<PromoBackgroundServices>();
builder.Services.AddSignalR();

builder.Services.AddAuthentication("Bearer")
	.AddJwtBearer("Bearer", options =>
	{
		options.Authority = "https://localhost:7211"; // Địa chỉ máy chủ xác thực (auth server) của bạn
		options.TokenValidationParameters = new TokenValidationParameters
		{
			ValidateAudience = false
		};
	});
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminPolicy", policy => policy.RequireRole("Admin"));
    options.AddPolicy("ClientPolicy", policy => policy.RequireRole("Client"));
    options.AddPolicy("StaffPolicy", policy => policy.RequireRole("Staff"));
});

builder.Services.AddBlazorise(options => options.Immediate = true)
    .AddBootstrapProviders()
    .AddFontAwesomeIcons();
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
	endpoints.MapHub<PromoHub>("/promohub");
	endpoints.MapFallbackToPage("/_Host"); 
});


app.Run();
