using Contracts.Logger;
using Dashboard.Areas.MainDataEntity.Models;
using Dashboard.Areas.ProductEntity.Models;
using Entities.CoreServicesModels.MainDataModels;
using Entities.CoreServicesModels.ProductModels;
using Entities.DBModels.MainDataModels;
using Entities.DBModels.ProductModels;
using Entities.RequestFeatures;

namespace Dashboard.Areas.ProductEntity.Controllers
{
    [Area("ProductEntity")]
    [Authorize(DashboardViewEnum.Product, AccessLevelEnum.View)]
    public class ProductController : Controller
    {
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        private readonly UnitOfWork _unitOfWork;
        private readonly LinkGenerator _linkGenerator;
        private readonly IWebHostEnvironment _environment;


        public ProductController(ILoggerManager logger, IMapper mapper,
                UnitOfWork unitOfWork, LinkGenerator linkGenerator,
                IWebHostEnvironment environment)
        {
            _logger = logger;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _linkGenerator = linkGenerator;
            _environment = environment;
        }

        public IActionResult Index(int id, bool ProfileLayOut = false)
        {

            ProductFilter filter = new()
            {
                Id = id
            };

            ViewData["ProfileLayOut"] = ProfileLayOut;

            ViewData[ViewDataConstants.AccessLevel] = (DashboardAccessLevelModel)Request.HttpContext.Items[ViewDataConstants.AccessLevel];

            return View(filter);
        }

        [HttpPost]
        public async Task<IActionResult> LoadTable([FromBody] ProductFilter dtParameters)
        {
            bool otherLang = (bool)Request.HttpContext.Items[ApiConstants.Language];

            ProductParameters parameters = new()
            {
                SearchColumns = "Id,Name,Order"
            };

            _ = _mapper.Map(dtParameters, parameters);

            parameters.IncludeColors = true;
            parameters.IncludeSizes = true;
            parameters.IncludeCategories = true;

            PagedList<ProductModel> data = await _unitOfWork.Product.GetProductsPaged(parameters, otherLang);

            List<ProductDto> resultDto = _mapper.Map<List<ProductDto>>(data);

            DataTable<ProductDto> dataTableManager = new();

            DataTableResult<ProductDto> dataTableResult = dataTableManager.LoadTable(dtParameters, resultDto, data.MetaData.TotalCount, _unitOfWork.Product.GetProductsCount());

            return Json(dataTableManager.ReturnTable(dataTableResult));
        }

        public IActionResult Details(int id)
        {
            bool otherLang = (bool)Request.HttpContext.Items[ApiConstants.Language];

            ProductDto data = _mapper.Map<ProductDto>(_unitOfWork.Product.GetProductById(id, otherLang));

            return View(data);
        }

        [Authorize(DashboardViewEnum.Product, AccessLevelEnum.CreateOrEdit)]
        public async Task<IActionResult> CreateOrEdit(int id = 0)
        {
            ProductCreateOrEditModel model = new();

            if (id > 0)
            {
                Product countryDB = await _unitOfWork.Product.FindProductById(id, trackChanges: false);
                model = _mapper.Map<ProductCreateOrEditModel>(countryDB);

                model.ImageUrl = countryDB.StorageUrl + countryDB.ImageUrl;

                model.Fk_Categories =
                    _unitOfWork.Product.GetProductCategories(new ProductCategoryParameters
                    {
                        Fk_Product = id
                    }, otherLang: false).Select(a => a.Fk_Category).ToList();

                model.Fk_Sizes =
                    _unitOfWork.Product.GetProductSizes(new ProductSizeParameters
                    {
                        Fk_Product = id
                    }, otherLang: false).Select(a => a.Fk_Size).ToList();

                model.Fk_Colors =
                    _unitOfWork.Product.GetProductColors(new ProductColorParameters
                    {
                        Fk_Product = id
                    }, otherLang: false).Select(a => a.Fk_Color).ToList();
            }

            SetViewData(id);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(DashboardViewEnum.Product, AccessLevelEnum.CreateOrEdit)]
        public async Task<IActionResult> CreateOrEdit(int id, ProductCreateOrEditModel model)
        {

            if (!ModelState.IsValid)
            {
                SetViewData(id);

                return View(model);
            }
            try
            {
                UserAuthenticatedDto auth = (UserAuthenticatedDto)Request.HttpContext.Items[ApiConstants.User];
                Product dataDB = new();
                if (id == 0)
                {
                    dataDB = _mapper.Map<Product>(model);

                    dataDB.CreatedBy = auth.UserName;

                    _unitOfWork.Product.CreateProduct(dataDB);
                }
                else
                {
                    dataDB = await _unitOfWork.Product.FindProductById(id, trackChanges: true);

                    _ = _mapper.Map(model, dataDB);

                    dataDB.LastModifiedBy = auth.UserName;
                }

                IFormFile imageFile = HttpContext.Request.Form.Files["ImageFile"];

                if (imageFile != null)
                {
                    dataDB.ImageUrl = await _unitOfWork.Product.UploadProduct(_environment.WebRootPath, imageFile);
                    dataDB.StorageUrl = _linkGenerator.GetUriByAction(HttpContext).GetBaseUri(HttpContext.Request.RouteValues["area"].ToString());
                }

                await _unitOfWork.Save();

                id = dataDB.Id;

                if (id > 0)
                {
                    _unitOfWork.Product.UpdateProductCategories(dataDB.Id, model.Fk_Categories);
                    _unitOfWork.Product.UpdateProductColors(dataDB.Id, model.Fk_Colors);
                    _unitOfWork.Product.UpdateProductSizes(dataDB.Id, model.Fk_Sizes);
                }

                await _unitOfWork.Save();

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewData[ViewDataConstants.Error] = _logger.LogError(HttpContext.Request, ex).ErrorMessage;
            }
            SetViewData(id);
            return View(model);
        }

        [Authorize(DashboardViewEnum.Product, AccessLevelEnum.Delete)]
        public async Task<IActionResult> Delete(int id)
        {
            Product data = await _unitOfWork.Product.FindProductById(id, trackChanges: false);

            return View(data != null);
        }

        [HttpPost, ActionName("Delete")]
        [Authorize(DashboardViewEnum.Product, AccessLevelEnum.Delete)]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _unitOfWork.Product.DeleteProduct(id);
            await _unitOfWork.Save();

            return RedirectToAction(nameof(Index));
        }

        //helper method
        private void SetViewData(int id)
        {
            bool otherLang = (bool)Request.HttpContext.Items[ApiConstants.Language];

            ViewData["id"] = id;
            ViewData["Categories"] = _unitOfWork.MainData.GetCategoriesLookUp(new CategoryParameters(), otherLang);
            ViewData["Sizes"] = _unitOfWork.MainData.GetSizesLookUp(new SizeParameters(), otherLang);
            ViewData["Colors"] = _unitOfWork.MainData.GetColorsLookUp(new ColorParameters(), otherLang);
        }

    }
}
