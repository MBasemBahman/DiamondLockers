using Entities.CoreServicesModels.MainDataModels;
using Entities.DBModels.MainDataModels;

namespace Repository.DBModels.MainDataModels
{
    public class CategoryRepository : RepositoryBase<Category>
    {
        public CategoryRepository(BaseContext context) : base(context)
        {
        }

        public IQueryable<Category> FindAll(
            CategoryParameters parameters,
            bool trackChanges)
        {
            return FindByCondition(a => true, trackChanges)
                   .Filter(parameters.Id);


        }
        
        public async Task<Category> FindById(int id, bool trackChanges)
        {
            return id == 0
                ? null
                : await FindByCondition(a => a.Id == id, trackChanges: trackChanges)
                    .Include(a => a.CategoryLang)
                    .SingleOrDefaultAsync();
        }
        
    }

    public static class CategoryRepositoryExtensions
    {
        public static IQueryable<Category> Filter(
            this IQueryable<Category> categories,
            int id)
        {
            return categories.Where(a => (id == 0 || a.Id == id));
        }


    }
}
