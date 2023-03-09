using Contracts.Logger;
using Dashboard.Areas.SettingEntity.Models;
using Entities.CoreServicesModels.SettingModels;
using Entities.DBModels.SettingModels;
using Entities.RequestFeatures;

namespace Dashboard.Areas.SettingEntity.Controllers
{
    [Area("SettingEntity")]
    [Authorize(DashboardViewEnum.Setting, AccessLevelEnum.View)]
    public class SettingController : Controller
    {
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        private readonly UnitOfWork _unitOfWork;
        private readonly LinkGenerator _linkGenerator;
        private readonly IWebHostEnvironment _environment;


        public SettingController(ILoggerManager logger, IMapper mapper,
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

            SettingFilter filter = new()
            {
                Id = id
            };

            ViewData["ProfileLayOut"] = ProfileLayOut;

            ViewData[ViewDataConstants.AccessLevel] = (DashboardAccessLevelModel)Request.HttpContext.Items[ViewDataConstants.AccessLevel];

            return View(filter);
        }

        [HttpPost]
        public async Task<IActionResult> LoadTable([FromBody] SettingFilter dtParameters)
        {
            bool otherLang = (bool)Request.HttpContext.Items[ApiConstants.Language];

            SettingParameters parameters = new()
            {
                SearchColumns = "Id,Name"
            };

            _ = _mapper.Map(dtParameters, parameters);

            PagedList<SettingModel> data = await _unitOfWork.Setting.GetSettingsPaged(parameters);

            List<SettingDto> resultDto = _mapper.Map<List<SettingDto>>(data);

            DataTable<SettingDto> dataTableManager = new();

            DataTableResult<SettingDto> dataTableResult = dataTableManager.LoadTable(dtParameters, resultDto, data.MetaData.TotalCount, _unitOfWork.Setting.GetSettingsCount());

            return Json(dataTableManager.ReturnTable(dataTableResult));
        }

        public IActionResult Details(int id)
        {
            bool otherLang = (bool)Request.HttpContext.Items[ApiConstants.Language];

            SettingDto data = _mapper.Map<SettingDto>(_unitOfWork.Setting.GetSettingById(id));

            return View(data);
        }

        [Authorize(DashboardViewEnum.Setting, AccessLevelEnum.CreateOrEdit)]
        public async Task<IActionResult> CreateOrEdit(int id = 0)
        {
            SettingCreateOrEditModel model = new();

            if (id > 0)
            {
                Setting dataDb = await _unitOfWork.Setting.FindSettingById(id, trackChanges: false);
                model = _mapper.Map<SettingCreateOrEditModel>(dataDb);
            }

            SetViewData(id);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(DashboardViewEnum.Setting, AccessLevelEnum.CreateOrEdit)]
        public async Task<IActionResult> CreateOrEdit(int id, SettingCreateOrEditModel model)
        {
            if (!ModelState.IsValid)
            {
                SetViewData(id);

                return View(model);
            }
            try
            {

                UserAuthenticatedDto auth = (UserAuthenticatedDto)Request.HttpContext.Items[ApiConstants.User];
                Setting dataDB = new();
                if (id == 0)
                {
                    dataDB = _mapper.Map<Setting>(model);

                    dataDB.CreatedBy = auth.UserName;

                    _unitOfWork.Setting.CreateSetting(dataDB);
                }
                else
                {
                    dataDB = await _unitOfWork.Setting.FindSettingById(id, trackChanges: true);

                    if (model.Type != SettingTypeEnum.File)
                    {
                        _unitOfWork.Setting.UpdateSetting(model, dataDB);
                    }
                    else
                    {
                        IFormFile imageFile = HttpContext.Request.Form.Files["ImageFile"];

                        if (imageFile != null)
                        {
                            dataDB.Value = await _unitOfWork.Setting.UploadSetting(_environment.WebRootPath, imageFile);
                        }
                    }

                    dataDB.Order = model.Order;
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

        [Authorize(DashboardViewEnum.Setting, AccessLevelEnum.Delete)]
        public async Task<IActionResult> Delete(int id)
        {
            Setting data = await _unitOfWork.Setting.FindSettingById(id, trackChanges: false);

            return View(data != null);
        }

        [HttpPost, ActionName("Delete")]
        [Authorize(DashboardViewEnum.Setting, AccessLevelEnum.Delete)]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _unitOfWork.Setting.DeleteSetting(id);
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
