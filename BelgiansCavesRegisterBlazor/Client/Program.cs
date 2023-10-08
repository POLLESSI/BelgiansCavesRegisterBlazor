using BelgiansCavesRegisterBlazor.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Supply HttpClient instances that include access tokens when making requests to the server project
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri
    (builder.HostEnvironment.BaseAddress) });

//builder.Services.AddApiAuthorization();

await builder.Build().RunAsync();
