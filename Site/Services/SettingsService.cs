using CoreServices;
using Entities.CoreServicesModels.SettingModels;

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
    
    public string Get(string var)
    {
        return _settingsDictionary[var];
    }
}