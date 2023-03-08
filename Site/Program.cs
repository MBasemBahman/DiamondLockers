using Site.Resources;
using Site.Utility;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Options;
using System.Globalization;
using System.Reflection;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews()
                .AddViewLocalization()
                .AddDataAnnotationsLocalization(options =>
                {
                    options.DataAnnotationLocalizerProvider = (type, factory) =>
                    {
                        AssemblyName assemblyName = new(typeof(ResourcesFile).GetTypeInfo().Assembly.FullName);
                        return factory.Create(nameof(ResourcesFile), assemblyName.Name);
                    };
                });

builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");
builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    CultureInfo[] supportedCultures = new[]
    {
        new CultureInfo("en"),
        new CultureInfo("ar")
    };
    options.DefaultRequestCulture = new RequestCulture(culture: "en", uiCulture: "en");
    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;
});
builder.Services.AddSingleton<LocalizationManager>();

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    _ = app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    _ = app.UseHsts();
}

app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseRouting();
app.UseCookiePolicy();
app.UseRequestLocalization(app.Services.GetService<IOptions<RequestLocalizationOptions>>().Value);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
