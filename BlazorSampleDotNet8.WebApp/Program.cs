using BlazorSampleDotNet8.WebApp.Components;
using BlazorSampleDotNet8.UseCases.Products;
using BlazorSampleDotNet8.UseCases.Products.Interfaces;
using BlazorSampleDotNet8.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddSingleton<IProductRepository, InMemoryProductRepository>();
builder.Services.AddScoped<IGetProductsByNameUseCase, GetProductsByNameUseCase>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
