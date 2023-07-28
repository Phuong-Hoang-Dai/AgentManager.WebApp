using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using AgentManager.WebApp.Models.Data;
using AgentManager.WebApp.Models;

var builder = WebApplication.CreateBuilder(args);
//var connectionString = builder.Configuration.GetConnectionString("AgentManagerDbContextConnection") ?? throw new InvalidOperationException("Connection string 'AgentManagerDbContextConnection' not found.");

//builder.Services.AddDbContext<AgentManagerDbContext>(options =>
//    options.UseSqlServer(connectionString));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AgentManagerDbContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("AgentManagerDbContext")));
builder.Services.AddRazorPages();

builder.Services.AddAuthentication();
builder.Services.AddAuthorization();
builder.Services.AddIdentity<Staff, IdentityRole>()
                .AddEntityFrameworkStores<AgentManagerDbContext>()
                .AddDefaultTokenProviders();


var app = builder.Build();

//Seed Data
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}

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
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
