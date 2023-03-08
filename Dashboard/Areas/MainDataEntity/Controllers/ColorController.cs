using Contracts.Logger;
using Dashboard.Areas.MainDataEntity.Models;
using Entities.CoreServicesModels.MainDataModels;
using Entities.DBModels.MainDataModels;
using Entities.RequestFeatures;

namespace Dashboard.Areas.MainDataEntity.Controllers
{
    [Area("MainDataEntity")]
    [Authorize(DashboardViewEnum.Color, AccessLevelEnum.View)]
    public class ColorController : Controller
    {
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        private readonly UnitOfWork _unitOfWork;
        private readonly LinkGenerator _linkGenerator;
        private readonly IWebHostEnvironment _environment;


        public ColorController(ILoggerManager logger, IMapper mapper,
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

            ColorFilter filter = new()
            {
                Id = id
            };

            ViewData["ProfileLayOut"] = ProfileLayOut;

            ViewData[ViewDataConstants.AccessLevel] = (DashboardAccessLevelModel)Request.HttpContext.Items[ViewDataConstants.AccessLevel];

            return View(filter);
        }

        [HttpPost]
        public async Task<IActionResult> LoadTable([FromBody] ColorFilter dtParameters)
        {
            bool otherLang = (bool)Request.HttpContext.Items[ApiConstants.Language];

            ColorParameters parameters = new()
            {
                SearchColumns = "Id,Name"
            };

            _ = _mapper.Map(dtParameters, parameters);

            PagedList<ColorModel> data = await _unitOfWork.MainData.GetColorsPaged(parameters, otherLang);

            List<ColorDto> resultDto = _mapper.Map<List<ColorDto>>(data);

            DataTable<ColorDto> dataTableManager = new();

            DataTableResult<ColorDto> dataTableResult = dataTableManager.LoadTable(dtParameters, resultDto, data.MetaData.TotalCount, _unitOfWork.MainData.GetColorsCount());

            return Json(dataTableManager.ReturnTable(dataTableResult));
        }

        public IActionResult Details(int id)
        {
            bool otherLang = (bool)Request.HttpContext.Items[ApiConstants.Language];

            ColorDto data = _mapper.Map<ColorDto>(_unitOfWork.MainData.GetColorById(id, otherLang));

            return View(data);
        }

        [Authorize(DashboardViewEnum.Color, AccessLevelEnum.CreateOrEdit)]
        public async Task<IActionResult> CreateOrEdit(int id = 0)
        {
            ColorCreateOrEditModel model = new();

            if (id > 0)
            {
                Color countryDB = await _unitOfWork.MainData.FindColorById(id, trackChanges: false);
                model = _mapper.Map<ColorCreateOrEditModel>(countryDB);
            }

            SetViewData(id);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(DashboardViewEnum.Color, AccessLevelEnum.CreateOrEdit)]
        public async Task<IActionResult> CreateOrEdit(int id, ColorCreateOrEditModel model)
        {

            if (!ModelState.IsValid)
            {
                SetViewData(id);

                return View(model);
            }
            try
            {

                UserAuthenticatedDto auth = (UserAuthenticatedDto)Request.HttpContext.Items[ApiConstants.User];
                Color dataDB = new();
                if (id == 0)
                {
                    dataDB = _mapper.Map<Color>(model);

                    dataDB.CreatedBy = auth.UserName;

                    _unitOfWork.MainData.CreateColor(dataDB);
                }
                else
                {
                    dataDB = await _unitOfWork.MainData.FindColorById(id, trackChanges: true);

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

        [Authorize(DashboardViewEnum.Color, AccessLevelEnum.Delete)]
        public async Task<IActionResult> Delete(int id)
        {
            Color data = await _unitOfWork.MainData.FindColorById(id, trackChanges: false);

            return View(data != null);
        }

        [HttpPost, ActionName("Delete")]
        [Authorize(DashboardViewEnum.Color, AccessLevelEnum.Delete)]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _unitOfWork.MainData.DeleteColor(id);
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
