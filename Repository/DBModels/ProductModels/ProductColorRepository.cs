
using Entities.CoreServicesModels.ProductModels;
using Entities.DBModels.ProductModels;

namespace Repository.DBModels.ProductModels
{
    public class ProductColorRepository : RepositoryBase<ProductColor>
    {
        public ProductColorRepository(BaseContext context) : base(context)
        {
        }

        public IQueryable<ProductColor> FindAll(
            ProductColorParameters parameters,
            bool trackChanges)
        {
            return FindByCondition(a => true, trackChanges)
                   .Filter(parameters.Id,
                       parameters.Fk_Product,
                       parameters.Fk_Color);


        }

        public async Task<ProductColor> FindById(int id, bool trackChanges)
        {
            return id == 0
                ? null
                : await FindByCondition(a => a.Id == id, trackChanges: trackChanges)
                    .SingleOrDefaultAsync();
        }

    }

    public static class ProductColorRepositoryExtensions
    {
        public static IQueryable<ProductColor> Filter(
            this IQueryable<ProductColor> categories,
            int id,
            int fk_Product,
            int fk_Color)
        {
            return categories.Where(a => (id == 0 || a.Id == id) &&
                                         (fk_Product == 0 || a.Fk_Product == fk_Product) &&
                                         (fk_Color == 0 || a.Fk_Color == fk_Color));
        }


    }
}
