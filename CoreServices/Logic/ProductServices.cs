using Entities.CoreServicesModels.MainDataModels;
using Entities.CoreServicesModels.ProductModels;
using Entities.DBModels.ProductModels;
using Microsoft.AspNetCore.Http;

namespace CoreServices.Logic
{
    public class ProductServices
    {
        private readonly RepositoryManager _repository;

        public ProductServices(RepositoryManager repository)
        {
            _repository = repository;
        }

        #region Product Services

        public IQueryable<ProductModel> GetProducts(ProductParameters parameters,
            bool otherLang)
        {
            return _repository.Product
                .FindAll(parameters, trackChanges: false)
                .Select(a => new ProductModel
                {
                    Id = a.Id,
                    CreatedAt = a.CreatedAt,
                    Name = otherLang ? a.ProductLang.Name : a.Name,
                    ImageUrl = a.StorageUrl + a.ImageUrl,
                    Order = a.Order,
                    ProductCategoriesString = parameters.IncludeCategories ?
                    string.Join(" , ", a.ProductCategories
                    .Select(b => otherLang ? b.Category.CategoryLang.Name : b.Category.Name)
                    .ToList()) : null,
                    ProductSizesString = parameters.IncludeSizes ? string.Join(" , ", a.ProductSizes
                    .Select(b => otherLang ? b.Size.SizeLang.Name : b.Size.Name)
                    .ToList()) : null,
                    ProductColorsString = parameters.IncludeColors ? string.Join(" , ", a.ProductColors
                    .Select(b => otherLang ? b.Color.ColorLang.Name : b.Color.Name)
                    .ToList()) : null
                })
                .Search(parameters.SearchColumns, parameters.SearchTerm)
                .Sort(parameters.OrderBy);
        }

        public async Task<PagedList<ProductModel>> GetProductsPaged(
            ProductParameters parameters,
            bool otherLang)
        {
            return await PagedList<ProductModel>.ToPagedList(GetProducts(parameters, otherLang), parameters.PageNumber, parameters.PageSize);
        }

        public void CreateProduct(Product entity)
        {
            entity.ProductLang ??= new ProductLang
            {
                Name = ""
            };

            _repository.Product.Create(entity);
        }

        public async Task<Product> FindProductById(int id, bool trackChanges)
        {
            return await _repository.Product.FindById(id, trackChanges);
        }

        public async Task<string> UploadProduct(string rootPath, IFormFile file)
        {
            FileUploader uploader = new(rootPath);
            return await uploader.UploudFile(file, "Upload/Product");
        }

        public ProductModel GetProductById(int id, bool otherLang)
        {
            return GetProducts(new ProductParameters { Id = id }, otherLang).SingleOrDefault();
        }

        public async Task DeleteProduct(int id)
        {
            Product entity = await FindProductById(id, trackChanges: false);
            _repository.Product.Delete(entity);
        }

        public int GetProductsCount()
        {
            return _repository.Product.Count();
        }


        #region Product Related Relations

        #region ProductSizes Models

        public void UpdateProductSizes(int fk_Product, List<int> sizes)
        {
            sizes ??= new List<int>();

            List<int> OldData = GetProductSizes(new ProductSizeParameters
            {
                Fk_Product = fk_Product
            }, otherLang: false).Select(a => a.Fk_Size).ToList();

            List<int> dataToCreate = sizes.Except(OldData).ToList();

            List<int> dataToRemove = OldData.Except(sizes).ToList();

            AddProductSizes(fk_Product, dataToCreate);

            RemoveProductSizes(fk_Product, dataToRemove);
        }

        private void AddProductSizes(int fk_Product, List<int> sizes)
        {
            if (sizes != null && sizes.Any())
            {
                foreach (int fk_Size in sizes)
                {
                    CreateProductSize(new ProductSize
                    {
                        Fk_Product = fk_Product,
                        Fk_Size = fk_Size
                    });
                }
            }
        }

        private void RemoveProductSizes(int fk_Product, List<int> fk_Sizes)
        {
            if (fk_Sizes != null && fk_Sizes.Any())
            {
                foreach (int fk_Size in fk_Sizes)
                {
                    DeleteProductSize(fk_Product, fk_Size);
                }
            }
        }

        #endregion

        #region ProductCategories Models

