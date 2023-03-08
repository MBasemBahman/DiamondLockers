using System.ComponentModel;
using Entities.CoreServicesModels.MainDataModels;
using Entities.CoreServicesModels.ProductModels;

namespace Dashboard.Areas.ProductEntity.Models;

public class ProductFilter : DtParameters
{
    public int Id { get; set; }
}

public class ProductDto : ProductModel
{
    [DisplayName(nameof(CreatedAt))]
    public new string CreatedAt { get; set; }

    [DisplayName(nameof(LastModifiedAt))]
    public string LastModifiedAt { get; set; }
}