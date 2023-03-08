using Contracts.Logger;
using Dashboard.Areas.MainDataEntity.Models;
using Entities.CoreServicesModels.MainDataModels;
using Entities.DBModels.MainDataModels;
using Entities.RequestFeatures;

namespace Dashboard.Areas.MainDataEntity.Controllers
{
    [Area("MainDataEntity")]
    [Authorize(DashboardViewEnum.Size, AccessLevelEnum.View)]
    public class SizeController : Controller
    {
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        private readonly UnitOfWork _unitOfWork;
        private readonly LinkGenerator _linkGenerator;
        private readonly IWebHostEnvironment _environment;


        public SizeController(ILoggerManager logger, IMapper mapper,
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

            SizeFilter filter = new()
            {
                Id = id
            };

            ViewData["ProfileLayOut"] = ProfileLayOut;

            ViewData[ViewDataConstants.AccessLevel] = (DashboardAccessLevelModel)Request.HttpContext.Items[ViewDataConstants.AccessLevel];

            return View(filter);
        }

        [HttpPost]
        public async Task<IActionResult> LoadTable([FromBody] SizeFilter dtParameters)
        {
            bool otherLang = (bool)Request.HttpContext.Items[ApiConstants.Language];

            SizeParameters parameters = new()
            {
                SearchColumns = "Id,Name"
            };

            _ = _mapper.Map(dtParameters, parameters);

            PagedList<SizeModel> data = await _unitOfWork.MainData.GetSizesPaged(parameters, otherLang);

            List<SizeDto> resultDto = _mapper.Map<List<SizeDto>>(data);

            DataTable<SizeDto> dataTableManager = new();

            DataTableResult<SizeDto> dataTableResult = dataTableManager.LoadTable(dtParameters, resultDto, data.MetaData.TotalCount, _unitOfWork.MainData.GetSizesCount());

            return Json(dataTableManager.ReturnTable(dataTableResult));
        }

        public IActionResult Details(int id)
        {
            bool otherLang = (bool)Request.HttpContext.Items[ApiConstants.Language];

            SizeDto data = _mapper.Map<SizeDto>(_unitOfWork.MainData.GetSizeById(id, otherLang));

            return View(data);
        }

        [Authorize(DashboardViewEnum.Size, AccessLevelEnum.CreateOrEdit)]
        public async Task<IActionResult> CreateOrEdit(int id = 0)
        {
            SizeCreateOrEditModel model = new();

            if (id > 0)
            {
                Size countryDB = await _unitOfWork.MainData.FindSizeById(id, trackChanges: false);
                model = _mapper.Map<SizeCreateOrEditModel>(countryDB);
            }

            SetViewData(id);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(DashboardViewEnum.Size, AccessLevelEnum.CreateOrEdit)]
        public async Task<IActionResult> CreateOrEdit(int id, SizeCreateOrEditModel model)
        {

            if (!ModelState.IsValid)
            {
                SetViewData(id);

                return View(model);
            }
            try
            {

                UserAuthenticatedDto auth = (UserAuthenticatedDto)Request.HttpContext.Items[ApiConstants.User];
                Size dataDB = new();
                if (id == 0)
                {
                    dataDB = _mapper.Map<Size>(model);

                    dataDB.CreatedBy = auth.UserName;

                    _unitOfWork.MainData.CreateSize(dataDB);
                }
                else
                {
                    dataDB = await _unitOfWork.MainData.FindSizeById(id, trackChanges: true);

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

        [Authorize(DashboardViewEnum.Size, AccessLevelEnum.Delete)]
        public async Task<IActionResult> Delete(int id)
        {
            Size data = await _unitOfWork.MainData.FindSizeById(id, trackChanges: false);

            return View(data != null);
        }

        [HttpPost, ActionName("Delete")]
        [Authorize(DashboardViewEnum.Size, AccessLevelEnum.Delete)]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _unitOfWork.MainData.DeleteSize(id);
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
