using BlazorApp.Components;
using BlazorApp.Service;
using BlazorApp.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddScoped<IService<Product>>(sp => new WebService<Product>("product"));
builder.Services.AddScoped<IService<Brand>>(sp => new WebService<Brand>("brand"));
builder.Services.AddScoped<IService<TypeProduct>>(sp => new WebService<TypeProduct>("typeproduct"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();
app.Run();
