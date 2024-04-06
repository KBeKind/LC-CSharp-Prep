using CodingEvents.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);
//var connectionString = builder.Configuration.GetConnectionString("EventDbContextConnection") ?? throw new InvalidOperationException("Connection string 'EventDbContextConnection' not found.");

// Add services to the container.
builder.Services.AddControllersWithViews();

string dbUser = Environment.GetEnvironmentVariable("DB_USER");
string dbPass = Environment.GetEnvironmentVariable("DB_PASS");
string dbName = Environment.GetEnvironmentVariable("DB_NAME");

var connectionString = $"server=localhost;user=codingeventscsharp;password=codingevents;database=coding-events-c-sharp";
var serverVersion = new MySqlServerVersion(new Version(8, 0, 33));

builder.Services.AddRazorPages();


builder.Services.AddDbContext<EventDbContext>(dbContextOptions => dbContextOptions.UseMySql(connectionString, serverVersion));

builder.Services.AddDefaultIdentity<IdentityUser>
(options =>
{
	options.SignIn.RequireConfirmedAccount = false;
	options.Password.RequireDigit = false;
	options.Password.RequiredLength = 4;
	options.Password.RequireNonAlphanumeric = false;
	options.Password.RequireUppercase = false;
	options.Password.RequireLowercase = false;
}).AddEntityFrameworkStores<EventDbContext>();

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

app.MapRazorPages();
app.MapControllers();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
