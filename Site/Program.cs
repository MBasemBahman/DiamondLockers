using BaseDB;
using Contracts.Constants;
using CoreServices;
using DevelopmentDAL;
using Entities.AuthenticationModels;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Repository;
using Site.Middlewares;
using Site.Resources;
using Site.Services;
using Site.Utility;
using System.Globalization;
using System.Reflection;
using TenantConfiguration;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

TenantConfig config = new(TenantData.TenantEnvironments.Development);

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

builder.Services.AddDbContext<BaseContext, DevelopmentContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection")));

if (config.Tenant == TenantData.TenantEnvironments.Development)
{
    _ = builder.Services.AddScoped(_ =>
    {
        HttpContext httpContext = new HttpContextAccessor().HttpContext;

        return new UserAuthenticatedDto
        {
            Name = httpContext?.Request.Cookies[ViewDataConstants.AccountName] ?? "",
            EmailAddress = httpContext?.Request.Cookies[ViewDataConstants.AccountEmail] ?? "",
        };
    });

    _ = builder.Services.AddScoped<RepositoryManager, RepositoryManager>();
    _ = builder.Services.AddScoped<UnitOfWork, UnitOfWork>();
}

builder.Services.AddSingleton<LocalizationManager>();
builder.Services.AddScoped<SettingsService>();

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
app.UseMiddleware<CultureMiddleware>();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
