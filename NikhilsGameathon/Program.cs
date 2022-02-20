using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<RazorPagesGamesContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("RazorPagesGamesContext")));

builder.Services.AddDbContext<RazorPagesMovieContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("RazorPagesMovieContext")));

builder.Services.AddDbContext<GGGamesContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("GGGamesContext")));

builder.Services.AddDbContext<Gamesontext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Gamesontext")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
