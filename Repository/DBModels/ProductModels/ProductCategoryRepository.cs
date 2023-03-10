
using Entities.CoreServicesModels.ProductModels;
using Entities.DBModels.ProductModels;

namespace Repository.DBModels.ProductModels
{
    public class ProductCategoryRepository : RepositoryBase<ProductCategory>
    {
        public ProductCategoryRepository(BaseContext context) : base(context)
        {
        }

        public IQueryable<ProductCategory> FindAll(
            ProductCategoryParameters parameters,
            bool trackChanges)
        {
            return FindByCondition(a => true, trackChanges)
                   .Filter(parameters.Id,
                       parameters.Fk_Product,
                       parameters.Fk_Category);


        }

        public async Task<ProductCategory> FindById(int id, bool trackChanges)
        {
            return id == 0
                ? null
                : await FindByCondition(a => a.Id == id, trackChanges: trackChanges)
                    .SingleOrDefaultAsync();
        }

    }

    public static class ProductCategoryRepositoryExtensions
    {
        public static IQueryable<ProductCategory> Filter(
            this IQueryable<ProductCategory> categories,
            int id,
            int fk_Product,
            int fk_Category)
        {
            return categories.Where(a => (id == 0 || a.Id == id) &&
                                         (fk_Product == 0 || a.Fk_Product == fk_Product) &&
                                         (fk_Category == 0 || a.Fk_Category == fk_Category));
        }


    }
}
