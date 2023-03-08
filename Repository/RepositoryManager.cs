using Repository.DBModels.AuditModels;
using Repository.DBModels.ContactFormModels;
using Repository.DBModels.DashboardAdministrationModels;
using Repository.DBModels.LogModels;
using Repository.DBModels.MainDataModels;
using Repository.DBModels.ProductModels;

namespace Repository
{
    public class RepositoryManager
    {
        private readonly BaseContext _dBContext;

        #region private

        #region LogModels
        private LogRepository _logRepository;
        #endregion

        #region UserModels
        private UserRepository _userRepository;
        private DeviceRepository _deviceRepository;
        private VerificationRepository _verificationRepository;
        private RefreshTokenRepository _refreshTokenRepository;
        #endregion

        #region DashboardAdministrationModels

        private AdministrationRolePremissionRepository _administrationRolePremissionRepository;
        private DashboardAccessLevelRepository _dashboardAccessLevelRepository;
        private DashboardAdministrationRoleRepository _dashboardAdministrationRoleRepository;
        private DashboardAdministratorRepository _dashboardAdministratorRepository;
        private DashboardViewRepository _dashboardViewRepository;

        #endregion

        #region MainData Models
        private CategoryRepository _categoryRepository;
        private SizeRepository _sizeRepository;
        private ColorRepository _colorRepository;
        #endregion

        #region Product Models

        private ProductRepository _productRepository;
        private ProductCategoryRepository _productCategoryRepository;
        private ProductSizeRepository _productSizeRepository;
        private ProductColorRepository _productColorRepository;

        #endregion

        #region ContactForm Models

        private ContactFormRepository _contactFormRepository;

        #endregion
        
        #region Audit Models
        private AuditRepository _auditRepository;
        #endregion

        #endregion

        public RepositoryManager(BaseContext dBContext)
        {
            _dBContext = dBContext;
        }

        public async Task Save()
        {
            _ = await _dBContext.SaveChangesAsync();
        }

        #region Public

        #region LogModels
        public LogRepository Log
        {
            get
            {
                _logRepository ??= new LogRepository(_dBContext);
                return _logRepository;
            }
        }
        #endregion

        #region UserModels

        public UserRepository User
        {
            get
            {
                _userRepository ??= new UserRepository(_dBContext);
                return _userRepository;
            }
        }

        public DeviceRepository Device
        {
            get
            {
                _deviceRepository ??= new DeviceRepository(_dBContext);
                return _deviceRepository;
            }
        }


        public VerificationRepository Verification
        {
            get
            {
                _verificationRepository ??= new VerificationRepository(_dBContext);
                return _verificationRepository;
            }
        }


        public RefreshTokenRepository RefreshToken
        {
            get
            {
                _refreshTokenRepository ??= new RefreshTokenRepository(_dBContext);
                return _refreshTokenRepository;
            }
        }

        #endregion

        #region DashboardAdministrationModels

        public AdministrationRolePremissionRepository AdministrationRolePremission
        {
            get
            {
                _administrationRolePremissionRepository ??= new AdministrationRolePremissionRepository(_dBContext);
                return _administrationRolePremissionRepository;
            }
        }

        public DashboardAccessLevelRepository DashboardAccessLevel
        {
            get
            {
                _dashboardAccessLevelRepository ??= new DashboardAccessLevelRepository(_dBContext);
                return _dashboardAccessLevelRepository;
            }
        }

        public DashboardAdministrationRoleRepository DashboardAdministrationRole
        {
            get
            {
                _dashboardAdministrationRoleRepository ??= new DashboardAdministrationRoleRepository(_dBContext);
                return _dashboardAdministrationRoleRepository;
            }
        }

        public DashboardAdministratorRepository DashboardAdministrator
        {
            get
            {
                _dashboardAdministratorRepository ??= new DashboardAdministratorRepository(_dBContext);
                return _dashboardAdministratorRepository;
            }
        }

        public DashboardViewRepository DashboardView
        {
            get
            {
                _dashboardViewRepository ??= new DashboardViewRepository(_dBContext);
                return _dashboardViewRepository;
            }
        }

        #endregion

        #region Audit Models
        public AuditRepository Audit
        {
            get
            {
                _auditRepository ??= new AuditRepository(_dBContext);
                return _auditRepository;
            }
        }
        #endregion
        
        #region MainData Models
        public CategoryRepository Category
        {
            get
            {
                _categoryRepository ??= new CategoryRepository(_dBContext);
                return _categoryRepository;
            }
        }
        
        public SizeRepository Size
        {
            get
            {
                _sizeRepository ??= new SizeRepository(_dBContext);
                return _sizeRepository;
            }
        }
        
        public ColorRepository Color
        {
            get
            {
                _colorRepository ??= new ColorRepository(_dBContext);
                return _colorRepository;
            }
        }
        
        #endregion

        #region Product Models

        public ProductRepository Product
        {
            get
            {
                _productRepository ??= new ProductRepository(_dBContext);
                return _productRepository;
            }
        }
        
        public ProductCategoryRepository ProductCategory
        {
            get
            {
                _productCategoryRepository ??= new ProductCategoryRepository(_dBContext);
                return _productCategoryRepository;
            }
        }
        
        public ProductSizeRepository ProductSize
        {
            get
            {
                _productSizeRepository ??= new ProductSizeRepository(_dBContext);
                return _productSizeRepository;
            }
        }
        
        public ProductColorRepository ProductColor
        {
            get
            {
                _productColorRepository ??= new ProductColorRepository(_dBContext);
                return _productColorRepository;
            }
        }

        #endregion

        #region ContactForm Models

        public ContactFormRepository ContactForm
        {
            get
            {
                _contactFormRepository ??= new ContactFormRepository(_dBContext);
                return _contactFormRepository;
            }
        }

        #endregion
        #endregion
    }
}
