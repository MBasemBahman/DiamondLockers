using Entities.DBModels.CompanyModels;

namespace Entities.DBModels.AccountModels;

public class Account : AuditImageEntity
{
    [DisplayName(nameof(Company))]
    [ForeignKey(nameof(Company))]
    public int Fk_Company { get; set; }

    [DisplayName(nameof(Company))]
    public Company Company { get; set; }

    [DisplayName(nameof(Name))]
    [Required(ErrorMessage = PropertyAttributeConstants.RequiredMsg)]
    public string Name { get; set; }

    [DisplayName(nameof(Phone))]
    [Phone]
    public string Phone { get; set; }

    [DisplayName(nameof(EmailAddress))]
    [EmailAddress]
    public string EmailAddress { get; set; }
}