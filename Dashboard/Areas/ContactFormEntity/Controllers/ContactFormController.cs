using Contracts.Logger;
using Dashboard.Areas.ContactFormEntity.Models;
using Entities.CoreServicesModels.MainDataModels;
using Entities.CoreServicesModels.ContactFormModels;
using Entities.DBModels.MainDataModels;
using Entities.DBModels.ContactFormModels;
using Entities.RequestFeatures;

namespace Dashboard.Areas.ContactFormEntity.Controllers
{
    [Area("ContactFormEntity")]
    [Authorize(DashboardViewEnum.ContactForm, AccessLevelEnum.View)]
    public class ContactFormController : Controller
    {
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        private readonly UnitOfWork _unitOfWork;
        private readonly LinkGenerator _linkGenerator;
        private readonly IWebHostEnvironment _environment;


        public ContactFormController(ILoggerManager logger, IMapper mapper,
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

            ContactFormFilter filter = new()
            {
                Id = id
            };

            ViewData["ProfileLayOut"] = ProfileLayOut;

            ViewData[ViewDataConstants.AccessLevel] = (DashboardAccessLevelModel)Request.HttpContext.Items[ViewDataConstants.AccessLevel];

            return View(filter);
        }

        [HttpPost]
        public async Task<IActionResult> LoadTable([FromBody] ContactFormFilter dtParameters)
        {
            bool otherLang = (bool)Request.HttpContext.Items[ApiConstants.Language];

            ContactFormParameters parameters = new()
            {
                SearchColumns = "Id,Name"
            };

            _ = _mapper.Map(dtParameters, parameters);

            PagedList<ContactFormModel> data = await _unitOfWork.ContactForm.GetContactFormsPaged(parameters);

            List<ContactFormDto> resultDto = _mapper.Map<List<ContactFormDto>>(data);

            DataTable<ContactFormDto> dataTableManager = new();

            DataTableResult<ContactFormDto> dataTableResult = dataTableManager.LoadTable(dtParameters, resultDto, data.MetaData.TotalCount, _unitOfWork.ContactForm.GetContactFormsCount());

            return Json(dataTableManager.ReturnTable(dataTableResult));
        }

        public IActionResult Details(int id)
        {
            bool otherLang = (bool)Request.HttpContext.Items[ApiConstants.Language];

            ContactFormDto data = _mapper.Map<ContactFormDto>(_unitOfWork.ContactForm.GetContactFormById(id));

            return View(data);
        }

        [Authorize(DashboardViewEnum.ContactForm, AccessLevelEnum.Delete)]
        public async Task<IActionResult> Delete(int id)
        {
            ContactForm data = await _unitOfWork.ContactForm.FindContactFormById(id, trackChanges: false);

            return View(data != null);
        }

        [HttpPost, ActionName("Delete")]
        [Authorize(DashboardViewEnum.ContactForm, AccessLevelEnum.Delete)]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _unitOfWork.ContactForm.DeleteContactForm(id);
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
