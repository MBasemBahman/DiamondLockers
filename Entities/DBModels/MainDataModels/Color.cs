
namespace Entities.DBModels.MainDataModels
{
    public class Color : AuditLookUpEntity
    {
        [Required(ErrorMessage = PropertyAttributeConstants.RequiredMsg)]
        [DisplayName($"{nameof(Name)}{PropertyAttributeConstants.ArLang}")]
        public new string Name { get; set; }
        
        [DisplayName(nameof(Order))]
        public int Order { get; set; }

        public ColorLang ColorLang { get; set; }
    }

    public class ColorLang : LangEntity<Color>
    {
        [DisplayName($"{nameof(Name)}{PropertyAttributeConstants.EnLang}")]
        [Required(ErrorMessage = PropertyAttributeConstants.RequiredMsg)]
        public string Name { get; set; }
    }
}
