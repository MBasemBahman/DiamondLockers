namespace Entities.EnumData
{
    public static class DBModelsEnum
    {
        public enum DashboardAccessLevelEnum
        {
            FullAccess = 1,
            DataControl = 2,
            Viewer = 3
        }

        public enum DashboardAdministrationRoleEnum
        {
            Developer = 1,
            Owner = 3,
            Employee = 6
        }

        public enum DashboardViewEnum
        {
            Home = 1,
            User = 2,
            DashboardAdministrator = 3,
            DashboardAccessLevel = 4,
            DashboardAdministrationRole = 5,
            DashboardView = 6,
            RefreshToken = 7,
            UserDevice = 8,
            Verification = 9,
            DBLogs = 10,
            Audit = 11,
            Category = 12,
            Size = 13,
            Color = 14,
            Product = 15
        }

        public enum AccountProfileItems
        {
            Details = 1,
            AccountCard = 2
        }
        public enum CompanyProfileItems
        {
            Details = 1,
            Account = 2
        }

        public enum AccountReturnPage
        {
            Index = 1,
            Profile = 2
        }

        public enum Gender
        {
            Male = 1,
            Female = 2
        }
        
        public enum CardTypeEnum
        {
            Work = 1,
            Personal = 2
        }
    }
}
