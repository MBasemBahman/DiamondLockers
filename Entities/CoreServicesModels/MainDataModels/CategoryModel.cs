namespace Entities.CoreServicesModels.MainDataModels
{
    public class CategoryParameters : RequestParameters
    {

    }

    public class CategoryModel
    {
        public int Id { get; set; }
        [DisplayName(nameof(Name))]
        public string Name { get; set; }
        
        [DisplayName(nameof(Order))]
        public int Order { get; set; }

        [DisplayName(nameof(CreatedAt))]
        public DateTime CreatedAt { get; set; }
    }

    public class CategoryCreateOrEditModel
    {
        [Required(ErrorMessage = PropertyAttributeConstants.RequiredMsg)]
        [DisplayName($"{nameof(Name)}{PropertyAttributeConstants.ArLang}")]
        public string Name { get; set; }

        public CategoryLangModel CategoryLang { get; set; }

        [DisplayName(nameof(Order))]
        public int Order { get; set; }
    }

    public class CategoryLangModel
    {
        [Required(ErrorMessage = PropertyAttributeConstants.RequiredMsg)]
        [DisplayName($"{nameof(Name)}{PropertyAttributeConstants.EnLang}")]
        public string Name { get; set; }
    }
}
