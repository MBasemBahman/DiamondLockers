using Entities.CoreServicesModels.MainDataModels;
using Entities.CoreServicesModels.ProductModels;
using Entities.DBModels.MainDataModels;
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
                    Order = a.Order
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

        public async Task CreateProduct(Product entity)
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

        public async Task UpdateProductSizes(int fk_Product, List<int> sizes)
        {
            sizes ??= new List<int>();

            List<int> OldData = GetProductSizes(new ProductSizeParameters
            {
                Fk_Product = fk_Product
            }, otherLang: false).Select(a => a.Fk_Size).ToList();

            List<int> dataToCreate = sizes.Except(OldData).ToList();

            List<int> dataToRemove = OldData.Except(sizes).ToList();

            AddProductSizes(fk_Product, dataToCreate);

            await RemoveProductSizes(dataToRemove);
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

        private async Task RemoveProductSizes(List<int> ids)
        {
            if (ids != null && ids.Any())
            {
                foreach (int id in ids)
                {
                    await DeleteProductSize(id);
                }
            }
        }

        #endregion
        
        #region ProductCategories Models

        public async Task UpdateProductCategories(int fk_Product, List<int> categories)
        {
            categories ??= new List<int>();

            List<int> oldData = GetProductCategories(new ProductCategoryParameters
            {
                Fk_Product = fk_Product
            }, otherLang: false).Select(a => a.Fk_Category).ToList();

            List<int> dataToCreate = categories.Except(oldData).ToList();

            List<int> dataToRemove = oldData.Except(categories).ToList();

            AddProductCategories(fk_Product, dataToCreate);

            await RemoveProductCategories(dataToRemove);
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

        private async Task RemoveProductCategories(List<int> ids)
        {
            if (ids != null && ids.Any())
            {
                foreach (int id in ids)
                {
                    await DeleteProductCategory(id);
                }
            }
        }

        #endregion

        #region ProductColors Models

        public async Task UpdateProductColors(int fk_Product, List<int> sizes)
        {
            sizes ??= new List<int>();

            List<int> OldData = GetProductColors(new ProductColorParameters
            {
                Fk_Product = fk_Product
            }, otherLang: false).Select(a => a.Fk_Color).ToList();

            List<int> dataToCreate = sizes.Except(OldData).ToList();

            List<int> dataToRemove = OldData.Except(sizes).ToList();

            AddProductColors(fk_Product, dataToCreate);

            await RemoveProductColors(dataToRemove);
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

        private async Task RemoveProductColors(List<int> ids)
        {
            if (ids != null && ids.Any())
            {
                foreach (int id in ids)
                {
                    await DeleteProductColor(id);
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

        public async Task CreateProductCategory(ProductCategory entity)
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

        public async Task DeleteProductCategory(int id)
        {
            ProductCategory entity = await FindProductCategoryById(id, trackChanges: false);
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

        public async Task CreateProductSize(ProductSize entity)
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

        public async Task DeleteProductSize(int id)
        {
            ProductSize entity = await FindProductSizeById(id, trackChanges: false);
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

        public async Task CreateProductColor(ProductColor entity)
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

        public async Task DeleteProductColor(int id)
        {
            ProductColor entity = await FindProductColorById(id, trackChanges: false);
            _repository.ProductColor.Delete(entity);
        }

        public int GetProductColorsCount()
        {
            return _repository.ProductColor.Count();
        }
        
        #endregion
    }
}
