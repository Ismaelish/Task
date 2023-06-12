using System.Security.Policy;
using System.Net.Mail;
using System.Net;
using Microsoft.Extensions.Configuration;
using MaximaMachineriesInc.DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ApplicationDbContext>();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("CMAXSHARED")
    ));

builder.Services.AddDbContext<RequestDbContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("CMAXCENTRALIZEDREQUEST")
    ));

builder.Services.AddDbContext<HRDbContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("CMAXHR")
    ));

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
   pattern: "{controller=Login}/{action=Login}/{id?}");

app.Run();
