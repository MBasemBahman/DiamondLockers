
using Entities.DBModels.ProductModels;

namespace Entities.DBModels.MainDataModels
{
    public class Size : AuditLookUpEntity
    {
        [Required(ErrorMessage = PropertyAttributeConstants.RequiredMsg)]
        [DisplayName($"{nameof(Name)}{PropertyAttributeConstants.ArLang}")]
        public new string Name { get; set; }
        
        [DisplayName(nameof(Order))]
        public int Order { get; set; }

        [DisplayName(nameof(ProductSizes))]
        public List<ProductSize> ProductSizes { get; set; }

        public SizeLang SizeLang { get; set; }
    }

    public class SizeLang : LangEntity<Size>
    {
        [DisplayName($"{nameof(Name)}{PropertyAttributeConstants.EnLang}")]
        [Required(ErrorMessage = PropertyAttributeConstants.RequiredMsg)]
        public string Name { get; set; }
    }
}
