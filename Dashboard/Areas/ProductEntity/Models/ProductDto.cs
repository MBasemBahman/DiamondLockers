using Entities.CoreServicesModels.ProductModels;
using System.ComponentModel;

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