using BlazorApp6.Client.Application;
using BlazorApp6.Client.Application.People;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddScoped(_ => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IGetPerson, GetPersonClient>();
await builder.Build().RunAsync();
