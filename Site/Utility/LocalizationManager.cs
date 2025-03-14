﻿using Microsoft.Extensions.Localization;
using Site.Resources;
using System.Reflection;

namespace Site.Utility
{
    public class LocalizationManager
    {
        private readonly IStringLocalizer localizer;
        public LocalizationManager(IStringLocalizerFactory factory)
        {
            AssemblyName assemblyName = new(typeof(ResourcesFile).GetTypeInfo().Assembly.FullName);
            localizer = factory.Create(nameof(ResourcesFile), assemblyName.Name);
        }

        public string Get(string key)
        {
            return localizer[key];
        }
    }
}
