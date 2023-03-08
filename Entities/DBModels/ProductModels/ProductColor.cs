
using Entities.DBModels.MainDataModels;

namespace Entities.DBModels.ProductModels
{
    public class ProductColor : AuditEntity
    {
        [DisplayName(nameof(Product))]
        [ForeignKey(nameof(Product))]
        public int Fk_Product { get; set; }

        [DisplayName(nameof(Product))]
        public Product Product { get; set; }

        [DisplayName(nameof(Color))]
        [ForeignKey(nameof(Color))]
        public int Fk_Color { get; set; }

        [DisplayName(nameof(Color))]
        public Color Color { get; set; }
    }
}
