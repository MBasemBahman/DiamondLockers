
namespace Entities.DBModels.ProductModels
{
    public class Product : AuditLookUpEntity
    {
        [Required(ErrorMessage = PropertyAttributeConstants.RequiredMsg)]
        [DisplayName($"{nameof(Name)}{PropertyAttributeConstants.ArLang}")]
        public new string Name { get; set; }
        
        [DisplayName(nameof(Order))]
        public int Order { get; set; }
        
        [DisplayName(nameof(StorageUrl))]
        public string StorageUrl { get; set; }
        
        [DisplayName(nameof(ImageUrl))]
        public string ImageUrl { get; set; }

        public ProductLang ProductLang { get; set; }
    }

    public class ProductLang : LangEntity<Product>
    {
        [DisplayName($"{nameof(Name)}{PropertyAttributeConstants.EnLang}")]
        [Required(ErrorMessage = PropertyAttributeConstants.RequiredMsg)]
        public string Name { get; set; }
    }
}
