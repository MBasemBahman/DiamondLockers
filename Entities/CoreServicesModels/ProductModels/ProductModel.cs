namespace Entities.CoreServicesModels.ProductModels
{
    public class ProductParameters : RequestParameters
    {
        public int Fk_Category { get; set; }
        public int Fk_Color { get; set; }
        public int Fk_Size { get; set; }

        public bool IncludeCategories { get; set; }
        public bool IncludeSizes { get; set; }
        public bool IncludeColors { get; set; }

        public bool IgnoreNoneName { get; set; }
    }

    public class ProductModel
    {
        public int Id { get; set; }
        [DisplayName(nameof(Name))]
        public string Name { get; set; }

        [DisplayName(nameof(Order))]
        public int Order { get; set; }

        [DisplayName(nameof(StorageUrl))]
        public string StorageUrl { get; set; }

        [DisplayName(nameof(ImageUrl))]
        public string ImageUrl { get; set; }

        [DisplayName(nameof(CreatedAt))]
        public DateTime CreatedAt { get; set; }

        [DisplayName("Categories")]
        public string ProductCategoriesString { get; set; }

        [DisplayName("Sizes")]
        public string ProductSizesString { get; set; }

        [DisplayName("Colors")]
        public string ProductColorsString { get; set; }
    }

    public class ProductCreateOrEditModel
    {
        [Required(ErrorMessage = PropertyAttributeConstants.RequiredMsg)]
        [DisplayName($"{nameof(Name)}{PropertyAttributeConstants.ArLang}")]
        public string Name { get; set; }

        [DisplayName(nameof(Order))]
        public int Order { get; set; }

        [DisplayName(nameof(ImageUrl))]
        public string ImageUrl { get; set; }

        public ProductLangModel ProductLang { get; set; }

        [DisplayName(nameof(Fk_Categories))]
        public List<int> Fk_Categories { get; set; }

        [DisplayName(nameof(Fk_Colors))]
        public List<int> Fk_Colors { get; set; }

        [DisplayName(nameof(Fk_Sizes))]
        public List<int> Fk_Sizes { get; set; }
    }

    public class ProductLangModel
    {
        [Required(ErrorMessage = PropertyAttributeConstants.RequiredMsg)]
        [DisplayName($"{nameof(Name)}{PropertyAttributeConstants.EnLang}")]
        public string Name { get; set; }
    }
}
