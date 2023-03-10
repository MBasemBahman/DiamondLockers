using Entities.CoreServicesModels.MainDataModels;
using Entities.DBModels.MainDataModels;

namespace Repository.DBModels.MainDataModels
{
    public class ColorRepository : RepositoryBase<Color>
    {
        public ColorRepository(BaseContext context) : base(context)
        {
        }

        public IQueryable<Color> FindAll(
            ColorParameters parameters,
            bool trackChanges)
        {
            return FindByCondition(a => true, trackChanges)
                   .Filter(parameters.Id);


        }

        public async Task<Color> FindById(int id, bool trackChanges)
        {
            return id == 0
                ? null
                : await FindByCondition(a => a.Id == id, trackChanges: trackChanges)
                    .Include(a => a.ColorLang)
                    .SingleOrDefaultAsync();
        }

    }

    public static class ColorRepositoryExtensions
    {
        public static IQueryable<Color> Filter(
            this IQueryable<Color> categories,
            int id)
        {
            return categories.Where(a => id == 0 || a.Id == id);
        }


    }
}
