using Microsoft.EntityFrameworkCore;
using Neuma.DataAccess.Data;
using Neuma.DataAccess.Repository;
using Neuma.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Identity;
using Neuma.Models;

var builder = WebApplication.CreateBuilder(args);

// 1 Add services to the container.
builder.Services.AddControllersWithViews();

//2 Setting the database
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<ApplicationDbContext>();


//5- Add RazorPages
builder.Services.AddRazorPages();


// 3 Setting Unit of Work
builder.Services.AddScoped<IUnitOfWork,  UnitOfWork>();

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

//4- Add UseAuthentication
app.UseAuthentication();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//5 - Adding Razor Pages
app.MapRazorPages();

app.Run();
