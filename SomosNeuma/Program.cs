using Microsoft.EntityFrameworkCore;
using Neuma.DataAccess.Data;
using Neuma.DataAccess.Repository;
using Neuma.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Identity;
using Neuma.Models;
using Neuma.Utility;
using Microsoft.AspNetCore.Identity.UI.Services;

var builder = WebApplication.CreateBuilder(args);

// 1 Add services to the container.
builder.Services.AddControllersWithViews();

//2 Setting the database
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<IdentityUser, IdentityRole>(options => 
options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();


//5- Add RazorPages
builder.Services.AddRazorPages();


// 3 Setting Unit of Work
builder.Services.AddScoped<IUnitOfWork,  UnitOfWork>();

//Add Email Sender to fix the error
builder.Services.AddScoped<IEmailSender, EmailSender>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{area=User}/{controller=Home}/{action=Index}/{id?}"
);

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
//4- Add UseAuthentication
app.UseAuthentication();

app.UseAuthorization();



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//5 - Adding Razor Pages
app.MapRazorPages();

app.Run();
