using Entities.CoreServicesModels.SettingModels;

namespace CoreServices.Extensions
{
    public static class SettingServiceSearchExtension
    {
        public static IQueryable<SettingModel> Search(this IQueryable<SettingModel> data, string searchColumns, string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm) || string.IsNullOrWhiteSpace(searchColumns))
            {
                return data;
            }

            searchTerm = searchTerm.SafeTrim().SafeLower();

            Expression<Func<SettingModel, bool>> expression = SearchQueryBuilder.CreateSearchQuery<SettingModel>(searchColumns, searchTerm);

            return data.Where(expression);
        }

    }

    public static class SettingSortExtension
    {
        public static IQueryable<SettingModel> Sort(this IQueryable<SettingModel> data, string orderByQueryString)
        {
            if (string.IsNullOrWhiteSpace(orderByQueryString))
            {
                return data.OrderBy(a => a.Id);
            }

            string orderQuery = OrderQueryBuilder.CreateOrderQuery<SettingModel>(orderByQueryString);

            return data.OrderBy(orderQuery);
        }

    }
}
