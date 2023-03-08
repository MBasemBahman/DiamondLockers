using Entities.CoreServicesModels.MainDataModels;

namespace Entities.CoreServicesModels.ProductModels
{
    public class ProductColorParameters : RequestParameters
    {
        public int Fk_Product { get; set; }
        public int Fk_Color { get; set; }
    }

    public class ProductColorModel
    {
        public int Id { get; set; }
        
        [DisplayName(nameof(Product))]
        [ForeignKey(nameof(Product))]
        public int Fk_Product { get; set; }

        [DisplayName(nameof(Product))]
        public ProductModel Product { get; set; }

        [DisplayName(nameof(Color))]
        [ForeignKey(nameof(Color))]
        public int Fk_Color { get; set; }

        [DisplayName(nameof(Color))]
        public ColorModel Color { get; set; }

        [DisplayName(nameof(CreatedAt))]
        public DateTime CreatedAt { get; set; }
    }

}
