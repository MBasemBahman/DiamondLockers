using Entities.CoreServicesModels.ContactFormModels;
using Entities.DBModels.ContactFormModels;

namespace Repository.DBModels.ContactFormModels
{
    public class ContactFormRepository : RepositoryBase<ContactForm>
    {
        public ContactFormRepository(BaseContext context) : base(context)
        {
        }

        public IQueryable<ContactForm> FindAll(
            ContactFormParameters parameters,
            bool trackChanges)
        {
            return FindByCondition(a => true, trackChanges)
                   .Filter(parameters.Id);


        }

        public async Task<ContactForm> FindById(int id, bool trackChanges)
        {
            return id == 0
                ? null
                : await FindByCondition(a => a.Id == id, trackChanges: trackChanges)
                         .SingleOrDefaultAsync();
        }

    }

    public static class ContactFormRepositoryExtensions
    {
        public static IQueryable<ContactForm> Filter(
            this IQueryable<ContactForm> categories,
            int id)
        {
            return categories.Where(a => id == 0 || a.Id == id);
        }


    }
}
