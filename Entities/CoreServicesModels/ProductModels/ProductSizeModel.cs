using Entities.CoreServicesModels.MainDataModels;

namespace Entities.CoreServicesModels.ProductModels
{
    public class ProductSizeParameters : RequestParameters
    {
        public int Fk_Product { get; set; }
        public int Fk_Size { get; set; }
    }

    public class ProductSizeModel
    {
        public int Id { get; set; }
        
        [DisplayName(nameof(Product))]
        [ForeignKey(nameof(Product))]
        public int Fk_Product { get; set; }

        [DisplayName(nameof(Product))]
        public ProductModel Product { get; set; }

        [DisplayName(nameof(Size))]
        [ForeignKey(nameof(Size))]
        public int Fk_Size { get; set; }

        [DisplayName(nameof(Size))]
        public SizeModel Size { get; set; }

        [DisplayName(nameof(CreatedAt))]
        public DateTime CreatedAt { get; set; }
    }

}
