using Entities.CoreServicesModels.MainDataModels;
using Entities.DBModels.MainDataModels;

namespace Repository.DBModels.MainDataModels
{
    public class SizeRepository : RepositoryBase<Size>
    {
        public SizeRepository(BaseContext context) : base(context)
        {
        }

        public IQueryable<Size> FindAll(
            SizeParameters parameters,
            bool trackChanges)
        {
            return FindByCondition(a => true, trackChanges)
                   .Filter(parameters.Id);


        }
        
        public async Task<Size> FindById(int id, bool trackChanges)
        {
            return id == 0
                ? null
                : await FindByCondition(a => a.Id == id, trackChanges: trackChanges)
                        .Include(a => a.SizeLang)
                         .SingleOrDefaultAsync();
        }
        
    }

    public static class SizeRepositoryExtensions
    {
        public static IQueryable<Size> Filter(
            this IQueryable<Size> categories,
            int id)
        {
            return categories.Where(a => (id == 0 || a.Id == id));
        }


    }
}
