using Entities.CoreServicesModels.SettingModels;
using Entities.DBModels.SettingModels;

namespace Repository.DBModels.SettingModels
{
    public class SettingRepository : RepositoryBase<Setting>
    {
        public SettingRepository(BaseContext context) : base(context)
        {
        }

        public IQueryable<Setting> FindAll(
            SettingParameters parameters,
            bool trackChanges)
        {
            return FindByCondition(a => true, trackChanges)
                   .Filter(parameters.Id);


        }

        public async Task<Setting> FindById(int id, bool trackChanges)
        {
            return id == 0
                ? null
                : await FindByCondition(a => a.Id == id, trackChanges: trackChanges)
                         .SingleOrDefaultAsync();
        }

    }

    public static class SettingRepositoryExtensions
    {
        public static IQueryable<Setting> Filter(
            this IQueryable<Setting> categories,
            int id)
        {
            return categories.Where(a => id == 0 || a.Id == id);
        }


    }
}
