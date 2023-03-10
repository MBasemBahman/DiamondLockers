using Entities.CoreServicesModels.ContactFormModels;
using System.ComponentModel;

namespace Dashboard.Areas.ContactFormEntity.Models;

public class ContactFormFilter : DtParameters
{
    public int Id { get; set; }
}

public class ContactFormDto : ContactFormModel
{
    [DisplayName(nameof(CreatedAt))]
    public string CreatedAt { get; set; }

    [DisplayName(nameof(LastModifiedAt))]
    public string LastModifiedAt { get; set; }
}