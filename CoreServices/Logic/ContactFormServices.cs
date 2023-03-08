using Entities.CoreServicesModels.MainDataModels;
using Entities.CoreServicesModels.ContactFormModels;
using Entities.DBModels.MainDataModels;
using Entities.DBModels.ContactFormModels;
using Microsoft.AspNetCore.Http;

namespace CoreServices.Logic
{
    public class ContactFormServices
    {
        private readonly RepositoryManager _repository;

        public ContactFormServices(RepositoryManager repository)
        {
            _repository = repository;
        }

        #region ContactForm Services

        public IQueryable<ContactFormModel> GetContactForms(ContactFormParameters parameters)
        {
            return _repository.ContactForm
                .FindAll(parameters, trackChanges: false)
                .Select(a => new ContactFormModel
                {
                    Id = a.Id,
                    Name = a.Name,
                    Email = a.Email,
                    Message = a.Message,
                    Phone = a.Phone,
                    Service = a.Service,
                    Type = a.Type
                })
                .Search(parameters.SearchColumns, parameters.SearchTerm)
                .Sort(parameters.OrderBy);
        }

        public async Task<PagedList<ContactFormModel>> GetContactFormsPaged(
            ContactFormParameters parameters)
        {
            return await PagedList<ContactFormModel>.ToPagedList(GetContactForms(parameters), parameters.PageNumber, parameters.PageSize);
        }

        public async Task CreateContactForm(ContactForm entity)
        {
            _repository.ContactForm.Create(entity);
        }

        public async Task<ContactForm> FindContactFormById(int id, bool trackChanges)
        {
            return await _repository.ContactForm.FindById(id, trackChanges);
        }

        public async Task<string> UploadContactForm(string rootPath, IFormFile file)
        {
            FileUploader uploader = new(rootPath);
            return await uploader.UploudFile(file, "Upload/ContactForm");
        }
        
        public ContactFormModel GetContactFormById(int id)
        {
            return GetContactForms(new ContactFormParameters { Id = id }).SingleOrDefault();
        }

        public async Task DeleteContactForm(int id)
        {
            ContactForm entity = await FindContactFormById(id, trackChanges: false);
            _repository.ContactForm.Delete(entity);
        }

        public int GetContactFormsCount()
        {
            return _repository.ContactForm.Count();
        }

        #endregion
    }
}
