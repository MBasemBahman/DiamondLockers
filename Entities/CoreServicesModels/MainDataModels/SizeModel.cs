namespace Entities.CoreServicesModels.MainDataModels
{
    public class SizeParameters : RequestParameters
    {

    }

    public class SizeModel
    {
        public int Id { get; set; }
        [DisplayName(nameof(Name))]
        public string Name { get; set; }
        
        [DisplayName(nameof(Order))]
        public int Order { get; set; }

        [DisplayName(nameof(CreatedAt))]
        public DateTime CreatedAt { get; set; }
    }

    public class SizeCreateOrEditModel
    {
        [Required(ErrorMessage = PropertyAttributeConstants.RequiredMsg)]
        [DisplayName($"{nameof(Name)}{PropertyAttributeConstants.ArLang}")]
        public string Name { get; set; }
        
        [DisplayName(nameof(Order))]
        public int Order { get; set; }

        public SizeLangModel SizeLang { get; set; }
    }

    public class SizeLangModel
    {
        [Required(ErrorMessage = PropertyAttributeConstants.RequiredMsg)]
        [DisplayName($"{nameof(Name)}{PropertyAttributeConstants.EnLang}")]
        public string Name { get; set; }
    }
}
