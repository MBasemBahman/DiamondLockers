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

        public static IQueryable<ProductCategoryModel> Search(this IQueryable<ProductCategoryModel> data, string searchColumns, string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm) || string.IsNullOrWhiteSpace(searchColumns))
            {
                return data;
            }

            searchTerm = searchTerm.SafeTrim().SafeLower();

            Expression<Func<ProductCategoryModel, bool>> expression = SearchQueryBuilder.CreateSearchQuery<ProductCategoryModel>(searchColumns, searchTerm);

            return data.Where(expression);
        }

        public static IQueryable<ProductSizeModel> Search(this IQueryable<ProductSizeModel> data, string searchColumns, string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm) || string.IsNullOrWhiteSpace(searchColumns))
            {
                return data;
            }

            searchTerm = searchTerm.SafeTrim().SafeLower();

            Expression<Func<ProductSizeModel, bool>> expression = SearchQueryBuilder.CreateSearchQuery<ProductSizeModel>(searchColumns, searchTerm);

            return data.Where(expression);
        }

        public static IQueryable<ProductColorModel> Search(this IQueryable<ProductColorModel> data, string searchColumns, string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm) || string.IsNullOrWhiteSpace(searchColumns))
            {
                return data;
            }

            searchTerm = searchTerm.SafeTrim().SafeLower();

            Expression<Func<ProductColorModel, bool>> expression = SearchQueryBuilder.CreateSearchQuery<ProductColorModel>(searchColumns, searchTerm);

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

        public static IQueryable<ProductCategoryModel> Sort(this IQueryable<ProductCategoryModel> data, string orderByQueryString)
        {
            if (string.IsNullOrWhiteSpace(orderByQueryString))
            {
                return data.OrderBy(a => a.Id);
            }

            string orderQuery = OrderQueryBuilder.CreateOrderQuery<ProductCategoryModel>(orderByQueryString);

            return data.OrderBy(orderQuery);
        }

        public static IQueryable<ProductSizeModel> Sort(this IQueryable<ProductSizeModel> data, string orderByQueryString)
        {
            if (string.IsNullOrWhiteSpace(orderByQueryString))
            {
                return data.OrderBy(a => a.Id);
            }

            string orderQuery = OrderQueryBuilder.CreateOrderQuery<ProductSizeModel>(orderByQueryString);

            return data.OrderBy(orderQuery);
        }

        public static IQueryable<ProductColorModel> Sort(this IQueryable<ProductColorModel> data, string orderByQueryString)
        {
            if (string.IsNullOrWhiteSpace(orderByQueryString))
            {
                return data.OrderBy(a => a.Id);
            }

            string orderQuery = OrderQueryBuilder.CreateOrderQuery<ProductColorModel>(orderByQueryString);

            return data.OrderBy(orderQuery);
        }

    }
}
