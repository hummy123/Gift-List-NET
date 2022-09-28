using GiftList.Models;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IGiftRepository, MockGiftRepository>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapDefaultControllerRoute();

app.Run();
