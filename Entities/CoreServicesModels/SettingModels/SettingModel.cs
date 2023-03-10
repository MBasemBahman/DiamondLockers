using Entities.EnumData;

namespace Entities.CoreServicesModels.SettingModels
{
    public class SettingParameters : RequestParameters
    {

    }

    public class SettingModel : AuditEntity
    {
        [DisplayName(nameof(Key))]
        public string Key { get; set; }

        [DisplayName(nameof(DisplayName))]
        public string DisplayName { get; set; }

        [DisplayName(nameof(Value))]
        public string Value { get; set; }

        [DisplayName(nameof(Type))]
        public DBModelsEnum.SettingTypeEnum Type { get; set; }

        [DisplayName(nameof(Order))]
        public int Order { get; set; }
    }

    public class SettingCreateOrEditModel
    {
        [DisplayName(nameof(Key))]
        [Required(ErrorMessage = PropertyAttributeConstants.RequiredMsg)]
        public string Key { get; set; }

        [DisplayName(nameof(DisplayName))]
        [Required(ErrorMessage = PropertyAttributeConstants.RequiredMsg)]
        public string DisplayName { get; set; }

        [DisplayName(nameof(Value))]
        public string Value { get; set; }

        [DisplayName(nameof(Type))]
        [Required(ErrorMessage = PropertyAttributeConstants.RequiredMsg)]
        public DBModelsEnum.SettingTypeEnum Type { get; set; }

        [DisplayName(nameof(Order))]
        public int Order { get; set; }
    }

}
