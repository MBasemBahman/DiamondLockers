using Entities.CoreServicesModels.MainDataModels;
using Entities.DBModels.MainDataModels;

namespace CoreServices.Logic
{
    public class MainDataServices
    {
        private readonly RepositoryManager _repository;

        public MainDataServices(RepositoryManager repository)
        {
            _repository = repository;
        }

        #region Category Services

        public IQueryable<CategoryModel> GetCategories(CategoryParameters parameters,
            bool otherLang)
        {
            return _repository.Category
                       .FindAll(parameters, trackChanges: false)
                       .Select(a => new CategoryModel
                       {
                           Id = a.Id,
                           CreatedAt = a.CreatedAt,
                           Name = otherLang ? a.CategoryLang.Name : a.Name,
                           Order = a.Order,
                           ProductCount = a.ProductCategories.Count
                       })
                       .Search(parameters.SearchColumns, parameters.SearchTerm)
                       .Sort(parameters.OrderBy);
        }

        public async Task<PagedList<CategoryModel>> GetCategoriesPaged(
                 CategoryParameters parameters,
                 bool otherLang)
        {
            return await PagedList<CategoryModel>.ToPagedList(GetCategories(parameters, otherLang), parameters.PageNumber, parameters.PageSize);
        }

        public void CreateCategory(Category entity)
        {
            entity.CategoryLang ??= new CategoryLang()
            {
                Name = ""
            };

            _repository.Category.Create(entity);
        }

        public async Task<Category> FindCategoryById(int id, bool trackChanges)
        {
            return await _repository.Category.FindById(id, trackChanges);
        }

        public CategoryModel GetCategoryById(int id, bool otherLang)
        {
            return GetCategories(new CategoryParameters { Id = id }, otherLang).SingleOrDefault();
        }

        public Dictionary<string, string> GetCategoriesLookUp(CategoryParameters parameters, bool otherLang)
        {
            return GetCategories(parameters, otherLang).ToDictionary(a => a.Id.ToString(), a => a.Name);
        }

        public async Task DeleteCategory(int id)
        {
            Category entity = await FindCategoryById(id, trackChanges: false);
            _repository.Category.Delete(entity);
        }

        public int GetCategoriesCount()
        {
            return _repository.Category.Count();
        }


        #endregion

        #region Size Services

        public IQueryable<SizeModel> GetSizes(SizeParameters parameters,
            bool otherLang)
        {
            return _repository.Size
                .FindAll(parameters, trackChanges: false)
                .Select(a => new SizeModel
                {
                    Id = a.Id,
                    CreatedAt = a.CreatedAt,
                    Name = otherLang ? a.SizeLang.Name : a.Name,
                    Order = a.Order,
                    ProductCount = a.ProductSizes.Count
                })
                .Search(parameters.SearchColumns, parameters.SearchTerm)
                .Sort(parameters.OrderBy);
        }

        public async Task<PagedList<SizeModel>> GetSizesPaged(
            SizeParameters parameters,
            bool otherLang)
        {
            return await PagedList<SizeModel>.ToPagedList(GetSizes(parameters, otherLang), parameters.PageNumber, parameters.PageSize);
        }

        public void CreateSize(Size entity)
        {
            entity.SizeLang ??= new SizeLang
            {
                Name = ""
            };

            _repository.Size.Create(entity);
        }

        public async Task<Size> FindSizeById(int id, bool trackChanges)
        {
            return await _repository.Size.FindById(id, trackChanges);
        }

        public Dictionary<string, string> GetSizesLookUp(SizeParameters parameters, bool otherLang)
        {
            return GetSizes(parameters, otherLang).ToDictionary(a => a.Id.ToString(), a => a.Name);
        }

        public SizeModel GetSizeById(int id, bool otherLang)
        {
            return GetSizes(new SizeParameters { Id = id }, otherLang).SingleOrDefault();
        }

        public async Task DeleteSize(int id)
        {
            Size entity = await FindSizeById(id, trackChanges: false);
            _repository.Size.Delete(entity);
        }

        public int GetSizesCount()
        {
            return _repository.Size.Count();
        }


        #endregion

        #region Color Services

        public IQueryable<ColorModel> GetColors(ColorParameters parameters,
            bool otherLang)
        {
            return _repository.Color
                .FindAll(parameters, trackChanges: false)
                .Select(a => new ColorModel
                {
                    Id = a.Id,
                    CreatedAt = a.CreatedAt,
                    Name = otherLang ? a.ColorLang.Name : a.Name,
                    Order = a.Order,
                    ProductCount = a.ProductColors.Count
                })
                .Search(parameters.SearchColumns, parameters.SearchTerm)
                .Sort(parameters.OrderBy);
        }

        public async Task<PagedList<ColorModel>> GetColorsPaged(
            ColorParameters parameters,
            bool otherLang)
        {
            return await PagedList<ColorModel>.ToPagedList(GetColors(parameters, otherLang), parameters.PageNumber, parameters.PageSize);
        }

        public void CreateColor(Color entity)
        {
            entity.ColorLang ??= new ColorLang
            {
                Name = ""
            };

            _repository.Color.Create(entity);
        }

        public async Task<Color> FindColorById(int id, bool trackChanges)
        {
            return await _repository.Color.FindById(id, trackChanges);
        }

        public Dictionary<string, string> GetColorsLookUp(ColorParameters parameters, bool otherLang)
        {
            return GetColors(parameters, otherLang).ToDictionary(a => a.Id.ToString(), a => a.Name);
        }

        public ColorModel GetColorById(int id, bool otherLang)
        {
            return GetColors(new ColorParameters { Id = id }, otherLang).SingleOrDefault();
        }

        public async Task DeleteColor(int id)
        {
            Color entity = await FindColorById(id, trackChanges: false);
            _repository.Color.Delete(entity);
        }

        public int GetColorsCount()
        {
            return _repository.Color.Count();
        }


        #endregion

    }
}
