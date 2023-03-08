using BaseDB;
using Microsoft.EntityFrameworkCore;
using ModelBuilderConfig.Configurations.DashboardAdministrationModels;
using TenantConfiguration;
using static TenantConfiguration.TenantData;

namespace DevelopmentDAL
{
    public class DevelopmentContext : BaseContext
    {
        public DevelopmentContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            TenantConfig config = new(TenantEnvironments.Development);

            #region DashboardAdministrationModels

            _ = modelBuilder.ApplyConfiguration(new DashboardViewConfiguration(config.DashboardViews));
            _ = modelBuilder.ApplyConfiguration(new DashboardViewLangConfiguration(config.DashboardViews));

            #endregion
        }
    }
}
