using BlazorDemo.Client.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BuberDinner.Web.Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Add this if you need to call JS
//builder.Services.AddSingleton<IJSInProcessRuntime>(services =>
//    (IJSInProcessRuntime)services.GetRequiredService<IJSRuntime>());

// builder.Services.AddScoped<SessionStorageService>();

await builder.Build().RunAsync();
