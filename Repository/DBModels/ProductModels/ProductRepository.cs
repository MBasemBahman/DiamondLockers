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
                   .Filter(parameters.Id);


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
            int id)
        {
            return categories.Where(a => (id == 0 || a.Id == id));
        }


    }
}