        public void UpdateProductCategories(int fk_Product, List<int> categories)
        {
            categories ??= new List<int>();

            List<int> oldData = GetProductCategories(new ProductCategoryParameters
            {
                Fk_Product = fk_Product
            }, otherLang: false).Select(a => a.Fk_Category).ToList();

            List<int> dataToCreate = categories.Except(oldData).ToList();

            List<int> dataToRemove = oldData.Except(categories).ToList();

            AddProductCategories(fk_Product, dataToCreate);

            RemoveProductCategories(fk_Product, dataToRemove);
        }

        private void AddProductCategories(int fk_Product, List<int> categories)
        {
            if (categories != null && categories.Any())
            {
                foreach (int fk_Category in categories)
                {
                    CreateProductCategory(new ProductCategory
                    {
                        Fk_Product = fk_Product,
                        Fk_Category = fk_Category
                    });
                }
            }
        }

        private void RemoveProductCategories(int fk_Product, List<int> fk_categories)
        {
            if (fk_categories != null && fk_categories.Any())
            {
                foreach (int fk_Category in fk_categories)
                {
                    DeleteProductCategory(fk_Product, fk_Category);
                }
            }
        }

        #endregion

        #region ProductColors Models

        public void UpdateProductColors(int fk_Product, List<int> sizes)
        {
            sizes ??= new List<int>();

            List<int> OldData = GetProductColors(new ProductColorParameters
            {
                Fk_Product = fk_Product
            }, otherLang: false).Select(a => a.Fk_Color).ToList();

            List<int> dataToCreate = sizes.Except(OldData).ToList();

            List<int> dataToRemove = OldData.Except(sizes).ToList();

            AddProductColors(fk_Product, dataToCreate);

            RemoveProductColors(fk_Product, dataToRemove);
        }

        private void AddProductColors(int fk_Product, List<int> sizes)
        {
            if (sizes != null && sizes.Any())
            {
                foreach (int fk_Color in sizes)
                {
                    CreateProductColor(new ProductColor
                    {
                        Fk_Product = fk_Product,
                        Fk_Color = fk_Color
                    });
                }
            }
        }

        private void RemoveProductColors(int fk_Product, List<int> fk_Colors)
        {
            if (fk_Colors != null && fk_Colors.Any())
            {
                foreach (int fk_Color in fk_Colors)
                {
                    DeleteProductColor(fk_Product, fk_Color);
                }
            }
        }

        #endregion

        #endregion

        #endregion

        #region ProductCategory Services

        public IQueryable<ProductCategoryModel> GetProductCategories(ProductCategoryParameters parameters,
            bool otherLang)
        {
            return _repository.ProductCategory
                .FindAll(parameters, trackChanges: false)
                .Select(a => new ProductCategoryModel
                {
                    Id = a.Id,
                    CreatedAt = a.CreatedAt,
                    Fk_Category = a.Fk_Category,
                    Category = new CategoryModel
                    {
                        Name = otherLang ? a.Category.CategoryLang.Name : a.Category.Name
                    },
                    Fk_Product = a.Fk_Product,
                    Product = new ProductModel
                    {
                        Name = otherLang ? a.Product.ProductLang.Name : a.Product.Name
                    },
                })
                .Search(parameters.SearchColumns, parameters.SearchTerm)
                .Sort(parameters.OrderBy);
        }

        public async Task<PagedList<ProductCategoryModel>> GetProductCategoriesPaged(
            ProductCategoryParameters parameters,
            bool otherLang)
        {
            return await PagedList<ProductCategoryModel>.ToPagedList(GetProductCategories(parameters, otherLang), parameters.PageNumber, parameters.PageSize);
        }

        public void CreateProductCategory(ProductCategory entity)
        {
            _repository.ProductCategory.Create(entity);
        }

        public async Task<ProductCategory> FindProductCategoryById(int id, bool trackChanges)
        {
            return await _repository.ProductCategory.FindById(id, trackChanges);
        }

        public ProductCategoryModel GetProductCategoryById(int id, bool otherLang)
        {
            return GetProductCategories(new ProductCategoryParameters { Id = id }, otherLang).SingleOrDefault();
        }

        private void DeleteProductCategory(int fk_Product, int fk_Category)
        {
            ProductCategory entity = _repository.ProductCategory.FindAll(new ProductCategoryParameters
            {
                Fk_Product = fk_Product,
                Fk_Category = fk_Category
            }, trackChanges: false).SingleOrDefault();
            _repository.ProductCategory.Delete(entity);
        }

