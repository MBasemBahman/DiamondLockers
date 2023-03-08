namespace Entities.DBModels.CompanyModels;

public class Company : AuditImageEntity
{
    [DisplayName(nameof(Name))]
    [Required(ErrorMessage = PropertyAttributeConstants.RequiredMsg)]
    public string Name { get; set; }

    [DisplayName(nameof(Phone))]
    [Phone]
    public string Phone { get; set; }

    [DisplayName(nameof(EmailAddress))]
    [EmailAddress]
    public string EmailAddress { get; set; }
    
    [DisplayName(nameof(WebsiteUrl))]
    [Url]
    public string WebsiteUrl { get; set; }
    
    [DisplayName(nameof(VideoUrl))]
    [Url]
    public string VideoUrl { get; set; }
}