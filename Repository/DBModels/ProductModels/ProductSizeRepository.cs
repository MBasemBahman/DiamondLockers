
using Entities.CoreServicesModels.ProductModels;
using Entities.DBModels.ProductModels;

namespace Repository.DBModels.ProductModels
{
    public class ProductSizeRepository : RepositoryBase<ProductSize>
    {
        public ProductSizeRepository(BaseContext context) : base(context)
        {
        }

        public IQueryable<ProductSize> FindAll(
            ProductSizeParameters parameters,
            bool trackChanges)
        {
            return FindByCondition(a => true, trackChanges)
                   .Filter(parameters.Id,
                       parameters.Fk_Product,
                       parameters.Fk_Size);


        }
        
        public async Task<ProductSize> FindById(int id, bool trackChanges)
        {
            return id == 0
                ? null
                : await FindByCondition(a => a.Id == id, trackChanges: trackChanges)
                    .SingleOrDefaultAsync();
        }
        
    }

    public static class ProductSizeRepositoryExtensions
    {
        public static IQueryable<ProductSize> Filter(
            this IQueryable<ProductSize> categories,
            int id,
            int fk_Product,
            int fk_Size)
        {
            return categories.Where(a => (id == 0 || a.Id == id) &&
                                         (fk_Product == 0 || a.Fk_Product == fk_Product) &&
                                         (fk_Size == 0 || a.Fk_Size == fk_Size) );
        }


    }
}
