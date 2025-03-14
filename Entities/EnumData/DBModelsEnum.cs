﻿namespace Entities.EnumData
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
            Product = 15,
            ContactForm = 16,
            Setting = 17
        }

        public enum SettingTypeEnum
        {
            Input,
            File,
            TextArea,
            Boolean
        }

    }
}
