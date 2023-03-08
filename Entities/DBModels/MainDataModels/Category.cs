
namespace Entities.DBModels.MainDataModels
{
    public class Category : AuditLookUpEntity
    {
        [Required(ErrorMessage = PropertyAttributeConstants.RequiredMsg)]
        [DisplayName($"{nameof(Name)}{PropertyAttributeConstants.ArLang}")]
        public new string Name { get; set; }
        
        [DisplayName(nameof(Order))]
        public int Order { get; set; }

        public CategoryLang CategoryLang { get; set; }
    }

    public class CategoryLang : LangEntity<Category>
    {
        [DisplayName($"{nameof(Name)}{PropertyAttributeConstants.EnLang}")]
        [Required(ErrorMessage = PropertyAttributeConstants.RequiredMsg)]
        public string Name { get; set; }
    }
}
