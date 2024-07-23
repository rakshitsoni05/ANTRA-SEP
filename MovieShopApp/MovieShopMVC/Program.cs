using Microsoft.EntityFrameworkCore;
using MovieShopApp.Core.Contracts.Repositories;
using MovieShopApp.Core.Contracts.Services;
using MovieShopApp.Infrastructure.Data;
using MovieShopApp.Infrastructure.Repositories;
using MovieShopApp.Infrastructure.Services;
using MovieShopMVC.ViewComponents;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddLogging();

builder.Services.AddDbContext<MovieShopEfDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MovieShopEfDb"));
});

builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<IMovieRepository, MovieRepository>();
builder.Services.AddScoped<ICastRepository, CastRepository>();
builder.Services.AddScoped<IGenreRepository, GenreRepository>();
builder.Services.AddScoped<ICastService, CastService>();
builder.Services.AddScoped<IGenreService, GenreService>();
builder.Services.AddTransient<GenresViewComponent>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Movies}/{action=Index}/{id?}");

app.Run();