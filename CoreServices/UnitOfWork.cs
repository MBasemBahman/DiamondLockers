﻿using CoreServices.Logic;
using Microsoft.Extensions.Configuration;

namespace CoreServices
{
    public class UnitOfWork
    {
        private readonly RepositoryManager _repository;
        private readonly IConfiguration _config;
        private UserService _userService;
        private LogServices _logServices;
        private DashboardAdministrationServices _dashboardAdministrationServices;
        private AuditServices _auditServices;
        private MainDataServices _mainDataServices;
        private ProductServices _productServices;
        private ContactFormServices _contactFormServices;
        private SettingServices _settingServices;

        public UnitOfWork(RepositoryManager repository, IConfiguration config)
        {
            _repository = repository;
            _config = config;
        }

        public async Task Save()
        {
            await _repository.Save();
        }

        public LogServices Log
        {
            get
            {
                _logServices ??= new LogServices(_repository);
                return _logServices;
            }
        }
        public UserService User
        {
            get
            {
                _userService ??= new UserService(_repository);
                return _userService;
            }
        }

        public DashboardAdministrationServices DashboardAdministration
        {
            get
            {
                _dashboardAdministrationServices ??= new DashboardAdministrationServices(_repository);
                return _dashboardAdministrationServices;
            }
        }

        public AuditServices Audit
        {
            get
            {
                _auditServices ??= new AuditServices(_repository);
                return _auditServices;
            }
        }

        public MainDataServices MainData
        {
            get
            {
                _mainDataServices ??= new MainDataServices(_repository);
                return _mainDataServices;
            }
        }

        public ProductServices Product
        {
            get
            {
                _productServices ??= new ProductServices(_repository);
                return _productServices;
            }
        }

        public ContactFormServices ContactForm
        {
            get
            {
                _contactFormServices ??= new ContactFormServices(_repository);
                return _contactFormServices;
            }
        }

        public SettingServices Setting
        {
            get
            {
                _settingServices ??= new SettingServices(_repository);
                return _settingServices;
            }
        }

    }
}