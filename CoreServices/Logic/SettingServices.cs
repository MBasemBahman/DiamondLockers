using Entities.CoreServicesModels.SettingModels;
using Entities.DBModels.SettingModels;
using Entities.EnumData;
using Microsoft.AspNetCore.Http;

namespace CoreServices.Logic
{
    public class SettingServices
    {
        private readonly RepositoryManager _repository;

        public SettingServices(RepositoryManager repository)
        {
            _repository = repository;
        }

        #region Setting Services

        public IQueryable<SettingModel> GetSettings(SettingParameters parameters)
        {
            return _repository.Setting
                .FindAll(parameters, trackChanges: false)
                .Select(a => new SettingModel
                {
                    Id = a.Id,
                    Key = a.Key,
                    DisplayName = a.DisplayName,
                    Value = a.Value,
                    Type = a.Type,
                    Order = a.Order,
                    CreatedAt = a.CreatedAt,
                    CreatedBy = a.CreatedBy,
                    LastModifiedAt = a.LastModifiedAt,
                    LastModifiedBy = a.LastModifiedBy
                })
                .Search(parameters.SearchColumns, parameters.SearchTerm)
                .Sort(parameters.OrderBy);
        }

        public async Task<PagedList<SettingModel>> GetSettingsPaged(
            SettingParameters parameters)
        {
            return await PagedList<SettingModel>.ToPagedList(GetSettings(parameters), parameters.PageNumber, parameters.PageSize);
        }

        public void CreateSetting(Setting entity)
        {
            _repository.Setting.Create(entity);
        }

        public Dictionary<string, string> GetSettingsLookUp(SettingParameters parameters)
        {
            return GetSettings(parameters).ToDictionary(a => a.Key, a => a.Value);
        }

        public void UpdateSetting(SettingCreateOrEditModel model, Setting entity)
        {
            if (model.Type != DBModelsEnum.SettingTypeEnum.File)
            {
                entity.Value = model.Value;
            }
        }

        public async Task<Setting> FindSettingById(int id, bool trackChanges)
        {
            return await _repository.Setting.FindById(id, trackChanges);
        }

        public async Task<string> UploadSetting(string rootPath, IFormFile file)
        {
            FileUploader uploader = new(rootPath);
            return await uploader.UploudFile(file, "Upload/Setting");
        }

        public SettingModel GetSettingById(int id)
        {
            return GetSettings(new SettingParameters { Id = id }).SingleOrDefault();
        }

        public async Task DeleteSetting(int id)
        {
            Setting entity = await FindSettingById(id, trackChanges: false);
            _repository.Setting.Delete(entity);
        }

        public int GetSettingsCount()
        {
            return _repository.Setting.Count();
        }

        #endregion
    }
}
