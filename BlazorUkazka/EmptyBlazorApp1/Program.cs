using EmptyBlazorApp1.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System.Globalization;

CultureInfo ci = new CultureInfo("cs-CZ");
CultureInfo.DefaultThreadCurrentCulture = ci;
CultureInfo.DefaultThreadCurrentUICulture = ci;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddDbContext<SeznamDbContext>();

var app = builder.Build();


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