        public int GetProductCategoriesCount()
        {
            return _repository.ProductCategory.Count();
        }

        #endregion

        #region ProductSize Services

        public IQueryable<ProductSizeModel> GetProductSizes(ProductSizeParameters parameters,
            bool otherLang)
        {
            return _repository.ProductSize
                .FindAll(parameters, trackChanges: false)
                .Select(a => new ProductSizeModel
                {
                    Id = a.Id,
                    CreatedAt = a.CreatedAt,
                    Fk_Size = a.Fk_Size,
                    Size = new SizeModel
                    {
                        Name = otherLang ? a.Size.SizeLang.Name : a.Size.Name
                    },
                    Fk_Product = a.Fk_Product,
                    Product = new ProductModel
                    {
                        Name = otherLang ? a.Product.ProductLang.Name : a.Product.Name
                    },
                })
                .Search(parameters.SearchColumns, parameters.SearchTerm)
                .Sort(parameters.OrderBy);
        }

        public async Task<PagedList<ProductSizeModel>> GetProductSizesPaged(
            ProductSizeParameters parameters,
            bool otherLang)
        {
            return await PagedList<ProductSizeModel>.ToPagedList(GetProductSizes(parameters, otherLang), parameters.PageNumber, parameters.PageSize);
        }

        public void CreateProductSize(ProductSize entity)
        {
            _repository.ProductSize.Create(entity);
        }

        public async Task<ProductSize> FindProductSizeById(int id, bool trackChanges)
        {
            return await _repository.ProductSize.FindById(id, trackChanges);
        }

        public ProductSizeModel GetProductSizeById(int id, bool otherLang)
        {
            return GetProductSizes(new ProductSizeParameters { Id = id }, otherLang).SingleOrDefault();
        }

        private void DeleteProductSize(int fk_Product, int fk_Size)
        {
            ProductSize entity = _repository.ProductSize.FindAll(new ProductSizeParameters
            {
                Fk_Product = fk_Product,
                Fk_Size = fk_Size
            }, trackChanges: false).SingleOrDefault();
            _repository.ProductSize.Delete(entity);
        }

        public int GetProductSizesCount()
        {
            return _repository.ProductSize.Count();
        }

        #endregion

        #region ProductColor Services

        public IQueryable<ProductColorModel> GetProductColors(ProductColorParameters parameters,
            bool otherLang)
        {
            return _repository.ProductColor
                .FindAll(parameters, trackChanges: false)
                .Select(a => new ProductColorModel
                {
                    Id = a.Id,
                    CreatedAt = a.CreatedAt,
                    Fk_Color = a.Fk_Color,
                    Color = new ColorModel
                    {
                        Name = otherLang ? a.Color.ColorLang.Name : a.Color.Name
                    },
                    Fk_Product = a.Fk_Product,
                    Product = new ProductModel
                    {
                        Name = otherLang ? a.Product.ProductLang.Name : a.Product.Name
                    },
                })
                .Search(parameters.SearchColumns, parameters.SearchTerm)
                .Sort(parameters.OrderBy);
        }

        public async Task<PagedList<ProductColorModel>> GetProductColorsPaged(
            ProductColorParameters parameters,
            bool otherLang)
        {
            return await PagedList<ProductColorModel>.ToPagedList(GetProductColors(parameters, otherLang), parameters.PageNumber, parameters.PageSize);
        }

        public void CreateProductColor(ProductColor entity)
        {
            _repository.ProductColor.Create(entity);
        }

        public async Task<ProductColor> FindProductColorById(int id, bool trackChanges)
        {
            return await _repository.ProductColor.FindById(id, trackChanges);
        }

        public ProductColorModel GetProductColorById(int id, bool otherLang)
        {
            return GetProductColors(new ProductColorParameters { Id = id }, otherLang).SingleOrDefault();
        }

        private void DeleteProductColor(int fk_Product, int fk_Color)
        {
            ProductColor entity = _repository.ProductColor.FindAll(new ProductColorParameters
            {
                Fk_Product = fk_Product,
                Fk_Color = fk_Color
            }, trackChanges: false).SingleOrDefault();
            _repository.ProductColor.Delete(entity);
        }

        public int GetProductColorsCount()
        {
            return _repository.ProductColor.Count();
        }

        #endregion
    }
}
