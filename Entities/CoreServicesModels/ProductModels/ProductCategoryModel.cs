using Entities.CoreServicesModels.MainDataModels;

namespace Entities.CoreServicesModels.ProductModels
{
    public class ProductCategoryParameters : RequestParameters
    {
        public int Fk_Product { get; set; }
        public int Fk_Category { get; set; }
    }

    public class ProductCategoryModel
    {
        public int Id { get; set; }

        [DisplayName(nameof(Product))]
        [ForeignKey(nameof(Product))]
        public int Fk_Product { get; set; }

        [DisplayName(nameof(Product))]
        public ProductModel Product { get; set; }

        [DisplayName(nameof(Category))]
        [ForeignKey(nameof(Category))]
        public int Fk_Category { get; set; }

        [DisplayName(nameof(Category))]
        public CategoryModel Category { get; set; }

        [DisplayName(nameof(CreatedAt))]
        public DateTime CreatedAt { get; set; }
    }

}
