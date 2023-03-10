using Entities.EnumData;

namespace Entities.DBModels.SettingModels;

public class Setting : AuditEntity
{
    [DisplayName(nameof(Key))]
    [Required(ErrorMessage = PropertyAttributeConstants.RequiredMsg)]
    public string Key { get; set; }

    [DisplayName(nameof(DisplayName))]
    [Required(ErrorMessage = PropertyAttributeConstants.RequiredMsg)]
    public string DisplayName { get; set; }

    [DisplayName(nameof(Value))]
    [Required(ErrorMessage = PropertyAttributeConstants.RequiredMsg)]
    public string Value { get; set; }

    [DisplayName(nameof(Type))]
    [Required(ErrorMessage = PropertyAttributeConstants.RequiredMsg)]
    public DBModelsEnum.SettingTypeEnum Type { get; set; }

    [DisplayName(nameof(Order))]
    public int Order { get; set; }
}