using cbsStudents.Data;
using Microsoft.EntityFrameworkCore;
using students.Models.Entities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddMvc().AddJsonOptions(o =>
{
    o.JsonSerializerOptions.PropertyNamingPolicy = null;
    o.JsonSerializerOptions.DictionaryKeyPolicy = null;
});
builder.Services.AddControllersWithViews().AddNewtonsoftJson(options => 
options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

builder.Services.AddDbContext<CbsStudentsContext>(options =>

    options.UseSqlite(builder.Configuration.GetConnectionString("CbsStudentsContext")));
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<CbsStudentsContext>();builder.Services.AddDbContext<CbsStudentsContext>(options =>
    options.UseSqlServer("CbsStudentsContext"));
builder.Services.AddDbContext<CbsStudentsContext>(options =>

    options.UseSqlite(builder.Configuration.GetConnectionString("CbsStudentsContext")));

// Add services to the container.
builder.Services.AddControllersWithViews();

 builder.Services.AddDbContext<CbsStudentsContext>(options =>
        options.UseSqlite(builder.Configuration.GetConnectionString("CbsStudentsContext")));

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
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
