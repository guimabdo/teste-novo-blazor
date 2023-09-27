using BlazorApp6.Application.People;
using BlazorApp6.Client.Application;
using BlazorApp6.Client.Application.People;
using BlazorApp6.Components;
using static BlazorApp6.Client.ApiUtils;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services
    .AddRazorComponents()
    .AddServerComponents()
    .AddWebAssemblyComponents();

builder.Services.AddScoped<IGetPerson, GetPersonHandler>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.MapRazorComponents<App>()
    .AddServerRenderMode()
    .AddWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(IGetPerson).Assembly);
app.MapGet(
    GetEndpoint<IGetPerson>(), 
    (IGetPerson handler, [AsParameters] GetPersonRequest request) => handler.HandleAsync(request)
);

app.Run();


