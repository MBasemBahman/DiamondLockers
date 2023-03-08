using Contracts.Logger;
using Dashboard.Areas.MainDataEntity.Models;
using Entities.CoreServicesModels.MainDataModels;
using Entities.DBModels.MainDataModels;
using Entities.RequestFeatures;

namespace Dashboard.Areas.MainDataEntity.Controllers
{
    [Area("MainDataEntity")]
    [Authorize(DashboardViewEnum.Category, AccessLevelEnum.View)]
    public class CategoryController : Controller
    {
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        private readonly UnitOfWork _unitOfWork;
        private readonly LinkGenerator _linkGenerator;
        private readonly IWebHostEnvironment _environment;


        public CategoryController(ILoggerManager logger, IMapper mapper,
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

            CategoryFilter filter = new()
            {
                Id = id
            };

            ViewData["ProfileLayOut"] = ProfileLayOut;

            ViewData[ViewDataConstants.AccessLevel] = (DashboardAccessLevelModel)Request.HttpContext.Items[ViewDataConstants.AccessLevel];

            return View(filter);
        }

        [HttpPost]
        public async Task<IActionResult> LoadTable([FromBody] CategoryFilter dtParameters)
        {
            bool otherLang = (bool)Request.HttpContext.Items[ApiConstants.Language];

            CategoryParameters parameters = new()
            {
                SearchColumns = "Id,Name"
            };

            _ = _mapper.Map(dtParameters, parameters);

            PagedList<CategoryModel> data = await _unitOfWork.MainData.GetCategoriesPaged(parameters, otherLang);

            List<CategoryDto> resultDto = _mapper.Map<List<CategoryDto>>(data);

            DataTable<CategoryDto> dataTableManager = new();

            DataTableResult<CategoryDto> dataTableResult = dataTableManager.LoadTable(dtParameters, resultDto, data.MetaData.TotalCount, _unitOfWork.MainData.GetCategoriesCount());

            return Json(dataTableManager.ReturnTable(dataTableResult));
        }

        public IActionResult Details(int id)
        {
            bool otherLang = (bool)Request.HttpContext.Items[ApiConstants.Language];

            CategoryDto data = _mapper.Map<CategoryDto>(_unitOfWork.MainData.GetCategoryById(id, otherLang));

            return View(data);
        }

        [Authorize(DashboardViewEnum.Category, AccessLevelEnum.CreateOrEdit)]
        public async Task<IActionResult> CreateOrEdit(int id = 0)
        {
            CategoryCreateOrEditModel model = new();

            if (id > 0)
            {
                Category countryDB = await _unitOfWork.MainData.FindCategoryById(id, trackChanges: false);
                model = _mapper.Map<CategoryCreateOrEditModel>(countryDB);
            }

            SetViewData(id);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(DashboardViewEnum.Category, AccessLevelEnum.CreateOrEdit)]
        public async Task<IActionResult> CreateOrEdit(int id, CategoryCreateOrEditModel model)
        {

            if (!ModelState.IsValid)
            {
                SetViewData(id);

                return View(model);
            }
            try
            {

                UserAuthenticatedDto auth = (UserAuthenticatedDto)Request.HttpContext.Items[ApiConstants.User];
                Category dataDB = new();
                if (id == 0)
                {
                    dataDB = _mapper.Map<Category>(model);

                    dataDB.CreatedBy = auth.UserName;

                    _unitOfWork.MainData.CreateCategory(dataDB);
                }
                else
                {
                    dataDB = await _unitOfWork.MainData.FindCategoryById(id, trackChanges: true);

                    _ = _mapper.Map(model, dataDB);

                    dataDB.LastModifiedBy = auth.UserName;
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

        [Authorize(DashboardViewEnum.Category, AccessLevelEnum.Delete)]
        public async Task<IActionResult> Delete(int id)
        {
            Category data = await _unitOfWork.MainData.FindCategoryById(id, trackChanges: false);

            return View(data != null);
        }

        [HttpPost, ActionName("Delete")]
        [Authorize(DashboardViewEnum.Category, AccessLevelEnum.Delete)]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _unitOfWork.MainData.DeleteCategory(id);
            await _unitOfWork.Save();

            return RedirectToAction(nameof(Index));
        }

        //helper method
        private void SetViewData(int id)
        {
            ViewData["id"] = id;
        }

    }
}
