using Entities.CoreServicesModels.MainDataModels;
using Entities.CoreServicesModels.ProductModels;
using Entities.DBModels.MainDataModels;
using Entities.DBModels.ProductModels;

namespace Repository.DBModels.ProductModels
{
    public class ProductRepository : RepositoryBase<Product>
    {
        public ProductRepository(BaseContext context) : base(context)
        {
        }

        public IQueryable<Product> FindAll(
            ProductParameters parameters,
            bool trackChanges)
        {
            return FindByCondition(a => true, trackChanges)
                   .Filter(parameters.Id,
                       parameters.Fk_Category,
                       parameters.Fk_Color,
                       parameters.Fk_Size);


        }
        
        public async Task<Product> FindById(int id, bool trackChanges)
        {
            return id == 0
                ? null
                : await FindByCondition(a => a.Id == id, trackChanges: trackChanges)
                    .Include(a => a.ProductLang)
                    .SingleOrDefaultAsync();
        }
        
    }

    public static class ProductRepositoryExtensions
    {
        public static IQueryable<Product> Filter(
            this IQueryable<Product> categories,
            int id,
            int fk_Category,
            int fk_Color,
            int fk_Size)
        {
            return categories.Where(a => (id == 0 || a.Id == id) &&
                                         (fk_Category == 0 || a.ProductCategories.Any(b => b.Fk_Category == fk_Category)) &&
                                         (fk_Color == 0 || a.ProductColors.Any(b => b.Fk_Color == fk_Color)) &&
                                         (fk_Size == 0 || a.ProductSizes.Any(b => b.Fk_Size == fk_Size)) );
        }


    }
}
