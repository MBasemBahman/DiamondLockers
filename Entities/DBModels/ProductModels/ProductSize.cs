
using Entities.DBModels.MainDataModels;

namespace Entities.DBModels.ProductModels
{
    public class ProductSize : AuditEntity
    {
        [DisplayName(nameof(Product))]
        [ForeignKey(nameof(Product))]
        public int Fk_Product { get; set; }

        [DisplayName(nameof(Product))]
        public Product Product { get; set; }

        [DisplayName(nameof(Size))]
        [ForeignKey(nameof(Size))]
        public int Fk_Size { get; set; }

        [DisplayName(nameof(Size))]
        public Size Size { get; set; }
    }
}
