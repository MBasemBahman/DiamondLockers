using System.ComponentModel;
using Entities.CoreServicesModels.ContactFormModels;

namespace Dashboard.Areas.ContactFormEntity.Models;

public class ContactFormFilter : DtParameters
{
    public int Id { get; set; }
}

public class ContactFormDto : ContactFormModel
{
    [DisplayName(nameof(CreatedAt))]
    public new string CreatedAt { get; set; }

    [DisplayName(nameof(LastModifiedAt))]
    public string LastModifiedAt { get; set; }
}