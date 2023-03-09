#region Dto Models
using Dashboard.Areas.DashboardAdministration.Models;
using Dashboard.Areas.LogEntity.Models;
using Dashboard.Areas.UserEntity.Models;
using Dashboard.Areas.AuditEntity.Models;
#endregion

#region Core Service Models
using Entities.CoreServicesModels.LogModels;
using Entities.CoreServicesModels.UserModels;
using Entities.CoreServicesModels.AuditModels;
#endregion

#region DB Models
using Entities.DBModels.DashboardAdministrationModels;
#endregion

using Dashboard.Areas.ContactFormEntity.Models;
using Dashboard.Areas.MainDataEntity.Models;
using Dashboard.Areas.ProductEntity.Models;
using Dashboard.Areas.SettingEntity.Models;
using Entities.CoreServicesModels.ContactFormModels;
using Entities.CoreServicesModels.MainDataModels;
using Entities.CoreServicesModels.ProductModels;
using Entities.CoreServicesModels.SettingModels;
using Entities.DBModels.ContactFormModels;
using Entities.DBModels.MainDataModels;
using Entities.DBModels.ProductModels;
using Entities.DBModels.SettingModels;
using Entities.RequestFeatures;

namespace Dashboard.MappingProfileCls
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            MapperConfiguration configuration = new(cfg =>
            {
                cfg.AllowNullCollections = false;
            });

            CreateMap<DateTime, string>().ConvertUsing(new DateTimeTypeConverter());
            CreateMap<DateTime?, string>().ConvertUsing(new DateTimeNullableTypeConverter());
            CreateMap<TimeSpan, string>().ConvertUsing(new TimeSpanTypeConverter());
            CreateMap<TimeSpan?, string>().ConvertUsing(new TimeSpanNullableTypeConverter());
            CreateMap<string, List<string>>().ConvertUsing(new ListOfStringTypeConverter());


            _ = CreateMap<DtParameters, RequestParameters>()
                .ForMember(dest => dest.SearchTerm, opt => opt.MapFrom(src => src.Search == null ? "" : src.Search.Value))
                .ForMember(dest => dest.OrderBy, opt =>
                                   opt.MapFrom(src => src.Order == null ?
                                                      "" :
                                                      (src.Order[0].Dir.ToString().ToLower() == "asc" ?
                                                       src.Columns[src.Order[0].Column].Data :
                                                       (src.Columns[src.Order[0].Column].Data.Contains(',') ?
                                                        src.Columns[src.Order[0].Column].Data.Replace(",", " desc,") :
                                                        src.Columns[src.Order[0].Column].Data + " desc"))))
                .ForMember(dest => dest.PageSize, opt => opt.MapFrom(src => src.Length))
                .ForMember(dest => dest.PageNumber, opt => opt.MapFrom(src => src.Length > 0 ? (src.Start / src.Length) + 1 : 0))
                .IncludeAllDerived();

            _ = CreateMap<UserAuthenticatedDto, UserDto>();

            #region Log Models
            _ = CreateMap<LogModel, LogDto>();

            _ = CreateMap<LogFilter, LogParameters>();

            #endregion

            #region User Models

            _ = CreateMap<UserFilter, UserParameters>();

            _ = CreateMap<UserModel, UserDto>();

            _ = CreateMap<User, UserCreateModel>();

            _ = CreateMap<UserCreateModel, User>();

            _ = CreateMap<UserDeviceFilter, UserDeviceParameters>();

            _ = CreateMap<UserDeviceModel, UserDeviceDto>();

            _ = CreateMap<RefreshTokenFilter, RefreshTokenParameters>();

            _ = CreateMap<RefreshTokenModel, RefreshTokenDto>();

            _ = CreateMap<VerificationFilter, VerificationParameters>();

            _ = CreateMap<VerificationModel, Areas.UserEntity.Models.VerificationDto>();

            _ = CreateMap<UserFilter, UserParameters>();

            #endregion

            #region Dashboard Administration Models

            #region Dashboard View
            _ = CreateMap<DashboardViewModel, DashboardViewDto>();

            _ = CreateMap<DashboardView, DashboardViewCreateOrEditModel>();

            _ = CreateMap<DashboardViewLang, DashboardViewLangModel>();

            _ = CreateMap<DashboardViewCreateOrEditModel, DashboardView>();

            _ = CreateMap<DashboardViewLangModel, DashboardViewLang>();
            #endregion

            #region Dashboard Administration Role
            _ = CreateMap<DashboardAdministrationRoleModel, DashboardAdministrationRoleDto>();

            _ = CreateMap<DashboardAdministrationRole, DashboardAdministrationRoleCreateOrEditModel>();

            _ = CreateMap<DashboardAdministrationRoleLang, DashboardAdministrationRoleLangModel>();

            _ = CreateMap<DashboardAdministrationRoleCreateOrEditModel, DashboardAdministrationRole>();

            _ = CreateMap<DashboardAdministrationRoleLangModel, DashboardAdministrationRoleLang>();

            _ = CreateMap<DashboardAdministrationRoleFilter, DashboardAdministrationRoleRequestParameters>();
            #endregion

            #region Dashboard Access Level
            _ = CreateMap<DashboardAccessLevelModel, DashboardAccessLevelDto>();

            _ = CreateMap<DashboardAccessLevel, DashboardAccessLevelCreateOrEditModel>();

            _ = CreateMap<DashboardAccessLevelLang, DashboardAccessLevelLangModel>();

            _ = CreateMap<DashboardAccessLevelCreateOrEditModel, DashboardAccessLevel>();

            _ = CreateMap<DashboardAccessLevelLangModel, DashboardAccessLevelLang>();
            #endregion

            #region Dashboard Administrator
            _ = CreateMap<DashboardAdministrator, DashboardAdministratorCreateOrEditModel>();

            _ = CreateMap<DashboardAdministratorCreateOrEditModel, DashboardAdministrator>();

            _ = CreateMap<DashboardAdministratorModel, DashboardAdministratorDto>();

            _ = CreateMap<DashboardAdministratorFilter, DashboardAdministratorParameters>();
            #endregion
            #endregion

            #region Main Data

            #region Category
            _ = CreateMap<Category, CategoryCreateOrEditModel>();
            
            _ = CreateMap<CategoryCreateOrEditModel, Category>();
            
            _ = CreateMap<CategoryModel, CategoryDto>();
            
            _ = CreateMap<CategoryFilter, CategoryParameters>();
            
            _ = CreateMap<CategoryLang, CategoryLangModel>();
            
            _ = CreateMap<CategoryLangModel, CategoryLang>();
            #endregion
            
            #region Size
            _ = CreateMap<Size, SizeCreateOrEditModel>();
            
            _ = CreateMap<SizeCreateOrEditModel, Size>();
            
            _ = CreateMap<SizeModel, SizeDto>();
            
            _ = CreateMap<SizeFilter, SizeParameters>();
            
            _ = CreateMap<SizeLang, SizeLangModel>();
            
            _ = CreateMap<SizeLangModel, SizeLang>();
            #endregion
            
            #region Color
            _ = CreateMap<Color, ColorCreateOrEditModel>();
            
            _ = CreateMap<ColorCreateOrEditModel, Color>();
            
            _ = CreateMap<ColorModel, ColorDto>();
            
            _ = CreateMap<ColorFilter, ColorParameters>();
            
            _ = CreateMap<ColorLang, ColorLangModel>();
            
            _ = CreateMap<ColorLangModel, ColorLang>();
            #endregion

            #endregion

            #region Product Models

            #region Product
            _ = CreateMap<Product, ProductCreateOrEditModel>()
                .ForMember(dest => dest.ImageUrl, opt => opt.Ignore());
            
            _ = CreateMap<ProductCreateOrEditModel, Product>()
                .ForMember(dest => dest.ImageUrl, opt => opt.Ignore());
            
            _ = CreateMap<ProductModel, ProductDto>();
            
            _ = CreateMap<ProductFilter, ProductParameters>();
            
            _ = CreateMap<ProductLang, ProductLangModel>();
            
            _ = CreateMap<ProductLangModel, ProductLang>();
            #endregion

            #endregion

            #region ContactForm Model

            _ = CreateMap<ContactForm, ContactFormCreateOrEditModel>();

            _ = CreateMap<ContactFormCreateOrEditModel, ContactForm>();
            
            _ = CreateMap<ContactFormModel, ContactFormDto>();
            
            _ = CreateMap<ContactFormFilter, ContactFormParameters>();

            #endregion
            
            #region Setting Model

            _ = CreateMap<Setting, SettingCreateOrEditModel>();

            _ = CreateMap<SettingCreateOrEditModel, Setting>();
            
            _ = CreateMap<SettingModel, SettingDto>();
            
            _ = CreateMap<SettingFilter, SettingParameters>();

            #endregion
            
            #region Audit Models

            #region Audit

            _ = CreateMap<AuditModel, AuditDto>();

            _ = CreateMap<AuditFilter, AuditParameters>();
            #endregion


            #endregion
        }
    }

    public class DateTimeNullableTypeConverter : ITypeConverter<DateTime?, string>
    {
        public string Convert(DateTime? source, string destination, ResolutionContext context)
        {
            return source == null ? "" : source.Value.AddHours(2).ToString(ApiConstants.DateTimeStringFormat);
        }
    }

    public class DateTimeTypeConverter : ITypeConverter<DateTime, string>
    {
        public string Convert(DateTime source, string destination, ResolutionContext context)
        {
            return source.AddHours(2).ToString(ApiConstants.DateTimeStringFormat);
        }
    }


    public class TimeSpanNullableTypeConverter : ITypeConverter<TimeSpan?, string>
    {
        public string Convert(TimeSpan? source, string destination, ResolutionContext context)
        {
            return source == null ? "" : new DateTime(source.Value.Ticks).ToString(ApiConstants.TimeFormat);
        }
    }

    public class TimeSpanTypeConverter : ITypeConverter<TimeSpan, string>
    {
        public string Convert(TimeSpan source, string destination, ResolutionContext context)
        {
            return new DateTime(source.Ticks).ToString(ApiConstants.TimeFormat);
        }
    }

    public class ListOfStringTypeConverter : ITypeConverter<string, List<string>>
    {
        public List<string> Convert(string source, List<string> destination, ResolutionContext context)
        {
            return !string.IsNullOrEmpty(source) ? source.Split(',').ToList() : null;
        }
    }
}
