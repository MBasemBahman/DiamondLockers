namespace Entities.CoreServicesModels.MainDataModels
{
    public class ColorParameters : RequestParameters
    {

    }

    public class ColorModel
    {
        public int Id { get; set; }
        [DisplayName(nameof(Name))]
        public string Name { get; set; }
        
        [DisplayName(nameof(Order))]
        public int Order { get; set; }

        [DisplayName(nameof(CreatedAt))]
        public DateTime CreatedAt { get; set; }
    }

    public class ColorCreateOrEditModel
    {
        [Required(ErrorMessage = PropertyAttributeConstants.RequiredMsg)]
        [DisplayName($"{nameof(Name)}{PropertyAttributeConstants.ArLang}")]
        public string Name { get; set; }

        [DisplayName(nameof(Order))]
        public int Order { get; set; }
        
        public ColorLangModel ColorLang { get; set; }
    }

    public class ColorLangModel
    {
        [Required(ErrorMessage = PropertyAttributeConstants.RequiredMsg)]
        [DisplayName($"{nameof(Name)}{PropertyAttributeConstants.EnLang}")]
        public string Name { get; set; }
    }
}
