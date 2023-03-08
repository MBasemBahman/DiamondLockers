using Entities.CoreServicesModels.MainDataModels;
using Entities.CoreServicesModels.ProductModels;

namespace CoreServices.Extensions
{
    public static class ProductServiceSearchExtension
    {
        public static IQueryable<ProductModel> Search(this IQueryable<ProductModel> data, string searchColumns, string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm) || string.IsNullOrWhiteSpace(searchColumns))
            {
                return data;
            }

            searchTerm = searchTerm.SafeTrim().SafeLower();

            Expression<Func<ProductModel, bool>> expression = SearchQueryBuilder.CreateSearchQuery<ProductModel>(searchColumns, searchTerm);

            return data.Where(expression);
        }
       
    }

    public static class ProductSortExtension
    {
        public static IQueryable<ProductModel> Sort(this IQueryable<ProductModel> data, string orderByQueryString)
        {
            if (string.IsNullOrWhiteSpace(orderByQueryString))
            {
                return data.OrderBy(a => a.Id);
            }

            string orderQuery = OrderQueryBuilder.CreateOrderQuery<ProductModel>(orderByQueryString);

            return data.OrderBy(orderQuery);
        }

    }
}
