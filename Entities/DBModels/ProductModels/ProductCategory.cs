
using Entities.DBModels.MainDataModels;

namespace Entities.DBModels.ProductModels
{
    public class ProductCategory : AuditEntity
    {
        [DisplayName(nameof(Product))]
        [ForeignKey(nameof(Product))]
        public int Fk_Product { get; set; }

        [DisplayName(nameof(Product))]
        public Product Product { get; set; }

        [DisplayName(nameof(Category))]
        [ForeignKey(nameof(Category))]
        public int Fk_Category { get; set; }

        [DisplayName(nameof(Category))]
        public Category Category { get; set; }
    }
}
