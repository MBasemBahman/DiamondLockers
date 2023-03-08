using Entities.CoreServicesModels.MainDataModels;
using Entities.CoreServicesModels.ContactFormModels;

namespace CoreServices.Extensions
{
    public static class ContactFormServiceSearchExtension
    {
        public static IQueryable<ContactFormModel> Search(this IQueryable<ContactFormModel> data, string searchColumns, string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm) || string.IsNullOrWhiteSpace(searchColumns))
            {
                return data;
            }

            searchTerm = searchTerm.SafeTrim().SafeLower();

            Expression<Func<ContactFormModel, bool>> expression = SearchQueryBuilder.CreateSearchQuery<ContactFormModel>(searchColumns, searchTerm);

            return data.Where(expression);
        }

    }

    public static class ContactFormSortExtension
    {
        public static IQueryable<ContactFormModel> Sort(this IQueryable<ContactFormModel> data, string orderByQueryString)
        {
            if (string.IsNullOrWhiteSpace(orderByQueryString))
            {
                return data.OrderBy(a => a.Id);
            }

            string orderQuery = OrderQueryBuilder.CreateOrderQuery<ContactFormModel>(orderByQueryString);

            return data.OrderBy(orderQuery);
        }

    }
}
