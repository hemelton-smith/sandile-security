﻿using Microsoft.Extensions.Configuration;
using System;

namespace SandileSecurity.Web.Main.Infrastructure
{
    public static class ConfigurationExtensions
    {
        public static T Read<T>(this IConfiguration configuration, string sectionName)
        {
            var data = Activator.CreateInstance<T>();
            configuration.ReadOnto(sectionName, data);
            return data;
        }

        public static void ReadOnto<T>(this IConfiguration configuration, string sectionName, T destination)
        {
            var configurationSection = configuration.GetSection(sectionName);
            configurationSection.Bind(destination);
        }
    }
}
