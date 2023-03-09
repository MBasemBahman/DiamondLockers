using CoreServices;
using Entities.CoreServicesModels.SettingModels;
using Entities.DBModels.SettingModels;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Site.Services;

public class SettingsService
{
    private readonly Dictionary<string, string> _settingsDictionary;
    
    public SettingsService(IServiceScopeFactory scopeFactory)
    {
        using var scope = scopeFactory.CreateScope();
        var unitOfWork = scope.ServiceProvider.GetRequiredService<UnitOfWork>();
        
        _settingsDictionary = unitOfWork.Setting.GetSettingsLookUp(new SettingParameters());
    }

    // public string this[string var] => GetSettingValue(var);
    //
    // private string GetSettingValue(string var)
    // {
    //     return _settingsDictionary[var];
    // }
    
    public string Get(string var)
    {
        return _settingsDictionary[var];
    }
}