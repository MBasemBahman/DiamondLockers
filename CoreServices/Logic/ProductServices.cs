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


        #endregion

    }
}
