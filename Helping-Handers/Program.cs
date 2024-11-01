using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Helping_Handers.Data;
using Helping_Handers.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("HelpingHandConnectionString") ?? throw new InvalidOperationException("Connection string 'HelpingHandConnectionString' not found.");

builder.Services.AddDbContext<Helping_HandDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<Helping_User>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<Helping_HandDbContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.MapControllers();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
