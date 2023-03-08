
namespace Entities.DBModels.ContactFormModels
{
    public class ContactForm : AuditEntity
    {
        [DisplayName(nameof(Type))]
        [Required(ErrorMessage = PropertyAttributeConstants.RequiredMsg)]
        public string Type { get; set; }
        
        [DisplayName(nameof(Name))]
        [Required(ErrorMessage = PropertyAttributeConstants.RequiredMsg)]
        public string Name { get; set; }
        
        [DisplayName(nameof(Phone))]
        [Required(ErrorMessage = PropertyAttributeConstants.RequiredMsg)]
        [Phone]
        public string Phone { get; set; }
        
        [DisplayName(nameof(Email))]
        [Required(ErrorMessage = PropertyAttributeConstants.RequiredMsg)]
        [EmailAddress]
        public string Email { get; set; }
        
        [DisplayName(nameof(Service))]
        [Required(ErrorMessage = PropertyAttributeConstants.RequiredMsg)]
        public string Service { get; set; }
        
        [DisplayName(nameof(Message))]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = PropertyAttributeConstants.RequiredMsg)]
        public string Message { get; set; }
    }
}
