using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BlazorSSRApp.Components;

var builder = WebApplication.CreateBuilder(args);

// 1️⃣ Enable Razor Components + interactive server components
builder.Services
    .AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

// 2️⃣ Anti-forgery middleware for <EditForm>
app.UseAntiforgery();

app.MapRazorComponents<App>()        // map your root component
   .AddInteractiveServerRenderMode();

app.Run();
