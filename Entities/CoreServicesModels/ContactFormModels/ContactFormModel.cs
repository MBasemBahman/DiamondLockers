namespace Entities.CoreServicesModels.ContactFormModels
{
    public class ContactFormParameters : RequestParameters
    {

    }

    public class ContactFormModel : AuditEntity
    {
        [DisplayName(nameof(Id))]
        public new int Id { get; set; }

        [DisplayName(nameof(Type))]
        public string Type { get; set; }

        [DisplayName(nameof(Name))]
        public string Name { get; set; }

        [DisplayName(nameof(Phone))]
        [Phone]
        public string Phone { get; set; }

        [DisplayName(nameof(Email))]
        [EmailAddress]
        public string Email { get; set; }

        [DisplayName(nameof(Service))]
        public string Service { get; set; }

        [DisplayName(nameof(Message))]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }
    }

    public class ContactFormCreateOrEditModel
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
