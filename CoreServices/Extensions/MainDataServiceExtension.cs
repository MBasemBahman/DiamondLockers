using Entities.CoreServicesModels.MainDataModels;

namespace CoreServices.Extensions
{
    public static class MainDataServiceSearchExtension
    {
        public static IQueryable<CategoryModel> Search(this IQueryable<CategoryModel> data, string searchColumns, string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm) || string.IsNullOrWhiteSpace(searchColumns))
            {
                return data;
            }

            searchTerm = searchTerm.SafeTrim().SafeLower();

            Expression<Func<CategoryModel, bool>> expression = SearchQueryBuilder.CreateSearchQuery<CategoryModel>(searchColumns, searchTerm);

            return data.Where(expression);
        }

        public static IQueryable<SizeModel> Search(this IQueryable<SizeModel> data, string searchColumns, string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm) || string.IsNullOrWhiteSpace(searchColumns))
            {
                return data;
            }

            searchTerm = searchTerm.SafeTrim().SafeLower();

            Expression<Func<SizeModel, bool>> expression = SearchQueryBuilder.CreateSearchQuery<SizeModel>(searchColumns, searchTerm);

            return data.Where(expression);
        }

        public static IQueryable<ColorModel> Search(this IQueryable<ColorModel> data, string searchColumns, string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm) || string.IsNullOrWhiteSpace(searchColumns))
            {
                return data;
            }

            searchTerm = searchTerm.SafeTrim().SafeLower();

            Expression<Func<ColorModel, bool>> expression = SearchQueryBuilder.CreateSearchQuery<ColorModel>(searchColumns, searchTerm);

            return data.Where(expression);
        }

    }

    public static class MainDataServiceSortExtension
    {
        public static IQueryable<CategoryModel> Sort(this IQueryable<CategoryModel> data, string orderByQueryString)
        {
            if (string.IsNullOrWhiteSpace(orderByQueryString))
            {
                return data.OrderBy(a => a.Id);
            }

            string orderQuery = OrderQueryBuilder.CreateOrderQuery<CategoryModel>(orderByQueryString);

            return data.OrderBy(orderQuery);
        }

        public static IQueryable<SizeModel> Sort(this IQueryable<SizeModel> data, string orderByQueryString)
        {
            if (string.IsNullOrWhiteSpace(orderByQueryString))
            {
                return data.OrderBy(a => a.Id);
            }

            string orderQuery = OrderQueryBuilder.CreateOrderQuery<SizeModel>(orderByQueryString);

            return data.OrderBy(orderQuery);
        }

        public static IQueryable<ColorModel> Sort(this IQueryable<ColorModel> data, string orderByQueryString)
        {
            if (string.IsNullOrWhiteSpace(orderByQueryString))
            {
                return data.OrderBy(a => a.Id);
            }

            string orderQuery = OrderQueryBuilder.CreateOrderQuery<ColorModel>(orderByQueryString);

            return data.OrderBy(orderQuery);
        }

    }
}
