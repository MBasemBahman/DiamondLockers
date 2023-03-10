using Entities.CoreServicesModels.SettingModels;
using System.ComponentModel;

namespace Dashboard.Areas.SettingEntity.Models;

public class SettingFilter : DtParameters
{
    public int Id { get; set; }
}

public class SettingDto : SettingModel
{
    [DisplayName(nameof(CreatedAt))]
    public new string CreatedAt { get; set; }

    [DisplayName(nameof(LastModifiedAt))]
    public new string LastModifiedAt { get; set; }
}